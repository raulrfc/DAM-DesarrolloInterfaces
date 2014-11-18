Imports Monopoly.Player
Imports Monopoly.Nuevo
Imports Monopoly.Square


Public Class Tablero
    Dim turn As Integer = 1

    Private Sub rollDice_Click(sender As Object, e As EventArgs) Handles rollDice.Click
        MsgBox(Cfg.difficulty)
        MsgBox(Cfg.player1.getCash)
        MsgBox(Cfg.player1.getName)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo.Show()
    End Sub

    

   
End Class
