<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCmdeRecap
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
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnConfirmer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNbPtiDej = New System.Windows.Forms.Label()
        Me.lblNumCh = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblLieu = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBoissonFroide = New System.Windows.Forms.Label()
        Me.lblBoissonChaude = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbSupp = New System.Windows.Forms.ListBox()
        Me.lbAccom = New System.Windows.Forms.ListBox()
        Me.lbViennoi = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbNbCmde = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIndiceCmde = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(83, 37)
        Me.btnMenu.TabIndex = 21
        Me.btnMenu.Text = "Menu Principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(245, 558)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(85, 41)
        Me.btnRetour.TabIndex = 24
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnConfirmer
        '
        Me.btnConfirmer.Location = New System.Drawing.Point(384, 558)
        Me.btnConfirmer.Name = "btnConfirmer"
        Me.btnConfirmer.Size = New System.Drawing.Size(92, 41)
        Me.btnConfirmer.TabIndex = 25
        Me.btnConfirmer.Text = "Confirmer la commande"
        Me.btnConfirmer.UseVisualStyleBackColor = True
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
        Me.GroupBox1.TabIndex = 28
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBoissonFroide)
        Me.GroupBox2.Controls.Add(Me.lblBoissonChaude)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lbSupp)
        Me.GroupBox2.Controls.Add(Me.lbAccom)
        Me.GroupBox2.Controls.Add(Me.lbViennoi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(191, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 222)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Récapitulatif du Petit Déjeuner"
        '
        'lblBoissonFroide
        '
        Me.lblBoissonFroide.AutoSize = True
        Me.lblBoissonFroide.Location = New System.Drawing.Point(236, 70)
        Me.lblBoissonFroide.Name = "lblBoissonFroide"
        Me.lblBoissonFroide.Size = New System.Drawing.Size(83, 13)
        Me.lblBoissonFroide.TabIndex = 9
        Me.lblBoissonFroide.Text = "lblBoissonFroide"
        '
        'lblBoissonChaude
        '
        Me.lblBoissonChaude.AutoSize = True
        Me.lblBoissonChaude.Location = New System.Drawing.Point(236, 42)
        Me.lblBoissonChaude.Name = "lblBoissonChaude"
        Me.lblBoissonChaude.Size = New System.Drawing.Size(91, 13)
        Me.lblBoissonChaude.TabIndex = 8
        Me.lblBoissonChaude.Text = "lblBoissonChaude"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(290, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Supplément(s)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(153, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Accomodement(s)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Viennoiserie(s)"
        '
        'lbSupp
        '
        Me.lbSupp.FormattingEnabled = True
        Me.lbSupp.Location = New System.Drawing.Point(266, 126)
        Me.lbSupp.Name = "lbSupp"
        Me.lbSupp.Size = New System.Drawing.Size(120, 69)
        Me.lbSupp.TabIndex = 4
        '
        'lbAccom
        '
        Me.lbAccom.FormattingEnabled = True
        Me.lbAccom.Location = New System.Drawing.Point(140, 126)
        Me.lbAccom.Name = "lbAccom"
        Me.lbAccom.Size = New System.Drawing.Size(120, 69)
        Me.lbAccom.TabIndex = 3
        '
        'lbViennoi
        '
        Me.lbViennoi.FormattingEnabled = True
        Me.lbViennoi.Location = New System.Drawing.Point(14, 126)
        Me.lbViennoi.Name = "lbViennoi"
        Me.lbViennoi.Size = New System.Drawing.Size(120, 69)
        Me.lbViennoi.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Boisson Froide : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Boisson Chaude :"
        '
        'lbNbCmde
        '
        Me.lbNbCmde.AutoSize = True
        Me.lbNbCmde.Location = New System.Drawing.Point(575, 497)
        Me.lbNbCmde.Name = "lbNbCmde"
        Me.lbNbCmde.Size = New System.Drawing.Size(13, 13)
        Me.lbNbCmde.TabIndex = 32
        Me.lbNbCmde.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(556, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "/"
        '
        'lblIndiceCmde
        '
        Me.lblIndiceCmde.AutoSize = True
        Me.lblIndiceCmde.Location = New System.Drawing.Point(536, 497)
        Me.lblIndiceCmde.Name = "lblIndiceCmde"
        Me.lblIndiceCmde.Size = New System.Drawing.Size(13, 13)
        Me.lblIndiceCmde.TabIndex = 30
        Me.lblIndiceCmde.Text = "1"
        '
        'formCmdeRecap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 654)
        Me.Controls.Add(Me.lbNbCmde)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblIndiceCmde)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConfirmer)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "formCmdeRecap"
        Me.Text = "Récapitulatif de la commande"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnConfirmer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNbPtiDej As System.Windows.Forms.Label
    Friend WithEvents lblNumCh As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblLieu As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbNbCmde As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblIndiceCmde As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbViennoi As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbSupp As System.Windows.Forms.ListBox
    Friend WithEvents lbAccom As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBoissonFroide As System.Windows.Forms.Label
    Friend WithEvents lblBoissonChaude As System.Windows.Forms.Label
End Class
