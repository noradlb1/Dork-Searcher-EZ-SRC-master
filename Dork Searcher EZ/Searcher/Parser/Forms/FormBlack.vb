Imports Searcher.Parser
Imports Searcher.Properties
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Windows.Forms
Imports Dork_Searcher_EZ.Searcher.Parser

Public Class FormBlack
    Private ReadOnly _config As Config = Config.GetConfig()
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim text As String = Me.tbAdd.Text
        If (text <> "") Then
            Me.lbBlack.Items.Add(text)
        End If
        Me.tbAdd.Clear()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Me.lbBlack.Items.Remove(Me.lbBlack.SelectedItem)
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDown.Click
        Me._config.sblacklist = ""
        File.WriteAllText("black", "")
        For Each item As Object In Me.lbBlack.Items
            File.AppendAllText("black", String.Concat(item, "" & vbCrLf & ""))
            Dim config As Searcher.Parser.Config = Me._config
            config.sblacklist = String.Concat(config.sblacklist, item, ";")
        Next
        MyBase.Hide()
    End Sub
    Private Sub FormBlack_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Me.lbBlack.Items.Clear()
            Dim strArrays As String() = File.ReadAllLines("black")
            For i As Integer = 0 To CInt(strArrays.Length)
                Dim str As String = strArrays(i)
                If (str <> "") Then
                    Me.lbBlack.Items.Add(str)
                End If
            Next

        Catch
        End Try
    End Sub


End Class