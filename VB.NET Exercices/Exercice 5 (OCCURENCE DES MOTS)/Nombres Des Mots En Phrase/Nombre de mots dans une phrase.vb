Public Class Form1
    Function calculer_nombre_mot(ByVal ph As String) As Integer
        Dim nbrm As Integer = 0
        ph = Trim(ph)
        If ph <> "" Then
            nbrm = 1
            For i As Short = 2 To Len(ph)
                If Mid(ph, i, 1) = " " And Mid(ph, i - 1, 1) <> " " Then
                    nbrm = nbrm + 1
                End If
            Next
        End If
        Return nbrm
    End Function

    Private Sub btnnm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnm.Click
        txtbox1.Text = calculer_nombre_mot(txtarea.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtarea.Text = ""
        txtbox1.Text = ""
        txtarea.Focus()
    End Sub

    Private Sub btnf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf.Click
        End
    End Sub
End Class
