Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing

Public Class Clients
    Dim Con As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")

    Public Sub CreateClientsTable()
        Try
            Con.Open()

            Dim cmd As New SqlCommand("CREATE TABLE clients (ID INT IDENTITY(1,1) PRIMARY KEY, Nombre VARCHAR(50), Apellido VARCHAR(50), Cedula INT, Telefono VARCHAR(12), Correo VARCHAR(50))", Con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MessageBox.Show("Error creating inventory table: " & ex.Message)'
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateClientsTable()
        DataGridViewClients.ReadOnly = True
        DataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        RefreshDataGridView()
    End Sub

    Private Sub RefreshDataGridView()
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

    Private Function ValidarCedula(ByVal cedula As String) As Boolean
        ' Expresión regular para validar la cédula
        Dim regex As New Regex("^\d{7,8}$")

        ' Verificar si la cédula cumple con el formato
        If regex.IsMatch(cedula) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub NombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            ' Allow control characters (e.g., backspace, delete)
            Exit Sub
        ElseIf NombreTextBox.Text.Length >= 20 Then
            ' Cancel the key press if the length exceeds 20 characters
            e.Handled = True
        End If
    End Sub

    Private Sub ApellidoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            ' Allow control characters (e.g., backspace, delete)
            Exit Sub
        ElseIf ApellidoTextBox.Text.Length >= 20 Then
            ' Cancel the key press if the length exceeds 20 characters
            e.Handled = True
        End If
    End Sub

    Private Sub CedulaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CedulaTextBox.KeyPress
        ' Verificar si la longitud del texto excede los 09 caracteres
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If CedulaTextBox.Text.Length >= 9 Then
            ' Cancelar la pulsación de tecla
            e.Handled = True
        End If
    End Sub

    Private Sub TelefonoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        ' Verificar si la longitud del texto excede los 12 caracteres
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If TelefonoTextBox.Text.Length >= 12 Then
            ' Cancelar la pulsación de tecla
            e.Handled = True
        End If
    End Sub

    Private Sub CorreoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CorreoTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            ' Allow control characters (e.g., backspace, delete)
            Exit Sub
        End If
        ' Allow all other characters
        e.Handled = False
        ' Verificar si la longitud del texto excede los 20 caracteres
        If CorreoTextBox.Text.Length >= 20 Then
            ' Cancelar la pulsación de tecla
            e.Handled = True
        End If
    End Sub

    Private Sub AddClientsButton_Click(sender As Object, e As EventArgs) Handles AddClientsButton.Click
        Dim pattern As String = "^[a-zA-Z]+$"
        Dim nombre As String = NombreTextBox.Text.ToUpper()
        Dim apellido As String = ApellidoTextBox.Text.ToUpper()
        Dim cedulaText As String = CedulaTextBox.Text()
        Dim telefono As String = TelefonoTextBox.Text()
        Dim correo As String = CorreoTextBox.Text

        ' Verificar si todas las casillas están vacías
        If String.IsNullOrWhiteSpace(nombre) AndAlso
       String.IsNullOrWhiteSpace(apellido) AndAlso
       String.IsNullOrWhiteSpace(cedulaText) AndAlso
       String.IsNullOrWhiteSpace(telefono) AndAlso
       String.IsNullOrWhiteSpace(correo) Then
            MessageBox.Show("Las casillas no pueden estar vacías.")
            Return
        End If


        If String.IsNullOrEmpty(cedulaText) Then
            MessageBox.Show("El campo de cédula está vacío. Por favor, ingrese un valor.")
            Return
        End If

        Dim cedula As Integer

        If Not Integer.TryParse(cedulaText, cedula) Then
            MessageBox.Show("El valor de cédula no es válido. Por favor, ingrese un número entero válido.")
            Return
        End If

        ' Validar el nombre
        If Not Regex.IsMatch(nombre, pattern) Then
            MessageBox.Show("El nombre debe ser solo texto.")
            Return
        End If

        ' Validar el apellido
        If Not Regex.IsMatch(apellido, pattern) Then
            MessageBox.Show("El apellido debe ser solo texto.")
            Return
        End If

        ' Verificar si la cédula ya existe en la base de datos
        Dim queryCheckCedula As String = "SELECT COUNT(*) FROM clients WHERE Cedula = @Cedula"

        Using cmdCheckCedula As New SqlCommand(queryCheckCedula, Con)
            cmdCheckCedula.Parameters.AddWithValue("@Cedula", cedula)

            Con.Open()
            Dim count As Integer = Convert.ToInt32(cmdCheckCedula.ExecuteScalar())
            Con.Close()

            If count > 0 Then
                MessageBox.Show("La cédula ya existe en la base de datos.")
                Return
            End If
        End Using

        ' Validar el correo electrónico
        If String.IsNullOrWhiteSpace(correo) Then
            MessageBox.Show("El campo de correo electrónico está vacío.")
            Return
        End If

        Try
            Dim mailAddress As New System.Net.Mail.MailAddress(correo)
        Catch ex As FormatException
            MessageBox.Show("El correo electrónico ingresado no es válido.")
            Return
        End Try


        Dim query As String = "INSERT INTO clients (Nombre, Apellido, Cedula, Telefono, Correo) VALUES (@Nombre, @Apellido, @Cedula, @Telefono, @Correo)"

        Using cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@Nombre", nombre)
            cmd.Parameters.AddWithValue("@Apellido", apellido)
            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Telefono", telefono)
            cmd.Parameters.AddWithValue("@Correo", correo)

            Con.Open()
            cmd.ExecuteNonQuery()
            Con.Close()
        End Using

        MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Limpiar los campos después de agregar el cliente
        NombreTextBox.Clear()
        ApellidoTextBox.Clear()
        CedulaTextBox.Clear()
        TelefonoTextBox.Clear()
        CorreoTextBox.Clear()
        'MessageBox.Show("Por favor, ingrese valores numéricos válidos para la cédula y el teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)'

        RefreshDataGridView()

    End Sub

    '''
    ''' Boton EDIT
    '''

    Private Sub EditClientsButton_Click(sender As Object, e As EventArgs) Handles EditClientsButton.Click

        Dim nombre As String = NombreTextBox.Text
        Dim apellido As String = ApellidoTextBox.Text
        Dim cedulaText As String = CedulaTextBox.Text
        Dim telefono As String = TelefonoTextBox.Text
        Dim correo As String = CorreoTextBox.Text

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(apellido) OrElse String.IsNullOrEmpty(cedulaText) OrElse String.IsNullOrEmpty(telefono) OrElse String.IsNullOrEmpty(correo) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cedula As Integer

        If Not Integer.TryParse(cedulaText, cedula) Then
            MessageBox.Show("El valor de cédula no es válido. Por favor, ingrese un número entero válido.")
            Return
        End If

        Dim query As String = "UPDATE clients SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Correo = @Correo WHERE Cedula = @Cedula"

        Using Con As New SqlConnection("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Apellido", apellido)
                cmd.Parameters.AddWithValue("@Cedula", cedulaText)
                cmd.Parameters.AddWithValue("@Telefono", telefono)
                cmd.Parameters.AddWithValue("@Correo", correo)

                Con.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Con.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se encontró ningún cliente con la cédula proporcionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using

        ' Limpiar los campos después de editar el cliente
        NombreTextBox.Clear()
        ApellidoTextBox.Clear()
        CedulaTextBox.Clear()
        TelefonoTextBox.Clear()
        CorreoTextBox.Clear()

        RefreshDataGridView()
    End Sub


    '''
    ''' Boton DEL
    '''

    Private Sub DelClientsButton_Click(sender As Object, e As EventArgs) Handles DelClientsButton.Click

        Dim cedulaText As String = CedulaTextBox.Text()

        If String.IsNullOrEmpty(cedulaText) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cedula As Integer

        If Not Integer.TryParse(cedulaText, cedula) Then
            MessageBox.Show("El valor de cédula no es válido. Por favor, ingrese un número entero válido.")
            Return
        End If

        Dim query As String = "DELETE FROM clients WHERE Cedula = @Cedula"

        Using cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@Cedula", cedulaText)

            Con.Open()
            cmd.ExecuteNonQuery()
            Con.Close()
        End Using

        ' Actualizar el DataGridView
        RefreshDataGridView()

        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    '''
    ''' Boton CLS
    '''

    Private Sub ClsClientsButton_Click(sender As Object, e As EventArgs) Handles ClsClientsButton.Click
        Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea borrar y restablecer toda la tabla?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Dim query As String = "TRUNCATE TABLE clients"

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

    Private Sub ExitClientsButton_Click(sender As Object, e As EventArgs) Handles ExitClientsButton.Click
        Application.Exit()
    End Sub

    '''
    ''' Menu tooltrip
    '''

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        IMS.Show()
        Me.Close()
    End Sub

    Private Sub AlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilerToolStripMenuItem.Click
        Alquiler.Show()
        Me.Close()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Report.Show()
        Me.Close()
    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        Export.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class