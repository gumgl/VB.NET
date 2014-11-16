<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TXTinput = New System.Windows.Forms.TextBox()
        Me.TXTresult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RADdecrypt = New System.Windows.Forms.RadioButton()
        Me.RADmd5 = New System.Windows.Forms.RadioButton()
        Me.RADencrypt = New System.Windows.Forms.RadioButton()
        Me.RADchar = New System.Windows.Forms.RadioButton()
        Me.RADlcase = New System.Windows.Forms.RadioButton()
        Me.RADascii = New System.Windows.Forms.RadioButton()
        Me.RADucase = New System.Windows.Forms.RadioButton()
        Me.RADlength = New System.Windows.Forms.RadioButton()
        Me.LBLkey = New System.Windows.Forms.Label()
        Me.TXTkey = New System.Windows.Forms.TextBox()
        Me.BTNclearinput = New System.Windows.Forms.Button()
        Me.BTNencrypt = New System.Windows.Forms.Button()
        Me.BTNhelp = New System.Windows.Forms.Button()
        Me.BTNsave = New System.Windows.Forms.Button()
        Me.BTNopen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNfolder = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CHKcode = New System.Windows.Forms.CheckBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharactersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LengthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UppercaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LowercaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterToASCIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASCIIToCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5HashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTinput
        '
        Me.TXTinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTinput.Location = New System.Drawing.Point(70, 50)
        Me.TXTinput.Name = "TXTinput"
        Me.TXTinput.Size = New System.Drawing.Size(242, 26)
        Me.TXTinput.TabIndex = 0
        '
        'TXTresult
        '
        Me.TXTresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTresult.Location = New System.Drawing.Point(12, 352)
        Me.TXTresult.Name = "TXTresult"
        Me.TXTresult.ReadOnly = True
        Me.TXTresult.Size = New System.Drawing.Size(288, 26)
        Me.TXTresult.TabIndex = 2
        Me.TXTresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your Input:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Result:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RADdecrypt)
        Me.GroupBox1.Controls.Add(Me.RADmd5)
        Me.GroupBox1.Controls.Add(Me.RADencrypt)
        Me.GroupBox1.Controls.Add(Me.RADchar)
        Me.GroupBox1.Controls.Add(Me.RADlcase)
        Me.GroupBox1.Controls.Add(Me.RADascii)
        Me.GroupBox1.Controls.Add(Me.RADucase)
        Me.GroupBox1.Controls.Add(Me.RADlength)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 205)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'RADdecrypt
        '
        Me.RADdecrypt.AutoSize = True
        Me.RADdecrypt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADdecrypt.Location = New System.Drawing.Point(18, 181)
        Me.RADdecrypt.Name = "RADdecrypt"
        Me.RADdecrypt.Size = New System.Drawing.Size(185, 19)
        Me.RADdecrypt.TabIndex = 7
        Me.RADdecrypt.Text = "Decrypt using Vernam Cipher"
        Me.RADdecrypt.UseCompatibleTextRendering = True
        Me.RADdecrypt.UseVisualStyleBackColor = True
        '
        'RADmd5
        '
        Me.RADmd5.AutoSize = True
        Me.RADmd5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADmd5.Location = New System.Drawing.Point(18, 131)
        Me.RADmd5.Name = "RADmd5"
        Me.RADmd5.Size = New System.Drawing.Size(113, 19)
        Me.RADmd5.TabIndex = 6
        Me.RADmd5.Text = "Show MD5 hash"
        Me.RADmd5.UseCompatibleTextRendering = True
        Me.RADmd5.UseVisualStyleBackColor = True
        '
        'RADencrypt
        '
        Me.RADencrypt.AutoSize = True
        Me.RADencrypt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADencrypt.Location = New System.Drawing.Point(18, 156)
        Me.RADencrypt.Name = "RADencrypt"
        Me.RADencrypt.Size = New System.Drawing.Size(184, 19)
        Me.RADencrypt.TabIndex = 5
        Me.RADencrypt.Text = "Encrypt using Vernam Cipher"
        Me.RADencrypt.UseCompatibleTextRendering = True
        Me.RADencrypt.UseVisualStyleBackColor = True
        '
        'RADchar
        '
        Me.RADchar.AutoSize = True
        Me.RADchar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADchar.Location = New System.Drawing.Point(18, 106)
        Me.RADchar.Name = "RADchar"
        Me.RADchar.Size = New System.Drawing.Size(156, 19)
        Me.RADchar.TabIndex = 4
        Me.RADchar.Text = "ASCII code to Character"
        Me.RADchar.UseCompatibleTextRendering = True
        Me.RADchar.UseVisualStyleBackColor = True
        '
        'RADlcase
        '
        Me.RADlcase.AutoSize = True
        Me.RADlcase.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADlcase.Location = New System.Drawing.Point(18, 60)
        Me.RADlcase.Name = "RADlcase"
        Me.RADlcase.Size = New System.Drawing.Size(82, 19)
        Me.RADlcase.TabIndex = 3
        Me.RADlcase.Text = "Lowercase"
        Me.RADlcase.UseCompatibleTextRendering = True
        Me.RADlcase.UseVisualStyleBackColor = True
        '
        'RADascii
        '
        Me.RADascii.AutoSize = True
        Me.RADascii.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADascii.Location = New System.Drawing.Point(18, 83)
        Me.RADascii.Name = "RADascii"
        Me.RADascii.Size = New System.Drawing.Size(156, 19)
        Me.RADascii.TabIndex = 2
        Me.RADascii.Text = "Character to ASCII code"
        Me.RADascii.UseCompatibleTextRendering = True
        Me.RADascii.UseVisualStyleBackColor = True
        '
        'RADucase
        '
        Me.RADucase.AutoSize = True
        Me.RADucase.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADucase.Location = New System.Drawing.Point(18, 37)
        Me.RADucase.Name = "RADucase"
        Me.RADucase.Size = New System.Drawing.Size(82, 19)
        Me.RADucase.TabIndex = 1
        Me.RADucase.Text = "Uppercase"
        Me.RADucase.UseCompatibleTextRendering = True
        Me.RADucase.UseVisualStyleBackColor = True
        '
        'RADlength
        '
        Me.RADlength.AutoSize = True
        Me.RADlength.Checked = True
        Me.RADlength.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADlength.Location = New System.Drawing.Point(18, 14)
        Me.RADlength.Name = "RADlength"
        Me.RADlength.Size = New System.Drawing.Size(91, 19)
        Me.RADlength.TabIndex = 0
        Me.RADlength.TabStop = True
        Me.RADlength.Text = "Show length"
        Me.RADlength.UseCompatibleTextRendering = True
        Me.RADlength.UseVisualStyleBackColor = True
        '
        'LBLkey
        '
        Me.LBLkey.AutoSize = True
        Me.LBLkey.Location = New System.Drawing.Point(71, 309)
        Me.LBLkey.Name = "LBLkey"
        Me.LBLkey.Size = New System.Drawing.Size(56, 13)
        Me.LBLkey.TabIndex = 6
        Me.LBLkey.Text = "Enter Key:"
        Me.LBLkey.Visible = False
        '
        'TXTkey
        '
        Me.TXTkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTkey.Location = New System.Drawing.Point(129, 301)
        Me.TXTkey.Name = "TXTkey"
        Me.TXTkey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TXTkey.Size = New System.Drawing.Size(115, 26)
        Me.TXTkey.TabIndex = 1
        Me.TXTkey.Visible = False
        '
        'BTNclearinput
        '
        Me.BTNclearinput.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BTNclearinput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNclearinput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.BTNclearinput.Location = New System.Drawing.Point(318, 51)
        Me.BTNclearinput.Name = "BTNclearinput"
        Me.BTNclearinput.Size = New System.Drawing.Size(41, 23)
        Me.BTNclearinput.TabIndex = 7
        Me.BTNclearinput.TabStop = False
        Me.BTNclearinput.Text = "Clear"
        Me.BTNclearinput.UseVisualStyleBackColor = False
        '
        'BTNencrypt
        '
        Me.BTNencrypt.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BTNencrypt.FlatAppearance.BorderSize = 3
        Me.BTNencrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNencrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BTNencrypt.Location = New System.Drawing.Point(250, 302)
        Me.BTNencrypt.Name = "BTNencrypt"
        Me.BTNencrypt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTNencrypt.Size = New System.Drawing.Size(54, 23)
        Me.BTNencrypt.TabIndex = 8
        Me.BTNencrypt.TabStop = False
        Me.BTNencrypt.Text = "Encrypt"
        Me.BTNencrypt.UseVisualStyleBackColor = False
        Me.BTNencrypt.Visible = False
        '
        'BTNhelp
        '
        Me.BTNhelp.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BTNhelp.FlatAppearance.BorderSize = 3
        Me.BTNhelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BTNhelp.Location = New System.Drawing.Point(12, 170)
        Me.BTNhelp.Name = "BTNhelp"
        Me.BTNhelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTNhelp.Size = New System.Drawing.Size(52, 23)
        Me.BTNhelp.TabIndex = 9
        Me.BTNhelp.TabStop = False
        Me.BTNhelp.Text = "Help"
        Me.BTNhelp.UseVisualStyleBackColor = False
        '
        'BTNsave
        '
        Me.BTNsave.Enabled = False
        Me.BTNsave.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BTNsave.FlatAppearance.BorderSize = 3
        Me.BTNsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BTNsave.Location = New System.Drawing.Point(306, 353)
        Me.BTNsave.Name = "BTNsave"
        Me.BTNsave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTNsave.Size = New System.Drawing.Size(52, 23)
        Me.BTNsave.TabIndex = 10
        Me.BTNsave.TabStop = False
        Me.BTNsave.Text = "Save..."
        Me.BTNsave.UseVisualStyleBackColor = False
        '
        'BTNopen
        '
        Me.BTNopen.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BTNopen.FlatAppearance.BorderSize = 3
        Me.BTNopen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNopen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BTNopen.Location = New System.Drawing.Point(12, 51)
        Me.BTNopen.Name = "BTNopen"
        Me.BTNopen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTNopen.Size = New System.Drawing.Size(52, 23)
        Me.BTNopen.TabIndex = 11
        Me.BTNopen.TabStop = False
        Me.BTNopen.Text = "Open..."
        Me.BTNopen.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "message"
        Me.OpenFileDialog1.Title = "Open a txt file"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.FileName = "message"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowItemReorder = True
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ActionsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.FileToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(370, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyMessageToolStripMenuItem, Me.PasteMessageToolStripMenuItem, Me.ToolStripSeparator1, Me.CopyResultToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearResetToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullScreenToolStripMenuItem, Me.ToolStripSeparator4, Me.CharactersToolStripMenuItem, Me.CodesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LengthToolStripMenuItem, Me.UppercaseToolStripMenuItem, Me.LowercaseToolStripMenuItem, Me.CharacterToASCIIToolStripMenuItem, Me.ASCIIToCharacterToolStripMenuItem, Me.MD5HashToolStripMenuItem, Me.EncryptToolStripMenuItem, Me.DecryptToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem1.Text = "Help"
        '
        'BTNfolder
        '
        Me.BTNfolder.Enabled = False
        Me.BTNfolder.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.BTNfolder.FlatAppearance.BorderSize = 3
        Me.BTNfolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNfolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BTNfolder.Location = New System.Drawing.Point(12, 311)
        Me.BTNfolder.Name = "BTNfolder"
        Me.BTNfolder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTNfolder.Size = New System.Drawing.Size(52, 35)
        Me.BTNfolder.TabIndex = 12
        Me.BTNfolder.TabStop = False
        Me.BTNfolder.Text = "Open Folder"
        Me.ToolTip1.SetToolTip(Me.BTNfolder, "Open the containing folder of the last file you saved")
        Me.BTNfolder.UseVisualStyleBackColor = False
        '
        'CHKcode
        '
        Me.CHKcode.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CHKcode.Location = New System.Drawing.Point(300, 293)
        Me.CHKcode.Name = "CHKcode"
        Me.CHKcode.Size = New System.Drawing.Size(64, 49)
        Me.CHKcode.TabIndex = 13
        Me.CHKcode.Text = "Use ASCII codes"
        Me.CHKcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.CHKcode, resources.GetString("CHKcode.ToolTip"))
        Me.CHKcode.UseVisualStyleBackColor = True
        Me.CHKcode.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(158, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(188, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.StringManip.My.Resources.Resources.external
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About Me..."
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = CType(resources.GetObject("SaveAsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'CopyMessageToolStripMenuItem
        '
        Me.CopyMessageToolStripMenuItem.Image = CType(resources.GetObject("CopyMessageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyMessageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyMessageToolStripMenuItem.Name = "CopyMessageToolStripMenuItem"
        Me.CopyMessageToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CopyMessageToolStripMenuItem.Text = "Copy Message"
        '
        'PasteMessageToolStripMenuItem
        '
        Me.PasteMessageToolStripMenuItem.Image = CType(resources.GetObject("PasteMessageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteMessageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteMessageToolStripMenuItem.Name = "PasteMessageToolStripMenuItem"
        Me.PasteMessageToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PasteMessageToolStripMenuItem.Text = "Paste Message"
        '
        'CopyResultToolStripMenuItem
        '
        Me.CopyResultToolStripMenuItem.Image = CType(resources.GetObject("CopyResultToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyResultToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyResultToolStripMenuItem.Name = "CopyResultToolStripMenuItem"
        Me.CopyResultToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CopyResultToolStripMenuItem.Text = "Copy Result"
        '
        'ClearResetToolStripMenuItem
        '
        Me.ClearResetToolStripMenuItem.Image = Global.StringManip.My.Resources.Resources.clear
        Me.ClearResetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClearResetToolStripMenuItem.Name = "ClearResetToolStripMenuItem"
        Me.ClearResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ClearResetToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ClearResetToolStripMenuItem.Text = "Clear / Reset"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.Image = Global.StringManip.My.Resources.Resources.FullScreen
        Me.FullScreenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FullScreenToolStripMenuItem.Text = "Full Screen"
        '
        'CharactersToolStripMenuItem
        '
        Me.CharactersToolStripMenuItem.Enabled = False
        Me.CharactersToolStripMenuItem.Image = CType(resources.GetObject("CharactersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CharactersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CharactersToolStripMenuItem.Name = "CharactersToolStripMenuItem"
        Me.CharactersToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CharactersToolStripMenuItem.Text = "ASCII Characters"
        '
        'CodesToolStripMenuItem
        '
        Me.CodesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CodesToolStripMenuItem.Enabled = False
        Me.CodesToolStripMenuItem.Image = CType(resources.GetObject("CodesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CodesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CodesToolStripMenuItem.Name = "CodesToolStripMenuItem"
        Me.CodesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CodesToolStripMenuItem.Text = "ASCII Codes"
        '
        'LengthToolStripMenuItem
        '
        Me.LengthToolStripMenuItem.Image = CType(resources.GetObject("LengthToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LengthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LengthToolStripMenuItem.Name = "LengthToolStripMenuItem"
        Me.LengthToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.LengthToolStripMenuItem.Text = "Length"
        '
        'UppercaseToolStripMenuItem
        '
        Me.UppercaseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UppercaseToolStripMenuItem.Image = CType(resources.GetObject("UppercaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UppercaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UppercaseToolStripMenuItem.Name = "UppercaseToolStripMenuItem"
        Me.UppercaseToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UppercaseToolStripMenuItem.Text = "Uppercase"
        '
        'LowercaseToolStripMenuItem
        '
        Me.LowercaseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LowercaseToolStripMenuItem.Image = CType(resources.GetObject("LowercaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LowercaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LowercaseToolStripMenuItem.Name = "LowercaseToolStripMenuItem"
        Me.LowercaseToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.LowercaseToolStripMenuItem.Text = "Lowercase"
        '
        'CharacterToASCIIToolStripMenuItem
        '
        Me.CharacterToASCIIToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CharacterToASCIIToolStripMenuItem.Image = CType(resources.GetObject("CharacterToASCIIToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CharacterToASCIIToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CharacterToASCIIToolStripMenuItem.Name = "CharacterToASCIIToolStripMenuItem"
        Me.CharacterToASCIIToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CharacterToASCIIToolStripMenuItem.Text = "Character to ASCII"
        '
        'ASCIIToCharacterToolStripMenuItem
        '
        Me.ASCIIToCharacterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ASCIIToCharacterToolStripMenuItem.Image = CType(resources.GetObject("ASCIIToCharacterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ASCIIToCharacterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ASCIIToCharacterToolStripMenuItem.Name = "ASCIIToCharacterToolStripMenuItem"
        Me.ASCIIToCharacterToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ASCIIToCharacterToolStripMenuItem.Text = "ASCII to Character"
        '
        'MD5HashToolStripMenuItem
        '
        Me.MD5HashToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MD5HashToolStripMenuItem.Image = CType(resources.GetObject("MD5HashToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MD5HashToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MD5HashToolStripMenuItem.Name = "MD5HashToolStripMenuItem"
        Me.MD5HashToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.MD5HashToolStripMenuItem.Text = "MD5 hash"
        '
        'EncryptToolStripMenuItem
        '
        Me.EncryptToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EncryptToolStripMenuItem.Image = CType(resources.GetObject("EncryptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncryptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem"
        Me.EncryptToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EncryptToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EncryptToolStripMenuItem.Text = "Encrypt"
        '
        'DecryptToolStripMenuItem
        '
        Me.DecryptToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DecryptToolStripMenuItem.Image = CType(resources.GetObject("DecryptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DecryptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DecryptToolStripMenuItem.Name = "DecryptToolStripMenuItem"
        Me.DecryptToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DecryptToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DecryptToolStripMenuItem.Text = "Decrypt"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem.Text = "View Help"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 390)
        Me.Controls.Add(Me.BTNfolder)
        Me.Controls.Add(Me.BTNopen)
        Me.Controls.Add(Me.BTNsave)
        Me.Controls.Add(Me.BTNhelp)
        Me.Controls.Add(Me.BTNencrypt)
        Me.Controls.Add(Me.BTNclearinput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLkey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTkey)
        Me.Controls.Add(Me.TXTresult)
        Me.Controls.Add(Me.TXTinput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.CHKcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Manipulation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTinput As System.Windows.Forms.TextBox
    Friend WithEvents TXTresult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RADlcase As System.Windows.Forms.RadioButton
    Friend WithEvents RADascii As System.Windows.Forms.RadioButton
    Friend WithEvents RADucase As System.Windows.Forms.RadioButton
    Friend WithEvents RADlength As System.Windows.Forms.RadioButton
    Friend WithEvents RADchar As System.Windows.Forms.RadioButton
    Friend WithEvents RADencrypt As System.Windows.Forms.RadioButton
    Friend WithEvents RADmd5 As System.Windows.Forms.RadioButton
    Friend WithEvents LBLkey As System.Windows.Forms.Label
    Friend WithEvents TXTkey As System.Windows.Forms.TextBox
    Friend WithEvents RADdecrypt As System.Windows.Forms.RadioButton
    Friend WithEvents BTNclearinput As System.Windows.Forms.Button
    Friend WithEvents BTNencrypt As System.Windows.Forms.Button
    Friend WithEvents BTNhelp As System.Windows.Forms.Button
    Friend WithEvents BTNsave As System.Windows.Forms.Button
    Friend WithEvents BTNopen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTNfolder As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CHKcode As System.Windows.Forms.CheckBox
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LengthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UppercaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LowercaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CharacterToASCIIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASCIIToCharacterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5HashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncryptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecryptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CharactersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
