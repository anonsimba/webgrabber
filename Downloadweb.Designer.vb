<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Downloadweb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downloadweb))
        Me.urldownload = New System.Windows.Forms.TextBox()
        Me.download = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.menubutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'urldownload
        '
        Me.urldownload.Location = New System.Drawing.Point(90, 166)
        Me.urldownload.Name = "urldownload"
        Me.urldownload.Size = New System.Drawing.Size(605, 22)
        Me.urldownload.TabIndex = 0
        '
        'download
        '
        Me.download.Location = New System.Drawing.Point(714, 146)
        Me.download.Name = "download"
        Me.download.Size = New System.Drawing.Size(249, 42)
        Me.download.TabIndex = 1
        Me.download.Text = "Download"
        Me.download.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(87, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter URL to Download:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(228, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(577, 95)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "WebPage Downloader"
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(619, 470)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(160, 37)
        Me.logout.TabIndex = 10
        Me.logout.Text = "Log Out"
        Me.logout.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(803, 470)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(160, 37)
        Me.exitbutton.TabIndex = 11
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'menubutton
        '
        Me.menubutton.Location = New System.Drawing.Point(433, 470)
        Me.menubutton.Name = "menubutton"
        Me.menubutton.Size = New System.Drawing.Size(160, 37)
        Me.menubutton.TabIndex = 12
        Me.menubutton.Text = "Main Menu"
        Me.menubutton.UseVisualStyleBackColor = True
        '
        'Downloadweb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1023, 539)
        Me.Controls.Add(Me.menubutton)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.download)
        Me.Controls.Add(Me.urldownload)
        Me.MaximizeBox = False
        Me.Name = "Downloadweb"
        Me.Text = "Web Grabber | Download WebPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents urldownload As TextBox
    Friend WithEvents download As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents logout As Button
    Friend WithEvents exitbutton As Button
    Friend WithEvents menubutton As Button
End Class
