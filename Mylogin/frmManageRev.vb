Imports System.IO
Imports DevComponents.DotNetBar
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class frmManageRev



    Sub loadrecord()
        conn.Close()
        Dim reader As MySqlDataReader

        Dim cm As New MySqlCommand
        Dim query As String
        query = "Select Review.Review_ID as 'Review ID', Review.Customer_ID as 'Customer ID', Review.Product_ID as 'Product ID', Review.Subject as 'Subject',  Review.Rating as 'Rating', Review.Comment as 'Comment', Review.Review_Date as 'Review Date', Product.Product_Image as 'Product Image' from review INNER JOIN product ON review.product_id = product.product_id order by product.product_id"
        conn.Open()
        cm = New MySqlCommand(query, conn)
        dr = cm.ExecuteReader

        While dr.Read
            DgvReview.Rows.Add(dr.Item("Product Image"), dr.Item("Review ID"), dr.Item("Customer ID"), dr.Item("Product ID"), dr.Item("Subject"), dr.Item("Rating"), dr.Item("Comment").ToString, dr.Item("Review Date").ToString)
        End While
        dr.Close()
        conn.Close()

        Dim imagecolumn = DirectCast(DgvReview.Columns("Column1"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom

        For i = 0 To DgvReview.Rows.Count - 1
            Dim r As DataGridViewRow = DgvReview.Rows(i)
            r.Height = 70

        Next
    End Sub

    Private Sub frmManageRev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        'txtMessage.Enabled = False
        'txtSub.Enabled = False
        'Guna2RatingStar1.Enabled = False
        'dtpCurrent.Enabled = False
        loadrecord()

    End Sub

    Private Sub DgvReview_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvReview.CellMouseClick
        btnReview.Enabled = True
        Try
            lblCustom.Text = DgvReview.CurrentRow.Cells(1).Value.ToString
            lblProdID.Text = DgvReview.CurrentRow.Cells(2).Value.ToString
            txtSub.Text = DgvReview.CurrentRow.Cells(4).Value.ToString
            Guna2RatingStar1.Value = DgvReview.CurrentRow.Cells(5).Value.ToString
            txtMessage.Text = DgvReview.CurrentRow.Cells(6).Value.ToString
            dtpCurrent.Value = DgvReview.CurrentRow.Cells(7).Value.ToString
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        conn.Close()
        loadrecord()
        Dim cm As MySqlCommand
        Dim reviewID = DgvReview.CurrentRow.Cells(1).Value.ToString
        cm = New MySqlCommand("DELETE FROM review WHERE Review_ID = @Review_ID", conn)
        cm.Parameters.Add("@Review_ID", MySqlDbType.Int64).Value = reviewID
        conn.Open()
        If cm.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Review Deleted", "DELAROTA MANAGE REVIEWS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error")
        End If
    End Sub
End Class