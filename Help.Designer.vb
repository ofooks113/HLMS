<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdActivity = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdContractor = New System.Windows.Forms.Button()
        Me.cmdItem = New System.Windows.Forms.Button()
        Me.cmdTariff = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose a function"
        '
        'cmdActivity
        '
        Me.cmdActivity.Location = New System.Drawing.Point(16, 31)
        Me.cmdActivity.Name = "cmdActivity"
        Me.cmdActivity.Size = New System.Drawing.Size(79, 23)
        Me.cmdActivity.TabIndex = 1
        Me.cmdActivity.Text = "Activity"
        Me.cmdActivity.UseVisualStyleBackColor = True
        '
        'cmdCustomer
        '
        Me.cmdCustomer.Location = New System.Drawing.Point(16, 60)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(79, 23)
        Me.cmdCustomer.TabIndex = 2
        Me.cmdCustomer.Text = "Customer"
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdContractor
        '
        Me.cmdContractor.Location = New System.Drawing.Point(16, 89)
        Me.cmdContractor.Name = "cmdContractor"
        Me.cmdContractor.Size = New System.Drawing.Size(79, 23)
        Me.cmdContractor.TabIndex = 3
        Me.cmdContractor.Text = "Contractor"
        Me.cmdContractor.UseVisualStyleBackColor = True
        '
        'cmdItem
        '
        Me.cmdItem.Location = New System.Drawing.Point(16, 119)
        Me.cmdItem.Name = "cmdItem"
        Me.cmdItem.Size = New System.Drawing.Size(79, 23)
        Me.cmdItem.TabIndex = 4
        Me.cmdItem.Text = "Property Item"
        Me.cmdItem.UseVisualStyleBackColor = True
        '
        'cmdTariff
        '
        Me.cmdTariff.Location = New System.Drawing.Point(16, 149)
        Me.cmdTariff.Name = "cmdTariff"
        Me.cmdTariff.Size = New System.Drawing.Size(79, 23)
        Me.cmdTariff.TabIndex = 5
        Me.cmdTariff.Text = "Weekly tariff"
        Me.cmdTariff.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(128, 31)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 208)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdTariff)
        Me.Controls.Add(Me.cmdItem)
        Me.Controls.Add(Me.cmdContractor)
        Me.Controls.Add(Me.cmdCustomer)
        Me.Controls.Add(Me.cmdActivity)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdActivity As Button
    Friend WithEvents cmdCustomer As Button
    Friend WithEvents cmdContractor As Button
    Friend WithEvents cmdItem As Button
    Friend WithEvents cmdTariff As Button
    Friend WithEvents cmdExit As Button
End Class
