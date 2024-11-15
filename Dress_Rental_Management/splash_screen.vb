Public Class splash_screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value > 5 AndAlso ProgressBar1.Value < 20 Then
            PictureBox1.Height -= 15
        ElseIf ProgressBar1.Value > 20 Then
            PictureBox1.Height += 15
        End If
        If ProgressBar1.Value = 10 Then
            Dim d As New Bill_out
            d.val = {1, 2, 3, 4, 5, 6, 7}
            d.WindowState = FormWindowState.Minimized
            d.Show()
            d.Hide()
        End If
        If ProgressBar1.Value = 34 Then
            If My.Settings.User_pin <> "" Then
                If Not My.Settings.PIN_as_default Then
                    Dim d As Integer = MessageBox.Show("We have found an existing user." & vbCrLf & "Login using PIN?", "Existin User Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If d = 6 Then
                        PIN_Login.Show()
                        Me.Hide()
                    Else
                        GoTo log
                    End If
                Else
                    PIN_Login.Show()
                    Me.Hide()
                End If
            Else
                GoTo log
            End If
        End If
        Exit Sub
log:
        Timer1.Dispose()
        Me.Hide()
        Login_signup.Show()
    End Sub
End Class