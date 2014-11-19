Imports Monopoly.Player
Imports Monopoly.Nuevo
Imports Monopoly.Square


Public Class Tablero
#Region "Variables"
    Dim arrImages(5) As Image
    Dim RandGen As Random
    Dim RandIndex As Integer
    Dim time As Integer
    Dim turn As Integer = 1
    Dim player1 As Player
    Dim player2 As Player
    Dim player3 As Player
    Dim player4 As Player
#End Region
   
#Region "Generate"
    Private Sub generatePlayers()
        Dim numPlayers As Integer

        numPlayers = Cfg.numPlayers

        Select Case numPlayers
            Case 2
                player1 = New Player(Cfg.player1.getName, Cfg.player1.getColor, Cfg.player1.getCash)
                player2 = New Player(Cfg.player2.getName, Cfg.player2.getColor, Cfg.player2.getCash)
            Case 3
                player1 = New Player(Cfg.player1.getName, Cfg.player1.getColor, Cfg.player1.getCash)
                player2 = New Player(Cfg.player2.getName, Cfg.player2.getColor, Cfg.player2.getCash)
                player3 = New Player(Cfg.player3.getName, Cfg.player3.getColor, Cfg.player3.getCash)
            Case 4
                player1 = New Player(Cfg.player1.getName, Cfg.player1.getColor, Cfg.player1.getCash)
                player2 = New Player(Cfg.player2.getName, Cfg.player2.getColor, Cfg.player2.getCash)
                player3 = New Player(Cfg.player3.getName, Cfg.player3.getColor, Cfg.player3.getCash)
                player4 = New Player(Cfg.player4.getName, Cfg.player4.getColor, Cfg.player4.getCash)
        End Select
    End Sub

    Private Sub generateBoard()
        Dim board As List(Of Square) = New List(Of Square)

        board.Add(New Square("Salida", 0))
        board.Add(New Square("Sangenis", 50))
        board.Add(New Square("Caja de comunidad", 0))
        board.Add(New Square("Monte Perdido", 50))
        board.Add(New Square("Impuesto sobre capital", 200))
        board.Add(New Square("Tranvía Sur", 0))
        board.Add(New Square("Ávila", 100))
        board.Add(New Square("Suerte", 50))
        board.Add(New Square("Lugo", 100))
        board.Add(New Square("San Juan de la Peña", 120))
        board.Add(New Square("Cárcel", 0))
        board.Add(New Square("Avenida Valencia", 140))
        board.Add(New Square("Compañía eléctrica", 160))
        board.Add(New Square("Avenida Navarra", 140))
        board.Add(New Square("Valle de broto", 160))
        board.Add(New Square("Tranvía Oeste", 0))
        board.Add(New Square("Salvador Allende", 180))
        board.Add(New Square("Caja de Comunidad", 0))
        board.Add(New Square("Miguel Servet", 180))
        board.Add(New Square("Avenida San José", 200))
        board.Add(New Square("Parking gratuito", 0))
        board.Add(New Square("Avenida Madrid", 220))
        board.Add(New Square("Suerte", 0))
        board.Add(New Square("Isabel la católica", 220))
        board.Add(New Square("Avenida América", 240))
        board.Add(New Square("Tranvía Norte", 0))
        board.Add(New Square("Vía Hispanidad", 260))
        board.Add(New Square("Conde Aranda", 260))
        board.Add(New Square("Compañía de aguas", 160))
        board.Add(New Square("Paseo Constitución", 280))
        board.Add(New Square("Ve a la carcel", 0))
        board.Add(New Square("Coso", 300))
        board.Add(New Square("Paseo Sagasta", 300))
        board.Add(New Square("Caja de comunidad", 0))
        board.Add(New Square("Avenida Ruiz Picasso", 330))
        board.Add(New Square("Tranvía Este", 0))
        board.Add(New Square("Gran Vía", 350))
        board.Add(New Square("Impuesto de lujo", 200))
        board.Add(New Square("Paseo Independencia", 400))

    End Sub
#End Region

#Region "Buttons"

    Private Sub rollDice_Click(sender As Object, e As EventArgs) Handles btnRolldice.Click
        RandGen = New Random(Now.Millisecond)
        RandIndex = RandGen.Next(0, 6)
        tmrRoll.Enabled = True
        pbDices.Visible = True

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If turn = 1 Then
            generatePlayers()
            lblPlayer.Text = player1.getName
            btnStart.Text = "Pasar turno"
            btnRolldice.Enabled = True
            btnStart.Enabled = False
        Else

        End If
    End Sub
#End Region
    
#Region "General"
    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrImages(0) = My.Resources.dice1
        arrImages(1) = My.Resources.dice2
        arrImages(2) = My.Resources.dice3
        arrImages(3) = My.Resources.dice4
        arrImages(4) = My.Resources.dice5
        arrImages(5) = My.Resources.dice6
        pbDices.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRoll.Tick
        Dim result As Integer = RandGen.Next(0, 6)

        time += 1

        If time < 15 Then
            For i = 0 To 6
                pbDices.Image = arrImages(result)
            Next i
        End If
        If time = 15 Then
            pbDices.Image = arrImages(RandIndex)
        End If
        If time = 25 Then
            tmrRoll.Enabled = False
            time = 0
            pbDices.Visible = False
            player1.move(RandIndex + 1)
            Label3.Text = player1.getPosition
            btnRolldice.Enabled = False
            btnStart.Enabled = True

        End If
    End Sub
#End Region
  

End Class
