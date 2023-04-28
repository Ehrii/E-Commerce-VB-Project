<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.DgvHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbCateg = New System.Windows.Forms.ComboBox()
        Me.Guna2GroupBox6 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Order_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Order_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'DgvHistory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHistory.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvHistory.ColumnHeadersHeight = 40
        Me.DgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Order_ID, Me.Order_Date, Me.Total, Me.Quantity, Me.Status, Me.Customer_ID, Me.Cancel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvHistory.Location = New System.Drawing.Point(269, 79)
        Me.DgvHistory.Name = "DgvHistory"
        Me.DgvHistory.RowHeadersVisible = False
        Me.DgvHistory.Size = New System.Drawing.Size(858, 557)
        Me.DgvHistory.TabIndex = 0
        Me.DgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvHistory.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvHistory.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvHistory.ThemeStyle.ReadOnly = False
        Me.DgvHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvHistory.ThemeStyle.RowsStyle.Height = 22
        Me.DgvHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(65, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 20)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "ORDER STATUS"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(65, 9)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(168, 27)
        Me.GunaLabel4.TabIndex = 45
        Me.GunaLabel4.Text = "ORDER HISTORY"
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BorderThickness = 1
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(44, 27)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes2.Size = New System.Drawing.Size(212, 23)
        Me.Guna2Shapes2.TabIndex = 46
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderThickness = 1
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(9, 25)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes1.Size = New System.Drawing.Size(200, 23)
        Me.Guna2Shapes1.TabIndex = 44
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(251, 233)
        Me.Guna2GroupBox1.TabIndex = 180
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'btnBack
        '
        Me.btnBack.AutoRoundedCorners = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderRadius = 13
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.HoverState.FillColor = System.Drawing.Color.Black
        Me.btnBack.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(9, 608)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(110, 28)
        Me.btnBack.TabIndex = 182
        Me.btnBack.Text = "BACK"
        '
        'cmbCateg
        '
        Me.cmbCateg.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCateg.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCateg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cmbCateg.FormattingEnabled = True
        Me.cmbCateg.Items.AddRange(New Object() {"All", "Pending", "Shipped", "Delivered", "Canceled"})
        Me.cmbCateg.Location = New System.Drawing.Point(959, 46)
        Me.cmbCateg.Name = "cmbCateg"
        Me.cmbCateg.Size = New System.Drawing.Size(168, 27)
        Me.cmbCateg.TabIndex = 56
        Me.cmbCateg.Text = "     Delivery Status"
        '
        'Guna2GroupBox6
        '
        Me.Guna2GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox6.Controls.Add(Me.RadioButton4)
        Me.Guna2GroupBox6.Controls.Add(Me.RadioButton3)
        Me.Guna2GroupBox6.Controls.Add(Me.RadioButton2)
        Me.Guna2GroupBox6.Controls.Add(Me.RadioButton1)
        Me.Guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox6.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox6.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2GroupBox6.Location = New System.Drawing.Point(12, 318)
        Me.Guna2GroupBox6.Name = "Guna2GroupBox6"
        Me.Guna2GroupBox6.Size = New System.Drawing.Size(251, 182)
        Me.Guna2GroupBox6.TabIndex = 193
        Me.Guna2GroupBox6.Text = "Periodical Information"
        Me.Guna2GroupBox6.UseTransparentBackground = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RadioButton4.Location = New System.Drawing.Point(10, 144)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(78, 26)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Yearly"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RadioButton3.Location = New System.Drawing.Point(10, 113)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(88, 26)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Monthly"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(10, 81)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(94, 26)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Weekly "
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(10, 49)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 26)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Daily"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Order_ID
        '
        Me.Order_ID.HeaderText = "Order ID"
        Me.Order_ID.Name = "Order_ID"
        '
        'Order_Date
        '
        Me.Order_Date.HeaderText = "Order Date"
        Me.Order_Date.Name = "Order_Date"
        '
        'Total
        '
        Me.Total.HeaderText = "Order Amount"
        Me.Total.Name = "Total"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Order Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Status
        '
        Me.Status.HeaderText = "Order Status"
        Me.Status.Name = "Status"
        '
        'Customer_ID
        '
        Me.Customer_ID.HeaderText = "Customer ID"
        Me.Customer_ID.Name = "Customer_ID"
        '
        'Cancel
        '
        Me.Cancel.HeaderText = ""
        Me.Cancel.Image = CType(resources.GetObject("Cancel.Image"), System.Drawing.Image)
        Me.Cancel.Name = "Cancel"
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1139, 648)
        Me.Controls.Add(Me.Guna2GroupBox6)
        Me.Controls.Add(Me.cmbCateg)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Controls.Add(Me.DgvHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistory"
        Me.Text = "frmHistory"
        CType(Me.DgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox6.ResumeLayout(False)
        Me.Guna2GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents DgvHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCateg As ComboBox
    Friend WithEvents Guna2GroupBox6 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Order_ID As DataGridViewTextBoxColumn
    Friend WithEvents Order_Date As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Customer_ID As DataGridViewTextBoxColumn
    Friend WithEvents Cancel As DataGridViewImageColumn
End Class
