Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 261
        Me.Height = 421
        txtDisplay.Width = 218
        txtDisplay.Height = 59
        Me.Text = "Standard Calculation"

    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Width = 510
        Me.Height = 416
        txtDisplay.Width = 459
        txtDisplay.Height = 59
        Me.Text = "Scientific Calculator"

    End Sub

    Private Sub TemperatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemperatureToolStripMenuItem.Click
        Me.Width = 847
        Me.Height = 416
        txtDisplay.Width = 459
        txtDisplay.Height = 59
        Me.Text = "Temperature"
    End Sub

End Class
