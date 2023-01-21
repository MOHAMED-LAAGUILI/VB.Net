Public Class Calculatrice
    Private cnt As Single
    Private mem As Single
    Private op As Char
    Sub traiterCalculatrice(ByVal bt As Button)
        Select Case bt.Text
            Case "0" To "9", "." : txtecran.Text = txtecran.Text & bt.Text
            Case "M" : If txtecran.Text <> "" Then
                    mem = CType(txtecran.Text, Single)
                End If
            Case "R" : txtecran.Text = mem
            Case "C" : txtecran.Clear()
            Case "=" : If txtecran.Text <> "" Then
                    Select Case op
                        Case "+" : txtecran.Text = cnt + CType(txtecran.Text, Single)
                        Case "-" : txtecran.Text = cnt - CType(txtecran.Text, Single)
                        Case "*" : txtecran.Text = cnt * CType(txtecran.Text, Single)
                        Case "/" : If CType(txtecran.Text, Single) <> 0 Then
                                txtecran.Text = cnt / CType(txtecran.Text, Single)
                            End If
                    End Select
                End If
            Case Else : If txtecran.Text <> "" Then
                    cnt = CType(txtecran.Text, Single)
                End If
                op = bt.Text
                txtecran.Clear()

        End Select
    End Sub

    Private Sub bt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt0.Click, bt1.Click, bt2.Click, bt3.Click, bt4.Click, bt5.Click, bt6.Click, bt7.Click, bt8.Click, bt9.Click, bts.Click, btr.Click, btpt.Click, btm.Click, btf.Click, btp.Click, btd.Click, bte.Click, btc.Click
        traiterCalculatrice(CType(sender, Button))
    End Sub
End Class
