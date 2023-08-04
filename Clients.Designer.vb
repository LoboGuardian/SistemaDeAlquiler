<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox = New Label()
        NombreTextBox = New TextBox()
        DataGridViewClients = New DataGridView()
        ExitClientsButton = New Button()
        AddClientsButton = New Button()
        EditClientsButton = New Button()
        DelClientsButton = New Button()
        ClsClientsButton = New Button()
        Label1 = New Label()
        ApellidoTextBox = New TextBox()
        Label3 = New Label()
        TelefonoTextBox = New TextBox()
        Label4 = New Label()
        CedulaTextBox = New TextBox()
        Label5 = New Label()
        CorreoTextBox = New TextBox()
        MenuStrip1 = New MenuStrip()
        InventarioToolStripMenuItem = New ToolStripMenuItem()
        AlquilerToolStripMenuItem = New ToolStripMenuItem()
        ReporteToolStripMenuItem = New ToolStripMenuItem()
        RespaldoToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox
        ' 
        TextBox.AutoSize = True
        TextBox.BackColor = Color.Khaki
        TextBox.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox.Location = New Point(64, 36)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(73, 23)
        TextBox.TabIndex = 27
        TextBox.Text = "Nombre"
        ' 
        ' NombreTextBox
        ' 
        NombreTextBox.Location = New Point(138, 36)
        NombreTextBox.Name = "NombreTextBox"
        NombreTextBox.Size = New Size(202, 27)
        NombreTextBox.TabIndex = 26
        ' 
        ' DataGridViewClients
        ' 
        DataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewClients.Location = New Point(26, 190)
        DataGridViewClients.Name = "DataGridViewClients"
        DataGridViewClients.RowHeadersWidth = 51
        DataGridViewClients.RowTemplate.Height = 29
        DataGridViewClients.Size = New Size(751, 248)
        DataGridViewClients.TabIndex = 32
        ' 
        ' ExitClientsButton
        ' 
        ExitClientsButton.BackColor = Color.Khaki
        ExitClientsButton.FlatStyle = FlatStyle.Popup
        ExitClientsButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ExitClientsButton.Location = New Point(683, 155)
        ExitClientsButton.Name = "ExitClientsButton"
        ExitClientsButton.Size = New Size(94, 29)
        ExitClientsButton.TabIndex = 31
        ExitClientsButton.Text = "Salida"
        ExitClientsButton.UseVisualStyleBackColor = False
        ' 
        ' AddClientsButton
        ' 
        AddClientsButton.BackColor = Color.Khaki
        AddClientsButton.FlatStyle = FlatStyle.Popup
        AddClientsButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        AddClientsButton.Location = New Point(26, 155)
        AddClientsButton.Name = "AddClientsButton"
        AddClientsButton.Size = New Size(94, 29)
        AddClientsButton.TabIndex = 46
        AddClientsButton.Text = "Añadir"
        AddClientsButton.UseVisualStyleBackColor = False
        ' 
        ' EditClientsButton
        ' 
        EditClientsButton.BackColor = Color.Khaki
        EditClientsButton.FlatStyle = FlatStyle.Popup
        EditClientsButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        EditClientsButton.Location = New Point(126, 155)
        EditClientsButton.Name = "EditClientsButton"
        EditClientsButton.Size = New Size(94, 29)
        EditClientsButton.TabIndex = 47
        EditClientsButton.Text = "Editar"
        EditClientsButton.UseVisualStyleBackColor = False
        ' 
        ' DelClientsButton
        ' 
        DelClientsButton.BackColor = Color.Khaki
        DelClientsButton.FlatStyle = FlatStyle.Popup
        DelClientsButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DelClientsButton.Location = New Point(228, 155)
        DelClientsButton.Name = "DelClientsButton"
        DelClientsButton.Size = New Size(94, 29)
        DelClientsButton.TabIndex = 48
        DelClientsButton.Text = "Eliminar"
        DelClientsButton.UseVisualStyleBackColor = False
        ' 
        ' ClsClientsButton
        ' 
        ClsClientsButton.BackColor = Color.Khaki
        ClsClientsButton.FlatStyle = FlatStyle.Popup
        ClsClientsButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ClsClientsButton.Location = New Point(328, 155)
        ClsClientsButton.Name = "ClsClientsButton"
        ClsClientsButton.Size = New Size(94, 29)
        ClsClientsButton.TabIndex = 49
        ClsClientsButton.Text = "Limpiar"
        ClsClientsButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Khaki
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(64, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 23)
        Label1.TabIndex = 51
        Label1.Text = "Apellido"
        ' 
        ' ApellidoTextBox
        ' 
        ApellidoTextBox.Location = New Point(138, 69)
        ApellidoTextBox.Name = "ApellidoTextBox"
        ApellidoTextBox.Size = New Size(202, 27)
        ApellidoTextBox.TabIndex = 50
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Khaki
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(348, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 23)
        Label3.TabIndex = 53
        Label3.Text = "Telefono"
        ' 
        ' TelefonoTextBox
        ' 
        TelefonoTextBox.Location = New Point(431, 40)
        TelefonoTextBox.Name = "TelefonoTextBox"
        TelefonoTextBox.Size = New Size(202, 27)
        TelefonoTextBox.TabIndex = 52
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Khaki
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(64, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 23)
        Label4.TabIndex = 55
        Label4.Text = "Cedula"
        ' 
        ' CedulaTextBox
        ' 
        CedulaTextBox.Location = New Point(138, 104)
        CedulaTextBox.Name = "CedulaTextBox"
        CedulaTextBox.Size = New Size(202, 27)
        CedulaTextBox.TabIndex = 54
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Khaki
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(348, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 23)
        Label5.TabIndex = 57
        Label5.Text = "Correo"
        ' 
        ' CorreoTextBox
        ' 
        CorreoTextBox.Location = New Point(431, 75)
        CorreoTextBox.Name = "CorreoTextBox"
        CorreoTextBox.Size = New Size(202, 27)
        CorreoTextBox.TabIndex = 56
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InventarioToolStripMenuItem, AlquilerToolStripMenuItem, ReporteToolStripMenuItem, RespaldoToolStripMenuItem, CerrarSesiónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 58
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InventarioToolStripMenuItem
        ' 
        InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        InventarioToolStripMenuItem.Size = New Size(89, 24)
        InventarioToolStripMenuItem.Text = "Inventario"
        ' 
        ' AlquilerToolStripMenuItem
        ' 
        AlquilerToolStripMenuItem.Name = "AlquilerToolStripMenuItem"
        AlquilerToolStripMenuItem.Size = New Size(75, 24)
        AlquilerToolStripMenuItem.Text = "Alquiler"
        ' 
        ' ReporteToolStripMenuItem
        ' 
        ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        ReporteToolStripMenuItem.Size = New Size(76, 24)
        ReporteToolStripMenuItem.Text = "Reporte"
        ' 
        ' RespaldoToolStripMenuItem
        ' 
        RespaldoToolStripMenuItem.Name = "RespaldoToolStripMenuItem"
        RespaldoToolStripMenuItem.Size = New Size(85, 24)
        RespaldoToolStripMenuItem.Text = "Respaldo"
        ' 
        ' CerrarSesiónToolStripMenuItem
        ' 
        CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        CerrarSesiónToolStripMenuItem.Size = New Size(108, 24)
        CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(52, 24)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.client_wallpaper_12_1426x652
        PictureBox1.Location = New Point(0, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 419)
        PictureBox1.TabIndex = 59
        PictureBox1.TabStop = False
        ' 
        ' Clients
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(CorreoTextBox)
        Controls.Add(Label4)
        Controls.Add(CedulaTextBox)
        Controls.Add(Label3)
        Controls.Add(TelefonoTextBox)
        Controls.Add(Label1)
        Controls.Add(ApellidoTextBox)
        Controls.Add(ClsClientsButton)
        Controls.Add(DelClientsButton)
        Controls.Add(EditClientsButton)
        Controls.Add(AddClientsButton)
        Controls.Add(DataGridViewClients)
        Controls.Add(ExitClientsButton)
        Controls.Add(TextBox)
        Controls.Add(NombreTextBox)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        MainMenuStrip = MenuStrip1
        Name = "Clients"
        Text = "Clients"
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents TextBox As Label
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DataGridViewClients As DataGridView
    Friend WithEvents ExitClientsButton As Button
    Friend WithEvents AddClientsButton As Button
    Friend WithEvents EditClientsButton As Button
    Friend WithEvents DelClientsButton As Button
    Friend WithEvents ClsClientsButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CedulaTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
