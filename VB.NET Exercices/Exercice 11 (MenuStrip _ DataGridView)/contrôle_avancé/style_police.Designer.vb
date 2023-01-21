<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class style_police
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt = New System.Windows.Forms.TextBox
        Me.checkgras = New System.Windows.Forms.CheckBox
        Me.checkitalic = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt)
        Me.GroupBox1.Controls.Add(Me.checkgras)
        Me.GroupBox1.Controls.Add(Me.checkitalic)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 210)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Style de police"
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(25, 33)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(371, 29)
        Me.txt.TabIndex = 1
        '
        'checkgras
        '
        Me.checkgras.AutoSize = True
        Me.checkgras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkgras.Location = New System.Drawing.Point(25, 77)
        Me.checkgras.Name = "checkgras"
        Me.checkgras.Size = New System.Drawing.Size(71, 28)
        Me.checkgras.TabIndex = 0
        Me.checkgras.Text = "Bold"
        Me.checkgras.UseVisualStyleBackColor = True
        '
        'checkitalic
        '
        Me.checkitalic.AutoSize = True
        Me.checkitalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkitalic.Location = New System.Drawing.Point(25, 121)
        Me.checkitalic.Name = "checkitalic"
        Me.checkitalic.Size = New System.Drawing.Size(71, 28)
        Me.checkitalic.TabIndex = 0
        Me.checkitalic.Text = "Italic"
        Me.checkitalic.UseVisualStyleBackColor = True
        '
        'style_police
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 374)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "style_police"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents checkgras As System.Windows.Forms.CheckBox
    Friend WithEvents checkitalic As System.Windows.Forms.CheckBox

End Class
