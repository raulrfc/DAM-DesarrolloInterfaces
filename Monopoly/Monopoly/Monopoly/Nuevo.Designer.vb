<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.clbNumPlayers = New System.Windows.Forms.CheckedListBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.clbDifficulty = New System.Windows.Forms.CheckedListBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.lblP3 = New System.Windows.Forms.Label()
        Me.lblP4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnColorP1 = New System.Windows.Forms.Button()
        Me.btnColorP2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnColorP4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnColorP3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clbNumPlayers
        '
        Me.clbNumPlayers.BackColor = System.Drawing.Color.White
        Me.clbNumPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbNumPlayers.CheckOnClick = True
        Me.clbNumPlayers.ColumnWidth = 40
        Me.clbNumPlayers.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbNumPlayers.ForeColor = System.Drawing.Color.Red
        Me.clbNumPlayers.FormattingEnabled = True
        Me.clbNumPlayers.Items.AddRange(New Object() {"2", "3", "4"})
        Me.clbNumPlayers.Location = New System.Drawing.Point(15, 87)
        Me.clbNumPlayers.MultiColumn = True
        Me.clbNumPlayers.Name = "clbNumPlayers"
        Me.clbNumPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clbNumPlayers.Size = New System.Drawing.Size(132, 16)
        Me.clbNumPlayers.TabIndex = 0
        Me.clbNumPlayers.ThreeDCheckBoxes = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(12, 68)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(121, 16)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Número de jugadores"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Red
        Me.lbl2.Location = New System.Drawing.Point(12, 119)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(59, 16)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Dificultad"
        '
        'clbDifficulty
        '
        Me.clbDifficulty.BackColor = System.Drawing.Color.White
        Me.clbDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbDifficulty.CheckOnClick = True
        Me.clbDifficulty.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbDifficulty.ForeColor = System.Drawing.Color.Red
        Me.clbDifficulty.FormattingEnabled = True
        Me.clbDifficulty.Items.AddRange(New Object() {"Fácil", "Media", "Difícil"})
        Me.clbDifficulty.Location = New System.Drawing.Point(15, 138)
        Me.clbDifficulty.MultiColumn = True
        Me.clbDifficulty.Name = "clbDifficulty"
        Me.clbDifficulty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clbDifficulty.Size = New System.Drawing.Size(121, 48)
        Me.clbDifficulty.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(322, 247)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Red
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 148
        Me.LineShape1.X2 = 148
        Me.LineShape1.Y1 = 72
        Me.LineShape1.Y2 = 243
        '
        'lblP1
        '
        Me.lblP1.AutoSize = True
        Me.lblP1.Enabled = False
        Me.lblP1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.ForeColor = System.Drawing.Color.Red
        Me.lblP1.Location = New System.Drawing.Point(166, 72)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(60, 15)
        Me.lblP1.TabIndex = 6
        Me.lblP1.Text = "Jugador 1"
        '
        'lblP2
        '
        Me.lblP2.AutoSize = True
        Me.lblP2.Enabled = False
        Me.lblP2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.ForeColor = System.Drawing.Color.Red
        Me.lblP2.Location = New System.Drawing.Point(166, 113)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(60, 15)
        Me.lblP2.TabIndex = 7
        Me.lblP2.Text = "Jugador 2"
        '
        'lblP3
        '
        Me.lblP3.AutoSize = True
        Me.lblP3.Enabled = False
        Me.lblP3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3.ForeColor = System.Drawing.Color.Red
        Me.lblP3.Location = New System.Drawing.Point(166, 154)
        Me.lblP3.Name = "lblP3"
        Me.lblP3.Size = New System.Drawing.Size(60, 15)
        Me.lblP3.TabIndex = 8
        Me.lblP3.Text = "Jugador 3"
        '
        'lblP4
        '
        Me.lblP4.AutoSize = True
        Me.lblP4.Enabled = False
        Me.lblP4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4.ForeColor = System.Drawing.Color.Red
        Me.lblP4.Location = New System.Drawing.Point(166, 195)
        Me.lblP4.Name = "lblP4"
        Me.lblP4.Size = New System.Drawing.Size(60, 15)
        Me.lblP4.TabIndex = 9
        Me.lblP4.Text = "Jugador 4"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(169, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "Jugador1"
        '
        'btnColorP1
        '
        Me.btnColorP1.BackColor = System.Drawing.Color.Red
        Me.btnColorP1.Enabled = False
        Me.btnColorP1.FlatAppearance.BorderSize = 2
        Me.btnColorP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColorP1.Location = New System.Drawing.Point(285, 90)
        Me.btnColorP1.Name = "btnColorP1"
        Me.btnColorP1.Size = New System.Drawing.Size(24, 20)
        Me.btnColorP1.TabIndex = 11
        Me.btnColorP1.UseVisualStyleBackColor = False
        '
        'btnColorP2
        '
        Me.btnColorP2.BackColor = System.Drawing.Color.LawnGreen
        Me.btnColorP2.Enabled = False
        Me.btnColorP2.FlatAppearance.BorderSize = 2
        Me.btnColorP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColorP2.Location = New System.Drawing.Point(285, 131)
        Me.btnColorP2.Name = "btnColorP2"
        Me.btnColorP2.Size = New System.Drawing.Size(24, 20)
        Me.btnColorP2.TabIndex = 13
        Me.btnColorP2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(169, 131)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 20)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "Jugador2"
        '
        'btnColorP4
        '
        Me.btnColorP4.BackColor = System.Drawing.Color.Blue
        Me.btnColorP4.Enabled = False
        Me.btnColorP4.FlatAppearance.BorderSize = 2
        Me.btnColorP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColorP4.Location = New System.Drawing.Point(285, 213)
        Me.btnColorP4.Name = "btnColorP4"
        Me.btnColorP4.Size = New System.Drawing.Size(24, 20)
        Me.btnColorP4.TabIndex = 15
        Me.btnColorP4.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(169, 213)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(110, 20)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "Jugador4"
        '
        'btnColorP3
        '
        Me.btnColorP3.BackColor = System.Drawing.Color.Yellow
        Me.btnColorP3.Enabled = False
        Me.btnColorP3.FlatAppearance.BorderSize = 2
        Me.btnColorP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColorP3.Location = New System.Drawing.Point(285, 172)
        Me.btnColorP3.Name = "btnColorP3"
        Me.btnColorP3.Size = New System.Drawing.Size(24, 20)
        Me.btnColorP3.TabIndex = 17
        Me.btnColorP3.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(169, 172)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(110, 20)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "Jugador3"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Red
        Me.btnOK.Enabled = False
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnOK.FlatAppearance.BorderSize = 2
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(15, 209)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(56, 23)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSalir.FlatAppearance.BorderSize = 2
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(77, 209)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 23)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Monopoly.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(322, 247)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnColorP3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnColorP4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.btnColorP2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnColorP1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblP4)
        Me.Controls.Add(Me.lblP3)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.clbDifficulty)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.clbNumPlayers)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clbNumPlayers As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents clbDifficulty As System.Windows.Forms.CheckedListBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblP1 As System.Windows.Forms.Label
    Friend WithEvents lblP2 As System.Windows.Forms.Label
    Friend WithEvents lblP3 As System.Windows.Forms.Label
    Friend WithEvents lblP4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnColorP1 As System.Windows.Forms.Button
    Friend WithEvents btnColorP2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnColorP4 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btnColorP3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
