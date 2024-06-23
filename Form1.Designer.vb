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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrTime = New System.Windows.Forms.Label()
        Me.dtpAlarmTime = New System.Windows.Forms.DateTimePicker()
        Me.rtbAlarmMessage = New System.Windows.Forms.RichTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSetAlarm = New System.Windows.Forms.Button()
        Me.TimerClock = New System.Timers.Timer()
        CType(Me.TimerClock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Alarm Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alarm Message:"
        '
        'lblCurrTime
        '
        Me.lblCurrTime.AutoSize = True
        Me.lblCurrTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrTime.ForeColor = System.Drawing.Color.Gold
        Me.lblCurrTime.Location = New System.Drawing.Point(320, 30)
        Me.lblCurrTime.Name = "lblCurrTime"
        Me.lblCurrTime.Size = New System.Drawing.Size(152, 39)
        Me.lblCurrTime.TabIndex = 0
        Me.lblCurrTime.Text = "The time"
        '
        'dtpAlarmTime
        '
        Me.dtpAlarmTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpAlarmTime.Location = New System.Drawing.Point(327, 115)
        Me.dtpAlarmTime.Name = "dtpAlarmTime"
        Me.dtpAlarmTime.ShowUpDown = True
        Me.dtpAlarmTime.Size = New System.Drawing.Size(200, 20)
        Me.dtpAlarmTime.TabIndex = 1
        '
        'rtbAlarmMessage
        '
        Me.rtbAlarmMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbAlarmMessage.Location = New System.Drawing.Point(327, 179)
        Me.rtbAlarmMessage.Name = "rtbAlarmMessage"
        Me.rtbAlarmMessage.Size = New System.Drawing.Size(321, 112)
        Me.rtbAlarmMessage.TabIndex = 2
        Me.rtbAlarmMessage.Text = "Owner it's time to wakeUp!"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Yellow
        Me.lblStatus.Location = New System.Drawing.Point(28, 328)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(227, 25)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Status:Alarm is not set"
        '
        'btnSetAlarm
        '
        Me.btnSetAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetAlarm.ForeColor = System.Drawing.Color.Red
        Me.btnSetAlarm.Location = New System.Drawing.Point(327, 328)
        Me.btnSetAlarm.Name = "btnSetAlarm"
        Me.btnSetAlarm.Size = New System.Drawing.Size(158, 35)
        Me.btnSetAlarm.TabIndex = 4
        Me.btnSetAlarm.Text = "Set Alarm"
        Me.btnSetAlarm.UseVisualStyleBackColor = True
        '
        'TimerClock
        '
        Me.TimerClock.Interval = 1000.0R
        Me.TimerClock.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(667, 428)
        Me.Controls.Add(Me.btnSetAlarm)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.rtbAlarmMessage)
        Me.Controls.Add(Me.dtpAlarmTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCurrTime)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Talking Alarm Clock"
        CType(Me.TimerClock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCurrTime As System.Windows.Forms.Label
    Friend WithEvents dtpAlarmTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents rtbAlarmMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnSetAlarm As System.Windows.Forms.Button
    Friend WithEvents TimerClock As System.Timers.Timer

End Class
