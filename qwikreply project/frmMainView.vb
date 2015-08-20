Imports System.Net 'imports the system.net framework
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading

Public Class frmMainView
    Private strReturnData As String
    Private IncomingIPAddress As String
    'create a server thread 
    Private RemoteIpEndPoint As New IPEndPoint(System.Net.IPAddress.Any, 0)
    'get Ip and port of incoming data 
    Private udpClient As New UdpClient(8080) 'create a variable called udpclient and assign it to port 8080
    Public thdUDPServer = New Thread(New ThreadStart(AddressOf ServerThread))

    Private Sub ServerThread()
        While True 'infinate loop

            Dim bytDataIn() As Byte
            bytDataIn = udpClient.Receive(RemoteIpEndPoint)
            strReturnData = System.Text.Encoding.ASCII.GetString(bytDataIn)
            UpdateForm() 'update the form when received data is dectet

        End While
    End Sub

    Private Sub UpdateForm()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf UpdateForm))
        Else

            ' IncomingIPAddress = RemoteIpEndPoint.Address.ToString
            Dim dataParts As String() = strReturnData.Split("^")
            Dim messageString As String = dataParts(0) & " said (on " & dataParts(1) & ", at  " & dataParts(2) & ") : " & dataParts(3)
            '            lbTextIn.Items.Add(IncomingIPAddress & " : " & strReturnData)
            lbTextIn.Items.Add(messageString)
        End If
    End Sub


    'Private Sub ReadData()
    '    Dim bytReceivedBytes() As Byte
    '    ' connect to endpoint ip and read in data into byte array
    '    bytReceivedBytes = udpClient.Receive(RemoteIpEndPoint)
    '    'convert incoming bytes to a string
    '    strReturnData = System.Text.Encoding.ASCII.GetString(bytReceivedBytes)

    '    lbTextIn.Items.Add(strReturnData)
    '    'recicived data is input into the list box 
    '    lbTextIn.Text = strReturnData
    '    'get the IP address of the incoming remote end-point and convert it into a string 
    '    IncomingIPAddress = RemoteIpEndPoint.Address.ToString
    'End Sub

    Private Sub createFile(strFileName As String)
        'the streamwriter only writes files not reads them only text files 
        Dim swWriteToFile As StreamWriter

        Dim blnCheck As Boolean
        'this checks if the files already exists on the system at the specified location 
        blnCheck = File.Exists(strFileName)

        If blnCheck = False Then
            'if file does not exist create a new one 
            swWriteToFile = File.CreateText(strFileName)
        Else
            'if file already exists add (append) text to it 
            swWriteToFile = File.AppendText(strFileName)
        End If

        With swWriteToFile
            .WriteLine(lbTextIn.Text)
            .Flush() 'clears out buffers 
            .Close() 'closes application 
        End With

    End Sub


    Private Sub SendData()

        'first declare  a variable to allow the the desttination Ip address to be sent to a port
        Dim strDestIPAddress As String = tbDestIPAddress.Text
        ' decalre a port for the data to sent to in this case 8080
        Dim intPort As Integer = 8080
        ' decalare a varibale for the data to be sent 
        Dim strTextToSend As String = ""
        strTextToSend = tbUserName.Text & "^" & Now.ToString("dd/MM/yyyy") & "^" & Now.ToString("HH:mm") & "^" & tbTextToSend.Text
        'strTextToSend = tbContactName.Text & "^" & DateAndTime.Now & "^" & tbTextToSend.Text
        'Add outgoing message to the listbox...
        lbTextIn.Items.Add(tbContactName.Text & " said:" & tbTextToSend.Text)


        'connect the updclient to the destion ip address and the port number 8080 
        udpClient.Connect(strDestIPAddress, intPort)

        'now convert the data into bytes using the ASCII tables 

        Dim bytASCIIBytes() As Byte
        ' assign the text TextToSend as the data to which it will be convetred into bytes 
        bytASCIIBytes = System.Text.Encoding.ASCII.GetBytes(strTextToSend)

        ' allow the updclient to send the data in the from of bytes from the TextToSend string called bytASCIIBytes. 
        udpClient.Send(bytASCIIBytes, bytASCIIBytes.Length)



    End Sub

    Private Sub SaveConvoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveConvoToolStripMenuItem.Click

        With SaveFileDialog1

            .Title = "Select text file to create and save"
            '* = any thing can be written ,| = seperates the text from extension
            .Filter = "Standard Text File (*.txt) | *.txt"
            'file name blank
            .FileName = ""

            .ShowDialog() 'show the form 

        End With

        'createFile(SaveFileDialog1.FileName)

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' 
            Dim sw As New StreamWriter(SaveFileDialog1.FileName)

            For Each item As String In lbTextIn.Items ' write converstation into the file 
                sw.WriteLine(item) 'each line until there is no more data to write 
            Next
            sw.Close() 'close  the sw variable assigned to the varaibale streamwriter

            MsgBox("Conversation saved") 'display message converstaion saved 
        End If

        


    End Sub
    Private Sub ReadFile(strFilename As String)
        'create a streamreader and assign it a file to open and read
        Dim srFileReader As StreamReader = New StreamReader(strFilename)
        'read in text from file and copy to the text-box

        lbTextIn.Text = srFileReader.ReadToEnd() 'read each line of data untill there is no more data to read in the label

        'close streamreader object
        srFileReader.Close()



    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Me.Hide() 'hide the current form
        frmSettings.ShowDialog() 'show the form
    End Sub

    Private Sub ContactsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactsToolStripMenuItem.Click
        Me.Hide() 'hide the cuurent form
        frmContactList.ShowDialog() 'show the form 
    End Sub

    Private Function CheckIp(ByVal ipaddress As String) As Boolean


        '        Return System.Net.IPAddress.TryParse(ipaddress, Nothing)

        'check ip function uses split to divide the ip address into four parts 
        Dim tempInt As Integer
        Dim ipParts As String() = ipaddress.Split(".")

        'if the ip address is equal to 4 then be false 
        If ipParts.Length <> 4 Then Return False



        ' a if statment part a states that if not interget then convert ip parts into integer
        For i = 0 To 3
            If Not Integer.TryParse(ipParts(i), tempInt) Or tempInt < 0 Or tempInt > 255 Then
                Return False
            End If
        Next

        'check for  >223 
        If Val(ipParts(0)) > 233 Then
            Return False
        End If
        'check for 0.0.0.0
        If ipaddress = "0.0.0.0" Then
            Return False
        End If

        Return True
        'boolean if ipaddress is = "any number given" then return false if true end statement 

        'check for 255.255.255.255

        If ipaddress = "255.255.255.255" Then
            Return False
        End If

        Return True

    End Function

    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Enter

        'create a if statement to check the IP 
        If CheckIp(tbDestIPAddress.Text) = False Then
            MsgBox("Invalid IP Address") 'if result is false then display a invalid IP address statement 
        ElseIf tbTextToSend.Text = "" Then 'if no text to send then display msgbox 
            MsgBox("Please enter a message to send")
            tbTextToSend.Focus()
        Else
            SendData() 'send the data
            tbTextToSend.Clear()
        End If

    End Sub

    Private Sub tbQuit_Click(sender As System.Object, e As System.EventArgs) Handles tbQuit.Click
        'Raises a ThreadAbortException in the thread on which it is invoked, to begin the process of terminating the thread. 
        'Calling this method usually terminates the thread.
        thdUDPServer.abort()
        udpClient.Close() 'close the UDPClient 
        udpClient = Nothing ' UDPClient clear 
        Application.Exit() 'exit the application or form 
    End Sub

    Private Sub OpenConversationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenConversationToolStripMenuItem.Click

        With OpenFileDialog1

            .Title = "Select  a file to open and read"
            '* = any thing can be written ,| = seperates the text from extension
            .Filter = "Standard Text File (*.txt) | *.txt"
            'file name blank
            .FileName = ""
        End With


        'only do this if the user actually chose a file
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            lbTextIn.Items.Clear()
            ''ReadFile(OpenFileDialog1.FileName)
            Dim sr As New StreamReader(OpenFileDialog1.FileName)
            While sr.Peek <> -1
                lbTextIn.Items.Add(sr.ReadLine)
            End While
            sr.Close() 'close the sr variable 
        End If
    End Sub

    Private Sub btnClearConvo_Click(sender As System.Object, e As System.EventArgs) Handles btnClearConvo.Click
        lbTextIn.Items.Clear() 'clear the items in the listBox 
    End Sub

    Private Sub frmMainView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load    
        thdUDPServer.start() 'as soon as program starts start the variable thdudpServer
        tbUserName.Text = "Ali" 'the username will always be Ali in the assigned textbox 
    End Sub

End Class

