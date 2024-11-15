Public Class Login_signup
    Private signsize As Integer = 432
    Private loginsize As Integer = 210
    Private confirm As Boolean = False
    Private invalfield As New Object
    Private Sub Run_Click(sender As Object, e As EventArgs) Handles run_qry.Click
        If run_qry.Text = "Login" Then
            If sh_mail.Text <> "" Then
                If sh_pwd.Text <> "" Then
                    If True Then 'Dummy if so that I can minimise login code
                        Dim p(2), v(2) As String
                        Dim d As New daoclass
                        Dim obj As SqlClient.SqlDataReader
                        'Checks If User is available
                        p = {"@mail", "@pwd"}
                        v = {sh_mail.Text, sh_pwd.Text}
                        obj = d.getdata("Select e_role,E_mailID,E_shop,E_name from user_master where E_mailID=@mail and e_Pass_wrd=@pwd", p, v)
                        While obj.Read
                            User_type = obj.Item(0)   'Stores the role of user
                            Emp_mailID = obj.Item(1)  'Saves employee mail ID in module
                            Emp_shop_ID = obj.Item(2) 'Saves shop ID
                            Emp_nme = obj.Item(3)
                        End While
                        d.closeconn()
                        If User_type <> "" Then
                            'If e-mail and password are correct
                            MessageBox.Show("Welcome " + User_type + vbCrLf + "Enjoy our services")
                            d.closeconn()
                            d.createlog("Logged in")
                            main_menu.Show()
                            Me.Hide()
                        Else
                            'If e-mail and/or password are in-correct
                            ReDim Preserve p(1), v(1)
                            obj = d.getdata("Select e_role from user_master where E_mailID=@mail", p, v)
                            'Checks if atleast user exists in user_master
                            While obj.Read
                                User_type = obj.Item(0)
                            End While
                            d.closeconn()
                            If User_type <> "" Then
                                'If user exists
                                MessageBox.Show("Enter correct password")
                                sh_pwd.Text = ""
                                sh_pwd.Focus()
                            Else
                                'If user does not exist
                                MessageBox.Show("User does not exist")
                                sh_pwd.Text = ""
                                sh_mail.Text = ""
                                sh_mail.Focus()
                            End If
                        End If
                    End If
                Else
                    sh_pwd.BackColor = Color.Coral
                    invalfield = sh_pwd
                    Timer1.Enabled = True
                End If
            Else
                sh_mail.BackColor = Color.Coral
                invalfield = sh_mail
                Timer1.Enabled = True
            End If
        Else
            If sh_nme.Text <> "" Then
                If sh_addr.Text <> "" Then
                    If sh_GST.MaskCompleted Then
                        If admin_name.Text <> "" Then
                            If sh_mail.Text <> "" Then
                                If sh_pwd.Text <> "" Then
                                    If True Then 'Dummy if so that I can minimise login code
                                        Dim p(1), v(1) As String
                                        Dim check_and_ID As String = ""
                                        Dim d As New daoclass
                                        Dim obj As SqlClient.SqlDataReader
                                        p = {"@mail"}
                                        v = {sh_mail.Text}
                                        obj = d.getdata("Select E_mailID from user_master where E_mailID=@mail", p, v)
                                        'Checks if the email inputted already exists or not
                                        While obj.Read
                                            check_and_ID = obj.Item(0)
                                        End While
                                        d.closeconn()
                                        If check_and_ID <> "" Then
                                            'If E-mail exists
                                            MessageBox.Show("Given E-mail has already been registered")
                                        Else
                                            'If E-mail does not exist
                                            ReDim p(4), v(4)
                                            p = {"@name", "@address", "@email", "@GST"}
                                            v = {sh_nme.Text, sh_addr.Text, sh_mail.Text, sh_GST.Text}
                                            d.editdata("Insert into shop_master(s_nme,s_addr,s_email,s_gstno) values(@name,@address,@email,@GST)", p, v)
                                            'Inserts shop details in shop master
                                            ReDim p(1), v(1)
                                            p = {"@mail"}
                                            v = {sh_mail.Text}
                                            obj = d.getdata("Select ID from shop_master where s_email=@mail", p, v)
                                            'Gets shop ID to make Admin user in user master
                                            While obj.Read
                                                check_and_ID = obj.Item(0)
                                            End While
                                            d.closeconn()
                                            ReDim p(4), v(4)
                                            p = {"@nme", "@mail", "@SID", "@pwd", "@eRole"}
                                            v = {admin_name.Text, sh_mail.Text, check_and_ID, sh_pwd.Text, "Admin"}
                                            'Inserts details for admin in user master
                                            d.editdata("Insert into user_master values(@nme,@mail,@SID,@pwd,@eRole)", p, v)
                                            MessageBox.Show("Account created... Moving to Log-In Screen")
                                            toggle(False)
                                            clear()
                                            sh_mail.Text = v(0)
                                            sh_pwd.Focus()
                                        End If
                                    End If
                                Else
                                    sh_pwd.BackColor = Color.Coral
                                    invalfield = sh_pwd
                                    Timer1.Enabled = True
                                End If
                            Else
                                sh_mail.BackColor = Color.Coral
                                invalfield = sh_mail
                                Timer1.Enabled = True
                            End If
                        Else
                            admin_name.BackColor = Color.Coral
                            invalfield = admin_name
                            Timer1.Enabled = True
                        End If
                    Else
                            sh_GST.BackColor = Color.Coral
                        invalfield = sh_GST
                        Timer1.Enabled = True
                    End If
                Else
                    sh_addr.BackColor = Color.Coral
                    invalfield = sh_addr
                    Timer1.Enabled = True
                End If
            Else
                sh_nme.BackColor = Color.Coral
                invalfield = sh_nme
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub clear()
        sh_addr.Text = ""
        sh_GST.Text = ""
        sh_mail.Text = ""
        sh_nme.Text = ""
        sh_pwd.Text = ""
    End Sub

    Private Sub toggle(ByVal signup As Boolean)
        'Sign Up is true when form is in Sign up mode.
        Panel2.Visible = signup
        If signup Then
            Me.Height = signsize
            title.Text = "Sign Up"
            run_qry.Text = "Sign Up"
            toggler.Text = "&Log In instead"
            'controlname.location = new point(X_value, Y_value)
            'This changes the location of the control to the specified (x,y) point
            Panel1.Location = New Point(Panel1.Location.X, Panel1.Location.Y + 222)
            sh_nme.Focus()
        Else
            Me.Height = loginsize
            title.Text = "Login"
            run_qry.Text = "Login"
            toggler.Text = "&Sign In instead"
            'controlname.location = new point(X_value, Y_value)
            'This changes the location of the control to the specified (x,y) point
            Panel1.Location = New Point(Panel1.Location.X, Panel1.Location.Y - 222)
            sh_mail.Focus()
        End If
    End Sub

    Private Sub page_toggle_Click(sender As Object, e As EventArgs) Handles toggler.Click
        clear()
        toggle(IIf(title.Text = "Sign Up", False, True))
        'Calls toggle(false) if user pressed 'login instead'
        'Calls toggle(true) if user pressed 'sign in instead'
    End Sub

    Private Sub txt_validation(sender As Object, e As KeyPressEventArgs) Handles sh_nme.KeyPress
        Dim d As New daoclass
        e.Handled = d.charvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub address_validation(sender As Object, e As KeyPressEventArgs) Handles sh_addr.KeyPress
        Dim d As New daoclass
        e.Handled = d.addressvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub mail_validation(sender As Object, e As KeyPressEventArgs) Handles sh_mail.KeyPress
        Dim d As New daoclass
        e.Handled = d.mailvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub password_validation(sender As Object, e As KeyPressEventArgs) Handles sh_pwd.KeyPress
        Dim d As New daoclass
        e.Handled = d.pwdvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub run_qry_KeyDown(sender As Object, e As KeyEventArgs) Handles sh_pwd.KeyDown, sh_nme.KeyDown, sh_mail.KeyDown, sh_GST.KeyDown, sh_addr.KeyDown
        If (e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Alt) OrElse e.KeyCode = Keys.Enter Then
            Navigation(sender.TabIndex, e, Me, True, True)
        End If
    End Sub

    Private Sub Login_signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toggle(False)
    End Sub
    Private Sub Login_signup_Disposed(sender As Object, e As EventArgs) Handles MyBase.Disposed
        If Not confirm Then
            End
        End If
    End Sub

    Private Sub run_qry_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar.GetHashCode = 851981 Then
            Run_Click(sender, e)
        End If
    End Sub

    Private Sub buttonFocus(sender As Object, e As EventArgs) Handles run_qry.GotFocus, toggler.GotFocus
        btngotfocus(sender)
    End Sub

    Private Sub buttonLostFocus(sender As Object, e As EventArgs) Handles run_qry.LostFocus, toggler.LostFocus
        btnlostfocus(sender)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        invalfield.Backcolor = Color.White
        invalfield.Focus()
        Timer1.Enabled = False
        invalfield = Nothing
    End Sub
End Class