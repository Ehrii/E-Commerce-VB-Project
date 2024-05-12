Imports System.IO
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmRoles
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadRegion()


    End Sub

    Sub readData(command As String)
        Dim reader As MySqlDataReader
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(command, conn)
        reader = cm.ExecuteReader
        While reader.Read
            Dim reg = reader.GetString("City_Name")
            cmbCity.Items.Add(reg)
        End While
    End Sub




    Sub loadRegion()
        conn.Close()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from region"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            Dim reg = reader.GetString("Region_Name")
            cmbRegion.Items.Add(reg)
        End While
        conn.Close()
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
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select Admin_id as'Admin ID', First_Name as 'First Name', Last_Name as'Last Name' , Admin_Email as'Admin Email', Admin_Username as'Admin Username', Admin_Password as'Admin Password' from admin", conn)

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvRoles.RowTemplate.Height = 70
        DgvRoles.DataSource = table
        conn.Close()

    End Sub




    Private Sub togAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles togAdmin.CheckedChanged
        If togAdmin.Checked Then
            loadAdmin()

            togCustomer.Enabled = False
            togSupplier.Enabled = False
            txtBarangay.Enabled = False
            txtPhoneNum.Enabled = False
            txtStreetAdd.Enabled = False
            btnAdd.Enabled = False
            cmbCity.Enabled = False
            cmbGender.Enabled = False
            cmbRegion.Enabled = False
            picCustomImage.Enabled = False
            txtFName.Enabled = True
            txtLName.Enabled = True
            txtPass.Enabled = True
            txtUsername.Enabled = True
            txtPass.Enabled = True
            btnAdd.Visible = False
            dtpDOB.Enabled = False
            txtEmail.Enabled = False
            btnAdd.Enabled = False
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            picCustomImage.Image = Nothing

        ElseIf togAdmin.Checked = False Then
            txtBarangay.Enabled = True
            txtPhoneNum.Enabled = True
            txtStreetAdd.Enabled = True
            cmbCity.Enabled = True
            cmbGender.Enabled = True
            cmbRegion.Enabled = True
            picCustomImage.Enabled = True
            txtFName.Enabled = True
            txtLName.Enabled = True
            dtpDOB.Enabled = True
            txtEmail.Enabled = True
            btnAdd.Enabled = True
            txtPass.Enabled = True
            txtUsername.Enabled = True
            txtPass.Enabled = True
            togCustomer.Enabled = True
            togSupplier.Enabled = True
            clearAll()

            DgvRoles.DataSource.clear()
        End If
    End Sub



    Private Sub DgvRoles_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvRoles.MouseClick

        If togAdmin.Checked Then
            txtFName.Text = DgvRoles.CurrentRow.Cells(1).Value
            txtLName.Text = DgvRoles.CurrentRow.Cells(2).Value
            txtUsername.Text = DgvRoles.CurrentRow.Cells(4).Value
            txtPass.Text = DgvRoles.CurrentRow.Cells(5).Value
            txtEmail.Text = DgvRoles.CurrentRow.Cells(3).Value
        Else
            txtFName.Text = DgvRoles.CurrentRow.Cells(1).Value
            txtLName.Text = DgvRoles.CurrentRow.Cells(2).Value
            txtUsername.Text = DgvRoles.CurrentRow.Cells(3).Value
            txtPass.Text = DgvRoles.CurrentRow.Cells(4).Value
            txtEmail.Text = DgvRoles.CurrentRow.Cells(5).Value
            txtPhoneNum.Text = DgvRoles.CurrentRow.Cells(6).Value
            txtStreetAdd.Text = DgvRoles.CurrentRow.Cells(7).Value
            txtBarangay.Text = DgvRoles.CurrentRow.Cells(8).Value
            cmbCity.Text = DgvRoles.CurrentRow.Cells(9).Value
            cmbRegion.Text = DgvRoles.CurrentRow.Cells(10).Value
            cmbGender.Text = DgvRoles.CurrentRow.Cells(11).Value
            dtpDOB.Value = DgvRoles.CurrentRow.Cells(12).Value

        End If




        If togCustomer.Checked Then
            Dim query As String
            Dim reader As MySqlDataReader
            query = "Select * from customer where email='" & DgvRoles.CurrentRow.Cells(5).Value.ToString() & "'"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            conn.Open()
            reader = cm.ExecuteReader
            While reader.Read
                Dim imageBytes As Byte() = DirectCast(reader("Profile_Image"), Byte())
                Dim stream As New MemoryStream(imageBytes)
                Dim image As Image = Image.FromStream(stream)
                picCustomImage.Image = image
            End While
            conn.Close()



        ElseIf togSupplier.Checked Then
            Dim query As String
            Dim reader As MySqlDataReader
            query = "Select * from supplier where email='" & DgvRoles.CurrentRow.Cells(5).Value.ToString() & "'"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            conn.Open()
            reader = cm.ExecuteReader
            While reader.Read
                Dim imageBytes As Byte() = DirectCast(reader("Profile_Image"), Byte())
                Dim stream As New MemoryStream(imageBytes)
                Dim image As Image = Image.FromStream(stream)
                picCustomImage.Image = image
            End While
            conn.Close()
        End If



    End Sub
    Sub enable()
        txtFName.Enabled = True
        txtLName.Enabled = True
        txtUsername.Enabled = True
        txtPass.Enabled = True
        txtEmail.Enabled = True
        txtPhoneNum.Enabled = True
        txtStreetAdd.Enabled = True
        txtBarangay.Enabled = True
        cmbCity.Enabled = True
        cmbRegion.Enabled = True
        cmbGender.Enabled = True
        dtpDOB.Enabled = True
    End Sub

    Sub disable()
        txtFName.Enabled = False
        txtLName.Enabled = False
        txtUsername.Enabled = False
        txtPass.Enabled = False
        txtEmail.Enabled = False
        txtPhoneNum.Enabled = False
        txtStreetAdd.Enabled = False
        txtBarangay.Enabled = False
        cmbCity.Enabled = False
        cmbRegion.Enabled = False
        cmbGender.Enabled = False
        dtpDOB.Enabled = False
    End Sub


    Private Sub cmbRegion_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbRegion.SelectedIndexChanged
        conn.Close()

        cmbCity.Items.Clear()
        If cmbRegion.Text = "Region 1 (Ilocos Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1001"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 2 (Cagayan Valley)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1002"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 3 (Central Luzon)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1003"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 4A (CALABARZON)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1004"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 4B (MIMAROPA)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1005"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 5 (Bicol Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1006"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 6 (Western Visayas)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1007"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 7 (Central Visayas)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1008"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 8 (Eastern Visayas)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1009"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 9 (Zamboanga Peninsula)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1010"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 10 (Northern Mindanao)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1011"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 11 (Davao Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1012"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 12 (SOCCSKSARGEN)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1013"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "Region 13 (Caraga Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1014"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "NCR (National Capital Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1015"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "CAR (Cordillera Administrative Region)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1016"
            conn.Open()
            readData(query)

        ElseIf cmbRegion.Text = "ARMM (Autonomous Region In Muslim Mindanao)" Then
            Dim query As String
            query = "Select * from city where Region_ID = 1017"
            conn.Open()
            readData(query)
        End If
        conn.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        enable()
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        disable()
        btnAdd.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtPass.Text <> "" Then
            If txtPass.TextLength > 10 Then
                lblPass.Text = "Password Is strong."
                lblPass.ForeColor = System.Drawing.Color.LightGreen

            ElseIf txtPass.TextLength >= 8 Then
                lblPass.Text = "Password Is average."
                lblPass.ForeColor = System.Drawing.Color.LightYellow

            Else
                lblPass.Text = "Password Is weak."
                lblPass.ForeColor = System.Drawing.Color.IndianRed
            End If
            lblPass.Visible = True
        Else
            lblPass.Visible = False
        End If
    End Sub


    Function isValidEmail(ByVal email As String) As Boolean
        Dim validEmail As Boolean = True
        Try
            Dim emailCheck = New System.Net.Mail.MailAddress(email)

        Catch ex As Exception
            validEmail = False
        End Try
        Return validEmail And Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@yahoo\.(com|com\.[a-z]{2}|[a-z]{2}\.[a-z]{2})$") Or Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@gmail\.com$")
    End Function

    Function valPhoneNumber(ByVal phoneNum As String) As Boolean
        Return phoneNum(0) = "0" And phoneNum(1) = "9" And phoneNum.Length = 11 And Regex.IsMatch(phoneNum, "^[0-9]+$")
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
                ''EMAIL
                If isValidEmail(txtEmail.Text) = False Then
                    MessageBox.Show("Invalid Email.Please try again ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ''PHONE NUMBER

                Try
                    If valPhoneNumber(txtPhoneNum.Text) = False Then
                        MessageBox.Show("Invalid Phone Number. Please try again ", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("Phone Number Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


                'DOB
                Dim dateOfBirth As Date = dtpDOB.Value
                Dim age As TimeSpan = DateTime.Now - dateOfBirth
                Dim ageInYears As Integer = CInt(Math.Floor(age.TotalDays / 365.25)) ' calculate age in years

                If ageInYears < 18 Then
                    MessageBox.Show("18 Below not valid", "Age Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If ageInYears > 64 Then
                    MessageBox.Show("Maximum age limit reaced ", "Age Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ''PASSWORD
                If ValidatePassword(txtPass.Text) = False Then
                    MessageBox.Show("Password must have 8-10 characters long with at least one numeric character and uppercase, lowercase and special characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


            If (txtFName.Text = Nothing Or txtLName.Text = Nothing Or cmbGender.Text = Nothing Or
                 txtBarangay.Text = Nothing Or txtEmail.Text = Nothing Or cmbCity.Text = Nothing Or
                 cmbRegion.Text = Nothing Or txtPhoneNum.Text = Nothing Or txtStreetAdd.Text = Nothing Or txtPass.Text = Nothing Or dtpDOB.Text = Nothing Or txtUsername.Text = Nothing Or cmbRegion.Text = Nothing) Then
                Dim msg, newStr As String
                msg = ""

                MessageBox.Show("Incomplete Credentials", "DELAROTA Account Creation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If txtFName.Text = "" Then
                    msg = msg + " First Name,"
                End If
                If txtLName.Text = "" Then
                    msg = msg + " Last Name,"
                End If

                If txtUsername.Text = "" Then
                    msg = msg & " Username,"
                End If
                If txtEmail.Text = "" Then
                    msg = msg & " Email,"
                End If
                If txtPhoneNum.Text = "" Then
                    msg = msg & " Phone Number,"
                End If
                If txtStreetAdd.Text = "" Then
                    msg = msg & " Street Address,"
                End If
                If txtBarangay.Text = "" Then
                    msg = msg & " Barangay,"
                End If
                If cmbCity.Text = "" Then
                    msg = msg & " City,"
                End If
                If cmbRegion.Text = "" Then
                    msg = msg & " Region,"
                End If
                If cmbGender.Text = "" Then
                    msg = msg & " Gender,"
                End If
                If txtPass.Text = "" Then
                    msg = msg & " Password field,"
                End If


                newStr = msg.TrimEnd(",")
                MessageBox.Show("Please Enter: " & newStr & ".", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            Else
                Dim gender As String = cmbGender.Text
                Dim city As String = cmbCity.Text
                Dim region As String = cmbRegion.Text
                Dim dateofBirth As Date = dtpDOB.Value.ToShortDateString
                Dim id As Integer


                Try
                    Dim command As New MySqlCommand("INSERT INTO customer VALUES(@Customer_ID,@First_Name,@Last_Name,@Customer_Username,@Customer_Password,@Email,@Phone_Number,@Street_Address ,@Barangay,@City,@Region,@Gender,@Date_Of_Birth,@Profile_Image)", conn)
                    Dim ms As New MemoryStream
                    picCustomImage.Image.Save(ms, picCustomImage.Image.RawFormat)
                    With command
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@Customer_ID", 0)
                        .Parameters.AddWithValue("@First_Name", txtFName.Text)
                        .Parameters.AddWithValue("@Last_Name", txtLName.Text)
                        .Parameters.AddWithValue("@Customer_Username", txtUsername.Text)
                        .Parameters.AddWithValue("@Customer_Password", txtPass.Text)
                        .Parameters.AddWithValue("@Email", txtEmail.Text)
                        .Parameters.AddWithValue("@Phone_Number", txtPhoneNum.Text)
                        .Parameters.AddWithValue("@Street_Address", txtStreetAdd.Text)
                        .Parameters.AddWithValue("@Barangay", txtBarangay.Text)
                        .Parameters.AddWithValue("@City", city)
                        .Parameters.AddWithValue("@Region", region)
                        .Parameters.AddWithValue("@Gender", gender)
                        .Parameters.AddWithValue("@Date_Of_Birth", dateofBirth)
                        .Parameters.AddWithValue("@Profile_Image", ms.ToArray())

                    End With

                    conn.Open()

                    If command.ExecuteNonQuery() = 1 Then

                        MessageBox.Show("Account Creation Successful!", "DELAROTA Account Creation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clearAll()

                    Dim query As String
                        Dim Reader As MySqlDataReader
                        query = "Select Customer_ID from customer where Customer_ID =(select max(Customer_ID) from customer)"
                        Dim cm As New MySqlCommand
                        cm = New MySqlCommand(query, conn)

                        Reader = cm.ExecuteReader
                        While Reader.Read
                            id = Reader.GetString("Customer_ID")
                            MessageBox.Show("Your Customer ID is:" & id, "DELAROTA Account Creation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End While
                        Reader.Close()
                        conn.Close()
                    Else
                    MessageBox.Show("Account Creation Failed!", "DELAROTA Account Creation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    loadcustomer()
                    clearAll()
                    End If

                Catch ex As Exception
                    MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            End If

    End Sub
    Function clearAll()
        txtBarangay.Clear()
        txtEmail.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPass.Clear()
        txtPhoneNum.Clear()
        txtStreetAdd.Clear()
        txtUsername.Clear()
        dtpDOB.Value = currdate
        cmbCity.Text = ""
        cmbGender.Text = ""
        cmbRegion.Text = ""
        picCustomImage.Image = Nothing
    End Function


    Private Function ValidatePassword(password As String) As Boolean
        Dim minimum = 8

        If (Not password.Length >= minimum) Then
            Return False
        End If

        Dim hasNum = False
        Dim hasCap = False
        Dim hasLow = False
        Dim hasSpe = False
        Dim currentCharacter As Char

        For i As Integer = 0 To password.Length - 1
            currentCharacter = password.Chars(i)
            If (Char.IsWhiteSpace(currentCharacter)) Then
                Return False
            End If
            If (Integer.TryParse(currentCharacter, 0)) Then
                hasNum = True
            ElseIf (Char.IsUpper(currentCharacter)) Then
                hasCap = True
            ElseIf (Char.IsLower(currentCharacter)) Then
                hasLow = True
            Else
                hasSpe = True
            End If
        Next

        Return hasNum And hasCap And hasLow And hasSpe


    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*PNG;*.GIF)|*.jpg;*.png;*.gif*"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            picCustomImage.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If togCustomer.Checked Then
            ''VALIDATION
            Try
                ''EMAIL
                If isValidEmail(txtEmail.Text) = False Then
                    MessageBox.Show("Invalid Email.Please try again ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ''PHONE NUMBER

                Try
                    If valPhoneNumber(txtPhoneNum.Text) = False Then
                        MessageBox.Show("Invalid Phone Number. Please try again ", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("Phone Number Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'IMAGE
                If picCustomImage.Image Is Nothing Then
                    MessageBox.Show("Please add a profile picture.", "Invalid Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                'DOB
                Dim dateOfBirth As Date = dtpDOB.Value
                Dim age As TimeSpan = DateTime.Now - dateOfBirth
                Dim ageInYears As Integer = CInt(Math.Floor(age.TotalDays / 365.25)) ' calculate age in years

                If ageInYears < 18 Then
                    MessageBox.Show("18 Below not valid", "Age Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If ageInYears > 64 Then
                    MessageBox.Show("Maximum age limit reaced ", "Age Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ''PASSWORD
                If ValidatePassword(txtPass.Text) = False Then
                    MessageBox.Show("Password must have 8-10 characters long with at least one numeric character and uppercase, lowercase and special characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


            Try
                Dim ms As New MemoryStream
                Dim command As New MySqlCommand("Update customer set First_Name=@Fname, Last_Name=@Lname, Customer_Username=@Username, Customer_Password =@Pass, Email=@Email,Phone_Number=@Phone, Street_Address=@Street, Barangay=@Barangay, City=@City, Region=@Region, Gender=@Gender,Date_Of_Birth =@DOB, Profile_Image=@ProfImage where customer_id='" & DgvRoles.CurrentRow.Cells(0).Value & "'", conn)
                picCustomImage.Image.Save(ms, picCustomImage.Image.RawFormat)

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
                    MessageBox.Show("Acccount Details Updated Successfully", "DELAROTA UPDATED ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadcustomer()
                Else
                    MessageBox.Show("Record not Inserted")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("UPDATE ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If




        If togSupplier.Checked Then

            ''VALIDATION
            Try
                ''EMAIL
                If isValidEmail(txtEmail.Text) = False Then
                    MessageBox.Show("Invalid Email.Please try again ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ''PHONE NUMBER

                Try
                    If valPhoneNumber(txtPhoneNum.Text) = False Then
                        MessageBox.Show("Invalid Phone Number. Please try again ", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("Phone Number Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'IMAGE
                If picCustomImage.Image Is Nothing Then
                    MessageBox.Show("Please add a profile picture.", "Invalid Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                'DOB
                Dim dateOfBirth As Date = dtpDOB.Value
                Dim age As TimeSpan = DateTime.Now - dateOfBirth
                Dim ageInYears As Integer = CInt(Math.Floor(age.TotalDays / 365.25)) ' calculate age in years

                If ageInYears < 18 Then
                    MessageBox.Show("18 Below not valid", "Age Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If ageInYears > 64 Then
                    MessageBox.Show("Maximum age limit reaced ", "Age Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ''PASSWORD
                If ValidatePassword(txtPass.Text) = False Then
                    MessageBox.Show("Password must have 8-10 characters long with at least one numeric character and uppercase, lowercase and special characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


            Try
                Dim ms As New MemoryStream
                Dim command As New MySqlCommand("Update supplier set First_Name=@Fname, Last_Name=@Lname, Supplier_Username=@Username, Supplier_Password =@Pass, Email=@Email,Phone_Number=@Phone, Street_Address=@Street, Barangay=@Barangay, City=@City, Region=@Region, Gender=@Gender,Date_Of_Birth =@DOB, Profile_Image=@ProfImage where supplier_id='" & DgvRoles.CurrentRow.Cells(0).Value & "'", conn)
                picCustomImage.Image.Save(ms, picCustomImage.Image.RawFormat)

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
                    MessageBox.Show("Supplier Acccount Details Updated Successfully", "DELAROTA UPDATED ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadSupplier()
                Else
                    MessageBox.Show("Record not Inserted")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("UPDATE ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If togAdmin.Checked Then
            ''VALIDATION

            Try

                ''EMAIL
                If isValidEmail(txtEmail.Text) = False Then
                    MessageBox.Show("Invalid Email.Please try again ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ''PASSWORD
                If ValidatePassword(txtPass.Text) = False Then
                    MessageBox.Show("Password must have 8-10 characters long with at least one numeric character and uppercase, lowercase and special characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


            Try
                Dim ms As New MemoryStream
                Dim command As New MySqlCommand("Update admin set First_Name=@Fname, Last_Name=@Lname, Admin_Email=@Email, Admin_Username =@Username, Admin_Password=@Pass where admin_id='" & DgvRoles.CurrentRow.Cells(0).Value & "'", conn)
                picCustomImage.Image.Save(ms, picCustomImage.Image.RawFormat)

                With command
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Fname", txtFName.Text)
                    .Parameters.AddWithValue("@Lname", txtLName.Text)
                    .Parameters.AddWithValue("@Username", txtUsername.Text)
                    .Parameters.AddWithValue("@Pass", txtPass.Text)
                    .Parameters.AddWithValue("@Email", txtEmail.Text)
                End With
                conn.Open()

                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Admin Acccount Details Updated Successfully", "DELAROTA UPDATED ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadAdmin()
                Else
                    MessageBox.Show("Record not Inserted")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("UPDATE ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub togSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles togSupplier.CheckedChanged
        If togSupplier.Checked = True Then

            loadSupplier()
            btnAdd.Enabled = False
            togCustomer.Enabled = False
            togAdmin.Enabled = False
        ElseIf togCustomer.Checked = False Then
            togCustomer.Enabled = True
            togAdmin.Enabled = True
            DgvRoles.DataSource.clear()
            clearAll()

        End If
    End Sub

    Private Sub togCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles togCustomer.CheckedChanged
        If togCustomer.Checked = True Then
            loadcustomer()
            togSupplier.Enabled = False
            togAdmin.Enabled = False
        ElseIf togCustomer.Checked = False Then
            togSupplier.Enabled = True
            togAdmin.Enabled = True
            DgvRoles.DataSource.clear()
            clearAll()

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If togAdmin.Checked Then
            Dim ms As New MemoryStream
            Dim command As New MySqlCommand("delete from admin where admin_id='" & DgvRoles.CurrentRow.Cells(0).Value & "'", conn)
            conn.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Admin Acccount Deleted", "DELAROTA ACCOUNT MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadAdmin()
            Else
                MessageBox.Show("Record not Inserted")
            End If
            conn.Close()
        End If



        If togCustomer.Checked Then
            Dim ms As New MemoryStream
            Dim command As New MySqlCommand("delete from customer  where customer_id='" & DgvRoles.CurrentRow.Cells(0).Value & "'", conn)
            conn.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Customer Acccount Deleted", "DELAROTA ACCOUNT MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadcustomer()
            Else
                MessageBox.Show("Record not Inserted")
            End If
        End If



        If togSupplier.Checked Then
            Dim ms As New MemoryStream
            Dim command As New MySqlCommand("delete from supplier  where supplier_id='" & DgvRoles.CurrentRow.Cells(0).Value & "'", conn)
            conn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Supplier Acccount Deleted", "DELAROTA ACCOUNT MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSupplier()
            Else
                MessageBox.Show("Record not Inserted")
            End If
        End If
    End Sub
End Class