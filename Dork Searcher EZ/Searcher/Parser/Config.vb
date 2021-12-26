Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace Searcher.Parser
	Friend Class Config
		Private ReadOnly Shared _cfg As Config

		Public List_Service As List(Of String) = New List(Of String)()

		Public Queue_Source As Queue(Of String) = New Queue(Of String)()

		Public List_SourceTwo As List(Of String) = New List(Of String)()

		Public Queue_Proxy As Queue(Of String) = New Queue(Of String)()

		Public List_demoProxy As List(Of String) = New List(Of String)()

		Public List_save As Queue(Of String) = New Queue(Of String)()

		Public SyncSource As Object = New Object()

		Public List_Thread As List(Of Thread) = New List(Of Thread)()

		Public Property bAP As Boolean

		Public Property bBeep As Boolean

		Public Property bblacklist As Boolean

		Public Property bDeleteNullSite As Boolean

		Public Property bDublDelSite As Boolean

		Public Property bDublDelSitePlus As Boolean

		Public Property bDublDelString As Boolean

		Public Property bDublDelTo As Boolean

		Public Property bOneFile As Boolean

		Public Property bPresence As Boolean

		Public Property bService As Boolean

		Public Property bwhitelist As Boolean

		Public Property Change As String

		Public Property EndWork As Boolean

		Public Property HWID As String

		Public Property iAllDork As Integer

		Public Property iAllThread As Integer

		Public Property iError As Integer

		Public Property iLink As Integer

		Public Property iLinkSetting As Integer

		Public Property iPage As Integer

		Public Property iPrivate As Integer

		Public Property iProxy As Integer

		Public Property ISearch As Boolean

		Public Property iService As Integer

		Public Property iTimeOut As Integer

		Public Property iTimerLinkProxy As Integer

		Public Property iWorkDork As Integer

		Public Property iWorkThread As Integer

		Public Property lastpath As String

		Public Property ManyWork As Boolean

		Public Property Message As String

		Public Property MessageInt As Integer

		Public Property sblacklist As String

		Public Property sData As String

		Public Property sProxyLink As String

		Public Property sProxyType As String

		Public Property sSaveFile As String

		Public Property sSearchService As String

		Public Property Status As Integer

		Public Property swhitelist As String

		Public Property Version As String

		Shared Sub New()
			Config._cfg = New Config()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Shared Function GetConfig() As Config
			Return Config._cfg
		End Function
	End Class
End Namespace