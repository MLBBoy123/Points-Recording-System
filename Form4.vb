Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PDBDataSet.TeamS' table. You can move, or remove it, as needed.
        Me.TeamSTableAdapter.Fill(Me.PDBDataSet.TeamS)

    End Sub

    Private Sub School_NameToolStripButton_Click(sender As Object, e As EventArgs) Handles School_NameToolStripButton.Click
        Try
            Me.TeamSTableAdapter.School_Name(Me.PDBDataSet.TeamS, School_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub School_NameToolStripTextBox_Click(sender As Object, e As EventArgs) Handles School_NameToolStripTextBox.Click

    End Sub
End Class