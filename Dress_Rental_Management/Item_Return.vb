Public Class Item_Return
    Private Sub Item_Return_Shown(sender As Object, e As EventArgs) Handles Me.Load
        ldata()
        SrchCat.SelectedIndex = 4
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

    Private Sub GoToReporting_Click(sender As Object, e As EventArgs) Handles GoToReporting.Click
        Dim d As New Reports
        d.Show()
        Me.Hide()
    End Sub

    Private Sub GoToSettings_Click(sender As Object, e As EventArgs) Handles GoToSettings.Click
        Dim d As New settings
        d.show()
        Me.Hide()
        Me.Focus()
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

    Private Sub ldata(Optional ByVal concat As String = "")
        Dim d As New daoclass
        Dim ds As DataSet
        Dim qr1, qr2 As String
        qr1 = "Select it.id, bi.cst_nme, bi.cst_cont, it.i_nme, it.i_code,it.i_qty,it.i_ret_dte from Items_on_rent it,Bill_Master bi where it.sh_id = " & Emp_shop_ID & " And it.i_ret_dte < '" & Today.ToString("yyyy-MM-dd") & "' And bi.b_id = it.i_bill_id And it.i_returned = 0" & IIf(concat <> "", " And " & concat & ";", ";")
        qr2 = "Select it.id, bi.cst_nme, bi.cst_cont, it.i_nme, it.i_code, it.i_qty, it.i_ret_dte From Items_on_rent it, Bill_Master bi Where it.sh_id = " & Emp_shop_ID & " And bi.b_id = it.i_bill_id And it.i_ret_dte > '" & Today.AddDays(-1).ToString("yyyy-MM-dd") & "' And it.i_returned = 0 " & IIf(concat <> "", " And " & concat & ";", ";")
        ds = d.datasetfill(qr1)
        OverList.DataSource = ds.Tables(0)
        ds = d.datasetfill(qr2)
        RentedList.DataSource = ds.Tables(0)
        For i = 0 To OverList.Rows.Count - 1
            OverList.Item(Overdcount.Name, i).Value = (Today - CDate(OverList.Item(Rented_ret_date.Name, i).Value)).TotalDays & " day(s)"
        Next
    End Sub

    Private Sub Item_returned(sender As Object, e As DataGridViewCellEventArgs) Handles RentedList.CellDoubleClick, OverList.CellDoubleClick
        Dim dao As New daoclass
        Dim re As SqlClient.SqlDataReader
        Dim dbqty As String = ""
        If sender.name = RentedList.Name Then
            Dim d As Integer = MessageBox.Show("Confirm return of item '" & RentedList.Item(iCode.Name, RentedList.CurrentCell.RowIndex).Value & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If d = 6 Then
                dao.editdata("Update Items_on_rent set i_returned = 1 where id = " & CInt(RentedList.Item(rId.Name, RentedList.CurrentCell.RowIndex).Value))
                re = dao.getdata("Select i_in_stk from Items_master where i_code = '" & RentedList.Item(iCode.Name, RentedList.CurrentCell.RowIndex).Value & "'")
                While re.Read
                    dbqty = re.Item(0)
                End While
                dao.closeconn()
                dbqty += CInt(RentedList.Item(iQty.Name, RentedList.CurrentCell.RowIndex).Value)
                dao.editdata("Update Items_master set i_in_stk = " & dbqty & "where i_code = '" & RentedList.Item(iCode.Name, RentedList.CurrentCell.RowIndex).Value & "'")
            End If
        Else
            Dim d As Integer = MessageBox.Show("Confirm return of item '" & OverList.Item(Rented_iCode.Name, OverList.CurrentCell.RowIndex).Value & "'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If d = 6 Then
                dao.editdata("Update Items_on_rent set i_returned = 2 where id = " & CInt(OverList.Item(Rented_id.Name, OverList.CurrentCell.RowIndex).Value))
                re = dao.getdata("Select i_in_stk from Items_master where i_code = '" & OverList.Item(Rented_iCode.Name, OverList.CurrentCell.RowIndex).Value & "'")
                While re.Read
                    dbqty = re.Item(0)
                End While
                dao.closeconn()
                dbqty += CInt(OverList.Item(Rented_Qty.Name, OverList.CurrentCell.RowIndex).Value)
                dao.editdata("Update Items_master set i_in_stk = " & dbqty & "where i_code = '" & OverList.Item(Rented_iCode.Name, OverList.CurrentCell.RowIndex).Value & "'")
            End If
        End If
        ldata()
    End Sub

    Public Sub End_This(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub SrchCat_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If SrchCat.Text.StartsWith("Return date") Then
        '    reportPanel.Enabled = True
        '    Srchtxt.Enabled = False
        'Else
        '    reportPanel.Enabled = False
        '    Srchtxt.Enabled = True
        'End If
    End Sub

    Private Sub Srchtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Srchtxt.KeyPress
        Dim d As New daoclass
        e.Handled = d.alphanuvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub SrchBtn_Click(sender As Object, e As EventArgs) Handles SrchBtn.Click
        Dim concat As String = ""
        Select Case SrchCat.SelectedIndex
            Case 0 'Customer Contact
                concat = "CAST(it.i_Cst_con as varchar(10)) like '" & Val(Srchtxt.Text) & "%'"
            Case 1 'Return date
                concat = "it.i_ret_dte = '" & DteOn.Value.ToString("yyyy-MM-dd") & "'"
            Case 2 'Item Code
                concat = "it.i_code like '" & Srchtxt.Text & "%'"
            Case 3 'Bill No.
                concat = "it.i_bill_id = " & Val(Srchtxt.Text)
        End Select
        ldata(concat)
    End Sub

    Private Sub SrchCat_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles SrchCat.SelectedIndexChanged
        If SrchCat.SelectedIndex = 1 Then
            reportPanel.Enabled = True
            Srchtxt.Enabled = False
        Else
            Srchtxt.Enabled = True
            reportPanel.Enabled = False
        End If
    End Sub

End Class