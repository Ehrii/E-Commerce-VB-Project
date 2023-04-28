Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlform.Controls.Clear()
        frmDashboard.TopLevel = False
        pnlform.Controls.Add(frmDashboard)
        frmDashboard.Show()
        Me.Size = New Size(1150, 739)
    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        pnlform.Controls.Clear()
        frmOrderHis.TopLevel = False
        pnlform.Controls.Add(frmOrderHis)
        Me.Size = New Size(1420, 739)
        Me.Location = New Point(50, 40)
        frmOrderHis.Show()

        'Me.Location = New Point(200, 100)

    End Sub

    Private Sub btnManageRoles_Click(sender As Object, e As EventArgs) Handles btnManageRoles.Click
        pnlform.Controls.Clear()
        frmRoles.TopLevel = False
        pnlform.Controls.Add(frmRoles)
        Me.Size = New Size(1450, 800)
        Me.Location = New Point(50, 20)
        frmRoles.Show()

    End Sub

    Private Sub btnInventory_Click_1(sender As Object, e As EventArgs) Handles btnInventory.Click
        pnlform.Controls.Clear()
        frmViewInv.TopLevel = False
        pnlform.Controls.Add(frmViewInv)
        Me.Size = New Size(1379, 739)

        Me.Location = New Point(50, 20)
        frmViewInv.Show()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        pnlform.Controls.Clear()
        frmSalesReport.TopLevel = False
        pnlform.Controls.Add(frmSalesReport)
        Me.Size = New Size(1400, 739)
        Me.Location = New Point(50, 20)
        frmSalesReport.Show()
    End Sub

    Private Sub btnAudit_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
        pnlform.Controls.Clear()
        frmAudit.TopLevel = False
        Me.Size = New Size(1400, 750)
        Me.Location = New Point(50, 20)
        pnlform.Controls.Add(frmAudit)
        frmAudit.Show()
    End Sub



    Private Sub btnManageProd_Click(sender As Object, e As EventArgs) Handles btnManageProd.Click
        pnlform.Controls.Clear()
        frmManage.TopLevel = False
        pnlform.Controls.Add(frmManage)
        Me.Size = New Size(1295, 739)
        Me.Location = New Point(50, 20)
        frmManage.Show()
    End Sub


End Class