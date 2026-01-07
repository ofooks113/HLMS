Imports System.Data
Imports System.Data.OleDb

Public Class ContractorJob

    ' initialise DB connection
    Dim cn As New OleDbConnection(DB_PATH)
    Dim da As New OleDbDataAdapter()
    Dim dt_editJob As New DataTable()
    Dim dt_viewCont As New DataTable()

    Dim add_mod_del_flag As Byte = PROTECT

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Load job details information
    ''
    ''
    Private Sub Jobs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set button colours when enabled 
        cmdDelete.ForeColor = Color.White
        cmdEdit.ForeColor = Color.White
        cmdAddNew.ForeColor = Color.White
        cmdCancel.ForeColor = Color.White

        loadContractorList()
        updateJobsList()
        resetForm()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Get contractor information from database and use it to create a combo box to select contractor
    ''
    ''
    Public Sub loadContractorList()

        ' open DB connection
        cn.Open()

        'select data from DB and store in dataTable
        da.SelectCommand = New OleDbCommand("select ContractorID, Firstname, Surname from ContractorTable ORDER BY Surname ASC, Firstname ASC", cn)

        ' clear existing data (needs refresh if customer table has been updated)
        If (contractorUpdated) Then
            dt_viewCont.Clear()
        End If

        da.Fill(dt_viewCont)

        'clear existing list 
        _contractors.Clear()

        Dim tmp As String = ""
        ' add items to contractor list
        Dim r As DataRow
        For Each r In dt_viewCont.Rows

            tmp = r(1).substring(0, 1) & " " & r(2)
            _contractors.Add(New HLMS_Contractor With {.contID = r(0), .contFirstName = r(1), .contSurname = r(2), .displayName = tmp})
        Next

        'close DB connection
        cn.Close()

        ' convince combobox to update!
        If contractorUpdated = True Then
            cmb_contractor.DataSource = Nothing
        End If

        ' bind data to contractor combobox
        cmb_contractor.DataSource = _contractors
        cmb_contractor.DisplayMember = "displayName"
        cmb_contractor.ValueMember = "contID"
        cmb_contractor.SelectedItem = 0

    End Sub



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Update listview when form loads or changes made
    ''
    ''

    Private Sub updateJobsList()

        'clear data table
        dt_editJob.Clear()
        lstv_Jobs.Items.Clear()
        lstv_Jobs.Columns.Clear()

        ' open DB connection
        cn.Open()

        'select data from DB and store in dataTable
        da.SelectCommand = New OleDbCommand("SELECT * from ContractorJobTable ORDER BY StartDate ASC", cn)

        ' clear existing data (needs refresh if Job table has been updated)
        If (contractorUpdated) Then
            dt_editJob.Clear()
        End If

        da.Fill(dt_editJob)

        'clear existing list 
        _jobs.Clear()

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

        lstv_Jobs.Columns.Add(h1)
        lstv_Jobs.Columns.Add(h2)
        lstv_Jobs.Columns.Add(h3)
        lstv_Jobs.Columns.Add(h4)
        lstv_Jobs.Columns.Add(h5)
        lstv_Jobs.Columns.Add(h6)
        lstv_Jobs.Columns.Add(h7)
        lstv_Jobs.Columns.Add(h8)
        lstv_Jobs.Columns.Add(h9)

        ' add items to customer listView
        Dim r As DataRow

        For Each r In dt_editJob.Rows
            Dim lstJobID As Integer = r(0)
            Dim lstJobRef As String = r(1)
            Dim lstJobStart As String = r(2)
            Dim lstJobEnd As String = r(3)
            Dim lstJobFeeAmount As Single = r(4)
            Dim lstJobFeeDueDate As String = r(5)
            Dim lstJobFeePaid As String = "N"

            If r(6) = True Then
                lstJobFeePaid = "Y"
            End If

            Dim lstJobFeePaidDate As String = r(7)
            Dim lstJobContID As Integer = r(8)

            Dim item As New ListViewItem(lstJobID)
            item.SubItems.Add(lstJobRef)
            item.SubItems.Add(lstJobContID)
            item.SubItems.Add(lstJobStart)
            item.SubItems.Add(lstJobEnd)
            item.SubItems.Add(lstJobFeeAmount)
            item.SubItems.Add(lstJobFeeDueDate)
            item.SubItems.Add(lstJobFeePaid)
            item.SubItems.Add(lstJobFeePaidDate)
            item.Tag = lstJobID
            lstv_Jobs.Items.Add(item)

            ' add Job ID, Ref, Start & End Date to Jobs list to allow quick search for clashes
            _jobs.Add(New HLMS_Job With {.jobID = r(0), .contID = (8), .jobStartDate = r(2), .jobEndDate = r(3)})
        Next

        cn.Close()

        jobUpdated = False
        incomeUpdated = True

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Enable / disable edit & delete Job buttons
    ''
    ''
    Private Sub lstv_Jobs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstv_Jobs.SelectedIndexChanged

        If (lstv_Jobs.SelectedItems.Count < 1) Then
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
    '' Choose to ADD NEW or UPDATE OLD Job
    ''
    ''
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click

        Dim feePaidDate As Date = Today.ToShortDateString()
        Dim result As Boolean = False


        If add_mod_del_flag = INSERT Then

                result = addJob(feePaidDate)

            ElseIf add_mod_del_flag = MODIFY Then

                result = changeJob(feePaidDate)

            End If

        ' successful change to database so reset values and buttons on form
        If result Then

            'reset buttons & inputs
            resetForm()

            JobUpdated = True

            ' update list view
            updateJobsList()

        End If


    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Add a new Job to the database
    ''
    ''
    Private Function addJob(ByVal feePaidDate As Date) As Boolean

        Dim success As Boolean = True

        Try
            'compose SQL INSERT statement
            Dim sql = "INSERT INTO ContractorJobTable(JobRef, StartDate, EndDate, FeeDue, FeeDueDate, FeePaid, FeePaidDate, ContractorID) Values (?, ?, ?, ?, ?, ?, ?, ?)"

            If chkFeePaid.Checked() Then
                feePaidDate = selectFeePaidDate.Value.ToShortDateString()
            End If

            'bind data to DB parameters
            Using cmd = New OleDb.OleDbCommand(sql, cn)
                cn.Open()
                cmd.Parameters.AddWithValue("@p1", txtJobRef.Text())
                cmd.Parameters.AddWithValue("@p2", selectStartDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p3", selectEndDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p4", Val(txtFeeDue.Text()))
                cmd.Parameters.AddWithValue("@p5", selectFeeDueDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p6", chkFeePaid.Checked())
                cmd.Parameters.AddWithValue("@p7", feePaidDate)
                cmd.Parameters.AddWithValue("@p8", cmb_contractor.SelectedValue())

                cmd.ExecuteNonQuery()
                cn.Close()
            End Using

            ' display status message & clear textboxes on successful addition to DB
            lbl_statusInfo.ForeColor = Color.MediumSeaGreen
            MsgBox("Job added to DB", MsgBoxStyle.OkOnly, "Success")

            resetForm()
            jobUpdated = True
            updateJobsList()

            ' display message if db update can't happen for any reason
        Catch ex As Exception
            success = False
            lbl_statusInfo.ForeColor = Color.DarkRed
            MsgBox("Error! Could not add job details to DB!")
        End Try

        Return success

    End Function


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Change an existing Job in the database
    ''
    ''

    Private Function changeJob(ByVal feePaidDate As Date) As Boolean

        Dim success As Boolean = True

        ' get the Job ID from the selected row
        Dim jobID As Integer = Val(lstv_Jobs.SelectedItems(0).Text)

        Try
            'compose SQL UPDATE statement
            Dim sql As String = "UPDATE ContractorJobTable SET JobRef = ?, StartDate = ?, EndDate = ?, FeeDue = ?, FeeDueDate = ?, FeePaid = ?, FeePaidDate = ?, ContractorID = ? WHERE JobID = ?"

            If chkFeePaid.Checked() Then
                feePaidDate = selectFeePaidDate.Value.ToShortDateString()
            End If

            Using cmd = New OleDbCommand(sql, cn)
                cn.Open()
                cmd.Parameters.AddWithValue("@p1", txtJobRef.Text())
                cmd.Parameters.AddWithValue("@p2", selectStartDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p3", selectEndDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p4", Val(txtFeeDue.Text()))
                cmd.Parameters.AddWithValue("@p5", selectFeeDueDate.Value().ToShortDateString())
                cmd.Parameters.AddWithValue("@p6", chkFeePaid.Checked())
                cmd.Parameters.AddWithValue("@p7", feePaidDate)
                cmd.Parameters.AddWithValue("@p8", cmb_contractor.SelectedValue())
                cmd.Parameters.AddWithValue("@p9", jobID)
                cmd.ExecuteNonQuery()
                cn.Close()
            End Using
            'End Using

            ' display message if db update can't happen for any reason
        Catch ex As Exception
            success = False
            lbl_statusInfo.ForeColor = Color.DarkRed
            MsgBox("Error! Could not update job in DB!")
        End Try

        Return success

    End Function


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Edit existing Job button clicked - get data from selected row and put into textboxes
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

        txtJobRef.Enabled = True
        txtFeeDue.Enabled = True
        chkFeePaid.Enabled = True
        selectStartDate.Enabled = True
        selectEndDate.Enabled = True
        selectFeeDueDate.Enabled = True


        txtJobRef.Text = lstv_Jobs.SelectedItems(0).SubItems(1).Text

        'find contractor name from contractorID in _contractors list
        Dim tmpIndex As Integer = Val(lstv_Jobs.SelectedItems(0).SubItems(2).Text)

        Dim selectedCont As HLMS_Contractor
        selectedCont = _contractors.Find(Function(p) p.contID = tmpIndex)
        Dim displayName As String = selectedCont.displayName

        ' update contractor combo box to display correct contractor name
        If cmb_contractor.FindStringExact(displayName) > -1 Then
            cmb_contractor.SelectedIndex = cmb_contractor.FindStringExact(displayName)
        End If

        selectStartDate.Value = lstv_Jobs.SelectedItems(0).SubItems(3).Text
        selectEndDate.Value = lstv_Jobs.SelectedItems(0).SubItems(4).Text
        txtFeeDue.Text = lstv_Jobs.SelectedItems(0).SubItems(5).Text
        selectFeeDueDate.Value = lstv_Jobs.SelectedItems(0).SubItems(6).Text

        If (lstv_Jobs.SelectedItems(0).SubItems(7).Text.Equals("Y")) Then
            chkFeePaid.Checked = True
        Else
            chkFeePaid.Checked = False
        End If

        ' disable rent paid date if it hasn't been paid yet
        If chkFeePaid.Checked Then
            selectFeePaidDate.Enabled = True
        Else
            selectFeePaidDate.Enabled = False
        End If

        selectFeePaidDate.Value = lstv_Jobs.SelectedItems(0).SubItems(8).Text

        lstv_Jobs.Enabled = False

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Delete a Job from the database
    ''
    ''
    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim result As MsgBoxResult = MsgBox("Caution! This will delete all associated records for this Job too!", MsgBoxStyle.OkCancel, "Confirm Delete?")

        If result = MsgBoxResult.Ok Then

            add_mod_del_flag = DELETE

            Try
                'compose SQL DELETE statement
                Dim sql As String = "DELETE * FROM ContractorJobTable WHERE jobID = ?"
                Dim jobID As Integer = Val(lstv_Jobs.SelectedItems(0).Text)

                Using cmd = New OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", jobID)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using


                ' display message if db update can't happen for any reason
            Catch ex As Exception
                MsgBox("Error! Could not delete job details from DB!")
            End Try

            cmdAddNew.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
            cmdDelete.BackColor = Color.LightGray
            cmdEdit.BackColor = Color.LightGray

            add_mod_del_flag = INSERT

            ' update list view
            jobUpdated = True
            updateJobsList()
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
        txtJobRef.Text = ""
        txtFeeDue.Text = ""
        cmb_contractor.SelectedIndex = 0
        selectEndDate.Value = Date.Now().AddDays(1)
        selectStartDate.Value = Date.Now()
        selectFeeDueDate.Value = Date.Now()
        selectFeePaidDate.Value = Date.Now()
        cmdCancel.Enabled = False
        cmdAddNew.Enabled = False
        cmdCancel.BackColor = Color.LightGray
        cmdAddNew.BackColor = Color.LightGray
        lstv_Jobs.Enabled = True
        lbl_statusInfo.Text = ""
        lbl_statusInfo.ForeColor = Color.DarkRed
        txtJobRef.Enabled = False
        txtFeeDue.Enabled = False
        chkFeePaid.Enabled = False
        selectStartDate.Enabled = False
        selectEndDate.Enabled = False
        selectFeeDueDate.Enabled = False
        selectFeePaidDate.Enabled = False

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Only allow numeric input into text box for rent amount
    '' 
    ''
    Private Sub txt_MaxNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFeeDue.KeyPress

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

    Private Sub cmb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_contractor.SelectedIndexChanged

        If add_mod_del_flag = PROTECT Then
            add_mod_del_flag = INSERT
        End If

        txtJobRef.Enabled = True
        cmdCancel.Enabled = True
        cmdCancel.BackColor = Color.Firebrick

    End Sub

    Private Sub txtJobRef_TextChanged(sender As Object, e As EventArgs) Handles txtJobRef.TextChanged

        If add_mod_del_flag = INSERT Then
            If Not txtJobRef.Text.Equals("") Then
                selectStartDate.Enabled = True
                selectEndDate.Enabled = True
            Else
                selectStartDate.Enabled = False
                selectEndDate.Enabled = False
            End If
        End If

        If Not txtJobRef.Text.Equals("") Then
            lbl_statusInfo.Text = ""
        Else
            lbl_statusInfo.Text = "PLEASE ENTER A JOB ID"
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
            txtFeeDue.Enabled = True
        End If


    End Sub

    Private Sub txtRentDue_TextChanged(sender As Object, e As EventArgs) Handles txtFeeDue.TextChanged

        'enable next input when adding new recor
        If add_mod_del_flag = INSERT And Val(txtFeeDue.Text) < 0 Then
            selectFeeDueDate.Enabled = False
        Else
            selectFeeDueDate.Enabled = True
        End If

        'validation messages
        If Val(txtFeeDue.Text) = 0 Then
            lbl_statusInfo.Text = "WARNING: FEE AMOUNT IS ZERO"
        ElseIf Val(txtFeeDue.Text) > 0 Then
            lbl_statusInfo.Text = ""
        Else
            lbl_statusInfo.Text = "INVALID FEE AMOUNT"
        End If

    End Sub

    Private Sub selectFeeDueDate_ValueChanged(sender As Object, e As EventArgs) Handles selectFeeDueDate.ValueChanged

        If selectFeeDueDate.Value < Today Then
            lbl_statusInfo.Text = "WARNING: FEE DUE DATE IS IN THE PAST!"
        Else
            lbl_statusInfo.Text = ""
        End If

        If add_mod_del_flag = INSERT Then
            chkFeePaid.Enabled = True
            cmdAddNew.Enabled = True
            cmdAddNew.BackColor = Color.MediumSeaGreen
        End If
    End Sub

    Private Sub chkFeePaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkFeePaid.CheckedChanged
        If chkFeePaid.Checked Then
            selectFeePaidDate.Enabled = True
        Else
            selectFeePaidDate.Enabled = False
        End If
    End Sub

End Class

