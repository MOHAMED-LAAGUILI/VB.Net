<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etudiant
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
        Me.txtnum = New System.Windows.Forms.TextBox
        Me.btn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnom = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdn = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtprn = New System.Windows.Forms.TextBox
        Me.bta = New System.Windows.Forms.Button
        Me.btf = New System.Windows.Forms.Button
        Me.dgvet = New System.Windows.Forms.DataGridView
        Me.Colnum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Colnom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Colprn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Coldn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.dgvet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion des étudiants"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro étudiant   :"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(140, 76)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(153, 20)
        Me.txtnum.TabIndex = 2
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(360, 73)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 3
        Me.btn.Text = "Nouveau"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nom étudiant        :"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(140, 107)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(153, 20)
        Me.txtnom.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date de naissance:"
        '
        'txtdn
        '
        Me.txtdn.Location = New System.Drawing.Point(140, 173)
        Me.txtdn.Name = "txtdn"
        Me.txtdn.Size = New System.Drawing.Size(153, 20)
        Me.txtdn.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Prénom étudiant   :"
        '
        'txtprn
        '
        Me.txtprn.Location = New System.Drawing.Point(140, 138)
        Me.txtprn.Name = "txtprn"
        Me.txtprn.Size = New System.Drawing.Size(153, 20)
        Me.txtprn.TabIndex = 2
        '
        'bta
        '
        Me.bta.Location = New System.Drawing.Point(360, 109)
        Me.bta.Name = "bta"
        Me.bta.Size = New System.Drawing.Size(75, 23)
        Me.bta.TabIndex = 3
        Me.bta.Text = "Ajouter"
        Me.bta.UseVisualStyleBackColor = True
        '
        'btf
        '
        Me.btf.Location = New System.Drawing.Point(360, 145)
        Me.btf.Name = "btf"
        Me.btf.Size = New System.Drawing.Size(75, 23)
        Me.btf.TabIndex = 3
        Me.btf.Text = "Fermer"
        Me.btf.UseVisualStyleBackColor = True
        '
        'dgvet
        '
        Me.dgvet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colnum, Me.Colnom, Me.Colprn, Me.Coldn})
        Me.dgvet.Location = New System.Drawing.Point(31, 227)
        Me.dgvet.Name = "dgvet"
        Me.dgvet.RowHeadersVisible = False
        Me.dgvet.Size = New System.Drawing.Size(453, 152)
        Me.dgvet.TabIndex = 4
        '
        'Colnum
        '
        Me.Colnum.HeaderText = "Numéro"
        Me.Colnum.Name = "Colnum"
        '
        'Colnom
        '
        Me.Colnom.HeaderText = "Nom étudiant"
        Me.Colnom.Name = "Colnom"
        '
        'Colprn
        '
        Me.Colprn.HeaderText = "Prénom"
        Me.Colprn.Name = "Colprn"
        '
        'Coldn
        '
        Me.Coldn.HeaderText = "Date de naissance"
        Me.Coldn.Name = "Coldn"
        Me.Coldn.Width = 150
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(478, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(151, 116)
        Me.DataGridView1.TabIndex = 5
        '
        'Etudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 417)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgvet)
        Me.Controls.Add(Me.btf)
        Me.Controls.Add(Me.bta)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txtprn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Etudiant"
        Me.Text = "Etudiant"
        CType(Me.dgvet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprn As System.Windows.Forms.TextBox
    Friend WithEvents bta As System.Windows.Forms.Button
    Friend WithEvents btf As System.Windows.Forms.Button
    Friend WithEvents dgvet As System.Windows.Forms.DataGridView
    Friend WithEvents Colnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colnom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colprn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coldn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
