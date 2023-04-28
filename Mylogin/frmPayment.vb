Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient

Public Class frmPayment
    Dim payment As String


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


        txtCardNumber.Text = "1234-5678-2234-2233"
        txtName.Text = "John Eriel Labadan"
        txtExpiry.Text = "02/22"
        txtSecurity.Text = "8722"
        clear()
        ' txtAmtDue.Text = 5000
        btnDelivery.Enabled = False
        txtEmail.Text = "cjohneriel@gmail.com"
        txtPass.Text = "eriel@371"
        txtAccPin.Text = "7123"
        connect()
    End Sub
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadrecord()
    End Sub









    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnVerifyCard.Click
        Dim dt = New DataTable()

        '  conn.Open()
        ' Dim query As String = "select * from creditinfo where creditcard_no ='" & txtCardNumber.Text & "'"
        cmd = New MySqlCommand("select * from creditinfo where creditcard_no ='" & txtCardNumber.Text & "' AND carholder_name='" & txtName.Text & "' AND expiry_date= '" & txtExpiry.Text & "' AND security_code='" & txtSecurity.Text & "' And creditcard_type='" & payment & "'", conn)
        Dim da = New MySqlDataAdapter(cmd)
        da.SelectCommand = cmd
        da.Fill(dt)

        '  Try
        conn.Close()
        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Invalid Credit card . please try again..", "Credit card verification message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dt.Rows.Count > 0 Then
            btnConfirmCard.Enabled = True
            MessageBox.Show("Credit card linked..", "Credit card verification message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                lblCreditBalance.Text = balance
                txtCash.Text = balance

            End While
            conn.Close()
        End If
        '  Catch ex As Exception
        '    MessageBox.Show("error: " & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '  End Try
        conn.Close()
    End Sub
    Private Sub btnVerifyWall_Click(sender As Object, e As EventArgs) Handles btnVerifyWall.Click
        Dim dt = New DataTable()
        conn.Close()

        '  conn.Open()
        ' Dim query As String = "select * from creditinfo where creditcard_no ='" & txtCardNumber.Text & "'"
        cmd = New MySqlCommand("select * from ewalletinfo where ewallet_email ='" & txtEmail.Text & "' AND ewallet_password='" & txtPass.Text & "' AND ewallet_pin= '" & txtAccPin.Text & "' AND ewallet_type='" & payment & "'", conn)
        Dim da = New MySqlDataAdapter(cmd)
        da.SelectCommand = cmd
        da.Fill(dt)

        '  Try
        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Invalid E-wallet . please try again..", "E-wallet verification message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf dt.Rows.Count > 0 Then
            btnConfirm.Enabled = True
            MessageBox.Show("E-wallet linked..", "E-wallet verification message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        'Catch ex As Exception
        '   MessageBox.Show("error: " & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '  End Try
        conn.Close()

    End Sub

    Function clear()
        btnVerifyCard.Enabled = False
        btnVerifyWall.Enabled = False
        btnConfirm.Enabled = False
        btnConfirmCard.Enabled = False
    End Function

    Private Sub btnConfirmCard_Click(sender As Object, e As EventArgs) Handles btnConfirmCard.Click
        If Val(lblCreditBalance.Text) < Val(txtAmtDue.Text) Then
            MessageBox.Show("Insufficient amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtCash.Text = Nothing Then
            MessageBox.Show("Please enter a cash amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim change, oldbalance, newbalance, cash, due As Decimal
        due = txtAmtDue.Text
        oldbalance = lblCreditBalance.Text
        cash = txtCash.Text
        If cash < due Then
            MessageBox.Show("Please enter a sufficient amount  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        change = cash - due
        txtChange.Text = FormatNumber(change, 2)
        ' newbalance = oldbalance - cash
        lblCreditBalance.Text = FormatNumber(oldbalance, 2) - FormatNumber(cash, 2) + FormatNumber(change, 2)
        btnDelivery.Enabled = True


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Val(lblBalance.Text) < Val(txtAmtDue.Text) Then
            MessageBox.Show("Insufficient amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtCash.Text = Nothing Then
            MessageBox.Show("Please enter a cash amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim change, oldbalance, newbalance, cash, due As Decimal
        due = txtAmtDue.Text
        oldbalance = lblBalance.Text
        cash = txtCash.Text
        If cash < due Then
            MessageBox.Show("Please enter a sufficient amount  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        change = cash - due
        txtVat.Text = FormatNumber(change, 2)
        ' newbalance = oldbalance - cash
        lblBalance.Text = oldbalance - cash + change
        btnDelivery.Enabled = True

    End Sub


    Private Sub btnCash_Click(sender As Object, e As EventArgs)

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
        ' newbalance = oldbalance - cash
        btnDelivery.Enabled = True
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

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        Console.WriteLine(orderID)
        conn.Close()


        Dim cm2 As New MySqlCommand
        cm2 = New MySqlCommand("UPDATE orderDetails SET Total=@Total where Order_ID='" & orderID & "'", conn)
        Dim amt As Decimal = CInt(txtAmtDue.Text)
        Console.WriteLine(amt)
        With cm2
            .Parameters.Clear()
            .Parameters.AddWithValue("@Total", amt)
        End With
        conn.Open()
        If cm2.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Amount Updated")
            frmSummary.Show()
            'frmManage.loadRecord()
            Me.Hide()
        Else
            MessageBox.Show("Record not Updated")
        End If
        conn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cm As New MySqlCommand
        conn.Close()


        Dim cm1 As New MySqlCommand
        conn.Close()
        cm1 = New MySqlCommand("Update delivery set Order_Status=@Status WHERE Delivery_ID ='" & frmDelivery.delivery & "'", conn)
        With cm1
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", "Canceled")
        End With
        conn.Open()
        If cm1.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Delivery Cancelled")
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
            .Parameters.AddWithValue("@Status", "Canceled")
        End With
        conn.Open()
        If cm3.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Order Canceled")

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
        MessageBox.Show("records deleted")
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
        Next

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

            clear()

        End If
    End Sub

    Private Sub btnConfirmCash_Click(sender As Object, e As EventArgs) Handles btnConfirmCash.Click
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
            btnDelivery.Enabled = True
        End If

    End Sub

    Private Sub picVisa_Click_1(sender As Object, e As EventArgs) Handles picVisa.Click
        pnlCredit.Visible = True
        pnlEwall.Visible = False
        picChosenCredit.Image = picVisa.Image
        payment = "Visa"
        btnVerifyCard.Enabled = True
    End Sub

    Private Sub picMaster_Click_1(sender As Object, e As EventArgs) Handles picMaster.Click
        pnlCredit.Visible = True
        pnlEwall.Visible = False
        picChosenCredit.Image = picMaster.Image
        payment = "Mastercard"
        btnVerifyCard.Enabled = True

    End Sub

    Private Sub picAmerican_Click_1(sender As Object, e As EventArgs) Handles picAmerican.Click
        pnlCredit.Visible = True
        pnlEwall.Visible = False
        picChosenCredit.Image = picAmerican.Image
        payment = "American Express"
        btnVerifyCard.Enabled = True
    End Sub

    Private Sub picGcash_Click_1(sender As Object, e As EventArgs) Handles picGcash.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picGcash.Image
        payment = "G-cash"
        btnVerifyWall.Enabled = True

    End Sub

    Private Sub picPayMaya_Click_1(sender As Object, e As EventArgs) Handles picPayMaya.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picPayMaya.Image
        payment = "Paymaya"
        btnVerifyWall.Enabled = True
    End Sub

    Private Sub picCoins_Click(sender As Object, e As EventArgs) Handles picCoins.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picCoins.Image
        payment = "Coins.Ph"
        btnVerifyWall.Enabled = True

    End Sub

    Private Sub picPaypal_Click_1(sender As Object, e As EventArgs) Handles picPaypal.Click
        pnlCredit.Visible = False
        pnlEwall.Visible = True
        picChosenEwall.Image = picPaypal.Image
        payment = "Paypal"
        btnVerifyWall.Enabled = True

    End Sub

End Class