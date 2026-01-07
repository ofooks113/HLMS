<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractorJob
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
        Dim Label8 As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim RentPaidDateLabel As System.Windows.Forms.Label
        Dim RentPaidLabel As System.Windows.Forms.Label
        Dim RentDueDateLabel As System.Windows.Forms.Label
        Dim RentDueLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.ContractorJobTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.ContractorJobTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.ContractorJobTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstv_Jobs = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtJobRef = New System.Windows.Forms.TextBox()
        Me.cmb_contractor = New System.Windows.Forms.ComboBox()
        Me.lbl_statusInfo = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.selectFeePaidDate = New System.Windows.Forms.DateTimePicker()
        Me.chkFeePaid = New System.Windows.Forms.CheckBox()
        Me.selectFeeDueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFeeDue = New System.Windows.Forms.TextBox()
        Me.selectEndDate = New System.Windows.Forms.DateTimePicker()
        Me.selectStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdHomepage = New System.Windows.Forms.Button()
        Label8 = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        RentPaidDateLabel = New System.Windows.Forms.Label()
        RentPaidLabel = New System.Windows.Forms.Label()
        RentDueDateLabel = New System.Windows.Forms.Label()
        RentDueLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.ContractorJobTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(19, 70)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(47, 13)
        Label8.TabIndex = 15
        Label8.Text = "Job Ref:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(19, 42)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(90, 13)
        CustomerIDLabel.TabIndex = 10
        CustomerIDLabel.Text = "Contractor Name:"
        '
        'RentPaidDateLabel
        '
        RentPaidDateLabel.AutoSize = True
        RentPaidDateLabel.Location = New System.Drawing.Point(19, 245)
        RentPaidDateLabel.Name = "RentPaidDateLabel"
        RentPaidDateLabel.Size = New System.Drawing.Size(78, 13)
        RentPaidDateLabel.TabIndex = 10
        RentPaidDateLabel.Text = "Fee Paid Date:"
        '
        'RentPaidLabel
        '
        RentPaidLabel.AutoSize = True
        RentPaidLabel.Location = New System.Drawing.Point(19, 215)
        RentPaidLabel.Name = "RentPaidLabel"
        RentPaidLabel.Size = New System.Drawing.Size(52, 13)
        RentPaidLabel.TabIndex = 8
        RentPaidLabel.Text = "Fee Paid:"
        '
        'RentDueDateLabel
        '
        RentDueDateLabel.AutoSize = True
        RentDueDateLabel.Location = New System.Drawing.Point(19, 186)
        RentDueDateLabel.Name = "RentDueDateLabel"
        RentDueDateLabel.Size = New System.Drawing.Size(77, 13)
        RentDueDateLabel.TabIndex = 6
        RentDueDateLabel.Text = "Fee Due Date:"
        '
        'RentDueLabel
        '
        RentDueLabel.AutoSize = True
        RentDueLabel.Location = New System.Drawing.Point(19, 157)
        RentDueLabel.Name = "RentDueLabel"
        RentDueLabel.Size = New System.Drawing.Size(51, 13)
        RentDueLabel.TabIndex = 4
        RentDueLabel.Text = "Fee Due:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(19, 128)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(55, 13)
        Label10.TabIndex = 2
        Label10.Text = "End Date:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(19, 99)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(58, 13)
        Label11.TabIndex = 0
        Label11.Text = "Start Date:"
        '
        'ContractorJobTableBindingSource
        '
        Me.ContractorJobTableBindingSource.DataMember = "ContractorJobTable"
        Me.ContractorJobTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContractorJobTableTableAdapter
        '
        Me.ContractorJobTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivityTableTableAdapter = Nothing
        Me.TableAdapterManager.AvailabilityTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.BookingTableTableAdapter = Nothing
        Me.TableAdapterManager.ContractorJobTableTableAdapter = Me.ContractorJobTableTableAdapter
        Me.TableAdapterManager.ContractorTableTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableTableAdapter = Nothing
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
        Me.Label9.Location = New System.Drawing.Point(452, 13)
        Me.Label9.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(5)
        Me.Label9.Size = New System.Drawing.Size(107, 23)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "FEE DUE DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CadetBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(612, 13)
        Me.Label7.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "PAID DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.CadetBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(552, 13)
        Me.Label6.MinimumSize = New System.Drawing.Size(60, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(60, 23)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = " PAID?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(372, 13)
        Me.Label5.MinimumSize = New System.Drawing.Size(80, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "FEE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(272, 13)
        Me.Label4.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "END"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CadetBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(172, 13)
        Me.Label3.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "START"
        '
        'lstv_Jobs
        '
        Me.lstv_Jobs.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstv_Jobs.FullRowSelect = True
        Me.lstv_Jobs.GridLines = True
        Me.lstv_Jobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstv_Jobs.HideSelection = False
        Me.lstv_Jobs.Location = New System.Drawing.Point(12, 36)
        Me.lstv_Jobs.MultiSelect = False
        Me.lstv_Jobs.Name = "lstv_Jobs"
        Me.lstv_Jobs.Size = New System.Drawing.Size(700, 198)
        Me.lstv_Jobs.TabIndex = 39
        Me.lstv_Jobs.UseCompatibleStateImageBehavior = False
        Me.lstv_Jobs.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(92, 13)
        Me.Label2.MinimumSize = New System.Drawing.Size(80, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "CONT ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.MinimumSize = New System.Drawing.Size(80, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "JOB REF"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.txtJobRef)
        Me.GroupBox1.Controls.Add(Me.cmb_contractor)
        Me.GroupBox1.Controls.Add(Me.lbl_statusInfo)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdAddNew)
        Me.GroupBox1.Controls.Add(CustomerIDLabel)
        Me.GroupBox1.Controls.Add(RentPaidDateLabel)
        Me.GroupBox1.Controls.Add(Me.selectFeePaidDate)
        Me.GroupBox1.Controls.Add(RentPaidLabel)
        Me.GroupBox1.Controls.Add(Me.chkFeePaid)
        Me.GroupBox1.Controls.Add(RentDueDateLabel)
        Me.GroupBox1.Controls.Add(Me.selectFeeDueDate)
        Me.GroupBox1.Controls.Add(RentDueLabel)
        Me.GroupBox1.Controls.Add(Me.txtFeeDue)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.selectEndDate)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.selectStartDate)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 277)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Details"
        '
        'txtJobRef
        '
        Me.txtJobRef.Enabled = False
        Me.txtJobRef.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobRef.Location = New System.Drawing.Point(124, 67)
        Me.txtJobRef.Name = "txtJobRef"
        Me.txtJobRef.Size = New System.Drawing.Size(150, 22)
        Me.txtJobRef.TabIndex = 16
        '
        'cmb_contractor
        '
        Me.cmb_contractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_contractor.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_contractor.FormattingEnabled = True
        Me.cmb_contractor.Location = New System.Drawing.Point(124, 39)
        Me.cmb_contractor.Name = "cmb_contractor"
        Me.cmb_contractor.Size = New System.Drawing.Size(150, 22)
        Me.cmb_contractor.TabIndex = 14
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
        'selectFeePaidDate
        '
        Me.selectFeePaidDate.Enabled = False
        Me.selectFeePaidDate.Location = New System.Drawing.Point(124, 239)
        Me.selectFeePaidDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectFeePaidDate.Name = "selectFeePaidDate"
        Me.selectFeePaidDate.Size = New System.Drawing.Size(150, 20)
        Me.selectFeePaidDate.TabIndex = 11
        '
        'chkFeePaid
        '
        Me.chkFeePaid.Enabled = False
        Me.chkFeePaid.Location = New System.Drawing.Point(124, 210)
        Me.chkFeePaid.Name = "chkFeePaid"
        Me.chkFeePaid.Size = New System.Drawing.Size(104, 24)
        Me.chkFeePaid.TabIndex = 9
        Me.chkFeePaid.Text = "Yes?"
        Me.chkFeePaid.UseVisualStyleBackColor = True
        '
        'selectFeeDueDate
        '
        Me.selectFeeDueDate.Enabled = False
        Me.selectFeeDueDate.Location = New System.Drawing.Point(124, 180)
        Me.selectFeeDueDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectFeeDueDate.Name = "selectFeeDueDate"
        Me.selectFeeDueDate.Size = New System.Drawing.Size(150, 20)
        Me.selectFeeDueDate.TabIndex = 7
        '
        'txtFeeDue
        '
        Me.txtFeeDue.Enabled = False
        Me.txtFeeDue.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeeDue.Location = New System.Drawing.Point(124, 154)
        Me.txtFeeDue.Name = "txtFeeDue"
        Me.txtFeeDue.Size = New System.Drawing.Size(150, 22)
        Me.txtFeeDue.TabIndex = 5
        '
        'selectEndDate
        '
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
        Me.selectStartDate.Enabled = False
        Me.selectStartDate.Location = New System.Drawing.Point(124, 93)
        Me.selectStartDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.selectStartDate.Name = "selectStartDate"
        Me.selectStartDate.Size = New System.Drawing.Size(150, 20)
        Me.selectStartDate.TabIndex = 1
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightGray
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.Gray
        Me.cmdDelete.Location = New System.Drawing.Point(456, 500)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(102, 31)
        Me.cmdDelete.TabIndex = 51
        Me.cmdDelete.Text = "Delete record"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.LightGray
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.Gray
        Me.cmdEdit.Location = New System.Drawing.Point(456, 460)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(102, 31)
        Me.cmdEdit.TabIndex = 50
        Me.cmdEdit.Text = "Edit Record"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdHomepage
        '
        Me.cmdHomepage.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHomepage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHomepage.ForeColor = System.Drawing.Color.White
        Me.cmdHomepage.Location = New System.Drawing.Point(637, 493)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(76, 38)
        Me.cmdHomepage.TabIndex = 52
        Me.cmdHomepage.Text = "CLOSE"
        Me.cmdHomepage.UseVisualStyleBackColor = False
        '
        'ContractorJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 552)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdHomepage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstv_Jobs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContractorJob"
        Me.Text = "ContractorJob"
        CType(Me.ContractorJobTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents ContractorJobTableBindingSource As BindingSource
    Friend WithEvents ContractorJobTableTableAdapter As HLMS1DataSetTableAdapters.ContractorJobTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstv_Jobs As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJobRef As TextBox
    Friend WithEvents cmb_contractor As ComboBox
    Friend WithEvents lbl_statusInfo As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents selectFeePaidDate As DateTimePicker
    Friend WithEvents chkFeePaid As CheckBox
    Friend WithEvents selectFeeDueDate As DateTimePicker
    Friend WithEvents txtFeeDue As TextBox
    Friend WithEvents selectEndDate As DateTimePicker
    Friend WithEvents selectStartDate As DateTimePicker
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdHomepage As Button
End Class
