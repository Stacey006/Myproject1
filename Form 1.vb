Public Class Form1
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Red
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ObjDemo As New Form2()
        ObjDemo.Show() 'Show Form2
    End Sub
    Private Sub Terminate(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
