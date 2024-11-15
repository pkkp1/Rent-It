Public Class main_menu

    Private Sub Me_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.load
        ldata()
    End Sub

    Private Sub ldata()
        Try
            Dim d As New daoclass
            Dim ds As New DataSet
            Dim p(2), v(2) As String
            ds = d.datasetfill("Select id,i_cst_con,i_code,i_qty,i_ret_dte from Items_on_rent where sh_id = " & Emp_shop_ID & " And i_ret_dte < '" & Today.ToString("yyyy/MM/dd") & "' And i_returned = 0")
            OverList.DataSource = ds.Tables(0)
            For i = 0 To OverList.Rows.Count() - 1
                OverList.Item(Over_dcount.Name, i).Value = (Today - CDate(OverList.Item(Rented_ret_date.Name, i).Value)).TotalDays & " day(s)"
            Next
            overAmt.Text = IIf(OverList.Rows.Count() - 1 < 10, "0", "")
            overAmt.Text &= OverList.Rows.Count() - 1
            Dim re As SqlClient.SqlDataReader = d.getdata("Select SUM(i_in_stk),SUM(i_qty) from Items_master where sh_id = " & Emp_shop_ID)
            While re.Read
                DressInStock.Text = re.Item(0)
                DressTtl.Text = re.Item(1)
            End While
            d.closeconn()
            re = d.getdata("Select SUM(c_opBal) from Customer_Master where c_opBal > 0 And c_sID = " & Emp_shop_ID)
            While re.Read
                CustDeb.Text = re.Item(0)
            End While
            d.closeconn()
            re = d.getdata("Select SUM(c_opBal) from Customer_Master where c_opBal < 0 And c_sID = " & Emp_shop_ID)
            While re.Read
                CustCred.Text = Math.Abs(re.Item(0))
            End While
            d.closeconn()
            CustNetBal.Text = Val(CustDeb.Text) - Val(CustCred.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OverList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OverList.CellDoubleClick
        Dim d As New Item_Return
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

    Private Sub btnfocus(sender As Object, e As EventArgs) Handles Rental_Return.GotFocus, GoToSettings.GotFocus, GoToReporting.GotFocus, GoToPurchase.GotFocus, GoToItemStock.GotFocus, GoToBilling.GotFocus
        btngotfocus(sender)
    End Sub

    Private Sub btnfocuslost(sender As Object, e As EventArgs) Handles Rental_Return.LostFocus, GoToSettings.LostFocus, GoToReporting.LostFocus, GoToPurchase.LostFocus, GoToItemStock.LostFocus, GoToBilling.LostFocus
        btnlostfocus(sender)
    End Sub

End Class