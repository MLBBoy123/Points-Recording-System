Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PDBDataSet.Ind' table. You can move, or remove it, as needed.
        Me.IndTableAdapter.Fill(Me.PDBDataSet.Ind)

    End Sub

    Private Sub SurnameToolStripTextBox_Click(sender As Object, e As EventArgs) Handles SurnameToolStripTextBox.Click

    End Sub
End Class