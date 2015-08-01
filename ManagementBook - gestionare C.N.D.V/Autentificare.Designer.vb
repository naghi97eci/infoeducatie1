<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autentificare
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.UtilizatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Utilizator = New ManagementBook___gestionare_C.N.D.V.Utilizator
        Me.UtilizatoriTableAdapter = New ManagementBook___gestionare_C.N.D.V.UtilizatorTableAdapters.UtilizatoriTableAdapter
        Me.Utilizator1 = New ManagementBook___gestionare_C.N.D.V.Utilizator
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Utilizator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Utilizator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(222, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 24)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(146, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UtilizatoriBindingSource
        Me.ComboBox1.DisplayMember = "Utilizator"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 26)
        Me.ComboBox1.TabIndex = 2
        '
        'UtilizatoriBindingSource
        '
        Me.UtilizatoriBindingSource.DataMember = "Utilizatori"
        Me.UtilizatoriBindingSource.DataSource = Me.Utilizator
        '
        'Utilizator
        '
        Me.Utilizator.DataSetName = "Utilizator"
        Me.Utilizator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilizatoriTableAdapter
        '
        Me.UtilizatoriTableAdapter.ClearBeforeFill = True
        '
        'Utilizator1
        '
        Me.Utilizator1.DataSetName = "Utilizator"
        Me.Utilizator1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(264, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Autentificare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Autentificare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autentificare"
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Utilizator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Utilizator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Utilizator As ManagementBook___gestionare_C.N.D.V.Utilizator
    Friend WithEvents UtilizatoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilizatoriTableAdapter As ManagementBook___gestionare_C.N.D.V.UtilizatorTableAdapters.UtilizatoriTableAdapter
    Friend WithEvents Utilizator1 As ManagementBook___gestionare_C.N.D.V.Utilizator
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
