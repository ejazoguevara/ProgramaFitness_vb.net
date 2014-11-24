Imports MySql.Data.MySqlClient
Public Class ListaClientes
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
        BDobj.da = New MySqlDataAdapter("SELECT DNI, nombre, apellido_paterno, apellido_materno FROM clientes", BDobj.cnn)
        BDobj.dt = New DataTable
        BDobj.dt.Clear()
        BDobj.da.Fill(BDobj.dt)
        BindingSource1.DataSource = BDobj.dt
        Me.DTclientes.DataSource = BindingSource1
        DTclientes.Columns(0).Width = 50
        DTclientes.Columns(1).Width = 130
        DTclientes.Columns(2).Width = 140
        DTclientes.Columns(3).Width = 140
        'DTclientes.Columns(0).Resizable = DataGridViewTriState.False
        DTclientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        Me.DTclientes.DefaultCellStyle.Font = New Font("Tahoma", 11)
        DTclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
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


    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        Aplicar_Filtro()
    End Sub

    Private Sub DTclientes_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTclientes.CellContentDoubleClick
        Dim fila As Integer
        fila = DTclientes.CurrentRow.Index
        Asistencia.txtDNI.Text = DTclientes.Item(0, fila).Value
        Asistencia.btnBuscar.PerformClick()
        Me.Dispose()
    End Sub

    Private Sub DTclientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTclientes.KeyDown
        Dim fila As Integer
        If e.KeyCode = Keys.Enter Then
            fila = DTclientes.CurrentRow.Index
            Asistencia.txtDNI.Text = DTclientes.Item(0, fila).Value
            Asistencia.btnBuscar.PerformClick()
            Me.Dispose()
        End If
    End Sub

    Private Sub ListaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobj.open()
        LlenarBindingSource()
    End Sub
End Class