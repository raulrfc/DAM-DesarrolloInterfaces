Imports AdvancedTextEditor.AdvancedTextEditor

Public Class Buscar
    Dim start As Integer = 0 ' Posición de inicio
    Dim indexOfSearchText As Integer = 0 ' Posición de búsqueda
    Dim rtb As RichTextBox = AdvancedTextEditor.GetCurrentDocument
    Dim col As Color

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim startindex As Integer = 0

        If txt1.Text.Length > 0 Then
            startindex = FindMyText(txt1.Text.Trim(), start, rtb.Text.Length)
        End If

        ' Si el string se encuentra en el texto lo ilumina
        If startindex >= 0 Then
            ' Encuentra el índice final (número de caracteres en el rtb)
            Dim endindex As Integer = txt1.Text.Length
            ' Se posiciona en el string seleccionado
            rtb.Select(startindex, endindex)
            ' Cambia el color a rojo
            col = rtb.SelectionBackColor
            rtb.SelectionBackColor = Color.Red
            ' Marca la posicion de inicio tras la posicion del ultimo string buscado
            start = startindex + endindex
        Else
            start = 0
            indexOfSearchText = 0
        End If
    End Sub

    Public Function FindMyText(ByVal txtToSearch As String, ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer
        ' Deselecciona el último string 
        If searchStart > 0 AndAlso searchEnd > 0 AndAlso indexOfSearchText >= 0 Then

            rtb.SelectionBackColor = col
            start = 0
            indexOfSearchText = 0
        End If

        ' Setea el valor de retorno a -1 por defecto
        Dim retVal As Integer = -1


        ' Si el indexOfSearchText = -1, es el final de la búsqueda
        If searchStart >= 0 AndAlso indexOfSearchText >= 0 Then

            If searchEnd > searchStart OrElse searchEnd = -1 Then
                ' Encuentra la posicion del string buscado en el rtb
                indexOfSearchText = rtb.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None)
                ' Determina cuando el texto ha sido encontrado
                If indexOfSearchText <> -1 Then
                    ' Devuelve el indice del texto especificado
                    retVal = indexOfSearchText
                End If
            End If
        End If
        Return retVal
    End Function
    ' Si la palabra a buscar cambia, se reinician los contadores
    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        start = 0
        indexOfSearchText = 0
    End Sub
    ' Método para reemplazar
    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click

        rtb.SelectionBackColor = col
        rtb.SelectedText = rtb.SelectedText.Replace(txt1.Text, txt2.Text)
        If (txt2.Text.Length < txt1.Text.Length) Then
            indexOfSearchText -= (txt1.Text.Length - txt2.Text.Length)
        End If

    End Sub
    ' Opciones personalizadas aplicadas al cargar el formulario
    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt1.AutoSize = False
        txt2.AutoSize = False
        txt1.Size = New Point(143, 37)
        txt2.Size = New Point(143, 37)
    End Sub
    ' Cuando se pulse sobre el botón de cerrar se desharán los cambios 
    Private Sub Form2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        rtb.SelectionBackColor = col
    End Sub

    Private Sub replaceALL_Click(sender As Object, e As EventArgs) Handles replaceALL.Click
        Dim i As Integer = 0
        Dim lon As Integer = rtb.TextLength
        For i = 0 To lon

            rtb.Find(txt1.Text, i, rtb.TextLength, RichTextBoxFinds.None)
            If (rtb.SelectedText.Length = 0) Then
                Return
            End If

            rtb.SelectedText = rtb.SelectedText.Replace(txt1.Text, txt2.Text)
            lon = rtb.TextLength
        Next
    End Sub
End Class