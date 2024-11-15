<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class purchase_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchase_master))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cred = New System.Windows.Forms.RadioButton()
        Me.ven_GST = New System.Windows.Forms.MaskedTextBox()
        Me.deb = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.InvNo = New System.Windows.Forms.TextBox()
        Me.Gtot = New System.Windows.Forms.TextBox()
        Me.ven_cont = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ven_nme = New System.Windows.Forms.TextBox()
        Me.ven_addr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Fin = New Guna.UI2.WinForms.Guna2Button()
        Me.Insert = New Guna.UI2.WinForms.Guna2Button()
        Me.It_rte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.It_code = New System.Windows.Forms.TextBox()
        Me.It_nme = New System.Windows.Forms.TextBox()
        Me.It_qty = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tqty = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ItemDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Itm_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_iname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_i_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nav = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GoToReporting = New Guna.UI2.WinForms.Guna2Button()
        Me.Rental_return = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToItemStock = New Guna.UI2.WinForms.Guna2Button()
        Me.GotoBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.GoToSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.It_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ItemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cred)
        Me.Panel1.Controls.Add(Me.ven_GST)
        Me.Panel1.Controls.Add(Me.deb)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.InvNo)
        Me.Panel1.Controls.Add(Me.Gtot)
        Me.Panel1.Controls.Add(Me.ven_cont)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ven_nme)
        Me.Panel1.Controls.Add(Me.ven_addr)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(252, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 391)
        Me.Panel1.TabIndex = 9
        '
        'cred
        '
        Me.cred.AutoSize = True
        Me.cred.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cred.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cred.Location = New System.Drawing.Point(322, 335)
        Me.cred.Name = "cred"
        Me.cred.Size = New System.Drawing.Size(77, 28)
        Me.cred.TabIndex = 7
        Me.cred.TabStop = True
        Me.cred.Text = "Credit"
        Me.cred.UseVisualStyleBackColor = True
        '
        'ven_GST
        '
        Me.ven_GST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_GST.Location = New System.Drawing.Point(322, 206)
        Me.ven_GST.Mask = "000000000000000"
        Me.ven_GST.Name = "ven_GST"
        Me.ven_GST.Size = New System.Drawing.Size(221, 26)
        Me.ven_GST.TabIndex = 3
        Me.ven_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'deb
        '
        Me.deb.AutoSize = True
        Me.deb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.deb.Location = New System.Drawing.Point(322, 305)
        Me.deb.Name = "deb"
        Me.deb.Size = New System.Drawing.Size(71, 28)
        Me.deb.TabIndex = 6
        Me.deb.TabStop = True
        Me.deb.Text = "Debit"
        Me.deb.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(49, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 24)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Vendor GST No"
        '
        'InvNo
        '
        Me.InvNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvNo.Location = New System.Drawing.Point(322, 46)
        Me.InvNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvNo.Name = "InvNo"
        Me.InvNo.Size = New System.Drawing.Size(221, 26)
        Me.InvNo.TabIndex = 0
        '
        'Gtot
        '
        Me.Gtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Gtot.Location = New System.Drawing.Point(322, 272)
        Me.Gtot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gtot.Name = "Gtot"
        Me.Gtot.Size = New System.Drawing.Size(221, 26)
        Me.Gtot.TabIndex = 5
        '
        'ven_cont
        '
        Me.ven_cont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_cont.Location = New System.Drawing.Point(322, 238)
        Me.ven_cont.Mask = "0000000000"
        Me.ven_cont.Name = "ven_cont"
        Me.ven_cont.Size = New System.Drawing.Size(221, 26)
        Me.ven_cont.TabIndex = 4
        Me.ven_cont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(51, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Purchase Payment Mode"
        '
        'ven_nme
        '
        Me.ven_nme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_nme.Location = New System.Drawing.Point(322, 78)
        Me.ven_nme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ven_nme.Name = "ven_nme"
        Me.ven_nme.Size = New System.Drawing.Size(221, 26)
        Me.ven_nme.TabIndex = 1
        '
        'ven_addr
        '
        Me.ven_addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ven_addr.Location = New System.Drawing.Point(322, 109)
        Me.ven_addr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ven_addr.Multiline = True
        Me.ven_addr.Name = "ven_addr"
        Me.ven_addr.Size = New System.Drawing.Size(221, 88)
        Me.ven_addr.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Purchase Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(49, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vendor Contact no"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendor Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendor Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice No."
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Fin)
        Me.Panel4.Controls.Add(Me.Insert)
        Me.Panel4.Controls.Add(Me.It_rte)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.It_code)
        Me.Panel4.Controls.Add(Me.It_nme)
        Me.Panel4.Controls.Add(Me.It_qty)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(252, 407)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(614, 242)
        Me.Panel4.TabIndex = 10
        '
        'Fin
        '
        Me.Fin.BorderColor = System.Drawing.Color.Transparent
        Me.Fin.BorderRadius = 20
        Me.Fin.BorderThickness = 2
        Me.Fin.CheckedState.Parent = Me.Fin
        Me.Fin.CustomImages.Parent = Me.Fin
        Me.Fin.CustomizableEdges.BottomRight = False
        Me.Fin.CustomizableEdges.TopLeft = False
        Me.Fin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Fin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Fin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Fin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Fin.DisabledState.Parent = Me.Fin
        Me.Fin.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Fin.ForeColor = System.Drawing.Color.White
        Me.Fin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.HoverState.FillColor = System.Drawing.Color.White
        Me.Fin.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Fin.HoverState.Parent = Me.Fin
        Me.Fin.Location = New System.Drawing.Point(377, 183)
        Me.Fin.Name = "Fin"
        Me.Fin.ShadowDecoration.Parent = Me.Fin
        Me.Fin.Size = New System.Drawing.Size(145, 45)
        Me.Fin.TabIndex = 99
        Me.Fin.TabStop = False
        Me.Fin.Text = "Finish"
        '
        'Insert
        '
        Me.Insert.BorderColor = System.Drawing.Color.Transparent
        Me.Insert.BorderRadius = 20
        Me.Insert.BorderThickness = 2
        Me.Insert.CheckedState.Parent = Me.Insert
        Me.Insert.CustomImages.Parent = Me.Insert
        Me.Insert.CustomizableEdges.BottomRight = False
        Me.Insert.CustomizableEdges.TopLeft = False
        Me.Insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Insert.DisabledState.Parent = Me.Insert
        Me.Insert.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Insert.ForeColor = System.Drawing.Color.White
        Me.Insert.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.HoverState.FillColor = System.Drawing.Color.White
        Me.Insert.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Insert.HoverState.Parent = Me.Insert
        Me.Insert.Location = New System.Drawing.Point(55, 183)
        Me.Insert.Name = "Insert"
        Me.Insert.ShadowDecoration.Parent = Me.Insert
        Me.Insert.Size = New System.Drawing.Size(145, 45)
        Me.Insert.TabIndex = 12
        Me.Insert.Text = "Insert"
        '
        'It_rte
        '
        Me.It_rte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_rte.Location = New System.Drawing.Point(322, 138)
        Me.It_rte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_rte.Name = "It_rte"
        Me.It_rte.Size = New System.Drawing.Size(221, 26)
        Me.It_rte.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(49, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 24)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Rate"
        '
        'It_code
        '
        Me.It_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_code.Location = New System.Drawing.Point(322, 19)
        Me.It_code.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_code.Name = "It_code"
        Me.It_code.Size = New System.Drawing.Size(221, 26)
        Me.It_code.TabIndex = 8
        '
        'It_nme
        '
        Me.It_nme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.It_nme.Location = New System.Drawing.Point(322, 56)
        Me.It_nme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.It_nme.Name = "It_nme"
        Me.It_nme.Size = New System.Drawing.Size(221, 26)
        Me.It_nme.TabIndex = 9
        '
        'It_qty
        '
        Me.It_qty.Location = New System.Drawing.Point(322, 96)
        Me.It_qty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.It_qty.Name = "It_qty"
        Me.It_qty.Size = New System.Drawing.Size(82, 26)
        Me.It_qty.TabIndex = 10
        Me.It_qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(47, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(47, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Item Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(47, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Item Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label11.Location = New System.Drawing.Point(872, 618)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(184, 31)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Total Quantity"
        '
        'Tqty
        '
        Me.Tqty.AutoSize = True
        Me.Tqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Tqty.Location = New System.Drawing.Point(1317, 618)
        Me.Tqty.Name = "Tqty"
        Me.Tqty.Size = New System.Drawing.Size(29, 31)
        Me.Tqty.TabIndex = 96
        Me.Tqty.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ItemDetails)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(873, 10)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(474, 605)
        Me.Panel3.TabIndex = 8
        '
        'ItemDetails
        '
        Me.ItemDetails.AllowUserToAddRows = False
        Me.ItemDetails.AllowUserToDeleteRows = False
        Me.ItemDetails.AllowUserToResizeColumns = False
        Me.ItemDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ItemDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ItemDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemDetails.BackgroundColor = System.Drawing.Color.White
        Me.ItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ItemDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Itm_id, Me.iCode, Me.b_iname, Me.b_i_qty})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemDetails.EnableHeadersVisualStyles = False
        Me.ItemDetails.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDetails.Location = New System.Drawing.Point(0, 0)
        Me.ItemDetails.MultiSelect = False
        Me.ItemDetails.Name = "ItemDetails"
        Me.ItemDetails.ReadOnly = True
        Me.ItemDetails.RowHeadersVisible = False
        Me.ItemDetails.RowTemplate.ReadOnly = True
        Me.ItemDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemDetails.Size = New System.Drawing.Size(472, 603)
        Me.ItemDetails.TabIndex = 47
        Me.ItemDetails.TabStop = False
        Me.ItemDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ItemDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ItemDetails.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ItemDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ItemDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ItemDetails.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ItemDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ItemDetails.ThemeStyle.HeaderStyle.Height = 23
        Me.ItemDetails.ThemeStyle.ReadOnly = True
        Me.ItemDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ItemDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemDetails.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemDetails.ThemeStyle.RowsStyle.Height = 22
        Me.ItemDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ItemDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.iCode.HeaderText = "Item Code"
        Me.iCode.Name = "iCode"
        Me.iCode.ReadOnly = True
        '
        'b_iname
        '
        Me.b_iname.DataPropertyName = "i_nme"
        Me.b_iname.FillWeight = 203.0457!
        Me.b_iname.HeaderText = "Name"
        Me.b_iname.Name = "b_iname"
        Me.b_iname.ReadOnly = True
        '
        'b_i_qty
        '
        Me.b_i_qty.DataPropertyName = "i_qty"
        Me.b_i_qty.FillWeight = 65.65144!
        Me.b_i_qty.HeaderText = "Qty."
        Me.b_i_qty.Name = "b_i_qty"
        Me.b_i_qty.ReadOnly = True
        '
        'nav
        '
        Me.nav.BackColor = System.Drawing.Color.White
        Me.nav.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.nav.BorderRadius = 1
        Me.nav.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.nav.BorderThickness = 2
        Me.nav.Controls.Add(Me.GoToReporting)
        Me.nav.Controls.Add(Me.Rental_return)
        Me.nav.Controls.Add(Me.GoToItemStock)
        Me.nav.Controls.Add(Me.GotoBilling)
        Me.nav.Controls.Add(Me.GoToSettings)
        Me.nav.Controls.Add(Me.PictureBox1)
        Me.nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav.Location = New System.Drawing.Point(0, 0)
        Me.nav.Name = "nav"
        Me.nav.ShadowDecoration.Parent = Me.nav
        Me.nav.Size = New System.Drawing.Size(246, 688)
        Me.nav.TabIndex = 127
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
        'Rental_return
        '
        Me.Rental_return.BorderColor = System.Drawing.Color.Transparent
        Me.Rental_return.BorderRadius = 20
        Me.Rental_return.BorderThickness = 2
        Me.Rental_return.CheckedState.Parent = Me.Rental_return
        Me.Rental_return.CustomImages.Parent = Me.Rental_return
        Me.Rental_return.CustomizableEdges.BottomRight = False
        Me.Rental_return.CustomizableEdges.TopLeft = False
        Me.Rental_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Rental_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Rental_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Rental_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Rental_return.DisabledState.Parent = Me.Rental_return
        Me.Rental_return.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_return.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Rental_return.ForeColor = System.Drawing.Color.White
        Me.Rental_return.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_return.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_return.HoverState.FillColor = System.Drawing.Color.White
        Me.Rental_return.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Rental_return.HoverState.Parent = Me.Rental_return
        Me.Rental_return.Location = New System.Drawing.Point(51, 385)
        Me.Rental_return.Name = "Rental_return"
        Me.Rental_return.ShadowDecoration.Parent = Me.Rental_return
        Me.Rental_return.Size = New System.Drawing.Size(145, 45)
        Me.Rental_return.TabIndex = 91
        Me.Rental_return.Text = "Return"
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
        'GotoBilling
        '
        Me.GotoBilling.BorderColor = System.Drawing.Color.Transparent
        Me.GotoBilling.BorderRadius = 20
        Me.GotoBilling.BorderThickness = 2
        Me.GotoBilling.CheckedState.Parent = Me.GotoBilling
        Me.GotoBilling.CustomImages.Parent = Me.GotoBilling
        Me.GotoBilling.CustomizableEdges.BottomRight = False
        Me.GotoBilling.CustomizableEdges.TopLeft = False
        Me.GotoBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GotoBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GotoBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GotoBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GotoBilling.DisabledState.Parent = Me.GotoBilling
        Me.GotoBilling.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GotoBilling.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GotoBilling.ForeColor = System.Drawing.Color.White
        Me.GotoBilling.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GotoBilling.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GotoBilling.HoverState.FillColor = System.Drawing.Color.White
        Me.GotoBilling.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GotoBilling.HoverState.Parent = Me.GotoBilling
        Me.GotoBilling.Location = New System.Drawing.Point(51, 232)
        Me.GotoBilling.Name = "GotoBilling"
        Me.GotoBilling.ShadowDecoration.Parent = Me.GotoBilling
        Me.GotoBilling.Size = New System.Drawing.Size(145, 45)
        Me.GotoBilling.TabIndex = 88
        Me.GotoBilling.Text = "Bill Maker"
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
        'purchase_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1358, 688)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Tqty)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "purchase_master"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.It_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ItemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tqty As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Fin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Insert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents It_rte As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents It_code As TextBox
    Friend WithEvents It_nme As TextBox
    Friend WithEvents It_qty As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cred As RadioButton
    Friend WithEvents ven_GST As MaskedTextBox
    Friend WithEvents deb As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents InvNo As TextBox
    Friend WithEvents Gtot As TextBox
    Friend WithEvents ven_cont As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ven_nme As TextBox
    Friend WithEvents ven_addr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ItemDetails As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Itm_id As DataGridViewTextBoxColumn
    Friend WithEvents iCode As DataGridViewTextBoxColumn
    Friend WithEvents b_iname As DataGridViewTextBoxColumn
    Friend WithEvents b_i_qty As DataGridViewTextBoxColumn
    Friend WithEvents nav As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GoToReporting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Rental_return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToItemStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GotoBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GoToSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
