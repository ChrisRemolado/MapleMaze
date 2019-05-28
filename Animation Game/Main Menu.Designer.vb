<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnLevelSelection = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.tmrStand = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picCharacter = New System.Windows.Forms.PictureBox()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(174, 216)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(174, 46)
        Me.btnStartGame.TabIndex = 1
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(276, 39)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(183, 33)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Maze Game"
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(174, 280)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(174, 46)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Help/Controls"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnLevelSelection
        '
        Me.btnLevelSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelSelection.Location = New System.Drawing.Point(387, 216)
        Me.btnLevelSelection.Name = "btnLevelSelection"
        Me.btnLevelSelection.Size = New System.Drawing.Size(174, 46)
        Me.btnLevelSelection.TabIndex = 4
        Me.btnLevelSelection.Text = "Level Selection"
        Me.btnLevelSelection.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(387, 280)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(174, 46)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "About/Credits"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'tmrStand
        '
        Me.tmrStand.Enabled = True
        Me.tmrStand.Interval = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Character Selection:"
        '
        'picCharacter
        '
        Me.picCharacter.BackColor = System.Drawing.Color.Transparent
        Me.picCharacter.Image = Global.Animation_Game.My.Resources.Resources.stand1_0
        Me.picCharacter.Location = New System.Drawing.Point(333, 114)
        Me.picCharacter.Name = "picCharacter"
        Me.picCharacter.Size = New System.Drawing.Size(69, 96)
        Me.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCharacter.TabIndex = 0
        Me.picCharacter.TabStop = False
        '
        'picBackground
        '
        Me.picBackground.Image = Global.Animation_Game.My.Resources.Resources.Main_Menu_Background
        Me.picBackground.Location = New System.Drawing.Point(0, -2)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(736, 366)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 6
        Me.picBackground.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Animation_Game.My.Resources.Resources.Main_Menu_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnLevelSelection)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.picCharacter)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maze Game - Main Menu"
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCharacter As System.Windows.Forms.PictureBox
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnLevelSelection As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents picBackground As System.Windows.Forms.PictureBox
    Friend WithEvents tmrStand As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
