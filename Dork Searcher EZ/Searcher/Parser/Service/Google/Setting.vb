Imports System
Imports System.Runtime.CompilerServices

Namespace Searcher.Parser.Service.Google
	Friend Class Setting
		Private ReadOnly Shared _cfg As Setting

		Public Property DopCountry As String

		Public Property DopDomain As String

		Public Property DopDomainRnd As Boolean

		Public Property DopFilter As Integer

		Public Property Doplang As String

		Public Property DopTime As String

		Public Property DopTimeOne As String

		Public Property DopTimeTwo1 As String

		Public Property DopTimeTwo2 As String

		Shared Sub New()
			Setting._cfg = New Setting()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Shared Function GetGoogle() As Setting
			Return Setting._cfg
		End Function
	End Class
End Namespace