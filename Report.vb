Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Report

    Private Sub ReporteButton_Click(sender As Object, e As EventArgs) Handles ReporteButton.Click
        ExportToPDF()
    End Sub

    Private Sub ExportToPDF()

        ' Verificar si el DataGridView de inventory tiene datos
        If DataGridView.Rows.Count > 0 Then
            ' Crear el documento PDF para inventory
            Dim doc As New Document()
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("C:\Users\rafae\OneDrive\Escritorio\inventory.pdf", FileMode.Create))
            doc.Open()
            ' Crear la tabla para inventory
            Dim table As New PdfPTable(DataGridView.Columns.Count)
            ' Agregar encabezados de columna
            For Each column As DataGridViewColumn In DataGridView.Columns
                table.AddCell(column.HeaderText)
            Next
            ' Agregar filas y celdas con datos
            For Each row As DataGridViewRow In DataGridView.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing Then
                        table.AddCell(cell.Value.ToString())
                    Else
                        table.AddCell("") ' Opcionalmente, puedes agregar un valor predeterminado en caso de que la celda sea nula
                    End If
                Next
            Next

            ' Agregar la tabla de inventory al documento
            doc.Add(table)

            ' Agregar el recuento de productos al documento
            Dim productCount As Integer = CountProducts()
            Dim countTable As New PdfPTable(2)
            countTable.DefaultCell.Padding = 3
            countTable.WidthPercentage = 100
            countTable.HorizontalAlignment = Element.ALIGN_LEFT
            countTable.AddCell("Recuento de productos:")
            countTable.AddCell(productCount.ToString())
            doc.Add(countTable)


            ' Cerrar el documento de inventory
            doc.Close()

            MessageBox.Show("La tabla 'inventory' se ha exportado a un archivo PDF.")
        Else
            MessageBox.Show("No hay datos en la tabla 'inventory'.")
        End If

        ' Verificar si el DataGridView de clientes tiene datos
        If DataGridViewClients.Rows.Count > 0 Then
            ' Crear el documento PDF para clientes
            Dim docClientes As New Document()
            Dim pdfWriterClientes As PdfWriter = PdfWriter.GetInstance(docClientes, New FileStream("C:\Users\rafae\OneDrive\Escritorio\clientes.pdf", FileMode.Create))
            docClientes.Open()

            ' Crear la tabla para clientes
            Dim tableClientes As New PdfPTable(DataGridViewClients.Columns.Count)
            ' Agregar encabezados de columna
            For Each column As DataGridViewColumn In DataGridViewClients.Columns
                tableClientes.AddCell(column.HeaderText)
            Next
            ' Agregar filas y celdas con datos
            For Each row As DataGridViewRow In DataGridViewClients.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing Then
                        tableClientes.AddCell(cell.Value.ToString())
                    Else
                        tableClientes.AddCell("") ' Opcionalmente, puedes agregar un valor predeterminado en caso de que la celda sea nula
                    End If
                Next
            Next

            ' Agregar la tabla de clientes al documento
            docClientes.Add(tableClientes)

            ' Agregar el recuento de productos al documento
            Dim clientesCount As Integer = CountClientes()
            Dim countclientesTable As New PdfPTable(2)
            countclientesTable.DefaultCell.Padding = 3
            countclientesTable.WidthPercentage = 100
            countclientesTable.HorizontalAlignment = Element.ALIGN_LEFT
            countclientesTable.AddCell("Recuento de Clientes:")
            countclientesTable.AddCell(clientesCount.ToString())
            docClientes.Add(countclientesTable)

            ' Cerrar el documento de clientes
            docClientes.Close()

            MessageBox.Show("La tabla 'clientes' se ha exportado a un archivo PDF.")
        Else
            MessageBox.Show("No hay datos en la tabla 'clientes'.")
        End If
    End Sub
    Private Function Count()

        Dim productCount As Integer = CountProducts()
        Dim clientesCount As Integer = CountClientes()

        RecuentoLabel.Text = "Recuento de productos en el inventario: " & productCount.ToString() & vbCrLf &
                          "Recuento de clientes: " & clientesCount.ToString()
    End Function



    Private Function CountProducts() As Integer
        Return DataGridView.Rows.Count
    End Function

    Private Function CountClientes() As Integer
        Return DataGridViewClients.Rows.Count
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
        IMS.Show()
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