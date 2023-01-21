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
        Me.bta = New System.Windows.Forms.Button
        Me.btf = New System.Windows.Forms.Button
        Me.bte = New System.Windows.Forms.Button
        Me.bti = New System.Windows.Forms.Button
        Me.List1 = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnom = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'bta
        '
        Me.bta.Location = New System.Drawing.Point(7, 181)
        Me.bta.Name = "bta"
        Me.bta.Size = New System.Drawing.Size(106, 30)
        Me.bta.TabIndex = 8
        Me.bta.Text = "Ajouter"
        Me.bta.UseVisualStyleBackColor = True
        '
        'btf
        '
        Me.btf.Location = New System.Drawing.Point(444, 317)
        Me.btf.Name = "btf"
        Me.btf.Size = New System.Drawing.Size(106, 30)
        Me.btf.TabIndex = 9
        Me.btf.Text = "Fermer"
        Me.btf.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btf.UseVisualStyleBackColor = True
        '
        'bte
        '
        Me.bte.Location = New System.Drawing.Point(328, 317)
        Me.bte.Name = "bte"
        Me.bte.Size = New System.Drawing.Size(106, 30)
        Me.bte.TabIndex = 10
        Me.bte.Text = "Effacer"
        Me.bte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bte.UseVisualStyleBackColor = True
        '
        'bti
        '
        Me.bti.Location = New System.Drawing.Point(161, 181)
        Me.bti.Name = "bti"
        Me.bti.Size = New System.Drawing.Size(106, 30)
        Me.bti.TabIndex = 11
        Me.bti.Text = "Initialiser"
        Me.bti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bti.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(328, 86)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(231, 212)
        Me.List1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Entrer votre nom ici  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Zone de liste simple"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(117, 138)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(191, 20)
        Me.txtnom.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 370)
        Me.Controls.Add(Me.bta)
        Me.Controls.Add(Me.btf)
        Me.Controls.Add(Me.bte)
        Me.Controls.Add(Me.bti)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bta As System.Windows.Forms.Button
    Friend WithEvents btf As System.Windows.Forms.Button
    Friend WithEvents bte As System.Windows.Forms.Button
    Friend WithEvents bti As System.Windows.Forms.Button
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnom As System.Windows.Forms.TextBox

End Class
