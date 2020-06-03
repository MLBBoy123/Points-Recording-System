Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.username = TextBox1.Text
        My.Settings.password = TextBox2.Text
        My.Settings.registered = True
        MsgBox("Please Login!")
        Me.Close()
        Form1.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Closing Exams",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
End Class