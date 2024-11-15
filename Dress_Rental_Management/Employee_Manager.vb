Public Class Employee_Manager
    Private Sub ldata()
        Dim d As New daoclass
        Dim ds As New DataSet
        ds = d.datasetfill("Select * from user_master where E_Shop = " &
             Emp_shop_ID & "And E_mailID != '" & Emp_mailID & "';")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If blankvalidate() Then
            Dim d As New daoclass
            Dim v(1), p(1) As String
            p = {"@mail"}
            v = {emMail.Text}
            Dim IsAdmin As Boolean = AdminCheck()
            If IsAdmin Then
                If emMail.ReadOnly Then
                    Dim confirm = MessageBox.Show(
                        "Delete Employee account " & emMail.Text & "?",
                        "Deletion confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                    If confirm = 6 Then
                        d.editdata("delete from user_master where E_mailID = 
                                    @mail", p, v)
                    Else
                        MessageBox.Show("Deletion cancelled")
                    End If
                Else
                    MessageBox.Show("Employee not selected" & vbCrLf &
                                    "Please select Employee from the table")
                End If
            Else
                MessageBox.Show("Admin password invalid")
                adm_pwd.Text = ""
                adm_pwd.Focus()
            End If
        End If
        clear()
        ldata()
    End Sub

    Private Sub clear()
        adm_pwd.Text = ""
        emMail.Text = ""
        EmPwd.Text = ""
        EmRole.Text = ""
        emMail.ReadOnly = False
    End Sub

    Private Sub closeall(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridView1.CellDoubleClick
        emMail.ReadOnly = True
        emMail.Text = DatagridView1.Item("mail",
                                         DatagridView1.CurrentCell.RowIndex).Value
        EmPwd.Text = DatagridView1.Item("pass_word",
                                        DatagridView1.CurrentCell.RowIndex).Value
        EmRole.Text = DatagridView1.Item("E_role",
                                         DatagridView1.CurrentCell.RowIndex).Value
    End Sub

    Private Sub EmRole_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmRole.KeyPress
        AutoSearch(EmRole, e, True)
    End Sub

    Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Load
        ldata()
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Logo blue: Color.FromArgb(11, 36, 69)
        'Logo Red: Color.FromArgb(152, 6, 58)
        ldata()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If blankvalidate() Then
            Dim d As New daoclass
            Dim v(2), p(2) As String
            Dim IsAdmin As Boolean = AdminCheck()
            If IsAdmin Then
                If Not emMail.ReadOnly Then
                    Dim confirm = MessageBox.Show("Insert new Employee account:" & vbCrLf & "Mail ID:" & emMail.Text & vbCrLf & "Role: " & vbCrLf & EmRole.Text & "?", "Insertion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirm = 6 Then
                        ReDim p(5), v(5)
                        p = {"@nme", "@mail", "@sid", "@pwd", "@role"}
                        v = {Emname.Text, emMail.Text, Emp_shop_ID, EmPwd.Text, EmRole.Text}
                        d.editdata("insert into user_master values(@name,@mail,@sid,@pwd,@role)", p, v)
                    Else
                        MessageBox.Show("Insertion cancelled")
                    End If
                Else
                    Dim confirm = MessageBox.Show("Update Employee record?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirm = 6 Then
                        ReDim p(3), v(3)
                        p = {"@nme", "@pwd", "@role", "@mail"}
                        v = {Emname.Text, EmPwd.Text, EmRole.Text, emMail.Text}
                        d.editdata("update user_master set E_name = @nme,E_Pass_wrd = @pwd, E_role = @role where E_mailID = @mail", p, v)
                    Else
                        MessageBox.Show("Update cancelled")
                    End If
                End If
            Else
                MessageBox.Show("Admin password invalid")
                adm_pwd.Text = ""
                adm_pwd.Focus()
            End If
        End If
        clear()
        ldata()
    End Sub

    Private Function AdminCheck() As Boolean
        Dim d As New daoclass
        Dim v(2), p(2) As String
        Dim IsAdmin As Boolean = False
        Dim obj As SqlClient.SqlDataReader
        'Checks If User is admin
        p = {"@mail", "@pwd"}
        v = {Emp_mailID, adm_pwd.Text}
        obj = d.getdata("Select e_role from user_master where E_mailID=@mail and e_Pass_wrd=@pwd", p, v)
        While obj.Read
            If obj.Item(0) = "Admin" Then
                IsAdmin = True
            End If
        End While
        d.closeconn()
        Return IsAdmin
    End Function

    Private Function blankvalidate() As Boolean
        If adm_pwd.Text <> "" Then
            If emMail.Text <> "" Then
                If EmPwd.Text <> "" Then
                    If EmRole.Text <> "" Then
                        Return True
                    Else
                        MessageBox.Show("Please select Employee Role")
                        EmRole.Focus()
                    End If
                Else
                    MessageBox.Show("Please enter Employee password")
                    EmPwd.Focus()
                End If
            Else
                MessageBox.Show("Please enter Employee mail ID")
                emMail.Focus()
            End If
        Else
            MessageBox.Show("Please enter Admin Password")
            adm_pwd.Focus()
        End If
        Return False
    End Function

    Private Sub Me_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
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

    Private Sub GoToBilling_Click(sender As Object, e As EventArgs) Handles GoToBilling.Click
        Dim d As New Bill_maker
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

    Private Sub GoToSettings_Click(sender As Object, e As EventArgs) Handles GoToSettings.Click
        Dim d As New settings
        d.Show()
        Me.Hide()
    End Sub

    Private Sub GoToItemStock_Click(sender As Object, e As EventArgs) Handles GoToItemStock.Click
        Dim d As New Item_Stock
        d.Show()
        Me.Hide()
    End Sub

End Class