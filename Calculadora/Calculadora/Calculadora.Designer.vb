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
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MóduloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrigonometríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConstantesMatemáticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversiónDivisasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversiónNuméricaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnSigno = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBorrarUltimo = New System.Windows.Forms.Button()
        Me.btnAbrirPar = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnUnoEntre = New System.Windows.Forms.Button()
        Me.btnCerrarPar = New System.Windows.Forms.Button()
        Me.btnXtoY = New System.Windows.Forms.Button()
        Me.btnX3 = New System.Windows.Forms.Button()
        Me.btnX2 = New System.Windows.Forms.Button()
        Me.btnConstE = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.cbTo = New System.Windows.Forms.ComboBox()
        Me.cbFrom = New System.Windows.Forms.ComboBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnSec = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnCot = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.gpb1 = New System.Windows.Forms.GroupBox()
        Me.rbtnHex = New System.Windows.Forms.RadioButton()
        Me.rbtnOctal = New System.Windows.Forms.RadioButton()
        Me.rbtnBinary = New System.Windows.Forms.RadioButton()
        Me.rbtnDecimal = New System.Windows.Forms.RadioButton()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnCsc = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.mnu.SuspendLayout()
        Me.panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gpb1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu
        '
        Me.mnu.BackColor = System.Drawing.Color.LightBlue
        Me.mnu.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.AgregarToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(336, 24)
        Me.mnu.TabIndex = 17
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kidsMenuItem, Me.mayoresMenuItem, Me.oficinaMenuItem})
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'kidsMenuItem
        '
        Me.kidsMenuItem.Enabled = False
        Me.kidsMenuItem.Name = "kidsMenuItem"
        Me.kidsMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.kidsMenuItem.Text = "Niños"
        '
        'mayoresMenuItem
        '
        Me.mayoresMenuItem.Name = "mayoresMenuItem"
        Me.mayoresMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.mayoresMenuItem.Text = "Mayores"
        '
        'oficinaMenuItem
        '
        Me.oficinaMenuItem.Name = "oficinaMenuItem"
        Me.oficinaMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.oficinaMenuItem.Text = "Oficina"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MóduloToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Enabled = False
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'MóduloToolStripMenuItem
        '
        Me.MóduloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrigonometríaToolStripMenuItem, Me.ConstantesMatemáticasToolStripMenuItem, Me.ConversiónDivisasToolStripMenuItem, Me.ConversiónNuméricaToolStripMenuItem})
        Me.MóduloToolStripMenuItem.Name = "MóduloToolStripMenuItem"
        Me.MóduloToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.MóduloToolStripMenuItem.Text = "Módulo"
        '
        'TrigonometríaToolStripMenuItem
        '
        Me.TrigonometríaToolStripMenuItem.Name = "TrigonometríaToolStripMenuItem"
        Me.TrigonometríaToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.TrigonometríaToolStripMenuItem.Text = "Trigonometría"
        '
        'ConstantesMatemáticasToolStripMenuItem
        '
        Me.ConstantesMatemáticasToolStripMenuItem.Name = "ConstantesMatemáticasToolStripMenuItem"
        Me.ConstantesMatemáticasToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ConstantesMatemáticasToolStripMenuItem.Text = "Constantes Matemáticas"
        '
        'ConversiónDivisasToolStripMenuItem
        '
        Me.ConversiónDivisasToolStripMenuItem.Name = "ConversiónDivisasToolStripMenuItem"
        Me.ConversiónDivisasToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ConversiónDivisasToolStripMenuItem.Text = "Conversión Divisas"
        '
        'ConversiónNuméricaToolStripMenuItem
        '
        Me.ConversiónNuméricaToolStripMenuItem.Name = "ConversiónNuméricaToolStripMenuItem"
        Me.ConversiónNuméricaToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ConversiónNuméricaToolStripMenuItem.Text = "Conversión Numérica"
        '
        'btnNum9
        '
        Me.btnNum9.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNum9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNum9.FlatAppearance.BorderSize = 2
        Me.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum9.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum8.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum7.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum0.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnIgual.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOpSumar.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOpRestar.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOpMultiplicar.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOpPercent.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOpSigno.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpSigno.Location = New System.Drawing.Point(324, 136)
        Me.btnOpSigno.Name = "btnOpSigno"
        Me.btnOpSigno.Size = New System.Drawing.Size(75, 75)
        Me.btnOpSigno.TabIndex = 21
        Me.btnOpSigno.Text = "+ -"
        Me.btnOpSigno.UseVisualStyleBackColor = False
        Me.btnOpSigno.Visible = False
        '
        'btnOpDividir
        '
        Me.btnOpDividir.BackColor = System.Drawing.Color.Yellow
        Me.btnOpDividir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpDividir.FlatAppearance.BorderSize = 2
        Me.btnOpDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpDividir.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOpRaiz.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNum1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum1.Location = New System.Drawing.Point(0, 55)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(75, 75)
        Me.btnNum1.TabIndex = 0
        Me.btnNum1.Text = "1"
        Me.btnNum1.UseVisualStyleBackColor = False
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.SystemColors.Info
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt1.Enabled = False
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
        Me.btnOpDecimal.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpDecimal.Location = New System.Drawing.Point(324, 55)
        Me.btnOpDecimal.Name = "btnOpDecimal"
        Me.btnOpDecimal.Size = New System.Drawing.Size(75, 75)
        Me.btnOpDecimal.TabIndex = 23
        Me.btnOpDecimal.Text = ","
        Me.btnOpDecimal.UseVisualStyleBackColor = False
        Me.btnOpDecimal.Visible = False
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
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
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.SteelBlue
        Me.btn1.FlatAppearance.BorderSize = 3
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn1.Location = New System.Drawing.Point(1, 0)
        Me.btn1.Margin = New System.Windows.Forms.Padding(1)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 30)
        Me.btn1.TabIndex = 31
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.SteelBlue
        Me.btn2.FlatAppearance.BorderSize = 3
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn2.Location = New System.Drawing.Point(43, 0)
        Me.btn2.Margin = New System.Windows.Forms.Padding(1)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 30)
        Me.btn2.TabIndex = 32
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.SteelBlue
        Me.btn3.FlatAppearance.BorderSize = 3
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn3.Location = New System.Drawing.Point(85, 0)
        Me.btn3.Margin = New System.Windows.Forms.Padding(1)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 30)
        Me.btn3.TabIndex = 33
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.SteelBlue
        Me.btn4.FlatAppearance.BorderSize = 3
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn4.Location = New System.Drawing.Point(1, 32)
        Me.btn4.Margin = New System.Windows.Forms.Padding(1)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(40, 30)
        Me.btn4.TabIndex = 34
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.SteelBlue
        Me.btn5.FlatAppearance.BorderSize = 3
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn5.Location = New System.Drawing.Point(43, 32)
        Me.btn5.Margin = New System.Windows.Forms.Padding(1)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(40, 30)
        Me.btn5.TabIndex = 35
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.SteelBlue
        Me.btn6.FlatAppearance.BorderSize = 3
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn6.Location = New System.Drawing.Point(85, 32)
        Me.btn6.Margin = New System.Windows.Forms.Padding(1)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(40, 30)
        Me.btn6.TabIndex = 36
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.SteelBlue
        Me.btn7.FlatAppearance.BorderSize = 3
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn7.Location = New System.Drawing.Point(1, 64)
        Me.btn7.Margin = New System.Windows.Forms.Padding(1)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(40, 30)
        Me.btn7.TabIndex = 37
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.SteelBlue
        Me.btn8.FlatAppearance.BorderSize = 3
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn8.Location = New System.Drawing.Point(43, 64)
        Me.btn8.Margin = New System.Windows.Forms.Padding(1)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(40, 30)
        Me.btn8.TabIndex = 38
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.SteelBlue
        Me.btn9.FlatAppearance.BorderSize = 3
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn9.Location = New System.Drawing.Point(85, 64)
        Me.btn9.Margin = New System.Windows.Forms.Padding(1)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(40, 30)
        Me.btn9.TabIndex = 39
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btnDecimal
        '
        Me.btnDecimal.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDecimal.FlatAppearance.BorderSize = 3
        Me.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDecimal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnDecimal.Location = New System.Drawing.Point(1, 96)
        Me.btnDecimal.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(40, 30)
        Me.btnDecimal.TabIndex = 40
        Me.btnDecimal.Text = ","
        Me.btnDecimal.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.SteelBlue
        Me.btn0.FlatAppearance.BorderSize = 3
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn0.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn0.Location = New System.Drawing.Point(43, 96)
        Me.btn0.Margin = New System.Windows.Forms.Padding(1)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(40, 30)
        Me.btn0.TabIndex = 41
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEqual.FlatAppearance.BorderSize = 3
        Me.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEqual.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnEqual.Location = New System.Drawing.Point(85, 96)
        Me.btnEqual.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(40, 30)
        Me.btnEqual.TabIndex = 42
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btnSumar
        '
        Me.btnSumar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSumar.FlatAppearance.BorderSize = 3
        Me.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSumar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSumar.Location = New System.Drawing.Point(127, 0)
        Me.btnSumar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(40, 30)
        Me.btnSumar.TabIndex = 43
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = False
        '
        'btnRestar
        '
        Me.btnRestar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRestar.FlatAppearance.BorderSize = 3
        Me.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRestar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnRestar.Location = New System.Drawing.Point(127, 32)
        Me.btnRestar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(40, 30)
        Me.btnRestar.TabIndex = 44
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = False
        '
        'btnDividir
        '
        Me.btnDividir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDividir.FlatAppearance.BorderSize = 3
        Me.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDividir.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnDividir.Location = New System.Drawing.Point(127, 96)
        Me.btnDividir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(40, 30)
        Me.btnDividir.TabIndex = 45
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = False
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnMultiplicar.FlatAppearance.BorderSize = 3
        Me.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMultiplicar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnMultiplicar.Location = New System.Drawing.Point(127, 64)
        Me.btnMultiplicar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(40, 30)
        Me.btnMultiplicar.TabIndex = 46
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = False
        '
        'btnRaiz
        '
        Me.btnRaiz.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRaiz.FlatAppearance.BorderSize = 3
        Me.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaiz.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnRaiz.Location = New System.Drawing.Point(169, 96)
        Me.btnRaiz.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(40, 30)
        Me.btnRaiz.TabIndex = 47
        Me.btnRaiz.Text = "√"
        Me.btnRaiz.UseVisualStyleBackColor = False
        '
        'btnPercent
        '
        Me.btnPercent.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPercent.FlatAppearance.BorderSize = 3
        Me.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPercent.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnPercent.Location = New System.Drawing.Point(169, 64)
        Me.btnPercent.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(40, 30)
        Me.btnPercent.TabIndex = 48
        Me.btnPercent.Text = "%"
        Me.btnPercent.UseVisualStyleBackColor = False
        '
        'btnSigno
        '
        Me.btnSigno.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSigno.FlatAppearance.BorderSize = 3
        Me.btnSigno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSigno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSigno.Location = New System.Drawing.Point(169, 32)
        Me.btnSigno.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSigno.Name = "btnSigno"
        Me.btnSigno.Size = New System.Drawing.Size(40, 30)
        Me.btnSigno.TabIndex = 49
        Me.btnSigno.Text = "+ -"
        Me.btnSigno.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnClear.Location = New System.Drawing.Point(169, 0)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(40, 30)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBorrarUltimo
        '
        Me.btnBorrarUltimo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBorrarUltimo.FlatAppearance.BorderSize = 3
        Me.btnBorrarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrarUltimo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBorrarUltimo.Location = New System.Drawing.Point(211, 0)
        Me.btnBorrarUltimo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBorrarUltimo.Name = "btnBorrarUltimo"
        Me.btnBorrarUltimo.Size = New System.Drawing.Size(40, 30)
        Me.btnBorrarUltimo.TabIndex = 51
        Me.btnBorrarUltimo.Text = "<-"
        Me.btnBorrarUltimo.UseVisualStyleBackColor = False
        '
        'btnAbrirPar
        '
        Me.btnAbrirPar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAbrirPar.FlatAppearance.BorderSize = 3
        Me.btnAbrirPar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbrirPar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAbrirPar.Location = New System.Drawing.Point(211, 96)
        Me.btnAbrirPar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAbrirPar.Name = "btnAbrirPar"
        Me.btnAbrirPar.Size = New System.Drawing.Size(40, 30)
        Me.btnAbrirPar.TabIndex = 52
        Me.btnAbrirPar.Text = "("
        Me.btnAbrirPar.UseVisualStyleBackColor = False
        '
        'btnFactorial
        '
        Me.btnFactorial.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFactorial.FlatAppearance.BorderSize = 3
        Me.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFactorial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnFactorial.Location = New System.Drawing.Point(211, 64)
        Me.btnFactorial.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(40, 30)
        Me.btnFactorial.TabIndex = 53
        Me.btnFactorial.Text = "n!"
        Me.btnFactorial.UseVisualStyleBackColor = False
        '
        'btnUnoEntre
        '
        Me.btnUnoEntre.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUnoEntre.FlatAppearance.BorderSize = 3
        Me.btnUnoEntre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnoEntre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnUnoEntre.Location = New System.Drawing.Point(211, 32)
        Me.btnUnoEntre.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUnoEntre.Name = "btnUnoEntre"
        Me.btnUnoEntre.Size = New System.Drawing.Size(40, 30)
        Me.btnUnoEntre.TabIndex = 54
        Me.btnUnoEntre.Text = "1/x"
        Me.btnUnoEntre.UseVisualStyleBackColor = False
        '
        'btnCerrarPar
        '
        Me.btnCerrarPar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCerrarPar.FlatAppearance.BorderSize = 3
        Me.btnCerrarPar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarPar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCerrarPar.Location = New System.Drawing.Point(253, 96)
        Me.btnCerrarPar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCerrarPar.Name = "btnCerrarPar"
        Me.btnCerrarPar.Size = New System.Drawing.Size(40, 30)
        Me.btnCerrarPar.TabIndex = 55
        Me.btnCerrarPar.Text = ")"
        Me.btnCerrarPar.UseVisualStyleBackColor = False
        '
        'btnXtoY
        '
        Me.btnXtoY.BackColor = System.Drawing.Color.SteelBlue
        Me.btnXtoY.FlatAppearance.BorderSize = 3
        Me.btnXtoY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnXtoY.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnXtoY.Location = New System.Drawing.Point(253, 64)
        Me.btnXtoY.Margin = New System.Windows.Forms.Padding(1)
        Me.btnXtoY.Name = "btnXtoY"
        Me.btnXtoY.Size = New System.Drawing.Size(40, 30)
        Me.btnXtoY.TabIndex = 56
        Me.btnXtoY.Text = "x^y"
        Me.btnXtoY.UseVisualStyleBackColor = False
        '
        'btnX3
        '
        Me.btnX3.BackColor = System.Drawing.Color.SteelBlue
        Me.btnX3.FlatAppearance.BorderSize = 3
        Me.btnX3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnX3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnX3.Location = New System.Drawing.Point(253, 32)
        Me.btnX3.Margin = New System.Windows.Forms.Padding(1)
        Me.btnX3.Name = "btnX3"
        Me.btnX3.Size = New System.Drawing.Size(40, 30)
        Me.btnX3.TabIndex = 57
        Me.btnX3.Text = "x^3"
        Me.btnX3.UseVisualStyleBackColor = False
        '
        'btnX2
        '
        Me.btnX2.BackColor = System.Drawing.Color.SteelBlue
        Me.btnX2.FlatAppearance.BorderSize = 3
        Me.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnX2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnX2.Location = New System.Drawing.Point(253, 0)
        Me.btnX2.Margin = New System.Windows.Forms.Padding(1)
        Me.btnX2.Name = "btnX2"
        Me.btnX2.Size = New System.Drawing.Size(40, 30)
        Me.btnX2.TabIndex = 58
        Me.btnX2.Text = "x^2"
        Me.btnX2.UseVisualStyleBackColor = False
        '
        'btnConstE
        '
        Me.btnConstE.BackColor = System.Drawing.Color.SteelBlue
        Me.btnConstE.FlatAppearance.BorderSize = 3
        Me.btnConstE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConstE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnConstE.Location = New System.Drawing.Point(85, 185)
        Me.btnConstE.Margin = New System.Windows.Forms.Padding(1)
        Me.btnConstE.Name = "btnConstE"
        Me.btnConstE.Size = New System.Drawing.Size(40, 45)
        Me.btnConstE.TabIndex = 65
        Me.btnConstE.Text = "e"
        Me.btnConstE.UseVisualStyleBackColor = False
        Me.btnConstE.Visible = False
        '
        'btnPi
        '
        Me.btnPi.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPi.FlatAppearance.BorderSize = 3
        Me.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnPi.Location = New System.Drawing.Point(85, 136)
        Me.btnPi.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(40, 47)
        Me.btnPi.TabIndex = 66
        Me.btnPi.Text = "π"
        Me.btnPi.UseVisualStyleBackColor = False
        Me.btnPi.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnConvertir)
        Me.Panel1.Controls.Add(Me.cbTo)
        Me.Panel1.Controls.Add(Me.cbFrom)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.txtFrom)
        Me.Panel1.Location = New System.Drawing.Point(297, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 94)
        Me.Panel1.TabIndex = 67
        Me.Panel1.Visible = False
        '
        'btnConvertir
        '
        Me.btnConvertir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnConvertir.FlatAppearance.BorderSize = 3
        Me.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConvertir.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnConvertir.Location = New System.Drawing.Point(3, 66)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(100, 27)
        Me.btnConvertir.TabIndex = 68
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = False
        '
        'cbTo
        '
        Me.cbTo.DropDownWidth = 200
        Me.cbTo.FormattingEnabled = True
        Me.cbTo.Items.AddRange(New Object() {"AED - United Arab Emirates Dirham (AED) ", "AFN - Afghan Afghani (AFN)", "ALL - Albanian Lek (ALL)", "AMD - Armenian Dram (AMD)", "ANG - Netherlands Antillean Guilder (ANG)", "AOA - Angolan Kwanza (AOA)", "ARS - Argentine Peso (ARS)", "AUD - Australian Dollar (A$)", "AWG - Aruban Florin (AWG)", "AZN - Azerbaijani Manat (AZN)", "BAM - Bosnia-Herzegovina Convertible Mark (BAM)", "BBD - Barbadian Dollar (BBD)", "BDT - Bangladeshi Taka (BDT)", "BGN - Bulgarian Lev (BGN)", "BHD - Bahraini Dinar (BHD)", "BIF - Burundian Franc (BIF)", "BMD - Bermudan Dollar (BMD)", "BND - Brunei Dollar (BND)", "BOB - Bolivian Boliviano (BOB)", "BRL - Brazilian Real (R$)", "BSD - Bahamian Dollar (BSD)", "BTC - Bitcoin (฿)", "BTN - Bhutanese Ngultrum (BTN)", "BWP - Botswanan Pula (BWP)", "BYR - Belarusian Ruble (BYR)", "BZD - Belize Dollar (BZD)", "CAD - Canadian Dollar (CA$)", "CDF - Congolese Franc (CDF)", "CHF - Swiss Franc (CHF)", "CLF - Chilean Unit of Account (UF) (CLF)", "CLP - Chilean Peso (CLP)", "CNH - CNH (CNH)", "CNY - Chinese Yuan (CN¥)", "COP - Colombian Peso (COP)", "CRC - Costa Rican Colón (CRC)", "CUP - Cuban Peso (CUP)", "CVE - Cape Verdean Escudo (CVE)", "CZK - Czech Republic Koruna (CZK)", "DEM - German Mark (DEM)", "DJF - Djiboutian Franc (DJF)", "DKK - Danish Krone (DKK)", "DOP - Dominican Peso (DOP)", "DZD - Algerian Dinar (DZD)", "EGP - Egyptian Pound (EGP)", "ERN - Eritrean Nakfa (ERN)", "ETB - Ethiopian Birr (ETB)", "EUR - Euro (€)", "FIM - Finnish Markka (FIM)", "FJD - Fijian Dollar (FJD)", "FKP - Falkland Islands Pound (FKP)", "FRF - French Franc (FRF)", "GBP - British Pound Sterling (£)", "GEL - Georgian Lari (GEL)", "GHS - Ghanaian Cedi (GHS)", "GIP - Gibraltar Pound (GIP)", "GMD - Gambian Dalasi (GMD)", "GNF - Guinean Franc (GNF)", "GTQ - Guatemalan Quetzal (GTQ)", "GYD - Guyanaese Dollar (GYD)", "HKD - Hong Kong Dollar (HK$)", "HNL - Honduran Lempira (HNL)", "HRK - Croatian Kuna (HRK)", "HTG - Haitian Gourde (HTG)", "HUF - Hungarian Forint (HUF)", "IDR - Indonesian Rupiah (IDR)", "IEP - Irish Pound (IEP)", "ILS - Israeli New Sheqel (₪)", "INR - Indian Rupee (Rs.)", "IQD - Iraqi Dinar (IQD)", "IRR - Iranian Rial (IRR)", "ISK - Icelandic Króna (ISK)", "ITL - Italian Lira (ITL)", "JMD - Jamaican Dollar (JMD)", "JOD - Jordanian Dinar (JOD)", "JPY - Japanese Yen (¥)", "KES - Kenyan Shilling (KES)", "KGS - Kyrgystani Som (KGS)", "KHR - Cambodian Riel (KHR)", "KMF - Comorian Franc (KMF)", "KPW - North Korean Won (KPW)", "KRW - South Korean Won (₩)", "KWD - Kuwaiti Dinar (KWD)", "KYD - Cayman Islands Dollar (KYD)", "KZT - Kazakhstani Tenge (KZT)", "LAK - Laotian Kip (LAK)", "LBP - Lebanese Pound (LBP)", "LKR - Sri Lankan Rupee (LKR)", "LRD - Liberian Dollar (LRD)", "LSL - Lesotho Loti (LSL)", "LTL - Lithuanian Litas (LTL)", "LVL - Latvian Lats (LVL)", "LYD - Libyan Dinar (LYD)", "MAD - Moroccan Dirham (MAD)", "MDL - Moldovan Leu (MDL)", "MGA - Malagasy Ariary (MGA)", "MKD - Macedonian Denar (MKD)", "MMK - Myanmar Kyat (MMK)", "MNT - Mongolian Tugrik (MNT)", "MOP - Macanese Pataca (MOP)", "MRO - Mauritanian Ouguiya (MRO)", "MUR - Mauritian Rupee (MUR)", "MVR - Maldivian Rufiyaa (MVR)", "MWK - Malawian Kwacha (MWK)", "MXN - Mexican Peso (MX$)", "MYR - Malaysian Ringgit (MYR)", "MZN - Mozambican Metical (MZN)", "NAD - Namibian Dollar (NAD)", "NGN - Nigerian Naira (NGN)", "NIO - Nicaraguan Córdoba (NIO)", "NOK - Norwegian Krone (NOK)", "NPR - Nepalese Rupee (NPR)", "NZD - New Zealand Dollar (NZ$)", "OMR - Omani Rial (OMR)", "PAB - Panamanian Balboa (PAB)", "PEN - Peruvian Nuevo Sol (PEN)", "PGK - Papua New Guinean Kina (PGK)", "PHP - Philippine Peso (Php)", "PKG - PKG (PKG)", "PKR - Pakistani Rupee (PKR)", "PLN - Polish Zloty (PLN)", "PYG - Paraguayan Guarani (PYG)", "QAR - Qatari Rial (QAR)", "RON - Romanian Leu (RON)", "RSD - Serbian Dinar (RSD)", "RUB - Russian Ruble (RUB)", "RWF - Rwandan Franc (RWF)", "SAR - Saudi Riyal (SAR)", "SBD - Solomon Islands Dollar (SBD)", "SCR - Seychellois Rupee (SCR)", "SDG - Sudanese Pound (SDG)", "SEK - Swedish Krona (SEK)", "SGD - Singapore Dollar (SGD)", "SHP - Saint Helena Pound (SHP)", "SLL - Sierra Leonean Leone (SLL)", "SOS - Somali Shilling (SOS)", "SRD - Surinamese Dollar (SRD)", "STD - São Tomé and Príncipe Dobra (STD)", "SVC - Salvadoran Colón (SVC)", "SYP - Syrian Pound (SYP)", "SZL - Swazi Lilangeni (SZL)", "THB - Thai Baht (฿)", "TJS - Tajikistani Somoni (TJS)", "TMT - Turkmenistani Manat (TMT)", "TND - Tunisian Dinar (TND)", "TOP - Tongan Paʻanga (TOP)", "TRY - Turkish Lira (TRY)", "TTD - Trinidad and Tobago Dollar (TTD)", "TWD - New Taiwan Dollar (NT$)", "TZS - Tanzanian Shilling (TZS)", "UAH - Ukrainian Hryvnia (UAH)", "UGX - Ugandan Shilling (UGX)", "USD - US Dollar ($)", "UYU - Uruguayan Peso (UYU)", "UZS - Uzbekistan Som (UZS)", "VEF - Venezuelan Bolívar (VEF)", "VND - Vietnamese Dong (₫)", "VUV - Vanuatu Vatu (VUV)", "WST - Samoan Tala (WST)", "XAF - CFA Franc BEAC (FCFA)", "XCD - East Caribbean Dollar (EC$)", "XDR - Special Drawing Rights (XDR)", "XOF - CFA Franc BCEAO (CFA)", "XPF - CFP Franc (CFPF)", "YER - Yemeni Rial (YER)", "ZAR - South African Rand (ZAR)", "ZMK - Zambian Kwacha (1968–2012) (ZMK)", "ZMW - Zambian Kwacha (ZMW)", "ZWL - Zimbabwean Dollar (2009) (ZWL)"})
        Me.cbTo.Location = New System.Drawing.Point(109, 32)
        Me.cbTo.Name = "cbTo"
        Me.cbTo.Size = New System.Drawing.Size(52, 21)
        Me.cbTo.TabIndex = 3
        '
        'cbFrom
        '
        Me.cbFrom.DropDownWidth = 200
        Me.cbFrom.FormattingEnabled = True
        Me.cbFrom.Items.AddRange(New Object() {"AED - United Arab Emirates Dirham (AED) ", "AFN - Afghan Afghani (AFN)", "ALL - Albanian Lek (ALL)", "AMD - Armenian Dram (AMD)", "ANG - Netherlands Antillean Guilder (ANG)", "AOA - Angolan Kwanza (AOA)", "ARS - Argentine Peso (ARS)", "AUD - Australian Dollar (A$)", "AWG - Aruban Florin (AWG)", "AZN - Azerbaijani Manat (AZN)", "BAM - Bosnia-Herzegovina Convertible Mark (BAM)", "BBD - Barbadian Dollar (BBD)", "BDT - Bangladeshi Taka (BDT)", "BGN - Bulgarian Lev (BGN)", "BHD - Bahraini Dinar (BHD)", "BIF - Burundian Franc (BIF)", "BMD - Bermudan Dollar (BMD)", "BND - Brunei Dollar (BND)", "BOB - Bolivian Boliviano (BOB)", "BRL - Brazilian Real (R$)", "BSD - Bahamian Dollar (BSD)", "BTC - Bitcoin (฿)", "BTN - Bhutanese Ngultrum (BTN)", "BWP - Botswanan Pula (BWP)", "BYR - Belarusian Ruble (BYR)", "BZD - Belize Dollar (BZD)", "CAD - Canadian Dollar (CA$)", "CDF - Congolese Franc (CDF)", "CHF - Swiss Franc (CHF)", "CLF - Chilean Unit of Account (UF) (CLF)", "CLP - Chilean Peso (CLP)", "CNH - CNH (CNH)", "CNY - Chinese Yuan (CN¥)", "COP - Colombian Peso (COP)", "CRC - Costa Rican Colón (CRC)", "CUP - Cuban Peso (CUP)", "CVE - Cape Verdean Escudo (CVE)", "CZK - Czech Republic Koruna (CZK)", "DEM - German Mark (DEM)", "DJF - Djiboutian Franc (DJF)", "DKK - Danish Krone (DKK)", "DOP - Dominican Peso (DOP)", "DZD - Algerian Dinar (DZD)", "EGP - Egyptian Pound (EGP)", "ERN - Eritrean Nakfa (ERN)", "ETB - Ethiopian Birr (ETB)", "EUR - Euro (€)", "FIM - Finnish Markka (FIM)", "FJD - Fijian Dollar (FJD)", "FKP - Falkland Islands Pound (FKP)", "FRF - French Franc (FRF)", "GBP - British Pound Sterling (£)", "GEL - Georgian Lari (GEL)", "GHS - Ghanaian Cedi (GHS)", "GIP - Gibraltar Pound (GIP)", "GMD - Gambian Dalasi (GMD)", "GNF - Guinean Franc (GNF)", "GTQ - Guatemalan Quetzal (GTQ)", "GYD - Guyanaese Dollar (GYD)", "HKD - Hong Kong Dollar (HK$)", "HNL - Honduran Lempira (HNL)", "HRK - Croatian Kuna (HRK)", "HTG - Haitian Gourde (HTG)", "HUF - Hungarian Forint (HUF)", "IDR - Indonesian Rupiah (IDR)", "IEP - Irish Pound (IEP)", "ILS - Israeli New Sheqel (₪)", "INR - Indian Rupee (Rs.)", "IQD - Iraqi Dinar (IQD)", "IRR - Iranian Rial (IRR)", "ISK - Icelandic Króna (ISK)", "ITL - Italian Lira (ITL)", "JMD - Jamaican Dollar (JMD)", "JOD - Jordanian Dinar (JOD)", "JPY - Japanese Yen (¥)", "KES - Kenyan Shilling (KES)", "KGS - Kyrgystani Som (KGS)", "KHR - Cambodian Riel (KHR)", "KMF - Comorian Franc (KMF)", "KPW - North Korean Won (KPW)", "KRW - South Korean Won (₩)", "KWD - Kuwaiti Dinar (KWD)", "KYD - Cayman Islands Dollar (KYD)", "KZT - Kazakhstani Tenge (KZT)", "LAK - Laotian Kip (LAK)", "LBP - Lebanese Pound (LBP)", "LKR - Sri Lankan Rupee (LKR)", "LRD - Liberian Dollar (LRD)", "LSL - Lesotho Loti (LSL)", "LTL - Lithuanian Litas (LTL)", "LVL - Latvian Lats (LVL)", "LYD - Libyan Dinar (LYD)", "MAD - Moroccan Dirham (MAD)", "MDL - Moldovan Leu (MDL)", "MGA - Malagasy Ariary (MGA)", "MKD - Macedonian Denar (MKD)", "MMK - Myanmar Kyat (MMK)", "MNT - Mongolian Tugrik (MNT)", "MOP - Macanese Pataca (MOP)", "MRO - Mauritanian Ouguiya (MRO)", "MUR - Mauritian Rupee (MUR)", "MVR - Maldivian Rufiyaa (MVR)", "MWK - Malawian Kwacha (MWK)", "MXN - Mexican Peso (MX$)", "MYR - Malaysian Ringgit (MYR)", "MZN - Mozambican Metical (MZN)", "NAD - Namibian Dollar (NAD)", "NGN - Nigerian Naira (NGN)", "NIO - Nicaraguan Córdoba (NIO)", "NOK - Norwegian Krone (NOK)", "NPR - Nepalese Rupee (NPR)", "NZD - New Zealand Dollar (NZ$)", "OMR - Omani Rial (OMR)", "PAB - Panamanian Balboa (PAB)", "PEN - Peruvian Nuevo Sol (PEN)", "PGK - Papua New Guinean Kina (PGK)", "PHP - Philippine Peso (Php)", "PKG - PKG (PKG)", "PKR - Pakistani Rupee (PKR)", "PLN - Polish Zloty (PLN)", "PYG - Paraguayan Guarani (PYG)", "QAR - Qatari Rial (QAR)", "RON - Romanian Leu (RON)", "RSD - Serbian Dinar (RSD)", "RUB - Russian Ruble (RUB)", "RWF - Rwandan Franc (RWF)", "SAR - Saudi Riyal (SAR)", "SBD - Solomon Islands Dollar (SBD)", "SCR - Seychellois Rupee (SCR)", "SDG - Sudanese Pound (SDG)", "SEK - Swedish Krona (SEK)", "SGD - Singapore Dollar (SGD)", "SHP - Saint Helena Pound (SHP)", "SLL - Sierra Leonean Leone (SLL)", "SOS - Somali Shilling (SOS)", "SRD - Surinamese Dollar (SRD)", "STD - São Tomé and Príncipe Dobra (STD)", "SVC - Salvadoran Colón (SVC)", "SYP - Syrian Pound (SYP)", "SZL - Swazi Lilangeni (SZL)", "THB - Thai Baht (฿)", "TJS - Tajikistani Somoni (TJS)", "TMT - Turkmenistani Manat (TMT)", "TND - Tunisian Dinar (TND)", "TOP - Tongan Paʻanga (TOP)", "TRY - Turkish Lira (TRY)", "TTD - Trinidad and Tobago Dollar (TTD)", "TWD - New Taiwan Dollar (NT$)", "TZS - Tanzanian Shilling (TZS)", "UAH - Ukrainian Hryvnia (UAH)", "UGX - Ugandan Shilling (UGX)", "USD - US Dollar ($)", "UYU - Uruguayan Peso (UYU)", "UZS - Uzbekistan Som (UZS)", "VEF - Venezuelan Bolívar (VEF)", "VND - Vietnamese Dong (₫)", "VUV - Vanuatu Vatu (VUV)", "WST - Samoan Tala (WST)", "XAF - CFA Franc BEAC (FCFA)", "XCD - East Caribbean Dollar (EC$)", "XDR - Special Drawing Rights (XDR)", "XOF - CFA Franc BCEAO (CFA)", "XPF - CFP Franc (CFPF)", "YER - Yemeni Rial (YER)", "ZAR - South African Rand (ZAR)", "ZMK - Zambian Kwacha (1968–2012) (ZMK)", "ZMW - Zambian Kwacha (ZMW)", "ZWL - Zimbabwean Dollar (2009) (ZWL)"})
        Me.cbFrom.Location = New System.Drawing.Point(109, -1)
        Me.cbFrom.Name = "cbFrom"
        Me.cbFrom.Size = New System.Drawing.Size(52, 21)
        Me.cbFrom.TabIndex = 2
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(3, 32)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(100, 20)
        Me.txtTo.TabIndex = 1
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(3, 0)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtFrom.TabIndex = 0
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.SteelBlue
        Me.btnC.FlatAppearance.BorderSize = 3
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnC.Location = New System.Drawing.Point(127, 200)
        Me.btnC.Margin = New System.Windows.Forms.Padding(1)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(40, 30)
        Me.btnC.TabIndex = 68
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        Me.btnC.Visible = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.SteelBlue
        Me.btnB.FlatAppearance.BorderSize = 3
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnB.Location = New System.Drawing.Point(127, 168)
        Me.btnB.Margin = New System.Windows.Forms.Padding(1)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(40, 30)
        Me.btnB.TabIndex = 69
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        Me.btnB.Visible = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.SteelBlue
        Me.btnA.FlatAppearance.BorderSize = 3
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnA.Location = New System.Drawing.Point(127, 136)
        Me.btnA.Margin = New System.Windows.Forms.Padding(1)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(40, 30)
        Me.btnA.TabIndex = 70
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        Me.btnA.Visible = False
        '
        'btnF
        '
        Me.btnF.BackColor = System.Drawing.Color.SteelBlue
        Me.btnF.FlatAppearance.BorderSize = 3
        Me.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnF.Location = New System.Drawing.Point(169, 200)
        Me.btnF.Margin = New System.Windows.Forms.Padding(1)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(40, 30)
        Me.btnF.TabIndex = 71
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = False
        Me.btnF.Visible = False
        '
        'btnSec
        '
        Me.btnSec.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSec.FlatAppearance.BorderSize = 3
        Me.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSec.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSec.Location = New System.Drawing.Point(43, 168)
        Me.btnSec.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.Size = New System.Drawing.Size(40, 30)
        Me.btnSec.TabIndex = 63
        Me.btnSec.Text = "Sec"
        Me.btnSec.UseVisualStyleBackColor = False
        Me.btnSec.Visible = False
        '
        'btnE
        '
        Me.btnE.BackColor = System.Drawing.Color.SteelBlue
        Me.btnE.FlatAppearance.BorderSize = 3
        Me.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnE.Location = New System.Drawing.Point(169, 168)
        Me.btnE.Margin = New System.Windows.Forms.Padding(1)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(40, 30)
        Me.btnE.TabIndex = 72
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = False
        Me.btnE.Visible = False
        '
        'btnCot
        '
        Me.btnCot.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCot.FlatAppearance.BorderSize = 3
        Me.btnCot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCot.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCot.Location = New System.Drawing.Point(43, 200)
        Me.btnCot.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCot.Name = "btnCot"
        Me.btnCot.Size = New System.Drawing.Size(40, 30)
        Me.btnCot.TabIndex = 62
        Me.btnCot.Text = "Cot"
        Me.btnCot.UseVisualStyleBackColor = False
        Me.btnCot.Visible = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.SteelBlue
        Me.btnD.FlatAppearance.BorderSize = 3
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnD.Location = New System.Drawing.Point(169, 136)
        Me.btnD.Margin = New System.Windows.Forms.Padding(1)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(40, 30)
        Me.btnD.TabIndex = 73
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        Me.btnD.Visible = False
        '
        'btnSin
        '
        Me.btnSin.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSin.FlatAppearance.BorderSize = 3
        Me.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSin.Location = New System.Drawing.Point(1, 136)
        Me.btnSin.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(40, 30)
        Me.btnSin.TabIndex = 61
        Me.btnSin.Text = "Sin"
        Me.btnSin.UseVisualStyleBackColor = False
        Me.btnSin.Visible = False
        '
        'gpb1
        '
        Me.gpb1.Controls.Add(Me.rbtnHex)
        Me.gpb1.Controls.Add(Me.rbtnOctal)
        Me.gpb1.Controls.Add(Me.rbtnBinary)
        Me.gpb1.Controls.Add(Me.rbtnDecimal)
        Me.gpb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpb1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.gpb1.Location = New System.Drawing.Point(211, 130)
        Me.gpb1.Name = "gpb1"
        Me.gpb1.Size = New System.Drawing.Size(82, 100)
        Me.gpb1.TabIndex = 74
        Me.gpb1.TabStop = False
        Me.gpb1.Visible = False
        '
        'rbtnHex
        '
        Me.rbtnHex.AutoSize = True
        Me.rbtnHex.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtnHex.Location = New System.Drawing.Point(3, 74)
        Me.rbtnHex.Name = "rbtnHex"
        Me.rbtnHex.Size = New System.Drawing.Size(49, 17)
        Me.rbtnHex.TabIndex = 3
        Me.rbtnHex.TabStop = True
        Me.rbtnHex.Text = "Hexa"
        Me.rbtnHex.UseVisualStyleBackColor = True
        '
        'rbtnOctal
        '
        Me.rbtnOctal.AutoSize = True
        Me.rbtnOctal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtnOctal.Location = New System.Drawing.Point(3, 51)
        Me.rbtnOctal.Name = "rbtnOctal"
        Me.rbtnOctal.Size = New System.Drawing.Size(55, 17)
        Me.rbtnOctal.TabIndex = 2
        Me.rbtnOctal.TabStop = True
        Me.rbtnOctal.Text = "Octal"
        Me.rbtnOctal.UseVisualStyleBackColor = True
        '
        'rbtnBinary
        '
        Me.rbtnBinary.AutoSize = True
        Me.rbtnBinary.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtnBinary.Location = New System.Drawing.Point(3, 29)
        Me.rbtnBinary.Name = "rbtnBinary"
        Me.rbtnBinary.Size = New System.Drawing.Size(67, 17)
        Me.rbtnBinary.TabIndex = 1
        Me.rbtnBinary.TabStop = True
        Me.rbtnBinary.Text = "Binario"
        Me.rbtnBinary.UseVisualStyleBackColor = True
        '
        'rbtnDecimal
        '
        Me.rbtnDecimal.AutoSize = True
        Me.rbtnDecimal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtnDecimal.Location = New System.Drawing.Point(3, 6)
        Me.rbtnDecimal.Name = "rbtnDecimal"
        Me.rbtnDecimal.Size = New System.Drawing.Size(67, 17)
        Me.rbtnDecimal.TabIndex = 0
        Me.rbtnDecimal.TabStop = True
        Me.rbtnDecimal.Text = "Decimal"
        Me.rbtnDecimal.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCos.FlatAppearance.BorderSize = 3
        Me.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCos.Location = New System.Drawing.Point(1, 168)
        Me.btnCos.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(40, 30)
        Me.btnCos.TabIndex = 60
        Me.btnCos.Text = "Cos"
        Me.btnCos.UseVisualStyleBackColor = False
        Me.btnCos.Visible = False
        '
        'btnTan
        '
        Me.btnTan.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTan.FlatAppearance.BorderSize = 3
        Me.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTan.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnTan.Location = New System.Drawing.Point(1, 200)
        Me.btnTan.Margin = New System.Windows.Forms.Padding(1)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(40, 30)
        Me.btnTan.TabIndex = 59
        Me.btnTan.Text = "Tan"
        Me.btnTan.UseVisualStyleBackColor = False
        Me.btnTan.Visible = False
        '
        'btnCsc
        '
        Me.btnCsc.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCsc.FlatAppearance.BorderSize = 3
        Me.btnCsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCsc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCsc.Location = New System.Drawing.Point(43, 136)
        Me.btnCsc.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCsc.Name = "btnCsc"
        Me.btnCsc.Size = New System.Drawing.Size(40, 30)
        Me.btnCsc.TabIndex = 64
        Me.btnCsc.Text = "Csc"
        Me.btnCsc.UseVisualStyleBackColor = False
        Me.btnCsc.Visible = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Transparent
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.btnCsc)
        Me.panel2.Controls.Add(Me.btnTan)
        Me.panel2.Controls.Add(Me.btnCos)
        Me.panel2.Controls.Add(Me.gpb1)
        Me.panel2.Controls.Add(Me.btnSin)
        Me.panel2.Controls.Add(Me.btnD)
        Me.panel2.Controls.Add(Me.btnCot)
        Me.panel2.Controls.Add(Me.btnE)
        Me.panel2.Controls.Add(Me.btnSec)
        Me.panel2.Controls.Add(Me.btnF)
        Me.panel2.Controls.Add(Me.btnA)
        Me.panel2.Controls.Add(Me.btnB)
        Me.panel2.Controls.Add(Me.btnC)
        Me.panel2.Controls.Add(Me.Panel1)
        Me.panel2.Controls.Add(Me.btnPi)
        Me.panel2.Controls.Add(Me.btnConstE)
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
        Me.panel2.Size = New System.Drawing.Size(467, 378)
        Me.panel2.TabIndex = 31
        Me.panel2.Visible = False
        '
        'Calculadora
        '
        Me.AcceptButton = Me.btnIgual
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(336, 427)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.mnu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnu
        Me.MaximizeBox = False
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gpb1.ResumeLayout(False)
        Me.gpb1.PerformLayout()
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
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MóduloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrigonometríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConstantesMatemáticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversiónDivisasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversiónNuméricaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents btnRestar As System.Windows.Forms.Button
    Friend WithEvents btnDividir As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicar As System.Windows.Forms.Button
    Friend WithEvents btnRaiz As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnSigno As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBorrarUltimo As System.Windows.Forms.Button
    Friend WithEvents btnAbrirPar As System.Windows.Forms.Button
    Friend WithEvents btnFactorial As System.Windows.Forms.Button
    Friend WithEvents btnUnoEntre As System.Windows.Forms.Button
    Friend WithEvents btnCerrarPar As System.Windows.Forms.Button
    Friend WithEvents btnXtoY As System.Windows.Forms.Button
    Friend WithEvents btnX3 As System.Windows.Forms.Button
    Friend WithEvents btnX2 As System.Windows.Forms.Button
    Friend WithEvents btnConstE As System.Windows.Forms.Button
    Friend WithEvents btnPi As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnConvertir As System.Windows.Forms.Button
    Friend WithEvents cbTo As System.Windows.Forms.ComboBox
    Friend WithEvents cbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnF As System.Windows.Forms.Button
    Friend WithEvents btnSec As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents btnCot As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents btnSin As System.Windows.Forms.Button
    Friend WithEvents gpb1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnHex As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnOctal As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBinary As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDecimal As System.Windows.Forms.RadioButton
    Friend WithEvents btnCos As System.Windows.Forms.Button
    Friend WithEvents btnTan As System.Windows.Forms.Button
    Friend WithEvents btnCsc As System.Windows.Forms.Button
    Friend WithEvents panel2 As System.Windows.Forms.Panel

End Class
