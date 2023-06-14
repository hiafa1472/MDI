Public Class MDI
    Private Sub KalkulatorUsiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalkulatorUsiaToolStripMenuItem.Click
        With Form1
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With Form1
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WaktuTools.Text = Now
    End Sub
End Class
