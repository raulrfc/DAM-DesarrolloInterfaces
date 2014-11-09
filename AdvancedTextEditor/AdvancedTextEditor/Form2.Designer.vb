<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFind.Location = New System.Drawing.Point(161, 24)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(91, 37)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Buscar"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReplace.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReplace.Location = New System.Drawing.Point(161, 67)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(91, 37)
        Me.btnReplace.TabIndex = 1
        Me.btnReplace.Text = "Reemplazar"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(12, 24)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(143, 27)
        Me.txt1.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(12, 67)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(143, 27)
        Me.txt2.TabIndex = 3
        '
        'Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(270, 124)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnFind)
        Me.Name = "Buscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
End Class
