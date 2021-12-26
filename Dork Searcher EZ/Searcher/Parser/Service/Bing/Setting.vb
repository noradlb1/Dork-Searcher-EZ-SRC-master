Imports System
Imports System.Runtime.CompilerServices

Namespace Searcher.Parser.Service.Bing
	Friend Class Setting
		Private ReadOnly Shared _cfg As Setting

		Public Property Dop18 As String

		Public Property DopLang As String

		Public Property DopRegion As String

		Shared Sub New()
			Setting._cfg = New Setting()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Shared Function GetBing() As Setting
			Return Setting._cfg
		End Function
	End Class
End Namespace