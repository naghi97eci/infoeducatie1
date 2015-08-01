Imports System.Data.SqlClient
Imports System.Data

Public Class Studenti
    Dim con As New SqlConnection
    Dim com As New SqlCommand

    Private Sub Studenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Studenti' table. You can move, or remove it, as needed.
        Me.StudentiTableAdapter.Fill(Me.DataSet1.Studenti)



        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()

    End Sub

    Private Sub Sterge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Nume, Prenume, Clasa, [Data nasterii], Adresa, [Numar tel :] FROM Studenti ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.DataGridView1.DataSource = dt
        con.Close()

    End Sub


    Private Sub btninchide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninchide.Click
        Adauga_Student.TopLevel = False

        Form1.Panel2.Controls.Add(Adauga_Student)
        Adauga_Student.BringToFront()
        Adauga_Student.Show()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Modifica_student.TopLevel = False

        Form1.Panel2.Controls.Add(Modifica_student)
        Modifica_student.BringToFront()
        Modifica_student.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Me.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                com.Connection = con
                com.CommandText = "DELETE FROM Studenti WHERE ID=" & intID
                com.ExecuteNonQuery()
                Me.resetare()


            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class