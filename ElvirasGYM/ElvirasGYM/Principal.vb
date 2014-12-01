Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Principal
    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    Public pestania As Integer

    Dim datos As MySqlDataReader

    Dim conectar As New BDMysql(server, BD, user, pass)
    Dim Sql As String

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        lblFecha.Text = Date.Now.ToShortDateString
        Timer1.Start()
        lblFecha1.BackColor = Color.Transparent
        lblEmpleado1.BackColor = Color.Transparent
        conectar.open()
        Thread.Sleep(300)
        Sql = "SELECT * FROM usuarios WHERE activo = 1"
        datos = conectar.executeReader(Sql)
        If datos.Read = True Then
            lblEmpleado.Text = datos("nombre").ToString & " " & datos("apellidos").ToString
        End If
        datos.Close()
        conectar.reader = Nothing
        conectar.cmd = Nothing
        conectar.cnn.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblHora.Text = Date.Now.ToShortTimeString
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        conectar.open()
        Sql = "UPDATE usuarios SET activo = 0"
        If conectar.executeSQL(Sql) Then
            Login.Close()
            Close()
        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        conectar.open()
        Sql = "UPDATE usuarios SET Activo = 0"
        If conectar.executeSQL(Sql) Then
            Login.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnNuevocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevocliente.Click
        Clientes.Show()
        pestania = 0
        Clientes.tabcliente.SelectTab(0)
    End Sub

    Private Sub IngresarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarClienteToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub btnPagocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagocliente.Click
        Clientes.Show()
        pestania = 1
        Clientes.tabcliente.SelectTab(1)
    End Sub

    Private Sub AsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsistenciaToolStripMenuItem.Click
        Asistencia.Show()
    End Sub

    
End Class