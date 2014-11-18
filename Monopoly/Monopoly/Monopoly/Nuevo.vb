Public Class Nuevo
    Dim numPlayers As Integer
    Dim difficulty As String
    Dim cash As Integer
    Dim player1 As Player
    Dim player2 As Player
    Dim player3 As Player
    Dim player4 As Player

#Region "CheckedLists"
    Private Sub clbDifficulty_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbDifficulty.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To Me.clbDifficulty.Items.Count - 1 Step 1
                If i <> e.Index Then
                    Me.clbDifficulty.SetItemChecked(i, False)
                End If
            Next i
        End If
    End Sub

    Private Function getCheckedDifficulty()
        Dim checked As String = ""
        For i = 0 To (clbDifficulty.Items.Count - 1)
            If clbDifficulty.GetItemChecked(i) = True Then
                checked = clbDifficulty.Items(i)
            End If
        Next
        Return checked
    End Function

    Private Sub clbDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbDifficulty.SelectedIndexChanged
        Dim checked As String

        checked = getCheckedDifficulty()

        Select Case checked
            Case "Fácil"
                difficulty = "Fácil"
                cash = 3000
            Case "Media"
                difficulty = "Media"
                cash = 2000
            Case "Difícil"
                difficulty = "Difícil"
                cash = 1000
        End Select
    End Sub

    Private Sub clbNumPlayers_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbNumPlayers.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To Me.clbNumPlayers.Items.Count - 1 Step 1
                If i <> e.Index Then
                    Me.clbNumPlayers.SetItemChecked(i, False)
                End If
            Next i
        End If
    End Sub

    Private Function getCheckedPlayers()
        Dim checked As Integer
        For i = 0 To (clbNumPlayers.Items.Count - 1)
            If clbNumPlayers.GetItemChecked(i) = True Then
                checked = clbNumPlayers.Items(i)
            End If
        Next
        Return checked
    End Function

    Private Sub clbNumPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbNumPlayers.SelectedIndexChanged
        Dim checked As Integer

        checked = getCheckedPlayers()

        Select Case checked
            Case 2
                p1Enabled(True)
                p2Enabled(True)
                p3Enabled(False)
                p4Enabled(False)
                numPlayers = 2
            Case 3
                p1Enabled(True)
                p2Enabled(True)
                p3Enabled(True)
                p4Enabled(False)
                numPlayers = 3
            Case 4
                p1Enabled(True)
                p2Enabled(True)
                p3Enabled(True)
                p4Enabled(True)
                numPlayers = 4
            Case Else
                p1Enabled(False)
                p2Enabled(False)
                p3Enabled(False)
                p4Enabled(False)
        End Select
    End Sub

#End Region

#Region "Players"
    Private Sub p1Enabled(ByVal value As Boolean)
        lblP1.Enabled = value
        TextBox1.Enabled = value
        btnColorP1.Enabled = value
    End Sub

    Private Sub p2Enabled(ByVal value As Boolean)
        lblP2.Enabled = value
        TextBox2.Enabled = value
        btnColorP2.Enabled = value
    End Sub

    Private Sub p3Enabled(ByVal value As Boolean)
        lblP3.Enabled = value
        TextBox3.Enabled = value
        btnColorP3.Enabled = value
    End Sub

    Private Sub p4Enabled(ByVal value As Boolean)
        lblP4.Enabled = value
        TextBox4.Enabled = value
        btnColorP4.Enabled = value
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColorP1.Click, btnColorP2.Click, btnColorP3.Click, btnColorP4.Click
        Dim clickedButton As Button

        clickedButton = CType(sender, Button)
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case clickedButton.Name
                Case "btnColorP1"
                    btnColorP1.BackColor = ColorDialog1.Color
                Case "btnColorP2"
                    btnColorP2.BackColor = ColorDialog1.Color
                Case "btnColorP3"
                    btnColorP3.BackColor = ColorDialog1.Color
                Case "btnColorP4"
                    btnColorP4.BackColor = ColorDialog1.Color
            End Select
        End If
    End Sub

#End Region

#Region "General"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If clbDifficulty.CheckedItems.Count > 0 AndAlso clbNumPlayers.CheckedItems.Count > 0 Then
            btnOK.Enabled = True
        Else
            btnOK.Enabled = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub setPlayers()
        player1 = New Player(TextBox1.Text, btnColorP1.BackColor, cash)
        player2 = New Player(TextBox2.Text, btnColorP2.BackColor, cash)
        player3 = New Player(TextBox3.Text, btnColorP3.BackColor, cash)
        player4 = New Player(TextBox4.Text, btnColorP4.BackColor, cash)
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        setPlayers()
        Cfg.numPlayers = numPlayers
        Cfg.difficulty = difficulty
        Cfg.player1 = player1
        Cfg.player2 = player2
        Cfg.player3 = player3
        Cfg.player4 = player4
        Me.Close()
    End Sub
#End Region


End Class