Public Class DevOptions
    Private Sub BTNCostHelp_Click(sender As Object, e As EventArgs) Handles BTNCostHelp.Click, BTNCostTHelp.Click
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
        TBInterval.Text = My.Settings.timerinterval
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



        For Each item In tbarr
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

        If TBInterval.Text < 0 Then
            MsgBox("Timer interval value must be greater than 0", vbCritical, "Error")
        Else
            My.Settings.timerinterval = TBInterval.Text
            Monitoring.tmrRefresh.Interval = My.Settings.timerinterval
        End If

        My.Settings.Save()

        MsgBox("Material Pricing (Blanks and Coatings) and refresh timer has been updated", vbInformation, "Update")
    End Sub

    Private Sub BTNCostTHelp_Click(sender As Object, e As EventArgs) Handles BTNCostTHelp.DoubleClick
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


End Class