Imports System.ComponentModel
Imports System.IO
Imports System.Security.AccessControl
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Guna.UI2.WinForms.Suite
Imports MySql.Data.MySqlClient

Public Class frmManage
    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' conn.ConnectionString = "server = localhost;user id=root; port = 3306;password=root;database=ecommercedb1"
        ' conn.Open()
        connect()
        loadRecord()
        Dim query, category As String
        Dim reader As MySqlDataReader
        query = "select * from category"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            category = reader.GetString("category_name")
            cmbCateg.Items.Add(category)

        End While
        conn.Close()
    End Sub


    Sub loadRecord()
        Dim cm As New MySqlCommand
        dgvProduct.Rows.Clear()
        'conn.Open()'
        cm = New MySqlCommand("Select * from product where Product_Name like '%" & txtSearch.Text & "%'", conn)

        dr = cm.ExecuteReader
        While dr.Read
            dgvProduct.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString, dr.Item("Description").ToString, dr.Item("Price"), dr.Item("Stock").ToString, dr.Item("Category_ID").ToString, dr.Item("Category_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvProduct.Rows.Count - 1
            Dim r As DataGridViewRow = dgvProduct.Rows(i)
            r.Height = 60
        Next

        Dim imagecolumn = DirectCast(dgvProduct.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Normal

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        conn.Open()
        loadRecord()

    End Sub



    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        Dim cm As New MySqlCommand
        Dim prodId As New Integer
        Dim colName As String = dgvProduct.Columns(e.ColumnIndex).Name
        If colName = "Delete" Then
            prodId = dgvProduct.CurrentRow.Cells(0).Value.ToString()
            cm = New MySqlCommand("DELETE FROM product WHERE Product_ID = @Product_ID", conn)
            cm.Parameters.Add("@Product_ID", MySqlDbType.Int64).Value = prodId

            conn.Open()
            If cm.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Deleted")
                loadRecord()
            Else
                MessageBox.Show("Error")
            End If
        End If
        If colName = "Update" Then
            frmProductDetails.lblID.Visible = True
            frmProductDetails.lblID.Text = "PRODUCT ID: " & dgvProduct.CurrentRow.Cells(0).Value.ToString()
            Dim data As Byte() = DirectCast(dgvProduct.CurrentRow.Cells(1).Value, Byte())
            Dim ms As New MemoryStream(data)
            frmProductDetails.picProdImg.Image = Image.FromStream(ms)
            frmProductDetails.txtItem.Text = dgvProduct.CurrentRow.Cells(2).Value.ToString()
            frmProductDetails.txtProdName.Text = dgvProduct.CurrentRow.Cells(3).Value.ToString()
            frmProductDetails.txtDesc.Text = dgvProduct.CurrentRow.Cells(4).Value.ToString()
            frmProductDetails.txtPrice.Text = dgvProduct.CurrentRow.Cells(5).Value.ToString()
            'frmProductDetails.txtStock.Text = dgvProduct.CurrentRow.Cells(6).Value.ToString()
            frmProductDetails.cmbCateg.Text = dgvProduct.CurrentRow.Cells(7).Value.ToString()
            frmProductDetails.lblCateg.Text = "CATEGORY: " & dgvProduct.CurrentRow.Cells(8).Value.ToString()
            frmProductDetails.lblAction.Text = "UPDATE RECORDS"
            frmProductDetails.Show()
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmProductDetails.lblID.Visible = False
        frmProductDetails.lblAction.Text = "INSERT RECORDS"
        frmProductDetails.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim cm As New MySqlCommand
        Dim prodId As New Integer
        Try
            prodId = InputBox("Enter the Product ID you want to delete...", "DELAROTA - Administration")
            cm = New MySqlCommand("DELETE FROM product WHERE Product_ID = @Product_ID", conn)
            cm.Parameters.Add("@Product_ID", MySqlDbType.Int64).Value = prodId
            conn.Open()
            If cm.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Deleted")
                loadRecord()
            Else
                MessageBox.Show("Error")
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        frmProductDetails.lblID.Visible = True
        frmProductDetails.lblID.Text = "PRODUCT ID: " & dgvProduct.CurrentRow.Cells(0).Value.ToString()
        'frmProduct.txtProdId.Text = dgvProduct.CurrentRow.Cells(0).Value.ToString()
        'retrieving the image from the datagrid'
        Dim data As Byte() = DirectCast(dgvProduct.CurrentRow.Cells(1).Value, Byte())
        Dim ms As New MemoryStream(data)
        frmProductDetails.picProdImg.Image = Image.FromStream(ms)
        frmProductDetails.txtItem.Text = dgvProduct.CurrentRow.Cells(2).Value.ToString()
        frmProductDetails.txtProdName.Text = dgvProduct.CurrentRow.Cells(3).Value.ToString()
        frmProductDetails.txtDesc.Text = dgvProduct.CurrentRow.Cells(4).Value.ToString()
        frmProductDetails.txtPrice.Text = dgvProduct.CurrentRow.Cells(5).Value.ToString()
        ' frmProductDetails.txtStock.Text = dgvProduct.CurrentRow.Cells(6).Value.ToString()
        frmProductDetails.cmbCateg.Text = dgvProduct.CurrentRow.Cells(7).Value.ToString()
        frmProductDetails.lblCateg.Text = "CATEGORY: " & dgvProduct.CurrentRow.Cells(8).Value.ToString()
        frmProductDetails.lblAction.Text = "UPDATE RECORDS"
        frmProductDetails.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCateg.SelectedIndexChanged
        connect()

        dgvProduct.Rows.Clear()
        Dim cm As New MySqlCommand
        If cmbCateg.Text = "All" Then
            cm = New MySqlCommand("Select * from product", conn)
        Else
            cm = New MySqlCommand("Select * from product where Category_Name like '%" & cmbCateg.Text & "%'", conn)
        End If


        dr = cm.ExecuteReader


        While dr.Read
            dgvProduct.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString, dr.Item("Description").ToString, dr.Item("Price"), dr.Item("Stock").ToString, dr.Item("Category_ID").ToString, dr.Item("Category_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvProduct.Rows.Count - 1
            Dim r As DataGridViewRow = dgvProduct.Rows(i)
            r.Height = 60
        Next
    End Sub
End Class