' By Dylan Lauro, Jake Krumsiek, Jake Rosa-Chaves

Public Class FormStart
    Private Sub btnShowJakeK_Click(sender As Object, e As EventArgs) Handles btnShowJakeK.Click
        Me.Hide()
        FormJakeK.Show()
    End Sub

    Private Sub btnShowDylan_Click(sender As Object, e As EventArgs) Handles btnShowDylan.Click
        Me.Hide()
        FormDylan.Show()
    End Sub

    Private Sub btnShowJakeR_Click(sender As Object, e As EventArgs) Handles btnShowJakeR.Click
        Me.Hide()
        FormJakeR.Show()
    End Sub
End Class
