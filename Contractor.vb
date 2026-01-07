Imports System.IO
Imports System.Data.OleDb

Public Class ContractorDetails

    ' initialise DB connection
    Dim cn As New OleDbConnection(DB_PATH)
    Dim da As New OleDbDataAdapter()
    Dim dt_editContractor As New DataTable()

    Dim add_mod_del_flag As Byte = INSERT


    ' Load contractor information
    Private Sub Contractor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set button colours when enabled 
        cmdDelete.ForeColor = Color.White
        cmdEdit.ForeColor = Color.White
        cmdAddNew.ForeColor = Color.White
        cmdCancel.ForeColor = Color.White

        lbl_statusInfo.Text = ""

        updateContractorList()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Enable / disable edit & delete contractor buttons
    ''
    ''
    Private Sub lstv_Contractor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstv_Contractor.SelectedIndexChanged

        If (lstv_Contractor.SelectedItems.Count < 1) Then
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
    ''  Enable add/update button when all required data has been entered
    ''
    ''
    Private Sub checkFormComplete(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged, txtSurname.TextChanged, txtEmail.TextChanged, txtTelephone.TextChanged, txtBusiness.TextChanged, txtTrade.TextChanged

        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.BackColor = Color.LightGray
        cmdEdit.BackColor = Color.LightGray

        lbl_statusInfo.Text = ""

        If txtFirstName.Text <> "" And txtSurname.Text <> "" And txtEmail.Text <> "" And txtTelephone.Text <> "" And txtBusiness.Text <> "" And txtTrade.Text <> "" Then
            cmdAddNew.Enabled = True
            cmdAddNew.BackColor = Color.MediumSeaGreen
            cmdCancel.Enabled = True
            cmdCancel.BackColor = Color.Firebrick
        Else
            cmdAddNew.Enabled = False
            cmdAddNew.BackColor = Color.LightGray
            cmdCancel.Enabled = False
            cmdCancel.BackColor = Color.LightGray
        End If

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Add new contractor to database
    ''
    ''
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click

        If add_mod_del_flag = INSERT Then

            Try
                'compose SQL INSERT statement
                Dim sql = "INSERT INTO ContractorTable(FirstName, Surname, Email, Telephone, BusinessName, Trade) Values (?, ?, ?, ?, ?, ?)"

                'bind data to DB parameters
                Using cmd = New OleDb.OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", txtFirstName.Text())
                    cmd.Parameters.AddWithValue("@p2", txtSurname.Text())
                    cmd.Parameters.AddWithValue("@p3", txtEmail.Text())
                    cmd.Parameters.AddWithValue("@p4", txtTelephone.Text())
                    cmd.Parameters.AddWithValue("@p5", txtBusiness.Text())
                    cmd.Parameters.AddWithValue("@p6", txtTrade.Text())

                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using

                ' display status message & clear textboxes on successful addition to DB
                lbl_statusInfo.ForeColor = Color.MediumSeaGreen
                lbl_statusInfo.Text = "Contractor added to DB"
                txtFirstName.Text = ""
                txtSurname.Text = ""
                txtEmail.Text = ""
                txtTelephone.Text = ""
                txtBusiness.Text = ""
                txtTrade.Text = ""

                updateContractorList()
                contractorUpdated = True

                ' display message if db update can't happen for any reason
            Catch ex As Exception
                lbl_statusInfo.ForeColor = Color.DarkRed
                MsgBox("Error! Could not add  contractor to DB!")
            End Try

        ElseIf add_mod_del_flag = MODIFY Then

            ' get the customer ID from the selected row
            Dim contID As Integer = Val(lstv_Contractor.SelectedItems(0).Text)

            Try
                'compose SQL UPDATE statement
                Dim sql As String = "UPDATE ContractorTable SET Firstname = ?, Surname = ?, Email = ?, Telephone = ?, BusinessName = ?, Trade = ? WHERE ContractorID = ?"

                Using cmd = New OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", txtFirstName.Text())
                    cmd.Parameters.AddWithValue("@p2", txtSurname.Text())
                    cmd.Parameters.AddWithValue("@p3", txtEmail.Text())
                    cmd.Parameters.AddWithValue("@p4", txtTelephone.Text())
                    cmd.Parameters.AddWithValue("@p5", txtBusiness.Text())
                    cmd.Parameters.AddWithValue("@p6", txtTrade.Text())
                    cmd.Parameters.AddWithValue("@7", contID)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using
                'End Using

                ' display message if db update can't happen for any reason
            Catch ex As Exception
                MsgBox("Error! Could not update contractor in DB!")
            End Try

            cmdAddNew.Text = "Add"
            cmdAddNew.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
            cmdCancel.Enabled = False
            cmdCancel.BackColor = Color.LightGray
            cmdDelete.BackColor = Color.LightGray
            cmdEdit.BackColor = Color.LightGray
            txtFirstName.Text = ""
            txtSurname.Text = ""
            txtEmail.Text = ""
            txtTelephone.Text = ""
            txtBusiness.Text = ""
            txtTrade.Text = ""
            lstv_Contractor.Enabled = True
            add_mod_del_flag = INSERT

            ' update list view
            updateContractorList()
            contractorUpdated = True

        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Update contractor listview and display
    ''
    ''
    Private Sub updateContractorList()

        'clear data table
        dt_editContractor.Clear()
        lstv_Contractor.Items.Clear()
        lstv_Contractor.Columns.Clear()

        ' open DB connection
        cn.Open()

        'select data from DB and store in dataTable
        da.SelectCommand = New OleDbCommand("SELECT * from ContractorTable ORDER BY Surname ASC, Firstname ASC ", cn)
        da.Fill(dt_editContractor)

        ' dynamically create listview columns
        Dim h1, h2, h3, h4, h5, h6, h7 As ColumnHeader
        h1 = New ColumnHeader
        h2 = New ColumnHeader
        h3 = New ColumnHeader
        h4 = New ColumnHeader
        h5 = New ColumnHeader
        h6 = New ColumnHeader
        h7 = New ColumnHeader

        h1.Width = 0
        h2.Width = 100
        h3.Width = 100
        h4.Width = 150
        h5.Width = 100
        h6.Width = 150
        h7.Width = 100

        lstv_Contractor.Columns.Add(h1)
        lstv_Contractor.Columns.Add(h2)
        lstv_Contractor.Columns.Add(h3)
        lstv_Contractor.Columns.Add(h4)
        lstv_Contractor.Columns.Add(h5)
        lstv_Contractor.Columns.Add(h6)
        lstv_Contractor.Columns.Add(h7)

        ' add items to customer listView
        Dim r As DataRow

        For Each r In dt_editContractor.Rows
            Dim lstContID As String = r(0)
            Dim lstContFirstName As String = r(1)
            Dim lstContSurname As String = r(2)
            Dim lstContEmail As String = r(3)
            Dim lstContTelephone As String = r(4)
            Dim lstContBusiness As String = r(5)
            Dim lstContTrade As String = r(6)

            Dim item As New ListViewItem(lstContID)
            item.SubItems.Add(lstContFirstName)
            item.SubItems.Add(lstContSurname)
            item.SubItems.Add(lstContEmail)
            item.SubItems.Add(lstContTelephone)
            item.SubItems.Add(lstContBusiness)
            item.SubItems.Add(lstContTrade)
            item.Tag = lstContID
            lstv_Contractor.Items.Add(item)
        Next

        cn.Close()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Edit existing contractor button clicked - get data from selected row and put into textboxes
    ''
    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click

        add_mod_del_flag = MODIFY
        cmdAddNew.Text = "Update"
        cmdAddNew.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.BackColor = Color.LightGray
        cmdEdit.BackColor = Color.LightGray
        cmdCancel.Enabled = True
        cmdCancel.BackColor = Color.Firebrick

        txtFirstName.Text = lstv_Contractor.SelectedItems(0).SubItems(1).Text
        txtSurname.Text = lstv_Contractor.SelectedItems(0).SubItems(2).Text
        txtEmail.Text = lstv_Contractor.SelectedItems(0).SubItems(3).Text
        txtTelephone.Text = lstv_Contractor.SelectedItems(0).SubItems(4).Text
        txtBusiness.Text = lstv_Contractor.SelectedItems(0).SubItems(5).Text
        txtTrade.Text = lstv_Contractor.SelectedItems(0).SubItems(6).Text

        lstv_Contractor.Enabled = False

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Delete selected item from contractor table
    ''
    ''
    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim result As MsgBoxResult = MsgBox("Caution! This will delete all associated jobs for this contractor too!", MsgBoxStyle.OkCancel, "Confirm Delete?")

        If result = MsgBoxResult.Ok Then

            add_mod_del_flag = DELETE

            Try
                'compose SQL UPDATE statement
                Dim sql As String = "DELETE * FROM ContractorTable WHERE ContractorID = ?"
                Dim contID As Integer = Val(lstv_Contractor.SelectedItems(0).Text)

                Using cmd = New OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", contID)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using


                ' display message if db update can't happen for any reason
            Catch ex As Exception
                MsgBox("Error! Could not delete contractor from DB!")
            End Try

            cmdAddNew.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
            cmdDelete.BackColor = Color.LightGray
            cmdEdit.BackColor = Color.LightGray

            add_mod_del_flag = INSERT

            ' update list view
            updateContractorList()
            contractorUpdated = True
        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' reset buttons etc if user cancels update
    ''
    ''
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtEmail.Text = ""
        txtTelephone.Text = ""
        txtBusiness.Text = ""
        txtTrade.Text = ""
        cmdCancel.Enabled = False
        cmdAddNew.Enabled = False
        cmdCancel.BackColor = Color.LightGray
        lstv_Contractor.Enabled = True
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Only allow numeric input into text box for telephone number
    '' 
    ''
    Private Sub txt_MaxNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelephone.KeyPress

        If e.KeyChar = ChrW(46) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Delete) OrElse e.KeyChar = ChrW(Keys.Back) OrElse e.KeyChar = ChrW(Keys.Tab) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSViewJobs_Click(sender As Object, e As EventArgs) Handles cmdViewJobs.Click

        ContractorJob.ShowDialog()
    End Sub
End Class
