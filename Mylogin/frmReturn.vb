Imports MySql.Data.MySqlClient

Public Class frmReturn


    Private Sub DgvInventory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvReturn.CellMouseClick


        lblID.Text = DgvReturn.CurrentRow.Cells(0).Value
        txtName.Text = DgvReturn.CurrentRow.Cells(1).Value
        lblQuantity.Text = DgvReturn.CurrentRow.Cells(2).Value
        lblAmount.Text = DgvReturn.CurrentRow.Cells(3).Value
        lblDateOrdered.Text = DgvReturn.CurrentRow.Cells(4).Value
        Dim orderID As Integer = DgvReturn.CurrentRow.Cells(5).Value


        '  Dim dateordered As Date =
        ' Dim address As String = 
        Dim query As String
        Dim reader As MySqlDataReader
        Dim receivingdate, deliveryadd, deliverymethod, deliverystatus
        query = "select * from delivery where Order_Id='" & orderID & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            receivingdate = reader.GetString("Delivery_Date")
            deliveryadd = reader.GetString("Delivery_Location")
            deliverymethod = reader.GetString("Delivery_Type")
            deliverystatus = reader.GetString("Order_Status")
        End While

        conn.Close()

        lblReceiving.Text = receivingdate
        txtAdd.Text = deliveryadd
        lblMethod.Text = deliverymethod
        lblStatus.Text = deliverystatus


        If lblMethod.Text = "Same-Day Shipping (Same Day)" Then
            circleProgBar.Value = 95
        End If


        If lblMethod.Text = "In-Store Pick-up" Then
            circleProgBar.Value = 100
        End If

        'lblDateOrdered

        If lblMethod.Text = "Standard Delivery (5-7 Days)" Then
            Dim dateord As Date = lblDateOrdered.Text
            Dim days As Single = Convert.ToInt32((dateord.AddDays(7) - currdate).TotalDays)

            If days <= 8 Then
                circleProgBar.Value = 10
            ElseIf days <= 6 Then
                circleProgBar.Value = 30
            ElseIf days <= 4 Then
                circleProgBar.Value = 60
            ElseIf days <= 2 Then
                circleProgBar.Value = 80
            ElseIf days <= 1 Then
                circleProgBar.Value = 95
            End If

            If lblStatus.Text = "Shipped" Then
                days = 2
                circleProgBar.Value = 65
                If days <= 2 Then
                    circleProgBar.Value = 84
                ElseIf days <= 1 Then
                    circleProgBar.Value = 95
                End If
            End If
        End If


        If lblMethod.Text = "Express Shipping (1-2 Days)" Then
            Dim dateord As Date = lblDateOrdered.Text
            Dim days As Single = Convert.ToInt32((dateord.AddDays(2) - currdate).TotalDays)

            If days <= 3 Then
                circleProgBar.Value = 30
            ElseIf days <= 2 Then
                circleProgBar.Value = 50
            ElseIf days <= 1 Then
                circleProgBar.Value = 98
            End If

            If lblStatus.Text = "Shipped" Then
                days = 2
                circleProgBar.Value = 55
                If days <= 1 Then
                    circleProgBar.Value = 95
                End If
            End If
        End If



        Dim query2 As String
        Dim reader2 As MySqlDataReader
        Dim orderAmt
        query2 = "select * from orderdetails where Order_Id='" & orderID & "'"
        Dim cm2 As New MySqlCommand
        cm2 = New MySqlCommand(query2, conn)
        conn.Open()
        reader2 = cm2.ExecuteReader
        While reader2.Read
            orderAmt = reader2.GetString("Total")

        End While

        conn.Close()
        lblOrderAmt.Text = orderAmt


        If lblStatus.Text = "Delivered" Or lblStatus.Text = "Returned" Then
            circleProgBar.ProgressColor = Color.LightGreen
            circleProgBar.ProgressColor2 = Color.SpringGreen
            progBar.ProgressColor = Color.LightGreen
            progBar.ProgressColor2 = Color.SpringGreen
            circleProgBar.Value = 100
        End If

        If lblStatus.Text = "Pending Order Return" Then
            circleProgBar.ProgressColor = Color.LightGreen
            circleProgBar.ProgressColor2 = Color.SpringGreen
            progBar.ProgressColor = Color.LightGreen
            progBar.ProgressColor2 = Color.SpringGreen
            circleProgBar.Value = 50
        End If


        If lblStatus.Text = "Shipped" Then
            circleProgBar.ProgressColor = Color.Yellow
            circleProgBar.ProgressColor2 = Color.Goldenrod
            progBar.ProgressColor = Color.Yellow
            progBar.ProgressColor2 = Color.Goldenrod
            circleProgBar.Value = 84
        End If


        If lblStatus.Text = "Pending" Then
            circleProgBar.ProgressColor = Color.Yellow
            circleProgBar.ProgressColor2 = Color.Goldenrod
            progBar.ProgressColor = Color.Yellow
            progBar.ProgressColor2 = Color.Goldenrod
            circleProgBar.Value = 10
        End If


        If lblStatus.Text = "Canceled" Then
            circleProgBar.Value = 0
            circleProgBar.ProgressColor = Color.IndianRed
            circleProgBar.ProgressColor2 = Color.Red
            progBar.ProgressColor = Color.Red
            progBar.ProgressColor2 = Color.IndianRed
        End If




    End Sub


    Sub loadrecord()
        btnReturn.Enabled = True
        conn.Close()
        Dim cm As New MySqlCommand
        DgvReturn.Rows.Clear()
        cm = New MySqlCommand("Select * from product_history where Customer_ID ='" & customID & "'", conn)
        conn.Open()
        dr = cm.ExecuteReader
        While dr.Read
            DgvReturn.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Name"), dr.Item("Product_Quantity").ToString, dr.Item("Amount").ToString, dr.Item("Order_Date"), dr.Item("Order_ID"))
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvReturn.Rows.Count - 1
            Dim r As DataGridViewRow = DgvReturn.Rows(i)
            r.Height = 40
        Next
    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrecord()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmHistory.Show()
    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If lblStatus.Text <> "Delivered" Then
            MessageBox.Show("Only Delivered Items may be returned with proof.", "RETURN PRODUCT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            frmReturnMenu.Show()
        End If
    End Sub
End Class