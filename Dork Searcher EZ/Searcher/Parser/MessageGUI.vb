Imports System

Namespace Searcher.Parser
	Friend Class MessageGUI
		Public Shared DoWork As MessageGUI.EventHandler

		Public Sub New()
			MyBase.New()
		End Sub

		Public Sub Message(ByVal tb As String, ByVal work As Integer)
			Dim doWork As MessageGUI.EventHandler = MessageGUI.DoWork
			If (doWork Is Nothing) Then
				Return
			End If
			doWork(tb, work)
		End Sub

		Public Delegate Sub EventHandler(ByVal tb As String, ByVal work As Integer)
	End Class
End Namespace