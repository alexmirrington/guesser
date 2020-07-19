<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLevelSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLevelSelect))
        Me.picDifficultyHeading = New System.Windows.Forms.PictureBox()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.btnEpic = New System.Windows.Forms.Button()
        Me.btnLegendary = New System.Windows.Forms.Button()
        Me.lblDifficultyInstructions = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.picDifficultyHeading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDifficultyHeading
        '
        Me.picDifficultyHeading.BackColor = System.Drawing.Color.Transparent
        Me.picDifficultyHeading.Image = CType(resources.GetObject("picDifficultyHeading.Image"), System.Drawing.Image)
        Me.picDifficultyHeading.Location = New System.Drawing.Point(30, 84)
        Me.picDifficultyHeading.Name = "picDifficultyHeading"
        Me.picDifficultyHeading.Size = New System.Drawing.Size(377, 136)
        Me.picDifficultyHeading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDifficultyHeading.TabIndex = 1
        Me.picDifficultyHeading.TabStop = False
        '
        'btnNormal
        '
        Me.btnNormal.BackColor = System.Drawing.Color.White
        Me.btnNormal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNormal.Location = New System.Drawing.Point(119, 260)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(198, 53)
        Me.btnNormal.TabIndex = 11
        Me.btnNormal.Tag = "0"
        Me.btnNormal.Text = "Normal"
        Me.btnNormal.UseVisualStyleBackColor = False
        '
        'btnEpic
        '
        Me.btnEpic.BackColor = System.Drawing.Color.White
        Me.btnEpic.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEpic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEpic.Location = New System.Drawing.Point(119, 319)
        Me.btnEpic.Name = "btnEpic"
        Me.btnEpic.Size = New System.Drawing.Size(198, 53)
        Me.btnEpic.TabIndex = 10
        Me.btnEpic.Tag = "1"
        Me.btnEpic.Text = "Epic"
        Me.btnEpic.UseVisualStyleBackColor = False
        '
        'btnLegendary
        '
        Me.btnLegendary.BackColor = System.Drawing.Color.White
        Me.btnLegendary.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLegendary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLegendary.Location = New System.Drawing.Point(119, 378)
        Me.btnLegendary.Name = "btnLegendary"
        Me.btnLegendary.Size = New System.Drawing.Size(198, 53)
        Me.btnLegendary.TabIndex = 9
        Me.btnLegendary.Tag = "2"
        Me.btnLegendary.Text = "Legendary"
        Me.btnLegendary.UseVisualStyleBackColor = False
        '
        'lblDifficultyInstructions
        '
        Me.lblDifficultyInstructions.AutoSize = True
        Me.lblDifficultyInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficultyInstructions.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyInstructions.ForeColor = System.Drawing.Color.White
        Me.lblDifficultyInstructions.Location = New System.Drawing.Point(60, 211)
        Me.lblDifficultyInstructions.Name = "lblDifficultyInstructions"
        Me.lblDifficultyInstructions.Size = New System.Drawing.Size(320, 24)
        Me.lblDifficultyInstructions.TabIndex = 8
        Me.lblDifficultyInstructions.Text = "Please Select a Difficulty Level"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.White
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 12
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'formLevelSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnNormal)
        Me.Controls.Add(Me.btnEpic)
        Me.Controls.Add(Me.btnLegendary)
        Me.Controls.Add(Me.lblDifficultyInstructions)
        Me.Controls.Add(Me.picDifficultyHeading)
        Me.Name = "formLevelSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level Select"
        CType(Me.picDifficultyHeading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDifficultyHeading As System.Windows.Forms.PictureBox
    Friend WithEvents btnNormal As System.Windows.Forms.Button
    Friend WithEvents btnEpic As System.Windows.Forms.Button
    Friend WithEvents btnLegendary As System.Windows.Forms.Button
    Friend WithEvents lblDifficultyInstructions As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
