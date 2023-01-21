<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facture
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbnf = New System.Windows.Forms.ComboBox
        Me.btn = New System.Windows.Forms.Button
        Me.btf = New System.Windows.Forms.Button
        Me.btc = New System.Windows.Forms.Button
        Me.txtdf = New System.Windows.Forms.TextBox
        Me.txtht = New System.Windows.Forms.TextBox
        Me.txtttc = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(356, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facture"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Numéro de la facture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "date de la facture"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total hors taxes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total toutes taxes comprises"
        '
        'cmbnf
        '
        Me.cmbnf.FormattingEnabled = True
        Me.cmbnf.Location = New System.Drawing.Point(354, 93)
        Me.cmbnf.Name = "cmbnf"
        Me.cmbnf.Size = New System.Drawing.Size(159, 21)
        Me.cmbnf.TabIndex = 1
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(84, 363)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(158, 42)
        Me.btn.TabIndex = 2
        Me.btn.Text = "Nouveau"
        Me.btn.UseVisualStyleBackColor = True
        '
        'btf
        '
        Me.btf.Location = New System.Drawing.Point(544, 363)
        Me.btf.Name = "btf"
        Me.btf.Size = New System.Drawing.Size(158, 42)
        Me.btf.TabIndex = 2
        Me.btf.Text = "Fermer"
        Me.btf.UseVisualStyleBackColor = True
        '
        'btc
        '
        Me.btc.Location = New System.Drawing.Point(316, 363)
        Me.btc.Name = "btc"
        Me.btc.Size = New System.Drawing.Size(158, 42)
        Me.btc.TabIndex = 2
        Me.btc.Text = "Calculer"
        Me.btc.UseVisualStyleBackColor = True
        '
        'txtdf
        '
        Me.txtdf.Location = New System.Drawing.Point(354, 148)
        Me.txtdf.Name = "txtdf"
        Me.txtdf.Size = New System.Drawing.Size(159, 20)
        Me.txtdf.TabIndex = 3
        '
        'txtht
        '
        Me.txtht.Location = New System.Drawing.Point(354, 202)
        Me.txtht.Name = "txtht"
        Me.txtht.Size = New System.Drawing.Size(159, 20)
        Me.txtht.TabIndex = 3
        '
        'txtttc
        '
        Me.txtttc.Location = New System.Drawing.Point(354, 255)
        Me.txtttc.Name = "txtttc"
        Me.txtttc.Size = New System.Drawing.Size(159, 20)
        Me.txtttc.TabIndex = 3
        '
        'Facture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(871, 441)
        Me.Controls.Add(Me.txtttc)
        Me.Controls.Add(Me.txtht)
        Me.Controls.Add(Me.txtdf)
        Me.Controls.Add(Me.btc)
        Me.Controls.Add(Me.btf)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.cmbnf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Facture"
        Me.Text = "Traitement des factures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbnf As System.Windows.Forms.ComboBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btf As System.Windows.Forms.Button
    Friend WithEvents btc As System.Windows.Forms.Button
    Friend WithEvents txtdf As System.Windows.Forms.TextBox
    Friend WithEvents txtht As System.Windows.Forms.TextBox
    Friend WithEvents txtttc As System.Windows.Forms.TextBox

End Class
