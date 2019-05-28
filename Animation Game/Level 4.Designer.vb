<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel4))
        Me.picCharacter = New System.Windows.Forms.PictureBox()
        Me.lblWall1 = New System.Windows.Forms.Label()
        Me.lblWall5 = New System.Windows.Forms.Label()
        Me.lblWall2 = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.picTeleporter1a = New System.Windows.Forms.PictureBox()
        Me.lblWall3 = New System.Windows.Forms.Label()
        Me.lblWall0 = New System.Windows.Forms.Label()
        Me.lblDoor5 = New System.Windows.Forms.Label()
        Me.lblWall4 = New System.Windows.Forms.Label()
        Me.lblDoor3 = New System.Windows.Forms.Label()
        Me.lblDoor1 = New System.Windows.Forms.Label()
        Me.picTeleporter1b = New System.Windows.Forms.PictureBox()
        Me.picTeleporter2a = New System.Windows.Forms.PictureBox()
        Me.picTeleporter4a = New System.Windows.Forms.PictureBox()
        Me.picLever1 = New System.Windows.Forms.PictureBox()
        Me.lblWall12 = New System.Windows.Forms.Label()
        Me.lblWall13 = New System.Windows.Forms.Label()
        Me.lblWall11 = New System.Windows.Forms.Label()
        Me.lblWall6 = New System.Windows.Forms.Label()
        Me.lblWall7 = New System.Windows.Forms.Label()
        Me.lblWall8 = New System.Windows.Forms.Label()
        Me.lblWall10 = New System.Windows.Forms.Label()
        Me.lblWall9 = New System.Windows.Forms.Label()
        Me.lblWall14 = New System.Windows.Forms.Label()
        Me.lblWall15 = New System.Windows.Forms.Label()
        Me.lblWall18 = New System.Windows.Forms.Label()
        Me.lblWall17 = New System.Windows.Forms.Label()
        Me.lblWall16 = New System.Windows.Forms.Label()
        Me.picTeleporter2b = New System.Windows.Forms.PictureBox()
        Me.picTeleporter4b = New System.Windows.Forms.PictureBox()
        Me.picTeleporter3b = New System.Windows.Forms.PictureBox()
        Me.picTeleporter3a = New System.Windows.Forms.PictureBox()
        Me.lblDoor4 = New System.Windows.Forms.Label()
        Me.lblWall33 = New System.Windows.Forms.Label()
        Me.picLever2 = New System.Windows.Forms.PictureBox()
        Me.lblWall36 = New System.Windows.Forms.Label()
        Me.lblWall37 = New System.Windows.Forms.Label()
        Me.lblWall35 = New System.Windows.Forms.Label()
        Me.lblWall38 = New System.Windows.Forms.Label()
        Me.lblWall34 = New System.Windows.Forms.Label()
        Me.picLever3 = New System.Windows.Forms.PictureBox()
        Me.lblDoor2 = New System.Windows.Forms.Label()
        Me.lblWall39 = New System.Windows.Forms.Label()
        Me.lblWall24 = New System.Windows.Forms.Label()
        Me.picLever4 = New System.Windows.Forms.PictureBox()
        Me.lblWall19 = New System.Windows.Forms.Label()
        Me.lblWall21 = New System.Windows.Forms.Label()
        Me.lblWall20 = New System.Windows.Forms.Label()
        Me.lblWall22 = New System.Windows.Forms.Label()
        Me.lblWall23 = New System.Windows.Forms.Label()
        Me.picLever5 = New System.Windows.Forms.PictureBox()
        Me.lblWall30 = New System.Windows.Forms.Label()
        Me.lblWall27 = New System.Windows.Forms.Label()
        Me.lblWall29 = New System.Windows.Forms.Label()
        Me.lblWall28 = New System.Windows.Forms.Label()
        Me.lblWall26 = New System.Windows.Forms.Label()
        Me.lblWall25 = New System.Windows.Forms.Label()
        Me.lblWall31 = New System.Windows.Forms.Label()
        Me.lblWall32 = New System.Windows.Forms.Label()
        Me.tmrStand = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter1a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter1b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter2a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter4a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLever1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter2b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter4b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter3b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeleporter3a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLever2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLever3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLever4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLever5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCharacter
        '
        Me.picCharacter.BackColor = System.Drawing.Color.Transparent
        Me.picCharacter.Image = Global.Animation_Game.My.Resources.Resources.stand1_0
        Me.picCharacter.Location = New System.Drawing.Point(12, 636)
        Me.picCharacter.Name = "picCharacter"
        Me.picCharacter.Size = New System.Drawing.Size(46, 64)
        Me.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCharacter.TabIndex = 1
        Me.picCharacter.TabStop = False
        '
        'lblWall1
        '
        Me.lblWall1.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall1.Location = New System.Drawing.Point(-3, 377)
        Me.lblWall1.Name = "lblWall1"
        Me.lblWall1.Size = New System.Drawing.Size(116, 14)
        Me.lblWall1.TabIndex = 39
        '
        'lblWall5
        '
        Me.lblWall5.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall5.Location = New System.Drawing.Point(210, 488)
        Me.lblWall5.Name = "lblWall5"
        Me.lblWall5.Size = New System.Drawing.Size(14, 120)
        Me.lblWall5.TabIndex = 38
        '
        'lblWall2
        '
        Me.lblWall2.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall2.Location = New System.Drawing.Point(99, 489)
        Me.lblWall2.Name = "lblWall2"
        Me.lblWall2.Size = New System.Drawing.Size(14, 120)
        Me.lblWall2.TabIndex = 40
        '
        'picExit
        '
        Me.picExit.Image = Global.Animation_Game.My.Resources.Resources.Cave_Entrance
        Me.picExit.Location = New System.Drawing.Point(872, 642)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(100, 58)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExit.TabIndex = 41
        Me.picExit.TabStop = False
        '
        'picTeleporter1a
        '
        Me.picTeleporter1a.Image = Global.Animation_Game.My.Resources.Resources.teleporter_Blue1
        Me.picTeleporter1a.Location = New System.Drawing.Point(8, 401)
        Me.picTeleporter1a.Name = "picTeleporter1a"
        Me.picTeleporter1a.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter1a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter1a.TabIndex = 42
        Me.picTeleporter1a.TabStop = False
        '
        'lblWall3
        '
        Me.lblWall3.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall3.Location = New System.Drawing.Point(99, 377)
        Me.lblWall3.Name = "lblWall3"
        Me.lblWall3.Size = New System.Drawing.Size(14, 120)
        Me.lblWall3.TabIndex = 43
        '
        'lblWall0
        '
        Me.lblWall0.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall0.Location = New System.Drawing.Point(109, 595)
        Me.lblWall0.Name = "lblWall0"
        Me.lblWall0.Size = New System.Drawing.Size(126, 14)
        Me.lblWall0.TabIndex = 44
        '
        'lblDoor5
        '
        Me.lblDoor5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblDoor5.Location = New System.Drawing.Point(500, 609)
        Me.lblDoor5.Name = "lblDoor5"
        Me.lblDoor5.Size = New System.Drawing.Size(14, 107)
        Me.lblDoor5.TabIndex = 65
        '
        'lblWall4
        '
        Me.lblWall4.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall4.Location = New System.Drawing.Point(227, 595)
        Me.lblWall4.Name = "lblWall4"
        Me.lblWall4.Size = New System.Drawing.Size(760, 14)
        Me.lblWall4.TabIndex = 66
        '
        'lblDoor3
        '
        Me.lblDoor3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblDoor3.Location = New System.Drawing.Point(333, 609)
        Me.lblDoor3.Name = "lblDoor3"
        Me.lblDoor3.Size = New System.Drawing.Size(14, 107)
        Me.lblDoor3.TabIndex = 67
        '
        'lblDoor1
        '
        Me.lblDoor1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblDoor1.Location = New System.Drawing.Point(203, 609)
        Me.lblDoor1.Name = "lblDoor1"
        Me.lblDoor1.Size = New System.Drawing.Size(14, 107)
        Me.lblDoor1.TabIndex = 68
        '
        'picTeleporter1b
        '
        Me.picTeleporter1b.Image = Global.Animation_Game.My.Resources.Resources.teleporter_Blue1
        Me.picTeleporter1b.Location = New System.Drawing.Point(119, 505)
        Me.picTeleporter1b.Name = "picTeleporter1b"
        Me.picTeleporter1b.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter1b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter1b.TabIndex = 69
        Me.picTeleporter1b.TabStop = False
        '
        'picTeleporter2a
        '
        Me.picTeleporter2a.Image = Global.Animation_Game.My.Resources.Resources.teleporter_Yellow1
        Me.picTeleporter2a.Location = New System.Drawing.Point(8, 179)
        Me.picTeleporter2a.Name = "picTeleporter2a"
        Me.picTeleporter2a.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter2a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter2a.TabIndex = 70
        Me.picTeleporter2a.TabStop = False
        '
        'picTeleporter4a
        '
        Me.picTeleporter4a.Image = CType(resources.GetObject("picTeleporter4a.Image"), System.Drawing.Image)
        Me.picTeleporter4a.Location = New System.Drawing.Point(232, 504)
        Me.picTeleporter4a.Name = "picTeleporter4a"
        Me.picTeleporter4a.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter4a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter4a.TabIndex = 71
        Me.picTeleporter4a.TabStop = False
        '
        'picLever1
        '
        Me.picLever1.Image = Global.Animation_Game.My.Resources.Resources.lever0
        Me.picLever1.Location = New System.Drawing.Point(18, 314)
        Me.picLever1.Name = "picLever1"
        Me.picLever1.Size = New System.Drawing.Size(40, 50)
        Me.picLever1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLever1.TabIndex = 72
        Me.picLever1.TabStop = False
        '
        'lblWall12
        '
        Me.lblWall12.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall12.Location = New System.Drawing.Point(99, 157)
        Me.lblWall12.Name = "lblWall12"
        Me.lblWall12.Size = New System.Drawing.Size(14, 120)
        Me.lblWall12.TabIndex = 73
        '
        'lblWall13
        '
        Me.lblWall13.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall13.Location = New System.Drawing.Point(-13, 271)
        Me.lblWall13.Name = "lblWall13"
        Me.lblWall13.Size = New System.Drawing.Size(126, 14)
        Me.lblWall13.TabIndex = 74
        '
        'lblWall11
        '
        Me.lblWall11.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall11.Location = New System.Drawing.Point(99, 150)
        Me.lblWall11.Name = "lblWall11"
        Me.lblWall11.Size = New System.Drawing.Size(126, 14)
        Me.lblWall11.TabIndex = 75
        '
        'lblWall6
        '
        Me.lblWall6.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall6.Location = New System.Drawing.Point(211, 377)
        Me.lblWall6.Name = "lblWall6"
        Me.lblWall6.Size = New System.Drawing.Size(14, 120)
        Me.lblWall6.TabIndex = 76
        '
        'lblWall7
        '
        Me.lblWall7.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall7.Location = New System.Drawing.Point(211, 271)
        Me.lblWall7.Name = "lblWall7"
        Me.lblWall7.Size = New System.Drawing.Size(14, 120)
        Me.lblWall7.TabIndex = 77
        '
        'lblWall8
        '
        Me.lblWall8.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall8.Location = New System.Drawing.Point(211, 271)
        Me.lblWall8.Name = "lblWall8"
        Me.lblWall8.Size = New System.Drawing.Size(126, 14)
        Me.lblWall8.TabIndex = 78
        '
        'lblWall10
        '
        Me.lblWall10.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall10.Location = New System.Drawing.Point(324, 165)
        Me.lblWall10.Name = "lblWall10"
        Me.lblWall10.Size = New System.Drawing.Size(14, 120)
        Me.lblWall10.TabIndex = 79
        '
        'lblWall9
        '
        Me.lblWall9.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall9.Location = New System.Drawing.Point(324, 94)
        Me.lblWall9.Name = "lblWall9"
        Me.lblWall9.Size = New System.Drawing.Size(14, 120)
        Me.lblWall9.TabIndex = 80
        '
        'lblWall14
        '
        Me.lblWall14.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall14.Location = New System.Drawing.Point(-46, 63)
        Me.lblWall14.Name = "lblWall14"
        Me.lblWall14.Size = New System.Drawing.Size(281, 14)
        Me.lblWall14.TabIndex = 81
        '
        'lblWall15
        '
        Me.lblWall15.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall15.Location = New System.Drawing.Point(221, -12)
        Me.lblWall15.Name = "lblWall15"
        Me.lblWall15.Size = New System.Drawing.Size(14, 82)
        Me.lblWall15.TabIndex = 82
        '
        'lblWall18
        '
        Me.lblWall18.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall18.Location = New System.Drawing.Point(333, 377)
        Me.lblWall18.Name = "lblWall18"
        Me.lblWall18.Size = New System.Drawing.Size(14, 232)
        Me.lblWall18.TabIndex = 83
        '
        'lblWall17
        '
        Me.lblWall17.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall17.Location = New System.Drawing.Point(333, 377)
        Me.lblWall17.Name = "lblWall17"
        Me.lblWall17.Size = New System.Drawing.Size(271, 14)
        Me.lblWall17.TabIndex = 84
        '
        'lblWall16
        '
        Me.lblWall16.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall16.Location = New System.Drawing.Point(443, -3)
        Me.lblWall16.Name = "lblWall16"
        Me.lblWall16.Size = New System.Drawing.Size(14, 394)
        Me.lblWall16.TabIndex = 85
        '
        'picTeleporter2b
        '
        Me.picTeleporter2b.Image = Global.Animation_Game.My.Resources.Resources.teleporter_Yellow1
        Me.picTeleporter2b.Location = New System.Drawing.Point(465, 12)
        Me.picTeleporter2b.Name = "picTeleporter2b"
        Me.picTeleporter2b.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter2b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter2b.TabIndex = 86
        Me.picTeleporter2b.TabStop = False
        '
        'picTeleporter4b
        '
        Me.picTeleporter4b.Image = CType(resources.GetObject("picTeleporter4b.Image"), System.Drawing.Image)
        Me.picTeleporter4b.Location = New System.Drawing.Point(875, 507)
        Me.picTeleporter4b.Name = "picTeleporter4b"
        Me.picTeleporter4b.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter4b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter4b.TabIndex = 87
        Me.picTeleporter4b.TabStop = False
        '
        'picTeleporter3b
        '
        Me.picTeleporter3b.Image = Global.Animation_Game.My.Resources.Resources.teleporter_Green1
        Me.picTeleporter3b.Location = New System.Drawing.Point(353, 504)
        Me.picTeleporter3b.Name = "picTeleporter3b"
        Me.picTeleporter3b.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter3b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter3b.TabIndex = 88
        Me.picTeleporter3b.TabStop = False
        '
        'picTeleporter3a
        '
        Me.picTeleporter3a.Image = Global.Animation_Game.My.Resources.Resources.teleporter_Green1
        Me.picTeleporter3a.Location = New System.Drawing.Point(887, 12)
        Me.picTeleporter3a.Name = "picTeleporter3a"
        Me.picTeleporter3a.Size = New System.Drawing.Size(85, 85)
        Me.picTeleporter3a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeleporter3a.TabIndex = 89
        Me.picTeleporter3a.TabStop = False
        '
        'lblDoor4
        '
        Me.lblDoor4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblDoor4.Location = New System.Drawing.Point(324, -3)
        Me.lblDoor4.Name = "lblDoor4"
        Me.lblDoor4.Size = New System.Drawing.Size(14, 97)
        Me.lblDoor4.TabIndex = 90
        '
        'lblWall33
        '
        Me.lblWall33.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall33.Location = New System.Drawing.Point(448, 285)
        Me.lblWall33.Name = "lblWall33"
        Me.lblWall33.Size = New System.Drawing.Size(539, 14)
        Me.lblWall33.TabIndex = 91
        '
        'picLever2
        '
        Me.picLever2.Image = Global.Animation_Game.My.Resources.Resources.lever0
        Me.picLever2.Location = New System.Drawing.Point(474, 143)
        Me.picLever2.Name = "picLever2"
        Me.picLever2.Size = New System.Drawing.Size(40, 50)
        Me.picLever2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLever2.TabIndex = 92
        Me.picLever2.TabStop = False
        '
        'lblWall36
        '
        Me.lblWall36.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall36.Location = New System.Drawing.Point(448, 110)
        Me.lblWall36.Name = "lblWall36"
        Me.lblWall36.Size = New System.Drawing.Size(126, 14)
        Me.lblWall36.TabIndex = 93
        '
        'lblWall37
        '
        Me.lblWall37.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall37.Location = New System.Drawing.Point(559, 110)
        Me.lblWall37.Name = "lblWall37"
        Me.lblWall37.Size = New System.Drawing.Size(107, 14)
        Me.lblWall37.TabIndex = 94
        '
        'lblWall35
        '
        Me.lblWall35.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall35.Location = New System.Drawing.Point(538, 124)
        Me.lblWall35.Name = "lblWall35"
        Me.lblWall35.Size = New System.Drawing.Size(15, 90)
        Me.lblWall35.TabIndex = 95
        '
        'lblWall38
        '
        Me.lblWall38.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall38.Location = New System.Drawing.Point(751, -3)
        Me.lblWall38.Name = "lblWall38"
        Me.lblWall38.Size = New System.Drawing.Size(14, 127)
        Me.lblWall38.TabIndex = 96
        '
        'lblWall34
        '
        Me.lblWall34.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall34.Location = New System.Drawing.Point(751, 210)
        Me.lblWall34.Name = "lblWall34"
        Me.lblWall34.Size = New System.Drawing.Size(14, 89)
        Me.lblWall34.TabIndex = 97
        '
        'picLever3
        '
        Me.picLever3.Image = Global.Animation_Game.My.Resources.Resources.lever0
        Me.picLever3.Location = New System.Drawing.Point(791, 20)
        Me.picLever3.Name = "picLever3"
        Me.picLever3.Size = New System.Drawing.Size(40, 50)
        Me.picLever3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLever3.TabIndex = 98
        Me.picLever3.TabStop = False
        '
        'lblDoor2
        '
        Me.lblDoor2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblDoor2.Location = New System.Drawing.Point(872, 109)
        Me.lblDoor2.Name = "lblDoor2"
        Me.lblDoor2.Size = New System.Drawing.Size(115, 15)
        Me.lblDoor2.TabIndex = 99
        '
        'lblWall39
        '
        Me.lblWall39.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall39.Location = New System.Drawing.Point(857, -3)
        Me.lblWall39.Name = "lblWall39"
        Me.lblWall39.Size = New System.Drawing.Size(14, 127)
        Me.lblWall39.TabIndex = 100
        '
        'lblWall24
        '
        Me.lblWall24.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall24.Location = New System.Drawing.Point(677, 285)
        Me.lblWall24.Name = "lblWall24"
        Me.lblWall24.Size = New System.Drawing.Size(14, 310)
        Me.lblWall24.TabIndex = 101
        '
        'picLever4
        '
        Me.picLever4.Image = Global.Animation_Game.My.Resources.Resources.lever0
        Me.picLever4.Location = New System.Drawing.Point(474, 314)
        Me.picLever4.Name = "picLever4"
        Me.picLever4.Size = New System.Drawing.Size(40, 50)
        Me.picLever4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLever4.TabIndex = 102
        Me.picLever4.TabStop = False
        '
        'lblWall19
        '
        Me.lblWall19.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall19.Location = New System.Drawing.Point(333, 483)
        Me.lblWall19.Name = "lblWall19"
        Me.lblWall19.Size = New System.Drawing.Size(124, 14)
        Me.lblWall19.TabIndex = 103
        '
        'lblWall21
        '
        Me.lblWall21.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall21.Location = New System.Drawing.Point(536, 482)
        Me.lblWall21.Name = "lblWall21"
        Me.lblWall21.Size = New System.Drawing.Size(14, 126)
        Me.lblWall21.TabIndex = 104
        '
        'lblWall20
        '
        Me.lblWall20.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall20.Location = New System.Drawing.Point(471, 391)
        Me.lblWall20.Name = "lblWall20"
        Me.lblWall20.Size = New System.Drawing.Size(14, 26)
        Me.lblWall20.TabIndex = 105
        '
        'lblWall22
        '
        Me.lblWall22.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall22.Location = New System.Drawing.Point(582, 559)
        Me.lblWall22.Name = "lblWall22"
        Me.lblWall22.Size = New System.Drawing.Size(14, 49)
        Me.lblWall22.TabIndex = 106
        '
        'lblWall23
        '
        Me.lblWall23.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall23.Location = New System.Drawing.Point(631, 533)
        Me.lblWall23.Name = "lblWall23"
        Me.lblWall23.Size = New System.Drawing.Size(14, 75)
        Me.lblWall23.TabIndex = 107
        '
        'picLever5
        '
        Me.picLever5.Image = Global.Animation_Game.My.Resources.Resources.lever0
        Me.picLever5.Location = New System.Drawing.Point(697, 314)
        Me.picLever5.Name = "picLever5"
        Me.picLever5.Size = New System.Drawing.Size(40, 50)
        Me.picLever5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLever5.TabIndex = 109
        Me.picLever5.TabStop = False
        '
        'lblWall30
        '
        Me.lblWall30.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall30.Location = New System.Drawing.Point(864, 377)
        Me.lblWall30.Name = "lblWall30"
        Me.lblWall30.Size = New System.Drawing.Size(14, 109)
        Me.lblWall30.TabIndex = 110
        '
        'lblWall27
        '
        Me.lblWall27.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall27.Location = New System.Drawing.Point(789, 482)
        Me.lblWall27.Name = "lblWall27"
        Me.lblWall27.Size = New System.Drawing.Size(89, 14)
        Me.lblWall27.TabIndex = 111
        '
        'lblWall29
        '
        Me.lblWall29.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall29.Location = New System.Drawing.Point(789, 377)
        Me.lblWall29.Name = "lblWall29"
        Me.lblWall29.Size = New System.Drawing.Size(89, 14)
        Me.lblWall29.TabIndex = 112
        '
        'lblWall28
        '
        Me.lblWall28.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall28.Location = New System.Drawing.Point(788, 387)
        Me.lblWall28.Name = "lblWall28"
        Me.lblWall28.Size = New System.Drawing.Size(14, 109)
        Me.lblWall28.TabIndex = 113
        '
        'lblWall26
        '
        Me.lblWall26.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall26.Location = New System.Drawing.Point(712, 559)
        Me.lblWall26.Name = "lblWall26"
        Me.lblWall26.Size = New System.Drawing.Size(14, 49)
        Me.lblWall26.TabIndex = 114
        '
        'lblWall25
        '
        Me.lblWall25.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall25.Location = New System.Drawing.Point(678, 450)
        Me.lblWall25.Name = "lblWall25"
        Me.lblWall25.Size = New System.Drawing.Size(36, 14)
        Me.lblWall25.TabIndex = 115
        '
        'lblWall31
        '
        Me.lblWall31.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall31.Location = New System.Drawing.Point(951, 433)
        Me.lblWall31.Name = "lblWall31"
        Me.lblWall31.Size = New System.Drawing.Size(36, 14)
        Me.lblWall31.TabIndex = 116
        '
        'lblWall32
        '
        Me.lblWall32.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWall32.Location = New System.Drawing.Point(857, 295)
        Me.lblWall32.Name = "lblWall32"
        Me.lblWall32.Size = New System.Drawing.Size(14, 22)
        Me.lblWall32.TabIndex = 117
        '
        'tmrStand
        '
        Me.tmrStand.Enabled = True
        Me.tmrStand.Interval = 75
        '
        'tmrCountdown
        '
        Me.tmrCountdown.Enabled = True
        Me.tmrCountdown.Interval = 1000
        '
        'lblCountdown
        '
        Me.lblCountdown.BackColor = System.Drawing.Color.Black
        Me.lblCountdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountdown.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCountdown.Location = New System.Drawing.Point(12, 9)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(91, 51)
        Me.lblCountdown.TabIndex = 118
        Me.lblCountdown.Text = "120"
        Me.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBackground
        '
        Me.picBackground.Image = Global.Animation_Game.My.Resources.Resources.Level_4_Background
        Me.picBackground.Location = New System.Drawing.Point(0, -4)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(987, 718)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'frmLevel4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = Global.Animation_Game.My.Resources.Resources.Level_4_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.picCharacter)
        Me.Controls.Add(Me.lblWall32)
        Me.Controls.Add(Me.lblWall31)
        Me.Controls.Add(Me.lblWall25)
        Me.Controls.Add(Me.lblWall26)
        Me.Controls.Add(Me.lblWall28)
        Me.Controls.Add(Me.lblWall29)
        Me.Controls.Add(Me.lblWall27)
        Me.Controls.Add(Me.lblWall30)
        Me.Controls.Add(Me.picLever5)
        Me.Controls.Add(Me.lblWall23)
        Me.Controls.Add(Me.lblWall22)
        Me.Controls.Add(Me.lblWall20)
        Me.Controls.Add(Me.lblWall21)
        Me.Controls.Add(Me.lblWall19)
        Me.Controls.Add(Me.picLever4)
        Me.Controls.Add(Me.lblWall24)
        Me.Controls.Add(Me.lblWall39)
        Me.Controls.Add(Me.lblDoor2)
        Me.Controls.Add(Me.picLever3)
        Me.Controls.Add(Me.lblWall34)
        Me.Controls.Add(Me.lblWall38)
        Me.Controls.Add(Me.lblWall35)
        Me.Controls.Add(Me.lblWall37)
        Me.Controls.Add(Me.lblWall36)
        Me.Controls.Add(Me.picLever2)
        Me.Controls.Add(Me.lblWall33)
        Me.Controls.Add(Me.lblDoor4)
        Me.Controls.Add(Me.picTeleporter3a)
        Me.Controls.Add(Me.picTeleporter3b)
        Me.Controls.Add(Me.picTeleporter4b)
        Me.Controls.Add(Me.picTeleporter2b)
        Me.Controls.Add(Me.lblWall16)
        Me.Controls.Add(Me.lblWall17)
        Me.Controls.Add(Me.lblWall18)
        Me.Controls.Add(Me.lblWall15)
        Me.Controls.Add(Me.lblWall14)
        Me.Controls.Add(Me.lblWall9)
        Me.Controls.Add(Me.lblWall10)
        Me.Controls.Add(Me.lblWall8)
        Me.Controls.Add(Me.lblWall7)
        Me.Controls.Add(Me.lblWall6)
        Me.Controls.Add(Me.lblWall11)
        Me.Controls.Add(Me.lblWall13)
        Me.Controls.Add(Me.lblWall12)
        Me.Controls.Add(Me.picLever1)
        Me.Controls.Add(Me.picTeleporter4a)
        Me.Controls.Add(Me.picTeleporter2a)
        Me.Controls.Add(Me.picTeleporter1b)
        Me.Controls.Add(Me.lblDoor1)
        Me.Controls.Add(Me.lblDoor3)
        Me.Controls.Add(Me.lblWall4)
        Me.Controls.Add(Me.lblDoor5)
        Me.Controls.Add(Me.lblWall0)
        Me.Controls.Add(Me.lblWall3)
        Me.Controls.Add(Me.picTeleporter1a)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.lblWall2)
        Me.Controls.Add(Me.lblWall1)
        Me.Controls.Add(Me.lblWall5)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "frmLevel4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maze Game - Level 4"
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter1a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter1b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter2a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter4a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLever1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter2b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter4b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter3b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeleporter3a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLever2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLever3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLever4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLever5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCharacter As System.Windows.Forms.PictureBox
    Friend WithEvents lblWall1 As System.Windows.Forms.Label
    Friend WithEvents lblWall5 As System.Windows.Forms.Label
    Friend WithEvents lblWall2 As System.Windows.Forms.Label
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents picTeleporter1a As System.Windows.Forms.PictureBox
    Friend WithEvents lblWall3 As System.Windows.Forms.Label
    Friend WithEvents lblWall0 As System.Windows.Forms.Label
    Friend WithEvents lblDoor5 As System.Windows.Forms.Label
    Friend WithEvents lblWall4 As System.Windows.Forms.Label
    Friend WithEvents lblDoor3 As System.Windows.Forms.Label
    Friend WithEvents lblDoor1 As System.Windows.Forms.Label
    Friend WithEvents picTeleporter1b As System.Windows.Forms.PictureBox
    Friend WithEvents picTeleporter2a As System.Windows.Forms.PictureBox
    Friend WithEvents picTeleporter4a As System.Windows.Forms.PictureBox
    Friend WithEvents picLever1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWall12 As System.Windows.Forms.Label
    Friend WithEvents lblWall13 As System.Windows.Forms.Label
    Friend WithEvents lblWall11 As System.Windows.Forms.Label
    Friend WithEvents lblWall6 As System.Windows.Forms.Label
    Friend WithEvents lblWall7 As System.Windows.Forms.Label
    Friend WithEvents lblWall8 As System.Windows.Forms.Label
    Friend WithEvents lblWall10 As System.Windows.Forms.Label
    Friend WithEvents lblWall9 As System.Windows.Forms.Label
    Friend WithEvents lblWall14 As System.Windows.Forms.Label
    Friend WithEvents lblWall15 As System.Windows.Forms.Label
    Friend WithEvents lblWall18 As System.Windows.Forms.Label
    Friend WithEvents lblWall17 As System.Windows.Forms.Label
    Friend WithEvents lblWall16 As System.Windows.Forms.Label
    Friend WithEvents picTeleporter2b As System.Windows.Forms.PictureBox
    Friend WithEvents picTeleporter4b As System.Windows.Forms.PictureBox
    Friend WithEvents picTeleporter3b As System.Windows.Forms.PictureBox
    Friend WithEvents picTeleporter3a As System.Windows.Forms.PictureBox
    Friend WithEvents lblDoor4 As System.Windows.Forms.Label
    Friend WithEvents lblWall33 As System.Windows.Forms.Label
    Friend WithEvents picLever2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWall36 As System.Windows.Forms.Label
    Friend WithEvents lblWall37 As System.Windows.Forms.Label
    Friend WithEvents lblWall35 As System.Windows.Forms.Label
    Friend WithEvents lblWall38 As System.Windows.Forms.Label
    Friend WithEvents lblWall34 As System.Windows.Forms.Label
    Friend WithEvents picLever3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDoor2 As System.Windows.Forms.Label
    Friend WithEvents lblWall39 As System.Windows.Forms.Label
    Friend WithEvents lblWall24 As System.Windows.Forms.Label
    Friend WithEvents picLever4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWall19 As System.Windows.Forms.Label
    Friend WithEvents lblWall21 As System.Windows.Forms.Label
    Friend WithEvents lblWall20 As System.Windows.Forms.Label
    Friend WithEvents lblWall22 As System.Windows.Forms.Label
    Friend WithEvents lblWall23 As System.Windows.Forms.Label
    Friend WithEvents picLever5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWall30 As System.Windows.Forms.Label
    Friend WithEvents lblWall27 As System.Windows.Forms.Label
    Friend WithEvents lblWall29 As System.Windows.Forms.Label
    Friend WithEvents lblWall28 As System.Windows.Forms.Label
    Friend WithEvents lblWall26 As System.Windows.Forms.Label
    Friend WithEvents lblWall25 As System.Windows.Forms.Label
    Friend WithEvents lblWall31 As System.Windows.Forms.Label
    Friend WithEvents lblWall32 As System.Windows.Forms.Label
    Friend WithEvents tmrStand As System.Windows.Forms.Timer
    Friend WithEvents tmrCountdown As System.Windows.Forms.Timer
    Friend WithEvents lblCountdown As System.Windows.Forms.Label
    Friend WithEvents picBackground As System.Windows.Forms.PictureBox
End Class
