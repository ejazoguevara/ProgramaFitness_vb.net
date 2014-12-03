Imports MySql.Data.MySqlClient
Public Class ConsultaGeneral
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim SQLString As String
    Dim datos As New DataSet


    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    'Instancia para la clase 
    Dim BDobj As New BDMysql(server, BD, user, pass)

    Sub LlenarBindingSource()
        If TabControl1.SelectedIndex = 0 Then
            BDobj.da = New MySqlDataAdapter("SELECT clientes.DNI as DNI, clientes.nombre as Nombre, clientes.apellido_paterno as 'Apellido Paterno', clientes.apellido_materno as 'Apellido Materno', pagos.tipo as 'Tipo / Pago' FROM clientes left join pagos on clientes.pagos_id = pagos.id WHERE clientes.DNI > 1001 order by clientes.DNI", BDobj.cnn)
            BDobj.dt = New DataTable
            BDobj.dt.Clear()
            BDobj.da.Fill(BDobj.dt)
            DatosClientes.DataSource = BDobj.dt
            Me.DTclientes.DataSource = DatosClientes
            DTclientes.Columns(0).Width = 60
            DTclientes.Columns(1).Width = 140
            DTclientes.Columns(2).Width = 140
            DTclientes.Columns(3).Width = 140
            DTclientes.Columns(4).Width = 110
            DTclientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            Me.DTclientes.DefaultCellStyle.Font = New Font("Tahoma", 11)
            DTclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ElseIf TabControl1.SelectedIndex = 1 Then
            BDobj.da = New MySqlDataAdapter("SELECT DNI as DNI, nombre as Nombre, cantidad as Cantidad, precio as Precio FROM productos order by DNI", BDobj.cnn)
            BDobj.dt = New DataTable
            BDobj.dt.Clear()
            BDobj.da.Fill(BDobj.dt)
            DatosProductos.DataSource = BDobj.dt
            Me.DTproductos.DataSource = DatosProductos
            DTproductos.Columns(0).Width = 90
            DTproductos.Columns(1).Width = 180
            DTproductos.Columns(2).Width = 160
            DTproductos.Columns(3).Width = 160
            DTproductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            Me.DTproductos.DefaultCellStyle.Font = New Font("Tahoma", 11)
            DTproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ElseIf TabControl1.SelectedIndex = 2 Then
            BDobj.da = New MySqlDataAdapter("SELECT nombre as Nombre, apellidos as Apellidos, usuario as Usuario, contrasenia as Contraseña FROM usuarios order by nombre", BDobj.cnn)
            BDobj.dt = New DataTable
            BDobj.dt.Clear()
            BDobj.da.Fill(BDobj.dt)
            DatosUsuarios.DataSource = BDobj.dt
            Me.DTusuarios.DataSource = DatosUsuarios
            DTusuarios.Columns(0).Width = 120
            DTusuarios.Columns(1).Width = 260
            DTusuarios.Columns(2).Width = 100
            DTusuarios.Columns(3).Width = 100
            DTusuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            Me.DTusuarios.DefaultCellStyle.Font = New Font("Tahoma", 11)
            DTusuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ElseIf TabControl1.SelectedIndex = 3 Then
            BDobj.da = New MySqlDataAdapter("SELECT nombre as Nombre, apellidos as Apellidos, sexo as Sexo, edad as Edad FROM instructores order by nombre", BDobj.cnn)
            BDobj.dt = New DataTable
            BDobj.dt.Clear()
            BDobj.da.Fill(BDobj.dt)
            DatosInstructores.DataSource = BDobj.dt
            Me.DTinstructores.DataSource = DatosInstructores
            DTinstructores.Columns(0).Width = 120
            DTinstructores.Columns(1).Width = 260
            DTinstructores.Columns(2).Width = 100
            DTinstructores.Columns(3).Width = 100
            DTinstructores.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            Me.DTinstructores.DefaultCellStyle.Font = New Font("Tahoma", 11)
            DTinstructores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
    End Sub

    Private Sub Aplicar_Filtro()
        Dim filtro1, filtro2, filtro3, filtro4 As String
        '' verificar que el DataSource no esté vacio  
        'If DatosClientes.DataSource Is Nothing Then
        '    txtBuscaclientes.BackColor = Color.Red
        '    Exit Sub
        'End If
        If TabControl1.SelectedIndex = 0 Then
            filtro1 = "[Nombre] like '%" & txtBuscaclientes.Text.Trim & "%' or  [Apellido Paterno] like '%" & txtBuscaclientes.Text.Trim & "%' or [Apellido Materno] like '%" & txtBuscaclientes.Text.Trim & "%'"
            DatosClientes.Filter = filtro1
            DTclientes.Rows(0).Selected = True
        ElseIf TabControl1.SelectedIndex = 1 Then
            filtro2 = "[Nombre] like '%" & txtBuscaproductos.Text.Trim & "%'"
            DatosProductos.Filter = filtro2
            DTproductos.Rows(0).Selected = True
        ElseIf TabControl1.SelectedIndex = 2 Then
            filtro3 = "[Nombre] like '%" & txtBuscausuarios.Text.Trim & "%' or [Apellidos] like '%" & txtBuscausuarios.Text.Trim & "%'"
            DatosUsuarios.Filter = filtro3
            DTusuarios.Rows(0).Selected = True
        ElseIf TabControl1.SelectedIndex = 3 Then
            filtro3 = "[Nombre] like '%" & txtBuscainstructores.Text.Trim & "%' or [Apellidos] like '%" & txtBuscainstructores.Text.Trim & "%'"
            DatosInstructores.Filter = filtro3
            DTinstructores.Rows(0).Selected = True
        End If
    End Sub

    Private Sub ConsultaGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobj.open()
        LlenarBindingSource()
    End Sub

    Private Sub txtBuscaclientes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscaclientes.GotFocus
        txtBuscaclientes.BackColor = Color.Honeydew
        txtBuscaclientes.ForeColor = Color.Black
    End Sub

    Private Sub txtBuscaclientes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscaclientes.LostFocus
        txtBuscaclientes.BackColor = Color.White
        txtBuscaclientes.ForeColor = Color.Black
    End Sub

    Private Sub txtBuscaclientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscaclientes.KeyDown
        Aplicar_Filtro()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        LlenarBindingSource()
    End Sub

    
    Private Sub txtBuscaproductos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscaproductos.GotFocus
        txtBuscaproductos.BackColor = Color.Honeydew
        txtBuscaproductos.ForeColor = Color.Black
    End Sub

    Private Sub txtBuscaproductos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscaproductos.KeyDown
        Aplicar_Filtro()
    End Sub

    Private Sub txtBuscaproductos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscaproductos.LostFocus
        txtBuscaproductos.BackColor = Color.White
        txtBuscaproductos.ForeColor = Color.Black
    End Sub

    Private Sub txtBuscausuarios_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscausuarios.GotFocus
        txtBuscausuarios.BackColor = Color.Honeydew
        txtBuscausuarios.ForeColor = Color.Black
    End Sub


    Private Sub txtBuscausuarios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscausuarios.KeyDown
        Aplicar_Filtro()
    End Sub

    Private Sub txtBuscausuarios_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscausuarios.LostFocus
        txtBuscausuarios.BackColor = Color.White
        txtBuscausuarios.ForeColor = Color.Black
    End Sub

    Private Sub txtBuscainstructores_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscainstructores.GotFocus
        txtBuscainstructores.BackColor = Color.Honeydew
        txtBuscainstructores.ForeColor = Color.Black
    End Sub

    Private Sub txtBuscainstructores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscainstructores.KeyDown
        Aplicar_Filtro()
    End Sub

    Private Sub txtBuscainstructores_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscainstructores.LostFocus
        txtBuscainstructores.BackColor = Color.White
        txtBuscainstructores.ForeColor = Color.Black
    End Sub
End Class