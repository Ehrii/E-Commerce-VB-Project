﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceipt))
        Me.PPD = New System.Windows.Forms.PrintPreviewDialog()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2CircleProgressBar3 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2CircleProgressBar3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PPD
        '
        Me.PPD.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD.Enabled = True
        Me.PPD.Icon = CType(resources.GetObject("PPD.Icon"), System.Drawing.Icon)
        Me.PPD.Name = "PPD"
        Me.PPD.Visible = False
        '
        'Doc
        '
        Me.Doc.DocumentName = "Document"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(256, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Print Receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(97, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "THANK YOU FOR ORDERING"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(147, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(373, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MONITOR YOUR ORDER HISTORY FOR DELIVERY UPDATES"
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.BorderRadius = 10
        Me.Guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(622, 7)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(32, 23)
        Me.Guna2ControlBox3.TabIndex = 73
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 10
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(584, 7)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(32, 23)
        Me.Guna2ControlBox1.TabIndex = 72
        '
        'Guna2CircleProgressBar3
        '
        Me.Guna2CircleProgressBar3.Animated = True
        Me.Guna2CircleProgressBar3.Controls.Add(Me.PictureBox1)
        Me.Guna2CircleProgressBar3.FillColor = System.Drawing.Color.Gray
        Me.Guna2CircleProgressBar3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2CircleProgressBar3.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleProgressBar3.Location = New System.Drawing.Point(266, 46)
        Me.Guna2CircleProgressBar3.Minimum = 0
        Me.Guna2CircleProgressBar3.Name = "Guna2CircleProgressBar3"
        Me.Guna2CircleProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2CircleProgressBar3.ProgressColor2 = System.Drawing.Color.Yellow
        Me.Guna2CircleProgressBar3.ProgressThickness = 7
        Me.Guna2CircleProgressBar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar3.Size = New System.Drawing.Size(127, 127)
        Me.Guna2CircleProgressBar3.TabIndex = 201
        Me.Guna2CircleProgressBar3.Text = "Guna2CircleProgressBar3"
        Me.Guna2CircleProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2CircleProgressBar3.Value = 99
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 366)
        Me.Controls.Add(Me.Guna2CircleProgressBar3)
        Me.Controls.Add(Me.Guna2ControlBox3)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceipt"
        Me.Guna2CircleProgressBar3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PPD As PrintPreviewDialog
    Friend WithEvents Doc As Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2CircleProgressBar3 As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
