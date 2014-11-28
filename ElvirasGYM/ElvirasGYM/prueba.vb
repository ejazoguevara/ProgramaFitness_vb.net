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


    Private Const server As String = "localhost"
    Private Const BD As String = "elvirasgym"
    Private Const user As String = "root"
    Private Const pass As String = ""

    'Instancia para la clase 
    Dim BDobj As New BDMysql(server, BD, user, pass)

    'Llena el combobox de grupo desde la base de datos
    Private Sub llenar_Combo()
        BDobj.cmd = New MySqlCommand
        BDobj.da = New MySqlDataAdapter
        BDobj.dt = New DataTable
        BDobj.cmd.Connection = BDobj.cnn
        BDobj.cmd.CommandText = "SELECT id, CONCAT(nombre,' ',apellido_paterno,' ',apellido_materno) as Nombre FROM clientes order by id"
        BDobj.da.SelectCommand = BDobj.cmd
        BDobj.da.Fill(BDobj.dt)
        cbxCliente.DataSource = BDobj.dt
        BindingSource1.DataSource = BDobj.dt
        cbxCliente.ValueMember = "id"
        cbxCliente.DisplayMember = "Nombre"
        cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList
        BDobj.cmd = Nothing
        BDobj.da = Nothing
        BDobj.dt = Nothing
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
        Aplicar_Filtro()
    End Sub

    Dim capHwnd As Integer
    'Tamaño de la ventana del webcam
    Dim ancho As Integer = 120
    Dim alto As Integer = 150
    '"libreria.DLL" = El nombre del API que se desea importar
    ' EntryPoint = indica el nombre exacto de la función del API que queremos usar
#Region "Librerias DLL"
    'La función SendMessage llama al procedimiento de ventana para la ventana especificada y no vuelve hasta que el procedimiento de ventana se ha procesado el mensaje
    'LRESULT SendMessage(
    'HWND hWnd, // handle of destination window
    'UINT Msg, // message to send
    'WPARAM wParam, // first message parameter
    'LPARAM lParam // second message parameter
    ');
    <DllImport("user32.dll", EntryPoint:="SendMessage")> _
    Public Shared Function SendMessage(ByVal hWnd As Integer, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    'Crea una ventana de captura
    <DllImport("avicap32.dll", EntryPoint:="capCreateCaptureWindowA")> _
    Public Shared Function capCreateCaptureWindowA(ByVal Nombre As String, ByVal dwStyle As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hWnd As Integer, ByVal nID As Integer) As Integer
    End Function

#End Region

#Region "Constantes API - no se que significan todas :)"
    Const WM_USER As Integer = 1024
    Const WM_CAP_CONNECT As Integer = 1034
    Const WM_CAP_DISCONNECT As Integer = 1035
    Const WM_CAP_GET_FRAME As Integer = 1084
    Const WM_CAP_COPY As Integer = 1054
    Const WM_CAP_START As Integer = WM_USER
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_USER + 52
    Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP_START + 41
    Const WM_CAP_DLG_VIDEOSOURCE As Integer = WM_CAP_START + 42
    Const WM_CAP_DLG_VIDEODISPLAY As Integer = WM_CAP_START + 43
    Const WM_CAP_GET_VIDEOFORMAT As Integer = WM_CAP_START + 44
    Const WM_CAP_SET_VIDEOFORMAT As Integer = WM_CAP_START + 45
    Const WM_CAP_DLG_VIDEOCOMPRESSION As Integer = WM_CAP_START + 46
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP_START + 50
#End Region

    Dim webcam As New WebCam

    Private Property ruta As Image

    'Private Property imagen As Bitmap

    'Captura frame y deposita en el portapapeles
    Public Sub timer_tick(ByVal picture As PictureBox)
        SendMessage(capHwnd, WM_CAP_GET_FRAME, 0, 0)
        SendMessage(capHwnd, WM_CAP_COPY, 0, 0)
        picture.Image = Clipboard.GetImage()
        Application.DoEvents()
    End Sub

    Public Sub Iniciar(ByVal timer As Timer, ByVal padre As Form)
        Try
            'Configura la ventana de captura
            capHwnd = capCreateCaptureWindowA("WebCam", 0, 0, 0, ancho, alto, padre.Handle.ToInt32(), 0)

            Application.DoEvents()

            SendMessage(capHwnd, WM_CAP_CONNECT, 0, 0)
            SendMessage(capHwnd, WM_CAP_SET_PREVIEWRATE, 69, 0)
            SendMessage(capHwnd, WM_CAP_SET_PREVIEW, 0, 0)
            'se inicia el Timer
            timer.Start()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Public Sub Detener(ByVal timer As Timer)
        Try
            timer.Stop()
            Application.DoEvents()
            SendMessage(capHwnd, WM_CAP_DISCONNECT, 0, 0)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Iniciar(Timer1, Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timer_tick(PictureBox1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Detener(Timer1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sfile_JPG As String = "..\Fotoclientes\prueba1.jpg"
        Dim obj_bitMap As New Bitmap(100, 120)
        PictureBox1.DrawToBitmap(obj_bitMap, New Rectangle(0, 0, 100, 120))
        obj_bitMap.Save(sfile_JPG, Imaging.ImageFormat.Jpeg)
        MessageBox.Show("Imagen capturada en [" & sfile_JPG & " ]")
    End Sub
End Class