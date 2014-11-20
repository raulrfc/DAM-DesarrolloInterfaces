Imports Monopoly.Player
Imports Monopoly.Nuevo
Imports Monopoly.Square


Public Class Tablero
#Region "Variables"
    Dim board As List(Of Square) = New List(Of Square)
    Dim arrImages(5) As Image
    Dim RandGen As Random

    Dim RandIndex As Integer
    Dim time As Integer
    Dim turn As Integer = 1
    Dim playerTurn As Integer = 1
    Dim numPlayers As Integer

    Dim player1 As Player
    Dim player2 As Player
    Dim player3 As Player
    Dim player4 As Player

    Dim currentSquare As Square
    Dim currentPlayer As Player
    Dim targetPlayer As Player
#End Region

#Region "Methods"

    Private Sub getCurrentPlayer()
        If playerTurn = 1 Then
            currentPlayer = player1
        End If
        If playerTurn = 2 Then
            currentPlayer = player2
        End If
        If playerTurn = 3 Then
            currentPlayer = player3
        End If
        If playerTurn = 4 Then
            currentPlayer = player4
        End If
    End Sub

    Private Sub returnStatsToPlayer()
        If playerTurn = 1 Then
            player1 = currentPlayer
        End If
        If playerTurn = 2 Then
            player2 = currentPlayer
        End If
        If playerTurn = 3 Then
            player3 = currentPlayer
        End If
        If playerTurn = 4 Then
            player4 = currentPlayer
        End If
    End Sub

    Private Sub UpdatePlayerStats()

        If playerTurn = 1 Then
            lblPlayer.Text = currentPlayer.getName
            lblP1Pos.Text = currentPlayer.getPosition
            lblP1Cash.Text = currentPlayer.getCash
        End If
        If playerTurn = 2 Then
            lblPlayer.Text = currentPlayer.getName
            lblP2Pos.Text = currentPlayer.getPosition
            lblP2Cash.Text = currentPlayer.getCash
        End If
        If playerTurn = 3 Then
            lblPlayer.Text = currentPlayer.getName
            lblP3Pos.Text = currentPlayer.getPosition
            lblP3Cash.Text = currentPlayer.getCash
        End If
        If playerTurn = 4 Then
            lblPlayer.Text = currentPlayer.getName
            lblP4Pos.Text = currentPlayer.getPosition
            lblP4Cash.Text = currentPlayer.getCash
        End If

    End Sub

    Private Sub JumpAction()
        Dim result As DialogResult
        Select Case currentPlayer.getPosition
            Case 5
                result = MessageBox.Show("Este tranvía te llevará hasta la parada del tranvía Norte, quieres cogerlo?", "Parada del tranvía Sur", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    currentPlayer.move(20)
                End If
            Case 15
                result = MessageBox.Show("Este tranvía te llevará hasta la parada del tranvía Este, quieres cogerlo?", "Parada del tranvía Oeste", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    currentPlayer.move(20)
                End If
            Case 25
                result = MessageBox.Show("Este tranvía te llevará hasta la parada del tranvía Sur, quieres cogerlo?", "Parada del tranvía Norte", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    currentPlayer.move(20)
                End If
            Case 30
                MsgBox("A la carcel")
                currentPlayer.move(20)
            Case 35
                result = MessageBox.Show("Este tranvía te llevará hasta la parada del tranvía Oeste, quieres cogerlo?", "Parada del tranvía Este", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    currentPlayer.move(20)
                End If


        End Select
    End Sub

    Private Sub OtherAction()
        MsgBox("Has encontrado un lugar en el que descansar, tómate un respiro y piensa tus próximos movimientos")
    End Sub

    Private Sub GoAction()
        currentPlayer.setCash(currentPlayer.getCash + 200)
        MsgBox("¡Has pasado por la salida, se te han ingresado 200 € en tu cuenta!")
    End Sub

    Private Sub TaxAction()
        currentPlayer.setCash(currentPlayer.getCash - currentSquare.getPrice())
        ' MsgBox(currentPlayer.getName + " ha pagado un impuesto por valor de " + currentSquare.getPrice)
        UpdatePlayerStats()

    End Sub

    Private Sub StreetAction()
        If (IsNothing(currentSquare.owner)) Then

            btnBuy.Enabled = True
        Else
            targetPlayer = currentSquare.owner
            currentPlayer.setCash(currentPlayer.getCash - currentSquare.getRent())
            targetPlayer.setCash(targetPlayer.getCash + currentSquare.getRent())
            'MsgBox(currentPlayer.getName + " le ha pagado " + currentSquare.getRent + " a " + targetPlayer.getName)
            UpdatePlayerStats()
        End If

    End Sub

    Private Sub checkSquare(ByVal pos As Integer)
        Dim st As SquareType

        currentSquare = board.Item(currentPlayer.getPosition)
        st = currentSquare.getSquareType

        Select Case st
            Case SquareType.STREET
                Panel2.Visible = True
                StreetAction()
            Case SquareType.TAX
                TaxAction()
            Case SquareType.JUMP
                JumpAction()
            Case SquareType.GO
                GoAction()
            Case SquareType.OTHER
                OtherAction()

        End Select
        UpdatePlayerStats()

    End Sub

    Private Sub setSquareColor(ByVal pos As Integer, ByVal col As Color)
        Select Case pos
            Case 1
                rs1.BackColor = col
            Case 3
                rs3.BackColor = col
            Case 6
                rs6.BackColor = col
            Case 8
                rs8.BackColor = col
            Case 9
                rs9.BackColor = col
            Case 11
                rs11.BackColor = col
            Case 12
                rs12.BackColor = col
            Case 13
                rs13.BackColor = col
            Case 14
                rs14.BackColor = col
            Case 16
                rs16.BackColor = col
            Case 18
                rs18.BackColor = col
            Case 19
                rs19.BackColor = col
            Case 21
                rs21.BackColor = col
            Case 23
                rs23.BackColor = col
            Case 24
                rs24.BackColor = col
            Case 26
                rs26.BackColor = col
            Case 27
                rs27.BackColor = col
            Case 28
                rs28.BackColor = col
            Case 29
                rs29.BackColor = col
            Case 31
                rs31.BackColor = col
            Case 32
                rs32.BackColor = col
            Case 34
                rs34.BackColor = col
            Case 37
                rs37.BackColor = col
            Case 39
                rs39.BackColor = col
        End Select
    End Sub

    Private Sub setPlayerLabel(ByVal numP As Integer)
        Select Case numP
            Case 2
                If playerTurn = 1 Then
                    lblPlayer.Text = player1.getName
                End If
                If playerTurn = 2 Then
                    lblPlayer.Text = player2.getName
                End If
            Case 3
                If playerTurn = 1 Then
                    lblPlayer.Text = player1.getName
                End If
                If playerTurn = 2 Then
                    lblPlayer.Text = player2.getName
                End If
                If playerTurn = 3 Then
                    lblPlayer.Text = player3.getName
                End If
            Case 4
                If playerTurn = 1 Then
                    lblPlayer.Text = player1.getName
                End If
                If playerTurn = 2 Then
                    lblPlayer.Text = player2.getName
                End If
                If playerTurn = 3 Then
                    lblPlayer.Text = player3.getName
                End If
                If playerTurn = 4 Then
                    lblPlayer.Text = player4.getName
                End If
        End Select

    End Sub

    Private Sub generateStartLayout()
        generatePlayers()
        generateBoard()
        lblPlayer.Text = player1.getName
        btnStart.Text = "PASAR TURNO"
        btnRolldice.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub endTimer()
        tmrRoll.Enabled = False
        time = 0
        pbDices.Visible = False
        btnStart.Enabled = True
        currentPlayer.move(RandIndex + 1)
        checkSquare(currentPlayer.getPosition)
    End Sub

#End Region

#Region "Generate"

    Private Sub generatePlayers()
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
        board.Add(New Square("Salida", 200, SquareType.GO))
        board.Add(New Square("Sangenis", 50, SquareType.STREET))
        board.Add(New Square("Caja de comunidad", 0, SquareType.CHEST))
        board.Add(New Square("Monte Perdido", 50, SquareType.STREET))
        board.Add(New Square("Impuesto sobre capital", 200, SquareType.TAX))
        board.Add(New Square("Tranvía Sur", 0, SquareType.JUMP))
        board.Add(New Square("Ávila", 100, SquareType.STREET))
        board.Add(New Square("Suerte", 0, SquareType.LUCKY))
        board.Add(New Square("Lugo", 100, SquareType.STREET))
        board.Add(New Square("San Juan de la Peña", 120, SquareType.STREET))
        board.Add(New Square("Cárcel", 0, SquareType.JAIL))
        board.Add(New Square("Avenida Valencia", 140, SquareType.STREET))
        board.Add(New Square("Compañía eléctrica", 160, SquareType.STREET))
        board.Add(New Square("Avenida Navarra", 140, SquareType.STREET))
        board.Add(New Square("Valle de broto", 160, SquareType.STREET))
        board.Add(New Square("Tranvía Oeste", 0, SquareType.JUMP))
        board.Add(New Square("Salvador Allende", 180, SquareType.STREET))
        board.Add(New Square("Caja de Comunidad", 0, SquareType.CHEST))
        board.Add(New Square("Miguel Servet", 180, SquareType.STREET))
        board.Add(New Square("Avenida San José", 200, SquareType.STREET))
        board.Add(New Square("Parking gratuito", 0, SquareType.OTHER))
        board.Add(New Square("Avenida Madrid", 220, SquareType.STREET))
        board.Add(New Square("Suerte", 0, SquareType.LUCKY))
        board.Add(New Square("Isabel la católica", 220, SquareType.STREET))
        board.Add(New Square("Avenida América", 240, SquareType.STREET))
        board.Add(New Square("Tranvía Norte", 0, SquareType.JUMP))
        board.Add(New Square("Vía Hispanidad", 260, SquareType.STREET))
        board.Add(New Square("Conde Aranda", 260, SquareType.STREET))
        board.Add(New Square("Compañía de aguas", 160, SquareType.STREET))
        board.Add(New Square("Paseo Constitución", 280, SquareType.STREET))
        board.Add(New Square("Ve a la carcel", 0, SquareType.JUMP))
        board.Add(New Square("Coso", 300, SquareType.STREET))
        board.Add(New Square("Paseo Sagasta", 300, SquareType.STREET))
        board.Add(New Square("Caja de comunidad", 0, SquareType.CHEST))
        board.Add(New Square("Avenida Ruiz Picasso", 330, SquareType.STREET))
        board.Add(New Square("Tranvía Este", 0, SquareType.JUMP))
        board.Add(New Square("Suerte", 0, SquareType.LUCKY))
        board.Add(New Square("Gran Vía", 350, SquareType.STREET))
        board.Add(New Square("Impuesto de lujo", 300, SquareType.TAX))
        board.Add(New Square("Paseo Independencia", 400, SquareType.STREET))

    End Sub

#End Region

#Region "Buttons"

    Private Sub rollDice_Click(sender As Object, e As EventArgs) Handles btnRolldice.Click
        RandGen = New Random(Now.Millisecond)
        RandIndex = RandGen.Next(0, 6)
        btnRolldice.Enabled = False
        tmrRoll.Enabled = True
        pbDices.Visible = True

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If btnStart.Text = "PASAR TURNO" Then
            returnStatsToPlayer()
            If playerTurn < numPlayers Then

                playerTurn += 1
                setPlayerLabel(numPlayers)
                btnRolldice.Enabled = True
                btnStart.Enabled = False
                getCurrentPlayer()
            Else

                turn += 1
                lblTurn.Text = turn
                playerTurn = 1
                setPlayerLabel(numPlayers)
                btnRolldice.Enabled = True
                btnStart.Enabled = False
                getCurrentPlayer()
            End If
        End If

        If btnStart.Text = "EMPEZAR" Then
            generateStartLayout()
            getCurrentPlayer()
        End If
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        currentPlayer.addProperty(currentSquare)
        currentPlayer.setCash(currentPlayer.getCash - currentSquare.getPrice)
        MsgBox("La propiedad " + currentSquare.getName + " ahora es del jugador " + currentPlayer.getName)
        setSquareColor(currentPlayer.getPosition, currentPlayer.getColor)
        currentSquare.owner = currentPlayer
        btnBuy.Enabled = False
        Panel2.Visible = False
        UpdatePlayerStats()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel2.Visible = False
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

    Private Sub passTurn(ByVal numP As Integer)

        getCurrentPlayer()

        Select Case numP
            Case 2
                If playerTurn = 1 Then
                    lblPlayer.Text = currentPlayer.getName
                    currentPlayer.move(RandIndex + 1)
                    lblP1Pos.Text = currentPlayer.getPosition
                    checkSquare(currentPlayer.getPosition)
                    lblP1Cash.Text = currentPlayer.getCash
                    Panel2.Visible = True
                End If
                If playerTurn = 2 Then
                    lblPlayer.Text = player2.getName
                    player2.move(RandIndex + 1)
                    lblP2Pos.Text = player2.getPosition
                    lblP2Cash.Text = player2.getCash
                End If
            Case 3
                If playerTurn = 1 Then
                    lblPlayer.Text = player1.getName
                    player1.move(RandIndex + 1)
                    lblP1Pos.Text = player1.getPosition
                    lblP1Cash.Text = player1.getCash
                End If
                If playerTurn = 2 Then
                    lblPlayer.Text = player2.getName
                    player2.move(RandIndex + 1)
                    lblP2Pos.Text = player2.getPosition
                    lblP2Cash.Text = player2.getCash
                End If
                If playerTurn = 3 Then
                    lblPlayer.Text = player3.getName
                    player3.move(RandIndex + 1)
                    lblP3Pos.Text = player3.getPosition
                    lblP3Cash.Text = player3.getCash
                End If
            Case 4
                If playerTurn = 1 Then
                    lblPlayer.Text = player1.getName
                    player1.move(RandIndex + 1)
                    lblP1Pos.Text = player1.getPosition
                    lblP1Cash.Text = player1.getCash
                End If
                If playerTurn = 2 Then
                    lblPlayer.Text = player2.getName
                    player2.move(RandIndex + 1)
                    lblP2Pos.Text = player2.getPosition
                    lblP2Cash.Text = player2.getCash
                End If
                If playerTurn = 3 Then
                    lblPlayer.Text = player3.getName
                    player3.move(RandIndex + 1)
                    lblP3Pos.Text = player3.getPosition
                    lblP3Cash.Text = player3.getCash
                End If
                If playerTurn = 4 Then
                    lblPlayer.Text = player4.getName
                    player4.move(RandIndex + 1)
                    lblP4Pos.Text = player4.getPosition
                    lblP4Cash.Text = player4.getCash
                End If
        End Select

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
            endTimer()
            ' passTurn(numPlayers)

        End If
    End Sub
#End Region
  

    
    
End Class
