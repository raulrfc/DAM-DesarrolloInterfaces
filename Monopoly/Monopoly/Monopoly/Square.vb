Public Class Square
    Dim name As String
    Dim houseNum As Integer
    Dim hotel As Boolean = False
    Dim price As Integer
    Dim rent As Integer
    Dim housePrice As Integer
    Dim hotelPrice As Integer

    Private Function setRent() As Integer
        If hotel = False Then
            rent = price + price * (houseNum * 20 / 100)
        Else
            rent = price + price * 1.2
        End If
        Return rent
    End Function

End Class
