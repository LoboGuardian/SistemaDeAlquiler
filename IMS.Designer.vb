<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMS
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
        MenuStrip1 = New MenuStrip()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AlquilerToolStripMenuItem = New ToolStripMenuItem()
        ReporteToolStripMenuItem = New ToolStripMenuItem()
        RegistroToolStripMenuItem = New ToolStripMenuItem()
        RespaldoToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        ModeloTextBox = New TextBox()
        Label2 = New Label()
        MarcaLabel = New Label()
        MarcaTextBox = New TextBox()
        SerialTextBox = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DescripcionTextBox = New TextBox()
        AddButton = New Button()
        EditButton = New Button()
        DelButton = New Button()
        ClsButton = New Button()
        DataGridView = New DataGridView()
        ExitButton = New Button()
        AñoTextBox = New TextBox()
        CantidadTextBox = New TextBox()
        ColorTextBox = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, AlquilerToolStripMenuItem, ReporteToolStripMenuItem, RegistroToolStripMenuItem, RespaldoToolStripMenuItem, AcercaDeToolStripMenuItem, CerrarSesiónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(871, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(75, 24)
        ClientesToolStripMenuItem.Text = "Clientes"
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
        ' RegistroToolStripMenuItem
        ' 
        RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        RegistroToolStripMenuItem.Size = New Size(78, 24)
        RegistroToolStripMenuItem.Text = "Registro"
        ' 
        ' RespaldoToolStripMenuItem
        ' 
        RespaldoToolStripMenuItem.Name = "RespaldoToolStripMenuItem"
        RespaldoToolStripMenuItem.Size = New Size(85, 24)
        RespaldoToolStripMenuItem.Text = "Respaldo"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(89, 24)
        AcercaDeToolStripMenuItem.Text = "Acerca de"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Khaki
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(25, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 23)
        Label3.TabIndex = 13
        Label3.Text = "Modelo"
        ' 
        ' ModeloTextBox
        ' 
        ModeloTextBox.Location = New Point(99, 105)
        ModeloTextBox.Name = "ModeloTextBox"
        ModeloTextBox.Size = New Size(202, 27)
        ModeloTextBox.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Khaki
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(299, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 23)
        Label2.TabIndex = 11
        Label2.Text = "Sistema de Inventario IMS"
        ' 
        ' MarcaLabel
        ' 
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = Color.Khaki
        MarcaLabel.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        MarcaLabel.Location = New Point(25, 76)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New Size(57, 23)
        MarcaLabel.TabIndex = 10
        MarcaLabel.Text = "Marca"
        ' 
        ' MarcaTextBox
        ' 
        MarcaTextBox.Location = New Point(99, 76)
        MarcaTextBox.Name = "MarcaTextBox"
        MarcaTextBox.Size = New Size(202, 27)
        MarcaTextBox.TabIndex = 9
        ' 
        ' SerialTextBox
        ' 
        SerialTextBox.Location = New Point(99, 135)
        SerialTextBox.Name = "SerialTextBox"
        SerialTextBox.Size = New Size(202, 27)
        SerialTextBox.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Khaki
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(25, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 23)
        Label1.TabIndex = 16
        Label1.Text = "Serial"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Khaki
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(325, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 23)
        Label4.TabIndex = 22
        Label4.Text = "Color"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Khaki
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(324, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 23)
        Label5.TabIndex = 20
        Label5.Text = "Cantidad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Khaki
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(325, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 23)
        Label6.TabIndex = 18
        Label6.Text = "Año"
        ' 
        ' DescripcionTextBox
        ' 
        DescripcionTextBox.Location = New Point(670, 102)
        DescripcionTextBox.Multiline = True
        DescripcionTextBox.Name = "DescripcionTextBox"
        DescripcionTextBox.Size = New Size(174, 60)
        DescripcionTextBox.TabIndex = 23
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.Khaki
        AddButton.FlatStyle = FlatStyle.Popup
        AddButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        AddButton.Location = New Point(25, 177)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(94, 29)
        AddButton.TabIndex = 25
        AddButton.Text = "Añadir"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' EditButton
        ' 
        EditButton.BackColor = Color.Khaki
        EditButton.FlatStyle = FlatStyle.Popup
        EditButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        EditButton.Location = New Point(125, 177)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(94, 29)
        EditButton.TabIndex = 26
        EditButton.Text = "Editar"
        EditButton.UseVisualStyleBackColor = False
        ' 
        ' DelButton
        ' 
        DelButton.BackColor = Color.Khaki
        DelButton.FlatStyle = FlatStyle.Popup
        DelButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DelButton.Location = New Point(225, 177)
        DelButton.Name = "DelButton"
        DelButton.Size = New Size(94, 29)
        DelButton.TabIndex = 27
        DelButton.Text = "Borrar"
        DelButton.UseVisualStyleBackColor = False
        ' 
        ' ClsButton
        ' 
        ClsButton.BackColor = Color.Khaki
        ClsButton.FlatStyle = FlatStyle.Popup
        ClsButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ClsButton.Location = New Point(325, 177)
        ClsButton.Name = "ClsButton"
        ClsButton.Size = New Size(94, 29)
        ClsButton.TabIndex = 28
        ClsButton.Text = "Limpiar"
        ClsButton.UseVisualStyleBackColor = False
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(25, 215)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.RowTemplate.Height = 29
        DataGridView.Size = New Size(834, 223)
        DataGridView.TabIndex = 29
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.Khaki
        ExitButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ExitButton.Location = New Point(765, 180)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 14
        ExitButton.Text = "Salida"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' AñoTextBox
        ' 
        AñoTextBox.Location = New Point(429, 76)
        AñoTextBox.Name = "AñoTextBox"
        AñoTextBox.Size = New Size(201, 27)
        AñoTextBox.TabIndex = 17
        ' 
        ' CantidadTextBox
        ' 
        CantidadTextBox.Location = New Point(428, 106)
        CantidadTextBox.Name = "CantidadTextBox"
        CantidadTextBox.Size = New Size(202, 27)
        CantidadTextBox.TabIndex = 19
        ' 
        ' ColorTextBox
        ' 
        ColorTextBox.Location = New Point(429, 136)
        ColorTextBox.Name = "ColorTextBox"
        ColorTextBox.Size = New Size(201, 27)
        ColorTextBox.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Khaki
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(671, 68)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 23)
        Label7.TabIndex = 24
        Label7.Text = "Descripción"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.home_background_image_1080x337
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(877, 340)
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.home_background_image_1080x337
        PictureBox2.Location = New Point(0, 189)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(877, 340)
        PictureBox2.TabIndex = 31
        PictureBox2.TabStop = False
        ' 
        ' IMS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 450)
        Controls.Add(DataGridView)
        Controls.Add(ClsButton)
        Controls.Add(DelButton)
        Controls.Add(EditButton)
        Controls.Add(AddButton)
        Controls.Add(Label7)
        Controls.Add(DescripcionTextBox)
        Controls.Add(Label4)
        Controls.Add(ColorTextBox)
        Controls.Add(Label5)
        Controls.Add(CantidadTextBox)
        Controls.Add(Label6)
        Controls.Add(AñoTextBox)
        Controls.Add(Label1)
        Controls.Add(SerialTextBox)
        Controls.Add(ExitButton)
        Controls.Add(Label3)
        Controls.Add(ModeloTextBox)
        Controls.Add(Label2)
        Controls.Add(MarcaLabel)
        Controls.Add(MarcaTextBox)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        MainMenuStrip = MenuStrip1
        Name = "IMS"
        Text = "IMS"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DelButton As Button
    Friend WithEvents ClsButton As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ExitButton As Button
    Friend WithEvents AñoTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents MBox As TextBox
    Friend WithEvents MarcaLabel As Label
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
