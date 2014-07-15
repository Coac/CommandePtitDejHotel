<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCommandeFin
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
        Me.ListBoxNum = New System.Windows.Forms.ListBox()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxPrenom = New System.Windows.Forms.ListBox()
        Me.ListBoxNbP = New System.Windows.Forms.ListBox()
        Me.ListBoxPrix = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxHidden = New System.Windows.Forms.ListBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxNum
        '
        Me.ListBoxNum.FormattingEnabled = True
        Me.ListBoxNum.Location = New System.Drawing.Point(99, 71)
        Me.ListBoxNum.Name = "ListBoxNum"
        Me.ListBoxNum.Size = New System.Drawing.Size(56, 134)
        Me.ListBoxNum.TabIndex = 0
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.Location = New System.Drawing.Point(204, 71)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(56, 134)
        Me.ListBoxNom.TabIndex = 1
        '
        'ListBoxPrenom
        '
        Me.ListBoxPrenom.FormattingEnabled = True
        Me.ListBoxPrenom.Location = New System.Drawing.Point(305, 71)
        Me.ListBoxPrenom.Name = "ListBoxPrenom"
        Me.ListBoxPrenom.Size = New System.Drawing.Size(56, 134)
        Me.ListBoxPrenom.TabIndex = 2
        '
        'ListBoxNbP
        '
        Me.ListBoxNbP.FormattingEnabled = True
        Me.ListBoxNbP.Location = New System.Drawing.Point(417, 71)
        Me.ListBoxNbP.Name = "ListBoxNbP"
        Me.ListBoxNbP.Size = New System.Drawing.Size(56, 134)
        Me.ListBoxNbP.TabIndex = 3
        '
        'ListBoxPrix
        '
        Me.ListBoxPrix.FormattingEnabled = True
        Me.ListBoxPrix.Location = New System.Drawing.Point(529, 71)
        Me.ListBoxPrix.Name = "ListBoxPrix"
        Me.ListBoxPrix.Size = New System.Drawing.Size(56, 134)
        Me.ListBoxPrix.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "n° de chambre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "prenom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(394, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "nombre de personnes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(535, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "prix"
        '
        'ListBoxHidden
        '
        Me.ListBoxHidden.FormattingEnabled = True
        Me.ListBoxHidden.Location = New System.Drawing.Point(728, 71)
        Me.ListBoxHidden.Name = "ListBoxHidden"
        Me.ListBoxHidden.Size = New System.Drawing.Size(56, 134)
        Me.ListBoxHidden.Sorted = True
        Me.ListBoxHidden.TabIndex = 10
        Me.ListBoxHidden.Visible = False
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(344, 226)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetour.TabIndex = 11
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'FormCommandeFin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 261)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ListBoxHidden)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxPrix)
        Me.Controls.Add(Me.ListBoxNbP)
        Me.Controls.Add(Me.ListBoxPrenom)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.ListBoxNum)
        Me.Name = "FormCommandeFin"
        Me.Text = "Chambres ayant passé une commande"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxNum As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxNom As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxPrenom As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxNbP As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxPrix As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBoxHidden As System.Windows.Forms.ListBox
    Friend WithEvents ButtonRetour As System.Windows.Forms.Button
End Class
