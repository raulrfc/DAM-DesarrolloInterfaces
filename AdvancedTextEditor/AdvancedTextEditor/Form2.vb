Imports AdvancedTextEditor.AdvancedTextEditor

Public Class Buscar
    Dim start As Integer = 0
    Dim indexOfSearchText As Integer = 0
    Dim rtb As RichTextBox = AdvancedTextEditor.GetCurrentDocument

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim startindex As Integer = 0

        If txt1.Text.Length > 0 Then
            startindex = FindMyText(txt1.Text.Trim(), start, rtb.Text.Length)
        End If

        ' If string was found in the RichTextBox, highlight it
        If startindex >= 0 Then
            ' Set the highlight color as red
            rtb.SelectionColor = Color.Red
            ' Find the end index. End Index = number of characters in textbox
            Dim endindex As Integer = txt1.Text.Length
            ' Highlight the search string
            rtb.Select(startindex, endindex)
            ' mark the start position after the position of
            ' last search string
            start = startindex + endindex
        End If
    End Sub

    Public Function FindMyText(ByVal txtToSearch As String, ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer
        ' Unselect the previously searched string
        If searchStart > 0 AndAlso searchEnd > 0 AndAlso indexOfSearchText >= 0 Then
            rtb.Undo()
            start = 0
            indexOfSearchText = 0
        End If

        ' Set the return value to -1 by default.
        Dim retVal As Integer = -1

        ' A valid starting index should be specified.
        ' if indexOfSearchText = -1, the end of search
        If searchStart >= 0 AndAlso indexOfSearchText >= 0 Then
            ' A valid ending index
            If searchEnd > searchStart OrElse searchEnd = -1 Then
                ' Find the position of search string in RichTextBox
                indexOfSearchText = rtb.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None)
                ' Determine whether the text was found in richTextBox1.
                If indexOfSearchText <> -1 Then
                    ' Return the index to the specified search text.
                    retVal = indexOfSearchText
                End If
            End If
        End If
        Return retVal
    End Function

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        start = 0
        indexOfSearchText = 0
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Dim startindex As Integer = 0
        
        If txt1.Text.Length > 0 Then
            startindex = FindMyText(txt1.Text.Trim(), start, rtb.Text.Length)


        End If
        rtb.SelectedText = rtb.SelectedText.Replace(txt1.Text, txt2.Text)
     
    End Sub

    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt1.AutoSize = False
        txt2.AutoSize = False
        txt1.Size = New Point(143, 37)
        txt2.Size = New Point(143, 37)
    End Sub
End Class