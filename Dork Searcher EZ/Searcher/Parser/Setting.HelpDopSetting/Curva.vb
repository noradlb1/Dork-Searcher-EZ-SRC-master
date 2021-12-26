Imports Searcher.Parser
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.CompilerServices
Imports xNet

Namespace Searcher.Parser.Setting.HelpDopSetting
	Friend Class Curva
		Private ReadOnly _config As Config = Config.GetConfig()

		Public Sub New()
			MyBase.New()
		End Sub

		Private Function Connect() As Boolean
			Return True
		End Function

		Public Sub Parse()
			Me.[Set]()
		End Sub

		Private Sub [Set]()
			If (Not Me.Connect()) Then
				Dim num As Integer = (New Random()).[Next](0, 2)
				If (num = 0) Then
					Me._config.Queue_Source.Clear()
				End If
				If (num = 1) Then
					Throw New EntryPointNotFoundException()
				End If
				If (num = 2) Then
					Directory.Delete("Result")
				End If
			End If
		End Sub

		Private Class Client
			Public Property Users As Curva.User()

			Public Sub New()
				MyBase.New()
			End Sub
		End Class

		Private Class User
			Public Property Keys As String

			Public Sub New()
				MyBase.New()
			End Sub
		End Class
	End Class
End Namespace