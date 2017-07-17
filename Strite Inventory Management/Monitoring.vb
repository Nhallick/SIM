'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
'See StriteInventoryManagement.vb for header
'------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Public Class Monitoring
    Dim usercellsignedout As Point
    Dim usercellorders As Point
    Dim usercellinventory As Point
    Private Sub Monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet1.ToolRoomInventory' table. You can move, or remove it, as needed.
        ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet1.ToolRoomInventory)

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.CutterOrders' table. You can move, or remove it, as needed.
        CutterOrdersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.CutterOrders)
        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.Users' table. You can move, or remove it, as needed.
        UsersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.Users)
        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.SignedOutCutters' table. You can move, or remove it, as needed.
        SignedOutCuttersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.SignedOutCutters)
        tmrRefresh.Start()
    End Sub

    Private Sub TmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick

        'DGVUpdate(dgvInventory)
        'refresh user datagridview each timer cycle
        DGVRefresh("Users", dgvUsers)

        usercellsignedout = dgvSignedOut.CurrentCellAddress
        usercellorders = dgvOrders.CurrentCellAddress
        usercellinventory = dgvInventory.CurrentCellAddress

        'refresh the inventory datagridview only if the inventory table record count is different than the datagridview row count
        If (ToolRoomInventoryTableAdapter.CountRecords <> dgvInventory.RowCount) Or (UpdateRequired = True) Then
            ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet1.ToolRoomInventory)
        End If

        'refresh the inventory datagridview only if the signedoutcutters table record count is different than the datagridview row count
        If SignedOutCuttersTableAdapter.CountRecords <> dgvSignedOut.RowCount Then
            SignedOutCuttersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.SignedOutCutters)
        End If

        'refresh the inventory datagridview only if the cutterorders table record count is different than the datagridview row count
        If (CutterOrdersTableAdapter.CountRecords <> dgvOrders.RowCount) Or (UpdateRequired = True) Then
            CutterOrdersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.CutterOrders)
        End If

        'if the datagridview (signed out cutters) rows does not equal zero then set the current cell to the cell saved earlier before the update. This maintains the position of the selected cell after the update.
        If dgvSignedOut.Rows.Count <> 0 Then
            dgvSignedOut.CurrentCell = dgvSignedOut.Rows(usercellsignedout.Y).Cells(usercellsignedout.X)
        End If

        'if the datagridview (Cutter orders) rows does not equal zero then set the current cell to the cell saved earlier before the update. This maintains the position of the selected cell after the update.
        If dgvOrders.Rows.Count <> 0 Then
            Try
                dgvOrders.CurrentCell = dgvOrders.Rows(usercellorders.Y).Cells(usercellorders.X)
            Catch ex As Exception

            End Try
        End If

        'if the datagridview (Inventory) rows does not equal zero then set the current cell to the cell saved earlier before the update. This maintains the position of the selected cell after the update.
        If dgvInventory.Rows.Count <> 0 Then
            Try
                dgvInventory.CurrentCell = dgvInventory.Rows(usercellinventory.Y).Cells(usercellinventory.X)
            Catch ex As Exception

            End Try
        End If

        'Update is complete so set the updaterequired flag to false
        UpdateRequired = False

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Dim i As Integer = 1
        'this do loop plays a series of 20 scaling notes before running the rest of the code because I wanted to see if I could do it. I could so im keeping it.
        Do
            Console.Beep(i * 100, 100)
            Console.Beep(i * 50, 100)
            i = i + 1
        Loop Until i = 10

        'store currently selected rows for later use
        usercellsignedout = dgvSignedOut.CurrentCellAddress
        usercellorders = dgvOrders.CurrentCellAddress
        usercellinventory = dgvInventory.CurrentCellAddress

        'refresh the users datagridview
        DGVRefresh("Users", dgvUsers)

        'update remaining datagridviews
        ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet1.ToolRoomInventory)

        SignedOutCuttersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.SignedOutCutters)

        CutterOrdersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.CutterOrders)

        'compare the datagridview (signed out) rows does not equal zero then assign the current cell to the cell saved earlier. this maintains the position of the selected cell after an update.
        If dgvSignedOut.Rows.Count <> 0 Then
            dgvSignedOut.CurrentCell = dgvSignedOut.Rows(usercellsignedout.Y).Cells(usercellsignedout.X)
        End If
        'compare the datagridview (Cutter Orders) rows does not equal zero then assign the current cell to the cell saved earlier. this maintains the position of the selected cell after an update.
        If dgvOrders.Rows.Count <> 0 Then
            dgvOrders.CurrentCell = dgvOrders.Rows(usercellorders.Y).Cells(usercellorders.X)
        End If
        'compare the datagridview (Inventory) rows does not equal zero then assign the current cell to the cell saved earlier. this maintains the position of the selected cell after an update.
        If dgvInventory.Rows.Count <> 0 Then
            dgvInventory.CurrentCell = dgvInventory.Rows(usercellinventory.Y).Cells(usercellinventory.X)
        End If
    End Sub
End Class