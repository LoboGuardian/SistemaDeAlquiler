Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms

Public Class Form1

    Dim connectionString As String = ("Data Source=DELL-G15;Initial Catalog=db;Integrated Security=True")
    Dim logFilePath As String = "C:\Users\rafae\OneDrive\Escritorio\program_stats.log"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateUsers()
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DeleteTable()
    End Sub

    Private Sub CreateUsers()

        Dim query As String = "INSERT INTO login (id, username, password) VALUES (@id, @username, @password)"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Crear usuario "user"
            Dim queryUser As String = "INSERT INTO login (username, password, email) VALUES (@username, @password, @email)"
            Using commandUser As New SqlCommand(queryUser, connection)
                commandUser.Parameters.AddWithValue("@username", "user")
                commandUser.Parameters.AddWithValue("@password", "user")
                commandUser.Parameters.AddWithValue("@email", "user@user.com")
                commandUser.ExecuteNonQuery()
            End Using

            ' Crear usuario "admin"
            Dim queryAdmin As String = "INSERT INTO login (username, password, email) VALUES (@username, @password, @email)"
            Using commandAdmin As New SqlCommand(queryAdmin, connection)
                commandAdmin.Parameters.AddWithValue("@username", "admin")
                commandAdmin.Parameters.AddWithValue("@password", "admin")
                commandAdmin.Parameters.AddWithValue("@email", "admin@admin.com")
                commandAdmin.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub DeleteTable()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "DROP TABLE login"
            Using command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        If username = "user" AndAlso password = "user" Then
            Return True
        End If

        Dim query As String = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password"
        Dim result As Integer

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                result = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return result > 0
    End Function

    Private Sub LoginButton_Click(sender As Object, e As EventArgs)
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña"
        Dim username As String = UsernameBox.Text
        Dim password As String = PasswordBox.Text

        If ValidateUser(username, password) Then
            If username = "user" AndAlso password = "user" Then
                MessageBox.Show("Inicio de sesión de usuario exitoso")
                'Dim Lend As New Lend()'
                'Lend.Show()'
                Me.Hide()
            Else
                MessageBox.Show("Inicio de sesión exitoso")
                Dim IMS As New IMS()
                IMS.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.Show()
        Me.Hide()
    End Sub

    Private Sub ForgetPasswordButton_Click(sender As Object, e As EventArgs) Handles ForgetPasswordButton.Click
        Dim username As String = UsernameBox.Text.Trim()
        Dim email As String = UsernameBox.Text.Trim()

        ' Realiza una consulta a la base de datos para buscar el nombre de usuario o dirección de correo electrónico
        ' y obtener la contraseña asociada
        Dim password As String = ObtenerContraseña(username, email)

        If Not String.IsNullOrEmpty(password) Then
            ' Envía un correo electrónico al usuario con la contraseña recuperada
            EnviarCorreoElectrónico(email, password)

            MessageBox.Show("Se ha enviado un correo electrónico con la contraseña recuperada.", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se encontró ningún usuario con los datos proporcionados.", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ObtenerContraseña(username As String, email As String) As String
        ' Realiza una consulta a la base de datos para buscar el nombre de usuario o dirección de correo electrónico
        ' y obtener la contraseña asociada
        ' Aquí debes implementar tu lógica para consultar la base de datos de SQL Server y obtener la contraseña
        ' Puedes utilizar ADO.NET o algún ORM como Entity Framework para realizar la consulta
        ' Retorna la contraseña encontrada o una cadena vacía si no se encontró ningún usuario
    End Function

    Private Sub EnviarCorreoElectrónico(email As String, password As String)
        ' Aquí debes implementar la lógica para enviar un correo electrónico al usuario con la contraseña recuperada
        ' Puedes utilizar la clase SmtpClient de System.Net.Mail para enviar el correo electrónico
        ' Asegúrate de configurar correctamente el servidor SMTP y las credenciales de autenticación en tu aplicación
    End Sub
End Class
