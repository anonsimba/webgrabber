<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.urlfield = New System.Windows.Forms.TextBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.refreshbutton = New System.Windows.Forms.Button()
        Me.Forwordbutton = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.menubutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'urlfield
        '
        Me.urlfield.Location = New System.Drawing.Point(22, 3)
        Me.urlfield.Name = "urlfield"
        Me.urlfield.Size = New System.Drawing.Size(1285, 22)
        Me.urlfield.TabIndex = 0
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(1313, 0)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(131, 25)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(1, 75)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1457, 754)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("https://google.com", System.UriKind.Absolute)
        '
        'backbutton
        '
        Me.backbutton.Location = New System.Drawing.Point(22, 30)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(219, 40)
        Me.backbutton.TabIndex = 3
        Me.backbutton.Text = "Back"
        Me.backbutton.UseVisualStyleBackColor = True
        '
        'refreshbutton
        '
        Me.refreshbutton.Location = New System.Drawing.Point(256, 31)
        Me.refreshbutton.Name = "refreshbutton"
        Me.refreshbutton.Size = New System.Drawing.Size(199, 39)
        Me.refreshbutton.TabIndex = 4
        Me.refreshbutton.Text = "Refresh"
        Me.refreshbutton.UseVisualStyleBackColor = True
        '
        'Forwordbutton
        '
        Me.Forwordbutton.Location = New System.Drawing.Point(481, 30)
        Me.Forwordbutton.Name = "Forwordbutton"
        Me.Forwordbutton.Size = New System.Drawing.Size(206, 40)
        Me.Forwordbutton.TabIndex = 5
        Me.Forwordbutton.Text = "Forword"
        Me.Forwordbutton.UseVisualStyleBackColor = True
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(937, 31)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(219, 40)
        Me.logout.TabIndex = 6
        Me.logout.Text = "LogOut"
        Me.logout.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(1178, 30)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(266, 39)
        Me.exitbutton.TabIndex = 7
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'menubutton
        '
        Me.menubutton.Location = New System.Drawing.Point(706, 29)
        Me.menubutton.Name = "menubutton"
        Me.menubutton.Size = New System.Drawing.Size(213, 39)
        Me.menubutton.TabIndex = 8
        Me.menubutton.Text = "Main Menu"
        Me.menubutton.UseVisualStyleBackColor = True
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1456, 831)
        Me.Controls.Add(Me.menubutton)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Forwordbutton)
        Me.Controls.Add(Me.refreshbutton)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.urlfield)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Browser"
        Me.Text = "Web Grabber | Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents urlfield As TextBox
    Friend WithEvents GoButton As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents backbutton As Button
    Friend WithEvents refreshbutton As Button
    Friend WithEvents Forwordbutton As Button
    Friend WithEvents logout As Button
    Friend WithEvents exitbutton As Button
    Friend WithEvents menubutton As Button
End Class
