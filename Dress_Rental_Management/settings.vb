Public Class settings
    Private Sub sh_nme_KeyDown(sender As Object, e As KeyEventArgs) Handles sh_nme.KeyDown, sh_GST.KeyDown, sh_addr.KeyDown
        If (e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Alt) OrElse e.KeyCode = Keys.Enter Then
            Navigation(sender.TabIndex, e, Me, True, True)
        End If
    End Sub

    Private Sub Sveshop_Click(sender As Object, e As EventArgs) Handles Sveshop.Click
        Dim d As New daoclass
        Dim utype As String = ""
        Dim re As SqlClient.SqlDataReader
        re = d.getdata("Select E_role from user_master where E_shop = " & Emp_shop_ID & " and E_mailID = '" & Admail.Text & "' and E_Pass_wrd = '" & Adpwd.Text & "'")
        While re.Read
            utype = re.Item(0)
        End While
        d.closeconn()
        If utype = "Admin" Then
            Dim p(4), v(4) As String
            p = {"@name", "@addr", "@mail", "@gst"}
            v = {sh_nme.Text, sh_addr.Text, sh_mail.Text, sh_GST.Text}
            d.editdata("Update shop_master set s_nme = @name, s_addr = @addr, s_email = @mail,s_gstno = @gst where ID = " & Emp_mailID)
            ReDim p(2), v(2)
            p = {"@mail", "@pwd"}
            v = {sh_mail.Text, sh_pwd.Text}
            d.editdata("Update user_master set E_mailID = @mail,E_pass_wrd = @pwd where E_shop = " & Emp_shop_ID)
            Emp_mailID = sh_pwd.Text
            d.createlog("Updated shop details")
            settings_Load(sender, e)
        Else
            MessageBox.Show("Invalid Admin Credentials")
        End If
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If User_type = "Admin" Then
            shset.Enabled = True
        End If
        Dim d As New daoclass
        Dim re As SqlClient.SqlDataReader
        re = d.getdata("Select s_nme,s_addr,s_email,s_gstno from shop_master where ID = " & Emp_shop_ID)
        While re.Read
            sh_nme.Text = re.Item(0)
            sh_addr.Text = re.Item(1)
            sh_mail.Text = re.Item(2)
            sh_GST.Text = re.Item(3)
        End While
        d.closeconn()
        If My.Settings.User_pin <> "" Then
            PINset.Text = "Old PIN"
            PINconf.Text = "New PIN"
            PIN_pwd_confirm.Enabled = False
            Delacc.Visible = True
        Else
            mail_lbl.Text = Emp_mailID
        End If
    End Sub

    Private Sub settings_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Employee_Manager.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Logs_master.Show()
        Me.Hide()
    End Sub

    Private Sub Sve_acc_Click(sender As Object, e As EventArgs) Handles Sve_acc.Click
        If PINset.Text = "Old PIN" Then
            If PIN_code_confirm.MaskCompleted Then
                If Val(PIN_code.Text) = decrypt(My.Settings.User_pin) Then
                    My.Settings.User_pin = encrypt(PIN_code_confirm.Text)
                    My.Settings.Save()
                    MessageBox.Show("New PIN set")
                Else
                    MessageBox.Show("Incorrect old PIN")
                    PIN_code.Focus()
                End If
            Else
                MessageBox.Show("Please enter a full 6 digit PIN password")
                PIN_code.Focus()
        End If
        Else
            If PIN_code.MaskCompleted Then
                If Val(PIN_code.Text) = Val(PIN_code_confirm.Text) Then
                    Dim p(2), v(2) As String
                    Dim d As New daoclass
                    Dim e_mail As String = ""
                    Dim obj As SqlClient.SqlDataReader
                    'Checks If User is available
                    p = {"@mail", "@pwd"}
                    v = {mail_lbl.Text, PIN_pwd_confirm.Text}
                    obj = d.getdata("Select E_mailID from user_master where E_mailID=@mail and e_Pass_wrd=@pwd", p, v)
                    While obj.Read
                        e_mail = obj.Item(0)
                    End While
                    d.closeconn()
                    If e_mail <> "" Then
                        'If e-mail returned and e-mail of logged in user is same
                        My.Settings.User_pin = encrypt(PIN_code.Text)
                        My.Settings.Usr_mail = encrypt(mail_lbl.Text)
                        My.Settings.Usr_pwd = encrypt(PIN_pwd_confirm.Text)
                        My.Settings.Save()
                        MessageBox.Show("PIN for current user created")
                    Else
                        MessageBox.Show("Incorrect Password")
                        PIN_pwd_confirm.Focus()
                    End If
                Else
                    MessageBox.Show("Incorrect confirmation string")
                    PIN_code_confirm.Focus()
                End If
            Else
                MessageBox.Show("Please enter a full 6 digit PIN password")
                PIN_code.Focus()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim d As New main_menu
        d.Show()
        Me.Hide()
    End Sub

    Private Sub GoToPurchase_Click(sender As Object, e As EventArgs) Handles GoToPurchase.Click
        Dim d As New purchase_master
        d.Show()
        Me.Hide()
    End Sub

    Private Sub Rental_Return_Click(sender As Object, e As EventArgs) Handles Rental_Return.Click
        Dim d As New Item_Return
        d.Show()
        Me.Hide()
    End Sub

    Private Sub GoToReporting_Click(sender As Object, e As EventArgs) Handles GoToReporting.Click
        Dim d As New Reports
        d.Show()
        Me.Hide()
    End Sub

    Private Sub GoToItemStock_Click(sender As Object, e As EventArgs) Handles GoToItemStock.Click
        Dim d As New Item_Stock
        d.Show()
        Me.Hide()
    End Sub

    Private Sub GoToBilling_Click(sender As Object, e As EventArgs) Handles GoToBilling.Click
        Dim d As New Bill_maker
        d.Show()
        Me.Hide()
    End Sub

    Private Sub Delacc_Click(sender As Object, e As EventArgs) Handles Delacc.Click
        Dim confirm As Integer = MessageBox.Show(
                    "Delete Item PIN and information?",
                    "Deletion confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)
        If confirm = 6 Then
            My.Settings.Reset()
            MessageBox.Show("PIN and information removed")
        End If
    End Sub
End Class