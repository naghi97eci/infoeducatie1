Imports System.Data.SqlClient
Imports System.Data
Public Class Administrare_Profile
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Administrare_Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Profile._Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.Profile._Profile)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        Me.Label1.Text = Me.DataGridView1.Rows.Count

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, [Nume profil] FROM Profile ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.DataGridView1.DataSource = dt
        con.Close()
        Me.Label1.Text = Me.DataGridView1.Rows.Count
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MsgBox("Va rugam introduceti denumirea profilului.", MsgBoxStyle.Information)
        Else
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If
            Dim adapt As New SqlDataAdapter("INSERT INTO Profile(ID,[Nume profil]) VALUES ('" & Label1.Text & "','" & TextBox2.Text & "')", con)
            Dim dt As New DataTable
            adapt.Fill(dt)
            Me.resetare()
            TextBox2.Text = ""
        End If
        

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Me.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                com.Connection = con
                com.CommandText = "DELETE FROM Profile WHERE ID=" & intID
                com.ExecuteNonQuery()
                Me.resetare()


            End If
        End If
    End Sub
End Class