Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmReview
    Dim prod As String
    Sub loadrecord()

        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from product_history where Customer_ID='" & frmCustomMenu.lblID.Text & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            prod = reader.GetString("Product_ID")
            cmbProduct.Items.Add(reader.GetString("Order_Date") & " - " & prod)
        End While
        conn.Close()

    End Sub

    Private Sub frmReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrecord()
        txtCustomer.Text = customID
        lblDate.Text = currdate
    End Sub

    Private Sub gunabtnConfirm_Click(sender As Object, e As EventArgs) Handles gunabtnConfirm.Click

        If cmbProduct.Text = "" Then
            MessageBox.Show("Please add a product..", "REVIEW ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtSub.Text = "" Then
            MessageBox.Show("Please add a subject..", "REVIEW ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtMessage.Text = "" Then
            MessageBox.Show("Please add a message..", "REVIEW ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If rating.Value = 0 Then
            MessageBox.Show("Please add a rating..", "REVIEW ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If




        Dim ms As New MemoryStream
        Dim command As New MySqlCommand("INSERT INTO review VALUES(@Review_ID,@Customer_ID,@Product_ID,@Subject, @Rating,@Comment,@Review_Date)", conn)
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Review_ID", 0)
            .Parameters.AddWithValue("@Customer_ID", frmShop.lblCustomId.Text)
            .Parameters.AddWithValue("@Product_ID", prod)
            .Parameters.AddWithValue("@Subject", txtSub.Text)
            .Parameters.AddWithValue("@Rating", rating.Value)
            .Parameters.AddWithValue("@Comment", txtMessage.Text)
            .Parameters.AddWithValue("@Review_Date", currdate)

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