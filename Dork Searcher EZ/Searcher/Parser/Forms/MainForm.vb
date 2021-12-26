Imports System.IO
Imports System.Threading
Imports xNet.xNet
Imports Dork_Searcher_EZ.Searcher.Parser.Setting.HelpDopSetting
Imports Dork_Searcher_EZ.Searcher.Parser.Files
Imports Dork_Searcher_EZ.Searcher.Parser
Imports Dork_Searcher_EZ.Searcher.Parser.DB

Public Class MainForm
    Private frmset As FormSetting = New FormSetting()

    Private ReadOnly _config As Config = Config.GetConfig()

    Private ReadOnly _linkgetproxy As LinkGetProxy = New LinkGetProxy()

    Private ReadOnly _getinfo As GetInfo = New GetInfo()

    Private ReadOnly _core As Core = New Core()

    Private ReadOnly _thread As ThreadWork = New ThreadWork()

    Private ReadOnly _openfile As OpenFile = New OpenFile()

    Private ReadOnly _music As Music = New Music()

    Private ReadOnly _sattingresult As SaveResult = New SaveResult()

    Private ReadOnly _insp As Inspection = New Inspection()

    Private ReadOnly _lang As language = New language()

    Private ReadOnly _time As time = New time()

    Private ReadOnly _country As country = New country()

    Private ReadOnly _getgoogle As Searcher.Parser.Service.Google.Setting = Searcher.Parser.Service.Google.Setting.GetGoogle()

    Private ReadOnly _getbing As Searcher.Parser.Service.Bing.Setting = Searcher.Parser.Service.Bing.Setting.GetBing()

    Private ReadOnly _getramb As Searcher.Parser.Service.Rambler.Setting = Searcher.Parser.Service.Rambler.Setting.GetRambler()

    Private ReadOnly _getnigma As Searcher.Parser.Service.Nigma.Setting = Searcher.Parser.Service.Nigma.Setting.GetNigma()

    Private ReadOnly _getyandex As Searcher.Parser.Service.Yandex.Setting = Searcher.Parser.Service.Yandex.Setting.GetYandex()

    Private ReadOnly _db As DataBaseWork = New DataBaseWork()

    Private pause As Boolean = True

    Private OpenSetting As Boolean

    Private Yes As Boolean

    Private nye As NewYearEnd = New NewYearEnd()

    Private frmblack As FormBlack = New FormBlack()

    Private frmWhite As FormWhite = New FormWhite()
    Public Sub New()
        InitializeComponent()
        MessageGUI.DoWork = CType([Delegate].Combine(MessageGUI.DoWork, New MessageGUI.EventHandler(AddressOf UpdateStatistics)), MessageGUI.EventHandler)
    End Sub

    Private Sub btnChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChange.Click
        Dim change As Change = New Change()
        Dim location As Point = MyBase.Location
        Dim x As Integer = location.X + 182
        location = MyBase.Location
        Dim y As Integer = location.Y + 96
        change.Location = New Point(x, y)
        Me.lbMessage.Text = Me._config.MessageInt.ToString()
        change.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Application.[Exit]()
    End Sub

    Private Sub btnDirectory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDirectory.Click
        Process.Start(String.Concat(Application.StartupPath, "/", Me._config.sData))
    End Sub

    Private Sub btnLinkLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLikLoad.Click
        If (Not Me.inspLink()) Then
            Me.UpdateStatistics("Proxy link is already included", 0)
            Return
        End If
        Me.TimerGetProxy.[Stop]()
        Me._config.sProxyLink = Me.tbProxyLink.Text
        Me.TimerGetProxy.Interval = Me._config.iTimerLinkProxy * 60000
        Me.TimerGetProxy.Start()
        Me.UpdateStatistics("Parsing Proxy", 0)
        Dim thread As System.Threading.Thread = New System.Threading.Thread(Sub() Me._linkgetproxy.GetProxy())
        thread.Start()
        Me.lbProxy.Text = Me._config.iProxy.ToString()
    End Sub

    Private Sub btnMany_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMany.Click
        Me.Setting()
        Me._config.ManyWork = True
        Me.clbService.Visible = True
    End Sub

    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
        Me.sourcei()
        If (Not Me.inspSource()) Then
            Me.UpdateStatistics("You can't load source", 0)
            Return
        End If
        Me._openfile.OpenSource("None")
        Dim label As System.Windows.Forms.Label = Me.lbDork
        Dim obj As Object = Me._config.iWorkDork
        Dim num As Integer = Me._config.iAllDork
        label.Text = String.Concat(obj, " / ", num.ToString())
    End Sub

    Private Sub btnPause_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPause.Click
        If (Me.inspPause()) Then
            If (Me.pause) Then
                Me.btnPause.BackgroundImage = My.Resources.btnBegin
                Me._thread.ThreadPause()
                Me.pause = False
                Return
            End If
            Me.btnPause.BackgroundImage = My.Resources.btnPause
            Me._thread.ThreadResume()
            Me.pause = True
        End If
    End Sub

    Private Sub btnProxy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProxy.Click
        Me._openfile.OpenProxy()
        Me.lbProxy.Text = Me._config.iProxy.ToString()
        Me.proxyi()
    End Sub

    Private Sub btnSetting_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetting.Click
        Dim location As Point = MyBase.Location
        Dim x As Integer = location.X + 290
        location = MyBase.Location
        Dim y As Integer = location.Y + 3
        Me.frmset.Location = New Point(x, y)
        Me.frmset.ShowDialog()
    End Sub

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click
        Me.path()
        If (Me.inspStart()) Then
            Me.ClearStart()
            Me._config.sSearchService = Me.cbSearch.Text
            Me._config.sProxyType = Me.cbProxyType.Text
            Me._config.iAllThread = Convert.ToInt32(Me.nudThread.Value)
            Me._config.iTimeOut = Convert.ToInt32(Me.nudTimeOut.Value)
            Me._config.iPage = Convert.ToInt32(Me.nudPage.Value)
            Me._config.iAllDork = Me._config.Queue_Source.Count
            Me._config.bBeep = Me.chbBeep.Checked
            Me._config.bOneFile = Me.chbOneFile.Checked
            Me._config.bDublDelString = Me.chbDelOne.Checked
            Me._config.bDeleteNullSite = Me.chbDelNull.Checked
            Me._config.bPresence = Me.chbPresence.Checked
            Me._config.bDublDelTo = Me.chbDelTwo.Checked
            Me._config.bDublDelSite = Me.chbDelThree.Checked
            Me._config.bDublDelSitePlus = Me.chbFour.Checked
            Me._config.bblacklist = Me.chbBlackList.Checked
            Me._config.bwhitelist = Me.chbWhiteList.Checked
            Me._config.ISearch = Me.chbISearch.Checked
            Me._config.bAP = Me.chbAntiPublic.Checked
            Me.SetDopSetting()
            Me.TimerCleartb.Interval = 600000
            Me.TimerCleartb.Start()
            Me._config.EndWork = False
            Me.TimerThread.Interval = 1000
            Me.TimerThread.Start()
            Me.UpdateStatistics("Start Work", 0)
            If (Not Me._config.ManyWork) Then
                Me._config.List_Service.Add(Me._config.sSearchService)
                Me.pbStatus.Maximum = Me._config.iAllDork
            Else
                For Each checkedItem As Object In Me.clbService.CheckedItems
                    Me._config.List_Service.Add(checkedItem.ToString())
                Next
                If (Me.clbService.CheckedItems.Count <> 0) Then
                    Me.pbStatus.Maximum = Me._config.iAllDork * Me.clbService.CheckedItems.Count
                Else
                    Me.pbStatus.Maximum = Me._config.iAllDork
                End If
            End If
            Me._core.Definition()
        End If
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStop.Click
        If (Me.inspStop()) Then
            Task.Run(Sub()
                         Me._thread.ThreadCancel()
                         Me._config.bService = False
                     End Sub)
        End If
    End Sub

    Private Sub btnTray_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTray.Click
        MyBase.WindowState = FormWindowState.Minimized
        Me.IconTray.Visible = True
        MyBase.Hide()
    End Sub

    Private Sub cbSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cbSearch.Click
        Me._config.ManyWork = False
        Me.clbService.Visible = False
    End Sub

    Private Sub cbSearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSearch.SelectedIndexChanged
        Me.Setting()
        Dim text As String = Me.cbSearch.Text
        If (text = "Rambler") Then
            Me.rtbLog.Text = Me._getinfo.Rambler
            Me.picSearch.Image = My.Resources.Rambler
            Me.Yes = True
            Return
        End If
        If (text = "Ecosia") Then
            Me.rtbLog.Text = Me._getinfo.Ecosia
            Me.picSearch.Image = My.Resources.Ecosia
            Me.Yes = False
            Return
        End If
        If (text = "Bing") Then
            Me.rtbLog.Text = Me._getinfo.Bing
            Me.picSearch.Image = My.Resources.Bing
            Me.Yes = True
            Return
        End If
        If (text = "MyWebSearch") Then
            Me.rtbLog.Text = Me._getinfo.MyWebSearch
            Me.picSearch.Image = My.Resources.MyWebSearch
            Me.Yes = False
            Return
        End If
        If (text = "Teoma") Then
            Me.rtbLog.Text = Me._getinfo.Teoma
            Me.picSearch.Image = My.Resources.Teoma
            Me.Yes = False
            Return
        End If
        If (text = "Amazon") Then
            Me.rtbLog.Text = Me._getinfo.Amazon
            Me.picSearch.Image = My.Resources.Amazon
            Me.Yes = False
            Return
        End If
        If (text = "Mail") Then
            Me.rtbLog.Text = Me._getinfo.Mail
            Me.picSearch.Image = My.Resources.mail
            Me.Yes = False
            Return
        End If
        If (text = "Orange") Then
            Me.rtbLog.Text = Me._getinfo.Orange
            Me.picSearch.Image = My.Resources.Orange
            Me.Yes = False
            Return
        End If
        If (text = "WOW") Then
            Me.rtbLog.Text = Me._getinfo.WOW
            Me.picSearch.Image = My.Resources.Wow
            Me.Yes = False
            Return
        End If
        If (text = "Yahoo") Then
            Me.rtbLog.Text = Me._getinfo.Yahoo
            Me.picSearch.Image = My.Resources.Yahoo
            Me.Yes = False
            Return
        End If
        If (text = "Ask") Then
            Me.rtbLog.Text = Me._getinfo.Ask
            Me.picSearch.Image = My.Resources.Ask
            Me.Yes = False
            Return
        End If
        If (text = "GoTo") Then
            Me.rtbLog.Text = Me._getinfo.[GoTo]
            Me.picSearch.Image = My.Resources._GoTo
            Me.Yes = False
            Return
        End If
        If (text = "AOL") Then
            Me.rtbLog.Text = Me._getinfo.AOL
            Me.picSearch.Image = My.Resources.AOL
            Me.Yes = False
            Return
        End If
        If (text = "Hotbot") Then
            Me.rtbLog.Text = Me._getinfo.Hotbot
            Me.picSearch.Image = My.Resources.Hotbot
            Me.Yes = False
            Return
        End If
        If (text = "Nigma") Then
            Me.rtbLog.Text = Me._getinfo.Nigma
            Me.picSearch.Image = My.Resources.nigma
            Me.Yes = True
            Return
        End If
        If (text = "Bravica") Then
            Me.rtbLog.Text = Me._getinfo.Bravica
            Me.picSearch.Image = My.Resources.Bravica
            Me.Yes = False
            Return
        End If
        If (text = "Search") Then
            Me.rtbLog.Text = Me._getinfo.Search
            Me.picSearch.Image = My.Resources.Search_com
            Me.Yes = False
            Return
        End If
        If (text = "StartPage") Then
            Me.rtbLog.Text = Me._getinfo.StartPage
            Me.picSearch.Image = My.Resources.StartPage
            Me.Yes = False
            Return
        End If
        If (text = "Yandex") Then
            Me.rtbLog.Text = Me._getinfo.Yandex
            Me.picSearch.Image = My.Resources.Yandex
            Me.Yes = True
            Return
        End If
        If (text = "ZenSearch") Then
            Me.rtbLog.Text = Me._getinfo.ZenSearch
            Me.picSearch.Image = My.Resources.ZenSearch
            Me.Yes = False
            Return
        End If
        If (text <> "Google") Then
            Return
        End If
        Me.Yes = True
        Me.rtbLog.Text = Me._getinfo.Google
        Me.picSearch.Image = My.Resources.Google
    End Sub

    Private Sub chbAntiPublic_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbAntiPublic.CheckedChanged
        If (Me.chbAntiPublic.Checked) Then
            If (Me._db.InspAP() <> 8) Then
                Me.chbAntiPublic.Checked = False
                MessageBox.Show("Please, follow the database setup")
            End If
            If (Not Me.chbDelOne.Checked AndAlso Not Me.chbDelTwo.Checked AndAlso Not Me.chbDelThree.Checked AndAlso Not Me.chbFour.Checked) Then
                Me.chbAntiPublic.Checked = False
                MessageBox.Show("Check pls (string|to=|site|site+)")
            End If
        End If
    End Sub

    Private Sub chbBlackList_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbBlackList.CheckedChanged
        If (Me.chbBlackList.Checked) Then
            Me.frmblack.ShowDialog(Me)
        End If
    End Sub

    Private Sub chbDelOne_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbDelOne.CheckedChanged
        If (Me.chbDelTwo.Checked OrElse Me.chbDelThree.Checked OrElse Me.chbFour.Checked) Then
            Me.chbDelTwo.Checked = False
            Me.chbDelThree.Checked = False
            Me.chbFour.Checked = False
        End If
    End Sub

    Private Sub chbDelThree_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles chbDelThree.CheckedChanged
        If (Me.chbDelOne.Checked OrElse Me.chbDelTwo.Checked OrElse Me.chbFour.Checked) Then
            Me.chbDelOne.Checked = False
            Me.chbDelTwo.Checked = False
            Me.chbFour.Checked = False
        End If
    End Sub

    Private Sub chbDelTwo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbDelTwo.CheckedChanged
        If (Me.chbDelOne.Checked OrElse Me.chbDelThree.Checked OrElse Me.chbFour.Checked) Then
            Me.chbDelOne.Checked = False
            Me.chbDelThree.Checked = False
            Me.chbFour.Checked = False
        End If
    End Sub

    Private Sub chbFour_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbFour.CheckedChanged
        If (Me.chbDelOne.Checked OrElse Me.chbDelTwo.Checked OrElse Me.chbDelThree.Checked) Then
            Me.chbDelOne.Checked = False
            Me.chbDelTwo.Checked = False
            Me.chbDelThree.Checked = False
        End If
    End Sub

    Private Sub chbWhiteList_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbWhiteList.CheckedChanged
        If (Me.chbWhiteList.Checked) Then
            Me.frmWhite.ShowDialog(Me)
        End If
    End Sub

    Private Sub clbService_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles clbService.ItemCheck
        Try
            Me.cbSearch.Text = Me.clbService.SelectedItem.ToString()
        Catch
        End Try
    End Sub

    Private Sub ClearStart()
        Me._config.iService = 1
        Me.lbDork.Text = "0 / 0"
        Me.lbQueue.Text = "0 / 0"
    End Sub

    Private Sub ClearStop()
        Me._config.List_Service.Clear()
        Me._config.Queue_Source.Clear()
        Me._config.List_SourceTwo.Clear()
        Me.lbServiceNow.Text = "None"
        Me._config.iWorkDork = 0
        Me._config.iAllDork = 0
        Me._config.Status = 0
    End Sub
    Private Sub GooglecbCountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglecbCountry.SelectedIndexChanged
        If (Me.GooglecbCountry.SelectedIndex = 0) Then
            Me.GooglechbCountryNorm.Enabled = False
            Me.GooglechbCountryHard.Enabled = False
            Return
        End If
        Me.GooglechbCountryNorm.Enabled = True
        Me.GooglechbCountryHard.Enabled = True
    End Sub

    Private Sub GooglecbTime_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglecbTime.SelectedIndexChanged
        If (Me.GooglecbTime.SelectedIndex = 0) Then
            Me.GooglechbTimeOne.Enabled = False
            Return
        End If
        Me.GooglechbTimeOne.Enabled = True
    End Sub

    Private Sub GooglechbCountryHard_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglechbCountryHard.CheckedChanged
        If (Me.GooglechbCountryNorm.Checked) Then
            Me.GooglechbCountryNorm.Checked = False
        End If
        If (Not Me.GooglechbCountryNorm.Checked AndAlso Not Me.GooglechbCountryHard.Checked) Then
            Me.GooglechbCountryHard.Checked = True
        End If
    End Sub

    Private Sub GooglechbCountryNorm_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglechbCountryNorm.CheckedChanged
        If (Me.GooglechbCountryHard.Checked) Then
            Me.GooglechbCountryHard.Checked = False
        End If
        If (Not Me.GooglechbCountryNorm.Checked AndAlso Not Me.GooglechbCountryHard.Checked) Then
            Me.GooglechbCountryNorm.Checked = True
        End If
    End Sub

    Private Sub GooglechbLangHard_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglechbLangHard.CheckedChanged
        If (Me.GooglechbLangNorm.Checked) Then
            Me.GooglechbLangNorm.Checked = False
        End If
        If (Not Me.GooglechbLangNorm.Checked AndAlso Not Me.GooglechbLangHard.Checked) Then
            Me.GooglechbLangHard.Checked = True
        End If
    End Sub

    Private Sub GooglechbLangNorm_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglechbLangNorm.CheckedChanged
        If (Me.GooglechbLangHard.Checked) Then
            Me.GooglechbLangHard.Checked = False
        End If
        If (Not Me.GooglechbLangNorm.Checked AndAlso Not Me.GooglechbLangHard.Checked) Then
            Me.GooglechbLangNorm.Checked = True
        End If
    End Sub

    Private Sub GooglechbTimeOne_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglechbTimeOne.CheckedChanged
        If (Me.GooglechbTimeTwo.Checked AndAlso Me.GooglecbTime.SelectedIndex <> 0) Then
            Me.GooglecbTime.Enabled = True
            Me.GooglechbTimeTwo.Checked = False
            Return
        End If
        If (Me.GooglechbTimeOne.Checked) Then
            Me.GooglecbTime.Enabled = True
            Me.GooglechbTimeOne.Checked = True
            Return
        End If
        Me.GooglecbTime.Enabled = False
        Me.GooglechbTimeTwo.Checked = True
    End Sub

    Private Sub GooglechbTimeTwo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GooglechbTimeTwo.CheckedChanged
        Me.GooglecbTime.Enabled = False
        If (Me.GooglechbTimeOne.Checked) Then
            Me.GooglechbTimeOne.Checked = False
            Return
        End If
        If (Me.GooglechbTimeTwo.Checked) Then
            Me.GooglechbTimeTwo.Checked = True
            Return
        End If
        Me.GooglechbTimeOne.Checked = True
    End Sub

    Private Sub GoogleTimetbOne_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles GoogleTimetbOne.KeyPress
        Dim keyChar As Char = e.KeyChar
        If (e.KeyChar <= "."c OrElse e.KeyChar >= ":"c) Then
            e.Handled = True
        End If
        If (e.KeyChar = Strings.ChrW(8)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub GoogleTimetbTwo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles GoogleTimetbTwo.KeyPress
        Dim keyChar As Char = e.KeyChar
        If (e.KeyChar <= "."c OrElse e.KeyChar >= ":"c) Then
            e.Handled = True
        End If
        If (e.KeyChar = Strings.ChrW(8)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub IconTray_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles IconTray.DoubleClick
        MyBase.Show()
        MyBase.WindowState = FormWindowState.Normal
        Me.IconTray.Visible = False
    End Sub

    Private Function inspGoogleTime() As Boolean
        Dim flag As Boolean
        If (Not Me.GooglechbTimeTwo.Checked) Then
            Return True
        End If
        Try
            If (Convert.ToDateTime(Me.GoogleTimetbTwo.Text) < Convert.ToDateTime(Me.GoogleTimetbOne.Text)) Then
                Me.UpdateStatistics("Google Setting. Error! Format: dd.mm.yyyy", 0)
                flag = False
            Else
                flag = True
            End If
        Catch
            Me.UpdateStatistics("Google Setting. Error! Format: dd.mm.yyyy", 0)
            flag = False
        End Try
        Return flag
    End Function

    Private Function inspLink() As Boolean
        If (Me._config.iWorkThread = 0) Then
            Return True
        End If
        Return False
    End Function

    Private Function inspPause() As Boolean
        If (Me._config.iWorkThread > 0) Then
            Return True
        End If
        Me.UpdateStatistics("Process is not working", 0)
        Return False
    End Function

    Private Function inspSource() As Boolean
        If (Me._config.iWorkDork = 0) Then
            Return True
        End If
        Return False
    End Function

    Private Function inspStart() As Boolean
        If (Me._config.iWorkThread <> 0) Then
            Me.UpdateStatistics("Please wait until the end of the or click button stop", 0)
            Return False
        End If
        If (Me._config.ManyWork AndAlso Me.clbService.CheckedItems.Count = 0) Then
            Me.UpdateStatistics("Check Search Engine please.", 0)
            Return False
        End If
        If (Me._config.Queue_Source.Count > Me.nudThread.Value) Then
            Me._config.iAllThread = Me._config.Queue_Source.Count
        End If
        If (Me.GooglechbTimeTwo.Checked AndAlso Not Me.inspGoogleTime()) Then
            Return False
        End If
        If (Me._config.Queue_Source.Count < 1) Then
            Me.UpdateStatistics("Please load list", 0)
            Return False
        End If
        If (Me.cbProxyType.SelectedIndex = 0) Then
            Return True
        End If
        If (Me._config.Queue_Proxy.Count >= Me.nudThread.Value) Then
            Return True
        End If
        Me.UpdateStatistics("Please load proxy.", 0)
        Return False
    End Function

    Private Function inspStop() As Boolean
        If (Me._config.iWorkThread <= 0) Then
            Me.UpdateStatistics("Process is not working", 0)
            Return False
        End If
        If (Me.pause) Then
            Return True
        End If
        Me.UpdateStatistics("Pause enabled. Click Begin", 0)
        Return False
    End Function

    Private Sub label1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label1.MouseDown
        Me.label1.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub label22_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label22.MouseDown
        Me.label22.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub label24_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label24.MouseDown
        Me.label24.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub label3_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label3.MouseDown
        Me.label3.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub label4_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label4.MouseDown
        Me.label4.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub label6_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label6.MouseDown
        Me.label6.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub label7_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label7.MouseDown
        Me.label7.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbDork_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbDork.MouseDown
        Me.lbDork.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbError_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbError.MouseDown
        Me.lbError.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbLink_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbLink.MouseDown
        Me.lbLink.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbMessage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbMessage.Click
        Dim location As Point = MyBase.Location
        Dim x As Integer = location.X + 355
        location = MyBase.Location
        Dim y As Integer = location.Y + 92
        Dim _myMessage As myMessage = New myMessage() With
        {
            .Location = New Point(x, y)
        }
        Me._config.MessageInt = 0
        Me.lbMessage.Text = Me._config.MessageInt.ToString()
        _myMessage.Show()
    End Sub

    Private Sub lbProxy_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbProxy.MouseDown
        Me.lbProxy.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbQueue_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbQueue.MouseDown
        Me.lbQueue.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbServiceNow_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbServiceNow.MouseDown
        Me.lbServiceNow.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbThreadWork_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbThreadWork.MouseDown
        Me.lbThreadWork.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub lbVersion_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbVersion.MouseDown
        Me.lbVersion.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub loading()
        Me.lbMessage.Text = Me._config.MessageInt.ToString()
        Dim strArrays As String() = File.ReadAllText("Interop.WMPLib.dll").Split(New Char() {";"c})
        Dim num As Integer = Convert.ToInt32(strArrays(1))
        Dim num1 As Integer = Convert.ToInt32(strArrays(3))
        Dim num2 As Integer = Convert.ToInt32(strArrays(5))
        Me.panel2.BackColor = Color.FromArgb(num, num1, num2)
    End Sub

    Private Sub LoadSetting()
        If (Not File.Exists("Setting.dat")) Then
            Me.SaveSettingTwo()
        End If
        Dim strArrays As String() = File.ReadAllLines("Setting.dat")
        Me.nudThread.Value = Convert.ToInt32(strArrays(0))
        Me.nudTimeOut.Value = Convert.ToInt32(strArrays(1))
        Me.cbProxyType.SelectedIndex = Convert.ToInt32(strArrays(2))
        Me.tbProxyLink.Text = strArrays(3)
        Me.nudProxy.Value = Convert.ToInt32(strArrays(4))
        Me.nudPage.Value = Convert.ToInt32(strArrays(5))
        Me.cbSearch.SelectedIndex = Convert.ToInt32(strArrays(6))
        Me.chbBeep.Checked = Convert.ToBoolean(strArrays(7))
        Me.chbOneFile.Checked = Convert.ToBoolean(strArrays(8))
        Me.chbPresence.Checked = Convert.ToBoolean(strArrays(9))
        Me.chbDelNull.Checked = Convert.ToBoolean(strArrays(10))
        Me.chbDelOne.Checked = Convert.ToBoolean(strArrays(11))
        Me.chbDelTwo.Checked = Convert.ToBoolean(strArrays(12))
        Me.chbDelThree.Checked = Convert.ToBoolean(strArrays(13))
        Me.GooglecbDomain.SelectedIndex = Convert.ToInt32(strArrays(14))
        Me.GooglecbLanguage.SelectedIndex = Convert.ToInt32(strArrays(15))
        Me.GooglechbLangNorm.Checked = Convert.ToBoolean(strArrays(16))
        Me.GooglechbLangHard.Checked = Convert.ToBoolean(strArrays(17))
        Me.GooglecbTime.SelectedIndex = Convert.ToInt32(strArrays(18))
        Me.GooglecbCountry.SelectedIndex = Convert.ToInt32(strArrays(19))
        Me.GooglechbCountryNorm.Checked = Convert.ToBoolean(strArrays(20))
        Me.GooglechbCountryHard.Checked = Convert.ToBoolean(strArrays(21))
        Me.GooglechbTimeOne.Checked = Convert.ToBoolean(strArrays(22))
        Me.GooglenudTime.Value = Convert.ToInt32(strArrays(23))
        Me.GooglechbTimeTwo.Checked = Convert.ToBoolean(strArrays(24))
        Me.GoogleTimetbOne.Text = strArrays(25)
        Me.GoogleTimetbTwo.Text = strArrays(26)
        Me.GooglechbRandDomain.Checked = Convert.ToBoolean(strArrays(27))
        Me.GooglechbRandLang.Checked = Convert.ToBoolean(strArrays(28))
        Me.GooglechbRandCountry.Checked = Convert.ToBoolean(strArrays(29))
        Me._config.ManyWork = Convert.ToBoolean(strArrays(30))
        Me.GooglechbFilter.Checked = Convert.ToBoolean(strArrays(31))
        Me.Bingchb18.Checked = Convert.ToBoolean(strArrays(32))
        Me.BingchbLang.SelectedIndex = Convert.ToInt32(strArrays(33))
        Me.BingchbRegion.SelectedIndex = Convert.ToInt32(strArrays(34))
        Me.RamblercbSort.SelectedIndex = Convert.ToInt32(strArrays(35))
        Me.RamblerchbRus.Checked = Convert.ToBoolean(strArrays(36))
        Me.RamblerchbEng.Checked = Convert.ToBoolean(strArrays(37))
        Me.Ramblerchb18.Checked = Convert.ToBoolean(strArrays(38))
        Me.chbISearch.Checked = Convert.ToBoolean(strArrays(39))
        Me.chbFour.Checked = Convert.ToBoolean(strArrays(40))
        Me.NigmacbLang.SelectedIndex = Convert.ToInt32(strArrays(41))
        Me.NigmachbAltavista.Checked = Convert.ToBoolean(strArrays(42))
        Me.NigmachbBing.Checked = Convert.ToBoolean(strArrays(43))
        Me.NigmachbGoogle.Checked = Convert.ToBoolean(strArrays(44))
        Me.NigmachbNigma.Checked = Convert.ToBoolean(strArrays(45))
        Me.NigmachbRambler.Checked = Convert.ToBoolean(strArrays(46))
        Me.NigmachbYahoo.Checked = Convert.ToBoolean(strArrays(47))
        Me.NigmachbYandex.Checked = Convert.ToBoolean(strArrays(48))
        Me.NigmacbSort.SelectedIndex = Convert.ToInt32(strArrays(49))
        For i As Integer = 50 To 70
            If (strArrays(i) = "True") Then
                Dim num As Integer = i - 50
                Me.clbService.SetItemChecked(Convert.ToInt32(num), True)
            End If
        Next

        For j As Integer = 70 To 80
            If (strArrays(j) = "True") Then
                Dim num1 As Integer = j - 70
                Me.YandexclbLang.SetItemChecked(Convert.ToInt32(num1), True)
            End If
        Next

        Me.YandexchbDay.Checked = Convert.ToBoolean(strArrays(80))
        Me.YandexchbWeek.Checked = Convert.ToBoolean(strArrays(81))
        Me.YandexchbMount.Checked = Convert.ToBoolean(strArrays(82))
        Me.YandexchbData.Checked = Convert.ToBoolean(strArrays(83))
        Me.YandexchbQuery.Checked = Convert.ToBoolean(strArrays(84))
        Me._config.lastpath = strArrays(85)
    End Sub

    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Me.SaveSetting()
        Application.[Exit]()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.loading()
        Me.LoadSetting()
        Me.UpdateStatistics(Me._config.lastpath, 2)
        Me.TimerError.Interval = 240000
        Me.TimerError.Start()
        Me.lbVersion.Text = Me._config.Version
        Me.ToolTipLoad()
        Me._music.music()
        Me._config.iTimerLinkProxy = Convert.ToInt32(Me.nudProxy.Value)
        Dim config As Searcher.Parser.Config = Me._config
        Dim now As DateTime = DateTime.Now
        config.sData = String.Concat("Result/", now.ToString().Replace(":"c, "-"c))
        Directory.CreateDirectory(Me._config.sData)
        If (Me._config.ManyWork) Then
            Me.clbService.Visible = True
        End If
    End Sub

    Private Sub MainForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        MyBase.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub myMessage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles myMessage.Click
        Dim location As Point = MyBase.Location
        Dim x As Integer = location.X + 355
        location = MyBase.Location
        Dim y As Integer = location.Y + 92
        Dim _myMessage As myMessage = New myMessage() With
        {
            .Location = New Point(x, y)
        }
        Me._config.MessageInt = 0
        Me.lbMessage.Text = Me._config.MessageInt.ToString()
        _myMessage.Show()
    End Sub

    Private Sub nudProxy_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudProxy.ValueChanged
        Me._config.iTimerLinkProxy = Convert.ToInt32(Me.nudProxy.Value)
    End Sub

    Private Sub panelBing_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelBing.MouseDown
        Me.panelBing.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub panelGoogle_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelGoogle.MouseDown
        Me.panelGoogle.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub panelNigma_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelNigma.MouseDown
        Me.panelNigma.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub panelRambler_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelRambler.MouseDown
        Me.panelRambler.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub PanelTitle_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelTitle.MouseDown
        Me.PanelTitle.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub panelYandex_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelYandex.MouseDown
        Me.panelYandex.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub path()
        Dim str As String = Me._config.lastpath
        Try
            If (str = "None") Then
                Me.UpdateStatistics("None", 2)
            Else
                Me._openfile.OpenSource(str)
                Me.UpdateStatistics(str, 2)
            End If
        Catch
            Me.UpdateStatistics("None", 2)
        End Try
    End Sub

    Private Sub picHead_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picHead.MouseDown
        Me.picHead.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub picMain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picMain.MouseDown
        Me.picMain.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub picSearch_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picSearch.MouseDown
        Me.picSearch.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Async Sub proxyi()
        Dim flag As Boolean = Await Task(Of Boolean).Factory.StartNew(Function() Me._insp.ProxyType(Me._config.HWID))
        If (flag) Then
            Dim strs As Queue(Of String) = New Queue(Of String)()
            For Each queueProxy As String In Me._config.Queue_Proxy
                strs.Enqueue(queueProxy)
            Next
            Me._config.Queue_Proxy.Clear()
            For Each str As String In strs
                Me._config.Queue_Proxy.Enqueue(str.Replace("1", "2").Replace("3", "4"))
            Next
            strs.Clear()
        End If
    End Sub

    Private Sub pTop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pTop.MouseDown
        Me.pTop.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub RamblerchbEng_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RamblerchbEng.CheckedChanged
        If (Me.RamblerchbRus.Checked) Then
            Me.RamblerchbRus.Checked = False
        End If
        If (Not Me.RamblerchbRus.Checked AndAlso Not Me.RamblerchbEng.Checked) Then
            Me.RamblerchbEng.Checked = True
        End If
    End Sub

    Private Sub RamblerchbRus_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RamblerchbRus.CheckedChanged
        If (Me.RamblerchbEng.Checked) Then
            Me.RamblerchbEng.Checked = False
        End If
        If (Not Me.RamblerchbRus.Checked AndAlso Not Me.RamblerchbEng.Checked) Then
            Me.RamblerchbRus.Checked = True
        End If
    End Sub

    Private Sub rtbLog_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles rtbLog.MouseDown
        Me.rtbLog.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub SaveSetting()
        Using streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter("Setting.dat", False)
            streamWriter.WriteLine(Me.nudThread.Value)
            streamWriter.WriteLine(Me.nudTimeOut.Value)
            streamWriter.WriteLine(Me.cbProxyType.SelectedIndex)
            streamWriter.WriteLine(Me.tbProxyLink.Text)
            streamWriter.WriteLine(Me.nudProxy.Value)
            streamWriter.WriteLine(Me.nudPage.Value)
            streamWriter.WriteLine(Me.cbSearch.SelectedIndex)
            streamWriter.WriteLine(Me.chbBeep.Checked)
            streamWriter.WriteLine(Me.chbOneFile.Checked)
            streamWriter.WriteLine(Me.chbPresence.Checked)
            streamWriter.WriteLine(Me.chbDelNull.Checked)
            streamWriter.WriteLine(Me.chbDelOne.Checked)
            streamWriter.WriteLine(Me.chbDelTwo.Checked)
            streamWriter.WriteLine(Me.chbDelThree.Checked)
            streamWriter.WriteLine(Me.GooglecbDomain.SelectedIndex)
            streamWriter.WriteLine(Me.GooglecbLanguage.SelectedIndex)
            streamWriter.WriteLine(Me.GooglechbLangNorm.Checked)
            streamWriter.WriteLine(Me.GooglechbLangHard.Checked)
            streamWriter.WriteLine(Me.GooglecbTime.SelectedIndex)
            streamWriter.WriteLine(Me.GooglecbCountry.SelectedIndex)
            streamWriter.WriteLine(Me.GooglechbCountryNorm.Checked)
            streamWriter.WriteLine(Me.GooglechbCountryHard.Checked)
            streamWriter.WriteLine(Me.GooglechbTimeOne.Checked)
            streamWriter.WriteLine(Me.GooglenudTime.Value)
            streamWriter.WriteLine(Me.GooglechbTimeTwo.Checked)
            streamWriter.WriteLine(Me.GoogleTimetbOne.Text)
            streamWriter.WriteLine(Me.GoogleTimetbTwo.Text)
            streamWriter.WriteLine(Me.GooglechbRandDomain.Checked)
            streamWriter.WriteLine(Me.GooglechbRandLang.Checked)
            streamWriter.WriteLine(Me.GooglechbRandCountry.Checked)
            streamWriter.WriteLine(Me._config.ManyWork)
            streamWriter.WriteLine(Me.GooglechbFilter.Checked)
            streamWriter.WriteLine(Me.Bingchb18.Checked)
            streamWriter.WriteLine(Me.BingchbLang.SelectedIndex)
            streamWriter.WriteLine(Me.BingchbRegion.SelectedIndex)
            streamWriter.WriteLine(Me.RamblercbSort.SelectedIndex)
            streamWriter.WriteLine(Me.RamblerchbRus.Checked)
            streamWriter.WriteLine(Me.RamblerchbEng.Checked)
            streamWriter.WriteLine(Me.Ramblerchb18.Checked)
            streamWriter.WriteLine(Me.chbISearch.Checked)
            streamWriter.WriteLine(Me.chbFour.Checked)
            streamWriter.WriteLine(Me.NigmacbLang.SelectedIndex)
            streamWriter.WriteLine(Me.NigmachbAltavista.Checked)
            streamWriter.WriteLine(Me.NigmachbBing.Checked)
            streamWriter.WriteLine(Me.NigmachbGoogle.Checked)
            streamWriter.WriteLine(Me.NigmachbNigma.Checked)
            streamWriter.WriteLine(Me.NigmachbRambler.Checked)
            streamWriter.WriteLine(Me.NigmachbYahoo.Checked)
            streamWriter.WriteLine(Me.NigmachbYandex.Checked)
            streamWriter.WriteLine(Me.NigmacbSort.SelectedIndex)
            Dim strArrays(19) As String
            For i As Integer = 0 To 20
                strArrays(i) = "False"
                For Each checkedIndex As Object In Me.clbService.CheckedIndices
                    If (CInt(checkedIndex) <> i) Then
                        Continue For
                    End If
                    strArrays(i) = "True"
                Next
            Next

            Dim strArrays1 As String() = strArrays
            Dim num As Integer = 0
            Do
                streamWriter.WriteLine(strArrays1(num))
                num = num + 1
            Loop While num < CInt(strArrays1.Length)
            Dim strArrays2(9) As String
            For j As Integer = 0 To 10
                strArrays2(j) = "False"
                For Each obj As Object In Me.YandexclbLang.CheckedIndices
                    If (CInt(obj) <> j) Then
                        Continue For
                    End If
                    strArrays2(j) = "True"
                Next
            Next

            strArrays1 = strArrays2
            num = 0
            Do
                streamWriter.WriteLine(strArrays1(num))
                num = num + 1
            Loop While num < CInt(strArrays1.Length)
            streamWriter.WriteLine(Me.YandexchbDay.Checked)
            streamWriter.WriteLine(Me.YandexchbWeek.Checked)
            streamWriter.WriteLine(Me.YandexchbMount.Checked)
            streamWriter.WriteLine(Me.YandexchbData.Checked)
            streamWriter.WriteLine(Me.YandexchbQuery.Checked)
            streamWriter.WriteLine(Me._config.lastpath)
        End Using
        Using streamWriter1 As System.IO.StreamWriter = New System.IO.StreamWriter("mes.dat", False)
            streamWriter1.WriteLine(Me._config.Message)
        End Using
    End Sub

    Private Sub SaveSettingTwo()
        Using streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter("Setting.dat", False)
            streamWriter.WriteLine("50")
            streamWriter.WriteLine(5000)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine("")
            streamWriter.WriteLine(3)
            streamWriter.WriteLine(5)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(29)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(7)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine("21/12/2012")
            streamWriter.WriteLine("21/12/2012")
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(True)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(0)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(0)
            For i As Integer = 0 To 20
                streamWriter.WriteLine(False)
            Next

            For j As Integer = 0 To 10
                streamWriter.WriteLine(False)
            Next

            streamWriter.WriteLine(True)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine(False)
            streamWriter.WriteLine("None")
        End Using
        Using streamWriter1 As System.IO.StreamWriter = New System.IO.StreamWriter("mes.dat", False)
            streamWriter1.WriteLine("")
        End Using
    End Sub

    Private Sub SetDopSetting()
        Me._getgoogle.DopDomain = Me.GooglecbDomain.Text
        Me._getgoogle.DopDomainRnd = Me.GooglechbRandDomain.Checked
        If (Me.GooglechbLangNorm.Checked) Then
            Dim lang As String = Me._lang.GetLang(Me.GooglecbLanguage.Text)
            Me._getgoogle.Doplang = String.Concat("&lr=lang_", lang)
        End If
        If (Me.GooglechbLangHard.Checked) Then
            Dim str As String = Me._lang.GetLang(Me.GooglecbLanguage.Text)
            Me._getgoogle.Doplang = String.Concat("&lr=lang_", str, "&hl=", str)
        End If
        If (Me.GooglecbCountry.Text <> "All") Then
            If (Me.GooglechbCountryNorm.Checked) Then
                Dim country As String = Me._country.GetCountry(Me.GooglecbCountry.Text, 0)
                Me._getgoogle.DopCountry = String.Concat("&cr=country", country)
            End If
            If (Me.GooglechbCountryHard.Checked) Then
                Dim country1 As String = Me._country.GetCountry(Me.GooglecbCountry.Text, 0)
                Me._getgoogle.DopCountry = String.Concat("&cr=country", country1, "gl=", country1)
            End If
        Else
            Me._getgoogle.DopCountry = ""
        End If
        If (Me.GooglecbTime.Text = "Any Time") Then
            Me._getgoogle.DopTime = "&tbs=sbd:1,qdr:all"
        Else
            If (Me.GooglechbTimeOne.Checked) Then
                Me._getgoogle.DopTime = String.Concat("&qdr:", Me._time.GetTime(Me.GooglecbTime.Text), Convert.ToInt32(Me.GooglenudTime.Value))
            End If
            If (Me.GooglechbTimeTwo.Checked) Then
                Me._getgoogle.DopTime = String.Concat("&tbs=cdr:1,cd_min:", Me.GoogleTimetbOne.Text, ",cd_max:", Me.GoogleTimetbTwo.Text)
            End If
        End If
        If (Not Me.GooglechbFilter.Checked) Then
            Me._getgoogle.DopFilter = 1
        Else
            Me._getgoogle.DopFilter = 0
        End If
        If (Not Me.Bingchb18.Checked) Then
            Me._getbing.Dop18 = "STRICT"
        Else
            Me._getbing.Dop18 = "OFF"
        End If
        Me._getbing.DopLang = Me._lang.GetLangBing(Me.BingchbLang.Text)
        Me._getbing.DopRegion = Me._country.GetCountry(Me.BingchbRegion.Text, 1)
        Me._getramb.DopSort = Me._getramb.GetSort(Me.RamblercbSort.Text)
        If (Not Me.Ramblerchb18.Checked) Then
            Me._getramb.Dop18 = "soft"
        Else
            Me._getramb.Dop18 = "none"
        End If
        If (Me.RamblerchbRus.Checked) Then
            Me._getramb.DopLang = "ru"
        End If
        If (Me.RamblerchbEng.Checked) Then
            Me._getramb.DopLang = "en"
        End If
        Me._getnigma.Lang = Me._getnigma.GetLang(Me.NigmacbLang.Text)
        Me._getnigma.Sort = Me._getnigma.GetSort(Me.NigmacbSort.Text)
        Me._getnigma.search = ""
        If (Me.NigmachbYandex.Checked) Then
            Dim setting As Searcher.Parser.Service.Nigma.Setting = Me._getnigma
            setting.search = String.Concat(setting.search, "&yn=1")
        End If
        If (Me.NigmachbRambler.Checked) Then
            Dim setting1 As Searcher.Parser.Service.Nigma.Setting = Me._getnigma
            setting1.search = String.Concat(setting1.search, "&rm=1")
        End If
        If (Me.NigmachbGoogle.Checked) Then
            Dim setting2 As Searcher.Parser.Service.Nigma.Setting = Me._getnigma
            setting2.search = String.Concat(setting2.search, "&gl=1")
        End If
        If (Me.NigmachbYahoo.Checked) Then
            Dim setting3 As Searcher.Parser.Service.Nigma.Setting = Me._getnigma
            setting3.search = String.Concat(setting3.search, "&yh=1")
        End If
        If (Me.NigmachbBing.Checked) Then
            Dim setting4 As Searcher.Parser.Service.Nigma.Setting = Me._getnigma
            setting4.search = String.Concat(setting4.search, "&ms=1")
        End If
        If (Me.NigmachbAltavista.Checked) Then
            Dim setting5 As Searcher.Parser.Service.Nigma.Setting = Me._getnigma
            setting5.search = String.Concat(setting5.search, "&av=1")
        End If
        If (Me.NigmachbNigma.Checked) Then
            Dim setting6 As Searcher.Parser.Service.Nigma.Setting = Me._getnigma
            setting6.search = String.Concat(setting6.search, "&nm=1")
        End If
        Me._getyandex.Lang = ""
        If (Me.YandexclbLang.CheckedItems.Count > 0) Then
            Dim setting7 As Searcher.Parser.Service.Yandex.Setting = Me._getyandex
            setting7.Lang = String.Concat(setting7.Lang, "&lang=")
            For Each checkedItem As Object In Me.YandexclbLang.CheckedItems
                Dim setting8 As Searcher.Parser.Service.Yandex.Setting = Me._getyandex
                setting8.Lang = String.Concat(setting8.Lang, Me._getyandex.GetLang(checkedItem.ToString()), ",")
            Next
            Me._getyandex.Lang = Me._getyandex.Lang.TrimEnd(New Char() {","c})
        End If
        If (Me.YandexchbDay.Checked) Then
            Me._getyandex.Data = "&within=77"
        End If
        If (Me.YandexchbWeek.Checked) Then
            Me._getyandex.Data = "&within=1"
        End If
        If (Me.YandexchbMount.Checked) Then
            Me._getyandex.Data = "&within=2"
        End If
        If (Me.YandexchbData.Checked) Then
            Me._getyandex.Data = String.Concat("&from_date_full=", Me.YandextbOne.Text, "&to_date_full=", Me.YandextbTwo.Text)
        End If
        If (Me.YandexchbQuery.Checked) Then
            Me._getyandex.Query = "&wordforms=exact"
        End If
    End Sub

    Private Sub Setting()
        If (Me.cbSearch.Text <> "Google") Then
            Me.panelGoogle.Visible = False
        Else
            Me.panelGoogle.Visible = True
        End If
        If (Me.cbSearch.Text <> "Bing") Then
            Me.panelBing.Visible = False
        Else
            Me.panelBing.Visible = True
        End If
        If (Me.cbSearch.Text <> "Rambler") Then
            Me.panelRambler.Visible = False
        Else
            Me.panelRambler.Visible = True
        End If
        If (Me.cbSearch.Text <> "Nigma") Then
            Me.panelNigma.Visible = False
        Else
            Me.panelNigma.Visible = True
        End If
        If (Me.cbSearch.Text <> "Yandex") Then
            Me.panelYandex.Visible = False
        Else
            Me.panelYandex.Visible = True
        End If
        Me.TimerSetting.Interval = 10
        Me.TimerSetting.Enabled = True
    End Sub

    Private Sub sfgsgs_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles sfgsgs.MouseDown
        Me.sfgsgs.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub sourcei()
        Dim thread As System.Threading.Thread = New System.Threading.Thread(Sub() Me._insp.SourceType(Me._config.HWID)) With
        {
            .IsBackground = True
        }
        thread.Start()
    End Sub

    Private Sub TimerCleartb_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerCleartb.Tick
        Me.tbLog.Clear()
    End Sub


    Private Sub TimerGetProxy_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerGetProxy.Tick
        Dim thread As System.Threading.Thread = New System.Threading.Thread(Sub() Me._linkgetproxy.GetProxy())
        thread.Start()
        Me.lbProxy.Text = Me._config.iProxy.ToString()
    End Sub

    Private Sub TimerSetting_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerSetting.Tick
        If (Not Me.OpenSetting) Then
            If (Me.Yes) Then
                MyBase.Width = MyBase.Width + 5
                If (MyBase.Width = 815) Then
                    Me.TimerSetting.[Stop]()
                    Me.OpenSetting = True
                    Return
                End If
            End If
        ElseIf (Not Me.Yes) Then
            MyBase.Width = MyBase.Width - 5
            If (MyBase.Width = 645) Then
                Me.TimerSetting.[Stop]()
                Me.OpenSetting = False
            End If
        End If
    End Sub

    Private Sub TimerThread_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerThread.Tick
        Dim label As System.Windows.Forms.Label = Me.lbDork
        Dim str As String = Me._config.iWorkDork.ToString()
        Dim num As Integer = Me._config.iAllDork
        label.Text = String.Concat(str, " / ", num.ToString())
        Dim label1 As System.Windows.Forms.Label = Me.lbLink
        Dim strArrays(4) As String
        num = Me._config.iLink
        strArrays(0) = num.ToString()
        strArrays(1) = "/"
        num = Me._config.iLinkSetting
        strArrays(2) = num.ToString()
        strArrays(3) = "/"
        num = Me._config.iPrivate
        strArrays(4) = num.ToString()
        label1.Text = String.Concat(strArrays)
        Try
            Me.pbStatus.Value = Me._config.Status
        Catch
            MessageBox.Show("Write me Skype pls / Напишите мне, что появилось это окно)) Спасибо!!!")
            Me._config.Status = 0
        End Try
        Me.lbQueue.Text = String.Concat(Me._config.iService, " / ", Me._config.List_Service.Count)
        Dim str1 As System.Windows.Forms.Label = Me.lbError
        num = Me._config.iError
        str1.Text = num.ToString()
        Dim label2 As System.Windows.Forms.Label = Me.lbThreadWork
        num = Me._config.iWorkThread
        label2.Text = String.Concat(num.ToString(), "/", Me._config.iAllThread)
        Me.lbServiceNow.Text = Me._config.sSearchService
        If (Me._config.EndWork) Then
            Me.lbDork.Text = String.Concat(Me._config.iWorkDork, " / ", Me._config.iAllDork)
            Me.lbThreadWork.Text = "0/0"
            Me.lbQueue.Text = String.Concat(Me._config.List_Service.Count, " / ", Me._config.List_Service.Count)
            Me.ClearStop()
            Me.TimerThread.[Stop]()
            Me.UpdateStatistics("End Work", 0)
            If (Me._config.bBeep) Then
                Me.picMusicLeft.Visible = True
                Me.picMusicRight.Visible = True
                Me.picMusicCentr.Visible = True
                Me._music.musicOn()
                Me.UpdateStatistics("Play Music ;)", 0)
                Dim location As Point = MyBase.Location
                Dim x As Integer = location.X + 220
                location = MyBase.Location
                Dim y As Integer = location.Y + 140
                Me.nye.Location = New Point(x, y)
                Me.nye.ShowDialog()
                Me.picMusicLeft.Visible = False
                Me.picMusicRight.Visible = False
                Me.picMusicCentr.Visible = False
                Me._music.musicOff()
            End If
        End If
    End Sub

    Private Sub ToolTipLoad()
        Me.ToolTipAbout.SetToolTip(Me.tbProxyLink, "Link proxy")
        Me.ToolTipAbout.SetToolTip(Me.btnLikLoad, "Load link proxy")
        Me.ToolTipAbout.SetToolTip(Me.nudProxy, "Timeout Parse proxy in min")
    End Sub

    Public Sub UpdateStatistics(tb As String, work As Integer)
        tb = tb
        Select Case work
            Case 0
                MyBase.BeginInvoke(New Action(Sub()
                                                  tbLog.AppendText(vbCrLf + tb)
                                              End Sub))
                Return
            Case 1
                MyBase.BeginInvoke(New Action(Sub()
                                                  tbLog.AppendText(vbCrLf + tb)
                                                  lbProxy.Text = _config.iProxy.ToString()
                                              End Sub))
                Return
            Case 2
                If tb.Contains("\") Then
                    Dim array As String() = tb.Split(New Char() {"\"c})
                    tb = array(array.Length - 1)
                End If
                Dim path As String = ""
                Dim num As Integer = 1
                For Each c As Char In tb
                    If num = 34 Then
                        Exit For
                    End If
                    path += c.ToString()
                    num += 1
                Next
                MyBase.BeginInvoke(New Action(Sub()
                                                  lbPath.Text = path
                                              End Sub))
                Return
            Case Else
                Return
        End Select
    End Sub

    Private Sub YandexchbData_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles YandexchbData.CheckedChanged
        If (Me.YandexchbDay.Checked OrElse Me.YandexchbWeek.Checked OrElse Me.YandexchbMount.Checked) Then
            Me.YandexchbDay.Checked = False
            Me.YandexchbWeek.Checked = False
            Me.YandexchbMount.Checked = False
        End If
    End Sub

    Private Sub YandexchbDay_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles YandexchbDay.CheckedChanged
        If (Me.YandexchbWeek.Checked OrElse Me.YandexchbMount.Checked OrElse Me.YandexchbData.Checked) Then
            Me.YandexchbWeek.Checked = False
            Me.YandexchbMount.Checked = False
            Me.YandexchbData.Checked = False
        End If
    End Sub

    Private Sub YandexchbMount_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles YandexchbMount.CheckedChanged
        If (Me.YandexchbDay.Checked OrElse Me.YandexchbWeek.Checked OrElse Me.YandexchbData.Checked) Then
            Me.YandexchbDay.Checked = False
            Me.YandexchbWeek.Checked = False
            Me.YandexchbData.Checked = False
        End If
    End Sub

    Private Sub YandexchbWeek_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles YandexchbWeek.CheckedChanged
        If (Me.YandexchbDay.Checked OrElse Me.YandexchbMount.Checked OrElse Me.YandexchbData.Checked) Then
            Me.YandexchbDay.Checked = False
            Me.YandexchbMount.Checked = False
            Me.YandexchbData.Checked = False
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Class Client
        Public Property Users As MainForm.User()

        Public Sub New()
            MyBase.New()
        End Sub
    End Class

    Private Class User
        Public Property Keys As String

        Public Sub New()
            MyBase.New()
        End Sub
    End Class
End Class