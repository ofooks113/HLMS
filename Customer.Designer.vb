<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.CustomerTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.cmdHomepage = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lstv_Customer = New System.Windows.Forms.ListView()
        Me.lbl_statusInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdViewBookings = New System.Windows.Forms.Button()
        FirstNameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(6, 27)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 0
        FirstNameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(6, 54)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 2
        SurnameLabel.Text = "Surname:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 78)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(6, 105)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 6
        TelephoneLabel.Text = "Telephone:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(6, 134)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 8
        NotesLabel.Text = "Notes:"
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableBindingSource
        '
        Me.CustomerTableBindingSource.DataMember = "CustomerTable"
        Me.CustomerTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'CustomerTableTableAdapter
        '
        Me.CustomerTableTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CustomerTableTableAdapter = Me.CustomerTableTableAdapter
        Me.TableAdapterManager.FeedbackTableTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonRateTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(NotesLabel)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(TelephoneLabel)
        Me.GroupBox1.Controls.Add(Me.cmdAddNew)
        Me.GroupBox1.Controls.Add(Me.txtTelephone)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 222)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightGray
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.ForeColor = System.Drawing.Color.Gray
        Me.cmdCancel.Location = New System.Drawing.Point(223, 184)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(102, 31)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'txtNotes
        '
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Notes", True))
        Me.txtNotes.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(77, 131)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(128, 85)
        Me.txtNotes.TabIndex = 5
        '
        'cmdAddNew
        '
        Me.cmdAddNew.BackColor = System.Drawing.Color.LightGray
        Me.cmdAddNew.Enabled = False
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.ForeColor = System.Drawing.Color.Gray
        Me.cmdAddNew.Location = New System.Drawing.Point(223, 147)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(102, 31)
        Me.cmdAddNew.TabIndex = 6
        Me.cmdAddNew.Text = "Add New Record"
        Me.cmdAddNew.UseVisualStyleBackColor = False
        '
        'txtTelephone
        '
        Me.txtTelephone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Telephone", True))
        Me.txtTelephone.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(77, 102)
        Me.txtTelephone.MaxLength = 11
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(128, 22)
        Me.txtTelephone.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(77, 75)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(128, 22)
        Me.txtEmail.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Surname", True))
        Me.txtSurname.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(77, 51)
        Me.txtSurname.MaxLength = 30
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(128, 22)
        Me.txtSurname.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "FirstName", True))
        Me.txtFirstName.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(77, 24)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(128, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'cmdHomepage
        '
        Me.cmdHomepage.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHomepage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHomepage.ForeColor = System.Drawing.Color.White
        Me.cmdHomepage.Location = New System.Drawing.Point(584, 439)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(76, 38)
        Me.cmdHomepage.TabIndex = 10
        Me.cmdHomepage.Text = "CLOSE"
        Me.cmdHomepage.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.LightGray
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.Gray
        Me.cmdEdit.Location = New System.Drawing.Point(373, 402)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(102, 31)
        Me.cmdEdit.TabIndex = 8
        Me.cmdEdit.Text = "Edit Record"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightGray
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.Gray
        Me.cmdDelete.Location = New System.Drawing.Point(373, 440)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(102, 31)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete record"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lstv_Customer
        '
        Me.lstv_Customer.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstv_Customer.FullRowSelect = True
        Me.lstv_Customer.GridLines = True
        Me.lstv_Customer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstv_Customer.HideSelection = False
        Me.lstv_Customer.Location = New System.Drawing.Point(12, 35)
        Me.lstv_Customer.MultiSelect = False
        Me.lstv_Customer.Name = "lstv_Customer"
        Me.lstv_Customer.Size = New System.Drawing.Size(640, 198)
        Me.lstv_Customer.TabIndex = 17
        Me.lstv_Customer.UseCompatibleStateImageBehavior = False
        Me.lstv_Customer.View = System.Windows.Forms.View.Details
        '
        'lbl_statusInfo
        '
        Me.lbl_statusInfo.AutoSize = True
        Me.lbl_statusInfo.Location = New System.Drawing.Point(370, 348)
        Me.lbl_statusInfo.Name = "lbl_statusInfo"
        Me.lbl_statusInfo.Size = New System.Drawing.Size(78, 13)
        Me.lbl_statusInfo.TabIndex = 18
        Me.lbl_statusInfo.Text = "STATUS INFO"
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
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "NAME"
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
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SURNAME"
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
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "EMAIL"
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
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "TELEPHONE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(462, 12)
        Me.Label5.MinimumSize = New System.Drawing.Size(190, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(190, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "NOTES"
        '
        'cmdViewBookings
        '
        Me.cmdViewBookings.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewBookings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewBookings.ForeColor = System.Drawing.Color.White
        Me.cmdViewBookings.Location = New System.Drawing.Point(542, 255)
        Me.cmdViewBookings.Name = "cmdViewBookings"
        Me.cmdViewBookings.Size = New System.Drawing.Size(110, 40)
        Me.cmdViewBookings.TabIndex = 38
        Me.cmdViewBookings.Text = "BOOKINGS"
        Me.cmdViewBookings.UseVisualStyleBackColor = False
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 489)
        Me.Controls.Add(Me.cmdViewBookings)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_statusInfo)
        Me.Controls.Add(Me.lstv_Customer)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdHomepage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Customer"
        Me.ShowInTaskbar = False
        Me.Text = "Customers"
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents CustomerTableBindingSource As BindingSource
    Friend WithEvents CustomerTableTableAdapter As HLMS1DataSetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents cmdHomepage As Button
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lstv_Customer As ListView
    Friend WithEvents cmdCancel As Button
    Friend WithEvents lbl_statusInfo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdViewBookings As Button
End Class
