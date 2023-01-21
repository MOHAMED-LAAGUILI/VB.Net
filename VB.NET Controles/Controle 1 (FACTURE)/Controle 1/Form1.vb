Public Class Form1
    Private Function Montant(ByVal nc As Single, ByVal pc As Single) As Single
        Dim mt As Single = 0
        mt = (nc * pc) * 1.2
        Return mt
    End Function
    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        If txt5.Text <> "" And txt6.Text <> "" Then
            If IsNumeric(txt5.Text) And IsNumeric(txt6.Text) Then
                txt7.Text = Montant(txt5.Text, txt6.Text)
            Else
                MessageBox.Show("Vous n'avez pas saisi un numéro que vous avez écrit le mauvais format. Veuillez réessayer", "Invalide Saisie", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Else
            MessageBox.Show("Vous n'avez rien écrit d'écrire uniquement des nombres et de réessayer", "Boîtes vides", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnn.Click
        txt1.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        txt7.Clear()
        txt1.Focus()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt2.Text = Date.Today
    End Sub
    Private Sub btnf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf.Click
        End
    End Sub
End Class
