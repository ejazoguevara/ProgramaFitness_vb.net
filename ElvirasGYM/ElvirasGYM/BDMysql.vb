Imports MySql.Data.MySqlClient

Public Class BDMysql
    Public cnn As MySqlConnection
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader

    Public dt As New DataTable
    Public da As New MySqlDataAdapter

    Private server As String = ""
    Private bD As String = ""
    Private user As String = ""
    Private pass As String = ""

    Sub New(ByVal server As String, ByVal BD As String, ByVal user As String, ByVal pass As String)
        Me.server = server
        Me.bD = BD
        Me.user = user
        Me.pass = pass
    End Sub

    'Se conecta a la base de datos
    Public Function open() As Boolean
        Dim _bandera As Boolean
        Try
            cnn = New MySqlConnection
            cnn.ConnectionString = "server=" & server & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass & ";"
            cnn.Open()
            'MsgBox("Conectado a BD")
            _bandera = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return _bandera
    End Function

    Public Function existe(ByVal sql As String) As Boolean
        Dim _bandera As Boolean
        cmd = New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = cnn
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            _bandera = True
        Else
            _bandera = False
        End If
        reader.Close()
        cmd = Nothing
        Return _bandera
    End Function


    Public Function executeSQL(ByVal sql As String) As Boolean
        Dim _bandera As Boolean
        Try
            cmd = New MySqlCommand
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            _bandera = True
            'MsgBox("Registro Modificado")
        Catch ex As Exception
            MsgBox(ex.Message)
            _bandera = False
        End Try
        cmd = Nothing
        Return _bandera
    End Function

    Public Function executeReader(ByVal sql As String) As MySqlDataReader
        Dim datos As MySqlDataReader
        cmd = New MySqlCommand
        cmd.CommandText = sql
        cmd.Connection = cnn
        datos = cmd.ExecuteReader
        cmd = Nothing
        Return datos
    End Function


End Class
