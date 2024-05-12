Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmViewInv
    Dim choice As String
    Private Sub frmViewInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadrecord()

    End Sub

    Sub loadrecord()

        Dim cm As New MySqlCommand
        DgvInventory.Rows.Clear()
        'conn.Open()'
        cm = New MySqlCommand("Select * from product where Product_Name like '%" & txtSearch.Text & "%'", conn)

        dr = cm.ExecuteReader
        While dr.Read
            DgvInventory.Rows.Add(dr.Item("Inventory_ID").ToString, dr.Item("Product_Image"), dr.Item("Product_ID"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvInventory.Rows.Count - 1
            Dim r As DataGridViewRow = DgvInventory.Rows(i)
            r.Height = 60
        Next

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        conn.Open()
        loadrecord()
    End Sub

    Sub loadinv(category As String)
        Try

            connect()
            DgvInventory.Rows.Clear()

            Dim cm As New MySqlCommand
            cm = New MySqlCommand("Select * from product where item_code like '" & category & "%'", conn)
            dr = cm.ExecuteReader
            While dr.Read
                DgvInventory.Rows.Add(dr.Item("Inventory_ID").ToString, dr.Item("Product_Image"), dr.Item("Product_ID").ToString, dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString)
            End While
            dr.Close()
            conn.Close()

            For i = 0 To DgvInventory.Rows.Count - 1
                Dim r As DataGridViewRow = DgvInventory.Rows(i)
                r.Height = 60
            Next
        Catch ex As Exception
            MessageBox.Show("LOAD INVENTORY ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Guna2ToggleSwitch3_CheckedChanged(sender As Object, e As EventArgs) Handles toggleMen.CheckedChanged

        If toggleMen.Checked = True Then
            choice = "MEN"
            conn.Open()
            loadinv(choice)
            toggleAcc.Enabled = False
            toggleKids.Enabled = False
            toggleWomen.Enabled = False
        ElseIf toggleMen.Checked = False Then
            conn.Open()
            loadrecord()
            toggleAcc.Enabled = True
            toggleKids.Enabled = True
            toggleWomen.Enabled = True
        End If
    End Sub



    Private Sub toggleWomen_CheckedChanged(sender As Object, e As EventArgs) Handles toggleWomen.CheckedChanged
        If toggleWomen.Checked = True Then
            choice = "WOMEN"
            conn.Open()
            loadinv(choice)
            toggleAcc.Enabled = False
            toggleKids.Enabled = False
            toggleMen.Enabled = False
        ElseIf toggleWomen.Checked = False Then
            conn.Open()
            loadrecord()
            toggleAcc.Enabled = True
            toggleKids.Enabled = True
            toggleMen.Enabled = True
        End If

    End Sub

    Private Sub toggleKids_CheckedChanged(sender As Object, e As EventArgs) Handles toggleKids.CheckedChanged
        If toggleKids.Checked = True Then
            choice = "KIDS"
            conn.Open()
            loadinv(choice)
            toggleAcc.Enabled = False
            toggleMen.Enabled = False
            toggleWomen.Enabled = False
        ElseIf toggleKids.Checked = False Then
            conn.Open()
            loadrecord()
            toggleAcc.Enabled = True
            toggleMen.Enabled = True
            toggleWomen.Enabled = True
        End If

    End Sub

    Private Sub toggleAcc_CheckedChanged(sender As Object, e As EventArgs) Handles toggleAcc.CheckedChanged
        If toggleAcc.Checked = True Then
            choice = "ACC"
            conn.Open()
            loadinv(choice)
            toggleMen.Enabled = False
            toggleKids.Enabled = False
            toggleWomen.Enabled = False
        ElseIf toggleAcc.Checked = False Then
            conn.Open()
            loadrecord()
            toggleMen.Enabled = True
            toggleKids.Enabled = True
            toggleWomen.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim sfd As New SaveFileDialog()
        sfd.FileName = "export-csv"
        sfd.Filter = "CSV File | *.csv"



        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = New StreamWriter(sfd.FileName, False, Encoding.UTF8)
                ' Write the column names to the CSV file
                Dim dgvColumnNames As List(Of String) = DgvInventory.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                   Select(Function(c) c.Name).ToList()
                sw.WriteLine(String.Join(",", dgvColumnNames))

                ' Write the data rows to the CSV file
                For Each row As DataGridViewRow In DgvInventory.Rows
                    Dim rowdata As New List(Of String)
                    For Each column As DataGridViewColumn In DgvInventory.Columns
                        Dim cellValue = row.Cells(column.Name).Value
                        If TypeOf cellValue Is System.Byte Then
                            ' Replace System.Byte values with an empty string
                            rowdata.Add("")
                        Else
                            rowdata.Add(Convert.ToString(cellValue))
                        End If
                    Next
                    sw.WriteLine(String.Join(",", rowdata))
                Next

                ' Close the StreamWriter and release the file lock
                sw.Close()

                ' Open the exported file
                Process.Start(sfd.FileName)
            End Using
        End If



    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim sfd1 As New SaveFileDialog()
        sfd1.FileName = "export-pdf"
        sfd1.Filter = "PDF file|*.pdf"
        If sfd1.ShowDialog() = DialogResult.OK Then
            ' Create a new PDF document
            Dim pdfDoc As New Document()
            ' Set the page size and margins
            pdfDoc.SetPageSize(PageSize.A4.Rotate())
            pdfDoc.SetMargins(30, 30, 30, 30)
            ' Create a new PDF writer to write the document to a file
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(sfd1.FileName, FileMode.Create))
            ' Open the PDF document
            pdfDoc.Open()

            ' Add a new table to the document
            Dim pdfTable As New PdfPTable(DgvInventory.Columns.Count - 1) ' exclude the column to be excluded
            pdfTable.TotalWidth = 500.0F
            pdfTable.LockedWidth = True

            ' Add the column headers to the table
            For Each column As DataGridViewColumn In DgvInventory.Columns
                If column.Name <> "Product_Image" Then ' exclude the column to be excluded
                    pdfTable.AddCell(New PdfPCell(New Phrase(column.HeaderText)))
                End If
            Next

            ' Add the data rows to the table
            Dim rowCount As Integer = DgvInventory.Rows.Count
            Dim totalProductCount As Integer = 0
            For Each row As DataGridViewRow In DgvInventory.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.OwningColumn.Name <> "Product_Image" Then ' exclude the column to be excluded
                        Dim cellValue = cell.Value
                        If cellValue Is Nothing OrElse TypeOf cellValue Is System.DBNull Then
                            pdfTable.AddCell(New PdfPCell(New Phrase("")))
                        Else
                            pdfTable.AddCell(New PdfPCell(New Phrase(cellValue.ToString())))
                            If cell.OwningColumn.Name = "Product_ID" Then
                            End If
                        End If
                    End If
                Next
            Next

            ' Add the total product count row to the table
            pdfTable.AddCell(New PdfPCell(New Phrase("Total Product Count")))
            pdfTable.AddCell(New PdfPCell(New Phrase(rowCount.ToString())))
            pdfTable.CompleteRow()
            ' Add the table to the PDF document
            pdfDoc.Add(pdfTable)

            ' Close the PDF document
            pdfDoc.Close()

            ' Open the exported file
            Process.Start(sfd1.FileName)
        End If

    End Sub


End Class