Public Class DevOptions
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
End Class