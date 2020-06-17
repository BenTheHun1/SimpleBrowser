Public Class frmWeb
    Private Sub frmWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webBrowser.ScriptErrorsSuppressed = True
        webBrowser.Refresh()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webBrowser.DocumentCompleted
        txtURL.Text = webBrowser.Document.Url.AbsoluteUri
        If webBrowser.CanGoForward = True Then
            btnForward.Enabled = True
        Else
            btnForward.Enabled = False
        End If
        If webBrowser.CanGoBack = True Then
            btnBack.Enabled = True
        Else
            btnBack.Enabled = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        webBrowser.GoBack()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        webBrowser.GoForward()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        webBrowser.Navigate(txtURL.Text)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        webBrowser.Refresh()
    End Sub
End Class
