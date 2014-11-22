Imports Monopoly.Tablero

Public Class Player
    Dim name As String
    Dim color As Color
    Dim cash As Integer
    Dim position As Integer = 0
    Dim jail As Boolean = False
    Dim jailTime As Integer = 0

    Sub New(ByVal name As String, ByVal color As Color, ByVal cash As Integer)
        Me.name = name
        Me.color = color
        Me.cash = cash
    End Sub

    Public Sub move(ByVal value As Integer)
        Dim overpos As Integer
        If position + value > 40 Then
            overpos = (position + value) - 40
            MsgBox("Has pasado por la casilla de salida, recibes una bonificación de 200 €")
            cash = cash + 200
            position = 0
            position = position + overpos
        Else
            Me.position += value
        End If

    End Sub
    Public Function getJailTime()
        Return Me.jailTime
    End Function
    Public Function getJail()
        Return Me.jail
    End Function
    Public Function getName()
        Return Me.name
    End Function

    Public Function getColor()
        Return Me.color
    End Function

    Public Function getCash()
        Return Me.cash
    End Function

    Public Function getPosition()
        Return Me.position
    End Function

    Public Sub setCash(ByVal value As Integer)
        Me.cash = value
    End Sub

    Public Sub setJail(jail As Boolean)
        Me.jail = jail
    End Sub
    Public Sub setJailTime()
        If jailTime < 2 Then
            Me.jailTime += 1
        Else
            Me.jailTime = 0
        End If

    End Sub
    Public Sub setPosition(ByVal pos As Integer)
        Me.position = pos
    End Sub

End Class
