Imports CrystalDecisions.CrystalReports.Engine
Public Class Reports

    Private Sub Reports_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles Me.Load
        reportPanel1.BackColor = Color.White
        Panel1.BackColor = Color.White
        TabPage1.BackColor = Color.White
        Dim d As New daoclass
        Dim re As SqlClient.SqlDataReader = d.getdata("Select distinct biller_nme from Bill_master where b_shop = " & Emp_shop_ID)
        S_biller.Items.Add("All Employees")
        While re.Read
            S_biller.Items.Add(re.Item(0))
        End While
        d.closeconn()
        re = d.getdata("Select distinct cst_cont from Bill_master where b_shop = " & Emp_shop_ID)
        S_cst.Items.Add("All Customers")
        While re.Read
            S_cst.Items.Add(re.Item(0))
        End While
        d.closeconn()
        re = d.getdata("Select distinct p_nme from purchase_master where sh_id = " & Emp_shop_ID)
        P_vendor.Items.Add("All Vendors")
        While re.Read
            P_vendor.Items.Add(re.Item(0))
        End While
        d.closeconn()
        Guna2TabControl1.Width = Me.Width - nav.Width
        Panel2.Width = Guna2TabControl1.Width - Guna2GroupBox1.Width - 100
        P_vendor.SelectedIndex = 0
        P_sort.SelectedIndex = 0
        S_biller.SelectedIndex = 0
        S_cst.SelectedIndex = 0
        S_sort.SelectedIndex = 0
        PFrom.Value = Today.AddMonths(-1)
        SFrom.Value = Today.AddMonths(-1)

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

    Private Sub PurchaseReport_Click(sender As Object, e As EventArgs) Handles PurchaseReport.Click
        Dim ds As New DataSet
        Dim d As New daoclass
        Dim rpt As Object = Nothing
        Dim qry As String = "Select * from Purchase_master where sh_id = " & Emp_shop_ID & " And p_dte between '" & PFrom.Value.ToString("yyyy/MM/dd") & "' And '" & PTo.Value.ToString("yyyy/MM/dd") & "'"
        If P_vendor.Text <> "All Vendors" Then
            qry &= " And p_nme = '" & P_vendor.Text & "'"
        End If
        ds = d.datasetfill(qry)
        Dim re1 As SqlClient.SqlDataReader = d.getdata(qry)
        Dim datadoesntexist As Boolean = True
        While re1.Read
            datadoesntexist = False
        End While
        d.closeconn()
        If datadoesntexist Then
            MessageBox.Show("No records available")
            Exit Sub
        End If
        Dim sname As String = ""
        Dim re As SqlClient.SqlDataReader = d.getdata("Select s_nme from shop_master where ID = " & Emp_shop_ID)
        While re.Read
            sname = re.Item(0)
        End While
        d.closeconn()
        Dim orpt As New ReportDocument
        Select Case P_sort.Text
            Case "Invoice no"
                rpt = New PurchaseReptInvoice
            Case "Vendor"
                rpt = New PurchaseReptVndr
            Case "Date"
                rpt = New PurchaseReptDte
        End Select
        rpt.Load()
        orpt.Load(rpt.FileName)
        orpt.Refresh()
        orpt.SetDataSource(ds.Tables(0))
        CrystalReportViewer1.ReportSource = orpt
        orpt.SetParameterValue("Shopnme", sname)
        Guna2TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub SalesReport_Click(sender As Object, e As EventArgs) Handles SalesReport.Click
        Dim ds As New DataSet
        Dim d As New daoclass
        Dim rpt As Object = Nothing
        Dim qry As String = "Select * from Bill_Master where b_shop = " & Emp_shop_ID & " And b_dte between '" & PFrom.Value.ToString("yyyy/MM/dd") & "' And '" & PTo.Value.ToString("yyyy/MM/dd") & "'"
        If S_biller.Text <> "All Employees" Then
            qry &= " And biller_nme = '" & S_biller.Text & "'"
        End If
        If S_cst.Text <> "All Customers" Then
            qry &= " And cst_cont = " & S_cst.Text
        End If
        ds = d.datasetfill(qry)
        Dim re1 As SqlClient.SqlDataReader = d.getdata(qry)
        Dim datadoesntexist As Boolean = True
        While re1.Read
            datadoesntexist = False
        End While
        d.closeconn()
        If datadoesntexist Then
            MessageBox.Show("No records available")
            Exit Sub
        End If
        Dim sname As String = ""
        Dim re As SqlClient.SqlDataReader = d.getdata("Select s_nme from shop_master where ID = " & Emp_shop_ID)
        While re.Read
            sname = re.Item(0)
        End While
        d.closeconn()
        Dim orpt As New ReportDocument
        Select Case S_sort.Text
            Case "Bill No"
                rpt = New BillReptNo
            Case "Employee"
                rpt = New BillReptEmp
            Case "Customer"
                rpt = New BillReptCst
            Case "Date"
                rpt = New BillReptDte
        End Select
        rpt.Load()
        orpt.Load(rpt.FileName)
        orpt.Refresh()
        orpt.SetDataSource(ds.Tables(0))
        CrystalReportViewer1.ReportSource = orpt
        orpt.SetParameterValue("Shopnme", sname)
        Guna2TabControl1.SelectedTab = TabPage2
    End Sub

End Class