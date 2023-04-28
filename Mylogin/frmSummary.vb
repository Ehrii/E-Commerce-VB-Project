Imports System.Drawing.Printing
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class frmSummary
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim cm As New MySqlCommand
        dgvCart.Rows.Clear()
        cm = New MySqlCommand("Select * from cart where Customer_ID ='" & customID & "'", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvCart.Rows.Add(dr.Item("Product_Image"), dr.Item("Product_Name"), dr.Item("Quantity").ToString, dr.Item("Amount").ToString)
        End While
        dr.Close()
        conn.Close()
        For i = 0 To dgvCart.Rows.Count - 1
            Dim r As DataGridViewRow = dgvCart.Rows(i)
            r.Height = 60
        Next
        Dim imagecolumn = DirectCast(dgvCart.Columns("Column1"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        lblOrder.Text = orderID

        lblDisc.Text = Val(frmDelivery.lblDiscAmt.Text)
        lblSubtotal.Text = frmCart.txtSub.Text
        lblShipping.Text = frmDelivery.lblShipping.Text
        lblTotal.Text = frmPayment.txtAmtDue.Text

    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmReceipt.Show()
    End Sub


End Class