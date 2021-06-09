Public Class FlashScreen
    Dim I As Integer
    Private Sub FlashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 849
        Me.Height = 277

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        I = I + 1
        If I > 5 Then
            Timer1.Enabled = False
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            LoginForm.Show()
            Me.Hide()
            Timer2.Stop()
        End If
    End Sub

    Private Sub ProgressBar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offen (*.png)|*.png |ALL Files |*.*"
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
