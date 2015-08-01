Imports System.Data.SqlClient
Imports System.Data
Public Class Adauga_situatie_scolara
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        m1.Text = TextBox2.Text
        n1.Text = TextBox1.Text
        m1.Visible = True
        n1.Visible = True
        Button1.Visible = False
        Button2.Visible = True

    End Sub

    Private Sub Adauga_situatie_scolara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Visible = True
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()
        Label9.Text = SitScolara.DataGridView1.Rows.Count
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
        Label9.Text = SitScolara.DataGridView1.Rows.Count


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        m2.Text = TextBox2.Text
        n2.Text = TextBox1.Text
        m2.Visible = True
        n2.Visible = True
        Button2.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        m3.Text = TextBox2.Text
        n3.Text = TextBox1.Text
        m3.Visible = True
        n3.Visible = True
        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        m4.Text = TextBox2.Text
        n4.Text = TextBox1.Text
        m4.Visible = True
        n4.Visible = True
        Button4.Visible = False
        Button5.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        m5.Text = TextBox2.Text
        n5.Text = TextBox1.Text
        m5.Visible = True
        n5.Visible = True
        Button5.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        m6.Text = TextBox2.Text
        n6.Text = TextBox1.Text
        m6.Visible = True
        n6.Visible = True
        Button6.Visible = False
        Button7.Visible = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        m7.Text = TextBox2.Text
        n7.Text = TextBox1.Text
        m7.Visible = True
        n7.Visible = True
        Button7.Visible = False
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        m8.Text = TextBox2.Text
        n8.Text = TextBox1.Text
        m8.Visible = True
        n8.Visible = True
        Button8.Visible = False
        Button9.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        m9.Text = TextBox2.Text
        n9.Text = TextBox1.Text
        m9.Visible = True
        n9.Visible = True
        Button9.Visible = False
        Button10.Visible = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        m10.Text = TextBox2.Text
        n10.Text = TextBox1.Text
        m10.Visible = True
        n10.Visible = True
        Button10.Visible = False
        Button11.Visible = True
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        m11.Text = TextBox2.Text
        n11.Text = TextBox1.Text
        m11.Visible = True
        n11.Visible = True
        Button11.Visible = False
        Button12.Visible = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        m12.Text = TextBox2.Text
        n12.Text = TextBox1.Text
        m12.Visible = True
        n12.Visible = True
        Button12.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        m13.Text = TextBox2.Text
        n13.Text = TextBox1.Text
        m13.Visible = True
        n13.Visible = True
        Button13.Visible = False
        Button14.Visible = True
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        m14.Text = TextBox2.Text
        n14.Text = TextBox1.Text
        m14.Visible = True
        n14.Visible = True
        Button14.Visible = False
        Button15.Visible = True
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        m15.Text = TextBox2.Text
        n15.Text = TextBox1.Text
        m15.Visible = True
        n15.Visible = True
        Button15.Visible = False
        Button16.Visible = True
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        m16.Text = TextBox2.Text
        n16.Text = TextBox1.Text
        m16.Visible = True
        n16.Visible = True
        Button16.Visible = False
        Button17.Visible = True
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        m17.Text = TextBox2.Text
        n17.Text = TextBox1.Text
        m17.Visible = True
        n17.Visible = True
        Button17.Visible = False
        Button18.Visible = True
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        m18.Text = TextBox2.Text
        n18.Text = TextBox1.Text
        m18.Visible = True
        n18.Visible = True
        Button18.Visible = False
        Button19.Visible = True
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        m19.Text = TextBox2.Text
        n19.Text = TextBox1.Text
        m19.Visible = True
        n19.Visible = True
        Button19.Visible = False
        Button20.Visible = True
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        m20.Text = TextBox2.Text
        n20.Text = TextBox1.Text
        m20.Visible = True
        n20.Visible = True
        Button20.Visible = False
        Button21.Visible = True
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        m21.Text = TextBox2.Text
        n21.Text = TextBox1.Text
        m21.Visible = True
        n21.Visible = True
        Button21.Visible = False
        Button22.Visible = True
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        m22.Text = TextBox2.Text
        n22.Text = TextBox1.Text
        m22.Visible = True
        n22.Visible = True
        Button22.Visible = False
        Button23.Visible = True
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        m23.Text = TextBox2.Text
        n23.Text = TextBox1.Text
        m23.Visible = True
        n23.Visible = True
        Button23.Visible = False
        Button24.Visible = True
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        m24.Text = TextBox2.Text
        n24.Text = TextBox1.Text
        m24.Visible = True
        n24.Visible = True
        Button24.Visible = False
        Button25.Visible = True
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        m25.Text = TextBox2.Text
        n25.Text = TextBox1.Text
        m25.Visible = True
        n25.Visible = True
        Button25.Enabled = False

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("INSERT INTO Situatiescolara(ID, Nume, Prenume, Clasa, Diriginte, m1, n1, m2, n2, m3, n3, m4, n4, m5, n5, m6, n6, m7, n7, m8, n8, m9, n9, m10, n10, m11, n11, m12, n12, m13, n13, m14, n14, m15, n15, m16, n16, m17, n17, m18, n18, m19, n19, m20, n20, m21, n21, m22, n22, m23, n23, m24, n24, m25, n25, [Semestrul 1], [Semestrul 2], [Medie Anuala]) VALUES ('" & Label9.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & m1.Text & "','" & n1.Text & "','" & m2.Text & "','" & n2.Text & "','" & m3.Text & "','" & n3.Text & "','" & m4.Text & "','" & n4.Text & "','" & m5.Text & "','" & n5.Text & "','" & m6.Text & "','" & n6.Text & "','" & m7.Text & "','" & n7.Text & "','" & m8.Text & "','" & n8.Text & "','" & m9.Text & "','" & n9.Text & "','" & m10.Text & "','" & n10.Text & "','" & m11.Text & "','" & n11.Text & "','" & m12.Text & "','" & n12.Text & "','" & m13.Text & "','" & n13.Text & "','" & m14.Text & "','" & n14.Text & "','" & m15.Text & "','" & n15.Text & "','" & m16.Text & "','" & n16.Text & "','" & m17.Text & "','" & n17.Text & "','" & m18.Text & "','" & n18.Text & "','" & m19.Text & "','" & n19.Text & "','" & m20.Text & "','" & n20.Text & "','" & m21.Text & "','" & n21.Text & "','" & m22.Text & "','" & n22.Text & "','" & m23.Text & "','" & n23.Text & "','" & m24.Text & "','" & n24.Text & "','" & m25.Text & "','" & n25.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "')", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.resetare()

    End Sub
End Class