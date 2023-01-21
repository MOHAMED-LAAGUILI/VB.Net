Public Class Etudiant
    Sub nouveau()
        txtnum.Clear()
        txtnom.Clear()
        txtprn.Clear()
        txtdn.Clear()
        txtnum.Focus()
    End Sub
    Sub ajouter()
        If txtnum.Text <> "" And txtnom.Text <> "" And txtprn.Text <> "" And txtdn.Text <> "" Then
            dgvet.Rows.Add(txtnum.Text, txtnom.Text, txtprn.Text, txtdn.Text)
        Else
            MessageBox.Show("AAAAAAAAAAAAAAAAAE", "bbbbbbb", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        nouveau()
    End Sub

    Private Sub bta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bta.Click
        ajouter()
    End Sub
End Class