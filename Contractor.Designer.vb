<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractorDetails
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
        Dim NotesLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.ContractorTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContractorTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.ContractorTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.ContractorJobTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContractorJobTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.ContractorJobTableTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstv_Contractor = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_statusInfo = New System.Windows.Forms.Label()
        Me.cmdViewJobs = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTrade = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtBusiness = New System.Windows.Forms.TextBox()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        NotesLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractorTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractorJobTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(6, 157)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(83, 13)
        NotesLabel.TabIndex = 8
        NotesLabel.Text = "Business Name:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(6, 128)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 6
        TelephoneLabel.Text = "Telephone:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(6, 101)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(35, 13)
        Label7.TabIndex = 4
        Label7.Text = "Email:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(6, 77)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(52, 13)
        Label8.TabIndex = 2
        Label8.Text = "Surname:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(6, 50)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(60, 13)
        Label9.TabIndex = 0
        Label9.Text = "First Name:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(6, 185)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(38, 13)
        Label10.TabIndex = 10
        Label10.Text = "Trade:"
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContractorTableBindingSource
        '
        Me.ContractorTableBindingSource.DataMember = "ContractorTable"
        Me.ContractorTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'ContractorTableTableAdapter
        '
        Me.ContractorTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivityTableTableAdapter = Nothing
        Me.TableAdapterManager.AvailabilityTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.BookingTableTableAdapter = Nothing
        Me.TableAdapterManager.ContractorJobTableTableAdapter = Nothing
        Me.TableAdapterManager.ContractorTableTableAdapter = Me.ContractorTableTableAdapter
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonRateTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ContractorJobTableBindingSource
        '
        Me.ContractorJobTableBindingSource.DataMember = "ContractorJobTable"
        Me.ContractorJobTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'ContractorJobTableTableAdapter
        '
        Me.ContractorJobTableTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(462, 12)
        Me.Label5.MinimumSize = New System.Drawing.Size(150, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(150, 23)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "BUSINESS NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(362, 12)
        Me.Label4.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "TELEPHONE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CadetBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(212, 12)
        Me.Label3.MinimumSize = New System.Drawing.Size(150, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(150, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "EMAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(112, 12)
        Me.Label2.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "SURNAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "NAME"
        '
        'lstv_Contractor
        '
        Me.lstv_Contractor.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstv_Contractor.FullRowSelect = True
        Me.lstv_Contractor.GridLines = True
        Me.lstv_Contractor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstv_Contractor.HideSelection = False
        Me.lstv_Contractor.Location = New System.Drawing.Point(12, 34)
        Me.lstv_Contractor.MultiSelect = False
        Me.lstv_Contractor.Name = "lstv_Contractor"
        Me.lstv_Contractor.Size = New System.Drawing.Size(700, 198)
        Me.lstv_Contractor.TabIndex = 25
        Me.lstv_Contractor.UseCompatibleStateImageBehavior = False
        Me.lstv_Contractor.View = System.Windows.Forms.View.Details
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.CadetBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(612, 12)
        Me.Label6.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "TRADE"
        '
        'lbl_statusInfo
        '
        Me.lbl_statusInfo.AutoSize = True
        Me.lbl_statusInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_statusInfo.Location = New System.Drawing.Point(88, 25)
        Me.lbl_statusInfo.Name = "lbl_statusInfo"
        Me.lbl_statusInfo.Size = New System.Drawing.Size(95, 15)
        Me.lbl_statusInfo.TabIndex = 38
        Me.lbl_statusInfo.Text = "STATUS INFO"
        '
        'cmdViewJobs
        '
        Me.cmdViewJobs.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdViewJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewJobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewJobs.ForeColor = System.Drawing.Color.White
        Me.cmdViewJobs.Location = New System.Drawing.Point(602, 245)
        Me.cmdViewJobs.Name = "cmdViewJobs"
        Me.cmdViewJobs.Size = New System.Drawing.Size(110, 40)
        Me.cmdViewJobs.TabIndex = 37
        Me.cmdViewJobs.Text = "VIEW JOBS"
        Me.cmdViewJobs.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightGray
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.Gray
        Me.cmdDelete.Location = New System.Drawing.Point(421, 432)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(102, 31)
        Me.cmdDelete.TabIndex = 35
        Me.cmdDelete.Text = "Delete record"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.LightGray
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.Gray
        Me.cmdEdit.Location = New System.Drawing.Point(421, 394)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(102, 31)
        Me.cmdEdit.TabIndex = 34
        Me.cmdEdit.Text = "Edit Record"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(636, 425)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 38)
        Me.cmdClose.TabIndex = 36
        Me.cmdClose.Text = "CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_statusInfo)
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(Me.txtTrade)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Controls.Add(NotesLabel)
        Me.GroupBox2.Controls.Add(Me.txtBusiness)
        Me.GroupBox2.Controls.Add(TelephoneLabel)
        Me.GroupBox2.Controls.Add(Me.cmdAddNew)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Me.txtSurname)
        Me.GroupBox2.Controls.Add(Label9)
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 218)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contractor Details"
        '
        'txtTrade
        '
        Me.txtTrade.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrade.Location = New System.Drawing.Point(91, 182)
        Me.txtTrade.Name = "txtTrade"
        Me.txtTrade.Size = New System.Drawing.Size(151, 22)
        Me.txtTrade.TabIndex = 9
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightGray
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.ForeColor = System.Drawing.Color.Gray
        Me.cmdCancel.Location = New System.Drawing.Point(261, 173)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(102, 31)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'txtBusiness
        '
        Me.txtBusiness.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusiness.Location = New System.Drawing.Point(91, 154)
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Size = New System.Drawing.Size(151, 22)
        Me.txtBusiness.TabIndex = 5
        '
        'cmdAddNew
        '
        Me.cmdAddNew.BackColor = System.Drawing.Color.LightGray
        Me.cmdAddNew.Enabled = False
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.ForeColor = System.Drawing.Color.Gray
        Me.cmdAddNew.Location = New System.Drawing.Point(261, 136)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(102, 31)
        Me.cmdAddNew.TabIndex = 6
        Me.cmdAddNew.Text = "Add New Record"
        Me.cmdAddNew.UseVisualStyleBackColor = False
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(91, 125)
        Me.txtTelephone.MaxLength = 11
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(151, 22)
        Me.txtTelephone.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(91, 98)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(151, 22)
        Me.txtEmail.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(91, 74)
        Me.txtSurname.MaxLength = 30
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(151, 22)
        Me.txtSurname.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(91, 47)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(151, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'ContractorDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 479)
        Me.Controls.Add(Me.cmdViewJobs)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstv_Contractor)
        Me.Name = "ContractorDetails"
        Me.Text = "Contractor"
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractorTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractorJobTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents ContractorTableBindingSource As BindingSource
    Friend WithEvents ContractorTableTableAdapter As HLMS1DataSetTableAdapters.ContractorTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContractorJobTableBindingSource As BindingSource
    Friend WithEvents ContractorJobTableTableAdapter As HLMS1DataSetTableAdapters.ContractorJobTableTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstv_Contractor As ListView
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_statusInfo As Label
    Friend WithEvents cmdViewJobs As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents txtBusiness As TextBox
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtTrade As TextBox
End Class
