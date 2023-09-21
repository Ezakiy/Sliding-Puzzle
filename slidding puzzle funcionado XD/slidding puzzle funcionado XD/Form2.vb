Public Class Form2
    Structure login
        Dim nome As String
        Dim username As String
        Dim password As String


    End Structure
    Public contas(99) As login
    Public index As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show("sua password deve conter no minimo 8 caracteres")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.TextLength < 8 Then
            MessageBox.Show("Sua senha é invalida")
        Else
            contas(index).nome = TextBox1.Text
            contas(index).username = TextBox2.Text
            contas(index).password = TextBox3.Text
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            index += 1
            MessageBox.Show("Sua conta foi criada")
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class