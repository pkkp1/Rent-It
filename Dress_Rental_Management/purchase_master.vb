Public Class purchase_master
    Public dets As String

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        If blankvalidateitem() Then
            Dim d As New daoclass
            Tqty.Text = Val(Tqty.Text) + It_qty.Value
            Dim v(6), p(6) As String
            p = {"@icode", "@type", "@tot", "@instk", "@rate", "@sID"}
            v = {It_code.Text, It_nme.Text, It_qty.Value, It_qty.Value, It_rte.Text, Emp_shop_ID}
            Dim re As SqlClient.SqlDataReader
            Dim ins As Boolean = True
            Dim newqty As Integer = 0
            Dim newstk As Integer = 0
            re = d.getdata("Select i_code,i_qty,i_in_stk from Items_master where i_code = '" & It_code.Text & "' and sh_id = " & Emp_shop_ID)
            While re.Read
                If re.Item(0) = It_code.Text Then
                    ins = False
                    newqty = re.Item(1) + It_qty.Value
                    newstk = re.Item(2) + It_qty.Value
                    Exit While
                End If
            End While
            d.closeconn()
            If ins Then
                d.editdata("insert into Items_master values(@icode,@type,@tot,@instk,@rate,@sID)", p, v)
            Else
                ReDim v(5), p(5)
                p = {"@type", "@tot", "@instk", "@rate", "@icode"}
                v = {It_nme.Text, newqty, newstk, It_rte.Text, It_code.Text}
                d.editdata("update Items_master set i_type = @type, i_qty = @tot, i_in_stk = @instk, i_rte = @rate where i_code = @icode", p, v)
            End If
            ItemDetails.Rows.Add(0, It_code.Text, It_nme.Text, It_qty.Text)
            clear()
        End If
    End Sub

    Private Function blankvalidateitem() As Boolean
        If It_code.Text <> "" Then
            If It_nme.Text <> "" Then
                If It_rte.Text <> "" Then
                    Return True
                Else
                    MessageBox.Show("Enter Item Rate")
                    It_rte.Focus()
                End If
            Else
                MessageBox.Show("Enter Item Name")
                It_nme.Focus()
            End If
        Else
            MessageBox.Show("Enter Item Code")
            It_code.Focus()
        End If
        Return False
    End Function

    Private Sub clear(Optional ByVal clrall As Boolean = False)
        If clrall Then
            InvNo.Text = ""
            ven_nme.Text = ""
            ven_addr.Text = ""
            ven_cont.Text = ""
            Gtot.Text = ""
            deb.Checked = False
            cred.Checked = False
            ven_cont.Text = ""
            ItemDetails.Rows.Clear()
        End If
        It_code.Text = ""
        It_nme.Text = ""
        It_rte.Text = ""
        It_qty.Value = 1
    End Sub

    Private Function blankvalidatesummary() As Boolean
        If InvNo.Text <> "" Then
            If ven_nme.Text <> "" Then
                If ven_addr.Text <> "" Then
                    If Not ven_cont.Text.EndsWith("_") Then
                        If Gtot.Text <> "" Then
                            If deb.Checked OrElse cred.Checked Then
                                If Not ven_cont.Text.EndsWith("_") Then
                                    Return True
                                Else
                                    MessageBox.Show("Enter Vendor GST no")
                                    ven_GST.Focus()
                                End If
                            Else
                                MessageBox.Show("Select valid payment mode")
                                deb.Focus()
                            End If
                        Else
                            MessageBox.Show("Enter Total Amount")
                            Gtot.Focus()
                        End If
                    Else
                        MessageBox.Show("Enter Vendor GST no")
                        ven_GST.Focus()
                    End If
                Else
                    MessageBox.Show("Enter Vendor Address")
                    ven_addr.Focus()
                End If
            Else
                MessageBox.Show("Enter Vendor Name")
                ven_nme.Focus()
            End If
        Else
            MessageBox.Show("Enter Invoice Number")
            InvNo.Focus()
        End If
        Return False
    End Function

    Private Sub Ctrls_KeyDown(sender As Object, e As KeyEventArgs) Handles ven_nme.KeyDown, ven_cont.KeyDown, ven_addr.KeyDown, cred.KeyDown, deb.KeyDown, It_rte.KeyDown, It_qty.KeyDown, It_nme.KeyDown, InvNo.KeyDown, Insert.KeyDown, Gtot.KeyDown
        If (e.KeyCode = Keys.Back AndAlso e.Modifiers = Keys.Alt) OrElse e.KeyCode = Keys.Enter Then
            Navigation(sender.TabIndex, e, Me, True, True)
        End If
    End Sub

    Private Sub Fin_Click(sender As Object, e As EventArgs) Handles Fin.Click
        Dim i As Integer
        For i = 0 To ItemDetails.Rows.Count - 2
            dets &= ItemDetails.Item(iCode.Name, i).Value & ": " & ItemDetails.Item(b_i_qty.Name, i).Value & "pc(s), " & vbCrLf
        Next
        dets &= ItemDetails.Item(iCode.Name, i).Value & ": " & ItemDetails.Item(b_i_qty.Name, i).Value & "." & vbCrLf
        Dim d As New daoclass
        Dim v(10), p(10) As String
        p = {"@sid", "@dte", "@InNo", "@vname", "@vcon", "@vadd", "@det", "@qty", "@gst", "@tot", "@mode"}
        v = {Emp_shop_ID, Today.ToString("yyyy/MM/dd"), InvNo.Text, ven_nme.Text, ven_cont.Text, ven_addr.Text, dets, Tqty.Text, ven_GST.Text, Gtot.Text, (IIf(deb.Checked = True, "debit", "credit"))}
        d.editdata("INSERT INTO purchase_Master(sh_id,p_dte,p_invno,p_nme,p_cont,p_add,p_details,p_qty,p_gst_no,p_gTot,p_pay_mode) VALUES(@sid, @dte, @InNo, @vname, @vcon, @vadd, @det, @qty, @gst, @tot, @mode)", p, v)
        MessageBox.Show("Purchase concluded")
        clear(True)
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim d As New main_menu
        d.Show()
        Me.Hide()
    End Sub

    Private Sub purchase_master_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

End Class