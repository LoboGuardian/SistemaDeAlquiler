Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Report

    Private Sub ExportToPDF()

        ' Obtener la fecha y hora actual
        Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")

        ' Agregar la fecha y hora al nombre del archivo
        Dim fileName As String = "Reporte_" & currentDate & ".pdf"

        ' Crear el documento PDF
        Dim doc As New Document()
        Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("C:\Users\rafae\OneDrive\Escritorio\" & fileName, FileMode.Create))
        doc.Open()

        ' Add logo
        Dim image As Image = Image.GetInstance("logo.png")
        image.ScaleAbsolute(50.0F, 50.0F)
        image.SetAbsolutePosition(500.0F, 750.0F)
        doc.Add(image)

        ' Add header
        Dim headerTable As New PdfPTable(1)
        headerTable.DefaultCell.Border = Rectangle.NO_BORDER
        headerTable.WidthPercentage = 100
        headerTable.TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin

        Dim cellA As New PdfPCell()
        cellA.Border = Rectangle.NO_BORDER
        ' Center align the text
        cellA.HorizontalAlignment = Element.ALIGN_CENTER
        cellA.VerticalAlignment = Element.ALIGN_MIDDLE

        ' Add company name
        cellA.AddElement(New Paragraph("COOPERATIVA SOLUCIONES"))
        cellA.AddElement(New Paragraph("GENEREALES EMPRESARIALES, R.L."))
        cellA.AddElement(New Paragraph("RIF: J-29780707-1"))
        headerTable.AddCell(cellA)

        ' Add header to each page
        pdfWriter.PageEvent = New HeaderFooter(headerTable)


        ' Crear la tabla para inventory
        If DataGridView.Rows.Count > 0 Then
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph("Tabla 'Inventario':"))
            doc.Add(New Paragraph(" "))


            Dim table As New PdfPTable(DataGridView.Columns.Count - 4) ' Restamos 4 para excluir los campos Nombre, Apellido y Cedula
            table.WidthPercentage = 100

            For Each column As DataGridViewColumn In DataGridView.Columns
                If column.HeaderText <> "ID" AndAlso column.HeaderText <> "Nombre" AndAlso column.HeaderText <> "Apellido" AndAlso column.HeaderText <> "Cedula" Then
                    table.AddCell(column.HeaderText)
                End If
            Next

            For Each row As DataGridViewRow In DataGridView.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.OwningColumn.HeaderText <> "ID" AndAlso cell.OwningColumn.HeaderText <> "Nombre" AndAlso cell.OwningColumn.HeaderText <> "Apellido" AndAlso cell.OwningColumn.HeaderText <> "Cedula" Then
                        If cell.Value IsNot Nothing Then
                            table.AddCell(cell.Value.ToString())
                        Else
                            table.AddCell("")
                        End If
                    End If
                Next
            Next

            doc.Add(table)

            Dim productCount As Integer = CountProducts()
            doc.Add(New Paragraph("Recuento de productos: " & productCount.ToString()))

            ' Agregar espacio debajo de la tabla
            doc.Add(New Paragraph(" "))
        Else
            ' Agregar mensaje de excepción si no hay datos en la tabla
            Throw New Exception("La tabla 'Inventario' no contiene datos.")
        End If

        doc.Add(image)

        ' Crear la tabla para clientes
        If DataGridViewClients.Rows.Count > 0 Then
            doc.NewPage()
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph("Tabla 'clientes':"))
            doc.Add(New Paragraph(" "))

            Dim tableClientes As New PdfPTable(DataGridViewClients.Columns.Count - 1)
            tableClientes.WidthPercentage = 100

            For Each column As DataGridViewColumn In DataGridViewClients.Columns
                If column.HeaderText <> "ID" Then
                    tableClientes.AddCell(column.HeaderText)
                End If
            Next

            For Each row As DataGridViewRow In DataGridViewClients.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.OwningColumn.HeaderText <> "ID" Then
                        If cell.Value IsNot Nothing Then
                            tableClientes.AddCell(cell.Value.ToString())
                        Else
                            tableClientes.AddCell("")
                        End If
                    End If
                Next
            Next

            doc.Add(tableClientes)

            Dim clientesCount As Integer = CountClientes()
            doc.Add(New Paragraph("Recuento de clientes: " & clientesCount.ToString()))

            ' Agregar espacio debajo de la tabla
            doc.Add(New Paragraph(" "))
        Else
            ' Agregar mensaje de excepción si no hay datos en la tabla
            Throw New Exception("La tabla 'clientes' no contiene datos.")
        End If

        doc.Close()

        MessageBox.Show("Los datos se han exportado a un archivo PDF.")
    End Sub

    Private Sub ReporteButton_Click(sender As Object, e As EventArgs) Handles ReporteButton.Click
        ExportToPDF()
    End Sub

    ' Clase para agregar el encabezado a cada página
    Public Class HeaderFooter
        Inherits PdfPageEventHelper

        Private headerTable As PdfPTable

        Public Sub New(ByVal headerTable As PdfPTable)
            Me.headerTable = headerTable
        End Sub

        Public Overrides Sub OnEndPage(ByVal writer As PdfWriter, ByVal document As Document)
            headerTable.WriteSelectedRows(0, -1, document.LeftMargin, document.PageSize.GetTop(document.TopMargin), writer.DirectContent)
        End Sub
    End Class



    Private Function Count()

        Dim productCount As Integer = CountProducts()
        Dim clientesCount As Integer = CountClientes()

        RecuentoLabel.Text = "Recuento de productos en el inventario: " & productCount.ToString() & vbCrLf &
                          "Recuento de clientes: " & clientesCount.ToString()
    End Function


    Private Function CountProducts() As Integer
        Dim count As Integer = 0
        For Each row As DataGridViewRow In DataGridView.Rows
            If Not row.IsNewRow AndAlso Not row.Cells("Id").Value Then
                count += 1
            End If
        Next
        Return count
    End Function

    Private Function CountClientes() As Integer
        Dim count As Integer = 0
        For Each row As DataGridViewRow In DataGridViewClients.Rows
            If Not row.IsNewRow AndAlso Not row.Cells("Id").Value Then
                count += 1
            End If
        Next
        Return count
    End Function


    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView.ReadOnly = True
        RefreshDataGridVieInventory()
        DataGridViewClients.ReadOnly = True
        DataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        RefreshDataGridViewClients()

    End Sub

    Private Sub RefreshDataGridViewClients()
        Dim query As String = "SELECT * FROM clients"

        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)

                DataGridViewClients.DataSource = table

                ' Ocultar las columnas ID
                DataGridViewClients.Columns("ID").Visible = False
            End Using
        End Using
    End Sub

    Private Sub RefreshDataGridVieInventory()
        Dim query As String = "SELECT * FROM inventory"

        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)

                DataGridView.DataSource = table

                ' Ocultar las columnas ID
                DataGridView.Columns("ID").Visible = False
                DataGridView.Columns("Cedula").Visible = False
                DataGridView.Columns("Nombre").Visible = False
                DataGridView.Columns("Apellido").Visible = False
            End Using
        End Using
    End Sub

    '''
    ''' Boton EXIT
    '''

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    '''
    ''' Menu tooltrip
    '''

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clients.Show()
        Me.Hide()
    End Sub

    Private Sub AlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilerToolStripMenuItem.Click
        Alquiler.Show()
        Me.Hide()
    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        Export.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class