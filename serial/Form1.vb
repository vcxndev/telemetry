Imports System.Random
Imports System.Threading
Public Class telemetry

    Event dataError()
    Private Sub Telemetry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMlist.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames())
    End Sub
    Private Sub connector_Click(sender As Object, e As EventArgs) Handles connector.Click

        If connector.Text = "Connect" Then
            t_text.Text = "35"
            b_text.Text = "97"
            v_text.Text = "60.0"

            Dim r As New Random

            Do While True
                If r.Next(0, 2) Then
                    If Val(v_text.Text) > 60 Then
                        Dim n_v = Val(v_text.Text) - (r.NextDouble() * 2)
                        v_text.Text = n_v
                    Else
                        Dim n_v = Val(v_text.Text) + (r.NextDouble() * 2)
                        v_text.Text = n_v
                    End If

                End If

                If r.Next(0, 2) Then
                    If Val(t_text.Text) < 35 Then
                        Dim n_t = Val(t_text.Text) + r.Next(0, 2)
                        t_text.Text = n_t
                    Else
                        Dim n_t = Val(t_text.Text) - r.Next(0, 2)
                        t_text.Text = n_t
                    End If

                End If

                Application.DoEvents()
                Thread.Sleep(r.Next(20) * 100)
            Loop

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
