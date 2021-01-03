<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class urlparsing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(urlparsing))
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.urlbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gobutton = New System.Windows.Forms.Button()
        Me.mainmenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(476, 447)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(228, 48)
        Me.exitbutton.TabIndex = 0
        Me.exitbutton.Text = "EXIT"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(748, 447)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(228, 48)
        Me.logout.TabIndex = 1
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'urlbox
        '
        Me.urlbox.Location = New System.Drawing.Point(231, 131)
        Me.urlbox.Name = "urlbox"
        Me.urlbox.Size = New System.Drawing.Size(507, 22)
        Me.urlbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(79, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter URL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(336, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(368, 95)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "URL Parsing"
        '
        'gobutton
        '
        Me.gobutton.Location = New System.Drawing.Point(744, 127)
        Me.gobutton.Name = "gobutton"
        Me.gobutton.Size = New System.Drawing.Size(163, 29)
        Me.gobutton.TabIndex = 10
        Me.gobutton.Text = "GO"
        Me.gobutton.UseVisualStyleBackColor = True
        '
        'mainmenu
        '
        Me.mainmenu.Location = New System.Drawing.Point(64, 441)
        Me.mainmenu.Name = "mainmenu"
        Me.mainmenu.Size = New System.Drawing.Size(228, 54)
        Me.mainmenu.TabIndex = 11
        Me.mainmenu.Text = "Main Menu"
        Me.mainmenu.UseVisualStyleBackColor = True
        '
        'urlparsing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 529)
        Me.Controls.Add(Me.mainmenu)
        Me.Controls.Add(Me.gobutton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.urlbox)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.exitbutton)
        Me.MaximizeBox = False
        Me.Name = "urlparsing"
        Me.Text = "Web Grabber | Url Parser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitbutton As Button
    Friend WithEvents logout As Button
    Friend WithEvents urlbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gobutton As Button
    Friend WithEvents mainmenu As Button
End Class
