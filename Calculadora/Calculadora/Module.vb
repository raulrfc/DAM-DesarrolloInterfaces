Imports System.Drawing
Imports Calculadora.Calculadora

Module Module1
    Public Sub setOficinaTheme(ByVal posicion As Integer) ' Carga el tema de la calculadora de oficina
        Dim layout As Integer

        Calculadora.mayoresMenuItem.Enabled = True
        Calculadora.kidsMenuItem.Enabled = True
        Calculadora.oficinaMenuItem.Enabled = False
        Calculadora.AgregarToolStripMenuItem.Enabled = True

        Calculadora.txt1.Width = 450

        Calculadora.panel2.Visible = True
        Calculadora.panel2.Location = New Point(10, 75)
        Calculadora.BackColor = Color.SlateGray


        If Calculadora.Panel1.Visible = True And posicion > 1 Then
            layout = 1
        ElseIf posicion > 1 Then
            layout = 2
        ElseIf Calculadora.Panel1.Visible = True Then
            layout = 3
        Else
            layout = 4
        End If

        Select Case (layout) 'Según el valor de la variable layout se redimensionará la calculadora a un tamaño u otro
            Case "1"
                Calculadora.Size = New Point(500, 350)
                Calculadora.txt1.Width = 450
            Case "2"
                Calculadora.Size = New Point(330, 350)
                Calculadora.txt1.Width = 290
            Case "3"
                Calculadora.Size = New Point(500, 250)
                Calculadora.txt1.Width = 450
            Case "4"
                Calculadora.Size = New Point(330, 250)
                Calculadora.txt1.Width = 290
        End Select
    End Sub

    Public Sub setMayoresTheme() ' Carga el tema de la calculadora para mayores

        setMayoresLayout()
        setBtnProperties("btnNum", Color.SteelBlue)
        setBtnProperties("btnOp", Color.SeaGreen)

        setBtnProperties2(Calculadora.btnIgual, Color.Snow, 162, 298)
        setBtnProperties2(Calculadora.btnOpDecimal, Color.SeaGreen, 0, 298)
        setBtnProperties2(Calculadora.btnBorrar, Color.Firebrick, 324, 55)
        Calculadora.BackColor = Color.DarkOliveGreen


    End Sub

    Public Sub setKidsTheme() ' Carga el tema de la calculadora para niños
        setKidsLayout()

        setBtnProperties("btnNum", Color.DodgerBlue)
        setBtnProperties2(Calculadora.btnOpSumar, Color.Lime, 243, 55)
        setBtnProperties2(Calculadora.btnOpRestar, Color.Red, 243, 136)
        setBtnProperties2(Calculadora.btnOpMultiplicar, Color.MediumSpringGreen, 243, 217)
        setBtnProperties2(Calculadora.btnOpDividir, Color.Yellow, 243, 298)
        setBtnProperties2(Calculadora.btnIgual, Color.Snow, 162, 298)
        setBtnProperties2(Calculadora.btnBorrar, Color.Fuchsia, 0, 298)
        Calculadora.BackColor = Color.LightBlue

    End Sub

    Public Sub setMayoresLayout() ' Prepara la disposición y visibilidad de los botones de la calculadora para mayores

        Calculadora.mayoresMenuItem.Enabled = False
        Calculadora.kidsMenuItem.Enabled = True
        Calculadora.oficinaMenuItem.Enabled = True
        Calculadora.AgregarToolStripMenuItem.Enabled = False

        Calculadora.panel2.Visible = False

        Calculadora.txt1.Width = 400
        Calculadora.Size = New Point(435, 440)

        Calculadora.btnOpDecimal.Visible = True
        Calculadora.btnOpRaiz.Visible = True
        Calculadora.btnOpPercent.Visible = True
        Calculadora.btnOpSigno.Visible = True

    End Sub

    Public Sub setKidsLayout() ' Prepara la disposición y visibilidad de los botones de la calculadora para niños

        Calculadora.mayoresMenuItem.Enabled = True
        Calculadora.kidsMenuItem.Enabled = False
        Calculadora.oficinaMenuItem.Enabled = True
        Calculadora.AgregarToolStripMenuItem.Enabled = False

        Calculadora.panel2.Visible = False

        Calculadora.txt1.Width = 318
        Calculadora.Size = New Point(350, 440)

        Calculadora.btnOpDecimal.Visible = False
        Calculadora.btnOpRaiz.Visible = False
        Calculadora.btnOpPercent.Visible = False
        Calculadora.btnOpSigno.Visible = False
    End Sub

    Public Sub setBtnProperties2(ByRef btn As Button, ByVal backColor As Color, ByVal x As Integer, ByVal y As Integer) ' Permite cambiar el color y la localización de un botón
        btn.BackColor = backColor
        btn.Location = New Point(x, y)
    End Sub

    Public Sub setBtnProperties(ByVal id As String, ByVal backColor As Color) ' Permite cambiar el color de una serie de botones indicando la raíz de los mismos
        For Each Control In Calculadora.panel.Controls
            If Control.GetType = GetType(Button) Then
                Dim btn = CType(Control, Button)
                If btn.Name.StartsWith(id) Then
                    btn.BackColor = backColor
                End If
            End If
        Next
    End Sub

    Public Sub setHex(ByVal valor As Boolean) ' Habilitará o desabilitará los botones hexadecimales en función del parámetro que se le pase
        Dim id As String = ""
        Dim letras() As String = {"A", "B", "C", "D", "E", "F"}

        For Each letra In letras 'Recorremos el string de letras
            id = "btn" + letra ' Asignamos a la variable "id" la concatenación de btn + una de las letras del array
            For Each Control In Calculadora.panel2.Controls ' Recorremos los controles del panel 2
                If Control.GetType = GetType(Button) Then ' Si es un botón definimos la variable "btn" como boton
                    Dim btn = CType(Control, Button)
                    If StrComp(btn.Name, id, CompareMethod.Binary) = 0 Then ' Si "btn" comienza por el id definido antes, se habilitará o deshabilitará en función de "valor"
                        btn.Enabled = valor
                    End If
                End If
            Next
        Next
    End Sub

    Public Sub setBinary() ' 

        Dim id As String = ""
        Dim numeros() As Integer = {9, 8, 7, 6, 5, 4, 3, 2}

        setHex(False)

        For Each num In numeros
            id = "btn" + num.ToString
            For Each Control In Calculadora.panel2.Controls
                If Control.GetType = GetType(Button) Then
                    Dim btn = CType(Control, Button)
                    If btn.Name.StartsWith(id) Then
                        btn.Enabled = False
                    End If
                End If
            Next
        Next
    End Sub

    Public Sub setOctal()
        setHex(False)
        setDecimal()
        Calculadora.btn8.Enabled = False
        Calculadora.btn9.Enabled = False

    End Sub

    Public Sub setDecimal()
        Dim id As String = ""
        Dim numeros() As Integer = {9, 8, 7, 6, 5, 4, 3, 2}

        setHex(False)

        For Each num In numeros
            id = "btn" + num.ToString
            For Each Control In Calculadora.panel2.Controls
                If Control.GetType = GetType(Button) Then
                    Dim btn = CType(Control, Button)
                    If btn.Name.StartsWith(id) Then
                        btn.Enabled = True
                    End If
                End If
            Next
        Next
    End Sub

End Module
