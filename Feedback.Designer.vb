<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
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
        Dim CommentLabel As System.Windows.Forms.Label
        Dim RatingLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.FeedbackTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeedbackTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.FeedbackTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.FeedbackTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CommentLabel = New System.Windows.Forms.Label()
        RatingLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedbackTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedbackTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(12, 252)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(54, 13)
        CommentLabel.TabIndex = 2
        CommentLabel.Text = "Comment:"
        '
        'RatingLabel
        '
        RatingLabel.AutoSize = True
        RatingLabel.Location = New System.Drawing.Point(12, 282)
        RatingLabel.Name = "RatingLabel"
        RatingLabel.Size = New System.Drawing.Size(41, 13)
        RatingLabel.TabIndex = 4
        RatingLabel.Text = "Rating:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(199, 252)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 11
        CustomerIDLabel.Text = "Customer ID:"
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FeedbackTableBindingSource
        '
        Me.FeedbackTableBindingSource.DataMember = "FeedbackTable"
        Me.FeedbackTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'FeedbackTableTableAdapter
        '
        Me.FeedbackTableTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableTableAdapter = Me.FeedbackTableTableAdapter
        Me.TableAdapterManager.InventoryTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonRateTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtComment
        '
        Me.txtComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedbackTableBindingSource, "Comment", True))
        Me.txtComment.Location = New System.Drawing.Point(72, 249)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(100, 20)
        Me.txtComment.TabIndex = 3
        '
        'txtRating
        '
        Me.txtRating.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedbackTableBindingSource, "Rating", True))
        Me.txtRating.Location = New System.Drawing.Point(72, 279)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(100, 20)
        Me.txtRating.TabIndex = 5
        '
        'cmdCustomer
        '
        Me.cmdCustomer.Location = New System.Drawing.Point(15, 29)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(144, 23)
        Me.cmdCustomer.TabIndex = 8
        Me.cmdCustomer.Text = "Return to Customer Form"
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(15, 0)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(98, 23)
        Me.cmdAddNew.TabIndex = 9
        Me.cmdAddNew.Text = "Add New Record"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(211, 0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Save Record"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(119, 0)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(86, 23)
        Me.cmdDelete.TabIndex = 11
        Me.cmdDelete.Text = "Delete Record"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedbackTableBindingSource, "CustomerID", True))
        Me.txtCustomerID.Location = New System.Drawing.Point(273, 249)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 12
        '
        'FeedbackTableDataGridView
        '
        Me.FeedbackTableDataGridView.AutoGenerateColumns = False
        Me.FeedbackTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FeedbackTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FeedbackTableDataGridView.DataSource = Me.FeedbackTableBindingSource
        Me.FeedbackTableDataGridView.Location = New System.Drawing.Point(15, 58)
        Me.FeedbackTableDataGridView.Name = "FeedbackTableDataGridView"
        Me.FeedbackTableDataGridView.Size = New System.Drawing.Size(444, 185)
        Me.FeedbackTableDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FeedbackID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FeedbackID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Rating"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rating"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(308, 26)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 13
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(202, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 14
        '
        'Feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 318)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.FeedbackTableDataGridView)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.cmdCustomer)
        Me.Controls.Add(RatingLabel)
        Me.Controls.Add(Me.txtRating)
        Me.Controls.Add(CommentLabel)
        Me.Controls.Add(Me.txtComment)
        Me.Name = "Feedback"
        Me.Text = "Feedback"
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedbackTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedbackTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents FeedbackTableBindingSource As BindingSource
    Friend WithEvents FeedbackTableTableAdapter As HLMS1DataSetTableAdapters.FeedbackTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtComment As TextBox
    Friend WithEvents txtRating As TextBox
    Friend WithEvents cmdCustomer As Button
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents FeedbackTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
