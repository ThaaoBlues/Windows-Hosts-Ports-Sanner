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


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim root = New TreeNode("Hosts")
        TreeView1.Nodes.Add(root)
        For Each host As String In Me.CheckedListBox1.CheckedItems
            TreeView1.Nodes(0).Nodes.Add(New TreeNode(host))
        Next
        BackgroundWorker1.RunWorkerAsync()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
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

End Class
