Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class prueba
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim SQLString, SQLString2 As String
    Dim id As Integer
    Dim imagen As String
    Dim datos As New DataSet
    Dim entro As Boolean = False

    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    'Instancia para la clase 
    Dim BDobj As New BDMysql(server, BD, user, pass)

    'Llena el combobox de grupo desde la base de datos
    Private Sub llenar_Combo()
        cbxCliente.DataSource = Nothing
        BindingSource1.DataSource = Nothing
        BindingSource1.DataSource = ""
        BindingSource1.Clear()
        BDobj.cmd = New MySqlCommand
        BDobj.da = New MySqlDataAdapter
        BDobj.dt = New DataTable
        BDobj.cmd.Connection = BDobj.cnn
        BDobj.cmd.CommandText = "SELECT id, CONCAT(nombre,' ',apellido_paterno,' ',apellido_materno) as Nombre FROM clientes order by id"
        BDobj.da.SelectCommand = BDobj.cmd
        BDobj.da.Fill(BDobj.dt)
        BindingSource1.DataSource = BDobj.dt
        cbxCliente.DataSource = BindingSource1
        cbxCliente.ValueMember = "id"
        cbxCliente.DisplayMember = "Nombre"
        cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
        entro = True
    End Sub

    Private Sub Aplicar_Filtro()
        ' verificar que el DataSource no esté vacio  
        If cbxCliente.DataSource Is Nothing Then
            cbxCliente.BackColor = Color.Red
            Exit Sub
        End If

        Try
            If txtFiltra.Text = "" Then
                llenar_Combo()
                Exit Sub
            End If
            Dim filtro As String = String.Empty
            'Se filtra por nombre, apellido paterno y apellido materno
            filtro = "[Nombre] like '%" & txtFiltra.Text.Trim & "%'"
            BindingSource1.Filter = filtro
            cbxCliente.DataSource = BindingSource1
        Catch ex As Exception 'Errores
            'MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobj.open()
        llenar_Combo()
    End Sub

    Private Sub txtFiltra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltra.KeyPress
        If Asc(e.KeyChar) = 8 And txtFiltra.Text = "" Then
            llenar_Combo()
        Else
            Aplicar_Filtro()
        End If
    End Sub

    Private Sub cbxCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCliente.SelectedIndexChanged
        If entro = True Then
            txtnombre.Text = Trim(cbxCliente.SelectedValue)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class