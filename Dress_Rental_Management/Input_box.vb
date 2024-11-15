Public Class Input_box
    Private Sub payment_change_Click(sender As Object, e As EventArgs) Handles payment_change.Click
        If IsNumeric(TextBox1.Text) AndAlso Val(TextBox1.Text) > 0 Then
            payment = Val(TextBox1.Text)
            Me.Close()
        End If
    End Sub

    Private Sub payment_change_LostFocus(sender As Object, e As EventArgs) Handles payment_change.LostFocus
        btnlostfocus(sender)
    End Sub

    Private Sub payment_change_GotFocus(sender As Object, e As EventArgs) Handles payment_change.GotFocus
        btngotfocus(sender)
    End Sub
End Class