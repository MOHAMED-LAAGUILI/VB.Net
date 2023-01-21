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
        Me.box1 = New System.Windows.Forms.CheckBox
        Me.box2 = New System.Windows.Forms.CheckBox
        Me.box3 = New System.Windows.Forms.CheckBox
        Me.box4 = New System.Windows.Forms.CheckBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'box1
        '
        Me.box1.AutoSize = True
        Me.box1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box1.Location = New System.Drawing.Point(25, 77)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(71, 28)
        Me.box1.TabIndex = 0
        Me.box1.Text = "Bold"
        Me.box1.UseVisualStyleBackColor = True
        '
        'box2
        '
        Me.box2.AutoSize = True
        Me.box2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box2.Location = New System.Drawing.Point(23, 111)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(71, 28)
        Me.box2.TabIndex = 0
        Me.box2.Text = "Italic"
        Me.box2.UseVisualStyleBackColor = True
        '
        'box3
        '
        Me.box3.AutoSize = True
        Me.box3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box3.Location = New System.Drawing.Point(25, 179)
        Me.box3.Name = "box3"
        Me.box3.Size = New System.Drawing.Size(126, 28)
        Me.box3.TabIndex = 0
        Me.box3.Text = "UnderLine"
        Me.box3.UseVisualStyleBackColor = True
        '
        'box4
        '
        Me.box4.AutoSize = True
        Me.box4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box4.Location = New System.Drawing.Point(25, 145)
        Me.box4.Name = "box4"
        Me.box4.Size = New System.Drawing.Size(81, 28)
        Me.box4.TabIndex = 0
        Me.box4.Text = "Strike"
        Me.box4.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(25, 33)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(260, 29)
        Me.txt1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.box1)
        Me.GroupBox1.Controls.Add(Me.box4)
        Me.GroupBox1.Controls.Add(Me.box2)
        Me.GroupBox1.Controls.Add(Me.box3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 220)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Style de police"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 341)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents box1 As System.Windows.Forms.CheckBox
    Friend WithEvents box2 As System.Windows.Forms.CheckBox
    Friend WithEvents box3 As System.Windows.Forms.CheckBox
    Friend WithEvents box4 As System.Windows.Forms.CheckBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
