﻿'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
'See StriteInventoryManagement.vb for header
'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Imports System.Linq
Public Class Monitoring
    Dim usercellsignedout As Point
    Dim usercellorders As Point
    Dim usercellinventory As Point
    Dim n As Integer
    Dim inventoryflag As Boolean
    Dim orderflag As Boolean
    Dim signedoutflag As Boolean
    Private Sub Monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet1.ToolRoomInventory' table. You can move, or remove it, as needed.
        ToolRoomInventoryTableAdapter.Fill(Tool_Cutter_DatabaseDataSet1.ToolRoomInventory)

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.CutterOrders' table. You can move, or remove it, as needed.
        CutterOrdersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.CutterOrders)
        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.Users' table. You can move, or remove it, as needed.
        UsersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.Users)

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.SignedOutCutters' table. You can move, or remove it, as needed.
        SignedOutCuttersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.SignedOutCutters)


        CBSearch.Items.Add("All")
        CBSearch.Items.Add("Inventory")
        CBSearch.Items.Add("Orders")
        CBSearch.Items.Add("Signed Out Cutters")
        CBSearch.Text = "All"
        tmrRefresh.Start()
        lblbInventoryValue.Text = "Current Tool Inventory Value: $" & ToolRoomInventoryTableAdapter.ToolRoomValue.ToString
        lblSignedOutValue.Text = "Current Signed Out Tool Value: $" & SignedOutCuttersTableAdapter.SignedOutToolValue.ToString
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
                'MsgBox(Convert.ToString(ex),vbcritical)
            End Try
        End If

        'if the datagridview (Inventory) rows does not equal zero then set the current cell to the cell saved earlier before the update. This maintains the position of the selected cell after the update.
        If dgvInventory.Rows.Count <> 0 Then
            Try
                dgvInventory.CurrentCell = dgvInventory.Rows(usercellinventory.Y).Cells(usercellinventory.X)
            Catch ex As Exception
                'MsgBox(Convert.ToString(ex),vbcritical)
            End Try
        End If

        'Update is complete so set the updaterequired flag to false
        UpdateRequired = False
        lblbInventoryValue.Text = "Current Tool Inventory Value: $" & ToolRoomInventoryTableAdapter.ToolRoomValue.ToString
        lblSignedOutValue.Text = "Current Signed Out Tool Value: $" & SignedOutCuttersTableAdapter.SignedOutToolValue.ToString
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Dim name As String() = {"N", "I", "C", "K", "I", "S", "C", "O", "O", "L"}

        ' Dim i As Integer = 1
        'this do loop plays a series of 20 scaling notes before running the rest of the code because I wanted to see if I could do it. I could so im keeping it.
        ' Do
        'Console.Beep(i * 100, 100)
        ' Try
        'MsgBox(name(i - 1), vbOKOnly)
        'Catch ex As Exception

        'End Try

        'Console.Beep(i * 50, 100)
        'i = i + 1
        'Loop Until i = 11

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

    Private Sub TBSearch_GotFocus(sender As Object, e As EventArgs) Handles TBSearch.GotFocus
        'define two lists to hold duplicate values
        Dim distinct As New List(Of String)
        Dim duplicates As New List(Of String)
        inventoryflag = True
        orderflag = True
        signedoutflag = True

        'use select case to determine which option is selected in the combo box
        Select Case CBSearch.Text
            'if "All" is selected then search through all the dgv's and find the specified tool
            Case "All"
                'check to see if any of the dgv's are empty
                If dgvInventory.Rows.Count = 0 Then
                    inventoryflag = False
                ElseIf dgvOrders.Rows.Count = 0 Then
                    orderflag = False
                ElseIf dgvSignedOut.Rows.Count = 0 Then
                    signedoutflag = False
                End If

                If dgvInventory.Rows.Count <> 0 Then
                    'dim a new specialized array in order to contain all strings used for the autocomplete function of the textbox
                    Dim Tools As New AutoCompleteStringCollection
                    Dim i As Integer = 0

                    'clear the autocomplete array before populating as to not just append values each time
                    TBSearch.AutoCompleteCustomSource.Clear()

                    'use a loop run as many times as there are rows in the datagridview
                    Do
                        If inventoryflag = True Then
                            Tools.Add(dgvInventory(1, i).Value)
                        ElseIf orderflag = True Then
                            Tools.Add(dgvOrders(1, i).Value)
                        ElseIf signedoutflag = True Then
                            Tools.Add(dgvSignedOut(1, i).Value)
                        End If
                        i = i + 1
                    Loop Until i = dgvInventory.RowCount

                    For n As Integer = 0 To Tools.Count - 1
                        'if distinct doesn't contain number(i), means this number isn't duplicated SO FAR
                        If Not distinct.Contains(Tools(n)) Then
                            distinct.Add(Tools(n))
                            'else, means distinct already contains the number, means this numbers(i) is a DUPLICATE
                            'if the number hasn't been added to duplicates, add it
                        ElseIf Not duplicates.Contains(Tools(n)) Then
                            duplicates.Add(Tools(n))
                        End If
                    Next

                    'set the autocompletesource to the tools array
                    TBSearch.AutoCompleteCustomSource = Tools
                End If
            Case "Orders"
                Populateautocomplete(TBSearch, dgvOrders)
            Case "Inventory"
                Populateautocomplete(TBSearch, dgvInventory)
            Case "Signed Out Cutters"
                Populateautocomplete(TBSearch, dgvSignedOut)
        End Select

    End Sub
    Public Sub Populateautocomplete(ByRef tb As TextBox, ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            'dim a new specialized array in order to contain all strings used for the autocomplete function of the textbox
            Dim Tools As New AutoCompleteStringCollection
            Dim i As Integer = 0

            'clear the autocomplete array before populating as to not just append values each time
            tb.AutoCompleteCustomSource.Clear()

            'use a loop run as many times as there are rows in the datagridview
            Do

                'add a new entry to the array using the current row of the datagridview. The row is changed each time the loop is looped using the "i" variable
                Tools.Add(dgv(1, i).Value)
                i = i + 1
            Loop Until i = dgv.RowCount

            'set the autocompletesource to the tools array
            tb.AutoCompleteCustomSource = Tools
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        'when the search button is clicked check to see which combobox option is selected
        'call either the searchall or searchinventory subs in order to search the respective dgv(s)
        Select Case CBSearch.Text
            Case "All"
                Searchall(TBSearch)
            Case "Inventory"
                SearchInventory(dgvInventory, TBSearch)
            Case "Orders"
                SearchInventory(dgvOrders, TBSearch)
            Case "Signed Out Cutters"
                SearchInventory(dgvSignedOut, TBSearch)
        End Select
    End Sub

    Public Sub Searchall(ByRef tb As TextBox)
        'this sub works similarly to the searchinventory sub but instead searches all the dgv's
        Dim tool As String
        Dim toolfound As Boolean = False
        Dim i As Integer = 0
        inventoryflag = True
        orderflag = True
        signedoutflag = True

        'checks to see if any of the dgv's are empty
        If dgvInventory.Rows.Count = 0 Then
            inventoryflag = False
        ElseIf dgvOrders.Rows.Count = 0 Then
            orderflag = False
        ElseIf dgvSignedOut.Rows.Count = 0 Then
            signedoutflag = False
        End If


        'checks if the textbox is blank and informs user that the textbox cannot be blank. if it is not blank then set the tool variable to the textbox text
        If tb.Text = "" Then
            MsgBox("The search textbox cannot be blank. Please enter a tool name to search.", vbCritical, "Error")
            Exit Sub
        Else
            tool = tb.Text
        End If

        'use do loop to check each record and compare the tool name to the tool variable
        Do
            If inventoryflag = True Then
                If tool = dgvInventory(1, i).Value Then
                    dgvInventory(1, i).Selected = True
                    toolfound = True
                End If
            End If
            i = i + 1
        Loop Until i = dgvInventory.RowCount

        i = 0
        Do
            If orderflag = True Then
                If tool = dgvOrders(1, i).Value Then
                    dgvOrders(1, i).Selected = True
                    toolfound = True
                End If
            End If

            i = i + 1
        Loop Until i = dgvOrders.RowCount

        i = 0
        Do
            If signedoutflag = True Then
                If tool = dgvSignedOut(1, i).Value Then
                    dgvSignedOut(1, i).Selected = True
                    toolfound = True
                End If
            End If

            i = i + 1
        Loop Until i = dgvSignedOut.RowCount

        'if the toolfound flag is false then the tool was not found in the list. the user is informed of this.
        If toolfound = False Then
            MsgBox("Tool was not found.", vbCritical, "Tool Not found!")
        End If

    End Sub

    Private Sub BTNDevOptions_Click(sender As Object, e As EventArgs) Handles BTNDevOptions.Click
        MsgBox("Do not modify the following settings unless you absolutely know what you are doing!", vbExclamation, "Warning!")
        DevOptions.Show()
    End Sub
End Class