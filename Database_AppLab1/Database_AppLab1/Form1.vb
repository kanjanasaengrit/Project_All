Public Class Form1
    Private Sub OpenCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCalculatorToolStripMenuItem.Click
        Calculator.MdiParent = Me
        Calculator.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class
