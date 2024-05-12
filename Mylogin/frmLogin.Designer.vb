<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.chkPass = New Guna.UI.WinForms.GunaCheckBox()
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linkaccnt = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnCreateAcc = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.p2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.anima1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.anima1.DefaultAnimation = Animation1
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.btnLogin, Guna.UI.Animation.DecorationType.None)
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(92, 385)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Size = New System.Drawing.Size(252, 42)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPass
        '
        Me.chkPass.BaseColor = System.Drawing.Color.White
        Me.chkPass.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkPass.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.chkPass.Cursor = System.Windows.Forms.Cursors.Cross
        Me.anima1.SetDecoration(Me.chkPass, Guna.UI.Animation.DecorationType.None)
        Me.chkPass.FillColor = System.Drawing.Color.White
        Me.chkPass.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPass.ForeColor = System.Drawing.Color.Silver
        Me.chkPass.Location = New System.Drawing.Point(106, 325)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(134, 20)
        Me.chkPass.TabIndex = 4
        Me.chkPass.Text = "Show Password"
        '
        'p2
        '
        Me.p2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.p2.Controls.Add(Me.txtEmail)
        Me.p2.Controls.Add(Me.txtPass)
        Me.p2.Controls.Add(Me.PictureBox2)
        Me.p2.Controls.Add(Me.PictureBox1)
        Me.p2.Controls.Add(Me.chkPass)
        Me.p2.Controls.Add(Me.linkaccnt)
        Me.p2.Controls.Add(Me.btnLogin)
        Me.p2.Controls.Add(Me.Guna2PictureBox1)
        Me.anima1.SetDecoration(Me.p2, Guna.UI.Animation.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(537, 12)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(407, 558)
        Me.p2.TabIndex = 1
        Me.p2.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.AutoRoundedCorners = True
        Me.txtEmail.BorderColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderRadius = 20
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtEmail, Guna.UI.Animation.DecorationType.None)
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(108, 219)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(238, 43)
        Me.txtEmail.TabIndex = 10
        '
        'txtPass
        '
        Me.txtPass.AutoRoundedCorners = True
        Me.txtPass.BorderColor = System.Drawing.Color.Transparent
        Me.txtPass.BorderRadius = 20
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtPass, Guna.UI.Animation.DecorationType.None)
        Me.txtPass.DefaultText = ""
        Me.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(108, 276)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.PlaceholderText = "Password"
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(238, 43)
        Me.txtPass.TabIndex = 9
        '
        'PictureBox2
        '
        Me.anima1.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(47, 276)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.anima1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 219)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'linkaccnt
        '
        Me.linkaccnt.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.linkaccnt.AutoSize = True
        Me.anima1.SetDecoration(Me.linkaccnt, Guna.UI.Animation.DecorationType.None)
        Me.linkaccnt.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkaccnt.LinkColor = System.Drawing.Color.Silver
        Me.linkaccnt.Location = New System.Drawing.Point(157, 443)
        Me.linkaccnt.Name = "linkaccnt"
        Me.linkaccnt.Size = New System.Drawing.Size(123, 17)
        Me.linkaccnt.TabIndex = 3
        Me.linkaccnt.TabStop = True
        Me.linkaccnt.Text = "Forgot Password?"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BorderRadius = 50
        Me.anima1.SetDecoration(Me.Guna2PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(47, 11)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(316, 186)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2GradientPanel2
        '
        Me.anima1.SetDecoration(Me.Guna2GradientPanel2, Guna.UI.Animation.DecorationType.None)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(-8, 1)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(21, 593)
        Me.Guna2GradientPanel2.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BackgroundImage = CType(resources.GetObject("Guna2GradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnCreateAcc)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblLogin)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox4)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox3)
        Me.anima1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI.Animation.DecorationType.None)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-11, 1)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(540, 593)
        Me.Guna2GradientPanel1.TabIndex = 3
        Me.Guna2GradientPanel1.UseTransparentBackground = True
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.AutoRoundedCorners = True
        Me.btnCreateAcc.BorderColor = System.Drawing.Color.Transparent
        Me.btnCreateAcc.BorderRadius = 17
        Me.anima1.SetDecoration(Me.btnCreateAcc, Guna.UI.Animation.DecorationType.None)
        Me.btnCreateAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateAcc.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnCreateAcc.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.ForeColor = System.Drawing.Color.Black
        Me.btnCreateAcc.Location = New System.Drawing.Point(155, 509)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.PressedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCreateAcc.Size = New System.Drawing.Size(280, 36)
        Me.btnCreateAcc.TabIndex = 4
        Me.btnCreateAcc.Text = "Register"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(193, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 76)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "READY TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GEAR UP?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.anima1.SetDecoration(Me.lblLogin, Guna.UI.Animation.DecorationType.None)
        Me.lblLogin.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(160, 425)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(275, 80)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Unlock your potential. Sign in to your  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  account and let's get moving!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    ""
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox4
        '
        Me.anima1.SetDecoration(Me.PictureBox4, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(84, 99)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(408, 349)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.anima1.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-78, -10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(620, 603)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 13
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Black
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me.lblLogin
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 582)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.p2)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents chkPass As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateAcc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents linkaccnt As Guna.UI.WinForms.GunaLinkLabel
End Class
