Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports OfficeOpenXml
Imports System.ComponentModel
Imports DocumentFormat.OpenXml

Public Class Export

    Private Function GenerarNombreArchivoUnico(rutaArchivo As String, fechaHoraActual As String) As String
        Dim contador As Integer = 1
        Dim nombreArchivo As String = "BaseDeDatos_" & fechaHoraActual & ".xlsx"
        Dim rutaCompleta As String = Path.Combine(rutaArchivo, nombreArchivo)

        While File.Exists(rutaCompleta)
            nombreArchivo = "BaseDeDatos_" & fechaHoraActual & "_" & contador.ToString() & ".xlsx"
            rutaCompleta = Path.Combine(rutaArchivo, nombreArchivo)
            contador += 1
        End While

        Return rutaCompleta
    End Function


    Private Sub ExportarTablaExcel(rutaArchivo As String)
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial
        Dim fechaHoraActual As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim rutaCompleta As String = GenerarNombreArchivoUnico(rutaArchivo, fechaHoraActual)

        Using package As New ExcelPackage(New FileInfo(rutaCompleta))
            ' Create "Inventory" worksheet
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Inventorio")

            Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
                connection.Open()
                ' Query inventory table
                Dim query As String = "SELECT * FROM inventory"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' ... Add data to "Inventory" worksheet
                        Dim columnIndex As Integer = 1
                        While reader.Read()
                            For i As Integer = 0 To reader.FieldCount - 1
                                Worksheet.Cells(1, columnIndex).Value = reader.GetName(i)
                                Worksheet.Cells(2, columnIndex).Value = reader(i)
                                columnIndex += 1
                            Next
                        End While
                    End Using
                End Using
            End Using

            ' Create "Cliente" worksheet
            worksheet = package.Workbook.Worksheets.Add("Clientes")

            Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
                connection.Open()
                ' Query clients table
                Dim query As String = "SELECT * FROM clients"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' ... Add data to "Cliente" worksheet
                        Dim columnIndex As Integer = 1
                        While reader.Read()
                            For i As Integer = 0 To reader.FieldCount - 1
                                Worksheet.Cells(1, columnIndex).Value = reader.GetName(i)
                                Worksheet.Cells(2, columnIndex).Value = reader(i)
                                columnIndex += 1
                            Next
                        End While
                    End Using
                End Using
            End Using

            package.Save()
        End Using
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Dim Inventory As ExcelWorksheet

        ' Call the method
        ExportarTablaExcel("C:\Users\rafae\OneDrive\Escritorio\")

        MessageBox.Show("Respaldo a Excel realizado.")

    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    '''
    ''' Menu tooltrip
    '''


    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        IMS.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clients.Show()
        Me.Hide()
    End Sub

    Private Sub AlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilerToolStripMenuItem.Click
        Alquiler.Show()
        Me.Hide()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Report.Show()
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