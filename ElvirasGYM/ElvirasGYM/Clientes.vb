Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Clientes

    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim SQLString, SQLString2 As String
    Dim idCliente As Integer
    Dim imagen As String
    Dim datos As New DataSet
    Dim exitefoto As Boolean = False


    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    'Instancia para la clase 
    Dim BDobj As New BDMysql(server, BD, user, pass)


    'Llena el Datagrid con la información de usuarios
    Sub LlenarBindingSource()
        If tabcliente.SelectedIndex = 0 Then
            BDobj.cnn.Close()
            BDobj.open()
            BDobj.da = New MySqlDataAdapter("SELECT clientes.DNI as DNI, clientes.nombre as Nombre, clientes.apellido_paterno as 'Apellido Paterno', clientes.apellido_materno as 'Apellido Materno', pagos.tipo as 'Tipo de Pago' FROM clientes left join pagos on clientes.pagos_id = pagos.id order by clientes.id", BDobj.cnn)
            BDobj.dt = New DataTable
            BDobj.dt.Clear()
            BDobj.da.Fill(BDobj.dt)
            BindingSource1.DataSource = BDobj.dt
            Me.DTclientes.DataSource = BindingSource1
            DTclientes.Columns(0).Width = 50
            DTclientes.Columns(1).Width = 130
            DTclientes.Columns(2).Width = 140
            DTclientes.Columns(3).Width = 140
            DTclientes.Columns(4).Width = 100
            DTclientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            Me.DTclientes.DefaultCellStyle.Font = New Font("Tahoma", 11)
            DTclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ElseIf tabcliente.SelectedIndex = 1 Then
            BDobj.da = New MySqlDataAdapter("SELECT DNI as DNI, CONCAT(nombre,' ',apellido_paterno,' ',apellido_materno) as 'Nombre Completo' FROM clientes WHERE DNI > 1001 order by DNI", BDobj.cnn)
            BDobj.dt = New DataTable
            BDobj.dt.Clear()
            BDobj.da.Fill(BDobj.dt)
            BSourcepagos.DataSource = BDobj.dt
            Me.DTPclientes.DataSource = BSourcepagos
            DTPclientes.Columns(0).Width = 60
            DTPclientes.Columns(1).Width = 200
            DTPclientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            'Me.DTPclientes.DefaultCellStyle.Font = New Font("Tahoma", 11)
            DTPclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
    End Sub

    Private Sub Aplicar_Filtro()
        ' verificar que el DataSource no esté vacio  
        If BindingSource1.DataSource Is Nothing Then
            ' si no hay registros cambiar el color del TextBox
            'txtBuscar.BackColor = Color.Red
            Exit Sub
        End If

        Try
            Dim filtro As String = String.Empty
            'Se filtra por nombre, apellido paterno y apellido materno
            filtro = "[Nombre] like '%" & txtBuscar.Text.Trim & "%' or  [Apellido Paterno] like '%" & txtBuscar.Text.Trim & "%' or [Apellido Materno] like '%" & txtBuscar.Text.Trim & "%'"
            BindingSource1.Filter = filtro
            DTclientes.Rows(0).Selected = True
        Catch ex As Exception 'Errores
            'MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Aplicar_FiltroPagos()
        ' verificar que el DataSource no esté vacio  
        If BSourcepagos.DataSource Is Nothing Then
            txtCliente.BackColor = Color.Red
            Exit Sub
        End If

        Try
            Dim filtro As String = String.Empty
            'Se filtra por nombre, apellido paterno y apellido materno
            filtro = "[Nombre Completo] like '%" & txtBuscar2.Text.Trim & "%' "
            BSourcepagos.Filter = filtro
            DTPclientes.Rows(0).Selected = True
        Catch ex As Exception 'Errores
            'MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Llena el combobox de grupo desde la base de datos
    Private Sub llenar_Combo()
        If tabcliente.SelectedIndex = 0 Then
            BDobj.cmd = New MySqlCommand
            BDobj.da = New MySqlDataAdapter
            BDobj.dt = New DataTable
            BDobj.cmd.Connection = BDobj.cnn
            BDobj.cmd.CommandText = "SELECT id, tipo FROM pagos order by id"
            BDobj.da.SelectCommand = BDobj.cmd
            BDobj.da.Fill(BDobj.dt)
            cbxTipo.DataSource = BDobj.dt
            cbxTipo.ValueMember = "id"
            cbxTipo.DisplayMember = "tipo"
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList
        ElseIf tabcliente.SelectedIndex = 1 Then
            BDobj.cmd = New MySqlCommand
            BDobj.da = New MySqlDataAdapter
            BDobj.dt = New DataTable
            BDobj.cmd.Connection = BDobj.cnn
            BDobj.cmd.CommandText = "SELECT id, tipo FROM pagos order by id"
            BDobj.da.SelectCommand = BDobj.cmd
            BDobj.da.Fill(BDobj.dt)
            cbxTipopago.DataSource = BDobj.dt
            cbxTipopago.ValueMember = "id"
            cbxTipopago.DisplayMember = "tipo"
            cbxTipopago.DropDownStyle = ComboBoxStyle.DropDownList
        End If 
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
    End Sub


    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobj.open()
        llenar_Combo()
        LlenarBindingSource()
        'llenar_DTPclientes()
        cbxCantidad.SelectedIndex = 0
        Me.Show()
        bloquear()
        cbxTipo.Enabled = False
    End Sub


    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Aplicar_Filtro()
    End Sub

    Private Sub DTclientes_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTclientes.KeyDown
        Dim fila As Integer
        If e.KeyCode = Keys.Enter Then
            fila = DTclientes.CurrentRow.Index
            txtDNI.Text = DTclientes.Item(0, fila).Value
            txtDNI.Enabled = False
            buscar()
            activar()
            btnGuardar.Enabled = True
            btnAgregar.Enabled = False
            txtNombre.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            btnEliminar.PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            btnNuevo.PerformClick()
        End If
    End Sub

    Private Sub DTclientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTclientes.CellDoubleClick
        Dim fila As Integer
        fila = DTclientes.CurrentRow.Index
        txtDNI.Text = DTclientes.Item(0, fila).Value
        activar()
        txtDNI.Enabled = False
        btnGuardar.Enabled = True
        btnAgregar.Enabled = False
        buscar()
        txtNombre.Focus()
    End Sub

    Private Sub cbxTipo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipo.GotFocus
        cbxTipo.BackColor = Color.Honeydew
        cbxTipo.ForeColor = Color.Black
    End Sub

    Private Sub cbxTipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipo.LostFocus
        cbxTipo.BackColor = Color.White
        cbxTipo.ForeColor = Color.Black
    End Sub

    Private Sub cbxGrupo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cbxClase.BackColor = Color.Honeydew
        cbxClase.ForeColor = Color.Black
    End Sub

    Private Sub cbxGrupo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cbxClase.BackColor = Color.White
        cbxClase.ForeColor = Color.Black
    End Sub

    Private Sub txtDNI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNI.GotFocus
        txtDNI.BackColor = Color.Honeydew
        txtDNI.ForeColor = Color.Black
    End Sub

    Private Sub txtDNI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNI.LostFocus
        txtDNI.BackColor = Color.White
        txtDNI.ForeColor = Color.Black
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.BackColor = Color.Honeydew
        txtNombre.ForeColor = Color.Black

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Validar.letras(e.KeyChar)
    End Sub

    Private Sub txtApellidop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidop.KeyPress
        Validar.letras(e.KeyChar)
    End Sub

    Private Sub txtApellidom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidom.KeyPress
        Validar.letras(e.KeyChar)
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        Validar.letras(e.KeyChar)
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
    End Sub

    Private Sub txtApellidop_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidop.GotFocus
        txtApellidop.BackColor = Color.Honeydew
        txtApellidop.ForeColor = Color.Black

    End Sub

    Private Sub txtApellidop_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidop.LostFocus
        txtApellidop.BackColor = Color.White
        txtApellidop.ForeColor = Color.Black
    End Sub

    Private Sub txtApellidom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidom.GotFocus
        txtApellidom.BackColor = Color.Honeydew
        txtApellidom.ForeColor = Color.Black
    End Sub

    Private Sub txtApellidom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidom.LostFocus
        txtApellidom.BackColor = Color.White
        txtApellidom.ForeColor = Color.Black
    End Sub

    Private Sub datosclientes_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles datosclientes.Paint
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.RoyalBlue, 2.0)
        g.DrawRectangle(pen, New Rectangle(txtDNI.Location, txtDNI.Size))
        g.DrawRectangle(pen, New Rectangle(txtNombre.Location, txtNombre.Size))
        g.DrawRectangle(pen, New Rectangle(txtApellidop.Location, txtApellidop.Size))
        g.DrawRectangle(pen, New Rectangle(txtApellidom.Location, txtApellidom.Size))
        g.DrawRectangle(pen, New Rectangle(cbxTipo.Location, cbxTipo.Size))
        pen.Dispose()
    End Sub

    Private Sub reservaclase_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles reservaclase.Paint
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.RoyalBlue, 2.0)
        g.DrawRectangle(pen, New Rectangle(txtDNI2.Location, txtDNI.Size))
        g.DrawRectangle(pen, New Rectangle(txtNombre2.Location, txtNombre.Size))
        g.DrawRectangle(pen, New Rectangle(txtApellidop2.Location, txtApellidop.Size))
        g.DrawRectangle(pen, New Rectangle(txtApellidom2.Location, txtApellidom.Size))
        g.DrawRectangle(pen, New Rectangle(cbxClase.Location, cbxClase.Size))
        g.DrawRectangle(pen, New Rectangle(cbxGrupo.Location, cbxClase.Size))
        pen.Dispose()
    End Sub

    'Bloquea cajas de texto
    Sub bloquear()
        cbxTipo.Enabled = False
        btnTomafoto.Enabled = False
        For Each c As Control In panelCliente.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = False
            End If
        Next
    End Sub

    'Activa cajas de texto
    Sub activar()
        cbxTipo.Enabled = True
        btnTomafoto.Enabled = True
        For Each c As Control In panelCliente.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            End If
        Next
    End Sub

    'Limpia las cajas de texto
    Sub limpiar()
        For Each c As Control In panelCliente.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    'Limpia las cajas de texto
    Sub limpiarPagos()
        fotocliente.Image = Nothing
        DTPHistorial.Rows.Clear()
        For Each c As Control In Panel2.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    'Verifica que ninguna caja de texto este vacia
    Function valida_blanco() As Boolean
        Dim _bandera As Boolean
        For Each c As Control In panelCliente.Controls
            If TypeOf c Is TextBox Then
                If c.Text = "" Then
                    _bandera = True
                End If
            End If
        Next
        Return _bandera
    End Function


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim dni As Integer
        BDobj.cnn.Close()
        BDobj.open()
        'BDobj.da = Nothing

        'Buscar DNI en la Base de datos el último
        SQLString = String.Format("SELECT * FROM clientes order by DNI")
        reader = BDobj.executeReader(SQLString)
        While reader.Read = True
            dni = CInt(reader("DNI").ToString)
        End While
        limpiar()
        activar()
        LlenarBindingSource()
        txtDNI.Text = dni + 1
        txtDNI.Enabled = False
        txtBuscar.Enabled = False
        txtBuscar.Text = ""
        imgFoto.Image = Nothing
        'txtBuscar.ForeColor = Color.Gainsboro
        cbxTipo.Enabled = True
        btnGuardar.Enabled = False
        btnAgregar.Enabled = True
        txtNombre.Focus()
    End Sub

    Sub buscar()
        Dim ruta As Image
        'Dim imagen2 As Bitmap
        SQLString = String.Format("SELECT * FROM clientes WHERE DNI = " & Trim(txtDNI.Text))
        reader = BDobj.executeReader(SQLString)
        If reader.Read = True Then
            txtNombre.Text = reader("nombre").ToString
            txtApellidop.Text = reader("apellido_paterno").ToString
            txtApellidom.Text = reader("apellido_materno").ToString
            cbxTipo.SelectedValue = reader("pagos_id").ToString
            If reader("foto") = "pendiente" Then
                imgFoto.Image = Nothing
            Else
                ruta = Image.FromFile("..\Fotoclientes\" & reader("foto"))
                'imagen2 = New Bitmap(ruta, 114, 115)
                imgFoto.SizeMode = PictureBoxSizeMode.StretchImage
                imgFoto.Image = ruta
            End If
        Else
            MsgBox("No se encontro un registro")
            limpiar()
            txtDNI.Focus()
        End If
        reader.Close()
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ruta As String = "..\Fotoclientes\foto" & txtDNI.Text & ".jpg"
        Dim foto As New Bitmap(120, 150)
        'Checa que ninguna caja de texto este vacia
        Dim bandera As Boolean
        For Each x As Control In panelCliente.Controls
            If TypeOf x Is TextBox Then
                If x.Text = "" Then
                    bandera = True
                End If
            End If
        Next
        imgFoto.DrawToBitmap(Foto, New Rectangle(0, 0, 120, 150))
        Foto.Save(ruta, Imaging.ImageFormat.Jpeg)
        If imgFoto.Image Is Nothing Then
            imagen = "pendinte"
        Else
            imagen = "foto" & txtDNI.Text & ".jpg"
        End If
        If bandera = False Then
            SQLString = String.Format("INSERT INTO clientes (DNI, nombre, apellido_paterno, apellido_materno, foto, activo, grupo_id, pagos_id, descuentos_id ) " & _
                                            " values ({0},'{1}','{2}','{3}','{4}',{5},{6},{7},{8})", _
                                            Trim(txtDNI.Text), Trim(txtNombre.Text), Trim(txtApellidop.Text), Trim(txtApellidom.Text), Trim(imagen), Trim(0), Trim(1), Trim(cbxTipo.SelectedValue), Trim(1))
            If BDobj.executeSQL(SQLString) Then
                MsgBox("Registro agregado con éxito...")
                LlenarBindingSource()
                btnNuevo.PerformClick()
            End If
        Else
            MsgBox("Te faltan datos....")
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim fila, dni As Integer
        Dim op As Integer
        fila = DTclientes.CurrentRow.Index
        dni = CInt(DTclientes.Item(0, fila).Value)
        op = MessageBox.Show("Esta seguro de eliminar el registro con DNI: " & dni, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = 6 Then
            SQLString = String.Format("DELETE FROM clientes WHERE DNI = " & dni)
            BDobj.executeSQL(SQLString)
            LlenarBindingSource()
        End If
    End Sub

    Private Sub tabcliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tabcliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            bloquear()
            'txtBuscar.Text = ""
            txtBuscar.Enabled = True
            txtBuscar.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            btnNuevo.PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            btnAgregar.PerformClick()
        ElseIf e.KeyCode = Keys.F5 Then
            btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim ruta As String = "..\Fotoclientes\foto" & txtDNI.Text & ".jpg"
        Dim foto As New Bitmap(120, 150)
        If My.Computer.FileSystem.FileExists("..\Fotoclientes\foto" & txtDNI.Text & ".jpg") Then
            'My.Computer.FileSystem.DeleteFile("..\Fotoclientes\foto" & txtDNI.Text & ".jpg")
            exitefoto = True
            ruta = "..\Fotoclientes\foto" & txtDNI.Text & "-2.jpg"
        End If
        imgFoto.DrawToBitmap(foto, New Rectangle(0, 0, 120, 150))
        foto.Save(ruta, Imaging.ImageFormat.Jpeg)
        'Checa que ninguna caja de texto este vacia
        Dim bandera As Boolean
        For Each x As Control In panelCliente.Controls
            If TypeOf x Is TextBox Then
                If x.Text = "" Then
                    bandera = True
                End If
            End If
        Next
        If imgFoto.Image Is Nothing Then
            imagen = "pendinte"
        ElseIf exitefoto = True Then
            imagen = "foto" & txtDNI.Text & "-2.jpg"
        Else
            imagen = "foto" & txtDNI.Text & ".jpg"
        End If
        If bandera = False And txtBuscar.Text = "" Then
            SQLString = String.Format("UPDATE clientes SET nombre = '" & Trim(txtNombre.Text) & "', apellido_paterno = '" & Trim(txtApellidop.Text) & "', apellido_materno = '" & Trim(txtApellidom.Text) & "', pagos_id = " & Trim(cbxTipo.SelectedValue) & ", foto = '" & Trim(imagen) & "' WHERE DNI = " & Trim(txtDNI.Text) & "")
            If BDobj.executeSQL(SQLString) Then
                MsgBox("Registro modificado...")
                LlenarBindingSource()
                btnNuevo.PerformClick()
            End If
        Else
            MsgBox("Faltan datos...")
        End If
    End Sub

    Private Sub btnTomafoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTomafoto.Click
        Camara.Show()
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        imgFoto.Image = Nothing
    End Sub

    Private Sub txtBuscar2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim fila, dni As Integer
            fila = DTPclientes.CurrentRow.Index
            dni = DTPclientes.Item(0, fila).Value
            txtCliente.Text = DTPclientes.Item(1, fila).Value
            buscar_formpago(dni)
        End If
    End Sub

    Sub buscar_formpago(ByVal dni As Integer)
        SQLString = String.Format("SELECT pagos.id as idPa, pagos.tipo, clientes.foto, clientes.id as idCli FROM pagos left join clientes ON clientes.pagos_id = pagos.id WHERE clientes.DNI = " & dni)
        reader = BDobj.executeReader(SQLString)
        If reader.Read Then
            cbxTipopago.SelectedValue = reader("idPa").ToString
            idCliente = reader("idCli")
            If reader("foto") = "pendiente" Then
                fotocliente.Image = Nothing
            Else
                Dim ruta = Image.FromFile("..\Fotoclientes\" & reader("foto"))
                fotocliente.SizeMode = PictureBoxSizeMode.StretchImage
                fotocliente.Image = ruta
            End If
            reader.Close()
            DTPHistorial.Rows.Clear()
            verifica_debe()
        End If
        reader.Close()
    End Sub

    Private Sub DTPclientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPclientes.DoubleClick
        Dim fila, dni As Integer
        fila = DTPclientes.CurrentRow.Index
        dni = DTPclientes.Item(0, fila).Value
        txtCliente.Text = DTPclientes.Item(1, fila).Value
        buscar_formpago(dni)
    End Sub

    Private Sub DTPclientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPclientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim fila, dni As Integer
            fila = DTPclientes.CurrentRow.Index
            dni = DTPclientes.Item(0, fila).Value
            txtCliente.Text = DTPclientes.Item(1, fila).Value
            buscar_formpago(dni)
        End If
    End Sub

    Sub verifica_debe()
        SQLString = String.Format("SELECT * FROM clientes_pagos WHERE clientes_id = " & idCliente)
        If BDobj.existe(SQLString) Then
            Exit Sub
        Else
            DTPHistorial.Rows.Add("No tiene pagos")
            cbxDebe.SelectedIndex = 0
        End If
    End Sub
  
    Private Sub txtBuscar2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar2.KeyPress
        Validar.letrasAndDecimal(e.KeyChar)
    End Sub

    Private Sub txtBuscar2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar2.TextChanged
        Aplicar_FiltroPagos()
    End Sub

    Private Sub tabcliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabcliente.SelectedIndexChanged
        LlenarBindingSource()
        llenar_Combo()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Dim bandera As Boolean
        For Each x As Control In Panel2.Controls
            If TypeOf x Is TextBox Then
                If x.Text = "" Then
                    bandera = True
                End If
            End If
        Next
        If bandera = False Then
            Dim fechaAn, fechaPa, fechaCo As String
            fechaPa = CDate(DTPpago.Value.ToShortDateString).ToString("yyyy-MM-dd")
            fechaCo = CDate(DTPcorte.Value.ToShortDateString).ToString("yyyy-MM-dd")
            fechaAn = fechaPa
            SQLString = String.Format("INSERT INTO clientes_pagos (pagos_id, clientes_id, fecha_anterior, fecha_corte, fecha_pago, pago) " & _
                         "values({0},{1},'{2}','{3}','{4}',{5})", Trim(cbxTipopago.SelectedValue), Trim(idCliente), Trim(fechaAn), Trim(fechaCo), Trim(fechaPa), Trim(txtPago.Text))
            If BDobj.executeSQL(SQLString) Then
                MsgBox("El pago se registro exitosamente...")
                limpiarPagos()
                txtBuscar2.Focus()
            End If
        Else
            MsgBox("Se necesitan los datos.")
            txtBuscar2.Focus()
        End If
    End Sub

    Private Sub DTPpago_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPpago.TextChanged
        If cbxTipopago.SelectedValue = 1 Then
            DTPcorte.Value = DTPpago.Value.Date.AddDays(cbxCantidad.SelectedItem * 6)
        ElseIf cbxTipopago.SelectedValue = 2 Then
            DTPcorte.Value = DTPpago.Value.Date.AddMonths(cbxCantidad.SelectedItem)
        End If
    End Sub
End Class