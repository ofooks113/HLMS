<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustFinancials
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
        Me.dtgCustomerFinancial = New System.Windows.Forms.DataGridView()
        Me.cmdFinancial = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.rbRentDue = New System.Windows.Forms.RadioButton()
        Me.rbSurname = New System.Windows.Forms.RadioButton()
        Me.rbFirstName = New System.Windows.Forms.RadioButton()
        Me.rbCustomerID = New System.Windows.Forms.RadioButton()
        CType(Me.dtgCustomerFinancial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgCustomerFinancial
        '
        Me.dtgCustomerFinancial.AllowUserToAddRows = False
        Me.dtgCustomerFinancial.AllowUserToDeleteRows = False
        Me.dtgCustomerFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCustomerFinancial.Location = New System.Drawing.Point(12, 8)
        Me.dtgCustomerFinancial.Name = "dtgCustomerFinancial"
        Me.dtgCustomerFinancial.ReadOnly = True
        Me.dtgCustomerFinancial.Size = New System.Drawing.Size(583, 273)
        Me.dtgCustomerFinancial.TabIndex = 0
        '
        'cmdFinancial
        '
        Me.cmdFinancial.Location = New System.Drawing.Point(505, 334)
        Me.cmdFinancial.Name = "cmdFinancial"
        Me.cmdFinancial.Size = New System.Drawing.Size(90, 51)
        Me.cmdFinancial.TabIndex = 2
        Me.cmdFinancial.Text = "Return to Financial form"
        Me.cmdFinancial.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(315, 313)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 3
        '
        'rbRentDue
        '
        Me.rbRentDue.AutoSize = True
        Me.rbRentDue.Location = New System.Drawing.Point(16, 357)
        Me.rbRentDue.Name = "rbRentDue"
        Me.rbRentDue.Size = New System.Drawing.Size(68, 17)
        Me.rbRentDue.TabIndex = 4
        Me.rbRentDue.TabStop = True
        Me.rbRentDue.Text = "RentDue"
        Me.rbRentDue.UseVisualStyleBackColor = True
        '
        'rbSurname
        '
        Me.rbSurname.AutoSize = True
        Me.rbSurname.Location = New System.Drawing.Point(16, 334)
        Me.rbSurname.Name = "rbSurname"
        Me.rbSurname.Size = New System.Drawing.Size(67, 17)
        Me.rbSurname.TabIndex = 5
        Me.rbSurname.TabStop = True
        Me.rbSurname.Text = "Surname"
        Me.rbSurname.UseVisualStyleBackColor = True
        '
        'rbFirstName
        '
        Me.rbFirstName.AutoSize = True
        Me.rbFirstName.Location = New System.Drawing.Point(16, 310)
        Me.rbFirstName.Name = "rbFirstName"
        Me.rbFirstName.Size = New System.Drawing.Size(72, 17)
        Me.rbFirstName.TabIndex = 6
        Me.rbFirstName.TabStop = True
        Me.rbFirstName.Text = "FirstName"
        Me.rbFirstName.UseVisualStyleBackColor = True
        '
        'rbCustomerID
        '
        Me.rbCustomerID.AutoSize = True
        Me.rbCustomerID.Location = New System.Drawing.Point(16, 287)
        Me.rbCustomerID.Name = "rbCustomerID"
        Me.rbCustomerID.Size = New System.Drawing.Size(80, 17)
        Me.rbCustomerID.TabIndex = 7
        Me.rbCustomerID.TabStop = True
        Me.rbCustomerID.Text = "CustomerID"
        Me.rbCustomerID.UseVisualStyleBackColor = True
        '
        'CustFinancials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 397)
        Me.Controls.Add(Me.rbCustomerID)
        Me.Controls.Add(Me.rbFirstName)
        Me.Controls.Add(Me.rbSurname)
        Me.Controls.Add(Me.rbRentDue)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdFinancial)
        Me.Controls.Add(Me.dtgCustomerFinancial)
        Me.Name = "CustFinancials"
        Me.Text = "CustFinancials"
        CType(Me.dtgCustomerFinancial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgCustomerFinancial As DataGridView
    Friend WithEvents cmdFinancial As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rbRentDue As RadioButton
    Friend WithEvents rbSurname As RadioButton
    Friend WithEvents rbFirstName As RadioButton
    Friend WithEvents rbCustomerID As RadioButton
End Class
