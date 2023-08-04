Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports OfficeOpenXml
Imports System.ComponentModel
Imports DocumentFormat.OpenXml

Public Class Export
    Public Sub ExportarTablaCSV(tabla As DataTable, rutaArchivo As String)
        Using writer As New StreamWriter(rutaArchivo)
            ' Escribir los encabezados de las columnas
            Dim encabezados As String = String.Join(",", tabla.Columns.Cast(Of DataColumn)().Select(Function(columna) columna.ColumnName))
            writer.WriteLine(encabezados)

            ' Escribir los datos de las filas
            For Each fila As DataRow In tabla.Rows
                Dim datosFila As String = String.Join(",", fila.ItemArray.Select(Function(dato) dato.ToString()))
                writer.WriteLine(datosFila)
            Next
        End Using
    End Sub

    Public Sub ExportarTablaExcel(tabla As DataTable, rutaArchivo As String)
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial
        Using package As New ExcelPackage(New FileInfo(rutaArchivo))
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Tabla")

            ' Escribir los encabezados de las columnas
            Dim columnaIndex As Integer = 1
            For Each columna As DataColumn In tabla.Columns
                worksheet.Cells(1, columnaIndex).Value = columna.ColumnName
                columnaIndex += 1
            Next

            ' Escribir los datos de las filas
            Dim filaIndex As Integer = 2
            For Each fila As DataRow In tabla.Rows
                columnaIndex = 1
                For Each columna As DataColumn In tabla.Columns
                    worksheet.Cells(filaIndex, columnaIndex).Value = fila(columna).ToString()
                    columnaIndex += 1
                Next
                filaIndex += 1
            Next

            package.Save()
        End Using
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click


        ' Crear el archivo de Excel
        Dim fileName As String = "C:\Users\rafae\OneDrive\Escritorio\archivo.xlsx"
        Using spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Create(fileName, SpreadsheetDocumentType.Workbook)
            ' Agregar una hoja de cálculo al libro de trabajo
            Dim workbookPart As WorkbookPart = spreadsheetDocument.AddWorkbookPart()
            workbookPart.Workbook = New Workbook()

            Dim worksheetPart As WorksheetPart = workbookPart.AddNewPart(Of WorksheetPart)()
            worksheetPart.Worksheet = New Worksheet(New SheetData())

            Dim sheets As Sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(New Sheets())
            Dim sheet As Sheet = New Sheet() With {
                .Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                .SheetId = 1,
                .Name = "Inventory"
            }
            sheets.Append(sheet)

            ' Obtener la hoja de cálculo
            Dim sheetData As SheetData = worksheetPart.Worksheet.GetFirstChild(Of SheetData)()

            ' Agregar los encabezados de columna
            Dim headerRow As Row = New Row()
            headerRow.Append(New Cell() With {
                .DataType = CellValues.String,
                .CellValue = New CellValue("ID")
            })
            headerRow.Append(New Cell() With {
                .DataType = CellValues.String,
                .CellValue = New CellValue("Marca")
            })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Modelo")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Serial")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Año")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Cantidad")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Color")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Descripción")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Estado")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Hora")
        })
            headerRow.Append(New Cell() With {
            .DataType = CellValues.String,
            .CellValue = New CellValue("Fecha")
        })
            sheetData.AppendChild(headerRow)

            Dim query As String = "SELECT * FROM inventory"

            Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Agregar los datos de la tabla "inventory"
                        While reader.Read()
                            Dim dataRow As Row = New Row()
                            dataRow.Append(New Cell() With {
                    .DataType = CellValues.Number,
                    .CellValue = New CellValue(reader("ID").ToString())
                })
                            dataRow.Append(New Cell() With {
                    .DataType = CellValues.String,
                    .CellValue = New CellValue(reader("Marca").ToString())
                })

                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Modelo").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Serial").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Año").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Cantidad").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Color").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Descripción").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Estado").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Hora").ToString())
                        })
                            dataRow.Append(New Cell() With {
                            .DataType = CellValues.String,
                            .CellValue = New CellValue(reader("Fecha").ToString())
                        })


                            sheetData.AppendChild(dataRow)
                        End While
                    End Using
                End Using
            End Using

            ' Guardar los cambios en el archivo de Excel
            worksheetPart.Worksheet.Save()
            spreadsheetDocument.Close()
        End Using
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    '''
    ''' Menu tooltrip
    '''

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