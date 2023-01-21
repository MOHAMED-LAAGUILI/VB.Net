<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionDesBillets
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
        Me.btnf = New System.Windows.Forms.Button
        Me.txtnb = New System.Windows.Forms.TextBox
        Me.txtdb = New System.Windows.Forms.TextBox
        Me.txtt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtd = New System.Windows.Forms.ComboBox
        Me.btnn = New System.Windows.Forms.Button
        Me.txttdb = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(382, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Office National des Aéroport"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Numéro Billet :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date Billet :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Destination :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 0
        '
        'btnf
        '
        Me.btnf.Location = New System.Drawing.Point(489, 399)
        Me.btnf.Name = "btnf"
        Me.btnf.Size = New System.Drawing.Size(224, 38)
        Me.btnf.TabIndex = 5
        Me.btnf.Text = "Fermer"
        Me.btnf.UseVisualStyleBackColor = True
        '
        'txtnb
        '
        Me.txtnb.Location = New System.Drawing.Point(386, 98)
        Me.txtnb.Name = "txtnb"
        Me.txtnb.Size = New System.Drawing.Size(226, 20)
        Me.txtnb.TabIndex = 0
        '
        'txtdb
        '
        Me.txtdb.Location = New System.Drawing.Point(386, 140)
        Me.txtdb.Name = "txtdb"
        Me.txtdb.Size = New System.Drawing.Size(226, 20)
        Me.txtdb.TabIndex = 1
        '
        'txtt
        '
        Me.txtt.Location = New System.Drawing.Point(386, 339)
        Me.txtt.Name = "txtt"
        Me.txtt.Size = New System.Drawing.Size(226, 20)
        Me.txtt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(246, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(342, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "* Aéoport Mohamed V Casablanca"
        '
        'txtd
        '
        Me.txtd.FormattingEnabled = True
        Me.txtd.ItemHeight = 13
        Me.txtd.Items.AddRange(New Object() {"Paris", "Londres", "Madrid", "Bruxelles"})
        Me.txtd.Location = New System.Drawing.Point(386, 273)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(226, 21)
        Me.txtd.TabIndex = 2
        '
        'btnn
        '
        Me.btnn.Location = New System.Drawing.Point(198, 399)
        Me.btnn.Name = "btnn"
        Me.btnn.Size = New System.Drawing.Size(233, 38)
        Me.btnn.TabIndex = 4
        Me.btnn.Text = "Nouveau"
        Me.btnn.UseVisualStyleBackColor = True
        '
        'txttdb
        '
        Me.txttdb.AutoSize = True
        Me.txttdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttdb.Location = New System.Drawing.Point(254, 342)
        Me.txttdb.Name = "txttdb"
        Me.txttdb.Size = New System.Drawing.Size(108, 16)
        Me.txttdb.TabIndex = 0
        Me.txttdb.Text = "Tarif du Billet :"
        '
        'GestionDesBillets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(961, 596)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.txtt)
        Me.Controls.Add(Me.txtdb)
        Me.Controls.Add(Me.txtnb)
        Me.Controls.Add(Me.btnn)
        Me.Controls.Add(Me.btnf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttdb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "GestionDesBillets"
        Me.Text = "Gestion des Billets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnf As System.Windows.Forms.Button
    Friend WithEvents txtnb As System.Windows.Forms.TextBox
    Friend WithEvents txtdb As System.Windows.Forms.TextBox
    Friend WithEvents txtt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtd As System.Windows.Forms.ComboBox
    Friend WithEvents btnn As System.Windows.Forms.Button
    Friend WithEvents txttdb As System.Windows.Forms.Label

End Class
