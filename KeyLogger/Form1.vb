Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If Diagnostics.Process.GetProcessesByName("notepad").Length >= 1 Then
            Timer1.Enabled = False
        End If
    End Sub
End Class