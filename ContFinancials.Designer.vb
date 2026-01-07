<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContFinancials
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
        Me.dtgContractorFinancial = New System.Windows.Forms.DataGridView()
        Me.cmdFinancials = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.rbContractorID = New System.Windows.Forms.RadioButton()
        Me.rbFirstname = New System.Windows.Forms.RadioButton()
        Me.rbSurname = New System.Windows.Forms.RadioButton()
        Me.rbFeeDue = New System.Windows.Forms.RadioButton()
        CType(Me.dtgContractorFinancial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgContractorFinancial
        '
        Me.dtgContractorFinancial.AllowUserToAddRows = False
        Me.dtgContractorFinancial.AllowUserToDeleteRows = False
        Me.dtgContractorFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgContractorFinancial.Location = New System.Drawing.Point(13, 13)
        Me.dtgContractorFinancial.Name = "dtgContractorFinancial"
        Me.dtgContractorFinancial.ReadOnly = True
        Me.dtgContractorFinancial.Size = New System.Drawing.Size(533, 302)
        Me.dtgContractorFinancial.TabIndex = 0
        '
        'cmdFinancials
        '
        Me.cmdFinancials.Location = New System.Drawing.Point(471, 333)
        Me.cmdFinancials.Name = "cmdFinancials"
        Me.cmdFinancials.Size = New System.Drawing.Size(75, 51)
        Me.cmdFinancials.TabIndex = 1
        Me.cmdFinancials.Text = "Return to Financials Menu"
        Me.cmdFinancials.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(308, 321)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 3
        '
        'rbContractorID
        '
        Me.rbContractorID.AutoSize = True
        Me.rbContractorID.Location = New System.Drawing.Point(16, 327)
        Me.rbContractorID.Name = "rbContractorID"
        Me.rbContractorID.Size = New System.Drawing.Size(85, 17)
        Me.rbContractorID.TabIndex = 4
        Me.rbContractorID.TabStop = True
        Me.rbContractorID.Text = "ContractorID"
        Me.rbContractorID.UseVisualStyleBackColor = True
        '
        'rbFirstname
        '
        Me.rbFirstname.AutoSize = True
        Me.rbFirstname.Location = New System.Drawing.Point(16, 350)
        Me.rbFirstname.Name = "rbFirstname"
        Me.rbFirstname.Size = New System.Drawing.Size(70, 17)
        Me.rbFirstname.TabIndex = 5
        Me.rbFirstname.TabStop = True
        Me.rbFirstname.Text = "Firstname"
        Me.rbFirstname.UseVisualStyleBackColor = True
        '
        'rbSurname
        '
        Me.rbSurname.AutoSize = True
        Me.rbSurname.Location = New System.Drawing.Point(16, 373)
        Me.rbSurname.Name = "rbSurname"
        Me.rbSurname.Size = New System.Drawing.Size(67, 17)
        Me.rbSurname.TabIndex = 6
        Me.rbSurname.TabStop = True
        Me.rbSurname.Text = "Surname"
        Me.rbSurname.UseVisualStyleBackColor = True
        '
        'rbFeeDue
        '
        Me.rbFeeDue.AutoSize = True
        Me.rbFeeDue.Location = New System.Drawing.Point(16, 396)
        Me.rbFeeDue.Name = "rbFeeDue"
        Me.rbFeeDue.Size = New System.Drawing.Size(66, 17)
        Me.rbFeeDue.TabIndex = 7
        Me.rbFeeDue.TabStop = True
        Me.rbFeeDue.Text = "Fee Due"
        Me.rbFeeDue.UseVisualStyleBackColor = True
        '
        'ContFinancials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 425)
        Me.Controls.Add(Me.rbFeeDue)
        Me.Controls.Add(Me.rbSurname)
        Me.Controls.Add(Me.rbFirstname)
        Me.Controls.Add(Me.rbContractorID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdFinancials)
        Me.Controls.Add(Me.dtgContractorFinancial)
        Me.Name = "ContFinancials"
        Me.Text = "ContFinancials"
        CType(Me.dtgContractorFinancial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgContractorFinancial As DataGridView
    Friend WithEvents cmdFinancials As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rbContractorID As RadioButton
    Friend WithEvents rbFirstname As RadioButton
    Friend WithEvents rbSurname As RadioButton
    Friend WithEvents rbFeeDue As RadioButton
End Class
