Imports System.Drawing.Text
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmShop
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = DateAndTime.Now
    End Sub
    Function loadcartcount()
        conn.Close()
        Dim query, cartcount As String
        query = "select count(*) from cart where customer_id='" & customID & "'"
        Dim cm As New MySqlCommand
        Dim cm2 As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        cartcount = cm.ExecuteScalar()
        conn.Close()
        lblCartCount.Text = cartcount
        frmCart.lblCartCount.Text = lblCartCount.Text
        If lblCartCount.Text = 0 Then
            txtCart.Enabled = False
        Else
            txtCart.Enabled = True
        End If
    End Function



    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        loadRecord()
        prodOverview()
        loadcartcount()
        If lblCartCount.Text = 0 Then
            txtCart.Enabled = False
        Else
            txtCart.Enabled = True
        End If
    End Sub


    Sub loadRecord()
        Dim cm As New MySqlCommand
        dgvShop.Rows.Clear()
        cm = New MySqlCommand("Select * from product where Product_Name like '%" & txtSearch.Text & "%'", conn)
        dr = cm.ExecuteReader

        While dr.Read
            dgvShop.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString, dr.Item("Description").ToString, dr.Item("Price"), dr.Item("Stock").ToString, dr.Item("Category_ID").ToString, dr.Item("Category_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvShop.Rows.Count - 1
            Dim r As DataGridViewRow = dgvShop.Rows(i)
            r.Height = 70
        Next

        Dim imagecolumn = DirectCast(dgvShop.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom

    End Sub



    Private Sub dgvShop_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShop.CellContentClick
        Dim colName As String = dgvShop.Columns(e.ColumnIndex).Name
        Try
            If colName = "Details" Then
                MessageBox.Show("Product Details is clicked!", "DELAROTA PRODUCT INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmProduct.txtProdId.Text = dgvShop.CurrentRow.Cells(0).Value.ToString()
                'retrieving the image from the datagrid'
                Dim data As Byte() = DirectCast(dgvShop.CurrentRow.Cells(1).Value, Byte())
                Dim ms As New MemoryStream(data)
                frmProduct.picProdImg.Image = Image.FromStream(ms)
                frmProduct.lblCode.Text = "ITEM CODE: " & dgvShop.CurrentRow.Cells(2).Value.ToString()
                frmProduct.lblProdName.Text = dgvShop.CurrentRow.Cells(3).Value.ToString()
                frmProduct.txtDesc.Text = dgvShop.CurrentRow.Cells(4).Value.ToString()
                frmProduct.txtPrice.Text = dgvShop.CurrentRow.Cells(5).Value.ToString()
                frmProduct.txtStock.Text = dgvShop.CurrentRow.Cells(6).Value.ToString()
                frmProduct.lblCategory.Text = dgvShop.CurrentRow.Cells(7).Value.ToString()
                frmProduct.lblCateg.Text = "CATEGORY NAME: " & dgvShop.CurrentRow.Cells(8).Value.ToString()
                frmProduct.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("VIEWING PRODUCT ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles txtCart.Click
        frmCart.Show()
        frmCart.lblCartCount.Text = lblCartCount.Text
        conn.Open()
        loadRecord()
        loadcartcount()
        frmCart.loadRecord()
        frmCart.loadCart()
    End Sub



    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        cmbAcc.Text = Nothing
        cmbKids.Text = Nothing
        cmbMen.Text = Nothing
        cmbWomen.Text = Nothing
        conn.Open()
        loadRecord()

    End Sub

    Private Sub dgvShop_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvShop.CellMouseMove

        prodOverview()


    End Sub

    Function prodOverview()
        Dim img As Byte() = DirectCast(dgvShop.CurrentRow.Cells(1).Value, Byte())
        Dim msimg As New MemoryStream(img)
        picProd.Image = Image.FromStream(msimg)
        txtProdDesc.Text = dgvShop.CurrentRow.Cells(4).Value.ToString()
        txtProdName.Text = dgvShop.CurrentRow.Cells(3).Value.ToString()
    End Function

    Private Sub dgvShop_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShop.CellContentDoubleClick
        Try
            MessageBox.Show("Product Details is clicked!", "DELAROTA PRODUCT INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmProduct.txtProdId.Text = dgvShop.CurrentRow.Cells(0).Value.ToString()
            'retrieving the image from the datagrid'
            Dim data As Byte() = DirectCast(dgvShop.CurrentRow.Cells(1).Value, Byte())
            Dim ms As New MemoryStream(data)
            frmProduct.picProdImg.Image = Image.FromStream(ms)
            frmProduct.lblCode.Text = "ITEM CODE: " & dgvShop.CurrentRow.Cells(2).Value.ToString()
            frmProduct.lblProdName.Text = dgvShop.CurrentRow.Cells(3).Value.ToString()
            frmProduct.txtDesc.Text = dgvShop.CurrentRow.Cells(4).Value.ToString()
            frmProduct.txtPrice.Text = dgvShop.CurrentRow.Cells(5).Value.ToString()
            frmProduct.txtStock.Text = dgvShop.CurrentRow.Cells(6).Value.ToString()
            frmProduct.lblCategory.Text = dgvShop.CurrentRow.Cells(7).Value.ToString()
            frmProduct.lblCateg.Text = "CATEGORY NAME: " & dgvShop.CurrentRow.Cells(8).Value.ToString()
            frmProduct.Show()
        Catch ex As Exception
            MessageBox.Show("VIEWING PRODUCT ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        frmHistory.Show()
    End Sub

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        conn.Open()
        loadRecord()
    End Sub

    Private Sub cmbMen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMen.SelectedIndexChanged
        cmbAcc.SelectedIndex = -1
        cmbKids.SelectedIndex = -1
        cmbWomen.SelectedIndex = -1
        Dim cm As New MySqlCommand
        dgvShop.Rows.Clear()
        conn.Open()
        cm = New MySqlCommand("Select * from product where Item_Code like '%" & cmbMen.Text & "%' AND category_id=1234001", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvShop.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString, dr.Item("Description").ToString, dr.Item("Price"), dr.Item("Stock").ToString, dr.Item("Category_ID").ToString, dr.Item("Category_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvShop.Rows.Count - 1
            Dim r As DataGridViewRow = dgvShop.Rows(i)
            r.Height = 70
        Next

        Dim imagecolumn = DirectCast(dgvShop.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
    End Sub

    Private Sub cmbWomen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWomen.SelectedIndexChanged
        cmbAcc.SelectedIndex = -1
        cmbKids.SelectedIndex = -1
        cmbMen.SelectedIndex = -1
        Dim cm As New MySqlCommand
        dgvShop.Rows.Clear()
        conn.Open()
        cm = New MySqlCommand("Select * from product where Item_Code like '%" & cmbWomen.Text & "%' AND category_id=1234002", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvShop.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString, dr.Item("Description").ToString, dr.Item("Price"), dr.Item("Stock").ToString, dr.Item("Category_ID").ToString, dr.Item("Category_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvShop.Rows.Count - 1
            Dim r As DataGridViewRow = dgvShop.Rows(i)
            r.Height = 70
        Next

        Dim imagecolumn = DirectCast(dgvShop.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
    End Sub

    Private Sub cmbKids_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKids.SelectedIndexChanged
        cmbAcc.SelectedIndex = -1
        cmbWomen.SelectedIndex = -1
        cmbMen.SelectedIndex = -1
        Dim cm As New MySqlCommand
        dgvShop.Rows.Clear()
        conn.Open()
        cm = New MySqlCommand("Select * from product where Item_Code like '%" & cmbKids.Text & "%' AND category_id=1234003", conn)


        dr = cm.ExecuteReader
        While dr.Read
            dgvShop.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString, dr.Item("Description").ToString, dr.Item("Price"), dr.Item("Stock").ToString, dr.Item("Category_ID").ToString, dr.Item("Category_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvShop.Rows.Count - 1
            Dim r As DataGridViewRow = dgvShop.Rows(i)
            r.Height = 70
        Next

        Dim imagecolumn = DirectCast(dgvShop.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
    End Sub

    Private Sub cmbAcc_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbAcc.SelectedIndexChanged
        cmbWomen.SelectedIndex = -1
        cmbKids.SelectedIndex = -1
        cmbMen.SelectedIndex = -1
        Dim cm As New MySqlCommand
        dgvShop.Rows.Clear()
        conn.Open()
        cm = New MySqlCommand("Select * from product where Product_Name like '%" & cmbAcc.Text & "%' AND category_id=1234004", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvShop.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString, dr.Item("Description").ToString, dr.Item("Price"), dr.Item("Stock").ToString, dr.Item("Category_ID").ToString, dr.Item("Category_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvShop.Rows.Count - 1
            Dim r As DataGridViewRow = dgvShop.Rows(i)
            r.Height = 70
        Next

        Dim imagecolumn = DirectCast(dgvShop.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub


End Class