Public Class NdP_1
    Public correcto As Integer
    Public pregunta As Integer
    Public intentos As Integer
    Public Sub preguntas()
        lbl_lifes.Text = ("Intentos: " + intentos.ToString)
        If correcto = 1 Then
            planeta_planet.Image = My.Resources.urano
            planeta1.Image = My.Resources.Buton_Mercurio
            planeta1.SizeMode = PictureBoxSizeMode.StretchImage
            planeta2.Image = My.Resources.button_neptuno
            planeta2.SizeMode = PictureBoxSizeMode.StretchImage
            planeta3.Image = My.Resources.button_urano
            planeta3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If correcto = 2 Then
            planeta_planet.Image = My.Resources.mercurio1
            planeta1.Image = My.Resources.button_marte
            planeta1.SizeMode = PictureBoxSizeMode.StretchImage
            planeta2.Image = My.Resources.Button_venus
            planeta2.SizeMode = PictureBoxSizeMode.StretchImage
            planeta3.Image = My.Resources.Buton_Mercurio
            planeta3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If correcto = 3 Then
            planeta_planet.Image = My.Resources.jupiter
            planeta1.Image = My.Resources.button_neptuno
            planeta1.SizeMode = PictureBoxSizeMode.StretchImage
            planeta2.Image = My.Resources.button_jupiter
            planeta2.SizeMode = PictureBoxSizeMode.StretchImage
            planeta3.Image = My.Resources.button_saturno
            planeta3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If correcto = 4 Then
            planeta_planet.Image = My.Resources.tierra
            planeta1.Image = My.Resources.button_tierra
            planeta1.SizeMode = PictureBoxSizeMode.StretchImage
            planeta2.Image = My.Resources.button_marte
            planeta2.SizeMode = PictureBoxSizeMode.StretchImage
            planeta3.Image = My.Resources.Buton_Mercurio
            planeta3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If correcto = 5 Then
            planeta_planet.Image = My.Resources.saturno
            planeta1.Image = My.Resources.button_saturno
            planeta1.SizeMode = PictureBoxSizeMode.StretchImage
            planeta2.Image = My.Resources.button_urano
            planeta2.SizeMode = PictureBoxSizeMode.StretchImage
            planeta3.Image = My.Resources.button_jupiter
            planeta3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If correcto = 6 Then
            planeta_planet.Image = My.Resources.venus1
            planeta1.Image = My.Resources.Buton_Mercurio
            planeta1.SizeMode = PictureBoxSizeMode.StretchImage
            planeta2.Image = My.Resources.Button_venus
            planeta2.SizeMode = PictureBoxSizeMode.StretchImage
            planeta3.Image = My.Resources.button_marte
            planeta3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If correcto = 7 Then
            planeta_planet.Image = My.Resources.marte
            planeta1.Image = My.Resources.button_jupiter
            planeta1.SizeMode = PictureBoxSizeMode.StretchImage
            planeta2.Image = My.Resources.button_tierra
            planeta2.SizeMode = PictureBoxSizeMode.StretchImage
            planeta3.Image = My.Resources.button_marte
            planeta3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If pregunta = 9 Then
            final1.Show()
        End If

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles planeta1.Click
        preguntas()
        Dim contador = 2
        If correcto = 5 And pregunta = 6 Then
            correcto = 6
            pregunta = 7
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto1.Show()
            Timer1.Start()
        ElseIf correcto = 4 And pregunta = 5 Then
            correcto = 5
            pregunta = 6
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto1.Show()
            Timer1.Start()
        ElseIf correcto = 0 And pregunta = 1 Then
            correcto = 1
            pregunta = 2
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto1.Show()
            Timer1.Start()
        Else
            incorrecto1.Show()
            contador = contador - 1
            My.Computer.Audio.Play(My.Resources.Sound2, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            Timer1.Start()
            If intentos < 1 Then
                Application.Restart()
            ElseIf contador = 1 Then
                intentos -= 1
                contador = 2
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles planeta3.Click
        preguntas()
        Dim contador = 2
        If correcto = 7 And pregunta = 8 Then
            correcto = 8
            pregunta = 9
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto3.Show()
            Timer1.Start()
        ElseIf correcto = 2 And pregunta = 3 Then
            correcto = 3
            pregunta = 4
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto3.Show()
            Timer1.Start()
        ElseIf correcto = 1 And pregunta = 2 Then
            correcto = 2
            pregunta = 3
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto3.Show()
            Timer1.Start()
        Else
            incorrecto3.Show()
            contador = contador - 1
            My.Computer.Audio.Play(My.Resources.Sound2, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            Timer1.Start()
            If intentos < 1 Then
                Application.Restart()
            ElseIf contador = 1 Then
                intentos -= 1
                contador = 2
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles planeta2.Click
        preguntas()
        Dim contador = 2
        If correcto = 6 And pregunta = 7 Then
            correcto = 7
            pregunta = 8
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto2.Show()
            Timer1.Start()
        ElseIf correcto = 3 And pregunta = 4 Then
            correcto = 4
            pregunta = 5
            My.Computer.Audio.Play(My.Resources.Sound4, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            correcto2.Show()
            Timer1.Start()
        Else
            incorrecto2.Show()
            contador = contador - 1
            My.Computer.Audio.Play(My.Resources.Sound2, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
            Timer1.Start()
            If intentos < 1 Then
                Application.Restart()
            ElseIf contador = 1 Then
                intentos -= 1
                contador = 2
            End If
        End If
    End Sub

    Private Sub NdP_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        correcto = 0
        pregunta = 1
        intentos = 2
        My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub incorrecto1_Click(sender As Object, e As EventArgs) Handles incorrecto2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        incorrecto3.Visible = False
        incorrecto2.Visible = False
        incorrecto1.Visible = False
        correcto1.Visible = False
        correcto2.Visible = False
        correcto3.Visible = False
        preguntas()
        lbl_correcto.Text = "correcto: " + correcto.ToString
        lbl_pregunta.Text = "pregunta: " + pregunta.ToString
        Timer1.Stop()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Application.Exit()
    End Sub

    Private Sub lbl_lifes_Click(sender As Object, e As EventArgs) Handles lbl_lifes.Click

    End Sub
End Class