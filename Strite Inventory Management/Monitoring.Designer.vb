<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitoring
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monitoring))
        Me.gbInventory = New System.Windows.Forms.GroupBox()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxBinSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinBinSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPlacedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateUpdatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolRoomInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet1 = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.GBSignedOut = New System.Windows.Forms.GroupBox()
        Me.dgvSignedOut = New System.Windows.Forms.DataGridView()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShopOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignedOutCuttersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.gbUsers = New System.Windows.Forms.GroupBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterfaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbOrders = New System.Windows.Forms.GroupBox()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.QtyToMakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSubmittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateMadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CutterOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CBSearch = New System.Windows.Forms.ComboBox()
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.BTNDevOptions = New System.Windows.Forms.Button()
        Me.ToolRoomInventoryTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.ToolRoomInventoryTableAdapter()
        Me.UsersTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.UsersTableAdapter()
        Me.CutterOrdersTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.CutterOrdersTableAdapter()
        Me.SignedOutCuttersTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.SignedOutCuttersTableAdapter()
        Me.lblbInventoryValue = New System.Windows.Forms.Label()
        Me.lblSignedOutValue = New System.Windows.Forms.Label()
        Me.gbInventory.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolRoomInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBSignedOut.SuspendLayout()
        CType(Me.dgvSignedOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignedOutCuttersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUsers.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOrders.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutterOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbInventory
        '
        Me.gbInventory.Controls.Add(Me.dgvInventory)
        Me.gbInventory.Location = New System.Drawing.Point(12, 12)
        Me.gbInventory.Name = "gbInventory"
        Me.gbInventory.Size = New System.Drawing.Size(912, 402)
        Me.gbInventory.TabIndex = 0
        Me.gbInventory.TabStop = False
        Me.gbInventory.Text = "Inventory"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AutoGenerateColumns = False
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "G"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuantityDataGridViewTextBoxColumn, Me.ToolDataGridViewTextBoxColumn, Me.MaxBinSizeDataGridViewTextBoxColumn, Me.MinBinSizeDataGridViewTextBoxColumn, Me.OrderPlacedDataGridViewTextBoxColumn, Me.DateUpdatedDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1})
        Me.dgvInventory.DataSource = Me.ToolRoomInventoryBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvInventory.Location = New System.Drawing.Point(6, 19)
        Me.dgvInventory.MultiSelect = False
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(900, 377)
        Me.dgvInventory.TabIndex = 0
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'ToolDataGridViewTextBoxColumn
        '
        Me.ToolDataGridViewTextBoxColumn.DataPropertyName = "Tool"
        Me.ToolDataGridViewTextBoxColumn.HeaderText = "Tool"
        Me.ToolDataGridViewTextBoxColumn.Name = "ToolDataGridViewTextBoxColumn"
        '
        'MaxBinSizeDataGridViewTextBoxColumn
        '
        Me.MaxBinSizeDataGridViewTextBoxColumn.DataPropertyName = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn.HeaderText = "Max Bin Size"
        Me.MaxBinSizeDataGridViewTextBoxColumn.Name = "MaxBinSizeDataGridViewTextBoxColumn"
        '
        'MinBinSizeDataGridViewTextBoxColumn
        '
        Me.MinBinSizeDataGridViewTextBoxColumn.DataPropertyName = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn.HeaderText = "Min Bin Size"
        Me.MinBinSizeDataGridViewTextBoxColumn.Name = "MinBinSizeDataGridViewTextBoxColumn"
        '
        'OrderPlacedDataGridViewTextBoxColumn
        '
        Me.OrderPlacedDataGridViewTextBoxColumn.DataPropertyName = "Order Placed"
        Me.OrderPlacedDataGridViewTextBoxColumn.HeaderText = "Order Placed"
        Me.OrderPlacedDataGridViewTextBoxColumn.Name = "OrderPlacedDataGridViewTextBoxColumn"
        '
        'DateUpdatedDataGridViewTextBoxColumn
        '
        Me.DateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "Date Updated"
        Me.DateUpdatedDataGridViewTextBoxColumn.HeaderText = "Date Updated"
        Me.DateUpdatedDataGridViewTextBoxColumn.Name = "DateUpdatedDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cost"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
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
        'GBSignedOut
        '
        Me.GBSignedOut.Controls.Add(Me.dgvSignedOut)
        Me.GBSignedOut.Location = New System.Drawing.Point(12, 420)
        Me.GBSignedOut.Name = "GBSignedOut"
        Me.GBSignedOut.Size = New System.Drawing.Size(912, 366)
        Me.GBSignedOut.TabIndex = 1
        Me.GBSignedOut.TabStop = False
        Me.GBSignedOut.Text = "Signed Out Cutters"
        '
        'dgvSignedOut
        '
        Me.dgvSignedOut.AllowUserToAddRows = False
        Me.dgvSignedOut.AllowUserToDeleteRows = False
        Me.dgvSignedOut.AutoGenerateColumns = False
        Me.dgvSignedOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSignedOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSignedOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuantityDataGridViewTextBoxColumn1, Me.ToolDataGridViewTextBoxColumn1, Me.ShopOrderDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.Cost})
        Me.dgvSignedOut.DataSource = Me.SignedOutCuttersBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Format = "G"
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSignedOut.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSignedOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSignedOut.Location = New System.Drawing.Point(6, 19)
        Me.dgvSignedOut.MultiSelect = False
        Me.dgvSignedOut.Name = "dgvSignedOut"
        Me.dgvSignedOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSignedOut.Size = New System.Drawing.Size(900, 341)
        Me.dgvSignedOut.TabIndex = 0
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.QuantityDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        '
        'ToolDataGridViewTextBoxColumn1
        '
        Me.ToolDataGridViewTextBoxColumn1.DataPropertyName = "Tool"
        Me.ToolDataGridViewTextBoxColumn1.HeaderText = "Tool"
        Me.ToolDataGridViewTextBoxColumn1.Name = "ToolDataGridViewTextBoxColumn1"
        '
        'ShopOrderDataGridViewTextBoxColumn
        '
        Me.ShopOrderDataGridViewTextBoxColumn.DataPropertyName = "ShopOrder"
        Me.ShopOrderDataGridViewTextBoxColumn.HeaderText = "ShopOrder"
        Me.ShopOrderDataGridViewTextBoxColumn.Name = "ShopOrderDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'Cost
        '
        Me.Cost.DataPropertyName = "Cost"
        DataGridViewCellStyle5.Format = "c"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Cost.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cost.HeaderText = "Cost"
        Me.Cost.Name = "Cost"
        '
        'SignedOutCuttersBindingSource
        '
        Me.SignedOutCuttersBindingSource.DataMember = "SignedOutCutters"
        Me.SignedOutCuttersBindingSource.DataSource = Me.Tool_Cutter_DatabaseDataSet
        '
        'Tool_Cutter_DatabaseDataSet
        '
        Me.Tool_Cutter_DatabaseDataSet.DataSetName = "Tool_Cutter_DatabaseDataSet"
        Me.Tool_Cutter_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbUsers
        '
        Me.gbUsers.Controls.Add(Me.dgvUsers)
        Me.gbUsers.Location = New System.Drawing.Point(930, 12)
        Me.gbUsers.Name = "gbUsers"
        Me.gbUsers.Size = New System.Drawing.Size(540, 205)
        Me.gbUsers.TabIndex = 2
        Me.gbUsers.TabStop = False
        Me.gbUsers.Text = "Users"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoGenerateColumns = False
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.InterfaceDataGridViewTextBoxColumn})
        Me.dgvUsers.DataSource = Me.UsersBindingSource
        Me.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUsers.Location = New System.Drawing.Point(6, 19)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(528, 180)
        Me.dgvUsers.TabIndex = 0
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'InterfaceDataGridViewTextBoxColumn
        '
        Me.InterfaceDataGridViewTextBoxColumn.DataPropertyName = "Interface"
        Me.InterfaceDataGridViewTextBoxColumn.HeaderText = "Interface"
        Me.InterfaceDataGridViewTextBoxColumn.Name = "InterfaceDataGridViewTextBoxColumn"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Tool_Cutter_DatabaseDataSet
        '
        'gbOrders
        '
        Me.gbOrders.Controls.Add(Me.dgvOrders)
        Me.gbOrders.Location = New System.Drawing.Point(930, 223)
        Me.gbOrders.Name = "gbOrders"
        Me.gbOrders.Size = New System.Drawing.Size(540, 563)
        Me.gbOrders.TabIndex = 3
        Me.gbOrders.TabStop = False
        Me.gbOrders.Text = "Orders"
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.AutoGenerateColumns = False
        Me.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QtyToMakeDataGridViewTextBoxColumn, Me.ToolNameDataGridViewTextBoxColumn, Me.DateSubmittedDataGridViewTextBoxColumn, Me.ApprovalDataGridViewTextBoxColumn, Me.DateMadeDataGridViewTextBoxColumn})
        Me.dgvOrders.DataSource = Me.CutterOrdersBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.Format = "G"
        DataGridViewCellStyle7.NullValue = Nothing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrders.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOrders.Location = New System.Drawing.Point(6, 19)
        Me.dgvOrders.MultiSelect = False
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrders.Size = New System.Drawing.Size(528, 538)
        Me.dgvOrders.TabIndex = 0
        '
        'QtyToMakeDataGridViewTextBoxColumn
        '
        Me.QtyToMakeDataGridViewTextBoxColumn.DataPropertyName = "QtyToMake"
        Me.QtyToMakeDataGridViewTextBoxColumn.HeaderText = "QtyToMake"
        Me.QtyToMakeDataGridViewTextBoxColumn.Name = "QtyToMakeDataGridViewTextBoxColumn"
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
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 1200
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1466, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(13, 19)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(12, 792)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CBSearch
        '
        Me.CBSearch.FormattingEnabled = True
        Me.CBSearch.Location = New System.Drawing.Point(93, 794)
        Me.CBSearch.Name = "CBSearch"
        Me.CBSearch.Size = New System.Drawing.Size(140, 21)
        Me.CBSearch.TabIndex = 5
        '
        'TBSearch
        '
        Me.TBSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TBSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TBSearch.Location = New System.Drawing.Point(239, 794)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(158, 20)
        Me.TBSearch.TabIndex = 6
        '
        'BTNDevOptions
        '
        Me.BTNDevOptions.Location = New System.Drawing.Point(1355, 791)
        Me.BTNDevOptions.Name = "BTNDevOptions"
        Me.BTNDevOptions.Size = New System.Drawing.Size(109, 23)
        Me.BTNDevOptions.TabIndex = 7
        Me.BTNDevOptions.Text = "Developer Options"
        Me.BTNDevOptions.UseVisualStyleBackColor = True
        '
        'ToolRoomInventoryTableAdapter
        '
        Me.ToolRoomInventoryTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'CutterOrdersTableAdapter
        '
        Me.CutterOrdersTableAdapter.ClearBeforeFill = True
        '
        'SignedOutCuttersTableAdapter
        '
        Me.SignedOutCuttersTableAdapter.ClearBeforeFill = True
        '
        'lblbInventoryValue
        '
        Me.lblbInventoryValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblbInventoryValue.AutoSize = True
        Me.lblbInventoryValue.BackColor = System.Drawing.Color.Transparent
        Me.lblbInventoryValue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblbInventoryValue.Location = New System.Drawing.Point(403, 797)
        Me.lblbInventoryValue.Name = "lblbInventoryValue"
        Me.lblbInventoryValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblbInventoryValue.Size = New System.Drawing.Size(154, 13)
        Me.lblbInventoryValue.TabIndex = 8
        Me.lblbInventoryValue.Text = "Current Tool Inventory Value: $"
        Me.lblbInventoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSignedOutValue
        '
        Me.lblSignedOutValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSignedOutValue.AutoSize = True
        Me.lblSignedOutValue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSignedOutValue.Location = New System.Drawing.Point(637, 797)
        Me.lblSignedOutValue.Name = "lblSignedOutValue"
        Me.lblSignedOutValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSignedOutValue.Size = New System.Drawing.Size(163, 13)
        Me.lblSignedOutValue.TabIndex = 8
        Me.lblSignedOutValue.Text = "Current Signed Out Tool Value: $"
        Me.lblSignedOutValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 823)
        Me.Controls.Add(Me.lblSignedOutValue)
        Me.Controls.Add(Me.lblbInventoryValue)
        Me.Controls.Add(Me.BTNDevOptions)
        Me.Controls.Add(Me.TBSearch)
        Me.Controls.Add(Me.CBSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.gbOrders)
        Me.Controls.Add(Me.gbUsers)
        Me.Controls.Add(Me.GBSignedOut)
        Me.Controls.Add(Me.gbInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Monitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring"
        Me.gbInventory.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolRoomInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBSignedOut.ResumeLayout(False)
        CType(Me.dgvSignedOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignedOutCuttersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUsers.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOrders.ResumeLayout(False)
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutterOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbInventory As GroupBox
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents GBSignedOut As GroupBox
    Friend WithEvents dgvSignedOut As DataGridView
    Friend WithEvents gbUsers As GroupBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents gbOrders As GroupBox
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents Tool_Cutter_DatabaseDataSet As Tool_Cutter_DatabaseDataSet
    Friend WithEvents ToolRoomInventoryTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.ToolRoomInventoryTableAdapter
    Friend WithEvents SignedOutCuttersBindingSource As BindingSource
    Friend WithEvents SignedOutCuttersTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.SignedOutCuttersTableAdapter
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterfaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CutterOrdersBindingSource As BindingSource
    Friend WithEvents CutterOrdersTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.CutterOrdersTableAdapter
    Friend WithEvents QtyToMakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateSubmittedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApprovalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateMadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Tool_Cutter_DatabaseDataSet1 As Tool_Cutter_DatabaseDataSet
    Friend WithEvents ToolRoomInventoryBindingSource As BindingSource
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CBSearch As ComboBox
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents BTNDevOptions As Button
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaxBinSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinBinSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderPlacedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateUpdatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ToolDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ShopOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cost As DataGridViewTextBoxColumn
    Friend WithEvents lblbInventoryValue As Label
    Friend WithEvents lblSignedOutValue As Label
End Class
