Imports System
Imports System.Collections.Generic
Imports System.Threading

Namespace Searcher.Parser
	Friend Class Clear
		Private ReadOnly _config As Config = Config.GetConfig()

		Public Sub New()
			MyBase.New()
		End Sub

		Public Sub ClearProgram()
			Me._config.List_Thread.Clear()
		End Sub
	End Class
End Namespace