Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports DevComponents.DotNetBar
Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient

Public Class frmPayment
    Public payment As String
    Public accdetails, email, ewallettype As String

    Sub Creditcard(type As String)
        Try
            conn.Close()
            Dim cm2 As New MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim dt = New DataTable()
            cm2 = New MySqlCommand("Select * from creditinfo where Customer_ID ='" & customID & "' AND creditcard_type='" & type & "'", conn)
            Dim da = New MySqlDataAdapter(cmd)
            da.SelectCommand = cm2
            da.Fill(dt)
            conn.Close()

            If dt.Rows.Count > 0 Then
                conn.Open()
                reader2 = cm2.ExecuteReader
                While reader2.Read
                    btnVerifyCard.Enabled = True
                    Dim creditcardno = reader2.GetString("creditcard_no")
                    Dim creditname = reader2.GetString("cardholder_name")
                    Dim expdate = reader2.GetString("expiry_date")
                    Dim seccode = reader2.GetString("security_code")
                    type = reader2.GetString("creditcard_type")
                    txtCardNumber.Text = creditcardno
                    txtName.Text = creditname
                    txtExpiry.Text = expdate
                    txtSecurity.Text = seccode
                End While
            Else
                txtCardNumber.Clear()
                txtName.Clear()
                txtExpiry.Clear()
                txtSecurity.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("CREDIT CARD ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Sub ewallet(type As String)
        Try
            conn.Close()
            Dim cm2 As New MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim dt = New DataTable()
            cm2 = New MySqlCommand("Select * from ewalletinfo where Customer_ID ='" & customID & "' AND ewallet_type='" & type & "'", conn)
            Dim da = New MySqlDataAdapter(cmd)
            da.SelectCommand = cm2
            da.Fill(dt)
            conn.Close()

            If dt.Rows.Count > 0 Then
                conn.Open()
                reader2 = cm2.ExecuteReader
                While reader2.Read
                    btnVerifyCard.Enabled = True
                    Dim email = reader2.GetString("ewallet_email")
                    Dim password = reader2.GetString("ewallet_password")
                    Dim accountpin = reader2.GetString("ewallet_pin")

                    txtEmail.Text = email
                    txtPass.Text = password
                    txtAccPin.Text = accountpin

                End While
            Else
                txtEmail.Clear()
                txtPass.Clear()
                txtAccPin.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("EWALLET ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub loadrecord()
        pnlCards.Visible = False
        pnlEwallet.Visible = False
        pnlPaypal.Visible = False
        picChosenCredit.Image = Nothing
        pnlEwall.Visible = False
        pnlCredit.Visible = False
        txtAmtDue.Enabled = False
        txtVat.Enabled = False
        btnConfirmCash.Enabled = False
        lblCash.Visible = False
        txtCash.Visible = False
        btnConfirmOrd.Enabled = False
        conn.Close()

        Dim query As String
        Dim balance, vat As Double
        Dim reader As MySqlDataReader
        query = "select * from orderdetails"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            balance = reader.GetString("total")
            vat = 0.12 * balance
            txtAmtDue.Text = balance + vat
            txtVat.Text = vat
        End While
        conn.Close()

        clear()
        connect()
    End Sub
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accdetails = customID
        txtChange.Clear()
        txtCash.Clear()
        loadrecord()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnVerifyCard.Click
        Try
            Dim dt = New DataTable()
            conn.Close()
            cmd = New MySqlCommand("select * from creditinfo where creditcard_no ='" & txtCardNumber.Text & "' AND cardholder_name='" & txtName.Text & "' AND expiry_date= '" & txtExpiry.Text & "' AND security_code='" & txtSecurity.Text & "' And creditcard_type='" & payment & "'", conn)
            Dim da = New MySqlDataAdapter(cmd)
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count <= 0 Then
                MessageBox.Show("Invalid Credit card . please try again..", "Credit card verification message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf dt.Rows.Count > 0 Then
                btnConfirmCard.Enabled = True
                MessageBox.Show("Credit card linked..", "Credit card verification message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim com As New MySqlCommand
                com = New MySqlCommand("UPDATE creditinfo SET Customer_ID=@Customer_ID where creditcard_no='" & txtCardNumber.Text & "'", conn)
                With com
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Customer_ID", customID)
                End With
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()

                Dim query As String
                Dim balance As Double
                Dim vat As Decimal
                Dim reader As MySqlDataReader
                query = "select * from creditinfo where creditcard_type='" & payment & "'"
                Dim cm As New MySqlCommand
                cm = New MySqlCommand(query, conn)
                conn.Open()
                reader = cm.ExecuteReader
                While reader.Read
                    balance = reader.GetString("amount")
                    lblCreditBalance.Text = FormatNumber(balance, 2) 'CHANGED
                    txtCash.Text = balance

                End While
                conn.Close()
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("PAYMENT VERIFICATION ERROR " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnVerifyWall_Click(sender As Object, e As EventArgs) Handles btnVerifyWall.Click
        Try
            Dim dt = New DataTable()
            conn.Close()
            cmd = New MySqlCommand("select * from ewalletinfo where ewallet_email ='" & txtEmail.Text & "' AND ewallet_password='" & txtPass.Text & "' AND ewallet_pin= '" & txtAccPin.Text & "' AND ewallet_type='" & payment & "'", conn)
            Dim da = New MySqlDataAdapter(cmd)
            da.SelectCommand = cmd
            da.Fill(dt)


            If dt.Rows.Count <= 0 Then
                MessageBox.Show("Invalid E-wallet . please try again..", "E-wallet verification message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf dt.Rows.Count > 0 Then
                btnConfirm.Enabled = True
                MessageBox.Show("E-wallet linked..", "E-wallet verification message", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Dim com As New MySqlCommand
                com = New MySqlCommand("UPDATE ewalletinfo SET Customer_ID=@Customer_ID where ewallet_email='" & txtEmail.Text & "'", conn)
                With com
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Customer_ID", customID)
                End With
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()

                Dim query As String
                Dim balance As Decimal
                Dim reader As MySqlDataReader
                query = "select * from ewalletinfo where ewallet_type='" & payment & "'"
                Dim cm As New MySqlCommand
                cm = New MySqlCommand(query, conn)
                conn.Open()
                reader = cm.ExecuteReader
                While reader.Read
                    balance = reader.GetString("amount")
                    lblBalance.Text = balance
                    txtCash.Text = balance
                End While
                conn.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("EWALLET VERIFICATION ERRROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function clear()
        btnVerifyCard.Enabled = False
        btnVerifyWall.Enabled = False
        btnConfirm.Enabled = False
        btnConfirmCard.Enabled = False
    End Function

    Private Sub btnConfirmCard_Click(sender As Object, e As EventArgs) Handles btnConfirmCard.Click
        Try
            accdetails = txtCardNumber.Text
            Dim change, oldbalance, newbalance, cash, due As Decimal
            due = txtAmtDue.Text
            oldbalance = lblCreditBalance.Text
            cash = txtCash.Text

            If oldbalance < due Then
                MessageBox.Show("Insufficient amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtCash.Text = Nothing Then
                MessageBox.Show("Please enter a cash amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cash < due Then
                MessageBox.Show("Please enter a sufficient amount  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            change = cash - due
            txtChange.Text = FormatNumber(change, 2)
            lblCreditBalance.Text = FormatNumber(oldbalance, 2) - FormatNumber(cash, 2) + FormatNumber(change, 2)
            btnConfirmOrd.Enabled = True
            btnConfirmCard.Enabled = False
        Catch ex As Exception
            MessageBox.Show("CONFIRM CARD ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            email = txtEmail.Text
            Dim change, oldbalance, newbalance, cash, due As Decimal
            due = txtAmtDue.Text
            oldbalance = lblBalance.Text
            cash = txtCash.Text
            If oldbalance < due Then
                MessageBox.Show("Insufficient amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtCash.Text = Nothing Then
                MessageBox.Show("Please enter a cash amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cash < due Then
                MessageBox.Show("Please enter a sufficient amount  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            change = cash - due
            txtChange.Text = FormatNumber(change, 2)
            lblBalance.Text = oldbalance - cash + change
            btnConfirmOrd.Enabled = True
            btnConfirm.Enabled = False
        Catch ex As Exception
            MessageBox.Show("CONFIRM E-WALLET ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnCash_Click(sender As Object, e As EventArgs)
        Try
            accdetails = customID
            If txtCash.Text = Nothing Then
                MessageBox.Show("Please a cash amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim change, oldbalance, newbalance, cash, due As Double
            due = txtAmtDue.Text
            oldbalance = lblBalance.Text
            cash = txtCash.Text
            If cash < due Then
                MessageBox.Show("Please enter a sufficient amount  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            change = cash - due
            txtVat.Text = FormatNumber(change, 2)
            btnConfirmOrd.Enabled = True
        Catch ex As Exception
            MessageBox.Show("CASH ON DELIVERY ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCardNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCardNumber.TextChanged
        If txtCardNumber.Text Like "4*4" Then
            picChosenCredit.Image = picVisa.Image
            payment = "Visa"
            btnVerifyCard.Enabled = True
        ElseIf txtCardNumber.Text Like "5*55" Then
            picChosenCredit.Image = picMaster.Image
            payment = "Mastercard"
            btnVerifyCard.Enabled = True
        ElseIf txtCardNumber.Text Like "3*3" Then
            picChosenCredit.Image = picAmerican.Image
            payment = "American Express"
            btnVerifyCard.Enabled = True
        End If
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnConfirmOrd.Click
        Try
            conn.Close()
            If cmbMethod.Text = "Credit/Debit Card" Then
                Dim balance As Integer = lblCreditBalance.Text
                Dim cm As New MySqlCommand
                cm = New MySqlCommand("UPDATE creditinfo SET amount=@amount  where creditcard_no='" & txtCardNumber.Text & "'", conn)
                With cm
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@amount", balance)
                End With
                conn.Open()
                If cm.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Credit Card Amount Updated", "DELAROTA CREDIT CARD MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmSummary.lblDetails.Text = txtCardNumber.Text
                    frmSummary.lblMode.Text = cmbMethod.Text
                    frmSummary.lblCard.Text = payment
                    frmSummary.Show()
                    frmSummary.loadsummary()

                    Me.Hide()

                End If
                conn.Close()
            End If

            If cmbMethod.Text = "E-Wallets" Or cmbMethod.Text = "Paypal" Then
                Dim balance As Integer = lblBalance.Text
                Dim cm1 As New MySqlCommand
                cm1 = New MySqlCommand("UPDATE ewalletinfo SET amount=@amount  where ewallet_type='" & payment & "'", conn)
                With cm1
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@amount", balance)
                End With
                conn.Open()
                If cm1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("E-wallet Amount Updated", "DELAROTA E-WALLET MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmSummary.lblDetails.Text = txtEmail.Text
                    frmSummary.lblMode.Text = cmbMethod.Text
                    frmSummary.lblCard.Text = payment
                    frmSummary.loadsummary()

                    frmSummary.Show()
                    Me.Hide()
                End If
                conn.Close()
            End If


            'ORDER DETAILS UPDATE
            Dim cm2 As New MySqlCommand
            cm2 = New MySqlCommand("UPDATE orderDetails SET Total=@Total where Order_ID='" & orderID & "'", conn)
            Dim amt As Decimal = CInt(txtAmtDue.Text)
            Console.WriteLine(amt)
            With cm2
                .Parameters.Clear()
                .Parameters.AddWithValue("@Total", amt)
            End With
            conn.Close()
            conn.Open()
            If cm2.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Order Details Updated", "DELAROTA ORDER DETAILS MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmSummary.Show()
                'frmManage.loadRecord()
                Me.Hide()
            Else
                MessageBox.Show("Record not Updated")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("CONFIRM PAYMENT ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            Dim cm As New MySqlCommand
            conn.Close()

            Dim cm1 As New MySqlCommand
            conn.Close()
            cm1 = New MySqlCommand("Update delivery set Order_Status=@Status WHERE Delivery_ID ='" & frmDelivery.delivery & "'", conn)
            With cm1
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "Canceled on Payment")
            End With
            conn.Open()
            If cm1.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Delivery Cancelled", "DELAROTA DELIVERY MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmShop.loadcartcount()
                frmShop.txtCart.Enabled = False

            Else
                MessageBox.Show("Error")
            End If
            Me.Hide()


            Dim cm3 As New MySqlCommand
            conn.Close()
            cm3 = New MySqlCommand("Update orderdetails set Status=@Status WHERE Order_ID ='" & orderID & "'", conn)
            With cm3
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "Canceled on Payment")
            End With
            conn.Open()
            If cm3.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Order Cancelled", "DELAROTA ORDER MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error")
            End If
            Me.Hide()

            'conn.Open()
            Dim cm2 As New MySqlCommand
            conn.Close()
            cm2 = New MySqlCommand("truncate table cart", conn)
            conn.Open()
            cm2.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Previous Cart Items Deleted", "DELAROTA CART MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmShop.loadcartcount()
            frmCart.loadRecord()
            frmShop.lblPrice.Text = "TOTAL PRICE: " & 0.00



            For i = 0 To frmDelivery.dgvCart.Rows.Count - 1
                Dim totalStock As Integer
                Dim quan As Integer = frmDelivery.dgvCart.Rows(i).Cells(2).Value
                Dim prodId As Integer = frmDelivery.dgvCart.Rows(i).Cells(0).Value
                Dim sum As Integer
                Dim query As String
                Dim reader As MySqlDataReader
                query = "select * from product where product_id='" & frmDelivery.dgvCart.Rows(i).Cells(0).Value & "'"
                Dim comm As New MySqlCommand
                comm = New MySqlCommand(query, conn)
                conn.Open()
                reader = comm.ExecuteReader
                While reader.Read
                    totalStock = reader("Stock")
                    Console.WriteLine(totalStock)
                End While

                conn.Close()
                conn.Open()
                Dim comm2 As New MySqlCommand
                comm2 = New MySqlCommand("Update product set Stock=@Stock WHERE Product_ID =@ProdId", conn)
                With comm2
                    sum = totalStock + quan
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@ProdId", prodId)
                    .Parameters.AddWithValue("@Stock", sum)
                    Console.WriteLine(sum)

                End With
                comm2.ExecuteNonQuery()
                frmShop.loadRecord()
                conn.Close()
                conn.Open()

                Dim comm3 As New MySqlCommand
                comm3 = New MySqlCommand("Update inventory set Stock=@Stock WHERE Product_ID =@ProdId", conn)
                With comm3
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@ProdId", prodId)
                    .Parameters.AddWithValue("@Stock", sum)
                    Console.WriteLine(sum)
                End With
                comm3.ExecuteNonQuery()
                frmShop.loadRecord()
                conn.Close()
            Next
        Catch ex As Exception
            MessageBox.Show("CANCEL PAYMENT ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMethod.SelectedIndexChanged
        If cmbMethod.SelectedItem = "Credit/Debit Card" Then
            btnConfirmCash.Visible = False
            pnlCards.Visible = True
            pnlEwallet.Visible = False
            pnlPaypal.Visible = False
            pnlCredit.Visible = True
            pnlEwall.Visible = False
            lblCash.Visible = False
            txtCash.Visible = False

            clear()
        ElseIf cmbMethod.SelectedItem = "E-Wallets" Then
            btnConfirmCash.Visible = False
            txtCash.Enabled = False
            pnlEwallet.Visible = True
            pnlCards.Visible = False
            pnlCredit.Visible = False
            pnlEwall.Visible = True
            pnlPaypal.Visible = False
            lblCash.Visible = False
            txtCash.Visible = False
            clear()

        ElseIf cmbMethod.SelectedItem = "Paypal" Then
            btnConfirmCash.Visible = False
            txtCash.Enabled = False
            pnlEwallet.Visible = False
            pnlCredit.Visible = False
            pnlEwall.Visible = True
            pnlCards.Visible = False
            pnlPaypal.Visible = True
            lblCash.Visible = False
            txtCash.Visible = False
            clear()

        ElseIf cmbMethod.SelectedItem = "Cash on Delivery" Then
            btnConfirmCash.Visible = True
            txtCash.Enabled = True
            pnlEwallet.Visible = False
            pnlCards.Visible = False
            pnlPaypal.Visible = False
            pnlCredit.Visible = False
            pnlEwall.Visible = False
            lblCash.Visible = True
            txtCash.Visible = True
            btnConfirmCash.Enabled = True
            payment = lblOrder.Text
            clear()

        End If
    End Sub

    Private Sub btnConfirmCash_Click(sender As Object, e As EventArgs) Handles btnConfirmCash.Click
        Try
            Dim change, cash, due As Decimal
            due = txtAmtDue.Text
            cash = txtCash.Text
            If txtCash.Text = Nothing Then
                MessageBox.Show("Please enter a cash amount...", "PAYMENT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If cash < due Then
                MessageBox.Show("Please enter a sufficient amount...", "PAYMENT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                change = cash - due
                txtChange.Text = FormatNumber(change, 2)
                btnConfirmOrd.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show("CONFIRM CASH ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub picVisa_Click_1(sender As Object, e As EventArgs) Handles picVisa.Click
        pnlCredit.Visible = True
        pnlEwall.Visible = False
        picChosenCredit.Image = picVisa.Image
        payment = "Visa"
        btnVerifyCard.Enabled = True
        Creditcard(payment)

    End Sub

    Private Sub picMaster_Click_1(sender As Object, e As EventArgs) Handles picMaster.Click
        pnlCredit.Visible = True
        pnlEwall.Visible = False
        picChosenCredit.Image = picMaster.Image
        payment = "Mastercard"
        btnVerifyCard.Enabled = True
        Creditcard(payment)

    End Sub

    Private Sub picAmerican_Click_1(sender As Object, e As EventArgs) Handles picAmerican.Click
        pnlCredit.Visible = True
        pnlEwall.Visible = False
        picChosenCredit.Image = picAmerican.Image
        payment = "American Express"
        btnVerifyCard.Enabled = True
        Creditcard(payment)
    End Sub

    Private Sub picGcash_Click_1(sender As Object, e As EventArgs) Handles picGcash.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picGcash.Image
        payment = "G-cash"
        btnVerifyWall.Enabled = True
        ewallet(payment)

    End Sub

    Private Sub picPayMaya_Click_1(sender As Object, e As EventArgs) Handles picPayMaya.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picPayMaya.Image
        payment = "Paymaya"
        btnVerifyWall.Enabled = True
        ewallet(payment)
    End Sub



    Private Sub picCoins_Click(sender As Object, e As EventArgs) Handles picCoins.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picCoins.Image
        payment = "Coins.Ph"
        btnVerifyWall.Enabled = True
        ewallet(payment)
    End Sub

    Private Sub picPaypal_Click_1(sender As Object, e As EventArgs) Handles picPaypal.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picPaypal.Image
        payment = "Paypal"
        btnVerifyWall.Enabled = True
        ewallet(payment)
    End Sub


End Class