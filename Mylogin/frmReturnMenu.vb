Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmReturnMenu
    Private Sub frmReturnMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblReturnAmt.Text = frmReturn.DgvReturn.CurrentRow.Cells(3).Value * frmReturn.DgvReturn.CurrentRow.Cells(2).Value
        lblCustomer.Text = customID
        lblOrderID.Text = frmReturn.DgvReturn.CurrentRow.Cells(5).Value.ToString()
        lblID.Text = frmReturn.lblID.Text
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*PNG;*.GIF)|*.jpg;*.png;*.gif*"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            picProof.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim ms As New MemoryStream
        picProof.Image.Save(ms, picProof.Image.RawFormat)
        Dim command As New MySqlCommand("INSERT INTO returnprod (Return_ID,Return_Reason,Return_Proof,Return_Status,Order_ID,Customer_ID,Product_ID, Return_Amount) VALUES(@Return_ID,@Return_Reason,@Return_Proof,@Return_Status,@Order_ID,@Customer_ID,@Product_ID, @Return_Amount)", conn)
        Dim status As String = "Pending"
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Return_ID", 0)
            .Parameters.AddWithValue("@Return_Reason", txtReason.Text)
            .Parameters.AddWithValue("@Return_Proof", ms.ToArray())
            .Parameters.AddWithValue("@Return_Status", status)
            .Parameters.AddWithValue("@Order_ID",  lblOrderID.Text)
            .Parameters.AddWithValue("@Customer_ID", customID)
            .Parameters.AddWithValue("@Product_ID", lblID.Text)
            .Parameters.AddWithValue("@Return_Amount", lblReturnAmt.Text)
        End With
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Success")
        Else
            MessageBox.Show("Record not Inserted")

        End If
        conn.Close()


    End Sub
End Class