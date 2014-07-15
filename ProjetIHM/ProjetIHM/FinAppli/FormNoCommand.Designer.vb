<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNoCommand
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxNoCom = New System.Windows.Forms.ListBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxNoCom
        '
        Me.ListBoxNoCom.FormattingEnabled = True
        Me.ListBoxNoCom.Location = New System.Drawing.Point(51, 50)
        Me.ListBoxNoCom.Name = "ListBoxNoCom"
        Me.ListBoxNoCom.Size = New System.Drawing.Size(189, 147)
        Me.ListBoxNoCom.TabIndex = 0
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(96, 214)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetour.TabIndex = 1
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'FormNoCommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 261)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ListBoxNoCom)
        Me.Name = "FormNoCommand"
        Me.Text = "Chambres n'ayant pas commandé"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxNoCom As System.Windows.Forms.ListBox
    Friend WithEvents ButtonRetour As System.Windows.Forms.Button
End Class
