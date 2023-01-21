Public Class Form1
    Sub transferer()
        For i As Short = 0 To Listmat.Items.Count - 1
            If Listmat.GetSelected(i) = True Then
                Listc.Items.Add(Listmat.Items.Item(i))
            End If
        Next
    End Sub
    Sub supprimer()
        Dim i As Short = 0
        Do While i < Listc.Items.Count
            If Listc.GetSelected(i) = True Then
                Listc.Items.RemoveAt(i)
                i = i - 1

            Else
                MessageBox.Show("Selectiner un element pour supprimer", "INVALID", MessageBoxButtons.OK)
            End If
            i = i + 1
        Loop
    End Sub
    Private Sub btt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt.Click
        transferer()
    End Sub

    Private Sub bts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bts.Click
        supprimer()
    End Sub

    Private Sub btf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btf.Click
        End
    End Sub
End Class
