Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j, i, numero As Integer

        Try
                j = 1

            'formula para el calculo de n!= 1x2x3...xn
            numero = (TextBox1.Text)
            If numero > 0 Then
                For i = 1 To numero Step 1
                    j = j * i

                Next

                Lfactorial.Text = j
            Else
                MsgBox("Ingrese un número positivo")
            End If

        Catch ex As Exception
                MsgBox(ex.Message)
            End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Lfactorial.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
