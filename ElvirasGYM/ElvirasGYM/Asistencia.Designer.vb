<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Asistencia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.DTclientes = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI cliente:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(105, 54)
        Me.txtDNI.MaxLength = 4
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(95, 22)
        Me.txtDNI.TabIndex = 0
        '
        'DTclientes
        '
        Me.DTclientes.AllowUserToAddRows = False
        Me.DTclientes.AllowUserToDeleteRows = False
        Me.DTclientes.AllowUserToResizeColumns = False
        Me.DTclientes.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DTclientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DTclientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DTclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dni, Me.foto, Me.Nombre, Me.ApellidoP, Me.ApellidoM, Me.Fecha})
        Me.DTclientes.GridColor = System.Drawing.Color.RoyalBlue
        Me.DTclientes.Location = New System.Drawing.Point(2, 87)
        Me.DTclientes.Name = "DTclientes"
        Me.DTclientes.ReadOnly = True
        Me.DTclientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DTclientes.RowHeadersVisible = False
        Me.DTclientes.RowHeadersWidth = 42
        Me.DTclientes.RowTemplate.Height = 40
        Me.DTclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTclientes.Size = New System.Drawing.Size(705, 421)
        Me.DTclientes.TabIndex = 1
        '
        'id
        '
        Me.id.Frozen = True
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'dni
        '
        Me.dni.Frozen = True
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'foto
        '
        Me.foto.Frozen = True
        Me.foto.HeaderText = "Foto"
        Me.foto.Name = "foto"
        Me.foto.ReadOnly = True
        Me.foto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Nombre
        '
        Me.Nombre.Frozen = True
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'ApellidoP
        '
        Me.ApellidoP.Frozen = True
        Me.ApellidoP.HeaderText = "Apellido Paterno"
        Me.ApellidoP.Name = "ApellidoP"
        Me.ApellidoP.ReadOnly = True
        '
        'ApellidoM
        '
        Me.ApellidoM.Frozen = True
        Me.ApellidoM.HeaderText = "Apellido Materno"
        Me.ApellidoM.Name = "ApellidoM"
        Me.ApellidoM.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.Frozen = True
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.LightGreen
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.ImageKey = "buscar.png"
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(465, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 62)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "buscar.png")
        Me.ImageList1.Images.SetKeyName(1, "save.png")
        Me.ImageList1.Images.SetKeyName(2, "exit.png")
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LightGreen
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.ImageKey = "save.png"
        Me.btnGuardar.ImageList = Me.ImageList1
        Me.btnGuardar.Location = New System.Drawing.Point(549, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 62)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Coral
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.ImageKey = "exit.png"
        Me.btnSalir.ImageList = Me.ImageList1
        Me.btnSalir.Location = New System.Drawing.Point(631, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 62)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(114, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "F1 = Ayuda"
        '
        'Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(710, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DTclientes)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(726, 550)
        Me.MinimumSize = New System.Drawing.Size(726, 550)
        Me.Name = "Asistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia"
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents DTclientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents foto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
