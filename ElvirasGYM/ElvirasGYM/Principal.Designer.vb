<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarGrupoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirCredencialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGrupos = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.btnInstructores = New System.Windows.Forms.Button()
        Me.btnNuevocliente = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnClases = New System.Windows.Forms.Button()
        Me.btnPagocliente = New System.Windows.Forms.Button()
        Me.lblEmpleado1 = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.OsSkin1 = New SkinSoft.OSSkin.OSSkin(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.OsSkin1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Honeydew
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.InstructoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasToolStripMenuItem, Me.VentasToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'AltasToolStripMenuItem
        '
        Me.AltasToolStripMenuItem.Name = "AltasToolStripMenuItem"
        Me.AltasToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AltasToolStripMenuItem.Text = "Stock"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.IngresarToolStripMenuItem.Text = "Capturar"
        '
        'InstructoresToolStripMenuItem
        '
        Me.InstructoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNuevoToolStripMenuItem, Me.AsignarGrupoToolStripMenuItem1})
        Me.InstructoresToolStripMenuItem.Name = "InstructoresToolStripMenuItem"
        Me.InstructoresToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.InstructoresToolStripMenuItem.Text = "Instructores"
        '
        'IngresarNuevoToolStripMenuItem
        '
        Me.IngresarNuevoToolStripMenuItem.Name = "IngresarNuevoToolStripMenuItem"
        Me.IngresarNuevoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.IngresarNuevoToolStripMenuItem.Text = "Capturar"
        '
        'AsignarGrupoToolStripMenuItem1
        '
        Me.AsignarGrupoToolStripMenuItem1.Name = "AsignarGrupoToolStripMenuItem1"
        Me.AsignarGrupoToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.AsignarGrupoToolStripMenuItem1.Text = "Asignar grupo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarClienteToolStripMenuItem, Me.AsignarGrupoToolStripMenuItem, Me.PagosToolStripMenuItem, Me.AsistenciaToolStripMenuItem, Me.ImprimirCredencialToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'IngresarClienteToolStripMenuItem
        '
        Me.IngresarClienteToolStripMenuItem.Name = "IngresarClienteToolStripMenuItem"
        Me.IngresarClienteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.IngresarClienteToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.IngresarClienteToolStripMenuItem.Text = "Capturar"
        '
        'AsignarGrupoToolStripMenuItem
        '
        Me.AsignarGrupoToolStripMenuItem.Name = "AsignarGrupoToolStripMenuItem"
        Me.AsignarGrupoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AsignarGrupoToolStripMenuItem.Text = "Asignar grupo"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'ImprimirCredencialToolStripMenuItem
        '
        Me.ImprimirCredencialToolStripMenuItem.Name = "ImprimirCredencialToolStripMenuItem"
        Me.ImprimirCredencialToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ImprimirCredencialToolStripMenuItem.Text = "Imprimir credencial"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'btnGrupos
        '
        Me.btnGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrupos.ImageKey = "grupo.png"
        Me.btnGrupos.ImageList = Me.imagenes
        Me.btnGrupos.Location = New System.Drawing.Point(883, 358)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Size = New System.Drawing.Size(111, 94)
        Me.btnGrupos.TabIndex = 2
        Me.btnGrupos.Text = "Grupos"
        Me.btnGrupos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrupos.UseVisualStyleBackColor = True
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "grupo.png")
        Me.imagenes.Images.SetKeyName(1, "pagar.png")
        Me.imagenes.Images.SetKeyName(2, "venta.png")
        Me.imagenes.Images.SetKeyName(3, "addcliente2.png")
        Me.imagenes.Images.SetKeyName(4, "addinstructor.png")
        Me.imagenes.Images.SetKeyName(5, "clases.png")
        '
        'btnInstructores
        '
        Me.btnInstructores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInstructores.ImageKey = "addinstructor.png"
        Me.btnInstructores.ImageList = Me.imagenes
        Me.btnInstructores.Location = New System.Drawing.Point(883, 458)
        Me.btnInstructores.Name = "btnInstructores"
        Me.btnInstructores.Size = New System.Drawing.Size(111, 94)
        Me.btnInstructores.TabIndex = 3
        Me.btnInstructores.Text = "Intructores"
        Me.btnInstructores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInstructores.UseVisualStyleBackColor = True
        '
        'btnNuevocliente
        '
        Me.btnNuevocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevocliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevocliente.ImageKey = "addcliente2.png"
        Me.btnNuevocliente.ImageList = Me.imagenes
        Me.btnNuevocliente.Location = New System.Drawing.Point(883, 158)
        Me.btnNuevocliente.Name = "btnNuevocliente"
        Me.btnNuevocliente.Size = New System.Drawing.Size(111, 94)
        Me.btnNuevocliente.TabIndex = 5
        Me.btnNuevocliente.Text = "Alta Clientes"
        Me.btnNuevocliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevocliente.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVentas.ImageKey = "venta.png"
        Me.btnVentas.ImageList = Me.imagenes
        Me.btnVentas.Location = New System.Drawing.Point(883, 58)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(111, 94)
        Me.btnVentas.TabIndex = 4
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnClases
        '
        Me.btnClases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClases.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClases.ImageKey = "clases.png"
        Me.btnClases.ImageList = Me.imagenes
        Me.btnClases.Location = New System.Drawing.Point(883, 558)
        Me.btnClases.Name = "btnClases"
        Me.btnClases.Size = New System.Drawing.Size(111, 94)
        Me.btnClases.TabIndex = 7
        Me.btnClases.Text = "Clases"
        Me.btnClases.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClases.UseVisualStyleBackColor = True
        '
        'btnPagocliente
        '
        Me.btnPagocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagocliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPagocliente.ImageKey = "pagar.png"
        Me.btnPagocliente.ImageList = Me.imagenes
        Me.btnPagocliente.Location = New System.Drawing.Point(883, 258)
        Me.btnPagocliente.Name = "btnPagocliente"
        Me.btnPagocliente.Size = New System.Drawing.Size(111, 94)
        Me.btnPagocliente.TabIndex = 6
        Me.btnPagocliente.Text = "Pago Clientes"
        Me.btnPagocliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagocliente.UseVisualStyleBackColor = True
        '
        'lblEmpleado1
        '
        Me.lblEmpleado1.AutoSize = True
        Me.lblEmpleado1.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpleado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado1.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblEmpleado1.Location = New System.Drawing.Point(8, 669)
        Me.lblEmpleado1.Name = "lblEmpleado1"
        Me.lblEmpleado1.Size = New System.Drawing.Size(94, 20)
        Me.lblEmpleado1.TabIndex = 8
        Me.lblEmpleado1.Text = "Empleado:"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblEmpleado.Location = New System.Drawing.Point(113, 672)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(0, 16)
        Me.lblEmpleado.TabIndex = 9
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha1.ForeColor = System.Drawing.Color.Black
        Me.lblFecha1.Location = New System.Drawing.Point(393, 669)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(64, 20)
        Me.lblFecha1.TabIndex = 10
        Me.lblFecha1.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Maroon
        Me.lblFecha.Location = New System.Drawing.Point(461, 664)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 24)
        Me.lblFecha.TabIndex = 11
        '
        'OsSkin1
        '
        Me.OsSkin1.HostForm = Nothing
        Me.OsSkin1.License = CType(resources.GetObject("OsSkin1.License"), SkinSoft.OSSkin.Licensing.OSSkinLicense)
        Me.OsSkin1.Style = SkinSoft.OSSkin.SkinStyle.MetroBlue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(599, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 45)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Elviras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(647, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 86)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fitness"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(683, 669)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Hora:"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Black
        Me.lblHora.Location = New System.Drawing.Point(742, 669)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(0, 20)
        Me.lblHora.TabIndex = 15
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1006, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblFecha1)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.lblEmpleado1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnGrupos)
        Me.Controls.Add(Me.btnInstructores)
        Me.Controls.Add(Me.btnClases)
        Me.Controls.Add(Me.btnNuevocliente)
        Me.Controls.Add(Me.btnPagocliente)
        Me.Controls.Add(Me.btnVentas)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1022, 733)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1022, 726)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elviras - Fitness"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.OsSkin1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGrupos As System.Windows.Forms.Button
    Friend WithEvents btnInstructores As System.Windows.Forms.Button
    Friend WithEvents btnNuevocliente As System.Windows.Forms.Button
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents btnClases As System.Windows.Forms.Button
    Friend WithEvents btnPagocliente As System.Windows.Forms.Button
    Friend WithEvents lblEmpleado1 As System.Windows.Forms.Label
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents AltasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarGrupoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirCredencialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OsSkin1 As SkinSoft.OSSkin.OSSkin
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents AsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
End Class
