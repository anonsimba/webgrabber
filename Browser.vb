Public Class Browser
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        WebBrowser1.Navigate(urlfield.Text)
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub refreshbutton_Click(sender As Object, e As EventArgs) Handles refreshbutton.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub Forwordbutton_Click(sender As Object, e As EventArgs) Handles Forwordbutton.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Application.Exit()
    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menubutton.Click
        Hide()
        MyMenu.Show()
    End Sub
End Class