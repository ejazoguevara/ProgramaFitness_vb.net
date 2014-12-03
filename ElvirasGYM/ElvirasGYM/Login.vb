Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Login

    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    Dim BDobjeto As New BDMysql(server, BD, user, pass)

    Private Sub txtUser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.GotFocus
        txtUser.BackColor = Color.Aqua
        txtUser.ForeColor = Color.Black
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        Validar.letrasAndDecimal(e.KeyChar)
    End Sub

    Private Sub txtUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.LostFocus
        txtUser.BackColor = Color.Lime
        txtUser.ForeColor = Color.Black
    End Sub

    Private Sub txtPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.GotFocus
        txtPass.BackColor = Color.Aqua
        txtPass.ForeColor = Color.Black
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEntrar.PerformClick()
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        Validar.letrasAndDecimal(e.KeyChar)
    End Sub

    Private Sub txtPass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.LostFocus
        txtPass.BackColor = Color.Lime
        txtPass.ForeColor = Color.Black
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim datos As MySqlDataReader
        Dim SQLString As String
        Dim id As Integer
        Dim usuario, password As String
        If txtUser.Text = "" Then
            MessageBox.Show("Ponga un nombre de usuario", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUser.Focus()
        ElseIf txtPass.Text = "" Then
            MessageBox.Show("Ponga un contraseña", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPass.Focus()
        Else
            BDobjeto.open()
            usuario = txtUser.Text
            password = txtPass.Text
            SQLString = "SELECT * FROM usuarios WHERE usuario = '" & usuario & "'" & " AND contrasenia = '" & password & "'"
            If BDobjeto.existe(SQLString) Then
                datos = BDobjeto.executeReader(SQLString)
                If datos.Read = True Then
                    id = datos("id")
                    SQLString = "UPDATE usuarios SET activo = 1 WHERE id = " & id
                    datos.Close()
                    If BDobjeto.executeSQL(SQLString) Then
                        Principal.Show()
                        BDobjeto.cnn.Close()
                    End If
                    Me.Hide()      
                End If
            Else
                MsgBox("Usuario y/o Contraseña no encontrado")
                txtUser.Text = ""
                txtPass.Text = ""
                txtUser.Focus()
            End If
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobjeto.open()
    End Sub
End Class
