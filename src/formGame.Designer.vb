<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGame))
        Me.picGameHeading = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblGameInstructions = New System.Windows.Forms.Label()
        Me.txtInputGuess = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lblGuessesRemaining = New System.Windows.Forms.Label()
        Me.picArrowUp = New System.Windows.Forms.PictureBox()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.picArrowDown = New System.Windows.Forms.PictureBox()
        CType(Me.picGameHeading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrowDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGameHeading
        '
        Me.picGameHeading.BackColor = System.Drawing.Color.Transparent
        Me.picGameHeading.Image = CType(resources.GetObject("picGameHeading.Image"), System.Drawing.Image)
        Me.picGameHeading.Location = New System.Drawing.Point(12, 71)
        Me.picGameHeading.Name = "picGameHeading"
        Me.picGameHeading.Size = New System.Drawing.Size(410, 78)
        Me.picGameHeading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGameHeading.TabIndex = 1
        Me.picGameHeading.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.White
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblGameInstructions
        '
        Me.lblGameInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblGameInstructions.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameInstructions.ForeColor = System.Drawing.Color.White
        Me.lblGameInstructions.Location = New System.Drawing.Point(12, 162)
        Me.lblGameInstructions.Name = "lblGameInstructions"
        Me.lblGameInstructions.Size = New System.Drawing.Size(410, 24)
        Me.lblGameInstructions.TabIndex = 9
        Me.lblGameInstructions.Text = "Pick a Number Between 1 and (x)"
        Me.lblGameInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInputGuess
        '
        Me.txtInputGuess.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputGuess.Location = New System.Drawing.Point(91, 191)
        Me.txtInputGuess.Margin = New System.Windows.Forms.Padding(5)
        Me.txtInputGuess.Name = "txtInputGuess"
        Me.txtInputGuess.Size = New System.Drawing.Size(242, 26)
        Me.txtInputGuess.TabIndex = 10
        '
        'btnGuess
        '
        Me.btnGuess.BackColor = System.Drawing.Color.White
        Me.btnGuess.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuess.Location = New System.Drawing.Point(132, 225)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(164, 53)
        Me.btnGuess.TabIndex = 12
        Me.btnGuess.Text = "Guess!"
        Me.btnGuess.UseVisualStyleBackColor = False
        '
        'lblGuessesRemaining
        '
        Me.lblGuessesRemaining.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGuessesRemaining.BackColor = System.Drawing.Color.Transparent
        Me.lblGuessesRemaining.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessesRemaining.ForeColor = System.Drawing.Color.White
        Me.lblGuessesRemaining.Location = New System.Drawing.Point(12, 310)
        Me.lblGuessesRemaining.Name = "lblGuessesRemaining"
        Me.lblGuessesRemaining.Size = New System.Drawing.Size(410, 24)
        Me.lblGuessesRemaining.TabIndex = 13
        Me.lblGuessesRemaining.Text = "Guesses Remaining: (y)"
        Me.lblGuessesRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picArrowUp
        '
        Me.picArrowUp.BackColor = System.Drawing.Color.Transparent
        Me.picArrowUp.Image = CType(resources.GetObject("picArrowUp.Image"), System.Drawing.Image)
        Me.picArrowUp.Location = New System.Drawing.Point(115, 347)
        Me.picArrowUp.Name = "picArrowUp"
        Me.picArrowUp.Size = New System.Drawing.Size(205, 145)
        Me.picArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picArrowUp.TabIndex = 14
        Me.picArrowUp.TabStop = False
        Me.picArrowUp.Visible = False
        '
        'lblFeedback
        '
        Me.lblFeedback.BackColor = System.Drawing.Color.Transparent
        Me.lblFeedback.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.ForeColor = System.Drawing.Color.White
        Me.lblFeedback.Location = New System.Drawing.Point(12, 495)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(410, 24)
        Me.lblFeedback.TabIndex = 15
        Me.lblFeedback.Text = "lblFeedback"
        Me.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picArrowDown
        '
        Me.picArrowDown.BackColor = System.Drawing.Color.Transparent
        Me.picArrowDown.Image = CType(resources.GetObject("picArrowDown.Image"), System.Drawing.Image)
        Me.picArrowDown.Location = New System.Drawing.Point(115, 347)
        Me.picArrowDown.Name = "picArrowDown"
        Me.picArrowDown.Size = New System.Drawing.Size(205, 145)
        Me.picArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picArrowDown.TabIndex = 16
        Me.picArrowDown.TabStop = False
        Me.picArrowDown.Visible = False
        '
        'formGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.picArrowDown)
        Me.Controls.Add(Me.lblFeedback)
        Me.Controls.Add(Me.picArrowUp)
        Me.Controls.Add(Me.lblGuessesRemaining)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtInputGuess)
        Me.Controls.Add(Me.lblGameInstructions)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picGameHeading)
        Me.Name = "formGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        CType(Me.picGameHeading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrowDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picGameHeading As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblGameInstructions As System.Windows.Forms.Label
    Friend WithEvents txtInputGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lblGuessesRemaining As System.Windows.Forms.Label
    Friend WithEvents picArrowUp As System.Windows.Forms.PictureBox
    Friend WithEvents lblFeedback As System.Windows.Forms.Label
    Friend WithEvents picArrowDown As System.Windows.Forms.PictureBox
End Class
