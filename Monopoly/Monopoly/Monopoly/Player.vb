Imports Monopoly.Tablero

Public Class Player
    Dim name As String
    Dim color As Color
    Dim cash As Integer
    Dim properties As List(Of Square)
    Dim position As Integer = 0

    Sub New(ByVal name As String, ByVal color As Color, ByVal cash As Integer)
        Me.name = name
        Me.color = color
        Me.cash = cash
    End Sub

    Public Sub move(ByVal value As Integer)
        Me.position += value
    End Sub

    Public Function getName()
        Return Me.name
    End Function

    Public Function getColor()
        Return Me.color
    End Function

    Public Function getCash()
        Return Me.cash
    End Function

    Public Function getProperties()
        Return Me.properties
    End Function

    Public Function getPosition()
        Return Me.position
    End Function
End Class
