' By Dylan Lauro, Jake Krumsiek, Jake Rosa-Chaves

Public Class FormJakeK
    Private Sub FormJakeK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.CurrentFlight = SQL.FlightData.Jake
        Regression.Regression()
    End Sub

    Private Sub btnShowDylan_Click(sender As Object, e As EventArgs) Handles btnShowDylan.Click
        Me.Hide()
        FormDylan.Show()
    End Sub

    Private Sub btnShowJakeR_Click(sender As Object, e As EventArgs) Handles btnShowJakeR.Click
        Me.Hide()
        FormJakeR.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class
