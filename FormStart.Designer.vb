<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStart
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
        lblChooseFlight = New Label()
        btnShowJakeK = New Button()
        btnShowDylan = New Button()
        btnShowJakeR = New Button()
        SuspendLayout()
        '
        ' lblChooseFlight
        '
        lblChooseFlight.AutoSize = True
        lblChooseFlight.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChooseFlight.Location = New Point(100, 24)
        lblChooseFlight.Name = "lblChooseFlight"
        lblChooseFlight.Size = New Size(156, 25)
        lblChooseFlight.TabIndex = 0
        lblChooseFlight.Text = "Choose a flight"
        '
        ' btnShowJakeK
        '
        btnShowJakeK.Location = New Point(70, 72)
        btnShowJakeK.Name = "btnShowJakeK"
        btnShowJakeK.Size = New Size(220, 40)
        btnShowJakeK.TabIndex = 1
        btnShowJakeK.Text = "Show Jake K"
        btnShowJakeK.UseVisualStyleBackColor = True
        '
        ' btnShowDylan
        '
        btnShowDylan.Location = New Point(70, 124)
        btnShowDylan.Name = "btnShowDylan"
        btnShowDylan.Size = New Size(220, 40)
        btnShowDylan.TabIndex = 2
        btnShowDylan.Text = "Show Dylan"
        btnShowDylan.UseVisualStyleBackColor = True
        '
        ' btnShowJakeR
        '
        btnShowJakeR.Location = New Point(70, 176)
        btnShowJakeR.Name = "btnShowJakeR"
        btnShowJakeR.Size = New Size(220, 40)
        btnShowJakeR.TabIndex = 3
        btnShowJakeR.Text = "Show Jake R"
        btnShowJakeR.UseVisualStyleBackColor = True
        '
        ' FormStart
        '
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(360, 248)
        Controls.Add(lblChooseFlight)
        Controls.Add(btnShowJakeK)
        Controls.Add(btnShowDylan)
        Controls.Add(btnShowJakeR)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormStart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "COM 390 Flight Project"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblChooseFlight As Label
    Friend WithEvents btnShowJakeK As Button
    Friend WithEvents btnShowDylan As Button
    Friend WithEvents btnShowJakeR As Button
End Class
