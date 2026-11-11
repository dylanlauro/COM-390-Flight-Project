<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJakeR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SeatLegend = New Panel()
        btnShowJakeK = New Button()
        btnShowDylan = New Button()
        Label13 = New Label()
        Label14 = New Label()
        LabelTaken = New Label()
        AvailableColor = New Panel()
        SelectedColor = New Panel()
        TakenColor = New Panel()
        SeatLegend.SuspendLayout()
        SuspendLayout()
        ' 
        ' SeatLegend
        ' 
        SeatLegend.BackColor = Color.White
        SeatLegend.BorderStyle = BorderStyle.FixedSingle
        SeatLegend.Controls.Add(Label13)
        SeatLegend.Controls.Add(Label14)
        SeatLegend.Controls.Add(LabelTaken)
        SeatLegend.Controls.Add(AvailableColor)
        SeatLegend.Controls.Add(SelectedColor)
        SeatLegend.Controls.Add(TakenColor)
        SeatLegend.Location = New Point(12, 12)
        SeatLegend.Name = "SeatLegend"
        SeatLegend.Size = New Size(140, 100)
        SeatLegend.TabIndex = 102
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(36, 12)
        Label13.Name = "Label13"
        Label13.Size = New Size(55, 15)
        Label13.TabIndex = 102
        Label13.Text = "Available"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(36, 42)
        Label14.Name = "Label14"
        Label14.Size = New Size(51, 15)
        Label14.TabIndex = 103
        Label14.Text = "Selected"
        ' 
        ' LabelTaken
        ' 
        LabelTaken.AutoSize = True
        LabelTaken.Location = New Point(36, 72)
        LabelTaken.Name = "LabelTaken"
        LabelTaken.Size = New Size(37, 15)
        LabelTaken.TabIndex = 104
        LabelTaken.Text = "Taken"
        ' 
        ' AvailableColor
        ' 
        AvailableColor.BackColor = Color.MediumSeaGreen
        AvailableColor.BorderStyle = BorderStyle.FixedSingle
        AvailableColor.Location = New Point(10, 10)
        AvailableColor.Name = "AvailableColor"
        AvailableColor.Size = New Size(18, 18)
        AvailableColor.TabIndex = 105
        ' 
        ' SelectedColor
        ' 
        SelectedColor.BackColor = Color.DeepSkyBlue
        SelectedColor.BorderStyle = BorderStyle.FixedSingle
        SelectedColor.Location = New Point(10, 40)
        SelectedColor.Name = "SelectedColor"
        SelectedColor.Size = New Size(18, 18)
        SelectedColor.TabIndex = 106
        ' 
        ' TakenColor
        ' 
        TakenColor.BackColor = Color.Gray
        TakenColor.BorderStyle = BorderStyle.FixedSingle
        TakenColor.Location = New Point(10, 70)
        TakenColor.Name = "TakenColor"
        TakenColor.Size = New Size(18, 18)
        TakenColor.TabIndex = 107
        ' 
        ' btnShowJakeK
        ' 
        btnShowJakeK.Location = New Point(12, 118)
        btnShowJakeK.Name = "btnShowJakeK"
        btnShowJakeK.Size = New Size(140, 30)
        btnShowJakeK.TabIndex = 401
        btnShowJakeK.Text = "Show Jake K"
        btnShowJakeK.UseVisualStyleBackColor = True
        ' 
        ' btnShowDylan
        ' 
        btnShowDylan.Location = New Point(12, 154)
        btnShowDylan.Name = "btnShowDylan"
        btnShowDylan.Size = New Size(140, 30)
        btnShowDylan.TabIndex = 402
        btnShowDylan.Text = "Show Dylan"
        btnShowDylan.UseVisualStyleBackColor = True
        ' 
        ' FormJakeR
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(716, 700)
        Controls.Add(SeatLegend)
        Controls.Add(btnShowJakeK)
        Controls.Add(btnShowDylan)
        Name = "FormJakeR"
        Text = "Jake R"
        SeatLegend.ResumeLayout(False)
        SeatLegend.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SeatLegend As Panel
    Friend WithEvents btnShowJakeK As Button
    Friend WithEvents btnShowDylan As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LabelTaken As Label
    Friend WithEvents AvailableColor As Panel
    Friend WithEvents SelectedColor As Panel
    Friend WithEvents TakenColor As Panel
End Class
