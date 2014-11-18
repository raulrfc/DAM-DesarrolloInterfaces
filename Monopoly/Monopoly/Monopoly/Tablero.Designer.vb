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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tablero))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rollDice = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape23 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape22 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape21 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape20 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape19 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape18 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape16 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.pbTablero = New System.Windows.Forms.PictureBox()
        Me.RectangleShape17 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape24 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape25 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape26 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape27 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape28 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txtReport)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTurn)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rollDice)
        Me.Panel1.Controls.Add(Me.Logo)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(865, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 793)
        Me.Panel1.TabIndex = 1
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(-1, 441)
        Me.txtReport.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReport.Size = New System.Drawing.Size(291, 238)
        Me.txtReport.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(150, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(87, 35)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Turno"
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.BackColor = System.Drawing.Color.White
        Me.lblTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTurn.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.ForeColor = System.Drawing.Color.Red
        Me.lblTurn.Location = New System.Drawing.Point(243, 89)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Padding = New System.Windows.Forms.Padding(5)
        Me.lblTurn.Size = New System.Drawing.Size(34, 36)
        Me.lblTurn.TabIndex = 5
        Me.lblTurn.Text = "1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(186, 770)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 732)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'rollDice
        '
        Me.rollDice.BackColor = System.Drawing.Color.Salmon
        Me.rollDice.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.rollDice.FlatAppearance.BorderSize = 2
        Me.rollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rollDice.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollDice.ForeColor = System.Drawing.Color.Red
        Me.rollDice.Location = New System.Drawing.Point(3, 715)
        Me.rollDice.Name = "rollDice"
        Me.rollDice.Size = New System.Drawing.Size(137, 75)
        Me.rollDice.TabIndex = 1
        Me.rollDice.Text = "TIRAR DADOS"
        Me.rollDice.UseVisualStyleBackColor = False
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape28, Me.RectangleShape27, Me.RectangleShape26, Me.RectangleShape25, Me.RectangleShape24, Me.RectangleShape17, Me.RectangleShape23, Me.RectangleShape22, Me.RectangleShape21, Me.RectangleShape20, Me.RectangleShape19, Me.RectangleShape18, Me.RectangleShape16, Me.RectangleShape15, Me.RectangleShape14, Me.RectangleShape13, Me.RectangleShape12, Me.RectangleShape11, Me.RectangleShape10, Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(293, 793)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape23
        '
        Me.RectangleShape23.BackColor = System.Drawing.Color.White
        Me.RectangleShape23.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape23.BorderColor = System.Drawing.Color.Green
        Me.RectangleShape23.BorderWidth = 2
        Me.RectangleShape23.Location = New System.Drawing.Point(69, 322)
        Me.RectangleShape23.Name = "RectangleShape23"
        Me.RectangleShape23.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape22
        '
        Me.RectangleShape22.BackColor = System.Drawing.Color.White
        Me.RectangleShape22.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape22.BorderColor = System.Drawing.Color.Green
        Me.RectangleShape22.BorderWidth = 2
        Me.RectangleShape22.Location = New System.Drawing.Point(37, 322)
        Me.RectangleShape22.Name = "RectangleShape22"
        Me.RectangleShape22.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape21
        '
        Me.RectangleShape21.BackColor = System.Drawing.Color.White
        Me.RectangleShape21.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape21.BorderColor = System.Drawing.Color.Green
        Me.RectangleShape21.BorderWidth = 2
        Me.RectangleShape21.Location = New System.Drawing.Point(6, 322)
        Me.RectangleShape21.Name = "RectangleShape21"
        Me.RectangleShape21.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape20
        '
        Me.RectangleShape20.BackColor = System.Drawing.Color.White
        Me.RectangleShape20.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape20.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape20.BorderWidth = 2
        Me.RectangleShape20.Location = New System.Drawing.Point(6, 275)
        Me.RectangleShape20.Name = "RectangleShape20"
        Me.RectangleShape20.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape19
        '
        Me.RectangleShape19.BackColor = System.Drawing.Color.White
        Me.RectangleShape19.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape19.BorderWidth = 2
        Me.RectangleShape19.Location = New System.Drawing.Point(37, 275)
        Me.RectangleShape19.Name = "RectangleShape19"
        Me.RectangleShape19.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape18
        '
        Me.RectangleShape18.BackColor = System.Drawing.Color.White
        Me.RectangleShape18.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape18.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape18.BorderWidth = 2
        Me.RectangleShape18.Location = New System.Drawing.Point(69, 275)
        Me.RectangleShape18.Name = "RectangleShape18"
        Me.RectangleShape18.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape16
        '
        Me.RectangleShape16.BackColor = System.Drawing.Color.White
        Me.RectangleShape16.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape16.BorderColor = System.Drawing.Color.Blue
        Me.RectangleShape16.BorderWidth = 2
        Me.RectangleShape16.Location = New System.Drawing.Point(184, 322)
        Me.RectangleShape16.Name = "RectangleShape16"
        Me.RectangleShape16.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape15
        '
        Me.RectangleShape15.BackColor = System.Drawing.Color.White
        Me.RectangleShape15.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape15.BorderColor = System.Drawing.Color.Blue
        Me.RectangleShape15.BorderWidth = 2
        Me.RectangleShape15.Location = New System.Drawing.Point(153, 322)
        Me.RectangleShape15.Name = "RectangleShape15"
        Me.RectangleShape15.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape14
        '
        Me.RectangleShape14.BackColor = System.Drawing.Color.White
        Me.RectangleShape14.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape14.BorderColor = System.Drawing.Color.Yellow
        Me.RectangleShape14.BorderWidth = 2
        Me.RectangleShape14.Location = New System.Drawing.Point(153, 276)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BackColor = System.Drawing.Color.White
        Me.RectangleShape13.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape13.BorderColor = System.Drawing.Color.Yellow
        Me.RectangleShape13.BorderWidth = 2
        Me.RectangleShape13.Location = New System.Drawing.Point(184, 276)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BackColor = System.Drawing.Color.White
        Me.RectangleShape12.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape12.BorderColor = System.Drawing.Color.Yellow
        Me.RectangleShape12.BorderWidth = 2
        Me.RectangleShape12.Location = New System.Drawing.Point(216, 276)
        Me.RectangleShape12.Name = "RectangleShape12"
        Me.RectangleShape12.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BackColor = System.Drawing.Color.White
        Me.RectangleShape11.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape11.BorderWidth = 2
        Me.RectangleShape11.Location = New System.Drawing.Point(216, 230)
        Me.RectangleShape11.Name = "RectangleShape11"
        Me.RectangleShape11.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BackColor = System.Drawing.Color.White
        Me.RectangleShape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape10.BorderWidth = 2
        Me.RectangleShape10.Location = New System.Drawing.Point(184, 230)
        Me.RectangleShape10.Name = "RectangleShape10"
        Me.RectangleShape10.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BackColor = System.Drawing.Color.White
        Me.RectangleShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape9.BorderWidth = 2
        Me.RectangleShape9.Location = New System.Drawing.Point(153, 230)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackColor = System.Drawing.Color.White
        Me.RectangleShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape8.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.Location = New System.Drawing.Point(69, 228)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BackColor = System.Drawing.Color.White
        Me.RectangleShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape7.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.Location = New System.Drawing.Point(37, 228)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.Color.White
        Me.RectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape6.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.Location = New System.Drawing.Point(6, 228)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.Color.White
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.Location = New System.Drawing.Point(216, 184)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.White
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.Location = New System.Drawing.Point(153, 184)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.White
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.Location = New System.Drawing.Point(184, 184)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.White
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Purple
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(37, 182)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(25, 41)
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 292
        Me.LineShape3.Y1 = 686
        Me.LineShape3.Y2 = 686
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 292
        Me.LineShape2.Y1 = 430
        Me.LineShape2.Y2 = 430
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 291
        Me.LineShape1.Y1 = 173
        Me.LineShape1.Y2 = 173
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Purple
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(6, 182)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(25, 41)
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
        'RectangleShape17
        '
        Me.RectangleShape17.BackColor = System.Drawing.Color.White
        Me.RectangleShape17.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape17.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape17.BorderWidth = 2
        Me.RectangleShape17.Location = New System.Drawing.Point(7, 377)
        Me.RectangleShape17.Name = "RectangleShape17"
        Me.RectangleShape17.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape24
        '
        Me.RectangleShape24.BackColor = System.Drawing.Color.White
        Me.RectangleShape24.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape24.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape24.BorderWidth = 2
        Me.RectangleShape24.Location = New System.Drawing.Point(38, 377)
        Me.RectangleShape24.Name = "RectangleShape24"
        Me.RectangleShape24.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape25
        '
        Me.RectangleShape25.BackColor = System.Drawing.Color.White
        Me.RectangleShape25.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape25.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape25.BorderWidth = 2
        Me.RectangleShape25.Location = New System.Drawing.Point(70, 377)
        Me.RectangleShape25.Name = "RectangleShape25"
        Me.RectangleShape25.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape26
        '
        Me.RectangleShape26.BackColor = System.Drawing.Color.White
        Me.RectangleShape26.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape26.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape26.BorderWidth = 2
        Me.RectangleShape26.Location = New System.Drawing.Point(103, 377)
        Me.RectangleShape26.Name = "RectangleShape26"
        Me.RectangleShape26.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape27
        '
        Me.RectangleShape27.BackColor = System.Drawing.Color.White
        Me.RectangleShape27.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape27.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape27.BorderWidth = 2
        Me.RectangleShape27.Location = New System.Drawing.Point(152, 376)
        Me.RectangleShape27.Name = "RectangleShape27"
        Me.RectangleShape27.Size = New System.Drawing.Size(25, 41)
        '
        'RectangleShape28
        '
        Me.RectangleShape28.BackColor = System.Drawing.Color.White
        Me.RectangleShape28.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape28.BorderColor = System.Drawing.Color.Aqua
        Me.RectangleShape28.BorderWidth = 2
        Me.RectangleShape28.Location = New System.Drawing.Point(183, 376)
        Me.RectangleShape28.Name = "RectangleShape28"
        Me.RectangleShape28.Size = New System.Drawing.Size(25, 41)
        '
        'Tablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 794)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbTablero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tablero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monopoly"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbTablero As System.Windows.Forms.PictureBox
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents rollDice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape23 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape22 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape21 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape20 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape19 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape18 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape16 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape15 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape14 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape13 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape12 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape11 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape28 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape27 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape26 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape25 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape24 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape17 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
