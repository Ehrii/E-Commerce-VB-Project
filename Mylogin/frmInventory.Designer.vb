<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.DgvInventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.grpEntry = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtStockQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ProductImg = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Inventory_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntry.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(343, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 22)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Search Products:"
        '
        'DgvInventory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvInventory.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvInventory.ColumnHeadersHeight = 40
        Me.DgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductImg, Me.Inventory_ID, Me.Item_Code, Me.Total, Me.Customer_ID})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvInventory.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvInventory.Location = New System.Drawing.Point(301, 122)
        Me.DgvInventory.Name = "DgvInventory"
        Me.DgvInventory.RowHeadersVisible = False
        Me.DgvInventory.Size = New System.Drawing.Size(836, 554)
        Me.DgvInventory.TabIndex = 82
        Me.DgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvInventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvInventory.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvInventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvInventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvInventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvInventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvInventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvInventory.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvInventory.ThemeStyle.ReadOnly = False
        Me.DgvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvInventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvInventory.ThemeStyle.RowsStyle.Height = 22
        Me.DgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picImg)
        Me.Panel1.Controls.Add(Me.lblMenu)
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.Guna2Shapes2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1148, 68)
        Me.Panel1.TabIndex = 84
        '
        'picImg
        '
        Me.picImg.Image = CType(resources.GetObject("picImg.Image"), System.Drawing.Image)
        Me.picImg.Location = New System.Drawing.Point(5, 6)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(62, 59)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 53
        Me.picImg.TabStop = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(64, 41)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(206, 20)
        Me.lblMenu.TabIndex = 52
        Me.lblMenu.Text = "STOCK ENTRY / VIEW STOCKS"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(64, 8)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(197, 27)
        Me.GunaLabel4.TabIndex = 50
        Me.GunaLabel4.Text = "ORDER INVENTORY"
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes2.BorderThickness = 1
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(48, 26)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes2.Size = New System.Drawing.Size(212, 23)
        Me.Guna2Shapes2.TabIndex = 51
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.BorderRadius = 10
        Me.Guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1103, 8)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(32, 23)
        Me.Guna2ControlBox3.TabIndex = 60
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 10
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1065, 8)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(32, 23)
        Me.Guna2ControlBox1.TabIndex = 59
        '
        'grpEntry
        '
        Me.grpEntry.BackColor = System.Drawing.Color.Transparent
        Me.grpEntry.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.grpEntry.Controls.Add(Me.btnDelete)
        Me.grpEntry.Controls.Add(Me.btnAdd)
        Me.grpEntry.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.grpEntry.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.grpEntry.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.grpEntry.Location = New System.Drawing.Point(12, 529)
        Me.grpEntry.Name = "grpEntry"
        Me.grpEntry.Size = New System.Drawing.Size(283, 100)
        Me.grpEntry.TabIndex = 174
        Me.grpEntry.Text = "Stock Entry"
        Me.grpEntry.UseTransparentBackground = True
        '
        'btnDelete
        '
        Me.btnDelete.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnDelete.BorderThickness = 1
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(150, 48)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PressedColor = System.Drawing.Color.DimGray
        Me.btnDelete.Size = New System.Drawing.Size(120, 38)
        Me.btnDelete.TabIndex = 176
        Me.btnDelete.Text = "Delete Stocks"
        '
        'btnAdd
        '
        Me.btnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(11, 48)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PressedColor = System.Drawing.Color.DimGray
        Me.btnAdd.Size = New System.Drawing.Size(120, 38)
        Me.btnAdd.TabIndex = 175
        Me.btnAdd.Text = "Update Stocks"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox2.Controls.Add(Me.txtStockQty)
        Me.Guna2GroupBox2.Controls.Add(Me.txtCode)
        Me.Guna2GroupBox2.Controls.Add(Me.txtID)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.txtName)
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 85)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(283, 438)
        Me.Guna2GroupBox2.TabIndex = 177
        Me.Guna2GroupBox2.Text = "Stock Information"
        Me.Guna2GroupBox2.UseTransparentBackground = True
        '
        'txtStockQty
        '
        Me.txtStockQty.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtStockQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStockQty.DefaultText = ""
        Me.txtStockQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStockQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStockQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStockQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStockQty.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtStockQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStockQty.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockQty.ForeColor = System.Drawing.Color.White
        Me.txtStockQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStockQty.Location = New System.Drawing.Point(14, 357)
        Me.txtStockQty.Multiline = True
        Me.txtStockQty.Name = "txtStockQty"
        Me.txtStockQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStockQty.PlaceholderText = ""
        Me.txtStockQty.SelectedText = ""
        Me.txtStockQty.Size = New System.Drawing.Size(256, 33)
        Me.txtStockQty.TabIndex = 188
        '
        'txtCode
        '
        Me.txtCode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.DefaultText = ""
        Me.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCode.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.White
        Me.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(14, 141)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.PlaceholderText = ""
        Me.txtCode.SelectedText = ""
        Me.txtCode.Size = New System.Drawing.Size(256, 33)
        Me.txtCode.TabIndex = 187
        '
        'txtID
        '
        Me.txtID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DefaultText = ""
        Me.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(14, 75)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderText = ""
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(256, 33)
        Me.txtID.TabIndex = 186
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 22)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Stock Qty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 22)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Product Name:"
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(14, 207)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(256, 120)
        Me.txtName.TabIndex = 182
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 22)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Item Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Inventory ID:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.Window
        Me.txtSearch.Location = New System.Drawing.Point(477, 89)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(279, 26)
        Me.txtSearch.TabIndex = 178
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(301, 85)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 81
        Me.PictureBox8.TabStop = False
        '
        'ProductImg
        '
        Me.ProductImg.HeaderText = "Product Image"
        Me.ProductImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ProductImg.Name = "ProductImg"
        Me.ProductImg.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Inventory_ID
        '
        Me.Inventory_ID.HeaderText = "Inventory ID"
        Me.Inventory_ID.Name = "Inventory_ID"
        '
        'Item_Code
        '
        Me.Item_Code.HeaderText = "Item Code"
        Me.Item_Code.Name = "Item_Code"
        '
        'Total
        '
        Me.Total.HeaderText = "Product Name"
        Me.Total.Name = "Total"
        '
        'Customer_ID
        '
        Me.Customer_ID.HeaderText = "Stock"
        Me.Customer_ID.Name = "Customer_ID"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 687)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.grpEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvInventory)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        CType(Me.DgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntry.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents DgvInventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picImg As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents grpEntry As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtStockQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProductImg As DataGridViewImageColumn
    Friend WithEvents Inventory_ID As DataGridViewTextBoxColumn
    Friend WithEvents Item_Code As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Customer_ID As DataGridViewTextBoxColumn
End Class
