<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LoginButton = New Button()
        UsernameBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PasswordBox = New TextBox()
        Label3 = New Label()
        ForgetPasswordButton = New Button()
        ExitButton = New Button()
        MenuStrip1 = New MenuStrip()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(131, 344)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(94, 29)
        LoginButton.TabIndex = 0
        LoginButton.Text = "Ingresar"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' UsernameBox
        ' 
        UsernameBox.Location = New Point(131, 132)
        UsernameBox.Name = "UsernameBox"
        UsernameBox.Size = New Size(213, 27)
        UsernameBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(169, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 2
        Label1.Text = "Usuario o correo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(150, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 20)
        Label2.TabIndex = 3
        Label2.Text = "Autenticación de Usuario"
        ' 
        ' PasswordBox
        ' 
        PasswordBox.Location = New Point(131, 226)
        PasswordBox.Name = "PasswordBox"
        PasswordBox.Size = New Size(213, 27)
        PasswordBox.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(169, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 5
        Label3.Text = "Contraseña"
        ' 
        ' ForgetPasswordButton
        ' 
        ForgetPasswordButton.Location = New Point(131, 379)
        ForgetPasswordButton.Name = "ForgetPasswordButton"
        ForgetPasswordButton.Size = New Size(194, 29)
        ForgetPasswordButton.TabIndex = 6
        ForgetPasswordButton.Text = "Recuperar contraseña"
        ForgetPasswordButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(231, 344)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 7
        ExitButton.Text = "Salida"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AcercaDeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(474, 28)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(89, 24)
        AcercaDeToolStripMenuItem.Text = "Acerca de"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(474, 457)
        Controls.Add(ExitButton)
        Controls.Add(ForgetPasswordButton)
        Controls.Add(Label3)
        Controls.Add(PasswordBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(UsernameBox)
        Controls.Add(LoginButton)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ForgetPasswordButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
