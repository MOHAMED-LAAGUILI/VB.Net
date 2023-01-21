<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculMontantPayer
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
        Me.txtnf = New System.Windows.Forms.TextBox
        Me.txtdf = New System.Windows.Forms.TextBox
        Me.txttf = New System.Windows.Forms.TextBox
        Me.txtmr = New System.Windows.Forms.TextBox
        Me.txtmp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnm = New System.Windows.Forms.Button
        Me.btnn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtnf
        '
        Me.txtnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnf.Location = New System.Drawing.Point(235, 91)
        Me.txtnf.Name = "txtnf"
        Me.txtnf.Size = New System.Drawing.Size(244, 21)
        Me.txtnf.TabIndex = 1
        '
        'txtdf
        '
        Me.txtdf.Location = New System.Drawing.Point(235, 126)
        Me.txtdf.Name = "txtdf"
        Me.txtdf.Size = New System.Drawing.Size(244, 20)
        Me.txtdf.TabIndex = 2
        '
        'txttf
        '
        Me.txttf.Location = New System.Drawing.Point(235, 165)
        Me.txttf.Name = "txttf"
        Me.txttf.Size = New System.Drawing.Size(244, 20)
        Me.txttf.TabIndex = 3
        '
        'txtmr
        '
        Me.txtmr.Location = New System.Drawing.Point(235, 203)
        Me.txtmr.Name = "txtmr"
        Me.txtmr.Size = New System.Drawing.Size(244, 20)
        Me.txtmr.TabIndex = 4
        '
        'txtmp
        '
        Me.txtmp.Location = New System.Drawing.Point(235, 241)
        Me.txtmp.Name = "txtmp"
        Me.txtmp.Size = New System.Drawing.Size(244, 20)
        Me.txtmp.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facture"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro de la facture :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date de la facture :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total de la facture :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Montant de la remise :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Montant à payer :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(411, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnm
        '
        Me.btnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnm.Location = New System.Drawing.Point(99, 334)
        Me.btnm.Name = "btnm"
        Me.btnm.Size = New System.Drawing.Size(139, 30)
        Me.btnm.TabIndex = 6
        Me.btnm.Text = "Calculer Montant"
        Me.btnm.UseVisualStyleBackColor = True
        '
        'btnn
        '
        Me.btnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnn.Location = New System.Drawing.Point(283, 334)
        Me.btnn.Name = "btnn"
        Me.btnn.Size = New System.Drawing.Size(91, 30)
        Me.btnn.TabIndex = 9
        Me.btnn.Text = "Nouveau"
        Me.btnn.UseVisualStyleBackColor = True
        '
        'CalculMontantPayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 390)
        Me.Controls.Add(Me.btnn)
        Me.Controls.Add(Me.btnm)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdf)
        Me.Controls.Add(Me.txtmp)
        Me.Controls.Add(Me.txtmr)
        Me.Controls.Add(Me.txttf)
        Me.Controls.Add(Me.txtnf)
        Me.Name = "CalculMontantPayer"
        Me.Text = "Calcul du montant à payer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnf As System.Windows.Forms.TextBox
    Friend WithEvents txtdf As System.Windows.Forms.TextBox
    Friend WithEvents txttf As System.Windows.Forms.TextBox
    Friend WithEvents txtmr As System.Windows.Forms.TextBox
    Friend WithEvents txtmp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnm As System.Windows.Forms.Button
    Friend WithEvents btnn As System.Windows.Forms.Button

End Class
