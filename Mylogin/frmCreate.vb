
Imports System.ComponentModel.Design
Imports System.Diagnostics.Eventing
Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Web.Compilation
Imports DevComponents.DotNetBar.Controls
Imports MySql.Data.MySqlClient
Public Class frmCreate
    Dim newStr, msg As String

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If ValidatePassword(txtPass.Text) = False Then
                MessageBox.Show("Password must have 8-10 characters long with at least one numeric character and uppercase, lowercase and special characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtPass.Text <> txtConfirmPass.Text Then
                MessageBox.Show("Passwords do not match!. Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            If isValidEmail(txtEmail.Text) = False Then
                MessageBox.Show("Invalid Email.Please try again ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If valPhoneNumber(txtPhoneNum.Text) = False Then
                MessageBox.Show("Invalid Phone Number. Please try again ", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    conn.Close()
                Else
                    MessageBox.Show("Account Creation Failed!", "DELAROTA Account Creation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    clearAll()
                End If

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Hide()
            End Try
        End If
        Me.Hide()
    End Sub

    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        'conn.ConnectionString = "server = localhost;user id=root; port = 3306;password=root;database=ecommercedb1"
        'conn.Open()

        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from region"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)

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
        Return validEmail
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



    Private Sub cmbRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRegion.SelectedIndexChanged

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

        'Dim regEx
        'regEx = CreateObject("vbscript.regexp")
        'regEx.Pattern = "^.*(?=.{8,})(?= .*\ d)(?=.*[a-z])(?=.*[A-Z])(?=.[!@#$%^&+=]).*$"
        'ValidatePassword = regEx.Test(password)
        'regEx = Nothing

    End Function

    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*PNG;*.GIF)|*.jpg;*.png;*.gif*"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            picCustomImage.Image = Image.FromFile(opf.FileName)
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