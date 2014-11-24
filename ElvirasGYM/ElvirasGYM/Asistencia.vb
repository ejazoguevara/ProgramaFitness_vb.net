Imports MySql.Data.MySqlClient
Public Class Asistencia
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
        BDobj.da = New MySqlDataAdapter("SELECT DNI, nombre, apellido_paterno, apellido_materno FROM clientes WHERE DNI = " & Trim(txtDNI.Text), BDobj.cnn)
        'BDobj.dt = New DataTable
        'BDobj.dt.Clear()
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


    Private Sub Asistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFecha.Text = Date.Now.ToShortDateString
        BDobj.open()
    End Sub

    Private Sub txtDNI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDNI.KeyDown
        If e.KeyCode = Keys.F1 Then
            ListaClientes.Show()
        End If
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        Validar.numDecimal(e.KeyChar)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        LlenarBindingSource()
        txtDNI.Text = ""
        txtDNI.Focus()
    End Sub
End Class