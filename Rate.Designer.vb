<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rate
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
        Dim RateLabel As System.Windows.Forms.Label
        Dim SeasonRateTypeLabel As System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.SeasonRateTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.cmdTariff = New System.Windows.Forms.Button()
        Me.cmdHomepage = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SeasonRateTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.SeasonRateTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.SeasonRateTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSeasonRateType = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        RateLabel = New System.Windows.Forms.Label()
        SeasonRateTypeLabel = New System.Windows.Forms.Label()
        CType(Me.SeasonRateTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonRateTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RateLabel
        '
        RateLabel.AutoSize = True
        RateLabel.Location = New System.Drawing.Point(12, 196)
        RateLabel.Name = "RateLabel"
        RateLabel.Size = New System.Drawing.Size(33, 13)
        RateLabel.TabIndex = 2
        RateLabel.Text = "Rate:"
        '
        'SeasonRateTypeLabel
        '
        SeasonRateTypeLabel.AutoSize = True
        SeasonRateTypeLabel.Location = New System.Drawing.Point(12, 229)
        SeasonRateTypeLabel.Name = "SeasonRateTypeLabel"
        SeasonRateTypeLabel.Size = New System.Drawing.Size(99, 13)
        SeasonRateTypeLabel.TabIndex = 11
        SeasonRateTypeLabel.Text = "Season Rate Type:"
        '
        'txtRate
        '
        Me.txtRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeasonRateTableBindingSource, "Rate", True))
        Me.txtRate.Location = New System.Drawing.Point(114, 189)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 3
        '
        'SeasonRateTableBindingSource
        '
        Me.SeasonRateTableBindingSource.DataMember = "SeasonRateTable"
        Me.SeasonRateTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdTariff
        '
        Me.cmdTariff.Location = New System.Drawing.Point(263, 206)
        Me.cmdTariff.Name = "cmdTariff"
        Me.cmdTariff.Size = New System.Drawing.Size(75, 36)
        Me.cmdTariff.TabIndex = 6
        Me.cmdTariff.Text = "Weekly Tariff"
        Me.cmdTariff.UseVisualStyleBackColor = True
        '
        'cmdHomepage
        '
        Me.cmdHomepage.Location = New System.Drawing.Point(263, 248)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(75, 38)
        Me.cmdHomepage.TabIndex = 7
        Me.cmdHomepage.Text = "Return to Main Menu"
        Me.cmdHomepage.UseVisualStyleBackColor = True
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(12, 1)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(98, 23)
        Me.cmdAddNew.TabIndex = 8
        Me.cmdAddNew.Text = "Add New Record"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(203, 1)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(87, 23)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete Record"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(116, 1)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(81, 23)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Save Record"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'SeasonRateTableTableAdapter
        '
        Me.SeasonRateTableTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SeasonRateTableTableAdapter = Me.SeasonRateTableTableAdapter
        Me.TableAdapterManager.SeasonTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SeasonRateTableDataGridView
        '
        Me.SeasonRateTableDataGridView.AutoGenerateColumns = False
        Me.SeasonRateTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SeasonRateTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SeasonRateTableDataGridView.DataSource = Me.SeasonRateTableBindingSource
        Me.SeasonRateTableDataGridView.Location = New System.Drawing.Point(14, 36)
        Me.SeasonRateTableDataGridView.Name = "SeasonRateTableDataGridView"
        Me.SeasonRateTableDataGridView.Size = New System.Drawing.Size(346, 145)
        Me.SeasonRateTableDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Rate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SeasonRateType"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SeasonRateType"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'txtSeasonRateType
        '
        Me.txtSeasonRateType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeasonRateTableBindingSource, "SeasonRateType", True))
        Me.txtSeasonRateType.Location = New System.Drawing.Point(117, 226)
        Me.txtSeasonRateType.Name = "txtSeasonRateType"
        Me.txtSeasonRateType.Size = New System.Drawing.Size(100, 20)
        Me.txtSeasonRateType.TabIndex = 12
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(112, 16)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 13
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 252)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 48)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Rate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(SeasonRateTypeLabel)
        Me.Controls.Add(Me.txtSeasonRateType)
        Me.Controls.Add(Me.SeasonRateTableDataGridView)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.cmdHomepage)
        Me.Controls.Add(Me.cmdTariff)
        Me.Controls.Add(RateLabel)
        Me.Controls.Add(Me.txtRate)
        Me.Name = "Rate"
        Me.Text = "Rate"
        CType(Me.SeasonRateTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonRateTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents SeasonRateTableBindingSource As BindingSource
    Friend WithEvents SeasonRateTableTableAdapter As HLMS1DataSetTableAdapters.SeasonRateTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents txtRate As TextBox
    Friend WithEvents cmdTariff As Button
    Friend WithEvents cmdHomepage As Button
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SeasonRateTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents txtSeasonRateType As TextBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
