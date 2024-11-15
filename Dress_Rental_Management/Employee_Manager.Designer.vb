<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Manager))
        Me.pwd = New System.Windows.Forms.Label()
        Me.adm_pwd = New System.Windows.Forms.TextBox()
        Me.emMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmPwd = New System.Windows.Forms.TextBox()
        Me.EmRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DatagridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.shopid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpNme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pass_word = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Emname = New System.Windows.Forms.TextBox()
        Me.nav = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GoToReporting = New Guna.UI2.WinForms.Guna2Button()
        Me.Rental_Return = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToItemStock = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.BackColor = System.Drawing.Color.White
        Me.pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pwd.Location = New System.Drawing.Point(275, 193)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(152, 24)
        Me.pwd.TabIndex = 17
        Me.pwd.Text = "Admin Password"
        '
        'adm_pwd
        '
        Me.adm_pwd.Location = New System.Drawing.Point(472, 190)
        Me.adm_pwd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.adm_pwd.Name = "adm_pwd"
        Me.adm_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.adm_pwd.Size = New System.Drawing.Size(267, 26)
        Me.adm_pwd.TabIndex = 4
        '
        'emMail
        '
        Me.emMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.emMail.Location = New System.Drawing.Point(472, 84)
        Me.emMail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.emMail.Name = "emMail"
        Me.emMail.Size = New System.Drawing.Size(267, 26)
        Me.emMail.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(275, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Employee Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(275, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Employee Password"
        '
        'EmPwd
        '
        Me.EmPwd.Location = New System.Drawing.Point(472, 120)
        Me.EmPwd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmPwd.Name = "EmPwd"
        Me.EmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.EmPwd.Size = New System.Drawing.Size(267, 26)
        Me.EmPwd.TabIndex = 2
        '
        'EmRole
        '
        Me.EmRole.FormattingEnabled = True
        Me.EmRole.Items.AddRange(New Object() {"Stock Keeper", "Billing Admin"})
        Me.EmRole.Location = New System.Drawing.Point(472, 154)
        Me.EmRole.Name = "EmRole"
        Me.EmRole.Size = New System.Drawing.Size(267, 28)
        Me.EmRole.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(275, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Employee role"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DatagridView1)
        Me.Panel1.Location = New System.Drawing.Point(291, 337)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 201)
        Me.Panel1.TabIndex = 26
        '
        'DatagridView1
        '
        Me.DatagridView1.AllowUserToAddRows = False
        Me.DatagridView1.AllowUserToDeleteRows = False
        Me.DatagridView1.AllowUserToResizeColumns = False
        Me.DatagridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DatagridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridView1.BackgroundColor = System.Drawing.Color.White
        Me.DatagridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DatagridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.shopid, Me.EmpNme, Me.mail, Me.pass_word, Me.E_role})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridView1.DefaultCellStyle = DataGridViewCellStyle3
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
        Me.DatagridView1.Size = New System.Drawing.Size(428, 201)
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
        Me.shopid.DataPropertyName = "E_shop"
        Me.shopid.HeaderText = "shopid"
        Me.shopid.Name = "shopid"
        Me.shopid.ReadOnly = True
        Me.shopid.Visible = False
        '
        'EmpNme
        '
        Me.EmpNme.DataPropertyName = "E_name"
        Me.EmpNme.HeaderText = "Name"
        Me.EmpNme.Name = "EmpNme"
        Me.EmpNme.ReadOnly = True
        '
        'mail
        '
        Me.mail.DataPropertyName = "E_mailID"
        Me.mail.HeaderText = "E-mail"
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = True
        '
        'pass_word
        '
        Me.pass_word.DataPropertyName = "E_Pass_Wrd"
        Me.pass_word.HeaderText = "Pass_word"
        Me.pass_word.Name = "pass_word"
        Me.pass_word.ReadOnly = True
        Me.pass_word.Visible = False
        '
        'E_role
        '
        Me.E_role.DataPropertyName = "E_role"
        Me.E_role.HeaderText = "Role"
        Me.E_role.Name = "E_role"
        Me.E_role.ReadOnly = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Dress_Rental_Management.My.Resources.Resources.navr_borderless
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(746, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(634, 607)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomizableEdges.BottomRight = False
        Me.Guna2Button1.CustomizableEdges.TopLeft = False
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(472, 232)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(111, 45)
        Me.Guna2Button1.TabIndex = 90
        Me.Guna2Button1.Text = "Remove"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.BorderThickness = 2
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomizableEdges.BottomRight = False
        Me.Guna2Button2.CustomizableEdges.TopLeft = False
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.DisabledState.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(617, 232)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(122, 45)
        Me.Guna2Button2.TabIndex = 91
        Me.Guna2Button2.Text = "Save"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(275, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Employee Name"
        '
        'Emname
        '
        Me.Emname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.Emname.Location = New System.Drawing.Point(472, 48)
        Me.Emname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Emname.Name = "Emname"
        Me.Emname.Size = New System.Drawing.Size(267, 26)
        Me.Emname.TabIndex = 92
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
        'Employee_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1337, 681)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Emname)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmRole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmPwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.emMail)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.adm_pwd)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Employee_Manager"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.DatagridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pwd As Label
    Friend WithEvents adm_pwd As TextBox
    Friend WithEvents emMail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmPwd As TextBox
    Friend WithEvents EmRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DatagridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Emname As TextBox
    Friend WithEvents shopid As DataGridViewTextBoxColumn
    Friend WithEvents EmpNme As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents pass_word As DataGridViewTextBoxColumn
    Friend WithEvents E_role As DataGridViewTextBoxColumn
    Friend WithEvents nav As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GoToReporting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Rental_Return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToItemStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
