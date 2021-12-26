Imports System.Text.RegularExpressions
Imports System.Threading
Imports xNet

Imports Dork_Searcher_EZ.Searcher.Parser.Files

Namespace Searcher.Parser.Service.Yandex
    Friend Class Yandex
        Private ReadOnly _save As SaveResult = New SaveResult()

        Private ReadOnly _config As Config = Config.GetConfig()

        Private ReadOnly _message As MessageGUI = New MessageGUI()

        Private ReadOnly _getyandex As Setting = Setting.GetYandex()

        Private page As Integer

        Private timeout As Integer

        Private proxytype As String

        Private allThread As Integer

        Private lang As String

        Private data As String

        Private query As String

        Private SyncProxy As Object = New Object()

        Private SyncSource As Object = New Object()

        Private SyncThread As Object = New Object()

        Private SyncDork As Object = New Object()

        Private SyncError As Object = New Object()

        Private SyncSave As Object = New Object()

        Public Sub New()
            MyBase.New()
        End Sub

        Private Sub Basic()
            Dim str As String
            Dim str1 As String = ""
            Dim str2 As String = ""
            While Me._config.Queue_Source.Count > 0
                SyncLock Me.SyncSource
                    str = Me._config.Queue_Source.Dequeue()
                End SyncLock
                Dim num As Integer = 0
                Do
                    Do
                        If (Me.proxytype <> "None") Then
                            str1 = If(str2 = "Error" OrElse str2 = "", Me.GetProxy(), str2.Split(New Char() {";"c})(1))
                        End If
                        str2 = Me.Connector(str, str1, num)
                    Loop While str2 = "Error"
                    If (str2.Split(New Char() {";"c})(0) = "Null") Then
                        Exit Do
                    End If
                    num = num + 1
                Loop While num < Me.page
                SyncLock Me.SyncDork
                    Dim status As Searcher.Parser.Config = Me._config
                    status.Status = status.Status + 1
                    Dim config As Searcher.Parser.Config = Me._config
                    config.iWorkDork = config.iWorkDork + 1
                End SyncLock
            End While
            SyncLock Me.SyncThread
                Dim config1 As Searcher.Parser.Config = Me._config
                config1.iWorkThread = config1.iWorkThread - 1
                If (Me._config.iWorkThread = 0) Then
                    Dim config2 As Searcher.Parser.Config = Me._config
                    config2.iService = config2.iService + 1
                    Me._config.iWorkDork = 0
                    Me._config.Queue_Source.Clear()
                    For Each listSourceTwo As String In Me._config.List_SourceTwo
                        Me._config.Queue_Source.Enqueue(listSourceTwo)
                    Next
                    Me._config.bService = False
                End If
            End SyncLock
        End Sub

        Private Function Connector(ByVal line As String, ByVal proxy As String, ByVal str As Integer) As String
            Dim str1 As String
            Using httpRequest As xNet.HttpRequest = New xNet.HttpRequest()
                httpRequest.ConnectTimeout = Me.timeout
                httpRequest.ReadWriteTimeout = Me.timeout
                str1 = Me.proxytype
                If (str1 <> "None") Then
                    If (str1 = "Socks5") Then
                        httpRequest.Proxy = Socks5ProxyClient.Parse(proxy)
                        httpRequest.Proxy.ConnectTimeout = Me.timeout
                        httpRequest.Proxy.ReadWriteTimeout = Me.timeout
                    ElseIf (str1 = "HTTP/S") Then
                        httpRequest.Proxy = HttpProxyClient.Parse(proxy)
                        httpRequest.Proxy.ConnectTimeout = Me.timeout
                        httpRequest.Proxy.ReadWriteTimeout = Me.timeout
                    ElseIf (str1 = "Socks4") Then
                        httpRequest.Proxy = Socks4ProxyClient.Parse(proxy)
                        httpRequest.Proxy.ConnectTimeout = Me.timeout
                        httpRequest.Proxy.ReadWriteTimeout = Me.timeout
                    End If
                End If
                httpRequest.Cookies = New CookieDictionary(False)
                httpRequest.IgnoreProtocolErrors = True
                httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36"
                httpRequest.AddHeader("Accept", "*/*")
                httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest")
                httpRequest.AddHeader("Upgrade-Insecure-Requests", "1")
                httpRequest.AddHeader("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4")
                httpRequest.KeepAlive = True
                httpRequest.Cookies.Add("yp", "1855762817.sp.nd%3A50%3Abn%3A0%3Afv%3A0%3Anr%3A1%3Aprs%3A0%3Afamily%3A0#")
                Dim str2 As String = ""
                Try
                    str2 = httpRequest.[Get](String.Concat(New Object() {"https://yandex.ru/search/?text=", line, "&p=", str, Me.lang, Me.data, Me.query}), Nothing).ToString()
                    If (Not str2.Contains("yandex.ru") OrElse str2.Length < 2000) Then
                        SyncLock Me.SyncError
                            Dim config As Searcher.Parser.Config = Me._config
                            config.iError = config.iError + 1
                        End SyncLock
                        str1 = "Error"
                    Else
                        Dim matchCollections As MatchCollection = Regex.Matches(str2, "link_cropped_no"" target=""_blank"" href=""(\S{1,500})"" onmousedown=")
                        If (matchCollections.Count <> 0) Then
                            For Each match As System.Text.RegularExpressions.Match In matchCollections
                                SyncLock Me.SyncSave
                                    Dim config1 As Searcher.Parser.Config = Me._config
                                    config1.iLink = config1.iLink + 1
                                    Me._save.SettingLine(match.Result("$1").Replace("amp;", ""))
                                End SyncLock
                            Next
                            Me._message.Message(String.Concat(line, " page:", str + 1), 0)
                            str1 = String.Concat("Good;", proxy)
                        Else
                            Me._message.Message(String.Concat(line, " page:Null"), 0)
                            str1 = String.Concat("Null;", proxy)
                        End If
                    End If
                Catch httpException As xNet.HttpException
                    SyncLock Me.SyncError
                        Dim config2 As Searcher.Parser.Config = Me._config
                        config2.iError = config2.iError + 1
                    End SyncLock
                    str1 = "Error"
                End Try
            End Using
            Return str1
        End Function

        Public Sub CreateThread()
            Me.GetSetting()
            Me._message.Message("Get setting Yandex.", 0)
            Dim num As Integer = 0
            Do
                Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.Basic)) With
                {
                    .IsBackground = True
                }
                SyncLock Me.SyncThread
                    Dim config As Searcher.Parser.Config = Me._config
                    config.iWorkThread = config.iWorkThread + 1
                    Me._config.List_Thread.Add(thread)
                End SyncLock
                thread.Start()
                System.Threading.Thread.Sleep(5)
                num = num + 1
            Loop While num < Me.allThread
            Me._message.Message("Start parsing with Yandex.", 0)
        End Sub

        Private Function GetProxy() As String
            Dim empty As String = String.Empty
            Dim flag As Boolean = True
            While flag
                Try
                    SyncLock Me.SyncProxy
                        empty = Me._config.Queue_Proxy.Dequeue()
                        Me._config.Queue_Proxy.Enqueue(empty)
                    End SyncLock
                Catch
                End Try
                If (empty = String.Empty) Then
                    Continue While
                End If
                If (empty Is Nothing) Then
                    Continue While
                End If
                Return empty
            End While
            Return "127.0.0.0:1080"
        End Function

        Private Sub GetSetting()
            Me.page = Me._config.iPage
            Me.timeout = Me._config.iTimeOut
            Me.proxytype = Me._config.sProxyType
            Me.allThread = Me._config.iAllThread
            Me.lang = Me._getyandex.Lang
            Me.data = Me._getyandex.Data
            Me.query = Me._getyandex.Query
        End Sub
    End Class
End Namespace