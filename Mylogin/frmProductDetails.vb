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
        conn.Close()

        If lblAction.Text = "INSERT RECORDS" Then
            addrecords()
        ElseIf lblAction.Text = "UPDATE RECORDS" Then
            updaterecords()
        End If
    End Sub

    Sub addrecords()
        Try
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

            Dim query2 As String
            Dim reader2 As MySqlDataReader

            query2 = "select inventory_id from product where inventory_id = (Select max(inventory_id) from product)"
            Dim cm2 As New MySqlCommand
            cm2 = New MySqlCommand(query2, conn)
            conn.Open()
            Dim value = Convert.ToInt32(cm2.ExecuteScalar())
            conn.Close()

            Dim query3 As String
            Dim reader3 As MySqlDataReader

            query3 = "select product_id from inventory where product_id = (Select max(product_id) from inventory)"
            Dim cm3 As New MySqlCommand
            cm3 = New MySqlCommand(query3, conn)
            conn.Open()
            Dim value1 = Convert.ToInt32(cm3.ExecuteScalar())
            conn.Close()

            Dim ms As New MemoryStream
            picProdImg.Image.Save(ms, picProdImg.Image.RawFormat)
            Dim command As New MySqlCommand("INSERT INTO product(Product_ID,Item_Code,Product_Image,Product_Name,Description,Price,Stock,Category_ID,Category_Name,Inventory_ID)  VALUES(@Product_ID,@Item_Code,@Product_Image,@Product_Name,@Description,@Price,@Stock,@Category_ID,@Category_Name,@Inventory_ID)", conn)
            With command
                .Parameters.Clear()
                .Parameters.AddWithValue("@Product_ID", value1 + 1)
                .Parameters.AddWithValue("@Item_Code", txtItem.Text)
                .Parameters.AddWithValue("@Product_Image", ms.ToArray())
                .Parameters.AddWithValue("@Product_Name", txtProdName.Text)
                .Parameters.AddWithValue("@Description", txtDesc.Text)
                .Parameters.AddWithValue("@Price", txtPrice.Text)
                .Parameters.AddWithValue("@Stock", 50)
                .Parameters.AddWithValue("@Category_ID", cmbCateg.Text)
                .Parameters.AddWithValue("@Category_Name", categ)
                .Parameters.AddWithValue("@Inventory_ID", value + 1)
            End With
            conn.Open()

            Dim command2 As New MySqlCommand("INSERT INTO inventory VALUES(@Inventory_ID,@Product_ID,@Stock)", conn)
            With command2
                .Parameters.Clear()
                .Parameters.AddWithValue("@Inventory_ID", value + 1)
                .Parameters.AddWithValue("@Product_ID", value1 + 1)
                .Parameters.AddWithValue("@Stock", 50)
            End With

            Dim command3 As New MySqlCommand("INSERT INTO sales_report VALUES(@Report_ID,@Product_ID,@Product_Name,@Sales_Volume,@Sales_Amount,@Sales_Expenses,@Sales_Profit)", conn)
            With command3
                .Parameters.Clear()
                .Parameters.AddWithValue("@Report_ID", 0)
                .Parameters.AddWithValue("@Product_ID", value1 + 1)
                .Parameters.AddWithValue("@Product_Name", txtProdName.Text)
                .Parameters.AddWithValue("@Sales_Volume", 0.0)
                .Parameters.AddWithValue("@Sales_Amount", 0.0)
                .Parameters.AddWithValue("@Sales_Expenses", 23232.23)
                .Parameters.AddWithValue("@Sales_Profit", 0.0)
            End With


            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Product Added", "MANAGE ORDERS MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            conn.Open()
            command2.ExecuteNonQuery()
            command3.ExecuteNonQuery()
            conn.Close()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("ADDING RECORDS ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Sub updaterecords()
        Try
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
            cm = New MySqlCommand("UPDATE product SET Product_ID=@ProdID,Item_Code = @Item,Product_Image =@ProdImg, Product_Name=@ProdName,Description=@Desc,Price=@Price, Category_ID=@CategID, Category_Name=@CategName WHERE Product_ID = @ProdID", conn)


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
                .Parameters.AddWithValue("@CategID", cmbCateg.Text)
                .Parameters.AddWithValue("@CategName", categ)
            End With

            conn.Open()
            If cm.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Product Updated", "MANAGE ORDERS MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmManage.loadRecord()
            Else
                MessageBox.Show("Record not Updated")
            End If
            conn.Close()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("UPDATE RECORDS ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


End Class