<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReview))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtMessage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gunabtnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSub = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2TextBox8 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.rating = New Guna.UI2.WinForms.Guna2RatingStar()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel4.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.BackgroundImage = CType(resources.GetObject("Guna2GradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.Guna2GradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2GradientPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GradientPanel4.BorderThickness = 2
        Me.Guna2GradientPanel4.Controls.Add(Me.txtMessage)
        Me.Guna2GradientPanel4.Controls.Add(Me.gunabtnConfirm)
        Me.Guna2GradientPanel4.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Guna2GradientPanel4.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GradientPanel4.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(-4, 1)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(998, 643)
        Me.Guna2GradientPanel4.TabIndex = 13
        '
        'txtMessage
        '
        Me.txtMessage.BorderColor = System.Drawing.Color.Goldenrod
        Me.txtMessage.BorderThickness = 2
        Me.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMessage.DefaultText = ""
        Me.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessage.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessage.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.White
        Me.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessage.Location = New System.Drawing.Point(40, 212)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMessage.PlaceholderText = "----WRITE A MESSAGE HERE----"
        Me.txtMessage.SelectedText = ""
        Me.txtMessage.Size = New System.Drawing.Size(906, 341)
        Me.txtMessage.TabIndex = 27
        '
        'gunabtnConfirm
        '
        Me.gunabtnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.gunabtnConfirm.BorderRadius = 15
        Me.gunabtnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gunabtnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gunabtnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gunabtnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gunabtnConfirm.FillColor = System.Drawing.Color.Black
        Me.gunabtnConfirm.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunabtnConfirm.ForeColor = System.Drawing.Color.White
        Me.gunabtnConfirm.Location = New System.Drawing.Point(841, 582)
        Me.gunabtnConfirm.Name = "gunabtnConfirm"
        Me.gunabtnConfirm.Size = New System.Drawing.Size(142, 37)
        Me.gunabtnConfirm.TabIndex = 11
        Me.gunabtnConfirm.Text = "SEND"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 15
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbProduct)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtCustomer)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtSub)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(40, 83)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(906, 112)
        Me.Guna2CustomGradientPanel1.TabIndex = 33
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblDate.Location = New System.Drawing.Point(585, 65)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(19, 21)
        Me.lblDate.TabIndex = 57
        Me.lblDate.Text = "*"
        '
        'cmbProduct
        '
        Me.cmbProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProduct.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(589, 24)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(248, 25)
        Me.cmbProduct.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(493, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "PRODUCT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(524, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "DATE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "CUSTOMER:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "SUBJECT:"
        '
        'txtCustomer
        '
        Me.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomer.DefaultText = ""
        Me.txtCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Location = New System.Drawing.Point(131, 20)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomer.PlaceholderText = ""
        Me.txtCustomer.SelectedText = ""
        Me.txtCustomer.Size = New System.Drawing.Size(328, 28)
        Me.txtCustomer.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCustomer.TabIndex = 24
        '
        'txtSub
        '
        Me.txtSub.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSub.DefaultText = ""
        Me.txtSub.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSub.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSub.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSub.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSub.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSub.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtSub.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSub.Location = New System.Drawing.Point(131, 58)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSub.PlaceholderText = ""
        Me.txtSub.SelectedText = ""
        Me.txtSub.Size = New System.Drawing.Size(328, 28)
        Me.txtSub.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSub.TabIndex = 25
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox8)
        Me.Guna2Panel1.Controls.Add(Me.rating)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(998, 58)
        Me.Guna2Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Guna2TextBox8
        '
        Me.Guna2TextBox8.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox8.DefaultText = "PRODUCT REVIEW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Guna2TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox8.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox8.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox8.ForeColor = System.Drawing.Color.Goldenrod
        Me.Guna2TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox8.Location = New System.Drawing.Point(59, 8)
        Me.Guna2TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TextBox8.Multiline = True
        Me.Guna2TextBox8.Name = "Guna2TextBox8"
        Me.Guna2TextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox8.PlaceholderText = ""
        Me.Guna2TextBox8.SelectedText = ""
        Me.Guna2TextBox8.Size = New System.Drawing.Size(208, 46)
        Me.Guna2TextBox8.TabIndex = 16
        '
        'rating
        '
        Me.rating.BackColor = System.Drawing.Color.Transparent
        Me.rating.BorderColor = System.Drawing.Color.White
        Me.rating.Location = New System.Drawing.Point(863, 14)
        Me.rating.Name = "rating"
        Me.rating.RatingColor = System.Drawing.Color.Goldenrod
        Me.rating.Size = New System.Drawing.Size(120, 28)
        Me.rating.TabIndex = 0
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = "RATE:"
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(786, 10)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(78, 45)
        Me.Guna2TextBox3.TabIndex = 13
        '
        'frmReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(991, 634)
        Me.Controls.Add(Me.Guna2GradientPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReview"
        Me.Text = "frmReview"
        Me.Guna2GradientPanel4.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtMessage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gunabtnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2TextBox8 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rating As Guna.UI2.WinForms.Guna2RatingStar
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents txtSub As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDate As Label
End Class
