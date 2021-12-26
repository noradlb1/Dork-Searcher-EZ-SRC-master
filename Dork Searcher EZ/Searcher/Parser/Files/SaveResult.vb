Imports Searcher.Parser
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions

Namespace Searcher.Parser.Files
	Friend Class SaveResult
		Private ReadOnly _config As Config = Config.GetConfig()

		Private ReadOnly _syncLine As Object = New Object()

		Private List_string As HashSet(Of String) = New HashSet(Of String)()

		Private List_to As HashSet(Of String) = New HashSet(Of String)()

		Private List_Site As HashSet(Of String) = New HashSet(Of String)()

		Private List_SitePlus As HashSet(Of String) = New HashSet(Of String)()

		Public Sub New()
			MyBase.New()
		End Sub

		Private Function blacklist(ByVal line As String) As String
			Dim strArrays As String() = Me._config.sblacklist.Split(New Char() { ";"C })
			Dim strArrays1 As String() = line.Split(New Char() { "/"C })(2).Split(New Char() { "."C })
			Dim strArrays2 As String() = strArrays
			Dim num As Integer = 0
			Do
				Dim str As String = strArrays2(num)
				If (str <> "") Then
					Dim strArrays3 As String() = strArrays1
					For i As Integer = 0 To CInt(strArrays3.Length)
						If (strArrays3(i) = str) Then
							Return "No"
						End If
					Next

				End If
				num = num + 1
			Loop While num < CInt(strArrays2.Length)
			Return line
		End Function

		Public Sub Clear()
			Me.List_to.Clear()
			Me.List_Site.Clear()
			Me.List_string.Clear()
			Me.List_SitePlus.Clear()
		End Sub

		Private Function DelDublString(ByVal line As String) As String
			If (Me.List_string.Add(line)) Then
				Return line
			End If
			Return "No"
		End Function

		Private Function DeleteNullLine(ByVal line As String) As String
			Dim match As System.Text.RegularExpressions.Match = Regex.Match(line, "^((http|https)://[a-z0-9\-\.:_]*/)(\S{1,})$", RegexOptions.IgnoreCase)
			If (match.Value = "") Then
				Return "No"
			End If
			Return match.Value
		End Function

		Private Function DublDelSite(ByVal line As String) As String
			If (Me.List_Site.Add(line.Split(New Char() { "/"C })(2))) Then
				Return line
			End If
			Return "No"
		End Function

		Private Function DublDelSitePlus(ByVal line As String) As String
			Dim num As Integer = 0
			Dim flag As Boolean = False
			Dim str As String = line.Split(New Char() { "/"C })(2)
			Dim str1 As String = "N/A"
			If (str.Split(New Char() { "."C })(0) = "mail") Then
				Return "No"
			End If
			If (str.Split(New Char() { "."C })(0) = "webmail") Then
				Return "No"
			End If
			If (str.Split(New Char() { "."C })(0) = "owa") Then
				Return "No"
			End If
			Dim str2 As String = str
			Dim num1 As Integer = 0
			Do
				If (str2(num1) = "."C) Then
					num = num + 1
				End If
				num1 = num1 + 1
			Loop While num1 < str2.Length
			Select Case num
				Case 1
					str1 = "(\S{1,500})\."
					Exit Select
				Case 2
					str1 = "\.(\S{1,500})\."
					Exit Select
				Case 3
					str1 = "\.(\S{1,500})\.\S{1,150}\."
					Exit Select
				Case 4
					str1 = "\.\S{1,150}\.(\S{1,500})\.\S{1,150}\."
					Exit Select
				Case 5
					str1 = "\.\S{1,150}\.\S{1,150}\.\S{1,150}\.(\S{1,500})\.\S{1,150}"
					Exit Select
			End Select
			Dim match As System.Text.RegularExpressions.Match = Regex.Match(str, str1)
			Try
				flag = Me.List_SitePlus.Add(match.Result("$1"))
			Catch
				flag = Me.List_SitePlus.Add(str)
			End Try
			If (flag) Then
				Return line
			End If
			Return "No"
		End Function

		Private Function DublDelTo(ByVal line As String) As String
			If (Me.List_to.Add(line.Split(New Char() { "="C })(0))) Then
				Return line
			End If
			Return "No"
		End Function

		Private Function Presence(ByVal line As String) As String
			If (line.Contains("?")) Then
				Return line
			End If
			Return "No"
		End Function

		Private Sub SaveLine(ByVal line As String)
			Try
				SyncLock Me._syncLine
					Using streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(Me._config.sSaveFile, True)
						streamWriter.WriteLine(line)
					End Using
				End SyncLock
				Dim config As Searcher.Parser.Config = Me._config
				config.iLinkSetting = config.iLinkSetting + 1
			Catch
			End Try
		End Sub

		Public Sub SettingLine(ByVal line As String)
			Dim str As String = line
			If (Not line.Contains("://")) Then
				str = String.Concat("http://", str)
			End If
			If (Me._config.bDublDelString) Then
				str = Me.DelDublString(line)
				If (str = "No") Then
					Return
				End If
			End If
			If (Me._config.bDeleteNullSite) Then
				str = Me.DeleteNullLine(str)
				If (str = "No") Then
					Return
				End If
			End If
			If (Me._config.bPresence) Then
				str = Me.Presence(str)
				If (str = "No") Then
					Return
				End If
			End If
			If (Me._config.bDublDelTo) Then
				str = Me.DublDelTo(str)
				If (str = "No") Then
					Return
				End If
			End If
			If (Me._config.bDublDelSite) Then
				str = Me.DublDelSite(str)
				If (str = "No") Then
					Return
				End If
			End If
			If (Me._config.bblacklist) Then
				str = Me.blacklist(str)
				If (str = "No") Then
					Return
				End If
			End If
			If (Me._config.bwhitelist) Then
				str = Me.whitelist(str)
				If (str = "No") Then
					Return
				End If
			End If
			If (Me._config.bDublDelSitePlus) Then
				str = Me.DublDelSitePlus(str)
				If (str = "No") Then
					Return
				End If
			End If
			Me.SaveLine(str)
		End Sub

		Private Function whitelist(ByVal line As String) As String
			Dim strArrays As String() = Me._config.swhitelist.Split(New Char() { ";"C })
			Dim strArrays1 As String() = line.Split(New Char() { "/"C })(2).Split(New Char() { "."C })
			Dim strArrays2 As String() = strArrays
			Dim num As Integer = 0
			Do
				Dim str As String = strArrays2(num)
				If (str <> "") Then
					Dim strArrays3 As String() = strArrays1
					For i As Integer = 0 To CInt(strArrays3.Length)
						If (strArrays3(i) = str) Then
							Return line
						End If
					Next

				End If
				num = num + 1
			Loop While num < CInt(strArrays2.Length)
			Return "No"
		End Function
	End Class
End Namespace