Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Close()
        Dim user As String = "Elektro"
        Dim password As String = "smt5mumet"

        If UsernameTextBox.Text = "Elektro" And PasswordTextBox.Text = "smt5mumet" Then
            Me.Hide()
            MDI.Show()
        Else
            MessageBox.Show("Password atau username tidak sesuai", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.ExitThread()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
