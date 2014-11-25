Imports Monopoly.Player
Imports Monopoly.Nuevo
Imports Monopoly.Square
Imports System.Drawing.Text


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

    Dim leavingSquare As Square
    Dim currentSquare As Square
    Dim currentPlayer As Player
    Dim targetPlayer As Player
#End Region

#Region "Methods"
    Private Sub movePicLogic(ByVal b As Button)
        If currentSquare.numPlayers = 0 Then
            b.Location = New Point(currentSquare.x, currentSquare.y)
        ElseIf currentSquare.numPlayers = 1 Then
            b.Location = New Point(currentSquare.x, currentSquare.y - 25)
        ElseIf currentSquare.numPlayers = 2 Then
            b.Location = New Point(currentSquare.x + 25, currentSquare.y)
        ElseIf currentSquare.numPlayers = 3 Then
            b.Location = New Point(currentSquare.x + 25, currentSquare.y - 25)
        End If
    End Sub

    Private Sub movePictures()
        If playerTurn = 1 Then
            movePicLogic(P1)
        End If
        If playerTurn = 2 Then
            movePicLogic(P2)
        End If
        If playerTurn = 3 Then
            movePicLogic(P3)
        End If
        If playerTurn = 4 Then
            movePicLogic(P4)
        End If
    End Sub

    Private Sub getCurrentPlayer()
        If playerTurn = 1 Then
            currentPlayer = player1
            checkJail()
        End If
        If playerTurn = 2 Then
            currentPlayer = player2
            checkJail()

        End If
        If playerTurn = 3 Then
            currentPlayer = player3
            checkJail()

        End If
        If playerTurn = 4 Then
            currentPlayer = player4
            checkJail()

        End If
    End Sub

    Private Sub UpdatePlayerStats()
        If playerTurn = 1 Then
            lblPlayer1.ForeColor = player1.getColor
            lblP1Pos.ForeColor = player1.getColor
            lblP1Cash.ForeColor = player1.getColor
            lblPlayer1.Text = currentPlayer.getName
            lblP1Pos.Text = currentPlayer.getPosition
            lblP1Cash.Text = currentPlayer.getCash
        End If
        If playerTurn = 2 Then
            lblPlayer2.ForeColor = player2.getColor
            lblP2Pos.ForeColor = player2.getColor
            lblP2Cash.ForeColor = player2.getColor
            lblPlayer2.Text = currentPlayer.getName
            lblP2Pos.Text = currentPlayer.getPosition
            lblP2Cash.Text = currentPlayer.getCash
        End If
        If playerTurn = 3 Then
            lblPlayer3.ForeColor = player3.getColor
            lblP3Pos.ForeColor = player3.getColor
            lblP3Cash.ForeColor = player3.getColor
            lblPlayer3.Text = currentPlayer.getName
            lblP3Pos.Text = currentPlayer.getPosition
            lblP3Cash.Text = currentPlayer.getCash
        End If
        If playerTurn = 4 Then
            lblPlayer4.ForeColor = player4.getColor
            lblP4Pos.ForeColor = player4.getColor
            lblP4Cash.ForeColor = player4.getColor
            lblPlayer4.Text = currentPlayer.getName
            lblP4Pos.Text = currentPlayer.getPosition
            lblP4Cash.Text = currentPlayer.getCash
        End If
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

    Private Sub setPlayerLabel()

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
        leavingSquare = board.Item(currentPlayer.getPosition)
        leavingSquare.numPlayers -= 1
        tmrRoll.Enabled = False
        time = 0
        pbDices.Visible = False
        btnStart.Enabled = True
        currentPlayer.move(RandIndex + 1)
        checkSquare(currentPlayer.getPosition)

    End Sub

#End Region

#Region "Squares"

    Private Sub checkJail()
        Dim jailedPlayer As Player
        jailedPlayer = currentPlayer
        If currentPlayer.getJail = True Then
            If currentPlayer.getJailTime < 2 Then
                movePictures()
                If playerTurn < numPlayers Then
                    playerTurn += 1
                Else
                    playerTurn = 1
                End If
                setPlayerLabel()
                currentPlayer.setJailTime()
                getCurrentPlayer()
                UpdatePlayerStats()
                MsgBox(jailedPlayer.getName + " está en la cárcel, es el turno del jugador " + currentPlayer.getName)
                btnRolldice.Enabled = True
            Else
                MsgBox(jailedPlayer.getName + "ha salido de la cárcel")
                currentPlayer.setJailTime()
                currentPlayer.setJail(False)
            End If

        End If
    End Sub

    Private Sub checkHouses()
        Dim result As DialogResult

        If currentSquare.houseNum < 4 Then
            result = MessageBox.Show("Tienes " + currentSquare.houseNum.ToString + " casas, ¿quieres comprar una casa por " + currentSquare.getRent.ToString() + "€ ?", currentSquare.getName, MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                currentPlayer.setCash(currentPlayer.getCash - currentSquare.getRent)
                currentSquare.houseNum += 1
            Else

            End If
        ElseIf currentSquare.houseNum = 4 Then
            result = MessageBox.Show("Tienes " + currentSquare.houseNum.ToString + " casas, ¿quieres comprar un hotel por " + currentSquare.getRent.ToString() + "€ ?", currentSquare.getName, MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                currentPlayer.setCash(currentPlayer.getCash - currentSquare.getRent)
                currentSquare.houseNum += 1
                currentSquare.hotel = True
            Else

            End If
        Else


        End If

    End Sub

    Private Sub LuckyAction()
        Dim result As DialogResult
        Dim luck As Integer

        luck = RandGen.Next(1, 10)

        Select Case luck

            Case 1
                MsgBox("Avanza hasta la casilla de salida")
                currentPlayer.setPosition(0)
            Case 2
                MsgBox("Retrocede 3 casillas")
                currentPlayer.setPosition(currentPlayer.getPosition - 3)
            Case 3
                MsgBox("Necesitas un descanso, ve al parking gratuito")
                currentPlayer.setPosition(20)
            Case 4
                MsgBox("Has entrado en un agujero negro, tu destino es un misterio")
                currentPlayer.setPosition(RandGen.Next(1, 40))
            Case 5
                MsgBox("Ve a la carcel, eres un delincuente")
                currentPlayer.setPosition(10)
                currentPlayer.setJail(True)
            Case 6
                MessageBox.Show("Te has encontrado un cofre, ¿quieres abrirlo?", "Suerte", MessageBoxButtons.YesNo)

                If result = Windows.Forms.DialogResult.Yes Then
                    MsgBox("El cofre contenía joyas por valor de 150 €, ¡enhorabuena!")
                    currentPlayer.setCash(currentPlayer.getCash + 150)
                Else
                    MsgBox("Dejas el cofre donde estaba")
                End If
            Case 7
                MsgBox("Ve al Paseo Independencia")
                currentPlayer.setPosition(39)
            Case 8
                MsgBox("Monopoly es un juego para disfrutar con los amigos, no os enfadéis y dale un abrazo a tus compañeros de juego")
                MsgBox(":)")
            Case 9
                MsgBox("Retrocede 10 casillas")
                If currentPlayer.getPosition - 10 < 0 Then
                    currentPlayer.setPosition(37)
                Else
                    currentPlayer.setPosition(currentPlayer.getPosition - 10)
                End If

            Case 10
                MessageBox.Show("Toma la pastilla azul y todo terminará, volverás a donde estabas; toma la pastilla roja y verás hasta donde llega la madriguera del conejo | AZUL(YES) ROJA(NO)", "Suerte", MessageBoxButtons.YesNo)

                If result = Windows.Forms.DialogResult.Yes Then
                    MsgBox("Tu mundo permanece inalterado")
                Else
                    Dim x As Integer = RandGen.Next(100, 500)
                    MsgBox("Has visto lugares que nadie más conoce, en tu viaje has amasado una fortuna de " + x + " €")
                    currentPlayer.setCash(currentPlayer.getCash + x)
                End If

        End Select
        currentSquare = board.Item(currentPlayer.getPosition)
        movePictures()
    End Sub

    Private Sub ChestAction()
        Dim chest As Integer

        chest = RandGen.Next(1, 10)

        Select Case chest

            Case 1
                MsgBox("Gracias a las ayudas a la comunidad los vecinos han donado 50 € a tu causa")
                currentPlayer.setCash(currentPlayer.getCash + 50)
            Case 2
                MsgBox("Tus inversiones en bolsa han dado sus frutos, has ganado 300 €")
                currentPlayer.setCash(currentPlayer.getCash + 300)
            Case 3
                MsgBox("Tu visión innovadora te ha dado el primer premio del concurso de Innovate Or Die, has ganado 150 €")
                currentPlayer.setCash(currentPlayer.getCash + 150)
            Case 4
                MsgBox("Te has encontrado el tesoro de un pirata, contiene 200 € en monedas de oro. YARR")
                currentPlayer.setCash(currentPlayer.getCash + 200)
            Case 5
                MsgBox("Has salvado al mundo de la invasión alienigena en una heróica misión suicida, los gobiernos del mundo te han dado las gracias")
            Case 6
                MsgBox("Has completado la maratón de Nueva York, enhorabuena, estás en buena forma")
            Case 7
                MsgBox("Los sobornos al gobierno para recibir ayudas te han costado 150 €")
                currentPlayer.setCash(currentPlayer.getCash - 150)
            Case 8
                MsgBox("El ruido de tus disparos jugando al Battlefield ha hecho que los militares bombardeen tu casa. Los daños ascienden a 300 €")
                currentPlayer.setCash(currentPlayer.getCash - 300)
            Case 9
                MsgBox("Tu coche ha pinchado, mientras cambiabas la rueda te ha mordido una serpiente y un pájaro hizo sus deposiciones sobre tu cara gabardina, 200 €")
                currentPlayer.setCash(currentPlayer.getCash - 200)
            Case 10
                MsgBox("Te han atracado, eres un tio con mala suerte, se han llevado 50 €, también eres pobre...")
                currentPlayer.setCash(currentPlayer.getCash - 50)

        End Select

    End Sub

    Private Sub JailAction()
        Dim result As DialogResult

        currentPlayer.setJail(True)

        MsgBox("Estás en la carcel, puedes permanecer aquí durante 2 turnos o pagar 200 € de fianza")

        result = MessageBox.Show("¿Quieres pagar la fianza?", "Carcel", MessageBoxButtons.YesNo)

        If result = Windows.Forms.DialogResult.Yes Then
            currentPlayer.setCash(currentPlayer.getCash - 200)
            currentPlayer.setJail(False)
        Else
            checkJail()
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
        currentSquare = board.Item(currentPlayer.getPosition)
        movePictures()
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
        MsgBox(currentPlayer.getName + " ha pagado un impuesto por valor de " + currentSquare.getPrice.ToString)
        UpdatePlayerStats()

    End Sub

    Private Sub StreetAction()
        If (IsNothing(currentSquare.owner)) Then
            btnBuy.Enabled = True
        Else
            targetPlayer = currentSquare.owner
            If currentPlayer.getName = targetPlayer.getName Then
                checkHouses()
            Else
                currentPlayer.setCash(currentPlayer.getCash - currentSquare.getRent())
                targetPlayer.setCash(targetPlayer.getCash + currentSquare.getRent())
                MsgBox(currentPlayer.getName + " le ha pagado " + currentSquare.getRent.ToString + " a " + targetPlayer.getName)
            End If

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
                currentSquare.showInfo(txtInfo)
                StreetAction()
            Case SquareType.TAX
                TaxAction()
            Case SquareType.JUMP
                JumpAction()
            Case SquareType.GO
                GoAction()
            Case SquareType.OTHER
                OtherAction()
            Case SquareType.JAIL
                JailAction()
            Case SquareType.CHEST
                ChestAction()
            Case SquareType.LUCKY
                LuckyAction()

        End Select
        UpdatePlayerStats()

    End Sub
#End Region

#Region "Generate"

    Private Sub generatePlayers()
        numPlayers = Cfg.numPlayers
      
        Select Case numPlayers
            Case 2
                player1 = New Player(Cfg.player1.getName, Cfg.player1.getColor, Cfg.player1.getCash)
                P1.BackColor = player1.getColor
                P1.Visible = True
                player2 = New Player(Cfg.player2.getName, Cfg.player2.getColor, Cfg.player2.getCash)
                P2.BackColor = player2.getColor
                P2.Visible = True
            Case 3
                player1 = New Player(Cfg.player1.getName, Cfg.player1.getColor, Cfg.player1.getCash)
                P1.BackColor = player1.getColor
                P1.Visible = True
                player2 = New Player(Cfg.player2.getName, Cfg.player2.getColor, Cfg.player2.getCash)
                P2.BackColor = player2.getColor
                P2.Visible = True
                player3 = New Player(Cfg.player3.getName, Cfg.player3.getColor, Cfg.player3.getCash)
                P3.BackColor = player3.getColor
                P3.Visible = True
            Case 4
                player1 = New Player(Cfg.player1.getName, Cfg.player1.getColor, Cfg.player1.getCash)
                P1.BackColor = player1.getColor
                P1.Visible = True
                player2 = New Player(Cfg.player2.getName, Cfg.player2.getColor, Cfg.player2.getCash)
                P2.BackColor = player2.getColor
                P2.Visible = True
                player3 = New Player(Cfg.player3.getName, Cfg.player3.getColor, Cfg.player3.getCash)
                P3.BackColor = player3.getColor
                P3.Visible = True
                player4 = New Player(Cfg.player4.getName, Cfg.player4.getColor, Cfg.player4.getCash)
                P4.BackColor = player4.getColor
                P4.Visible = True
        End Select
    End Sub

    Private Sub generateBoard()
        board.Add(New Square("Salida", 200, SquareType.GO, 760, 745))
        board.Add(New Square("Sangenis", 50, SquareType.STREET, 685, 745))
        board.Add(New Square("Caja de comunidad", 0, SquareType.CHEST, 615, 745))
        board.Add(New Square("Monte Perdido", 50, SquareType.STREET, 545, 745))
        board.Add(New Square("Impuesto sobre capital", 200, SquareType.TAX, 475, 745))
        board.Add(New Square("Tranvía Sur", 0, SquareType.JUMP, 410, 745))
        board.Add(New Square("Ávila", 100, SquareType.STREET, 340, 745))
        board.Add(New Square("Suerte", 0, SquareType.LUCKY, 270, 745))
        board.Add(New Square("Lugo", 100, SquareType.STREET, 195, 745))
        board.Add(New Square("San Juan de la Peña", 120, SquareType.STREET, 130, 745))
        board.Add(New Square("Cárcel", 0, SquareType.JAIL, 10, 745))
        board.Add(New Square("Avenida Valencia", 140, SquareType.STREET, 20, 655))
        board.Add(New Square("Compañía eléctrica", 160, SquareType.STREET, 20, 590))
        board.Add(New Square("Avenida Navarra", 140, SquareType.STREET, 20, 530))
        board.Add(New Square("Valle de broto", 160, SquareType.STREET, 20, 465))
        board.Add(New Square("Tranvía Oeste", 0, SquareType.JUMP, 20, 400))
        board.Add(New Square("Salvador Allende", 180, SquareType.STREET, 20, 335))
        board.Add(New Square("Caja de Comunidad", 0, SquareType.CHEST, 20, 270))
        board.Add(New Square("Miguel Servet", 180, SquareType.STREET, 20, 205))
        board.Add(New Square("Avenida San José", 200, SquareType.STREET, 20, 140))
        board.Add(New Square("Parking gratuito", 0, SquareType.OTHER, 20, 70))
        board.Add(New Square("Avenida Madrid", 220, SquareType.STREET, 130, 62))
        board.Add(New Square("Suerte", 0, SquareType.LUCKY, 198, 62))
        board.Add(New Square("Isabel la católica", 220, SquareType.STREET, 265, 62))
        board.Add(New Square("Avenida América", 240, SquareType.STREET, 335, 62))
        board.Add(New Square("Tranvía Norte", 0, SquareType.JUMP, 405, 62))
        board.Add(New Square("Vía Hispanidad", 260, SquareType.STREET, 475, 62))
        board.Add(New Square("Conde Aranda", 260, SquareType.STREET, 550, 62))
        board.Add(New Square("Compañía de aguas", 160, SquareType.STREET, 615, 62))
        board.Add(New Square("Paseo Constitución", 280, SquareType.STREET, 685, 62))
        board.Add(New Square("Ve a la carcel", 0, SquareType.JUMP, 755, 62))
        board.Add(New Square("Coso", 300, SquareType.STREET, 795, 140))
        board.Add(New Square("Paseo Sagasta", 300, SquareType.STREET, 795, 205))
        board.Add(New Square("Caja de comunidad", 0, SquareType.CHEST, 795, 270))
        board.Add(New Square("Avenida Ruiz Picasso", 330, SquareType.STREET, 795, 335))
        board.Add(New Square("Tranvía Este", 0, SquareType.JUMP, 795, 395))
        board.Add(New Square("Suerte", 0, SquareType.LUCKY, 795, 465))
        board.Add(New Square("Gran Vía", 350, SquareType.STREET, 795, 530))
        board.Add(New Square("Impuesto de lujo", 300, SquareType.TAX, 795, 590))
        board.Add(New Square("Paseo Independencia", 400, SquareType.STREET, 795, 655))

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
            If playerTurn < numPlayers Then

                playerTurn += 1
                setPlayerLabel()
                btnRolldice.Enabled = True
                btnStart.Enabled = False
                getCurrentPlayer()
            Else

                turn += 1
                lblTurn.Text = turn
                playerTurn = 1
                setPlayerLabel()
                btnRolldice.Enabled = True
                btnStart.Enabled = False
                getCurrentPlayer()
            End If
        End If

        If btnStart.Text = "EMPEZAR" Then
            generateStartLayout()
            getCurrentPlayer()

            

            currentSquare = board.Item(0)
            currentSquare.numPlayers = 0
            lblTurn.Text = 1
            movePicLogic(P1)
            currentSquare.numPlayers += 1
            movePicLogic(P2)
            currentSquare.numPlayers += 1
            movePicLogic(P3)
            currentSquare.numPlayers += 1
            movePicLogic(P4)
        End If
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
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

    Private Sub main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.D AndAlso e.Modifiers = Keys.Control) Then

            Panel4.Visible = True
        End If
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
            movePictures()
            currentSquare.numPlayers += 1

        End If
    End Sub
#End Region




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RandGen = New Random(Now.Millisecond)
        currentPlayer.setPosition(7)
        checkSquare(currentPlayer.getPosition)
        UpdatePlayerStats()
        movePictures()
        currentSquare.numPlayers += 1

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RandGen = New Random(Now.Millisecond)
        currentPlayer.setPosition(2)
        checkSquare(currentPlayer.getPosition)
        UpdatePlayerStats()
        movePictures()
        currentSquare.numPlayers += 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RandGen = New Random(Now.Millisecond)
        currentPlayer.setPosition(5)
        checkSquare(currentPlayer.getPosition)
        UpdatePlayerStats()
        movePictures()
        currentSquare.numPlayers += 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RandGen = New Random(Now.Millisecond)
        currentPlayer.setPosition(3)
        checkSquare(currentPlayer.getPosition)
        UpdatePlayerStats()
        movePictures()
        currentSquare.numPlayers += 1
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RandGen = New Random(Now.Millisecond)
        currentPlayer.setPosition(10)

        checkSquare(currentPlayer.getPosition)
        

        currentSquare.numPlayers += 1
    End Sub
End Class
