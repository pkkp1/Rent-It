Public Class Cust_Master
    Private cstcont As String
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldata()
    End Sub

    Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Load
        Me_Load(sender, e)
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

    Public Sub ldata()
        Dim d As New daoclass
        Dim ds As New DataSet
        ds = d.datasetfill("Select * from Customer_master where c_sID = " & Emp_shop_ID)
        DatagridView1.DataSource = ds.Tables(0)
    End Sub

    Public Sub ldata(ByVal cont As Integer)
        Dim d As New daoclass
        Dim ds As New DataSet
        ds = d.datasetfill("Select * from Customer_master where c_sID = " & Emp_shop_ID & " And CAST(c_contact as varchar(10)) like '" & cont & "%';")
        DatagridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Clr()
        Custname.Text = "-"
        Custcontact.Text = ""
        Custcontact.Enabled = False
        CstOpBal.Text = "0"
        CustBalChange.Text = ""
    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click
        Dim d As New daoclass
        If Val(CstOpBal.Text) = 0 Then
            d.editdata("Delete from Customer_master where c_contact = " + Val(Custcontact.Text))
            Clr()
            ldata()
        Else
            MessageBox.Show("Customer balance must be 0 first")
        End If
    End Sub

    Private Sub Sve_Click(sender As Object, e As EventArgs) Handles Sve.Click
        If Custname.Text <> "" Then
            Dim d As New daoclass
            If Custcontact.Text <> cstcont Then
                'Dim exists As Boolean = False
                'For i = 0 To DatagridView1.Rows.Count - 1
                '    If DatagridView1.Item(custCont.Name, i).Value = Custcontact.Text Then
                '        exists = True
                '    End If
                '    If Not exists Then
                '    Else
                '        MessageBox.Show("Contact number in-use by another customer")
                '    End If
                'Next
                Try
                    d.editdata("Update Customer_master set c_contact = " & Custcontact.Text & " where c_contact = " & cstcont)
                    d.editdata("Update Bill_Master set cst_cont = " & Custcontact.Text & " where cst_cont = " & cstcont)
                    d.editdata("Update Items_on_rent set i_cst_con = " & Custcontact.Text & " where i_cst_con = " & cstcont)
                    d.createlog("Updated contact info of Customer " & Custname.Text)
                Catch ex As SqlClient.SqlException
                    MessageBox.Show(ex.Message) '"Entered contact is taken by another customer")
                    d.closeconn()
                    Exit Sub
                End Try
            End If
            If CustBalChange.Text <> "" Then
                d.update_Cust_account(Val(Custcontact.Text), Val(CustBalChange.Text))
            End If
            Clr()
            ldata()
        End If
    End Sub

    Private Sub Srch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Srch.KeyPress
        Dim d As New daoclass
        e.Handled = d.numvalidate(e.KeyChar, e.KeyChar.GetHashCode)
    End Sub

    Private Sub DatagridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridView1.CellDoubleClick
        Custname.Text = DatagridView1.Item("custNme", DatagridView1.CurrentCell.RowIndex).Value.ToString
        Custcontact.Text = DatagridView1.Item("custCont", DatagridView1.CurrentCell.RowIndex).Value.ToString
        Custcontact.Enabled = True
        cstcont = Custcontact.Text
        CstOpBal.Text = DatagridView1.Item("custBalance", DatagridView1.CurrentCell.RowIndex).Value.ToString
    End Sub

    Private Sub Srch_TextChanged(sender As Object, e As EventArgs) Handles Srch.TextChanged
        If Srch.Text <> "" Then
            ldata(Val(Srch.Text))
        Else
            ldata()
        End If
    End Sub

    Private Sub Cust_Master_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub CustBalChange_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustBalChange.KeyPress
        Dim d As New daoclass
        If d.numvalidate(e.KeyChar, e.KeyChar.GetHashCode) OrElse e.KeyChar.GetHashCode = 2949165 Then
            e.Handled = True
        End If
    End Sub
End Class