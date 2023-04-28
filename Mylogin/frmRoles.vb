Imports MySql.Data.MySqlClient

Public Class frmRoles
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()


    End Sub





    Sub loadcustomer()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select Customer_id as'Customer ID', First_Name as 'First Name', Last_Name as'Last Name' , Customer_Username as'Username', Customer_Password as'Password', Email as'Email', Phone_Number as 'Phone Number', Street_Address as 'Street Address', Barangay as 'Barangay', City as 'City', Region as 'Region',  Gender as 'Gender', Date_Of_Birth as 'Date of Birth' from customer", conn)

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvRoles.RowTemplate.Height = 70
        DgvRoles.DataSource = table
        conn.Close()

    End Sub

    Sub loadSupplier()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select Supplier_id as'Supplier ID', First_Name as 'First Name', Last_Name as'Last Name' , Supplier_Username as'Supplier Username', Supplier_Password as'Password', Email as'Email', Phone_Number as 'Phone Number', Street_Address as 'Street Address', Barangay as 'Barangay', City as 'City', Region as 'Region',  Gender as 'Gender', Date_Of_Birth as 'Date of Birth' from supplier", conn)

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvRoles.RowTemplate.Height = 70
        DgvRoles.DataSource = table
        conn.Close()


    End Sub

    Sub loadAdmin()


    End Sub

    Private Sub Guna2ToggleSwitch3_CheckedChanged(sender As Object, e As EventArgs) Handles togCustomer.CheckedChanged
        If togCustomer.Checked = True Then
            loadcustomer()
            togSupplier.Enabled = False
            togAdmin.Enabled = False
        ElseIf togCustomer.Checked = False Then
            togSupplier.Enabled = True
            togAdmin.Enabled = True
            DgvRoles.DataSource.clear()
        End If
    End Sub

    Private Sub togSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles togSupplier.CheckedChanged
        If togSupplier.Checked = True Then
            loadSupplier()
            togCustomer.Enabled = False
            togAdmin.Enabled = False
        ElseIf togSupplier.Checked = False Then
            togCustomer.Enabled = True
            togAdmin.Enabled = True
            DgvRoles.DataSource.clear()

        End If
    End Sub


    Private Sub DgvRoles_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvRoles.MouseClick

        'txtFName.Text = DgvRoles.CurrentRow.Cells(0).Value.ToString()
        txtFName.Text = DgvRoles.CurrentRow.Cells(1).Value.ToString()
        txtLName.Text = DgvRoles.CurrentRow.Cells(2).Value.ToString()
        txtUsername.Text = DgvRoles.CurrentRow.Cells(3).Value.ToString()
        txtPass.Text = DgvRoles.CurrentRow.Cells(4).Value.ToString()
        txtEmail.Text = DgvRoles.CurrentRow.Cells(5).Value.ToString()
        txtPhoneNum.Text = DgvRoles.CurrentRow.Cells(6).Value.ToString()
        txtStreetAdd.Text = DgvRoles.CurrentRow.Cells(7).Value.ToString()
        txtBarangay.Text = DgvRoles.CurrentRow.Cells(8).Value.ToString()
        cmbCity.Text = DgvRoles.CurrentRow.Cells(9).Value.ToString()
        cmbRegion.Text = DgvRoles.CurrentRow.Cells(10).Value.ToString()
        cmbGender.Text = DgvRoles.CurrentRow.Cells(11).Value.ToString()
        dtpDOB.Value = DgvRoles.CurrentRow.Cells(12).Value

    End Sub


End Class