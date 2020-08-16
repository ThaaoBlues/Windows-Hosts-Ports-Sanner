Imports System.IO

Public Class Form1
    Dim host As String
    Dim port As Integer
    Dim counter As Integer

    Private Sub scan_hosts(ByVal ip As String)

        Dim strIPAddress As String

        strIPAddress = ip

        Dim split As String() = strIPAddress.Split(".")
        Dim base As String = strIPAddress
        base = base.Replace(split(split.Length - 1), "")
        Me.Invoke(Sub()
                      'safe to access the form or controls in here
                      Me.ProgressBar2.Maximum = 254
                  End Sub)

        For i = 1 To 254
            Me.Invoke(Sub()
                          'safe to access the form or controls in here
                          ProgressBar2.Value = ProgressBar2.Value + 1
                      End Sub)

            If My.Computer.Network.Ping(base & i.ToString, 1) Then
                Try
                    Me.Invoke(Sub()
                                  'safe to access the form or controls in here
                                  Me.CheckedListBox1.Items.Add(System.Net.Dns.GetHostEntry(base & i.ToString).HostName.ToString)
                              End Sub)
                Catch ex As Exception
                End Try

            End If

        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Dim strIPAddress As String

            Try
                strIPAddress = TextBox7.Text
            Catch ex As Exception
                MsgBox("Please Select an IP to scan")
                Return
            End Try
            Dim root = New TreeNode("Hosts")
            TreeView1.Nodes.Add(root)

            TreeView1.Nodes(0).Nodes.Add(New TreeNode(strIPAddress))

            BackgroundWorker1.RunWorkerAsync()
        Else
            Dim strIPAddress As String

            Try
                strIPAddress = Me.CheckedListBox2.CheckedItems(0)
            Catch ex As Exception
                MsgBox("Please Select an IP to scan")
                Return
            End Try
            Dim root = New TreeNode("Hosts")
            TreeView1.Nodes.Add(root)
            For Each host As String In Me.CheckedListBox1.CheckedItems
                TreeView1.Nodes(0).Nodes.Add(New TreeNode(host))
            Next
            BackgroundWorker1.RunWorkerAsync()
        End If


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strIPAddress As String

        Try
            strIPAddress = Me.CheckedListBox2.CheckedItems(0)
        Catch ex As Exception
            MsgBox("Please Select a base IP")
            Return
        End Try
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork



        If CheckBox1.Checked Then
            Dim node As Integer = 0
            Dim max As Integer = TextBox1.Text

            If TextBox7.Text <> "" Then

                Dim host = TextBox7.Text

                Me.Invoke(Sub()
                              'safe to access the form or controls in here
                              Me.ProgressBar1.Maximum = max
                          End Sub)
                Dim hostadd As System.Net.IPAddress
                Try

                    hostadd = System.Net.Dns.GetHostEntry(host).AddressList(0)
                Catch ex As Exception
                    MsgBox("Invalid IP address")
                    Return
                End Try


                For i = 0 To max
                    Me.Invoke(Sub()
                                  'safe to access the form or controls in here
                                  ProgressBar1.Value = i
                                  TextBox6.Text = i
                              End Sub)

                    port = i


                    Dim EPhost As New System.Net.IPEndPoint(hostadd, port)


                    Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork,
                                                           System.Net.Sockets.SocketType.Stream,
                                                           System.Net.Sockets.ProtocolType.Tcp)
                    Try
                        s.Connect(EPhost)
                    Catch
                    End Try
                    If s.Connected Then
                        Me.Invoke(Sub()
                                      'safe to access the form or controls in here
                                      Me.TreeView1.Nodes(0).Nodes(node).Nodes.Add(i)
                                  End Sub)

                    End If

                Next
            Else
                MsgBox("Please Select a base IP")
            End If

        Else
            Dim node As Integer = 0
            Dim max As Integer = TextBox1.Text

            If Me.CheckedListBox1.CheckedItems.Count() <> 1 Then

                For Each host As String In Me.CheckedListBox1.CheckedItems

                    Me.Invoke(Sub()
                                  'safe to access the form or controls in here
                                  Me.ProgressBar1.Maximum = max
                              End Sub)

                    For i = 0 To max
                        Me.Invoke(Sub()
                                      'safe to access the form or controls in here
                                      ProgressBar1.Value = i
                                      TextBox6.Text = i
                                  End Sub)

                        port = i
                        Dim hostadd As System.Net.IPAddress =
                    System.Net.Dns.GetHostEntry(host).AddressList(0)
                        Dim EPhost As New System.Net.IPEndPoint(hostadd, port)
                        Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork,
                                                           System.Net.Sockets.SocketType.Stream,
                                                           System.Net.Sockets.ProtocolType.Tcp)
                        Try
                            s.Connect(EPhost)
                        Catch
                        End Try
                        If s.Connected Then
                            Me.Invoke(Sub()
                                          'safe to access the form or controls in here
                                          Me.TreeView1.Nodes(0).Nodes(node).Nodes.Add(i)
                                      End Sub)

                        End If

                    Next
                    node = node + 1
                Next
            Else
                host = Me.CheckedListBox1.CheckedItems(0)
                Me.Invoke(Sub()
                              'safe to access the form or controls in here
                              Me.ProgressBar1.Maximum = max
                          End Sub)

                For i = 0 To max
                    Me.Invoke(Sub()
                                  'safe to access the form or controls in here
                                  ProgressBar1.Value = i
                                  TextBox6.Text = i
                              End Sub)

                    port = i
                    Dim hostadd As System.Net.IPAddress =
                System.Net.Dns.GetHostEntry(host).AddressList(0)
                    Dim EPhost As New System.Net.IPEndPoint(hostadd, port)
                    Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork,
                                                       System.Net.Sockets.SocketType.Stream,
                                                       System.Net.Sockets.ProtocolType.Tcp)
                    Try
                        s.Connect(EPhost)
                    Catch
                    End Try
                    If s.Connected Then
                        Me.Invoke(Sub()
                                      'safe to access the form or controls in here
                                      Me.TreeView1.Nodes(0).Nodes(node).Nodes.Add(i)
                                  End Sub)

                    End If

                Next
            End If
        End If









    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim addrlist = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList().ToList
        For Each ips In addrlist
            CheckedListBox2.Items.Add(ips.ToString)
        Next
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        For Each ips As String In Me.CheckedListBox2.CheckedItems
            scan_hosts(ips)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text <> "" And TextBox3.Text = "" Then
            Dim ip = TextBox2.Text
            Dim mac = GetMAC(ip)
            TextBox3.Text = mac
        Else
            MsgBox("Please fill the IP case and let the MAC case blank")
            Return
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim IP As String

        Try
            IP = Me.CheckedListBox2.CheckedItems(0)
        Catch ex As Exception
            MsgBox("Please Select an IP to copy")
            Return
        End Try
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(IP)
    End Sub

    Declare Function SendARP Lib "iphlpapi.dll" (
      ByVal DestIP As UInt32, ByVal SrcIP As UInt32,
      ByVal pMacAddr As Byte(), ByRef PhyAddrLen As Integer) As Integer

    Public Shared Function GetMAC(ByVal IPaddress As String) As String

        Dim addr As System.Net.IPAddress = System.Net.IPAddress.Parse(IPaddress)
            Dim mac() As Byte = New Byte(6) {}
            Dim len As Integer = mac.Length
            SendARP(CType(addr.Address, UInt32), 0, mac, len)
            Dim macAddress As String = BitConverter.ToString(mac, 0, len)
        Return macAddress
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckedListBox1.Items.Clear()

        Dim strIPAddress As String

        Try
            strIPAddress = Me.CheckedListBox2.CheckedItems(0)
        Catch ex As Exception
            MsgBox("Please Select a base IP")
            Return
        End Try



        Dim split As String() = strIPAddress.Split(".")
        Dim base As String = strIPAddress
        base = base.Replace(split(split.Length - 1), "")

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("arp.exe", "-a")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        oProcess.WaitForExit()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        For Each line In sOutput.Split(vbNewLine)

            If line.Contains(base) Then
                For Each sep In line.Split(" "c)
                    If sep.Contains(base) Then
                        CheckedListBox1.Items.Add(sep)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox4.Text <> "" And TextBox5.Text = "" Then
            TextBox5.Text = System.Net.Dns.GetHostEntry(TextBox4.Text).HostName.ToString()
        ElseIf TextBox4.Text = "" And TextBox5.Text <> "" Then
            For Each IPs In System.Net.Dns.GetHostEntry(TextBox5.Text).AddressList()
                TextBox4.Text = TextBox4.Text + IPs.ToString + vbNewLine
            Next
        Else
            MsgBox("Please fill only one case")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Me.TreeView1.Nodes.Count = 0 Then
            MsgBox("There is no scan result to save yet.")
            Return
        End If
        Dim thisDate As String
        thisDate = Today
        thisDate = thisDate.ToString.Replace("/", "_")
        MsgBox(Directory.GetCurrentDirectory() + "/" + thisDate + "_scan.txt")
        For Each tn In TreeView1.Nodes
            listnodes(tn)
        Next
    End Sub
    Private Sub listnodes(view As TreeNode)
        Dim indexer As System.IO.StreamWriter
        Dim thisDate As String
        thisDate = Today
        thisDate = thisDate.ToString.Replace("/", "_")
        indexer = My.Computer.FileSystem.OpenTextFileWriter(Directory.GetCurrentDirectory() + "/" + thisDate + "_scan.txt", True)
        For Each tn In view.Nodes
            indexer.WriteLine(tn)
            indexer.Close()
            listnodes(tn)
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("Feature not available yet")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
            MsgBox("Scan has been cancelled")
        Else
            MsgBox("No scan are running")
        End If

    End Sub

End Class
