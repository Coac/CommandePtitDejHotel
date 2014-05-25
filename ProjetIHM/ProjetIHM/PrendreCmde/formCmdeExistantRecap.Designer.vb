<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCmdeExistantRecap
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNbPtiDej = New System.Windows.Forms.Label()
        Me.lblNumCh = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblLieu = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnAnnul = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnConfirmer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNbPtiDej)
        Me.GroupBox1.Controls.Add(Me.lblNumCh)
        Me.GroupBox1.Controls.Add(Me.lblPrenom)
        Me.GroupBox1.Controls.Add(Me.lblNom)
        Me.GroupBox1.Controls.Add(Me.lblLieu)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(191, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 210)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations de la commande"
        '
        'lblNbPtiDej
        '
        Me.lblNbPtiDej.AutoSize = True
        Me.lblNbPtiDej.Location = New System.Drawing.Point(233, 127)
        Me.lblNbPtiDej.Name = "lblNbPtiDej"
        Me.lblNbPtiDej.Size = New System.Drawing.Size(59, 13)
        Me.lblNbPtiDej.TabIndex = 34
        Me.lblNbPtiDej.Text = "lblNbPtiDej"
        '
        'lblNumCh
        '
        Me.lblNumCh.AutoSize = True
        Me.lblNumCh.Location = New System.Drawing.Point(233, 96)
        Me.lblNumCh.Name = "lblNumCh"
        Me.lblNumCh.Size = New System.Drawing.Size(52, 13)
        Me.lblNumCh.TabIndex = 33
        Me.lblNumCh.Text = "lblNumCh"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(233, 65)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(53, 13)
        Me.lblPrenom.TabIndex = 32
        Me.lblPrenom.Text = "lblPrenom"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(233, 34)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(39, 13)
        Me.lblNom.TabIndex = 31
        Me.lblNom.Text = "lblNom"
        '
        'lblLieu
        '
        Me.lblLieu.AutoSize = True
        Me.lblLieu.Location = New System.Drawing.Point(34, 169)
        Me.lblLieu.Name = "lblLieu"
        Me.lblLieu.Size = New System.Drawing.Size(37, 13)
        Me.lblLieu.TabIndex = 30
        Me.lblLieu.Text = "lblLieu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Nombre de petit déjeuner :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Numéro de chambre : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Prénom : "
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(83, 37)
        Me.btnMenu.TabIndex = 29
        Me.btnMenu.Text = "Menu Principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnAnnul
        '
        Me.btnAnnul.Location = New System.Drawing.Point(344, 288)
        Me.btnAnnul.Name = "btnAnnul"
        Me.btnAnnul.Size = New System.Drawing.Size(92, 41)
        Me.btnAnnul.TabIndex = 32
        Me.btnAnnul.Text = "Annuler la commande"
        Me.btnAnnul.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(192, 288)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(85, 41)
        Me.btnRetour.TabIndex = 31
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnConfirmer
        '
        Me.btnConfirmer.Location = New System.Drawing.Point(501, 288)
        Me.btnConfirmer.Name = "btnConfirmer"
        Me.btnConfirmer.Size = New System.Drawing.Size(92, 41)
        Me.btnConfirmer.TabIndex = 33
        Me.btnConfirmer.Text = "Confirmer la commande"
        Me.btnConfirmer.UseVisualStyleBackColor = True
        '
        'formCmdeExistantRecap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 377)
        Me.Controls.Add(Me.btnConfirmer)
        Me.Controls.Add(Me.btnAnnul)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "formCmdeExistantRecap"
        Me.Text = "formCmdeExistantRecap"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNbPtiDej As System.Windows.Forms.Label
    Friend WithEvents lblNumCh As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblLieu As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnAnnul As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnConfirmer As System.Windows.Forms.Button
End Class
