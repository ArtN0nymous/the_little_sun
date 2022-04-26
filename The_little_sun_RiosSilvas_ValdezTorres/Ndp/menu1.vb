Public Class menu1

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Computer.Audio.Play(My.Resources.sound5, AudioPlayMode.WaitToComplete)
        NdP_1.Show()
        Me.Hide()
    End Sub

    Private Sub menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.sound5, AudioPlayMode.WaitToComplete)
        IdP_1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        lbl_proximamente.Visible = True
    End Sub

    Private Sub lbl_proximamente_Click(sender As Object, e As EventArgs) Handles lbl_proximamente.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class