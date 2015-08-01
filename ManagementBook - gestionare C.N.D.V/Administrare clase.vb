Imports System.Data.SqlClient
Imports System.Data
Public Class Administrare_clase
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Administrare_clase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Clase2.Clase' table. You can move, or remove it, as needed.
        Me.ClaseTableAdapter1.Fill(Me.Clase2.Clase)
        'TODO: This line of code loads data into the 'Clase._Clase' table. You can move, or remove it, as needed.
        Me.ClaseTableAdapter.Fill(Me.Clase._Clase)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        Me.Label1.Text = Me.DataGridView1.Rows.Count
        ComboBox1.Text = "A"
        ComboBox2.Text = "V"


    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Clase FROM Clase ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.DataGridView1.DataSource = dt
        con.Close()
        Me.Label1.Text = Me.DataGridView1.Rows.Count
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("INSERT INTO Clase(ID,Clase) VALUES ('" & Label1.Text & "','" & ComboBox2.Text + "" + ComboBox1.Text & "')", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.resetare()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Me.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                com.Connection = con
                com.CommandText = "DELETE FROM Clase WHERE ID=" & intID
                com.ExecuteNonQuery()
                Me.resetare()


            End If
        End If
    End Sub
End Class