Public Class style_police
    Sub traiter_police()
        If checkgras.Checked = True And checkitalic.Checked = True Then
            txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold Or FontStyle.Italic)
        ElseIf checkgras.Checked = True And checkitalic.Checked = False Then
            txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold)
        ElseIf checkgras.Checked = False And checkitalic.Checked = False Then
            txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular)
        ElseIf checkgras.Checked = False And checkitalic.Checked = True Then
            txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, FontStyle.Italic)

        End If
    End Sub

    Private Sub checkgras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkgras.CheckedChanged
        traiter_police()
    End Sub

    Private Sub checkitalic_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkitalic.CheckedChanged
        traiter_police()
    End Sub
End Class
