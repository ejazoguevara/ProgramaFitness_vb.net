﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DTclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI cliente:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(97, 23)
        Me.txtDNI.MaxLength = 4
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(82, 20)
        Me.txtDNI.TabIndex = 0
        '
        'DTclientes
        '
        Me.DTclientes.AllowUserToAddRows = False
        Me.DTclientes.AllowUserToResizeColumns = False
        Me.DTclientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DTclientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DTclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dni, Me.foto, Me.Nombre, Me.ApellidoP, Me.ApellidoM, Me.Fecha})
        Me.DTclientes.GridColor = System.Drawing.Color.RoyalBlue
        Me.DTclientes.Location = New System.Drawing.Point(2, 65)
        Me.DTclientes.Name = "DTclientes"
        Me.DTclientes.ReadOnly = True
        Me.DTclientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DTclientes.RowHeadersVisible = False
        Me.DTclientes.RowHeadersWidth = 42
        Me.DTclientes.RowTemplate.Height = 40
        Me.DTclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTclientes.Size = New System.Drawing.Size(604, 343)
        Me.DTclientes.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageKey = "buscar.png"
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(190, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(47, 47)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        Me.btnGuardar.BackColor = System.Drawing.Color.Honeydew
        Me.btnGuardar.ImageKey = "save.png"
        Me.btnGuardar.ImageList = Me.ImageList1
        Me.btnGuardar.Location = New System.Drawing.Point(506, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(47, 47)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.ImageKey = "exit.png"
        Me.btnSalir.ImageList = Me.ImageList1
        Me.btnSalir.Location = New System.Drawing.Point(559, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(47, 47)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = False
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
        'Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 411)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DTclientes)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(625, 450)
        Me.MinimumSize = New System.Drawing.Size(625, 450)
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
End Class
