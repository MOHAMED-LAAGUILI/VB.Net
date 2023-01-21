Public Class Liste_simple
    Sub ajouter()
        List.Items.Add(txtnom.Text)
    End Sub
    Sub initialiser()
        txtnom.Clear()
        txtnom.Focus()
    End Sub
    Sub effacer()
        List.Items.Clear()
    End Sub

    Private Sub bta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bta.Click
        ajouter()
    End Sub

    Private Sub bti_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bti.Click
        initialiser()
    End Sub

    Private Sub bte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bte.Click
        effacer()
    End Sub

    Private Sub btf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btf.Click
        Me.Close()
    End Sub
End Class