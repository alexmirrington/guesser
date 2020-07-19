<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.picMainHeading = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnSwitchPlayer = New System.Windows.Forms.Button()
        Me.btnHallOfFame = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.picMainHeading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMainHeading
        '
        Me.picMainHeading.BackColor = System.Drawing.Color.Transparent
        Me.picMainHeading.Image = CType(resources.GetObject("picMainHeading.Image"), System.Drawing.Image)
        Me.picMainHeading.Location = New System.Drawing.Point(12, 100)
        Me.picMainHeading.Name = "picMainHeading"
        Me.picMainHeading.Size = New System.Drawing.Size(410, 78)
        Me.picMainHeading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picMainHeading.TabIndex = 1
        Me.picMainHeading.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(12, 211)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(410, 24)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome, (playerName)"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSwitchPlayer
        '
        Me.btnSwitchPlayer.BackColor = System.Drawing.Color.White
        Me.btnSwitchPlayer.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwitchPlayer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSwitchPlayer.Location = New System.Drawing.Point(119, 378)
        Me.btnSwitchPlayer.Name = "btnSwitchPlayer"
        Me.btnSwitchPlayer.Size = New System.Drawing.Size(198, 53)
        Me.btnSwitchPlayer.TabIndex = 5
        Me.btnSwitchPlayer.Text = "Switch Player"
        Me.btnSwitchPlayer.UseVisualStyleBackColor = False
        '
        'btnHallOfFame
        '
        Me.btnHallOfFame.BackColor = System.Drawing.Color.White
        Me.btnHallOfFame.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHallOfFame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHallOfFame.Location = New System.Drawing.Point(119, 319)
        Me.btnHallOfFame.Name = "btnHallOfFame"
        Me.btnHallOfFame.Size = New System.Drawing.Size(198, 53)
        Me.btnHallOfFame.TabIndex = 6
        Me.btnHallOfFame.Text = "Hall Of Fame"
        Me.btnHallOfFame.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.White
        Me.btnPlay.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPlay.Location = New System.Drawing.Point(119, 260)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(198, 53)
        Me.btnPlay.TabIndex = 7
        Me.btnPlay.Text = "Play!"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.White
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnHallOfFame)
        Me.Controls.Add(Me.btnSwitchPlayer)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picMainHeading)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.picMainHeading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMainHeading As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnSwitchPlayer As System.Windows.Forms.Button
    Friend WithEvents btnHallOfFame As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
