Imports System.Data.SqlClient
Imports System.Data
Public Class Adauga_Ora_Prof
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If TextBox1.Text.Length < 3 Then
            MsgBox("Campurile obligatorii nu au fost completate. Va rugam completati campurile si incercati din nou", MsgBoxStyle.Information)
        Else

            If TextBox37.Text.Length < 3 Then
                MsgBox("Campurile obligatorii nu au fost completate. Va rugam completati campurile si incercati din nou", MsgBoxStyle.Information)

            Else

                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                Dim adapt As New SqlDataAdapter("INSERT INTO Orarprof(ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri) VALUES ('" & Label38.Text & "','" & Label2.Text & "','" & TextBox1.Text & "','" & TextBox37.Text & "','" & TextBox2.Text & "','" & TextBox15.Text & "','" & TextBox22.Text & "','" & TextBox29.Text & "','" & TextBox36.Text & "')", con)

                Dim adapt2 As New SqlDataAdapter("INSERT INTO Orarprof(ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri) VALUES ('" & Label38.Text & "','" & Label3.Text & "','" & TextBox1.Text & "','" & TextBox37.Text & "','" & TextBox3.Text & "','" & TextBox14.Text & "','" & TextBox21.Text & "','" & TextBox28.Text & "','" & TextBox35.Text & "')", con)

                Dim adapt3 As New SqlDataAdapter("INSERT INTO Orarprof(ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri) VALUES ('" & Label38.Text & "','" & Label4.Text & "','" & TextBox1.Text & "','" & TextBox37.Text & "','" & TextBox4.Text & "','" & TextBox13.Text & "','" & TextBox20.Text & "','" & TextBox27.Text & "','" & TextBox34.Text & "')", con)
                Dim adapt4 As New SqlDataAdapter("INSERT INTO Orarprof(ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri) VALUES ('" & Label38.Text & "','" & Label5.Text & "','" & TextBox1.Text & "','" & TextBox37.Text & "','" & TextBox5.Text & "','" & TextBox12.Text & "','" & TextBox19.Text & "','" & TextBox26.Text & "','" & TextBox33.Text & "')", con)
                Dim adapt5 As New SqlDataAdapter("INSERT INTO Orarprof(ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri) VALUES ('" & Label38.Text & "','" & Label6.Text & "','" & TextBox1.Text & "','" & TextBox37.Text & "','" & TextBox6.Text & "','" & TextBox11.Text & "','" & TextBox18.Text & "','" & TextBox25.Text & "','" & TextBox32.Text & "')", con)
                Dim adapt6 As New SqlDataAdapter("INSERT INTO Orarprof(ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri) VALUES ('" & Label38.Text & "','" & Label7.Text & "','" & TextBox1.Text & "','" & TextBox37.Text & "','" & TextBox7.Text & "','" & TextBox10.Text & "','" & TextBox17.Text & "','" & TextBox24.Text & "','" & TextBox31.Text & "')", con)
                Dim adapt7 As New SqlDataAdapter("INSERT INTO Orarprof(ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri) VALUES ('" & Label38.Text & "','" & Label9.Text & "','" & TextBox1.Text & "','" & TextBox37.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox16.Text & "','" & TextBox23.Text & "','" & TextBox30.Text & "')", con)

                Dim dt As New DataTable
                adapt.Fill(dt)
                adapt2.Fill(dt)
                adapt3.Fill(dt)
                adapt4.Fill(dt)
                adapt5.Fill(dt)
                adapt6.Fill(dt)
                adapt7.Fill(dt)
                Me.resetare()

            End If
        End If

        
        
    End Sub

    Private Sub Adauga_Ora_Prof_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Profesori._Profesori' table. You can move, or remove it, as needed.
        Me.ProfesoriTableAdapter.Fill(Me.Profesori._Profesori)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()
        Label38.Text = Orar_Profesori.DataGridView1.Rows.Count
       
    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Ora, Profesor, Materie, Luni, Marti, Miercuri, Joi, Vineri FROM Orarprof ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Orar_Profesori.DataGridView1.DataSource = dt
        con.Close()

    End Sub

    Private Sub TextBox33_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox33.TextChanged

    End Sub

    Private Sub TextBox37_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox37.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class