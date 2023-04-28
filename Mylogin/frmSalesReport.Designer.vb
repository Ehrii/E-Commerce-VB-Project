<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesReport))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.DgvSales = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtCustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVolume = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSales = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        CType(Me.DgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'DgvSales
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSales.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSales.ColumnHeadersHeight = 40
        Me.DgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSales.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSales.Location = New System.Drawing.Point(301, 87)
        Me.DgvSales.Name = "DgvSales"
        Me.DgvSales.RowHeadersVisible = False
        Me.DgvSales.Size = New System.Drawing.Size(876, 584)
        Me.DgvSales.TabIndex = 185
        Me.DgvSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSales.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvSales.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSales.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvSales.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvSales.ThemeStyle.ReadOnly = False
        Me.DgvSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSales.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvSales.ThemeStyle.RowsStyle.Height = 22
        Me.DgvSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox2.Controls.Add(Me.txtCustomer)
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.txtStatus)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.txtVolume)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.txtSales)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 87)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(283, 342)
        Me.Guna2GroupBox2.TabIndex = 186
        Me.Guna2GroupBox2.Text = "Report Information"
        Me.Guna2GroupBox2.UseTransparentBackground = True
        '
        'txtCustomer
        '
        Me.txtCustomer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomer.DefaultText = ""
        Me.txtCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.ForeColor = System.Drawing.Color.White
        Me.txtCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Location = New System.Drawing.Point(12, 291)
        Me.txtCustomer.Multiline = True
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomer.PlaceholderText = ""
        Me.txtCustomer.SelectedText = ""
        Me.txtCustomer.Size = New System.Drawing.Size(256, 33)
        Me.txtCustomer.TabIndex = 194
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 22)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Sales Date:"
        '
        'txtStatus
        '
        Me.txtStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatus.DefaultText = ""
        Me.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.White
        Me.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.Location = New System.Drawing.Point(12, 218)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PlaceholderText = ""
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.Size = New System.Drawing.Size(256, 33)
        Me.txtStatus.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Sales Status"
        '
        'txtVolume
        '
        Me.txtVolume.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtVolume.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVolume.DefaultText = ""
        Me.txtVolume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVolume.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVolume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVolume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVolume.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtVolume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVolume.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.ForeColor = System.Drawing.Color.White
        Me.txtVolume.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVolume.Location = New System.Drawing.Point(12, 145)
        Me.txtVolume.Multiline = True
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVolume.PlaceholderText = ""
        Me.txtVolume.SelectedText = ""
        Me.txtVolume.Size = New System.Drawing.Size(256, 33)
        Me.txtVolume.TabIndex = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Sales Volume:"
        '
        'txtSales
        '
        Me.txtSales.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSales.DefaultText = ""
        Me.txtSales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSales.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtSales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSales.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.ForeColor = System.Drawing.Color.White
        Me.txtSales.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSales.Location = New System.Drawing.Point(12, 77)
        Me.txtSales.Multiline = True
        Me.txtSales.Name = "txtSales"
        Me.txtSales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSales.PlaceholderText = ""
        Me.txtSales.SelectedText = ""
        Me.txtSales.Size = New System.Drawing.Size(256, 33)
        Me.txtSales.TabIndex = 188
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 22)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Sales Amount:"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 445)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(283, 226)
        Me.Guna2GroupBox1.TabIndex = 187
        Me.Guna2GroupBox1.Text = "Date Information"
        Me.Guna2GroupBox1.UseTransparentBackground = True
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.Checked = True
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(21, 121)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(200, 27)
        Me.Guna2DateTimePicker2.TabIndex = 179
        Me.Guna2DateTimePicker2.Value = New Date(2023, 4, 25, 14, 34, 18, 207)
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(21, 69)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.Guna2DateTimePicker1.TabIndex = 178
        Me.Guna2DateTimePicker1.Value = New Date(2023, 4, 25, 14, 34, 18, 207)
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Guna2Button2.Location = New System.Drawing.Point(16, 158)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.DimGray
        Me.Guna2Button2.Size = New System.Drawing.Size(120, 38)
        Me.Guna2Button2.TabIndex = 177
        Me.Guna2Button2.Text = "Date Filter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "From:"
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1189, 68)
        Me.Panel1.TabIndex = 188
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
        Me.lblMenu.Size = New System.Drawing.Size(187, 20)
        Me.lblMenu.TabIndex = 52
        Me.lblMenu.Text = "VIEW THE TOTAL REVENUE"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(64, 8)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(154, 27)
        Me.GunaLabel4.TabIndex = 50
        Me.GunaLabel4.Text = "SALES REPORT"
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
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1144, 8)
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1106, 8)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(32, 23)
        Me.Guna2ControlBox1.TabIndex = 59
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox3.Controls.Add(Me.Label6)
        Me.Guna2GroupBox3.Controls.Add(Me.lblSales)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(301, 544)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(198, 127)
        Me.Guna2GroupBox3.TabIndex = 188
        Me.Guna2GroupBox3.Text = "Total Sales:"
        Me.Guna2GroupBox3.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 31)
        Me.Label6.TabIndex = 185
        Me.Label6.Text = "₱"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblSales.Location = New System.Drawing.Point(35, 60)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(26, 31)
        Me.lblSales.TabIndex = 184
        Me.lblSales.Text = "*"
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 683)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.DgvSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesReport"
        Me.Text = "frmSalesReport"
        CType(Me.DgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents DgvSales As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtSales As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCustomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVolume As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picImg As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblSales As Label
    Friend WithEvents Label6 As Label
End Class
