Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class frmProduct

    Dim id As Integer = 50
    Dim sum As Double
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim ms As New MemoryStream
        picProdImg.Image.Save(ms, picProdImg.Image.RawFormat)
        Dim command As New MySqlCommand("INSERT INTO cart VALUES(@Cart_ID,@Product_ID,@Product_Image,@Product_Name,@Quantity,@Amount,@Item_Size,@Customer_ID,@Order_Date, @Order_ID)", conn)
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cart_ID", 0)
            .Parameters.AddWithValue("@Product_ID", txtProdId.Text)
            .Parameters.AddWithValue("@Product_Image", ms.ToArray())
            .Parameters.AddWithValue("@Quantity", nudQuan.Value)
            .Parameters.AddWithValue("@Product_Name", lblProdName.Text & " - " & cmbSize.Text)
            .Parameters.AddWithValue("@Amount", txtPrice.Text)
            .Parameters.AddWithValue("@Item_Size", cmbSize.Text)
            .Parameters.AddWithValue("@Customer_ID", customID)
            .Parameters.AddWithValue("@Order_Date", currdatetime)
            .Parameters.AddWithValue("@Order_ID", orderID)
        End With
        ' conn.Open()

        If cmbSize.Text = "" Then
            MessageBox.Show("Please enter a size", "DELAROTA ITEM SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If nudQuan.Value = 0 Then
            MessageBox.Show("Please enter item quantity", "DELAROTA QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtStock.Text = 0 Then
            MessageBox.Show("Stock not available, Please come back later..", "DELAROTA QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        'conn.Open()
        conn.Close()
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Inserted")
            Dim query, cartcount As String
            query = "select count(*) from cart where customer_id='" & customID & "'"
            Dim cm As New MySqlCommand
            Dim cm2 As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            cartcount = cm.ExecuteScalar()
            conn.Close()
            frmShop.lblCartCount.Text = cartcount
            frmShop.txtCart.Enabled = True
            frmCart.loadRecord()

        Else
            MessageBox.Show("Record not Inserted")
        End If


        Dim command3 As New MySqlCommand("UPDATE product set stock=@stock where product_id='" & txtProdId.Text & "'", conn)
        Dim newStock As Integer = txtStock.Text - nudQuan.Value
        With command3
            .Parameters.Clear()
            .Parameters.AddWithValue("@stock", newStock)
        End With
        conn.Open()
        command3.ExecuteNonQuery()
        frmShop.loadRecord()
        conn.Close()

        conn.Close()
        Me.Hide()
    End Sub


End Class