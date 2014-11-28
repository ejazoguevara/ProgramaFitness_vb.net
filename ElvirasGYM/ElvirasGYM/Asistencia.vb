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

    Sub verifica_asistencia()
        Dim ruta As Image
        Dim foto As Bitmap
        Dim fecha As String = CDate(Date.Now.ToShortDateString).ToString("yyyy-MM-dd")
        'SQLString = String.Format("Select DNI from clientes")
        SQLString = String.Format("SELECT asistencias.clientes_id, clientes.DNI, clientes.nombre, clientes.apellido_paterno, clientes.apellido_materno, clientes.foto FROM asistencias left join clientes on asistencias.clientes_id = clientes.id WHERE asistencias.fecha = '" & Trim(fecha) & "'")
        'MsgBox(SQLString)
        DTclientes.Rows.Clear()
        reader = BDobj.executeReader(SQLString)
        While reader.Read = True
            txtDNI.Text = reader("DNI")
            If reader("foto") = "pendiente" Then
                foto = Nothing
            Else
                ruta = Image.FromFile("..\Fotoclientes\foto" & txtDNI.Text & ".jpg")
                foto = New Bitmap(ruta, 32, 40)
            End If

            DTclientes.Rows.Add(reader("clientes_id"), reader("DNI"), foto, reader("nombre"), reader("apellido_paterno"), reader("apellido_materno"), CDate(fecha).ToString("dd/MM/yyyy"))
        End While
        reader.Close()
        txtDNI.Text = ""
        txtDNI.Focus()
    End Sub


    Private Sub Asistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BDobj.open()
        DTclientes.Columns(0).Width = 40
        DTclientes.Columns(1).Width = 60
        DTclientes.Columns(2).Width = 70
        DTclientes.Columns(3).Width = 130
        DTclientes.Columns(4).Width = 160
        DTclientes.Columns(5).Width = 160
        DTclientes.Columns(6).Width = 100
        verifica_asistencia()
    End Sub

    Private Sub txtDNI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNI.GotFocus
        txtDNI.BackColor = Color.Honeydew
        txtDNI.ForeColor = Color.Black
    End Sub

    Private Sub txtDNI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNI.LostFocus
        txtDNI.BackColor = Color.White
        txtDNI.ForeColor = Color.Black
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
        Dim dnicliente As Integer
        Dim flag As Boolean
        Dim ruta As Image
        Dim foto As Bitmap
        If txtDNI.Text = "" Then
            MsgBox("Capture el DNI del cliente")
            txtDNI.Focus()
            Exit Sub
        End If
        For i = 0 To DTclientes.RowCount() - 1
            dnicliente = DTclientes.Item(1, i).Value
            If dnicliente = txtDNI.Text Then
                flag = True
            End If
        Next
        If flag = True Then
            MsgBox("Al cliente ya se le tomo asistencia")
            txtDNI.Text = ""
            txtDNI.Focus()
            Exit Sub
        End If
        Dim fecha As String = Date.Now.ToShortDateString
        SQLString = String.Format("SELECT id, DNI, nombre, apellido_paterno, apellido_materno, foto FROM clientes WHERE DNI = " & Trim(txtDNI.Text))
        reader = BDobj.executeReader(SQLString)
        If reader.Read = True Then
            If reader("foto") = "pendiente" Then
                foto = Nothing
            Else
                ruta = Image.FromFile("..\Fotoclientes\foto" & txtDNI.Text & ".jpg")
                foto = New Bitmap(ruta, 32, 40)
            End If
            DTclientes.Rows.Add(reader("id"), reader("DNI"), foto, reader("nombre"), reader("apellido_paterno"), reader("apellido_materno"), fecha)
        Else
            MsgBox("No se encontro un registro")
            txtDNI.Focus()
        End If
        reader.Close()
        txtDNI.Text = ""
        txtDNI.Focus()
    End Sub

    
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim bandera As Boolean
        Dim existe As Boolean = False
        Dim fecha, fechaNow As String
        For i = 0 To DTclientes.RowCount() - 1
            existe = False
            fechaNow = CDate(Date.Now.ToShortDateString)
            SQLString = String.Format("SELECT clientes_id, fecha FROM asistencias WHERE fecha = '" & CDate(Date.Now.ToShortDateString).ToString("yyyy-MM-dd") & "'")
            'MsgBox(SQLString)
            reader = BDobj.executeReader(SQLString)
            While reader.Read
                If reader("clientes_id") = DTclientes.Item(0, i).Value Then
                    existe = True
                    Exit While
                End If
            End While
            reader.Close()
            If existe = False Then
                fecha = CDate(DTclientes.Item(6, i).Value).ToString("yyyy-MM-dd")
                SQLString = String.Format("INSERT INTO asistencias (clientes_id, fecha) VALUES ({0},'{1}')", Trim(DTclientes.Item(0, i).Value), Trim(fecha))
                'MsgBox(SQLString)
                If BDobj.executeSQL(SQLString) Then
                    bandera = True
                Else
                    bandera = False
                End If
            End If
        Next
        txtDNI.Text = ""
        txtDNI.Focus()
        If bandera = True Then
            MsgBox("Se guardo con éxito...")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim op As Integer
        op = MessageBox.Show("Desea guardar la asistencia antes de salir....", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = 6 Then
            btnGuardar.PerformClick()
        ElseIf op = 7 Then
            Me.Dispose()
        End If
    End Sub

    Private Sub DTclientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTclientes.KeyDown
        Dim fila, id As Integer
        fila = DTclientes.CurrentRow.Index
        If e.KeyCode = Keys.Delete Then
            id = DTclientes.Item(0, fila).Value
            SQLString = String.Format("DELETE FROM asistencias WHERE clientes_id = " & id)
            BDobj.executeSQL(SQLString)
            verifica_asistencia()
        ElseIf e.KeyCode = Keys.F1 Then
            ListaClientes.Show()
        End If
    End Sub
End Class