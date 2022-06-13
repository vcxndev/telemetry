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
        Me.speed_lbl = New System.Windows.Forms.Label()
        Me.temp_lbl = New System.Windows.Forms.Label()
        Me.batt_lbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox3.Location = New System.Drawing.Point(151, 416)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.telemetry.My.Resources.Resources.thermo
        Me.PictureBox2.Location = New System.Drawing.Point(151, 229)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.telemetry.My.Resources.Resources.speed
        Me.PictureBox1.Location = New System.Drawing.Point(350, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'speed_lbl
        '
        Me.speed_lbl.AutoSize = True
        Me.speed_lbl.Font = New System.Drawing.Font("Trebuchet MS", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.speed_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.speed_lbl.Location = New System.Drawing.Point(482, 58)
        Me.speed_lbl.Name = "speed_lbl"
        Me.speed_lbl.Size = New System.Drawing.Size(183, 100)
        Me.speed_lbl.TabIndex = 6
        Me.speed_lbl.Text = "999"
        '
        'temp_lbl
        '
        Me.temp_lbl.AutoSize = True
        Me.temp_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.temp_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.temp_lbl.Location = New System.Drawing.Point(296, 244)
        Me.temp_lbl.Name = "temp_lbl"
        Me.temp_lbl.Size = New System.Drawing.Size(106, 76)
        Me.temp_lbl.TabIndex = 7
        Me.temp_lbl.Text = "99"
        '
        'batt_lbl
        '
        Me.batt_lbl.AutoSize = True
        Me.batt_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.batt_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.batt_lbl.Location = New System.Drawing.Point(296, 416)
        Me.batt_lbl.Name = "batt_lbl"
        Me.batt_lbl.Size = New System.Drawing.Size(106, 76)
        Me.batt_lbl.TabIndex = 8
        Me.batt_lbl.Text = "99"
        '
        'telemetry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1146, 717)
        Me.Controls.Add(Me.batt_lbl)
        Me.Controls.Add(Me.temp_lbl)
        Me.Controls.Add(Me.speed_lbl)
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
    Friend WithEvents speed_lbl As Label
    Friend WithEvents temp_lbl As Label
    Friend WithEvents batt_lbl As Label
End Class
