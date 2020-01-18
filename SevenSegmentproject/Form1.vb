Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Label8.Text + 1


        Select Case Label8.Text

            Case 1

                '0
                Label1.BackColor = Color.Red
                Label2.BackColor = Color.Red
                Label3.BackColor = Color.Red
                Label4.BackColor = Color.Red
                Label5.BackColor = Color.Red
                Label6.BackColor = Color.Red

                Label7.BackColor = Color.Black

            Case 2

                '1
                Label2.BackColor = Color.Red
                Label3.BackColor = Color.Red

                Label1.BackColor = Color.Black
                Label4.BackColor = Color.Black
                Label5.BackColor = Color.Black
                Label6.BackColor = Color.Black
                Label7.BackColor = Color.Black

            Case 3
                '2
                Label1.BackColor = Color.Red
                Label2.BackColor = Color.Red
                Label7.BackColor = Color.Red
                Label5.BackColor = Color.Red
                Label4.BackColor = Color.Red

                Label3.BackColor = Color.Black
                Label6.BackColor = Color.Black


            Case 4
                '3
                Label1.BackColor = Color.Red
                Label2.BackColor = Color.Red
                Label7.BackColor = Color.Red
                Label3.BackColor = Color.Red
                Label4.BackColor = Color.Red

                Label5.BackColor = Color.Black
                Label6.BackColor = Color.Black


            Case 5
                '4
                Label2.BackColor = Color.Red
                Label3.BackColor = Color.Red
                Label6.BackColor = Color.Red
                Label7.BackColor = Color.Red

                Label1.BackColor = Color.Black
                Label4.BackColor = Color.Black
                Label5.BackColor = Color.Black


            Case 6
                '5
                Label1.BackColor = Color.Red
                Label3.BackColor = Color.Red
                Label4.BackColor = Color.Red
                Label6.BackColor = Color.Red
                Label7.BackColor = Color.Red

                Label2.BackColor = Color.Black
                Label5.BackColor = Color.Black


            Case 7
                '6
                Label1.BackColor = Color.Red
                Label3.BackColor = Color.Red
                Label4.BackColor = Color.Red
                Label5.BackColor = Color.Red
                Label6.BackColor = Color.Red
                Label7.BackColor = Color.Red

                Label2.BackColor = Color.Black


            Case 8
                '7
                Label1.BackColor = Color.Red
                Label2.BackColor = Color.Red
                Label3.BackColor = Color.Red

                Label4.BackColor = Color.Black
                Label5.BackColor = Color.Black
                Label6.BackColor = Color.Black
                Label7.BackColor = Color.Black

            Case 9
                '8
                Label1.BackColor = Color.Red
                Label2.BackColor = Color.Red
                Label3.BackColor = Color.Red
                Label4.BackColor = Color.Red
                Label5.BackColor = Color.Red
                Label6.BackColor = Color.Red
                Label7.BackColor = Color.Red

            Case 10
                '9
                Label1.BackColor = Color.Red
                Label2.BackColor = Color.Red
                Label3.BackColor = Color.Red
                Label4.BackColor = Color.Red
                Label6.BackColor = Color.Red
                Label7.BackColor = Color.Red

                Label5.BackColor = Color.Black

        End Select

        If (Label8.Text > 10) Then

            Label8.Text = -1
        End If
    End Sub
End Class
