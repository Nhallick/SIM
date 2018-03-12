<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Filtering
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filtering))
        Me.dgvSignedOut = New System.Windows.Forms.DataGridView()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShopOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignedOutCuttersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.GBFilter = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBHigh = New System.Windows.Forms.TextBox()
        Me.TBLow = New System.Windows.Forms.TextBox()
        Me.CBCost = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DPHigh = New System.Windows.Forms.DateTimePicker()
        Me.DPLow = New System.Windows.Forms.DateTimePicker()
        Me.CBDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboDepartment = New System.Windows.Forms.ComboBox()
        Me.CBDepartment = New System.Windows.Forms.CheckBox()
        Me.CBDepartmentAM = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboShopOrder = New System.Windows.Forms.ComboBox()
        Me.CBShopOrderAM = New System.Windows.Forms.CheckBox()
        Me.CBShopOrder = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBToolAM = New System.Windows.Forms.CheckBox()
        Me.ComboTool = New System.Windows.Forms.ComboBox()
        Me.CBTool = New System.Windows.Forms.CheckBox()
        Me.GBQuantity = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUDHigh = New System.Windows.Forms.NumericUpDown()
        Me.NUDLow = New System.Windows.Forms.NumericUpDown()
        Me.CBQuantity = New System.Windows.Forms.CheckBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BTNFilter = New System.Windows.Forms.Button()
        Me.LBLCost = New System.Windows.Forms.Label()
        Me.ToolRoomInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet1 = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.SignedOutCuttersTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.SignedOutCuttersTableAdapter()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.LBLCount = New System.Windows.Forms.Label()
        Me.BTNPrint = New System.Windows.Forms.Button()
        Me.PBPrint = New System.Windows.Forms.ProgressBar()
        Me.SFDPrint = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvSignedOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignedOutCuttersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFilter.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBQuantity.SuspendLayout()
        CType(Me.NUDHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolRoomInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSignedOut
        '
        Me.dgvSignedOut.AllowUserToAddRows = False
        Me.dgvSignedOut.AllowUserToDeleteRows = False
        Me.dgvSignedOut.AutoGenerateColumns = False
        Me.dgvSignedOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSignedOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSignedOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuantityDataGridViewTextBoxColumn, Me.ToolDataGridViewTextBoxColumn, Me.ShopOrderDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.dgvSignedOut.DataSource = Me.SignedOutCuttersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "G"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSignedOut.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSignedOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSignedOut.Location = New System.Drawing.Point(12, 12)
        Me.dgvSignedOut.MultiSelect = False
        Me.dgvSignedOut.Name = "dgvSignedOut"
        Me.dgvSignedOut.RowHeadersVisible = False
        Me.dgvSignedOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSignedOut.Size = New System.Drawing.Size(1124, 485)
        Me.dgvSignedOut.TabIndex = 1
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
        DataGridViewCellStyle1.Format = "G"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.DateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
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
        'GBFilter
        '
        Me.GBFilter.Controls.Add(Me.GroupBox5)
        Me.GBFilter.Controls.Add(Me.GroupBox4)
        Me.GBFilter.Controls.Add(Me.GroupBox3)
        Me.GBFilter.Controls.Add(Me.GroupBox2)
        Me.GBFilter.Controls.Add(Me.GroupBox1)
        Me.GBFilter.Controls.Add(Me.GBQuantity)
        Me.GBFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFilter.Location = New System.Drawing.Point(12, 503)
        Me.GBFilter.Name = "GBFilter"
        Me.GBFilter.Size = New System.Drawing.Size(1124, 213)
        Me.GBFilter.TabIndex = 2
        Me.GBFilter.TabStop = False
        Me.GBFilter.Text = "Filter By..."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TBHigh)
        Me.GroupBox5.Controls.Add(Me.TBLow)
        Me.GroupBox5.Controls.Add(Me.CBCost)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(984, 25)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(128, 178)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "And..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Between..."
        '
        'TBHigh
        '
        Me.TBHigh.Location = New System.Drawing.Point(9, 105)
        Me.TBHigh.Name = "TBHigh"
        Me.TBHigh.Size = New System.Drawing.Size(100, 20)
        Me.TBHigh.TabIndex = 5
        Me.TBHigh.Text = "00.00"
        '
        'TBLow
        '
        Me.TBLow.Location = New System.Drawing.Point(9, 62)
        Me.TBLow.Name = "TBLow"
        Me.TBLow.Size = New System.Drawing.Size(100, 20)
        Me.TBLow.TabIndex = 4
        Me.TBLow.Text = "00.00"
        '
        'CBCost
        '
        Me.CBCost.AutoSize = True
        Me.CBCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCost.Location = New System.Drawing.Point(6, 19)
        Me.CBCost.Name = "CBCost"
        Me.CBCost.Size = New System.Drawing.Size(47, 17)
        Me.CBCost.TabIndex = 3
        Me.CBCost.Text = "Cost"
        Me.CBCost.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DPHigh)
        Me.GroupBox4.Controls.Add(Me.DPLow)
        Me.GroupBox4.Controls.Add(Me.CBDate)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(822, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 178)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "And..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Between..."
        '
        'DPHigh
        '
        Me.DPHigh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPHigh.Location = New System.Drawing.Point(9, 105)
        Me.DPHigh.Name = "DPHigh"
        Me.DPHigh.Size = New System.Drawing.Size(141, 20)
        Me.DPHigh.TabIndex = 6
        Me.DPHigh.Value = New Date(2018, 2, 1, 0, 0, 0, 0)
        '
        'DPLow
        '
        Me.DPLow.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPLow.Location = New System.Drawing.Point(9, 62)
        Me.DPLow.Name = "DPLow"
        Me.DPLow.Size = New System.Drawing.Size(141, 20)
        Me.DPLow.TabIndex = 5
        Me.DPLow.Value = New Date(2018, 2, 1, 0, 0, 0, 0)
        '
        'CBDate
        '
        Me.CBDate.AutoSize = True
        Me.CBDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDate.Location = New System.Drawing.Point(6, 19)
        Me.CBDate.Name = "CBDate"
        Me.CBDate.Size = New System.Drawing.Size(49, 17)
        Me.CBDate.TabIndex = 4
        Me.CBDate.Text = "Date"
        Me.CBDate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboDepartment)
        Me.GroupBox3.Controls.Add(Me.CBDepartment)
        Me.GroupBox3.Controls.Add(Me.CBDepartmentAM)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(620, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 178)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'ComboDepartment
        '
        Me.ComboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboDepartment.FormattingEnabled = True
        Me.ComboDepartment.Location = New System.Drawing.Point(6, 55)
        Me.ComboDepartment.Name = "ComboDepartment"
        Me.ComboDepartment.Size = New System.Drawing.Size(180, 21)
        Me.ComboDepartment.TabIndex = 3
        '
        'CBDepartment
        '
        Me.CBDepartment.AutoSize = True
        Me.CBDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDepartment.Location = New System.Drawing.Point(6, 19)
        Me.CBDepartment.Name = "CBDepartment"
        Me.CBDepartment.Size = New System.Drawing.Size(81, 17)
        Me.CBDepartment.TabIndex = 2
        Me.CBDepartment.Text = "Department"
        Me.CBDepartment.UseVisualStyleBackColor = True
        '
        'CBDepartmentAM
        '
        Me.CBDepartmentAM.AutoSize = True
        Me.CBDepartmentAM.Location = New System.Drawing.Point(6, 84)
        Me.CBDepartmentAM.Name = "CBDepartmentAM"
        Me.CBDepartmentAM.Size = New System.Drawing.Size(117, 17)
        Me.CBDepartmentAM.TabIndex = 3
        Me.CBDepartmentAM.Text = "Approximate Match"
        Me.CBDepartmentAM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboShopOrder)
        Me.GroupBox2.Controls.Add(Me.CBShopOrderAM)
        Me.GroupBox2.Controls.Add(Me.CBShopOrder)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(395, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 178)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'ComboShopOrder
        '
        Me.ComboShopOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboShopOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboShopOrder.FormattingEnabled = True
        Me.ComboShopOrder.Location = New System.Drawing.Point(6, 55)
        Me.ComboShopOrder.Name = "ComboShopOrder"
        Me.ComboShopOrder.Size = New System.Drawing.Size(207, 21)
        Me.ComboShopOrder.TabIndex = 6
        '
        'CBShopOrderAM
        '
        Me.CBShopOrderAM.AutoSize = True
        Me.CBShopOrderAM.Location = New System.Drawing.Point(6, 84)
        Me.CBShopOrderAM.Name = "CBShopOrderAM"
        Me.CBShopOrderAM.Size = New System.Drawing.Size(117, 17)
        Me.CBShopOrderAM.TabIndex = 3
        Me.CBShopOrderAM.Text = "Approximate Match"
        Me.CBShopOrderAM.UseVisualStyleBackColor = True
        '
        'CBShopOrder
        '
        Me.CBShopOrder.AutoSize = True
        Me.CBShopOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBShopOrder.Location = New System.Drawing.Point(6, 19)
        Me.CBShopOrder.Name = "CBShopOrder"
        Me.CBShopOrder.Size = New System.Drawing.Size(80, 17)
        Me.CBShopOrder.TabIndex = 5
        Me.CBShopOrder.Text = "Shop Order"
        Me.CBShopOrder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBToolAM)
        Me.GroupBox1.Controls.Add(Me.ComboTool)
        Me.GroupBox1.Controls.Add(Me.CBTool)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(168, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 178)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'CBToolAM
        '
        Me.CBToolAM.AutoSize = True
        Me.CBToolAM.Location = New System.Drawing.Point(6, 84)
        Me.CBToolAM.Name = "CBToolAM"
        Me.CBToolAM.Size = New System.Drawing.Size(117, 17)
        Me.CBToolAM.TabIndex = 3
        Me.CBToolAM.Text = "Approximate Match"
        Me.CBToolAM.UseVisualStyleBackColor = True
        '
        'ComboTool
        '
        Me.ComboTool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboTool.FormattingEnabled = True
        Me.ComboTool.Location = New System.Drawing.Point(6, 55)
        Me.ComboTool.Name = "ComboTool"
        Me.ComboTool.Size = New System.Drawing.Size(209, 21)
        Me.ComboTool.TabIndex = 2
        '
        'CBTool
        '
        Me.CBTool.AutoSize = True
        Me.CBTool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTool.Location = New System.Drawing.Point(6, 19)
        Me.CBTool.Name = "CBTool"
        Me.CBTool.Size = New System.Drawing.Size(47, 17)
        Me.CBTool.TabIndex = 1
        Me.CBTool.Text = "Tool"
        Me.CBTool.UseVisualStyleBackColor = True
        '
        'GBQuantity
        '
        Me.GBQuantity.Controls.Add(Me.Label6)
        Me.GBQuantity.Controls.Add(Me.Label5)
        Me.GBQuantity.Controls.Add(Me.NUDHigh)
        Me.GBQuantity.Controls.Add(Me.NUDLow)
        Me.GBQuantity.Controls.Add(Me.CBQuantity)
        Me.GBQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBQuantity.Location = New System.Drawing.Point(6, 25)
        Me.GBQuantity.Name = "GBQuantity"
        Me.GBQuantity.Size = New System.Drawing.Size(156, 178)
        Me.GBQuantity.TabIndex = 6
        Me.GBQuantity.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "And..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Between..."
        '
        'NUDHigh
        '
        Me.NUDHigh.Location = New System.Drawing.Point(6, 105)
        Me.NUDHigh.Name = "NUDHigh"
        Me.NUDHigh.Size = New System.Drawing.Size(120, 20)
        Me.NUDHigh.TabIndex = 2
        '
        'NUDLow
        '
        Me.NUDLow.Location = New System.Drawing.Point(6, 62)
        Me.NUDLow.Name = "NUDLow"
        Me.NUDLow.Size = New System.Drawing.Size(120, 20)
        Me.NUDLow.TabIndex = 1
        Me.NUDLow.ThousandsSeparator = True
        '
        'CBQuantity
        '
        Me.CBQuantity.AutoSize = True
        Me.CBQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBQuantity.Location = New System.Drawing.Point(6, 19)
        Me.CBQuantity.Name = "CBQuantity"
        Me.CBQuantity.Size = New System.Drawing.Size(65, 17)
        Me.CBQuantity.TabIndex = 0
        Me.CBQuantity.Text = "Quantity"
        Me.CBQuantity.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(1060, 719)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BTNFilter
        '
        Me.BTNFilter.Location = New System.Drawing.Point(817, 719)
        Me.BTNFilter.Name = "BTNFilter"
        Me.BTNFilter.Size = New System.Drawing.Size(75, 23)
        Me.BTNFilter.TabIndex = 4
        Me.BTNFilter.Text = "&Filter"
        Me.BTNFilter.UseVisualStyleBackColor = True
        '
        'LBLCost
        '
        Me.LBLCost.AutoSize = True
        Me.LBLCost.Location = New System.Drawing.Point(12, 719)
        Me.LBLCost.Name = "LBLCost"
        Me.LBLCost.Size = New System.Drawing.Size(114, 13)
        Me.LBLCost.TabIndex = 5
        Me.LBLCost.Text = "Selection Cost: $00.00"
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
        'SignedOutCuttersTableAdapter
        '
        Me.SignedOutCuttersTableAdapter.ClearBeforeFill = True
        '
        'BTNClear
        '
        Me.BTNClear.Location = New System.Drawing.Point(898, 719)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(75, 23)
        Me.BTNClear.TabIndex = 6
        Me.BTNClear.Text = "&Reset"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'LBLCount
        '
        Me.LBLCount.AutoSize = True
        Me.LBLCount.Location = New System.Drawing.Point(12, 735)
        Me.LBLCount.Name = "LBLCount"
        Me.LBLCount.Size = New System.Drawing.Size(378, 13)
        Me.LBLCount.TabIndex = 7
        Me.LBLCount.Text = "Selected Tool Count: ## Unique Entries, ## Total Tools, ## Discounted Tools"
        '
        'BTNPrint
        '
        Me.BTNPrint.Location = New System.Drawing.Point(979, 719)
        Me.BTNPrint.Name = "BTNPrint"
        Me.BTNPrint.Size = New System.Drawing.Size(75, 24)
        Me.BTNPrint.TabIndex = 8
        Me.BTNPrint.Text = "&Print"
        Me.BTNPrint.UseVisualStyleBackColor = True
        '
        'PBPrint
        '
        Me.PBPrint.Location = New System.Drawing.Point(612, 719)
        Me.PBPrint.MarqueeAnimationSpeed = 1
        Me.PBPrint.Name = "PBPrint"
        Me.PBPrint.Size = New System.Drawing.Size(199, 23)
        Me.PBPrint.Step = 1
        Me.PBPrint.TabIndex = 9
        '
        'SFDPrint
        '
        Me.SFDPrint.DefaultExt = "xlsx"
        Me.SFDPrint.InitialDirectory = "H:\"
        '
        'Filtering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 754)
        Me.Controls.Add(Me.PBPrint)
        Me.Controls.Add(Me.BTNPrint)
        Me.Controls.Add(Me.LBLCount)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.LBLCost)
        Me.Controls.Add(Me.BTNFilter)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GBFilter)
        Me.Controls.Add(Me.dgvSignedOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Filtering"
        Me.Text = "Filter..."
        CType(Me.dgvSignedOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignedOutCuttersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFilter.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBQuantity.ResumeLayout(False)
        Me.GBQuantity.PerformLayout()
        CType(Me.NUDHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolRoomInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSignedOut As DataGridView
    Friend WithEvents GBFilter As GroupBox
    Friend WithEvents CBShopOrder As CheckBox
    Friend WithEvents CBDate As CheckBox
    Friend WithEvents CBCost As CheckBox
    Friend WithEvents CBDepartment As CheckBox
    Friend WithEvents CBTool As CheckBox
    Friend WithEvents CBQuantity As CheckBox
    Friend WithEvents GBQuantity As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBHigh As TextBox
    Friend WithEvents TBLow As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DPHigh As DateTimePicker
    Friend WithEvents DPLow As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboDepartment As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboShopOrder As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboTool As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NUDHigh As NumericUpDown
    Friend WithEvents NUDLow As NumericUpDown
    Friend WithEvents BtnClose As Button
    Friend WithEvents BTNFilter As Button
    Friend WithEvents ToolRoomInventoryBindingSource As BindingSource
    Friend WithEvents Tool_Cutter_DatabaseDataSet1 As Tool_Cutter_DatabaseDataSet
    Friend WithEvents SignedOutCuttersBindingSource As BindingSource
    Friend WithEvents Tool_Cutter_DatabaseDataSet As Tool_Cutter_DatabaseDataSet
    Friend WithEvents SignedOutCuttersTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.SignedOutCuttersTableAdapter
    Friend WithEvents LBLCost As Label
    Friend WithEvents CBDepartmentAM As CheckBox
    Friend WithEvents CBShopOrderAM As CheckBox
    Friend WithEvents CBToolAM As CheckBox
    Friend WithEvents BTNClear As Button
    Friend WithEvents LBLCount As Label
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShopOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BTNPrint As Button
    Friend WithEvents PBPrint As ProgressBar
    Friend WithEvents SFDPrint As SaveFileDialog
End Class
