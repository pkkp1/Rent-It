Module DatashareAndMore
    Public Emp_shop_ID As Integer
    Public User_type, Emp_mailID, Emp_nme As String
    Public dsReprt As DataSet
    Public payment As Integer

    Public Sub btngotfocus(ByVal btn As Object)
        btn.bordercolor = Color.FromArgb(152, 6, 58)
        btn.fillcolor = Color.White
        btn.forecolor = Color.FromArgb(152, 6, 58)
    End Sub

    Public Sub btnlostfocus(ByVal btn As Object)
        btn.bordercolor = Color.Transparent
        btn.fillcolor = Color.FromArgb(152, 6, 58)
        btn.forecolor = Color.White
    End Sub

    Public Sub Navigation(tbin As Integer, e As KeyEventArgs, ByVal frm As Form, ByVal bck As Boolean, ByVal fwd As Boolean)
        Dim d As Integer
        If e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Alt AndAlso bck Then
            d = tbin - 1
        ElseIf e.KeyCode = Keys.Enter AndAlso fwd Then
            d = tbin + 1
        End If
        e.Handled = True
        e.SuppressKeyPress = True
        'Nullifies the beep sound you get when you press alt
        Try
            For Each ctrl In frm.Controls
                If ctrl.GetType() Is GetType(Panel) AndAlso ctrl.name <> "nav" Then
                    For Each c In ctrl.Controls
                        If c.TabIndex = d Then
                            c.focus
                            Exit Sub
                        End If
                    Next
                ElseIf ctrl.TabIndex = d Then
                    ctrl.focus()
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AutoSearch(ByRef xcb As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal blnLimitToList As Boolean)
        Dim strFindStr As String = ""
        If e.KeyChar = ChrW(8) Then
            If (xcb.SelectionStart <= 1) Then
                xcb.Text = ""
                Exit Sub
            End If
            If (xcb.SelectionLength = 0) Then
                strFindStr = xcb.Text.Substring(0, xcb.Text.Length - 1)
            Else
                strFindStr = xcb.Text.Substring(0, xcb.SelectionStart - 1)
            End If
        Else
            If (xcb.SelectionLength = 0) Then
                strFindStr = xcb.Text + e.KeyChar
            Else
                strFindStr = xcb.Text.Substring(0, xcb.SelectionStart) + e.KeyChar
            End If

            Dim intIdx As Integer = -1
            ' Search the string in the ComboBox list.  

            intIdx = xcb.FindString(strFindStr)
            If (intIdx <> -1) Then
                xcb.SelectedText = ""
                xcb.SelectedIndex = intIdx
                xcb.SelectionStart = strFindStr.Length
                xcb.SelectionLength = xcb.Text.Length
                e.Handled = True
            Else
                e.Handled = blnLimitToList
            End If
        End If
    End Sub
    Public Function encrypt(ByVal str As String) As String
        Dim encr As String = ""
        Dim chrs() As Char = str
        For i = 0 To chrs.Length - 1
            Dim temp As String = Asc(chrs(i))
            If temp.Length < 3 Then
                temp = "0" & temp
            End If
            encr &= temp
            If i <> chrs.Length - 1 Then
                encr &= " "
            End If
        Next
        Return encr
    End Function
    Public Function decrypt(ByVal str As String) As String
        Dim decr As String = ""
        For Each s As String In str.Split(" ")
            Dim asci As Integer = Val(s)
            If Chr(asci) <> " " Then
                decr &= Chr(asci)
            End If
        Next
        Return decr
    End Function
End Module