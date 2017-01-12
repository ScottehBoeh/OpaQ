Public Class Form1

    Private Sub opaqBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub opacityBar_Scroll(sender As Object, e As EventArgs) Handles opacityBar.Scroll

        'Debug.Write(opacityBar.Value)

        Opacity = opacityBar.Value / 22 + 0.1 '<-- Just so opacityBar value of "0" is opaque and not transprent/invisible

    End Sub

    Private Sub buttonForward_Click(sender As Object, e As EventArgs) Handles buttonForward.Click

        'Check that browser can actually go Forward
        If (theBrowser.CanGoForward) Then
            theBrowser.GoForward()
        End If

    End Sub

    Private Sub buttonBack_Click(sender As Object, e As EventArgs) Handles buttonBack.Click

        'Check that browser can actually go Backwards
        If (theBrowser.CanGoBack) Then
            theBrowser.GoBack()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stripMenuExit.Click

        'Close Program
        Close()

    End Sub

    Private Sub buttonHome_Click(sender As Object, e As EventArgs) Handles buttonHome.Click

        'Go to Homepage
        theBrowser.Navigate(My.Settings.Home)

    End Sub

    Private Sub buttonGo_Click(sender As Object, e As EventArgs) Handles buttonGo.Click

        'Navigate to newly entered Text (If Textbox has Value)
        If (addressBar.Text IsNot "") Then
            theBrowser.Navigate(addressBar.Text)
        End If

    End Sub

    Private Sub CurrentPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentPageToolStripMenuItem.Click

        'Change Homepage to Address Bar Value
        My.Settings.Home = addressBar.Text
        My.Settings.Save()

    End Sub

    Private Sub CustomPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomPageToolStripMenuItem.Click

        'Ask user to input name/URL of new Homepage
        Dim response As Object
        response = InputBox("Please Enter Home Page URL", "Webbrowser", My.Settings.Home)
        My.Settings.Home = response
        My.Settings.Save()

    End Sub

End Class
