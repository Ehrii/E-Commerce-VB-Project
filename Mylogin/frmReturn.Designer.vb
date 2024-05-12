<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturn
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.DgvReturn = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Order_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblOrderAmt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.circleProgBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDateOrdered = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblReceiving = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.progBar = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.DgvReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'DgvReturn
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgvReturn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvReturn.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvReturn.ColumnHeadersHeight = 40
        Me.DgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Order_Date, Me.Category_ID, Me.Quantity, Me.Amount, Me.SalesDate, Me.OrderID})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvReturn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvReturn.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReturn.Location = New System.Drawing.Point(12, 12)
        Me.DgvReturn.Name = "DgvReturn"
        Me.DgvReturn.RowHeadersVisible = False
        Me.DgvReturn.Size = New System.Drawing.Size(851, 661)
        Me.DgvReturn.TabIndex = 175
        Me.DgvReturn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvReturn.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvReturn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvReturn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvReturn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvReturn.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvReturn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReturn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReturn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvReturn.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvReturn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvReturn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvReturn.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvReturn.ThemeStyle.ReadOnly = False
        Me.DgvReturn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvReturn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvReturn.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvReturn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvReturn.ThemeStyle.RowsStyle.Height = 22
        Me.DgvReturn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReturn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Order_Date
        '
        Me.Order_Date.HeaderText = "Product ID"
        Me.Order_Date.Name = "Order_Date"
        '
        'Category_ID
        '
        Me.Category_ID.HeaderText = "Product Name"
        Me.Category_ID.Name = "Category_ID"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Product Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Product Amount"
        Me.Amount.Name = "Amount"
        '
        'SalesDate
        '
        Me.SalesDate.HeaderText = "Date Ordered "
        Me.SalesDate.Name = "SalesDate"
        '
        'OrderID
        '
        Me.OrderID.HeaderText = "Order ID"
        Me.OrderID.Name = "OrderID"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Label11)
        Me.Guna2Panel1.Controls.Add(Me.lblOrderAmt)
        Me.Guna2Panel1.Controls.Add(Me.Label14)
        Me.Guna2Panel1.Controls.Add(Me.lblStatus)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.btnReturn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(869, 502)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(355, 171)
        Me.Guna2Panel1.TabIndex = 176
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(194, 122)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.DimGray
        Me.Guna2Button1.Size = New System.Drawing.Size(138, 38)
        Me.Guna2Button1.TabIndex = 197
        Me.Guna2Button1.Text = "Delete Order?"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(18, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(250, 34)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "* Order Amount includes Vat,  Discounts," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and other fees."
        '
        'lblOrderAmt
        '
        Me.lblOrderAmt.AutoSize = True
        Me.lblOrderAmt.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderAmt.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderAmt.ForeColor = System.Drawing.Color.White
        Me.lblOrderAmt.Location = New System.Drawing.Point(133, 51)
        Me.lblOrderAmt.Name = "lblOrderAmt"
        Me.lblOrderAmt.Size = New System.Drawing.Size(18, 22)
        Me.lblOrderAmt.TabIndex = 195
        Me.lblOrderAmt.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(17, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 22)
        Me.Label14.TabIndex = 194
        Me.Label14.Text = "Order Amount:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(123, 22)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(18, 22)
        Me.lblStatus.TabIndex = 193
        Me.lblStatus.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 22)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Order Status:"
        '
        'btnReturn
        '
        Me.btnReturn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnReturn.BorderThickness = 1
        Me.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReturn.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnReturn.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(21, 122)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.PressedColor = System.Drawing.Color.DimGray
        Me.btnReturn.Size = New System.Drawing.Size(137, 38)
        Me.btnReturn.TabIndex = 60
        Me.btnReturn.Text = "Return Product"
        '
        'circleProgBar
        '
        Me.circleProgBar.Animated = True
        Me.circleProgBar.BackColor = System.Drawing.Color.Transparent
        Me.circleProgBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.circleProgBar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.circleProgBar.ForeColor = System.Drawing.Color.White
        Me.circleProgBar.Location = New System.Drawing.Point(3, 8)
        Me.circleProgBar.Minimum = 0
        Me.circleProgBar.Name = "circleProgBar"
        Me.circleProgBar.ProgressColor = System.Drawing.Color.Goldenrod
        Me.circleProgBar.ProgressColor2 = System.Drawing.Color.Yellow
        Me.circleProgBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.circleProgBar.ShowText = True
        Me.circleProgBar.Size = New System.Drawing.Size(83, 83)
        Me.circleProgBar.TabIndex = 177
        Me.circleProgBar.Text = "Guna2CircleProgressBar1"
        Me.circleProgBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderThickness = 3
        Me.Guna2Panel2.Controls.Add(Me.txtAdd)
        Me.Guna2Panel2.Controls.Add(Me.lblMethod)
        Me.Guna2Panel2.Controls.Add(Me.Label12)
        Me.Guna2Panel2.Controls.Add(Me.lblDateOrdered)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Controls.Add(Me.lblReceiving)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.progBar)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2Panel2.Controls.Add(Me.circleProgBar)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(870, 12)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(355, 484)
        Me.Guna2Panel2.TabIndex = 177
        '
        'txtAdd
        '
        Me.txtAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdd.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.ForeColor = System.Drawing.Color.White
        Me.txtAdd.Location = New System.Drawing.Point(91, 91)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(249, 39)
        Me.txtAdd.TabIndex = 191
        Me.txtAdd.Text = "*"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.BackColor = System.Drawing.Color.Transparent
        Me.lblMethod.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethod.ForeColor = System.Drawing.Color.White
        Me.lblMethod.Location = New System.Drawing.Point(26, 458)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(15, 17)
        Me.lblMethod.TabIndex = 188
        Me.lblMethod.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(25, 438)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 17)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "Delivery Method:"
        '
        'lblDateOrdered
        '
        Me.lblDateOrdered.AutoSize = True
        Me.lblDateOrdered.BackColor = System.Drawing.Color.Transparent
        Me.lblDateOrdered.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOrdered.ForeColor = System.Drawing.Color.White
        Me.lblDateOrdered.Location = New System.Drawing.Point(190, 55)
        Me.lblDateOrdered.Name = "lblDateOrdered"
        Me.lblDateOrdered.Size = New System.Drawing.Size(15, 17)
        Me.lblDateOrdered.TabIndex = 186
        Me.lblDateOrdered.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(90, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 185
        Me.Label10.Text = "Date Ordered:"
        '
        'lblReceiving
        '
        Me.lblReceiving.AutoSize = True
        Me.lblReceiving.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiving.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiving.ForeColor = System.Drawing.Color.White
        Me.lblReceiving.Location = New System.Drawing.Point(190, 36)
        Me.lblReceiving.Name = "lblReceiving"
        Me.lblReceiving.Size = New System.Drawing.Size(15, 17)
        Me.lblReceiving.TabIndex = 183
        Me.lblReceiving.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(89, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(91, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Receiving Date:"
        '
        'progBar
        '
        Me.progBar.AutoRoundedCorners = True
        Me.progBar.BackColor = System.Drawing.Color.Transparent
        Me.progBar.BorderRadius = 14
        Me.progBar.Location = New System.Drawing.Point(20, 135)
        Me.progBar.Maximum = 200
        Me.progBar.Minimum = 50
        Me.progBar.Name = "progBar"
        Me.progBar.ProgressColor = System.Drawing.Color.Goldenrod
        Me.progBar.ProgressColor2 = System.Drawing.Color.Yellow
        Me.progBar.Size = New System.Drawing.Size(30, 300)
        Me.progBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progBar.TabIndex = 180
        Me.progBar.Text = "Guna2VProgressBar1"
        Me.progBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.progBar.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(86, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DELIVERY STATUS"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox2.BorderThickness = 4
        Me.Guna2GroupBox2.Controls.Add(Me.txtName)
        Me.Guna2GroupBox2.Controls.Add(Me.lblAmount)
        Me.Guna2GroupBox2.Controls.Add(Me.lblQuantity)
        Me.Guna2GroupBox2.Controls.Add(Me.lblID)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.Label6)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(58, 135)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(285, 300)
        Me.Guna2GroupBox2.TabIndex = 179
        Me.Guna2GroupBox2.Text = "Order Status"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(13, 135)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(252, 36)
        Me.txtName.TabIndex = 190
        Me.txtName.Text = "*"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.White
        Me.lblAmount.Location = New System.Drawing.Point(12, 254)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(16, 19)
        Me.lblAmount.TabIndex = 189
        Me.lblAmount.Text = "*"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(12, 201)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(16, 19)
        Me.lblQuantity.TabIndex = 188
        Me.lblQuantity.Text = "*"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(12, 79)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(16, 19)
        Me.lblID.TabIndex = 185
        Me.lblID.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(9, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 22)
        Me.Label7.TabIndex = 186
        Me.Label7.Text = "Product Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 22)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "Product Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 22)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "Product Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "Product ID:"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me.Guna2GroupBox2
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1236, 681)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.DgvReturn)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReturn"
        CType(Me.DgvReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DgvReturn As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents circleProgBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents progBar As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblReceiving As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblDateOrdered As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMethod As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Order_Date As DataGridViewTextBoxColumn
    Friend WithEvents Category_ID As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents SalesDate As DataGridViewTextBoxColumn
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents lblOrderAmt As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label8 As Label
End Class
