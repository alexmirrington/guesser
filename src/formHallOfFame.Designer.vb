<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHallOfFame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHallOfFame))
        Me.picHOFHeading = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnNormalScores = New System.Windows.Forms.Button()
        Me.btnEpicScores = New System.Windows.Forms.Button()
        Me.btnLegendaryScores = New System.Windows.Forms.Button()
        Me.btnMyScores = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnBackToMain = New System.Windows.Forms.Button()
        CType(Me.picHOFHeading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHOFHeading
        '
        Me.picHOFHeading.BackColor = System.Drawing.Color.Transparent
        Me.picHOFHeading.Image = CType(resources.GetObject("picHOFHeading.Image"), System.Drawing.Image)
        Me.picHOFHeading.Location = New System.Drawing.Point(26, 20)
        Me.picHOFHeading.Name = "picHOFHeading"
        Me.picHOFHeading.Size = New System.Drawing.Size(377, 136)
        Me.picHOFHeading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHOFHeading.TabIndex = 2
        Me.picHOFHeading.TabStop = False
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
        'btnNormalScores
        '
        Me.btnNormalScores.BackColor = System.Drawing.Color.White
        Me.btnNormalScores.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNormalScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNormalScores.Location = New System.Drawing.Point(12, 119)
        Me.btnNormalScores.Name = "btnNormalScores"
        Me.btnNormalScores.Size = New System.Drawing.Size(98, 37)
        Me.btnNormalScores.TabIndex = 14
        Me.btnNormalScores.Tag = "0"
        Me.btnNormalScores.Text = "Normal"
        Me.btnNormalScores.UseVisualStyleBackColor = False
        '
        'btnEpicScores
        '
        Me.btnEpicScores.BackColor = System.Drawing.Color.White
        Me.btnEpicScores.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEpicScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEpicScores.Location = New System.Drawing.Point(116, 119)
        Me.btnEpicScores.Name = "btnEpicScores"
        Me.btnEpicScores.Size = New System.Drawing.Size(98, 37)
        Me.btnEpicScores.TabIndex = 15
        Me.btnEpicScores.Tag = "1"
        Me.btnEpicScores.Text = "Epic"
        Me.btnEpicScores.UseVisualStyleBackColor = False
        '
        'btnLegendaryScores
        '
        Me.btnLegendaryScores.BackColor = System.Drawing.Color.White
        Me.btnLegendaryScores.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLegendaryScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLegendaryScores.Location = New System.Drawing.Point(220, 119)
        Me.btnLegendaryScores.Name = "btnLegendaryScores"
        Me.btnLegendaryScores.Size = New System.Drawing.Size(98, 37)
        Me.btnLegendaryScores.TabIndex = 16
        Me.btnLegendaryScores.Tag = "2"
        Me.btnLegendaryScores.Text = "Legendary"
        Me.btnLegendaryScores.UseVisualStyleBackColor = False
        '
        'btnMyScores
        '
        Me.btnMyScores.BackColor = System.Drawing.Color.White
        Me.btnMyScores.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMyScores.Location = New System.Drawing.Point(324, 119)
        Me.btnMyScores.Name = "btnMyScores"
        Me.btnMyScores.Size = New System.Drawing.Size(95, 37)
        Me.btnMyScores.TabIndex = 17
        Me.btnMyScores.Tag = "3"
        Me.btnMyScores.Text = "My Scores"
        Me.btnMyScores.UseVisualStyleBackColor = False
        '
        'lstScores
        '
        Me.lstScores.BackColor = System.Drawing.Color.White
        Me.lstScores.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 18
        Me.lstScores.Location = New System.Drawing.Point(30, 162)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(368, 346)
        Me.lstScores.TabIndex = 18
        '
        'btnBackToMain
        '
        Me.btnBackToMain.BackColor = System.Drawing.Color.White
        Me.btnBackToMain.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackToMain.Location = New System.Drawing.Point(116, 514)
        Me.btnBackToMain.Name = "btnBackToMain"
        Me.btnBackToMain.Size = New System.Drawing.Size(202, 37)
        Me.btnBackToMain.TabIndex = 19
        Me.btnBackToMain.Text = "Back to Main Menu"
        Me.btnBackToMain.UseVisualStyleBackColor = False
        '
        'formHallOfFame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.btnBackToMain)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.btnMyScores)
        Me.Controls.Add(Me.btnLegendaryScores)
        Me.Controls.Add(Me.btnEpicScores)
        Me.Controls.Add(Me.btnNormalScores)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picHOFHeading)
        Me.Name = "formHallOfFame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picHOFHeading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picHOFHeading As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnNormalScores As System.Windows.Forms.Button
    Friend WithEvents btnEpicScores As System.Windows.Forms.Button
    Friend WithEvents btnLegendaryScores As System.Windows.Forms.Button
    Friend WithEvents btnMyScores As System.Windows.Forms.Button
    Friend WithEvents lstScores As System.Windows.Forms.ListBox
    Friend WithEvents btnBackToMain As System.Windows.Forms.Button
End Class
