Imports System.Data.OleDb
Public Class DevOptions
    Dim dbconn As New OleDbConnection
    Dim Dset As New DataSet
    Dim Dtable As New DataTable
    Dim Dtable2 As DataTable
    Dim Dadapter As New OleDbDataAdapter
    Private Sub BTNCostHelp_Click(sender As Object, e As EventArgs) Handles BTNCostHelp.Click, BTNCostTHelp.Click
        'help information for the material/coating based cost section
        MsgBox("This section is used to modify the pricing for each family of tools, grouped by size. Pricing is based off of (average cost for blanks) + (average cost for coating) for each size.", vbInformation, "Help")
    End Sub

    Private Sub DevOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings for material costs*******************************************************
        TBoneeighthM.Text = My.Settings.oneeighth
        TBthreesixteenthsM.Text = My.Settings.threesixteenths
        TBfifteensixtyfourthsM.Text = My.Settings.fifteensixtyfourths
        TBonefourthM.Text = My.Settings.onefourth
        TBfivesixteenthsM.Text = My.Settings.fivesixteenths
        TBthreeeighthsM.Text = My.Settings.threeeighths
        TBsevensixteenthsM.Text = My.Settings.sevensixteenths
        TBonehalfM.Text = My.Settings.onehalf
        TBfiveeighthsM.Text = My.Settings.fiveeighths
        TBthreefourthsM.Text = My.Settings.threefourths
        '***************************************************************************************

        'Load settings for time costs*******************************************************
        TBToneeighth.Text = My.Settings.Toneeighth
        TBTthreesixteenths.Text = My.Settings.Tthreesixteenths
        TBTfifteensixtyfourths.Text = My.Settings.Tfifteensixtyfourths
        TBTonefourth.Text = My.Settings.Tonefourth
        TBTfivesixteenths.Text = My.Settings.Tfivesixteenths
        TBTthreeeighths.Text = My.Settings.Tthreeeighths
        TBTsevensixteenths.Text = My.Settings.Tsevensixteenths
        TBTonehalf.Text = My.Settings.Tonehalf
        TBTfiveeighths.Text = My.Settings.Tfiveeighths
        TBTthreefourths.Text = My.Settings.Tthreefourths
        '***************************************************************************************
        'set the text value of the tbrefresh text box to the value in settings for interval
        tbrefresh.Text = My.Settings.TInterval.ToString

    End Sub

    Private Sub BTNApply_Click(sender As Object, e As EventArgs) Handles BTNApply.Click
        Dim tbarr(19) As TextBox
        'Material Text boxes*****************
        tbarr(0) = TBoneeighthM
        tbarr(1) = TBthreesixteenthsM
        tbarr(2) = TBfifteensixtyfourthsM
        tbarr(3) = TBonefourthM
        tbarr(4) = TBfivesixteenthsM
        tbarr(5) = TBthreeeighthsM
        tbarr(6) = TBsevensixteenthsM
        tbarr(7) = TBonehalfM
        tbarr(8) = TBfiveeighthsM
        tbarr(9) = TBthreefourthsM
        '***********************************

        'Time Text boxes*****************
        tbarr(10) = TBToneeighth
        tbarr(11) = TBTthreesixteenths
        tbarr(12) = TBTfifteensixtyfourths
        tbarr(13) = TBTonefourth
        tbarr(14) = TBTfivesixteenths
        tbarr(15) = TBTthreeeighths
        tbarr(16) = TBTsevensixteenths
        tbarr(17) = TBTonehalf
        tbarr(18) = TBTfiveeighths
        tbarr(19) = TBTthreefourths
        '***********************************


        'loop through each item in the tbarr array
        For Each item In tbarr
            'if the value is not numeric then send a message box
            If Not IsNumeric(item.Text) Then
                MsgBox("All text boxes must be filled out containing a decimal value for cost.", vbCritical, "Error")
                Exit Sub
            End If
        Next

        'Overwrite settings for material costs*******************************************************
        My.Settings.oneeighth = TBoneeighthM.Text
        My.Settings.threesixteenths = TBthreesixteenthsM.Text
        My.Settings.fifteensixtyfourths = TBfifteensixtyfourthsM.Text
        My.Settings.onefourth = TBonefourthM.Text
        My.Settings.fivesixteenths = TBfivesixteenthsM.Text
        My.Settings.threeeighths = TBthreeeighthsM.Text
        My.Settings.sevensixteenths = TBsevensixteenthsM.Text
        My.Settings.onehalf = TBonehalfM.Text
        My.Settings.fiveeighths = TBfiveeighthsM.Text
        My.Settings.threefourths = TBthreefourthsM.Text
        '*********************************************************************************************
        'Overwrite settings for time costs*******************************************************
        My.Settings.Toneeighth = TBToneeighth.Text
        My.Settings.Tthreesixteenths = TBTthreesixteenths.Text
        My.Settings.Tfifteensixtyfourths = TBTfifteensixtyfourths.Text
        My.Settings.Tonefourth = TBTonefourth.Text
        My.Settings.Tfivesixteenths = TBTfivesixteenths.Text
        My.Settings.Tthreeeighths = TBTthreeeighths.Text
        My.Settings.Tsevensixteenths = TBTsevensixteenths.Text
        My.Settings.Tonehalf = TBTonehalf.Text
        My.Settings.Tfiveeighths = TBTfiveeighths.Text
        My.Settings.Tthreefourths = TBTthreefourths.Text
        '*********************************************************************************************

        If IsNumeric(tbrefresh.Text) Then
            'if the value in the tbrefresh text box is less than 0 then inform the user it cannot be less than 0
            If tbrefresh.Text < 0 Then
                MsgBox("Refresh interval cannot be less than 0.", vbCritical, "Error")
                'if the value is greater than 0 put that value in the interval container in settings
            Else
                My.Settings.TInterval = Convert.ToInt16(tbrefresh.Text)
                Monitoring.tmrRefresh.Interval = My.Settings.TInterval
            End If
        Else
            MsgBox("Refresh interval must be numeric.", vbCritical, "Error")
        End If

        'save the settings
        My.Settings.Save()

        'confirmation of settings change
        MsgBox("Material Pricing (Blanks and Coatings) and monitor form refresh have been updated", vbInformation, "Update")
    End Sub

    Private Sub BTNCostTHelp_Click(sender As Object, e As EventArgs) Handles BTNCostTHelp.DoubleClick
        'help information for the time based cost section
        MsgBox("This section is used to modify the pricing for each family of tools, grouped by size. Pricing is based off of time spent machining for each size.", vbInformation, "Help")
    End Sub

    Private Sub BTNReset_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        'Load settings for material costs*******************************************************
        TBoneeighthM.Text = My.Settings.oneeighth
        TBthreesixteenthsM.Text = My.Settings.threesixteenths
        TBfifteensixtyfourthsM.Text = My.Settings.fifteensixtyfourths
        TBonefourthM.Text = My.Settings.onefourth
        TBfivesixteenthsM.Text = My.Settings.fivesixteenths
        TBthreeeighthsM.Text = My.Settings.threeeighths
        TBsevensixteenthsM.Text = My.Settings.sevensixteenths
        TBonehalfM.Text = My.Settings.onehalf
        TBfiveeighthsM.Text = My.Settings.fiveeighths
        TBthreefourthsM.Text = My.Settings.threefourths
        '***************************************************************************************

        'Load settings for time costs*******************************************************
        TBToneeighth.Text = My.Settings.Toneeighth
        TBTthreesixteenths.Text = My.Settings.Tthreesixteenths
        TBTfifteensixtyfourths.Text = My.Settings.Tfifteensixtyfourths
        TBTonefourth.Text = My.Settings.Tonefourth
        TBTfivesixteenths.Text = My.Settings.Tfivesixteenths
        TBTthreeeighths.Text = My.Settings.Tthreeeighths
        TBTsevensixteenths.Text = My.Settings.Tsevensixteenths
        TBTonehalf.Text = My.Settings.Tonehalf
        TBTfiveeighths.Text = My.Settings.Tfiveeighths
        TBTthreefourths.Text = My.Settings.Tthreefourths
        '***************************************************************************************
    End Sub

    Private Sub BTNUpdate_Click(sender As Object, e As EventArgs) Handles BTNUpdate.Click
        Dim i As Integer = 0
        Dim tools As String = ""
        Dim toolschanged As Integer = 0
        Dim invcount As Integer = Monitoring.dgvInventory.Rows.Count
        PBUpdate.Maximum = invcount
        PBUpdate.Minimum = 0
        Do Until i = invcount
            Dim Qty As String = Monitoring.dgvInventory(0, i).Value
            Dim ToolName As String = Monitoring.dgvInventory(1, i).Value
            Dim TCost As Decimal

            'extract the size from the toolname identifier (always the first term)
            Dim toolsplit() As String = Split(ToolName, " ")
            Dim size As String = toolsplit(0)

            Select Case size
                Case "1/8"
                    TCost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "3/16"
                    TCost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "15/64"
                    TCost = My.Settings.fifteensixtyfourths + My.Settings.Tfifteensixtyfourths
                Case "1/4"
                    TCost = My.Settings.onefourth + My.Settings.Tonefourth
                Case "5/16"
                    TCost = My.Settings.fivesixteenths + My.Settings.Tfivesixteenths
                Case "3/8"
                    TCost = My.Settings.threeeighths + My.Settings.Tthreeeighths
                Case "7/16"
                    TCost = My.Settings.sevensixteenths + My.Settings.Tsevensixteenths
                Case "1/2"
                    TCost = My.Settings.onehalf + My.Settings.Tonehalf
                Case "5/8"
                    TCost = My.Settings.fiveeighths + My.Settings.Tfiveeighths
                Case "3/4"
                    TCost = My.Settings.threefourths + My.Settings.Tthreefourths
                Case "11/64"
                    TCost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "3/32"
                    TCost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "9/64"
                    TCost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "5/64"
                    TCost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "11/32"
                    TCost = My.Settings.threeeighths + My.Settings.Tthreeeighths
                Case "5/32"
                    TCost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "13/64"
                    TCost = My.Settings.fifteensixtyfourths + My.Settings.Tfifteensixtyfourths
                Case "7/64"
                    TCost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "7/32"
                    TCost = My.Settings.fifteensixtyfourths + My.Settings.Tfifteensixtyfourths
                Case "9/32"
                    TCost = My.Settings.fivesixteenths + My.Settings.Tfivesixteenths
                Case "test"
                    TCost = 123.45
                Case Else
                    TCost = 0.00
            End Select

            Dim toolcost As Decimal = Math.Round((Qty * TCost), 2)

            dbconn.Close()
            Dim selstr As String = "SELECT [Cost],[Tool] FROM [ToolRoomInventory] WHERE [Tool] = '" & ToolName & "'"
            dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Tool & Cutter Grinding\Tool Cutter Database.accdb;Persist Security Info = False"

            Try
                dbconn.Open()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex), vbCritical, "Error")
            End Try
            Try
                Dset.Tables.Add(Dtable)
            Catch ex As Exception
                '  MsgBox(Convert.ToString(ex), vbCritical,"Error")
            End Try
            Dadapter = New OleDbDataAdapter(selstr, dbconn)
            Dim cb = New OleDbCommandBuilder(Dadapter) With {
                .QuotePrefix = "[",
                .QuoteSuffix = "]"
            }

            Try
                Dadapter.Fill(Dtable)
            Catch ex As Exception
                MsgBox(Convert.ToString(ex), vbCritical, "Error")
            End Try

            If ((Dtable(0).Item(0)) = (toolcost)) = True Then

            Else
                dbconn.Close()
                'update approval to either "Accepted" or "Rejected" depending on the button press
                Dim Str As String = "UPDATE [ToolRoomInventory] set [Cost] = '" & (toolcost) & "' WHERE ([Tool] = '" & ToolName & "')"
                dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Tool & Cutter Grinding\Tool Cutter Database.accdb;Persist Security Info = False"

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
                Dadapter = New OleDbDataAdapter(Str, dbconn)
                cb = New OleDbCommandBuilder(Dadapter) With {
                    .QuotePrefix = "[",
                    .QuoteSuffix = "]"
                }
                Dadapter.Fill(Dtable)
                'MsgBox(Str,vbinformation,"SQL")
                dbconn.Close()

                toolschanged += 1
                tools = tools + ToolName + ", "

            End If
            Dtable.Clear()
            dbconn.Close()
            i = i + 1
            PBUpdate.Value = i
        Loop
        If toolschanged = 0 Then
            MsgBox("No tools needed to be changed!", vbInformation, "No Changes")
        Else
            MsgBox("A total of " & toolschanged & " tool costs were changed. Following is a list of the tools that have been changed.", vbInformation, "Tools Changed")
            tools = tools.Substring(0, tools.Length - 2)
            MsgBox(tools, vbInformation, "Tools Changed List")
        End If


        Monitoring.BtnRefresh_Click(sender, e)
        PBUpdate.Value = 0
    End Sub
End Class