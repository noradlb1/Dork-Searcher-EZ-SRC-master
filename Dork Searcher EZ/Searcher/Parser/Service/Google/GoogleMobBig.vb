Imports System.Text.RegularExpressions
Imports System.Threading
Imports xNet

Imports Dork_Searcher_EZ.Searcher.Parser.Files

Namespace Searcher.Parser.Service.Google
    Friend Class GoogleMobBig
        Private ReadOnly _save As SaveResult = New SaveResult()

        Private ReadOnly _config As Config = Config.GetConfig()

        Private ReadOnly _message As MessageGUI = New MessageGUI()

        Private ReadOnly _getgoogle As Setting = Setting.GetGoogle()

        Private page As Integer

        Private timeout As Integer

        Private proxytype As String

        Private allThread As Integer

        Private domain As String

        Private lang As String

        Private country As String

        Private time As String

        Private filter As Integer

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
                httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
                httpRequest.AddHeader("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.5,en;q=0.3")
                httpRequest.AddHeader("Upgrade-Insecure-Requests", "1")
                httpRequest.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 9_2_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13D15 Safari/601.1"
                Dim str2 As String = ""
                Try
                    str2 = httpRequest.[Get](String.Concat(New Object() {"https://www.", Me.domain, "/search?q=", line, "&num=100", Me.lang, Me.country, Me.time, "&filter=", Me.filter, "&btnG=Search&start=", str * 100}), Nothing).ToString()
                    If (str2.Contains("Our systems have detected unusual traffic from your computer network") OrElse str2.Contains("but your computer or network may be sending automated queries") OrElse Not str2.Contains("google.com")) Then
                        SyncLock Me.SyncError
                            Dim config As Searcher.Parser.Config = Me._config
                            config.iError = config.iError + 1
                        End SyncLock
                        str1 = "Error"
                    Else
                        Dim matchCollections As MatchCollection = Regex.Matches(str2, "<a class=""_wSg"" href=""(\S{5,500})""")
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
            Me._message.Message("Get setting Google.", 0)
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
            Me._message.Message("Start parsing with Google.", 0)
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
            Me.domain = Me._getgoogle.DopDomain
            Me.lang = Me._getgoogle.Doplang
            Me.country = Me._getgoogle.DopCountry
            Me.time = Me._getgoogle.DopTime
            Me.filter = Me._getgoogle.DopFilter
        End Sub
    End Class
End Namespace