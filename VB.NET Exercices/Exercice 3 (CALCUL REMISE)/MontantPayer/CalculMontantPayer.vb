Public Class CalculMontantPayer
    Private Function MontantRemise(ByVal tf As Single) As Single
        If tf < 1000 Then
            Return 0
        ElseIf tf < 5000 Then
            Return tf * 0.05
        Else
            Return tf * 0.07
        End If
    End Function

    Private Function MontantaPayer(ByVal tf As Single, ByVal mr As Single) As Single
        Return tf - mr
    End Function

    Private Sub btnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnn.Click
        txtnf.Text = ""
        txtdf.Text = ""
        txttf.Text = ""
        txtmr.Text = ""
        txtmp.Text = ""
        txtnf.Focus()
    End Sub

    Private Sub btnm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnm.Click
        If txttf.Text <> "" Then
            If IsNumeric(txttf.Text) Then
                txtmr.Text = MontantRemise(txttf.Text)
                txtmp.Text = MontantaPayer(txttf.Text, txtmr.Text)
            Else
                MessageBox.Show("Entrer un nombre dans la zone de text total", "Erreur de saisie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txttf.Text = ""
                txttf.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub CalculMontantPayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdf.Text = Date.Today
    End Sub

    Private Sub txttf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttf.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txttf.Text <> "" Then
                If IsNumeric(txttf.Text) Then
                    txtmr.Text = MontantRemise(txttf.Text)
                    txtmp.Text = MontantaPayer(txttf.Text, txtmr.Text)
                Else
                    MessageBox.Show("Entrer un nombre dans la zone de text total", "Erreur de saisie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    txttf.Text = ""
                    txttf.Focus()
                End If
            End If
        End If
    End Sub
End Class