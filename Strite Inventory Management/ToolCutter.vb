'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
'See StriteInventoryManagement.vb for header
'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Imports System.ComponentModel

Public Class ToolCutter
    Private Sub ToolCutter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Upon loading of the form start the refresh timer and fill the data grid view with all current outstanding cutter orders
        TMRRefresh.Start()

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.CutterOrders' table. You can move, or remove it, as needed.
        CutterOrdersTableAdapter.FillOrders(Tool_Cutter_DatabaseDataSet.CutterOrders)
    End Sub

    Private Sub ToolCutter_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'Upon closing this form show the main interface selection screen
        DGVUserStatusandInterface("ONLINE", "MAIN WINDOW")
        StriteInventoryManagement.Show()
    End Sub

    Private Sub TMRRefresh_Tick(sender As Object, e As EventArgs) Handles TMRRefresh.Tick

        'declare variable to store number indicating current number of orders. fill with number of rows in the datagridview
        Dim currentorders As Integer = DGVOrders.RowCount

        'Run a query through the cutterorderstableadapter to check the number of orders in the database. If that number is greater than what is currently in the datagridview update the records in the datagridview
        If CutterOrdersTableAdapter.CountOrders <> currentorders Then
            CutterOrdersTableAdapter.FillOrders(Tool_Cutter_DatabaseDataSet.CutterOrders)
        End If

        'updates the label text to reflect the current number of orders (useful when number of orders reaches higher numbers)
        LBLOrders.Text = "Current Orders" & " " & "(" & DGVOrders.RowCount & ")"



    End Sub

    Private Sub BTNSubmit_Click(sender As Object, e As EventArgs) Handles BTNSubmit.Click

        'when the submit button is pushed the currently selected order is processed to the toolroom orders datagridview according to the "ToolCutterSubmit" sub
        ToolCutterSubmit(DGVOrders)

        'refresh the order datagridview with the current orders to make
        CutterOrdersTableAdapter.FillOrders(Tool_Cutter_DatabaseDataSet.CutterOrders)
        UpdateRequired = True
    End Sub

    Private Sub BTNNewCutter_Click(sender As Object, e As EventArgs) Handles BTNNewCutter.Click

        'When the new button is pushed the user is prompted to input relevant data and a new order is created
        NewTool()

        'Refresh the order datagridview with the current orders to make
        CutterOrdersTableAdapter.FillOrders(Tool_Cutter_DatabaseDataSet.CutterOrders)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Searchorders(DGVOrders, tbSearch)
    End Sub

    Private Sub TbSearch_Click(sender As Object, e As EventArgs) Handles tbSearch.Click
        Try
            'this sub is invoked when the user activates the search text box

            'dim a new specialized array in order to contain all strings used for the auto-complete function of the text box
            Dim Tools As New AutoCompleteStringCollection
            Dim i As Integer = 0

            'clear the auto-complete array before populating as to not just append values each time
            tbSearch.AutoCompleteCustomSource.Clear()

            'use a loop run as many times as there are rows in the datagridview
            Do

                'add a new entry to the array using the current row of the datagridview. The row is changed each time the loop is looped using the "i" variable
                Tools.Add(DGVOrders(1, i).Value)
                i = i + 1
            Loop Until i = DGVOrders.RowCount

            'set the autocompletesource to the tools array
            tbSearch.AutoCompleteCustomSource = Tools
        Catch ex As Exception
            'MsgBox(Convert.ToString(ex), vbCritical,"Error")
        End Try

    End Sub
End Class