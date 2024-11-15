<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.P_vendor = New System.Windows.Forms.ComboBox()
        Me.P_sort = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PTo = New System.Windows.Forms.DateTimePicker()
        Me.PFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PurchaseReport = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.S_cst = New System.Windows.Forms.ComboBox()
        Me.S_sort = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.S_biller = New System.Windows.Forms.ComboBox()
        Me.reportPanel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.STo = New System.Windows.Forms.DateTimePicker()
        Me.SFrom = New System.Windows.Forms.DateTimePicker()
        Me.HisLbl2 = New System.Windows.Forms.Label()
        Me.HisLbl3 = New System.Windows.Forms.Label()
        Me.SalesReport = New Guna.UI2.WinForms.Guna2Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.nav = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Rental_Return = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToItemStock = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.reportPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(246, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(961, 662)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.Guna2TabControl1.TabIndex = 92
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Guna2GroupBox3)
        Me.TabPage1.Controls.Add(Me.Guna2GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(953, 614)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generation"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(509, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 608)
        Me.Panel2.TabIndex = 128
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Dress_Rental_Management.My.Resources.Resources.navr_borderless
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(441, 608)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox3.BorderRadius = 20
        Me.Guna2GroupBox3.Controls.Add(Me.Label11)
        Me.Guna2GroupBox3.Controls.Add(Me.P_vendor)
        Me.Guna2GroupBox3.Controls.Add(Me.P_sort)
        Me.Guna2GroupBox3.Controls.Add(Me.Label12)
        Me.Guna2GroupBox3.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox3.Controls.Add(Me.PurchaseReport)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(52, 304)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(412, 291)
        Me.Guna2GroupBox3.TabIndex = 127
        Me.Guna2GroupBox3.Text = "Purchase Report"
        Me.Guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(46, 177)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 19)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Grouped by:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'P_vendor
        '
        Me.P_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_vendor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.P_vendor.FormattingEnabled = True
        Me.P_vendor.Location = New System.Drawing.Point(142, 142)
        Me.P_vendor.Name = "P_vendor"
        Me.P_vendor.Size = New System.Drawing.Size(208, 25)
        Me.P_vendor.TabIndex = 126
        '
        'P_sort
        '
        Me.P_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_sort.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.P_sort.FormattingEnabled = True
        Me.P_sort.Items.AddRange(New Object() {"Invoice no", "Vendor", "Date"})
        Me.P_sort.Location = New System.Drawing.Point(142, 174)
        Me.P_sort.Name = "P_sort"
        Me.P_sort.Size = New System.Drawing.Size(208, 25)
        Me.P_sort.TabIndex = 124
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(46, 145)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 19)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Vendor:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PTo)
        Me.Panel1.Controls.Add(Me.PFrom)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Panel1.Location = New System.Drawing.Point(39, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 93)
        Me.Panel1.TabIndex = 121
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(7, 5)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 19)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Bought Between:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PTo
        '
        Me.PTo.Location = New System.Drawing.Point(103, 60)
        Me.PTo.Name = "PTo"
        Me.PTo.Size = New System.Drawing.Size(208, 25)
        Me.PTo.TabIndex = 119
        '
        'PFrom
        '
        Me.PFrom.Location = New System.Drawing.Point(103, 29)
        Me.PFrom.Name = "PFrom"
        Me.PFrom.Size = New System.Drawing.Size(208, 25)
        Me.PFrom.TabIndex = 118
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(7, 33)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 19)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "From Date:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(7, 65)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 19)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "To Date:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PurchaseReport
        '
        Me.PurchaseReport.BorderColor = System.Drawing.Color.Transparent
        Me.PurchaseReport.BorderRadius = 20
        Me.PurchaseReport.BorderThickness = 2
        Me.PurchaseReport.CheckedState.Parent = Me.PurchaseReport
        Me.PurchaseReport.CustomImages.Parent = Me.PurchaseReport
        Me.PurchaseReport.CustomizableEdges.BottomRight = False
        Me.PurchaseReport.CustomizableEdges.TopLeft = False
        Me.PurchaseReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PurchaseReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PurchaseReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PurchaseReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PurchaseReport.DisabledState.Parent = Me.PurchaseReport
        Me.PurchaseReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.PurchaseReport.ForeColor = System.Drawing.Color.White
        Me.PurchaseReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.HoverState.FillColor = System.Drawing.Color.White
        Me.PurchaseReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurchaseReport.HoverState.Parent = Me.PurchaseReport
        Me.PurchaseReport.Location = New System.Drawing.Point(142, 235)
        Me.PurchaseReport.Name = "PurchaseReport"
        Me.PurchaseReport.ShadowDecoration.Parent = Me.PurchaseReport
        Me.PurchaseReport.Size = New System.Drawing.Size(208, 44)
        Me.PurchaseReport.TabIndex = 117
        Me.PurchaseReport.TabStop = False
        Me.PurchaseReport.Text = "Generate"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.S_cst)
        Me.Guna2GroupBox1.Controls.Add(Me.S_sort)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.S_biller)
        Me.Guna2GroupBox1.Controls.Add(Me.reportPanel1)
        Me.Guna2GroupBox1.Controls.Add(Me.SalesReport)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(52, 7)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(412, 291)
        Me.Guna2GroupBox1.TabIndex = 122
        Me.Guna2GroupBox1.Text = "Sales Report"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Grouped by:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'S_cst
        '
        Me.S_cst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_cst.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.S_cst.FormattingEnabled = True
        Me.S_cst.Location = New System.Drawing.Point(142, 172)
        Me.S_cst.Name = "S_cst"
        Me.S_cst.Size = New System.Drawing.Size(208, 25)
        Me.S_cst.TabIndex = 126
        '
        'S_sort
        '
        Me.S_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_sort.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.S_sort.FormattingEnabled = True
        Me.S_sort.Items.AddRange(New Object() {"Bill No", "Employee", "Customer", "Date"})
        Me.S_sort.Location = New System.Drawing.Point(142, 204)
        Me.S_sort.Name = "S_sort"
        Me.S_sort.Size = New System.Drawing.Size(208, 25)
        Me.S_sort.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Customer:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Biller:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'S_biller
        '
        Me.S_biller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_biller.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.S_biller.FormattingEnabled = True
        Me.S_biller.Location = New System.Drawing.Point(142, 141)
        Me.S_biller.Name = "S_biller"
        Me.S_biller.Size = New System.Drawing.Size(208, 25)
        Me.S_biller.TabIndex = 122
        '
        'reportPanel1
        '
        Me.reportPanel1.Controls.Add(Me.Label2)
        Me.reportPanel1.Controls.Add(Me.STo)
        Me.reportPanel1.Controls.Add(Me.SFrom)
        Me.reportPanel1.Controls.Add(Me.HisLbl2)
        Me.reportPanel1.Controls.Add(Me.HisLbl3)
        Me.reportPanel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.reportPanel1.Location = New System.Drawing.Point(39, 43)
        Me.reportPanel1.Name = "reportPanel1"
        Me.reportPanel1.Size = New System.Drawing.Size(325, 93)
        Me.reportPanel1.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Sold Between:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'STo
        '
        Me.STo.Location = New System.Drawing.Point(103, 60)
        Me.STo.Name = "STo"
        Me.STo.Size = New System.Drawing.Size(208, 25)
        Me.STo.TabIndex = 119
        '
        'SFrom
        '
        Me.SFrom.Location = New System.Drawing.Point(103, 29)
        Me.SFrom.Name = "SFrom"
        Me.SFrom.Size = New System.Drawing.Size(208, 25)
        Me.SFrom.TabIndex = 118
        '
        'HisLbl2
        '
        Me.HisLbl2.AutoSize = True
        Me.HisLbl2.BackColor = System.Drawing.Color.White
        Me.HisLbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl2.Location = New System.Drawing.Point(7, 33)
        Me.HisLbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl2.Name = "HisLbl2"
        Me.HisLbl2.Size = New System.Drawing.Size(77, 19)
        Me.HisLbl2.TabIndex = 114
        Me.HisLbl2.Text = "From Date:"
        Me.HisLbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HisLbl3
        '
        Me.HisLbl3.AutoSize = True
        Me.HisLbl3.BackColor = System.Drawing.Color.White
        Me.HisLbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl3.Location = New System.Drawing.Point(7, 65)
        Me.HisLbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl3.Name = "HisLbl3"
        Me.HisLbl3.Size = New System.Drawing.Size(59, 19)
        Me.HisLbl3.TabIndex = 115
        Me.HisLbl3.Text = "To Date:"
        Me.HisLbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SalesReport
        '
        Me.SalesReport.BorderColor = System.Drawing.Color.Transparent
        Me.SalesReport.BorderRadius = 20
        Me.SalesReport.BorderThickness = 2
        Me.SalesReport.CheckedState.Parent = Me.SalesReport
        Me.SalesReport.CustomImages.Parent = Me.SalesReport
        Me.SalesReport.CustomizableEdges.BottomRight = False
        Me.SalesReport.CustomizableEdges.TopLeft = False
        Me.SalesReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SalesReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SalesReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SalesReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SalesReport.DisabledState.Parent = Me.SalesReport
        Me.SalesReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.SalesReport.ForeColor = System.Drawing.Color.White
        Me.SalesReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.HoverState.FillColor = System.Drawing.Color.White
        Me.SalesReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SalesReport.HoverState.Parent = Me.SalesReport
        Me.SalesReport.Location = New System.Drawing.Point(142, 235)
        Me.SalesReport.Name = "SalesReport"
        Me.SalesReport.ShadowDecoration.Parent = Me.SalesReport
        Me.SalesReport.Size = New System.Drawing.Size(208, 44)
        Me.SalesReport.TabIndex = 117
        Me.SalesReport.TabStop = False
        Me.SalesReport.Text = "Generate"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(953, 614)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(947, 608)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'nav
        '
        Me.nav.BackColor = System.Drawing.Color.White
        Me.nav.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.nav.BorderRadius = 1
        Me.nav.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.nav.BorderThickness = 2
        Me.nav.Controls.Add(Me.Rental_Return)
        Me.nav.Controls.Add(Me.GoToPurchase)
        Me.nav.Controls.Add(Me.GoToItemStock)
        Me.nav.Controls.Add(Me.GoToBilling)
        Me.nav.Controls.Add(Me.GoToSettings)
        Me.nav.Controls.Add(Me.PictureBox1)
        Me.nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav.Location = New System.Drawing.Point(0, 0)
        Me.nav.Name = "nav"
        Me.nav.ShadowDecoration.Parent = Me.nav
        Me.nav.Size = New System.Drawing.Size(246, 662)
        Me.nav.TabIndex = 127
        '
        'Rental_Return
        '
        Me.Rental_Return.BorderColor = System.Drawing.Color.Transparent
        Me.Rental_Return.BorderRadius = 20
        Me.Rental_Return.BorderThickness = 2
        Me.Rental_Return.CheckedState.Parent = Me.Rental_Return
        Me.Rental_Return.CustomImages.Parent = Me.Rental_Return
        Me.Rental_Return.CustomizableEdges.BottomRight = False
        Me.Rental_Return.CustomizableEdges.TopLeft = False
        Me.Rental_Return.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Rental_Return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Rental_Return.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Rental_Return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Rental_Return.DisabledState.Parent = Me.Rental_Return
        Me.Rental_Return.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_Return.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Rental_Return.ForeColor = System.Drawing.Color.White
        Me.Rental_Return.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_Return.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_Return.HoverState.FillColor = System.Drawing.Color.White
        Me.Rental_Return.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_Return.HoverState.Parent = Me.Rental_Return
        Me.Rental_Return.Location = New System.Drawing.Point(51, 436)
        Me.Rental_Return.Name = "Rental_Return"
        Me.Rental_Return.ShadowDecoration.Parent = Me.Rental_Return
        Me.Rental_Return.Size = New System.Drawing.Size(145, 45)
        Me.Rental_Return.TabIndex = 91
        Me.Rental_Return.Text = "Return"
        '
        'GoToPurchase
        '
        Me.GoToPurchase.BorderColor = System.Drawing.Color.Transparent
        Me.GoToPurchase.BorderRadius = 20
        Me.GoToPurchase.BorderThickness = 2
        Me.GoToPurchase.CheckedState.Parent = Me.GoToPurchase
        Me.GoToPurchase.CustomImages.Parent = Me.GoToPurchase
        Me.GoToPurchase.CustomizableEdges.BottomRight = False
        Me.GoToPurchase.CustomizableEdges.TopLeft = False
        Me.GoToPurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GoToPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GoToPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GoToPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GoToPurchase.DisabledState.Parent = Me.GoToPurchase
        Me.GoToPurchase.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToPurchase.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GoToPurchase.ForeColor = System.Drawing.Color.White
        Me.GoToPurchase.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToPurchase.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToPurchase.HoverState.FillColor = System.Drawing.Color.White
        Me.GoToPurchase.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToPurchase.HoverState.Parent = Me.GoToPurchase
        Me.GoToPurchase.Location = New System.Drawing.Point(51, 385)
        Me.GoToPurchase.Name = "GoToPurchase"
        Me.GoToPurchase.ShadowDecoration.Parent = Me.GoToPurchase
        Me.GoToPurchase.Size = New System.Drawing.Size(145, 45)
        Me.GoToPurchase.TabIndex = 90
        Me.GoToPurchase.Text = "Purchase"
        '
        'GoToItemStock
        '
        Me.GoToItemStock.BorderColor = System.Drawing.Color.Transparent
        Me.GoToItemStock.BorderRadius = 20
        Me.GoToItemStock.BorderThickness = 2
        Me.GoToItemStock.CheckedState.Parent = Me.GoToItemStock
        Me.GoToItemStock.CustomImages.Parent = Me.GoToItemStock
        Me.GoToItemStock.CustomizableEdges.BottomRight = False
        Me.GoToItemStock.CustomizableEdges.TopLeft = False
        Me.GoToItemStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GoToItemStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GoToItemStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GoToItemStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GoToItemStock.DisabledState.Parent = Me.GoToItemStock
        Me.GoToItemStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToItemStock.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GoToItemStock.ForeColor = System.Drawing.Color.White
        Me.GoToItemStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToItemStock.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToItemStock.HoverState.FillColor = System.Drawing.Color.White
        Me.GoToItemStock.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToItemStock.HoverState.Parent = Me.GoToItemStock
        Me.GoToItemStock.Location = New System.Drawing.Point(51, 283)
        Me.GoToItemStock.Name = "GoToItemStock"
        Me.GoToItemStock.ShadowDecoration.Parent = Me.GoToItemStock
        Me.GoToItemStock.Size = New System.Drawing.Size(145, 45)
        Me.GoToItemStock.TabIndex = 89
        Me.GoToItemStock.Text = "Stock"
        '
        'GoToBilling
        '
        Me.GoToBilling.BorderColor = System.Drawing.Color.Transparent
        Me.GoToBilling.BorderRadius = 20
        Me.GoToBilling.BorderThickness = 2
        Me.GoToBilling.CheckedState.Parent = Me.GoToBilling
        Me.GoToBilling.CustomImages.Parent = Me.GoToBilling
        Me.GoToBilling.CustomizableEdges.BottomRight = False
        Me.GoToBilling.CustomizableEdges.TopLeft = False
        Me.GoToBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GoToBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GoToBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GoToBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GoToBilling.DisabledState.Parent = Me.GoToBilling
        Me.GoToBilling.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToBilling.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GoToBilling.ForeColor = System.Drawing.Color.White
        Me.GoToBilling.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToBilling.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToBilling.HoverState.FillColor = System.Drawing.Color.White
        Me.GoToBilling.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToBilling.HoverState.Parent = Me.GoToBilling
        Me.GoToBilling.Location = New System.Drawing.Point(51, 232)
        Me.GoToBilling.Name = "GoToBilling"
        Me.GoToBilling.ShadowDecoration.Parent = Me.GoToBilling
        Me.GoToBilling.Size = New System.Drawing.Size(145, 45)
        Me.GoToBilling.TabIndex = 88
        Me.GoToBilling.Text = "Bill Maker"
        '
        'GoToSettings
        '
        Me.GoToSettings.BorderColor = System.Drawing.Color.Transparent
        Me.GoToSettings.BorderRadius = 20
        Me.GoToSettings.BorderThickness = 2
        Me.GoToSettings.CheckedState.Parent = Me.GoToSettings
        Me.GoToSettings.CustomImages.Parent = Me.GoToSettings
        Me.GoToSettings.CustomizableEdges.BottomRight = False
        Me.GoToSettings.CustomizableEdges.TopLeft = False
        Me.GoToSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GoToSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GoToSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GoToSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GoToSettings.DisabledState.Parent = Me.GoToSettings
        Me.GoToSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToSettings.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GoToSettings.ForeColor = System.Drawing.Color.White
        Me.GoToSettings.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToSettings.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToSettings.HoverState.FillColor = System.Drawing.Color.White
        Me.GoToSettings.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToSettings.HoverState.Parent = Me.GoToSettings
        Me.GoToSettings.Location = New System.Drawing.Point(51, 334)
        Me.GoToSettings.Name = "GoToSettings"
        Me.GoToSettings.ShadowDecoration.Parent = Me.GoToSettings
        Me.GoToSettings.Size = New System.Drawing.Size(145, 45)
        Me.GoToSettings.TabIndex = 13
        Me.GoToSettings.Text = "Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.Dress_Rental_Management.My.Resources.Resources.logo11
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(14, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 79)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1207, 662)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Reports"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.reportPanel1.ResumeLayout(False)
        Me.reportPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.nav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents reportPanel1 As Panel
    Friend WithEvents STo As DateTimePicker
    Friend WithEvents SFrom As DateTimePicker
    Friend WithEvents HisLbl2 As Label
    Friend WithEvents HisLbl3 As Label
    Friend WithEvents SalesReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents S_biller As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents S_sort As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents S_cst As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents P_vendor As ComboBox
    Friend WithEvents P_sort As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PTo As DateTimePicker
    Friend WithEvents PFrom As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PurchaseReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nav As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Rental_Return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToItemStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
