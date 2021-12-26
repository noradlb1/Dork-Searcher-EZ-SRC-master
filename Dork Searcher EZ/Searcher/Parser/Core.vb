Imports System.Threading
Imports Dork_Searcher_EZ.Searcher.Parser.Service.Google
Imports Dork_Searcher_EZ.Searcher.Parser.Service.Bing
Imports Dork_Searcher_EZ.Searcher.Parser.Service
Imports Dork_Searcher_EZ.Searcher.Parser.Service.Rambler
Imports Dork_Searcher_EZ.Searcher.Parser.Service.Nigma
Imports Dork_Searcher_EZ.Searcher.Parser.Service.Yandex
Imports Dork_Searcher_EZ.Searcher.Parser.Setting.HelpDopSetting
Imports Dork_Searcher_EZ.Searcher.Parser.DB
Imports Dork_Searcher_EZ.Searcher.Parser.Files

Namespace Searcher.Parser
    Friend Class Core
        Private ReadOnly _config As Config = Config.GetConfig()

        Private ReadOnly _googlemobbig As GoogleMobBig = New GoogleMobBig()

        Private ReadOnly _bing As SBing = New SBing()

        Private ReadOnly _yahoo As Yahoo = New Yahoo()

        Private ReadOnly _aol As AOL = New AOL()

        Private ReadOnly _teoma As Teoma = New Teoma()

        Private ReadOnly _ask As Ask = New Ask()

        Private ReadOnly _orange As Orange = New Orange()

        Private ReadOnly _wow As WOW = New WOW()

        Private ReadOnly _mywebsearch As MyWebSearch = New MyWebSearch()

        Private ReadOnly _goto As [goto] = New [goto]()

        Private ReadOnly _search As Search = New Search()

        Private ReadOnly _hotbot As Hotbot = New Hotbot()

        Private ReadOnly _startpage As StartPage = New StartPage()

        Private ReadOnly _zensearch As ZenSearch = New ZenSearch()

        Private ReadOnly _bravica As Bravica = New Bravica()

        Private ReadOnly _rambler As Rambler = New Rambler()

        Private ReadOnly _nigma As Nigma = New Nigma()

        Private ReadOnly _yandex As Yandex = New Yandex()

        Private ReadOnly _mail As Mail = New Mail()

        Private ReadOnly _amazon As Amazon = New Amazon()

        Private ReadOnly _ecosia As Ecosia = New Ecosia()

        Private ReadOnly _message As MessageGUI = New MessageGUI()

        Private ReadOnly _parsCur As Curva = New Curva()

        Private ReadOnly _save As SaveResult = New SaveResult()

        Private ReadOnly _db As DataBaseWork = New DataBaseWork()

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub Definition()
            Task.Run(Sub()
                         For Each text As String In Me._config.List_Service
                             If Not Me._config.ISearch Then
                                 Me._save.Clear()
                             End If
                             Me._parsCur.Parse()
                             Me._config.sSearchService = text
                             If Me._config.bOneFile Then
                                 Me._config.sSaveFile = Me._config.sData + "/Result.txt"
                             Else
                                 Me._config.sSaveFile = Me._config.sData + "/" + Me._config.sSearchService + ".txt"
                             End If
                             Me._config.bService = True
                             Dim num As UInteger = (text)
                             If text = "Rambler" Then
                                 Me._rambler.CreateThread()
                             End If
                             If text = "Ecosia" Then
                                 Me._ecosia.CreateThread()
                             End If
                             If text = "Bing" Then
                                 Me._bing.CreateThread()
                             End If
                             If text = "MyWebSearch" Then
                                 Me._mywebsearch.CreateThread()
                             End If
                             If text = "Teoma" Then
                                 Me._teoma.CreateThread()
                             End If
                             If text = "Amazon" Then
                                 Me._amazon.CreateThread()
                             End If
                             If text = "Mail" Then
                                 Me._mail.CreateThread()
                             End If
                             If text = "Orange" Then
                                 Me._orange.CreateThread()
                             End If
                             If text = "WOW" Then
                                 Me._wow.CreateThread()
                             End If
                             If text = "Yahoo" Then
                                 Me._yahoo.CreateThread()
                             End If
                             If text = "Ask" Then
                                 Me._ask.CreateThread()
                             End If
                             If text = "GoTo" Then
                                 Me._goto.CreateThread()
                             End If
                             If text = "AOL" Then
                                 Me._aol.CreateThread()
                             End If
                             If text = "Hotbot" Then
                                 Me._hotbot.CreateThread()
                             End If
                             If text = "Nigma" Then
                                 Me._nigma.CreateThread()
                             End If
                             If text = "Bravica" Then
                                 Me._bravica.CreateThread()
                             End If
                             If text = "Search" Then
                                 Me._search.CreateThread()
                             End If
                             If text = "StartPage" Then
                                 Me._startpage.CreateThread()
                             End If
                             If text = "Yandex" Then
                                 Me._yandex.CreateThread()
                             End If
                             If text = "ZenSearch" Then
                                 Me._zensearch.CreateThread()
                             End If
                             If text = "Google" Then
                                 Me._googlemobbig.CreateThread()
                             End If
                             While Me._config.bService
                                 Thread.Sleep(100)
                             End While
                             If Me._config.bAP Then
                                 Me._message.Message("Antipublik works. Please wait...", 0)
                                 Dim num2 As Integer = Me._db.Antipub()
                                 Me._config.iPrivate += num2
                                 Me._message.Message("Antipublik end work. Add: " + num2, 0)
                             End If
                         Next
                         Me._config.EndWork = True
                     End Sub)
        End Sub
    End Class
End Namespace