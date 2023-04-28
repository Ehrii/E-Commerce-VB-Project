Public Class frmSupplier

    Private Sub btnManage_Click(sender As Object, e As EventArgs)
    End Sub



    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        pnlform.Controls.Clear()
        frmViewInv.TopLevel = False
        pnlform.Controls.Add(frmViewInv)
        frmViewInv.Show()
        Me.Size = New Size(1379, 739)
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click

        pnlform.Controls.Clear()
        frmInventory.TopLevel = False
        pnlform.Controls.Add(frmInventory)
        frmInventory.Show()
        frmInventory.btnAdd.Text = "Add Stocks"
        frmInventory.btnAdd.Enabled = True
        frmInventory.btnDelete.Enabled = False
        frmInventory.grpEntry.Text = "Stock Entry Options"
        frmInventory.lblMenu.Text = "STOCK ENTRY / VIEW STOCKS"

        Me.Size = New Size(1365, 739)
    End Sub

    Private Sub btnStockAdj_Click(sender As Object, e As EventArgs) Handles btnStockAdj.Click
        pnlform.Controls.Clear()
        frmInventory.TopLevel = False
        pnlform.Controls.Add(frmInventory)
        frmInventory.Show()
        frmInventory.btnAdd.Text = "Update Stocks"
        frmInventory.grpEntry.Text = "Stock Adjustment Options"
        frmInventory.lblMenu.Text = "STOCK ADJUSTMENTS"
        frmInventory.btnDelete.Enabled = True
        frmInventory.btnAdd.Enabled = False
        Me.Size = New Size(1365, 739)
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        pnlform.Controls.Clear()
        frmSuppDetails.TopLevel = False
        pnlform.Controls.Add(frmSuppDetails)
        frmSuppDetails.Show()
        Me.Size = New Size(1290, 739)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        pnlform.Controls.Clear()
        frmStockHis.TopLevel = False
        pnlform.Controls.Add(frmStockHis)
        frmStockHis.Show()
        Me.Size = New Size(1410, 739)
    End Sub


End Class