<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.loginbox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'password
        '
        Me.password.HideSelection = False
        Me.password.Location = New System.Drawing.Point(566, 258)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(376, 22)
        Me.password.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(421, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(421, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(60, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 332)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'loginbutton
        '
        Me.loginbutton.Location = New System.Drawing.Point(427, 330)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(241, 48)
        Me.loginbutton.TabIndex = 5
        Me.loginbutton.Text = "Login"
        Me.loginbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(696, 330)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(246, 48)
        Me.exitbutton.TabIndex = 6
        Me.exitbutton.Text = "EXIT"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(550, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 95)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Web Grabber"
        '
        'loginbox
        '
        Me.loginbox.Location = New System.Drawing.Point(566, 202)
        Me.loginbox.Name = "loginbox"
        Me.loginbox.Size = New System.Drawing.Size(376, 22)
        Me.loginbox.TabIndex = 8
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1031, 545)
        Me.Controls.Add(Me.loginbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.loginbutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Web Grabber | Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginbutton As Button
    Friend WithEvents exitbutton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents loginbox As TextBox
End Class
