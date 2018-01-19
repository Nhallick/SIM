'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
'See StriteInventoryManagement.vb for header
'------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Imports System.Data.OleDb
Public Module Functions
    Dim dbconn As New OleDbConnection
    Dim Dset As New DataSet
    Dim Dtable As New DataTable
    Dim Dtable2 As DataTable
    Dim Dadapter As New OleDbDataAdapter

    Public Sub DGVRefresh(ByVal table As String, ByRef dgv As DataGridView)

        'This sub connects to the database and updates a datagridview with ALL records from a specific table specified through code
        'close connection from any previous session
        dbconn.Close()

        'clear dataset so as not to append data
        Dset.Clear()

        'Select SQL query that selects ALL records from a table
        Dim str As String = "SELECT * FROM " & "[" & table & "]" & ""
        dbconn.ConnectionString = My.Settings.DatabasePath

        'use try catch statement to open the connection
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try

        'use try catch statement to add a table (dt) to the dataset (ds) in order to store values
        Try
            Dset.Tables.Add(Dtable)
        Catch ex As Exception
            ' MsgBox(Convert.ToString(ex), vbCritical,"Error")
        End Try

        'create new dataadapter object using the sql string from above and the connection created above
        Dadapter = New OleDbDataAdapter(str, dbconn)

        'create new command builder in order to execute the SELECT SQL statement using the dataadapter created (da)
        'specify prefix and suffix for cb
        Dim cb = New OleDbCommandBuilder(Dadapter) With {
            .QuotePrefix = "[",
            .QuoteSuffix = "]"
        }
        'use try catch statement to fill the datatable (dt) using the dataadapter (da)
        Try
            Dadapter.Fill(Dtable)
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try

        'set the datasource of the datagridview to the datatable
        dgv.DataSource = Dtable.DefaultView

        'close the connection to the database
        dbconn.Close()
    End Sub

    Public Sub DGVUserStatusandInterface(ByVal status As String, ByVal userinterface As String)

        'this sub updates the users status and interface according to variables given through code when calling the sub
        dbconn.Close()
        Dim str As String = "UPDATE [Users] set [Status] = '" & status & "', [Interface] = '" & userinterface & "' WHERE [Username] = '" & Environment.UserName & "'"
        dbconn.ConnectionString = My.Settings.DatabasePath
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try
        Try
            Dset.Tables.Add(Dtable)
        Catch ex As Exception
            'MsgBox(Convert.ToString(ex), vbCritical,"Error")
        End Try
        Dadapter = New OleDbDataAdapter(str, dbconn)
        Dim cb = New OleDbCommandBuilder(Dadapter) With {
            .QuotePrefix = "[",
            .QuoteSuffix = "]"
        }
        Dadapter.Fill(Dtable)
        dbconn.Close()
    End Sub
    Public Sub UserValidation()

        'this sub validates the current user to the database. if the user is not on the database then the program will close immediately. If they are on the database or "Registered" then they are allowed to use the program.
        dbconn.Close()
        Dset.Clear()

        'SQL statement used to compare the computers domain name (Environment.Username) with the username field in the database
        Dim str As String = $"SELECT * FROM [Users] WHERE [Username]= '{Environment.UserName}'"
        dbconn.ConnectionString = My.Settings.DatabasePath
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
        Dadapter = New OleDbDataAdapter(str, dbconn)
        Dim cb = New OleDbCommandBuilder(Dadapter) With {
            .QuotePrefix = "[",
            .QuoteSuffix = "]"
        }

        Try
            Dadapter.Fill(Dtable)
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try

        'Count the number of results in the datatable. There should be only 1 result as each computer has a different name. If there is a result the user is registered.
        If Dtable.Rows.Count = 0 Then
            MsgBox("User '" & Environment.UserName & "' is not registered. Speak to the administrator of the software to register your username (ext. 344). The program will now terminate.", MsgBoxStyle.Critical, "Error")
            StriteInventoryManagement.Close()
        End If
        dbconn.Close()
    End Sub

    Public Sub ToolCutterSubmit(ByRef dgv As DataGridView)

        'this sub allows a user in the toolcutter window to submit an order to the toolroom once finished
        'TODO: add dialog to ask the user if they are sure they want to submit the order *COMPLETED: 19/06/2017*

        'if the datagridview has no rows (there are no orders) then exit the sub and do not try to submit anything
        If ToolCutter.DGVOrders.RowCount = 0 Then
            Exit Sub
        Else

            'declare relevant variables
            Dim i As Integer = dgv.CurrentRow.Index
            Dim QtyToMake As String = dgv(0, i).Value
            Dim ToolName As String = dgv(1, i).Value
            Dim DateSubmitted As String = dgv(2, i).Value
            Dim datemade As String
            Dim result As String = MsgBox("Are you sure you would like to submit this order for (" & QtyToMake & ") pcs. of (" & ToolName & ")?", vbYesNo + vbInformation, "Submit this order?")
            If result = vbYes Then
                dbconn.Close()
                datemade = Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
                'Update the approval field in the database to "submitted for Approval" indicating to the program to move the order to the tool room interface
                Dim Str As String = "UPDATE [CutterOrders] set [Approval] = ""Submitted for Approval"", [Date Made] = '" & datemade & "' WHERE ([QtyToMake] = " & QtyToMake & ") AND ([Tool Name] = '" & ToolName & "') AND ([Date Submitted] = '" & DateSubmitted & "') AND ([Approval] = ""Awaiting Submittal"")"

                dbconn.ConnectionString = My.Settings.DatabasePath
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
                Dim cb = New OleDbCommandBuilder(Dadapter) With {
                    .QuotePrefix = "[",
                    .QuoteSuffix = "]"
                }
                Try
                    Dadapter.Fill(Dtable)
                Catch ex As Exception
                    ' MsgBox(Convert.ToString(ex),vbcritical,"Error")
                End Try
                dbconn.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Public Sub ToolRoomAcceptReject(ByRef condition As String, ByRef dgv As DataGridView)
        Try
            'this sub is used to handle acceptance and rejection of orders by the toolroom user for submitted orders. When an order is accepted it is added into the inventory and the quantity is updated. If the tool is not present in the inventory the user is prompted to add it.
            If ToolRoom.DGVSubOrders.RowCount = 0 Then
                Exit Sub
            Else
                Dim i As Integer = dgv.CurrentRow.Index
                Dim QtyToMake As String = dgv(0, i).Value
                Dim ToolName As String = dgv(1, i).Value
                Dim DateSubmitted As String = dgv(2, i).Value
                Dim MaxBin As String
                Dim MinBin As String
                Dim Countresult As Integer
                Dim loopflag As Boolean = False
                Dim rejectresult As String = vbNo
                Dim TCost As Decimal
                Dim INVCost As String = "!!NSD!!"
                Dim nosizeflag As Boolean = False

                'extract the size from the toolname identifier (always the first term)
                Dim toolsplit() As String = Split(ToolName, " ")
                Dim size As String = toolsplit(0)

                'compare sizes to known sizes with pricing data to obtain a total material + coating cost for 1 part (cost will be multiplied later by quantity for full cost)
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
                        nosizeflag = True
                End Select

                dbconn.Close()

                'update approval to either "Accepted" or "Rejected" depending on the button press
                Dim Str As String = "UPDATE [CutterOrders] set [Approval] = '" & condition & "' WHERE ([QtyToMake] = " & QtyToMake & ") AND ([Tool Name] = '" & ToolName & "') AND ([Date Submitted] = '" & DateSubmitted & "')"

                'update approval to "Submitted for approval" (Used if adding a new cutter and the option "No" is selected or if the user selects "no" when asked if they want to reject the order. Effectively just returns order to the toolroom order datagridview box
                Dim Str4 As String = "UPDATE [CutterOrders] set [Approval] = ""Submitted For Approval"" WHERE ([QtyToMake] = " & QtyToMake & ") AND ([Tool Name] = '" & ToolName & "') AND ([Date Submitted] = '" & DateSubmitted & "')"

                'updates quantity in the inventory based on the quantity made in the order
                Dim str2 As String
                If nosizeflag = True Then
                    str2 = "UPDATE [ToolRoomInventory] set [Quantity] = [Quantity] + '" & QtyToMake & "', [Order Placed]= ""N"", [Date Updated]= '" & Date.Now & "', [Cost] = [Cost] + '" & (INVCost) & "' WHERE [Tool] = '" & ToolName & "'"
                Else
                    str2 = "UPDATE [ToolRoomInventory] set [Quantity] = [Quantity] + '" & QtyToMake & "', [Order Placed]= ""N"", [Date Updated]= '" & Date.Now & "', [Cost] = [Cost] + '" & (TCost * QtyToMake) & "' WHERE [Tool] = '" & ToolName & "'"
                End If


                'used to count the number of tools in inventory with a certain name. Used primarily to check if a tool exists in the inventory already or not
                Dim count As String = "SELECT Count(*) AS Expr1, Tool FROM [ToolRoomInventory] GROUP BY Tool HAVING (Tool = '" & ToolName & "')"
                dbconn.ConnectionString = My.Settings.DatabasePath

                'changes approval condition to accepted or rejected-----------------------------------------------------------------------------------------------------
                Try
                    dbconn.Open()
                Catch ex As Exception
                    ' MsgBox(Convert.ToString(ex),vbcritical,"Error")
                End Try
                Try
                    Dset.Tables.Add(Dtable)
                Catch ex As Exception
                    'MsgBox(Convert.ToString(ex),vbcritical,"Error")
                End Try
                Dadapter = New OleDbDataAdapter(Str, dbconn)
                Dim cb = New OleDbCommandBuilder(Dadapter) With {
                    .QuotePrefix = "[",
                    .QuoteSuffix = "]"
                }
                Dadapter.Fill(Dtable)
                'MsgBox(Str,vbinformation,"SQL")
                dbconn.Close()
                '-------------------------------------------------------------------------------------------------------------------------------------------------------

                'if the condition was changed to "rejected" then ask the user if they are sure about rejecting. If "yes" then reject the order, if "no" then restore order to "Submitted for Approval" condition
                If condition = "Rejected" Then
                    Dim Str5 As String = "UPDATE [ToolRoomInventory] set [Order Placed]= ""N"" WHERE [Tool] = '" & ToolName & "'"
                    rejectresult = MsgBox("Are you sure you would like to reject this order: (" & QtyToMake & ") of (" & ToolName & ")? This decision cannot be undone.", vbYesNo + vbInformation, "Reject Order?")
                    Dim comment As String
                    dbconn.Open()

                    If rejectresult = vbYes Then
                        Dadapter = New OleDbDataAdapter(Str5, dbconn)
                        cb = New OleDbCommandBuilder(Dadapter)
                        Dadapter.Fill(Dtable)
                        Do
                            comment = InputBox("Please describe why this order is being rejected", "Reject")
                        Loop Until comment <> ""
                        Dim Str6 As String = "UPDATE [CutterOrders] set [Approval] = [Approval] + '" & " (" & comment & ") " & "' + '" & " (" & (TCost * QtyToMake) & ") " & "' WHERE ([QtyToMake] = " & QtyToMake & ") AND ([Tool Name] = '" & ToolName & "') AND ([Date Submitted] = '" & DateSubmitted & "')"
                        Dadapter = New OleDbDataAdapter(Str6, dbconn)
                        cb = New OleDbCommandBuilder(Dadapter)
                        Dadapter.Fill(Dtable)
                        Exit Sub
                    End If
                    If rejectresult = vbNo Then
                        Dadapter = New OleDbDataAdapter(Str4, dbconn)
                        cb = New OleDbCommandBuilder(Dadapter)
                        Dadapter.Fill(Dtable)
                        Exit Sub
                    End If
                End If
                dbconn.Close()
                'handles adding tool to inventory or updating the quantity if it already exists-------------------------------------------------------------------------
                'Count number of records matching 'ToolName' (should only be 1)
                Dim cb2 As New OleDbCommand(count, dbconn)
                dbconn.Open()
                'use execute scalar command when using a COUNT command
                Countresult = cb2.ExecuteScalar
                dbconn.Close()
                'use count result to determine which str operation to invoke (0 means the tool does not exist in the inventory)
                If Countresult = 0 Then

                    'prompt user to confirm adding the tool to the database
                    Dim result As String = MsgBox("'" & ToolName & "' does not exist in the database, add this tool?", vbYesNo + vbInformation, "Add Tool?")
                    dbconn.Open()
                    'If "no" then revert approval to "submitted for approval" (in cases of a mistake I guess)
                    If result = vbNo Then
                        Dadapter = New OleDbDataAdapter(Str4, dbconn)
                        cb = New OleDbCommandBuilder(Dadapter)
                        Dadapter.Fill(Dtable)
                        Exit Sub

                        'If "Yes" then prompt user for max and min bin size then add to inventory database
                    ElseIf result = vbYes Then

                        'Run in a loop to account for "Idiot Proofing" in order to assure no program breaking mistakes in data
                        Do
                            MaxBin = InputBox("Please input max bin quantity", "Max Bin", "0")
                            MinBin = InputBox("Please input min bin quantity", "Min Bin", "0")

                            'Check if only numbers were submitted by user
                            If IsNumeric(MinBin & MaxBin) = False Then
                                MsgBox("Minimum bin size (" & MinBin & ") and maximum bin size (" & MaxBin & ") values must be numeric values", vbCritical, "Error")
                                loopflag = False

                                'check if minimum bin size is bigger than maximum bin size (not acceptable)
                            ElseIf Convert.ToInt16(MinBin) > Convert.ToInt16(MaxBin) Then
                                MsgBox("Minimum bin size (" & MinBin & ") cannot be larger than maximum bin size (" & MaxBin & ")", vbCritical, "Error")
                                loopflag = False
                            Else
                                loopflag = True
                            End If
                        Loop Until loopflag = True

                        'used to insert (add) a new cutter to the inventory. user is prompted to add min and max bin sizes
                        Dim Str3 As String = "INSERT INTO [ToolRoomInventory] ([Quantity], [Tool], [Max Bin Size], [Min Bin Size], [Order Placed], [Date Updated], [Cost]) VALUES (" & QtyToMake & ", '" & ToolName & "', " & MaxBin & ", " & MinBin & ", ""N"", '" & Date.Now & "', '" & (TCost * QtyToMake) & "' )"
                        Dadapter = New OleDbDataAdapter(Str3, dbconn)
                        cb = New OleDbCommandBuilder(Dadapter)
                        Dadapter.Fill(Dtable)
                    End If
                Else

                    'if the tool is already in the inventory just add the made quantity to the inventory quantity
                    Dadapter = New OleDbDataAdapter(str2, dbconn)
                    cb = New OleDbCommandBuilder(Dadapter)
                    Dadapter.Fill(Dtable)
                End If
                '-------------------------------------------------------------------------------------------------------------------------------------------------------
                dbconn.Close()
            End If
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try

    End Sub

    Public Sub NewTool()
        dbconn.Close()
        Dset.Clear()
        Dim QtyToMake As String
        Dim ToolName As String
        Dim DateSubmitted As String
        Dim Approval As String
        Dim result As String = MsgBox("Are you sure you would like to create a new order?", vbYesNo + vbInformation, "Create New Order?")
        Dim loopflag As Boolean = False
        Dim countresult As Integer = 0

        If result = vbYes Then

            'gather information from user. use do loops to make sure user inputs information that wont break the program
            Do
                Do
                    ToolName = InputBox("Please input new tool name below", "Name...")
                Loop Until ToolName <> ""
                Do
                    QtyToMake = InputBox("Please input quantity to make below", "Quantity...")
                Loop Until IsNumeric(QtyToMake) = True
                loopflag = True
                DateSubmitted = Date.Now
                Approval = "Awaiting Submittal"
            Loop Until loopflag = True

            'Following code used to insert new tool order in the database
            Dim str As String = "INSERT INTO [CutterOrders] ([QtyToMake], [Tool Name], [Date Submitted], [Approval]) VALUES (" & QtyToMake & ", '" & ToolName & "', '" & DateSubmitted & "', '" & Approval & "')"
            Dim count As String = "SELECT Count (*) AS Expr1, [Tool Name], Approval FROM CutterOrders GROUP BY [Tool Name], Approval HAVING ([Tool Name] = '" & ToolName & "') AND (Approval = ""Awaiting Submittal"")"

            Dim cb2 As New OleDbCommand(count, dbconn)
            dbconn.Open()
            'use execute scalar command when using a COUNT command
            countresult = cb2.ExecuteScalar
            dbconn.Close()

            'checks to see if there are any tools that match the toolname and are awaiting submittal
            'if there aren't then run the insert SQL command to insert the new tool into the database
            If countresult = 0 Then
                dbconn.ConnectionString = My.Settings.DatabasePath
                Try
                    dbconn.Open()
                Catch ex As Exception
                    MsgBox(Convert.ToString(ex), vbCritical, "Error")
                End Try
                Try
                    Dset.Tables.Add(Dtable)
                Catch ex As Exception

                End Try
                Dadapter = New OleDbDataAdapter(str, dbconn)
                Dim cb = New OleDbCommandBuilder(Dadapter) With {
                    .QuotePrefix = "[",
                    .QuoteSuffix = "]"
                }

                Try
                    Dadapter.Fill(Dtable)
                Catch ex As Exception
                    MsgBox(Convert.ToString(ex), vbCritical, "Error")
                End Try
                dbconn.Close()

                'if the tool exists already in the database and is awaiting submittal then update the quantity to add the desired amount
            Else
                Dim updatestr As String = "UPDATE [CutterOrders] set [QtyToMake] = [QtyToMake] + '" & QtyToMake & "' WHERE ([Tool Name] = '" & ToolName & "')"
                Try
                    dbconn.Open()
                Catch ex As Exception
                    MsgBox(Convert.ToString(ex), vbCritical, "Error")
                End Try
                Try
                    Dset.Tables.Add(Dtable)
                Catch ex As Exception

                End Try
                Dadapter = New OleDbDataAdapter(updatestr, dbconn)
                Dim cb = New OleDbCommandBuilder(Dadapter) With {
                    .QuotePrefix = "[",
                    .QuoteSuffix = "]"
                }
                Try
                    Dadapter.Fill(Dtable)
                Catch ex As Exception
                    MsgBox(Convert.ToString(ex), vbCritical, "Error")
                End Try
                dbconn.Close()
            End If

        Else
            Exit Sub
        End If
    End Sub

    Public Sub SignOutTool(ByRef dgv As DataGridView)
        Dim loopflag As Boolean = False
        'if the inventory in the toolroom interface is empty (unlikely) then exit the sub
        'if it isn't empty then run the code to sign out a tool
        If ToolRoom.DGVInventory.RowCount = 0 Then
            Exit Sub
        Else

            'declare relevant variables
            Dim i As Integer = dgv.CurrentRow.Index
            Dim Qty As String = dgv(0, i).Value
            Dim Tool As String = dgv(1, i).Value
            Dim MaxBin As String = dgv(2, i).Value
            Dim Minbin As String = dgv(3, i).Value
            Dim QtyToSignOut As String
            Dim ShopOrder As String
            Dim Department As String
            Dim personname As String
            Dim DateSignedOut As String = Date.Now
            Dim ToolName As String = dgv.SelectedRows(0).Cells(1).Value.ToString
            Dim DateSubmitted As String = Date.Now
            Dim Approval As String = "Awaiting Submittal"
            Dim TCost As Decimal

            'extract the size data from the toolname identifier (always the first term)
            Dim toolsplit() As String = Split(ToolName, " ")
            Dim size As String = toolsplit(0)

            'compare sizes to known sizes with pricing data to obtain a total material + coating cost for 1 part (cost will be multiplied later by quantity for full cost)
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
            End Select

            'prompt user to confirm signing out tool
            Dim result As String = MsgBox("Are you sure you would like to sign out this tool: (" & Tool & ")", vbYesNo + vbInformation, "Sign Out?")

            'if user selects yes then run the following code
            If result = vbYes Then
                dbconn.Close()

                'Get quantity from user
                Do
                    QtyToSignOut = InputBox("Enter quantity to sign out", "Quantity")
                Loop Until IsNumeric(QtyToSignOut) = True

                'get shoporder from user
                Do
                    ShopOrder = InputBox("Please enter shop order that this/these tool(s) will be used for", "Shop Order")
                Loop Until ShopOrder <> ""

                'get department from user
                Do
                    Department = InputBox("Please enter department that is requesting this/these tool(s)", "Department")
                Loop Until Department <> ""

                'Get name of person requesting the tool
                Do
                    personname = InputBox("Please enter the name of the person requesting the tool(s)", "Name")
                Loop Until personname <> ""

                'following code used to insert the sign out record to the database
                Dim Str As String = "INSERT INTO [SignedOutCutters] ([Quantity], [Tool], [ShopOrder], [Department], [Date], [Cost]) VALUES (" & QtyToSignOut & ", '" & Tool & "', '" & ShopOrder & "', '" & Department & "' + "" ("" + '" & personname & "' + "")"", '" & DateSignedOut & "', '" & (TCost * QtyToSignOut) & "' )"
                dbconn.ConnectionString = My.Settings.DatabasePath
                Try
                    dbconn.Open()
                Catch ex As Exception
                    MsgBox(Convert.ToString(ex), vbCritical, "Error")
                End Try
                Try
                    Dset.Tables.Add(Dtable)
                Catch ex As Exception
                    ' MsgBox(Convert.ToString(ex), vbCritical,"Error")
                End Try
                Dadapter = New OleDbDataAdapter(Str, dbconn)
                Dim cb = New OleDbCommandBuilder(Dadapter) With {
                    .QuotePrefix = "[",
                    .QuoteSuffix = "]"
                }
                Dadapter.Fill(Dtable)

                'update the corresponding record in the database to reflect quantity signed out
                Dim Str2 As String = "UPDATE [ToolRoomInventory] set [Quantity] = [Quantity] - '" & QtyToSignOut & "', [Date Updated]= '" & Date.Now & "', [Cost] = [Cost] - '" & (TCost * QtyToSignOut) & "'  WHERE [Tool] = '" & Tool & "'"
                Dadapter = New OleDbDataAdapter(Str2, dbconn)
                cb = New OleDbCommandBuilder(Dadapter)
                Dadapter.Fill(Dtable)
                dbconn.Close()

                'Checks to see if the currently selected tool is already on order
                If dgv.SelectedRows(0).Cells(4).Value.ToString() = "Y" Then

                    Dim count As String = "SELECT Count (*) AS Expr1, [Tool Name], Approval FROM CutterOrders GROUP BY [Tool Name], Approval HAVING ([Tool Name] = '" & ToolName & "') AND (Approval = ""Awaiting Submittal"")"
                    Dim countresult As Integer
                    Dim cb2 As New OleDbCommand(count, dbconn)
                    dbconn.ConnectionString = My.Settings.DatabasePath
                    dbconn.Open()
                    'use execute scalar command when using a COUNT command
                    countresult = cb2.ExecuteScalar
                    dbconn.Close()

                    Dim str3 As String = ""
                    If countresult = 0 Then
                        str3 = "INSERT INTO [CutterOrders] ([QtyToMake], [Tool Name], [Date Submitted], [Approval]) VALUES (" & QtyToSignOut & ", '" & ToolName & "', '" & DateSubmitted & "', '" & Approval & "')"
                    ElseIf countresult > 0 Then
                        str3 = "UPDATE [CutterOrders] set [QtyToMake] ='" & QtyToSignOut & "' + [QtyToMake] ,[Date Submitted] = '" & DateSubmitted & "' WHERE ([Tool Name] = '" & ToolName & "') AND ([Approval] = ""Awaiting Submittal"")"
                    End If

                    dbconn.ConnectionString = My.Settings.DatabasePath
                    Try
                        dbconn.Open()
                    Catch ex As Exception
                        MsgBox(Convert.ToString(ex), vbCritical, "Error")
                    End Try
                    Try
                        Dset.Tables.Add(Dtable)
                    Catch ex As Exception
                        'MsgBox(Convert.ToString(ex), vbCritical,"Error")
                    End Try
                    Dadapter = New OleDbDataAdapter(str3, dbconn)
                    cb = New OleDbCommandBuilder(Dadapter) With {
                        .QuotePrefix = "[",
                        .QuoteSuffix = "]"
                    }
                    Dadapter.Fill(Dtable)
                    dbconn.Close()
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Public Sub InventoryEdit(ByRef dgv As DataGridView)

        If ToolRoom.DGVInventory.RowCount = 0 Then
            Exit Sub
        Else

            'declare relevant variables
            Dim i As Integer = dgv.CurrentRow.Index
            Dim EditQTY As String
            Dim EditMaxBinSize As String
            Dim EditMinBinSize As String
            Dim loopflag As Boolean = False
            Dim Quantity As String = dgv(0, i).Value
            Dim Tool As String = dgv(1, i).Value
            Dim MaxBinSize As String = dgv(2, i).Value
            Dim MinBinSize As String = dgv(3, i).Value
            Dim OrderPlaced As String = dgv(4, i).Value
            Dim tcost As Decimal
            Dim toolsplit() As String = Split(Tool, " ")
            Dim size As String = toolsplit(0)

            Select Case size
                Case "1/8"
                    tcost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "3/16"
                    tcost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "15/64"
                    tcost = My.Settings.fifteensixtyfourths + My.Settings.Tfifteensixtyfourths
                Case "1/4"
                    tcost = My.Settings.onefourth + My.Settings.Tonefourth
                Case "5/16"
                    tcost = My.Settings.fivesixteenths + My.Settings.Tfivesixteenths
                Case "3/8"
                    tcost = My.Settings.threeeighths + My.Settings.Tthreeeighths
                Case "7/16"
                    tcost = My.Settings.sevensixteenths + My.Settings.Tsevensixteenths
                Case "1/2"
                    tcost = My.Settings.onehalf + My.Settings.Tonehalf
                Case "5/8"
                    tcost = My.Settings.fiveeighths + My.Settings.Tfiveeighths
                Case "3/4"
                    tcost = My.Settings.threefourths + My.Settings.Tthreefourths
                Case "11/64"
                    tcost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "3/32"
                    tcost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "9/64"
                    tcost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "5/64"
                    tcost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "11/32"
                    tcost = My.Settings.threeeighths + My.Settings.Tthreeeighths
                Case "5/32"
                    tcost = My.Settings.threesixteenths + My.Settings.Tthreesixteenths
                Case "13/64"
                    tcost = My.Settings.fifteensixtyfourths + My.Settings.Tfifteensixtyfourths
                Case "7/64"
                    tcost = My.Settings.oneeighth + My.Settings.Toneeighth
                Case "7/32"
                    tcost = My.Settings.fifteensixtyfourths + My.Settings.Tfifteensixtyfourths
                Case "9/32"
                    tcost = My.Settings.fivesixteenths + My.Settings.Tfivesixteenths
                Case "test"
                    tcost = 123.45
            End Select

            'ask user to confirm whether or not they would like to edit the record
            Dim result As String = MsgBox("Are you sure you would like to edit this record for (" & Quantity & ") pcs. of (" & Tool & ")?", vbYesNo + vbInformation, "Edit this order?")
            If result = vbYes Then
                dbconn.Close()

                'Ask user to input new values if they so choose. leaving the input box blank will keep the same original value as before the edit command was invoked
                EditQTY = InputBox("Please enter new quantity. Old quantity is: (" & Quantity & ")", "New Quantity")
                EditMaxBinSize = InputBox("Please enter new maximum bin size. Old maximum bin size is: (" & MaxBinSize & ")", "New Max Bin Size")
                EditMinBinSize = InputBox("Please enter new minimum bin size. Old minimum bin size is: (" & MinBinSize & ")", "New Min Bin Size")

                'since there are only two options for order placed the user is asked if they would like to change it to the other option or not (Toggle)
                '****functionality for changing the order placed field was removed due to the fact that the user should not have access to this****
                'EditOrderPlaced = MsgBox("Change order status? Current status is: (" & OrderPlaced & ")", vbYesNo + vbQuestion, "Order Status")

                'handles the toggling of the order placed field
                'If EditOrderPlaced = vbYes Then
                'If OrderPlaced = "Y" Then
                'EditOrderPlaced = "N"
                'ElseIf OrderPlaced = "N" Then
                'EditOrderPlaced = "Y"
                'End If
                'ElseIf EditOrderPlaced = vbNo Then
                'EditOrderPlaced = OrderPlaced
                'End If

                'loop to check if the new quantity is blank (Keep old value) or if it is not numeric (Get user to re-input value) runs until value is either blank or numeric
                Do
                    Select Case EditQTY
                        Case ""
                            EditQTY = Quantity
                            loopflag = True
                            Exit Select
                        Case Else
                            If IsNumeric(EditQTY) = False Then
                                MsgBox("New quantity (" & EditQTY & ") must be a valid number.", vbCritical, "Error")
                                EditQTY = InputBox("Please enter new quantity. Old quantity is: (" & Quantity & ")", "New Quantity")
                                loopflag = False
                            ElseIf IsNumeric(EditQTY) = True Then
                                loopflag = True
                            End If
                    End Select
                Loop Until loopflag = True

                'loop to check if the max bin size is blank (Keep old value) or if it is not numeric (Get user to re-input value) runs until value is either blank or numeric
                Do
                    Select Case EditMaxBinSize
                        Case ""
                            EditMaxBinSize = MaxBinSize
                            loopflag = True
                            Exit Select
                        Case Else
                            If IsNumeric(EditMaxBinSize) = False Then
                                MsgBox("New max bin size (" & EditMaxBinSize & ") must be a valid number.", vbCritical, "Error")
                                EditMaxBinSize = InputBox("Please enter new max bin size. Old max bin size is: (" & MaxBinSize & ")", "New Max Bin Size")
                                loopflag = False
                            ElseIf IsNumeric(EditMaxBinSize) = True Then
                                loopflag = True
                            End If
                    End Select
                Loop Until loopflag = True

                'loop to check if the min bin size is blank (Keep old value) or if it is not numeric (Get user to re-input value) runs until value is either blank or numeric
                Do
                    Select Case EditMinBinSize
                        Case ""
                            EditMinBinSize = MinBinSize
                            loopflag = True
                            Exit Select
                        Case Else
                            If IsNumeric(EditMinBinSize) = False Then
                                MsgBox("New min bin size (" & EditMinBinSize & ") must be a valid number", vbCritical, "Error")
                                EditMinBinSize = InputBox("Please enter new min bin size. Old min bin size is: (" & MinBinSize & ")", "New Min Bin Size")
                                loopflag = False
                            ElseIf IsNumeric(EditMinBinSize) = True Then
                                loopflag = True
                            End If
                    End Select
                Loop Until loopflag = True

                'Update the Tool Room Inventory table record for the current tool and change the values that the user specified
                Dim Str As String = "UPDATE [ToolRoomInventory] set [Quantity] = " & EditQTY & ", [Max Bin Size] = " & EditMaxBinSize & ", [Min Bin Size] = " & EditMinBinSize & ", [Date Updated] = '" & Date.Now & "',[Cost] = '" & (tcost * EditQTY) & "' WHERE [Tool] = '" & Tool & "'"
                dbconn.ConnectionString = My.Settings.DatabasePath
                Try
                    dbconn.Open()
                Catch ex As Exception
                    MsgBox(Convert.ToString(ex), vbCritical, "Error")
                End Try
                Try
                    Dset.Tables.Add(Dtable)
                Catch ex As Exception
                    'MsgBox(Convert.ToString(ex), vbCritical,"Error")
                End Try
                Dadapter = New OleDbDataAdapter(Str, dbconn)
                Dim cb = New OleDbCommandBuilder(Dadapter) With {
                    .QuotePrefix = "[",
                    .QuoteSuffix = "]"
                }
                Dadapter.Fill(Dtable)
                dbconn.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Public Sub SearchInventory(ByRef dgv As DataGridView, ByRef tb As TextBox)
        Dim tool As String
        Dim toolfound As Boolean = False
        Dim i As Integer = 0

        If dgv.Rows.Count = 0 Then
            Exit Sub
        End If
        'checks if the text box is blank and informs user that the text box cannot be blank. if it is not blank then set the tool variable to the text box text
        If tb.Text = "" Then
            MsgBox("The search text box cannot be blank. Please enter a tool name to search.", vbCritical, "Error")
            Exit Sub
        Else
            tool = tb.Text
        End If

        'use do loop to check each record and compare the tool name to the tool variable
        Do

            'if the tool variable is equal to current datagridview row being checked then select that row and set the toolfound flag to true
            If tool = dgv(1, i).Value Then
                dgv(1, i).Selected = True
                toolfound = True
            End If
            i = i + 1
        Loop Until i = dgv.RowCount

        'if the toolfound flag is false then the tool was not found in the list. the user is informed of this.
        If toolfound = False Then
            MsgBox("Tool was not found in inventory.", vbCritical, "Tool Not found!")
        End If

    End Sub

    Public Sub DGVUpdate(ByRef dgv As DataGridView)
        'clear dataset to remove data from tables
        Dset.Clear()
        Dim i As Integer = 0
        'declare an item to hold a value from the datatable for later use
        Dim dbitem As String
        Dim str As String = "SELECT * FROM [ToolRoomInventory]"
        dbconn.ConnectionString = My.Settings.DatabasePath

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try
        Try
            Dset.Tables.Add(Dtable)
            Dtable.Clear()
        Catch ex As Exception
            ' MsgBox(Convert.ToString(ex),vbcritical,"Error")
        End Try
        Dadapter = New OleDbDataAdapter(str, dbconn)
        Dim cb = New OleDbCommandBuilder(Dadapter) With {
            .QuotePrefix = "[",
            .QuoteSuffix = "]"
        }

        Try
            Dadapter.Fill(Dtable)
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try

        'run through each item in the data grid view using a for loop
        For Each item In dgv.Rows
            dbitem = Dtable.Rows(i).Item(10).ToString
            'compare the date column of the datagridview with the date column in the database. If they don't match then update the inventory datagridview on the monitoring screen
            If (dgv(5, i).Value) <> (dbitem) Then
                Monitoring.ToolRoomInventoryTableAdapter.Fill(Monitoring.Tool_Cutter_DatabaseDataSet.ToolRoomInventory)
                Exit For
            End If
            i = i + 1
        Next
        dbconn.Close()
    End Sub

    Public Function Admincheck()
        Dim adminresult As String
        dbconn.Close()
        Dset.Clear()

        'SQL statement used to compare the computers domain name (Environment.Username) with the username field in the database
        Dim str As String = "SELECT * FROM [Users] WHERE [Username]= '" & Environment.UserName & "' AND [Admin]= ""Y"""
        dbconn.ConnectionString = My.Settings.DatabasePath
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try
        Try
            Dset.Tables.Add(Dtable)
        Catch ex As Exception
            ' MsgBox(Convert.ToString(ex),vbcritical,"Error")
        End Try
        Dadapter = New OleDbDataAdapter(str, dbconn)
        Dim cb = New OleDbCommandBuilder(Dadapter) With {
            .QuotePrefix = "[",
            .QuoteSuffix = "]"
        }

        Try
            Dadapter.Fill(Dtable)
        Catch ex As Exception
            MsgBox(Convert.ToString(ex), vbCritical, "Error")
        End Try

        'Count the number of results in the datatable. There should be only 1 result as each computer has a different name. If there is a result the user is registered.
        If Dtable.Rows.Count = 1 Then
            adminresult = "Y"
        Else
            adminresult = "N"
        End If
        dbconn.Close()
        Return adminresult
    End Function

    Public Sub NewInventoryItem()
        dbconn.Close()
        Dset.Clear()
        Dim Qty As String
        Dim ToolName As String
        Dim MaxBin As String
        Dim MinBin As String
        Dim DateUpdated As String

        Dim result As String = MsgBox("Are you sure you would like to add a new tool?", vbYesNo + vbInformation, "Create New Tool?")
        Dim loopflag As Boolean = False

        If result = vbYes Then

            'gather information from user. use do loops to make sure user inputs information that wont break the program
            Do
                Do
                    ToolName = InputBox("Please input new tool name below", "Name...")
                Loop Until ToolName <> ""
                Do
                    Qty = InputBox("Please input quantity on hand below", "Quantity...")
                Loop Until IsNumeric(Qty) = True
                Do
                    MaxBin = InputBox("Please input maximum bin size below", "Max Bin...")
                Loop Until IsNumeric(MaxBin) = True
                Do
                    MinBin = InputBox("Please input minimum bin size below", "Min Bin...")
                Loop Until IsNumeric(MinBin) = True

                loopflag = True
                DateUpdated = Date.Now
            Loop Until loopflag = True

            'Following code used to insert new tool order in the database
            Dim str As String = "INSERT INTO [ToolRoomInventory] ([Quantity], [Tool], [Max Bin Size], [Min Bin Size], [Order Placed], [Date Updated]) VALUES (" & Qty & ", '" & ToolName & "', '" & MaxBin & "', '" & MinBin & "', ""N"", '" & DateUpdated & "')"
            dbconn.ConnectionString = My.Settings.DatabasePath
            Try
                dbconn.Open()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex), vbCritical, "Error")
            End Try
            Try
                Dset.Tables.Add(Dtable)
            Catch ex As Exception
                ' MsgBox(Convert.ToString(ex), vbCritical,"Error")
            End Try
            Dadapter = New OleDbDataAdapter(str, dbconn)
            Dim cb = New OleDbCommandBuilder(Dadapter) With {
                .QuotePrefix = "[",
                .QuoteSuffix = "]"
            }

            Try
                Dadapter.Fill(Dtable)
            Catch ex As Exception
                MsgBox(Convert.ToString(ex), vbCritical, "Error")
            End Try
            dbconn.Close()
        Else
            Exit Sub
        End If
    End Sub

    Public Sub Searchorders(ByRef dgv As DataGridView, ByRef tb As TextBox)
        Dim tool As String
        Dim toolfound As Boolean = False
        Dim i As Integer = 0

        'checks if the text box is blank and informs user that the text box cannot be blank. if it is not blank then set the tool variable to the text box text
        If tb.Text = "" Then
            MsgBox("The search text box cannot be blank. Please enter a tool name to search.", vbCritical, "Error")
            Exit Sub
        Else
            tool = tb.Text
        End If

        'use do loop to check each record and compare the tool name to the tool variable
        Do

            'if the tool variable is equal to current datagridview row being checked then select that row and set the toolfound flag to true
            If dgv.Rows.Count <> 0 Then
                If tool = dgv(1, i).Value Then
                    dgv(1, i).Selected = True
                    toolfound = True
                End If
                i = i + 1
            End If

        Loop Until i = dgv.RowCount

        'if the toolfound flag is false then the tool was not found in the list. the user is informed of this.
        If toolfound = False Then
            MsgBox("Tool was not found in orders.", vbCritical, "Tool Not found!")
        End If
    End Sub
End Module

Public Module GlobalVariables
    'Global variable created in order to be used across all forms which signals certain subs to update dgv's
    Public UpdateRequired As Boolean
End Module
