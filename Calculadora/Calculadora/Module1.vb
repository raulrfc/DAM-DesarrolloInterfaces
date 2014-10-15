Imports System.Drawing
Imports Calculadora.Calculadora

Module Module1
    Public Sub setMayoresTheme()
        setMayoresLayout()

        setBtnProperties(Calculadora.btn0, Color.Brown)
        setBtnProperties(Calculadora.btn1, Color.Brown)
        setBtnProperties(Calculadora.btn2, Color.Brown)
        setBtnProperties(Calculadora.btn3, Color.Brown)
        setBtnProperties(Calculadora.btn4, Color.Brown)
        setBtnProperties(Calculadora.btn5, Color.Brown)
        setBtnProperties(Calculadora.btn6, Color.Brown)
        setBtnProperties(Calculadora.btn7, Color.Brown)
        setBtnProperties(Calculadora.btn8, Color.Brown)
        setBtnProperties(Calculadora.btn9, Color.Brown)
    End Sub

    Public Sub setMayoresLayout()

        Calculadora.mayoresMenuItem.Enabled = False
        Calculadora.kidsMenuItem.Enabled = True
        Calculadora.oficinaMenuItem.Enabled = True

        Calculadora.txt1.Width = 400

        Calculadora.btnDecimal.Visible = True
        Calculadora.btnRaiz.Visible = True
        Calculadora.btnPercent.Visible = True
        Calculadora.btnSigno.Visible = True


    End Sub


    Public Sub setBtnProperties(ByRef btn As Button, ByVal backColor As Color)
        btn.BackColor = backColor
    End Sub

End Module
