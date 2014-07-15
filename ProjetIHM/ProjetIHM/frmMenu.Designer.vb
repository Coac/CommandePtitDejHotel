<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.btnHote = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnClient
        '
        Me.btnClient.Location = New System.Drawing.Point(57, 230)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(144, 53)
        Me.btnClient.TabIndex = 0
        Me.btnClient.Text = "Prendre une commande"
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        Me.btnFin.Location = New System.Drawing.Point(404, 230)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(144, 53)
        Me.btnFin.TabIndex = 1
        Me.btnFin.Text = "Fin et visualisation des éléments comptables"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'btnHote
        '
        Me.btnHote.Location = New System.Drawing.Point(230, 230)
        Me.btnHote.Name = "btnHote"
        Me.btnHote.Size = New System.Drawing.Size(144, 53)
        Me.btnHote.TabIndex = 2
        Me.btnHote.Text = "Afficher les renseignements sur les commandes"
        Me.btnHote.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(251, 52)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(76, 13)
        Me.lblTitre.TabIndex = 3
        Me.lblTitre.Text = "Menu principal"
        '
        'tmr
        '
        Me.tmr.Interval = 3000
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 351)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnHote)
        Me.Controls.Add(Me.btnFin)
        Me.Controls.Add(Me.btnClient)
        Me.Name = "frmMenu"
        Me.Text = "Menu principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClient As System.Windows.Forms.Button
    Friend WithEvents btnFin As System.Windows.Forms.Button
    Friend WithEvents btnHote As System.Windows.Forms.Button
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents tmr As System.Windows.Forms.Timer

End Class
