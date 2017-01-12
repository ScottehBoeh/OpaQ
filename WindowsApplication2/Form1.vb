Public Class opaqBrowser

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
        theBrowser.GoHome()

    End Sub

    Private Sub buttonGo_Click(sender As Object, e As EventArgs) Handles buttonGo.Click

        'Navigate to newly entered Text (If Textbox has Value)
        If (addressBar.Text IsNot "") Then
            theBrowser.Navigate(addressBar.Text)
        End If

    End Sub
End Class
