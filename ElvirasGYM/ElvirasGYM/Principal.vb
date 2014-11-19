Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Principal
    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""
    Dim datos As MySqlDataReader


    Dim conectar As New BDMysql(server, BD, user, pass)
    Dim Sql As String

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        lblFecha.Text = Date.Now.ToShortDateString
        lblFecha1.BackColor = Color.Transparent
        lblEmpleado1.BackColor = Color.Transparent
        conectar.open()
        Thread.Sleep(500)
        Sql = "SELECT * FROM usuarios WHERE activo = 1"
        datos = conectar.executeReader(Sql)
        If datos.Read = True Then
            lblEmpleado.Text = datos("nombre").ToString & " " & datos("apellidos").ToString
        End If
        datos.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Sql = "UPDATE usuarios SET activo = 0"
        If conectar.executeSQL(Sql) Then
            Login.Close()
            Close()
        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Sql = "UPDATE usuarios SET Activo = 0"
        If conectar.executeSQL(Sql) Then
            Login.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnNuevocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevocliente.Click
        Clientes.Show()
        Clientes.tabcliente.SelectTab(0)
    End Sub

    Private Sub IngresarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarClienteToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub btnPagocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagocliente.Click
        Clientes.Show()
        Clientes.tabcliente.SelectTab(1)
    End Sub
End Class