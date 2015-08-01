Imports System.Data.SqlClient
Imports System.Data
Public Class Orar_studenti
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Orar_studenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Orarstudenti._Orarstudenti' table. You can move, or remove it, as needed.
        Me.OrarstudentiTableAdapter.Fill(Me.Orarstudenti._Orarstudenti)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Ora, Clasa, Diriginte, Luni, Marti, Miercuri, Joi, Vineri FROM Orarstudenti ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.DataGridView1.DataSource = dt
        con.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Me.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                com.Connection = con
                com.CommandText = "DELETE FROM Orarstudenti WHERE ID=" & intID
                com.ExecuteNonQuery()
                Me.resetare()


            End If
        End If
    End Sub

    Private Sub btninchide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninchide.Click
        Modificare_orar_prof.Show()

    End Sub
End Class