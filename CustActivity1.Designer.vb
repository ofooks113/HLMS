<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustActivity1
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
        Me.CustActivity1DataGridView = New System.Windows.Forms.DataGridView()
        Me.cmdActivityMenu = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.rbID = New System.Windows.Forms.RadioButton()
        Me.rbEndDate = New System.Windows.Forms.RadioButton()
        Me.rbStartDate = New System.Windows.Forms.RadioButton()
        Me.rbsName = New System.Windows.Forms.RadioButton()
        Me.rbfName = New System.Windows.Forms.RadioButton()
        CType(Me.CustActivity1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustActivity1DataGridView
        '
        Me.CustActivity1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustActivity1DataGridView.Location = New System.Drawing.Point(12, 3)
        Me.CustActivity1DataGridView.Name = "CustActivity1DataGridView"
        Me.CustActivity1DataGridView.Size = New System.Drawing.Size(776, 353)
        Me.CustActivity1DataGridView.TabIndex = 0
        '
        'cmdActivityMenu
        '
        Me.cmdActivityMenu.Location = New System.Drawing.Point(708, 362)
        Me.cmdActivityMenu.Name = "cmdActivityMenu"
        Me.cmdActivityMenu.Size = New System.Drawing.Size(80, 51)
        Me.cmdActivityMenu.TabIndex = 1
        Me.cmdActivityMenu.Text = "Return to Activity Menu"
        Me.cmdActivityMenu.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(571, 362)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 2
        '
        'rbID
        '
        Me.rbID.AutoSize = True
        Me.rbID.Location = New System.Drawing.Point(12, 362)
        Me.rbID.Name = "rbID"
        Me.rbID.Size = New System.Drawing.Size(80, 17)
        Me.rbID.TabIndex = 3
        Me.rbID.TabStop = True
        Me.rbID.Text = "CustomerID"
        Me.rbID.UseVisualStyleBackColor = True
        '
        'rbEndDate
        '
        Me.rbEndDate.AutoSize = True
        Me.rbEndDate.Location = New System.Drawing.Point(98, 362)
        Me.rbEndDate.Name = "rbEndDate"
        Me.rbEndDate.Size = New System.Drawing.Size(67, 17)
        Me.rbEndDate.TabIndex = 4
        Me.rbEndDate.TabStop = True
        Me.rbEndDate.Text = "EndDate"
        Me.rbEndDate.UseVisualStyleBackColor = True
        '
        'rbStartDate
        '
        Me.rbStartDate.AutoSize = True
        Me.rbStartDate.Location = New System.Drawing.Point(12, 428)
        Me.rbStartDate.Name = "rbStartDate"
        Me.rbStartDate.Size = New System.Drawing.Size(73, 17)
        Me.rbStartDate.TabIndex = 5
        Me.rbStartDate.TabStop = True
        Me.rbStartDate.Text = "Start Date"
        Me.rbStartDate.UseVisualStyleBackColor = True
        '
        'rbsName
        '
        Me.rbsName.AutoSize = True
        Me.rbsName.Location = New System.Drawing.Point(12, 405)
        Me.rbsName.Name = "rbsName"
        Me.rbsName.Size = New System.Drawing.Size(67, 17)
        Me.rbsName.TabIndex = 6
        Me.rbsName.TabStop = True
        Me.rbsName.Text = "Surname"
        Me.rbsName.UseVisualStyleBackColor = True
        '
        'rbfName
        '
        Me.rbfName.AutoSize = True
        Me.rbfName.Location = New System.Drawing.Point(12, 382)
        Me.rbfName.Name = "rbfName"
        Me.rbfName.Size = New System.Drawing.Size(70, 17)
        Me.rbfName.TabIndex = 7
        Me.rbfName.TabStop = True
        Me.rbfName.Text = "Firstname"
        Me.rbfName.UseVisualStyleBackColor = True
        '
        'CustActivity1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rbfName)
        Me.Controls.Add(Me.rbsName)
        Me.Controls.Add(Me.rbStartDate)
        Me.Controls.Add(Me.rbEndDate)
        Me.Controls.Add(Me.rbID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdActivityMenu)
        Me.Controls.Add(Me.CustActivity1DataGridView)
        Me.Name = "CustActivity1"
        Me.Text = "CustActivity1"
        CType(Me.CustActivity1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustActivity1DataGridView As DataGridView
    Friend WithEvents cmdActivityMenu As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rbID As RadioButton
    Friend WithEvents rbEndDate As RadioButton
    Friend WithEvents rbStartDate As RadioButton
    Friend WithEvents rbsName As RadioButton
    Friend WithEvents rbfName As RadioButton
End Class
