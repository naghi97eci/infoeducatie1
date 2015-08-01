Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        











        Me.Button11.Location = New Point(Me.Width - 35, Me.MenuStrip1.Location.Y)
        Me.Button10.Location = New Point(Me.Width - 62, Me.MenuStrip1.Location.Y)
        Button9.Location = New Point(Panel1.Width - 110, Button1.Location.Y)
        Button8.Location = New Point(Panel1.Width - 205, Button1.Location.Y)
        Button7.Location = New Point(Panel1.Width - 300, Button1.Location.Y)
        Button6.Location = New Point(Panel1.Width - 395, Button1.Location.Y)





    End Sub

    Private Sub InchideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InchideToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btninchide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninchide.Click
        Me.Close()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Studenti.TopLevel = False
        Me.Panel2.Controls.Add(Studenti)
        Studenti.Size = Me.Panel2.Size

        Studenti.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Prof.TopLevel = False

        Me.Panel2.Controls.Add(Prof)
        Prof.BringToFront()
        Prof.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Adauga_situatie_scolara.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Orar_Profesori.Show()
        Orar_Profesori.BringToFront()


       
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Orar_studenti.Show()

        
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Adauga_Student.TopLevel = False

        Me.Panel2.Controls.Add(Adauga_Student)
        Adauga_Student.BringToFront()
        Adauga_Student.Show()


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Adauga_Profesor.TopLevel = False

        Me.Panel2.Controls.Add(Adauga_Profesor)
        Adauga_Profesor.BringToFront()
        Adauga_Profesor.Show()


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
     
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Autentificare.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       
        ToolStripStatusLabel4.Text = DateAndTime.TimeOfDay
        
        
        
        
        
        
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        Administrare_Profile.Show()

    End Sub

    Private Sub BackupBazaDeDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaseToolStripMenuItem.Click
        Administrare_clase.Show()

    End Sub

    Private Sub AdaugaStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaStudentToolStripMenuItem.Click
        Adauga_Student.Show()

    End Sub

    Private Sub AdaugaProfesorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaProfesorToolStripMenuItem.Click
        Adauga_Profesor.Show()

    End Sub

    Private Sub AdaugaOrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaOrarToolStripMenuItem1.Click
        Modificare_orar_prof.Show()

    End Sub

    Private Sub AdaugaOrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaOrarToolStripMenuItem.Click
        Adauga_Ora_Prof.Show()

    End Sub

    Private Sub AdaugaSituatieScolaraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaSituatieScolaraToolStripMenuItem.Click
        Adauga_situatie_scolara.Show()

    End Sub

    Private Sub UtilizatoriToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilizatoriToolStripMenuItem1.Click
        Utilizatori.Show()



    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class
