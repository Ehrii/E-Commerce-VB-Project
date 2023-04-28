Public Class frmRegister
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCreate.Show()
        frmCreate.lblRole.Text = "CUSTOMER"


    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        frmCreate.Show()
        frmCreate.lblRole.Text = "SUPPLIER"

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frmCreate.Show()
        frmCreate.lblRole.Text = "ADMINISTRATOR"

    End Sub
End Class