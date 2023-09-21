Public Class Form3
    Dim flag As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To UBound(Form2.contas)
            If TextBox1.Text = Form2.contas(i).username And TextBox2.Text = Form2.contas(i).password Then
                Form4.Show()
                Me.Hide()
                flag = True
            End If
        Next

        If flag = False Then
            MessageBox.Show("Os dados inseridos estão errados, por favor tente novamente.")
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class