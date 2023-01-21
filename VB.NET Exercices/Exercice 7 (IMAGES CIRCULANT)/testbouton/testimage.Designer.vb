<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testimage
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
        Me.btd = New System.Windows.Forms.Button
        Me.P1 = New System.Windows.Forms.PictureBox
        Me.btf = New System.Windows.Forms.Button
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btd
        '
        Me.btd.Location = New System.Drawing.Point(28, 38)
        Me.btd.Name = "btd"
        Me.btd.Size = New System.Drawing.Size(79, 28)
        Me.btd.TabIndex = 0
        Me.btd.Text = "Defiler"
        Me.btd.UseVisualStyleBackColor = True
        '
        'P1
        '
        Me.P1.Location = New System.Drawing.Point(113, 29)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(607, 448)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1.TabIndex = 1
        Me.P1.TabStop = False
        '
        'btf
        '
        Me.btf.Location = New System.Drawing.Point(28, 72)
        Me.btf.Name = "btf"
        Me.btf.Size = New System.Drawing.Size(79, 28)
        Me.btf.TabIndex = 0
        Me.btf.Text = "Fermer"
        Me.btf.UseVisualStyleBackColor = True
        '
        'testimage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 489)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.btf)
        Me.Controls.Add(Me.btd)
        Me.Name = "testimage"
        Me.Text = " test de bouton"
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btd As System.Windows.Forms.Button
    Friend WithEvents P1 As System.Windows.Forms.PictureBox
    Friend WithEvents btf As System.Windows.Forms.Button

End Class
