Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Clientes

    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim SQLString, SQLString2 As String
    Dim id As Integer
    Dim datos As New DataSet


    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    'Instancia para la clase 
    Dim BDobj As New BDMysql(server, BD, user, pass)


    'Llena el Datagrid con la información de usuarios
    Sub LlenarBindingSource()
        'SQLString = "SELECT clientes.id, clientes.nombre, clientes.apellido_paterno, clientes.apellido_materno, pagos.tipo FROM clientes left join pagos on clientes.pagos_id = pagos.id order by clientes.id"
        'BDobj.cmd = New MySqlCommand(SQLString, BDobj.cnn)
        'BDobj.da.SelectCommand = BDobj.cmd
        'BDobj.da.Fill(datos)
        'BindingSource1.DataSource = datos
        'DTclientes.DataSource = BindingSource1

        BDobj.da = New MySqlDataAdapter("SELECT clientes.id, clientes.nombre, clientes.apellido_paterno, clientes.apellido_materno, pagos.tipo FROM clientes left join pagos on clientes.pagos_id = pagos.id order by clientes.id", BDobj.cnn)
        datos = New DataSet
        BDobj.da.Fill(datos)
        BindingSource1.DataSource = datos.Tables(0)
        Me.DTclientes.DataSource = BindingSource1
        DTclientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        Me.DTclientes.DefaultCellStyle.Font = New Font("Tahoma", 11)
        DTclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
    End Sub

    'Llena el combobox de grupo desde la base de datos
    Private Sub llenar_Combo()
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
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
    End Sub


    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobj.open()
        llenar_Combo()
        Dim tab As Integer = tabcliente.SelectedIndex
        Me.Show()
        If tab = 0 Then
            LlenarBindingSource()
        End If
        bloquear()
        cbxTipo.Enabled = False
    End Sub

    Private Sub DTclientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim fila As Integer
        fila = DTclientes.CurrentRow.Index
        If e.KeyCode = Keys.Enter Then
            txtDNI.Text = DTclientes.Item(0, fila).Value
            txtDNI.Enabled = False
            buscar()
            'activar()
        End If
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
        For Each c As Control In datosclientes.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = False
            End If
        Next
    End Sub

    'Activa cajas de texto
    Sub activar()
        For Each c As Control In datosclientes.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            End If
        Next
    End Sub

    'Limpia las cajas de texto
    Sub limpiar()
        For Each c As Control In datosclientes.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    'Verifica que ninguna caja de texto este vacia
    Function valida_blanco() As Boolean
        Dim _bandera As Boolean
        For Each c As Control In datosclientes.Controls
            If TypeOf c Is TextBox Then
                If c.Text = "" Then
                    _bandera = True
                End If
            End If
        Next
        Return _bandera
    End Function


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim id, fila As Integer
        fila = DTclientes.RowCount()
        id = CInt(DTclientes.Item(0, fila - 1).Value)
        limpiar()
        activar()
        txtDNI.Text = id + 1
        txtDNI.Enabled = False
        cbxTipo.Enabled = True
        txtNombre.Focus()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub

    Sub buscar()
        SQLString = String.Format("SELECT * FROM clientes WHERE id = " & Trim(txtDNI.Text))
        reader = BDobj.executeReader(SQLString)
        If reader.Read = True Then
            txtNombre.Text = reader("nombre").ToString
            txtApellidop.Text = reader("apellido_paterno").ToString
            txtApellidom.Text = reader("apellido_materno").ToString
            cbxTipo.SelectedValue = reader("pagos_id").ToString
        Else
            MsgBox("No se encontro un registro")
            limpiar()
            txtDNI.Focus()
        End If
        reader.Close()
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'Checa que ninguna caja de texto este vacia
        Dim bandera As Boolean
        For Each x As Control In gbxDos.Controls
            If TypeOf x Is TextBox Then
                If x.Text = "" Then
                    bandera = True
                End If
            End If
        Next
        If bandera = False Then
            SQLString = String.Format("INSERT INTO clientes (nombre, apellido_paterno, apellido_materno, foto, activo, grupo_id, pagos_id, descuentos_id ) " & _
                                            " values ('{0}','{1}','{2}','{3}',{4},{5},{6},{7})", _
                                            Trim(txtNombre.Text), Trim(txtApellidop.Text), Trim(txtApellidom.Text), Trim("pendiente"), Trim(0), Trim(1), Trim(cbxTipo.SelectedValue), Trim(1))
            If BDobj.executeSQL(SQLString) Then
                MsgBox("Registro agregado con éxito...")
                btnNuevo.PerformClick()
                LlenarBindingSource()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim fila, id As Integer
        fila = DTclientes.CurrentRow.Index
        id = CInt(DTclientes.Item(0, fila).Value)
        SQLString = String.Format("DELETE FROM contacto WHERE id_contacto = " & id)
        BDobj.executeSQL(SQLString)
    End Sub
End Class