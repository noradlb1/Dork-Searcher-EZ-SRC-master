Imports Dork_Searcher_EZ.Searcher.Parser.Files
Imports xNet


Namespace Searcher.Parser
    Friend Class LinkGetProxy
        Private ReadOnly _config As Config = Config.GetConfig()

        Private ReadOnly _openfile As OpenFile = New OpenFile()

        Private ReadOnly _message As MessageGUI = New MessageGUI()

        Public Sub New()
            MyBase.New()
        End Sub

        Private Function Connect() As Boolean
            Dim flag As Boolean
            Using httpRequest As xNet.HttpRequest = New xNet.HttpRequest()
                Try
                    httpRequest.UserAgent = "Linux / Firefox 44: Mozilla/5.0 (X11; Fedora; Linux x86_64; rv:44.0) Gecko/20100101 Firefox/44.0"
                    httpRequest.AddHeader("Accept", "*/*")
                    httpRequest.KeepAlive = True
                    httpRequest.ConnectTimeout = 15000
                    httpRequest.ReadWriteTimeout = 15000
                    httpRequest.KeepAliveTimeout = 15000
                    Dim str As String = httpRequest.[Get](Me._config.sProxyLink, Nothing).ToString()
                    Me._openfile.OpenProxyLink(str)
                    flag = If(Me._config.Queue_Proxy.Count <= 0, False, True)
                Catch
                    flag = False
                End Try
            End Using
            Return flag
        End Function

        Public Sub GetProxy()
            For i As Integer = 0 To 3
                If (Me.Connect()) Then
                    Me._message.Message("GetProxy Ok!", 1)
                    Return
                End If
                Me._message.Message("GetProxy ERROR!", 1)
            Next

        End Sub
    End Class
End Namespace