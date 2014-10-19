Imports System.Drawing
Imports Calculadora.Calculadora

Module Module1
    Public Sub setOficinaTheme()
        Calculadora.mayoresMenuItem.Enabled = True
        Calculadora.kidsMenuItem.Enabled = True
        Calculadora.oficinaMenuItem.Enabled = False

        Calculadora.txt1.Width = 290

        Calculadora.panel2.Visible = True
        Calculadora.panel2.Location = New Point(10, 75)
    End Sub
    Public Sub setMayoresTheme()

        setMayoresLayout()
        setBtnProperties("btnNum", Color.SteelBlue)
        setBtnProperties("btnOp", Color.SeaGreen)

        setBtnProperties2(Calculadora.btnIgual, Color.Snow, 162, 298)
        setBtnProperties2(Calculadora.btnOpDecimal, Color.SeaGreen, 0, 298)
        setBtnProperties2(Calculadora.btnBorrar, Color.Firebrick, 324, 55)

    End Sub

    Public Sub setMayoresLayout()

        Calculadora.mayoresMenuItem.Enabled = False
        Calculadora.kidsMenuItem.Enabled = True
        Calculadora.oficinaMenuItem.Enabled = True

        Calculadora.panel2.Visible = False

        Calculadora.txt1.Width = 400

        Calculadora.btnOpDecimal.Visible = True
        Calculadora.btnOpRaiz.Visible = True
        Calculadora.btnOpPercent.Visible = True
        Calculadora.btnOpSigno.Visible = True

    End Sub

    Public Sub setKidsTheme()
        setKidsLayout()

        setBtnProperties("btnNum", Color.DodgerBlue)
        setBtnProperties2(Calculadora.btnOpSumar, Color.Lime, 243, 55)
        setBtnProperties2(Calculadora.btnOpRestar, Color.Red, 243, 136)
        setBtnProperties2(Calculadora.btnOpMultiplicar, Color.MediumSpringGreen, 243, 217)
        setBtnProperties2(Calculadora.btnOpDividir, Color.Yellow, 243, 298)
        setBtnProperties2(Calculadora.btnIgual, Color.Snow, 162, 298)
        setBtnProperties2(Calculadora.btnBorrar, Color.Fuchsia, 0, 298)

    End Sub

    Public Sub setKidsLayout()

        Calculadora.mayoresMenuItem.Enabled = True
        Calculadora.kidsMenuItem.Enabled = False
        Calculadora.oficinaMenuItem.Enabled = True

        Calculadora.panel2.Visible = False

        Calculadora.txt1.Width = 318

        Calculadora.btnOpDecimal.Visible = False
        Calculadora.btnOpRaiz.Visible = False
        Calculadora.btnOpPercent.Visible = False
        Calculadora.btnOpSigno.Visible = False
    End Sub

    Public Sub setBtnProperties2(ByRef btn As Button, ByVal backColor As Color, ByVal x As Integer, ByVal y As Integer)
        btn.BackColor = backColor
        btn.Location = New Point(x, y)
        'btn.Size = New Point(anchura, altura)
    End Sub


    Public Sub setBtnProperties2(ByRef btn As Button, ByVal backColor As Color)
        btn.BackColor = backColor
    End Sub

    Public Sub setBtnProperties(ByVal id As String, ByVal backColor As Color)
        For Each Control In Calculadora.panel.Controls
            If Control.GetType = GetType(Button) Then
                Dim btn = CType(Control, Button)
                If btn.Name.StartsWith(id) Then
                    btn.BackColor = backColor
                End If
            End If
        Next
    End Sub

End Module
