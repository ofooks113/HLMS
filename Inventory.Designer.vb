<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label10 As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim RentPaidLabel As System.Windows.Forms.Label
        Dim RentDueDateLabel As System.Windows.Forms.Label
        Dim locationLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.InventoryTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.InventoryTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstv_Items = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lbl_statusInfo = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.chkServiceable = New System.Windows.Forms.CheckBox()
        Me.selectReplaceByDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.selectNextCheckDate = New System.Windows.Forms.DateTimePicker()
        Me.selectLastCheckDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Label10 = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        RentPaidLabel = New System.Windows.Forms.Label()
        RentDueDateLabel = New System.Windows.Forms.Label()
        locationLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(19, 81)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(63, 13)
        Label10.TabIndex = 15
        Label10.Text = "Description:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(19, 53)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(27, 13)
        CustomerIDLabel.TabIndex = 10
        CustomerIDLabel.Text = "Item"
        '
        'RentPaidLabel
        '
        RentPaidLabel.AutoSize = True
        RentPaidLabel.Location = New System.Drawing.Point(302, 127)
        RentPaidLabel.Name = "RentPaidLabel"
        RentPaidLabel.Size = New System.Drawing.Size(66, 13)
        RentPaidLabel.TabIndex = 8
        RentPaidLabel.Text = "Serviceable:"
        '
        'RentDueDateLabel
        '
        RentDueDateLabel.AutoSize = True
        RentDueDateLabel.Location = New System.Drawing.Point(302, 154)
        RentDueDateLabel.Name = "RentDueDateLabel"
        RentDueDateLabel.Size = New System.Drawing.Size(91, 13)
        RentDueDateLabel.TabIndex = 6
        RentDueDateLabel.Text = "Replace By Date:"
        '
        'locationLabel
        '
        locationLabel.AutoSize = True
        locationLabel.Location = New System.Drawing.Point(19, 155)
        locationLabel.Name = "locationLabel"
        locationLabel.Size = New System.Drawing.Size(51, 13)
        locationLabel.TabIndex = 4
        locationLabel.Text = "Location:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(302, 82)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(92, 13)
        Label11.TabIndex = 2
        Label11.Text = "Next Check Date:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(302, 53)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(90, 13)
        Label12.TabIndex = 0
        Label12.Text = "Last Check Date:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(19, 183)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(49, 13)
        Label13.TabIndex = 36
        Label13.Text = "Quantity:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(19, 214)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(31, 13)
        Label14.TabIndex = 38
        Label14.Text = "Cost:"
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryTableBindingSource
        '
        Me.InventoryTableBindingSource.DataMember = "InventoryTable"
        Me.InventoryTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'InventoryTableTableAdapter
        '
        Me.InventoryTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivityTableTableAdapter = Nothing
        Me.TableAdapterManager.AvailabilityTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.BookingTableTableAdapter = Nothing
        Me.TableAdapterManager.ContractorJobTableTableAdapter = Nothing
        Me.TableAdapterManager.ContractorTableTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableTableAdapter = Me.InventoryTableTableAdapter
        Me.TableAdapterManager.SeasonRateTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.CadetBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(557, 14)
        Me.Label9.MinimumSize = New System.Drawing.Size(95, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(5)
        Me.Label9.Size = New System.Drawing.Size(95, 23)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "NEXT CHECK"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CadetBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(712, 14)
        Me.Label7.MinimumSize = New System.Drawing.Size(95, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(95, 23)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "REPLACE BY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.CadetBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(652, 14)
        Me.Label6.MinimumSize = New System.Drawing.Size(60, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(60, 23)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "COST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(462, 14)
        Me.Label5.MinimumSize = New System.Drawing.Size(95, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(95, 23)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "LAST CHECK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(362, 14)
        Me.Label4.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "LOCATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CadetBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(282, 14)
        Me.Label3.MinimumSize = New System.Drawing.Size(80, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "QUANTITY"
        '
        'lstv_Items
        '
        Me.lstv_Items.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstv_Items.FullRowSelect = True
        Me.lstv_Items.GridLines = True
        Me.lstv_Items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstv_Items.HideSelection = False
        Me.lstv_Items.Location = New System.Drawing.Point(12, 37)
        Me.lstv_Items.MultiSelect = False
        Me.lstv_Items.Name = "lstv_Items"
        Me.lstv_Items.Size = New System.Drawing.Size(896, 241)
        Me.lstv_Items.TabIndex = 0
        Me.lstv_Items.UseCompatibleStateImageBehavior = False
        Me.lstv_Items.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(132, 14)
        Me.Label2.MinimumSize = New System.Drawing.Size(150, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(150, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "DESCRIPTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.MinimumSize = New System.Drawing.Size(120, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ITEM NAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.CadetBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(807, 14)
        Me.Label8.MinimumSize = New System.Drawing.Size(101, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5)
        Me.Label8.Size = New System.Drawing.Size(101, 23)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "SERVICEABLE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtItem)
        Me.GroupBox2.Controls.Add(Label14)
        Me.GroupBox2.Controls.Add(Me.txtCost)
        Me.GroupBox2.Controls.Add(Label13)
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.lbl_statusInfo)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Controls.Add(Me.cmdAddNew)
        Me.GroupBox2.Controls.Add(CustomerIDLabel)
        Me.GroupBox2.Controls.Add(RentPaidLabel)
        Me.GroupBox2.Controls.Add(Me.chkServiceable)
        Me.GroupBox2.Controls.Add(RentDueDateLabel)
        Me.GroupBox2.Controls.Add(Me.selectReplaceByDate)
        Me.GroupBox2.Controls.Add(locationLabel)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Controls.Add(Label11)
        Me.GroupBox2.Controls.Add(Me.selectNextCheckDate)
        Me.GroupBox2.Controls.Add(Label12)
        Me.GroupBox2.Controls.Add(Me.selectLastCheckDate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 298)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Details"
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(125, 50)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(150, 22)
        Me.txtItem.TabIndex = 1
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(124, 211)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(150, 22)
        Me.txtCost.TabIndex = 5
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(124, 180)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(150, 22)
        Me.txtQuantity.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(124, 78)
        Me.txtDescription.MaxLength = 256
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(150, 68)
        Me.txtDescription.TabIndex = 2
        '
        'lbl_statusInfo
        '
        Me.lbl_statusInfo.AutoSize = True
        Me.lbl_statusInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_statusInfo.Location = New System.Drawing.Point(122, 19)
        Me.lbl_statusInfo.Name = "lbl_statusInfo"
        Me.lbl_statusInfo.Size = New System.Drawing.Size(95, 15)
        Me.lbl_statusInfo.TabIndex = 35
        Me.lbl_statusInfo.Text = "STATUS INFO"
        Me.lbl_statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightGray
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.ForeColor = System.Drawing.Color.Gray
        Me.cmdCancel.Location = New System.Drawing.Point(480, 249)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(102, 31)
        Me.cmdCancel.TabIndex = 11
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAddNew
        '
        Me.cmdAddNew.BackColor = System.Drawing.Color.LightGray
        Me.cmdAddNew.Enabled = False
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.ForeColor = System.Drawing.Color.Gray
        Me.cmdAddNew.Location = New System.Drawing.Point(480, 212)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(102, 31)
        Me.cmdAddNew.TabIndex = 10
        Me.cmdAddNew.Text = "Add New Record"
        Me.cmdAddNew.UseVisualStyleBackColor = False
        '
        'chkServiceable
        '
        Me.chkServiceable.Location = New System.Drawing.Point(407, 122)
        Me.chkServiceable.Name = "chkServiceable"
        Me.chkServiceable.Size = New System.Drawing.Size(104, 24)
        Me.chkServiceable.TabIndex = 8
        Me.chkServiceable.Text = "Yes?"
        Me.chkServiceable.UseVisualStyleBackColor = True
        '
        'selectReplaceByDate
        '
        Me.selectReplaceByDate.Location = New System.Drawing.Point(407, 148)
        Me.selectReplaceByDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectReplaceByDate.Name = "selectReplaceByDate"
        Me.selectReplaceByDate.Size = New System.Drawing.Size(150, 20)
        Me.selectReplaceByDate.TabIndex = 9
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(124, 152)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(150, 22)
        Me.txtLocation.TabIndex = 3
        '
        'selectNextCheckDate
        '
        Me.selectNextCheckDate.Location = New System.Drawing.Point(407, 76)
        Me.selectNextCheckDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectNextCheckDate.Name = "selectNextCheckDate"
        Me.selectNextCheckDate.Size = New System.Drawing.Size(150, 20)
        Me.selectNextCheckDate.TabIndex = 7
        Me.selectNextCheckDate.Value = New Date(2022, 1, 24, 0, 0, 0, 0)
        '
        'selectLastCheckDate
        '
        Me.selectLastCheckDate.Location = New System.Drawing.Point(407, 47)
        Me.selectLastCheckDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectLastCheckDate.Name = "selectLastCheckDate"
        Me.selectLastCheckDate.Size = New System.Drawing.Size(150, 20)
        Me.selectLastCheckDate.TabIndex = 6
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightGray
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.Gray
        Me.cmdDelete.Location = New System.Drawing.Point(667, 559)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(102, 31)
        Me.cmdDelete.TabIndex = 13
        Me.cmdDelete.Text = "Delete record"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.LightGray
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.Gray
        Me.cmdEdit.Location = New System.Drawing.Point(667, 519)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(102, 31)
        Me.cmdEdit.TabIndex = 12
        Me.cmdEdit.Text = "Edit Record"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(832, 551)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 38)
        Me.cmdClose.TabIndex = 14
        Me.cmdClose.Text = "CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'FormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 601)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstv_Items)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInventory"
        Me.Text = "Inventory"
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents InventoryTableBindingSource As BindingSource
    Friend WithEvents InventoryTableTableAdapter As HLMS1DataSetTableAdapters.InventoryTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstv_Items As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lbl_statusInfo As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents chkServiceable As CheckBox
    Friend WithEvents selectReplaceByDate As DateTimePicker
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents selectNextCheckDate As DateTimePicker
    Friend WithEvents selectLastCheckDate As DateTimePicker
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents txtItem As TextBox
End Class
