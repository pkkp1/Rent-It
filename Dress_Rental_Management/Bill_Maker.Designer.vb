<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bill_maker
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill_maker))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Digibilll = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Itm_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_iname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_dur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Custcontact = New System.Windows.Forms.ComboBox()
        Me.Disc = New System.Windows.Forms.TextBox()
        Me.Bill_history = New System.Windows.Forms.Panel()
        Me.prevBills = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.sId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_pay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_billernme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_nme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_qnty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSubtot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_dte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GTot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SubTot = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.IsNewCST = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cust_manager = New System.Windows.Forms.Panel()
        Me.CstOpBal = New System.Windows.Forms.Label()
        Me.Custname = New System.Windows.Forms.TextBox()
        Me.ManageCust = New Guna.UI2.WinForms.Guna2Button()
        Me.PrntBill = New Guna.UI2.WinForms.Guna2Button()
        Me.Ins_Itm = New Guna.UI2.WinForms.Guna2Button()
        Me.Itm_ttl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Itm_nme = New System.Windows.Forms.TextBox()
        Me.Itm_qty = New System.Windows.Forms.NumericUpDown()
        Me.Itm_cst = New System.Windows.Forms.TextBox()
        Me.Item_code = New System.Windows.Forms.ComboBox()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.HisLbl1 = New System.Windows.Forms.Label()
        Me.HisLbl2 = New System.Windows.Forms.Label()
        Me.HisLbl3 = New System.Windows.Forms.Label()
        Me.biller = New System.Windows.Forms.Panel()
        Me.DelItem = New Guna.UI2.WinForms.Guna2Button()
        Me.GenReport = New Guna.UI2.WinForms.Guna2Button()
        Me.DteFrm = New System.Windows.Forms.DateTimePicker()
        Me.DteTo = New System.Windows.Forms.DateTimePicker()
        Me.reportPanel = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NmeDisplay = New System.Windows.Forms.Label()
        Me.ContDisplay = New System.Windows.Forms.Label()
        Me.nav = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GoToReporting = New Guna.UI2.WinForms.Guna2Button()
        Me.Rental_Return = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToItemStock = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.From_Bal = New System.Windows.Forms.CheckBox()
        Me.Pay_now = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.History_Show = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3.SuspendLayout()
        CType(Me.Digibilll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bill_history.SuspendLayout()
        CType(Me.prevBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cust_manager.SuspendLayout()
        CType(Me.Itm_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.biller.SuspendLayout()
        Me.reportPanel.SuspendLayout()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Digibilll)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(835, 160)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 373)
        Me.Panel3.TabIndex = 7
        '
        'Digibilll
        '
        Me.Digibilll.AllowUserToAddRows = False
        Me.Digibilll.AllowUserToDeleteRows = False
        Me.Digibilll.AllowUserToResizeColumns = False
        Me.Digibilll.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Digibilll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Digibilll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Digibilll.BackgroundColor = System.Drawing.Color.White
        Me.Digibilll.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Digibilll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Digibilll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Digibilll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Digibilll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Digibilll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Itm_id, Me.iCode, Me.b_iname, Me.b_i_dur, Me.b_i_qty, Me.b_i_rate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Digibilll.DefaultCellStyle = DataGridViewCellStyle3
        Me.Digibilll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Digibilll.EnableHeadersVisualStyles = False
        Me.Digibilll.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Digibilll.Location = New System.Drawing.Point(0, 0)
        Me.Digibilll.MultiSelect = False
        Me.Digibilll.Name = "Digibilll"
        Me.Digibilll.ReadOnly = True
        Me.Digibilll.RowHeadersVisible = False
        Me.Digibilll.RowTemplate.ReadOnly = True
        Me.Digibilll.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Digibilll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Digibilll.Size = New System.Drawing.Size(352, 371)
        Me.Digibilll.TabIndex = 47
        Me.Digibilll.TabStop = False
        Me.Digibilll.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.Digibilll.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Digibilll.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Digibilll.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Digibilll.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Digibilll.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Digibilll.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Digibilll.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Digibilll.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Digibilll.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Digibilll.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Digibilll.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Digibilll.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Digibilll.ThemeStyle.HeaderStyle.Height = 23
        Me.Digibilll.ThemeStyle.ReadOnly = True
        Me.Digibilll.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Digibilll.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Digibilll.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Digibilll.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Digibilll.ThemeStyle.RowsStyle.Height = 22
        Me.Digibilll.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Digibilll.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Itm_id
        '
        Me.Itm_id.DataPropertyName = "id"
        Me.Itm_id.HeaderText = "ID"
        Me.Itm_id.Name = "Itm_id"
        Me.Itm_id.ReadOnly = True
        Me.Itm_id.Visible = False
        '
        'iCode
        '
        Me.iCode.DataPropertyName = "i_code"
        Me.iCode.HeaderText = "Itm_code"
        Me.iCode.Name = "iCode"
        Me.iCode.ReadOnly = True
        Me.iCode.Visible = False
        '
        'b_iname
        '
        Me.b_iname.DataPropertyName = "i_nme"
        Me.b_iname.FillWeight = 203.0457!
        Me.b_iname.HeaderText = "Name"
        Me.b_iname.Name = "b_iname"
        Me.b_iname.ReadOnly = True
        '
        'b_i_dur
        '
        Me.b_i_dur.DataPropertyName = "i_dur"
        Me.b_i_dur.FillWeight = 65.65144!
        Me.b_i_dur.HeaderText = "Duration"
        Me.b_i_dur.Name = "b_i_dur"
        Me.b_i_dur.ReadOnly = True
        '
        'b_i_qty
        '
        Me.b_i_qty.DataPropertyName = "i_qty"
        Me.b_i_qty.FillWeight = 65.65144!
        Me.b_i_qty.HeaderText = "Qty."
        Me.b_i_qty.Name = "b_i_qty"
        Me.b_i_qty.ReadOnly = True
        '
        'b_i_rate
        '
        Me.b_i_rate.DataPropertyName = "i_rte"
        Me.b_i_rate.FillWeight = 65.65144!
        Me.b_i_rate.HeaderText = "Rate"
        Me.b_i_rate.Name = "b_i_rate"
        Me.b_i_rate.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(832, 579)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 22)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Discount"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Contact No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Customer Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Custcontact
        '
        Me.Custcontact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Custcontact.ForeColor = System.Drawing.Color.Black
        Me.Custcontact.FormattingEnabled = True
        Me.Custcontact.Location = New System.Drawing.Point(247, 37)
        Me.Custcontact.MaxLength = 10
        Me.Custcontact.Name = "Custcontact"
        Me.Custcontact.Size = New System.Drawing.Size(204, 30)
        Me.Custcontact.Sorted = True
        Me.Custcontact.TabIndex = 1
        '
        'Disc
        '
        Me.Disc.BackColor = System.Drawing.Color.White
        Me.Disc.ForeColor = System.Drawing.Color.Black
        Me.Disc.Location = New System.Drawing.Point(1022, 576)
        Me.Disc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Disc.Name = "Disc"
        Me.Disc.Size = New System.Drawing.Size(168, 30)
        Me.Disc.TabIndex = 5
        Me.Disc.TabStop = False
        Me.Disc.Text = "0"
        Me.Disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Bill_history
        '
        Me.Bill_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bill_history.Controls.Add(Me.prevBills)
        Me.Bill_history.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bill_history.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bill_history.Location = New System.Drawing.Point(280, 74)
        Me.Bill_history.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bill_history.Name = "Bill_history"
        Me.Bill_history.Size = New System.Drawing.Size(540, 10)
        Me.Bill_history.TabIndex = 85
        Me.Bill_history.Visible = False
        '
        'prevBills
        '
        Me.prevBills.AllowUserToAddRows = False
        Me.prevBills.AllowUserToDeleteRows = False
        Me.prevBills.AllowUserToResizeColumns = False
        Me.prevBills.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.prevBills.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.prevBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.prevBills.BackgroundColor = System.Drawing.Color.White
        Me.prevBills.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.prevBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.prevBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.prevBills.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.prevBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.prevBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sId, Me.b_pay, Me.b_no, Me.b_billernme, Me.C_nme, Me.CCont, Me.B_qnty, Me.CSubtot, Me.CDisc, Me.Btot, Me.Bill_dte})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prevBills.DefaultCellStyle = DataGridViewCellStyle6
        Me.prevBills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prevBills.EnableHeadersVisualStyles = False
        Me.prevBills.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.prevBills.Location = New System.Drawing.Point(0, 0)
        Me.prevBills.MultiSelect = False
        Me.prevBills.Name = "prevBills"
        Me.prevBills.ReadOnly = True
        Me.prevBills.RowHeadersVisible = False
        Me.prevBills.RowTemplate.ReadOnly = True
        Me.prevBills.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prevBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.prevBills.Size = New System.Drawing.Size(538, 8)
        Me.prevBills.TabIndex = 48
        Me.prevBills.TabStop = False
        Me.prevBills.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.prevBills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.prevBills.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.prevBills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.prevBills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.prevBills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.prevBills.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.prevBills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.prevBills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.prevBills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.prevBills.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevBills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.prevBills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.prevBills.ThemeStyle.HeaderStyle.Height = 23
        Me.prevBills.ThemeStyle.ReadOnly = True
        Me.prevBills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.prevBills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.prevBills.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevBills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.prevBills.ThemeStyle.RowsStyle.Height = 22
        Me.prevBills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.prevBills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'sId
        '
        Me.sId.DataPropertyName = "b_shop"
        Me.sId.HeaderText = "sID"
        Me.sId.Name = "sId"
        Me.sId.ReadOnly = True
        Me.sId.Visible = False
        '
        'b_pay
        '
        Me.b_pay.DataPropertyName = "b_paymode"
        Me.b_pay.HeaderText = "Payment"
        Me.b_pay.Name = "b_pay"
        Me.b_pay.ReadOnly = True
        Me.b_pay.Visible = False
        '
        'b_no
        '
        Me.b_no.DataPropertyName = "b_id"
        Me.b_no.HeaderText = "B_no"
        Me.b_no.Name = "b_no"
        Me.b_no.ReadOnly = True
        Me.b_no.Visible = False
        '
        'b_billernme
        '
        Me.b_billernme.DataPropertyName = "biller_nme"
        Me.b_billernme.HeaderText = "Biller"
        Me.b_billernme.Name = "b_billernme"
        Me.b_billernme.ReadOnly = True
        '
        'C_nme
        '
        Me.C_nme.DataPropertyName = "cst_nme"
        Me.C_nme.HeaderText = "Cst. name"
        Me.C_nme.Name = "C_nme"
        Me.C_nme.ReadOnly = True
        '
        'CCont
        '
        Me.CCont.DataPropertyName = "cst_cont"
        Me.CCont.HeaderText = "Contact"
        Me.CCont.Name = "CCont"
        Me.CCont.ReadOnly = True
        '
        'B_qnty
        '
        Me.B_qnty.DataPropertyName = "b_Itm_Qty"
        Me.B_qnty.HeaderText = "Qty."
        Me.B_qnty.Name = "B_qnty"
        Me.B_qnty.ReadOnly = True
        '
        'CSubtot
        '
        Me.CSubtot.DataPropertyName = "b_subtot"
        Me.CSubtot.HeaderText = "Subtotal"
        Me.CSubtot.Name = "CSubtot"
        Me.CSubtot.ReadOnly = True
        '
        'CDisc
        '
        Me.CDisc.DataPropertyName = "b_disc"
        Me.CDisc.HeaderText = "Discount"
        Me.CDisc.Name = "CDisc"
        Me.CDisc.ReadOnly = True
        '
        'Btot
        '
        Me.Btot.DataPropertyName = "b_gTot"
        Me.Btot.HeaderText = "Total"
        Me.Btot.Name = "Btot"
        Me.Btot.ReadOnly = True
        '
        'Bill_dte
        '
        Me.Bill_dte.DataPropertyName = "b_dte"
        Me.Bill_dte.HeaderText = "Date"
        Me.Bill_dte.Name = "Bill_dte"
        Me.Bill_dte.ReadOnly = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'GTot
        '
        Me.GTot.BackColor = System.Drawing.Color.White
        Me.GTot.ForeColor = System.Drawing.Color.Black
        Me.GTot.Location = New System.Drawing.Point(1022, 613)
        Me.GTot.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GTot.Name = "GTot"
        Me.GTot.ReadOnly = True
        Me.GTot.Size = New System.Drawing.Size(167, 30)
        Me.GTot.TabIndex = 91
        Me.GTot.TabStop = False
        Me.GTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(833, 616)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 22)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Grand Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(961, 616)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 22)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "₹"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SubTot
        '
        Me.SubTot.BackColor = System.Drawing.Color.White
        Me.SubTot.ForeColor = System.Drawing.Color.Black
        Me.SubTot.Location = New System.Drawing.Point(1021, 539)
        Me.SubTot.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SubTot.Name = "SubTot"
        Me.SubTot.ReadOnly = True
        Me.SubTot.Size = New System.Drawing.Size(169, 30)
        Me.SubTot.TabIndex = 90
        Me.SubTot.TabStop = False
        Me.SubTot.Text = "0"
        Me.SubTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(832, 542)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 22)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Sub Total"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(961, 542)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 22)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "₹"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IsNewCST
        '
        Me.IsNewCST.AutoSize = True
        Me.IsNewCST.BackColor = System.Drawing.Color.White
        Me.IsNewCST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.IsNewCST.Location = New System.Drawing.Point(184, 3)
        Me.IsNewCST.Name = "IsNewCST"
        Me.IsNewCST.Size = New System.Drawing.Size(147, 26)
        Me.IsNewCST.TabIndex = 0
        Me.IsNewCST.Text = "New Customer"
        Me.IsNewCST.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(28, 127)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 22)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Customer Balance"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cust_manager
        '
        Me.Cust_manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cust_manager.Controls.Add(Me.CstOpBal)
        Me.Cust_manager.Controls.Add(Me.Custname)
        Me.Cust_manager.Controls.Add(Me.ManageCust)
        Me.Cust_manager.Controls.Add(Me.Label1)
        Me.Cust_manager.Controls.Add(Me.Label9)
        Me.Cust_manager.Controls.Add(Me.Custcontact)
        Me.Cust_manager.Controls.Add(Me.Label2)
        Me.Cust_manager.Controls.Add(Me.IsNewCST)
        Me.Cust_manager.Location = New System.Drawing.Point(281, 78)
        Me.Cust_manager.Name = "Cust_manager"
        Me.Cust_manager.Size = New System.Drawing.Size(538, 166)
        Me.Cust_manager.TabIndex = 1
        '
        'CstOpBal
        '
        Me.CstOpBal.AutoSize = True
        Me.CstOpBal.BackColor = System.Drawing.Color.White
        Me.CstOpBal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CstOpBal.Location = New System.Drawing.Point(243, 127)
        Me.CstOpBal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CstOpBal.Name = "CstOpBal"
        Me.CstOpBal.Size = New System.Drawing.Size(38, 22)
        Me.CstOpBal.TabIndex = 101
        Me.CstOpBal.Text = "----"
        Me.CstOpBal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Custname
        '
        Me.Custname.Location = New System.Drawing.Point(245, 81)
        Me.Custname.Name = "Custname"
        Me.Custname.Size = New System.Drawing.Size(208, 30)
        Me.Custname.TabIndex = 2
        '
        'ManageCust
        '
        Me.ManageCust.BorderRadius = 25
        Me.ManageCust.CheckedState.Parent = Me.ManageCust
        Me.ManageCust.CustomImages.Parent = Me.ManageCust
        Me.ManageCust.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ManageCust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ManageCust.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ManageCust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ManageCust.DisabledState.Parent = Me.ManageCust
        Me.ManageCust.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ManageCust.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ManageCust.ForeColor = System.Drawing.Color.White
        Me.ManageCust.HoverState.Parent = Me.ManageCust
        Me.ManageCust.Image = Global.Dress_Rental_Management.My.Resources.Resources.Manage
        Me.ManageCust.ImageSize = New System.Drawing.Size(45, 40)
        Me.ManageCust.Location = New System.Drawing.Point(480, 68)
        Me.ManageCust.Name = "ManageCust"
        Me.ManageCust.ShadowDecoration.Parent = Me.ManageCust
        Me.ManageCust.Size = New System.Drawing.Size(53, 55)
        Me.ManageCust.TabIndex = 4
        Me.ManageCust.TabStop = False
        '
        'PrntBill
        '
        Me.PrntBill.BorderColor = System.Drawing.Color.Transparent
        Me.PrntBill.BorderRadius = 20
        Me.PrntBill.BorderThickness = 2
        Me.PrntBill.CheckedState.Parent = Me.PrntBill
        Me.PrntBill.CustomImages.Parent = Me.PrntBill
        Me.PrntBill.CustomizableEdges.BottomRight = False
        Me.PrntBill.CustomizableEdges.TopLeft = False
        Me.PrntBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PrntBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PrntBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PrntBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PrntBill.DisabledState.Parent = Me.PrntBill
        Me.PrntBill.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.PrntBill.ForeColor = System.Drawing.Color.White
        Me.PrntBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.HoverState.FillColor = System.Drawing.Color.White
        Me.PrntBill.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PrntBill.HoverState.Parent = Me.PrntBill
        Me.PrntBill.Location = New System.Drawing.Point(599, 593)
        Me.PrntBill.Name = "PrntBill"
        Me.PrntBill.ShadowDecoration.Parent = Me.PrntBill
        Me.PrntBill.Size = New System.Drawing.Size(137, 45)
        Me.PrntBill.TabIndex = 115
        Me.PrntBill.TabStop = False
        Me.PrntBill.Text = "Print"
        '
        'Ins_Itm
        '
        Me.Ins_Itm.BorderColor = System.Drawing.Color.Transparent
        Me.Ins_Itm.BorderRadius = 20
        Me.Ins_Itm.BorderThickness = 2
        Me.Ins_Itm.CheckedState.Parent = Me.Ins_Itm
        Me.Ins_Itm.CustomImages.Parent = Me.Ins_Itm
        Me.Ins_Itm.CustomizableEdges.BottomRight = False
        Me.Ins_Itm.CustomizableEdges.TopLeft = False
        Me.Ins_Itm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Ins_Itm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Ins_Itm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Ins_Itm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Ins_Itm.DisabledState.Parent = Me.Ins_Itm
        Me.Ins_Itm.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Ins_Itm.ForeColor = System.Drawing.Color.White
        Me.Ins_Itm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.HoverState.FillColor = System.Drawing.Color.White
        Me.Ins_Itm.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ins_Itm.HoverState.Parent = Me.Ins_Itm
        Me.Ins_Itm.Location = New System.Drawing.Point(314, 593)
        Me.Ins_Itm.Name = "Ins_Itm"
        Me.Ins_Itm.ShadowDecoration.Parent = Me.Ins_Itm
        Me.Ins_Itm.Size = New System.Drawing.Size(137, 45)
        Me.Ins_Itm.TabIndex = 106
        Me.Ins_Itm.Text = "Insert Item"
        '
        'Itm_ttl
        '
        Me.Itm_ttl.AutoSize = True
        Me.Itm_ttl.BackColor = System.Drawing.Color.Transparent
        Me.Itm_ttl.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Itm_ttl.ForeColor = System.Drawing.Color.Black
        Me.Itm_ttl.Location = New System.Drawing.Point(292, 101)
        Me.Itm_ttl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Itm_ttl.Name = "Itm_ttl"
        Me.Itm_ttl.Size = New System.Drawing.Size(26, 22)
        Me.Itm_ttl.TabIndex = 114
        Me.Itm_ttl.Text = "/1"
        Me.Itm_ttl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(26, 231)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 22)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Required on"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(26, 189)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 22)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Booked on"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(26, 145)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 22)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Rate per day"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(27, 99)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 22)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Item Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(26, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Item Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Item code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Itm_nme
        '
        Me.Itm_nme.BackColor = System.Drawing.Color.White
        Me.Itm_nme.ForeColor = System.Drawing.Color.Black
        Me.Itm_nme.Location = New System.Drawing.Point(246, 52)
        Me.Itm_nme.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Itm_nme.Name = "Itm_nme"
        Me.Itm_nme.Size = New System.Drawing.Size(208, 30)
        Me.Itm_nme.TabIndex = 101
        '
        'Itm_qty
        '
        Me.Itm_qty.BackColor = System.Drawing.Color.White
        Me.Itm_qty.ForeColor = System.Drawing.Color.Black
        Me.Itm_qty.Location = New System.Drawing.Point(246, 97)
        Me.Itm_qty.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Itm_qty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Itm_qty.Name = "Itm_qty"
        Me.Itm_qty.ReadOnly = True
        Me.Itm_qty.Size = New System.Drawing.Size(40, 30)
        Me.Itm_qty.TabIndex = 102
        Me.Itm_qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Itm_cst
        '
        Me.Itm_cst.BackColor = System.Drawing.Color.White
        Me.Itm_cst.ForeColor = System.Drawing.Color.Black
        Me.Itm_cst.Location = New System.Drawing.Point(245, 142)
        Me.Itm_cst.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Itm_cst.Name = "Itm_cst"
        Me.Itm_cst.ReadOnly = True
        Me.Itm_cst.Size = New System.Drawing.Size(207, 30)
        Me.Itm_cst.TabIndex = 190
        Me.Itm_cst.TabStop = False
        '
        'Item_code
        '
        Me.Item_code.BackColor = System.Drawing.Color.White
        Me.Item_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Item_code.ForeColor = System.Drawing.Color.Black
        Me.Item_code.FormattingEnabled = True
        Me.Item_code.Location = New System.Drawing.Point(246, 8)
        Me.Item_code.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Item_code.Name = "Item_code"
        Me.Item_code.Size = New System.Drawing.Size(208, 30)
        Me.Item_code.TabIndex = 100
        '
        'DateTo
        '
        Me.DateTo.Location = New System.Drawing.Point(246, 225)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(208, 30)
        Me.DateTo.TabIndex = 103
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(209, 145)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 22)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "₹"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateFrom
        '
        Me.DateFrom.Location = New System.Drawing.Point(246, 183)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(208, 30)
        Me.DateFrom.TabIndex = 102
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(961, 579)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 22)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "₹ / %"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HisLbl1
        '
        Me.HisLbl1.AutoSize = True
        Me.HisLbl1.BackColor = System.Drawing.Color.White
        Me.HisLbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl1.Location = New System.Drawing.Point(13, 9)
        Me.HisLbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl1.Name = "HisLbl1"
        Me.HisLbl1.Size = New System.Drawing.Size(49, 22)
        Me.HisLbl1.TabIndex = 113
        Me.HisLbl1.Text = "Bills"
        Me.HisLbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HisLbl2
        '
        Me.HisLbl2.AutoSize = True
        Me.HisLbl2.BackColor = System.Drawing.Color.White
        Me.HisLbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl2.Location = New System.Drawing.Point(13, 36)
        Me.HisLbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl2.Name = "HisLbl2"
        Me.HisLbl2.Size = New System.Drawing.Size(100, 22)
        Me.HisLbl2.TabIndex = 114
        Me.HisLbl2.Text = "From Date:"
        Me.HisLbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HisLbl3
        '
        Me.HisLbl3.AutoSize = True
        Me.HisLbl3.BackColor = System.Drawing.Color.White
        Me.HisLbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HisLbl3.Location = New System.Drawing.Point(345, 36)
        Me.HisLbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HisLbl3.Name = "HisLbl3"
        Me.HisLbl3.Size = New System.Drawing.Size(79, 22)
        Me.HisLbl3.TabIndex = 115
        Me.HisLbl3.Text = "To Date:"
        Me.HisLbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'biller
        '
        Me.biller.Controls.Add(Me.DelItem)
        Me.biller.Controls.Add(Me.Itm_ttl)
        Me.biller.Controls.Add(Me.Label12)
        Me.biller.Controls.Add(Me.Itm_nme)
        Me.biller.Controls.Add(Me.Label11)
        Me.biller.Controls.Add(Me.Itm_qty)
        Me.biller.Controls.Add(Me.Label10)
        Me.biller.Controls.Add(Me.Itm_cst)
        Me.biller.Controls.Add(Me.Label5)
        Me.biller.Controls.Add(Me.Item_code)
        Me.biller.Controls.Add(Me.Label3)
        Me.biller.Controls.Add(Me.Label4)
        Me.biller.Controls.Add(Me.DateFrom)
        Me.biller.Controls.Add(Me.Label8)
        Me.biller.Controls.Add(Me.DateTo)
        Me.biller.Enabled = False
        Me.biller.Location = New System.Drawing.Point(283, 256)
        Me.biller.Name = "biller"
        Me.biller.Size = New System.Drawing.Size(537, 264)
        Me.biller.TabIndex = 99
        '
        'DelItem
        '
        Me.DelItem.BorderRadius = 25
        Me.DelItem.CheckedState.Parent = Me.DelItem
        Me.DelItem.CustomImages.Parent = Me.DelItem
        Me.DelItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DelItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DelItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DelItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DelItem.DisabledState.Parent = Me.DelItem
        Me.DelItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DelItem.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DelItem.ForeColor = System.Drawing.Color.White
        Me.DelItem.HoverState.Parent = Me.DelItem
        Me.DelItem.Image = Global.Dress_Rental_Management.My.Resources.Resources.del2
        Me.DelItem.ImageSize = New System.Drawing.Size(45, 40)
        Me.DelItem.Location = New System.Drawing.Point(481, 52)
        Me.DelItem.Name = "DelItem"
        Me.DelItem.ShadowDecoration.Parent = Me.DelItem
        Me.DelItem.Size = New System.Drawing.Size(53, 55)
        Me.DelItem.TabIndex = 116
        Me.DelItem.TabStop = False
        '
        'GenReport
        '
        Me.GenReport.BorderColor = System.Drawing.Color.Transparent
        Me.GenReport.BorderRadius = 20
        Me.GenReport.BorderThickness = 2
        Me.GenReport.CheckedState.Parent = Me.GenReport
        Me.GenReport.CustomImages.Parent = Me.GenReport
        Me.GenReport.CustomizableEdges.BottomRight = False
        Me.GenReport.CustomizableEdges.TopLeft = False
        Me.GenReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GenReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GenReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GenReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GenReport.DisabledState.Parent = Me.GenReport
        Me.GenReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GenReport.ForeColor = System.Drawing.Color.White
        Me.GenReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.HoverState.FillColor = System.Drawing.Color.White
        Me.GenReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GenReport.HoverState.Parent = Me.GenReport
        Me.GenReport.Location = New System.Drawing.Point(645, 22)
        Me.GenReport.Name = "GenReport"
        Me.GenReport.ShadowDecoration.Parent = Me.GenReport
        Me.GenReport.Size = New System.Drawing.Size(123, 45)
        Me.GenReport.TabIndex = 117
        Me.GenReport.TabStop = False
        Me.GenReport.Text = "Generate"
        '
        'DteFrm
        '
        Me.DteFrm.Location = New System.Drawing.Point(123, 31)
        Me.DteFrm.Name = "DteFrm"
        Me.DteFrm.Size = New System.Drawing.Size(208, 30)
        Me.DteFrm.TabIndex = 118
        '
        'DteTo
        '
        Me.DteTo.Location = New System.Drawing.Point(431, 31)
        Me.DteTo.Name = "DteTo"
        Me.DteTo.Size = New System.Drawing.Size(208, 30)
        Me.DteTo.TabIndex = 119
        '
        'reportPanel
        '
        Me.reportPanel.Controls.Add(Me.DteTo)
        Me.reportPanel.Controls.Add(Me.HisLbl1)
        Me.reportPanel.Controls.Add(Me.DteFrm)
        Me.reportPanel.Controls.Add(Me.HisLbl2)
        Me.reportPanel.Controls.Add(Me.GenReport)
        Me.reportPanel.Controls.Add(Me.HisLbl3)
        Me.reportPanel.Location = New System.Drawing.Point(273, 0)
        Me.reportPanel.Name = "reportPanel"
        Me.reportPanel.Size = New System.Drawing.Size(787, 72)
        Me.reportPanel.TabIndex = 120
        Me.reportPanel.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(839, 86)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(162, 22)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Customer Name    :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(839, 124)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(161, 22)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "Customer Contact :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NmeDisplay
        '
        Me.NmeDisplay.AutoSize = True
        Me.NmeDisplay.BackColor = System.Drawing.Color.White
        Me.NmeDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.NmeDisplay.Location = New System.Drawing.Point(1009, 86)
        Me.NmeDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NmeDisplay.Name = "NmeDisplay"
        Me.NmeDisplay.Size = New System.Drawing.Size(51, 22)
        Me.NmeDisplay.TabIndex = 122
        Me.NmeDisplay.Text = "name"
        Me.NmeDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NmeDisplay.Visible = False
        '
        'ContDisplay
        '
        Me.ContDisplay.AutoSize = True
        Me.ContDisplay.BackColor = System.Drawing.Color.White
        Me.ContDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ContDisplay.Location = New System.Drawing.Point(1009, 124)
        Me.ContDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ContDisplay.Name = "ContDisplay"
        Me.ContDisplay.Size = New System.Drawing.Size(110, 22)
        Me.ContDisplay.TabIndex = 123
        Me.ContDisplay.Text = "0000000000"
        Me.ContDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ContDisplay.Visible = False
        '
        'nav
        '
        Me.nav.BackColor = System.Drawing.Color.White
        Me.nav.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.nav.BorderRadius = 1
        Me.nav.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.nav.BorderThickness = 2
        Me.nav.Controls.Add(Me.History_Show)
        Me.nav.Controls.Add(Me.GoToReporting)
        Me.nav.Controls.Add(Me.Rental_Return)
        Me.nav.Controls.Add(Me.GoToPurchase)
        Me.nav.Controls.Add(Me.GoToItemStock)
        Me.nav.Controls.Add(Me.GoToSettings)
        Me.nav.Controls.Add(Me.PictureBox1)
        Me.nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav.Location = New System.Drawing.Point(0, 0)
        Me.nav.Name = "nav"
        Me.nav.ShadowDecoration.Parent = Me.nav
        Me.nav.Size = New System.Drawing.Size(246, 662)
        Me.nav.TabIndex = 124
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
        Me.GoToItemStock.Location = New System.Drawing.Point(51, 232)
        Me.GoToItemStock.Name = "GoToItemStock"
        Me.GoToItemStock.ShadowDecoration.Parent = Me.GoToItemStock
        Me.GoToItemStock.Size = New System.Drawing.Size(145, 45)
        Me.GoToItemStock.TabIndex = 89
        Me.GoToItemStock.Text = "Stock"
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.From_Bal)
        Me.Panel1.Controls.Add(Me.Pay_now)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Location = New System.Drawing.Point(283, 527)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 42)
        Me.Panel1.TabIndex = 125
        '
        'From_Bal
        '
        Me.From_Bal.AutoSize = True
        Me.From_Bal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.From_Bal.Location = New System.Drawing.Point(294, 8)
        Me.From_Bal.Name = "From_Bal"
        Me.From_Bal.Size = New System.Drawing.Size(196, 26)
        Me.From_Bal.TabIndex = 116
        Me.From_Bal.Text = "Deduct from Balance"
        Me.From_Bal.UseVisualStyleBackColor = True
        '
        'Pay_now
        '
        Me.Pay_now.AutoSize = True
        Me.Pay_now.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Pay_now.Location = New System.Drawing.Point(154, 8)
        Me.Pay_now.Name = "Pay_now"
        Me.Pay_now.Size = New System.Drawing.Size(102, 26)
        Me.Pay_now.TabIndex = 115
        Me.Pay_now.Text = "Pay Now"
        Me.Pay_now.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(27, 9)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 22)
        Me.Label19.TabIndex = 114
        Me.Label19.Text = "Paymode"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'History_Show
        '
        Me.History_Show.BorderColor = System.Drawing.Color.Transparent
        Me.History_Show.BorderRadius = 20
        Me.History_Show.BorderThickness = 2
        Me.History_Show.CheckedState.Parent = Me.History_Show
        Me.History_Show.CustomImages.Parent = Me.History_Show
        Me.History_Show.CustomizableEdges.BottomRight = False
        Me.History_Show.CustomizableEdges.TopLeft = False
        Me.History_Show.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.History_Show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.History_Show.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.History_Show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.History_Show.DisabledState.Parent = Me.History_Show
        Me.History_Show.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.History_Show.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.History_Show.ForeColor = System.Drawing.Color.White
        Me.History_Show.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.History_Show.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.History_Show.HoverState.FillColor = System.Drawing.Color.White
        Me.History_Show.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.History_Show.HoverState.Parent = Me.History_Show
        Me.History_Show.Location = New System.Drawing.Point(51, 488)
        Me.History_Show.Name = "History_Show"
        Me.History_Show.ShadowDecoration.Parent = Me.History_Show
        Me.History_Show.Size = New System.Drawing.Size(145, 45)
        Me.History_Show.TabIndex = 93
        Me.History_Show.Text = "History"
        '
        'Bill_maker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1207, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.ContDisplay)
        Me.Controls.Add(Me.PrntBill)
        Me.Controls.Add(Me.NmeDisplay)
        Me.Controls.Add(Me.Ins_Itm)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Bill_history)
        Me.Controls.Add(Me.biller)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GTot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SubTot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Disc)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Cust_manager)
        Me.Controls.Add(Me.reportPanel)
        Me.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Bill_maker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.Digibilll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bill_history.ResumeLayout(False)
        CType(Me.prevBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cust_manager.ResumeLayout(False)
        Me.Cust_manager.PerformLayout()
        CType(Me.Itm_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.biller.ResumeLayout(False)
        Me.biller.PerformLayout()
        Me.reportPanel.ResumeLayout(False)
        Me.reportPanel.PerformLayout()
        Me.nav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Digibilll As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Custcontact As ComboBox
    Friend WithEvents Disc As TextBox
    Friend WithEvents Bill_history As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GTot As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents SubTot As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents IsNewCST As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Cust_manager As Panel
    Friend WithEvents ManageCust As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DelItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrntBill As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Ins_Itm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Itm_ttl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Itm_nme As TextBox
    Friend WithEvents Itm_qty As NumericUpDown
    Friend WithEvents Itm_cst As TextBox
    Friend WithEvents Item_code As ComboBox
    Friend WithEvents DateTo As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DateFrom As DateTimePicker
    Friend WithEvents Custname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents HisLbl1 As Label
    Friend WithEvents HisLbl2 As Label
    Friend WithEvents HisLbl3 As Label
    Friend WithEvents biller As Panel
    Friend WithEvents GenReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DteFrm As DateTimePicker
    Friend WithEvents DteTo As DateTimePicker
    Friend WithEvents reportPanel As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents NmeDisplay As Label
    Friend WithEvents ContDisplay As Label
    Friend WithEvents Itm_id As DataGridViewTextBoxColumn
    Friend WithEvents iCode As DataGridViewTextBoxColumn
    Friend WithEvents b_iname As DataGridViewTextBoxColumn
    Friend WithEvents b_i_dur As DataGridViewTextBoxColumn
    Friend WithEvents b_i_qty As DataGridViewTextBoxColumn
    Friend WithEvents b_i_rate As DataGridViewTextBoxColumn
    Friend WithEvents prevBills As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CstOpBal As Label
    Friend WithEvents sId As DataGridViewTextBoxColumn
    Friend WithEvents b_pay As DataGridViewTextBoxColumn
    Friend WithEvents b_no As DataGridViewTextBoxColumn
    Friend WithEvents b_billernme As DataGridViewTextBoxColumn
    Friend WithEvents C_nme As DataGridViewTextBoxColumn
    Friend WithEvents CCont As DataGridViewTextBoxColumn
    Friend WithEvents B_qnty As DataGridViewTextBoxColumn
    Friend WithEvents CSubtot As DataGridViewTextBoxColumn
    Friend WithEvents CDisc As DataGridViewTextBoxColumn
    Friend WithEvents Btot As DataGridViewTextBoxColumn
    Friend WithEvents Bill_dte As DataGridViewTextBoxColumn
    Friend WithEvents nav As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GoToReporting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Rental_Return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToItemStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Pay_now As CheckBox
    Friend WithEvents From_Bal As CheckBox
    Friend WithEvents History_Show As Guna.UI2.WinForms.Guna2Button
End Class
