Imports System
Imports System.Collections.Generic

Namespace Searcher.Parser.Setting.HelpDopSetting
	Friend Class time
		Private DBTime As Dictionary(Of String, String)

        Public Sub New()
            Me.DBTime = New Dictionary(Of String, String)() From
            {
                {"Any Time", "all"},
                {"Hour", "h"},
                {"Day", "d"},
                {"Week", "w"},
                {"Mount", "m"},
                {"Year", "y"}
            }
        End Sub

        Public Function GetTime(ByVal Time As String) As String
			Dim value As String
			Dim enumerator As Dictionary(Of String, String).Enumerator = Me.DBTime.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim current As KeyValuePair(Of String, String) = enumerator.Current
					If (current.Key <> Time) Then
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
	End Class
End Namespace