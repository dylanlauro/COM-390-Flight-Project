' By Dylan Lauro, Jake Krumsiek, Jake Rosa-Chaves

Public Class FormJakeR
    Private Sub btnShowJakeK_Click(sender As Object, e As EventArgs) Handles btnShowJakeK.Click
        Me.Hide()
        FormJakeK.Show()
    End Sub

    Private Sub btnShowDylan_Click(sender As Object, e As EventArgs) Handles btnShowDylan.Click
        Me.Hide()
        FormDylan.Show()
    End Sub

    Private Sub FormJakeR_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
