<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class telemetry
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
        Me.connector = New System.Windows.Forms.Button()
        Me.COMlist = New System.Windows.Forms.ComboBox()
        Me.BaudList = New System.Windows.Forms.ComboBox()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.s_text = New System.Windows.Forms.TextBox()
        Me.b_text = New System.Windows.Forms.TextBox()
        Me.v_text = New System.Windows.Forms.TextBox()
        Me.t_text = New System.Windows.Forms.TextBox()
        Me.Percent = New System.Windows.Forms.Label()
        Me.Volt = New System.Windows.Forms.Label()
        Me.Celcius = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'connector
        '
        Me.connector.Location = New System.Drawing.Point(1022, 674)
        Me.connector.Name = "connector"
        Me.connector.Size = New System.Drawing.Size(99, 21)
        Me.connector.TabIndex = 0
        Me.connector.Text = "Connect"
        Me.connector.UseVisualStyleBackColor = True
        '
        'COMlist
        '
        Me.COMlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMlist.FormattingEnabled = True
        Me.COMlist.Location = New System.Drawing.Point(812, 675)
        Me.COMlist.Name = "COMlist"
        Me.COMlist.Size = New System.Drawing.Size(99, 21)
        Me.COMlist.TabIndex = 1
        '
        'BaudList
        '
        Me.BaudList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BaudList.FormattingEnabled = True
        Me.BaudList.Items.AddRange(New Object() {"9600", "115200"})
        Me.BaudList.Location = New System.Drawing.Point(917, 674)
        Me.BaudList.Name = "BaudList"
        Me.BaudList.Size = New System.Drawing.Size(99, 21)
        Me.BaudList.TabIndex = 2
        '
        'SerialPort
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.telemetry.My.Resources.Resources.a
        Me.PictureBox3.Location = New System.Drawing.Point(176, 418)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.telemetry.My.Resources.Resources.thermo
        Me.PictureBox2.Location = New System.Drawing.Point(835, 409)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.telemetry.My.Resources.Resources.speed
        Me.PictureBox1.Location = New System.Drawing.Point(303, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(646, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 67)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "km/h"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(518, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 100)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "V"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        's_text
        '
        Me.s_text.BackColor = System.Drawing.SystemColors.MenuText
        Me.s_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.s_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.s_text.ForeColor = System.Drawing.SystemColors.Window
        Me.s_text.Location = New System.Drawing.Point(484, 202)
        Me.s_text.Name = "s_text"
        Me.s_text.Size = New System.Drawing.Size(100, 73)
        Me.s_text.TabIndex = 11
        Me.s_text.Text = "0"
        Me.s_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'b_text
        '
        Me.b_text.BackColor = System.Drawing.SystemColors.MenuText
        Me.b_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.b_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.b_text.ForeColor = System.Drawing.SystemColors.Window
        Me.b_text.Location = New System.Drawing.Point(155, 525)
        Me.b_text.Name = "b_text"
        Me.b_text.Size = New System.Drawing.Size(100, 73)
        Me.b_text.TabIndex = 12
        Me.b_text.Text = "0"
        Me.b_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'v_text
        '
        Me.v_text.BackColor = System.Drawing.SystemColors.MenuText
        Me.v_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.v_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.v_text.ForeColor = System.Drawing.SystemColors.Window
        Me.v_text.Location = New System.Drawing.Point(450, 536)
        Me.v_text.Name = "v_text"
        Me.v_text.Size = New System.Drawing.Size(146, 55)
        Me.v_text.TabIndex = 13
        Me.v_text.Text = "0"
        '
        't_text
        '
        Me.t_text.BackColor = System.Drawing.SystemColors.MenuText
        Me.t_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.t_text.ForeColor = System.Drawing.SystemColors.Window
        Me.t_text.Location = New System.Drawing.Point(826, 525)
        Me.t_text.Name = "t_text"
        Me.t_text.Size = New System.Drawing.Size(100, 73)
        Me.t_text.TabIndex = 14
        Me.t_text.Text = "0"
        Me.t_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Percent
        '
        Me.Percent.AutoSize = True
        Me.Percent.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Percent.ForeColor = System.Drawing.SystemColors.Window
        Me.Percent.Location = New System.Drawing.Point(261, 536)
        Me.Percent.Name = "Percent"
        Me.Percent.Size = New System.Drawing.Size(67, 55)
        Me.Percent.TabIndex = 15
        Me.Percent.Text = "%"
        '
        'Volt
        '
        Me.Volt.AutoSize = True
        Me.Volt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Volt.ForeColor = System.Drawing.SystemColors.Window
        Me.Volt.Location = New System.Drawing.Point(590, 536)
        Me.Volt.Name = "Volt"
        Me.Volt.Size = New System.Drawing.Size(56, 55)
        Me.Volt.TabIndex = 16
        Me.Volt.Text = "V"
        '
        'Celcius
        '
        Me.Celcius.AutoSize = True
        Me.Celcius.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Celcius.ForeColor = System.Drawing.SystemColors.Window
        Me.Celcius.Location = New System.Drawing.Point(938, 536)
        Me.Celcius.Name = "Celcius"
        Me.Celcius.Size = New System.Drawing.Size(78, 55)
        Me.Celcius.TabIndex = 17
        Me.Celcius.Text = "°C"
        '
        'telemetry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1146, 717)
        Me.Controls.Add(Me.Celcius)
        Me.Controls.Add(Me.Volt)
        Me.Controls.Add(Me.Percent)
        Me.Controls.Add(Me.t_text)
        Me.Controls.Add(Me.v_text)
        Me.Controls.Add(Me.b_text)
        Me.Controls.Add(Me.s_text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BaudList)
        Me.Controls.Add(Me.COMlist)
        Me.Controls.Add(Me.connector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "telemetry"
        Me.Text = "telemetry"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents connector As Button
    Friend WithEvents COMlist As ComboBox
    Friend WithEvents BaudList As ComboBox
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents s_text As TextBox
    Friend WithEvents b_text As TextBox
    Friend WithEvents v_text As TextBox
    Friend WithEvents t_text As TextBox
    Friend WithEvents Percent As Label
    Friend WithEvents Volt As Label
    Friend WithEvents Celcius As Label
End Class
