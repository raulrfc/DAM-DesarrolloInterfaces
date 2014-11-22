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

    Public Function getRentInfo(ByVal numHouses As Integer) As Integer
        Dim rentInfo As Integer
        Select Case numHouses
            Case 1
                rentInfo = price + price * (numHouses * 20 / 100)
            Case 2
                rentInfo = price + price * (numHouses * 20 / 100)
            Case 3
                rentInfo = price + price * (numHouses * 20 / 100)
            Case 4
                rentInfo = price + price * (numHouses * 20 / 100)
            Case 5
                rentInfo = price + price * 1.2
        End Select
        Return rentInfo
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

    Public Function getHouseNum() As Integer
        Return houseNum
    End Function

    Public Sub showInfo(ByVal txt As TextBox)
        txt.Text = name & Environment.NewLine & "Alquileres" & Environment.NewLine & "Base: " & getRentInfo(0).ToString & Environment.NewLine & "1 Casa: " & getRentInfo(1).ToString & Environment.NewLine & "2 Casas: " & getRentInfo(2).ToString & Environment.NewLine & "3 Casas: " & getRentInfo(3).ToString & Environment.NewLine & "4 Casas: " & getRentInfo(4).ToString & Environment.NewLine & "Hotel: " & getRentInfo(5).ToString & Environment.NewLine & "PRECIO: " & price
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
