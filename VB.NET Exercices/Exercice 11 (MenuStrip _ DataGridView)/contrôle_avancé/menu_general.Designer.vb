<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_general
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnFichier = New System.Windows.Forms.ToolStripMenuItem
        Me.mniDéfiler = New System.Windows.Forms.ToolStripMenuItem
        Me.mniStyle = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mniQuitter = New System.Windows.Forms.ToolStripMenuItem
        Me.mnLesListes = New System.Windows.Forms.ToolStripMenuItem
        Me.mniListeSimple = New System.Windows.Forms.ToolStripMenuItem
        Me.mniListeMulticolonne = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mniGestionDesÉtudiants = New System.Windows.Forms.ToolStripMenuItem
        Me.mnEdition = New System.Windows.Forms.ToolStripMenuItem
        Me.mniCopier = New System.Windows.Forms.ToolStripMenuItem
        Me.mniCouper = New System.Windows.Forms.ToolStripMenuItem
        Me.mniColler = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.SsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFichier, Me.mnLesListes, Me.mnEdition})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 48)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(627, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnFichier
        '
        Me.mnFichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDéfiler, Me.mniStyle, Me.ToolStripMenuItem1, Me.mniQuitter, Me.ToolStripSeparator2})
        Me.mnFichier.Name = "mnFichier"
        Me.mnFichier.Size = New System.Drawing.Size(54, 20)
        Me.mnFichier.Text = "Fichier"
        '
        'mniDéfiler
        '
        Me.mniDéfiler.Checked = True
        Me.mniDéfiler.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mniDéfiler.Image = Global.contrôle_avancé.My.Resources.Resources.AAA
        Me.mniDéfiler.Name = "mniDéfiler"
        Me.mniDéfiler.Size = New System.Drawing.Size(152, 22)
        Me.mniDéfiler.Text = "Défiler image"
        '
        'mniStyle
        '
        Me.mniStyle.Name = "mniStyle"
        Me.mniStyle.Size = New System.Drawing.Size(152, 22)
        Me.mniStyle.Text = "Style de police"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mniQuitter
        '
        Me.mniQuitter.Name = "mniQuitter"
        Me.mniQuitter.Size = New System.Drawing.Size(152, 22)
        Me.mniQuitter.Text = "Quitter"
        '
        'mnLesListes
        '
        Me.mnLesListes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniListeSimple, Me.mniListeMulticolonne, Me.ToolStripSeparator1, Me.mniGestionDesÉtudiants})
        Me.mnLesListes.Name = "mnLesListes"
        Me.mnLesListes.Size = New System.Drawing.Size(65, 20)
        Me.mnLesListes.Text = "Les listes"
        '
        'mniListeSimple
        '
        Me.mniListeSimple.Name = "mniListeSimple"
        Me.mniListeSimple.Size = New System.Drawing.Size(187, 22)
        Me.mniListeSimple.Text = "Liste simple"
        '
        'mniListeMulticolonne
        '
        Me.mniListeMulticolonne.Name = "mniListeMulticolonne"
        Me.mniListeMulticolonne.Size = New System.Drawing.Size(187, 22)
        Me.mniListeMulticolonne.Text = "Liste multi-colonne"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'mniGestionDesÉtudiants
        '
        Me.mniGestionDesÉtudiants.Name = "mniGestionDesÉtudiants"
        Me.mniGestionDesÉtudiants.Size = New System.Drawing.Size(187, 22)
        Me.mniGestionDesÉtudiants.Text = "Gestion des étudiants"
        '
        'mnEdition
        '
        Me.mnEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniCopier, Me.mniCouper, Me.mniColler})
        Me.mnEdition.Name = "mnEdition"
        Me.mnEdition.Size = New System.Drawing.Size(56, 20)
        Me.mnEdition.Text = "Edition"
        '
        'mniCopier
        '
        Me.mniCopier.Name = "mniCopier"
        Me.mniCopier.Size = New System.Drawing.Size(152, 22)
        Me.mniCopier.Text = "Copier"
        '
        'mniCouper
        '
        Me.mniCouper.Name = "mniCouper"
        Me.mniCouper.Size = New System.Drawing.Size(152, 22)
        Me.mniCouper.Text = "Couper"
        '
        'mniColler
        '
        Me.mniColler.Name = "mniColler"
        Me.mniColler.Size = New System.Drawing.Size(152, 22)
        Me.mniColler.Text = "Coller"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SsToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(627, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SsToolStripMenuItem
        '
        Me.SsToolStripMenuItem.Name = "SsToolStripMenuItem"
        Me.SsToolStripMenuItem.Size = New System.Drawing.Size(29, 20)
        Me.SsToolStripMenuItem.Text = "ss"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(627, 24)
        Me.MenuStrip3.TabIndex = 3
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'menu_general
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 482)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip3)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu_general"
        Me.Text = "Menu général"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnFichier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDéfiler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniStyle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniQuitter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLesListes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniListeSimple As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniListeMulticolonne As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniGestionDesÉtudiants As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnEdition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCopier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCouper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniColler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents SsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
End Class
