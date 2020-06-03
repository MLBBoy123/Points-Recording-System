Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label8.Click, Label7.Click, Label6.Click, Label10.Click, Label11.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox7.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub



    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click, Label16.Click, Label20.Click, Label19.Click, Label18.Click

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged, TextBox16.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PDBDataSet.TeamS' table. You can move, or remove it, as needed.
        Me.TeamSTableAdapter.Fill(Me.PDBDataSet.TeamS)
        'TODO: This line of code loads data into the 'PDBDataSet.Ind' table. You can move, or remove it, as needed.
        Me.IndTableAdapter.Fill(Me.PDBDataSet.Ind)

        'TODO: This line of code loads data into the 'PointSystemdbDataSet.Team' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PointSystemdbDataSet.Individual' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click, Label23.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Closing Exams",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TeamSBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Closing Exams",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IndBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IndBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.IndBindingSource.EndEdit()
        Me.IndTableAdapter.Update(Me.PDBDataSet)

Feedback:
        MsgBox("Check your records", vbInformation)
        Exit Sub
    End Sub




    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TeamSBindingSource.AddNew()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error GoTo Feedback
        Me.Validate()
        Me.TeamSBindingSource.EndEdit()
        Me.TeamSTableAdapter.Update(Me.PDBDataSet)

Feedback:
        MsgBox("Check your records", vbInformation)
        Exit Sub

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox17.Text = Val(TextBox10.Text) + Val(TextBox13.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Text = Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Closing Exams",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox18.Text = My.Settings.username And TextBox19.Text = My.Settings.password Then
            MsgBox("You have logged in!")
            GroupBox1.Visible = False
        Else
            MsgBox("Please Enter A Username/Password")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form3.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form4.Show()

    End Sub
End Class

