Public Class NewYearEnd
    Private x As Integer

    Private y As Integer
    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
        MyBase.Close()
    End Sub
    Private Sub picEnd_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picEnd.MouseDown
        Me.x = e.X
        Me.y = e.Y
    End Sub

    Private Sub picEnd_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picEnd.MouseMove
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim location As Point = MyBase.Location
            Dim x As Integer = location.X + (e.X - Me.x)
            location = MyBase.Location
            MyBase.Location = New Point(x, location.Y + (e.Y - Me.y))
        End If
    End Sub
End Class