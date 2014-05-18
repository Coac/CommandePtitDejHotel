<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNumCh
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
        Me.lblIndication = New System.Windows.Forms.Label()
        Me.txtboxNumCh = New System.Windows.Forms.TextBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIndication
        '
        Me.lblIndication.AutoSize = True
        Me.lblIndication.Location = New System.Drawing.Point(62, 94)
        Me.lblIndication.Name = "lblIndication"
        Me.lblIndication.Size = New System.Drawing.Size(161, 13)
        Me.lblIndication.TabIndex = 0
        Me.lblIndication.Text = "Entrez votre numéro de chambre"
        '
        'txtboxNumCh
        '
        Me.txtboxNumCh.Location = New System.Drawing.Point(82, 120)
        Me.txtboxNumCh.MaxLength = 3
        Me.txtboxNumCh.Name = "txtboxNumCh"
        Me.txtboxNumCh.Size = New System.Drawing.Size(100, 20)
        Me.txtboxNumCh.TabIndex = 1
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(251, 105)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(98, 35)
        Me.btnValider.TabIndex = 2
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(83, 37)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Menu Principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'formNumCh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 199)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.txtboxNumCh)
        Me.Controls.Add(Me.lblIndication)
        Me.Name = "formNumCh"
        Me.Text = "Numéro de Chambre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIndication As System.Windows.Forms.Label
    Friend WithEvents txtboxNumCh As System.Windows.Forms.TextBox
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class
