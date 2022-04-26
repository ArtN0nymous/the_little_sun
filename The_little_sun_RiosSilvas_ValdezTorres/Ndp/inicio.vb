Public Class Inicio


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.sonido1, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(My.Resources.sound5, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Stop()
        menu1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class
