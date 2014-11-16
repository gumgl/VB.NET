<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMquiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMquiz))
        Me.GRBaverage = New System.Windows.Forms.GroupBox()
        Me.RADhard = New System.Windows.Forms.RadioButton()
        Me.RADmedium = New System.Windows.Forms.RadioButton()
        Me.RADeasy = New System.Windows.Forms.RadioButton()
        Me.LBLaverage = New System.Windows.Forms.Label()
        Me.LBLmessage = New System.Windows.Forms.Label()
        Me.BTNstart = New System.Windows.Forms.Button()
        Me.BTNstop = New System.Windows.Forms.Button()
        Me.BTNreset = New System.Windows.Forms.Button()
        Me.BTNexit = New System.Windows.Forms.Button()
        Me.GRBquiz = New System.Windows.Forms.GroupBox()
        Me.LBLcorrect5 = New System.Windows.Forms.Label()
        Me.TXTanswer5 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LBLnum52 = New System.Windows.Forms.Label()
        Me.LBLnum51 = New System.Windows.Forms.Label()
        Me.LBLcorrect4 = New System.Windows.Forms.Label()
        Me.TXTanswer4 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LBLnum42 = New System.Windows.Forms.Label()
        Me.LBLnum41 = New System.Windows.Forms.Label()
        Me.LBLcorrect3 = New System.Windows.Forms.Label()
        Me.TXTanswer3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLnum32 = New System.Windows.Forms.Label()
        Me.LBLnum31 = New System.Windows.Forms.Label()
        Me.LBLcorrect2 = New System.Windows.Forms.Label()
        Me.TXTanswer2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLnum22 = New System.Windows.Forms.Label()
        Me.LBLnum21 = New System.Windows.Forms.Label()
        Me.LBLcorrect1 = New System.Windows.Forms.Label()
        Me.TXTanswer1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLnum12 = New System.Windows.Forms.Label()
        Me.LBLnum11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLtimeleft = New System.Windows.Forms.Label()
        Me.TMRquiz = New System.Windows.Forms.Timer(Me.components)
        Me.TMRcursor = New System.Windows.Forms.Timer(Me.components)
        Me.LBLsuspensions = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GRBaverage.SuspendLayout()
        Me.GRBquiz.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRBaverage
        '
        Me.GRBaverage.Controls.Add(Me.RADhard)
        Me.GRBaverage.Controls.Add(Me.RADmedium)
        Me.GRBaverage.Controls.Add(Me.RADeasy)
        Me.GRBaverage.Controls.Add(Me.LBLaverage)
        Me.GRBaverage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBaverage.Location = New System.Drawing.Point(29, 12)
        Me.GRBaverage.Name = "GRBaverage"
        Me.GRBaverage.Size = New System.Drawing.Size(340, 144)
        Me.GRBaverage.TabIndex = 0
        Me.GRBaverage.TabStop = False
        Me.GRBaverage.Text = "Average"
        Me.GRBaverage.UseCompatibleTextRendering = True
        '
        'RADhard
        '
        Me.RADhard.AutoSize = True
        Me.RADhard.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADhard.Location = New System.Drawing.Point(195, 65)
        Me.RADhard.Name = "RADhard"
        Me.RADhard.Size = New System.Drawing.Size(69, 19)
        Me.RADhard.TabIndex = 3
        Me.RADhard.Text = "Science"
        Me.ToolTip1.SetToolTip(Me.RADhard, "5 multiplications involving numbers from 0 to 30 in 40 seconds")
        Me.RADhard.UseCompatibleTextRendering = True
        Me.RADhard.UseVisualStyleBackColor = True
        '
        'RADmedium
        '
        Me.RADmedium.AutoSize = True
        Me.RADmedium.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADmedium.Location = New System.Drawing.Point(195, 42)
        Me.RADmedium.Name = "RADmedium"
        Me.RADmedium.Size = New System.Drawing.Size(131, 19)
        Me.RADmedium.TabIndex = 2
        Me.RADmedium.Text = "Computer Science"
        Me.ToolTip1.SetToolTip(Me.RADmedium, "5 multiplications involving numbers from 0 to 20 in 30 seconds")
        Me.RADmedium.UseCompatibleTextRendering = True
        Me.RADmedium.UseVisualStyleBackColor = True
        '
        'RADeasy
        '
        Me.RADeasy.AutoSize = True
        Me.RADeasy.Checked = True
        Me.RADeasy.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADeasy.Location = New System.Drawing.Point(195, 19)
        Me.RADeasy.Name = "RADeasy"
        Me.RADeasy.Size = New System.Drawing.Size(109, 19)
        Me.RADeasy.TabIndex = 1
        Me.RADeasy.TabStop = True
        Me.RADeasy.Text = "Social Science"
        Me.ToolTip1.SetToolTip(Me.RADeasy, "5 multiplications involving numbers from 0 to 10 in 20 seconds")
        Me.RADeasy.UseCompatibleTextRendering = True
        Me.RADeasy.UseVisualStyleBackColor = True
        '
        'LBLaverage
        '
        Me.LBLaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLaverage.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLaverage.Location = New System.Drawing.Point(21, 16)
        Me.LBLaverage.Name = "LBLaverage"
        Me.LBLaverage.Size = New System.Drawing.Size(151, 65)
        Me.LBLaverage.TabIndex = 0
        Me.LBLaverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LBLaverage, "Your final grade")
        '
        'LBLmessage
        '
        Me.LBLmessage.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLmessage.Location = New System.Drawing.Point(40, 100)
        Me.LBLmessage.Name = "LBLmessage"
        Me.LBLmessage.Size = New System.Drawing.Size(323, 53)
        Me.LBLmessage.TabIndex = 31
        Me.LBLmessage.Text = "Select your program and press Start to begin the Quiz!"
        Me.LBLmessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLmessage.UseCompatibleTextRendering = True
        '
        'BTNstart
        '
        Me.BTNstart.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNstart.Location = New System.Drawing.Point(397, 28)
        Me.BTNstart.Name = "BTNstart"
        Me.BTNstart.Size = New System.Drawing.Size(75, 23)
        Me.BTNstart.TabIndex = 6
        Me.BTNstart.TabStop = False
        Me.BTNstart.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.BTNstart, "Start the quiz")
        Me.BTNstart.UseCompatibleTextRendering = True
        Me.BTNstart.UseVisualStyleBackColor = True
        '
        'BTNstop
        '
        Me.BTNstop.Enabled = False
        Me.BTNstop.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNstop.ForeColor = System.Drawing.Color.DimGray
        Me.BTNstop.Location = New System.Drawing.Point(397, 62)
        Me.BTNstop.Name = "BTNstop"
        Me.BTNstop.Size = New System.Drawing.Size(75, 23)
        Me.BTNstop.TabIndex = 7
        Me.BTNstop.TabStop = False
        Me.BTNstop.Text = "Stop"
        Me.ToolTip1.SetToolTip(Me.BTNstop, "Stop the quiz")
        Me.BTNstop.UseCompatibleTextRendering = True
        Me.BTNstop.UseVisualStyleBackColor = True
        '
        'BTNreset
        '
        Me.BTNreset.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNreset.Location = New System.Drawing.Point(397, 96)
        Me.BTNreset.Name = "BTNreset"
        Me.BTNreset.Size = New System.Drawing.Size(75, 23)
        Me.BTNreset.TabIndex = 3
        Me.BTNreset.TabStop = False
        Me.BTNreset.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.BTNreset, "Reset the form")
        Me.BTNreset.UseCompatibleTextRendering = True
        Me.BTNreset.UseVisualStyleBackColor = True
        '
        'BTNexit
        '
        Me.BTNexit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNexit.Location = New System.Drawing.Point(397, 127)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(75, 45)
        Me.BTNexit.TabIndex = 4
        Me.BTNexit.TabStop = False
        Me.BTNexit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.BTNexit, "Exit this program")
        Me.BTNexit.UseCompatibleTextRendering = True
        Me.BTNexit.UseVisualStyleBackColor = True
        '
        'GRBquiz
        '
        Me.GRBquiz.Controls.Add(Me.LBLcorrect5)
        Me.GRBquiz.Controls.Add(Me.TXTanswer5)
        Me.GRBquiz.Controls.Add(Me.Label24)
        Me.GRBquiz.Controls.Add(Me.Label25)
        Me.GRBquiz.Controls.Add(Me.LBLnum52)
        Me.GRBquiz.Controls.Add(Me.LBLnum51)
        Me.GRBquiz.Controls.Add(Me.LBLcorrect4)
        Me.GRBquiz.Controls.Add(Me.TXTanswer4)
        Me.GRBquiz.Controls.Add(Me.Label19)
        Me.GRBquiz.Controls.Add(Me.Label20)
        Me.GRBquiz.Controls.Add(Me.LBLnum42)
        Me.GRBquiz.Controls.Add(Me.LBLnum41)
        Me.GRBquiz.Controls.Add(Me.LBLcorrect3)
        Me.GRBquiz.Controls.Add(Me.TXTanswer3)
        Me.GRBquiz.Controls.Add(Me.Label14)
        Me.GRBquiz.Controls.Add(Me.Label15)
        Me.GRBquiz.Controls.Add(Me.LBLnum32)
        Me.GRBquiz.Controls.Add(Me.LBLnum31)
        Me.GRBquiz.Controls.Add(Me.LBLcorrect2)
        Me.GRBquiz.Controls.Add(Me.TXTanswer2)
        Me.GRBquiz.Controls.Add(Me.Label9)
        Me.GRBquiz.Controls.Add(Me.Label10)
        Me.GRBquiz.Controls.Add(Me.LBLnum22)
        Me.GRBquiz.Controls.Add(Me.LBLnum21)
        Me.GRBquiz.Controls.Add(Me.LBLcorrect1)
        Me.GRBquiz.Controls.Add(Me.TXTanswer1)
        Me.GRBquiz.Controls.Add(Me.Label6)
        Me.GRBquiz.Controls.Add(Me.Label5)
        Me.GRBquiz.Controls.Add(Me.LBLnum12)
        Me.GRBquiz.Controls.Add(Me.LBLnum11)
        Me.GRBquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBquiz.Location = New System.Drawing.Point(12, 176)
        Me.GRBquiz.Name = "GRBquiz"
        Me.GRBquiz.Size = New System.Drawing.Size(253, 241)
        Me.GRBquiz.TabIndex = 4
        Me.GRBquiz.TabStop = False
        Me.GRBquiz.Text = "Quiz"
        Me.GRBquiz.UseCompatibleTextRendering = True
        Me.GRBquiz.Visible = False
        '
        'LBLcorrect5
        '
        Me.LBLcorrect5.BackColor = System.Drawing.Color.Red
        Me.LBLcorrect5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLcorrect5.ForeColor = System.Drawing.Color.White
        Me.LBLcorrect5.Location = New System.Drawing.Point(126, 179)
        Me.LBLcorrect5.Name = "LBLcorrect5"
        Me.LBLcorrect5.Size = New System.Drawing.Size(28, 25)
        Me.LBLcorrect5.TabIndex = 29
        Me.LBLcorrect5.Text = "5"
        Me.LBLcorrect5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLcorrect5.UseCompatibleTextRendering = True
        Me.LBLcorrect5.Visible = False
        '
        'TXTanswer5
        '
        Me.TXTanswer5.Enabled = False
        Me.TXTanswer5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTanswer5.Location = New System.Drawing.Point(126, 180)
        Me.TXTanswer5.Name = "TXTanswer5"
        Me.TXTanswer5.Size = New System.Drawing.Size(28, 23)
        Me.TXTanswer5.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(106, 181)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 20)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "="
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label24.UseCompatibleTextRendering = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(51, 181)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 20)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "X"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label25.UseCompatibleTextRendering = True
        '
        'LBLnum52
        '
        Me.LBLnum52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum52.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum52.Location = New System.Drawing.Point(72, 180)
        Me.LBLnum52.Name = "LBLnum52"
        Me.LBLnum52.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum52.TabIndex = 25
        Me.LBLnum52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum52.UseCompatibleTextRendering = True
        '
        'LBLnum51
        '
        Me.LBLnum51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum51.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum51.Location = New System.Drawing.Point(17, 180)
        Me.LBLnum51.Name = "LBLnum51"
        Me.LBLnum51.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum51.TabIndex = 24
        Me.LBLnum51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum51.UseCompatibleTextRendering = True
        '
        'LBLcorrect4
        '
        Me.LBLcorrect4.BackColor = System.Drawing.Color.Red
        Me.LBLcorrect4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLcorrect4.ForeColor = System.Drawing.Color.White
        Me.LBLcorrect4.Location = New System.Drawing.Point(126, 139)
        Me.LBLcorrect4.Name = "LBLcorrect4"
        Me.LBLcorrect4.Size = New System.Drawing.Size(28, 25)
        Me.LBLcorrect4.TabIndex = 23
        Me.LBLcorrect4.Text = "4"
        Me.LBLcorrect4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLcorrect4.UseCompatibleTextRendering = True
        Me.LBLcorrect4.Visible = False
        '
        'TXTanswer4
        '
        Me.TXTanswer4.Enabled = False
        Me.TXTanswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTanswer4.Location = New System.Drawing.Point(126, 140)
        Me.TXTanswer4.Name = "TXTanswer4"
        Me.TXTanswer4.Size = New System.Drawing.Size(28, 23)
        Me.TXTanswer4.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(107, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 20)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "="
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label19.UseCompatibleTextRendering = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(51, 141)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 20)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "X"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label20.UseCompatibleTextRendering = True
        '
        'LBLnum42
        '
        Me.LBLnum42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum42.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum42.Location = New System.Drawing.Point(72, 140)
        Me.LBLnum42.Name = "LBLnum42"
        Me.LBLnum42.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum42.TabIndex = 19
        Me.LBLnum42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum42.UseCompatibleTextRendering = True
        '
        'LBLnum41
        '
        Me.LBLnum41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum41.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum41.Location = New System.Drawing.Point(17, 140)
        Me.LBLnum41.Name = "LBLnum41"
        Me.LBLnum41.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum41.TabIndex = 18
        Me.LBLnum41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum41.UseCompatibleTextRendering = True
        '
        'LBLcorrect3
        '
        Me.LBLcorrect3.BackColor = System.Drawing.Color.Red
        Me.LBLcorrect3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLcorrect3.ForeColor = System.Drawing.Color.White
        Me.LBLcorrect3.Location = New System.Drawing.Point(126, 98)
        Me.LBLcorrect3.Name = "LBLcorrect3"
        Me.LBLcorrect3.Size = New System.Drawing.Size(28, 25)
        Me.LBLcorrect3.TabIndex = 17
        Me.LBLcorrect3.Text = "3"
        Me.LBLcorrect3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLcorrect3.UseCompatibleTextRendering = True
        Me.LBLcorrect3.Visible = False
        '
        'TXTanswer3
        '
        Me.TXTanswer3.Enabled = False
        Me.TXTanswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTanswer3.Location = New System.Drawing.Point(126, 99)
        Me.TXTanswer3.Name = "TXTanswer3"
        Me.TXTanswer3.Size = New System.Drawing.Size(28, 23)
        Me.TXTanswer3.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(106, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 20)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "="
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label14.UseCompatibleTextRendering = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(51, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "X"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.UseCompatibleTextRendering = True
        '
        'LBLnum32
        '
        Me.LBLnum32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum32.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum32.Location = New System.Drawing.Point(72, 99)
        Me.LBLnum32.Name = "LBLnum32"
        Me.LBLnum32.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum32.TabIndex = 13
        Me.LBLnum32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum32.UseCompatibleTextRendering = True
        '
        'LBLnum31
        '
        Me.LBLnum31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum31.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum31.Location = New System.Drawing.Point(17, 99)
        Me.LBLnum31.Name = "LBLnum31"
        Me.LBLnum31.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum31.TabIndex = 12
        Me.LBLnum31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum31.UseCompatibleTextRendering = True
        '
        'LBLcorrect2
        '
        Me.LBLcorrect2.BackColor = System.Drawing.Color.Red
        Me.LBLcorrect2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLcorrect2.ForeColor = System.Drawing.Color.White
        Me.LBLcorrect2.Location = New System.Drawing.Point(126, 57)
        Me.LBLcorrect2.Name = "LBLcorrect2"
        Me.LBLcorrect2.Size = New System.Drawing.Size(28, 25)
        Me.LBLcorrect2.TabIndex = 11
        Me.LBLcorrect2.Text = "2"
        Me.LBLcorrect2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLcorrect2.UseCompatibleTextRendering = True
        Me.LBLcorrect2.Visible = False
        '
        'TXTanswer2
        '
        Me.TXTanswer2.Enabled = False
        Me.TXTanswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTanswer2.Location = New System.Drawing.Point(126, 58)
        Me.TXTanswer2.Name = "TXTanswer2"
        Me.TXTanswer2.Size = New System.Drawing.Size(28, 23)
        Me.TXTanswer2.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(107, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "="
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label9.UseCompatibleTextRendering = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "X"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.UseCompatibleTextRendering = True
        '
        'LBLnum22
        '
        Me.LBLnum22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum22.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum22.Location = New System.Drawing.Point(72, 58)
        Me.LBLnum22.Name = "LBLnum22"
        Me.LBLnum22.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum22.TabIndex = 7
        Me.LBLnum22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum22.UseCompatibleTextRendering = True
        '
        'LBLnum21
        '
        Me.LBLnum21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum21.Location = New System.Drawing.Point(17, 58)
        Me.LBLnum21.Name = "LBLnum21"
        Me.LBLnum21.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum21.TabIndex = 6
        Me.LBLnum21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum21.UseCompatibleTextRendering = True
        '
        'LBLcorrect1
        '
        Me.LBLcorrect1.BackColor = System.Drawing.Color.Red
        Me.LBLcorrect1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLcorrect1.ForeColor = System.Drawing.Color.White
        Me.LBLcorrect1.Location = New System.Drawing.Point(126, 15)
        Me.LBLcorrect1.Name = "LBLcorrect1"
        Me.LBLcorrect1.Size = New System.Drawing.Size(28, 25)
        Me.LBLcorrect1.TabIndex = 5
        Me.LBLcorrect1.Text = "1"
        Me.LBLcorrect1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLcorrect1.UseCompatibleTextRendering = True
        Me.LBLcorrect1.Visible = False
        '
        'TXTanswer1
        '
        Me.TXTanswer1.Enabled = False
        Me.TXTanswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTanswer1.Location = New System.Drawing.Point(126, 16)
        Me.TXTanswer1.Name = "TXTanswer1"
        Me.TXTanswer1.Size = New System.Drawing.Size(28, 23)
        Me.TXTanswer1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "="
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "X"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.UseCompatibleTextRendering = True
        '
        'LBLnum12
        '
        Me.LBLnum12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum12.Location = New System.Drawing.Point(72, 16)
        Me.LBLnum12.Name = "LBLnum12"
        Me.LBLnum12.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum12.TabIndex = 1
        Me.LBLnum12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum12.UseCompatibleTextRendering = True
        '
        'LBLnum11
        '
        Me.LBLnum11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLnum11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnum11.Location = New System.Drawing.Point(17, 16)
        Me.LBLnum11.Name = "LBLnum11"
        Me.LBLnum11.Size = New System.Drawing.Size(28, 23)
        Me.LBLnum11.TabIndex = 0
        Me.LBLnum11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLnum11.UseCompatibleTextRendering = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LBLtimeleft)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(287, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 184)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Time Left"
        Me.GroupBox3.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Time Left:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.UseCompatibleTextRendering = True
        '
        'LBLtimeleft
        '
        Me.LBLtimeleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLtimeleft.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtimeleft.Location = New System.Drawing.Point(28, 56)
        Me.LBLtimeleft.Name = "LBLtimeleft"
        Me.LBLtimeleft.Size = New System.Drawing.Size(111, 111)
        Me.LBLtimeleft.TabIndex = 0
        Me.LBLtimeleft.Text = "20"
        Me.LBLtimeleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LBLtimeleft, "Seconds left")
        Me.LBLtimeleft.UseCompatibleTextRendering = True
        '
        'TMRquiz
        '
        Me.TMRquiz.Interval = 1000
        '
        'TMRcursor
        '
        '
        'LBLsuspensions
        '
        Me.LBLsuspensions.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLsuspensions.Location = New System.Drawing.Point(287, 374)
        Me.LBLsuspensions.Name = "LBLsuspensions"
        Me.LBLsuspensions.Size = New System.Drawing.Size(165, 43)
        Me.LBLsuspensions.TabIndex = 32
        Me.LBLsuspensions.Text = "Number of suspensions to date: "
        Me.LBLsuspensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.LBLsuspensions, "This number gets reset if you change this program's name or location")
        Me.LBLsuspensions.UseCompatibleTextRendering = True
        Me.LBLsuspensions.Visible = False
        '
        'FRMquiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(503, 454)
        Me.Controls.Add(Me.LBLsuspensions)
        Me.Controls.Add(Me.LBLmessage)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GRBquiz)
        Me.Controls.Add(Me.BTNexit)
        Me.Controls.Add(Me.BTNreset)
        Me.Controls.Add(Me.BTNstop)
        Me.Controls.Add(Me.BTNstart)
        Me.Controls.Add(Me.GRBaverage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRMquiz"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Guillaume's Math Quiz"
        Me.GRBaverage.ResumeLayout(False)
        Me.GRBaverage.PerformLayout()
        Me.GRBquiz.ResumeLayout(False)
        Me.GRBquiz.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GRBaverage As System.Windows.Forms.GroupBox
    Friend WithEvents LBLaverage As System.Windows.Forms.Label
    Friend WithEvents BTNstart As System.Windows.Forms.Button
    Friend WithEvents BTNstop As System.Windows.Forms.Button
    Friend WithEvents BTNreset As System.Windows.Forms.Button
    Friend WithEvents BTNexit As System.Windows.Forms.Button
    Friend WithEvents RADhard As System.Windows.Forms.RadioButton
    Friend WithEvents RADmedium As System.Windows.Forms.RadioButton
    Friend WithEvents RADeasy As System.Windows.Forms.RadioButton
    Friend WithEvents GRBquiz As System.Windows.Forms.GroupBox
    Friend WithEvents LBLnum11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLtimeleft As System.Windows.Forms.Label
    Friend WithEvents LBLcorrect5 As System.Windows.Forms.Label
    Friend WithEvents TXTanswer5 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LBLnum52 As System.Windows.Forms.Label
    Friend WithEvents LBLnum51 As System.Windows.Forms.Label
    Friend WithEvents LBLcorrect4 As System.Windows.Forms.Label
    Friend WithEvents TXTanswer4 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LBLnum42 As System.Windows.Forms.Label
    Friend WithEvents LBLnum41 As System.Windows.Forms.Label
    Friend WithEvents LBLcorrect3 As System.Windows.Forms.Label
    Friend WithEvents TXTanswer3 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LBLnum32 As System.Windows.Forms.Label
    Friend WithEvents LBLnum31 As System.Windows.Forms.Label
    Friend WithEvents LBLcorrect2 As System.Windows.Forms.Label
    Friend WithEvents TXTanswer2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LBLnum22 As System.Windows.Forms.Label
    Friend WithEvents LBLnum21 As System.Windows.Forms.Label
    Friend WithEvents LBLcorrect1 As System.Windows.Forms.Label
    Friend WithEvents TXTanswer1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLnum12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TMRquiz As System.Windows.Forms.Timer
    Friend WithEvents TMRcursor As System.Windows.Forms.Timer
    Friend WithEvents LBLmessage As System.Windows.Forms.Label
    Friend WithEvents LBLsuspensions As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
