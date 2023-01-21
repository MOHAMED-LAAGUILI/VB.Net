Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2 As Single
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        TextBox3.Text = n1 + n2
    End Sub
End Class
