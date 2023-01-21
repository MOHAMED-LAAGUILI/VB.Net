Public Class TestControle
    Function test(ByVal i As Short) As String
        Return CType(Listetudiants.Items.Item(i), String)
    End Function

    Private Sub btafficher_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btafficher.Click
        'Txt1.Text = test(4)
        'supprimer(4)
        If rdb0.Checked = False Then
            rdb0.Checked = True
        Else
            rdb0.Checked = False
        End If

    End Sub
    Sub supprimer(ByVal i As Short)
        Listetudiants.Items.RemoveAt(i)
    End Sub
End Class
