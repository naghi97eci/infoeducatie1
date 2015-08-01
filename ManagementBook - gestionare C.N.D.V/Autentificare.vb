Public Class Autentificare

    Private Sub Autentificare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Utilizator.Utilizatori' table. You can move, or remove it, as needed.
        Me.UtilizatoriTableAdapter.Fill(Me.Utilizator.Utilizatori)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aut = Me.UtilizatoriTableAdapter.Login(TextBox1.Text, ComboBox1.Text)
        If aut Then
            MsgBox("error")

        End If
    End Sub
End Class