Imports System.Net
Imports System.Net.Sockets
Public Class frmSettings


    Private Sub btnGetMyIPAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetMyIPAddress.Click
        'create a varaiable to enable it to obtain the host name of the machine
        Dim IpHost As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())

        IpHost.AddressList = Array.FindAll(IpHost.AddressList, Function(n As IPAddress) n.AddressFamily = AddressFamily.InterNetwork)

        lblMyIP.Text = IpHost.AddressList(0).ToString


    End Sub
    'Private Function GetMyIPAdress() As String
    '    Dim strMyIpAddress As String

    '    Dim IPHost As IPHostEntry

    '    IPHost = Dns.GetHostEntry(Dns.GetHostName)

    '    strMyIpAddress = IPHost.AddressList(0).ToString

    '    Return strMyIpAddress

    'End Function


    Private Function GetNetworkStatus() As String
        'craetae varaibel blnsatus to check the status of the network
        Dim blnStatus As Boolean

        'using the systems.net imports the code below finds the network satus 
        blnStatus = NetworkInformation.NetworkInterface.GetIsNetworkAvailable

        Return blnStatus.ToString ' returns the value to a string 

    End Function

    Private Sub btnStatus_Click(sender As System.Object, e As System.EventArgs) Handles btnStatus.Click
        'using the systmes imports this variable called get networks status retretives it but the condition must be ture 
        If GetNetworkStatus() = "True" Then
            ' if true the color of the labled will be light sea green 
            lblConnected.BackColor = Color.LightSeaGreen
        Else 'otherwise the color will be red if the condition is false 
            lblConnected.BackColor = Color.Red
        End If

        lblConnected.Text = GetNetworkStatus() 'the text from label is assiged to the varaible get network satus 
    End Sub

    Private Sub btnExitSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnExitSettings.Click
        Me.Close() 'closes the form 
        frmMainView.Show() 'displays the frmMainview form 
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class