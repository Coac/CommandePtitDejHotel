<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuFin
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
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ButtonNoCom = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.btnChCmde = New System.Windows.Forms.Button()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(25, 247)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(58, 43)
        Me.ButtonRetour.TabIndex = 0
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'ButtonNoCom
        '
        Me.ButtonNoCom.Location = New System.Drawing.Point(25, 77)
        Me.ButtonNoCom.Name = "ButtonNoCom"
        Me.ButtonNoCom.Size = New System.Drawing.Size(198, 60)
        Me.ButtonNoCom.TabIndex = 1
        Me.ButtonNoCom.Text = "Liste des chambres qui n'ont rien commandé" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonNoCom.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(246, 77)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(198, 60)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Liste des chambres qui ont annulé leur commande" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'btnChCmde
        '
        Me.btnChCmde.Location = New System.Drawing.Point(474, 77)
        Me.btnChCmde.Name = "btnChCmde"
        Me.btnChCmde.Size = New System.Drawing.Size(198, 60)
        Me.btnChCmde.TabIndex = 3
        Me.btnChCmde.Text = "Liste des chambres qui ont passé une commande" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnChCmde.UseVisualStyleBackColor = True
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(570, 252)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(78, 32)
        Me.ButtonQuit.TabIndex = 4
        Me.ButtonQuit.Text = "Quitter"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'FormMenuFin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 302)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.btnChCmde)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonNoCom)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Name = "FormMenuFin"
        Me.Text = "Visualitsation des éléments comptables"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonRetour As System.Windows.Forms.Button
    Friend WithEvents ButtonNoCom As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents btnChCmde As System.Windows.Forms.Button
    Friend WithEvents ButtonQuit As System.Windows.Forms.Button
End Class
