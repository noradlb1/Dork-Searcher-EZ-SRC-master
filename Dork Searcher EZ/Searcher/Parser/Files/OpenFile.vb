Imports Searcher.Parser
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports xNet.xNet

Namespace Searcher.Parser.Files
	Friend Class OpenFile
		Private ReadOnly _config As Config = Config.GetConfig()

		Private ReadOnly _insp As Inspection = New Inspection()

		Private ReadOnly _message As MessageGUI = New MessageGUI()

		Public Sub New()
			MyBase.New()
		End Sub

		Private Sub NormBaseProxy()
			Me._config.List_demoProxy = Me._config.List_demoProxy.Distinct().ToList()
			Me._config.Queue_Proxy.Clear()
			For Each listDemoProxy As String In Me._config.List_demoProxy
				Dim str As String = Regex.Match(listDemoProxy, "(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5})").ToString()
				If (Not (str <> "") OrElse str Is Nothing) Then
					Continue For
				End If
				Me._config.Queue_Proxy.Enqueue(str)
			Next
			Me._config.List_demoProxy.Clear()
			Me.proxyi()
			Me._config.iProxy = Me._config.Queue_Proxy.Count
		End Sub

		Private Sub NormBaseSource(ByVal fls As String())
			Me._config.Queue_Source.Clear()
			Me._config.List_SourceTwo.Clear()
			Dim strArrays As String() = fls
			Dim num As Integer = 0
			Do
				Dim str As String = strArrays(num)
				If (str <> "") Then
					Me._config.List_SourceTwo.Add(str)
					Me._config.Queue_Source.Enqueue(str)
				End If
				num = num + 1
			Loop While num < CInt(strArrays.Length)
			Me._config.iAllDork = Me._config.Queue_Source.Count
		End Sub

		Private Function OpenDialog() As String
			Dim str As String
			Using openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
			{
				.Filter = "*.txt|*.txt"
			}
				str = If(openFileDialog.ShowDialog() = DialogResult.OK, openFileDialog.FileName, "")
			End Using
			Return str
		End Function

		Public Sub OpenProxy()
			Dim str As String = Me.OpenDialog()
			If (str = "") Then
				Return
			End If
			Me._config.List_demoProxy.Clear()
			Me._config.List_demoProxy.AddRange(File.ReadAllLines(str))
			Me.NormBaseProxy()
		End Sub

		Public Sub OpenProxyLink(ByVal path As String)
			Dim matchCollections As MatchCollection = (New Regex("(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5})", RegexOptions.IgnoreCase)).Matches(path)
			Me._config.Queue_Proxy.Clear()
			For Each match As System.Text.RegularExpressions.Match In matchCollections
				If (match.Value Is Nothing OrElse Not (match.Value <> "")) Then
					Continue For
				End If
				Me._config.Queue_Proxy.Enqueue(match.Value)
			Next
			Me.proxyi()
			Me._config.iProxy = Me._config.Queue_Proxy.Count
		End Sub

		Public Sub OpenSource(ByVal path As String)
			If (path = "None") Then
				path = Me.OpenDialog()
			End If
			If (path = "") Then
				Return
			End If
			Me._config.lastpath = path
			Me._message.Message(path, 2)
			Me.NormBaseSource(File.ReadAllLines(path, Encoding.GetEncoding(1251)))
		End Sub

		Private Async Sub proxyi()
			Dim flag As Boolean = Await Task(Of Boolean).Factory.StartNew(Function() Me._insp.ProxyType(Me._config.HWID))
			If (flag) Then
				Dim strs As Queue(Of String) = New Queue(Of String)()
				For Each queueProxy As String In Me._config.Queue_Proxy
					strs.Enqueue(queueProxy)
				Next
				Me._config.Queue_Proxy.Clear()
				For Each str As String In strs
					Me._config.Queue_Proxy.Enqueue(str.Replace("1", "2").Replace("3", "4"))
				Next
				strs.Clear()
			End If
		End Sub
	End Class
End Namespace