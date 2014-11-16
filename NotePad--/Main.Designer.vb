<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItemNew = New System.Windows.Forms.MenuItem()
        Me.MenuItemOpen = New System.Windows.Forms.MenuItem()
        Me.MenuItemSave = New System.Windows.Forms.MenuItem()
        Me.MenuItemSaveAs = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItemPrint = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItemExit = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItemUndo = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCut = New System.Windows.Forms.MenuItem()
        Me.MenuItemCopy = New System.Windows.Forms.MenuItem()
        Me.MenuItemPaste = New System.Windows.Forms.MenuItem()
        Me.MenuItemDelete = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItemFind = New System.Windows.Forms.MenuItem()
        Me.MenuItemGoTo = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItemSelectAll = New System.Windows.Forms.MenuItem()
        Me.MenuItemTimeDate = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItemWordWrap = New System.Windows.Forms.MenuItem()
        Me.MenuItemFontStyle = New System.Windows.Forms.MenuItem()
        Me.MenuItemFontColor = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItemStatusBar = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItemViewHelp = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItemAbout = New System.Windows.Forms.MenuItem()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemNew, Me.MenuItemOpen, Me.MenuItemSave, Me.MenuItemSaveAs, Me.MenuItem10, Me.MenuItemPrint, Me.MenuItem12, Me.MenuItemExit})
        Me.MenuItem1.Text = "File"
        '
        'MenuItemNew
        '
        Me.MenuItemNew.Index = 0
        Me.MenuItemNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItemNew.Text = "New"
        '
        'MenuItemOpen
        '
        Me.MenuItemOpen.Index = 1
        Me.MenuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItemOpen.Text = "Open..."
        '
        'MenuItemSave
        '
        Me.MenuItemSave.Index = 2
        Me.MenuItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItemSave.Text = "Save"
        '
        'MenuItemSaveAs
        '
        Me.MenuItemSaveAs.Index = 3
        Me.MenuItemSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
        Me.MenuItemSaveAs.Text = "Save As..."
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 4
        Me.MenuItem10.Text = "-"
        '
        'MenuItemPrint
        '
        Me.MenuItemPrint.Index = 5
        Me.MenuItemPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItemPrint.Text = "Print..."
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 6
        Me.MenuItem12.Text = "-"
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Index = 7
        Me.MenuItemExit.Text = "Exit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemUndo, Me.MenuItem7, Me.MenuItemCut, Me.MenuItemCopy, Me.MenuItemPaste, Me.MenuItemDelete, Me.MenuItem8, Me.MenuItemFind, Me.MenuItemGoTo, Me.MenuItem6, Me.MenuItemSelectAll, Me.MenuItemTimeDate})
        Me.MenuItem2.Text = "Edit"
        '
        'MenuItemUndo
        '
        Me.MenuItemUndo.Index = 0
        Me.MenuItemUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItemUndo.Text = "Undo"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "-"
        '
        'MenuItemCut
        '
        Me.MenuItemCut.Index = 2
        Me.MenuItemCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItemCut.Text = "Cut"
        '
        'MenuItemCopy
        '
        Me.MenuItemCopy.Index = 3
        Me.MenuItemCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItemCopy.Text = "Copy"
        '
        'MenuItemPaste
        '
        Me.MenuItemPaste.Index = 4
        Me.MenuItemPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItemPaste.Text = "Paste"
        '
        'MenuItemDelete
        '
        Me.MenuItemDelete.Index = 5
        Me.MenuItemDelete.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.MenuItemDelete.Text = "Delete"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "-"
        '
        'MenuItemFind
        '
        Me.MenuItemFind.Index = 7
        Me.MenuItemFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItemFind.Text = "Find..."
        '
        'MenuItemGoTo
        '
        Me.MenuItemGoTo.Index = 8
        Me.MenuItemGoTo.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.MenuItemGoTo.Text = "Go to..."
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Text = "-"
        '
        'MenuItemSelectAll
        '
        Me.MenuItemSelectAll.Index = 10
        Me.MenuItemSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.MenuItemSelectAll.Text = "Select All"
        '
        'MenuItemTimeDate
        '
        Me.MenuItemTimeDate.Index = 11
        Me.MenuItemTimeDate.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItemTimeDate.Text = "Time/Date"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemWordWrap, Me.MenuItemFontStyle, Me.MenuItemFontColor})
        Me.MenuItem3.Text = "Format"
        '
        'MenuItemWordWrap
        '
        Me.MenuItemWordWrap.Index = 0
        Me.MenuItemWordWrap.Text = "Word Wrap"
        '
        'MenuItemFontStyle
        '
        Me.MenuItemFontStyle.Index = 1
        Me.MenuItemFontStyle.Text = "Font Style..."
        '
        'MenuItemFontColor
        '
        Me.MenuItemFontColor.Index = 2
        Me.MenuItemFontColor.Text = "Font Color..."
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemStatusBar})
        Me.MenuItem4.Text = "View"
        '
        'MenuItemStatusBar
        '
        Me.MenuItemStatusBar.Index = 0
        Me.MenuItemStatusBar.Text = "Status Bar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemViewHelp, Me.MenuItem21, Me.MenuItemAbout})
        Me.MenuItem5.Text = "Help"
        '
        'MenuItemViewHelp
        '
        Me.MenuItemViewHelp.Index = 0
        Me.MenuItemViewHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItemViewHelp.Text = "View Help"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 1
        Me.MenuItem21.Text = "-"
        '
        'MenuItemAbout
        '
        Me.MenuItemAbout.Index = 2
        Me.MenuItemAbout.Text = "About Notepad--"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 319)
        Me.StatusBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(384, 22)
        Me.StatusBar1.TabIndex = 0
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Ln 1, Col 1"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.HideSelection = False
        Me.TextBox2.Location = New System.Drawing.Point(134, 25)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(271, 248)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Tag = ""
        Me.TextBox2.Visible = False
        Me.TextBox2.WordWrap = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "%userprofile%\Desktop"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.DetectUrls = False
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.TextBox1.Size = New System.Drawing.Size(213, 195)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        Me.TextBox1.WordWrap = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Untitled - Notepad--"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemNew As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOpen As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSave As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSaveAs As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemPrint As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCut As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCopy As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemPaste As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MenuItemWordWrap As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFontStyle As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemViewHelp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAbout As System.Windows.Forms.MenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MenuItemStatusBar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFontColor As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MenuItemUndo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFind As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemTimeDate As System.Windows.Forms.MenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItemGoTo As System.Windows.Forms.MenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
