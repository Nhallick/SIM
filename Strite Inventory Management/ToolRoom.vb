'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
'See StriteInventoryManagement.vb for header
'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class ToolRoom
    Dim dbconn As New OleDbConnection
    Dim Dset As New DataSet
    Dim Dtable As New DataTable
    Dim Dtable2 As DataTable
    Dim Dadapter As New OleDbDataAdapter
    Private Sub ToolRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.CutterOrders' table. You can move, or remove it, as needed.
        CutterOrdersTableAdapter.FillSubmittedCutters(Tool_Cutter_DatabaseDataSet.CutterOrders)
        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet2.ToolRoomInventory' table. You can move, or remove it, as needed.
        ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet2.ToolRoomInventory)
        btnNew.Hide()
        TMRRefresh.Start()
    End Sub

    Private Sub ToolRoom_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'When toolroom window is closed set the users interface to main window
        DGVUserStatusandInterface("ONLINE", "MAIN WINDOW")

        'show main window
        StriteInventoryManagement.Show()
    End Sub

    Private Sub TMRRefresh_Tick(sender As Object, e As EventArgs) Handles TMRRefresh.Tick


        Dim usercellinventory As Point
        usercellinventory = DGVInventory.CurrentCellAddress


        'declare variable to store number indicating current number of orders. fill with number of rows in the datagridview
        Dim currentorders As Integer = DGVSubOrders.RowCount
        Dim i As Integer = 0

        'Run a query through the cutterorderstableadapter to check the number of orders in the database. If that number is greater than what is currently in the datagridview update the records in the datagridview
        If CutterOrdersTableAdapter.CountSubmissions <> currentorders Then
            CutterOrdersTableAdapter.FillSubmittedCutters(Tool_Cutter_DatabaseDataSet.CutterOrders)
        End If

        If Environment.UserName = "cringler" Then
            'count the number of tools that have quantities lower than their minimum bin size with GetLowTools()
            If ToolRoomInventoryTableAdapter.GetLowTools().Count > 0 Then

                'keep running this code until there are no more "Low" tools left
                Do Until ToolRoomInventoryTableAdapter.GetLowTools.Count = 0

                    'use the first item of the GetLowTools() collection to fill these variables. At the end of this code block the current item will be removed from the collection. At the start of the loop each time there will be a different item
                    Dim QtyToMake As Integer = (ToolRoomInventoryTableAdapter.GetLowTools(0).Max_Bin_Size - ToolRoomInventoryTableAdapter.GetLowTools(0).Quantity)
                    Dim toolname As String = ToolRoomInventoryTableAdapter.GetLowTools(0).Tool
                    Dim DateSubmitted As String = Date.Now
                    Dim Approval As String = "Awaiting Submittal"

                    Dim count As String = "SELECT Count (*) AS Expr1, [Tool Name], Approval FROM CutterOrders GROUP BY [Tool Name], Approval HAVING ([Tool Name] = '" & toolname & "') AND (Approval = ""Awaiting Submittal"")"
                    Dim countresult As Integer
                    Dim cb2 As New OleDbCommand(count, dbconn)
                    dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Tool & Cutter Grinding\Tool Cutter Database.accdb;Persist Security Info = False"
                    dbconn.Open()
                    'use execute scalar command when using a COUNT command
                    countresult = cb2.ExecuteScalar
                    dbconn.Close()

                    If countresult = 0 Then
                        'insert new order into the [cutterorders] table
                        Dim str As String = "INSERT INTO [CutterOrders] ([QtyToMake], [Tool Name], [Date Submitted], [Approval]) VALUES (" & QtyToMake & ", '" & toolname & "', '" & DateSubmitted & "', '" & Approval & "')"
                        dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Tool & Cutter Grinding\Tool Cutter Database.accdb;Persist Security Info = False"
                        Try
                            dbconn.Open()
                        Catch ex As Exception
                            'MsgBox(Convert.ToString(ex),vbcritical,"Error")
                        End Try
                        Try
                            Dset.Tables.Add(Dtable)
                        Catch ex As Exception
                            'MsgBox(Convert.ToString(ex),vbcritical,"Error")
                        End Try
                        Dadapter = New OleDbDataAdapter(str, dbconn)
                        Dim cb = New OleDbCommandBuilder(Dadapter) With {
                            .QuotePrefix = "[",
                            .QuoteSuffix = "]"
                        }

                        Try
                            Dadapter.Fill(Dtable)
                        Catch ex As Exception
                            ' MsgBox(Convert.ToString(ex),vbcritical,"Error")
                        End Try

                        'update inventory listing to show there is an order currently placed
                        Dim str2 As String = "UPDATE [ToolRoomInventory] set [Order Placed]= ""Y"" WHERE [Tool] = '" & toolname & "'"
                        Dadapter = New OleDbDataAdapter(str2, dbconn)
                        cb = New OleDbCommandBuilder(Dadapter)
                        Dadapter.Fill(Dtable)
                        dbconn.Close()
                    ElseIf countresult > 0 Then
                        Dim dateupdated As String
                        dateupdated = Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
                        Dim update As String = "UPDATE [CutterOrders] set [QtyToMake] ='" & QtyToMake & "' + [QtyToMake] ,[Date Submitted] = '" & dateupdated & "' WHERE ([Tool Name] = '" & toolname & "') AND ([Approval] = ""Awaiting Submittal"")"
                        Try
                            dbconn.Open()
                        Catch ex As Exception
                            MsgBox(Convert.ToString(ex), vbCritical, "Error")
                        End Try
                        Try
                            Dset.Tables.Add(Dtable)
                        Catch ex As Exception
                            'MsgBox(Convert.ToString(ex),vbcritical,"Error")
                        End Try
                        Dadapter = New OleDbDataAdapter(update, dbconn)
                        Dim cb = New OleDbCommandBuilder(Dadapter) With {
                            .QuotePrefix = "[",
                            .QuoteSuffix = "]"
                        }
                        Try
                            Dadapter.Fill(Dtable)
                        Catch ex As Exception
                            MsgBox(Convert.ToString(ex), vbCritical, "Error")
                        End Try
                        Dim str2 As String = "UPDATE [ToolRoomInventory] set [Order Placed]= ""Y"" WHERE [Tool] = '" & toolname & "'"
                        Dadapter = New OleDbDataAdapter(str2, dbconn)
                        cb = New OleDbCommandBuilder(Dadapter)
                        Dadapter.Fill(Dtable)
                        dbconn.Close()
                        dbconn.Close()
                    End If



                    'refresh inventory datagridview
                    ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet2.ToolRoomInventory)
                Loop
            End If
        End If

        'run through each item in the inventory datagridview and if the "Order placed" column reads "Y" change the colour to yellow. If it reads "N" change the colour to white.
        i = 0
        For Each item In DGVInventory.Rows
            If DGVInventory(4, i).Value = "Y" Then
                DGVInventory(4, i).Style.BackColor = Color.Yellow
            ElseIf DGVInventory(4, i).Value = "N" Then
                DGVInventory(4, i).Style.BackColor = Color.White
            End If
            i = i + 1
        Next

        'updates the label text to reflect the current number of orders (useful when number of orders reaches higher numbers)
        GBSubmittedOrders.Text = "Submitted Orders " & "(" & currentorders & ")"

        'updates the label text to reflect the current number of tools in inventory (useful when number of tools reaches higher numbers)
        GBInventory.Text = "Inventory " & "(" & DGVInventory.RowCount & ")"

        If DGVInventory.Rows.Count <> 0 Then
            DGVInventory.CurrentCell = DGVInventory.Rows(usercellinventory.Y).Cells(usercellinventory.X)
        End If

        If TBSearch.Text = "StriteNewTool" Then
            btnNew.Show()
        Else
            btnNew.Hide()
        End If
    End Sub

    Private Sub BTNAccept_Click(sender As Object, e As EventArgs) Handles BTNAccept.Click
        Dim usercellorders As Point
        usercellorders = DGVSubOrders.CurrentCellAddress

        'When the Accept button is pushed the currently selected order is processed into the inventory according to the "ToolRoomAcceptReject" sub
        ToolRoomAcceptReject("Approved", DGVSubOrders)

        'refresh the orders datagridview with all submitted orders
        CutterOrdersTableAdapter.FillSubmittedCutters(Tool_Cutter_DatabaseDataSet.CutterOrders)

        'refreshes the inventory datagridview with all inventory items
        ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet2.ToolRoomInventory)

        If DGVSubOrders.Rows.Count > 0 Then
            Try
                DGVSubOrders.CurrentCell = DGVSubOrders.Rows(usercellorders.Y).Cells(usercellorders.X)
            Catch ex As Exception
                'MsgBox(Convert.ToString(ex),vbcritical,"Error")
            End Try

        End If

        UpdateRequired = True
    End Sub

    Private Sub BTNReject_Click(sender As Object, e As EventArgs) Handles BTNReject.Click
        'when the reject button is pushed the currently selected order is processed according to the "toolRoomAcceptReject" sub (in this case it is put into a sort of limbo and no longer shows up in this program anymore. The order is kept in the database for future review)
        ToolRoomAcceptReject("Rejected", DGVSubOrders)

        'update the orders datagridview with all submitted orders
        CutterOrdersTableAdapter.FillSubmittedCutters(Tool_Cutter_DatabaseDataSet.CutterOrders)
    End Sub

    Private Sub BTNSignOut_Click(sender As Object, e As EventArgs) Handles BTNSignOut.Click
        If Environment.UserName = "cringler" Then
            Dim usercellinventory As Point
            usercellinventory = DGVInventory.CurrentCellAddress

            'When the sign out button is pushed the signouttool sub is run and the user is prompted to enter information in order to sign out the tool from inventory
            SignOutTool(DGVInventory)

            'refresh the inventory datagridview with current information
            ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet2.ToolRoomInventory)

            DGVInventory.CurrentCell = DGVInventory.Rows(usercellinventory.Y).Cells(usercellinventory.X)
            UpdateRequired = True
        End If

    End Sub

    Private Sub BTNEdit_Click(sender As Object, e As EventArgs) Handles BTNEdit.Click
        Dim usercellinventory As Point
        usercellinventory = DGVInventory.CurrentCellAddress

        'when the edit button is pushed the inventoryedit sub is called and the user is prompted to enter the relevant information
        InventoryEdit(DGVInventory)

        'refresh the inventory datagridview with current information
        ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet2.ToolRoomInventory)

        DGVInventory.CurrentCell = DGVInventory.Rows(usercellinventory.Y).Cells(usercellinventory.X)

        UpdateRequired = True
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click

        'when the search button is pushed the searchinventory sub is called
        SearchInventory(DGVInventory, TBSearch)
    End Sub

    Private Sub TBSearch_GotFocus(sender As Object, e As EventArgs) Handles TBSearch.GotFocus
        'this sub is invoked when the user activates the search text box
        If DGVInventory.Rows.Count <> 0 Then
            'dim a new specialized array in order to contain all strings used for the auto-complete function of the text box
            Dim Tools As New AutoCompleteStringCollection
            Dim i As Integer = 0

            'clear the auto-complete array before populating as to not just append values each time
            TBSearch.AutoCompleteCustomSource.Clear()

            'use a loop run as many times as there are rows in the datagridview
            Do

                'add a new entry to the array using the current row of the datagridview. The row is changed each time the loop is looped using the "i" variable
                Tools.Add(DGVInventory(1, i).Value)
                i = i + 1
            Loop Until i = DGVInventory.RowCount

            'set the autocompletesource to the tools array
            TBSearch.AutoCompleteCustomSource = Tools
        End If

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' if the secret "New" button is clicked then run the NewInventoryItem sub to create a new tool and refresh the dgv
        NewInventoryItem()

        ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet2.ToolRoomInventory)
    End Sub

    Private Sub BtnOrderSearch_Click(sender As Object, e As EventArgs) Handles BtnOrderSearch.Click

        Searchorders(DGVSubOrders, TBOrderSearch)
    End Sub

    Private Sub TBOrderSearch_GotFocus(sender As Object, e As EventArgs) Handles TBOrderSearch.GotFocus
        'this sub is used to populate the auto-complete form of the order search text box
        If DGVSubOrders.Rows.Count <> 0 Then
            Dim Orders As New AutoCompleteStringCollection
            Dim i As Integer = 0

            TBOrderSearch.AutoCompleteCustomSource.Clear()

            Do

                Orders.Add(DGVSubOrders(1, i).Value)
                i = i + 1
            Loop Until i = DGVSubOrders.RowCount

            TBOrderSearch.AutoCompleteCustomSource = Orders
        End If
    End Sub
End Class