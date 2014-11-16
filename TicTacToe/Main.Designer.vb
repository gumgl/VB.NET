<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelPlayer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelXwins = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelOwins = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BTNreset = New System.Windows.Forms.ToolStripSplitButton()
        Me.PNLboard = New System.Windows.Forms.Panel()
        Me.PNLmiddleH = New System.Windows.Forms.Panel()
        Me.PNLmiddleV = New System.Windows.Forms.Panel()
        Me.PNLbottom = New System.Windows.Forms.Panel()
        Me.PNLtop = New System.Windows.Forms.Panel()
        Me.PNLright = New System.Windows.Forms.Panel()
        Me.PNLleft = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TMRtime = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItemNew = New System.Windows.Forms.MenuItem()
        Me.MenuItemSave = New System.Windows.Forms.MenuItem()
        Me.MenuItemOpen = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItemUndo = New System.Windows.Forms.MenuItem()
        Me.MenuItemRedo = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItemStats = New System.Windows.Forms.MenuItem()
        Me.MenuItemOptions = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItemExit = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.PNLboard.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowItemReorder = True
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelTimer, Me.ToolStripStatusLabelPlayer, Me.ToolStripStatusLabelXwins, Me.ToolStripStatusLabelOwins, Me.BTNreset})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 400)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(400, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelTimer
        '
        Me.ToolStripStatusLabelTimer.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelTimer.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabelTimer.Name = "ToolStripStatusLabelTimer"
        Me.ToolStripStatusLabelTimer.Size = New System.Drawing.Size(103, 19)
        Me.ToolStripStatusLabelTimer.Spring = True
        Me.ToolStripStatusLabelTimer.Text = "Time: 0:00"
        '
        'ToolStripStatusLabelPlayer
        '
        Me.ToolStripStatusLabelPlayer.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelPlayer.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabelPlayer.Name = "ToolStripStatusLabelPlayer"
        Me.ToolStripStatusLabelPlayer.Size = New System.Drawing.Size(99, 19)
        Me.ToolStripStatusLabelPlayer.Text = "Current Player: X"
        '
        'ToolStripStatusLabelXwins
        '
        Me.ToolStripStatusLabelXwins.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelXwins.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabelXwins.Name = "ToolStripStatusLabelXwins"
        Me.ToolStripStatusLabelXwins.Size = New System.Drawing.Size(57, 19)
        Me.ToolStripStatusLabelXwins.Text = "X wins: 0"
        '
        'ToolStripStatusLabelOwins
        '
        Me.ToolStripStatusLabelOwins.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelOwins.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabelOwins.Name = "ToolStripStatusLabelOwins"
        Me.ToolStripStatusLabelOwins.Size = New System.Drawing.Size(59, 19)
        Me.ToolStripStatusLabelOwins.Text = "O wins: 0"
        '
        'BTNreset
        '
        Me.BTNreset.BackColor = System.Drawing.SystemColors.Window
        Me.BTNreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BTNreset.DropDownButtonWidth = 0
        Me.BTNreset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNreset.Name = "BTNreset"
        Me.BTNreset.Size = New System.Drawing.Size(67, 22)
        Me.BTNreset.Text = "Reset wins"
        '
        'PNLboard
        '
        Me.PNLboard.BackColor = System.Drawing.Color.Black
        Me.PNLboard.Controls.Add(Me.PNLmiddleH)
        Me.PNLboard.Controls.Add(Me.PNLmiddleV)
        Me.PNLboard.Controls.Add(Me.PNLbottom)
        Me.PNLboard.Controls.Add(Me.PNLtop)
        Me.PNLboard.Controls.Add(Me.PNLright)
        Me.PNLboard.Controls.Add(Me.PNLleft)
        Me.PNLboard.Controls.Add(Me.PictureBox9)
        Me.PNLboard.Controls.Add(Me.PictureBox8)
        Me.PNLboard.Controls.Add(Me.PictureBox7)
        Me.PNLboard.Controls.Add(Me.PictureBox6)
        Me.PNLboard.Controls.Add(Me.PictureBox5)
        Me.PNLboard.Controls.Add(Me.PictureBox4)
        Me.PNLboard.Controls.Add(Me.PictureBox3)
        Me.PNLboard.Controls.Add(Me.PictureBox2)
        Me.PNLboard.Controls.Add(Me.PictureBox1)
        Me.PNLboard.Location = New System.Drawing.Point(0, 0)
        Me.PNLboard.Name = "PNLboard"
        Me.PNLboard.Size = New System.Drawing.Size(400, 400)
        Me.PNLboard.TabIndex = 1
        '
        'PNLmiddleH
        '
        Me.PNLmiddleH.BackColor = System.Drawing.Color.Lime
        Me.PNLmiddleH.Location = New System.Drawing.Point(56, 192)
        Me.PNLmiddleH.Name = "PNLmiddleH"
        Me.PNLmiddleH.Size = New System.Drawing.Size(288, 16)
        Me.PNLmiddleH.TabIndex = 15
        '
        'PNLmiddleV
        '
        Me.PNLmiddleV.BackColor = System.Drawing.Color.Lime
        Me.PNLmiddleV.Location = New System.Drawing.Point(192, 56)
        Me.PNLmiddleV.Name = "PNLmiddleV"
        Me.PNLmiddleV.Size = New System.Drawing.Size(16, 288)
        Me.PNLmiddleV.TabIndex = 14
        '
        'PNLbottom
        '
        Me.PNLbottom.BackColor = System.Drawing.Color.Lime
        Me.PNLbottom.Location = New System.Drawing.Point(56, 328)
        Me.PNLbottom.Name = "PNLbottom"
        Me.PNLbottom.Size = New System.Drawing.Size(288, 16)
        Me.PNLbottom.TabIndex = 15
        '
        'PNLtop
        '
        Me.PNLtop.BackColor = System.Drawing.Color.Lime
        Me.PNLtop.Location = New System.Drawing.Point(56, 56)
        Me.PNLtop.Name = "PNLtop"
        Me.PNLtop.Size = New System.Drawing.Size(288, 16)
        Me.PNLtop.TabIndex = 14
        '
        'PNLright
        '
        Me.PNLright.BackColor = System.Drawing.Color.Lime
        Me.PNLright.Location = New System.Drawing.Point(328, 56)
        Me.PNLright.Name = "PNLright"
        Me.PNLright.Size = New System.Drawing.Size(16, 288)
        Me.PNLright.TabIndex = 14
        '
        'PNLleft
        '
        Me.PNLleft.BackColor = System.Drawing.Color.Lime
        Me.PNLleft.Location = New System.Drawing.Point(56, 56)
        Me.PNLleft.Name = "PNLleft"
        Me.PNLleft.Size = New System.Drawing.Size(16, 288)
        Me.PNLleft.TabIndex = 13
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(272, 272)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 12
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(136, 272)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(0, 272)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 10
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(272, 136)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(136, 136)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 136)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(272, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(136, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TMRtime
        '
        Me.TMRtime.Interval = 1000
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemNew, Me.MenuItemSave, Me.MenuItemOpen, Me.MenuItem3, Me.MenuItemUndo, Me.MenuItemRedo, Me.MenuItem6, Me.MenuItemStats, Me.MenuItemOptions, Me.MenuItem7, Me.MenuItemExit})
        Me.MenuItem1.Text = "Game"
        '
        'MenuItemNew
        '
        Me.MenuItemNew.Index = 0
        Me.MenuItemNew.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItemNew.Text = "New Game"
        '
        'MenuItemSave
        '
        Me.MenuItemSave.Enabled = False
        Me.MenuItemSave.Index = 1
        Me.MenuItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItemSave.Text = "Save Game..."
        '
        'MenuItemOpen
        '
        Me.MenuItemOpen.Index = 2
        Me.MenuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItemOpen.Text = "Open Game..."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "-"
        '
        'MenuItemUndo
        '
        Me.MenuItemUndo.Enabled = False
        Me.MenuItemUndo.Index = 4
        Me.MenuItemUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItemUndo.Text = "Undo"
        '
        'MenuItemRedo
        '
        Me.MenuItemRedo.Enabled = False
        Me.MenuItemRedo.Index = 5
        Me.MenuItemRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY
        Me.MenuItemRedo.Text = "Redo"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "-"
        '
        'MenuItemStats
        '
        Me.MenuItemStats.Index = 7
        Me.MenuItemStats.Text = "Statistics"
        '
        'MenuItemOptions
        '
        Me.MenuItemOptions.Index = 8
        Me.MenuItemOptions.Text = "Options"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 9
        Me.MenuItem7.Text = "-"
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Index = 10
        Me.MenuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.MenuItemExit.Text = "Exit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem2.Text = "Help"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem4.Text = "View Help"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.Ctrl0
        Me.MenuItem5.Text = "Hack wins"
        Me.MenuItem5.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "ttt"
        Me.OpenFileDialog1.Title = "Open a saved game"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "ttt"
        Me.SaveFileDialog1.Title = "Save current game"
        '
        'FRMmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(400, 424)
        Me.Controls.Add(Me.PNLboard)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "FRMmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Tic Tac Toe by Guillaume L."
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PNLboard.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents PNLboard As System.Windows.Forms.Panel
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabelTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TMRtime As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabelPlayer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelXwins As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelOwins As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PNLmiddleH As System.Windows.Forms.Panel
    Friend WithEvents PNLmiddleV As System.Windows.Forms.Panel
    Friend WithEvents PNLbottom As System.Windows.Forms.Panel
    Friend WithEvents PNLtop As System.Windows.Forms.Panel
    Friend WithEvents PNLright As System.Windows.Forms.Panel
    Friend WithEvents PNLleft As System.Windows.Forms.Panel
    Friend WithEvents BTNreset As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemNew As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemUndo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemRedo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemStats As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOptions As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSave As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOpen As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
