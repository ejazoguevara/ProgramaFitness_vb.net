Public Class Camara
    Dim webcam As New WebCam

    Private Property ruta As Image

    Private Property imagen As Bitmap

    Private Sub btnCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapturar.Click
        webcam.Detener(Timer1)
    End Sub

    Private Sub Camara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        webcam.Iniciar(Timer1, Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        webcam.timer_tick(PictureBox1)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        imagen = New Bitmap(120, 150)
        PictureBox1.DrawToBitmap(imagen, New Rectangle(0, 0, 120, 150))
        Clientes.imgFoto.Image = imagen
        Me.Dispose()
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        webcam.Iniciar(Timer1, Me)
    End Sub
End Class