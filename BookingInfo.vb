Imports System.Data
Imports System.Data.OleDb

Public Class BookingInfo

    ' initialise DB connection
    Dim cn As New OleDbConnection(DB_PATH)
    Dim da As New OleDbDataAdapter()
    Dim dt_editBooking As New DataTable()
    Dim dt_viewCust As New DataTable()

    Dim add_mod_del_flag As Byte = PROTECT

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Load booking information
    ''
    ''
    Private Sub Bookings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set button colours when enabled 
        cmdDelete.ForeColor = Color.White
        cmdEdit.ForeColor = Color.White
        cmdAddNew.ForeColor = Color.White
        cmdCancel.ForeColor = Color.White

        loadCustomerList()
        updateBookingsList()
        resetForm()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Get customer information from database and use it to create a combo box to select customer
    ''
    ''
    Public Sub loadCustomerList()

        ' open DB connection
        cn.Open()

        'select data from DB and store in dataTable
        da.SelectCommand = New OleDbCommand("select CustomerID, Firstname, Surname from CustomerTable ORDER BY Surname ASC, Firstname ASC", cn)

        ' clear existing data (needs refresh if customer table has been updated)
        If (customerUpdated) Then
            dt_viewCust.Clear()
        End If

        da.Fill(dt_viewCust)

        'clear existing list 
        _customers.Clear()

        Dim tmp As String = ""
        ' add items to customer list
        Dim r As DataRow
        For Each r In dt_viewCust.Rows

            tmp = r(1).substring(0, 1) & " " & r(2)
            _customers.Add(New HLMS_Customer With {.custID = r(0), .custFirstName = r(1), .custSurname = r(2), .displayName = tmp})
        Next

        'close DB connection
        cn.Close()

        ' convince combobox to update!
        If customerUpdated = True Then
            cmb_customer.DataSource = Nothing
        End If

        ' bind data to customer combobox
        cmb_customer.DataSource = _customers
        cmb_customer.DisplayMember = "displayName"
        cmb_customer.ValueMember = "custID"
        cmb_customer.SelectedItem = 0

    End Sub



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Update listview when form loads or changes made
    ''
    ''

    Private Sub updateBookingsList()

        'clear data table
        dt_editBooking.Clear()
        lstv_Bookings.Items.Clear()
        lstv_Bookings.Columns.Clear()

        ' open DB connection
        cn.Open()

        'select data from DB and store in dataTable
        da.SelectCommand = New OleDbCommand("SELECT * from BookingTable ORDER BY StartDate ASC", cn)

        ' clear existing data (needs refresh if booking table has been updated)
        If (bookingUpdated) Then
            dt_editBooking.Clear()
        End If

        da.Fill(dt_editBooking)

        'clear existing list 
        _bookings.Clear()

        ' dynamically create listview columns
        Dim h1, h2, h3, h4, h5, h6, h7, h8, h9 As ColumnHeader
        h1 = New ColumnHeader
        h2 = New ColumnHeader
        h3 = New ColumnHeader
        h4 = New ColumnHeader
        h5 = New ColumnHeader
        h6 = New ColumnHeader
        h7 = New ColumnHeader
        h8 = New ColumnHeader
        h9 = New ColumnHeader

        h1.Width = 0
        h2.Width = 80
        h3.Width = 80
        h4.Width = 100
        h5.Width = 100
        h6.Width = 80
        h7.Width = 100
        h8.Width = 60
        h9.Width = 100

        h8.TextAlign = HorizontalAlignment.Center

        lstv_Bookings.Columns.Add(h1)
        lstv_Bookings.Columns.Add(h2)
        lstv_Bookings.Columns.Add(h3)
        lstv_Bookings.Columns.Add(h4)
        lstv_Bookings.Columns.Add(h5)
        lstv_Bookings.Columns.Add(h6)
        lstv_Bookings.Columns.Add(h7)
        lstv_Bookings.Columns.Add(h8)
        lstv_Bookings.Columns.Add(h9)

        ' add items to customer listView
        Dim r As DataRow

        For Each r In dt_editBooking.Rows
            Dim lstBookingID As Integer = r(0)
            Dim lstBookingRef As String = r(1)
            Dim lstBookingCustID As String = r(2)
            Dim lstBookingStart As String = r(3)
            Dim lstBookingEnd As String = r(4)
            Dim lstBookingRentAmount As String = r(5)
            Dim lstBookingRentDueDate As String = r(6)
            Dim lstBookingRentPaid As String = "N"

            If r(7) = True Then
                lstBookingRentPaid = "Y"
            End If

            Dim lstBookingRentPaidDate As String = r(8)

            Dim item As New ListViewItem(lstBookingID)
            item.SubItems.Add(lstBookingRef)
            item.SubItems.Add(lstBookingCustID)
            item.SubItems.Add(lstBookingStart)
            item.SubItems.Add(lstBookingEnd)
            item.SubItems.Add(lstBookingRentAmount)
            item.SubItems.Add(lstBookingRentDueDate)
            item.SubItems.Add(lstBookingRentPaid)
            item.SubItems.Add(lstBookingRentPaidDate)
            item.Tag = lstBookingID
            lstv_Bookings.Items.Add(item)

            ' add booking ID, Ref, Start & End Date to bookings list to allow quick search for clashes
            _bookings.Add(New HLMS_Booking With {.bookingID = r(0), .bookingRef = r(1), .bookingStartDate = r(3), .bookingEndDate = r(4)})
        Next

        cn.Close()

        bookingUpdated = False
        incomeUpdated = True

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Enable / disable edit & delete booking buttons
    ''
    ''
    Private Sub lstv_Bookings_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstv_Bookings.SelectedIndexChanged

        If (lstv_Bookings.SelectedItems.Count < 1) Then
            ' nothing selected.. do not enable butttons!
            cmdDelete.Enabled = False
            cmdDelete.BackColor = Color.LightGray
            cmdEdit.Enabled = False
            cmdEdit.BackColor = Color.LightGray
        Else
            cmdDelete.Enabled = True
            cmdDelete.BackColor = Color.Firebrick
            cmdEdit.Enabled = True
            cmdEdit.BackColor = Color.SteelBlue
        End If
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Choose to ADD NEW or UPDATE OLD booking
    ''
    ''
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click

        Dim rentPaidDate As Date = Today.ToShortDateString()
        Dim result As Boolean = False
        Dim bookingClash As Boolean = False
        Dim bookingRef As String = txtBookingRef.Text().ToUpper()

        If add_mod_del_flag = INSERT Then

            bookingClash = checkDateClash(selectStartDate.Value.ToShortDateString, selectEndDate.Value.ToShortDateString, "_NEW_")

            If bookingClash Then
                MsgBox("DATE IS ALREADY BOOKED!", MsgBoxStyle.Critical, "Ooops!")
                lbl_statusInfo.Text = "PLEASE CHECK DATE RANGE!"
            Else
                result = addBooking(rentPaidDate)
            End If

        ElseIf add_mod_del_flag = MODIFY Then

            bookingClash = checkDateClash(selectStartDate.Value.ToShortDateString, selectEndDate.Value.ToShortDateString, bookingRef)

            If bookingClash Then
                MsgBox("DATE IS ALREADY BOOKED!", MsgBoxStyle.Critical, "Ooops!")
                lbl_statusInfo.Text = "PLEASE CHECK DATE RANGE!"
            Else
                result = changeBooking(rentPaidDate)
            End If

        End If


        ' successful change to database so reset values and buttons on form
        If result Then

            'reset buttons & inputs
            resetForm()

            bookingUpdated = True

            ' update list view
            updateBookingsList()

        End If




    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Add a new booking to the database
    ''
    ''
    Private Function addBooking(ByVal rentPaidDate As Date) As Boolean

        Dim success As Boolean = True

        Try
            'compose SQL INSERT statement
            Dim sql = "INSERT INTO BookingTable(BookingRef, CustomerID, StartDate, EndDate, RentDue, RentDueDate, RentPaid, RentPaidDate) Values (?, ?, ?, ?, ?, ?, ?, ?)"

            If chkRentPaid.Checked() Then
                rentPaidDate = selectRentPaidDate.Value.ToShortDateString()
            End If

            'bind data to DB parameters
            Using cmd = New OleDb.OleDbCommand(sql, cn)
                cn.Open()
                cmd.Parameters.AddWithValue("@p1", txtBookingRef.Text().ToUpper())
                cmd.Parameters.AddWithValue("@p2", cmb_customer.SelectedValue())
                cmd.Parameters.AddWithValue("@p3", selectStartDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p4", selectEndDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p5", Val(txtRentDue.Text()))
                cmd.Parameters.AddWithValue("@p6", selectRentDueDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p7", chkRentPaid.Checked())
                cmd.Parameters.AddWithValue("@p8", rentPaidDate)

                cmd.ExecuteNonQuery()
                cn.Close()
            End Using

            ' display status message & clear textboxes on successful addition to DB
            lbl_statusInfo.ForeColor = Color.MediumSeaGreen
            MsgBox("Booking added to DB", MsgBoxStyle.OkOnly, "Success")

            resetForm()
            bookingUpdated = True
            updateBookingsList()

            ' display message if db update can't happen for any reason
        Catch ex As Exception
            success = False
            lbl_statusInfo.ForeColor = Color.DarkRed
            MsgBox("Error! Could not add  booking to DB!")
        End Try

        Return success

    End Function


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Change an existing booking in the database
    ''
    ''

    Private Function changeBooking(ByVal rentPaidDate As Date) As Boolean

        Dim success As Boolean = True

        ' get the booking ID from the selected row
        Dim bookingID As Integer = Val(lstv_Bookings.SelectedItems(0).Text)

        Try
            'compose SQL UPDATE statement
            Dim sql As String = "UPDATE BookingTable SET BookingRef = ?, CustomerID = ?, StartDate = ?, EndDate = ?, RentDue = ?, RentDueDate = ?, RentPaid = ?, RentPaidDate = ? WHERE BookingID = ?"

            If chkRentPaid.Checked() Then
                rentPaidDate = selectRentPaidDate.Value.ToShortDateString()
            End If

            Using cmd = New OleDbCommand(sql, cn)
                cn.Open()
                cmd.Parameters.AddWithValue("@p1", txtBookingRef.Text().ToUpper())
                cmd.Parameters.AddWithValue("@p2", cmb_customer.SelectedValue())
                cmd.Parameters.AddWithValue("@p3", selectStartDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p4", selectEndDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p5", Val(txtRentDue.Text()))
                cmd.Parameters.AddWithValue("@p6", selectRentDueDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p7", chkRentPaid.Checked())
                cmd.Parameters.AddWithValue("@p8", rentPaidDate)
                cmd.Parameters.AddWithValue("@p9", bookingID)
                cmd.ExecuteNonQuery()
                cn.Close()
            End Using
            'End Using

            ' display message if db update can't happen for any reason
        Catch ex As Exception
            success = False
            lbl_statusInfo.ForeColor = Color.DarkRed
            MsgBox("Error! Could not update booking in DB!")
        End Try

        Return success

    End Function


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Edit existing booking button clicked - get data from selected row and put into textboxes
    ''
    ''
    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click

        add_mod_del_flag = MODIFY
        cmdAddNew.Text = "Update"
        cmdAddNew.Enabled = True
        cmdAddNew.BackColor = Color.MediumSeaGreen
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.BackColor = Color.LightGray
        cmdEdit.BackColor = Color.LightGray
        cmdCancel.Enabled = True
        cmdCancel.BackColor = Color.Firebrick

        txtBookingRef.Enabled = True
        txtRentDue.Enabled = True
        chkRentPaid.Enabled = True
        selectStartDate.Enabled = True
        selectEndDate.Enabled = True
        selectRentDueDate.Enabled = True


        txtBookingRef.Text = lstv_Bookings.SelectedItems(0).SubItems(1).Text.ToUpper()

        'find customer name from customerID in _customers list
        Dim tmpIndex As Integer = Val(lstv_Bookings.SelectedItems(0).SubItems(2).Text)

        Dim selectedCust As HLMS_Customer
        selectedCust = _customers.Find(Function(p) p.custID = tmpIndex)
        Dim displayName As String = selectedCust.displayName

        ' update customer combo box to display correct customer name
        If cmb_customer.FindStringExact(displayName) > -1 Then
            cmb_customer.SelectedIndex = cmb_customer.FindStringExact(displayName)
        End If

        selectStartDate.Value = lstv_Bookings.SelectedItems(0).SubItems(3).Text
        selectEndDate.Value = lstv_Bookings.SelectedItems(0).SubItems(4).Text
        txtRentDue.Text = lstv_Bookings.SelectedItems(0).SubItems(5).Text
        selectRentDueDate.Value = lstv_Bookings.SelectedItems(0).SubItems(6).Text

        If (lstv_Bookings.SelectedItems(0).SubItems(7).Text.Equals("Y")) Then
            chkRentPaid.Checked = True
        Else
            chkRentPaid.Checked = False
        End If

        ' disable rent paid date if it hasn't been paid yet
        If chkRentPaid.Checked Then
            selectRentPaidDate.Enabled = True
        Else
            selectRentPaidDate.Enabled = False
        End If

        selectRentPaidDate.Value = lstv_Bookings.SelectedItems(0).SubItems(8).Text

        lstv_Bookings.Enabled = False

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Delete a booking from the database
    ''
    ''
    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim result As MsgBoxResult = MsgBox("Caution! This will delete all associated records for this booking too!", MsgBoxStyle.OkCancel, "Confirm Delete?")

        If result = MsgBoxResult.Ok Then

            add_mod_del_flag = DELETE

            Try
                'compose SQL DELETE statement
                Dim sql As String = "DELETE * FROM BookingTable WHERE BookingID = ?"
                Dim bookingID As Integer = Val(lstv_Bookings.SelectedItems(0).Text)

                Using cmd = New OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", bookingID)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using


                ' display message if db update can't happen for any reason
            Catch ex As Exception
                MsgBox("Error! Could not delete booking from DB!")
            End Try

            cmdAddNew.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
            cmdDelete.BackColor = Color.LightGray
            cmdEdit.BackColor = Color.LightGray

            add_mod_del_flag = INSERT

            ' update list view
            bookingUpdated = True
            updateBookingsList()
        End If

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' reset buttons etc if user cancels update
    ''
    ''

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        ' rest buttons and form inputs        
        resetForm()

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Reset all buttons and form inputs to defaults
    '' 
    ''
    Private Sub resetForm()

        add_mod_del_flag = PROTECT
        cmdAddNew.Text = "Add"
        txtBookingRef.Text = ""
        txtRentDue.Text = ""
        cmb_customer.SelectedIndex = 0
        selectEndDate.Value = Date.Now().AddDays(1)
        selectStartDate.Value = Date.Now()
        selectRentDueDate.Value = Date.Now()
        selectRentPaidDate.Value = Date.Now()
        cmdCancel.Enabled = False
        cmdAddNew.Enabled = False
        cmdCancel.BackColor = Color.LightGray
        cmdAddNew.BackColor = Color.LightGray
        lstv_Bookings.Enabled = True
        lbl_statusInfo.Text = ""
        lbl_statusInfo.ForeColor = Color.DarkRed
        txtBookingRef.Enabled = False
        txtRentDue.Enabled = False
        chkRentPaid.Enabled = False
        selectStartDate.Enabled = False
        selectEndDate.Enabled = False
        selectRentDueDate.Enabled = False
        selectRentPaidDate.Enabled = False

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Only allow numeric input into text box for rent amount
    '' 
    ''
    Private Sub txt_MaxNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRentDue.KeyPress

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Delete) OrElse e.KeyChar = ChrW(Keys.Back) OrElse e.KeyChar = ChrW(Keys.Tab) OrElse e.KeyChar = ChrW(46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Close this form
    '' 
    ''
    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdHomepage.Click
        Me.Close()
    End Sub



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Form Inputs & Validation
    '' 
    ''

    Private Sub cmb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_customer.SelectedIndexChanged

        If add_mod_del_flag = PROTECT Then
            add_mod_del_flag = INSERT
        End If

        txtBookingRef.Enabled = True
        cmdCancel.Enabled = True
        cmdCancel.BackColor = Color.Firebrick

    End Sub

    Private Sub txtBookingRef_TextChanged(sender As Object, e As EventArgs) Handles txtBookingRef.TextChanged

        If add_mod_del_flag = INSERT Then
            If Not txtBookingRef.Text.Equals("") Then
                selectStartDate.Enabled = True
                selectEndDate.Enabled = True
            Else
                selectStartDate.Enabled = False
                selectEndDate.Enabled = False
            End If
        End If

        If Not txtBookingRef.Text.Equals("") Then
            lbl_statusInfo.Text = ""
        Else
            lbl_statusInfo.Text = "PLEASE ENTER A BOOKING REFERENCE"
        End If


    End Sub

    Private Sub selectStartDate_ValueChanged(sender As Object, e As EventArgs) Handles selectStartDate.ValueChanged, selectEndDate.ValueChanged

        ' do validation checks
        If selectEndDate.Value < selectStartDate.Value Then
            selectEndDate.Value = selectStartDate.Value.AddDays(1)
        End If


        If selectStartDate.Value < Today Then
            lbl_statusInfo.Text = "WARNING: START DATE IS IN THE PAST!"
        Else
            lbl_statusInfo.Text = ""
        End If


        'enable next input when adding new record
        If add_mod_del_flag = INSERT Then
            txtRentDue.Enabled = True
        End If


    End Sub

    Private Sub txtRentDue_TextChanged(sender As Object, e As EventArgs) Handles txtRentDue.TextChanged

        'enable next input when adding new recor
        If add_mod_del_flag = INSERT And Val(txtRentDue.Text) < 0 Then
            selectRentDueDate.Enabled = False
        Else
            selectRentDueDate.Enabled = True
        End If

        'validation messages
        If Val(txtRentDue.Text) = 0 Then
            lbl_statusInfo.Text = "WARNING: RENT AMOUNT IS ZERO"
        ElseIf Val(txtRentDue.Text) > 0 Then
            lbl_statusInfo.Text = ""
        Else
            lbl_statusInfo.Text = "INVALID RENT AMOUNT"
        End If

    End Sub

    Private Sub selectRentDueDate_ValueChanged(sender As Object, e As EventArgs) Handles selectRentDueDate.ValueChanged

        If selectRentDueDate.Value < Today Then
            lbl_statusInfo.Text = "WARNING: RENT DUE DATE IS IN THE PAST!"
        Else
            lbl_statusInfo.Text = ""
        End If

        If add_mod_del_flag = INSERT Then
            chkRentPaid.Enabled = True
            cmdAddNew.Enabled = True
            cmdAddNew.BackColor = Color.MediumSeaGreen
        End If
    End Sub

    Private Sub chkRentPaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkRentPaid.CheckedChanged
        If chkRentPaid.Checked Then
            selectRentPaidDate.Enabled = True
        Else
            selectRentPaidDate.Enabled = False
        End If
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Check existing bookings for clash of dates
    '' 
    ''
    Public Function checkDateClash(startDate, EndDate, bookingref)

        Dim bookingClash As Boolean = False


        ' loop through existing bookings and check if dates clash
        For Each b In _bookings

            If (startDate >= b.bookingStartDate And startDate <= b.bookingEndDate) Or
               (EndDate >= b.bookingStartDate And EndDate <= b.bookingEndDate) Then

                ' there is a booking clash... but it could be with itself...

                ' if it's a new booking... there is definitely a clash!
                If (bookingref.Equals("_NEW_")) Then
                    ' date is already booked!
                    bookingClash = True
                Else
                    If Not (bookingref.Equals(b.bookingRef)) Then
                        ' clash is not with itself... 
                        bookingClash = True
                    End If
                End If
            End If

        Next

        Return bookingClash

    End Function


End Class