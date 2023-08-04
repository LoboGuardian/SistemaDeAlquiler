<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquiler
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
        InventarioToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ReporteToolStripMenuItem = New ToolStripMenuItem()
        RespaldoToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        DataGridView = New DataGridView()
        RentButton = New Button()
        MarcaLabel = New Label()
        SerialTextBox = New TextBox()
        UnRentButton = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        CedulaTextBox = New TextBox()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InventarioToolStripMenuItem, ClientesToolStripMenuItem, ReporteToolStripMenuItem, RespaldoToolStripMenuItem, CerrarSesiónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InventarioToolStripMenuItem
        ' 
        InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        InventarioToolStripMenuItem.Size = New Size(89, 24)
        InventarioToolStripMenuItem.Text = "Inventario"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(75, 24)
        ClientesToolStripMenuItem.Text = "Clientes"
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
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(12, 183)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.RowTemplate.Height = 29
        DataGridView.Size = New Size(762, 255)
        DataGridView.TabIndex = 35
        ' 
        ' RentButton
        ' 
        RentButton.BackColor = Color.Khaki
        RentButton.FlatStyle = FlatStyle.Popup
        RentButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        RentButton.Location = New Point(41, 145)
        RentButton.Name = "RentButton"
        RentButton.Size = New Size(100, 29)
        RentButton.TabIndex = 34
        RentButton.Text = "Alquilar"
        RentButton.UseVisualStyleBackColor = False
        ' 
        ' MarcaLabel
        ' 
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = Color.Khaki
        MarcaLabel.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        MarcaLabel.Location = New Point(41, 44)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New Size(51, 23)
        MarcaLabel.TabIndex = 31
        MarcaLabel.Text = "Serial"
        ' 
        ' SerialTextBox
        ' 
        SerialTextBox.Location = New Point(115, 44)
        SerialTextBox.Name = "SerialTextBox"
        SerialTextBox.Size = New Size(159, 27)
        SerialTextBox.TabIndex = 30
        ' 
        ' UnRentButton
        ' 
        UnRentButton.BackColor = Color.Khaki
        UnRentButton.FlatStyle = FlatStyle.Popup
        UnRentButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UnRentButton.Location = New Point(155, 145)
        UnRentButton.Name = "UnRentButton"
        UnRentButton.Size = New Size(100, 29)
        UnRentButton.TabIndex = 36
        UnRentButton.Text = "Devuelto"
        UnRentButton.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(305, 44)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(469, 119)
        DataGridView1.TabIndex = 37
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Khaki
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(41, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 23)
        Label1.TabIndex = 39
        Label1.Text = "Cedula"
        ' 
        ' CedulaTextBox
        ' 
        CedulaTextBox.Location = New Point(115, 90)
        CedulaTextBox.Name = "CedulaTextBox"
        CedulaTextBox.Size = New Size(159, 27)
        CedulaTextBox.TabIndex = 38
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.alquiler_0
        PictureBox1.Location = New Point(0, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 426)
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' Alquiler
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(CedulaTextBox)
        Controls.Add(DataGridView1)
        Controls.Add(UnRentButton)
        Controls.Add(DataGridView)
        Controls.Add(RentButton)
        Controls.Add(MarcaLabel)
        Controls.Add(SerialTextBox)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        MainMenuStrip = MenuStrip1
        Name = "Alquiler"
        Text = "Alquiler"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents RentButton As Button
    Friend WithEvents MarcaLabel As Label
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents UnRentButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CedulaTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
