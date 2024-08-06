Public Class Form2
    Dim nilai1 As Integer
    Dim nilai2 As Integer
    Dim hasil As Decimal
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = nilai1 + nilai2
        TextBox3.Text = hasil

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = nilai1 - nilai2
        TextBox3.Text = hasil
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = nilai1 * nilai2
        TextBox3.Text = hasil
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = nilai1 / nilai2
        TextBox3.Text = hasil
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub


End Class