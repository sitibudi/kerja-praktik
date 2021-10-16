
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Public Class Form1
    Dim myPort As Array  'COM Ports detected on the system will be stored here
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data

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
        SerialPort1.Close()             'Close our Serial Port

        Connected.Enabled = True
        Disconnected.Enabled = False
    End Sub

    Private Sub Command_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
