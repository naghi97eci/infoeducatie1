Imports System.Data.SqlClient
Imports System.Data
Public Class SitScolara
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub SitScolara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Situatiescolara._Situatiescolara' table. You can move, or remove it, as needed.
        Me.SituatiescolaraTableAdapter.Fill(Me.Situatiescolara._Situatiescolara)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Adauga_situatie_scolara.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Me.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                com.Connection = con
                com.CommandText = "DELETE FROM Situatiescolara  WHERE ID=" & intID
                com.ExecuteNonQuery()
                Me.resetare()


            End If
        End If
    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Nume, Prenume, Clasa, Diriginte, m1, n1, m2, n2, m3, n3, m4, n4, m5, n5, m6, n6, m7, n7, m8, n8,m9,n9,m10,n10,m11,n11,m12,n12,m13,n13,m14,m15,n15,m16,n16,m17,n17,m18,n18,m19,n19,m20,n20,m21,n21,m22,n22,m23,n23,m24,n24,m25,n25, [Semestrul 1], [Semestrul 2], [Medie Anuala] FROM Situatiescolara ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Situatie_scolara.DataGridView1.DataSource = dt
        con.Close()
    End Sub

End Class