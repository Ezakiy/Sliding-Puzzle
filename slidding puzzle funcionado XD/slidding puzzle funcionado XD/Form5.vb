Public Class Form5
    Public contador As Integer
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Embaralhar()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Call espaçovazio(B1, B2)
        Call espaçovazio(B1, B4)
        Call verifsoluçao()

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Call espaçovazio(B2, B1)
        Call espaçovazio(B2, B3)
        Call espaçovazio(B2, B5)
        Call verifsoluçao()

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Call espaçovazio(B3, B2)
        Call espaçovazio(B3, B6)
        Call verifsoluçao()

    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Call espaçovazio(B4, B1)
        Call espaçovazio(B4, B3)
        Call espaçovazio(B4, B7)
        Call espaçovazio(B4, B5)

    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Call espaçovazio(B5, B2)
        Call espaçovazio(B5, B6)
        Call espaçovazio(B5, B8)
        Call espaçovazio(B5, B4)
        Call verifsoluçao()
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Call espaçovazio(B6, B5)
        Call espaçovazio(B6, B0)
        Call espaçovazio(B6, B3)
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Call espaçovazio(B7, B4)
        Call espaçovazio(B7, B8)
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Call espaçovazio(B8, B7)
        Call espaçovazio(B8, B5)
        Call espaçovazio(B8, B0)
        Call verifsoluçao()
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        Call espaçovazio(B0, B6)
        Call espaçovazio(B0, B8)
        Call espaçovazio(B0, B7)
        Call espaçovazio(B0, B5)
        Call espaçovazio(B0, B4)
        Call espaçovazio(B0, B3)
        Call espaçovazio(B0, B2)
        Call espaçovazio(B0, B1)
        Call verifsoluçao()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Call Embaralhar()
        Label1.Text = "Nº de clicks 0 "
    End Sub
End Class