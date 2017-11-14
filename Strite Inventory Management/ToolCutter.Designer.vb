<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToolCutter
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolCutter))
        Me.LBLOrders = New System.Windows.Forms.Label()
        Me.DGVOrders = New System.Windows.Forms.DataGridView()
        Me.QtyToMakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSubmittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CutterOrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tool = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShopOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.BTNNewCutter = New System.Windows.Forms.Button()
        Me.TMRRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.CutterOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CutterOrdersTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.CutterOrdersTableAdapter()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutterOrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutterOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLOrders
        '
        Me.LBLOrders.AutoSize = True
        Me.LBLOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOrders.Location = New System.Drawing.Point(8, 9)
        Me.LBLOrders.Name = "LBLOrders"
        Me.LBLOrders.Size = New System.Drawing.Size(135, 24)
        Me.LBLOrders.TabIndex = 1
        Me.LBLOrders.Text = "Current Orders"
        '
        'DGVOrders
        '
        Me.DGVOrders.AllowUserToAddRows = False
        Me.DGVOrders.AutoGenerateColumns = False
        Me.DGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QtyToMakeDataGridViewTextBoxColumn, Me.ToolNameDataGridViewTextBoxColumn, Me.DateSubmittedDataGridViewTextBoxColumn})
        Me.DGVOrders.DataSource = Me.CutterOrdersBindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Format = "G"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVOrders.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVOrders.Location = New System.Drawing.Point(12, 36)
        Me.DGVOrders.MultiSelect = False
        Me.DGVOrders.Name = "DGVOrders"
        Me.DGVOrders.RowHeadersVisible = False
        Me.DGVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOrders.Size = New System.Drawing.Size(982, 379)
        Me.DGVOrders.TabIndex = 2
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
        'CutterOrdersBindingSource1
        '
        Me.CutterOrdersBindingSource1.DataMember = "CutterOrders"
        Me.CutterOrdersBindingSource1.DataSource = Me.Tool_Cutter_DatabaseDataSet
        '
        'Tool_Cutter_DatabaseDataSet
        '
        Me.Tool_Cutter_DatabaseDataSet.DataSetName = "Tool_Cutter_DatabaseDataSet"
        Me.Tool_Cutter_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'ShopOrder
        '
        Me.ShopOrder.DataPropertyName = "ShopOrder"
        Me.ShopOrder.HeaderText = "ShopOrder"
        Me.ShopOrder.Name = "ShopOrder"
        '
        'Department
        '
        Me.Department.DataPropertyName = "Department"
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tool"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tool"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ShopOrder"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ShopOrder"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Location = New System.Drawing.Point(12, 421)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BTNSubmit.TabIndex = 3
        Me.BTNSubmit.Text = "Submit Order"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'BTNNewCutter
        '
        Me.BTNNewCutter.Location = New System.Drawing.Point(93, 421)
        Me.BTNNewCutter.Name = "BTNNewCutter"
        Me.BTNNewCutter.Size = New System.Drawing.Size(75, 23)
        Me.BTNNewCutter.TabIndex = 4
        Me.BTNNewCutter.Text = "New"
        Me.BTNNewCutter.UseVisualStyleBackColor = True
        '
        'TMRRefresh
        '
        Me.TMRRefresh.Interval = 1300
        '
        'CutterOrdersBindingSource
        '
        Me.CutterOrdersBindingSource.DataMember = "CutterOrders"
        Me.CutterOrdersBindingSource.DataSource = Me.Tool_Cutter_DatabaseDataSet
        '
        'CutterOrdersTableAdapter
        '
        Me.CutterOrdersTableAdapter.ClearBeforeFill = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(770, 421)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbSearch.Location = New System.Drawing.Point(851, 423)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(143, 20)
        Me.tbSearch.TabIndex = 6
        '
        'ToolCutter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 456)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BTNNewCutter)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.DGVOrders)
        Me.Controls.Add(Me.LBLOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ToolCutter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tool Cutter"
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutterOrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutterOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLOrders As Label
    Friend WithEvents DGVOrders As DataGridView
    Friend WithEvents Tool_Cutter_DatabaseDataSet As Tool_Cutter_DatabaseDataSet
    Friend WithEvents CutterOrdersBindingSource As BindingSource
    Friend WithEvents CutterOrdersTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.CutterOrdersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Tool As DataGridViewTextBoxColumn
    Friend WithEvents ShopOrder As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents BTNSubmit As Button
    Friend WithEvents BTNNewCutter As Button
    Friend WithEvents TMRRefresh As Timer
    Friend WithEvents QtyToMakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateSubmittedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CutterOrdersBindingSource1 As BindingSource
    Friend WithEvents BtnSearch As Button
    Friend WithEvents tbSearch As TextBox
End Class
