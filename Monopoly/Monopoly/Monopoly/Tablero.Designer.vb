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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rs28 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs34 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs32 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs31 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs21 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs23 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs24 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs39 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs37 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs26 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs27 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs29 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs19 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs18 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs16 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rs1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.pbDices = New System.Windows.Forms.PictureBox()
        Me.pbTablero = New System.Windows.Forms.PictureBox()
        Me.tmrRoll = New System.Windows.Forms.Timer(Me.components)
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.Panel1.Controls.Add(Me.lblPlayer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTurn)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnRolldice)
        Me.Panel1.Controls.Add(Me.Logo)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(865, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 793)
        Me.Panel1.TabIndex = 1
        '
        'lblP4Cash
        '
        Me.lblP4Cash.AutoSize = True
        Me.lblP4Cash.Location = New System.Drawing.Point(191, 553)
        Me.lblP4Cash.Name = "lblP4Cash"
        Me.lblP4Cash.Size = New System.Drawing.Size(44, 13)
        Me.lblP4Cash.TabIndex = 22
        Me.lblP4Cash.Text = "P4Cash"
        '
        'lblP4Pos
        '
        Me.lblP4Pos.AutoSize = True
        Me.lblP4Pos.Location = New System.Drawing.Point(100, 553)
        Me.lblP4Pos.Name = "lblP4Pos"
        Me.lblP4Pos.Size = New System.Drawing.Size(38, 13)
        Me.lblP4Pos.TabIndex = 21
        Me.lblP4Pos.Text = "P4Pos"
        '
        'lblPlayer4
        '
        Me.lblPlayer4.AutoSize = True
        Me.lblPlayer4.Location = New System.Drawing.Point(13, 553)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.lblPlayer4.Size = New System.Drawing.Size(51, 13)
        Me.lblPlayer4.TabIndex = 20
        Me.lblPlayer4.Text = "Jugador4"
        '
        'lblP3Cash
        '
        Me.lblP3Cash.AutoSize = True
        Me.lblP3Cash.Location = New System.Drawing.Point(191, 521)
        Me.lblP3Cash.Name = "lblP3Cash"
        Me.lblP3Cash.Size = New System.Drawing.Size(44, 13)
        Me.lblP3Cash.TabIndex = 19
        Me.lblP3Cash.Text = "P3Cash"
        '
        'lblP3Pos
        '
        Me.lblP3Pos.AutoSize = True
        Me.lblP3Pos.Location = New System.Drawing.Point(100, 521)
        Me.lblP3Pos.Name = "lblP3Pos"
        Me.lblP3Pos.Size = New System.Drawing.Size(38, 13)
        Me.lblP3Pos.TabIndex = 18
        Me.lblP3Pos.Text = "P3Pos"
        '
        'lblPlayer3
        '
        Me.lblPlayer3.AutoSize = True
        Me.lblPlayer3.Location = New System.Drawing.Point(13, 521)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.lblPlayer3.Size = New System.Drawing.Size(51, 13)
        Me.lblPlayer3.TabIndex = 17
        Me.lblPlayer3.Text = "Jugador3"
        '
        'lblP2Cash
        '
        Me.lblP2Cash.AutoSize = True
        Me.lblP2Cash.Location = New System.Drawing.Point(191, 482)
        Me.lblP2Cash.Name = "lblP2Cash"
        Me.lblP2Cash.Size = New System.Drawing.Size(44, 13)
        Me.lblP2Cash.TabIndex = 16
        Me.lblP2Cash.Text = "P2Cash"
        '
        'lblP2Pos
        '
        Me.lblP2Pos.AutoSize = True
        Me.lblP2Pos.Location = New System.Drawing.Point(100, 482)
        Me.lblP2Pos.Name = "lblP2Pos"
        Me.lblP2Pos.Size = New System.Drawing.Size(38, 13)
        Me.lblP2Pos.TabIndex = 15
        Me.lblP2Pos.Text = "P2Pos"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(13, 482)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(51, 13)
        Me.lblPlayer2.TabIndex = 14
        Me.lblPlayer2.Text = "Jugador2"
        '
        'lblP1Cash
        '
        Me.lblP1Cash.AutoSize = True
        Me.lblP1Cash.Location = New System.Drawing.Point(191, 447)
        Me.lblP1Cash.Name = "lblP1Cash"
        Me.lblP1Cash.Size = New System.Drawing.Size(44, 13)
        Me.lblP1Cash.TabIndex = 13
        Me.lblP1Cash.Text = "P1Cash"
        '
        'lblP1Pos
        '
        Me.lblP1Pos.AutoSize = True
        Me.lblP1Pos.Location = New System.Drawing.Point(100, 447)
        Me.lblP1Pos.Name = "lblP1Pos"
        Me.lblP1Pos.Size = New System.Drawing.Size(38, 13)
        Me.lblP1Pos.TabIndex = 12
        Me.lblP1Pos.Text = "P1Pos"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(13, 447)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(51, 13)
        Me.lblPlayer1.TabIndex = 11
        Me.lblPlayer1.Text = "Jugador1"
        '
        'lblPlayer
        '
        Me.lblPlayer.BackColor = System.Drawing.Color.White
        Me.lblPlayer.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.ForeColor = System.Drawing.Color.Red
        Me.lblPlayer.Location = New System.Drawing.Point(111, 129)
        Me.lblPlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPlayer.Size = New System.Drawing.Size(169, 31)
        Me.lblPlayer.TabIndex = 10
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(8, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(103, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "JUGADOR:"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Red
        Me.btnStart.Enabled = False
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStart.FlatAppearance.BorderSize = 2
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(153, 713)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(137, 77)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "EMPEZAR"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(174, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(75, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Turno"
        '
        'lblTurn
        '
        Me.lblTurn.BackColor = System.Drawing.Color.White
        Me.lblTurn.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.ForeColor = System.Drawing.Color.Red
        Me.lblTurn.Location = New System.Drawing.Point(249, 98)
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
        Me.btnNuevo.FlatAppearance.BorderSize = 2
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(7, 92)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(89, 32)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnRolldice
        '
        Me.btnRolldice.BackColor = System.Drawing.Color.Red
        Me.btnRolldice.Enabled = False
        Me.btnRolldice.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRolldice.FlatAppearance.BorderSize = 2
        Me.btnRolldice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRolldice.Font = New System.Drawing.Font("DS-Digital", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRolldice.ForeColor = System.Drawing.Color.White
        Me.btnRolldice.Location = New System.Drawing.Point(3, 713)
        Me.btnRolldice.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRolldice.Name = "btnRolldice"
        Me.btnRolldice.Size = New System.Drawing.Size(150, 77)
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rs28, Me.rs12, Me.rs34, Me.rs32, Me.rs31, Me.rs21, Me.rs23, Me.rs24, Me.rs39, Me.rs37, Me.rs26, Me.rs27, Me.rs29, Me.rs19, Me.rs18, Me.rs16, Me.rs14, Me.rs13, Me.rs11, Me.rs9, Me.rs6, Me.rs8, Me.rs3, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.rs1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(293, 793)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'rs28
        '
        Me.rs28.BackColor = System.Drawing.Color.White
        Me.rs28.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs28.BorderColor = System.Drawing.Color.Aqua
        Me.rs28.BorderWidth = 2
        Me.rs28.Location = New System.Drawing.Point(129, 278)
        Me.rs28.Name = "rs28"
        Me.rs28.Size = New System.Drawing.Size(25, 41)
        '
        'rs12
        '
        Me.rs12.BackColor = System.Drawing.Color.White
        Me.rs12.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rs12.BorderWidth = 2
        Me.rs12.Location = New System.Drawing.Point(129, 228)
        Me.rs12.Name = "rs12"
        Me.rs12.Size = New System.Drawing.Size(25, 41)
        '
        'rs34
        '
        Me.rs34.BackColor = System.Drawing.Color.White
        Me.rs34.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs34.BorderColor = System.Drawing.Color.Green
        Me.rs34.BorderWidth = 2
        Me.rs34.Location = New System.Drawing.Point(69, 322)
        Me.rs34.Name = "rs34"
        Me.rs34.Size = New System.Drawing.Size(25, 41)
        '
        'rs32
        '
        Me.rs32.BackColor = System.Drawing.Color.White
        Me.rs32.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs32.BorderColor = System.Drawing.Color.Green
        Me.rs32.BorderWidth = 2
        Me.rs32.Location = New System.Drawing.Point(37, 322)
        Me.rs32.Name = "rs32"
        Me.rs32.Size = New System.Drawing.Size(25, 41)
        '
        'rs31
        '
        Me.rs31.BackColor = System.Drawing.Color.White
        Me.rs31.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs31.BorderColor = System.Drawing.Color.Green
        Me.rs31.BorderWidth = 2
        Me.rs31.Location = New System.Drawing.Point(6, 322)
        Me.rs31.Name = "rs31"
        Me.rs31.Size = New System.Drawing.Size(25, 41)
        '
        'rs21
        '
        Me.rs21.BackColor = System.Drawing.Color.White
        Me.rs21.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs21.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rs21.BorderWidth = 2
        Me.rs21.Location = New System.Drawing.Point(6, 275)
        Me.rs21.Name = "rs21"
        Me.rs21.Size = New System.Drawing.Size(25, 41)
        '
        'rs23
        '
        Me.rs23.BackColor = System.Drawing.Color.White
        Me.rs23.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs23.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rs23.BorderWidth = 2
        Me.rs23.Location = New System.Drawing.Point(37, 275)
        Me.rs23.Name = "rs23"
        Me.rs23.Size = New System.Drawing.Size(25, 41)
        '
        'rs24
        '
        Me.rs24.BackColor = System.Drawing.Color.White
        Me.rs24.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs24.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rs24.BorderWidth = 2
        Me.rs24.Location = New System.Drawing.Point(69, 275)
        Me.rs24.Name = "rs24"
        Me.rs24.Size = New System.Drawing.Size(25, 41)
        '
        'rs39
        '
        Me.rs39.BackColor = System.Drawing.Color.White
        Me.rs39.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs39.BorderColor = System.Drawing.Color.Blue
        Me.rs39.BorderWidth = 2
        Me.rs39.Location = New System.Drawing.Point(223, 322)
        Me.rs39.Name = "rs39"
        Me.rs39.Size = New System.Drawing.Size(25, 41)
        '
        'rs37
        '
        Me.rs37.BackColor = System.Drawing.Color.White
        Me.rs37.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs37.BorderColor = System.Drawing.Color.Blue
        Me.rs37.BorderWidth = 2
        Me.rs37.Location = New System.Drawing.Point(192, 322)
        Me.rs37.Name = "rs37"
        Me.rs37.Size = New System.Drawing.Size(25, 41)
        '
        'rs26
        '
        Me.rs26.BackColor = System.Drawing.Color.White
        Me.rs26.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs26.BorderColor = System.Drawing.Color.Yellow
        Me.rs26.BorderWidth = 2
        Me.rs26.Location = New System.Drawing.Point(192, 276)
        Me.rs26.Name = "rs26"
        Me.rs26.Size = New System.Drawing.Size(25, 41)
        '
        'rs27
        '
        Me.rs27.BackColor = System.Drawing.Color.White
        Me.rs27.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs27.BorderColor = System.Drawing.Color.Yellow
        Me.rs27.BorderWidth = 2
        Me.rs27.Location = New System.Drawing.Point(223, 276)
        Me.rs27.Name = "rs27"
        Me.rs27.Size = New System.Drawing.Size(25, 41)
        '
        'rs29
        '
        Me.rs29.BackColor = System.Drawing.Color.White
        Me.rs29.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs29.BorderColor = System.Drawing.Color.Yellow
        Me.rs29.BorderWidth = 2
        Me.rs29.Location = New System.Drawing.Point(255, 276)
        Me.rs29.Name = "rs29"
        Me.rs29.Size = New System.Drawing.Size(25, 41)
        '
        'rs19
        '
        Me.rs19.BackColor = System.Drawing.Color.White
        Me.rs19.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rs19.BorderWidth = 2
        Me.rs19.Location = New System.Drawing.Point(255, 230)
        Me.rs19.Name = "rs19"
        Me.rs19.Size = New System.Drawing.Size(25, 41)
        '
        'rs18
        '
        Me.rs18.BackColor = System.Drawing.Color.White
        Me.rs18.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs18.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rs18.BorderWidth = 2
        Me.rs18.Location = New System.Drawing.Point(223, 230)
        Me.rs18.Name = "rs18"
        Me.rs18.Size = New System.Drawing.Size(25, 41)
        '
        'rs16
        '
        Me.rs16.BackColor = System.Drawing.Color.White
        Me.rs16.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rs16.BorderWidth = 2
        Me.rs16.Location = New System.Drawing.Point(192, 230)
        Me.rs16.Name = "rs16"
        Me.rs16.Size = New System.Drawing.Size(25, 41)
        '
        'rs14
        '
        Me.rs14.BackColor = System.Drawing.Color.White
        Me.rs14.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs14.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.rs14.BorderWidth = 2
        Me.rs14.Location = New System.Drawing.Point(69, 228)
        Me.rs14.Name = "rs14"
        Me.rs14.Size = New System.Drawing.Size(25, 41)
        '
        'rs13
        '
        Me.rs13.BackColor = System.Drawing.Color.White
        Me.rs13.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs13.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.rs13.BorderWidth = 2
        Me.rs13.Location = New System.Drawing.Point(37, 228)
        Me.rs13.Name = "rs13"
        Me.rs13.Size = New System.Drawing.Size(25, 41)
        '
        'rs11
        '
        Me.rs11.BackColor = System.Drawing.Color.White
        Me.rs11.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs11.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.rs11.BorderWidth = 2
        Me.rs11.Location = New System.Drawing.Point(6, 228)
        Me.rs11.Name = "rs11"
        Me.rs11.Size = New System.Drawing.Size(25, 41)
        '
        'rs9
        '
        Me.rs9.BackColor = System.Drawing.Color.White
        Me.rs9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rs9.BorderWidth = 2
        Me.rs9.Location = New System.Drawing.Point(255, 184)
        Me.rs9.Name = "rs9"
        Me.rs9.Size = New System.Drawing.Size(25, 41)
        '
        'rs6
        '
        Me.rs6.BackColor = System.Drawing.Color.White
        Me.rs6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rs6.BorderWidth = 2
        Me.rs6.Location = New System.Drawing.Point(192, 184)
        Me.rs6.Name = "rs6"
        Me.rs6.Size = New System.Drawing.Size(25, 41)
        '
        'rs8
        '
        Me.rs8.BackColor = System.Drawing.Color.White
        Me.rs8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rs8.BorderWidth = 2
        Me.rs8.Location = New System.Drawing.Point(223, 184)
        Me.rs8.Name = "rs8"
        Me.rs8.Size = New System.Drawing.Size(25, 41)
        '
        'rs3
        '
        Me.rs3.BackColor = System.Drawing.Color.White
        Me.rs3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs3.BorderColor = System.Drawing.Color.Purple
        Me.rs3.BorderWidth = 2
        Me.rs3.Location = New System.Drawing.Point(37, 182)
        Me.rs3.Name = "rs3"
        Me.rs3.Size = New System.Drawing.Size(25, 41)
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 292
        Me.LineShape3.Y1 = 710
        Me.LineShape3.Y2 = 710
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -1
        Me.LineShape2.X2 = 291
        Me.LineShape2.Y1 = 371
        Me.LineShape2.Y2 = 371
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 292
        Me.LineShape1.Y1 = 168
        Me.LineShape1.Y2 = 168
        '
        'rs1
        '
        Me.rs1.BackColor = System.Drawing.Color.White
        Me.rs1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rs1.BorderColor = System.Drawing.Color.Purple
        Me.rs1.BorderWidth = 2
        Me.rs1.Location = New System.Drawing.Point(6, 182)
        Me.rs1.Name = "rs1"
        Me.rs1.Size = New System.Drawing.Size(25, 41)
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
        Me.btnCancel.Font = New System.Drawing.Font("DS-Digital", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnBuy.Font = New System.Drawing.Font("DS-Digital", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuy.ForeColor = System.Drawing.Color.White
        Me.btnBuy.Location = New System.Drawing.Point(4, 192)
        Me.btnBuy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(75, 23)
        Me.btnBuy.TabIndex = 1
        Me.btnBuy.Text = "Comprar"
        Me.btnBuy.UseVisualStyleBackColor = False
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbTablero As System.Windows.Forms.PictureBox
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents btnRolldice As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rs34 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs32 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs31 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs21 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs23 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs24 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs39 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs37 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs26 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs27 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs29 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs19 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs18 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs16 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs14 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs13 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs11 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents rs1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs28 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rs12 As Microsoft.VisualBasic.PowerPacks.RectangleShape
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

End Class
