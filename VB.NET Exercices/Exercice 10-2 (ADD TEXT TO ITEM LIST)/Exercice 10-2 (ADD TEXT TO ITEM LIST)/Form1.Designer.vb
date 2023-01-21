<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bttr = New System.Windows.Forms.Button
        Me.bte = New System.Windows.Forms.Button
        Me.bts = New System.Windows.Forms.Button
        Me.btf = New System.Windows.Forms.Button
        Me.btt = New System.Windows.Forms.Button
        Me.Listc = New System.Windows.Forms.ListBox
        Me.Listmat = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'bttr
        '
        Me.bttr.Location = New System.Drawing.Point(602, 297)
        Me.bttr.Name = "bttr"
        Me.bttr.Size = New System.Drawing.Size(67, 34)
        Me.bttr.TabIndex = 8
        Me.bttr.Text = "Trier"
        Me.bttr.UseVisualStyleBackColor = True
        '
        'bte
        '
        Me.bte.Location = New System.Drawing.Point(529, 297)
        Me.bte.Name = "bte"
        Me.bte.Size = New System.Drawing.Size(67, 34)
        Me.bte.TabIndex = 10
        Me.bte.Text = "Effacer"
        Me.bte.UseVisualStyleBackColor = True
        '
        'bts
        '
        Me.bts.Location = New System.Drawing.Point(456, 297)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(67, 34)
        Me.bts.TabIndex = 9
        Me.bts.Text = "Supprimer"
        Me.bts.UseVisualStyleBackColor = True
        '
        'btf
        '
        Me.btf.Location = New System.Drawing.Point(200, 255)
        Me.btf.Name = "btf"
        Me.btf.Size = New System.Drawing.Size(114, 34)
        Me.btf.TabIndex = 12
        Me.btf.Text = "Fermer"
        Me.btf.UseVisualStyleBackColor = True
        '
        'btt
        '
        Me.btt.Location = New System.Drawing.Point(60, 255)
        Me.btt.Name = "btt"
        Me.btt.Size = New System.Drawing.Size(114, 34)
        Me.btt.TabIndex = 11
        Me.btt.Text = "Transferer"
        Me.btt.UseVisualStyleBackColor = True
        '
        'Listc
        '
        Me.Listc.FormattingEnabled = True
        Me.Listc.Location = New System.Drawing.Point(496, 107)
        Me.Listc.Name = "Listc"
        Me.Listc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Listc.Size = New System.Drawing.Size(185, 173)
        Me.Listc.TabIndex = 7
        '
        'Listmat
        '
        Me.Listmat.ColumnWidth = 180
        Me.Listmat.FormattingEnabled = True
        Me.Listmat.Items.AddRange(New Object() {"Les matières ", "Conception", "visual basic", "Language c++", "Logiciel d'application", "Recherche d'emploi", "Assistance technique", "Les jours", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi"})
        Me.Listmat.Location = New System.Drawing.Point(45, 137)
        Me.Listmat.MultiColumn = True
        Me.Listmat.Name = "Listmat"
        Me.Listmat.Size = New System.Drawing.Size(370, 95)
        Me.Listmat.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Liste des matières"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Liste  multiple"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 395)
        Me.Controls.Add(Me.bttr)
        Me.Controls.Add(Me.bte)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.btf)
        Me.Controls.Add(Me.btt)
        Me.Controls.Add(Me.Listc)
        Me.Controls.Add(Me.Listmat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttr As System.Windows.Forms.Button
    Friend WithEvents bte As System.Windows.Forms.Button
    Friend WithEvents bts As System.Windows.Forms.Button
    Friend WithEvents btf As System.Windows.Forms.Button
    Friend WithEvents btt As System.Windows.Forms.Button
    Friend WithEvents Listc As System.Windows.Forms.ListBox
    Friend WithEvents Listmat As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
