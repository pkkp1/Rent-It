Public Class Bill_maker
    Public animatedown As Boolean = True
    Public isNewBill As Boolean = False
    Public billID As Integer

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

    Private Sub Me_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        DateFrom.MinDate = Today
        DateTo.MinDate = DateFrom.Value.AddDays(1)
        DteFrm.Value = Today.AddMonths(-1)
        DteTo.MaxDate = Today
    End Sub

    Private Sub LoadItems()
        Dim d As New daoclass
        Dim ds As New DataSet
        ds = d.datasetfill("Select i_code from Items_master where i_in_stk > 0 And sh_id = " & Emp_shop_ID & ";")
        Item_code.DataSource = ds.Tables(0)
        Item_code.ValueMember = "i_code"
        Item_code.DisplayMember = "i_code"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim diff As Integer
        If animatedown Then
            If Bill_history.Height < 510 Then
                Bill_history.BringToFront()
                diff = +10
            ElseIf Bill_history.Height = 510 Then
                Dim d As New daoclass
                d.createlog("Accessed Billing History")
                reportPanel.Visible = True
                biller.Enabled = False
                animatedown = False
                Timer1.Enabled = False
                Ins_Itm.Enabled = False
                Exit Sub
            End If
        Else
            If Bill_history.Height > 10 Then
                diff = -10
            ElseIf Bill_history.Height = 10 Then
                animatedown = True
                Timer1.Enabled = False
                reportPanel.Visible = False
                Bill_history.Visible = False
                Digibilll.DataSource = Nothing
                prevBills.DataSource = Nothing
                biller.Enabled = False
                Ins_Itm.Enabled = True
                IsNewCST.Focus()
                Custcontact.DataSource = Nothing
                Item_code.DataSource = Nothing
                NmeDisplay.Text = ""
                ContDisplay.Text = ""
                SubTot.Text = 0
                GTot.Text = 0
                Disc.Text = 0
                Exit Sub
            End If
        End If
        Bill_history.Height += diff
    End Sub

    Private Sub DateFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateFrom.ValueChanged
        DateTo.MinDate = DateFrom.Value.AddDays(1)
    End Sub

    Private Sub Ins_Itm_Click(sender As Object, e As EventArgs) Handles Ins_Itm.Click
        If biller.Enabled Then
            Dim dcount As Integer = (DateTo.Value - DateFrom.Value).TotalDays
            Dim d As New daoclass
            Dim v(), p() As String
            Dim re As SqlClient.SqlDataReader
            SubTot.Text += Val(Itm_cst.Text) * Itm_qty.Value * dcount
            Dim discount As Integer = IIf(Disc.Text.EndsWith("%"), Val(SubTot.Text) * Val(Disc.Text) / 100, Val(Disc.Text))
            If Not isNewBill Then
                'Lock the table
                nav.Enabled = False
                ReDim v(8), p(8)
                p = {"@sid", "@emname", "@cnme", "@cont", "@Qty", "@subtot", "@disc", "@Grand", "@dte"}
                v = {Emp_shop_ID, Emp_nme, Custname.Text, Custcontact.Text, 0, SubTot.Text, discount, Val(GTot.Text), Today.ToString("yyyy/MM/dd")}
                d.editdata("Insert into Bill_Master(b_shop,biller_nme,cst_nme,cst_cont,b_Itm_qty,b_subtot,b_disc,b_gTot,b_dte) values(@sid,@emname,@cnme,@cont,@qty,@subtot,@disc,@Grand,@dte)", p, v)
                re = d.getdata("Select Max(b_id) from Bill_Master")
                While re.Read
                    billID = re.Item(0)
                End While
                d.closeconn()
                d.createlog("Created a new Bill")
                Me.ControlBox = False
                isNewBill = True
            End If
            ReDim p(10), v(10)
            v = {Emp_shop_ID, Item_code.Text, Itm_nme.Text, Itm_qty.Value, Itm_cst.Text, dcount, DateFrom.Value.ToString("yyyy/MM/dd"), DateTo.Value.ToString("yyyy/MM/dd"), Val(Custcontact.Text), billID}
            p = {"@sID", "@Icde", "@nme", "@qty", "@rte", "@dur", "@req", "@retrn", "@contact", "@id"}
            d.editdata("Insert into Items_on_rent(sh_id,i_code,i_nme,i_qty,i_rte,i_dur,i_req_dte,i_ret_dte,i_Cst_con,i_bill_id,i_returned) values(@sID,@Icde,@nme,@qty,@rte,@dur,@req,@retrn,@contact,@id,0);", p, v)
            re = d.getdata("Select Max(id) from Items_on_rent where sh_id = " & Emp_shop_ID)
            Dim I_id As Integer = 0
            While re.Read
                I_id = re.Item(0)
            End While
            d.closeconn()
            Digibilll.Rows.Add(I_id, Item_code.Text, Itm_nme.Text, (dcount & " d."), Itm_qty.Value, Itm_cst.Text)
            d.editdata("Update Items_master set i_in_stk = i_in_stk - " & Itm_qty.Value & " where i_code = '" & Item_code.Text & "'")
            d.editdata("Update Bill_Master set b_subtot = " & Val(SubTot.Text) & ", b_disc = " & discount & ", b_gTot = " & Val(GTot.Text) & ", b_Itm_Qty = b_Itm_Qty + " & CInt(Itm_qty.Value) & " Where b_id = " & billID)
            LoadItems()
            Item_code.Focus()
        End If
    End Sub

    Private Sub Disc_TextChanged(sender As Object, e As EventArgs) Handles Disc.TextChanged, SubTot.TextChanged
        If Disc.Text.EndsWith("%") Then
            If Val(Disc.Text.TrimEnd("%")) > 100 Then
                Disc.Text = "100%"
            End If
            GTot.Text = Val(SubTot.Text) - (Val(SubTot.Text) * Val(Disc.Text) / 100)
        Else
            GTot.Text = Val(SubTot.Text) - Val(Disc.Text)
        End If
    End Sub

    Private Sub Item_code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item_code.SelectedIndexChanged
        Dim d As New daoclass
        Dim v(0), p(0) As String
        v(0) = Item_code.Text
        p(0) = "@code"
        Dim obj As SqlClient.SqlDataReader
        obj = d.getdata("Select * from Items_master where i_code = @code", p, v)
        While obj.Read
            Itm_nme.Text = obj.Item(1)
            Itm_qty.Maximum = obj.Item(3)
            Itm_ttl.Text = "/" & obj.Item(3)
            Itm_cst.Text = obj.Item(4)
        End While
        d.closeconn()
    End Sub

    Private Sub DelItem_Click(sender As Object, e As EventArgs) Handles DelItem.Click
        Dim d As New daoclass
        Dim v(2), p(2) As String
        SubTot.Text = Val(SubTot.Text) - (Digibilll.Item(b_i_qty.Name, Digibilll.CurrentCell.RowIndex).Value * Val((Digibilll.Item(b_i_dur.Name, Digibilll.CurrentCell.RowIndex).Value).ToString.TrimEnd(" d.")) * Digibilll.Item(b_i_rate.Name, Digibilll.CurrentCell.RowIndex).Value)
        Dim discount As Integer = IIf(Disc.Text.EndsWith("%"), Val(SubTot.Text) * Val(Disc.Text) / 100, Val(Disc.Text))
        v = {Digibilll.Item(Itm_id.Name, Digibilll.CurrentCell.RowIndex).Value.ToString, Emp_shop_ID}
        p = {"@id", "@shop"}
        d.editdata("delete from Items_on_rent where id = @id and sh_id = @shop", p, v)
        d.editdata("Update Items_master set i_in_stk = i_in_stk + " & Val(Digibilll.Item(b_i_qty.Name, Digibilll.CurrentCell.RowIndex).Value.ToString) & " where i_code = '" & Digibilll.Item(iCode.Name, Digibilll.CurrentCell.RowIndex).Value & "' And sh_id = " & Emp_shop_ID)
        d.editdata("Update Bill_Master set b_subtot = " & Val(SubTot.Text) & ", b_disc = " & discount & ", b_gTot = " & Val(GTot.Text) & ", b_Itm_Qty = b_Itm_Qty - " & CInt(Digibilll.Item(b_i_qty.Name, Digibilll.CurrentCell.RowIndex).Value) & " Where b_id = " & billID)
        Digibilll.Rows.RemoveAt(Digibilll.CurrentCell.RowIndex)
    End Sub

    Private Sub ManageCust_Click(sender As Object, e As EventArgs) Handles ManageCust.Click
        Cust_Master.Show()
        Me.Hide()
    End Sub

    Private Sub Custcontact_Leave(sender As Object, e As EventArgs) Handles Custcontact.Leave
        If Not IsNewCST.Checked Then
            Dim d As New daoclass
            Dim re As SqlClient.SqlDataReader
            re = d.getdata("Select * from Customer_master where c_contact = " & Val(Custcontact.Text))
            While re.Read
                Custname.Text = re.Item(1)
                CstOpBal.Text = re.Item(3)
                Disc.Text = re.Item(4) & "%"
            End While
            d.closeconn()
            biller.Enabled = True
            Item_code.Focus()
            LoadItems()
        End If
    End Sub

    Private Sub GenReport_Click(sender As Object, e As EventArgs) Handles GenReport.Click
        Dim d As New daoclass
        Dim ds As DataSet
        ds = d.datasetfill("Select * from Bill_Master where b_shop =" & Emp_shop_ID & " And b_dte >= '" & DteFrm.Value.ToString("yyyy/MM/dd") & "' And b_dte <= '" & DteTo.Value.ToString("yyyy/MM/dd") & "'")
        prevBills.DataSource = ds.Tables(0)
        dsReprt = ds
    End Sub

    Private Sub PrntBill_Click(sender As Object, e As EventArgs) Handles PrntBill.Click
        If Digibilll.Rows.Count > 0 Then
            If Pay_now.Checked OrElse From_Bal.Checked Then
                Me.Cursor = Cursors.WaitCursor
                Dim d As New daoclass
                Dim paystr As String = ""
                If Pay_now.Checked Then
                    paystr = "deb"
                End If
                If From_Bal.Checked Then
                    If paystr <> "" Then
                        Dim inp As New Input_box
                        inp.ShowDialog()
                        d.update_Cust_account(Custcontact.Text, payment - Val(GTot.Text))

                        paystr &= " & cred"
                    Else
                        paystr = "cred"
                        d.update_Cust_account(Custcontact.Text, 0 - Val(GTot.Text))
                    End If
                End If
                dsReprt = d.datasetfill("Select i_nme,i_qty,i_rte,i_req_dte,i_ret_dte from Items_on_rent where i_bill_id = " & billID & " and sh_id = " & Emp_shop_ID)
                d.editdata("Update Customer_Master set c_prev_Disc = " & (IIf(Disc.Text.EndsWith("%"), Val(Disc.Text.TrimEnd("%")), Math.Round((Val(Disc.Text) * 100 / (Val(SubTot.Text))), 0))) & " where c_contact = " & Custcontact.Text)
                Dim repform As New Bill_out
                Dim re As SqlClient.SqlDataReader
                re = d.getdata("Select s_nme,s_addr from shop_master where ID = " & Emp_shop_ID)
                Dim nme, adr As String
                nme = ""
                adr = ""
                While re.Read
                    nme = re.Item(0)
                    adr = re.Item(1)
                End While
                d.closeconn()
                repform.val = {billID, nme, adr, NmeDisplay.Text, ContDisplay.Text, SubTot.Text, Disc.Text, GTot.Text}
                repform.Show()
                isNewBill = False
                newbill()
                Me.Cursor = Cursors.Default
                payment = 0
            Else
                MessageBox.Show("Please choose a payment mode")
            End If
        End If
    End Sub

    Private Sub newbill()
        Custcontact.DataSource = Nothing
        Item_code.DataSource = Nothing
        nav.Enabled = True
        Item_code.Text = ""
        Custcontact.Text = ""
        Custname.Text = ""
        CstOpBal.Text = ""
        Itm_nme.Text = ""
        Itm_cst.Text = ""
        ContDisplay.Text = ""
        NmeDisplay.Text = ""
        SubTot.Text = 0
        GTot.Text = 0
        Disc.Text = 0
        DateFrom.Value = Today
        While Digibilll.DisplayedRowCount(True) <> 0
            Digibilll.Rows.RemoveAt(Digibilll.CurrentCell.RowIndex)
        End While
        biller.Enabled = False
        IsNewCST.Focus()
        isNewBill = False
        billID = 0
        Me.ControlBox = True
    End Sub

    Private Sub Custcontact_GotFocus(sender As Object, e As EventArgs) Handles Custcontact.GotFocus
        If Not IsNewCST.Checked Then
            Custname.ReadOnly = True
            Dim d As New daoclass
            Dim ds As New DataSet
            ds = d.datasetfill("Select c_contact from Customer_master where c_sID = " & Emp_shop_ID)
            Custcontact.DataSource = ds.Tables(0)
            Custcontact.ValueMember = "c_contact"
            Custcontact.DisplayMember = "c_contact"
        End If
    End Sub

    Private Sub GenReport_VisibleChanged(sender As Object, e As EventArgs) Handles GenReport.VisibleChanged
        If Not GenReport.Visible Then
            prevBills.DataSource = Nothing
        End If
    End Sub

    Private Sub DteFrm_ValueChanged(sender As Object, e As EventArgs) Handles DteFrm.ValueChanged
        DteTo.MinDate = DteFrm.MinDate.AddDays(1)
    End Sub

    Private Sub prevBills_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles prevBills.CellDoubleClick
        If prevBills.Rows.Count > 0 Then
            Dim bID As Integer = Val(prevBills.Item(b_no.Name, prevBills.CurrentCell.RowIndex).Value)
            Dim d As New daoclass
            Dim ds As New DataSet
            ds = d.datasetfill("Select id,i_code,i_qty,i_rte,i_dur,i_nme from Items_on_rent where i_bill_id = " & bID)
            Digibilll.DataSource = ds.Tables(0)
            NmeDisplay.Text = prevBills.Item(C_nme.Name, prevBills.CurrentCell.RowIndex).Value
            ContDisplay.Text = prevBills.Item(CCont.Name, prevBills.CurrentCell.RowIndex).Value
            Disc.Text = prevBills.Item(CDisc.Name, prevBills.CurrentCell.RowIndex).Value
            billID = prevBills.Item(b_no.Name, prevBills.CurrentCell.RowIndex).Value
            GTot.Text = prevBills.Item(Btot.Name, prevBills.CurrentCell.RowIndex).Value
            SubTot.Text = prevBills.Item(CSubtot.Name, prevBills.CurrentCell.RowIndex).Value
        End If
    End Sub

    Private Sub Cust_manager_Leave(sender As Object, e As EventArgs) Handles Cust_manager.Leave
        If Not IsNewCST.Checked Then
            NmeDisplay.Text = Custname.Text
            ContDisplay.Text = Custcontact.Text
            NmeDisplay.Visible = True
            ContDisplay.Visible = True
        End If
    End Sub

    Private Sub Bill_maker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isNewBill Then
            e.Cancel = True
            MessageBox.Show("Cannot close until Billing is resolved")
        End If
    End Sub

    Private Sub Bill_maker_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, Itm_nme.KeyDown, Itm_cst.KeyDown, Item_code.KeyDown, Ins_Itm.KeyDown, DateTo.KeyDown, DateFrom.KeyDown, Custname.KeyDown, Custcontact.KeyDown, IsNewCST.KeyDown, Itm_qty.KeyDown, Custname.KeyDown
        If (e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Alt) OrElse e.KeyCode = Keys.Enter Then
            Navigation(sender.TabIndex, e, Me, True, True)
            If sender.name = "Custname" Then
                If IsNewCST.Checked Then
                    Dim d As New daoclass
                    If IsNumeric(Custcontact.Text) AndAlso Custcontact.Text.Length = 10 Then
                        If Custname.Text <> "" Then
                            Try
                                d.editdata("Insert into Customer_master(c_sID,c_nme,c_contact,c_opBal,c_prev_Disc) values(" & Emp_shop_ID & ",'" & Custname.Text & "'," & Custcontact.Text & ",0,0)")
                                d.createlog("A new customer was created")
                                biller.Enabled = True
                                Item_code.Focus()
                                LoadItems()
                            Catch ex As Exception

                            End Try
                        Else
                            MessageBox.Show("Name cannot be blank")
                            Custname.Focus()
                        End If
                    Else
                        MessageBox.Show("Please enter proper contact no.")
                        Custcontact.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Custname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Custname.KeyPress
        Dim d As New daoclass
        e.Handled = d.charvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub Custcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Custcontact.KeyPress
        If IsNewCST.Checked Then
            Dim d As New daoclass
            e.Handled = d.numvalidate(e.KeyChar, e.KeyChar.GetHashCode)
        Else
            AutoSearch(Item_code, e, True)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        If prevBills.Rows.Count > 0 Then
            Dim d As New daoclass
            Dim ds As DataSet
            ds = d.datasetfill("Select * from Bill_Master where b_shop =" & Emp_shop_ID & " And b_dte >= '" & DteFrm.Value.ToString("yyyy/MM/dd") & "' And b_dte <= '" & DteTo.Value.ToString("yyyy/MM/dd") & "'")
            dsReprt = ds
            Dim rpt As New Bill_out
            rpt.Show()
        End If
    End Sub

    Private Sub buttonfocus(sender As Object, e As EventArgs) Handles PrntBill.GotFocus, Ins_Itm.GotFocus, GenReport.GotFocus
        btngotfocus(sender)
    End Sub

    Private Sub buttonlostfocus(sender As Object, e As EventArgs) Handles PrntBill.LostFocus, Ins_Itm.LostFocus, GenReport.LostFocus
        btnlostfocus(sender)
    End Sub

    Private Sub History_Show_Click(sender As Object, e As EventArgs) Handles History_Show.Click
        Timer1.Enabled = True
        Bill_history.Visible = True
        NmeDisplay.Visible = True
        ContDisplay.Visible = True
    End Sub
End Class