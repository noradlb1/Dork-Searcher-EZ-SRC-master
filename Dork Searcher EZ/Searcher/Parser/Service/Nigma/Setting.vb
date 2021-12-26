Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Namespace Searcher.Parser.Service.Nigma
	Friend Class Setting
		Private ReadOnly Shared _cfg As Setting

		Private DBLang As Dictionary(Of String, String)

		Private DBSort As Dictionary(Of String, Integer)

		Public Property Lang As String

		Public Property search As String

		Public Property Sort As Integer

		Shared Sub New()
			Setting._cfg = New Setting()
		End Sub

        Public Sub New()
            Me.DBLang = New Dictionary(Of String, String)() From
            {
                {"All", "all"},
                {"Russian", "ru"},
                {"Ukrainian", "uk"},
                {"English", "en"}
            }
            Me.DBSort = New Dictionary(Of String, Integer)() From
            {
                {"None", 0},
                {"By Date (Newest)", 1},
                {"By Date (Oldest)", 2}
            }
        End Sub

        Public Function GetLang(ByVal lang As String) As String
			Dim value As String
			Dim enumerator As Dictionary(Of String, String).Enumerator = Me.DBLang.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim current As KeyValuePair(Of String, String) = enumerator.Current
					If (current.Key <> lang) Then
						Continue While
					End If
					value = current.Value
					Return value
				End While
				Return "all"
			Finally
				DirectCast(enumerator, IDisposable).Dispose()
			End Try
			Return value
		End Function

		Public Shared Function GetNigma() As Setting
			Return Setting._cfg
		End Function

		Public Function GetSort(ByVal sort As String) As Integer
			Dim value As Integer
			Dim enumerator As Dictionary(Of String, Integer).Enumerator = Me.DBSort.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim current As KeyValuePair(Of String, Integer) = enumerator.Current
					If (current.Key <> sort) Then
						Continue While
					End If
					value = current.Value
					Return value
				End While
				Return 0
			Finally
				DirectCast(enumerator, IDisposable).Dispose()
			End Try
			Return value
		End Function
	End Class
End Namespace