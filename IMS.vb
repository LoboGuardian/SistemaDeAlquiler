Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class IMS
    Dim Con As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")

    Public Sub CreateInventoryTable()
        Try
            Con.Open()

            Dim cmd As New SqlCommand("CREATE TABLE inventory (ID INT IDENTITY(1,1) PRIMARY KEY, Marca VARCHAR(50), Modelo VARCHAR(50), Serial VARCHAR(50), Año INT, Cantidad INT, Color VARCHAR(50), Descripción VARCHAR(50), Estado VARCHAR(50), Hora VARCHAR(10), Fecha VARCHAR(10))", Con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MessageBox.Show("Error creating inventory table: " & ex.Message)'
        Finally
            Con.Close()
        End Try
    End Sub


    '''
    ''' Carga del Programa
    '''

    Private Sub IMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateInventoryTable()
        ' Establecer el DataGridView como de solo lectura
        DataGridView.ReadOnly = True
        DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill'
        RefreshDataGridView()
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
                DataGridView.Columns("Cedula").Visible = False
                DataGridView.Columns("Nombre").Visible = False
                DataGridView.Columns("Apellido").Visible = False
            End Using
        End Using
    End Sub

    '''
    ''' Boton Add
    '''

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim pattern As String = "^[a-zA-Z]+$"
        Dim marca As String = MarcaTextBox.Text.ToUpper()
        Dim modelo As String = ModeloTextBox.Text.ToUpper()
        Dim serial As String = SerialTextBox.Text.ToUpper()
        Dim año As Integer
        Dim cantidad As Integer
        Dim color As String = ColorTextBox.Text.ToUpper()
        Dim descripcion As String = DescripcionTextBox.Text.ToUpper()
        Dim estado As String = "DISPONIBLE"
        Dim fechaActual As DateTime = DateTime.Now
        Dim horaMinutos As String = fechaActual.ToString("HH:mm")
        Dim fechaCompleta As String = fechaActual.ToString("yyyy-MM-dd")

        ' Verificar si todas las casillas están vacías
        If String.IsNullOrWhiteSpace(marca) AndAlso
       String.IsNullOrWhiteSpace(modelo) AndAlso
       String.IsNullOrWhiteSpace(serial) AndAlso
       String.IsNullOrWhiteSpace(AñoTextBox.Text) AndAlso
       String.IsNullOrWhiteSpace(CantidadTextBox.Text) AndAlso
       String.IsNullOrWhiteSpace(color) AndAlso
       String.IsNullOrWhiteSpace(descripcion) Then
            MessageBox.Show("Las casillas no pueden estar vacías.")
            Return
        End If

        ' Validar la marca
        If Not Regex.IsMatch(marca, pattern) Then
            MessageBox.Show("La marca debe ser solo texto.")
            Return
        End If

        ' Validar el modelo
        If Not Regex.IsMatch(modelo, pattern) Then
            MessageBox.Show("El modelo debe ser solo texto.")
            Return
        End If

        ' Validar el año
        If Not IsNumeric(AñoTextBox.Text) Then
            MessageBox.Show("El año debe ser un valor numérico.")
            Return
        End If

        año = Integer.Parse(AñoTextBox.Text)

        ' Validar la cantidad
        If Not IsNumeric(CantidadTextBox.Text) Then
            MessageBox.Show("La cantidad debe ser un valor numérico.")
            Return
        End If

        cantidad = Integer.Parse(CantidadTextBox.Text)

        ' Validar el color
        If Not Regex.IsMatch(color, pattern) Then
            MessageBox.Show("El color debe ser solo texto.")
            Return
        End If

        ' Verificar si el serial ya existe en la base de datos
        Dim query As String = "SELECT COUNT(*) FROM inventory WHERE Serial = @Serial"
        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Serial", serial)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                connection.Close()

                If count > 0 Then
                    MessageBox.Show("El serial ya existe en la base de datos.")
                    Return
                End If
            End Using
        End Using

        ' Insertar los datos en la base de datos
        query = "INSERT INTO inventory (Marca, Modelo, Serial, Año, Cantidad, Color, Descripción, Estado, Hora, Fecha) VALUES (@Marca, @Modelo, @Serial, @Año, @Cantidad, @Color, @Descripción, @Estado, @Hora, @Fecha)"
        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Marca", marca)
                command.Parameters.AddWithValue("@Modelo", modelo)
                command.Parameters.AddWithValue("@Serial", serial)
                command.Parameters.AddWithValue("@Año", Integer.Parse(AñoTextBox.Text))
                command.Parameters.AddWithValue("@Cantidad", cantidad)
                command.Parameters.AddWithValue("@Color", color)
                command.Parameters.AddWithValue("@Descripción", descripcion)
                command.Parameters.AddWithValue("@Estado", estado)
                command.Parameters.AddWithValue("@Hora", horaMinutos)
                command.Parameters.AddWithValue("@Fecha", fechaCompleta)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                RefreshDataGridView()
            End Using
        End Using

        MarcaTextBox.Clear()
        ModeloTextBox.Clear()
        SerialTextBox.Clear()
        AñoTextBox.Clear()
        CantidadTextBox.Clear()
        ColorTextBox.Clear()
        DescripcionTextBox.Clear()

    End Sub

    '''
    ''' Boton EDIT
    '''

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        ' Obtener los valores actualizados de los campos
        Dim marca As String = MarcaTextBox.Text.ToUpper()
        Dim modelo As String = ModeloTextBox.Text.ToUpper()
        Dim serial As String = SerialTextBox.Text.ToUpper()
        Dim año As Integer
        Dim cantidad As Integer
        Dim color As String = ColorTextBox.Text.ToUpper()
        Dim descripcion As String = DescripcionTextBox.Text.ToUpper()

        ' Validar los campos actualizados (condiciones individuales para cada casilla)
        If Not String.IsNullOrWhiteSpace(marca) AndAlso Not Regex.IsMatch(marca, "^[a-zA-Z]+$") Then
            MessageBox.Show("La marca debe ser solo texto.")
            Return
        End If

        If Not String.IsNullOrWhiteSpace(modelo) AndAlso Not Regex.IsMatch(modelo, "^[a-zA-Z]+$") Then
            MessageBox.Show("El modelo debe ser solo texto.")
            Return
        End If

        If Not String.IsNullOrWhiteSpace(serial) AndAlso Not Regex.IsMatch(serial, "^[a-zA-Z]+$") Then
            MessageBox.Show("El serial debe ser solo texto.")
            Return
        End If

        If Not String.IsNullOrWhiteSpace(AñoTextBox.Text) AndAlso Not IsNumeric(AñoTextBox.Text) Then
            MessageBox.Show("El año debe ser un valor numérico.")
            Return
        End If

        If Not String.IsNullOrWhiteSpace(CantidadTextBox.Text) AndAlso Not IsNumeric(CantidadTextBox.Text) Then
            MessageBox.Show("La cantidad debe ser un valor numérico.")
            Return
        End If

        If Not String.IsNullOrWhiteSpace(color) AndAlso Not Regex.IsMatch(color, "^[a-zA-Z]+$") Then
            MessageBox.Show("El color debe ser solo texto.")
            Return
        End If

        ' Actualizar los datos en la base de datos
        Dim query As String = "UPDATE inventory SET Marca = @Marca, Modelo = @Modelo, Año = @Año, Cantidad = @Cantidad, Color = @Color, Descripción = @Descripción WHERE Serial = @Serial"
        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Marca", marca)
                command.Parameters.AddWithValue("@Modelo", modelo)
                command.Parameters.AddWithValue("@Año", Integer.TryParse(AñoTextBox.Text, año))
                command.Parameters.AddWithValue("@Cantidad", Integer.TryParse(CantidadTextBox.Text, cantidad))
                command.Parameters.AddWithValue("@Color", color)
                command.Parameters.AddWithValue("@Descripción", descripcion)
                command.Parameters.AddWithValue("@Serial", serial)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                RefreshDataGridView()
            End Using
        End Using

        ' Limpiar los campos después de la edición
        MarcaTextBox.Clear()
        ModeloTextBox.Clear()
        SerialTextBox.Clear()
        AñoTextBox.Clear()
        CantidadTextBox.Clear()
        ColorTextBox.Clear()
        DescripcionTextBox.Clear()

        ' Mostrar un mensaje de éxito
        MessageBox.Show("Los datos se han actualizado correctamente.")

    End Sub

    '''
    ''' Boton DEL
    '''

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        Dim serial As String = SerialTextBox.Text.Trim()

        ' Create a SQL query to delete the rows based on the serial number
        Dim query As String = "DELETE FROM inventory WHERE Serial = @Serial"

        ' Create a SqlConnection and SqlCommand objects
        Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                ' Add the serial number parameter to the command
                command.Parameters.AddWithValue("@Serial", serial)

                ' Open the connection
                connection.Open()

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Check the number of rows affected
                If rowsAffected > 0 Then
                    MessageBox.Show("Item borrado exitosamente.")
                Else
                    MessageBox.Show("No se ha encontrado item por ese serial.")
                End If
            End Using
        End Using
        RefreshDataGridView()
    End Sub

    '''
    ''' Boton CLS
    '''

    Private Sub ClsButton_Click(sender As Object, e As EventArgs) Handles ClsButton.Click
        Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea borrar y restablecer toda la tabla?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Dim query As String = "TRUNCATE TABLE inventory"

            Using connection As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                    RefreshDataGridView()
                End Using
            End Using
        End If
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

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        Export.Show()
        Me.Hide()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class