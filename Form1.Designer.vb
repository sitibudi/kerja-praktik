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
        Me.Connected = New System.Windows.Forms.Button()
        Me.Disconnected = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Port = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Baud = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Connected
        '
        Me.Connected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Connected.Location = New System.Drawing.Point(53, 126)
        Me.Connected.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Connected.Name = "Connected"
        Me.Connected.Size = New System.Drawing.Size(128, 35)
        Me.Connected.TabIndex = 0
        Me.Connected.Text = "Connected"
        Me.Connected.UseVisualStyleBackColor = False
        '
        'Disconnected
        '
        Me.Disconnected.BackColor = System.Drawing.Color.Red
        Me.Disconnected.Location = New System.Drawing.Point(189, 126)
        Me.Disconnected.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Disconnected.Name = "Disconnected"
        Me.Disconnected.Size = New System.Drawing.Size(128, 35)
        Me.Disconnected.TabIndex = 1
        Me.Disconnected.Text = "Disconnected"
        Me.Disconnected.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 20)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Port"
        '
        'Port
        '
        Me.Port.FormattingEnabled = True
        Me.Port.Location = New System.Drawing.Point(53, 6)
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(264, 28)
        Me.Port.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Baud Rate"
        '
        'Baud
        '
        Me.Baud.FormattingEnabled = True
        Me.Baud.Location = New System.Drawing.Point(104, 55)
        Me.Baud.Name = "Baud"
        Me.Baud.Size = New System.Drawing.Size(213, 28)
        Me.Baud.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(359, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(266, 484)
        Me.ListBox1.TabIndex = 7
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(631, 6)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(328, 484)
        Me.ListBox2.TabIndex = 8
        '
        'proses
        '
        Me.proses.Location = New System.Drawing.Point(359, 511)
        Me.proses.Name = "proses"
        Me.proses.Size = New System.Drawing.Size(117, 40)
        Me.proses.TabIndex = 9
        Me.proses.Text = "PROSES"
        Me.proses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.proses)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Baud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Port)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Disconnected)
        Me.Controls.Add(Me.Connected)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Connected As Button
    Friend WithEvents Disconnected As Button
    Friend WithEvents label1 As Label
    Friend WithEvents Port As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Baud As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents proses As Button
End Class
