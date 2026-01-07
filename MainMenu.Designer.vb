<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.cmdTariff = New System.Windows.Forms.Button()
        Me.cmdItem = New System.Windows.Forms.Button()
        Me.cmdContractor = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.cmdMaintenance = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.txtBillPaid = New System.Windows.Forms.TextBox()
        Me.txtBillDue = New System.Windows.Forms.TextBox()
        Me.gpExpenses = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpRent = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRentReceived = New System.Windows.Forms.TextBox()
        Me.txtRentDue = New System.Windows.Forms.TextBox()
        Me.dateAvailableFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateAvailableTo = New System.Windows.Forms.DateTimePicker()
        Me.cmdFinancial = New System.Windows.Forms.Button()
        Me.cmdNewBooking = New System.Windows.Forms.Button()
        Me.grpAvailability = New System.Windows.Forms.GroupBox()
        Me.cmd_checkAvailable = New System.Windows.Forms.Button()
        Me.lbl_available = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdActivity = New System.Windows.Forms.Button()
        Me.gpExpenses.SuspendLayout()
        Me.gpRent.SuspendLayout()
        Me.grpAvailability.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTariff
        '
        Me.cmdTariff.BackColor = System.Drawing.Color.Teal
        Me.cmdTariff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTariff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTariff.ForeColor = System.Drawing.Color.Snow
        Me.cmdTariff.Location = New System.Drawing.Point(12, 312)
        Me.cmdTariff.Name = "cmdTariff"
        Me.cmdTariff.Size = New System.Drawing.Size(159, 54)
        Me.cmdTariff.TabIndex = 1
        Me.cmdTariff.Text = "Set Tariff"
        Me.cmdTariff.UseVisualStyleBackColor = False
        '
        'cmdItem
        '
        Me.cmdItem.BackColor = System.Drawing.Color.Teal
        Me.cmdItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdItem.ForeColor = System.Drawing.Color.Snow
        Me.cmdItem.Location = New System.Drawing.Point(12, 252)
        Me.cmdItem.Name = "cmdItem"
        Me.cmdItem.Size = New System.Drawing.Size(159, 54)
        Me.cmdItem.TabIndex = 2
        Me.cmdItem.Text = "Inventory"
        Me.cmdItem.UseVisualStyleBackColor = False
        '
        'cmdContractor
        '
        Me.cmdContractor.BackColor = System.Drawing.Color.Teal
        Me.cmdContractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContractor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContractor.ForeColor = System.Drawing.Color.Snow
        Me.cmdContractor.Location = New System.Drawing.Point(12, 132)
        Me.cmdContractor.Name = "cmdContractor"
        Me.cmdContractor.Size = New System.Drawing.Size(159, 54)
        Me.cmdContractor.TabIndex = 3
        Me.cmdContractor.Text = "Contractors"
        Me.cmdContractor.UseVisualStyleBackColor = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.Color.Teal
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.Color.Snow
        Me.cmdCustomer.Location = New System.Drawing.Point(12, 72)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(159, 54)
        Me.cmdCustomer.TabIndex = 4
        Me.cmdCustomer.Text = "Customers"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'Calendar
        '
        Me.Calendar.Location = New System.Drawing.Point(201, 264)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 5
        '
        'cmdMaintenance
        '
        Me.cmdMaintenance.BackColor = System.Drawing.Color.Teal
        Me.cmdMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMaintenance.ForeColor = System.Drawing.Color.Snow
        Me.cmdMaintenance.Location = New System.Drawing.Point(12, 192)
        Me.cmdMaintenance.Name = "cmdMaintenance"
        Me.cmdMaintenance.Size = New System.Drawing.Size(158, 54)
        Me.cmdMaintenance.TabIndex = 7
        Me.cmdMaintenance.Text = "Maintenance"
        Me.cmdMaintenance.UseVisualStyleBackColor = False
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.ForeColor = System.Drawing.Color.White
        Me.cmdHelp.Location = New System.Drawing.Point(455, 334)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(107, 32)
        Me.cmdHelp.TabIndex = 9
        Me.cmdHelp.Text = "HELP"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdQuit
        '
        Me.cmdQuit.BackColor = System.Drawing.Color.Firebrick
        Me.cmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.ForeColor = System.Drawing.Color.White
        Me.cmdQuit.Location = New System.Drawing.Point(455, 372)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(107, 54)
        Me.cmdQuit.TabIndex = 10
        Me.cmdQuit.Text = "QUIT"
        Me.cmdQuit.UseVisualStyleBackColor = False
        '
        'txtBillPaid
        '
        Me.txtBillPaid.Location = New System.Drawing.Point(6, 34)
        Me.txtBillPaid.Name = "txtBillPaid"
        Me.txtBillPaid.ReadOnly = True
        Me.txtBillPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtBillPaid.TabIndex = 15
        Me.txtBillPaid.Text = "£"
        '
        'txtBillDue
        '
        Me.txtBillDue.Location = New System.Drawing.Point(120, 34)
        Me.txtBillDue.Name = "txtBillDue"
        Me.txtBillDue.ReadOnly = True
        Me.txtBillDue.Size = New System.Drawing.Size(100, 20)
        Me.txtBillDue.TabIndex = 16
        Me.txtBillDue.Text = "£"
        '
        'gpExpenses
        '
        Me.gpExpenses.Controls.Add(Me.Label3)
        Me.gpExpenses.Controls.Add(Me.Label4)
        Me.gpExpenses.Controls.Add(Me.txtBillPaid)
        Me.gpExpenses.Controls.Add(Me.txtBillDue)
        Me.gpExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpExpenses.Location = New System.Drawing.Point(326, 88)
        Me.gpExpenses.Name = "gpExpenses"
        Me.gpExpenses.Size = New System.Drawing.Size(236, 64)
        Me.gpExpenses.TabIndex = 0
        Me.gpExpenses.TabStop = False
        Me.gpExpenses.Text = "Expenses"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Outstanding"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Paid"
        '
        'gpRent
        '
        Me.gpRent.Controls.Add(Me.Label2)
        Me.gpRent.Controls.Add(Me.Label1)
        Me.gpRent.Controls.Add(Me.txtRentReceived)
        Me.gpRent.Controls.Add(Me.txtRentDue)
        Me.gpRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpRent.Location = New System.Drawing.Point(326, 13)
        Me.gpRent.Name = "gpRent"
        Me.gpRent.Size = New System.Drawing.Size(236, 67)
        Me.gpRent.TabIndex = 17
        Me.gpRent.TabStop = False
        Me.gpRent.Text = "Rent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Outstanding"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Received"
        '
        'txtRentReceived
        '
        Me.txtRentReceived.Location = New System.Drawing.Point(6, 34)
        Me.txtRentReceived.Name = "txtRentReceived"
        Me.txtRentReceived.ReadOnly = True
        Me.txtRentReceived.Size = New System.Drawing.Size(100, 20)
        Me.txtRentReceived.TabIndex = 15
        Me.txtRentReceived.Text = "£"
        '
        'txtRentDue
        '
        Me.txtRentDue.Location = New System.Drawing.Point(120, 34)
        Me.txtRentDue.Name = "txtRentDue"
        Me.txtRentDue.ReadOnly = True
        Me.txtRentDue.Size = New System.Drawing.Size(100, 20)
        Me.txtRentDue.TabIndex = 16
        Me.txtRentDue.Text = "£"
        '
        'dateAvailableFrom
        '
        Me.dateAvailableFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAvailableFrom.CustomFormat = "dd/MM/yyyy"
        Me.dateAvailableFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAvailableFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateAvailableFrom.Location = New System.Drawing.Point(94, 21)
        Me.dateAvailableFrom.Name = "dateAvailableFrom"
        Me.dateAvailableFrom.Size = New System.Drawing.Size(132, 20)
        Me.dateAvailableFrom.TabIndex = 17
        '
        'dateAvailableTo
        '
        Me.dateAvailableTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAvailableTo.CustomFormat = "dd/MM/yyyy"
        Me.dateAvailableTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAvailableTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateAvailableTo.Location = New System.Drawing.Point(94, 43)
        Me.dateAvailableTo.Name = "dateAvailableTo"
        Me.dateAvailableTo.Size = New System.Drawing.Size(132, 20)
        Me.dateAvailableTo.TabIndex = 18
        '
        'cmdFinancial
        '
        Me.cmdFinancial.BackColor = System.Drawing.Color.Teal
        Me.cmdFinancial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFinancial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinancial.ForeColor = System.Drawing.Color.Snow
        Me.cmdFinancial.Location = New System.Drawing.Point(12, 372)
        Me.cmdFinancial.Name = "cmdFinancial"
        Me.cmdFinancial.Size = New System.Drawing.Size(158, 54)
        Me.cmdFinancial.TabIndex = 19
        Me.cmdFinancial.Text = "Financial"
        Me.cmdFinancial.UseVisualStyleBackColor = False
        '
        'cmdNewBooking
        '
        Me.cmdNewBooking.BackColor = System.Drawing.Color.Teal
        Me.cmdNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNewBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewBooking.ForeColor = System.Drawing.Color.Snow
        Me.cmdNewBooking.Location = New System.Drawing.Point(12, 12)
        Me.cmdNewBooking.Name = "cmdNewBooking"
        Me.cmdNewBooking.Size = New System.Drawing.Size(158, 54)
        Me.cmdNewBooking.TabIndex = 20
        Me.cmdNewBooking.Text = "Bookings"
        Me.cmdNewBooking.UseVisualStyleBackColor = False
        '
        'grpAvailability
        '
        Me.grpAvailability.Controls.Add(Me.cmd_checkAvailable)
        Me.grpAvailability.Controls.Add(Me.lbl_available)
        Me.grpAvailability.Controls.Add(Me.Label6)
        Me.grpAvailability.Controls.Add(Me.Label5)
        Me.grpAvailability.Controls.Add(Me.dateAvailableTo)
        Me.grpAvailability.Controls.Add(Me.dateAvailableFrom)
        Me.grpAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAvailability.Location = New System.Drawing.Point(195, 158)
        Me.grpAvailability.Name = "grpAvailability"
        Me.grpAvailability.Size = New System.Drawing.Size(367, 94)
        Me.grpAvailability.TabIndex = 21
        Me.grpAvailability.TabStop = False
        Me.grpAvailability.Text = "Check Availability"
        '
        'cmd_checkAvailable
        '
        Me.cmd_checkAvailable.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmd_checkAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_checkAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_checkAvailable.ForeColor = System.Drawing.Color.White
        Me.cmd_checkAvailable.Location = New System.Drawing.Point(243, 21)
        Me.cmd_checkAvailable.Name = "cmd_checkAvailable"
        Me.cmd_checkAvailable.Size = New System.Drawing.Size(108, 42)
        Me.cmd_checkAvailable.TabIndex = 22
        Me.cmd_checkAvailable.Text = "CHECK AVAILABILITY"
        Me.cmd_checkAvailable.UseVisualStyleBackColor = False
        '
        'lbl_available
        '
        Me.lbl_available.AutoSize = True
        Me.lbl_available.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_available.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lbl_available.Location = New System.Drawing.Point(19, 72)
        Me.lbl_available.Name = "lbl_available"
        Me.lbl_available.Size = New System.Drawing.Size(73, 13)
        Me.lbl_available.TabIndex = 24
        Me.lbl_available.Text = "AVAILABLE"
        Me.lbl_available.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "End Date:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Start Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdActivity
        '
        Me.cmdActivity.BackColor = System.Drawing.Color.Teal
        Me.cmdActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActivity.ForeColor = System.Drawing.Color.Snow
        Me.cmdActivity.Location = New System.Drawing.Point(176, 12)
        Me.cmdActivity.Name = "cmdActivity"
        Me.cmdActivity.Size = New System.Drawing.Size(143, 55)
        Me.cmdActivity.TabIndex = 22
        Me.cmdActivity.Text = "Activity"
        Me.cmdActivity.UseVisualStyleBackColor = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 440)
        Me.Controls.Add(Me.cmdActivity)
        Me.Controls.Add(Me.grpAvailability)
        Me.Controls.Add(Me.cmdNewBooking)
        Me.Controls.Add(Me.cmdFinancial)
        Me.Controls.Add(Me.gpRent)
        Me.Controls.Add(Me.gpExpenses)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdMaintenance)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.cmdCustomer)
        Me.Controls.Add(Me.cmdContractor)
        Me.Controls.Add(Me.cmdItem)
        Me.Controls.Add(Me.cmdTariff)
        Me.Name = "FormMenu"
        Me.Text = "Main Menu"
        Me.gpExpenses.ResumeLayout(False)
        Me.gpExpenses.PerformLayout()
        Me.gpRent.ResumeLayout(False)
        Me.gpRent.PerformLayout()
        Me.grpAvailability.ResumeLayout(False)
        Me.grpAvailability.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdTariff As Button
    Friend WithEvents cmdItem As Button
    Friend WithEvents cmdContractor As Button
    Friend WithEvents cmdCustomer As Button
    Friend WithEvents Calendar As MonthCalendar
    Friend WithEvents cmdMaintenance As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdQuit As Button
    Friend WithEvents txtBillPaid As TextBox
    Friend WithEvents txtBillDue As TextBox
    Friend WithEvents gpExpenses As GroupBox
    Friend WithEvents gpRent As GroupBox
    Friend WithEvents txtRentReceived As TextBox
    Friend WithEvents txtRentDue As TextBox
    Friend WithEvents dateAvailableFrom As DateTimePicker
    Friend WithEvents dateAvailableTo As DateTimePicker
    Friend WithEvents cmdFinancial As Button
    Friend WithEvents cmdNewBooking As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpAvailability As GroupBox
    Friend WithEvents lbl_available As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmd_checkAvailable As Button
    Friend WithEvents cmdActivity As Button
End Class
