﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logs_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logs_master))
        Me.reportPanel = New System.Windows.Forms.Panel()
        Me.ReportPanel2 = New System.Windows.Forms.Panel()
        Me.L_to = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.L_frm = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.L_sort = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.L_act = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_emp = New System.Windows.Forms.ComboBox()
        Me.GenReport = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LogList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lrole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Laction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logdon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nav = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GoToReporting = New Guna.UI2.WinForms.Guna2Button()
        Me.Rental_Return = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToItemStock = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.reportPanel.SuspendLayout()
        Me.ReportPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LogList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportPanel
        '
        Me.reportPanel.Controls.Add(Me.ReportPanel2)
        Me.reportPanel.Controls.Add(Me.L_sort)
        Me.reportPanel.Controls.Add(Me.Label5)
        Me.reportPanel.Controls.Add(Me.L_act)
        Me.reportPanel.Controls.Add(Me.Label6)
        Me.reportPanel.Controls.Add(Me.Label7)
        Me.reportPanel.Controls.Add(Me.L_emp)
        Me.reportPanel.Controls.Add(Me.GenReport)
        Me.reportPanel.Location = New System.Drawing.Point(246, 0)
        Me.reportPanel.Name = "reportPanel"
        Me.reportPanel.Size = New System.Drawing.Size(954, 102)
        Me.reportPanel.TabIndex = 121
        '
        'ReportPanel2
        '
        Me.ReportPanel2.Controls.Add(Me.L_to)
        Me.ReportPanel2.Controls.Add(Me.Label8)
        Me.ReportPanel2.Controls.Add(Me.L_frm)
        Me.ReportPanel2.Controls.Add(Me.Label10)
        Me.ReportPanel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ReportPanel2.Location = New System.Drawing.Point(11, 13)
        Me.ReportPanel2.Name = "ReportPanel2"
        Me.ReportPanel2.Size = New System.Drawing.Size(370, 69)
        Me.ReportPanel2.TabIndex = 134
        '
        'L_to
        '
        Me.L_to.CustomFormat = "dd MMMM yyyy"
        Me.L_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.L_to.Location = New System.Drawing.Point(130, 37)
        Me.L_to.Name = "L_to"
        Me.L_to.Size = New System.Drawing.Size(226, 25)
        Me.L_to.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 19)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Logged Between:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_frm
        '
        Me.L_frm.CustomFormat = "dd MMMM yyyy"
        Me.L_frm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.L_frm.Location = New System.Drawing.Point(130, 6)
        Me.L_frm.Name = "L_frm"
        Me.L_frm.Size = New System.Drawing.Size(226, 25)
        Me.L_frm.TabIndex = 118
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 19)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "And:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_sort
        '
        Me.L_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.L_sort.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.L_sort.FormattingEnabled = True
        Me.L_sort.Items.AddRange(New Object() {"Date", "Employee", "Customer"})
        Me.L_sort.Location = New System.Drawing.Point(495, 70)
        Me.L_sort.Name = "L_sort"
        Me.L_sort.Size = New System.Drawing.Size(208, 25)
        Me.L_sort.TabIndex = 133
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(388, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Order by:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_act
        '
        Me.L_act.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.L_act.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.L_act.FormattingEnabled = True
        Me.L_act.Location = New System.Drawing.Point(495, 38)
        Me.L_act.Name = "L_act"
        Me.L_act.Size = New System.Drawing.Size(208, 25)
        Me.L_act.TabIndex = 132
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(388, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Action:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(388, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Of Employee:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_emp
        '
        Me.L_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.L_emp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.L_emp.FormattingEnabled = True
        Me.L_emp.Location = New System.Drawing.Point(495, 7)
        Me.L_emp.Name = "L_emp"
        Me.L_emp.Size = New System.Drawing.Size(208, 25)
        Me.L_emp.TabIndex = 129
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
        Me.GenReport.Location = New System.Drawing.Point(793, 30)
        Me.GenReport.Name = "GenReport"
        Me.GenReport.ShadowDecoration.Parent = Me.GenReport
        Me.GenReport.Size = New System.Drawing.Size(149, 45)
        Me.GenReport.TabIndex = 117
        Me.GenReport.TabStop = False
        Me.GenReport.Text = "Show logs"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LogList)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(246, 107)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 585)
        Me.Panel3.TabIndex = 125
        '
        'LogList
        '
        Me.LogList.AllowUserToAddRows = False
        Me.LogList.AllowUserToDeleteRows = False
        Me.LogList.AllowUserToResizeColumns = False
        Me.LogList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LogList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LogList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LogList.BackgroundColor = System.Drawing.Color.White
        Me.LogList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.LogList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LogList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.LogList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lid, Me.sid, Me.Emp_mail, Me.lrole, Me.Laction, Me.Logdon, Me.Logat})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LogList.DefaultCellStyle = DataGridViewCellStyle3
        Me.LogList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogList.EnableHeadersVisualStyles = False
        Me.LogList.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LogList.Location = New System.Drawing.Point(0, 0)
        Me.LogList.MultiSelect = False
        Me.LogList.Name = "LogList"
        Me.LogList.ReadOnly = True
        Me.LogList.RowHeadersVisible = False
        Me.LogList.RowTemplate.ReadOnly = True
        Me.LogList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LogList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LogList.Size = New System.Drawing.Size(952, 583)
        Me.LogList.TabIndex = 47
        Me.LogList.TabStop = False
        Me.LogList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.LogList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LogList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.LogList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.LogList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.LogList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.LogList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.LogList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LogList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LogList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.LogList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.LogList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.LogList.ThemeStyle.HeaderStyle.Height = 23
        Me.LogList.ThemeStyle.ReadOnly = True
        Me.LogList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LogList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.LogList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LogList.ThemeStyle.RowsStyle.Height = 22
        Me.LogList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.LogList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lid
        '
        Me.lid.DataPropertyName = "Log_id"
        Me.lid.HeaderText = "LogID"
        Me.lid.Name = "lid"
        Me.lid.ReadOnly = True
        Me.lid.Visible = False
        '
        'sid
        '
        Me.sid.DataPropertyName = "Log_sID"
        Me.sid.HeaderText = "Shopid"
        Me.sid.Name = "sid"
        Me.sid.ReadOnly = True
        Me.sid.Visible = False
        '
        'Emp_mail
        '
        Me.Emp_mail.DataPropertyName = "Log_Emp"
        Me.Emp_mail.FillWeight = 200.0!
        Me.Emp_mail.HeaderText = "Email-id of Empoyee"
        Me.Emp_mail.Name = "Emp_mail"
        Me.Emp_mail.ReadOnly = True
        '
        'lrole
        '
        Me.lrole.DataPropertyName = "Log_Role"
        Me.lrole.FillWeight = 75.0!
        Me.lrole.HeaderText = "Role Of Employee"
        Me.lrole.Name = "lrole"
        Me.lrole.ReadOnly = True
        '
        'Laction
        '
        Me.Laction.DataPropertyName = "Log_action"
        Me.Laction.FillWeight = 200.0!
        Me.Laction.HeaderText = "Log Action"
        Me.Laction.Name = "Laction"
        Me.Laction.ReadOnly = True
        '
        'Logdon
        '
        Me.Logdon.DataPropertyName = "Log_date"
        Me.Logdon.FillWeight = 50.0!
        Me.Logdon.HeaderText = "Log Date"
        Me.Logdon.Name = "Logdon"
        Me.Logdon.ReadOnly = True
        '
        'Logat
        '
        Me.Logat.DataPropertyName = "Log_time"
        Me.Logat.FillWeight = 50.0!
        Me.Logat.HeaderText = "Log Time"
        Me.Logat.Name = "Logat"
        Me.Logat.ReadOnly = True
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
        Me.nav.Size = New System.Drawing.Size(246, 692)
        Me.nav.TabIndex = 126
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
        'Logs_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.reportPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Logs_master"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.reportPanel.ResumeLayout(False)
        Me.reportPanel.PerformLayout()
        Me.ReportPanel2.ResumeLayout(False)
        Me.ReportPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.LogList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reportPanel As Panel
    Friend WithEvents GenReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LogList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lid As DataGridViewTextBoxColumn
    Friend WithEvents sid As DataGridViewTextBoxColumn
    Friend WithEvents Emp_mail As DataGridViewTextBoxColumn
    Friend WithEvents lrole As DataGridViewTextBoxColumn
    Friend WithEvents Laction As DataGridViewTextBoxColumn
    Friend WithEvents Logdon As DataGridViewTextBoxColumn
    Friend WithEvents Logat As DataGridViewTextBoxColumn
    Friend WithEvents nav As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GoToReporting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Rental_Return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToItemStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents L_sort As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents L_act As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_emp As ComboBox
    Friend WithEvents ReportPanel2 As Panel
    Friend WithEvents L_to As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents L_frm As DateTimePicker
    Friend WithEvents Label10 As Label
End Class
