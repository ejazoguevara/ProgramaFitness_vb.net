Imports MySql.Data.MySqlClient
Public Class Clientes

    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim SQLString, SQLString2 As String
    Dim id As Integer

    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    'Instancia para la clase 
    Dim BDobj As New BDMysql(server, BD, user, pass)


    'Llena el Datagrid con la información de usuarios
    Sub LlenarBindingSource()
        BDobj.da = New MySqlDataAdapter("select id, nombre, apellido_paterno, apellido_materno, grupo_id, pagos_id from clientes order by id", BDobj.cnn)
        BDobj.dt = New DataTable
        BDobj.dt.Clear()
        BDobj.da.Fill(BDobj.dt)
        BindingSource1.DataSource = BDobj.dt
        Me.DTclientes.DataSource = BindingSource1
        DTclientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        Me.DTclientes.DefaultCellStyle.Font = New Font("Tahoma", 11)
        DTclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
    End Sub


    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobj.open()
        Dim tab As Integer = tabcliente.SelectedIndex
        If tab = 0 Then
            LlenarBindingSource()
        End If
    End Sub

    Private Sub DTclientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTclientes.KeyDown
        Dim fila As Integer
        fila = DTclientes.CurrentRow.Index
        If e.KeyCode = Keys.Enter Then
            txtDNI.Text = DTclientes.Item(0, fila).Value
            txtNombre.Text = DTclientes.Item(1, fila).Value
            txtApellidop.Text = DTclientes.Item(2, fila).Value
            txtApellidom.Text = DTclientes.Item(3, fila).Value
            txtDNI.Enabled = False
            'activar()
            'txtId.Enabled = False
            'btnAgregar.Enabled = False
            'btnCambiar.Enabled = True
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

    Private Sub cbxGrupo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxGrupo.GotFocus
        cbxGrupo.BackColor = Color.Honeydew
        cbxGrupo.ForeColor = Color.Black
    End Sub

    Private Sub cbxGrupo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxGrupo.LostFocus
        cbxGrupo.BackColor = Color.White
        cbxGrupo.ForeColor = Color.Black
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
        g.DrawRectangle(pen, New Rectangle(cbxGrupo.Location, cbxGrupo.Size))
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
        'activar()
        txtDNI.Text = id + 1
        txtDNI.Enabled = False
        'btnAgregar.Enabled = True
        'btnCambiar.Enabled = False
        txtNombre.Focus()
    End Sub

   
End Class