<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlockWeb))
        Me.logout = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.urlbox = New System.Windows.Forms.TextBox()
        Me.block = New System.Windows.Forms.Button()
        Me.unblock = New System.Windows.Forms.Button()
        Me.viewurl = New System.Windows.Forms.Button()
        Me.menubutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(503, 449)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(201, 46)
        Me.logout.TabIndex = 0
        Me.logout.Text = "Log Out"
        Me.logout.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(732, 450)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(201, 43)
        Me.exitbutton.TabIndex = 1
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(73, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter URL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(314, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(442, 95)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Website Blocker"
        '
        'urlbox
        '
        Me.urlbox.Location = New System.Drawing.Point(259, 145)
        Me.urlbox.Name = "urlbox"
        Me.urlbox.Size = New System.Drawing.Size(674, 22)
        Me.urlbox.TabIndex = 9
        '
        'block
        '
        Me.block.Location = New System.Drawing.Point(79, 203)
        Me.block.Name = "block"
        Me.block.Size = New System.Drawing.Size(409, 61)
        Me.block.TabIndex = 10
        Me.block.Text = "Block URL"
        Me.block.UseVisualStyleBackColor = True
        '
        'unblock
        '
        Me.unblock.Location = New System.Drawing.Point(525, 203)
        Me.unblock.Name = "unblock"
        Me.unblock.Size = New System.Drawing.Size(408, 61)
        Me.unblock.TabIndex = 11
        Me.unblock.Text = "UnBlock URL"
        Me.unblock.UseVisualStyleBackColor = True
        '
        'viewurl
        '
        Me.viewurl.Location = New System.Drawing.Point(79, 289)
        Me.viewurl.Name = "viewurl"
        Me.viewurl.Size = New System.Drawing.Size(854, 61)
        Me.viewurl.TabIndex = 12
        Me.viewurl.Text = "View Blocked URLS"
        Me.viewurl.UseVisualStyleBackColor = True
        '
        'menubutton
        '
        Me.menubutton.Location = New System.Drawing.Point(35, 450)
        Me.menubutton.Name = "menubutton"
        Me.menubutton.Size = New System.Drawing.Size(201, 46)
        Me.menubutton.TabIndex = 13
        Me.menubutton.Text = "Main Menu"
        Me.menubutton.UseVisualStyleBackColor = True
        '
        'BlockWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1022, 530)
        Me.Controls.Add(Me.menubutton)
        Me.Controls.Add(Me.viewurl)
        Me.Controls.Add(Me.unblock)
        Me.Controls.Add(Me.block)
        Me.Controls.Add(Me.urlbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.logout)
        Me.MaximizeBox = False
        Me.Name = "BlockWeb"
        Me.Text = "Web Grabber | Website Blocker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logout As Button
    Friend WithEvents exitbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents urlbox As TextBox
    Friend WithEvents block As Button
    Friend WithEvents unblock As Button
    Friend WithEvents viewurl As Button
    Friend WithEvents menubutton As Button
End Class
