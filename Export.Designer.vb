<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export
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
        AlquilerToolStripMenuItem = New ToolStripMenuItem()
        ReporteToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        ExportButton = New Button()
        ExitButton = New Button()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InventarioToolStripMenuItem, ClientesToolStripMenuItem, AlquilerToolStripMenuItem, ReporteToolStripMenuItem, CerrarSesiónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(346, 28)
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
        ' ExportButton
        ' 
        ExportButton.BackColor = Color.Khaki
        ExportButton.FlatStyle = FlatStyle.Popup
        ExportButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ExportButton.Location = New Point(12, 46)
        ExportButton.Name = "ExportButton"
        ExportButton.Size = New Size(94, 34)
        ExportButton.TabIndex = 37
        ExportButton.Text = "Respaldar"
        ExportButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.Khaki
        ExitButton.FlatStyle = FlatStyle.Popup
        ExitButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ExitButton.Location = New Point(164, 51)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 36
        ExitButton.Text = "Salida"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cloud_backup_for_business
        PictureBox1.Location = New Point(0, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(346, 146)
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' Export
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(346, 181)
        Controls.Add(ExportButton)
        Controls.Add(ExitButton)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        MainMenuStrip = MenuStrip1
        Name = "Export"
        Text = "Ventana de Exportación"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
