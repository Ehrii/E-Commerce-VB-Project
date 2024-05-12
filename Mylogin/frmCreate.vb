﻿
Imports System.ComponentModel.Design
Imports System.Diagnostics.Eventing
Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Web.Compilation
Imports System.Web.UI.WebControls.WebParts
Imports DevComponents.DotNetBar.Controls
Imports MySql.Data.MySqlClient
Public Class frmCreate
    Dim newStr, msg As String




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        conn.Close()
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
            ElseIf txtPass.Text <> txtConfirmPass.Text Then
                MessageBox.Show("Passwords do not match!. Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


        If (txtFName.Text = Nothing Or txtLName.Text = Nothing Or cmbGender.Text = Nothing Or
             txtBarangay.Text = Nothing Or txtEmail.Text = Nothing Or cmbCity.Text = Nothing Or
             cmbRegion.Text = Nothing Or txtPhoneNum.Text = Nothing Or txtStreetAdd.Text = Nothing Or txtPass.Text = Nothing Or txtConfirmPass.Text = Nothing Or dtpDOB.Text = Nothing Or txtUsername.Text = Nothing Or cmbRegion.Text = Nothing) Then

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
            If txtConfirmPass.Text = "" Then
                msg = msg & " Confirm Password field,"
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
                    clearAll()
                End If

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
        Me.Hide()
    End Sub

    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrecord()
    End Sub
    '


    Sub loadrecord()
        conn.Close()

        If lblAction.Text = "UPDATE CUSTOMER ACCOUNT" Then
            btnEdit.Enabled = True
            btnUpdate.Enabled = True
            btnCancel.Enabled = False
            btnRegis.Enabled = False
            txtConfirmPass.Visible = False
            lblConfirm.Visible = False
            disable()
            connect()
            Dim query2 As String
            Dim reader2 As MySqlDataReader
            'new connection string'
            query2 = "select * from customer where customer_id ='" & customID & "'"
            Dim conn1 As New MySqlConnection("server = localhost;user id=root; port = 3306;password=root;database=ecommercedb1")
            Dim comm As New MySqlCommand(query2, conn1)
            Dim adapter As New MySqlDataAdapter(query2, conn1)
            Dim table As New DataTable()
            Dim imgByte() As Byte
            adapter.Fill(table)
            imgByte = table(0)(13)
            Dim ms As New MemoryStream(imgByte)
            conn1.Open()
            reader2 = comm.ExecuteReader()
            While reader2.Read()
                Dim Fname = reader2.GetString("First_Name")
                Dim Lname = reader2.GetString("Last_Name")
                Dim Username = reader2.GetString("Customer_Username")
                Dim Password = reader2.GetString("Customer_Password")
                Dim Email = reader2.GetString("Email")
                Dim Phone = reader2.GetString("Phone_Number")
                Dim Street = reader2.GetString("Street_Address")
                Dim Barangay = reader2.GetString("Barangay")
                Dim City = reader2.GetString("City")
                Dim Region = reader2.GetString("Region")
                Dim Gender = reader2.GetString("Gender")
                Dim DOB = reader2.GetString("Date_Of_Birth")

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
                picCustomImage.Image = Image.FromStream(ms)
                ' frmCreate.picCustomImage.Image = Image.FromStream(ms)
            End While
            reader2.Close()
            conn.Close()

            conn.Open()
            loadRegion()

        Else
            btnEdit.Enabled = False
            btnUpdate.Enabled = False
            btnCancel.Enabled = True
            btnRegis.Enabled = True
            loadRegion()
        End If
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



    Private Sub cmbRegion_SelectedIndexChanged(sender As Object, e As EventArgs)
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

    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*PNG;*.GIF)|*.jpg;*.png;*.gif*"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            picCustomImage.Image = Image.FromFile(opf.FileName)
        End If
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        enable()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        If ValidatePassword(txtPass.Text) = True Then
            Dim ms As New MemoryStream
            Dim command As New MySqlCommand("Update customer set First_Name=@Fname, Last_Name=@Lname, Customer_Username=@Username, Customer_Password =@Pass, Email=@Email,Phone_Number=@Phone, Street_Address=@Street, Barangay=@Barangay, City=@City, Region=@Region, Gender=@Gender,Date_Of_Birth =@DOB, Profile_Image=@ProfImage where customer_id='" & customID & "'", conn)
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
                disable()
            Else
                MessageBox.Show("Record not Inserted")
            End If
            conn.Close()
        End If

    End Sub

    Function clearAll()
        txtBarangay.Clear()
        txtConfirmPass.Clear()
        txtEmail.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPass.Clear()
        txtPhoneNum.Clear()
        txtStreetAdd.Clear()
        txtUsername.Clear()
        cmbCity.Text = ""
        cmbGender.Text = ""
        cmbRegion.Text = ""
        picCustomImage.Image = Nothing
    End Function


    'At least 8 Characters
    'At least 1 Number
    'At least 1 lowercase letter
    'At least 1 uppercase letter
    'At least 1 special character. Special Characters include !@#$%^+=

End Class