Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class frmPrint
    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadprint()
    End Sub

    Sub loadprint()
        connect()
        Dim cm As New MySqlCommand
        dgvPrint.Rows.Clear()
        cm = New MySqlCommand("Select * from product_history where Order_ID ='" & frmHistory.DgvHistory.CurrentRow.Cells(2).Value.ToString & "'", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvPrint.Rows.Add(dr.Item("Product_ID"), dr.Item("Product_Name"), dr.Item("Product_Quantity").ToString, dr.Item("Amount").ToString)
        End While
        dr.Close()
        conn.Close()
        For i = 0 To dgvPrint.Rows.Count - 1
            Dim r As DataGridViewRow = dgvPrint.Rows(i)
            r.Height = 60
        Next
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
        e.Graphics.DrawString("Customer ID:" & customID & "            Order ID: " & frmHistory.DgvHistory.CurrentRow.Cells(2).Value, f8, Brushes.Black, info, center)

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
        e.Graphics.DrawString("Total Amount", f8ab, Brushes.Black, rect7, center)



        Dim y As Integer = 93
        Dim overallamt As Double

        For i = 0 To dgvPrint.Rows.Count - 1
            Dim rect8 As New Rectangle(5, y, 60, 23)
            Dim rect9 As New Rectangle(65, y, 60, 23)
            Dim rect10 As New Rectangle(125, y, 60, 23)
            Dim rect11 As New Rectangle(185, y, 60, 23)
            Dim total As Double = dgvPrint.Rows(i).Cells(2).Value * dgvPrint.Rows(i).Cells(3).Value

            e.Graphics.DrawRectangle(Pens.Black, rect8)
            e.Graphics.DrawRectangle(Pens.Black, rect9)
            e.Graphics.DrawRectangle(Pens.Black, rect10)
            e.Graphics.DrawRectangle(Pens.Black, rect11)

            e.Graphics.DrawString(dgvPrint.Rows(i).Cells(1).Value, prodName, Brushes.Black, rect8, center)
            e.Graphics.DrawString(FormatNumber(dgvPrint.Rows(i).Cells(2).Value, 2), f8, Brushes.Black, rect9, center)
            e.Graphics.DrawString(FormatNumber(dgvPrint.Rows(i).Cells(3).Value, 2), f8, Brushes.Black, rect10, center)
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
        e.Graphics.DrawString("Amount with VAT/Fees ", f8bb, Brushes.Black, rect14, center)

        Dim rect15 As New Rectangle(185, y + 12, 60, 12)
        e.Graphics.DrawRectangle(Pens.Black, rect15)
        e.Graphics.DrawString(FormatNumber(frmHistory.DgvHistory.CurrentRow.Cells(4).Value, 2), f8bb, Brushes.Black, rect15, center)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Doc.DefaultPageSettings.PaperSize = New PaperSize("Mysize", 250, 350)
        PPD.PrintPreviewControl.Zoom = 2.5
        PPD.Document = Doc
        PPD.ShowDialog()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Hide()

    End Sub
End Class