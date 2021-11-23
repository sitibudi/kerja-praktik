<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Connected = New System.Windows.Forms.Button()
        Me.Disconnected = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Port = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Baud = New System.Windows.Forms.ComboBox()
        Me.proses = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Set_Zero = New System.Windows.Forms.Button()
        Me.Ret_Zero = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Connected
        '
        Me.Connected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Connected.Location = New System.Drawing.Point(32, 90)
        Me.Connected.Name = "Connected"
        Me.Connected.Size = New System.Drawing.Size(85, 23)
        Me.Connected.TabIndex = 0
        Me.Connected.Text = "Connected"
        Me.Connected.UseVisualStyleBackColor = False
        '
        'Disconnected
        '
        Me.Disconnected.BackColor = System.Drawing.Color.Red
        Me.Disconnected.Location = New System.Drawing.Point(123, 90)
        Me.Disconnected.Name = "Disconnected"
        Me.Disconnected.Size = New System.Drawing.Size(85, 23)
        Me.Disconnected.TabIndex = 1
        Me.Disconnected.Text = "Disconnected"
        Me.Disconnected.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 14)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(26, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Port"
        '
        'Port
        '
        Me.Port.FormattingEnabled = True
        Me.Port.Location = New System.Drawing.Point(66, 12)
        Me.Port.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(143, 21)
        Me.Port.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Baud Rate"
        '
        'Baud
        '
        Me.Baud.FormattingEnabled = True
        Me.Baud.Location = New System.Drawing.Point(66, 44)
        Me.Baud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Baud.Name = "Baud"
        Me.Baud.Size = New System.Drawing.Size(143, 21)
        Me.Baud.TabIndex = 6
        '
        'proses
        '
        Me.proses.Location = New System.Drawing.Point(16, 281)
        Me.proses.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.proses.Name = "proses"
        Me.proses.Size = New System.Drawing.Size(78, 26)
        Me.proses.TabIndex = 9
        Me.proses.Text = "RUN"
        Me.proses.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.PortName = "COM6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Baud)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Port)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.Disconnected)
        Me.GroupBox1.Controls.Add(Me.Connected)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 125)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'Set_Zero
        '
        Me.Set_Zero.Location = New System.Drawing.Point(38, 155)
        Me.Set_Zero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Set_Zero.Name = "Set_Zero"
        Me.Set_Zero.Size = New System.Drawing.Size(78, 26)
        Me.Set_Zero.TabIndex = 11
        Me.Set_Zero.Text = "Set_Zero"
        Me.Set_Zero.UseVisualStyleBackColor = True
        '
        'Ret_Zero
        '
        Me.Ret_Zero.Location = New System.Drawing.Point(137, 155)
        Me.Ret_Zero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Ret_Zero.Name = "Ret_Zero"
        Me.Ret_Zero.Size = New System.Drawing.Size(78, 26)
        Me.Ret_Zero.TabIndex = 12
        Me.Ret_Zero.Text = "Return_Zero"
        Me.Ret_Zero.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 252)
        Me.TextBox1.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(548, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 297)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 27)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(225, 244)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.proses)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(252, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 317)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Command"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Ret_Zero)
        Me.Controls.Add(Me.Set_Zero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Connected As Button
    Friend WithEvents Disconnected As Button
    Friend WithEvents label1 As Label
    Friend WithEvents Port As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Baud As ComboBox
    Friend WithEvents proses As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Set_Zero As Button
    Friend WithEvents Ret_Zero As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
End Class
