Imports System.Drawing.Text
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.IO


Public Class AdvancedTextEditor

    Dim TabCount As Integer = 0
    Dim dateStart As Date

#Region "Methods"

#Region "Tabs"

    Private Sub AddTab()
        Dim Body As New RichTextBox()

        Body.Name = "Body"
        Body.Dock = DockStyle.Fill
        Body.ContextMenuStrip = contextMnu

        Dim NewPage As New TabPage()
        TabCount += 1

        Dim DocumentText As String = "Document " & TabCount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        TabControl1.TabPages.Add(NewPage)
    End Sub

    Private Sub RemoveTab()

        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            AddTab()
        End If

    End Sub

    Private Sub RemoveAllTabs()
        For Each Page As TabPage In TabControl1.TabPages
            TabControl1.TabPages.Remove(Page)
        Next

        AddTab()
    End Sub

    Private Sub RemoveAllTabsExceptFocus()

        For Each Page As TabPage In TabControl1.TabPages
            If Not Page.Name = TabControl1.SelectedTab.Name Then
                TabControl1.TabPages.Remove(Page)
            End If
        Next
    End Sub

#End Region

#Region "SaveAndOpen"

    Private Sub Save()
        sfd.FileName = TabControl1.SelectedTab.Name
        sfd.Filter = "RTF|*.rtf"
        sfd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        sfd.Title = "Save"

        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then

            If sfd.FileName.Length > 0 Then
                GetCurrentDocument.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText)
            End If

        End If
    End Sub

    Private Sub SaveAs()
        sfd.FileName = TabControl1.SelectedTab.Name
        sfd.Filter = "Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*"
        sfd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        sfd.Title = "Save As"

        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then

            If sfd.FileName.Length > 0 Then
                GetCurrentDocument.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText)
            End If

        End If
    End Sub

    Private Sub Open()
        ofd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        ofd.Filter = "RTF|*.rtf|Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*"

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If ofd.FileName.Length > 0 AndAlso StrComp(Path.GetExtension(ofd.FileName), ".rtf") = 0 Then
                GetCurrentDocument.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText)
            Else
                GetCurrentDocument.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText)
            End If
        End If
    End Sub

#End Region

#Region "Text Functions"
    Private Sub Undo()
        GetCurrentDocument.Undo()
    End Sub

    Private Sub Redo()
        GetCurrentDocument.Redo()
    End Sub
    Private Sub Cut()
        GetCurrentDocument.Cut()
    End Sub

    Private Sub Copy()
        GetCurrentDocument.Copy()
    End Sub

    Private Sub Paste()
        GetCurrentDocument.Paste()
    End Sub

    Private Sub SelectAll()
        GetCurrentDocument.SelectAll()
    End Sub

#End Region

#Region "General"
    Private Sub GetFontCollection()

        Dim InsFont As New InstalledFontCollection()

        For Each item As FontFamily In InsFont.Families
            ToolStripComboBox1.Items.Add(item.Name)
        Next
        ToolStripComboBox1.SelectedIndex = 0

    End Sub

    Private Sub PopulateFontSizes()
        For i = 1 To 75
            ToolStripComboBox2.Items.Add(i)
        Next

        ToolStripComboBox2.SelectedIndex = 11

    End Sub
#End Region

#End Region

#Region "Properties"
    Public ReadOnly Property GetCurrentDocument() As RichTextBox
        Get
            Return CType(TabControl1.SelectedTab.Controls.Item("Body"), RichTextBox)
        End Get
    End Property
#End Region

#Region "Paint"

    Private Sub mnu_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles mnu.Paint

        Dim targetRect As New Rectangle(0, 0, mnu.Width, mnu.Height)

        Dim brush As New System.Drawing.Drawing2D.LinearGradientBrush(targetRect, Color.DarkSlateBlue, Color.MediumPurple, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(brush, targetRect)

    End Sub
    Private Sub ToolStrip1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ToolStrip.Paint

        Dim targetRect As New Rectangle(0, 0, ToolStrip.Width, ToolStrip.Height)

        Dim brush As New System.Drawing.Drawing2D.LinearGradientBrush(targetRect, Color.DarkSlateBlue, Color.MediumPurple, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(brush, targetRect)

    End Sub

    Private Sub StatusStrip_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles StatusStrip.Paint

        Dim targetRect As New Rectangle(0, 0, ToolStrip.Width, ToolStrip.Height)

        Dim brush As New System.Drawing.Drawing2D.LinearGradientBrush(targetRect, Color.DarkSlateBlue, Color.MediumPurple, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(brush, targetRect)

    End Sub

    Private Sub AdvancedTextEditor_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim targetRect As New Rectangle(0, 0, MyBase.Width, MyBase.Height)

        Dim brush As New System.Drawing.Drawing2D.LinearGradientBrush(targetRect, Color.DarkSlateBlue, Color.MediumPurple, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(brush, targetRect)

    End Sub

#End Region

#Region "Events"

#Region "General"
    Private Sub AdvancedTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddTab()
        GetFontCollection()
        PopulateFontSizes()
        dateStart = Date.Now

    End Sub

    Public Function CountWords(ByVal value As String) As Integer
        Dim collection As MatchCollection = Regex.Matches(value, "\S+")
        Return collection.Count
    End Function

    Private Sub time()
        Dim dateNow As Date = Date.Now
        Dim time As TimeSpan

        time = dateNow.Subtract(dateStart)
        ToolStripStatusLabel4.Text = time.Seconds.ToString & "s"
        If time.Minutes > 0 Then
            ToolStripStatusLabel4.Text = time.Minutes.ToString & "m:" & time.Seconds.ToString & "s"
        End If
        If time.Hours > 0 Then
            ToolStripStatusLabel4.Text = time.Hours.ToString & "h:" & time.Minutes.ToString & "m:" & time.Seconds.ToString & "s"
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        time()
        If GetCurrentDocument.Text.Length > 0 Then
            lblCountWords2.Text = GetCurrentDocument.Text.Length
            ToolStripStatusLabel2.Text = CountWords(GetCurrentDocument.Text)
        End If

    End Sub
#End Region

#Region "Menu"

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        AddTab()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Open()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        SaveAs()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        SelectAll()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Buscar.Show()
    End Sub

    Private Sub ReemplazarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReemplazarToolStripMenuItem.Click
        Buscar.Show()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        AddTab()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        Open()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Save()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        Undo()
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Redo()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

    End Sub
#End Region

#Region "Toolbar"

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim BoldFont As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Bold)
        Dim RegularFont As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Regular)

        If GetCurrentDocument.SelectionFont.Bold Then
            GetCurrentDocument.SelectionFont = RegularFont
        Else
            GetCurrentDocument.SelectionFont = BoldFont
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim ItalicFont As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Italic)
        Dim RegularFont As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Regular)

        If GetCurrentDocument.SelectionFont.Italic Then
            GetCurrentDocument.SelectionFont = RegularFont
        Else
            GetCurrentDocument.SelectionFont = ItalicFont
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim UnderlineFont As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Underline)
        Dim RegularFont As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Regular)

        If GetCurrentDocument.SelectionFont.Underline Then
            GetCurrentDocument.SelectionFont = RegularFont
        Else
            GetCurrentDocument.SelectionFont = UnderlineFont
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim Strikeout As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Strikeout)
        Dim RegularFont As New Font(GetCurrentDocument.SelectionFont.Name, GetCurrentDocument.SelectionFont.Size, FontStyle.Regular)

        If GetCurrentDocument.SelectionFont.Strikeout Then
            GetCurrentDocument.SelectionFont = RegularFont
        Else
            GetCurrentDocument.SelectionFont = Strikeout
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click

        Dim NewFontSize As Single = GetCurrentDocument.SelectionFont.Size + 2

        Dim NewFont As New Font(GetCurrentDocument.SelectionFont.Name, NewFontSize, GetCurrentDocument.SelectionFont.Style)

        GetCurrentDocument.SelectionFont = NewFont

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim NewFontSize As Single = GetCurrentDocument.SelectionFont.Size - 2

        Dim NewFont As New Font(GetCurrentDocument.SelectionFont.Name, NewFontSize, GetCurrentDocument.SelectionFont.Style)

        GetCurrentDocument.SelectionFont = NewFont
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click

        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            GetCurrentDocument.SelectionColor = ColorDialog.Color

        End If

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click

        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            GetCurrentDocument.SelectionBackColor = ColorDialog.Color

        End If

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Dim NewFont As New Font(ToolStripComboBox1.SelectedItem.ToString(), _
                                GetCurrentDocument.SelectionFont.Size, GetCurrentDocument.SelectionFont.Style)

        GetCurrentDocument.SelectionFont = NewFont
    End Sub

    Private Sub ToolStripComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        Dim NewSize As Single = ToolStripComboBox2.SelectedItem

        Dim NewFont As New Font(GetCurrentDocument.SelectionFont.Name, NewSize, GetCurrentDocument.SelectionFont.Style)

        GetCurrentDocument.SelectionFont = NewFont
    End Sub

#End Region

#Region "ContextMenu"

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem1.Click
        Undo()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem1.Click
        Redo()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem1.Click
        Cut()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem1.Click
        Copy()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem1.Click
        Paste()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        Save()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        RemoveTab()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles CerrarTodasToolStripMenuItem1.Click
        RemoveAllTabs()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles CerrarTodasExceptoEstaToolStripMenuItem1.Click
        RemoveAllTabsExceptFocus()
    End Sub

#End Region

#End Region



End Class
