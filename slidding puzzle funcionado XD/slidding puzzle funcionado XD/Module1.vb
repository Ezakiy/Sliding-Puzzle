Module Module1
    Sub espaçovazio(ByRef butt1 As Button, ByRef butt2 As Button)
        If butt2.Text = "" Then
            butt2.Text = butt1.Text
            butt1.Text = ""
        End If
    End Sub
    Sub verifsoluçao()
        If Form5.B1.Text = "1" And Form5.B2.Text = "2" And Form5.B3.Text = "3" And Form5.B4.Text = "4" And Form5.B5.Text = "5" And Form5.B6.Text = "6" And Form5.B7.Text = "7" And Form5.B8.Text = "8" Then

            MessageBox.Show("parabens você ganhou!", "embaralhar jogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Form5.contador = Form5.contador + 1
        Form5.Label1.Text = "Nº de clicks " & Form5.contador
    End Sub
    Sub Embaralhar()
        Dim a(8), i, j, rn As Integer
        Dim flag As Boolean
        flag = False
        i = 1
        a(j) = 1
        Do While i <= 8
            Randomize()
            rn = CInt(Int((8 * Rnd()) + 1))
            For j = 1 To i
                If (a(j) = rn) Then
                    flag = True
                    Exit For

                End If
            Next
            If flag = True Then
                flag = False
            Else
                a(i) = rn
                i = i + 1
            End If
        Loop
        Form5.B1.Text = a(1)
        Form5.B2.Text = a(2)
        Form5.B3.Text = a(3)
        Form5.B4.Text = a(4)
        Form5.B5.Text = a(5)
        Form5.B6.Text = a(6)
        Form5.B7.Text = a(7)
        Form5.B8.Text = a(8)
        Form5.B0.Text = ""
    End Sub
End Module
