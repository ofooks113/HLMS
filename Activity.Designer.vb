<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Activity
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
        Me.HLMS1DataSet = New Booking.HLMS1DataSet()
        Me.ActivityTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivityTableTableAdapter = New Booking.HLMS1DataSetTableAdapters.ActivityTableTableAdapter()
        Me.TableAdapterManager = New Booking.HLMS1DataSetTableAdapters.TableAdapterManager()
        Me.cmdHomepage = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdContractor = New System.Windows.Forms.Button()
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HLMS1DataSet
        '
        Me.HLMS1DataSet.DataSetName = "HLMS1DataSet"
        Me.HLMS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivityTableBindingSource
        '
        Me.ActivityTableBindingSource.DataMember = "ActivityTable"
        Me.ActivityTableBindingSource.DataSource = Me.HLMS1DataSet
        '
        'ActivityTableTableAdapter
        '
        Me.ActivityTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivityTableTableAdapter = Me.ActivityTableTableAdapter
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
        Me.TableAdapterManager.SeasonTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Booking.HLMS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmdHomepage
        '
        Me.cmdHomepage.Location = New System.Drawing.Point(224, 74)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(81, 43)
        Me.cmdHomepage.TabIndex = 6
        Me.cmdHomepage.Text = "Return to Homepage"
        Me.cmdHomepage.UseVisualStyleBackColor = True
        '
        'cmdCustomer
        '
        Me.cmdCustomer.Location = New System.Drawing.Point(13, 13)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(98, 49)
        Me.cmdCustomer.TabIndex = 7
        Me.cmdCustomer.Text = "Customers"
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdContractor
        '
        Me.cmdContractor.Location = New System.Drawing.Point(13, 68)
        Me.cmdContractor.Name = "cmdContractor"
        Me.cmdContractor.Size = New System.Drawing.Size(98, 49)
        Me.cmdContractor.TabIndex = 8
        Me.cmdContractor.Text = "Contractor"
        Me.cmdContractor.UseVisualStyleBackColor = True
        '
        'Activity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 132)
        Me.Controls.Add(Me.cmdContractor)
        Me.Controls.Add(Me.cmdCustomer)
        Me.Controls.Add(Me.cmdHomepage)
        Me.Name = "Activity"
        Me.Text = "Activity"
        CType(Me.HLMS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HLMS1DataSet As HLMS1DataSet
    Friend WithEvents ActivityTableBindingSource As BindingSource
    Friend WithEvents ActivityTableTableAdapter As HLMS1DataSetTableAdapters.ActivityTableTableAdapter
    Friend WithEvents TableAdapterManager As HLMS1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmdHomepage As Button
    Friend WithEvents cmdCustomer As Button
    Friend WithEvents cmdContractor As Button
End Class
