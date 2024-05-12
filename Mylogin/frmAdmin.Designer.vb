<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.S = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2BorderlessForm2 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnManageRoles = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnManageOrders = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSalesRet = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSales = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAudit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnManageProd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReview = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDatabaseRecov = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlform = New System.Windows.Forms.Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'S
        '
        Me.S.ContainerControl = Me
        Me.S.DockIndicatorTransparencyValue = 0.6R
        Me.S.DragForm = False
        Me.S.TransparentWhileDrag = True
        '
        'Guna2BorderlessForm2
        '
        Me.Guna2BorderlessForm2.ContainerControl = Me
        Me.Guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm2.DragForm = False
        Me.Guna2BorderlessForm2.TransparentWhileDrag = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderRadius = 30
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(5, 7)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(205, 166)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnDashboard
        '
        Me.btnDashboard.AutoRoundedCorners = True
        Me.btnDashboard.BorderRadius = 21
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.FillColor = System.Drawing.Color.Empty
        Me.btnDashboard.FillColor2 = System.Drawing.Color.Empty
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.Location = New System.Drawing.Point(-76, 200)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(328, 45)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        '
        'btnManageRoles
        '
        Me.btnManageRoles.AutoRoundedCorners = True
        Me.btnManageRoles.BorderRadius = 21
        Me.btnManageRoles.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnManageRoles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnManageRoles.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageRoles.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageRoles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnManageRoles.FillColor = System.Drawing.Color.Empty
        Me.btnManageRoles.FillColor2 = System.Drawing.Color.Empty
        Me.btnManageRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageRoles.ForeColor = System.Drawing.Color.White
        Me.btnManageRoles.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnManageRoles.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnManageRoles.Image = CType(resources.GetObject("btnManageRoles.Image"), System.Drawing.Image)
        Me.btnManageRoles.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnManageRoles.Location = New System.Drawing.Point(-51, 371)
        Me.btnManageRoles.Name = "btnManageRoles"
        Me.btnManageRoles.Size = New System.Drawing.Size(292, 45)
        Me.btnManageRoles.TabIndex = 6
        Me.btnManageRoles.Text = "Manage Roles"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BorderRadius = 21
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Empty
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GradientButton1.Image = CType(resources.GetObject("Guna2GradientButton1.Image"), System.Drawing.Image)
        Me.Guna2GradientButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(-102, 800)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(359, 45)
        Me.Guna2GradientButton1.TabIndex = 9
        Me.Guna2GradientButton1.Text = "Log-Out"
        '
        'btnManageOrders
        '
        Me.btnManageOrders.AutoRoundedCorners = True
        Me.btnManageOrders.BorderRadius = 21
        Me.btnManageOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnManageOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnManageOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageOrders.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnManageOrders.FillColor = System.Drawing.Color.Empty
        Me.btnManageOrders.FillColor2 = System.Drawing.Color.Empty
        Me.btnManageOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageOrders.ForeColor = System.Drawing.Color.White
        Me.btnManageOrders.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnManageOrders.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnManageOrders.Image = CType(resources.GetObject("btnManageOrders.Image"), System.Drawing.Image)
        Me.btnManageOrders.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnManageOrders.Location = New System.Drawing.Point(-51, 315)
        Me.btnManageOrders.Name = "btnManageOrders"
        Me.btnManageOrders.Size = New System.Drawing.Size(307, 45)
        Me.btnManageOrders.TabIndex = 10
        Me.btnManageOrders.Text = "Manage Orders"
        '
        'btnInventory
        '
        Me.btnInventory.AutoRoundedCorners = True
        Me.btnInventory.BorderRadius = 21
        Me.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInventory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInventory.FillColor = System.Drawing.Color.Empty
        Me.btnInventory.FillColor2 = System.Drawing.Color.Empty
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnInventory.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnInventory.Location = New System.Drawing.Point(-83, 427)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(329, 45)
        Me.btnInventory.TabIndex = 11
        Me.btnInventory.Text = "Inventory"
        '
        'btnSalesRet
        '
        Me.btnSalesRet.AutoRoundedCorners = True
        Me.btnSalesRet.BorderRadius = 21
        Me.btnSalesRet.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSalesRet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSalesRet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalesRet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalesRet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSalesRet.FillColor = System.Drawing.Color.Empty
        Me.btnSalesRet.FillColor2 = System.Drawing.Color.Empty
        Me.btnSalesRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesRet.ForeColor = System.Drawing.Color.White
        Me.btnSalesRet.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnSalesRet.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSalesRet.Image = CType(resources.GetObject("btnSalesRet.Image"), System.Drawing.Image)
        Me.btnSalesRet.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSalesRet.Location = New System.Drawing.Point(-35, 611)
        Me.btnSalesRet.Name = "btnSalesRet"
        Me.btnSalesRet.Size = New System.Drawing.Size(265, 45)
        Me.btnSalesRet.TabIndex = 12
        Me.btnSalesRet.Text = "Sales Returns"
        '
        'btnSales
        '
        Me.btnSales.AutoRoundedCorners = True
        Me.btnSales.BorderRadius = 21
        Me.btnSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSales.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSales.FillColor = System.Drawing.Color.Empty
        Me.btnSales.FillColor2 = System.Drawing.Color.Empty
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnSales.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSales.Image = CType(resources.GetObject("btnSales.Image"), System.Drawing.Image)
        Me.btnSales.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSales.Location = New System.Drawing.Point(-61, 487)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(307, 45)
        Me.btnSales.TabIndex = 13
        Me.btnSales.Text = "Sales Report"
        '
        'btnAudit
        '
        Me.btnAudit.AutoRoundedCorners = True
        Me.btnAudit.BorderRadius = 21
        Me.btnAudit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAudit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAudit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAudit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAudit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAudit.FillColor = System.Drawing.Color.Empty
        Me.btnAudit.FillColor2 = System.Drawing.Color.Empty
        Me.btnAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAudit.ForeColor = System.Drawing.Color.White
        Me.btnAudit.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnAudit.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnAudit.Image = CType(resources.GetObject("btnAudit.Image"), System.Drawing.Image)
        Me.btnAudit.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAudit.Location = New System.Drawing.Point(-66, 548)
        Me.btnAudit.Name = "btnAudit"
        Me.btnAudit.Size = New System.Drawing.Size(307, 45)
        Me.btnAudit.TabIndex = 14
        Me.btnAudit.Text = "Audit Trail"
        '
        'btnManageProd
        '
        Me.btnManageProd.AutoRoundedCorners = True
        Me.btnManageProd.BorderRadius = 21
        Me.btnManageProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnManageProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnManageProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageProd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnManageProd.FillColor = System.Drawing.Color.Empty
        Me.btnManageProd.FillColor2 = System.Drawing.Color.Empty
        Me.btnManageProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageProd.ForeColor = System.Drawing.Color.White
        Me.btnManageProd.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnManageProd.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnManageProd.Image = CType(resources.GetObject("btnManageProd.Image"), System.Drawing.Image)
        Me.btnManageProd.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnManageProd.Location = New System.Drawing.Point(-58, 257)
        Me.btnManageProd.Name = "btnManageProd"
        Me.btnManageProd.Size = New System.Drawing.Size(328, 45)
        Me.btnManageProd.TabIndex = 15
        Me.btnManageProd.Text = "Manage Products"
        '
        'btnReview
        '
        Me.btnReview.AutoRoundedCorners = True
        Me.btnReview.BorderRadius = 21
        Me.btnReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReview.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReview.FillColor = System.Drawing.Color.Empty
        Me.btnReview.FillColor2 = System.Drawing.Color.Empty
        Me.btnReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReview.ForeColor = System.Drawing.Color.White
        Me.btnReview.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnReview.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnReview.Image = CType(resources.GetObject("btnReview.Image"), System.Drawing.Image)
        Me.btnReview.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnReview.Location = New System.Drawing.Point(-26, 672)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(265, 45)
        Me.btnReview.TabIndex = 16
        Me.btnReview.Text = "Manage Reviews"
        '
        'btnDatabaseRecov
        '
        Me.btnDatabaseRecov.AutoRoundedCorners = True
        Me.btnDatabaseRecov.BorderRadius = 21
        Me.btnDatabaseRecov.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDatabaseRecov.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDatabaseRecov.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDatabaseRecov.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDatabaseRecov.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDatabaseRecov.FillColor = System.Drawing.Color.Empty
        Me.btnDatabaseRecov.FillColor2 = System.Drawing.Color.Empty
        Me.btnDatabaseRecov.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatabaseRecov.ForeColor = System.Drawing.Color.White
        Me.btnDatabaseRecov.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnDatabaseRecov.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDatabaseRecov.Image = CType(resources.GetObject("btnDatabaseRecov.Image"), System.Drawing.Image)
        Me.btnDatabaseRecov.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDatabaseRecov.Location = New System.Drawing.Point(-17, 730)
        Me.btnDatabaseRecov.Name = "btnDatabaseRecov"
        Me.btnDatabaseRecov.Size = New System.Drawing.Size(265, 45)
        Me.btnDatabaseRecov.TabIndex = 17
        Me.btnDatabaseRecov.Text = "Database Recovery"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDatabaseRecov)
        Me.Panel1.Controls.Add(Me.btnReview)
        Me.Panel1.Controls.Add(Me.btnManageProd)
        Me.Panel1.Controls.Add(Me.btnAudit)
        Me.Panel1.Controls.Add(Me.btnSales)
        Me.Panel1.Controls.Add(Me.btnSalesRet)
        Me.Panel1.Controls.Add(Me.btnInventory)
        Me.Panel1.Controls.Add(Me.btnManageOrders)
        Me.Panel1.Controls.Add(Me.Guna2GradientButton1)
        Me.Panel1.Controls.Add(Me.btnManageRoles)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 867)
        Me.Panel1.TabIndex = 2
        '
        'pnlform
        '
        Me.pnlform.BackColor = System.Drawing.Color.Transparent
        Me.pnlform.BackgroundImage = CType(resources.GetObject("pnlform.BackgroundImage"), System.Drawing.Image)
        Me.pnlform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlform.Location = New System.Drawing.Point(215, 0)
        Me.pnlform.Name = "pnlform"
        Me.pnlform.Size = New System.Drawing.Size(1104, 867)
        Me.pnlform.TabIndex = 3
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1319, 867)
        Me.Controls.Add(Me.pnlform)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmin"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents S As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2BorderlessForm2 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlform As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDatabaseRecov As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnReview As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnManageProd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAudit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSales As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSalesRet As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnManageOrders As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnManageRoles As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
