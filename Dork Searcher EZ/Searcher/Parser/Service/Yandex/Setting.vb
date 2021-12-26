Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Namespace Searcher.Parser.Service.Yandex
	Friend Class Setting
		Private ReadOnly Shared _cfg As Setting

		Private DBLang As Dictionary(Of String, String)

		Public Property Data As String

		Public Property Lang As String

		Public Property Query As String

		Shared Sub New()
			Setting._cfg = New Setting()
		End Sub

        Public Sub New()
            Me.DBLang = New Dictionary(Of String, String)() From
            {
                {"Russian", "ru"},
                {"English", "en"},
                {"Belorussian", "be"},
                {"Indonesian", "id"},
                {"Kazakh", "kk"},
                {"German", "de"},
                {"Tatar", "tt"},
                {"Turkish", "tr"},
                {"Ukrainian", "uk"},
                {"French", "fr"}
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
				Return ""
			Finally
				DirectCast(enumerator, IDisposable).Dispose()
			End Try
			Return value
		End Function

		Public Shared Function GetYandex() As Setting
			Return Setting._cfg
		End Function
	End Class
End Namespace