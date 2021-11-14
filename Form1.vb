
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports System.ConsoleKey
Imports RepeatButton
Public Class Form1
    Dim myPort As Array  'COM Ports detected on the system will be stored here
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    Dim i, barisan, relX, relY, posX1, posY1, posX2, posY2, sudut, pena, arah As Integer
    Function sdt2rad(sdt As Integer) As Double
        Dim hsl As Double = Math.PI * sdt / 180
        sdt2rad = hsl
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When our form loads, auto detect all serial ports in the system and populate the Port Combo box.
        myPort = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available
        Baud.Items.Add(9600)     'Populate the Baud Combo box to common baud rates used   
        Baud.Items.Add(19200)
        Baud.Items.Add(38400)
        Baud.Items.Add(57600)
        Baud.Items.Add(115200)

        For i = 0 To UBound(myPort)
            Port.Items.Add(myPort(i))
        Next
        Port.Text = Port.Items.Item(0)    'Set Port text to the first COM port detected
        Baud.Text = Baud.Items.Item(0)    'Set Baud text to the first Baud rate on the list

        Disconnected.Enabled = False           'Initially Disconnect Button is Disabled
    End Sub
    Private Sub Port_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Port.SelectedIndexChanged

    End Sub

    Private Sub Connected_Click(sender As Object, e As EventArgs) Handles Connected.Click
        SerialPort1.PortName = Port.Text         'Set SerialPort1 to the selected COM port at startup
        SerialPort1.BaudRate = Baud.Text         'Set Baud rate to the selected value on 

        'Other Serial Port Property
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8            'Open our serial port
        SerialPort1.Open()

        Connected.Enabled = False          'Disable Connect button
        Disconnected.Enabled = True        'and Enable Disconnect button
    End Sub

    Private Sub Disconnected_Click(sender As Object, e As EventArgs) Handles Disconnected.Click
        SerialPort1.Close()             'Close our Serial Por'
        Connected.Enabled = True
        Disconnected.Enabled = False
    End Sub

    Private Sub Command_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub segitiga(psdt As Integer, np As Byte)
        Dim xa, ya, xb, yb, xc, yc As Integer
        Dim msudut As Integer = psdt + 90
        xa = posX1 + (-5) * Math.Cos(sdt2rad(msudut)) ' - 0 * Math.Sin(sdt2rad(msudut))
        ya = posY1 + (-5) * Math.Sin(sdt2rad(msudut)) ' + 0 * Math.Cos(sdt2rad(msudut))
        xb = posX1 + (+5) * Math.Cos(sdt2rad(msudut)) ' - 0 * Math.Sin(sdt2rad(msudut))
        yb = posY1 + (+5) * Math.Sin(sdt2rad(msudut)) ' + 0 * Math.Cos(sdt2rad(msudut))
        xc = posX1 - ((-5) * Math.Sin(sdt2rad(msudut))) ' 0 * Math.Cos(sdt2rad(msudut)) - ((-5) * Math.Sin(sdt2rad(msudut)))
        yc = posY1 + ((-5) * Math.Cos(sdt2rad(msudut))) '0 * Math.Sin(sdt2rad(msudut)) + ((-5) * Math.Cos(sdt2rad(msudut)))
    End Sub
    Private Sub penanaik()
        pena = 0
    End Sub
    Private Sub penaturun()
        pena = 1
    End Sub

    Private Sub maju(jarak As Integer)
        segitiga(sudut, 0) 'hapus segitga
        posX2 = posX1 + (jarak * Math.Cos(sdt2rad(arah)))
        posY2 = posY1 + (jarak * Math.Sin(sdt2rad(arah)))

        posY1 = posY2
        posX1 = posX2
        segitiga(sudut, 1) 'gambar segitiga
        'Me.Refresh()
    End Sub
    Private Sub mundur(jarak As Integer)
        segitiga(sudut, 0) 'hapus segitga
        posX2 = posX1 - (jarak * Math.Cos(sdt2rad(arah)))
        posY2 = posY1 - (jarak * Math.Sin(sdt2rad(arah)))

        posY1 = posY2
        posX1 = posX2
        segitiga(sudut, 1) 'gambar segitiga
        'Me.Refresh()
    End Sub
    Private Sub kiri(sdt As Integer)
        segitiga(sudut, 0) 'hapus segitga
        sudut = -90 - sdt
        arah = arah - sdt
        arah = arah Mod 360
        segitiga(sudut, 1) 'gambar segitga
    End Sub
    Private Sub kanan(sdt As Integer)
        segitiga(sudut, 0) 'hapus segitga
        sudut = -90 + sdt
        arah = arah + sdt
        arah = arah Mod 360
        segitiga(sudut, 1) 'gambar segitga
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = proses.Text & "," & TextBox2.Text

    End Sub
End Class
