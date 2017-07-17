<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StriteInventoryManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StriteInventoryManagement))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLUser = New System.Windows.Forms.Label()
        Me.BTNToolCutter = New System.Windows.Forms.Button()
        Me.BTNToolRoom = New System.Windows.Forms.Button()
        Me.DGVUsers = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterfaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool_Cutter_DatabaseDataSet = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSet()
        Me.TMRRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.UsersTableAdapter = New Strite_Inventory_Management.Tool_Cutter_DatabaseDataSetTableAdapters.UsersTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current User:"
        '
        'LBLUser
        '
        Me.LBLUser.AutoSize = True
        Me.LBLUser.Location = New System.Drawing.Point(155, 215)
        Me.LBLUser.Name = "LBLUser"
        Me.LBLUser.Size = New System.Drawing.Size(57, 13)
        Me.LBLUser.TabIndex = 2
        Me.LBLUser.Text = "UserName"
        Me.LBLUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNToolCutter
        '
        Me.BTNToolCutter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNToolCutter.Location = New System.Drawing.Point(15, 231)
        Me.BTNToolCutter.Name = "BTNToolCutter"
        Me.BTNToolCutter.Size = New System.Drawing.Size(197, 78)
        Me.BTNToolCutter.TabIndex = 3
        Me.BTNToolCutter.Text = "Tool Cutter Interface"
        Me.BTNToolCutter.UseVisualStyleBackColor = True
        '
        'BTNToolRoom
        '
        Me.BTNToolRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNToolRoom.Location = New System.Drawing.Point(15, 315)
        Me.BTNToolRoom.Name = "BTNToolRoom"
        Me.BTNToolRoom.Size = New System.Drawing.Size(197, 80)
        Me.BTNToolRoom.TabIndex = 4
        Me.BTNToolRoom.Text = "Tool Room Interface"
        Me.BTNToolRoom.UseVisualStyleBackColor = True
        '
        'DGVUsers
        '
        Me.DGVUsers.AllowUserToAddRows = False
        Me.DGVUsers.AllowUserToDeleteRows = False
        Me.DGVUsers.AutoGenerateColumns = False
        Me.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.InterfaceDataGridViewTextBoxColumn})
        Me.DGVUsers.DataSource = Me.UsersBindingSource
        Me.DGVUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVUsers.Location = New System.Drawing.Point(218, 12)
        Me.DGVUsers.MultiSelect = False
        Me.DGVUsers.Name = "DGVUsers"
        Me.DGVUsers.ReadOnly = True
        Me.DGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVUsers.ShowEditingIcon = False
        Me.DGVUsers.Size = New System.Drawing.Size(428, 383)
        Me.DGVUsers.TabIndex = 5
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InterfaceDataGridViewTextBoxColumn
        '
        Me.InterfaceDataGridViewTextBoxColumn.DataPropertyName = "Interface"
        Me.InterfaceDataGridViewTextBoxColumn.HeaderText = "Interface"
        Me.InterfaceDataGridViewTextBoxColumn.Name = "InterfaceDataGridViewTextBoxColumn"
        Me.InterfaceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Tool_Cutter_DatabaseDataSet
        '
        'Tool_Cutter_DatabaseDataSet
        '
        Me.Tool_Cutter_DatabaseDataSet.DataSetName = "Tool_Cutter_DatabaseDataSet"
        Me.Tool_Cutter_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TMRRefresh
        '
        Me.TMRRefresh.Interval = 1100
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'StriteInventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 410)
        Me.Controls.Add(Me.DGVUsers)
        Me.Controls.Add(Me.BTNToolRoom)
        Me.Controls.Add(Me.BTNToolCutter)
        Me.Controls.Add(Me.LBLUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StriteInventoryManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Strite  Inventory Management"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tool_Cutter_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLUser As Label
    Friend WithEvents BTNToolCutter As Button
    Friend WithEvents BTNToolRoom As Button
    Friend WithEvents DGVUsers As DataGridView
    Friend WithEvents TMRRefresh As Timer
    Friend WithEvents Tool_Cutter_DatabaseDataSet As Tool_Cutter_DatabaseDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As Tool_Cutter_DatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterfaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
