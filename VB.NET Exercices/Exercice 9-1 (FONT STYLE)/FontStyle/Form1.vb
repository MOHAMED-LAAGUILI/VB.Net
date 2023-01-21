Public Class Form1
    Private Sub box1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box1.CheckedChanged
        If box1.Checked Then
            txt1.Font = New Font(txt1.Font, txt1.Font.Style Or FontStyle.Bold)
        Else
            txt1.Font = New Font(txt1.Font, txt1.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub box2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box2.CheckedChanged
        If box2.Checked Then
            txt1.Font = New Font(txt1.Font, txt1.Font.Style Or FontStyle.Italic)
        Else
            txt1.Font = New Font(txt1.Font, txt1.Font.Style And Not FontStyle.Italic)
        End If
    End Sub
    Private Sub box3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box3.CheckedChanged
        If box3.Checked Then
            txt1.Font = New Font(txt1.Font, txt1.Font.Style Or FontStyle.Strikeout)
        Else
            txt1.Font = New Font(txt1.Font, txt1.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub
    Private Sub box4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box4.CheckedChanged
        If box4.Checked Then
            txt1.Font = New Font(txt1.Font, txt1.Font.Style Or FontStyle.Underline)
        Else
            txt1.Font = New Font(txt1.Font, txt1.Font.Style And Not FontStyle.Underline)
        End If
    End Sub

    
End Class
