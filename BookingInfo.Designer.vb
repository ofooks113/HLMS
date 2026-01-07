<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingInfo
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
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim RentDueLabel As System.Windows.Forms.Label
        Dim RentDueDateLabel As System.Windows.Forms.Label
        Dim RentPaidLabel As System.Windows.Forms.Label
        Dim RentPaidDateLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.BookingTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.BookingTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBookingRef = New System.Windows.Forms.TextBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.lbl_statusInfo = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.selectRentPaidDate = New System.Windows.Forms.DateTimePicker()
        Me.chkRentPaid = New System.Windows.Forms.CheckBox()
        Me.selectRentDueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRentDue = New System.Windows.Forms.TextBox()
        Me.selectEndDate = New System.Windows.Forms.DateTimePicker()
        Me.selectStartDate = New System.Windows.Forms.DateTimePicker()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.CustomerTableTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstv_Bookings = New System.Windows.Forms.ListView()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdHomepage = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        RentDueLabel = New System.Windows.Forms.Label()
        RentDueDateLabel = New System.Windows.Forms.Label()
        RentPaidLabel = New System.Windows.Forms.Label()
        RentPaidDateLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Location = New System.Drawing.Point(19, 99)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(58, 13)
        StartDateLabel.TabIndex = 0
        StartDateLabel.Text = "Start Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Location = New System.Drawing.Point(19, 128)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(55, 13)
        EndDateLabel.TabIndex = 2
        EndDateLabel.Text = "End Date:"
        '
        'RentDueLabel
        '
        RentDueLabel.AutoSize = True
        RentDueLabel.Location = New System.Drawing.Point(19, 157)
        RentDueLabel.Name = "RentDueLabel"
        RentDueLabel.Size = New System.Drawing.Size(56, 13)
        RentDueLabel.TabIndex = 4
        RentDueLabel.Text = "Rent Due:"
        '
        'RentDueDateLabel
        '
        RentDueDateLabel.AutoSize = True
        RentDueDateLabel.Location = New System.Drawing.Point(19, 186)
        RentDueDateLabel.Name = "RentDueDateLabel"
        RentDueDateLabel.Size = New System.Drawing.Size(82, 13)
        RentDueDateLabel.TabIndex = 6
        RentDueDateLabel.Text = "Rent Due Date:"
        '
        'RentPaidLabel
        '
        RentPaidLabel.AutoSize = True
        RentPaidLabel.Location = New System.Drawing.Point(19, 215)
        RentPaidLabel.Name = "RentPaidLabel"
        RentPaidLabel.Size = New System.Drawing.Size(57, 13)
        RentPaidLabel.TabIndex = 8
        RentPaidLabel.Text = "Rent Paid:"
        '
        'RentPaidDateLabel
        '
        RentPaidDateLabel.AutoSize = True
        RentPaidDateLabel.Location = New System.Drawing.Point(19, 245)
        RentPaidDateLabel.Name = "RentPaidDateLabel"
        RentPaidDateLabel.Size = New System.Drawing.Size(83, 13)
        RentPaidDateLabel.TabIndex = 10
        RentPaidDateLabel.Text = "Rent Paid Date:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(19, 42)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(85, 13)
        CustomerIDLabel.TabIndex = 10
        CustomerIDLabel.Text = "Customer Name:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(19, 70)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(69, 13)
        Label8.TabIndex = 15
        Label8.Text = "Booking Ref:"
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableBindingSource
        '
        Me.BookingTableBindingSource.DataMember = "BookingTable"
        Me.BookingTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'BookingTableTableAdapter
        '
        Me.BookingTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivityTableTableAdapter = Nothing
        Me.TableAdapterManager.AvailabilityTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.BookingTableTableAdapter = Me.BookingTableTableAdapter
        Me.TableAdapterManager.ContractorJobTableTableAdapter = Nothing
        Me.TableAdapterManager.ContractorTableTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonRateTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.txtBookingRef)
        Me.GroupBox1.Controls.Add(Me.cmb_customer)
        Me.GroupBox1.Controls.Add(Me.lbl_statusInfo)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdAddNew)
        Me.GroupBox1.Controls.Add(CustomerIDLabel)
        Me.GroupBox1.Controls.Add(RentPaidDateLabel)
        Me.GroupBox1.Controls.Add(Me.selectRentPaidDate)
        Me.GroupBox1.Controls.Add(RentPaidLabel)
        Me.GroupBox1.Controls.Add(Me.chkRentPaid)
        Me.GroupBox1.Controls.Add(RentDueDateLabel)
        Me.GroupBox1.Controls.Add(Me.selectRentDueDate)
        Me.GroupBox1.Controls.Add(RentDueLabel)
        Me.GroupBox1.Controls.Add(Me.txtRentDue)
        Me.GroupBox1.Controls.Add(EndDateLabel)
        Me.GroupBox1.Controls.Add(Me.selectEndDate)
        Me.GroupBox1.Controls.Add(StartDateLabel)
        Me.GroupBox1.Controls.Add(Me.selectStartDate)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 277)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking Information"
        '
        'txtBookingRef
        '
        Me.txtBookingRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingTableBindingSource, "RentDue", True))
        Me.txtBookingRef.Enabled = False
        Me.txtBookingRef.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingRef.Location = New System.Drawing.Point(124, 67)
        Me.txtBookingRef.Name = "txtBookingRef"
        Me.txtBookingRef.Size = New System.Drawing.Size(150, 22)
        Me.txtBookingRef.TabIndex = 16
        '
        'cmb_customer
        '
        Me.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_customer.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(124, 39)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(150, 22)
        Me.cmb_customer.TabIndex = 14
        '
        'lbl_statusInfo
        '
        Me.lbl_statusInfo.AutoSize = True
        Me.lbl_statusInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_statusInfo.Location = New System.Drawing.Point(121, 16)
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
        Me.cmdCancel.Location = New System.Drawing.Point(291, 228)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(102, 31)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAddNew
        '
        Me.cmdAddNew.BackColor = System.Drawing.Color.LightGray
        Me.cmdAddNew.Enabled = False
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.ForeColor = System.Drawing.Color.Gray
        Me.cmdAddNew.Location = New System.Drawing.Point(291, 188)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(102, 31)
        Me.cmdAddNew.TabIndex = 12
        Me.cmdAddNew.Text = "Add New Record"
        Me.cmdAddNew.UseVisualStyleBackColor = False
        '
        'selectRentPaidDate
        '
        Me.selectRentPaidDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingTableBindingSource, "RentPaidDate", True))
        Me.selectRentPaidDate.Enabled = False
        Me.selectRentPaidDate.Location = New System.Drawing.Point(124, 239)
        Me.selectRentPaidDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectRentPaidDate.Name = "selectRentPaidDate"
        Me.selectRentPaidDate.Size = New System.Drawing.Size(150, 20)
        Me.selectRentPaidDate.TabIndex = 11
        '
        'chkRentPaid
        '
        Me.chkRentPaid.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BookingTableBindingSource, "RentPaid", True))
        Me.chkRentPaid.Enabled = False
        Me.chkRentPaid.Location = New System.Drawing.Point(124, 210)
        Me.chkRentPaid.Name = "chkRentPaid"
        Me.chkRentPaid.Size = New System.Drawing.Size(104, 24)
        Me.chkRentPaid.TabIndex = 9
        Me.chkRentPaid.Text = "Yes?"
        Me.chkRentPaid.UseVisualStyleBackColor = True
        '
        'selectRentDueDate
        '
        Me.selectRentDueDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingTableBindingSource, "RentDueDate", True))
        Me.selectRentDueDate.Enabled = False
        Me.selectRentDueDate.Location = New System.Drawing.Point(124, 180)
        Me.selectRentDueDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectRentDueDate.Name = "selectRentDueDate"
        Me.selectRentDueDate.Size = New System.Drawing.Size(150, 20)
        Me.selectRentDueDate.TabIndex = 7
        '
        'txtRentDue
        '
        Me.txtRentDue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingTableBindingSource, "RentDue", True))
        Me.txtRentDue.Enabled = False
        Me.txtRentDue.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentDue.Location = New System.Drawing.Point(124, 154)
        Me.txtRentDue.Name = "txtRentDue"
        Me.txtRentDue.Size = New System.Drawing.Size(150, 22)
        Me.txtRentDue.TabIndex = 5
        '
        'selectEndDate
        '
        Me.selectEndDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingTableBindingSource, "EndDate", True))
        Me.selectEndDate.Enabled = False
        Me.selectEndDate.Location = New System.Drawing.Point(124, 122)
        Me.selectEndDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectEndDate.Name = "selectEndDate"
        Me.selectEndDate.Size = New System.Drawing.Size(150, 20)
        Me.selectEndDate.TabIndex = 3
        Me.selectEndDate.Value = New Date(2022, 1, 24, 0, 0, 0, 0)
        '
        'selectStartDate
        '
        Me.selectStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingTableBindingSource, "StartDate", True))
        Me.selectStartDate.Enabled = False
        Me.selectStartDate.Location = New System.Drawing.Point(124, 93)
        Me.selectStartDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectStartDate.Name = "selectStartDate"
        Me.selectStartDate.Size = New System.Drawing.Size(150, 20)
        Me.selectStartDate.TabIndex = 1
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(370, 9)
        Me.Label5.MinimumSize = New System.Drawing.Size(80, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "RENT "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(270, 9)
        Me.Label4.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "END"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CadetBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(170, 9)
        Me.Label3.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "START"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(90, 9)
        Me.Label2.MinimumSize = New System.Drawing.Size(80, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "CUST ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.MinimumSize = New System.Drawing.Size(80, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "REF"
        '
        'lstv_Bookings
        '
        Me.lstv_Bookings.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstv_Bookings.FullRowSelect = True
        Me.lstv_Bookings.GridLines = True
        Me.lstv_Bookings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstv_Bookings.HideSelection = False
        Me.lstv_Bookings.Location = New System.Drawing.Point(10, 32)
        Me.lstv_Bookings.MultiSelect = False
        Me.lstv_Bookings.Name = "lstv_Bookings"
        Me.lstv_Bookings.Size = New System.Drawing.Size(700, 198)
        Me.lstv_Bookings.TabIndex = 24
        Me.lstv_Bookings.UseCompatibleStateImageBehavior = False
        Me.lstv_Bookings.View = System.Windows.Forms.View.Details
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightGray
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.Gray
        Me.cmdDelete.Location = New System.Drawing.Point(453, 495)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(102, 31)
        Me.cmdDelete.TabIndex = 32
        Me.cmdDelete.Text = "Delete record"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.LightGray
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.Gray
        Me.cmdEdit.Location = New System.Drawing.Point(453, 455)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(102, 31)
        Me.cmdEdit.TabIndex = 31
        Me.cmdEdit.Text = "Edit Record"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdHomepage
        '
        Me.cmdHomepage.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHomepage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHomepage.ForeColor = System.Drawing.Color.White
        Me.cmdHomepage.Location = New System.Drawing.Point(634, 488)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(76, 38)
        Me.cmdHomepage.TabIndex = 33
        Me.cmdHomepage.Text = "CLOSE"
        Me.cmdHomepage.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.CadetBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(550, 9)
        Me.Label6.MinimumSize = New System.Drawing.Size(60, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(60, 23)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = " PAID?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CadetBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(610, 9)
        Me.Label7.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "PAID DATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.CadetBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(450, 9)
        Me.Label9.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(5)
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "RENT DUE"
        '
        'BookingInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 544)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdHomepage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstv_Bookings)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookingInfo"
        Me.Text = "BookingInfo"
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents BookingTableBindingSource As BindingSource
    Friend WithEvents BookingTableTableAdapter As HLMS1DataSetTableAdapters.BookingTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents selectRentPaidDate As DateTimePicker
    Friend WithEvents chkRentPaid As CheckBox
    Friend WithEvents selectRentDueDate As DateTimePicker
    Friend WithEvents txtRentDue As TextBox
    Friend WithEvents selectEndDate As DateTimePicker
    Friend WithEvents selectStartDate As DateTimePicker
    Friend WithEvents CustomerTableBindingSource As BindingSource
    Friend WithEvents CustomerTableTableAdapter As HLMS1DataSetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstv_Bookings As ListView
    Friend WithEvents lbl_statusInfo As Label
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdHomepage As Button
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBookingRef As TextBox
    Friend WithEvents Label9 As Label
End Class
