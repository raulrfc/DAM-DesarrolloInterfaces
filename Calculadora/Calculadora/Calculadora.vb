Public Class Calculadora
    Dim resultado As Decimal = 0 'Define resultado como decimal y lo inicializa a 0
    Dim operandos As Queue(Of Decimal) = New Queue(Of Decimal) 'Crea una lista de decimales que guardará los números que se vayan introduciendo en la calculadora
    Dim operaciones As Queue(Of String) = New Queue(Of String) 'Crea una lista de strings que guardará las operaciones que se vayan introduciendo en la calculadora
    Dim posicion As Integer = 1 ' Define la variable posición para controlar la localización de los botones al integrar los módulos a la calculadora
    Dim flag As String = "dec" ' Variable de control para la conversión numérica inicializada a decimal

#Region "Funciones necesarias"
    Private Sub encolarOperacionYOperando(ByVal op As String)
        Dim operando As Decimal

        If txt1.Text = Nothing Then
            operando = 0
        Else
            operando = Decimal.Parse(txt1.Text) 'Guarda el número que hay en la caja de texto en la variable operando
        End If

        operandos.Enqueue(operando) 'Agrega el operando a la lista de operandos
        operaciones.Enqueue(op) 'Agrega la operación a la lista de operaciones
        txt1.Clear() 'Limpia el texto de la pantalla
    End Sub

    Private Sub operar()
        resultado = operandos.Dequeue 'Quitamos de la cola el primer elemento y se lo asignamos a "resultado"

        Do While (operandos.Count > 0 Or operaciones.Count > 0) 'Mientras el número de elementos en la cola de operandos sea mayor a 0, realizamos las operaciones
            Dim operando As Decimal = 0


            If (operandos.Count > 0) Then
                operando = operandos.Dequeue
            End If

            Dim operacion = operaciones.Dequeue

            Select Case (operacion) 'Según el valor de la variable operacion realizará una operación u otra
                Case "+" : resultado = Decimal.Add(resultado, operando)
                Case "-" : resultado = Decimal.Subtract(resultado, operando)
                Case "x" : resultado = Decimal.Multiply(resultado, operando)
                Case "/" : resultado = Decimal.Divide(resultado, operando)
                Case "%" : resultado = (resultado * operando) / 100
                Case "Raiz" : resultado = Math.Sqrt(resultado)
                Case "Fac" : resultado = Factorial(resultado)
                Case "x2" : resultado = resultado * resultado
                Case "x3" : resultado = resultado * resultado * resultado
                Case "exp" : resultado = Math.Pow(resultado, operando)
                Case "Sin" : resultado = Math.Sin(resultado * (Math.PI / 180)) 'El ángulo es transformado a radianes para poder usar la función Math
                Case "Cos" : resultado = Math.Cos(resultado * (Math.PI / 180))
                Case "Tan" : resultado = Math.Tan(resultado * (Math.PI / 180))
                Case "Csc" : resultado = 1 / Math.Sin(resultado * (Math.PI / 180))
                Case "Sec" : resultado = 1 / Math.Cos(resultado * (Math.PI / 180))
                Case "Cot" : resultado = 1 / Math.Tan(resultado * (Math.PI / 180))
                Case "10tox" : resultado = Math.Pow(10, operando)
                Case "Log" : resultado = Math.Log(resultado)

            End Select
        Loop
    End Sub

    Private Sub Calculadora_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown ' Éste método permite la entrada por teclado de números y operaciones básicas
        Select Case (e.KeyCode) ' Selecciona uno u otro caso en función de la tecla que se ha pulsado y entonces la redirige al método adecuado, en caso de que no sea una tecla válida, evita que se muestre en pantalla
            Case Keys.D0, Keys.NumPad0
                btn0_Click(Me, EventArgs.Empty)
            Case Keys.D1, Keys.NumPad1
                btn1_Click(Me, EventArgs.Empty)
            Case Keys.D2, Keys.NumPad2
                btn2_Click(Me, EventArgs.Empty)
            Case Keys.D3, Keys.NumPad3
                btn3_Click(Me, EventArgs.Empty)
            Case Keys.D4, Keys.NumPad4
                btn4_Click(Me, EventArgs.Empty)
            Case Keys.D5, Keys.NumPad5
                btn5_Click(Me, EventArgs.Empty)
            Case Keys.D6, Keys.NumPad6
                btn6_Click(Me, EventArgs.Empty)
            Case Keys.D7, Keys.NumPad7
                btn7_Click(Me, EventArgs.Empty)
            Case Keys.D8, Keys.NumPad8
                btn8_Click(Me, EventArgs.Empty)
            Case Keys.D9, Keys.NumPad9
                btn9_Click(Me, EventArgs.Empty)
            Case Keys.Add
                btnSumar_Click(Me, EventArgs.Empty)
            Case Keys.Subtract
                btnRestar_Click(Me, EventArgs.Empty)
            Case Keys.Multiply
                btnMultiplicar_Click(Me, EventArgs.Empty)
            Case Keys.Divide
                btnDividir_Click(Me, EventArgs.Empty)
            Case Keys.Back
                btnBorrarUltimo_Click(Me, EventArgs.Empty)
            Case Keys.Decimal
                btnDecimal_Click(Me, EventArgs.Empty)
            Case Keys.Enter
                btnIgual_Click(Me, EventArgs.Empty)
            Case Else
                txt1.Text = txt1.Text + ""
        End Select
        e.Handled = True
    End Sub
#End Region

#Region "Menus"

    Private Sub kidsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kidsMenuItem.Click ' Carga la calculadora para niños
        setKidsTheme()
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.kidsBack
    End Sub

    Private Sub ancianosMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mayoresMenuItem.Click ' Carga la calculadora para mayores
        setMayoresTheme()
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.elderBack
    End Sub

    Private Sub oficinaMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oficinaMenuItem.Click ' Carga la calculadora para oficinas
        setOficinaTheme(posicion)
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.officeBack
    End Sub

    Private Sub TrigonometríaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrigonometríaToolStripMenuItem.Click ' Carga los botones de funciones trigonométricas

        btnSin.Location = New Point(posicion, 136)
        btnSin.Visible = True
        btnCos.Location = New Point(posicion, 168)
        btnCos.Visible = True
        btnTan.Location = New Point(posicion, 200)
        btnTan.Visible = True
        btnCsc.Location = New Point(posicion + 42, 136)
        btnCsc.Visible = True
        btnSec.Location = New Point(posicion + 42, 168)
        btnSec.Visible = True
        btnCot.Location = New Point(posicion + 42, 200)
        btnCot.Visible = True

        If (Panel1.Visible = True) Then
            Me.Size = New Point(500, 350)
        Else
            Me.Size = New Point(330, 350)
        End If
        TrigonometríaToolStripMenuItem.Enabled = False

        posicion = posicion + (2 * 42)
    End Sub

    Private Sub ConstantesMatemáticasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConstantesMatemáticasToolStripMenuItem.Click ' Carga los botones de las constantes matemáticas
        btnPi.Location = New Point(posicion, 136)
        btnPi.Visible = True
        btnConstE.Location = New Point(posicion, 185)
        btnConstE.Visible = True

        If (Panel1.Visible = True) Then
            Me.Size = New Point(500, 350)
        Else
            Me.Size = New Point(330, 350)
        End If

        ConstantesMatemáticasToolStripMenuItem.Enabled = False
        posicion = posicion + 42
    End Sub

    Private Sub ConversiónDivisasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversiónDivisasToolStripMenuItem.Click ' Carga la interfaz para la conversión de divisas
        Panel1.Visible = True
        txtFrom.AutoSize = False
        txtFrom.Size = New Point(100, 30)
        txtTo.AutoSize = False
        txtTo.Size = New Point(100, 30)
        cbFrom.AutoSize = False
        cbFrom.Size = New Point(50, 30)
        cbTo.AutoSize = False
        cbTo.Size = New Point(50, 30)

        If posicion > 1 Then
            Me.Size = New Point(500, 350)
        Else
            Me.Size = New Point(500, 250)
        End If

        ConversiónDivisasToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ConversiónNuméricaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversiónNuméricaToolStripMenuItem.Click ' Carga la interfaz para la conversión numérica
        btnA.Location = New Point(posicion, 136)
        btnA.Visible = True
        btnB.Location = New Point(posicion, 168)
        btnB.Visible = True
        btnC.Location = New Point(posicion, 200)
        btnC.Visible = True
        btnD.Location = New Point(posicion + 42, 136)
        btnD.Visible = True
        btnE.Location = New Point(posicion + 42, 168)
        btnE.Visible = True
        btnF.Location = New Point(posicion + 42, 200)
        btnF.Visible = True
        gpb1.Location = New Point(posicion + 84, 130)
        gpb1.Visible = True

        If (Panel1.Visible = True) Then
            Me.Size = New Point(500, 350)
        Else
            Me.Size = New Point(330, 350)
        End If
        ConversiónNuméricaToolStripMenuItem.Enabled = False
        posicion = posicion + 168

    End Sub

#End Region

#Region "Numeros"

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum1.Click, btn1.Click
        txt1.Text = txt1.Text & 1 'Agregamos a la caja de texto el número 1
        setMayoresSound()

    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum2.Click, btn2.Click
        txt1.Text = txt1.Text & 2
        setMayoresSound()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum3.Click, btn3.Click
        txt1.Text = txt1.Text & 3
        setMayoresSound()
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum4.Click, btn4.Click
        txt1.Text = txt1.Text & 4
        setMayoresSound()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum5.Click, btn5.Click
        txt1.Text = txt1.Text & 5
        setMayoresSound()
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum6.Click, btn6.Click
        txt1.Text = txt1.Text & 6
        setMayoresSound()
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum7.Click, btn7.Click
        txt1.Text = txt1.Text & 7
        setMayoresSound()
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum8.Click, btn8.Click
        txt1.Text = txt1.Text & 8
        setMayoresSound()
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum9.Click, btn9.Click
        txt1.Text = txt1.Text & 9
        setMayoresSound()
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum0.Click, btn0.Click
        txt1.Text = txt1.Text & 0
        setMayoresSound()
    End Sub

#End Region

#Region "Operaciones niños"
    Private Sub btnIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgual.Click, btnEqual.Click
        setMayoresSound()
        If (txt1.Text <> "") Then
            operandos.Enqueue(Decimal.Parse(txt1.Text))
        End If

        operar()
        txt1.Text = resultado

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click, btnClear.Click
        setMayoresSound()
        txt1.Clear()
        resultado = 0
    End Sub

    Private Sub btnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpSumar.Click, btnSumar.Click
        setMayoresSound()
        encolarOperacionYOperando("+")
    End Sub

    Private Sub btnRestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpRestar.Click, btnRestar.Click
        setMayoresSound()
        encolarOperacionYOperando("-")
    End Sub

    Private Sub btnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpMultiplicar.Click, btnMultiplicar.Click
        setMayoresSound()
        encolarOperacionYOperando("x")
    End Sub

    Private Sub btnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpDividir.Click, btnDividir.Click
        setMayoresSound()
        encolarOperacionYOperando("/")
    End Sub
#End Region

#Region "Operaciones mayores"

    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpPercent.Click, btnPercent.Click
        setMayoresSound()
        encolarOperacionYOperando("%")
    End Sub

    Private Sub btnSigno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpSigno.Click, btnSigno.Click
        setMayoresSound()
        txt1.Text = Decimal.Negate(txt1.Text)
    End Sub

    Private Sub btnRaiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpRaiz.Click, btnRaiz.Click
        setMayoresSound()
        encolarOperacionYOperando("Raiz")
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpDecimal.Click, btnDecimal.Click 'Agregar la coma decimal
        Dim dot As Boolean = False 'Define una variable de control booleana como False
        setMayoresSound()

        If txt1.Text.IndexOf(",") >= 0 Then 'Si detecta la coma en la caja de texto, cambia el valor de dot a True
            dot = True
        Else 'Si dot es false, agrega la coma decimal
            txt1.Text += ","
        End If

    End Sub
#End Region

#Region "Operaciones Oficina"

    Private Function Factorial(ByVal numero As Decimal) As Decimal 'Función recursiva para calcular el factorial de un número pasado por parámetro

        If (numero > 0) Then
            Factorial = numero * Factorial(numero - 1)
        Else
            Factorial = 1
        End If

    End Function

    Private Sub btnFactorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactorial.Click
        encolarOperacionYOperando("Fac")
    End Sub

    Private Sub btnX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX2.Click
        encolarOperacionYOperando("x2")
    End Sub

    Private Sub btnX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX3.Click
        encolarOperacionYOperando("x3")
    End Sub

    Private Sub btnXtoY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXtoY.Click
        encolarOperacionYOperando("exp")
    End Sub

    Private Sub btnLn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLn.Click
        encolarOperacionYOperando("Ln")
    End Sub

    Private Sub btn10toX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10toX.Click
        encolarOperacionYOperando("10tox")
    End Sub

    Private Sub btnBorrarUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarUltimo.Click
        txt1.Text = txt1.Text.Remove(txt1.TextLength - 1) ' Borra el último número introducido 
    End Sub
#End Region

#Region "Módulo Trigonometría"
    Private Sub btnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSin.Click
        encolarOperacionYOperando("Sin")
    End Sub

    Private Sub btnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCos.Click
        encolarOperacionYOperando("Cos")
    End Sub

    Private Sub btnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTan.Click
        encolarOperacionYOperando("Tan")
    End Sub

    Private Sub btnCsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCsc.Click
        encolarOperacionYOperando("Csc")
    End Sub

    Private Sub btnSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSec.Click
        encolarOperacionYOperando("Sec")
    End Sub

    Private Sub btnCot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCot.Click
        encolarOperacionYOperando("Cot")
    End Sub
#End Region

#Region "Módulo Constantes Matemáticas"
    Private Sub btnPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPi.Click
        txt1.Text = Math.PI
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConstE.Click
        txt1.Text = Math.E
    End Sub
#End Region

#Region "Módulo Conversión Divisas"

    Public Sub Convertir(ByVal cantidad As Decimal, ByVal fromCurrency As String, ByVal toCurrency As String) ' Método para la conversión de monedas conectándose a un servicio web
        Dim web As System.Net.WebClient = New System.Net.WebClient() ' Defino un cliente web para acceder al servicio web
        Dim url As String = "https://www.google.com/finance/converter?a=" + cantidad.ToString + "&from=" + fromCurrency + "&to=" + toCurrency + "" ' Defino la URL con los parámetros del método, conecta con el servicio web de Google
        Dim response As String = web.DownloadString(url) ' Defino la variable  url; descargo la respuesta del servicio web en un String y la guardo en la variable
        Dim length As Integer = response.LastIndexOf("</span>") - (response.LastIndexOf("class=bld>") + 10) ' Defino la longitud de caracteres que quiero coger del resultado anterior
        Dim result As String = response.Substring((response.LastIndexOf("class=bld>") + 10), length) ' Con el método substring, recojo la parte numérica de la conversión y la almaceno en la variable "result"
        Dim dresult As Decimal = Decimal.Parse(result.Split(" ")(0).Replace(".", ",")) ' Defino la variable Decimal "dresult"; Separo el resultado hasta que encuentra un espacio, para eliminar el tipo de divisa; Reemplazo el . por una , para su posterior uso. Lo convierto todo a decimal para poder redondear después a 2 decimales.

        txtTo.Text = Decimal.Round(dresult, 2).ToString ' Muestro por la segunda pantalla el resultado; el resultado es redondeado a 2 decimales y convertido a string.

    End Sub

    Private Sub btnConvertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertir.Click
        Dim cantidad As Decimal = txtFrom.Text
        Dim FromCurrency As String = cbFrom.SelectedItem.Substring(0, 3)
        Dim ToCurrency As String = cbTo.SelectedItem.Substring(0, 3)

        Convertir(cantidad, FromCurrency, ToCurrency)
    End Sub
#End Region

#Region "Módulo Conversión Numérica"

    Private Sub conversionNumerica(ByVal flag As String, ByVal num As Int32, ByVal target As Integer) ' Método para controlar la conversión numérica de cualquier base
        Select Case (flag)
            Case "bin"
                num = Convert.ToInt32(txt1.Text, 2) ' Se convierte el número a base decimal en función de la "flag" recibida

            Case "oct"
                num = Convert.ToInt32(txt1.Text, 8)

            Case "dec"
                num = Convert.ToInt32(txt1.Text, 10)

            Case "hex"
                num = Convert.ToInt32(txt1.Text, 16)

        End Select
        txt1.Text = Convert.ToString(num, target) ' El número decimal se convierte después a la base objetivo
    End Sub

    Private Sub rbtnDecimal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDecimal.CheckedChanged
        Dim num As String = txt1.Text
        If rbtnDecimal.Checked = True Then
            setDecimal()
            Select Case (flag)
                Case "bin" : txt1.Text = Convert.ToInt32(num, 2)
                Case "oct" : txt1.Text = Convert.ToInt32(num, 8)
                Case "hex" : txt1.Text = Convert.ToInt32(num, 16)
            End Select
        End If
        flag = "dec"
    End Sub

    Private Sub rbtnBinary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnBinary.CheckedChanged

        If rbtnBinary.Checked = True Then
            setBinary()
            conversionNumerica(flag, txt1.Text, 2)
        End If

        flag = "bin"
    End Sub

    Private Sub rbtnOctal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnOctal.CheckedChanged
        If rbtnOctal.Checked = True Then
            setOctal()
            conversionNumerica(flag, txt1.Text, 8)
        End If

        flag = "oct"
    End Sub

    Private Sub rbtnHex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnHex.CheckedChanged
        If rbtnHex.Checked = True Then
            setHex(True)
            conversionNumerica(flag, txt1.Text, 16)
        End If

        flag = "hex"
    End Sub
#End Region

End Class