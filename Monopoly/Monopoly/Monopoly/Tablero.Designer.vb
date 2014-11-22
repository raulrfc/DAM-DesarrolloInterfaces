<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tablero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tablero))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblP4Cash = New System.Windows.Forms.Label()
        Me.lblP4Pos = New System.Windows.Forms.Label()
        Me.lblPlayer4 = New System.Windows.Forms.Label()
        Me.lblP3Cash = New System.Windows.Forms.Label()
        Me.lblP3Pos = New System.Windows.Forms.Label()
        Me.lblPlayer3 = New System.Windows.Forms.Label()
        Me.lblP2Cash = New System.Windows.Forms.Label()
        Me.lblP2Pos = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblP1Cash = New System.Windows.Forms.Label()
        Me.lblP1Pos = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnRolldice = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.pbDices = New System.Windows.Forms.PictureBox()
        Me.pbTablero = New System.Windows.Forms.PictureBox()
        Me.tmrRoll = New System.Windows.Forms.Timer(Me.components)
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rs1 = New System.Windows.Forms.Button()
        Me.rs3 = New System.Windows.Forms.Button()
        Me.rs9 = New System.Windows.Forms.Button()
        Me.rs8 = New System.Windows.Forms.Button()
        Me.rs6 = New System.Windows.Forms.Button()
        Me.rs11 = New System.Windows.Forms.Button()
        Me.rs14 = New System.Windows.Forms.Button()
        Me.rs13 = New System.Windows.Forms.Button()
        Me.rs16 = New System.Windows.Forms.Button()
        Me.rs19 = New System.Windows.Forms.Button()
        Me.rs18 = New System.Windows.Forms.Button()
        Me.rs21 = New System.Windows.Forms.Button()
        Me.rs24 = New System.Windows.Forms.Button()
        Me.rs23 = New System.Windows.Forms.Button()
        Me.rs26 = New System.Windows.Forms.Button()
        Me.rs29 = New System.Windows.Forms.Button()
        Me.rs27 = New System.Windows.Forms.Button()
        Me.rs31 = New System.Windows.Forms.Button()
        Me.rs34 = New System.Windows.Forms.Button()
        Me.rs32 = New System.Windows.Forms.Button()
        Me.rs39 = New System.Windows.Forms.Button()
        Me.rs37 = New System.Windows.Forms.Button()
        Me.rs12 = New System.Windows.Forms.Button()
        Me.rs28 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button30)
        Me.Panel1.Controls.Add(Me.rs28)
        Me.Panel1.Controls.Add(Me.rs12)
        Me.Panel1.Controls.Add(Me.rs39)
        Me.Panel1.Controls.Add(Me.rs37)
        Me.Panel1.Controls.Add(Me.rs31)
        Me.Panel1.Controls.Add(Me.rs34)
        Me.Panel1.Controls.Add(Me.rs32)
        Me.Panel1.Controls.Add(Me.rs26)
        Me.Panel1.Controls.Add(Me.rs29)
        Me.Panel1.Controls.Add(Me.rs27)
        Me.Panel1.Controls.Add(Me.rs21)
        Me.Panel1.Controls.Add(Me.rs24)
        Me.Panel1.Controls.Add(Me.rs23)
        Me.Panel1.Controls.Add(Me.rs16)
        Me.Panel1.Controls.Add(Me.rs19)
        Me.Panel1.Controls.Add(Me.rs18)
        Me.Panel1.Controls.Add(Me.rs11)
        Me.Panel1.Controls.Add(Me.rs14)
        Me.Panel1.Controls.Add(Me.rs13)
        Me.Panel1.Controls.Add(Me.rs6)
        Me.Panel1.Controls.Add(Me.rs9)
        Me.Panel1.Controls.Add(Me.rs8)
        Me.Panel1.Controls.Add(Me.rs3)
        Me.Panel1.Controls.Add(Me.rs1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblP4Cash)
        Me.Panel1.Controls.Add(Me.lblP4Pos)
        Me.Panel1.Controls.Add(Me.lblPlayer4)
        Me.Panel1.Controls.Add(Me.lblP3Cash)
        Me.Panel1.Controls.Add(Me.lblP3Pos)
        Me.Panel1.Controls.Add(Me.lblPlayer3)
        Me.Panel1.Controls.Add(Me.lblP2Cash)
        Me.Panel1.Controls.Add(Me.lblP2Pos)
        Me.Panel1.Controls.Add(Me.lblPlayer2)
        Me.Panel1.Controls.Add(Me.lblP1Cash)
        Me.Panel1.Controls.Add(Me.lblP1Pos)
        Me.Panel1.Controls.Add(Me.lblPlayer1)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.btnRolldice)
        Me.Panel1.Controls.Add(Me.Logo)
        Me.Panel1.Location = New System.Drawing.Point(865, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 793)
        Me.Panel1.TabIndex = 1
        '
        'lblP4Cash
        '
        Me.lblP4Cash.AutoSize = True
        Me.lblP4Cash.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Cash.ForeColor = System.Drawing.Color.Red
        Me.lblP4Cash.Location = New System.Drawing.Point(212, 652)
        Me.lblP4Cash.Name = "lblP4Cash"
        Me.lblP4Cash.Size = New System.Drawing.Size(52, 17)
        Me.lblP4Cash.TabIndex = 22
        Me.lblP4Cash.Text = "P4Cash"
        '
        'lblP4Pos
        '
        Me.lblP4Pos.AutoSize = True
        Me.lblP4Pos.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Pos.ForeColor = System.Drawing.Color.Red
        Me.lblP4Pos.Location = New System.Drawing.Point(122, 652)
        Me.lblP4Pos.Name = "lblP4Pos"
        Me.lblP4Pos.Size = New System.Drawing.Size(45, 17)
        Me.lblP4Pos.TabIndex = 21
        Me.lblP4Pos.Text = "P4Pos"
        '
        'lblPlayer4
        '
        Me.lblPlayer4.AutoSize = True
        Me.lblPlayer4.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer4.ForeColor = System.Drawing.Color.Red
        Me.lblPlayer4.Location = New System.Drawing.Point(25, 652)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.lblPlayer4.Size = New System.Drawing.Size(61, 17)
        Me.lblPlayer4.TabIndex = 20
        Me.lblPlayer4.Text = "Jugador4"
        '
        'lblP3Cash
        '
        Me.lblP3Cash.AutoSize = True
        Me.lblP3Cash.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Cash.ForeColor = System.Drawing.Color.Red
        Me.lblP3Cash.Location = New System.Drawing.Point(212, 613)
        Me.lblP3Cash.Name = "lblP3Cash"
        Me.lblP3Cash.Size = New System.Drawing.Size(52, 17)
        Me.lblP3Cash.TabIndex = 19
        Me.lblP3Cash.Text = "P3Cash"
        '
        'lblP3Pos
        '
        Me.lblP3Pos.AutoSize = True
        Me.lblP3Pos.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Pos.ForeColor = System.Drawing.Color.Red
        Me.lblP3Pos.Location = New System.Drawing.Point(122, 613)
        Me.lblP3Pos.Name = "lblP3Pos"
        Me.lblP3Pos.Size = New System.Drawing.Size(45, 17)
        Me.lblP3Pos.TabIndex = 18
        Me.lblP3Pos.Text = "P3Pos"
        '
        'lblPlayer3
        '
        Me.lblPlayer3.AutoSize = True
        Me.lblPlayer3.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer3.ForeColor = System.Drawing.Color.Red
        Me.lblPlayer3.Location = New System.Drawing.Point(25, 613)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.lblPlayer3.Size = New System.Drawing.Size(61, 17)
        Me.lblPlayer3.TabIndex = 17
        Me.lblPlayer3.Text = "Jugador3"
        '
        'lblP2Cash
        '
        Me.lblP2Cash.AutoSize = True
        Me.lblP2Cash.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Cash.ForeColor = System.Drawing.Color.Red
        Me.lblP2Cash.Location = New System.Drawing.Point(212, 574)
        Me.lblP2Cash.Name = "lblP2Cash"
        Me.lblP2Cash.Size = New System.Drawing.Size(52, 17)
        Me.lblP2Cash.TabIndex = 16
        Me.lblP2Cash.Text = "P2Cash"
        '
        'lblP2Pos
        '
        Me.lblP2Pos.AutoSize = True
        Me.lblP2Pos.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Pos.ForeColor = System.Drawing.Color.Red
        Me.lblP2Pos.Location = New System.Drawing.Point(122, 574)
        Me.lblP2Pos.Name = "lblP2Pos"
        Me.lblP2Pos.Size = New System.Drawing.Size(45, 17)
        Me.lblP2Pos.TabIndex = 15
        Me.lblP2Pos.Text = "P2Pos"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.ForeColor = System.Drawing.Color.Red
        Me.lblPlayer2.Location = New System.Drawing.Point(25, 574)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(61, 17)
        Me.lblPlayer2.TabIndex = 14
        Me.lblPlayer2.Text = "Jugador2"
        '
        'lblP1Cash
        '
        Me.lblP1Cash.AutoSize = True
        Me.lblP1Cash.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Cash.ForeColor = System.Drawing.Color.Red
        Me.lblP1Cash.Location = New System.Drawing.Point(212, 535)
        Me.lblP1Cash.Name = "lblP1Cash"
        Me.lblP1Cash.Size = New System.Drawing.Size(52, 17)
        Me.lblP1Cash.TabIndex = 13
        Me.lblP1Cash.Text = "P1Cash"
        '
        'lblP1Pos
        '
        Me.lblP1Pos.AutoSize = True
        Me.lblP1Pos.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Pos.ForeColor = System.Drawing.Color.Red
        Me.lblP1Pos.Location = New System.Drawing.Point(122, 535)
        Me.lblP1Pos.Name = "lblP1Pos"
        Me.lblP1Pos.Size = New System.Drawing.Size(45, 17)
        Me.lblP1Pos.TabIndex = 12
        Me.lblP1Pos.Text = "P1Pos"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.ForeColor = System.Drawing.Color.Red
        Me.lblPlayer1.Location = New System.Drawing.Point(25, 535)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(61, 17)
        Me.lblPlayer1.TabIndex = 11
        Me.lblPlayer1.Text = "Jugador1"
        '
        'lblPlayer
        '
        Me.lblPlayer.BackColor = System.Drawing.Color.White
        Me.lblPlayer.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.ForeColor = System.Drawing.Color.Red
        Me.lblPlayer.Location = New System.Drawing.Point(121, 42)
        Me.lblPlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPlayer.Size = New System.Drawing.Size(169, 33)
        Me.lblPlayer.TabIndex = 10
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(117, 33)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "JUGADOR:"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Red
        Me.btnStart.Enabled = False
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStart.FlatAppearance.BorderSize = 3
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(145, 752)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(145, 38)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "EMPEZAR"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(6, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(77, 35)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Turno"
        '
        'lblTurn
        '
        Me.lblTurn.BackColor = System.Drawing.Color.White
        Me.lblTurn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.ForeColor = System.Drawing.Color.Red
        Me.lblTurn.Location = New System.Drawing.Point(83, 6)
        Me.lblTurn.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Padding = New System.Windows.Forms.Padding(5)
        Me.lblTurn.Size = New System.Drawing.Size(31, 31)
        Me.lblTurn.TabIndex = 5
        Me.lblTurn.Text = "1"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Red
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevo.FlatAppearance.BorderSize = 3
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(145, 716)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(145, 38)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnRolldice
        '
        Me.btnRolldice.BackColor = System.Drawing.Color.Red
        Me.btnRolldice.Enabled = False
        Me.btnRolldice.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRolldice.FlatAppearance.BorderSize = 3
        Me.btnRolldice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRolldice.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRolldice.ForeColor = System.Drawing.Color.White
        Me.btnRolldice.Location = New System.Drawing.Point(0, 716)
        Me.btnRolldice.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRolldice.Name = "btnRolldice"
        Me.btnRolldice.Size = New System.Drawing.Size(149, 77)
        Me.btnRolldice.TabIndex = 1
        Me.btnRolldice.Text = "TIRAR DADOS"
        Me.btnRolldice.UseVisualStyleBackColor = False
        '
        'Logo
        '
        Me.Logo.Image = Global.Monopoly.My.Resources.Resources.logo
        Me.Logo.Location = New System.Drawing.Point(0, 0)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(290, 86)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'pbDices
        '
        Me.pbDices.InitialImage = Global.Monopoly.My.Resources.Resources.dice6
        Me.pbDices.Location = New System.Drawing.Point(384, 322)
        Me.pbDices.Name = "pbDices"
        Me.pbDices.Size = New System.Drawing.Size(100, 97)
        Me.pbDices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDices.TabIndex = 2
        Me.pbDices.TabStop = False
        Me.pbDices.Visible = False
        '
        'pbTablero
        '
        Me.pbTablero.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.pbTablero.Image = Global.Monopoly.My.Resources.Resources.Tablero
        Me.pbTablero.Location = New System.Drawing.Point(2, 0)
        Me.pbTablero.Margin = New System.Windows.Forms.Padding(0)
        Me.pbTablero.Name = "pbTablero"
        Me.pbTablero.Size = New System.Drawing.Size(863, 793)
        Me.pbTablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTablero.TabIndex = 0
        Me.pbTablero.TabStop = False
        '
        'tmrRoll
        '
        Me.tmrRoll.Interval = 200
        '
        'txtInfo
        '
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.ForeColor = System.Drawing.Color.Red
        Me.txtInfo.Location = New System.Drawing.Point(3, 3)
        Me.txtInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(152, 182)
        Me.txtInfo.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnBuy)
        Me.Panel2.Controls.Add(Me.txtInfo)
        Me.Panel2.Location = New System.Drawing.Point(358, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 220)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(79, 192)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(76, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.Color.Red
        Me.btnBuy.Enabled = False
        Me.btnBuy.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuy.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuy.ForeColor = System.Drawing.Color.White
        Me.btnBuy.Location = New System.Drawing.Point(4, 192)
        Me.btnBuy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(75, 23)
        Me.btnBuy.TabIndex = 1
        Me.btnBuy.Text = "Comprar"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "TEST "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.lblTurn)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblPlayer)
        Me.Panel3.Location = New System.Drawing.Point(0, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 78)
        Me.Panel3.TabIndex = 24
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(2, 792)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 3
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(290, 3)
        Me.Button3.TabIndex = 26
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 3
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(290, 3)
        Me.Button4.TabIndex = 27
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 3
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(0, 713)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(290, 3)
        Me.Button5.TabIndex = 27
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(82, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 26)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "PROPIEDADES"
        '
        'rs1
        '
        Me.rs1.BackColor = System.Drawing.Color.White
        Me.rs1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.rs1.FlatAppearance.BorderSize = 3
        Me.rs1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs1.Location = New System.Drawing.Point(11, 205)
        Me.rs1.Name = "rs1"
        Me.rs1.Size = New System.Drawing.Size(28, 57)
        Me.rs1.TabIndex = 29
        Me.rs1.UseVisualStyleBackColor = False
        '
        'rs3
        '
        Me.rs3.BackColor = System.Drawing.Color.White
        Me.rs3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.rs3.FlatAppearance.BorderSize = 3
        Me.rs3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs3.Location = New System.Drawing.Point(45, 205)
        Me.rs3.Name = "rs3"
        Me.rs3.Size = New System.Drawing.Size(28, 57)
        Me.rs3.TabIndex = 30
        Me.rs3.UseVisualStyleBackColor = False
        '
        'rs9
        '
        Me.rs9.BackColor = System.Drawing.Color.White
        Me.rs9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.rs9.FlatAppearance.BorderSize = 3
        Me.rs9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs9.Location = New System.Drawing.Point(249, 205)
        Me.rs9.Name = "rs9"
        Me.rs9.Size = New System.Drawing.Size(28, 57)
        Me.rs9.TabIndex = 32
        Me.rs9.UseVisualStyleBackColor = False
        '
        'rs8
        '
        Me.rs8.BackColor = System.Drawing.Color.White
        Me.rs8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.rs8.FlatAppearance.BorderSize = 3
        Me.rs8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs8.Location = New System.Drawing.Point(215, 205)
        Me.rs8.Name = "rs8"
        Me.rs8.Size = New System.Drawing.Size(28, 57)
        Me.rs8.TabIndex = 31
        Me.rs8.UseVisualStyleBackColor = False
        '
        'rs6
        '
        Me.rs6.BackColor = System.Drawing.Color.White
        Me.rs6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.rs6.FlatAppearance.BorderSize = 3
        Me.rs6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs6.Location = New System.Drawing.Point(181, 205)
        Me.rs6.Name = "rs6"
        Me.rs6.Size = New System.Drawing.Size(28, 57)
        Me.rs6.TabIndex = 33
        Me.rs6.UseVisualStyleBackColor = False
        '
        'rs11
        '
        Me.rs11.BackColor = System.Drawing.Color.White
        Me.rs11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.rs11.FlatAppearance.BorderSize = 3
        Me.rs11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs11.Location = New System.Drawing.Point(11, 268)
        Me.rs11.Name = "rs11"
        Me.rs11.Size = New System.Drawing.Size(28, 57)
        Me.rs11.TabIndex = 36
        Me.rs11.UseVisualStyleBackColor = False
        '
        'rs14
        '
        Me.rs14.BackColor = System.Drawing.Color.White
        Me.rs14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.rs14.FlatAppearance.BorderSize = 3
        Me.rs14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs14.Location = New System.Drawing.Point(79, 268)
        Me.rs14.Name = "rs14"
        Me.rs14.Size = New System.Drawing.Size(28, 57)
        Me.rs14.TabIndex = 35
        Me.rs14.UseVisualStyleBackColor = False
        '
        'rs13
        '
        Me.rs13.BackColor = System.Drawing.Color.White
        Me.rs13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.rs13.FlatAppearance.BorderSize = 3
        Me.rs13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs13.Location = New System.Drawing.Point(45, 268)
        Me.rs13.Name = "rs13"
        Me.rs13.Size = New System.Drawing.Size(28, 57)
        Me.rs13.TabIndex = 34
        Me.rs13.UseVisualStyleBackColor = False
        '
        'rs16
        '
        Me.rs16.BackColor = System.Drawing.Color.White
        Me.rs16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rs16.FlatAppearance.BorderSize = 3
        Me.rs16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs16.Location = New System.Drawing.Point(181, 268)
        Me.rs16.Name = "rs16"
        Me.rs16.Size = New System.Drawing.Size(28, 57)
        Me.rs16.TabIndex = 39
        Me.rs16.UseVisualStyleBackColor = False
        '
        'rs19
        '
        Me.rs19.BackColor = System.Drawing.Color.White
        Me.rs19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rs19.FlatAppearance.BorderSize = 3
        Me.rs19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs19.Location = New System.Drawing.Point(249, 268)
        Me.rs19.Name = "rs19"
        Me.rs19.Size = New System.Drawing.Size(28, 57)
        Me.rs19.TabIndex = 38
        Me.rs19.UseVisualStyleBackColor = False
        '
        'rs18
        '
        Me.rs18.BackColor = System.Drawing.Color.White
        Me.rs18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rs18.FlatAppearance.BorderSize = 3
        Me.rs18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs18.Location = New System.Drawing.Point(215, 268)
        Me.rs18.Name = "rs18"
        Me.rs18.Size = New System.Drawing.Size(28, 57)
        Me.rs18.TabIndex = 37
        Me.rs18.UseVisualStyleBackColor = False
        '
        'rs21
        '
        Me.rs21.BackColor = System.Drawing.Color.White
        Me.rs21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rs21.FlatAppearance.BorderSize = 3
        Me.rs21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs21.Location = New System.Drawing.Point(11, 331)
        Me.rs21.Name = "rs21"
        Me.rs21.Size = New System.Drawing.Size(28, 57)
        Me.rs21.TabIndex = 42
        Me.rs21.UseVisualStyleBackColor = False
        '
        'rs24
        '
        Me.rs24.BackColor = System.Drawing.Color.White
        Me.rs24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rs24.FlatAppearance.BorderSize = 3
        Me.rs24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs24.Location = New System.Drawing.Point(79, 331)
        Me.rs24.Name = "rs24"
        Me.rs24.Size = New System.Drawing.Size(28, 57)
        Me.rs24.TabIndex = 41
        Me.rs24.UseVisualStyleBackColor = False
        '
        'rs23
        '
        Me.rs23.BackColor = System.Drawing.Color.White
        Me.rs23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rs23.FlatAppearance.BorderSize = 3
        Me.rs23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs23.Location = New System.Drawing.Point(45, 331)
        Me.rs23.Name = "rs23"
        Me.rs23.Size = New System.Drawing.Size(28, 57)
        Me.rs23.TabIndex = 40
        Me.rs23.UseVisualStyleBackColor = False
        '
        'rs26
        '
        Me.rs26.BackColor = System.Drawing.Color.White
        Me.rs26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.rs26.FlatAppearance.BorderSize = 3
        Me.rs26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs26.Location = New System.Drawing.Point(181, 331)
        Me.rs26.Name = "rs26"
        Me.rs26.Size = New System.Drawing.Size(28, 57)
        Me.rs26.TabIndex = 45
        Me.rs26.UseVisualStyleBackColor = False
        '
        'rs29
        '
        Me.rs29.BackColor = System.Drawing.Color.White
        Me.rs29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.rs29.FlatAppearance.BorderSize = 3
        Me.rs29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs29.Location = New System.Drawing.Point(249, 331)
        Me.rs29.Name = "rs29"
        Me.rs29.Size = New System.Drawing.Size(28, 57)
        Me.rs29.TabIndex = 44
        Me.rs29.UseVisualStyleBackColor = False
        '
        'rs27
        '
        Me.rs27.BackColor = System.Drawing.Color.White
        Me.rs27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.rs27.FlatAppearance.BorderSize = 3
        Me.rs27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs27.Location = New System.Drawing.Point(215, 331)
        Me.rs27.Name = "rs27"
        Me.rs27.Size = New System.Drawing.Size(28, 57)
        Me.rs27.TabIndex = 43
        Me.rs27.UseVisualStyleBackColor = False
        '
        'rs31
        '
        Me.rs31.BackColor = System.Drawing.Color.White
        Me.rs31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.rs31.FlatAppearance.BorderSize = 3
        Me.rs31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs31.Location = New System.Drawing.Point(11, 394)
        Me.rs31.Name = "rs31"
        Me.rs31.Size = New System.Drawing.Size(28, 57)
        Me.rs31.TabIndex = 48
        Me.rs31.UseVisualStyleBackColor = False
        '
        'rs34
        '
        Me.rs34.BackColor = System.Drawing.Color.White
        Me.rs34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.rs34.FlatAppearance.BorderSize = 3
        Me.rs34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs34.Location = New System.Drawing.Point(79, 394)
        Me.rs34.Name = "rs34"
        Me.rs34.Size = New System.Drawing.Size(28, 57)
        Me.rs34.TabIndex = 47
        Me.rs34.UseVisualStyleBackColor = False
        '
        'rs32
        '
        Me.rs32.BackColor = System.Drawing.Color.White
        Me.rs32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.rs32.FlatAppearance.BorderSize = 3
        Me.rs32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs32.Location = New System.Drawing.Point(45, 394)
        Me.rs32.Name = "rs32"
        Me.rs32.Size = New System.Drawing.Size(28, 57)
        Me.rs32.TabIndex = 46
        Me.rs32.UseVisualStyleBackColor = False
        '
        'rs39
        '
        Me.rs39.BackColor = System.Drawing.Color.White
        Me.rs39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.rs39.FlatAppearance.BorderSize = 3
        Me.rs39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs39.Location = New System.Drawing.Point(249, 394)
        Me.rs39.Name = "rs39"
        Me.rs39.Size = New System.Drawing.Size(28, 57)
        Me.rs39.TabIndex = 50
        Me.rs39.UseVisualStyleBackColor = False
        '
        'rs37
        '
        Me.rs37.BackColor = System.Drawing.Color.White
        Me.rs37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.rs37.FlatAppearance.BorderSize = 3
        Me.rs37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs37.Location = New System.Drawing.Point(215, 394)
        Me.rs37.Name = "rs37"
        Me.rs37.Size = New System.Drawing.Size(28, 57)
        Me.rs37.TabIndex = 49
        Me.rs37.UseVisualStyleBackColor = False
        '
        'rs12
        '
        Me.rs12.BackColor = System.Drawing.Color.White
        Me.rs12.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.rs12.FlatAppearance.BorderSize = 3
        Me.rs12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs12.Location = New System.Drawing.Point(125, 268)
        Me.rs12.Name = "rs12"
        Me.rs12.Size = New System.Drawing.Size(28, 57)
        Me.rs12.TabIndex = 51
        Me.rs12.UseVisualStyleBackColor = False
        '
        'rs28
        '
        Me.rs28.BackColor = System.Drawing.Color.White
        Me.rs28.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.rs28.FlatAppearance.BorderSize = 3
        Me.rs28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rs28.Location = New System.Drawing.Point(125, 331)
        Me.rs28.Name = "rs28"
        Me.rs28.Size = New System.Drawing.Size(28, 57)
        Me.rs28.TabIndex = 52
        Me.rs28.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button30.FlatAppearance.BorderSize = 3
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Location = New System.Drawing.Point(0, 519)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(290, 3)
        Me.Button30.TabIndex = 28
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Tablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pbDices)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbTablero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tablero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monopoly"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbTablero As System.Windows.Forms.PictureBox
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents btnRolldice As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents pbDices As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRoll As System.Windows.Forms.Timer
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblP4Cash As System.Windows.Forms.Label
    Friend WithEvents lblP4Pos As System.Windows.Forms.Label
    Friend WithEvents lblPlayer4 As System.Windows.Forms.Label
    Friend WithEvents lblP3Cash As System.Windows.Forms.Label
    Friend WithEvents lblP3Pos As System.Windows.Forms.Label
    Friend WithEvents lblPlayer3 As System.Windows.Forms.Label
    Friend WithEvents lblP2Cash As System.Windows.Forms.Label
    Friend WithEvents lblP2Pos As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblP1Cash As System.Windows.Forms.Label
    Friend WithEvents lblP1Pos As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents rs28 As System.Windows.Forms.Button
    Friend WithEvents rs12 As System.Windows.Forms.Button
    Friend WithEvents rs39 As System.Windows.Forms.Button
    Friend WithEvents rs37 As System.Windows.Forms.Button
    Friend WithEvents rs31 As System.Windows.Forms.Button
    Friend WithEvents rs34 As System.Windows.Forms.Button
    Friend WithEvents rs32 As System.Windows.Forms.Button
    Friend WithEvents rs26 As System.Windows.Forms.Button
    Friend WithEvents rs29 As System.Windows.Forms.Button
    Friend WithEvents rs27 As System.Windows.Forms.Button
    Friend WithEvents rs21 As System.Windows.Forms.Button
    Friend WithEvents rs24 As System.Windows.Forms.Button
    Friend WithEvents rs23 As System.Windows.Forms.Button
    Friend WithEvents rs16 As System.Windows.Forms.Button
    Friend WithEvents rs19 As System.Windows.Forms.Button
    Friend WithEvents rs18 As System.Windows.Forms.Button
    Friend WithEvents rs11 As System.Windows.Forms.Button
    Friend WithEvents rs14 As System.Windows.Forms.Button
    Friend WithEvents rs13 As System.Windows.Forms.Button
    Friend WithEvents rs6 As System.Windows.Forms.Button
    Friend WithEvents rs9 As System.Windows.Forms.Button
    Friend WithEvents rs8 As System.Windows.Forms.Button
    Friend WithEvents rs3 As System.Windows.Forms.Button
    Friend WithEvents rs1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
