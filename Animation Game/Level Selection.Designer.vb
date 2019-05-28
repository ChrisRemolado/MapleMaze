<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevelSelection
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
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.btnLevel1 = New System.Windows.Forms.Button()
        Me.btnLevel2 = New System.Windows.Forms.Button()
        Me.btnLevel3 = New System.Windows.Forms.Button()
        Me.btnLevel4 = New System.Windows.Forms.Button()
        Me.btnLevel5 = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.btnLevel6 = New System.Windows.Forms.Button()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.Location = New System.Drawing.Point(247, 33)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(240, 33)
        Me.lblChoose.TabIndex = 8
        Me.lblChoose.Text = "Choose a Level:"
        '
        'btnLevel1
        '
        Me.btnLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel1.Location = New System.Drawing.Point(60, 103)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(110, 37)
        Me.btnLevel1.TabIndex = 11
        Me.btnLevel1.Text = "Level 1"
        Me.btnLevel1.UseVisualStyleBackColor = True
        '
        'btnLevel2
        '
        Me.btnLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel2.Location = New System.Drawing.Point(312, 103)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(110, 37)
        Me.btnLevel2.TabIndex = 12
        Me.btnLevel2.Text = "Level 2"
        Me.btnLevel2.UseVisualStyleBackColor = True
        '
        'btnLevel3
        '
        Me.btnLevel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel3.Location = New System.Drawing.Point(564, 103)
        Me.btnLevel3.Name = "btnLevel3"
        Me.btnLevel3.Size = New System.Drawing.Size(110, 37)
        Me.btnLevel3.TabIndex = 13
        Me.btnLevel3.Text = "Level 3"
        Me.btnLevel3.UseVisualStyleBackColor = True
        '
        'btnLevel4
        '
        Me.btnLevel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel4.Location = New System.Drawing.Point(60, 184)
        Me.btnLevel4.Name = "btnLevel4"
        Me.btnLevel4.Size = New System.Drawing.Size(110, 37)
        Me.btnLevel4.TabIndex = 14
        Me.btnLevel4.Text = "Level 4"
        Me.btnLevel4.UseVisualStyleBackColor = True
        '
        'btnLevel5
        '
        Me.btnLevel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel5.Location = New System.Drawing.Point(312, 184)
        Me.btnLevel5.Name = "btnLevel5"
        Me.btnLevel5.Size = New System.Drawing.Size(110, 37)
        Me.btnLevel5.TabIndex = 15
        Me.btnLevel5.Text = "Level 5"
        Me.btnLevel5.UseVisualStyleBackColor = True
        '
        'picBackground
        '
        Me.picBackground.Image = Global.Animation_Game.My.Resources.Resources.Main_Menu_Background
        Me.picBackground.Location = New System.Drawing.Point(-1, -51)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(736, 464)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 7
        Me.picBackground.TabStop = False
        '
        'btnLevel6
        '
        Me.btnLevel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel6.Location = New System.Drawing.Point(564, 184)
        Me.btnLevel6.Name = "btnLevel6"
        Me.btnLevel6.Size = New System.Drawing.Size(110, 37)
        Me.btnLevel6.TabIndex = 16
        Me.btnLevel6.Text = "Level 6"
        Me.btnLevel6.UseVisualStyleBackColor = True
        '
        'frmLevelSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(734, 250)
        Me.Controls.Add(Me.btnLevel6)
        Me.Controls.Add(Me.btnLevel5)
        Me.Controls.Add(Me.btnLevel4)
        Me.Controls.Add(Me.btnLevel3)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "frmLevelSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maze Game - Level Selection"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBackground As System.Windows.Forms.PictureBox
    Friend WithEvents lblChoose As System.Windows.Forms.Label
    Friend WithEvents btnLevel1 As System.Windows.Forms.Button
    Friend WithEvents btnLevel2 As System.Windows.Forms.Button
    Friend WithEvents btnLevel3 As System.Windows.Forms.Button
    Friend WithEvents btnLevel4 As System.Windows.Forms.Button
    Friend WithEvents btnLevel5 As System.Windows.Forms.Button
    Friend WithEvents btnLevel6 As System.Windows.Forms.Button
End Class
