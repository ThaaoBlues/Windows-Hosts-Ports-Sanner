﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.clock_hosts = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'clock_hosts
        '
        Me.clock_hosts.Enabled = True
        Me.clock_hosts.Interval = 5000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(432, 31)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(356, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(11, 60)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(224, 304)
        Me.CheckedListBox1.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(432, 60)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(356, 304)
        Me.TreeView1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Start scan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 26)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Hosts discovery(ping)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(11, 29)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(224, 25)
        Me.ProgressBar2.TabIndex = 6
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bases IP to use :"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(243, 60)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(183, 94)
        Me.CheckedListBox2.TabIndex = 8
        '
        'BackgroundWorker2
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(686, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "8888"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(618, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Port range :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 25)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Hosts discovery(ARP table)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "IP to MAC :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(277, 193)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "IP :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "MAC :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(277, 222)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 20)
        Me.TextBox3.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(277, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 21)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Get MAC"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(144, 401)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 26)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Copy selected IP"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "IP to Hostname (and Revese) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "IP :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(277, 370)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(143, 20)
        Me.TextBox5.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(238, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "host :"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(277, 401)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 21)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Convert"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(277, 293)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 71)
        Me.TextBox4.TabIndex = 25
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(618, 401)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(170, 21)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "Save scan"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(512, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(429, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Scanning port :"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(432, 424)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(180, 21)
        Me.Button8.TabIndex = 29
        Me.Button8.Text = "Cancel scan"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(618, 424)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(170, 21)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "Pause scan"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(537, 371)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(143, 20)
        Me.TextBox7.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(429, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Select a specific IP :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(686, 375)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "Use the specified IP."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 453)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "Network Scanner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clock_hosts As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
