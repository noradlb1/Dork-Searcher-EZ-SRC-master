Imports System.IO
Imports Dork_Searcher_EZ.Searcher.Parser

Public Class FormWhite
    Private ReadOnly _config As Config = Config.GetConfig()
    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim text As String = Me.tbAdd.Text
        If (text <> "") Then
            Me.lbWhite.Items.Add(text)
        End If
        Me.tbAdd.Clear()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Me.lbWhite.Items.Remove(Me.lbWhite.SelectedItem)
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDown.Click
        Me._config.swhitelist = ""
        File.WriteAllText("white", "")
        For Each item As Object In Me.lbWhite.Items
            File.AppendAllText("white", String.Concat(item, "" & vbCrLf & ""))
            Dim config As Searcher.Parser.Config = Me._config
            config.swhitelist = String.Concat(config.swhitelist, item, ";")
        Next
        MyBase.Hide()
    End Sub
    Private Sub WhiteList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Me.lbWhite.Items.Clear()
            Dim strArrays As String() = File.ReadAllLines("white")
            For i As Integer = 0 To CInt(strArrays.Length)
                Dim str As String = strArrays(i)
                If (str <> "") Then
                    Me.lbWhite.Items.Add(str)
                End If
            Next

        Catch
        End Try
    End Sub
End Class