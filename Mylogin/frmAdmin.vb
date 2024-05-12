Imports Guna.UI.Animation
Imports Guna.UI2.WinForms

Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized

    End Sub




    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlform.Controls.Clear()
        frmDashboard.TopLevel = False
        pnlform.Controls.Add(frmDashboard)
        frmDashboard.Show()
        Me.Location = New Point(50, 10)
        frmDashboard.Location = New Point(50, 50)
        Me.Size = New Size(1420, 840)

    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        pnlform.Controls.Clear()
        frmOrderHis.TopLevel = False
        pnlform.Controls.Add(frmOrderHis)
        Me.Size = New Size(1420, 840)
        Me.Location = New Point(50, 10)
        frmOrderHis.Location = New Point(0, 60)

        frmOrderHis.Show()

        'Me.Location = New Point(200, 100)

    End Sub

    Private Sub btnManageRoles_Click(sender As Object, e As EventArgs) Handles btnManageRoles.Click
        pnlform.Controls.Clear()
        frmRoles.TopLevel = False
        pnlform.Controls.Add(frmRoles)
        Me.Size = New Size(1460, 840)
        Me.Location = New Point(50, 10)
        frmRoles.Location = New Point(5, 40)

        frmRoles.Show()

    End Sub

    Private Sub btnInventory_Click_1(sender As Object, e As EventArgs) Handles btnInventory.Click
        pnlform.Controls.Clear()
        frmViewInv.TopLevel = False
        pnlform.Controls.Add(frmViewInv)
        Me.Size = New Size(1420, 840)
        frmViewInv.Location = New Point(0, 60)

        Me.Location = New Point(50, 10)
        frmViewInv.Show()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        pnlform.Controls.Clear()
        frmSalesReport.TopLevel = False
        pnlform.Controls.Add(frmSalesReport)
        frmSalesReport.Location = New Point(0, 60)

        Me.Size = New Size(1537, 840)
        Me.Location = New Point(50, 10)
        frmSalesReport.Show()
    End Sub

    Private Sub btnAudit_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
        pnlform.Controls.Clear()
        frmAudit.TopLevel = False
        Me.Size = New Size(1420, 840)
        Me.Location = New Point(50, 10)
        frmAudit.Location = New Point(0, 40)

        pnlform.Controls.Add(frmAudit)
        frmAudit.Show()
    End Sub



    Private Sub btnManageProd_Click(sender As Object, e As EventArgs) Handles btnManageProd.Click
        pnlform.Controls.Clear()
        frmManage.TopLevel = False
        pnlform.Controls.Add(frmManage)
        Me.Size = New Size(1420, 900)
        Me.Location = New Point(50, 10)
        frmManage.Location = New Point(0, 60)

        frmManage.Show()
    End Sub

    Private Sub btnDatabaseRecovery_Click(sender As Object, e As EventArgs) Handles btnSalesRet.Click
        pnlform.Controls.Clear()
        frmSalesReturn.TopLevel = False
        pnlform.Controls.Add(frmSalesReturn)
        Me.Size = New Size(1420, 840)
        Me.Location = New Point(50, 10)
        frmSalesReturn.Location = New Point(25, 60)

        frmSalesReturn.Show()
    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        pnlform.Controls.Clear()
        frmManageRev.TopLevel = False
        pnlform.Controls.Add(frmManageRev)
        Me.Size = New Size(1420, 840)
        Me.Location = New Point(50, 10)
        frmManageRev.Location = New Point(20, 60)

        frmManageRev.Show()
    End Sub

    Private Sub btnDatabaseRecov_Click(sender As Object, e As EventArgs) Handles btnDatabaseRecov.Click
        pnlform.Controls.Clear()
        frmBackup.TopLevel = False
        pnlform.Controls.Add(frmBackup)
        Me.Size = New Size(1420, 840)
        Me.Location = New Point(50, 10)
        frmBackup.Location = New Point(250, 2)
        frmBackup.Show()

    End Sub


End Class