Imports System.IO

Public Class telemetry

    Event dataError()
    Private Sub Telemetry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMlist.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames())
    End Sub
    Private Sub connector_Click(sender As Object, e As EventArgs) Handles connector.Click

        If connector.Text = "Connect" Then
            Try
                SerialPort.PortName = COMlist.SelectedItem
                SerialPort.BaudRate = BaudList.SelectedItem
                SerialPort.Open()
            Catch ex As Exception
                SerialPort.PortName = 0
                SerialPort.BaudRate = 9600
                SerialPort.Close() ' this could throw an error as well, will see
            End Try

            If SerialPort.IsOpen() Then
                connector.Text = "Disconnect"
                COMlist.Enabled = False
                BaudList.Enabled = False
            End If

        ElseIf connector.Text = "Disconnect" Then
            SerialPort.Close()
            connector.Text = "Connect"
            COMlist.Enabled = True
            BaudList.Enabled = True
        End If

    End Sub
    Private Sub PortData(sender As Object, e As EventArgs) Handles SerialPort.DataReceived
        Dim msg As String = ""
        Try
            msg = SerialPort.ReadLine() ' could change
        Catch ex As Exception
            RaiseEvent dataError()
            Return
        End Try
        ' add parser here 
    End Sub

    Private Sub dataErrHandler() Handles Me.dataError
        SerialPort.Close()
        connector.Text = "Connect"
        COMlist.Enabled = True
        BaudList.Enabled = True
    End Sub

End Class
