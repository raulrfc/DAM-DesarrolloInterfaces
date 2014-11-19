Public Class Square
    Dim name As String
    Dim houseNum As Integer = 0
    Dim hotel As Boolean = False
    Dim price As Integer
    Dim rent As Integer
    Dim housePrice As Integer = 0
    Dim hotelPrice As Integer = 0
    Dim owner As Player

    Sub New(ByVal name As String, ByVal price As Integer)
        Me.name = name
        Me.price = price
    End Sub

    Private Function setRent() As Integer
        If hotel = False Then
            rent = price + price * (houseNum * 20 / 100)
        Else
            rent = price + price * 1.2
        End If
        Return rent
    End Function

    Private Sub showInfo()

    End Sub

End Class
