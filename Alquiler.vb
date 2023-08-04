Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports DocumentFormat.OpenXml.Office2010.Excel

Public Class Alquiler
    Dim Con As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")

    '''
    ''' Carga del Programa
    '''

    Private Sub Alquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer el DataGridView como de solo lectura
        DataGridView.ReadOnly = True
        DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill'
        RefreshDataGridView()
        DataGridView1.ReadOnly = True
        RefreshDataGridClientsView()
    End Sub

    Private Sub RefreshDataGridView()
        Dim query As String = "SELECT * FROM inventory"

        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)

                DataGridView.DataSource = table

                ' Ocultar las columnas ID
                DataGridView.Columns("ID").Visible = False
                DataGridView.Columns("Descripción").Visible = False
                DataGridView.Columns("Hora").Visible = False
                DataGridView.Columns("Fecha").Visible = False
            End Using
        End Using
    End Sub

    Private Sub RefreshDataGridClientsView()
        Dim query As String = "SELECT * FROM clients"

        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)

                DataGridView1.DataSource = table

                ' Ocultar las columnas ID, Telefono y Correo
                DataGridView1.Columns("ID").Visible = False
                DataGridView1.Columns("Telefono").Visible = False
                DataGridView1.Columns("Correo").Visible = False
            End Using
        End Using
    End Sub

    Public Sub AgregarColumnas()
        Dim connectionString As String = "Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True"
        Dim query As String = "ALTER TABLE inventory ADD Cedula VARCHAR(10), Nombre VARCHAR(50), Apellido VARCHAR(50)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub EliminarColumnas()
        Dim connectionString As String = "Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True"
        Dim query As String = "ALTER TABLE inventory DROP COLUMN cedula, nombre, apellido"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    '''
    ''' Boton Add
    '''

    Private Sub RentButton_Click(sender As Object, e As EventArgs) Handles RentButton.Click

        Dim serial As String = SerialTextBox.Text
        Dim cedula As Integer

        If Integer.TryParse(CedulaTextBox.Text, cedula) Then
            Dim objetoEncontrado As Boolean = False
            Dim clienteEncontrado As Boolean = False

            Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
                connection.Open()

                ' Verificar si el objeto existe en la base de datos
                Dim queryExistence As String = "SELECT COUNT(*) FROM inventory WHERE Serial = @Serial"
                Using commandExistence As New SqlCommand(queryExistence, connection)
                    commandExistence.Parameters.AddWithValue("@Serial", serial)
                    Dim count As Integer = Convert.ToInt32(commandExistence.ExecuteScalar())

                    If count > 0 Then
                        objetoEncontrado = True

                        ' Verificar si el cliente existe en la base de datos
                        Dim queryClientExistence As String = "SELECT COUNT(*) FROM clients WHERE Cedula = @Cedula"
                        Using commandClientExistence As New SqlCommand(queryClientExistence, connection)
                            commandClientExistence.Parameters.AddWithValue("@Cedula", cedula)
                            Dim clientCount As Integer = Convert.ToInt32(commandClientExistence.ExecuteScalar())

                            If clientCount > 0 Then
                                clienteEncontrado = True

                                ' Obtener los datos del cliente correspondiente a la cédula ingresada
                                Dim queryClient As String = "SELECT Nombre, Apellido FROM clients WHERE Cedula = @Cedula"
                                Using commandClient As New SqlCommand(queryClient, connection)
                                    commandClient.Parameters.AddWithValue("@Cedula", cedula)
                                    Dim reader As SqlDataReader = commandClient.ExecuteReader()

                                    If reader.Read() Then
                                        Dim nombre As String = reader("Nombre").ToString()
                                        Dim apellido As String = reader("Apellido").ToString()

                                        reader.Close()

                                        ' Actualizar la tabla "inventory" con los datos del cliente
                                        Dim queryInventory As String = "UPDATE inventory SET Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula WHERE Serial = @Serial"
                                        Using commandInventory As New SqlCommand(queryInventory, connection)
                                            commandInventory.Parameters.AddWithValue("@Nombre", nombre)
                                            commandInventory.Parameters.AddWithValue("@Apellido", apellido)
                                            commandInventory.Parameters.AddWithValue("@Cedula", cedula)
                                            commandInventory.Parameters.AddWithValue("@Serial", serial)
                                            commandInventory.ExecuteNonQuery()
                                        End Using
                                    End If
                                End Using
                            End If
                        End Using
                    End If
                End Using
            End Using

            If Not objetoEncontrado Then
                MessageBox.Show("No se encontró ningún objeto con el serial ingresado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not clienteEncontrado Then
                MessageBox.Show("No se encontró ningún cliente con la cédula ingresada en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' La cédula ingresada no es un número válido
            MessageBox.Show("La cédula ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        RefreshDataGridView()
    End Sub


    Private Sub UnRentButton_Click(sender As Object, e As EventArgs) Handles UnRentButton.Click
        Dim serial As String = SerialTextBox.Text
        Dim cedula As String = CedulaTextBox.Text

        For Each row As DataGridViewRow In DataGridView.Rows
            Dim serialCellValue As String = row.Cells("Serial").Value.ToString()
            Dim cedulaCellValue As String = row.Cells("Cedula").Value.ToString()
            If Not String.IsNullOrEmpty(serial) AndAlso serialCellValue = serial Then
                UpdateRow(row)
                Exit For
            ElseIf Not String.IsNullOrEmpty(cedula) AndAlso cedulaCellValue = cedula Then
                UpdateRow(row)
                Exit For
            End If
        Next
        RefreshDataGridView()
    End Sub

    Private Sub UpdateRow(row As DataGridViewRow)
        row.Cells("Estado").Value = "DISPONIBLE"
        row.Cells("Nombre").Value = DBNull.Value
        row.Cells("Apellido").Value = DBNull.Value
        row.Cells("Cedula").Value = DBNull.Value

        Dim id As Integer = Convert.ToInt32(row.Cells("ID").Value)
        Dim query As String = "UPDATE inventory SET Estado = 'DISPONIBLE', Nombre = NULL, Apellido = NULL, Cedula = NULL WHERE ID = @ID"

        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    '''
    ''' Menu tooltrip
    '''

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        'IMS.Show()'
        Dim imsForm As New IMS()
        imsForm.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Clients.Show()
        Me.Hide()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Export.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class