Imports System.Drawing.Printing
Imports System.Runtime.InteropServices.ComTypes
Imports System.Web.UI.WebControls
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class frmReceipt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Doc.DefaultPageSettings.PaperSize = New PaperSize("Mysize", 250, 350)
        PPD.PrintPreviewControl.Zoom = 2.5
        PPD.Document = Doc
        PPD.ShowDialog()

        'PPD.Document = Doc
        'PPD.ShowDialog()





    End Sub

    Private Sub Doc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Doc.PrintPage
        Dim f8 As New Font("Arial", 5, FontStyle.Regular)
        Dim f8ab As New Font("Arial", 5, FontStyle.Bold)
        Dim f8b As New Font("Verdana", 5, FontStyle.Regular)
        Dim f8bb As New Font("Verdana", 5, FontStyle.Bold)
        Dim prodName As New Font("Verdana", 3.5, FontStyle.Bold)

        Dim left As New StringFormat
        Dim center As New StringFormat
        Dim right As New StringFormat
        left.Alignment = StringAlignment.Near
        center.Alignment = StringAlignment.Center
        right.Alignment = StringAlignment.Far



        'Draw rectangles'
        Dim rect1 As New Rectangle(5, 5, 240, 17)
        Dim rect2 As New Rectangle(5, 22, 240, 17)
        Dim rect3 As New Rectangle(5, 39, 240, 17)
        Dim info As New Rectangle(5, 56, 240, 17)


        e.Graphics.DrawRectangle(Pens.Black, rect1)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect3)
        e.Graphics.DrawRectangle(Pens.Black, info)


        e.Graphics.DrawString("DELAROTA SPORTSWEWAR", f8, Brushes.Black, rect1, center)
        e.Graphics.DrawString("CUSTOMER ORDER RECEIPT", f8, Brushes.Black, rect2, center)
        e.Graphics.DrawString("0300-1234567" & "    " & currdatetime, f8, Brushes.Black, rect3, center)
        e.Graphics.DrawString("Customer ID:" & customID & "            Order ID: " & orderID, f8, Brushes.Black, info, center)

        Dim rect4 As New Rectangle(5, 76, 60, 17)
        Dim rect5 As New Rectangle(65, 76, 60, 17)
        Dim rect6 As New Rectangle(125, 76, 60, 17)
        Dim rect7 As New Rectangle(185, 76, 60, 17)


        e.Graphics.DrawRectangle(Pens.Black, rect4)
        e.Graphics.DrawRectangle(Pens.Black, rect5)
        e.Graphics.DrawRectangle(Pens.Black, rect6)
        e.Graphics.DrawRectangle(Pens.Black, rect7)

        e.Graphics.DrawString("Product name", f8ab, Brushes.Black, rect4, center)
        e.Graphics.DrawString("Quantity", f8ab, Brushes.Black, rect5, center)
        e.Graphics.DrawString("Price", f8ab, Brushes.Black, rect6, center)
        e.Graphics.DrawString("Sum ", f8ab, Brushes.Black, rect7, center)



        Dim y As Integer = 93
        Dim overallamt As Double

        For i = 0 To frmSummary.dgvSummary.Rows.Count - 1
            Dim rect8 As New Rectangle(5, y, 60, 23)
            Dim rect9 As New Rectangle(65, y, 60, 23)
            Dim rect10 As New Rectangle(125, y, 60, 23)
            Dim rect11 As New Rectangle(185, y, 60, 23)
            Dim total As Double = frmSummary.dgvSummary.Rows(i).Cells(3).Value * frmSummary.dgvSummary.Rows(i).Cells(4).Value

            e.Graphics.DrawRectangle(Pens.Black, rect8)
            e.Graphics.DrawRectangle(Pens.Black, rect9)
            e.Graphics.DrawRectangle(Pens.Black, rect10)
            e.Graphics.DrawRectangle(Pens.Black, rect11)

            e.Graphics.DrawString(frmSummary.dgvSummary.Rows(i).Cells(2).Value, prodName, Brushes.Black, rect8, center)
            e.Graphics.DrawString(FormatNumber(frmSummary.dgvSummary.Rows(i).Cells(3).Value, 2), f8, Brushes.Black, rect9, center)
            e.Graphics.DrawString(FormatNumber(frmSummary.dgvSummary.Rows(i).Cells(4).Value, 2), f8, Brushes.Black, rect10, center)
            e.Graphics.DrawString(total, f8, Brushes.Black, rect11, center)
            y += 23
            overallamt += total
        Next
        Dim rect12 As New Rectangle(5, y, 240, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect12)
        e.Graphics.DrawString("Subtotal ", f8bb, Brushes.Black, rect12, center)

        Dim rect13 As New Rectangle(185, y, 60, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect13)
        e.Graphics.DrawString(FormatNumber(overallamt, 2), f8bb, Brushes.Black, rect13, center)

        Dim rect14 As New Rectangle(5, y + 12, 240, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect14)
        e.Graphics.DrawString("Discount ", f8bb, Brushes.Black, rect14, center)

        Dim rect15 As New Rectangle(185, y + 12, 60, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect15)
        e.Graphics.DrawString(frmSummary.lblDisc.Text, f8bb, Brushes.Black, rect15, center)

        Dim rect16 As New Rectangle(5, y + 24, 240, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect16)
        e.Graphics.DrawString("Shipping ", f8bb, Brushes.Black, rect16, center)

        Dim rect17 As New Rectangle(185, y + 24, 60, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect17)
        e.Graphics.DrawString(frmSummary.lblShipping.Text, f8bb, Brushes.Black, rect17, center)

        Dim rect18 As New Rectangle(5, y + 36, 240, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect18)
        e.Graphics.DrawString("Total Vat ", f8bb, Brushes.Black, rect18, center)

        Dim rect19 As New Rectangle(185, y + 36, 60, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect19)
        e.Graphics.DrawString(frmPayment.txtVat.Text, f8bb, Brushes.Black, rect19, center)

        Dim rect20 As New Rectangle(5, y + 48, 240, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect20)
        e.Graphics.DrawString("Total Amount ", f8bb, Brushes.Black, rect20, center)

        Dim rect21 As New Rectangle(185, y + 48, 60, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect21)
        e.Graphics.DrawString(FormatNumber(frmSummary.lblTotal.Text, 2), f8bb, Brushes.Black, rect21, center)
    End Sub

    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("INSERT INTO payment VALUES(@Payment_ID,@Order_ID,@Payment_Method,@Payment_Amount,@Payment_Date,@Amount_Due)", conn)
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Payment_ID", 0)
            .Parameters.AddWithValue("@Order_ID", orderID)
            .Parameters.AddWithValue("@Payment_Method", frmPayment.cmbMethod.Text)
            .Parameters.AddWithValue("@Payment_Amount", frmPayment.txtCash.Text)
            .Parameters.AddWithValue("@Payment_Date", currdatetime)
            .Parameters.AddWithValue("@Amount_Due", CInt(frmPayment.txtAmtDue.Text))
        End With
        'conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Success")
        Else
            MessageBox.Show("Record not Inserted")

        End If
        conn.Close()

        Dim cm2 As New MySqlCommand
        cm2 = New MySqlCommand("UPDATE orderDetails SET Status=@Status where Order_ID='" & orderID & "'", conn)

        With cm2
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", "Shipped")
        End With
        conn.Open()
        If cm2.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Order Status Changed. Please check your order history..", "ORDER STATUS MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'frmManage.loadRecord()
            Me.Hide()
        Else
            MessageBox.Show("Record not Updated")
        End If
        conn.Close()

        Dim cartcom As New MySqlCommand
        conn.Close()
        cartcom = New MySqlCommand("truncate table cart", conn)
        conn.Open()
        cartcom.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Previous cart records deleted")

    End Sub
End Class