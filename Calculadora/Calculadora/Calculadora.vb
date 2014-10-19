
Public Class Calculadora
    Dim resultado As Decimal = 0 'Define resultado como decimal y lo inicializa a 0
    Dim operandos As Queue(Of Decimal) = New Queue(Of Decimal) 'Crea una lista de decimales que guardará los números que se vayan introduciendo en la calculadora
    Dim operaciones As Queue(Of String) = New Queue(Of String) 'Crea una lista de strings que guardará las operaciones que se vayan introduciendo en la calculadora

    Private Sub encolarOperacionYOperando(ByVal op As String)
        Dim operando As Decimal = Decimal.Parse(txt1.Text) 'Guarda el número que hay en la caja de texto en la variable operando

        operandos.Enqueue(operando) 'Agrega el operando a la lista de operandos
        operaciones.Enqueue(op) 'Agrega la operación a la lista de operaciones
        txt1.Clear() 'Limpia el texto de la pantalla
    End Sub

    Private Sub operar()
        resultado = operandos.Dequeue 'Quitamos de la cola el primer elemento y se lo asignamos a "resultado"

        Do While (operandos.Count > 0 Or operaciones.Count > 0) 'Mientras el número de elementos en la cola de operandos sea mayor a 0, realizamos las operaciones
            Dim operando = 0

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

            End Select

        Loop
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum1.Click, btn1.Click
        txt1.Text = txt1.Text & 1 'Agregamos a la caja de texto el número 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum2.Click, btn2.Click
        txt1.Text = txt1.Text & 2
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum3.Click, btn3.Click
        txt1.Text = txt1.Text & 3
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum4.Click, btn4.Click
        txt1.Text = txt1.Text & 4
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum5.Click, btn5.Click
        txt1.Text = txt1.Text & 5
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum6.Click, btn6.Click
        txt1.Text = txt1.Text & 6
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum7.Click, btn7.Click
        txt1.Text = txt1.Text & 7
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum8.Click, btn8.Click
        txt1.Text = txt1.Text & 8
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum9.Click, btn9.Click
        txt1.Text = txt1.Text & 9
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum0.Click, btn0.Click
        txt1.Text = txt1.Text & 0
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click, btnClear.Click
        txt1.Clear()
        resultado = 0
    End Sub

    Private Sub btnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpSumar.Click, btnSumar.Click
        encolarOperacionYOperando("+")
    End Sub

    Private Sub btnRestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpRestar.Click, btnRestar.Click
        encolarOperacionYOperando("-")
    End Sub

    Private Sub btnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpMultiplicar.Click, btnMultiplicar.Click
        encolarOperacionYOperando("x")
    End Sub

    Private Sub btnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpDividir.Click, btnDividir.Click
        encolarOperacionYOperando("/")
    End Sub

    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpPercent.Click, btnPercent.Click
        encolarOperacionYOperando("%")
    End Sub

    Private Sub btnSigno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpSigno.Click, btnSigno.Click
        txt1.Text = Decimal.Negate(txt1.Text)
    End Sub

    Private Sub btnRaiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpRaiz.Click, btnRaiz.Click
        encolarOperacionYOperando("Raiz")
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpDecimal.Click, btnDecimal.Click
        Dim dot As Boolean = False

        If txt1.Text.IndexOf(",") >= 0 Then dot = True

        If dot = False Then txt1.Text += ","

    End Sub

    Private Sub btnIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgual.Click, btnEqual.Click
        If (txt1.Text <> "") Then
            operandos.Enqueue(Decimal.Parse(txt1.Text))
        End If

        operar()
        txt1.Text = resultado

    End Sub

    Private Sub kidsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kidsMenuItem.Click
        setKidsTheme()
    End Sub

    Private Sub ancianosMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mayoresMenuItem.Click
        setMayoresTheme()
    End Sub

    Private Sub oficinaMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oficinaMenuItem.Click
        setOficinaTheme()
    End Sub

End Class