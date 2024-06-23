Public Class Form1
    Dim btnAlarmOn As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerClock.Enabled = True
        btnAlarmOn = False
    End Sub

    Private Sub TimerClock_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TimerClock.Elapsed
        lblCurrTime.Text = TimeOfDay

        If btnAlarmOn = True Then
            If TimeOfDay = dtpAlarmTime.Text Then
                Dim voice = CreateObject("SAPI.spvoice")
                voice.speak(rtbAlarmMessage.Text)

                btnAlarmOn = False
                lblStatus.ForeColor = Color.Yellow
                lblStatus.Text = "Status:Alarm not set!"
            End If
        End If
       
    End Sub

    Private Sub btnSetAlarm_Click(sender As Object, e As EventArgs) Handles btnSetAlarm.Click
        btnAlarmOn = True
        lblStatus.ForeColor = Color.Red
        lblStatus.Text = "Status:Alarm is set!"
    End Sub
End Class
