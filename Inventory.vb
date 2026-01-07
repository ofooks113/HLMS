Imports System.IO
Imports System.Data.OleDb

Public Class FormInventory

    ' initialise DB connection
    Dim cn As New OleDbConnection(DB_PATH)
    Dim da As New OleDbDataAdapter()
    Dim dt_editItem As New DataTable()

    Dim add_mod_del_flag As Byte = INSERT


    ' Load item information
    Private Sub Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set button colours when enabled 
        cmdDelete.ForeColor = Color.White
        cmdEdit.ForeColor = Color.White
        cmdAddNew.ForeColor = Color.White
        cmdCancel.ForeColor = Color.White

        lbl_statusInfo.Text = ""

        updateItemList()

        selectLastCheckDate.Value = Today.ToShortDateString()
        selectNextCheckDate.Value = Today.AddYears(1).ToShortDateString()
        selectReplaceByDate.Value = Today.AddYears(5).ToShortDateString()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Enable / disable edit & delete item buttons
    ''
    ''
    Private Sub lstv_Items_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstv_Items.SelectedIndexChanged

        If (lstv_Items.SelectedItems.Count < 1) Then
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



    Private Sub checkFormComplete(sender As Object, e As EventArgs) Handles txtItem.TextChanged, txtDescription.TextChanged, txtQuantity.TextChanged, txtLocation.TextChanged, txtCost.TextChanged

        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.BackColor = Color.LightGray
        cmdEdit.BackColor = Color.LightGray

        lbl_statusInfo.Text = ""

        If txtItem.Text <> "" And txtDescription.Text <> "" And txtCost.Text <> "" And txtLocation.Text <> "" And txtQuantity.Text <> "" Then
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
    '' Add new item to database
    ''
    ''
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click

        If add_mod_del_flag = INSERT Then

            '''' "[itemName], [Description], [Quantity], [Location], [DateLastCheck], [DateNextCheck], [IsServiceable], [Cost], [DateReplacement]"
            Try
                'compose SQL INSERT statement
                Dim sql = "INSERT INTO InventoryTable(itemName, Description, Quantity, Location, DateLastCheck, DateNextCheck, IsServiceable, Cost, DateReplacement) Values (?, ?, ?, ?, ?, ?, ?, ?, ?)"

                'bind data to DB parameters
                Using cmd = New OleDb.OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", txtItem.Text())
                    cmd.Parameters.AddWithValue("@p2", txtDescription.Text())
                    cmd.Parameters.AddWithValue("@p3", Val(txtQuantity.Text()))
                    cmd.Parameters.AddWithValue("@p4", txtLocation.Text())
                    cmd.Parameters.AddWithValue("@p5", selectLastCheckDate.Value.ToShortDateString())
                    cmd.Parameters.AddWithValue("@p6", selectNextCheckDate.Value.ToShortDateString())
                    cmd.Parameters.AddWithValue("@p7", chkServiceable.Checked())
                    cmd.Parameters.AddWithValue("@p8", txtCost.Text())
                    cmd.Parameters.AddWithValue("@p9", selectReplaceByDate.Value.ToShortDateString())

                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using

                ' display status message & clear textboxes on successful addition to DB
                lbl_statusInfo.ForeColor = Color.MediumSeaGreen
                lbl_statusInfo.Text = "Item added to DB"
                txtItem.Text = ""
                txtDescription.Text = ""
                txtLocation.Text = ""
                txtCost.Text = ""
                txtQuantity.Text = ""

                updateItemList()
                '   itemUpdated = True

                ' display message if db update can't happen for any reason
            Catch ex As Exception
                lbl_statusInfo.ForeColor = Color.DarkRed
                MsgBox("Error! Could not add  item to DB!")
            End Try

        ElseIf add_mod_del_flag = MODIFY Then

            ' get the customer ID from the selected row
            Dim itemID As Integer = Val(lstv_Items.SelectedItems(0).Text)

            Try
                'compose SQL UPDATE statement
                Dim sql As String = "UPDATE InventoryTable SET itemName = ?, Description = ?, Quantity = ?, Location = ?, DateLastCheck = ?, DateNextCheck =?, IsServiceable = ?, Cost = ?, DateReplacement = ? WHERE ItemID = ?"

                Using cmd = New OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", txtItem.Text())
                    cmd.Parameters.AddWithValue("@p2", txtDescription.Text())
                    cmd.Parameters.AddWithValue("@p3", Val(txtQuantity.Text()))
                    cmd.Parameters.AddWithValue("@p4", txtLocation.Text())
                    cmd.Parameters.AddWithValue("@p5", selectLastCheckDate.Value.ToShortDateString())
                    cmd.Parameters.AddWithValue("@p6", selectNextCheckDate.Value.ToShortDateString())
                    cmd.Parameters.AddWithValue("@p7", chkServiceable.Checked())
                    cmd.Parameters.AddWithValue("@p8", Val(txtCost.Text()))
                    cmd.Parameters.AddWithValue("@p9", selectReplaceByDate.Value.ToShortDateString())
                    cmd.Parameters.AddWithValue("@p10", itemID)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using
                'End Using

                ' display message if db update can't happen for any reason
            Catch ex As Exception
                MsgBox("Error! Could not update item in DB!")
            End Try

            cmdAddNew.Text = "Add"
            cmdAddNew.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
            cmdCancel.Enabled = False
            cmdCancel.BackColor = Color.LightGray
            cmdDelete.BackColor = Color.LightGray
            cmdEdit.BackColor = Color.LightGray
            txtItem.Text = ""
            txtDescription.Text = ""
            txtLocation.Text = ""
            txtCost.Text = ""
            txtQuantity.Text = ""
            lstv_Items.Enabled = True
            add_mod_del_flag = INSERT

            ' update list view
            updateItemList()
            '   itemUpdated = True

        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Update item listview and display
    ''
    ''
    Private Sub updateItemList()

        'clear data table
        dt_editItem.Clear()
        lstv_Items.Items.Clear()
        lstv_Items.Columns.Clear()

        ' open DB connection
        cn.Open()

        'select data from DB and store in dataTable
        da.SelectCommand = New OleDbCommand("SELECT * from InventoryTable ORDER BY itemName ASC", cn)
        da.Fill(dt_editItem)

        ' dynamically create listview columns
        Dim h1, h2, h3, h4, h5, h6, h7, h8, h9, h10 As ColumnHeader
        h1 = New ColumnHeader
        h2 = New ColumnHeader
        h3 = New ColumnHeader
        h4 = New ColumnHeader
        h5 = New ColumnHeader
        h6 = New ColumnHeader
        h7 = New ColumnHeader
        h8 = New ColumnHeader
        h9 = New ColumnHeader
        h10 = New ColumnHeader

        h1.Width = 0
        h2.Width = 120
        h3.Width = 150
        h4.Width = 80
        h5.Width = 100
        h6.Width = 95
        h7.Width = 95
        h8.Width = 60
        h9.Width = 95
        h10.Width = 101

        h10.TextAlign = HorizontalAlignment.Center

        lstv_Items.Columns.Add(h1)
        lstv_Items.Columns.Add(h2)
        lstv_Items.Columns.Add(h3)
        lstv_Items.Columns.Add(h4)
        lstv_Items.Columns.Add(h5)
        lstv_Items.Columns.Add(h6)
        lstv_Items.Columns.Add(h7)
        lstv_Items.Columns.Add(h8)
        lstv_Items.Columns.Add(h9)
        lstv_Items.Columns.Add(h10)

        ' add items to customer listView
        Dim r As DataRow

        For Each r In dt_editItem.Rows
            Dim lstItemID As String = r(0)
            Dim lstItemName As String = r(1)
            Dim lstItemDesc As String = r(2)
            Dim lstItemQuant As String = r(3)
            Dim lstItemLoc As String = r(4)
            Dim lstItemLastCheck As String = r(5)
            Dim lstItemNextCheck As String = r(6)
            Dim lstItemCost As Double = Format(r(7), "0.00")
            Dim lstItemReplaceBy As String = r(8)
            Dim lstItemServiceable As String = "N"

            If r(9) = True Then
                lstItemServiceable = "Y"
            End If

            Dim item As New ListViewItem(lstItemID)
            item.SubItems.Add(lstItemName)
            item.SubItems.Add(lstItemDesc)
            item.SubItems.Add(lstItemQuant)
            item.SubItems.Add(lstItemLoc)
            item.SubItems.Add(lstItemLastCheck)
            item.SubItems.Add(lstItemNextCheck)
            item.SubItems.Add(lstItemCost)
            item.SubItems.Add(lstItemReplaceBy)
            item.SubItems.Add(lstItemServiceable)
            item.Tag = lstItemID
            lstv_Items.Items.Add(item)
        Next

        cn.Close()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Edit existing item button clicked - get data from selected row and put into textboxes
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

        txtItem.Text = lstv_Items.SelectedItems(0).SubItems(1).Text
        txtDescription.Text = lstv_Items.SelectedItems(0).SubItems(2).Text
        txtQuantity.Text = lstv_Items.SelectedItems(0).SubItems(3).Text
        txtLocation.Text = lstv_Items.SelectedItems(0).SubItems(4).Text
        selectLastCheckDate.Value = lstv_Items.SelectedItems(0).SubItems(5).Text
        selectNextCheckDate.Value = lstv_Items.SelectedItems(0).SubItems(6).Text
        txtCost.Text = lstv_Items.SelectedItems(0).SubItems(7).Text
        selectReplaceByDate.Value = lstv_Items.SelectedItems(0).SubItems(8).Text

        If (lstv_Items.SelectedItems(0).SubItems(9).Text.Equals("Y")) Then
            chkServiceable.Checked = True
        Else
            chkServiceable.Checked = False
        End If

        lstv_Items.Enabled = False

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Delete selected item from item table
    ''
    ''
    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim result As MsgBoxResult = MsgBox("Caution! This will delete all associated data for this item too!", MsgBoxStyle.OkCancel, "Confirm Delete?")

        If result = MsgBoxResult.Ok Then

            add_mod_del_flag = DELETE

            Try
                'compose SQL UPDATE statement
                Dim sql As String = "DELETE * FROM InventoryTable WHERE ItemID = ?"
                Dim itemID As Integer = Val(lstv_Items.SelectedItems(0).Text)

                Using cmd = New OleDbCommand(sql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@p1", itemID)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using


                ' display message if db update can't happen for any reason
            Catch ex As Exception
                MsgBox("Error! Could not delete item from DB!")
            End Try

            cmdAddNew.Enabled = False
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
            cmdDelete.BackColor = Color.LightGray
            cmdEdit.BackColor = Color.LightGray

            add_mod_del_flag = INSERT

            ' update list view
            updateItemList()
            'itemUpdated = True
        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' reset buttons etc if user cancels update
    ''
    ''
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        txtItem.Text = ""
        txtDescription.Text = ""
        txtLocation.Text = ""
        txtCost.Text = ""
        txtQuantity.Text = ""
        cmdCancel.Enabled = False
        cmdAddNew.Enabled = False
        cmdCancel.BackColor = Color.LightGray
        lstv_Items.Enabled = True
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Only allow numeric input into text box for telephone number
    '' 
    ''
    Private Sub txt_MaxNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCost.KeyPress, txtQuantity.KeyPress

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Delete) OrElse e.KeyChar = ChrW(Keys.Back) OrElse e.KeyChar = ChrW(Keys.Tab) OrElse e.KeyChar = ChrW(46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


End Class