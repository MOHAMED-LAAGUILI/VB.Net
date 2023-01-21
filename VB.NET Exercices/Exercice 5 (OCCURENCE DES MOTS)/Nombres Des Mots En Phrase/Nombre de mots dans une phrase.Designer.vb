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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbox1 = New System.Windows.Forms.TextBox
        Me.btnnm = New System.Windows.Forms.Button
        Me.btnf = New System.Windows.Forms.Button
        Me.txtarea = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrer Votre Phrase ici :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre de mots :"
        '
        'txtbox1
        '
        Me.txtbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox1.Location = New System.Drawing.Point(152, 166)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(225, 26)
        Me.txtbox1.TabIndex = 0
        '
        'btnnm
        '
        Me.btnnm.Location = New System.Drawing.Point(83, 247)
        Me.btnnm.Name = "btnnm"
        Me.btnnm.Size = New System.Drawing.Size(113, 26)
        Me.btnnm.TabIndex = 2
        Me.btnnm.Text = "Nombre de mots"
        Me.btnnm.UseVisualStyleBackColor = True
        '
        'btnf
        '
        Me.btnf.Location = New System.Drawing.Point(298, 245)
        Me.btnf.Name = "btnf"
        Me.btnf.Size = New System.Drawing.Size(79, 31)
        Me.btnf.TabIndex = 4
        Me.btnf.Text = "Fermer"
        Me.btnf.UseVisualStyleBackColor = True
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(68, 55)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(366, 39)
        Me.txtarea.TabIndex = 1
        Me.txtarea.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nouveau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 290)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtarea)
        Me.Controls.Add(Me.btnf)
        Me.Controls.Add(Me.btnnm)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Nombre de mots dans une phrase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnnm As System.Windows.Forms.Button
    Friend WithEvents btnf As System.Windows.Forms.Button
    Friend WithEvents txtarea As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
