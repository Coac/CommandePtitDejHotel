<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCancel
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
        Me.ListBoxCancel = New System.Windows.Forms.ListBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxCancel
        '
        Me.ListBoxCancel.FormattingEnabled = True
        Me.ListBoxCancel.Location = New System.Drawing.Point(147, 50)
        Me.ListBoxCancel.Name = "ListBoxCancel"
        Me.ListBoxCancel.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxCancel.TabIndex = 0
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(165, 181)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetour.TabIndex = 2
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'FormCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 261)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ListBoxCancel)
        Me.Name = "FormCancel"
        Me.Text = "Chambre ayant annulé leur commande"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxCancel As System.Windows.Forms.ListBox
    Friend WithEvents ButtonRetour As System.Windows.Forms.Button
End Class
