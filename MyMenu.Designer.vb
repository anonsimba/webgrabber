<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyMenu))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.helpbutton = New System.Windows.Forms.Button()
        Me.aboutbutton = New System.Windows.Forms.Button()
        Me.logoutbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(338, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 95)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Main Menu"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(56, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 116)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Web Browser"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(56, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 116)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Download Web Page"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(701, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(264, 116)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Url Parsing"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(701, 311)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(264, 116)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Block Web Page"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'helpbutton
        '
        Me.helpbutton.BackgroundImage = CType(resources.GetObject("helpbutton.BackgroundImage"), System.Drawing.Image)
        Me.helpbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.helpbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.helpbutton.Location = New System.Drawing.Point(12, 484)
        Me.helpbutton.Name = "helpbutton"
        Me.helpbutton.Size = New System.Drawing.Size(223, 50)
        Me.helpbutton.TabIndex = 13
        Me.helpbutton.Text = "Help"
        Me.helpbutton.UseVisualStyleBackColor = True
        '
        'aboutbutton
        '
        Me.aboutbutton.BackgroundImage = CType(resources.GetObject("aboutbutton.BackgroundImage"), System.Drawing.Image)
        Me.aboutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.aboutbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.aboutbutton.Location = New System.Drawing.Point(256, 484)
        Me.aboutbutton.Name = "aboutbutton"
        Me.aboutbutton.Size = New System.Drawing.Size(235, 50)
        Me.aboutbutton.TabIndex = 14
        Me.aboutbutton.Text = "About"
        Me.aboutbutton.UseVisualStyleBackColor = True
        '
        'logoutbutton
        '
        Me.logoutbutton.BackgroundImage = CType(resources.GetObject("logoutbutton.BackgroundImage"), System.Drawing.Image)
        Me.logoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoutbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.logoutbutton.Location = New System.Drawing.Point(507, 484)
        Me.logoutbutton.Name = "logoutbutton"
        Me.logoutbutton.Size = New System.Drawing.Size(233, 50)
        Me.logoutbutton.TabIndex = 15
        Me.logoutbutton.Text = "Log Out"
        Me.logoutbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.BackgroundImage = CType(resources.GetObject("exitbutton.BackgroundImage"), System.Drawing.Image)
        Me.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.exitbutton.Location = New System.Drawing.Point(772, 484)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(238, 50)
        Me.exitbutton.TabIndex = 16
        Me.exitbutton.Text = "EXIT"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(338, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 272)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'MyMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1022, 546)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.logoutbutton)
        Me.Controls.Add(Me.aboutbutton)
        Me.Controls.Add(Me.helpbutton)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "MyMenu"
        Me.Text = "Web Grabber | Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents helpbutton As Button
    Friend WithEvents aboutbutton As Button
    Friend WithEvents logoutbutton As Button
    Friend WithEvents exitbutton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
