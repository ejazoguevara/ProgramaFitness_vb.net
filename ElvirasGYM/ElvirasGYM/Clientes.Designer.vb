﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tabcliente = New System.Windows.Forms.TabControl()
        Me.datosclientes = New System.Windows.Forms.TabPage()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gbxDos = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cbxClase = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellidop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTomafoto = New System.Windows.Forms.Button()
        Me.Foto = New System.Windows.Forms.ImageList(Me.components)
        Me.DTclientes = New System.Windows.Forms.DataGridView()
        Me.pagosclientes = New System.Windows.Forms.TabPage()
        Me.imprimircarnet = New System.Windows.Forms.TabPage()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabcliente.SuspendLayout()
        Me.datosclientes.SuspendLayout()
        Me.gbxDos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabcliente
        '
        Me.tabcliente.Controls.Add(Me.datosclientes)
        Me.tabcliente.Controls.Add(Me.pagosclientes)
        Me.tabcliente.Controls.Add(Me.imprimircarnet)
        Me.tabcliente.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcliente.Location = New System.Drawing.Point(12, 12)
        Me.tabcliente.Name = "tabcliente"
        Me.tabcliente.SelectedIndex = 0
        Me.tabcliente.Size = New System.Drawing.Size(709, 448)
        Me.tabcliente.TabIndex = 0
        '
        'datosclientes
        '
        Me.datosclientes.Controls.Add(Me.txtNombre)
        Me.datosclientes.Controls.Add(Me.gbxDos)
        Me.datosclientes.Controls.Add(Me.btnBuscar)
        Me.datosclientes.Controls.Add(Me.cbxClase)
        Me.datosclientes.Controls.Add(Me.Label7)
        Me.datosclientes.Controls.Add(Me.cbxTipo)
        Me.datosclientes.Controls.Add(Me.Label6)
        Me.datosclientes.Controls.Add(Me.txtApellidom)
        Me.datosclientes.Controls.Add(Me.Label4)
        Me.datosclientes.Controls.Add(Me.txtApellidop)
        Me.datosclientes.Controls.Add(Me.Label3)
        Me.datosclientes.Controls.Add(Me.Label2)
        Me.datosclientes.Controls.Add(Me.txtDNI)
        Me.datosclientes.Controls.Add(Me.Label1)
        Me.datosclientes.Controls.Add(Me.Panel1)
        Me.datosclientes.Controls.Add(Me.btnTomafoto)
        Me.datosclientes.Controls.Add(Me.DTclientes)
        Me.datosclientes.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datosclientes.Location = New System.Drawing.Point(4, 24)
        Me.datosclientes.Name = "datosclientes"
        Me.datosclientes.Padding = New System.Windows.Forms.Padding(3)
        Me.datosclientes.Size = New System.Drawing.Size(701, 420)
        Me.datosclientes.TabIndex = 0
        Me.datosclientes.Text = "Datos personales"
        Me.datosclientes.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(136, 63)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(156, 25)
        Me.txtNombre.TabIndex = 2
        '
        'gbxDos
        '
        Me.gbxDos.Controls.Add(Me.btnEliminar)
        Me.gbxDos.Controls.Add(Me.btnNuevo)
        Me.gbxDos.Controls.Add(Me.btnAgregar)
        Me.gbxDos.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbxDos.Location = New System.Drawing.Point(6, 348)
        Me.gbxDos.Name = "gbxDos"
        Me.gbxDos.Size = New System.Drawing.Size(689, 71)
        Me.gbxDos.TabIndex = 30
        Me.gbxDos.TabStop = False
        Me.gbxDos.Text = "Operaciones:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(433, 14)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 51)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(177, 14)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 51)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(306, 14)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 51)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageKey = "buscar.png"
        Me.btnBuscar.ImageList = Me.imagenes
        Me.btnBuscar.Location = New System.Drawing.Point(115, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(53, 43)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "tomarfoto2.png")
        Me.imagenes.Images.SetKeyName(1, "buscar.png")
        '
        'cbxClase
        '
        Me.cbxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClase.FormattingEnabled = True
        Me.cbxClase.Location = New System.Drawing.Point(375, 97)
        Me.cbxClase.Name = "cbxClase"
        Me.cbxClase.Size = New System.Drawing.Size(156, 25)
        Me.cbxClase.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(309, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Clase:"
        '
        'cbxTipo
        '
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(410, 58)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(121, 25)
        Me.cbxTipo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tipo de pago:"
        '
        'txtApellidom
        '
        Me.txtApellidom.Location = New System.Drawing.Point(136, 135)
        Me.txtApellidom.MaxLength = 20
        Me.txtApellidom.Name = "txtApellidom"
        Me.txtApellidom.Size = New System.Drawing.Size(156, 25)
        Me.txtApellidom.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Apellido Materno:"
        '
        'txtApellidop
        '
        Me.txtApellidop.Location = New System.Drawing.Point(136, 97)
        Me.txtApellidop.MaxLength = 20
        Me.txtApellidop.Name = "txtApellidop"
        Me.txtApellidop.Size = New System.Drawing.Size(156, 25)
        Me.txtApellidop.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(47, 26)
        Me.txtDNI.MaxLength = 4
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(56, 25)
        Me.txtDNI.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DNI:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(543, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 118)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 115)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnTomafoto
        '
        Me.btnTomafoto.ImageKey = "tomarfoto.png"
        Me.btnTomafoto.ImageList = Me.Foto
        Me.btnTomafoto.Location = New System.Drawing.Point(543, 121)
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
        'DTclientes
        '
        Me.DTclientes.AllowUserToAddRows = False
        Me.DTclientes.AllowUserToDeleteRows = False
        Me.DTclientes.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DTclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTclientes.Location = New System.Drawing.Point(6, 169)
        Me.DTclientes.Name = "DTclientes"
        Me.DTclientes.ReadOnly = True
        Me.DTclientes.Size = New System.Drawing.Size(689, 178)
        Me.DTclientes.TabIndex = 11
        '
        'pagosclientes
        '
        Me.pagosclientes.Location = New System.Drawing.Point(4, 24)
        Me.pagosclientes.Name = "pagosclientes"
        Me.pagosclientes.Padding = New System.Windows.Forms.Padding(3)
        Me.pagosclientes.Size = New System.Drawing.Size(701, 420)
        Me.pagosclientes.TabIndex = 1
        Me.pagosclientes.Text = "Pagos"
        Me.pagosclientes.UseVisualStyleBackColor = True
        '
        'imprimircarnet
        '
        Me.imprimircarnet.Location = New System.Drawing.Point(4, 24)
        Me.imprimircarnet.Name = "imprimircarnet"
        Me.imprimircarnet.Size = New System.Drawing.Size(701, 420)
        Me.imprimircarnet.TabIndex = 2
        Me.imprimircarnet.Text = "Imprimir carnet"
        Me.imprimircarnet.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 464)
        Me.Controls.Add(Me.tabcliente)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(749, 503)
        Me.MinimumSize = New System.Drawing.Size(749, 503)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.tabcliente.ResumeLayout(False)
        Me.datosclientes.ResumeLayout(False)
        Me.datosclientes.PerformLayout()
        Me.gbxDos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabcliente As System.Windows.Forms.TabControl
    Friend WithEvents datosclientes As System.Windows.Forms.TabPage
    Friend WithEvents pagosclientes As System.Windows.Forms.TabPage
    Friend WithEvents imprimircarnet As System.Windows.Forms.TabPage
    Friend WithEvents DTclientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnTomafoto As System.Windows.Forms.Button
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cbxClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents gbxDos As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Foto As System.Windows.Forms.ImageList
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
