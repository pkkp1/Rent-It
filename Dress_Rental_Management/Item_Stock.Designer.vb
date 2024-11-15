<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Item_Stock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item_Stock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.rte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.it_type = New System.Windows.Forms.ComboBox()
        Me.tot_amt = New System.Windows.Forms.NumericUpDown()
        Me.stk_amt = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.it_code = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sve = New Guna.UI2.WinForms.Guna2Button()
        Me.del = New Guna.UI2.WinForms.Guna2Button()
        Me.nav = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GoToReporting = New Guna.UI2.WinForms.Guna2Button()
        Me.Rental_Return = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.iCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itotqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iStk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tot_amt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stk_amt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel1.Location = New System.Drawing.Point(304, 219)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 351)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iCode, Me.iType, Me.itotqty, Me.iStk, Me.iRate, Me.sId})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(541, 349)
        Me.DataGridView1.TabIndex = 45
        Me.DataGridView1.TabStop = False
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 23
        Me.DataGridView1.ThemeStyle.ReadOnly = True
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'rte
        '
        Me.rte.Location = New System.Drawing.Point(502, 113)
        Me.rte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rte.Name = "rte"
        Me.rte.Size = New System.Drawing.Size(229, 26)
        Me.rte.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(377, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Rate per item"
        '
        'it_type
        '
        Me.it_type.FormattingEnabled = True
        Me.it_type.Location = New System.Drawing.Point(502, 46)
        Me.it_type.Name = "it_type"
        Me.it_type.Size = New System.Drawing.Size(229, 28)
        Me.it_type.TabIndex = 1
        '
        'tot_amt
        '
        Me.tot_amt.Location = New System.Drawing.Point(502, 80)
        Me.tot_amt.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.tot_amt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(49, 26)
        Me.tot_amt.TabIndex = 2
        Me.tot_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tot_amt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'stk_amt
        '
        Me.stk_amt.Location = New System.Drawing.Point(682, 80)
        Me.stk_amt.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.stk_amt.Name = "stk_amt"
        Me.stk_amt.Size = New System.Drawing.Size(49, 26)
        Me.stk_amt.TabIndex = 3
        Me.stk_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.stk_amt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(378, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 24)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Total Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(597, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 24)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "In Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(378, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Type"
        '
        'it_code
        '
        Me.it_code.Location = New System.Drawing.Point(502, 13)
        Me.it_code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.it_code.Name = "it_code"
        Me.it_code.Size = New System.Drawing.Size(229, 26)
        Me.it_code.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(378, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 24)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Item Code"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Dress_Rental_Management.My.Resources.Resources.navr_borderless
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(895, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(445, 584)
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'sve
        '
        Me.sve.BorderColor = System.Drawing.Color.Transparent
        Me.sve.BorderRadius = 20
        Me.sve.BorderThickness = 2
        Me.sve.CheckedState.Parent = Me.sve
        Me.sve.CustomImages.Parent = Me.sve
        Me.sve.CustomizableEdges.BottomRight = False
        Me.sve.CustomizableEdges.TopLeft = False
        Me.sve.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.sve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.sve.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.sve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.sve.DisabledState.Parent = Me.sve
        Me.sve.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.sve.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.sve.ForeColor = System.Drawing.Color.White
        Me.sve.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.sve.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.sve.HoverState.FillColor = System.Drawing.Color.White
        Me.sve.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.sve.HoverState.Parent = Me.sve
        Me.sve.Location = New System.Drawing.Point(382, 160)
        Me.sve.Name = "sve"
        Me.sve.ShadowDecoration.Parent = Me.sve
        Me.sve.Size = New System.Drawing.Size(145, 45)
        Me.sve.TabIndex = 90
        Me.sve.Text = "Save"
        '
        'del
        '
        Me.del.BorderColor = System.Drawing.Color.Transparent
        Me.del.BorderRadius = 20
        Me.del.BorderThickness = 2
        Me.del.CheckedState.Parent = Me.del
        Me.del.CustomImages.Parent = Me.del
        Me.del.CustomizableEdges.BottomRight = False
        Me.del.CustomizableEdges.TopLeft = False
        Me.del.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.del.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.del.DisabledState.Parent = Me.del
        Me.del.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.del.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.del.ForeColor = System.Drawing.Color.White
        Me.del.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.del.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.del.HoverState.FillColor = System.Drawing.Color.White
        Me.del.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.del.HoverState.Parent = Me.del
        Me.del.Location = New System.Drawing.Point(586, 160)
        Me.del.Name = "del"
        Me.del.ShadowDecoration.Parent = Me.del
        Me.del.Size = New System.Drawing.Size(145, 45)
        Me.del.TabIndex = 91
        Me.del.Text = "Delete"
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
        Me.nav.Controls.Add(Me.GoToBilling)
        Me.nav.Controls.Add(Me.GoToSettings)
        Me.nav.Controls.Add(Me.PictureBox1)
        Me.nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav.Location = New System.Drawing.Point(0, 0)
        Me.nav.Name = "nav"
        Me.nav.ShadowDecoration.Parent = Me.nav
        Me.nav.Size = New System.Drawing.Size(246, 609)
        Me.nav.TabIndex = 95
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
        Me.GoToReporting.Location = New System.Drawing.Point(51, 436)
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
        Me.Rental_Return.Location = New System.Drawing.Point(51, 385)
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
        Me.GoToPurchase.Location = New System.Drawing.Point(51, 334)
        Me.GoToPurchase.Name = "GoToPurchase"
        Me.GoToPurchase.ShadowDecoration.Parent = Me.GoToPurchase
        Me.GoToPurchase.Size = New System.Drawing.Size(145, 45)
        Me.GoToPurchase.TabIndex = 90
        Me.GoToPurchase.Text = "Purchase"
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
        Me.GoToSettings.Location = New System.Drawing.Point(51, 283)
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
        'iCode
        '
        Me.iCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.iCode.DataPropertyName = "i_code"
        Me.iCode.Frozen = True
        Me.iCode.HeaderText = "Item Code"
        Me.iCode.Name = "iCode"
        Me.iCode.ReadOnly = True
        Me.iCode.Width = 120
        '
        'iType
        '
        Me.iType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.iType.DataPropertyName = "i_type"
        Me.iType.Frozen = True
        Me.iType.HeaderText = "Type"
        Me.iType.Name = "iType"
        Me.iType.ReadOnly = True
        Me.iType.Width = 180
        '
        'itotqty
        '
        Me.itotqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.itotqty.DataPropertyName = "i_qty"
        Me.itotqty.Frozen = True
        Me.itotqty.HeaderText = "Total Amt."
        Me.itotqty.Name = "itotqty"
        Me.itotqty.ReadOnly = True
        Me.itotqty.Width = 60
        '
        'iStk
        '
        Me.iStk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.iStk.DataPropertyName = "i_in_stk"
        Me.iStk.Frozen = True
        Me.iStk.HeaderText = "In Stock"
        Me.iStk.Name = "iStk"
        Me.iStk.ReadOnly = True
        '
        'iRate
        '
        Me.iRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.iRate.DataPropertyName = "i_rte"
        Me.iRate.Frozen = True
        Me.iRate.HeaderText = "Rate"
        Me.iRate.Name = "iRate"
        Me.iRate.ReadOnly = True
        '
        'sId
        '
        Me.sId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.sId.DataPropertyName = "sh_id"
        Me.sId.HeaderText = "Shop Id"
        Me.sId.Name = "sId"
        Me.sId.ReadOnly = True
        Me.sId.Visible = False
        '
        'Item_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1352, 609)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.sve)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.it_code)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.stk_amt)
        Me.Controls.Add(Me.tot_amt)
        Me.Controls.Add(Me.it_type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rte)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Item_Stock"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tot_amt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stk_amt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents it_type As ComboBox
    Friend WithEvents tot_amt As NumericUpDown
    Friend WithEvents stk_amt As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents it_code As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents sve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents del As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nav As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GoToReporting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Rental_Return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents iCode As DataGridViewTextBoxColumn
    Friend WithEvents iType As DataGridViewTextBoxColumn
    Friend WithEvents itotqty As DataGridViewTextBoxColumn
    Friend WithEvents iStk As DataGridViewTextBoxColumn
    Friend WithEvents iRate As DataGridViewTextBoxColumn
    Friend WithEvents sId As DataGridViewTextBoxColumn
End Class
