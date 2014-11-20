Public Class Square
    Public name As String
    Public houseNum As Integer = 0
    Public hotel As Boolean = False
    Public price As Integer
    Public rent As Integer
    Public housePrice As Integer = 0
    Public hotelPrice As Integer = 0
    Public owner As Player
    Public squareType As SquareType

    Sub New(ByVal name As String, ByVal price As Integer, ByVal squareType As SquareType)
        Me.name = name
        Me.price = price
        Me.squareType = squareType
    End Sub

    Public Function getRent() As Integer
        If hotel = False Then
            Me.rent = price + price * (houseNum * 20 / 100)
        Else
            Me.rent = price + price * 1.2
        End If
        Return Me.rent
    End Function

    Public Function getSquareType() As SquareType
        Return Me.squareType
    End Function

    Public Function getPrice() As Integer
        Return Me.price
    End Function

    Public Function getName() As String
        Return name
    End Function

    Public Sub showInfo(ByVal txt As TextBox)
        txt.Text = name + "\n Número de casas: \n 1 casa: " + housePrice
    End Sub

End Class

Public Enum SquareType
    STREET
    TAX
    LUCKY
    CHEST
    JUMP
    GO
    JAIL
    OTHER
End Enum
