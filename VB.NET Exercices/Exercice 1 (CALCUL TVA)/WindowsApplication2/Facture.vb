Public Class Facture
    Function calculer_ttc(ByVal ht As Single) As Single
        Dim tcc As Single = 0
        tcc = ht + ht * 0.2
        Return tcc
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Sub nouveau()
        cmbnf.Text = ""
        txtdf.Clear()
        txtht.Clear()
        txtttc.Clear()
        cmbnf.Focus()
    End Sub

    Private Sub btc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btc.Click
        If txtht.Text <> "" Then
            If IsNumeric(txtht.Text) Then
                txtttc.Text = calculer_ttc(txtht.Text)


            Else
                MessageBox.Show("il faut entrer un nombre dans la zone de text hors taxes", "erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txtht.Text = ""
                txtht.Focus()
            End If
        Else
            MessageBox.Show("il faut remplir la zonne de text hors taxes", "erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtht.Text = ""
            txtht.Focus()
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn.Click
        nouveau()
    End Sub

    Private Sub btf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btf.Click
        End
    End Sub

    Private Sub Facture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdf.Text = Date.Today
    End Sub
End Class


