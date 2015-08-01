Imports System.Data.SqlClient
Imports System.Data
Public Class Adauga_Student
    Dim con As New SqlConnection
    Dim com As New SqlCommand

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Adauga_Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()


    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Nume, Prenume, Clasa, [Data nasterii], Adresa, [Numar tel :] FROM Studenti ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Studenti.DataGridView1.DataSource = dt
        con.Close()
        Label1.Text = Studenti.DataGridView1.Rows.Count

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text.Length < 3 Then
            MsgBox("Va rugam completati campul pentru 'Nume'", MsgBoxStyle.Information)
        Else
            If TextBox3.Text.Length < 3 Then
                MsgBox("Va rugam completati campul pentru 'Prenume'", MsgBoxStyle.Information)
            Else
                If TextBox4.Text.Length < 3 Then
                    MsgBox("Va rugam completati campul pentru 'Clasa'", MsgBoxStyle.Information)
                Else
                    If TextBox5.Text.Length < 3 Then
                        MsgBox("Va rugam completati campul pentru 'Data nasterii'", MsgBoxStyle.Information)
                    Else
                        If TextBox6.Text.Length < 3 Then
                            MsgBox("Varugam completati campul pentru 'Adresa'", MsgBoxStyle.Information)
                        Else
                            If TextBox7.Text.Length < 9 Then
                                MsgBox("Va rugam completati campul pentru 'Numar tel.'", MsgBoxStyle.Information)
                            Else
                                Me.resetare()
                                If Not con.State = ConnectionState.Open Then
                                    con.Open()
                                End If


                                Dim adapt As New SqlDataAdapter("INSERT INTO Studenti(ID,Nume, Prenume, CLasa, [Data nasterii], Adresa, [Numar tel :]) VALUES ('" & Label1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')", con)
                                Dim dt As New DataTable
                                adapt.Fill(dt)
                                Me.resetare()
                                MsgBox("Noul student a fost introdus cu succes", MsgBoxStyle.Information)
                                TextBox2.Text = ""
                                TextBox3.Text = ""
                                TextBox4.Text = ""
                                TextBox5.Text = ""
                                TextBox6.Text = ""
                                TextBox7.Text = ""
                            End If
                        End If
                    End If
                End If
            End If
        End If



    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox2.Text.Length < 3 Then
            MsgBox("Va rugam completati campul pentru 'Nume'", MsgBoxStyle.Information)
        Else
            If TextBox3.Text.Length < 3 Then
                MsgBox("Va rugam completati campul pentru 'Prenume'", MsgBoxStyle.Information)
            Else
                If TextBox4.Text.Length < 3 Then
                    MsgBox("Va rugam completati campul pentru 'Clasa'", MsgBoxStyle.Information)
                Else
                    If TextBox5.Text.Length < 3 Then
                        MsgBox("Va rugam completati campul pentru 'Data nasterii'", MsgBoxStyle.Information)
                    Else
                        If TextBox6.Text.Length < 3 Then
                            MsgBox("Varugam completati campul pentru 'Adresa'", MsgBoxStyle.Information)
                        Else
                            If TextBox7.Text.Length < 9 Then
                                MsgBox("Va rugam completati campul pentru 'Numar tel.'", MsgBoxStyle.Information)
                            Else
                                If Not con.State = ConnectionState.Open Then
                                    con.Open()
                                End If
                                Dim adapt As New SqlDataAdapter("INSERT INTO Studenti(ID,Nume, Prenume, CLasa, [Data nasterii], Adresa, [Numar tel :]) VALUES ('" & Label1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')", con)
                                Dim dt As New DataTable
                                adapt.Fill(dt)
                                Me.resetare()
                                MsgBox("Noul student a fost introdus cu succes", MsgBoxStyle.Information)
                                Me.Close()
                                Adauga_situatie_scolara.Show()
                                Adauga_situatie_scolara.TextBox4.Text = Me.TextBox2.Text
                                Adauga_situatie_scolara.TextBox3.Text = Me.TextBox3.Text
                                Adauga_situatie_scolara.TextBox6.Text = Me.TextBox4.Text
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class