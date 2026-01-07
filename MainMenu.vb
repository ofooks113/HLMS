Imports System.IO
Imports System.Data.OleDb
Public Class FormMenu

    ' initialise DB connection
    Dim cn As New OleDbConnection(DB_PATH)
    Dim da As New OleDbDataAdapter()

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selection of calendar is a week.
        Calendar.MaxSelectionCount = 7
        'Minimum selection date is today's date
        Calendar.MinDate = Date.Today

        dateAvailableFrom.Value = Today()
        dateAvailableTo.Value = Today().AddDays(1)
        lbl_available.Text = ""

        getFinanceData("RENT")
        getFinanceData("EXPENSES")

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Update finance data on menu form if changes have been made elsewhere and we return to the menu
    ''
    ''
    Private Sub FormMenu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If (incomeUpdated) Then
            getFinanceData("RENT")
            getFinanceData("EXPENSES")
            incomeUpdated = False
            Me.Refresh()
        End If

    End Sub

    Private Sub cmdActivity_Click(sender As Object, e As EventArgs) Handles cmdMaintenance.Click
        ' Open Activity form
        ContractorJob.ShowDialog()
    End Sub
    Private Sub cmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        ' Open Customer form
        Customer.ShowDialog()
    End Sub
    Private Sub cmdContractor_Click(sender As Object, e As EventArgs) Handles cmdContractor.Click
        ' Open Contractor details form
        ContractorDetails.ShowDialog()
    End Sub
    Private Sub cmdItem_Click(sender As Object, e As EventArgs) Handles cmdItem.Click
        ' Open Inventory form
        FormInventory.ShowDialog()
    End Sub
    Private Sub cmdTariff_Click(sender As Object, e As EventArgs) Handles cmdTariff.Click
        ' Open Ratings form
        Rate.ShowDialog()
    End Sub
    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        ' Open Help form
        Help.ShowDialog()
    End Sub

    Private Sub cmdQuit_Click(sender As Object, e As EventArgs) Handles cmdQuit.Click
        'Contains description, style and title of message box
        Dim r As MsgBoxResult
        r = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Booking")
        If r = MsgBoxResult.Yes Then
            'Close Main Menu form
            Application.Exit()
        End If
    End Sub
    Private Sub Calendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateChanged
        If Calendar.MaxSelectionCount > 7 Then
            MessageBox.Show("Cannot exceed 7 days, please try again.", "Date Range over Maximum")
        End If
    End Sub

    Private Sub cmdFinancial_Click(sender As Object, e As EventArgs) Handles cmdFinancial.Click
        ' Open Finacnce form
        Financial.ShowDialog()
    End Sub

    Private Sub cmdNewBooking_Click(sender As Object, e As EventArgs) Handles cmdNewBooking.Click
        ' Open Booking Info form
        BookingInfo.ShowDialog()
    End Sub




    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Get total rent paid and total rent due to display on main menu form
    ''
    ''
    Private Sub getFinanceData(ByVal source As String)

        Dim sql As String = ""
        Dim dt_financeINfo As New DataTable()

        If source.Equals("RENT") Then
            sql = "SELECT RentDue, RentPaid from BookingTable"
        ElseIf source.Equals("EXPENSES") Then
            sql = "SELECT FeeDue, FeePaid from ContractorJobTable"
        End If

        If Not sql.Equals("") Then
            Dim totalDue As Single = 0
            Dim totalPaid As Single = 0

            'clear data table
            dt_financeInfo.Clear()

            ' open DB connection
            cn.Open()

            'select data from DB and store in dataTable
            da.SelectCommand = New OleDbCommand(sql, cn)
            da.Fill(dt_financeInfo)

            Dim r As DataRow

            ' caclulate totals
            For Each r In dt_financeInfo.Rows

                ' if Paid is true, add  paid amount to total  paid amount
                If (r(1) = True) Then
                    totalPaid += Val(r(0))
                Else
                    totalDue += Val(r(0))
                End If
            Next

            cn.Close()

            ' display total due and total paid on main menu form

            If source.Equals("RENT") Then
                txtRentDue.Text = "£ " & totalDue
                txtRentReceived.Text = "£ " & totalPaid
            ElseIf source.Equals("EXPENSES") Then
                txtBillDue.Text = "£ " & totalDue
                txtBillPaid.Text = "£ " & totalPaid
            End If

        Else
            MsgBox("ERROR: Could not get finance data from database", MsgBoxStyle.Critical, "Oops!")
        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Button to check availability
    ''
    ''
    Private Sub cmd_checkAvailable_Click(sender As Object, e As EventArgs) Handles cmd_checkAvailable.Click

        checkAvailability(dateAvailableFrom.Value.ToShortDateString, dateAvailableTo.Value.ToShortDateString)

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Find out if selected times are available or not
    ''
    ''
    Private Sub checkAvailability(ByVal fromDate As Date, ByVal toDate As Date)

        Dim available As Boolean = True

        Dim sql As String = "SELECT StartDate, EndDate FROM BookingTable ORDER BY StartDate ASC"
        Dim dt_availability As New DataTable()

        'clear data table
        dt_availability.Clear()

        ' open DB connection
        cn.Open()

        'select data from DB and store in dataTable
        da.SelectCommand = New OleDbCommand(sql, cn)
        da.Fill(dt_availability)

        Dim r As DataRow

        'check availability
        For Each r In dt_availability.Rows

            If (fromDate >= r(0) And fromDate <= r(1)) Or
               (toDate >= r(0) And toDate <= r(1)) Then

                ' date not available so exit for loop
                available = False
                Exit For
            End If
        Next

        cn.Close()

        If available = True Then
            lbl_available.Text = "AVAILABLE"
            lbl_available.ForeColor = Color.MediumSeaGreen
        Else
            lbl_available.Text = "NOT AVAILABLE"
            lbl_available.ForeColor = Color.DarkRed
        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Make sure that TO Date is always after the FROM date
    ''
    Private Sub dateAvailableFrom_ValueChanged(sender As Object, e As EventArgs) Handles dateAvailableFrom.ValueChanged

        If dateAvailableFrom.Value > dateAvailableTo.Value Then
            dateAvailableTo.Value = dateAvailableFrom.Value.AddDays(1)
        End If

    End Sub

    Private Sub cmdActivity_Click_1(sender As Object, e As EventArgs) Handles cmdActivity.Click
        Activity.ShowDialog()
    End Sub
End Class

