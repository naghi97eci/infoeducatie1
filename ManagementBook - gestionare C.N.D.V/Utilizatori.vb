Imports System.Data.SqlClient
Imports System.Data
Public Class Utilizatori
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()

    End Sub

    Private Sub Utilizatori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Utilizator.Utilizatori' table. You can move, or remove it, as needed.
        Me.UtilizatoriTableAdapter.Fill(Me.Utilizator.Utilizatori)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()
        label4.text = Me.DataGridView1.Rows.Count
        


    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Utilizator, Parola FROM Utilizatori ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.DataGridView1.DataSource = dt
        con.Close()
        Label4.Text = Me.DataGridView1.Rows.Count

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If TextBox1.Text.Length < 1 Then
            MsgBox("Introduceti numele utilizatorului", MsgBoxStyle.Information)
        Else '
            If TextBox2.Text.Length < 1 Then
                MsgBox("Adaugati o parola utilizatorului", MsgBoxStyle.Information)
            Else
                If TextBox2.Text = TextBox3.Text Then
                    If Not con.State = ConnectionState.Open Then
                        con.Open()
                    End If
                    Dim adapt As New SqlDataAdapter("INSERT INTO Utilizatori(ID, Utilizator, Parola) VALUES ('" & Label4.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "')", con)
                    Dim dt As New DataTable
                    adapt.Fill(dt)
                    Me.resetare()
                    MsgBox("Utilizator nou introdus cu succes", MsgBoxStyle.Information)
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""

                Else
                    MsgBox("Parola introdusa nu corespunde", MsgBoxStyle.Information)
                End If
            End If
        End If
       
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Me.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                com.Connection = con
                com.CommandText = "DELETE FROM Utilizatori WHERE ID=" & intID
                com.ExecuteNonQuery()
                Me.resetare()


            End If
        End If
    End Sub
End Class