Public Class Logs_master
    Private Sub GenReport_Click(sender As Object, e As EventArgs) Handles GenReport.Click
        Dim d As New daoclass
        Dim ds As DataSet
        Dim qry As String = "Select * from Logs_Master where Log_sID =" & Emp_shop_ID & " And Log_date >= '" & L_frm.Value.ToString("yyyy/MM/dd") & "' And Log_date <= '" & L_to.Value.ToString("yyyy/MM/dd") & "'"
        If L_emp.Text <> "All Employees" Then
            qry &= " And Log_Emp = '" & L_emp.Text & "'"
        End If
        If L_act.Text <> "All Actions" Then
            qry &= " And Log_action = '" & L_act.Text & "'"
        End If
        ds = d.datasetfill(qry)
        LogList.DataSource = ds.Tables(0)
        dsReprt = ds
    End Sub


    Private Sub Logs_master_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
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

    Private Sub GoToBilling_Click(sender As Object, e As EventArgs) Handles GoToBilling.Click
        Dim d As New Bill_maker
        d.Show()
        Me.Hide()
    End Sub

    Private Sub Logs_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As New daoclass
        Dim re As SqlClient.SqlDataReader = d.getdata("Select distinct Log_action from Logs_Master where Log_sID = " & Emp_shop_ID)
        L_act.Items.Add("All Actions")
        While re.Read
            L_act.Items.Add(re.Item(0))
        End While
        d.closeconn()
        re = d.getdata("Select distinct Log_Emp from Logs_Master where Log_sID = " & Emp_shop_ID)
        L_emp.Items.Add("All Employees")
        While re.Read
            L_emp.Items.Add(re.Item(0))
        End While
        d.closeconn()
        L_emp.SelectedIndex = 0
        L_act.SelectedIndex = 0
        L_frm.Value = Today.AddMonths(-1)
    End Sub

End Class