<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Report))
        MenuStrip1 = New MenuStrip()
        InventarioToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AlquilerToolStripMenuItem = New ToolStripMenuItem()
        RespaldoToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        ExitButton = New Button()
        ReporteButton = New Button()
        DataGridViewClients = New DataGridView()
        DataGridView = New DataGridView()
        PictureBox1 = New PictureBox()
        RecuentoLabel = New TextBox()
        MenuStrip1.SuspendLayout()
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InventarioToolStripMenuItem, ClientesToolStripMenuItem, AlquilerToolStripMenuItem, RespaldoToolStripMenuItem, CerrarSesiónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
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
        ' AlquilerToolStripMenuItem
        ' 
        AlquilerToolStripMenuItem.Name = "AlquilerToolStripMenuItem"
        AlquilerToolStripMenuItem.Size = New Size(75, 24)
        AlquilerToolStripMenuItem.Text = "Alquiler"
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
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.Khaki
        ExitButton.FlatStyle = FlatStyle.Popup
        ExitButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ExitButton.Location = New Point(694, 40)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 2
        ExitButton.Text = "Salida"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' ReporteButton
        ' 
        ReporteButton.BackColor = Color.Khaki
        ReporteButton.FlatStyle = FlatStyle.Popup
        ReporteButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ReporteButton.Location = New Point(12, 40)
        ReporteButton.Name = "ReporteButton"
        ReporteButton.Size = New Size(94, 69)
        ReporteButton.TabIndex = 1
        ReporteButton.Text = "Generar reporte"
        ReporteButton.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewClients
        ' 
        DataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewClients.Location = New Point(12, 293)
        DataGridViewClients.Name = "DataGridViewClients"
        DataGridViewClients.RowHeadersWidth = 51
        DataGridViewClients.RowTemplate.Height = 29
        DataGridViewClients.Size = New Size(764, 145)
        DataGridViewClients.TabIndex = 34
        DataGridViewClients.TabStop = False
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(12, 115)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.RowTemplate.Height = 29
        DataGridView.Size = New Size(764, 172)
        DataGridView.TabIndex = 35
        DataGridView.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 450)
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' RecuentoLabel
        ' 
        RecuentoLabel.Location = New Point(158, 42)
        RecuentoLabel.Name = "RecuentoLabel"
        RecuentoLabel.Size = New Size(125, 27)
        RecuentoLabel.TabIndex = 38
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RecuentoLabel)
        Controls.Add(DataGridView)
        Controls.Add(DataGridViewClients)
        Controls.Add(ReporteButton)
        Controls.Add(ExitButton)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        Name = "Report"
        Text = "Ventana de Reporte"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitButton As Button
    Friend WithEvents ReporteButton As Button
    Friend WithEvents DataGridViewClients As DataGridView
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RecuentoLabel As TextBox
End Class
