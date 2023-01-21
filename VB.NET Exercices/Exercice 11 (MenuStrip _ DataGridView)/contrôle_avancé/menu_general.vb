Public Class menu_general
    Sub afficherFenetre(ByVal f As Form)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mniDéfiler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mniDéfiler.Click
        afficherFenetre(testimage)
    End Sub

    Private Sub mniStyle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mniStyle.Click
        afficherFenetre(style_police)
    End Sub

    Private Sub mniQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniQuitter.Click
        End
    End Sub

    Private Sub mniListeSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniListeSimple.Click
        afficherFenetre(Liste_simple)
    End Sub

    Private Sub mniListeMulticolonne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniListeMulticolonne.Click
        afficherFenetre(Liste_Multiple)
    End Sub

    Private Sub mniGestionDesÉtudiants_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniGestionDesÉtudiants.Click
        afficherFenetre(Etudiant)
    End Sub
End Class