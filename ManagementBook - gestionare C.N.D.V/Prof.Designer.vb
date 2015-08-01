<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prof
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrenumeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaterieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiriginteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdresaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumarTelDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProfesoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Profesori = New ManagementBook___gestionare_C.N.D.V.Profesori
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrenumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataNasteriiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumarTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ProfesoriTableAdapter = New ManagementBook___gestionare_C.N.D.V.ProfesoriTableAdapters.ProfesoriTableAdapter
        Me.Button7 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Profesori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.NumeDataGridViewTextBoxColumn1, Me.PrenumeDataGridViewTextBoxColumn1, Me.MaterieDataGridViewTextBoxColumn, Me.DiriginteDataGridViewTextBoxColumn, Me.AdresaDataGridViewTextBoxColumn1, Me.NumarTelDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.ProfesoriBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(291, 115)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1059, 516)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.Width = 50
        '
        'NumeDataGridViewTextBoxColumn1
        '
        Me.NumeDataGridViewTextBoxColumn1.DataPropertyName = "Nume"
        Me.NumeDataGridViewTextBoxColumn1.HeaderText = "Nume"
        Me.NumeDataGridViewTextBoxColumn1.Name = "NumeDataGridViewTextBoxColumn1"
        Me.NumeDataGridViewTextBoxColumn1.Width = 150
        '
        'PrenumeDataGridViewTextBoxColumn1
        '
        Me.PrenumeDataGridViewTextBoxColumn1.DataPropertyName = "Prenume"
        Me.PrenumeDataGridViewTextBoxColumn1.HeaderText = "Prenume"
        Me.PrenumeDataGridViewTextBoxColumn1.Name = "PrenumeDataGridViewTextBoxColumn1"
        Me.PrenumeDataGridViewTextBoxColumn1.Width = 150
        '
        'MaterieDataGridViewTextBoxColumn
        '
        Me.MaterieDataGridViewTextBoxColumn.DataPropertyName = "Materie"
        Me.MaterieDataGridViewTextBoxColumn.HeaderText = "Materie"
        Me.MaterieDataGridViewTextBoxColumn.Name = "MaterieDataGridViewTextBoxColumn"
        Me.MaterieDataGridViewTextBoxColumn.Width = 150
        '
        'DiriginteDataGridViewTextBoxColumn
        '
        Me.DiriginteDataGridViewTextBoxColumn.DataPropertyName = "Diriginte"
        Me.DiriginteDataGridViewTextBoxColumn.HeaderText = "Diriginte"
        Me.DiriginteDataGridViewTextBoxColumn.Name = "DiriginteDataGridViewTextBoxColumn"
        Me.DiriginteDataGridViewTextBoxColumn.Width = 150
        '
        'AdresaDataGridViewTextBoxColumn1
        '
        Me.AdresaDataGridViewTextBoxColumn1.DataPropertyName = "Adresa"
        Me.AdresaDataGridViewTextBoxColumn1.HeaderText = "Adresa"
        Me.AdresaDataGridViewTextBoxColumn1.Name = "AdresaDataGridViewTextBoxColumn1"
        Me.AdresaDataGridViewTextBoxColumn1.Width = 210
        '
        'NumarTelDataGridViewTextBoxColumn1
        '
        Me.NumarTelDataGridViewTextBoxColumn1.DataPropertyName = "Numar tel :"
        Me.NumarTelDataGridViewTextBoxColumn1.HeaderText = "Numar tel :"
        Me.NumarTelDataGridViewTextBoxColumn1.Name = "NumarTelDataGridViewTextBoxColumn1"
        Me.NumarTelDataGridViewTextBoxColumn1.Width = 150
        '
        'ProfesoriBindingSource
        '
        Me.ProfesoriBindingSource.DataMember = "Profesori"
        Me.ProfesoriBindingSource.DataSource = Me.Profesori
        '
        'Profesori
        '
        Me.Profesori.DataSetName = "Profesori"
        Me.Profesori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'NumeDataGridViewTextBoxColumn
        '
        Me.NumeDataGridViewTextBoxColumn.DataPropertyName = "Nume"
        Me.NumeDataGridViewTextBoxColumn.HeaderText = "Nume"
        Me.NumeDataGridViewTextBoxColumn.Name = "NumeDataGridViewTextBoxColumn"
        Me.NumeDataGridViewTextBoxColumn.Width = 150
        '
        'PrenumeDataGridViewTextBoxColumn
        '
        Me.PrenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume"
        Me.PrenumeDataGridViewTextBoxColumn.HeaderText = "Prenume"
        Me.PrenumeDataGridViewTextBoxColumn.Name = "PrenumeDataGridViewTextBoxColumn"
        Me.PrenumeDataGridViewTextBoxColumn.Width = 150
        '
        'ClasaDataGridViewTextBoxColumn
        '
        Me.ClasaDataGridViewTextBoxColumn.DataPropertyName = "Clasa"
        Me.ClasaDataGridViewTextBoxColumn.HeaderText = "Clasa"
        Me.ClasaDataGridViewTextBoxColumn.Name = "ClasaDataGridViewTextBoxColumn"
        Me.ClasaDataGridViewTextBoxColumn.Width = 150
        '
        'DataNasteriiDataGridViewTextBoxColumn
        '
        Me.DataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "Data nasterii"
        Me.DataNasteriiDataGridViewTextBoxColumn.HeaderText = "Data nasterii"
        Me.DataNasteriiDataGridViewTextBoxColumn.Name = "DataNasteriiDataGridViewTextBoxColumn"
        Me.DataNasteriiDataGridViewTextBoxColumn.Width = 150
        '
        'AdresaDataGridViewTextBoxColumn
        '
        Me.AdresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa"
        Me.AdresaDataGridViewTextBoxColumn.HeaderText = "Adresa"
        Me.AdresaDataGridViewTextBoxColumn.Name = "AdresaDataGridViewTextBoxColumn"
        Me.AdresaDataGridViewTextBoxColumn.Width = 210
        '
        'NumarTelDataGridViewTextBoxColumn
        '
        Me.NumarTelDataGridViewTextBoxColumn.DataPropertyName = "Numar tel :"
        Me.NumarTelDataGridViewTextBoxColumn.HeaderText = "Numar tel :"
        Me.NumarTelDataGridViewTextBoxColumn.Name = "NumarTelDataGridViewTextBoxColumn"
        Me.NumarTelDataGridViewTextBoxColumn.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Profesori"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1323, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = " X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1299, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 24)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "__"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 135)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actualizeza date"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.xposed_gel
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(123, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 100)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Actualizare date"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.adaugastudent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(13, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 100)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Adaugare profesor nou"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 259)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 138)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.situatiescolara
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(123, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 100)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Orar profesor"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Untitled12_1
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(13, 25)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 100)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Stergere profesor"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(940, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Diriginte :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1015, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 26)
        Me.TextBox1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(676, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Materie :"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(746, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 26)
        Me.TextBox2.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(347, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Prenume :"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(429, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(185, 26)
        Me.TextBox3.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nume :"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(98, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 26)
        Me.TextBox4.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1221, 60)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cautare"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Forward_arrow_button_next_right_media_mail
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(1151, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 26)
        Me.Button8.TabIndex = 21
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Forward_arrow_button_next_right_media_mail
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(882, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 26)
        Me.Button9.TabIndex = 20
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Forward_arrow_button_next_right_media_mail
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(620, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 26)
        Me.Button10.TabIndex = 15
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Forward_arrow_button_next_right_media_mail
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(289, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(50, 26)
        Me.Button11.TabIndex = 14
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button11.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 0, 0, 2)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProfesoriTableAdapter
        '
        Me.ProfesoriTableAdapter.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.CausesValidation = False
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Untisdadtled_1
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(17, 581)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(135, 50)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "               Iesire"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Prof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 714)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Prof"
        Me.Text = "Prof"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Profesori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As ManagementBook___gestionare_C.N.D.V.DataSet1
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataNasteriiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumarTelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Profesori As ManagementBook___gestionare_C.N.D.V.Profesori
    Friend WithEvents ProfesoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoriTableAdapter As ManagementBook___gestionare_C.N.D.V.ProfesoriTableAdapters.ProfesoriTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenumeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiriginteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumarTelDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
