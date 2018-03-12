Imports System.Data.OleDb

Public Class Filtering
    Dim dbconn As New OleDbConnection
    Dim Dset As New DataSet
    Dim Dtable As New DataTable
    Dim Dtable2 As DataTable
    Dim Dadapter As New OleDbDataAdapter

    Private Sub Filtering_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.SignedOutCutters' table. You can move, or remove it, as needed.
        SignedOutCuttersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.SignedOutCutters)

        LBLCost.Text = "Selection Cost: $" & My.Settings.SignedOutVal

        Dim counttotal As Integer = 0
        Dim i As Integer = 0
        Dim discontinued As Integer = 0
        For Each item In dgvSignedOut.Rows
            counttotal += Convert.ToInt16(dgvSignedOut(0, i).Value)
            If dgvSignedOut(0, i).Value = 0 Then
                discontinued += 1
            End If

            i = i + 1
        Next

        LBLCount.Text = "Selected Tool Count: " & dgvSignedOut.Rows.Count & " Unique Entries, " & counttotal & " Total Tools, " & Convert.ToString(discontinued) & " Discontinued Tools"
        PopulateComboBox(ComboTool, dgvSignedOut, 1)
        PopulateComboBox(ComboShopOrder, dgvSignedOut, 2)
        PopulateComboBox(ComboDepartment, dgvSignedOut, 3)
        DPHigh.Value = Date.Now
        DPLow.Value = Date.Now

        Try
            i = 0
            Do Until i = dgvSignedOut.Rows.Count - 1
                dgvSignedOut(4, i).Value = Convert.ToDateTime(dgvSignedOut(4, i).Value)
                i = i + 1
            Loop
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try

        dgvSignedOut.Sort(dgvSignedOut.Columns(4), ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub BTNFilter_Click(sender As Object, e As EventArgs) Handles BTNFilter.Click
        Dim Quantity As String

        If CBQuantity.Checked = True Then
            Quantity = " BETWEEN " & NUDLow.Value & " AND " & NUDHigh.Value
        Else
            Quantity = " > - 1"
        End If

        Dim Tool As String
        If CBTool.Checked = True Then
            If ComboTool.Text = "" Then
                MsgBox("Tool combo box must have data in it if you would like to filter by tool.", vbCritical, "Error")
                Exit Sub
            End If
            Tool = " = '" & ComboTool.Text & "'"
            If CBToolAM.Checked = True Then
                Tool = " LIKE '%" & ComboTool.Text & "%'"
            End If
        Else
            Tool = "LIKE '%'"
        End If

        Dim ShopOrder As String
        If CBShopOrder.Checked = True Then
            If ComboShopOrder.Text = "" Then
                MsgBox("Shop Order combo box must have data in it if you would like to filter by Shop Order.", vbCritical, "Error")
                Exit Sub
            End If
            ShopOrder = " = '" & ComboShopOrder.Text & "'"
            If CBShopOrderAM.Checked = True Then
                ShopOrder = " LIKE '%" & ComboShopOrder.Text & "%'"
            End If
        Else
            ShopOrder = "LIKE '%'"
        End If

        Dim Department As String
        If CBDepartment.Checked = True Then
            If ComboDepartment.Text = "" Then
                MsgBox("Department combo box must have data in it if you would like to filter by department.", vbCritical, "Error")
                Exit Sub
            End If
            Department = " = '" & ComboDepartment.Text & "'"
            If CBDepartmentAM.Checked = True Then
                Department = " LIKE '%" & ComboDepartment.Text & "%'"
            End If
        Else
            Department = "LIKE '%'"
        End If

        Dim DateUpdated As String
        If CBDate.Checked = True Then
            'DateUpdated = "STR_TO_DATE([Date], '%m/%d/%Y') BETWEEN STR_TO_DATE(" & DPLow.Text & ", '%m/%d/%Y') AND STR_TO_DATE(" & DPHigh.Text & ", '%m/%d/%Y')"
            DateUpdated = "BETWEEN '" & Convert.ToDateTime(DPLow.Value) & "' AND '" & Convert.ToDateTime(DPHigh.Value) & "'"
        Else
            DateUpdated = "LIKE '%'"
        End If

        Dim Cost As String
        If CBCost.Checked = True Then
            If (TBLow.Text = "") Or (TBHigh.Text = "") Or (IsNumeric(TBLow.Text) = False) Or (IsNumeric(TBHigh.Text) = False) Then
                MsgBox("Both cost text boxes must be numeric and contain data in order to filter by cost.", vbCritical, "Error")
                Exit Sub
            End If
            Cost = " BETWEEN " & TBLow.Text & " AND " & TBHigh.Text
        Else
            Cost = " > - 1"
        End If

        Dim sqlcommand As String = "SELECT * FROM [SignedOutCutters] WHERE ([Quantity]" & Quantity & ") AND ([Tool] " & Tool & ") AND ([ShopOrder] " & ShopOrder & ") AND ([Department] " & Department & ") AND ([Date] " & DateUpdated & ") AND ([Cost]" & Cost & ")"

        dbconn.ConnectionString = My.Settings.DatabasePath

        'MsgBox(sqlcommand)
        'Clipboard.SetText(sqlcommand)

        dbconn.Close()
        Dset.Clear()

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try
        Try
            Dset.Tables.Add(Dtable)
        Catch ex As Exception

        End Try
        Dadapter = New OleDbDataAdapter(sqlcommand, dbconn)
        Dim cb = New OleDbCommandBuilder(Dadapter) With {
            .QuotePrefix = "[",
            .QuoteSuffix = "]"
        }
        Try
            Dadapter.Fill(Dtable)
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try
        dgvSignedOut.DataSource = Dtable.DefaultView
        dbconn.Close()

        Dim SOC As Decimal
        Dim i As Integer = 0
        Dim counttotal As Integer = 0
        Dim discontinued As Integer = 0
        For Each item In dgvSignedOut.Rows
            SOC += Convert.ToDecimal(dgvSignedOut(5, i).Value)
            counttotal += Convert.ToInt16(dgvSignedOut(0, i).Value)
            If dgvSignedOut(0, i).Value = 0 Then
                discontinued += 1
            End If
            i = i + 1
        Next

        LBLCost.Text = "Selection Cost: $" & Convert.ToString(SOC)
        LBLCount.Text = "Selected Tool Count: " & dgvSignedOut.Rows.Count & " Unique Entries, " & counttotal & " Total Tools, " & Convert.ToString(discontinued) & " Discontinued Tools"
        PopulateComboBox(ComboTool, dgvSignedOut, 1)
        PopulateComboBox(ComboShopOrder, dgvSignedOut, 2)
        PopulateComboBox(ComboDepartment, dgvSignedOut, 3)
        dgvSignedOut.Sort(dgvSignedOut.Columns(4), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        CBQuantity.Checked = False
        CBTool.Checked = False
        CBShopOrder.Checked = False
        CBDepartment.Checked = False
        CBDate.Checked = False
        CBCost.Checked = False
        CBToolAM.Checked = False
        CBShopOrderAM.Checked = False
        CBDepartmentAM.Checked = False

        NUDLow.Value = 0
        NUDHigh.Value = 0

        ComboTool.Text = ""
        ComboShopOrder.Text = ""
        ComboDepartment.Text = ""

        DPHigh.Value = Date.Now
        DPLow.Value = Date.Now

        TBLow.Text = ""
        TBHigh.Text = ""

        Filtering_Load(sender, e)
        BTNFilter_Click(sender, e)
    End Sub
    Public Sub PopulateComboBox(ByRef cb As ComboBox, ByVal dgv As DataGridView, ByVal x As Integer)
        If dgv.Rows.Count <> 0 Then
            Dim i As Integer = 0
            Dim distinct As New AutoCompleteStringCollection
            Dim duplicates As New List(Of String)
            Dim Tools As New List(Of String)
            cb.Items.Clear()



            Do

                Tools.Add(dgvSignedOut(x, i).Value)

                i = i + 1
            Loop Until i = dgvSignedOut.RowCount

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

            For n = 0 To distinct.Count - 1
                cb.Items.Add(distinct(n))
            Next

            'Do
            '    cb.Items.Add(dgv(x, i).Value)
            '    i = i + 1
            'Loop Until i = dgv.RowCount
            cb.Sorted = True
            cb.AutoCompleteCustomSource.Clear()
            cb.AutoCompleteCustomSource = distinct
        End If
    End Sub

    Private Sub BTNPrint_Click(sender As Object, e As EventArgs) Handles BTNPrint.Click
        'Do Until i = dgvSignedOut.Rows.Count
        '    With dgvSignedOut.Rows(i)
        '        If .Height <> 3 Then
        '            .Height = 0
        '        Else
        '            '.Height = i
        '            .Height = 22
        '        End If
        '        dgvSignedOut.CurrentCell = dgvSignedOut.Rows(i).Cells(0)
        '    End With
        '    'System.Threading.Thread.Sleep(5)
        '    'dgvSignedOut.Update()
        '    i = i + 1
        'Loop
        'dgvSignedOut.CurrentCell = dgvSignedOut.Rows(0).Cells(0)


        Monitoring.tmrRefresh.Stop()
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime
        dgvSignedOut.SelectionMode = DataGridViewSelectionMode.CellSelect
        Cursor = Cursors.WaitCursor
        Dim saveloc As String
        SFDPrint.DefaultExt = ".xlsx"
        SFDPrint.FileName = "Filtered Values (" & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ")"
        SFDPrint.InitialDirectory = "H:\"
        SFDPrint.AddExtension = True
        If SFDPrint.ShowDialog() = DialogResult.OK Then
            saveloc = SFDPrint.FileName
        Else
            MsgBox("Save Canceled", vbCritical)
            Cursor = Cursors.Default
            Exit Sub
        End If
        'MsgBox(saveloc)
        Dim i As Integer = 0
        PBPrint.Minimum = 0
        PBPrint.Value = 0

        PBPrint.Maximum = (dgvSignedOut.Rows.Count) * (dgvSignedOut.Columns.Count)
        'MsgBox(PBPrint.Maximum)
        'PBPrint.Maximum = 0

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim j As Integer

        'For i = 0 To dgvSignedOut.RowCount - 1
        '    For j = 0 To dgvSignedOut.ColumnCount - 1
        '        For k As Integer = 1 To dgvSignedOut.Columns.Count

        '        Next
        '        PBPrint.Maximum += 1
        '    Next
        'Next
        'MsgBox(PBPrint.Maximum)

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet.Name = "Filtered Data (" & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & ")"


        For i = 0 To dgvSignedOut.RowCount - 1
            For j = 0 To dgvSignedOut.ColumnCount - 1
                For k As Integer = 1 To dgvSignedOut.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgvSignedOut.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvSignedOut(j, i).Value.ToString()
                    dgvSignedOut.CurrentCell = dgvSignedOut.Rows(i).Cells(j)

                Next
                PBPrint.PerformStep()
            Next
        Next

        Try
            xlWorkSheet.SaveAs(saveloc)
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlWorkSheet)
            MsgBox("Filtered data has been saved to " & saveloc, vbInformation, "Success!")
        Catch ex As Exception
            MsgBox("Error Saving Document, Please Try Again.", vbCritical, "Error")
        End Try



        Cursor = Cursors.Default
        dgvSignedOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        PBPrint.Value = 0
        Monitoring.tmrRefresh.Start()


    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub
End Class