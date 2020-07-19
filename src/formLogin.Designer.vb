<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Me.picLoginHeading = New System.Windows.Forms.PictureBox()
        Me.lblLoginInstructions = New System.Windows.Forms.Label()
        Me.txtInputPlayername = New System.Windows.Forms.TextBox()
        Me.btnClearPlayername = New System.Windows.Forms.Button()
        Me.btnSubmitPlayername = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.picLoginHeading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLoginHeading
        '
        Me.picLoginHeading.BackColor = System.Drawing.Color.Transparent
        Me.picLoginHeading.Image = CType(resources.GetObject("picLoginHeading.Image"), System.Drawing.Image)
        Me.picLoginHeading.Location = New System.Drawing.Point(12, 111)
        Me.picLoginHeading.Name = "picLoginHeading"
        Me.picLoginHeading.Size = New System.Drawing.Size(410, 78)
        Me.picLoginHeading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLoginHeading.TabIndex = 0
        Me.picLoginHeading.TabStop = False
        '
        'lblLoginInstructions
        '
        Me.lblLoginInstructions.AutoSize = True
        Me.lblLoginInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginInstructions.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginInstructions.ForeColor = System.Drawing.Color.White
        Me.lblLoginInstructions.Location = New System.Drawing.Point(66, 215)
        Me.lblLoginInstructions.Name = "lblLoginInstructions"
        Me.lblLoginInstructions.Size = New System.Drawing.Size(306, 24)
        Me.lblLoginInstructions.TabIndex = 1
        Me.lblLoginInstructions.Text = "Please choose a Player Name"
        '
        'txtInputPlayername
        '
        Me.txtInputPlayername.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputPlayername.Location = New System.Drawing.Point(70, 261)
        Me.txtInputPlayername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtInputPlayername.Name = "txtInputPlayername"
        Me.txtInputPlayername.Size = New System.Drawing.Size(302, 26)
        Me.txtInputPlayername.TabIndex = 2
        '
        'btnClearPlayername
        '
        Me.btnClearPlayername.BackColor = System.Drawing.Color.White
        Me.btnClearPlayername.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPlayername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClearPlayername.Location = New System.Drawing.Point(70, 295)
        Me.btnClearPlayername.Name = "btnClearPlayername"
        Me.btnClearPlayername.Size = New System.Drawing.Size(98, 49)
        Me.btnClearPlayername.TabIndex = 3
        Me.btnClearPlayername.Text = "Clear"
        Me.btnClearPlayername.UseVisualStyleBackColor = False
        '
        'btnSubmitPlayername
        '
        Me.btnSubmitPlayername.BackColor = System.Drawing.Color.White
        Me.btnSubmitPlayername.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitPlayername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmitPlayername.Location = New System.Drawing.Point(174, 295)
        Me.btnSubmitPlayername.Name = "btnSubmitPlayername"
        Me.btnSubmitPlayername.Size = New System.Drawing.Size(198, 49)
        Me.btnSubmitPlayername.TabIndex = 4
        Me.btnSubmitPlayername.Text = "Submit"
        Me.btnSubmitPlayername.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.White
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.White
        Me.btnQuit.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQuit.Location = New System.Drawing.Point(70, 513)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(302, 37)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit Game"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnSubmitPlayername)
        Me.Controls.Add(Me.btnClearPlayername)
        Me.Controls.Add(Me.txtInputPlayername)
        Me.Controls.Add(Me.lblLoginInstructions)
        Me.Controls.Add(Me.picLoginHeading)
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.picLoginHeading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLoginHeading As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoginInstructions As System.Windows.Forms.Label
    Friend WithEvents txtInputPlayername As System.Windows.Forms.TextBox
    Friend WithEvents btnClearPlayername As System.Windows.Forms.Button
    Friend WithEvents btnSubmitPlayername As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
