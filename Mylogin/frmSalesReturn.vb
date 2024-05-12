Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmSalesReturn
    Private Sub frmSalesReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadrecord()
    End Sub

    Sub loadrecord()
        conn.Close()

        Dim cm As New MySqlCommand
        DgvReturn.Rows.Clear()
        'conn.Open()'
        cm = New MySqlCommand("Select * from returnprod", conn)
        conn.Open()

        dr = cm.ExecuteReader
        While dr.Read
            DgvReturn.Rows.Add(dr.Item("Return_ID").ToString, dr.Item("Return_Reason"), dr.Item("Return_Proof"), dr.Item("Return_Status").ToString, dr.Item("Order_ID").ToString, dr.Item("Customer_ID").ToString, dr.Item("Product_ID").ToString, dr.Item("Return_Amount").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvReturn.Rows.Count - 1
            Dim r As DataGridViewRow = DgvReturn.Rows(i)
            r.Height = 70
        Next
        conn.Close()





    End Sub





    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        btnReturn.Enabled = False
        Try
            Dim query, query2, query3 As String
            Dim prodId As Integer
            cmd = New MySqlCommand
            'Dim prodId As Integer

            cmd.Connection = conn
            query = "Select*from product_history WHERE Order_ID = '" & DgvReturn.CurrentRow.Cells(4).Value & "' AND Customer_ID= '" & DgvReturn.CurrentRow.Cells(5).Value & "'"
            Dim dt = New DataTable()
            Dim da = New MySqlDataAdapter(query, conn)
            da.Fill(dt)
            Dim expense, profit As Integer
            Dim totalQuan As Integer
            Dim totalAmt As Double
            Dim amt As Integer
            Dim quan As Integer

            Dim reader As MySqlDataReader
            Dim Reader2 As MySqlDataReader
            Dim cm2 As MySqlCommand
            Dim cm3 As New MySqlCommand
            conn.Close()

            conn.Open()

            query2 = "select * from product_history where order_id='" & DgvReturn.CurrentRow.Cells(4).Value & "' and product_id='" & DgvReturn.CurrentRow.Cells(6).Value & "'"
            cm2 = New MySqlCommand(query2, conn)
            reader = cm2.ExecuteReader
            While reader.Read
                prodId = reader("Product_ID")
                quan = reader("Product_Quantity")
            End While
            conn.Close()


            query3 = "select * from sales_report where product_id='" & DgvReturn.CurrentRow.Cells(6).Value & "'"
            cm3 = New MySqlCommand(query3, conn)
            conn.Open()

            Reader2 = cm3.ExecuteReader
            While Reader2.Read
                totalQuan = Reader2("sales_volume")
                totalAmt = Reader2("sales_amount")
                expense = Reader2("sales_expenses")
            End While

            amt = DgvReturn.CurrentRow.Cells(7).Value
            totalQuan -= quan
            totalAmt -= amt


            If expense >= totalAmt Then
                profit = 0.00
            ElseIf expense < totalAmt Then
                profit = totalAmt - expense
            End If
            ' Next


            Dim Command3 As New MySqlCommand("UPDATE sales_report set Sales_Volume=@QtySold,Sales_Amount=@AmtSold , Sales_Profit = @Profit where Product_Id=@ProdID", conn)
            With Command3
                .Parameters.AddWithValue("@qtysold", totalQuan)
                .Parameters.AddWithValue("@amtsold", totalAmt)
                .Parameters.AddWithValue("@profit", profit)
                .Parameters.AddWithValue("@prodid", prodId)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            frmOrderHis.dashboard()
            conn.Close()


            Dim command4 As New MySqlCommand("UPDATE returnprod set Return_Status = @Status WHERE Return_id ='" & DgvReturn.CurrentRow.Cells(0).Value & "'AND Product_ID='" & DgvReturn.CurrentRow.Cells(6).Value & "'", conn)
            With command4
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "Returned")
            End With
            conn.Open()
            If command4.ExecuteNonQuery() = 1 Then
                MsgBox("Marked as Returned")
                loadrecord()

            Else
                MessageBox.Show("Product Not Returned")

            End If
            conn.Close()



            Dim accdetails As String
            Dim amount As Decimal
            ''PAYMENT
            Dim query4
            Dim reader4 As MySqlDataReader
            query4 = "select * from payment where order_id='" & lblOrder.Text & "'"
            Dim cm4 As New MySqlCommand
            cm4 = New MySqlCommand(query4, conn)
            conn.Open()
            reader4 = cm4.ExecuteReader
            While reader4.Read
                accdetails = reader4.GetString("Account_Details")
            End While
            conn.Close()

            Dim query5
            Dim reader5 As MySqlDataReader
            query5 = "select * from creditinfo where creditcard_no='" & accdetails & "'"
            Dim cm5 As New MySqlCommand
            cm5 = New MySqlCommand(query5, conn)
            conn.Open()
            reader5 = cm5.ExecuteReader
            While reader5.Read
                amount = reader5("amount")
            End While
            conn.Close()

            Dim command6 As New MySqlCommand("UPDATE creditinfo set amount=@amt WHERE creditcard_no='" & accdetails & "'", conn)
            With command6
                .Parameters.Clear()
                .Parameters.AddWithValue("@amt", Val(DgvReturn.CurrentRow.Cells(7).Value) + amount)
            End With
            conn.Open()
            If command6.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Payment Info Updated", "PAYMENT INFO MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Payment not Updated")

            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("MARK AS RETURN ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvReturn_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvReturn.CellMouseClick

        lblOrder.Text = DgvReturn.CurrentRow.Cells(4).Value
        Dim colName As String = DgvReturn.Columns(e.ColumnIndex).Name
        If colName = "returnprod" Then
            Dim data As Byte() = DirectCast(DgvReturn.CurrentRow.Cells(2).Value, Byte())
            Dim ms As New MemoryStream(data)
            frmManageReturnMenu.picProof.Image = Image.FromStream(ms)
            frmManageReturnMenu.txtReason.Text = DgvReturn.CurrentRow.Cells(1).Value
            frmManageReturnMenu.lblOrderID.Text = DgvReturn.CurrentRow.Cells(4).Value
            frmManageReturnMenu.lblCustomer.Text = DgvReturn.CurrentRow.Cells(5).Value
            frmManageReturnMenu.Show()
        End If

        If DgvReturn.CurrentRow.Cells(3).Value = "Approved" Then
            btnReturn.Enabled = True
        Else
            btnReturn.Enabled = False
        End If
    End Sub


End Class