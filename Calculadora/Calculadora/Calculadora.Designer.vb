<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kidsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mayoresMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.oficinaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNum9 = New System.Windows.Forms.Button()
        Me.btnNum8 = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnNum7 = New System.Windows.Forms.Button()
        Me.btnNum0 = New System.Windows.Forms.Button()
        Me.btnNum6 = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnNum3 = New System.Windows.Forms.Button()
        Me.btnOpSumar = New System.Windows.Forms.Button()
        Me.btnNum5 = New System.Windows.Forms.Button()
        Me.btnOpRestar = New System.Windows.Forms.Button()
        Me.btnNum4 = New System.Windows.Forms.Button()
        Me.btnOpMultiplicar = New System.Windows.Forms.Button()
        Me.btnOpPercent = New System.Windows.Forms.Button()
        Me.btnNum2 = New System.Windows.Forms.Button()
        Me.btnOpSigno = New System.Windows.Forms.Button()
        Me.btnOpDividir = New System.Windows.Forms.Button()
        Me.btnOpRaiz = New System.Windows.Forms.Button()
        Me.btnNum1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnOpDecimal = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnX2 = New System.Windows.Forms.Button()
        Me.btnX3 = New System.Windows.Forms.Button()
        Me.btnXtoY = New System.Windows.Forms.Button()
        Me.btnCerrarPar = New System.Windows.Forms.Button()
        Me.btnUnoEntre = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnAbrirPar = New System.Windows.Forms.Button()
        Me.btnBorrarUltimo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSigno = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.mnu.SuspendLayout()
        Me.panel.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(1044, 24)
        Me.mnu.TabIndex = 17
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kidsMenuItem, Me.mayoresMenuItem, Me.oficinaMenuItem})
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'kidsMenuItem
        '
        Me.kidsMenuItem.Enabled = False
        Me.kidsMenuItem.Name = "kidsMenuItem"
        Me.kidsMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.kidsMenuItem.Text = "Niños"
        '
        'mayoresMenuItem
        '
        Me.mayoresMenuItem.Name = "mayoresMenuItem"
        Me.mayoresMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.mayoresMenuItem.Text = "Mayores"
        '
        'oficinaMenuItem
        '
        Me.oficinaMenuItem.Name = "oficinaMenuItem"
        Me.oficinaMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.oficinaMenuItem.Text = "Oficina"
        '
        'btnNum9
        '
        Me.btnNum9.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum9.FlatAppearance.BorderSize = 2
        Me.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum9.Location = New System.Drawing.Point(162, 217)
        Me.btnNum9.Name = "btnNum9"
        Me.btnNum9.Size = New System.Drawing.Size(75, 75)
        Me.btnNum9.TabIndex = 9
        Me.btnNum9.Text = "9"
        Me.btnNum9.UseVisualStyleBackColor = False
        '
        'btnNum8
        '
        Me.btnNum8.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum8.FlatAppearance.BorderSize = 2
        Me.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum8.Location = New System.Drawing.Point(81, 217)
        Me.btnNum8.Name = "btnNum8"
        Me.btnNum8.Size = New System.Drawing.Size(75, 75)
        Me.btnNum8.TabIndex = 8
        Me.btnNum8.Text = "8"
        Me.btnNum8.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBorrar.FlatAppearance.BorderSize = 2
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(0, 298)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 75)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "BORRAR"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnNum7
        '
        Me.btnNum7.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum7.FlatAppearance.BorderSize = 2
        Me.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum7.Location = New System.Drawing.Point(0, 217)
        Me.btnNum7.Name = "btnNum7"
        Me.btnNum7.Size = New System.Drawing.Size(75, 75)
        Me.btnNum7.TabIndex = 7
        Me.btnNum7.Text = "7"
        Me.btnNum7.UseVisualStyleBackColor = False
        '
        'btnNum0
        '
        Me.btnNum0.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum0.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum0.FlatAppearance.BorderSize = 2
        Me.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum0.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum0.Location = New System.Drawing.Point(81, 298)
        Me.btnNum0.Name = "btnNum0"
        Me.btnNum0.Size = New System.Drawing.Size(75, 75)
        Me.btnNum0.TabIndex = 11
        Me.btnNum0.Text = "0"
        Me.btnNum0.UseVisualStyleBackColor = False
        '
        'btnNum6
        '
        Me.btnNum6.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum6.FlatAppearance.BorderSize = 2
        Me.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum6.Location = New System.Drawing.Point(162, 136)
        Me.btnNum6.Name = "btnNum6"
        Me.btnNum6.Size = New System.Drawing.Size(75, 75)
        Me.btnNum6.TabIndex = 5
        Me.btnNum6.Text = "6"
        Me.btnNum6.UseVisualStyleBackColor = False
        '
        'btnIgual
        '
        Me.btnIgual.BackColor = System.Drawing.Color.Snow
        Me.btnIgual.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnIgual.FlatAppearance.BorderSize = 2
        Me.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIgual.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(162, 298)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(75, 75)
        Me.btnIgual.TabIndex = 12
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = False
        '
        'btnNum3
        '
        Me.btnNum3.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum3.FlatAppearance.BorderSize = 2
        Me.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum3.Location = New System.Drawing.Point(162, 55)
        Me.btnNum3.Name = "btnNum3"
        Me.btnNum3.Size = New System.Drawing.Size(75, 75)
        Me.btnNum3.TabIndex = 4
        Me.btnNum3.Text = "3"
        Me.btnNum3.UseVisualStyleBackColor = False
        '
        'btnOpSumar
        '
        Me.btnOpSumar.BackColor = System.Drawing.Color.Lime
        Me.btnOpSumar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpSumar.FlatAppearance.BorderSize = 2
        Me.btnOpSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpSumar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpSumar.Location = New System.Drawing.Point(243, 55)
        Me.btnOpSumar.Name = "btnOpSumar"
        Me.btnOpSumar.Size = New System.Drawing.Size(75, 75)
        Me.btnOpSumar.TabIndex = 13
        Me.btnOpSumar.Text = "+"
        Me.btnOpSumar.UseVisualStyleBackColor = False
        '
        'btnNum5
        '
        Me.btnNum5.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum5.FlatAppearance.BorderSize = 2
        Me.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum5.Location = New System.Drawing.Point(81, 136)
        Me.btnNum5.Name = "btnNum5"
        Me.btnNum5.Size = New System.Drawing.Size(75, 75)
        Me.btnNum5.TabIndex = 3
        Me.btnNum5.Text = "5"
        Me.btnNum5.UseVisualStyleBackColor = False
        '
        'btnOpRestar
        '
        Me.btnOpRestar.BackColor = System.Drawing.Color.Red
        Me.btnOpRestar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpRestar.FlatAppearance.BorderSize = 2
        Me.btnOpRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpRestar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpRestar.Location = New System.Drawing.Point(243, 136)
        Me.btnOpRestar.Name = "btnOpRestar"
        Me.btnOpRestar.Size = New System.Drawing.Size(75, 75)
        Me.btnOpRestar.TabIndex = 14
        Me.btnOpRestar.Text = "-"
        Me.btnOpRestar.UseVisualStyleBackColor = False
        '
        'btnNum4
        '
        Me.btnNum4.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum4.FlatAppearance.BorderSize = 2
        Me.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum4.Location = New System.Drawing.Point(0, 136)
        Me.btnNum4.Name = "btnNum4"
        Me.btnNum4.Size = New System.Drawing.Size(75, 75)
        Me.btnNum4.TabIndex = 2
        Me.btnNum4.Text = "4"
        Me.btnNum4.UseVisualStyleBackColor = False
        '
        'btnOpMultiplicar
        '
        Me.btnOpMultiplicar.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnOpMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpMultiplicar.FlatAppearance.BorderSize = 2
        Me.btnOpMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpMultiplicar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpMultiplicar.Location = New System.Drawing.Point(243, 217)
        Me.btnOpMultiplicar.Name = "btnOpMultiplicar"
        Me.btnOpMultiplicar.Size = New System.Drawing.Size(75, 75)
        Me.btnOpMultiplicar.TabIndex = 15
        Me.btnOpMultiplicar.Text = "x"
        Me.btnOpMultiplicar.UseVisualStyleBackColor = False
        '
        'btnOpPercent
        '
        Me.btnOpPercent.BackColor = System.Drawing.Color.Brown
        Me.btnOpPercent.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpPercent.FlatAppearance.BorderSize = 2
        Me.btnOpPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpPercent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpPercent.Location = New System.Drawing.Point(324, 298)
        Me.btnOpPercent.Name = "btnOpPercent"
        Me.btnOpPercent.Size = New System.Drawing.Size(75, 75)
        Me.btnOpPercent.TabIndex = 20
        Me.btnOpPercent.Text = "%"
        Me.btnOpPercent.UseVisualStyleBackColor = False
        Me.btnOpPercent.Visible = False
        '
        'btnNum2
        '
        Me.btnNum2.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum2.FlatAppearance.BorderSize = 2
        Me.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum2.Location = New System.Drawing.Point(81, 55)
        Me.btnNum2.Name = "btnNum2"
        Me.btnNum2.Size = New System.Drawing.Size(75, 75)
        Me.btnNum2.TabIndex = 1
        Me.btnNum2.Text = "2"
        Me.btnNum2.UseVisualStyleBackColor = False
        '
        'btnOpSigno
        '
        Me.btnOpSigno.BackColor = System.Drawing.Color.Brown
        Me.btnOpSigno.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpSigno.FlatAppearance.BorderSize = 2
        Me.btnOpSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpSigno.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpSigno.Location = New System.Drawing.Point(324, 136)
        Me.btnOpSigno.Name = "btnOpSigno"
        Me.btnOpSigno.Size = New System.Drawing.Size(75, 75)
        Me.btnOpSigno.TabIndex = 21
        Me.btnOpSigno.Text = "+-"
        Me.btnOpSigno.UseVisualStyleBackColor = False
        Me.btnOpSigno.Visible = False
        '
        'btnOpDividir
        '
        Me.btnOpDividir.BackColor = System.Drawing.Color.Yellow
        Me.btnOpDividir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpDividir.FlatAppearance.BorderSize = 2
        Me.btnOpDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpDividir.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpDividir.Location = New System.Drawing.Point(243, 298)
        Me.btnOpDividir.Name = "btnOpDividir"
        Me.btnOpDividir.Size = New System.Drawing.Size(75, 75)
        Me.btnOpDividir.TabIndex = 16
        Me.btnOpDividir.Text = "÷"
        Me.btnOpDividir.UseVisualStyleBackColor = False
        '
        'btnOpRaiz
        '
        Me.btnOpRaiz.BackColor = System.Drawing.Color.Brown
        Me.btnOpRaiz.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpRaiz.FlatAppearance.BorderSize = 2
        Me.btnOpRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpRaiz.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpRaiz.Location = New System.Drawing.Point(324, 217)
        Me.btnOpRaiz.Name = "btnOpRaiz"
        Me.btnOpRaiz.Size = New System.Drawing.Size(75, 75)
        Me.btnOpRaiz.TabIndex = 22
        Me.btnOpRaiz.Text = "√"
        Me.btnOpRaiz.UseVisualStyleBackColor = False
        Me.btnOpRaiz.Visible = False
        '
        'btnNum1
        '
        Me.btnNum1.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum1.Location = New System.Drawing.Point(0, 55)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(75, 75)
        Me.btnNum1.TabIndex = 0
        Me.btnNum1.Text = "1"
        Me.btnNum1.UseVisualStyleBackColor = False
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(0, 0)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(318, 44)
        Me.txt1.TabIndex = 6
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOpDecimal
        '
        Me.btnOpDecimal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOpDecimal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpDecimal.FlatAppearance.BorderSize = 2
        Me.btnOpDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpDecimal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpDecimal.Location = New System.Drawing.Point(324, 55)
        Me.btnOpDecimal.Name = "btnOpDecimal"
        Me.btnOpDecimal.Size = New System.Drawing.Size(75, 75)
        Me.btnOpDecimal.TabIndex = 23
        Me.btnOpDecimal.Text = "."
        Me.btnOpDecimal.UseVisualStyleBackColor = False
        Me.btnOpDecimal.Visible = False
        '
        'panel
        '
        Me.panel.Controls.Add(Me.btnOpDecimal)
        Me.panel.Controls.Add(Me.txt1)
        Me.panel.Controls.Add(Me.btnNum1)
        Me.panel.Controls.Add(Me.btnOpRaiz)
        Me.panel.Controls.Add(Me.btnOpDividir)
        Me.panel.Controls.Add(Me.btnOpSigno)
        Me.panel.Controls.Add(Me.btnNum2)
        Me.panel.Controls.Add(Me.btnOpPercent)
        Me.panel.Controls.Add(Me.btnOpMultiplicar)
        Me.panel.Controls.Add(Me.btnNum4)
        Me.panel.Controls.Add(Me.btnOpRestar)
        Me.panel.Controls.Add(Me.btnNum5)
        Me.panel.Controls.Add(Me.btnOpSumar)
        Me.panel.Controls.Add(Me.btnNum3)
        Me.panel.Controls.Add(Me.btnIgual)
        Me.panel.Controls.Add(Me.btnNum6)
        Me.panel.Controls.Add(Me.btnNum0)
        Me.panel.Controls.Add(Me.btnNum7)
        Me.panel.Controls.Add(Me.btnBorrar)
        Me.panel.Controls.Add(Me.btnNum8)
        Me.panel.Controls.Add(Me.btnNum9)
        Me.panel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel.Location = New System.Drawing.Point(12, 27)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(498, 378)
        Me.panel.TabIndex = 18
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.btnX2)
        Me.panel2.Controls.Add(Me.btnX3)
        Me.panel2.Controls.Add(Me.btnXtoY)
        Me.panel2.Controls.Add(Me.btnCerrarPar)
        Me.panel2.Controls.Add(Me.btnUnoEntre)
        Me.panel2.Controls.Add(Me.btnFactorial)
        Me.panel2.Controls.Add(Me.btnAbrirPar)
        Me.panel2.Controls.Add(Me.btnBorrarUltimo)
        Me.panel2.Controls.Add(Me.btnClear)
        Me.panel2.Controls.Add(Me.btnSigno)
        Me.panel2.Controls.Add(Me.btnPercent)
        Me.panel2.Controls.Add(Me.btnRaiz)
        Me.panel2.Controls.Add(Me.btnMultiplicar)
        Me.panel2.Controls.Add(Me.btnDividir)
        Me.panel2.Controls.Add(Me.btnRestar)
        Me.panel2.Controls.Add(Me.btnSumar)
        Me.panel2.Controls.Add(Me.btnEqual)
        Me.panel2.Controls.Add(Me.btn0)
        Me.panel2.Controls.Add(Me.btnDecimal)
        Me.panel2.Controls.Add(Me.btn9)
        Me.panel2.Controls.Add(Me.btn8)
        Me.panel2.Controls.Add(Me.btn7)
        Me.panel2.Controls.Add(Me.btn6)
        Me.panel2.Controls.Add(Me.btn5)
        Me.panel2.Controls.Add(Me.btn4)
        Me.panel2.Controls.Add(Me.btn3)
        Me.panel2.Controls.Add(Me.btn2)
        Me.panel2.Controls.Add(Me.btn1)
        Me.panel2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel2.Location = New System.Drawing.Point(516, 27)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(498, 378)
        Me.panel2.TabIndex = 31
        Me.panel2.Visible = False
        '
        'btnX2
        '
        Me.btnX2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnX2.Location = New System.Drawing.Point(253, 0)
        Me.btnX2.Margin = New System.Windows.Forms.Padding(1)
        Me.btnX2.Name = "btnX2"
        Me.btnX2.Size = New System.Drawing.Size(40, 30)
        Me.btnX2.TabIndex = 58
        Me.btnX2.Text = "x^2"
        Me.btnX2.UseVisualStyleBackColor = False
        '
        'btnX3
        '
        Me.btnX3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnX3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnX3.Location = New System.Drawing.Point(253, 32)
        Me.btnX3.Margin = New System.Windows.Forms.Padding(1)
        Me.btnX3.Name = "btnX3"
        Me.btnX3.Size = New System.Drawing.Size(40, 30)
        Me.btnX3.TabIndex = 57
        Me.btnX3.Text = "x^3"
        Me.btnX3.UseVisualStyleBackColor = False
        '
        'btnXtoY
        '
        Me.btnXtoY.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnXtoY.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnXtoY.Location = New System.Drawing.Point(253, 64)
        Me.btnXtoY.Margin = New System.Windows.Forms.Padding(1)
        Me.btnXtoY.Name = "btnXtoY"
        Me.btnXtoY.Size = New System.Drawing.Size(40, 30)
        Me.btnXtoY.TabIndex = 56
        Me.btnXtoY.Text = "x^y"
        Me.btnXtoY.UseVisualStyleBackColor = False
        '
        'btnCerrarPar
        '
        Me.btnCerrarPar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCerrarPar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCerrarPar.Location = New System.Drawing.Point(253, 96)
        Me.btnCerrarPar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCerrarPar.Name = "btnCerrarPar"
        Me.btnCerrarPar.Size = New System.Drawing.Size(40, 30)
        Me.btnCerrarPar.TabIndex = 55
        Me.btnCerrarPar.Text = ")"
        Me.btnCerrarPar.UseVisualStyleBackColor = False
        '
        'btnUnoEntre
        '
        Me.btnUnoEntre.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnUnoEntre.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUnoEntre.Location = New System.Drawing.Point(211, 32)
        Me.btnUnoEntre.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUnoEntre.Name = "btnUnoEntre"
        Me.btnUnoEntre.Size = New System.Drawing.Size(40, 30)
        Me.btnUnoEntre.TabIndex = 54
        Me.btnUnoEntre.Text = "1/x"
        Me.btnUnoEntre.UseVisualStyleBackColor = False
        '
        'btnFactorial
        '
        Me.btnFactorial.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFactorial.Location = New System.Drawing.Point(211, 64)
        Me.btnFactorial.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(40, 30)
        Me.btnFactorial.TabIndex = 53
        Me.btnFactorial.Text = "n!"
        Me.btnFactorial.UseVisualStyleBackColor = False
        '
        'btnAbrirPar
        '
        Me.btnAbrirPar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAbrirPar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAbrirPar.Location = New System.Drawing.Point(211, 96)
        Me.btnAbrirPar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAbrirPar.Name = "btnAbrirPar"
        Me.btnAbrirPar.Size = New System.Drawing.Size(40, 30)
        Me.btnAbrirPar.TabIndex = 52
        Me.btnAbrirPar.Text = "("
        Me.btnAbrirPar.UseVisualStyleBackColor = False
        '
        'btnBorrarUltimo
        '
        Me.btnBorrarUltimo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBorrarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBorrarUltimo.Location = New System.Drawing.Point(211, 0)
        Me.btnBorrarUltimo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBorrarUltimo.Name = "btnBorrarUltimo"
        Me.btnBorrarUltimo.Size = New System.Drawing.Size(40, 30)
        Me.btnBorrarUltimo.TabIndex = 51
        Me.btnBorrarUltimo.Text = "<-"
        Me.btnBorrarUltimo.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Location = New System.Drawing.Point(169, 0)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(40, 30)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSigno
        '
        Me.btnSigno.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSigno.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSigno.Location = New System.Drawing.Point(169, 32)
        Me.btnSigno.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSigno.Name = "btnSigno"
        Me.btnSigno.Size = New System.Drawing.Size(40, 30)
        Me.btnSigno.TabIndex = 49
        Me.btnSigno.Text = "+ -"
        Me.btnSigno.UseVisualStyleBackColor = False
        '
        'btnPercent
        '
        Me.btnPercent.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPercent.Location = New System.Drawing.Point(169, 64)
        Me.btnPercent.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(40, 30)
        Me.btnPercent.TabIndex = 48
        Me.btnPercent.Text = "%"
        Me.btnPercent.UseVisualStyleBackColor = False
        '
        'btnRaiz
        '
        Me.btnRaiz.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRaiz.Location = New System.Drawing.Point(169, 96)
        Me.btnRaiz.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(40, 30)
        Me.btnRaiz.TabIndex = 47
        Me.btnRaiz.Text = "√"
        Me.btnRaiz.UseVisualStyleBackColor = False
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnMultiplicar.Location = New System.Drawing.Point(127, 64)
        Me.btnMultiplicar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(40, 30)
        Me.btnMultiplicar.TabIndex = 46
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = False
        '
        'btnDividir
        '
        Me.btnDividir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDividir.Location = New System.Drawing.Point(127, 96)
        Me.btnDividir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(40, 30)
        Me.btnDividir.TabIndex = 45
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = False
        '
        'btnRestar
        '
        Me.btnRestar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRestar.Location = New System.Drawing.Point(127, 32)
        Me.btnRestar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(40, 30)
        Me.btnRestar.TabIndex = 44
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = False
        '
        'btnSumar
        '
        Me.btnSumar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSumar.Location = New System.Drawing.Point(127, 0)
        Me.btnSumar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(40, 30)
        Me.btnSumar.TabIndex = 43
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEqual.Location = New System.Drawing.Point(85, 96)
        Me.btnEqual.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(40, 30)
        Me.btnEqual.TabIndex = 42
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn0.Location = New System.Drawing.Point(43, 96)
        Me.btn0.Margin = New System.Windows.Forms.Padding(1)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(40, 30)
        Me.btn0.TabIndex = 41
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnDecimal
        '
        Me.btnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDecimal.Location = New System.Drawing.Point(1, 96)
        Me.btnDecimal.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(40, 30)
        Me.btnDecimal.TabIndex = 40
        Me.btnDecimal.Text = ","
        Me.btnDecimal.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn9.Location = New System.Drawing.Point(85, 64)
        Me.btn9.Margin = New System.Windows.Forms.Padding(1)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(40, 30)
        Me.btn9.TabIndex = 39
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn8.Location = New System.Drawing.Point(43, 64)
        Me.btn8.Margin = New System.Windows.Forms.Padding(1)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(40, 30)
        Me.btn8.TabIndex = 38
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn7.Location = New System.Drawing.Point(1, 64)
        Me.btn7.Margin = New System.Windows.Forms.Padding(1)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(40, 30)
        Me.btn7.TabIndex = 37
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn6.Location = New System.Drawing.Point(85, 32)
        Me.btn6.Margin = New System.Windows.Forms.Padding(1)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(40, 30)
        Me.btn6.TabIndex = 36
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn5.Location = New System.Drawing.Point(43, 32)
        Me.btn5.Margin = New System.Windows.Forms.Padding(1)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(40, 30)
        Me.btn5.TabIndex = 35
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn4.Location = New System.Drawing.Point(1, 32)
        Me.btn4.Margin = New System.Windows.Forms.Padding(1)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(40, 30)
        Me.btn4.TabIndex = 34
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn3.Location = New System.Drawing.Point(85, 0)
        Me.btn3.Margin = New System.Windows.Forms.Padding(1)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 30)
        Me.btn3.TabIndex = 33
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn2.Location = New System.Drawing.Point(43, 0)
        Me.btn2.Margin = New System.Windows.Forms.Padding(1)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 30)
        Me.btn2.TabIndex = 32
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn1.Location = New System.Drawing.Point(1, 0)
        Me.btn1.Margin = New System.Windows.Forms.Padding(1)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 30)
        Me.btn1.TabIndex = 31
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 488)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.mnu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu
        Me.MaximizeBox = False
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kidsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mayoresMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents oficinaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNum9 As System.Windows.Forms.Button
    Friend WithEvents btnNum8 As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnNum7 As System.Windows.Forms.Button
    Friend WithEvents btnNum0 As System.Windows.Forms.Button
    Friend WithEvents btnNum6 As System.Windows.Forms.Button
    Friend WithEvents btnIgual As System.Windows.Forms.Button
    Friend WithEvents btnNum3 As System.Windows.Forms.Button
    Friend WithEvents btnOpSumar As System.Windows.Forms.Button
    Friend WithEvents btnNum5 As System.Windows.Forms.Button
    Friend WithEvents btnOpRestar As System.Windows.Forms.Button
    Friend WithEvents btnNum4 As System.Windows.Forms.Button
    Friend WithEvents btnOpMultiplicar As System.Windows.Forms.Button
    Friend WithEvents btnOpPercent As System.Windows.Forms.Button
    Friend WithEvents btnNum2 As System.Windows.Forms.Button
    Friend WithEvents btnOpSigno As System.Windows.Forms.Button
    Friend WithEvents btnOpDividir As System.Windows.Forms.Button
    Friend WithEvents btnOpRaiz As System.Windows.Forms.Button
    Friend WithEvents btnNum1 As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents btnOpDecimal As System.Windows.Forms.Button
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnX2 As System.Windows.Forms.Button
    Friend WithEvents btnX3 As System.Windows.Forms.Button
    Friend WithEvents btnXtoY As System.Windows.Forms.Button
    Friend WithEvents btnCerrarPar As System.Windows.Forms.Button
    Friend WithEvents btnUnoEntre As System.Windows.Forms.Button
    Friend WithEvents btnFactorial As System.Windows.Forms.Button
    Friend WithEvents btnAbrirPar As System.Windows.Forms.Button
    Friend WithEvents btnBorrarUltimo As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSigno As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnRaiz As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicar As System.Windows.Forms.Button
    Friend WithEvents btnDividir As System.Windows.Forms.Button
    Friend WithEvents btnRestar As System.Windows.Forms.Button
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button

End Class
