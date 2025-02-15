Public Class Form2
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        Label1.Font = New Font(GroupBox2.Text, Label1.Font.Size, Label1.Font.Style)
    End Sub
    Private Sub UpdateFontStyle()
        Dim newFontStyle As FontStyle = FontStyle.Regular
        If CheckBox2.Checked Then newFontStyle = FontStyle.Bold
        If CheckBox1.Checked Then newFontStyle = FontStyle.Italic
        If CheckBox3.Checked Then newFontStyle = FontStyle.Bold Or FontStyle.Italic
        Label1.Font = New Font(Label1.Font.FontFamily, Label1.Font.Size, newFontStyle)
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub RadioButtonColor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        If RadioButton4.Checked Then Label1.ForeColor = Color.Green
        If RadioButton5.Checked Then Label1.ForeColor = Color.Blue
        If RadioButton6.Checked Then Label1.ForeColor = Color.Red
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image File|*.jpg;*.png;*.bmp;*.gif"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class