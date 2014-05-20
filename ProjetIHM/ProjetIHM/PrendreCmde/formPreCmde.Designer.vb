<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPreCmde
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
        Me.pnlService = New System.Windows.Forms.Panel()
        Me.lblService = New System.Windows.Forms.Label()
        Me.rdbChambre = New System.Windows.Forms.RadioButton()
        Me.rdbSalle = New System.Windows.Forms.RadioButton()
        Me.lblNbDej = New System.Windows.Forms.Label()
        Me.cbNbPtitDej = New System.Windows.Forms.ComboBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.hsbHeure = New System.Windows.Forms.HScrollBar()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblHeure = New System.Windows.Forms.Label()
        Me.gbHeure = New System.Windows.Forms.GroupBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblNumCh = New System.Windows.Forms.Label()
        Me.pnlService.SuspendLayout()
        Me.gbHeure.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlService
        '
        Me.pnlService.Controls.Add(Me.lblService)
        Me.pnlService.Controls.Add(Me.rdbChambre)
        Me.pnlService.Controls.Add(Me.rdbSalle)
        Me.pnlService.Location = New System.Drawing.Point(113, 171)
        Me.pnlService.Name = "pnlService"
        Me.pnlService.Size = New System.Drawing.Size(184, 96)
        Me.pnlService.TabIndex = 18
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(15, 10)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(43, 13)
        Me.lblService.TabIndex = 2
        Me.lblService.Text = "Service"
        '
        'rdbChambre
        '
        Me.rdbChambre.AutoSize = True
        Me.rdbChambre.Checked = True
        Me.rdbChambre.Location = New System.Drawing.Point(28, 37)
        Me.rdbChambre.Name = "rdbChambre"
        Me.rdbChambre.Size = New System.Drawing.Size(105, 17)
        Me.rdbChambre.TabIndex = 1
        Me.rdbChambre.TabStop = True
        Me.rdbChambre.Text = "Dans la chambre"
        Me.rdbChambre.UseVisualStyleBackColor = True
        '
        'rdbSalle
        '
        Me.rdbSalle.AutoSize = True
        Me.rdbSalle.Location = New System.Drawing.Point(28, 59)
        Me.rdbSalle.Name = "rdbSalle"
        Me.rdbSalle.Size = New System.Drawing.Size(64, 17)
        Me.rdbSalle.TabIndex = 0
        Me.rdbSalle.TabStop = True
        Me.rdbSalle.Text = "En Salle"
        Me.rdbSalle.UseVisualStyleBackColor = True
        '
        'lblNbDej
        '
        Me.lblNbDej.AutoSize = True
        Me.lblNbDej.Location = New System.Drawing.Point(388, 99)
        Me.lblNbDej.Name = "lblNbDej"
        Me.lblNbDej.Size = New System.Drawing.Size(126, 13)
        Me.lblNbDej.TabIndex = 17
        Me.lblNbDej.Text = "Nombre de petit déjeuner"
        '
        'cbNbPtitDej
        '
        Me.cbNbPtitDej.FormattingEnabled = True
        Me.cbNbPtitDej.Items.AddRange(New Object() {"1", "2", "2", "4"})
        Me.cbNbPtitDej.Location = New System.Drawing.Point(520, 96)
        Me.cbNbPtitDej.Name = "cbNbPtitDej"
        Me.cbNbPtitDej.Size = New System.Drawing.Size(35, 21)
        Me.cbNbPtitDej.TabIndex = 16
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(152, 129)
        Me.txtPrenom.MaxLength = 15
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(159, 20)
        Me.txtPrenom.TabIndex = 15
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(152, 99)
        Me.txtNom.MaxLength = 20
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(159, 20)
        Me.txtNom.TabIndex = 14
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(102, 129)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 13
        Me.lblPrenom.Text = "Prénom"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(102, 99)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 12
        Me.lblNom.Text = "Nom"
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(83, 37)
        Me.btnMenu.TabIndex = 19
        Me.btnMenu.Text = "Menu Principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(438, 304)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(78, 27)
        Me.btnSuivant.TabIndex = 20
        Me.btnSuivant.Text = "Suivant"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'hsbHeure
        '
        Me.hsbHeure.Location = New System.Drawing.Point(17, 74)
        Me.hsbHeure.Name = "hsbHeure"
        Me.hsbHeure.Size = New System.Drawing.Size(189, 17)
        Me.hsbHeure.TabIndex = 21
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(14, 41)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(31, 13)
        Me.lblMin.TabIndex = 22
        Me.lblMin.Text = "6h00"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(175, 41)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(31, 13)
        Me.lblMax.TabIndex = 23
        Me.lblMax.Text = "9h00"
        '
        'lblHeure
        '
        Me.lblHeure.AutoSize = True
        Me.lblHeure.Location = New System.Drawing.Point(93, 41)
        Me.lblHeure.Name = "lblHeure"
        Me.lblHeure.Size = New System.Drawing.Size(31, 13)
        Me.lblHeure.TabIndex = 24
        Me.lblHeure.Text = "6h00"
        '
        'gbHeure
        '
        Me.gbHeure.Controls.Add(Me.hsbHeure)
        Me.gbHeure.Controls.Add(Me.lblHeure)
        Me.gbHeure.Controls.Add(Me.lblMin)
        Me.gbHeure.Controls.Add(Me.lblMax)
        Me.gbHeure.Location = New System.Drawing.Point(360, 152)
        Me.gbHeure.Name = "gbHeure"
        Me.gbHeure.Size = New System.Drawing.Size(216, 115)
        Me.gbHeure.TabIndex = 25
        Me.gbHeure.TabStop = False
        Me.gbHeure.Text = "Vous allez être servi à"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(257, 33)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(188, 13)
        Me.lblTitre.TabIndex = 26
        Me.lblTitre.Text = "Prise de commande pour la chambre : "
        '
        'lblNumCh
        '
        Me.lblNumCh.AutoSize = True
        Me.lblNumCh.Location = New System.Drawing.Point(451, 33)
        Me.lblNumCh.Name = "lblNumCh"
        Me.lblNumCh.Size = New System.Drawing.Size(25, 13)
        Me.lblNumCh.TabIndex = 27
        Me.lblNumCh.Text = "216"
        '
        'formPreCmde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 437)
        Me.Controls.Add(Me.lblNumCh)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.gbHeure)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pnlService)
        Me.Controls.Add(Me.lblNbDej)
        Me.Controls.Add(Me.cbNbPtitDej)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Name = "formPreCmde"
        Me.Text = "Commande de petit déjeuner"
        Me.pnlService.ResumeLayout(False)
        Me.pnlService.PerformLayout()
        Me.gbHeure.ResumeLayout(False)
        Me.gbHeure.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlService As System.Windows.Forms.Panel
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents rdbChambre As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSalle As System.Windows.Forms.RadioButton
    Friend WithEvents lblNbDej As System.Windows.Forms.Label
    Friend WithEvents cbNbPtitDej As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnSuivant As System.Windows.Forms.Button
    Friend WithEvents hsbHeure As System.Windows.Forms.HScrollBar
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblHeure As System.Windows.Forms.Label
    Friend WithEvents gbHeure As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblNumCh As System.Windows.Forms.Label
End Class
