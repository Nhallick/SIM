<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToolRoom
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolRoom))
        Me.GBInventory = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.BTNSearch = New System.Windows.Forms.Button()
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.BTNSignOut = New System.Windows.Forms.Button()
        Me.DGVInventory = New System.Windows.Forms.DataGridView()
        Me.QuantityDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxBinSizeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinBinSizeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPlacedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateUpdatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolRoomInventoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet2 = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.GBSubmittedOrders = New System.Windows.Forms.GroupBox()
        Me.BTNReject = New System.Windows.Forms.Button()
        Me.BTNAccept = New System.Windows.Forms.Button()
        Me.DGVSubOrders = New System.Windows.Forms.DataGridView()
        Me.QtyToMakeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSubmittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateMadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CutterOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.TMRRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.QtyToMakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxBinSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinBinSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tool = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxBinSizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinBinSizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPlacedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolRoomInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet1 = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.ToolRoomInventoryTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.ToolRoomInventoryTableAdapter()
        Me.CutterOrdersTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.CutterOrdersTableAdapter()
        Me.GBInventory.SuspendLayout()
        CType(Me.DGVInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolRoomInventoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBSubmittedOrders.SuspendLayout()
        CType(Me.DGVSubOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutterOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolRoomInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBInventory
        '
        Me.GBInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBInventory.Controls.Add(Me.btnNew)
        Me.GBInventory.Controls.Add(Me.TBSearch)
        Me.GBInventory.Controls.Add(Me.BTNSearch)
        Me.GBInventory.Controls.Add(Me.BTNEdit)
        Me.GBInventory.Controls.Add(Me.BTNSignOut)
        Me.GBInventory.Controls.Add(Me.DGVInventory)
        Me.GBInventory.Location = New System.Drawing.Point(12, 12)
        Me.GBInventory.Name = "GBInventory"
        Me.GBInventory.Size = New System.Drawing.Size(652, 517)
        Me.GBInventory.TabIndex = 1
        Me.GBInventory.TabStop = False
        Me.GBInventory.Text = "Inventory"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(571, 487)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'TBSearch
        '
        Me.TBSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TBSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TBSearch.Location = New System.Drawing.Point(249, 490)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(176, 20)
        Me.TBSearch.TabIndex = 4
        '
        'BTNSearch
        '
        Me.BTNSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNSearch.Location = New System.Drawing.Point(168, 488)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.Size = New System.Drawing.Size(75, 23)
        Me.BTNSearch.TabIndex = 3
        Me.BTNSearch.Text = "Search"
        Me.BTNSearch.UseVisualStyleBackColor = True
        '
        'BTNEdit
        '
        Me.BTNEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNEdit.Location = New System.Drawing.Point(87, 488)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(75, 23)
        Me.BTNEdit.TabIndex = 2
        Me.BTNEdit.Text = "Edit"
        Me.BTNEdit.UseVisualStyleBackColor = True
        '
        'BTNSignOut
        '
        Me.BTNSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNSignOut.Location = New System.Drawing.Point(6, 488)
        Me.BTNSignOut.Name = "BTNSignOut"
        Me.BTNSignOut.Size = New System.Drawing.Size(75, 23)
        Me.BTNSignOut.TabIndex = 1
        Me.BTNSignOut.Text = "Sign Out"
        Me.BTNSignOut.UseVisualStyleBackColor = True
        '
        'DGVInventory
        '
        Me.DGVInventory.AllowUserToAddRows = False
        Me.DGVInventory.AllowUserToDeleteRows = False
        Me.DGVInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVInventory.AutoGenerateColumns = False
        Me.DGVInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuantityDataGridViewTextBoxColumn2, Me.ToolDataGridViewTextBoxColumn2, Me.MaxBinSizeDataGridViewTextBoxColumn2, Me.MinBinSizeDataGridViewTextBoxColumn2, Me.OrderPlacedDataGridViewTextBoxColumn1, Me.DateUpdatedDataGridViewTextBoxColumn})
        Me.DGVInventory.DataSource = Me.ToolRoomInventoryBindingSource1
        Me.DGVInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVInventory.Location = New System.Drawing.Point(6, 19)
        Me.DGVInventory.MultiSelect = False
        Me.DGVInventory.Name = "DGVInventory"
        Me.DGVInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventory.Size = New System.Drawing.Size(640, 463)
        Me.DGVInventory.TabIndex = 0
        '
        'QuantityDataGridViewTextBoxColumn2
        '
        Me.QuantityDataGridViewTextBoxColumn2.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn2.Name = "QuantityDataGridViewTextBoxColumn2"
        '
        'ToolDataGridViewTextBoxColumn2
        '
        Me.ToolDataGridViewTextBoxColumn2.DataPropertyName = "Tool"
        Me.ToolDataGridViewTextBoxColumn2.HeaderText = "Tool"
        Me.ToolDataGridViewTextBoxColumn2.Name = "ToolDataGridViewTextBoxColumn2"
        '
        'MaxBinSizeDataGridViewTextBoxColumn2
        '
        Me.MaxBinSizeDataGridViewTextBoxColumn2.DataPropertyName = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn2.HeaderText = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn2.Name = "MaxBinSizeDataGridViewTextBoxColumn2"
        '
        'MinBinSizeDataGridViewTextBoxColumn2
        '
        Me.MinBinSizeDataGridViewTextBoxColumn2.DataPropertyName = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn2.HeaderText = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn2.Name = "MinBinSizeDataGridViewTextBoxColumn2"
        '
        'OrderPlacedDataGridViewTextBoxColumn1
        '
        Me.OrderPlacedDataGridViewTextBoxColumn1.DataPropertyName = "Order Placed"
        Me.OrderPlacedDataGridViewTextBoxColumn1.HeaderText = "Order Placed"
        Me.OrderPlacedDataGridViewTextBoxColumn1.Name = "OrderPlacedDataGridViewTextBoxColumn1"
        '
        'DateUpdatedDataGridViewTextBoxColumn
        '
        Me.DateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "Date Updated"
        Me.DateUpdatedDataGridViewTextBoxColumn.HeaderText = "Date Updated"
        Me.DateUpdatedDataGridViewTextBoxColumn.Name = "DateUpdatedDataGridViewTextBoxColumn"
        '
        'ToolRoomInventoryBindingSource1
        '
        Me.ToolRoomInventoryBindingSource1.DataMember = "ToolRoomInventory"
        Me.ToolRoomInventoryBindingSource1.DataSource = Me.Tool_Cutter_DatabaseDataSet2
        '
        'Tool_Cutter_DatabaseDataSet2
        '
        Me.Tool_Cutter_DatabaseDataSet2.DataSetName = "Tool_Cutter_DatabaseDataSet"
        Me.Tool_Cutter_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GBSubmittedOrders
        '
        Me.GBSubmittedOrders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBSubmittedOrders.Controls.Add(Me.BTNReject)
        Me.GBSubmittedOrders.Controls.Add(Me.BTNAccept)
        Me.GBSubmittedOrders.Controls.Add(Me.DGVSubOrders)
        Me.GBSubmittedOrders.Location = New System.Drawing.Point(670, 12)
        Me.GBSubmittedOrders.Name = "GBSubmittedOrders"
        Me.GBSubmittedOrders.Size = New System.Drawing.Size(444, 517)
        Me.GBSubmittedOrders.TabIndex = 2
        Me.GBSubmittedOrders.TabStop = False
        Me.GBSubmittedOrders.Text = "SubmittedOrders"
        '
        'BTNReject
        '
        Me.BTNReject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNReject.Location = New System.Drawing.Point(87, 488)
        Me.BTNReject.Name = "BTNReject"
        Me.BTNReject.Size = New System.Drawing.Size(75, 23)
        Me.BTNReject.TabIndex = 2
        Me.BTNReject.Text = "Reject"
        Me.BTNReject.UseVisualStyleBackColor = True
        '
        'BTNAccept
        '
        Me.BTNAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNAccept.Location = New System.Drawing.Point(6, 488)
        Me.BTNAccept.Name = "BTNAccept"
        Me.BTNAccept.Size = New System.Drawing.Size(75, 23)
        Me.BTNAccept.TabIndex = 1
        Me.BTNAccept.Text = "Accept"
        Me.BTNAccept.UseVisualStyleBackColor = True
        '
        'DGVSubOrders
        '
        Me.DGVSubOrders.AllowUserToAddRows = False
        Me.DGVSubOrders.AllowUserToDeleteRows = False
        Me.DGVSubOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVSubOrders.AutoGenerateColumns = False
        Me.DGVSubOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSubOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSubOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QtyToMakeDataGridViewTextBoxColumn1, Me.ToolNameDataGridViewTextBoxColumn, Me.DateSubmittedDataGridViewTextBoxColumn, Me.ApprovalDataGridViewTextBoxColumn, Me.DateMadeDataGridViewTextBoxColumn})
        Me.DGVSubOrders.DataSource = Me.CutterOrdersBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVSubOrders.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVSubOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVSubOrders.Location = New System.Drawing.Point(6, 19)
        Me.DGVSubOrders.MultiSelect = False
        Me.DGVSubOrders.Name = "DGVSubOrders"
        Me.DGVSubOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSubOrders.Size = New System.Drawing.Size(432, 463)
        Me.DGVSubOrders.TabIndex = 0
        '
        'QtyToMakeDataGridViewTextBoxColumn1
        '
        Me.QtyToMakeDataGridViewTextBoxColumn1.DataPropertyName = "QtyToMake"
        Me.QtyToMakeDataGridViewTextBoxColumn1.HeaderText = "QtyToMake"
        Me.QtyToMakeDataGridViewTextBoxColumn1.Name = "QtyToMakeDataGridViewTextBoxColumn1"
        '
        'ToolNameDataGridViewTextBoxColumn
        '
        Me.ToolNameDataGridViewTextBoxColumn.DataPropertyName = "Tool Name"
        Me.ToolNameDataGridViewTextBoxColumn.HeaderText = "Tool Name"
        Me.ToolNameDataGridViewTextBoxColumn.Name = "ToolNameDataGridViewTextBoxColumn"
        '
        'DateSubmittedDataGridViewTextBoxColumn
        '
        Me.DateSubmittedDataGridViewTextBoxColumn.DataPropertyName = "Date Submitted"
        Me.DateSubmittedDataGridViewTextBoxColumn.HeaderText = "Date Submitted"
        Me.DateSubmittedDataGridViewTextBoxColumn.Name = "DateSubmittedDataGridViewTextBoxColumn"
        '
        'ApprovalDataGridViewTextBoxColumn
        '
        Me.ApprovalDataGridViewTextBoxColumn.DataPropertyName = "Approval"
        Me.ApprovalDataGridViewTextBoxColumn.HeaderText = "Approval"
        Me.ApprovalDataGridViewTextBoxColumn.Name = "ApprovalDataGridViewTextBoxColumn"
        '
        'DateMadeDataGridViewTextBoxColumn
        '
        Me.DateMadeDataGridViewTextBoxColumn.DataPropertyName = "Date Made"
        Me.DateMadeDataGridViewTextBoxColumn.HeaderText = "Date Made"
        Me.DateMadeDataGridViewTextBoxColumn.Name = "DateMadeDataGridViewTextBoxColumn"
        '
        'CutterOrdersBindingSource
        '
        Me.CutterOrdersBindingSource.DataMember = "CutterOrders"
        Me.CutterOrdersBindingSource.DataSource = Me.Tool_Cutter_DatabaseDataSet
        '
        'Tool_Cutter_DatabaseDataSet
        '
        Me.Tool_Cutter_DatabaseDataSet.DataSetName = "Tool_Cutter_DatabaseDataSet"
        Me.Tool_Cutter_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TMRRefresh
        '
        Me.TMRRefresh.Interval = 1400
        '
        'QtyToMakeDataGridViewTextBoxColumn
        '
        Me.QtyToMakeDataGridViewTextBoxColumn.DataPropertyName = "QtyToMake"
        Me.QtyToMakeDataGridViewTextBoxColumn.HeaderText = "QtyToMake"
        Me.QtyToMakeDataGridViewTextBoxColumn.Name = "QtyToMakeDataGridViewTextBoxColumn"
        Me.QtyToMakeDataGridViewTextBoxColumn.Width = 130
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 149
        '
        'ToolDataGridViewTextBoxColumn
        '
        Me.ToolDataGridViewTextBoxColumn.DataPropertyName = "Tool"
        Me.ToolDataGridViewTextBoxColumn.HeaderText = "Tool"
        Me.ToolDataGridViewTextBoxColumn.Name = "ToolDataGridViewTextBoxColumn"
        Me.ToolDataGridViewTextBoxColumn.Width = 150
        '
        'MaxBinSizeDataGridViewTextBoxColumn
        '
        Me.MaxBinSizeDataGridViewTextBoxColumn.DataPropertyName = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn.HeaderText = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn.Name = "MaxBinSizeDataGridViewTextBoxColumn"
        Me.MaxBinSizeDataGridViewTextBoxColumn.Width = 149
        '
        'MinBinSizeDataGridViewTextBoxColumn
        '
        Me.MinBinSizeDataGridViewTextBoxColumn.DataPropertyName = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn.HeaderText = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn.Name = "MinBinSizeDataGridViewTextBoxColumn"
        Me.MinBinSizeDataGridViewTextBoxColumn.Width = 149
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Tool
        '
        Me.Tool.DataPropertyName = "Tool"
        Me.Tool.HeaderText = "Tool"
        Me.Tool.Name = "Tool"
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        Me.QuantityDataGridViewTextBoxColumn1.Width = 119
        '
        'ToolDataGridViewTextBoxColumn1
        '
        Me.ToolDataGridViewTextBoxColumn1.DataPropertyName = "Tool"
        Me.ToolDataGridViewTextBoxColumn1.HeaderText = "Tool"
        Me.ToolDataGridViewTextBoxColumn1.Name = "ToolDataGridViewTextBoxColumn1"
        Me.ToolDataGridViewTextBoxColumn1.Width = 120
        '
        'MaxBinSizeDataGridViewTextBoxColumn1
        '
        Me.MaxBinSizeDataGridViewTextBoxColumn1.DataPropertyName = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn1.HeaderText = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn1.Name = "MaxBinSizeDataGridViewTextBoxColumn1"
        Me.MaxBinSizeDataGridViewTextBoxColumn1.Width = 119
        '
        'MinBinSizeDataGridViewTextBoxColumn1
        '
        Me.MinBinSizeDataGridViewTextBoxColumn1.DataPropertyName = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn1.HeaderText = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn1.Name = "MinBinSizeDataGridViewTextBoxColumn1"
        Me.MinBinSizeDataGridViewTextBoxColumn1.Width = 120
        '
        'OrderPlacedDataGridViewTextBoxColumn
        '
        Me.OrderPlacedDataGridViewTextBoxColumn.DataPropertyName = "Order Placed"
        Me.OrderPlacedDataGridViewTextBoxColumn.HeaderText = "Order Placed"
        Me.OrderPlacedDataGridViewTextBoxColumn.Name = "OrderPlacedDataGridViewTextBoxColumn"
        Me.OrderPlacedDataGridViewTextBoxColumn.Width = 119
        '
        'ToolRoomInventoryBindingSource
        '
        Me.ToolRoomInventoryBindingSource.DataMember = "ToolRoomInventory"
        Me.ToolRoomInventoryBindingSource.DataSource = Me.Tool_Cutter_DatabaseDataSet1
        '
        'Tool_Cutter_DatabaseDataSet1
        '
        Me.Tool_Cutter_DatabaseDataSet1.DataSetName = "Tool_Cutter_DatabaseDataSet"
        Me.Tool_Cutter_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolRoomInventoryTableAdapter
        '
        Me.ToolRoomInventoryTableAdapter.ClearBeforeFill = True
        '
        'CutterOrdersTableAdapter
        '
        Me.CutterOrdersTableAdapter.ClearBeforeFill = True
        '
        'ToolRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 541)
        Me.Controls.Add(Me.GBSubmittedOrders)
        Me.Controls.Add(Me.GBInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ToolRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tool Room"
        Me.GBInventory.ResumeLayout(False)
        Me.GBInventory.PerformLayout()
        CType(Me.DGVInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolRoomInventoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBSubmittedOrders.ResumeLayout(False)
        CType(Me.DGVSubOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutterOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolRoomInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBInventory As GroupBox
    Friend WithEvents DGVInventory As DataGridView
    Friend WithEvents GBSubmittedOrders As GroupBox
    Friend WithEvents BTNReject As Button
    Friend WithEvents BTNAccept As Button
    Friend WithEvents DGVSubOrders As DataGridView
    Friend WithEvents BTNSearch As Button
    Friend WithEvents BTNEdit As Button
    Friend WithEvents BTNSignOut As Button
    Friend WithEvents TMRRefresh As Timer
    Friend WithEvents Tool_Cutter_DatabaseDataSet As Tool_Cutter_DatabaseDataSet
    Friend WithEvents QtyToMakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tool_Cutter_DatabaseDataSet1 As Tool_Cutter_DatabaseDataSet
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaxBinSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinBinSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Tool As DataGridViewTextBoxColumn
    Friend WithEvents ToolRoomInventoryBindingSource As BindingSource
    Friend WithEvents ToolRoomInventoryTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.ToolRoomInventoryTableAdapter
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ToolDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaxBinSizeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MinBinSizeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OrderPlacedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tool_Cutter_DatabaseDataSet2 As Tool_Cutter_DatabaseDataSet
    Friend WithEvents ToolRoomInventoryBindingSource1 As BindingSource
    Friend WithEvents QuantityDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ToolDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MaxBinSizeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MinBinSizeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents OrderPlacedDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateUpdatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CutterOrdersBindingSource As BindingSource
    Friend WithEvents CutterOrdersTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.CutterOrdersTableAdapter
    Friend WithEvents QtyToMakeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ToolNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateSubmittedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApprovalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateMadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnNew As Button
End Class
