Imports DevComponents.AdvTree
Imports DevComponents.Editors
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmProductDetails
    Dim id, categ

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*PNG;*.GIF)|*.jpg;*.png;*.gif*"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            picProdImg.Image = Image.FromFile(opf.FileName)
        End If
    End Sub




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If lblAction.Text = "INSERT RECORDS" Then
            addrecords()
        ElseIf lblAction.Text = "UPDATE RECORDS" Then
            updaterecords()
        End If
    End Sub

    Sub addrecords()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select category_name from category where category_id ='" & cmbCateg.Text & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            categ = reader.GetString("category_name")
        End While
        conn.Close()

        Dim ms As New MemoryStream
        picProdImg.Image.Save(ms, picProdImg.Image.RawFormat)
        Dim command As New MySqlCommand("INSERT INTO product VALUES(@Product_ID,@Item_Code,@Product_Image,@Product_Name,@Description,@Price,@Stock,@Category_ID,@Category_Name)", conn)
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Product_ID", 0)
            .Parameters.AddWithValue("@Item_Code", txtItem.Text)
            .Parameters.AddWithValue("@Product_Image", ms.ToArray())
            .Parameters.AddWithValue("@Product_Name", txtProdName.Text)
            .Parameters.AddWithValue("@Description", txtDesc.Text)
            .Parameters.AddWithValue("@Price", txtPrice.Text)
            .Parameters.AddWithValue("@Stock", "")
            .Parameters.AddWithValue("@Category_ID", cmbCateg.Text)
            .Parameters.AddWithValue("@Category_Name", categ)
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Inserted")
            frmManage.loadRecord()
            txtDesc.Clear()
            txtItem.Clear()
            txtPrice.Clear()
            txtProdName.Clear()
            cmbCateg.Text = Nothing
            picProdImg.Image = Nothing
        Else
            MessageBox.Show("Record not Inserted")
        End If
        conn.Close()
        Me.Hide()

    End Sub


    Sub updaterecords()

        If cmbCateg.Text = "" Then
            MessageBox.Show("Please enter a category ID....")
            Exit Sub

        End If

        Dim categId As New Integer
        categId = frmManage.dgvProduct.CurrentRow.Cells(7).Value.ToString()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select category_name from category where category_id ='" & cmbCateg.Text & "'"
        Dim comm As New MySqlCommand
        comm = New MySqlCommand(query, conn)
        conn.Open()
        reader = comm.ExecuteReader
        While reader.Read
            categ = reader.GetString("category_name")
        End While
        conn.Close()

        Dim ms As New MemoryStream
        Dim cm As New MySqlCommand
        cm = New MySqlCommand("UPDATE product SET Product_ID=@ProdID,Item_Code = @Item,Product_Image =@ProdImg, Product_Name=@ProdName,Description=@Desc,Price=@Price,Stock=@Stock, Category_ID=@CategID, Category_Name=@CategName WHERE Product_ID = @ProdID", conn)

        'cm.Parameters.Add("@Product_ID", MySqlDbType.Int64).Value = prodId
        'cm.Parameters.Add("@Product_Image", MySqlDbType.LongBlob).Value = ms.ToArray()
        'cm.Parameters.Add("@Product_Name", MySqlDbType.VarChar).Value = txtProdName.Text
        'cm.Parameters.Add("@Description", MySqlDbType.VarChar).Value = txtDesc.Text
        'cm.Parameters.Add("@Price", MySqlDbType.Double).Value = txtPrice.Text
        'cm.Parameters.Add("@Stock", MySqlDbType.Int64).Value = txtStock.Text
        'cm.Parameters.Add("@Category_ID", MySqlDbType.Int64).Value = txtCateg.Text
        picProdImg.Image.Save(ms, picProdImg.Image.RawFormat)
        Dim prodId As New Integer
        prodId = frmManage.dgvProduct.CurrentRow.Cells(0).Value.ToString()
        With cm
            .Parameters.Clear()
            .Parameters.AddWithValue("@ProdID", prodId)
            .Parameters.AddWithValue("@Item", txtItem.Text)
            .Parameters.AddWithValue("@ProdImg", ms.ToArray())
            .Parameters.AddWithValue("@ProdName", txtProdName.Text)
            .Parameters.AddWithValue("@Desc", txtDesc.Text)
            .Parameters.AddWithValue("@Price", txtPrice.Text)
            .Parameters.AddWithValue("@Stock", "")
            .Parameters.AddWithValue("@CategID", cmbCateg.Text)
            .Parameters.AddWithValue("@CategName", categ)
        End With

        conn.Open()
        If cm.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Updated")
            frmManage.loadRecord()
        Else
            MessageBox.Show("Record not Updated")
        End If
        conn.Close()

        Me.Hide()

    End Sub



    Private Sub frmProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conn.ConnectionString = "server = localhost;user id=root; port = 3306;password=root;database=ecommercedb1"
        'conn.Open()
        connect()

        Dim names As String()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from category"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        'conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            id = reader.GetString("category_id")
            cmbCateg.Items.Add(id)
        End While
        conn.Close()





    End Sub

    'Private Sub cmbCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCateg.SelectedIndexChanged
    '    If cmbCateg.SelectedIndex = 0 Then
    '        lblCateg.Text = "Hats "
    '    ElseIf cmbCateg.SelectedIndex = 1 Then
    '        lblCateg.Text = "Shoes"
    '    ElseIf cmbCateg.SelectedIndex = 2 Then
    '        lblCateg.Text = "Clothes"
    '    End If
    'End Sub
End Class