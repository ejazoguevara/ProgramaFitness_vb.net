<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabcliente = New System.Windows.Forms.TabControl()
        Me.datosclientes = New System.Windows.Forms.TabPage()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.imgBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.DTclientes = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.btnTomafoto = New System.Windows.Forms.Button()
        Me.Foto = New System.Windows.Forms.ImageList(Me.components)
        Me.panelCliente = New System.Windows.Forms.Panel()
        Me.panelBuscar = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidom = New System.Windows.Forms.TextBox()
        Me.txtApellidop = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.pagosclientes = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxDebe = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.DTPcorte = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.fotocliente = New System.Windows.Forms.PictureBox()
        Me.DTPpago = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbxTipopago = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBuscar2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.DTPclientes = New System.Windows.Forms.DataGridView()
        Me.imprimircarnet = New System.Windows.Forms.TabPage()
        Me.reservaclase = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbxGrupo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTgrupo = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxClase = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.txtApellidom2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidop2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBuscar2 = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txtDNI2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSourcepagos = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DTPHistorial = New System.Windows.Forms.DataGridView()
        Me.FechasPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.tabcliente.SuspendLayout()
        Me.datosclientes.SuspendLayout()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCliente.SuspendLayout()
        Me.panelBuscar.SuspendLayout()
        Me.pagosclientes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.fotocliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DTPclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.reservaclase.SuspendLayout()
        CType(Me.DTgrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSourcepagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DTPHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabcliente
        '
        Me.tabcliente.Controls.Add(Me.datosclientes)
        Me.tabcliente.Controls.Add(Me.pagosclientes)
        Me.tabcliente.Controls.Add(Me.imprimircarnet)
        Me.tabcliente.Controls.Add(Me.reservaclase)
        Me.tabcliente.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcliente.Location = New System.Drawing.Point(4, 4)
        Me.tabcliente.Name = "tabcliente"
        Me.tabcliente.SelectedIndex = 0
        Me.tabcliente.Size = New System.Drawing.Size(668, 448)
        Me.tabcliente.TabIndex = 0
        '
        'datosclientes
        '
        Me.datosclientes.Controls.Add(Me.btnGuardar)
        Me.datosclientes.Controls.Add(Me.btnEliminar)
        Me.datosclientes.Controls.Add(Me.DTclientes)
        Me.datosclientes.Controls.Add(Me.btnAgregar)
        Me.datosclientes.Controls.Add(Me.btnNuevo)
        Me.datosclientes.Controls.Add(Me.Label4)
        Me.datosclientes.Controls.Add(Me.Label3)
        Me.datosclientes.Controls.Add(Me.Label2)
        Me.datosclientes.Controls.Add(Me.Label1)
        Me.datosclientes.Controls.Add(Me.Panel1)
        Me.datosclientes.Controls.Add(Me.btnTomafoto)
        Me.datosclientes.Controls.Add(Me.panelCliente)
        Me.datosclientes.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datosclientes.Location = New System.Drawing.Point(4, 24)
        Me.datosclientes.Name = "datosclientes"
        Me.datosclientes.Padding = New System.Windows.Forms.Padding(3)
        Me.datosclientes.Size = New System.Drawing.Size(660, 420)
        Me.datosclientes.TabIndex = 0
        Me.datosclientes.Text = "Datos personales"
        Me.datosclientes.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.ImageKey = "save.png"
        Me.btnGuardar.ImageList = Me.imgBotones
        Me.btnGuardar.Location = New System.Drawing.Point(555, 46)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(99, 87)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Guarda cambios (F5)"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'imgBotones
        '
        Me.imgBotones.ImageStream = CType(resources.GetObject("imgBotones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBotones.TransparentColor = System.Drawing.Color.Transparent
        Me.imgBotones.Images.SetKeyName(0, "delete.png")
        Me.imgBotones.Images.SetKeyName(1, "save.png")
        Me.imgBotones.Images.SetKeyName(2, "addcliente.png")
        Me.imgBotones.Images.SetKeyName(3, "new104.png")
        Me.imgBotones.Images.SetKeyName(4, "pagar.png")
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.ImageKey = "delete.png"
        Me.btnEliminar.ImageList = Me.imgBotones
        Me.btnEliminar.Location = New System.Drawing.Point(555, 139)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 87)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar (Supr)"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'DTclientes
        '
        Me.DTclientes.AllowUserToAddRows = False
        Me.DTclientes.AllowUserToDeleteRows = False
        Me.DTclientes.AllowUserToResizeColumns = False
        Me.DTclientes.AllowUserToResizeRows = False
        Me.DTclientes.BackgroundColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTclientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DTclientes.ColumnHeadersHeight = 25
        Me.DTclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTclientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DTclientes.Location = New System.Drawing.Point(6, 214)
        Me.DTclientes.MultiSelect = False
        Me.DTclientes.Name = "DTclientes"
        Me.DTclientes.ReadOnly = True
        Me.DTclientes.RowHeadersVisible = False
        Me.DTclientes.RowHeadersWidth = 40
        Me.DTclientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTclientes.Size = New System.Drawing.Size(543, 200)
        Me.DTclientes.TabIndex = 31
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.ImageKey = "addcliente.png"
        Me.btnAgregar.ImageList = Me.imgBotones
        Me.btnAgregar.Location = New System.Drawing.Point(555, 232)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(99, 88)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar (F3)"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.ImageKey = "new104.png"
        Me.btnNuevo.ImageList = Me.imgBotones
        Me.btnNuevo.Location = New System.Drawing.Point(555, 326)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(99, 88)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo (F2)"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Azure
        Me.Label4.Location = New System.Drawing.Point(10, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Azure
        Me.Label3.Location = New System.Drawing.Point(10, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Azure
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DNI:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.imgFoto)
        Me.Panel1.Location = New System.Drawing.Point(396, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 156)
        Me.Panel1.TabIndex = 4
        '
        'imgFoto
        '
        Me.imgFoto.Location = New System.Drawing.Point(19, 2)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(120, 150)
        Me.imgFoto.TabIndex = 4
        Me.imgFoto.TabStop = False
        '
        'btnTomafoto
        '
        Me.btnTomafoto.ImageKey = "tomarfoto.png"
        Me.btnTomafoto.ImageList = Me.Foto
        Me.btnTomafoto.Location = New System.Drawing.Point(396, 160)
        Me.btnTomafoto.Name = "btnTomafoto"
        Me.btnTomafoto.Size = New System.Drawing.Size(152, 42)
        Me.btnTomafoto.TabIndex = 10
        Me.btnTomafoto.UseVisualStyleBackColor = True
        '
        'Foto
        '
        Me.Foto.ImageStream = CType(resources.GetObject("Foto.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Foto.TransparentColor = System.Drawing.Color.Transparent
        Me.Foto.Images.SetKeyName(0, "tomarfoto.png")
        '
        'panelCliente
        '
        Me.panelCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelCliente.BackColor = System.Drawing.Color.Azure
        Me.panelCliente.Controls.Add(Me.panelBuscar)
        Me.panelCliente.Controls.Add(Me.txtNombre)
        Me.panelCliente.Controls.Add(Me.cbxTipo)
        Me.panelCliente.Controls.Add(Me.Label6)
        Me.panelCliente.Controls.Add(Me.txtApellidom)
        Me.panelCliente.Controls.Add(Me.txtApellidop)
        Me.panelCliente.Controls.Add(Me.txtDNI)
        Me.panelCliente.Location = New System.Drawing.Point(7, 3)
        Me.panelCliente.Name = "panelCliente"
        Me.panelCliente.Size = New System.Drawing.Size(542, 205)
        Me.panelCliente.TabIndex = 32
        '
        'panelBuscar
        '
        Me.panelBuscar.Controls.Add(Me.Label13)
        Me.panelBuscar.Controls.Add(Me.txtBuscar)
        Me.panelBuscar.Controls.Add(Me.Label12)
        Me.panelBuscar.Location = New System.Drawing.Point(130, 3)
        Me.panelBuscar.Name = "panelBuscar"
        Me.panelBuscar.Size = New System.Drawing.Size(223, 44)
        Me.panelBuscar.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(63, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Presiona F1"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(60, 20)
        Me.txtBuscar.MaxLength = 4
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(155, 23)
        Me.txtBuscar.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Azure
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(1, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Buscar:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(134, 60)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(211, 25)
        Me.txtNombre.TabIndex = 2
        '
        'cbxTipo
        '
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(134, 168)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(156, 25)
        Me.cbxTipo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tipo de pago:"
        '
        'txtApellidom
        '
        Me.txtApellidom.Location = New System.Drawing.Point(134, 132)
        Me.txtApellidom.MaxLength = 20
        Me.txtApellidom.Name = "txtApellidom"
        Me.txtApellidom.Size = New System.Drawing.Size(211, 25)
        Me.txtApellidom.TabIndex = 4
        '
        'txtApellidop
        '
        Me.txtApellidop.Location = New System.Drawing.Point(134, 94)
        Me.txtApellidop.MaxLength = 20
        Me.txtApellidop.Name = "txtApellidop"
        Me.txtApellidop.Size = New System.Drawing.Size(211, 25)
        Me.txtApellidop.TabIndex = 3
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(45, 23)
        Me.txtDNI.MaxLength = 4
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(56, 25)
        Me.txtDNI.TabIndex = 0
        '
        'pagosclientes
        '
        Me.pagosclientes.Controls.Add(Me.btnPagar)
        Me.pagosclientes.Controls.Add(Me.GroupBox3)
        Me.pagosclientes.Controls.Add(Me.Panel2)
        Me.pagosclientes.Controls.Add(Me.GroupBox2)
        Me.pagosclientes.Location = New System.Drawing.Point(4, 24)
        Me.pagosclientes.Name = "pagosclientes"
        Me.pagosclientes.Padding = New System.Windows.Forms.Padding(3)
        Me.pagosclientes.Size = New System.Drawing.Size(660, 420)
        Me.pagosclientes.TabIndex = 1
        Me.pagosclientes.Text = "Pagos"
        Me.pagosclientes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Controls.Add(Me.txtPago)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.lblNota)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.cbxDebe)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.cbxCantidad)
        Me.Panel2.Controls.Add(Me.DTPcorte)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DTPpago)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.cbxTipopago)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txtBuscar2)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 173)
        Me.Panel2.TabIndex = 33
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(127, 119)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(110, 27)
        Me.txtPago.TabIndex = 43
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(125, 15)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Capture el pago:  $"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNota.Location = New System.Drawing.Point(3, 154)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(437, 15)
        Me.lblNota.TabIndex = 41
        Me.lblNota.Text = "Nota: El pago, se asignara a las semanas o meses que deba el cliente."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(240, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 15)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Debe:"
        '
        'cbxDebe
        '
        Me.cbxDebe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDebe.FormattingEnabled = True
        Me.cbxDebe.Items.AddRange(New Object() {"0", "1", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbxDebe.Location = New System.Drawing.Point(243, 77)
        Me.cbxDebe.Name = "cbxDebe"
        Me.cbxDebe.Size = New System.Drawing.Size(91, 23)
        Me.cbxDebe.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(143, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 15)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "N° Sem/Mes"
        '
        'cbxCantidad
        '
        Me.cbxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbxCantidad.Location = New System.Drawing.Point(146, 77)
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(91, 23)
        Me.cbxCantidad.TabIndex = 37
        '
        'DTPcorte
        '
        Me.DTPcorte.Enabled = False
        Me.DTPcorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPcorte.Location = New System.Drawing.Point(340, 77)
        Me.DTPcorte.Name = "DTPcorte"
        Me.DTPcorte.Size = New System.Drawing.Size(150, 23)
        Me.DTPcorte.TabIndex = 36
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(338, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(138, 15)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Fecha próximo corte:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.fotocliente)
        Me.Panel3.Location = New System.Drawing.Point(496, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(152, 156)
        Me.Panel3.TabIndex = 34
        '
        'fotocliente
        '
        Me.fotocliente.Location = New System.Drawing.Point(19, 2)
        Me.fotocliente.Name = "fotocliente"
        Me.fotocliente.Size = New System.Drawing.Size(120, 150)
        Me.fotocliente.TabIndex = 4
        Me.fotocliente.TabStop = False
        '
        'DTPpago
        '
        Me.DTPpago.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPpago.Location = New System.Drawing.Point(5, 77)
        Me.DTPpago.Name = "DTPpago"
        Me.DTPpago.Size = New System.Drawing.Size(135, 23)
        Me.DTPpago.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 15)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Fecha de pago:"
        '
        'cbxTipopago
        '
        Me.cbxTipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipopago.FormattingEnabled = True
        Me.cbxTipopago.Location = New System.Drawing.Point(375, 25)
        Me.cbxTipopago.Name = "cbxTipopago"
        Me.cbxTipopago.Size = New System.Drawing.Size(115, 23)
        Me.cbxTipopago.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(143, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 15)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Nombre completo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Buscar cliente:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(372, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 15)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Tipo de pago:"
        '
        'txtBuscar2
        '
        Me.txtBuscar2.Location = New System.Drawing.Point(5, 25)
        Me.txtBuscar2.MaxLength = 30
        Me.txtBuscar2.Name = "txtBuscar2"
        Me.txtBuscar2.Size = New System.Drawing.Size(135, 23)
        Me.txtBuscar2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTPclientes)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(3, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 236)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clientes:"
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPagar.ImageKey = "pagar.png"
        Me.btnPagar.ImageList = Me.imgBotones
        Me.btnPagar.Location = New System.Drawing.Point(544, 203)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(99, 88)
        Me.btnPagar.TabIndex = 8
        Me.btnPagar.Text = "Pagar (F5)"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'DTPclientes
        '
        Me.DTPclientes.AllowUserToAddRows = False
        Me.DTPclientes.AllowUserToDeleteRows = False
        Me.DTPclientes.AllowUserToResizeColumns = False
        Me.DTPclientes.AllowUserToResizeRows = False
        Me.DTPclientes.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DTPclientes.ColumnHeadersHeight = 40
        Me.DTPclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTPclientes.Location = New System.Drawing.Point(9, 22)
        Me.DTPclientes.Name = "DTPclientes"
        Me.DTPclientes.ReadOnly = True
        Me.DTPclientes.RowHeadersVisible = False
        Me.DTPclientes.RowHeadersWidth = 50
        Me.DTPclientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTPclientes.Size = New System.Drawing.Size(264, 201)
        Me.DTPclientes.TabIndex = 34
        '
        'imprimircarnet
        '
        Me.imprimircarnet.Location = New System.Drawing.Point(4, 24)
        Me.imprimircarnet.Name = "imprimircarnet"
        Me.imprimircarnet.Size = New System.Drawing.Size(660, 420)
        Me.imprimircarnet.TabIndex = 2
        Me.imprimircarnet.Text = "Imprimir carnet"
        Me.imprimircarnet.UseVisualStyleBackColor = True
        '
        'reservaclase
        '
        Me.reservaclase.Controls.Add(Me.Button1)
        Me.reservaclase.Controls.Add(Me.cbxGrupo)
        Me.reservaclase.Controls.Add(Me.Label11)
        Me.reservaclase.Controls.Add(Me.DTgrupo)
        Me.reservaclase.Controls.Add(Me.cbxClase)
        Me.reservaclase.Controls.Add(Me.Label7)
        Me.reservaclase.Controls.Add(Me.txtNombre2)
        Me.reservaclase.Controls.Add(Me.txtApellidom2)
        Me.reservaclase.Controls.Add(Me.Label5)
        Me.reservaclase.Controls.Add(Me.txtApellidop2)
        Me.reservaclase.Controls.Add(Me.Label9)
        Me.reservaclase.Controls.Add(Me.Label10)
        Me.reservaclase.Controls.Add(Me.btnBuscar2)
        Me.reservaclase.Controls.Add(Me.txtDNI2)
        Me.reservaclase.Controls.Add(Me.Label8)
        Me.reservaclase.Controls.Add(Me.GroupBox1)
        Me.reservaclase.Location = New System.Drawing.Point(4, 24)
        Me.reservaclase.Name = "reservaclase"
        Me.reservaclase.Padding = New System.Windows.Forms.Padding(3)
        Me.reservaclase.Size = New System.Drawing.Size(660, 420)
        Me.reservaclase.TabIndex = 3
        Me.reservaclase.Text = "Reservar clase"
        Me.reservaclase.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 115)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Reservar clase"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbxGrupo
        '
        Me.cbxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGrupo.Enabled = False
        Me.cbxGrupo.FormattingEnabled = True
        Me.cbxGrupo.Location = New System.Drawing.Point(368, 94)
        Me.cbxGrupo.Name = "cbxGrupo"
        Me.cbxGrupo.Size = New System.Drawing.Size(156, 23)
        Me.cbxGrupo.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(307, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Grupo:"
        '
        'DTgrupo
        '
        Me.DTgrupo.AllowUserToAddRows = False
        Me.DTgrupo.AllowUserToDeleteRows = False
        Me.DTgrupo.AllowUserToResizeColumns = False
        Me.DTgrupo.AllowUserToResizeRows = False
        Me.DTgrupo.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DTgrupo.ColumnHeadersHeight = 25
        Me.DTgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTgrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.Nombre, Me.Apellidop, Me.Apellidom, Me.TipoPago})
        Me.DTgrupo.Location = New System.Drawing.Point(9, 201)
        Me.DTgrupo.MultiSelect = False
        Me.DTgrupo.Name = "DTgrupo"
        Me.DTgrupo.ReadOnly = True
        Me.DTgrupo.RowHeadersVisible = False
        Me.DTgrupo.RowHeadersWidth = 40
        Me.DTgrupo.Size = New System.Drawing.Size(587, 171)
        Me.DTgrupo.TabIndex = 30
        '
        'DNI
        '
        Me.DNI.Frozen = True
        Me.DNI.HeaderText = "DNI"
        Me.DNI.MaxInputLength = 5
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DNI.Width = 55
        '
        'Nombre
        '
        Me.Nombre.Frozen = True
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MaxInputLength = 30
        Me.Nombre.MinimumWidth = 100
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Apellidop
        '
        Me.Apellidop.Frozen = True
        Me.Apellidop.HeaderText = "Apellido Paterno"
        Me.Apellidop.MaxInputLength = 50
        Me.Apellidop.MinimumWidth = 100
        Me.Apellidop.Name = "Apellidop"
        Me.Apellidop.ReadOnly = True
        Me.Apellidop.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Apellidop.Width = 136
        '
        'Apellidom
        '
        Me.Apellidom.Frozen = True
        Me.Apellidom.HeaderText = "Apellido Materno"
        Me.Apellidom.MaxInputLength = 50
        Me.Apellidom.MinimumWidth = 100
        Me.Apellidom.Name = "Apellidom"
        Me.Apellidom.ReadOnly = True
        Me.Apellidom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Apellidom.Width = 140
        '
        'TipoPago
        '
        Me.TipoPago.Frozen = True
        Me.TipoPago.HeaderText = "Tipo de Pago"
        Me.TipoPago.MaxInputLength = 30
        Me.TipoPago.MinimumWidth = 50
        Me.TipoPago.Name = "TipoPago"
        Me.TipoPago.ReadOnly = True
        Me.TipoPago.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TipoPago.Width = 114
        '
        'cbxClase
        '
        Me.cbxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClase.FormattingEnabled = True
        Me.cbxClase.Location = New System.Drawing.Point(368, 60)
        Me.cbxClase.Name = "cbxClase"
        Me.cbxClase.Size = New System.Drawing.Size(156, 23)
        Me.cbxClase.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Clase:"
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(137, 60)
        Me.txtNombre2.MaxLength = 20
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(156, 23)
        Me.txtNombre2.TabIndex = 22
        '
        'txtApellidom2
        '
        Me.txtApellidom2.Location = New System.Drawing.Point(137, 132)
        Me.txtApellidom2.MaxLength = 20
        Me.txtApellidom2.Name = "txtApellidom2"
        Me.txtApellidom2.Size = New System.Drawing.Size(156, 23)
        Me.txtApellidom2.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Apellido Materno:"
        '
        'txtApellidop2
        '
        Me.txtApellidop2.Location = New System.Drawing.Point(137, 94)
        Me.txtApellidop2.MaxLength = 20
        Me.txtApellidop2.Name = "txtApellidop2"
        Me.txtApellidop2.Size = New System.Drawing.Size(156, 23)
        Me.txtApellidop2.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Apellido Paterno:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Nombre:"
        '
        'btnBuscar2
        '
        Me.btnBuscar2.ImageKey = "buscar.png"
        Me.btnBuscar2.ImageList = Me.imagenes
        Me.btnBuscar2.Location = New System.Drawing.Point(137, 8)
        Me.btnBuscar2.Name = "btnBuscar2"
        Me.btnBuscar2.Size = New System.Drawing.Size(53, 43)
        Me.btnBuscar2.TabIndex = 19
        Me.btnBuscar2.UseVisualStyleBackColor = True
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "tomarfoto2.png")
        Me.imagenes.Images.SetKeyName(1, "buscar.png")
        Me.imagenes.Images.SetKeyName(2, "addcliente2.png")
        Me.imagenes.Images.SetKeyName(3, "delete.png")
        Me.imagenes.Images.SetKeyName(4, "save.png")
        Me.imagenes.Images.SetKeyName(5, "pagar.png")
        '
        'txtDNI2
        '
        Me.txtDNI2.Location = New System.Drawing.Point(47, 19)
        Me.txtDNI2.MaxLength = 4
        Me.txtDNI2.Name = "txtDNI2"
        Me.txtDNI2.Size = New System.Drawing.Size(56, 23)
        Me.txtDNI2.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "DNI:"
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 205)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un grupo:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.DTPHistorial)
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(282, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 236)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial de pagos:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageKey = "pagar.png"
        Me.Button2.ImageList = Me.imgBotones
        Me.Button2.Location = New System.Drawing.Point(541, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 88)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Pagar (F5)"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DTPHistorial
        '
        Me.DTPHistorial.AllowUserToAddRows = False
        Me.DTPHistorial.AllowUserToDeleteRows = False
        Me.DTPHistorial.AllowUserToResizeColumns = False
        Me.DTPHistorial.AllowUserToResizeRows = False
        Me.DTPHistorial.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DTPHistorial.ColumnHeadersHeight = 40
        Me.DTPHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTPHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechasPago, Me.pagos})
        Me.DTPHistorial.Location = New System.Drawing.Point(6, 22)
        Me.DTPHistorial.Name = "DTPHistorial"
        Me.DTPHistorial.ReadOnly = True
        Me.DTPHistorial.RowHeadersVisible = False
        Me.DTPHistorial.RowHeadersWidth = 50
        Me.DTPHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTPHistorial.Size = New System.Drawing.Size(244, 201)
        Me.DTPHistorial.TabIndex = 34
        '
        'FechasPago
        '
        Me.FechasPago.Frozen = True
        Me.FechasPago.HeaderText = "Fechas de Pago"
        Me.FechasPago.Name = "FechasPago"
        Me.FechasPago.ReadOnly = True
        Me.FechasPago.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FechasPago.Width = 150
        '
        'pagos
        '
        Me.pagos.Frozen = True
        Me.pagos.HeaderText = "Pagos"
        Me.pagos.Name = "pagos"
        Me.pagos.ReadOnly = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(146, 25)
        Me.txtCliente.MaxLength = 4
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(223, 23)
        Me.txtCliente.TabIndex = 44
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 464)
        Me.Controls.Add(Me.tabcliente)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(690, 503)
        Me.MinimumSize = New System.Drawing.Size(690, 503)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.tabcliente.ResumeLayout(False)
        Me.datosclientes.ResumeLayout(False)
        Me.datosclientes.PerformLayout()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCliente.ResumeLayout(False)
        Me.panelCliente.PerformLayout()
        Me.panelBuscar.ResumeLayout(False)
        Me.panelBuscar.PerformLayout()
        Me.pagosclientes.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.fotocliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DTPclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.reservaclase.ResumeLayout(False)
        Me.reservaclase.PerformLayout()
        CType(Me.DTgrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSourcepagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DTPHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabcliente As System.Windows.Forms.TabControl
    Friend WithEvents datosclientes As System.Windows.Forms.TabPage
    Friend WithEvents pagosclientes As System.Windows.Forms.TabPage
    Friend WithEvents imprimircarnet As System.Windows.Forms.TabPage
    Friend WithEvents btnTomafoto As System.Windows.Forms.Button
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents imgFoto As System.Windows.Forms.PictureBox
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtApellidom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellidop As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Foto As System.Windows.Forms.ImageList
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents reservaclase As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbxGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTgrupo As System.Windows.Forms.DataGridView
    Friend WithEvents cbxClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidom2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellidop2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar2 As System.Windows.Forms.Button
    Friend WithEvents txtDNI2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BSourcepagos As System.Windows.Forms.BindingSource
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTclientes As System.Windows.Forms.DataGridView
    Friend WithEvents panelCliente As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents imgBotones As System.Windows.Forms.ImageList
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents panelBuscar As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DTPpago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbxTipopago As System.Windows.Forms.ComboBox
    Friend WithEvents DTPclientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbxDebe As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents DTPcorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents fotocliente As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents txtPago As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DTPHistorial As System.Windows.Forms.DataGridView
    Friend WithEvents FechasPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
End Class
