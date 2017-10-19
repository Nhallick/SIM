'-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
'Project: Strite Inventory Management Software
'Description: Software built with the purpose of managing the inventory flow of the in house operation tool cutter currently run by Tim Barnard
'Created By: Nick Hallick
'            Process Engineer
'            nhallick@strite.com
'            519-658-9361 ext.344
'Project Start Date: 14/06/2017
'Project End Date: TBD
'Revision: 1.1.1 (Published)

'***********************************************************************************************************************************************************************
'The Dreaded TODO Section
'TODO: Make a function to enable database connection and refresh grid views *COMPLETED: 15/06/2017*
'TODO: Make a function to update records *COMPLETED: 15/06/2017*
'TODO: User authentication through database. Program checks database for username and only allows access if username is in system *COMPLETED: 16/06/2017*
'TODO: Allow DGV on toolcutter.vb to refresh when new orders are added to the database *COMPLETED: 19/06/2017*

'TODO: When signing out cutter that is already on order no new order is placed *COMPLETED: 27/06/2017*
'TODO: When cutter order is rejected it does not re-order automatically

'TODO: Full Functionality of edit button in toolroom interface *COMPLETED: 21/06/2017*
'TODO: FUll functionality of search button in toolroom interface *COMPLETED: 21/06/2017*

'***********************************************************************************************************************************************************************
'UPDATES
'1.1.1
'  -Bug Fix: fixed bug where dates were showing up as mm/dd/yyyy instead of dd/mm/yyyy
'1.2.0
'  -Integrate project with GitHub version control
'-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Imports System.ComponentModel
Public Class StriteInventoryManagement
    Private Sub BTNToolCutter_Click(sender As Object, e As EventArgs) Handles BTNToolCutter.Click

        'When the tool cutter interface button is clicked show the tool cutter interface and hide home window
        'If Admincheck() = "Y" Or Environment.UserName = "tbarnard" Then
        DGVUserStatusandInterface("ONLINE", "TOOL CUTTER INTERFACE")
            ToolCutter.Show()
            Hide()
        ' End If

    End Sub

    Private Sub BTNToolRoom_Click(sender As Object, e As EventArgs) Handles BTNToolRoom.Click

        'When the tool room interface button is clicked show the tool room interface and hide home window
        '  If Admincheck() = "Y" Or Environment.UserName = "acaetano" Or Environment.UserName = "cringler" Then
        DGVUserStatusandInterface("ONLINE", "TOOL ROOM INTERFACE")
            ToolRoom.Show()
            Hide()
        ' End If

    End Sub

    Private Sub StriteInventoryMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.Users' table. You can move, or remove it, as needed.
        UsersTableAdapter.Fill(Tool_Cutter_DatabaseDataSet.Users)

        'validate the current user based on machine name
        UserValidation()

        'populate the user datagridview
        DGVRefresh("Users", DGVUsers)

        'change current users status and interface
        DGVUserStatusandInterface("ONLINE", "MAIN WINDOW")

        TMRRefresh.Start()

        'TODO: This line of code loads data into the 'Tool_Cutter_DatabaseDataSet.Users' table. You can move, or remove it, as needed.
        'UsersTableAdapter.FillBy(Tool_Cutter_DatabaseDataSet.Users)
        'get the current users name by finding their computer name and display it in a label
        LBLUser.Text = Environment.UserName
    End Sub

    Private Sub TMRRefresh_Tick(sender As Object, e As EventArgs) Handles TMRRefresh.Tick
        Dim i As Integer
        'refresh the user datagridview using the timer interval (1 second is probably the best interval, could be longer if neccessary) (Is currently 1.1 seconds as of 08/08/2017)
        DGVRefresh("Users", DGVUsers)

        'Use a for loop to go through each item in the datagridview. If a user is online change the status cell green, if they are offline change the cell to red.
        i = 0
        For Each item In DGVUsers.Rows
            If DGVUsers(1, i).Value = "ONLINE" Then
                DGVUsers(1, i).Style.BackColor = Color.Green
            ElseIf DGVUsers(1, i).Value = "OFFLINE" Then
                DGVUsers(1, i).Style.BackColor = Color.Red
            End If
            i = i + 1
        Next
    End Sub

    Private Sub StriteInventoryMgmt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'when the program is closed completely set the user status to offline and interface to closed
        DGVUserStatusandInterface("OFFLINE", "CLOSED")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'if a user clicks on the strite logo and they are approved (see below for usernames) bring up the monitoring interface.
        Select Case Environment.UserName
            Case "nhallick"
                Monitoring.Show()
            Case "rcensner"
                Monitoring.Show()
            Case "kelka"
                Monitoring.Show()
            Case Else
                Exit Select
        End Select
    End Sub
End Class
