Public Class Item_Stock
    Private Sub Item_Stock_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Load
        ldata()
    End Sub

    Private Sub ldata()
        Dim d As New daoclass
        Dim ds As New DataSet
        ds = d.datasetfill("Select * from Items_master where sh_id = " &
             Emp_shop_ID & ";")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        it_code.ReadOnly = True
        it_code.Text = DataGridView1.Item(iCode.Name, DataGridView1.CurrentCell.RowIndex).Value
        it_type.Text = DataGridView1.Item(iType.Name, DataGridView1.CurrentCell.RowIndex).Value
        tot_amt.Value = DataGridView1.Item(itotqty.Name, DataGridView1.CurrentCell.RowIndex).Value
        stk_amt.Value = DataGridView1.Item(iStk.Name, DataGridView1.CurrentCell.RowIndex).Value
        rte.Text = DataGridView1.Item(iRate.Name, DataGridView1.CurrentCell.RowIndex).Value
        it_type.Focus()
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        If blankvalidate() Then
            Dim d As New daoclass
            Dim v(1), p(1) As String
            p = {"@icode"}
            v = {it_code.Text}
            If it_code.ReadOnly Then
                Dim confirm = MessageBox.Show(
                    "Delete Item " & v(0) & "?",
                    "Deletion confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)
                If confirm = 6 Then
                    d.editdata("delete from Items_master where i_code = @icode", p, v)
                    ldata()
                    clear()
                Else
                    MessageBox.Show("Deletion cancelled")
                End If
            Else
                MessageBox.Show("Item not selected" & vbCrLf &
                                "Please select Item from the table")
            End If
        End If
    End Sub

    Private Function blankvalidate() As Boolean
        If it_code.Text <> "" Then
            If it_type.Text <> "" Then
                If rte.Text <> "" AndAlso IsNumeric(rte.Text) Then
                    Return True
                Else
                    MessageBox.Show("Enter valid Item rate")
                    rte.Focus()
                End If
            Else
                MessageBox.Show("Enter or select valid Item type")
                it_type.Focus()
            End If
        Else
            MessageBox.Show("Enter valid item code")
            it_code.Focus()
        End If
        Return False
    End Function

    Private Sub clear()
        it_code.Text = ""
        it_type.Text = ""
        tot_amt.Value = 1
        stk_amt.Value = 1
        rte.Text = ""
        it_code.ReadOnly = False
        it_code.Focus()
    End Sub

    Private Sub sve_Click(sender As Object, e As EventArgs) Handles sve.Click
        If blankvalidate() Then
            Dim d As New daoclass
            Dim v(6), p(6) As String
            p = {"@icode", "@type", "@tot", "@instk", "@rate", "@sID"}
            v = {it_code.Text, it_type.Text, tot_amt.Value, stk_amt.Value, rte.Text, Emp_shop_ID}
            If Not it_code.ReadOnly Then
                Dim confirm = MessageBox.Show("Insert new Item:" & vbCrLf & "Item code:" & v(0) & vbCrLf & "Type: " & v(1) & "?", "Insertion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = 6 Then
                    d.editdata("insert into Items_master values(@icode,@type,@tot,@instk,@rate,@sID)", p, v)
                    ldata()
                    clear()
                Else
                    MessageBox.Show("Insertion cancelled")
                End If
            Else
                Dim confirm = MessageBox.Show("Update Item details?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = 6 Then
                    ReDim v(5), p(5)
                    p = {"@type", "@tot", "@instk", "@rate", "@icode"}
                    v = {it_type.Text, tot_amt.Value, stk_amt.Value, rte.Text, it_code.Text}
                    d.editdata("update Items_master set i_type = @type, i_qty = @tot, i_in_stk = @instk, i_rte = @rate where i_code = @icode", p, v)
                    ldata()
                    clear()
                Else
                    MessageBox.Show("Update cancelled")
                End If
            End If
        End If
    End Sub

    Private Sub rte_KeyDown(sender As Object, e As KeyEventArgs) Handles tot_amt.KeyDown, stk_amt.KeyDown, rte.KeyDown, it_type.KeyDown, it_code.KeyDown
        If (e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Alt) OrElse e.KeyCode = Keys.Enter Then
            Navigation(sender.TabIndex, e, Me, True, True)
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

    Private Sub GoToSettings_Click(sender As Object, e As EventArgs) Handles GoToSettings.Click
        Dim d As New settings
        d.Show()
        Me.Hide()
    End Sub

    Private Sub GoToBilling_Click(sender As Object, e As EventArgs) Handles GoToBilling.Click
        Dim d As New Bill_maker
        d.Show()
        Me.Hide()
    End Sub

End Class