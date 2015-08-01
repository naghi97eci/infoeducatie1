Public Class Situatie_scolara

    Private Sub Situatie_scolara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Situatiescolara._Situatiescolara' table. You can move, or remove it, as needed.
        Me.SituatiescolaraTableAdapter.Fill(Me.Situatiescolara._Situatiescolara)

    End Sub
End Class