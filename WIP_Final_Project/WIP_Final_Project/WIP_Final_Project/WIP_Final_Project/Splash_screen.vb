Public Class Splash_screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (loadBar.Value = loadBar.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            LogReg.Show()
        Else
            loadBar.PerformStep()
        End If
    End Sub

    Private Sub Splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
