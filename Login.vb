Public Class Login

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Dim answer As MsgBoxResult
        answer = MsgBox("Do you want to quit now?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        'loginbox
        If loginbox.Text = String.Empty Then
            MsgBox("Please Enter Username", MsgBoxStyle.Information, "Web Grabber")
        End If
        If password.Text = String.Empty Then
            MsgBox("Please Enter Password", MsgBoxStyle.Information, "Web Grabber")
            Return
        End If
        If loginbox.Text = "admin" And
        password.Text = "admin" Then
            Me.Hide()
            MyMenu.Show()
        Else
            MsgBox("Incorrect Username or Password!", MsgBoxStyle.Information, "Web Grabber")
        End If
    End Sub


End Class
