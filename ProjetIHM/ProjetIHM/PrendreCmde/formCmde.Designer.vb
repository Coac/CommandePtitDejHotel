<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCmde
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
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.cbNbPtitDej = New System.Windows.Forms.ComboBox()
        Me.lblNbDej = New System.Windows.Forms.Label()
        Me.pnlService = New System.Windows.Forms.Panel()
        Me.lblService = New System.Windows.Forms.Label()
        Me.rdbChambre = New System.Windows.Forms.RadioButton()
        Me.rdbSalle = New System.Windows.Forms.RadioButton()
        Me.gbBoissonChaude = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.gbViennnoiseries = New System.Windows.Forms.GroupBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.gbAccommodements = New System.Windows.Forms.GroupBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.gbBoissonFroide = New System.Windows.Forms.GroupBox()
        Me.cbBoissonFroide = New System.Windows.Forms.ComboBox()
        Me.gbSupplements = New System.Windows.Forms.GroupBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.pnlService.SuspendLayout()
        Me.gbBoissonChaude.SuspendLayout()
        Me.gbViennnoiseries.SuspendLayout()
        Me.gbAccommodements.SuspendLayout()
        Me.gbBoissonFroide.SuspendLayout()
        Me.gbSupplements.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(83, 37)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Menu Principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(96, 101)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 5
        Me.lblNom.Text = "Nom"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(96, 131)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 6
        Me.lblPrenom.Text = "Prénom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(146, 101)
        Me.txtNom.MaxLength = 20
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(159, 20)
        Me.txtNom.TabIndex = 7
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(146, 131)
        Me.txtPrenom.MaxLength = 15
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(159, 20)
        Me.txtPrenom.TabIndex = 8
        '
        'cbNbPtitDej
        '
        Me.cbNbPtitDej.FormattingEnabled = True
        Me.cbNbPtitDej.Items.AddRange(New Object() {"1", "2", "2", "4"})
        Me.cbNbPtitDej.Location = New System.Drawing.Point(464, 98)
        Me.cbNbPtitDej.Name = "cbNbPtitDej"
        Me.cbNbPtitDej.Size = New System.Drawing.Size(35, 21)
        Me.cbNbPtitDej.TabIndex = 9
        '
        'lblNbDej
        '
        Me.lblNbDej.AutoSize = True
        Me.lblNbDej.Location = New System.Drawing.Point(332, 101)
        Me.lblNbDej.Name = "lblNbDej"
        Me.lblNbDej.Size = New System.Drawing.Size(126, 13)
        Me.lblNbDej.TabIndex = 10
        Me.lblNbDej.Text = "Nombre de petit déjeuner"
        '
        'pnlService
        '
        Me.pnlService.Controls.Add(Me.lblService)
        Me.pnlService.Controls.Add(Me.rdbChambre)
        Me.pnlService.Controls.Add(Me.rdbSalle)
        Me.pnlService.Location = New System.Drawing.Point(576, 98)
        Me.pnlService.Name = "pnlService"
        Me.pnlService.Size = New System.Drawing.Size(184, 96)
        Me.pnlService.TabIndex = 11
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
        'gbBoissonChaude
        '
        Me.gbBoissonChaude.Controls.Add(Me.RadioButton7)
        Me.gbBoissonChaude.Controls.Add(Me.RadioButton6)
        Me.gbBoissonChaude.Controls.Add(Me.RadioButton5)
        Me.gbBoissonChaude.Controls.Add(Me.RadioButton4)
        Me.gbBoissonChaude.Controls.Add(Me.RadioButton3)
        Me.gbBoissonChaude.Controls.Add(Me.RadioButton2)
        Me.gbBoissonChaude.Controls.Add(Me.RadioButton1)
        Me.gbBoissonChaude.Location = New System.Drawing.Point(99, 255)
        Me.gbBoissonChaude.Name = "gbBoissonChaude"
        Me.gbBoissonChaude.Size = New System.Drawing.Size(168, 284)
        Me.gbBoissonChaude.TabIndex = 12
        Me.gbBoissonChaude.TabStop = False
        Me.gbBoissonChaude.Text = "Boisson Chaude"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Location = New System.Drawing.Point(38, 32)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "RadioButton7"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(38, 66)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(38, 100)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(38, 236)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(38, 202)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(38, 168)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(38, 134)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'gbViennnoiseries
        '
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox8)
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox7)
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox6)
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox5)
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox4)
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox3)
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox2)
        Me.gbViennnoiseries.Controls.Add(Me.CheckBox1)
        Me.gbViennnoiseries.Location = New System.Drawing.Point(360, 255)
        Me.gbViennnoiseries.Name = "gbViennnoiseries"
        Me.gbViennnoiseries.Size = New System.Drawing.Size(308, 173)
        Me.gbViennnoiseries.TabIndex = 13
        Me.gbViennnoiseries.TabStop = False
        Me.gbViennnoiseries.Text = "Viennoiseries"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(193, 134)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(193, 100)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(193, 66)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(193, 34)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(17, 134)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(17, 100)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(17, 64)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'gbAccommodements
        '
        Me.gbAccommodements.Controls.Add(Me.CheckBox13)
        Me.gbAccommodements.Controls.Add(Me.CheckBox12)
        Me.gbAccommodements.Controls.Add(Me.CheckBox11)
        Me.gbAccommodements.Controls.Add(Me.CheckBox10)
        Me.gbAccommodements.Controls.Add(Me.CheckBox9)
        Me.gbAccommodements.Location = New System.Drawing.Point(718, 255)
        Me.gbAccommodements.Name = "gbAccommodements"
        Me.gbAccommodements.Size = New System.Drawing.Size(156, 219)
        Me.gbAccommodements.TabIndex = 14
        Me.gbAccommodements.TabStop = False
        Me.gbAccommodements.Tag = "c"
        Me.gbAccommodements.Text = "Accommodements"
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(21, 166)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox13.TabIndex = 4
        Me.CheckBox13.Text = "CheckBox13"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(21, 133)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox12.TabIndex = 3
        Me.CheckBox12.Text = "CheckBox12"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(21, 100)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox11.TabIndex = 2
        Me.CheckBox11.Text = "CheckBox11"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(21, 67)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox10.TabIndex = 1
        Me.CheckBox10.Text = "CheckBox10"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(21, 34)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox9.TabIndex = 0
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'gbBoissonFroide
        '
        Me.gbBoissonFroide.Controls.Add(Me.cbBoissonFroide)
        Me.gbBoissonFroide.Location = New System.Drawing.Point(431, 466)
        Me.gbBoissonFroide.Name = "gbBoissonFroide"
        Me.gbBoissonFroide.Size = New System.Drawing.Size(203, 61)
        Me.gbBoissonFroide.TabIndex = 15
        Me.gbBoissonFroide.TabStop = False
        Me.gbBoissonFroide.Text = "Boisson Froide"
        '
        'cbBoissonFroide
        '
        Me.cbBoissonFroide.FormattingEnabled = True
        Me.cbBoissonFroide.Location = New System.Drawing.Point(43, 24)
        Me.cbBoissonFroide.Name = "cbBoissonFroide"
        Me.cbBoissonFroide.Size = New System.Drawing.Size(121, 21)
        Me.cbBoissonFroide.TabIndex = 0
        '
        'gbSupplements
        '
        Me.gbSupplements.Controls.Add(Me.CheckBox23)
        Me.gbSupplements.Controls.Add(Me.CheckBox22)
        Me.gbSupplements.Controls.Add(Me.CheckBox21)
        Me.gbSupplements.Controls.Add(Me.CheckBox20)
        Me.gbSupplements.Controls.Add(Me.CheckBox19)
        Me.gbSupplements.Controls.Add(Me.CheckBox18)
        Me.gbSupplements.Controls.Add(Me.CheckBox17)
        Me.gbSupplements.Controls.Add(Me.CheckBox16)
        Me.gbSupplements.Controls.Add(Me.CheckBox15)
        Me.gbSupplements.Controls.Add(Me.CheckBox14)
        Me.gbSupplements.Location = New System.Drawing.Point(99, 578)
        Me.gbSupplements.Name = "gbSupplements"
        Me.gbSupplements.Size = New System.Drawing.Size(775, 107)
        Me.gbSupplements.TabIndex = 16
        Me.gbSupplements.TabStop = False
        Me.gbSupplements.Text = "Suppléments"
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(27, 31)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox14.TabIndex = 0
        Me.CheckBox14.Text = "CheckBox14"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(180, 31)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox15.TabIndex = 1
        Me.CheckBox15.Text = "CheckBox15"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(333, 31)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox16.TabIndex = 2
        Me.CheckBox16.Text = "CheckBox16"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(486, 31)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox17.TabIndex = 3
        Me.CheckBox17.Text = "CheckBox17"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(639, 31)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox18.TabIndex = 4
        Me.CheckBox18.Text = "CheckBox18"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(27, 68)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox19.TabIndex = 5
        Me.CheckBox19.Text = "CheckBox19"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Location = New System.Drawing.Point(180, 68)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox20.TabIndex = 6
        Me.CheckBox20.Text = "CheckBox20"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Location = New System.Drawing.Point(332, 68)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox21.TabIndex = 7
        Me.CheckBox21.Text = "CheckBox21"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Location = New System.Drawing.Point(486, 68)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox22.TabIndex = 8
        Me.CheckBox22.Text = "CheckBox22"
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Location = New System.Drawing.Point(639, 68)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox23.TabIndex = 9
        Me.CheckBox23.Text = "CheckBox23"
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'formCmde
        '
        Me.AccessibleDescription = "sc"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 711)
        Me.Controls.Add(Me.gbSupplements)
        Me.Controls.Add(Me.gbBoissonFroide)
        Me.Controls.Add(Me.gbAccommodements)
        Me.Controls.Add(Me.gbViennnoiseries)
        Me.Controls.Add(Me.gbBoissonChaude)
        Me.Controls.Add(Me.pnlService)
        Me.Controls.Add(Me.lblNbDej)
        Me.Controls.Add(Me.cbNbPtitDej)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "formCmde"
        Me.Text = "Commande de Petit Déjeuner"
        Me.pnlService.ResumeLayout(False)
        Me.pnlService.PerformLayout()
        Me.gbBoissonChaude.ResumeLayout(False)
        Me.gbBoissonChaude.PerformLayout()
        Me.gbViennnoiseries.ResumeLayout(False)
        Me.gbViennnoiseries.PerformLayout()
        Me.gbAccommodements.ResumeLayout(False)
        Me.gbAccommodements.PerformLayout()
        Me.gbBoissonFroide.ResumeLayout(False)
        Me.gbSupplements.ResumeLayout(False)
        Me.gbSupplements.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents cbNbPtitDej As System.Windows.Forms.ComboBox
    Friend WithEvents lblNbDej As System.Windows.Forms.Label
    Friend WithEvents pnlService As System.Windows.Forms.Panel
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents rdbChambre As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSalle As System.Windows.Forms.RadioButton
    Friend WithEvents gbBoissonChaude As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbViennnoiseries As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents gbAccommodements As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents gbBoissonFroide As System.Windows.Forms.GroupBox
    Friend WithEvents cbBoissonFroide As System.Windows.Forms.ComboBox
    Friend WithEvents gbSupplements As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
End Class
