<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContActivity
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
        Me.ContActivityDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdHomepage = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.rbID = New System.Windows.Forms.RadioButton()
        Me.rbfName = New System.Windows.Forms.RadioButton()
        Me.rbsName = New System.Windows.Forms.RadioButton()
        Me.rbStartDate = New System.Windows.Forms.RadioButton()
        Me.rbEndDate = New System.Windows.Forms.RadioButton()
        CType(Me.ContActivityDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContActivityDataGridView1
        '
        Me.ContActivityDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContActivityDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContActivityDataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.ContActivityDataGridView1.Name = "ContActivityDataGridView1"
        Me.ContActivityDataGridView1.Size = New System.Drawing.Size(611, 235)
        Me.ContActivityDataGridView1.TabIndex = 0
        '
        'cmdHomepage
        '
        Me.cmdHomepage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHomepage.Location = New System.Drawing.Point(507, 327)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(115, 36)
        Me.cmdHomepage.TabIndex = 1
        Me.cmdHomepage.Text = "Return to homepage"
        Me.cmdHomepage.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(363, 312)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 3
        '
        'rbID
        '
        Me.rbID.AutoSize = True
        Me.rbID.Location = New System.Drawing.Point(12, 257)
        Me.rbID.Name = "rbID"
        Me.rbID.Size = New System.Drawing.Size(85, 17)
        Me.rbID.TabIndex = 4
        Me.rbID.TabStop = True
        Me.rbID.Text = "ContractorID"
        Me.rbID.UseVisualStyleBackColor = True
        '
        'rbfName
        '
        Me.rbfName.AutoSize = True
        Me.rbfName.Location = New System.Drawing.Point(12, 280)
        Me.rbfName.Name = "rbfName"
        Me.rbfName.Size = New System.Drawing.Size(70, 17)
        Me.rbfName.TabIndex = 5
        Me.rbfName.TabStop = True
        Me.rbfName.Text = "Firstname"
        Me.rbfName.UseVisualStyleBackColor = True
        '
        'rbsName
        '
        Me.rbsName.AutoSize = True
        Me.rbsName.Location = New System.Drawing.Point(12, 303)
        Me.rbsName.Name = "rbsName"
        Me.rbsName.Size = New System.Drawing.Size(67, 17)
        Me.rbsName.TabIndex = 6
        Me.rbsName.TabStop = True
        Me.rbsName.Text = "Surname"
        Me.rbsName.UseVisualStyleBackColor = True
        '
        'rbStartDate
        '
        Me.rbStartDate.AutoSize = True
        Me.rbStartDate.Location = New System.Drawing.Point(12, 326)
        Me.rbStartDate.Name = "rbStartDate"
        Me.rbStartDate.Size = New System.Drawing.Size(73, 17)
        Me.rbStartDate.TabIndex = 7
        Me.rbStartDate.TabStop = True
        Me.rbStartDate.Text = "Start Date"
        Me.rbStartDate.UseVisualStyleBackColor = True
        '
        'rbEndDate
        '
        Me.rbEndDate.AutoSize = True
        Me.rbEndDate.Location = New System.Drawing.Point(12, 346)
        Me.rbEndDate.Name = "rbEndDate"
        Me.rbEndDate.Size = New System.Drawing.Size(67, 17)
        Me.rbEndDate.TabIndex = 8
        Me.rbEndDate.TabStop = True
        Me.rbEndDate.Text = "EndDate"
        Me.rbEndDate.UseVisualStyleBackColor = True
        '
        'ContActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 373)
        Me.Controls.Add(Me.rbEndDate)
        Me.Controls.Add(Me.rbStartDate)
        Me.Controls.Add(Me.rbsName)
        Me.Controls.Add(Me.rbfName)
        Me.Controls.Add(Me.rbID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdHomepage)
        Me.Controls.Add(Me.ContActivityDataGridView1)
        Me.Name = "ContActivity"
        Me.Text = "ContActivity"
        CType(Me.ContActivityDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContActivityDataGridView1 As DataGridView
    Friend WithEvents cmdHomepage As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rbID As RadioButton
    Friend WithEvents rbfName As RadioButton
    Friend WithEvents rbsName As RadioButton
    Friend WithEvents rbStartDate As RadioButton
    Friend WithEvents rbEndDate As RadioButton
End Class
