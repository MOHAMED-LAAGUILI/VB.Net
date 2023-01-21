Public Class testimage
    Private m As Short = 0
    Sub defiler()
        Select Case m
            Case 0 : P1.Image = Image.FromFile("c:\TS_DI_VB\img11.png")
            Case 1 : P1.Image = Image.FromFile("c:\TS_DI_VB\img12.bmp")
            Case 2 : P1.Image = Image.FromFile("c:\TS_DI_VB\img13.bmp")
            Case 3 : P1.Image = Image.FromFile("c:\TS_DI_VB\img14.bmp")
            Case 4 : P1.Image = Image.FromFile("c:\TS_DI_VB\img15.bmp")
            Case 5 : P1.Image = Image.FromFile("c:\TS_DI_VB\img16.jfif")
        End Select
        m = m + 1
        If m > 5 Then m = 0
    End Sub

    Private Sub btd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btd.Click
        defiler()
    End Sub
End Class
