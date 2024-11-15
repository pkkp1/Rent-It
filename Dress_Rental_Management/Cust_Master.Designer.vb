<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cust_Master
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cust_Master))
        Me.CstOpBal = New System.Windows.Forms.Label()
        Me.DatagridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.shopid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custNme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custCont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CustBalChange = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Custname = New System.Windows.Forms.Label()
        Me.Srch = New System.Windows.Forms.TextBox()
        Me.Del = New Guna.UI2.WinForms.Guna2Button()
        Me.Sve = New Guna.UI2.WinForms.Guna2Button()
        Me.nav = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GoToReporting = New Guna.UI2.WinForms.Guna2Button()
        Me.Rental_Return = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToItemStock = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Custcontact = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CstOpBal
        '
        Me.CstOpBal.AutoSize = True
        Me.CstOpBal.BackColor = System.Drawing.Color.White
        Me.CstOpBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CstOpBal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CstOpBal.Location = New System.Drawing.Point(479, 127)
        Me.CstOpBal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CstOpBal.Name = "CstOpBal"
        Me.CstOpBal.Size = New System.Drawing.Size(20, 24)
        Me.CstOpBal.TabIndex = 124
        Me.CstOpBal.Text = "0"
        Me.CstOpBal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DatagridView1
        '
        Me.DatagridView1.AllowUserToAddRows = False
        Me.DatagridView1.AllowUserToDeleteRows = False
        Me.DatagridView1.AllowUserToResizeColumns = False
        Me.DatagridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DatagridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DatagridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridView1.BackgroundColor = System.Drawing.Color.White
        Me.DatagridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DatagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DatagridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.shopid, Me.custNme, Me.custCont, Me.custBalance, Me.custDisc})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DatagridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridView1.EnableHeadersVisualStyles = False
        Me.DatagridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.DatagridView1.Location = New System.Drawing.Point(0, 0)
        Me.DatagridView1.MultiSelect = False
        Me.DatagridView1.Name = "DatagridView1"
        Me.DatagridView1.ReadOnly = True
        Me.DatagridView1.RowHeadersVisible = False
        Me.DatagridView1.RowTemplate.ReadOnly = True
        Me.DatagridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridView1.Size = New System.Drawing.Size(418, 321)
        Me.DatagridView1.TabIndex = 48
        Me.DatagridView1.TabStop = False
        Me.DatagridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.DatagridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DatagridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DatagridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DatagridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DatagridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DatagridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DatagridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.DatagridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DatagridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DatagridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DatagridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DatagridView1.ThemeStyle.HeaderStyle.Height = 23
        Me.DatagridView1.ThemeStyle.ReadOnly = True
        Me.DatagridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DatagridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DatagridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DatagridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DatagridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DatagridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'shopid
        '
        Me.shopid.DataPropertyName = "c_sID"
        Me.shopid.HeaderText = "shopid"
        Me.shopid.Name = "shopid"
        Me.shopid.ReadOnly = True
        Me.shopid.Visible = False
        '
        'custNme
        '
        Me.custNme.DataPropertyName = "c_nme"
        Me.custNme.HeaderText = "Name"
        Me.custNme.Name = "custNme"
        Me.custNme.ReadOnly = True
        '
        'custCont
        '
        Me.custCont.DataPropertyName = "c_contact"
        Me.custCont.HeaderText = "Contact"
        Me.custCont.Name = "custCont"
        Me.custCont.ReadOnly = True
        '
        'custBalance
        '
        Me.custBalance.DataPropertyName = "c_opBal"
        Me.custBalance.HeaderText = "Bal"
        Me.custBalance.Name = "custBalance"
        Me.custBalance.ReadOnly = True
        '
        'custDisc
        '
        Me.custDisc.DataPropertyName = "c_prev_Disc"
        Me.custDisc.HeaderText = "Prev. Disc."
        Me.custDisc.Name = "custDisc"
        Me.custDisc.ReadOnly = True
        Me.custDisc.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DatagridView1)
        Me.Panel1.Location = New System.Drawing.Point(273, 348)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 321)
        Me.Panel1.TabIndex = 118
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Dress_Rental_Management.My.Resources.Resources.navr_borderless
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(711, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(631, 589)
        Me.PictureBox2.TabIndex = 119
        Me.PictureBox2.TabStop = False
        '
        'CustBalChange
        '
        Me.CustBalChange.BackColor = System.Drawing.Color.White
        Me.CustBalChange.ForeColor = System.Drawing.Color.Black
        Me.CustBalChange.Location = New System.Drawing.Point(483, 159)
        Me.CustBalChange.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CustBalChange.Name = "CustBalChange"
        Me.CustBalChange.Size = New System.Drawing.Size(111, 26)
        Me.CustBalChange.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(270, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 24)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Payment amount"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(272, 302)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 34)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Contact no"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Custname
        '
        Me.Custname.AutoSize = True
        Me.Custname.BackColor = System.Drawing.Color.White
        Me.Custname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Custname.Location = New System.Drawing.Point(479, 58)
        Me.Custname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Custname.Name = "Custname"
        Me.Custname.Size = New System.Drawing.Size(16, 24)
        Me.Custname.TabIndex = 122
        Me.Custname.Text = "-"
        Me.Custname.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Srch
        '
        Me.Srch.BackColor = System.Drawing.Color.White
        Me.Srch.ForeColor = System.Drawing.Color.Black
        Me.Srch.Location = New System.Drawing.Point(410, 306)
        Me.Srch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Srch.MaxLength = 10
        Me.Srch.Name = "Srch"
        Me.Srch.Size = New System.Drawing.Size(135, 26)
        Me.Srch.TabIndex = 0
        '
        'Del
        '
        Me.Del.BorderColor = System.Drawing.Color.Transparent
        Me.Del.BorderRadius = 20
        Me.Del.BorderThickness = 2
        Me.Del.CheckedState.Parent = Me.Del
        Me.Del.CustomImages.Parent = Me.Del
        Me.Del.CustomizableEdges.BottomRight = False
        Me.Del.CustomizableEdges.TopLeft = False
        Me.Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Del.DisabledState.Parent = Me.Del
        Me.Del.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Del.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Del.ForeColor = System.Drawing.Color.White
        Me.Del.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Del.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Del.HoverState.FillColor = System.Drawing.Color.White
        Me.Del.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Del.HoverState.Parent = Me.Del
        Me.Del.Location = New System.Drawing.Point(274, 205)
        Me.Del.Name = "Del"
        Me.Del.ShadowDecoration.Parent = Me.Del
        Me.Del.Size = New System.Drawing.Size(129, 33)
        Me.Del.TabIndex = 91
        Me.Del.Text = "Delete"
        '
        'Sve
        '
        Me.Sve.BorderColor = System.Drawing.Color.Transparent
        Me.Sve.BorderRadius = 20
        Me.Sve.BorderThickness = 2
        Me.Sve.CheckedState.Parent = Me.Sve
        Me.Sve.CustomImages.Parent = Me.Sve
        Me.Sve.CustomizableEdges.BottomRight = False
        Me.Sve.CustomizableEdges.TopLeft = False
        Me.Sve.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Sve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Sve.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Sve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Sve.DisabledState.Parent = Me.Sve
        Me.Sve.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Sve.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sve.ForeColor = System.Drawing.Color.White
        Me.Sve.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Sve.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Sve.HoverState.FillColor = System.Drawing.Color.White
        Me.Sve.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Sve.HoverState.Parent = Me.Sve
        Me.Sve.Location = New System.Drawing.Point(546, 205)
        Me.Sve.Name = "Sve"
        Me.Sve.ShadowDecoration.Parent = Me.Sve
        Me.Sve.Size = New System.Drawing.Size(145, 33)
        Me.Sve.TabIndex = 91
        Me.Sve.Text = "Update Account"
        '
        'nav
        '
        Me.nav.BackColor = System.Drawing.Color.White
        Me.nav.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.nav.BorderRadius = 1
        Me.nav.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.nav.BorderThickness = 2
        Me.nav.Controls.Add(Me.GoToReporting)
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
        Me.nav.Size = New System.Drawing.Size(246, 681)
        Me.nav.TabIndex = 132
        '
        'GoToReporting
        '
        Me.GoToReporting.BorderColor = System.Drawing.Color.Transparent
        Me.GoToReporting.BorderRadius = 20
        Me.GoToReporting.BorderThickness = 2
        Me.GoToReporting.CheckedState.Parent = Me.GoToReporting
        Me.GoToReporting.CustomImages.Parent = Me.GoToReporting
        Me.GoToReporting.CustomizableEdges.BottomRight = False
        Me.GoToReporting.CustomizableEdges.TopLeft = False
        Me.GoToReporting.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GoToReporting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GoToReporting.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GoToReporting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GoToReporting.DisabledState.Parent = Me.GoToReporting
        Me.GoToReporting.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToReporting.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GoToReporting.ForeColor = System.Drawing.Color.White
        Me.GoToReporting.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToReporting.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToReporting.HoverState.FillColor = System.Drawing.Color.White
        Me.GoToReporting.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GoToReporting.HoverState.Parent = Me.GoToReporting
        Me.GoToReporting.Location = New System.Drawing.Point(51, 487)
        Me.GoToReporting.Name = "GoToReporting"
        Me.GoToReporting.ShadowDecoration.Parent = Me.GoToReporting
        Me.GoToReporting.Size = New System.Drawing.Size(145, 45)
        Me.GoToReporting.TabIndex = 92
        Me.GoToReporting.Text = "Reports"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(272, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Customer Balance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Custcontact
        '
        Me.Custcontact.Enabled = False
        Me.Custcontact.ForeColor = System.Drawing.Color.Black
        Me.Custcontact.Location = New System.Drawing.Point(483, 93)
        Me.Custcontact.Mask = "9999999999"
        Me.Custcontact.Name = "Custcontact"
        Me.Custcontact.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Custcontact.Size = New System.Drawing.Size(208, 26)
        Me.Custcontact.TabIndex = 134
        Me.Custcontact.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(272, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 24)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Contact No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(272, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 24)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Customer Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cust_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1337, 681)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Custcontact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.Sve)
        Me.Controls.Add(Me.Del)
        Me.Controls.Add(Me.Srch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CustBalChange)
        Me.Controls.Add(Me.Custname)
        Me.Controls.Add(Me.CstOpBal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Cust_Master"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CstOpBal As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DatagridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CustBalChange As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Custname As Label
    Friend WithEvents Srch As TextBox
    Friend WithEvents shopid As DataGridViewTextBoxColumn
    Friend WithEvents custNme As DataGridViewTextBoxColumn
    Friend WithEvents custCont As DataGridViewTextBoxColumn
    Friend WithEvents custBalance As DataGridViewTextBoxColumn
    Friend WithEvents custDisc As DataGridViewTextBoxColumn
    Friend WithEvents Del As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Sve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nav As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GoToReporting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Rental_Return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToItemStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Custcontact As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
