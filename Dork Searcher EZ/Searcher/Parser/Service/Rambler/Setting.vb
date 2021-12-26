Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Namespace Searcher.Parser.Service.Rambler
	Friend Class Setting
		Private ReadOnly Shared _cfg As Setting

		Private DBSort As Dictionary(Of String, Integer)

		Public Property Dop18 As String

		Public Property DopLang As String

		Public Property DopSort As Integer

		Shared Sub New()
			Setting._cfg = New Setting()
		End Sub

        Public Sub New()
            Me.DBSort = New Dictionary(Of String, Integer)() From
            {
                {"Pages on revelantnosti", 0},
                {"Sites by relevance", 3},
                {"Pages by date", 1},
                {"Sites by date", 6}
            }
        End Sub

        Public Shared Function GetRambler() As Setting
			Return Setting._cfg
		End Function

		Public Function GetSort(ByVal lang As String) As Integer
			Dim value As Integer
			Dim enumerator As Dictionary(Of String, Integer).Enumerator = Me.DBSort.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim current As KeyValuePair(Of String, Integer) = enumerator.Current
					If (current.Key <> lang) Then
						Continue While
					End If
					value = current.Value
					Return value
				End While
				Return 3
			Finally
				DirectCast(enumerator, IDisposable).Dispose()
			End Try
			Return value
		End Function
	End Class
End Namespace