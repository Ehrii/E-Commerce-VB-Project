Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmCustomerDashboard
    Sub auditload()
        Dim username
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from customer where Customer_ID='" & customID & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            username = reader.GetString("Customer_Username")
        End While
        conn.Close()


        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT product.product_image as 'Product Image',product.product_name as 'Product Name', sales_report.product_id as 'Product ID' FROM product INNER JOIN sales_report ON product.product_id = sales_report.product_id Order by sales_report.sales_amount DESC limit 15", conn)

        conn.Open()
        dr = command.ExecuteReader

        While dr.Read
            DgvActivity.Rows.Add(dr.Item("Product Image"), dr.Item("Product Name"), dr.Item("Product ID").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvActivity.Rows.Count - 1
            Dim r As DataGridViewRow = DgvActivity.Rows(i)
            r.Height = 70
        Next

        Dim imagecolumn = DirectCast(DgvActivity.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom

    End Sub


    Sub reviewhigh()
        Dim query As String
        Dim reader As MySqlDataReader

        query = "SELECT review.comment as 'Comment', review.rating as 'Rating', product.product_image as 'Product Image', review.product_id as 'Product ID', review.customer_id as 'Customer ID' FROM review INNER JOIN product ON review.product_id = product.product_id WHERE review.rating = (SELECT MAX(rating) FROM review)"

        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader

        While reader.Read
            Dim review = reader.GetString("Comment")
            Dim rating = reader("Rating")
            Dim product = reader.GetString("Product ID")
            Dim Customer = reader.GetString("Customer ID")
            txtReview2.Text = " ' " & review & " ' " & " - Customer: " & Customer
            txtProd2.Text = "Product: " & product
            Guna2RatingStar2.Value = rating

            Dim imageBytes As Byte() = DirectCast(reader("Product Image"), Byte())
            Dim stream As New MemoryStream(imageBytes)
            Dim image As Image = Image.FromStream(stream)
            picReview2.Image = image


        End While
        conn.Close()
    End Sub




    Sub reviewlowest()
        Dim query As String
        Dim reader As MySqlDataReader


        query = "SELECT review.comment as 'Comment', review.rating as 'Rating', product.product_image as 'Product Image', review.product_id as 'Product ID', review.customer_id as 'Customer ID' FROM review INNER JOIN product ON review.product_id = product.product_id ORDER BY review.rating ASC LIMIT 1"

        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader

        While reader.Read
            Dim review = reader.GetString("Comment")
            Dim rating = reader("Rating")
            Dim product = reader.GetString("Product ID")
            Dim Customer = reader.GetString("Customer ID")
            txtReview3.Text = " ' " & review & " ' " & " - Customer: " & Customer
            txtProd3.Text = "Product: " & product
            Guna2RatingStar3.Value = rating

            Dim imageBytes As Byte() = DirectCast(reader("Product Image"), Byte())
            Dim stream As New MemoryStream(imageBytes)
            Dim image As Image = Image.FromStream(stream)
            picReview3.Image = image
        End While
        conn.Close()
    End Sub

    Sub reviewrecent()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "SELECT review.comment as 'Comment',review.rating as 'Rating', product.product_image as 'Product Image', review.product_id as 'Product ID', review.customer_id as 'Customer ID'  FROM review INNER JOIN product ON review.product_id = product.product_id  Order by review.review_id desc limit 1"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader

        While reader.Read
            Dim review = reader.GetString("Comment")
            Dim rating = reader("Rating")
            Dim product = reader.GetString("Product ID")
            Dim Customer = reader.GetString("Customer ID")
            txtReview1.Text = " ' " & review & " ' " & " - Customer: " & Customer
            txtProd1.Text = "Product: " & product
            Guna2RatingStar1.Value = rating

            Dim imageBytes As Byte() = DirectCast(reader("Product Image"), Byte())
            Dim stream As New MemoryStream(imageBytes)
            Dim image As Image = Image.FromStream(stream)
            picReview1.Image = image


        End While
        conn.Close()
    End Sub




    Private Sub frmCustomerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        auditload()
        reviewlowest()
        reviewrecent()
        reviewhigh()
        txtVoucher1.Visible = False
        txtVoucher2.Visible = False
        txtVoucher3.Visible = False
        txtVoucher4.Visible = False
        txtVoucher5.Visible = False
        txtVoucher6.Visible = False






        Dim targetDate As DateTime = New DateTime(2023, 5, 9)
        Dim daysLeft As Integer = DateDiff(DateInterval.Day, DateTime.Today, targetDate)
        Label1.Text = targetDate & " " & daysLeft & " Days Left"
        Dim targetDate1 As DateTime = New DateTime(2023, 5, 9)
        Dim daysLeft1 As Integer = DateDiff(DateInterval.Day, DateTime.Today, targetDate1)
        Label2.Text = targetDate1 & " " & daysLeft1 & " Days Left"
        Dim targetDate2 As DateTime = New DateTime(2023, 5, 12)
        Dim daysLeft2 As Integer = DateDiff(DateInterval.Day, DateTime.Today, targetDate2)
        Label3.Text = targetDate2 & " " & daysLeft2 & " Days Left"
        Dim targetDate3 As DateTime = New DateTime(2023, 5, 12)
        Dim daysLeft3 As Integer = DateDiff(DateInterval.Day, DateTime.Today, targetDate3)
        Label4.Text = targetDate3 & " " & daysLeft3 & " Days Left"
        Dim targetDate4 As DateTime = New DateTime(2023, 5, 14)
        Dim daysLeft4 As Integer = DateDiff(DateInterval.Day, DateTime.Today, targetDate4)
        Label5.Text = targetDate4 & " " & daysLeft4 & " Days Left"
        Dim targetDate5 As DateTime = New DateTime(2023, 5, 14)
        Dim daysLeft5 As Integer = DateDiff(DateInterval.Day, DateTime.Today, targetDate5)
        Label6.Text = targetDate5 & " " & daysLeft5 & " Days Left"

        If daysLeft >= 10 Then
            Guna2CircleProgressBar1.Value = 10
        ElseIf daysLeft >= 6 Then
            Guna2CircleProgressBar1.Value = 30
        ElseIf daysLeft >= 4 Then
            Guna2CircleProgressBar1.Value = 50
        ElseIf daysLeft >= 1 Then
            Guna2CircleProgressBar1.Value = 70
        ElseIf daysLeft >= 0 Then
            Guna2CircleProgressBar1.Value = 100
            Guna2CircleProgressBar1.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar1.ProgressColor = Color.LimeGreen
        ElseIf daysLeft < 0 Then
            daysLeft = 0
            Label1.Text = targetDate & " " & daysLeft & " Days Left"
            Guna2CircleProgressBar1.Value = 100
            Guna2CircleProgressBar1.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar1.ProgressColor = Color.LimeGreen
        End If


        If daysLeft1 >= 10 Then
            Guna2CircleProgressBar2.Value = 10
        ElseIf daysLeft1 >= 6 Then
            Guna2CircleProgressBar2.Value = 30
        ElseIf daysLeft1 >= 4 Then
            Guna2CircleProgressBar2.Value = 50
        ElseIf daysLeft1 >= 1 Then
            Guna2CircleProgressBar2.Value = 70
        ElseIf daysLeft1 >= 0 Then
            Guna2CircleProgressBar2.Value = 100
            Guna2CircleProgressBar2.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar2.ProgressColor = Color.LimeGreen
        ElseIf daysLeft1 < 0 Then
            daysLeft1 = 0
            Label2.Text = targetDate & " " & daysLeft1 & " Days Left"
            Guna2CircleProgressBar2.Value = 100
            Guna2CircleProgressBar2.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar2.ProgressColor = Color.LimeGreen
        End If


        If daysLeft2 >= 10 Then
            Guna2CircleProgressBar3.Value = 10
        ElseIf daysLeft2 >= 6 Then
            Guna2CircleProgressBar3.Value = 30
        ElseIf daysLeft2 >= 4 Then
            Guna2CircleProgressBar3.Value = 50
        ElseIf daysLeft2 >= 1 Then
            Guna2CircleProgressBar3.Value = 70
        ElseIf daysLeft2 >= 0 Then
            Guna2CircleProgressBar3.Value = 100
            Guna2CircleProgressBar3.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar3.ProgressColor = Color.LimeGreen
        ElseIf daysLeft2 < 0 Then
            daysLeft2 = 0
            Label3.Text = targetDate & " " & daysLeft2 & " Days Left"
            Guna2CircleProgressBar2.Value = 100
            Guna2CircleProgressBar2.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar2.ProgressColor = Color.LimeGreen
        End If

        If daysLeft3 >= 10 Then
            Guna2CircleProgressBar4.Value = 10
        ElseIf daysLeft3 >= 6 Then
            Guna2CircleProgressBar4.Value = 30
        ElseIf daysLeft3 >= 4 Then
            Guna2CircleProgressBar4.Value = 50
        ElseIf daysLeft3 >= 1 Then
            Guna2CircleProgressBar4.Value = 70
        ElseIf daysLeft3 >= 0 Then
            Guna2CircleProgressBar4.Value = 100
            Guna2CircleProgressBar4.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar4.ProgressColor = Color.LimeGreen
        ElseIf daysLeft3 < 0 Then
            daysLeft3 = 0
            Label4.Text = targetDate & " " & daysLeft3 & " Days Left"
            Guna2CircleProgressBar4.Value = 100
            Guna2CircleProgressBar4.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar4.ProgressColor = Color.LimeGreen

        End If

        If daysLeft4 >= 10 Then
            Guna2CircleProgressBar5.Value = 10
        ElseIf daysLeft4 >= 6 Then
            Guna2CircleProgressBar5.Value = 30
        ElseIf daysLeft4 >= 4 Then
            Guna2CircleProgressBar5.Value = 50
        ElseIf daysLeft4 >= 1 Then
            Guna2CircleProgressBar5.Value = 70
        ElseIf daysLeft4 >= 0 Then
            Guna2CircleProgressBar5.Value = 100
            Guna2CircleProgressBar5.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar5.ProgressColor = Color.LimeGreen
        ElseIf daysLeft4 < 0 Then
            daysLeft4 = 0
            Label5.Text = targetDate & " " & daysLeft4 & " Days Left"
            Guna2CircleProgressBar5.Value = 100
            Guna2CircleProgressBar5.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar5.ProgressColor = Color.LimeGreen
        End If


        If daysLeft5 >= 10 Then
            Guna2CircleProgressBar6.Value = 10
        ElseIf daysLeft5 >= 6 Then
            Guna2CircleProgressBar6.Value = 30
        ElseIf daysLeft5 >= 4 Then
            Guna2CircleProgressBar6.Value = 50
        ElseIf daysLeft5 >= 1 Then
            Guna2CircleProgressBar6.Value = 70
        ElseIf daysLeft5 >= 0 Then
            Guna2CircleProgressBar6.Value = 100
            Guna2CircleProgressBar6.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar6.ProgressColor = Color.LimeGreen
        ElseIf daysLeft5 < 0 Then
            daysLeft5 = 0
            Label6.Text = targetDate & " " & daysLeft5 & " Days Left"
            Guna2CircleProgressBar6.Value = 100
            Guna2CircleProgressBar6.ProgressColor = Color.LimeGreen
            Guna2CircleProgressBar6.ProgressColor = Color.LimeGreen
        End If



    End Sub


    Private Sub btnShow1_Click(sender As Object, e As EventArgs) Handles btnShow1.Click
        If Guna2CircleProgressBar1.Value = 100 Then
            txtVoucher1.Visible = True
        End If

    End Sub

    Private Sub btnShow2_Click(sender As Object, e As EventArgs) Handles btnShow2.Click
        If Guna2CircleProgressBar2.Value = 100 Then
            txtVoucher2.Visible = True
        End If
    End Sub

    Private Sub btnShow3_Click(sender As Object, e As EventArgs) Handles btnShow3.Click
        If Guna2CircleProgressBar3.Value = 100 Then
            txtVoucher3.Visible = True
        End If
    End Sub

    Private Sub btnShow4_Click(sender As Object, e As EventArgs) Handles btnShow4.Click
        If Guna2CircleProgressBar4.Value = 100 Then
            txtVoucher4.Visible = True
        End If
    End Sub

    Private Sub btnShow5_Click(sender As Object, e As EventArgs) Handles btnShow5.Click
        If Guna2CircleProgressBar5.Value = 100 Then
            txtVoucher5.Visible = True
        End If
    End Sub

    Private Sub btnShow6_Click(sender As Object, e As EventArgs) Handles btnShow6.Click
        If Guna2CircleProgressBar6.Value = 100 Then
            txtVoucher6.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = currdate & " " & DateTime.Now.ToString("hh:mm:ss tt")
    End Sub


End Class