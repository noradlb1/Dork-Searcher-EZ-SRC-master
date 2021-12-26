Imports Dork_Searcher_EZ.Searcher.Parser
Imports Dork_Searcher_ez_V_13._0._1._4_Paid_Version.Searcher.Parser

Public Class myMessage
    Private ReadOnly _config As Config = Config.GetConfig()
    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        MyBase.Close()
    End Sub
    Private Sub myMessage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.rtbMessage.Text = Me._config.Message
        Me.rtbMessage.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub panelHead_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelHead.MouseDown
        Me.panelHead.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub
End Class