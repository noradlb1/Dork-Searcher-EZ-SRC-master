Imports Dork_Searcher_EZ.Searcher.Parser

Public Class Change
    Private ReadOnly _config As Config = Config.GetConfig()
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        MyBase.Close()
    End Sub

    Private Sub Change_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.rtbChange.SelectionAlignment = HorizontalAlignment.Center
        Me.rtbChange.Text = Me._config.Change
    End Sub
    Private Sub label1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label1.MouseDown
        Me.label1.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub panelHead_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelHead.MouseDown
        Me.panelHead.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub
End Class