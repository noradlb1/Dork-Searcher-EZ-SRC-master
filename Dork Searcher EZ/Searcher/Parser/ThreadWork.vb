Imports System
Imports System.Collections.Generic
Imports System.Threading

Namespace Searcher.Parser
	Friend Class ThreadWork
		Private ReadOnly _config As Config = Config.GetConfig()

		Public Sub New()
			MyBase.New()
		End Sub

		Public Sub ThreadCancel()
			For Each listThread As Thread In Me._config.List_Thread
				If (Not listThread.IsAlive) Then
					Continue For
				End If
				Try
					listThread.Abort()
					Dim config As Searcher.Parser.Config = Me._config
					config.iWorkThread = config.iWorkThread - 1
				Catch
					listThread.[Resume]()
					listThread.Abort()
					Dim config1 As Searcher.Parser.Config = Me._config
					config1.iWorkThread = config1.iWorkThread - 1
				End Try
			Next
		End Sub

		Public Sub ThreadPause()
			For Each listThread As Thread In Me._config.List_Thread
				If (Not listThread.IsAlive) Then
					Continue For
				End If
				listThread.Suspend()
			Next
		End Sub

		Public Sub ThreadResume()
			For Each listThread As Thread In Me._config.List_Thread
				If (Not listThread.IsAlive) Then
					Continue For
				End If
				listThread.[Resume]()
			Next
		End Sub
	End Class
End Namespace