<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaGeneral
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabClientes = New System.Windows.Forms.TabPage()
        Me.DTclientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscaclientes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabProductos = New System.Windows.Forms.TabPage()
        Me.DTproductos = New System.Windows.Forms.DataGridView()
        Me.txtBuscaproductos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DTusuarios = New System.Windows.Forms.DataGridView()
        Me.txtBuscausuarios = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DTinstructores = New System.Windows.Forms.DataGridView()
        Me.txtBuscainstructores = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DatosClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosUsuarios = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosInstructores = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabClientes.SuspendLayout()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProductos.SuspendLayout()
        CType(Me.DTproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DTusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DTinstructores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosInstructores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabClientes)
        Me.TabControl1.Controls.Add(Me.tabProductos)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(626, 447)
        Me.TabControl1.TabIndex = 0
        '
        'tabClientes
        '
        Me.tabClientes.BackColor = System.Drawing.Color.Honeydew
        Me.tabClientes.Controls.Add(Me.DTclientes)
        Me.tabClientes.Controls.Add(Me.txtBuscaclientes)
        Me.tabClientes.Controls.Add(Me.Label1)
        Me.tabClientes.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabClientes.Location = New System.Drawing.Point(4, 22)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClientes.Size = New System.Drawing.Size(618, 421)
        Me.tabClientes.TabIndex = 0
        Me.tabClientes.Text = "Clientes"
        '
        'DTclientes
        '
        Me.DTclientes.AllowUserToAddRows = False
        Me.DTclientes.AllowUserToDeleteRows = False
        Me.DTclientes.AllowUserToResizeColumns = False
        Me.DTclientes.AllowUserToResizeRows = False
        Me.DTclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTclientes.Location = New System.Drawing.Point(18, 59)
        Me.DTclientes.Name = "DTclientes"
        Me.DTclientes.ReadOnly = True
        Me.DTclientes.RowHeadersVisible = False
        Me.DTclientes.Size = New System.Drawing.Size(585, 345)
        Me.DTclientes.TabIndex = 2
        '
        'txtBuscaclientes
        '
        Me.txtBuscaclientes.Location = New System.Drawing.Point(73, 12)
        Me.txtBuscaclientes.Name = "txtBuscaclientes"
        Me.txtBuscaclientes.Size = New System.Drawing.Size(166, 23)
        Me.txtBuscaclientes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'tabProductos
        '
        Me.tabProductos.BackColor = System.Drawing.Color.LightCyan
        Me.tabProductos.Controls.Add(Me.DTproductos)
        Me.tabProductos.Controls.Add(Me.txtBuscaproductos)
        Me.tabProductos.Controls.Add(Me.Label2)
        Me.tabProductos.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProductos.Location = New System.Drawing.Point(4, 22)
        Me.tabProductos.Name = "tabProductos"
        Me.tabProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProductos.Size = New System.Drawing.Size(618, 421)
        Me.tabProductos.TabIndex = 1
        Me.tabProductos.Text = "Productos"
        '
        'DTproductos
        '
        Me.DTproductos.AllowUserToAddRows = False
        Me.DTproductos.AllowUserToDeleteRows = False
        Me.DTproductos.AllowUserToResizeColumns = False
        Me.DTproductos.AllowUserToResizeRows = False
        Me.DTproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTproductos.Location = New System.Drawing.Point(18, 61)
        Me.DTproductos.Name = "DTproductos"
        Me.DTproductos.ReadOnly = True
        Me.DTproductos.RowHeadersVisible = False
        Me.DTproductos.Size = New System.Drawing.Size(585, 345)
        Me.DTproductos.TabIndex = 5
        '
        'txtBuscaproductos
        '
        Me.txtBuscaproductos.Location = New System.Drawing.Point(73, 14)
        Me.txtBuscaproductos.Name = "txtBuscaproductos"
        Me.txtBuscaproductos.Size = New System.Drawing.Size(166, 23)
        Me.txtBuscaproductos.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Buscar:"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Beige
        Me.TabPage1.Controls.Add(Me.DTusuarios)
        Me.TabPage1.Controls.Add(Me.txtBuscausuarios)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(618, 421)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Usuarios"
        '
        'DTusuarios
        '
        Me.DTusuarios.AllowUserToAddRows = False
        Me.DTusuarios.AllowUserToDeleteRows = False
        Me.DTusuarios.AllowUserToResizeColumns = False
        Me.DTusuarios.AllowUserToResizeRows = False
        Me.DTusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTusuarios.Location = New System.Drawing.Point(18, 61)
        Me.DTusuarios.Name = "DTusuarios"
        Me.DTusuarios.ReadOnly = True
        Me.DTusuarios.RowHeadersVisible = False
        Me.DTusuarios.Size = New System.Drawing.Size(585, 345)
        Me.DTusuarios.TabIndex = 8
        '
        'txtBuscausuarios
        '
        Me.txtBuscausuarios.Location = New System.Drawing.Point(73, 14)
        Me.txtBuscausuarios.Name = "txtBuscausuarios"
        Me.txtBuscausuarios.Size = New System.Drawing.Size(166, 23)
        Me.txtBuscausuarios.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Buscar:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage2.Controls.Add(Me.DTinstructores)
        Me.TabPage2.Controls.Add(Me.txtBuscainstructores)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(618, 421)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Instructores"
        '
        'DTinstructores
        '
        Me.DTinstructores.AllowUserToAddRows = False
        Me.DTinstructores.AllowUserToDeleteRows = False
        Me.DTinstructores.AllowUserToResizeColumns = False
        Me.DTinstructores.AllowUserToResizeRows = False
        Me.DTinstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTinstructores.Location = New System.Drawing.Point(18, 61)
        Me.DTinstructores.Name = "DTinstructores"
        Me.DTinstructores.ReadOnly = True
        Me.DTinstructores.RowHeadersVisible = False
        Me.DTinstructores.Size = New System.Drawing.Size(585, 345)
        Me.DTinstructores.TabIndex = 8
        '
        'txtBuscainstructores
        '
        Me.txtBuscainstructores.Location = New System.Drawing.Point(73, 14)
        Me.txtBuscainstructores.Name = "txtBuscainstructores"
        Me.txtBuscainstructores.Size = New System.Drawing.Size(166, 23)
        Me.txtBuscainstructores.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Buscar:"
        '
        'ConsultaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 471)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(666, 510)
        Me.MinimumSize = New System.Drawing.Size(666, 510)
        Me.Name = "ConsultaGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaGeneral"
        Me.TabControl1.ResumeLayout(False)
        Me.tabClientes.ResumeLayout(False)
        Me.tabClientes.PerformLayout()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProductos.ResumeLayout(False)
        Me.tabProductos.PerformLayout()
        CType(Me.DTproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DTusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DTinstructores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosInstructores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabClientes As System.Windows.Forms.TabPage
    Friend WithEvents DTclientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscaclientes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabProductos As System.Windows.Forms.TabPage
    Friend WithEvents DTproductos As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscaproductos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DTusuarios As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscausuarios As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DTinstructores As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscainstructores As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DatosClientes As System.Windows.Forms.BindingSource
    Friend WithEvents DatosProductos As System.Windows.Forms.BindingSource
    Friend WithEvents DatosUsuarios As System.Windows.Forms.BindingSource
    Friend WithEvents DatosInstructores As System.Windows.Forms.BindingSource
End Class
