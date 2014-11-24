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


    Private Sub Asistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFecha.Text = Date.Now.ToShortDateString
        BDobj.open()
        DTclientes.Columns(0).Width = 40
        DTclientes.Columns(1).Width = 60
        DTclientes.Columns(2).Width = 100
        DTclientes.Columns(3).Width = 140
        DTclientes.Columns(4).Width = 140
        DTclientes.Columns(5).Width = 100
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
        Dim ruta As Image
        Dim foto As Bitmap
        If txtDNI.Text = "" Then
            MsgBox("Capture el DNI del cliente")
            txtDNI.Focus()
            Exit Sub
        End If
        Dim fecha As String = CDate(lblFecha.Text).ToString("yyyy-MM-dd")
        SQLString = String.Format("SELECT DNI, nombre, apellido_paterno, apellido_materno, foto FROM clientes WHERE DNI = " & Trim(txtDNI.Text))
        reader = BDobj.executeReader(SQLString)
        If reader.Read = True Then
            If reader("foto") = "pendiente" Then
                foto = Nothing
            Else
                ruta = Image.FromFile("..\Fotoclientes\foto" & txtDNI.Text & ".jpg")
                foto = New Bitmap(ruta, 32, 32)
            End If
            DTclientes.Rows.Add(reader("DNI"), foto, reader("nombre"), reader("apellido_paterno"), reader("apellido_materno"), fecha)
        Else
            MsgBox("No se encontro un registro")
            txtDNI.Focus()
        End If
        reader.Close()
        txtDNI.Text = ""
        txtDNI.Focus()
    End Sub
End Class