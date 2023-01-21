Public Class GestionDesBillets
    Private Function tarif(ByVal txtd As String) As Single
        Dim trf As Single = 0
        If txtd.CompareTo("Paris") = 0 Then
            trf = 700.0
        ElseIf txtd.CompareTo("Londres") = 0 Then
            trf = 950.0
        ElseIf txtd.CompareTo("Madrid") = 0 Then
            trf = 600.0
        ElseIf txtd.CompareTo("Bruxelles") = 0 Then
            trf = 1200.0
        End If
        Return trf
    End Function
    Private Sub Nouveau()
        txtnb.Text = ""
        txtdb.Text = ""
        txtd.Text = ""
        txtt.Text = ""
        txtnb.Focus()
    End Sub

    Private Sub btnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnn.Click
        Nouveau()
    End Sub

    Private Sub btnf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf.Click
        End
    End Sub

    Private Sub txtd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtd.SelectedIndexChanged
        txtt.Text = tarif(txtd.Text)
    End Sub

    Private Sub GestionDesBillets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdb.Text = Date.Today
    End Sub
End Class
