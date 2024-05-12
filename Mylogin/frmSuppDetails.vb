Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class frmSuppDetails
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        enable()
    End Sub

    Sub enable()
        txtBarangay.Enabled = True
        txtEmail.Enabled = True
        txtFName.Enabled = True
        txtLName.Enabled = True
        txtPass.Enabled = True
        txtPhoneNum.Enabled = True
        txtStreetAdd.Enabled = True
        txtUsername.Enabled = True
        cmbCity.Enabled = True
        cmbGender.Enabled = True
        cmbRegion.Enabled = True
        dtpDOB.Enabled = True
        btnBrowse.Enabled = True

    End Sub


    Sub disable()
        txtBarangay.Enabled = False
        txtEmail.Enabled = False
        txtFName.Enabled = False
        txtLName.Enabled = False
        txtPass.Enabled = False
        txtPhoneNum.Enabled = False
        txtStreetAdd.Enabled = False
        txtUsername.Enabled = False
        cmbCity.Enabled = False
        cmbGender.Enabled = False
        cmbRegion.Enabled = False
        dtpDOB.Enabled = False
        btnBrowse.Enabled = False

    End Sub

    Private Sub frmSuppDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'conn.ConnectionString = "server = localhost;user id=root; port = 3306;password=root;database=ecommercedb1"
        'conn.Open()

        connect()
        disable()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from supplier where supplier_id ='" & supplierID & "'"
        Dim comm As New MySqlCommand
        comm = New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        Dim imgByte() As Byte
        adapter.fill(table)

        imgbyte = table(0)(13)
        Dim ms As New MemoryStream(imgByte)
        reader = comm.ExecuteReader
        While reader.Read
            Dim Fname = reader.GetString("First_Name")
            Dim Lname = reader.GetString("Last_Name")
            Dim Username = reader.GetString("Supplier_Username")
            Dim Password = reader.GetString("Supplier_Password")
            Dim Email = reader.GetString("Email")
            Dim Phone = reader.GetString("Phone_Number")
            Dim Street = reader.GetString("Street_Address")
            Dim Barangay = reader.GetString("Barangay")
            Dim City = reader.GetString("City")
            Dim Region = reader.GetString("Region")
            Dim Gender = reader.GetString("Gender")
            Dim DOB = reader.GetString("Date_Of_Birth")
            txtFName.Text = Fname
            txtLName.Text = Lname
            txtUsername.Text = Username
            txtPass.Text = Password
            txtEmail.Text = Email
            txtPhoneNum.Text = Phone
            txtStreetAdd.Text = Street
            txtBarangay.Text = Barangay
            cmbCity.Text = City
            cmbGender.Text = Gender
            cmbRegion.Text = Region
            dtpDOB.Value = DOB
            picSupplierImg.Image = Image.FromStream(ms)
        End While
        conn.Close()

        Dim regquery As String
        Dim readerreg As MySqlDataReader
        regquery = "select * from region"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(regquery, conn)
        conn.Open()
        readerreg = cm.ExecuteReader
        While readerreg.Read
            Dim reg = readerreg.GetString("Region_Name")
            cmbRegion.Items.Add(reg)
        End While
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        conn.Close()
        Dim ms As New MemoryStream
        Dim command As New MySqlCommand("Update supplier set First_Name=@Fname, Last_Name=@Lname, Supplier_Username=@Username, Supplier_Password =@Pass, Email=@Email,Phone_Number=@Phone, Street_Address=@Street, Barangay=@Barangay, City=@City, Region=@Region, Gender=@Gender,Date_Of_Birth =@DOB, Profile_Image=@ProfImage where supplier_id='" & supplierID & "'", conn)
        picSupplierImg.Image.Save(ms, picSupplierImg.Image.RawFormat)

        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Fname", txtFName.Text)
            .Parameters.AddWithValue("@Lname", txtLName.Text)
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .Parameters.AddWithValue("@Pass", txtPass.Text)
            .Parameters.AddWithValue("@Email", txtEmail.Text)
            .Parameters.AddWithValue("@Phone", txtPhoneNum.Text)
            .Parameters.AddWithValue("@Street", txtStreetAdd.Text)
            .Parameters.AddWithValue("@Barangay", txtBarangay.Text)
            .Parameters.AddWithValue("@City", cmbCity.Text)
            .Parameters.AddWithValue("@Region", cmbRegion.Text)
            .Parameters.AddWithValue("@Gender", cmbGender.Text)
            .Parameters.AddWithValue("@DOB", dtpDOB.Value)
            .Parameters.AddWithValue("@ProfImage", ms.ToArray())
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Updated Records")
            disable()
        Else
            MessageBox.Show("Record not Inserted")
        End If
        conn.Close()
    End Sub


    Sub readData(command As String)
        Dim reader As MySqlDataReader
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(command, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            Dim reg = reader.GetString("City_Name")
            cmbCity.Items.Add(reg)
        End While

    End Sub

    Private Sub cmbRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRegion.SelectedIndexChanged

        cmbCity.Items.Clear()
        conn.Close()

        If cmbRegion.Text = "Region 1 (Ilocos Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1001"
            'conn.Open()

            readData(query)

        ElseIf cmbRegion.Text = "Region 2 (Cagayan Valley)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1002"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 3 (Central Luzon)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1003"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 4A (CALABARZON)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1004"
            'conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 4B (MIMAROPA)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1005"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 5 (Bicol Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1006"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 6 (Western Visayas)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1007"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 7 (Central Visayas)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1008"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 8 (Eastern Visayas)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1009"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 9 (Zamboanga Peninsula)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1010"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 10 (Northern Mindanao)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1011"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 11 (Davao Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1012"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 12 (SOCCSKSARGEN)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1013"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 13 (Caraga Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1014"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "NCR (National Capital Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1015"
            'conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "CAR (Cordillera Administrative Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1016"
            ' conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "ARMM (Autonomous Region In Muslim Mindanao)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1017"
            ' conn.Open()
            readData(query)
        End If
        conn.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*PNG;*.GIF)|*.jpg;*.png;*.gif*"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            picSupplierImg.Image = Image.FromFile(opf.FileName)
        End If
    End Sub


End Class