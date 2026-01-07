<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyTariff
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
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim SeasonRateIDLabel As System.Windows.Forms.Label
        Me.selectStartDate = New System.Windows.Forms.DateTimePicker()
        Me.SeasonTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.selectEndDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdHomepage = New System.Windows.Forms.Button()
        Me.cmdRate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.SeasonTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.SeasonTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.SeasonTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSeasonRateID = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        SeasonRateIDLabel = New System.Windows.Forms.Label()
        CType(Me.SeasonTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Location = New System.Drawing.Point(12, 220)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(58, 13)
        StartDateLabel.TabIndex = 2
        StartDateLabel.Text = "Start Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Location = New System.Drawing.Point(15, 250)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(55, 13)
        EndDateLabel.TabIndex = 4
        EndDateLabel.Text = "End Date:"
        '
        'SeasonRateIDLabel
        '
        SeasonRateIDLabel.AutoSize = True
        SeasonRateIDLabel.Location = New System.Drawing.Point(15, 290)
        SeasonRateIDLabel.Name = "SeasonRateIDLabel"
        SeasonRateIDLabel.Size = New System.Drawing.Size(86, 13)
        SeasonRateIDLabel.TabIndex = 12
        SeasonRateIDLabel.Text = "Season Rate ID:"
        '
        'selectStartDate
        '
        Me.selectStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SeasonTableBindingSource, "StartDate", True))
        Me.selectStartDate.Location = New System.Drawing.Point(107, 220)
        Me.selectStartDate.Name = "selectStartDate"
        Me.selectStartDate.Size = New System.Drawing.Size(129, 20)
        Me.selectStartDate.TabIndex = 3
        '
        'SeasonTableBindingSource
        '
        Me.SeasonTableBindingSource.DataMember = "SeasonTable"
        Me.SeasonTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'selectEndDate
        '
        Me.selectEndDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SeasonTableBindingSource, "EndDate", True))
        Me.selectEndDate.Location = New System.Drawing.Point(107, 250)
        Me.selectEndDate.Name = "selectEndDate"
        Me.selectEndDate.Size = New System.Drawing.Size(129, 20)
        Me.selectEndDate.TabIndex = 5
        '
        'cmdHomepage
        '
        Me.cmdHomepage.Location = New System.Drawing.Point(381, 210)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(74, 38)
        Me.cmdHomepage.TabIndex = 8
        Me.cmdHomepage.Text = "Return to Homepage"
        Me.cmdHomepage.UseVisualStyleBackColor = True
        '
        'cmdRate
        '
        Me.cmdRate.Location = New System.Drawing.Point(381, 250)
        Me.cmdRate.Name = "cmdRate"
        Me.cmdRate.Size = New System.Drawing.Size(75, 41)
        Me.cmdRate.TabIndex = 9
        Me.cmdRate.Text = "Return to Rate"
        Me.cmdRate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(242, 12)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(109, 23)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Text = "Delete Record"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(127, 12)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(109, 23)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Save record"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(12, 12)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(109, 23)
        Me.cmdAddNew.TabIndex = 12
        Me.cmdAddNew.Text = "Add New Record"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'SeasonTableTableAdapter
        '
        Me.SeasonTableTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.FeedbackTableTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonRateTableTableAdapter = Nothing
        Me.TableAdapterManager.SeasonTableTableAdapter = Me.SeasonTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SeasonTableDataGridView
        '
        Me.SeasonTableDataGridView.AutoGenerateColumns = False
        Me.SeasonTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SeasonTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SeasonTableDataGridView.DataSource = Me.SeasonTableBindingSource
        Me.SeasonTableDataGridView.Location = New System.Drawing.Point(12, 41)
        Me.SeasonTableDataGridView.Name = "SeasonTableDataGridView"
        Me.SeasonTableDataGridView.Size = New System.Drawing.Size(459, 151)
        Me.SeasonTableDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StartDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StartDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EndDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EndDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SeasonRateID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SeasonRateID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'txtSeasonRateID
        '
        Me.txtSeasonRateID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeasonTableBindingSource, "SeasonRateID", True))
        Me.txtSeasonRateID.Location = New System.Drawing.Point(107, 287)
        Me.txtSeasonRateID.Name = "txtSeasonRateID"
        Me.txtSeasonRateID.Size = New System.Drawing.Size(129, 20)
        Me.txtSeasonRateID.TabIndex = 13
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(291, 250)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 14
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(275, 220)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 15
        '
        'WeeklyTariff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 325)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(SeasonRateIDLabel)
        Me.Controls.Add(Me.txtSeasonRateID)
        Me.Controls.Add(Me.SeasonTableDataGridView)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdRate)
        Me.Controls.Add(Me.cmdHomepage)
        Me.Controls.Add(EndDateLabel)
        Me.Controls.Add(Me.selectEndDate)
        Me.Controls.Add(StartDateLabel)
        Me.Controls.Add(Me.selectStartDate)
        Me.Name = "WeeklyTariff"
        Me.Text = "WeeklyTariff"
        CType(Me.SeasonTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents SeasonTableBindingSource As BindingSource
    Friend WithEvents SeasonTableTableAdapter As HLMS1DataSetTableAdapters.SeasonTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents selectStartDate As DateTimePicker
    Friend WithEvents selectEndDate As DateTimePicker
    Friend WithEvents cmdHomepage As Button
    Friend WithEvents cmdRate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents SeasonTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents txtSeasonRateID As TextBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
