<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedTextEditor))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblCountWords = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCountWords2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReemplazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.contextMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeshacerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasExceptoEstaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.mnu.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.contextMnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(684, 378)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(684, 450)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.mnu)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        Me.ToolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCountWords, Me.lblCountWords2, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip.TabIndex = 0
        '
        'lblCountWords
        '
        Me.lblCountWords.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lblCountWords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCountWords.Name = "lblCountWords"
        Me.lblCountWords.Size = New System.Drawing.Size(68, 17)
        Me.lblCountWords.Text = "Caracteres: "
        '
        'lblCountWords2
        '
        Me.lblCountWords2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lblCountWords2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCountWords2.Name = "lblCountWords2"
        Me.lblCountWords2.Size = New System.Drawing.Size(13, 17)
        Me.lblCountWords2.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "Palabras:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel2.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(114, 17)
        Me.ToolStripStatusLabel3.Text = "Tiempo trabajando: "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(684, 378)
        Me.TabControl1.TabIndex = 0
        '
        'mnu
        '
        Me.mnu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.mnu.Dock = System.Windows.Forms.DockStyle.None
        Me.mnu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnu.Size = New System.Drawing.Size(684, 25)
        Me.mnu.TabIndex = 0
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.NuevoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NuevoToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_insert_drive_file_black_18dp
        Me.NuevoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        Me.NuevoToolStripMenuItem.ToolTipText = "Crea un nuevo documento de texto"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.AbrirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AbrirToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_folder_open_black_18dp
        Me.AbrirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        Me.AbrirToolStripMenuItem.ToolTipText = "Abre un documento de texto"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.GuardarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GuardarToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_save_black_18dp
        Me.GuardarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        Me.GuardarToolStripMenuItem.ToolTipText = "Guarda el documento"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.GuardarComoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar como..."
        Me.GuardarComoToolStripMenuItem.ToolTipText = "Guarda el documento con un formato y localización personalizadas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.ToolTipText = "Salir del programa"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.CortarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ReemplazarToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.DeshacerToolStripMenuItem})
        Me.EditarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(105, 21)
        Me.EditarToolStripMenuItem.Text = "Herramientas"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.CopiarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CopiarToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_content_copy_black_18dp
        Me.CopiarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        Me.CopiarToolStripMenuItem.ToolTipText = "Copia el texto seleccionado al portapapeles"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.CortarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CortarToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_content_cut_black_18dp
        Me.CortarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        Me.CortarToolStripMenuItem.ToolTipText = "Corta el texto seleccionado al portapapeles"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.PegarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PegarToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_content_paste_black_18dp
        Me.PegarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        Me.PegarToolStripMenuItem.ToolTipText = "Pega un texto anteriormente cortado o copiado"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BuscarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BuscarToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_search_black_24dp
        Me.BuscarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        Me.BuscarToolStripMenuItem.ToolTipText = "Busca caracteres o palabras en el texto"
        '
        'ReemplazarToolStripMenuItem
        '
        Me.ReemplazarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ReemplazarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReemplazarToolStripMenuItem.Name = "ReemplazarToolStripMenuItem"
        Me.ReemplazarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReemplazarToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ReemplazarToolStripMenuItem.Text = "Reemplazar"
        Me.ReemplazarToolStripMenuItem.ToolTipText = "Reemplaza palabras del texto"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.SeleccionarTodoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        Me.SeleccionarTodoToolStripMenuItem.ToolTipText = "Seleccionar todo el texto"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.RehacerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RehacerToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_redo_black_24dp
        Me.RehacerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        Me.RehacerToolStripMenuItem.ToolTipText = "Rehace la última acción eliminada"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.DeshacerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeshacerToolStripMenuItem.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_undo_black_24dp
        Me.DeshacerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        Me.DeshacerToolStripMenuItem.ToolTipText = "Deshace la última acción"
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator5, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripButton13, Me.ToolStripButton14, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSeparator3, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripSeparator4, Me.ToolStripComboBox1, Me.ToolStripComboBox2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(684, 25)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 1
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_insert_drive_file_black_18dp
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "ToolStripButton10"
        Me.ToolStripButton10.ToolTipText = "Nuevo"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_folder_open_black_18dp
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "ToolStripButton11"
        Me.ToolStripButton11.ToolTipText = "Abrir"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_save_black_18dp
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "ToolStripButton12"
        Me.ToolStripButton12.ToolTipText = "Guardar "
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripButton1.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_format_bold_black_18dp
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "N"
        Me.ToolStripButton1.ToolTipText = "Negrita"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripButton2.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_format_italic_black_18dp
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "I"
        Me.ToolStripButton2.ToolTipText = "Cursiva"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline)
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripButton3.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_format_underline_black_18dp
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "S"
        Me.ToolStripButton3.ToolTipText = "Subrayado"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Strikeout)
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripButton4.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_format_strikethrough_black_18dp
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "abc"
        Me.ToolStripButton4.ToolTipText = "Tachado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_undo_black_24dp
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "ToolStripButton13"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_redo_black_24dp
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "ToolStripButton14"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(28, 22)
        Me.ToolStripButton6.Text = "A+"
        Me.ToolStripButton6.ToolTipText = "Incrementar tamaño de fuente"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripButton7.Text = "A-"
        Me.ToolStripButton7.ToolTipText = "Reducir tamaño de fuente"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton8.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton8.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_format_color_text_black_18dp
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "A"
        Me.ToolStripButton8.ToolTipText = "Cambiar color de letra"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ToolStripButton9.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton9.Image = Global.AdvancedTextEditor.My.Resources.Resources.ic_format_color_fill_black_18dp
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "!"
        Me.ToolStripButton9.ToolTipText = "Cambiar color de fondo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.DropDownWidth = 180
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(190, 25)
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(100, 25)
        '
        'ofd
        '
        Me.ofd.DefaultExt = "txt"
        Me.ofd.Filter = "Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*"
        '
        'sfd
        '
        Me.sfd.DefaultExt = "txt"
        Me.sfd.Filter = "Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*"
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'contextMnu
        '
        Me.contextMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem1, Me.RehacerToolStripMenuItem1, Me.CortarToolStripMenuItem1, Me.CopiarToolStripMenuItem1, Me.PegarToolStripMenuItem1, Me.GuardarToolStripMenuItem1, Me.CerrarToolStripMenuItem1, Me.CerrarTodasToolStripMenuItem1, Me.CerrarTodasExceptoEstaToolStripMenuItem1})
        Me.contextMnu.Name = "contextMnu"
        Me.contextMnu.Size = New System.Drawing.Size(207, 202)
        '
        'DeshacerToolStripMenuItem1
        '
        Me.DeshacerToolStripMenuItem1.Name = "DeshacerToolStripMenuItem1"
        Me.DeshacerToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.DeshacerToolStripMenuItem1.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem1
        '
        Me.RehacerToolStripMenuItem1.Name = "RehacerToolStripMenuItem1"
        Me.RehacerToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.RehacerToolStripMenuItem1.Text = "Rehacer"
        '
        'CortarToolStripMenuItem1
        '
        Me.CortarToolStripMenuItem1.Name = "CortarToolStripMenuItem1"
        Me.CortarToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.CortarToolStripMenuItem1.Text = "Cortar"
        '
        'CopiarToolStripMenuItem1
        '
        Me.CopiarToolStripMenuItem1.Name = "CopiarToolStripMenuItem1"
        Me.CopiarToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.CopiarToolStripMenuItem1.Text = "Copiar"
        '
        'PegarToolStripMenuItem1
        '
        Me.PegarToolStripMenuItem1.Name = "PegarToolStripMenuItem1"
        Me.PegarToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.PegarToolStripMenuItem1.Text = "Pegar"
        '
        'GuardarToolStripMenuItem1
        '
        Me.GuardarToolStripMenuItem1.Name = "GuardarToolStripMenuItem1"
        Me.GuardarToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.GuardarToolStripMenuItem1.Text = "Guardar"
        '
        'CerrarToolStripMenuItem1
        '
        Me.CerrarToolStripMenuItem1.Name = "CerrarToolStripMenuItem1"
        Me.CerrarToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.CerrarToolStripMenuItem1.Text = "Cerrar"
        '
        'CerrarTodasToolStripMenuItem1
        '
        Me.CerrarTodasToolStripMenuItem1.Name = "CerrarTodasToolStripMenuItem1"
        Me.CerrarTodasToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.CerrarTodasToolStripMenuItem1.Text = "Cerrar todas"
        '
        'CerrarTodasExceptoEstaToolStripMenuItem1
        '
        Me.CerrarTodasExceptoEstaToolStripMenuItem1.Name = "CerrarTodasExceptoEstaToolStripMenuItem1"
        Me.CerrarTodasExceptoEstaToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.CerrarTodasExceptoEstaToolStripMenuItem1.Text = "Cerrar todas excepto esta"
        '
        'AdvancedTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(650, 450)
        Me.Name = "AdvancedTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AwesomeTextEditor"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.contextMnu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReemplazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents contextMnu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeshacerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarTodasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarTodasExceptoEstaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblCountWords As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCountWords2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton

End Class
