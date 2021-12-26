Imports System.ComponentModel
Imports Control

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.label1 = New System.Windows.Forms.Label()
        Me.sfgsgs = New System.Windows.Forms.Label()
        Me.lbError = New System.Windows.Forms.Label()
        Me.lbProxy = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lbThreadWork = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.TimerSetting = New System.Windows.Forms.Timer(Me.components)
        Me.nudTimeOut = New System.Windows.Forms.NumericUpDown()
        Me.nudThread = New System.Windows.Forms.NumericUpDown()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.tbProxyLink = New System.Windows.Forms.TextBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.lbServiceNow = New System.Windows.Forms.Label()
        Me.lbQueue = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.lbLink = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lbDork = New System.Windows.Forms.Label()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label8 = New System.Windows.Forms.Label()
        Me.nudPage = New System.Windows.Forms.NumericUpDown()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbProxyType = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.nudProxy = New System.Windows.Forms.NumericUpDown()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.TimerThread = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGetProxy = New System.Windows.Forms.Timer(Me.components)
        Me.btnLikLoad = New System.Windows.Forms.Button()
        Me.ToolTipAbout = New System.Windows.Forms.ToolTip(Me.components)
        Me.IconTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.chbBeep = New System.Windows.Forms.CheckBox()
        Me.chbOneFile = New System.Windows.Forms.CheckBox()
        Me.chbDelOne = New System.Windows.Forms.CheckBox()
        Me.chbDelNull = New System.Windows.Forms.CheckBox()
        Me.chbPresence = New System.Windows.Forms.CheckBox()
        Me.chbDelTwo = New System.Windows.Forms.CheckBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.chbDelThree = New System.Windows.Forms.CheckBox()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.label21 = New System.Windows.Forms.Label()
        Me.GooglecbDomain = New System.Windows.Forms.ComboBox()
        Me.GooglecbLanguage = New System.Windows.Forms.ComboBox()
        Me.GooglecbCountry = New System.Windows.Forms.ComboBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.GooglecbTime = New System.Windows.Forms.ComboBox()
        Me.GooglechbFilter = New System.Windows.Forms.CheckBox()
        Me.TimerError = New System.Windows.Forms.Timer(Me.components)
        Me.label16 = New System.Windows.Forms.Label()
        Me.chbBlackList = New System.Windows.Forms.CheckBox()
        Me.TimerCleartb = New System.Windows.Forms.Timer(Me.components)
        Me.chbWhiteList = New System.Windows.Forms.CheckBox()
        Me.panelGoogle = New System.Windows.Forms.Panel()
        Me.GooglechbCountryHard = New System.Windows.Forms.CheckBox()
        Me.GooglechbCountryNorm = New System.Windows.Forms.CheckBox()
        Me.GooglechbLangHard = New System.Windows.Forms.CheckBox()
        Me.GooglechbLangNorm = New System.Windows.Forms.CheckBox()
        Me.GooglechbRandCountry = New System.Windows.Forms.CheckBox()
        Me.GooglechbRandLang = New System.Windows.Forms.CheckBox()
        Me.GooglechbRandDomain = New System.Windows.Forms.CheckBox()
        Me.GooglechbTimeTwo = New System.Windows.Forms.CheckBox()
        Me.GooglechbTimeOne = New System.Windows.Forms.CheckBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.GoogleTimetbTwo = New System.Windows.Forms.TextBox()
        Me.GoogleTimetbOne = New System.Windows.Forms.TextBox()
        Me.GooglenudTime = New System.Windows.Forms.NumericUpDown()
        Me.panelBing = New System.Windows.Forms.Panel()
        Me.label18 = New System.Windows.Forms.Label()
        Me.BingchbRegion = New System.Windows.Forms.ComboBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.BingchbLang = New System.Windows.Forms.ComboBox()
        Me.Bingchb18 = New System.Windows.Forms.CheckBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.clbService = New System.Windows.Forms.CheckedListBox()
        Me.btnMany = New System.Windows.Forms.Button()
        Me.panelRambler = New System.Windows.Forms.Panel()
        Me.RamblerchbEng = New System.Windows.Forms.CheckBox()
        Me.RamblerchbRus = New System.Windows.Forms.CheckBox()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.RamblercbSort = New System.Windows.Forms.ComboBox()
        Me.Ramblerchb18 = New System.Windows.Forms.CheckBox()
        Me.rtbLog = New Control.ViewOnlyRichTextBox()
        Me.chbISearch = New System.Windows.Forms.CheckBox()
        Me.panelNigma = New System.Windows.Forms.Panel()
        Me.NigmacbSort = New System.Windows.Forms.ComboBox()
        Me.label28 = New System.Windows.Forms.Label()
        Me.NigmachbBing = New System.Windows.Forms.CheckBox()
        Me.NigmachbNigma = New System.Windows.Forms.CheckBox()
        Me.NigmachbAltavista = New System.Windows.Forms.CheckBox()
        Me.NigmachbYahoo = New System.Windows.Forms.CheckBox()
        Me.NigmachbRambler = New System.Windows.Forms.CheckBox()
        Me.NigmachbGoogle = New System.Windows.Forms.CheckBox()
        Me.NigmachbYandex = New System.Windows.Forms.CheckBox()
        Me.label26 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.NigmacbLang = New System.Windows.Forms.ComboBox()
        Me.chbFour = New System.Windows.Forms.CheckBox()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label32 = New System.Windows.Forms.Label()
        Me.panelYandex = New System.Windows.Forms.Panel()
        Me.YandexchbQuery = New System.Windows.Forms.CheckBox()
        Me.label33 = New System.Windows.Forms.Label()
        Me.YandextbTwo = New System.Windows.Forms.TextBox()
        Me.YandextbOne = New System.Windows.Forms.TextBox()
        Me.YandexchbData = New System.Windows.Forms.CheckBox()
        Me.YandexchbMount = New System.Windows.Forms.CheckBox()
        Me.YandexchbWeek = New System.Windows.Forms.CheckBox()
        Me.YandexchbDay = New System.Windows.Forms.CheckBox()
        Me.YandexclbLang = New System.Windows.Forms.CheckedListBox()
        Me.label35 = New System.Windows.Forms.Label()
        Me.chbAntiPublic = New System.Windows.Forms.CheckBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.lbPath = New System.Windows.Forms.Label()
        Me.btnClose = New Control.MyButton()
        Me.btnTray = New Control.MyButton()
        Me.btnDirectory = New Control.MyButton()
        Me.btnStart = New Control.MyButton()
        Me.btnStop = New Control.MyButton()
        Me.btnPause = New Control.MyButton()
        Me.btnProxy = New Control.MyButton()
        Me.btnOpen = New Control.MyButton()
        Me.picMusicCentr = New System.Windows.Forms.PictureBox()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.picMusicRight = New System.Windows.Forms.PictureBox()
        Me.picMusicLeft = New System.Windows.Forms.PictureBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSetting = New Control.MyButton()
        Me.myMessage = New Control.MyButton()
        Me.btnChange = New Control.MyButton()
        Me.picHead = New System.Windows.Forms.PictureBox()
        CType(Me.nudTimeOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.nudPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProxy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTop.SuspendLayout()
        Me.panelGoogle.SuspendLayout()
        CType(Me.GooglenudTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBing.SuspendLayout()
        Me.panelRambler.SuspendLayout()
        Me.panelNigma.SuspendLayout()
        Me.panelYandex.SuspendLayout()
        CType(Me.picMusicCentr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMusicRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMusicLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(242, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Parsing:"
        '
        'sfgsgs
        '
        Me.sfgsgs.AutoSize = True
        Me.sfgsgs.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.sfgsgs.Location = New System.Drawing.Point(255, 64)
        Me.sfgsgs.Name = "sfgsgs"
        Me.sfgsgs.Size = New System.Drawing.Size(35, 13)
        Me.sfgsgs.TabIndex = 8
        Me.sfgsgs.Text = "Error:"
        '
        'lbError
        '
        Me.lbError.AutoSize = True
        Me.lbError.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbError.Location = New System.Drawing.Point(293, 65)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(13, 13)
        Me.lbError.TabIndex = 12
        Me.lbError.Text = "0"
        '
        'lbProxy
        '
        Me.lbProxy.AutoSize = True
        Me.lbProxy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbProxy.Location = New System.Drawing.Point(293, 20)
        Me.lbProxy.Name = "lbProxy"
        Me.lbProxy.Size = New System.Drawing.Size(13, 13)
        Me.lbProxy.TabIndex = 10
        Me.lbProxy.Text = "0"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label3.Location = New System.Drawing.Point(251, 20)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Proxy:"
        '
        'lbThreadWork
        '
        Me.lbThreadWork.AutoSize = True
        Me.lbThreadWork.ForeColor = System.Drawing.Color.White
        Me.lbThreadWork.Location = New System.Drawing.Point(494, 65)
        Me.lbThreadWork.Name = "lbThreadWork"
        Me.lbThreadWork.Size = New System.Drawing.Size(23, 13)
        Me.lbThreadWork.TabIndex = 11
        Me.lbThreadWork.Text = "0/0"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(451, 65)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(45, 13)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Thread:"
        '
        'tbLog
        '
        Me.tbLog.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbLog.Location = New System.Drawing.Point(3, 271)
        Me.tbLog.Multiline = True
        Me.tbLog.Name = "tbLog"
        Me.tbLog.ReadOnly = True
        Me.tbLog.Size = New System.Drawing.Size(195, 102)
        Me.tbLog.TabIndex = 0
        '
        'nudTimeOut
        '
        Me.nudTimeOut.Location = New System.Drawing.Point(142, 192)
        Me.nudTimeOut.Maximum = New Decimal(New Integer() {25000, 0, 0, 0})
        Me.nudTimeOut.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudTimeOut.Name = "nudTimeOut"
        Me.nudTimeOut.Size = New System.Drawing.Size(52, 20)
        Me.nudTimeOut.TabIndex = 7
        Me.nudTimeOut.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'nudThread
        '
        Me.nudThread.Location = New System.Drawing.Point(50, 192)
        Me.nudThread.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudThread.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudThread.Name = "nudThread"
        Me.nudThread.Size = New System.Drawing.Size(42, 20)
        Me.nudThread.TabIndex = 8
        Me.nudThread.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(6, 194)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(45, 13)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Thread:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(92, 194)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(51, 13)
        Me.label11.TabIndex = 10
        Me.label11.Text = "TimeOut:"
        '
        'tbProxyLink
        '
        Me.tbProxyLink.Location = New System.Drawing.Point(41, 245)
        Me.tbProxyLink.Name = "tbProxyLink"
        Me.tbProxyLink.Size = New System.Drawing.Size(115, 20)
        Me.tbProxyLink.TabIndex = 13
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.pictureBox1)
        Me.PanelTitle.Controls.Add(Me.btnSetting)
        Me.PanelTitle.Controls.Add(Me.lbMessage)
        Me.PanelTitle.Controls.Add(Me.myMessage)
        Me.PanelTitle.Controls.Add(Me.btnChange)
        Me.PanelTitle.Controls.Add(Me.label24)
        Me.PanelTitle.Controls.Add(Me.lbServiceNow)
        Me.PanelTitle.Controls.Add(Me.lbQueue)
        Me.PanelTitle.Controls.Add(Me.label22)
        Me.PanelTitle.Controls.Add(Me.lbLink)
        Me.PanelTitle.Controls.Add(Me.label4)
        Me.PanelTitle.Controls.Add(Me.lbDork)
        Me.PanelTitle.Controls.Add(Me.lbThreadWork)
        Me.PanelTitle.Controls.Add(Me.label7)
        Me.PanelTitle.Controls.Add(Me.picHead)
        Me.PanelTitle.Controls.Add(Me.lbError)
        Me.PanelTitle.Controls.Add(Me.pbStatus)
        Me.PanelTitle.Controls.Add(Me.label1)
        Me.PanelTitle.Controls.Add(Me.lbProxy)
        Me.PanelTitle.Controls.Add(Me.label3)
        Me.PanelTitle.Controls.Add(Me.sfgsgs)
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(645, 86)
        Me.PanelTitle.TabIndex = 18
        '
        'lbMessage
        '
        Me.lbMessage.AutoSize = True
        Me.lbMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbMessage.ForeColor = System.Drawing.Color.Black
        Me.lbMessage.Location = New System.Drawing.Point(561, 47)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(13, 13)
        Me.lbMessage.TabIndex = 92
        Me.lbMessage.Text = "0"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.ForeColor = System.Drawing.Color.White
        Me.label24.Location = New System.Drawing.Point(349, 50)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(115, 13)
        Me.label24.TabIndex = 35
        Me.label24.Text = "------------------------->"
        '
        'lbServiceNow
        '
        Me.lbServiceNow.AutoSize = True
        Me.lbServiceNow.ForeColor = System.Drawing.Color.Orange
        Me.lbServiceNow.Location = New System.Drawing.Point(451, 50)
        Me.lbServiceNow.Name = "lbServiceNow"
        Me.lbServiceNow.Size = New System.Drawing.Size(32, 13)
        Me.lbServiceNow.TabIndex = 34
        Me.lbServiceNow.Text = "None"
        '
        'lbQueue
        '
        Me.lbQueue.AutoSize = True
        Me.lbQueue.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbQueue.Location = New System.Drawing.Point(293, 50)
        Me.lbQueue.Name = "lbQueue"
        Me.lbQueue.Size = New System.Drawing.Size(29, 13)
        Me.lbQueue.TabIndex = 33
        Me.lbQueue.Text = "0 / 0"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.ForeColor = System.Drawing.Color.White
        Me.label22.Location = New System.Drawing.Point(245, 50)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(43, 13)
        Me.label22.TabIndex = 32
        Me.label22.Text = "Queue:"
        '
        'lbLink
        '
        Me.lbLink.AutoSize = True
        Me.lbLink.ForeColor = System.Drawing.Color.White
        Me.lbLink.Location = New System.Drawing.Point(293, 35)
        Me.lbLink.Name = "lbLink"
        Me.lbLink.Size = New System.Drawing.Size(33, 13)
        Me.lbLink.TabIndex = 28
        Me.lbLink.Text = "0/0/0"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(257, 35)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(29, 13)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Link:"
        '
        'lbDork
        '
        Me.lbDork.AutoSize = True
        Me.lbDork.ForeColor = System.Drawing.Color.White
        Me.lbDork.Location = New System.Drawing.Point(293, 5)
        Me.lbDork.Name = "lbDork"
        Me.lbDork.Size = New System.Drawing.Size(29, 13)
        Me.lbDork.TabIndex = 23
        Me.lbDork.Text = "0 / 0"
        '
        'pbStatus
        '
        Me.pbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbStatus.Location = New System.Drawing.Point(0, 81)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(645, 5)
        Me.pbStatus.TabIndex = 5
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(545, 90)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1, 1)
        Me.panel2.TabIndex = 45
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label8.ForeColor = System.Drawing.Color.Gold
        Me.label8.Location = New System.Drawing.Point(205, 120)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(35, 13)
        Me.label8.TabIndex = 30
        Me.label8.Text = "Page:"
        '
        'nudPage
        '
        Me.nudPage.Location = New System.Drawing.Point(243, 118)
        Me.nudPage.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPage.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPage.Name = "nudPage"
        Me.nudPage.Size = New System.Drawing.Size(45, 20)
        Me.nudPage.TabIndex = 29
        Me.nudPage.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbSearch
        '
        Me.cbSearch.DropDownHeight = 150
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.IntegralHeight = False
        Me.cbSearch.Items.AddRange(New Object() {"Google", "Rambler", "Amazon", "Yandex", "Ecosia", "Yahoo", "Bing", "AOL", "Teoma", "Nigma", "Ask", "Orange", "WOW", "MyWebSearch", "GoTo", "Search", "Hotbot", "StartPage", "ZenSearch", "Bravica", "Mail"})
        Me.cbSearch.Location = New System.Drawing.Point(531, 94)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(109, 21)
        Me.cbSearch.TabIndex = 23
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.ForeColor = System.Drawing.Color.PaleGreen
        Me.lbVersion.Location = New System.Drawing.Point(74, 377)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(43, 13)
        Me.lbVersion.TabIndex = 25
        Me.lbVersion.Text = "1.0.0.0"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(5, 377)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(69, 13)
        Me.label6.TabIndex = 24
        Me.label6.Text = "Last Version:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(6, 221)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Proxy Type:"
        '
        'cbProxyType
        '
        Me.cbProxyType.BackColor = System.Drawing.Color.White
        Me.cbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProxyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProxyType.FormattingEnabled = True
        Me.cbProxyType.Items.AddRange(New Object() {"None", "HTTP", "Socks4", "Socks5"})
        Me.cbProxyType.Location = New System.Drawing.Point(69, 218)
        Me.cbProxyType.Name = "cbProxyType"
        Me.cbProxyType.Size = New System.Drawing.Size(125, 21)
        Me.cbProxyType.TabIndex = 20
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.label5.Location = New System.Drawing.Point(560, 377)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(84, 13)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Created by Zurr"
        '
        'nudProxy
        '
        Me.nudProxy.Location = New System.Drawing.Point(162, 245)
        Me.nudProxy.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudProxy.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudProxy.Name = "nudProxy"
        Me.nudProxy.Size = New System.Drawing.Size(32, 20)
        Me.nudProxy.TabIndex = 22
        Me.nudProxy.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.panel1.Location = New System.Drawing.Point(646, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1, 390)
        Me.panel1.TabIndex = 23
        '
        'btnLikLoad
        '
        Me.btnLikLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLikLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLikLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLikLoad.Location = New System.Drawing.Point(9, 245)
        Me.btnLikLoad.Name = "btnLikLoad"
        Me.btnLikLoad.Size = New System.Drawing.Size(27, 20)
        Me.btnLikLoad.TabIndex = 26
        Me.btnLikLoad.Text = "Ok"
        Me.btnLikLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLikLoad.UseVisualStyleBackColor = False
        '
        'IconTray
        '
        Me.IconTray.Icon = CType(resources.GetObject("IconTray.Icon"), System.Drawing.Icon)
        Me.IconTray.Text = "Searcher"
        '
        'chbBeep
        '
        Me.chbBeep.AutoSize = True
        Me.chbBeep.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbBeep.ForeColor = System.Drawing.Color.White
        Me.chbBeep.Location = New System.Drawing.Point(205, 160)
        Me.chbBeep.Name = "chbBeep"
        Me.chbBeep.Size = New System.Drawing.Size(50, 17)
        Me.chbBeep.TabIndex = 36
        Me.chbBeep.Text = "Beep"
        Me.chbBeep.UseVisualStyleBackColor = False
        '
        'chbOneFile
        '
        Me.chbOneFile.AutoSize = True
        Me.chbOneFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbOneFile.ForeColor = System.Drawing.Color.White
        Me.chbOneFile.Location = New System.Drawing.Point(205, 140)
        Me.chbOneFile.Name = "chbOneFile"
        Me.chbOneFile.Size = New System.Drawing.Size(63, 17)
        Me.chbOneFile.TabIndex = 37
        Me.chbOneFile.Text = "One file"
        Me.chbOneFile.UseVisualStyleBackColor = False
        '
        'chbDelOne
        '
        Me.chbDelOne.AutoSize = True
        Me.chbDelOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbDelOne.ForeColor = System.Drawing.Color.White
        Me.chbDelOne.Location = New System.Drawing.Point(205, 260)
        Me.chbDelOne.Name = "chbDelOne"
        Me.chbDelOne.Size = New System.Drawing.Size(53, 17)
        Me.chbDelOne.TabIndex = 38
        Me.chbDelOne.Text = "srting"
        Me.chbDelOne.UseVisualStyleBackColor = False
        '
        'chbDelNull
        '
        Me.chbDelNull.AutoSize = True
        Me.chbDelNull.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbDelNull.ForeColor = System.Drawing.Color.White
        Me.chbDelNull.Location = New System.Drawing.Point(205, 200)
        Me.chbDelNull.Name = "chbDelNull"
        Me.chbDelNull.Size = New System.Drawing.Size(96, 17)
        Me.chbDelNull.TabIndex = 39
        Me.chbDelNull.Text = "Delete null site"
        Me.chbDelNull.UseVisualStyleBackColor = False
        '
        'chbPresence
        '
        Me.chbPresence.AutoSize = True
        Me.chbPresence.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbPresence.ForeColor = System.Drawing.Color.White
        Me.chbPresence.Location = New System.Drawing.Point(205, 180)
        Me.chbPresence.Name = "chbPresence"
        Me.chbPresence.Size = New System.Drawing.Size(86, 17)
        Me.chbPresence.TabIndex = 40
        Me.chbPresence.Text = "Presence (?)"
        Me.chbPresence.UseVisualStyleBackColor = False
        '
        'chbDelTwo
        '
        Me.chbDelTwo.AutoSize = True
        Me.chbDelTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbDelTwo.ForeColor = System.Drawing.Color.Orange
        Me.chbDelTwo.Location = New System.Drawing.Point(276, 260)
        Me.chbDelTwo.Name = "chbDelTwo"
        Me.chbDelTwo.Size = New System.Drawing.Size(44, 17)
        Me.chbDelTwo.TabIndex = 41
        Me.chbDelTwo.Text = "to="
        Me.chbDelTwo.UseVisualStyleBackColor = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(318, 261)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(18, 15)
        Me.label9.TabIndex = 42
        Me.label9.Text = "or"
        '
        'chbDelThree
        '
        Me.chbDelThree.AutoSize = True
        Me.chbDelThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbDelThree.ForeColor = System.Drawing.Color.DarkCyan
        Me.chbDelThree.Location = New System.Drawing.Point(337, 260)
        Me.chbDelThree.Name = "chbDelThree"
        Me.chbDelThree.Size = New System.Drawing.Size(43, 17)
        Me.chbDelThree.TabIndex = 43
        Me.chbDelThree.Text = "site"
        Me.chbDelThree.UseVisualStyleBackColor = False
        '
        'pTop
        '
        Me.pTop.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pTop.Controls.Add(Me.label21)
        Me.pTop.Location = New System.Drawing.Point(646, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(171, 86)
        Me.pTop.TabIndex = 50
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label21.ForeColor = System.Drawing.Color.SeaShell
        Me.label21.Location = New System.Drawing.Point(5, 32)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(165, 29)
        Me.label21.TabIndex = 72
        Me.label21.Text = "Setting Parser"
        '
        'GooglecbDomain
        '
        Me.GooglecbDomain.DropDownHeight = 150
        Me.GooglecbDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GooglecbDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GooglecbDomain.FormattingEnabled = True
        Me.GooglecbDomain.IntegralHeight = False
        Me.GooglecbDomain.Items.AddRange(New Object() {"google.com", "google.ru", "google.com.ua", "google.de", "google.fr", "google.ac", "google.ad", "google.ae", "google.com.af", "google.com.ag", "google.com.ai", "google.al", "google.am", "google.co.ao", "google.com.ar", "google.as", "google.at", "google.com.au", "google.az", "google.ba", "google.com.bd", "google.be", "google.bf", "google.bg", "google.com.bh", "google.bi", "google.bj", "google.com.bn", "google.com.bo", "google.com.br", "google.bs", "google.co.bw", "google.by", "google.com.bz", "google.ca", "google.com.kh", "google.cc", "google.cd", "google.cf", "google.cat", "google.cg", "google.ch", "google.ci", "google.co.ck", "google.cl", "google.cm", "google.cn", "google.com.co", "google.co.cr", "google.com.cu", "google.cv", "google.com.cy", "google.cz", "google.dj", "google.dk", "google.dm", "google.com.do", "google.dz", "google.com.ec", "google.ee", "google.com.eg", "google.es", "google.com.et", "google.fi", "google.com.fj", "google.fm", "google.ga", "google.ge", "google.gf", "google.gg", "google.com.gh", "google.com.gi", "google.gl", "google.gm", "google.gp", "google.gr", "google.com.gt", "google.gy", "google.com.hk", "google.hn", "google.hr", "google.ht", "google.hu", "google.co.id", "google.iq", "google.ie", "google.co.il", "google.im", "google.co.in", "google.io", "google.is", "google.it", "google.je", "google.com.jm", "google.jo", "google.co.jp", "google.co.ke", "google.com.kh", "google.ki", "google.kg", "google.co.kr", "google.com.kw", "google.kz", "google.la", "google.com.lb", "google.com.lc", "google.li", "google.lk", "google.co.ls", "google.lt", "google.lu", "google.lv", "google.com.ly", "google.co.ma", "google.md", "google.me", "google.mg", "google.mk", "google.ml", "google.mn", "google.ms", "google.com.mt", "google.mu", "google.mv", "google.mw", "google.com.mx", "google.com.my", "google.co.mz", "google.com.na", "google.ne", "google.com.nf", "google.com.ng", "google.com.ni", "google.nl", "google.no", "google.com.np", "google.nr", "google.nu", "google.co.nz", "google.com.om", "google.com.pa", "google.com.pe", "google.com.ph", "google.com.pk", "google.pl", "google.com.pg", "google.pn", "google.com.pr", "google.ps", "google.pt", "google.com.py", "google.com.qa", "google.ro", "google.rs", "google.rw", "google.com.sa", "google.com.sb", "google.sc", "google.se", "google.com.sg", "google.sh", "google.si", "google.sk", "google.com.sl", "google.sn", "google.sm", "google.so", "google.st", "google.com.sv", "google.td", "google.tg", "google.co.th", "google.com.tj", "google.tk", "google.tl", "google.tm", "google.to", "google.com.tn", "google.com.tr", "google.tt", "google.com.tw", "google.co.tz", "google.co.ug", "google.co.uk", "google.us", "google.com.uy", "google.co.uz", "google.com.vc", "google.co.ve", "google.vg", "google.co.vi", "google.com.vn", "google.vu", "google.ws", "google.co.za", "google.co.zm", "google.co.zw", "google.com.mm"})
        Me.GooglecbDomain.Location = New System.Drawing.Point(3, 17)
        Me.GooglecbDomain.Name = "GooglecbDomain"
        Me.GooglecbDomain.Size = New System.Drawing.Size(159, 21)
        Me.GooglecbDomain.TabIndex = 32
        '
        'GooglecbLanguage
        '
        Me.GooglecbLanguage.DropDownHeight = 150
        Me.GooglecbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GooglecbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GooglecbLanguage.FormattingEnabled = True
        Me.GooglecbLanguage.IntegralHeight = False
        Me.GooglecbLanguage.Items.AddRange(New Object() {"(Afan) Oromo", "Abkhazian", "Afar", "Afrikaans", "Albanian", "Amharic", "Arabic", "Armenian", "Assamese", "Aymara", "Azerbaijani", "Bashkir", "Basque", "Bengali", "Bhutani", "Bihari", "Bislama", "Breton", "Bulgarian", "Burmese", "Byelorussian", "Cambodian", "Catalan", "Chinese", "Corsican", "Croatian", "Czech", "Danish", "Dutch", "English", "Esperanto", "Estonian", "Faeroese", "Fiji", "Finnish", "French", "Frisian", "Galician", "Georgian", "German", "Greek", "Greenlandic", "Guarani", "Gujarati", "Hausa", "Hebrew (former iw)", "Hindi", "Hungarian", "Icelandic", "Indonesian (former in)", "Interlingua", "Interlingue", "Inupiak", "Inuktitut (Eskimo)", "Irish", "Italian", "Japanese", "Javanese", "Kannada", "Kashmiri", "Kazakh", "Kinyarwanda", "Kirghiz", "Kirundi", "Korean", "Kurdish", "Laothian", "Latin", "Latvian, Lettish", "Lingala", "Lithuanian", "Macedonian", "Malagasy", "Malay", "Malayalam", "Maltese", "Maori", "Marathi", "Moldavian", "Mongolian", "Nauru", "Nepali", "Norwegian", "Occitan", "Oriya", "Pashto, Pushto", "Persian", "Polish", "Portuguese", "Punjabi", "Quechua", "Rhaeto-Romance", "Romanian", "Russian", "Samoan", "Sangro", "Sanskrit", "Scots Gaelic", "Serbian", "Serbo-Croatian", "Sesotho", "Setswana", "Shona", "Sindhi", "Singhalese", "Siswati", "Slovak", "Slovenian", "Somali", "Spanish", "Sudanese", "Swahili", "Swedish", "Tagalog", "Tajik", "Tamil", "Tatar", "Tegulu", "Thai", "Tibetan", "Tigrinya", "Tonga", "Tsonga", "Turkish", "Turkmen", "Twi", "Uigur", "Ukrainian", "Urdu", "Uzbek", "Vietnamese", "Volapuk", "Welch", "Wolof", "Xhosa", "Yiddish (former ji)", "Yoruba", "Zhuang", "Zulu"})
        Me.GooglecbLanguage.Location = New System.Drawing.Point(3, 71)
        Me.GooglecbLanguage.Name = "GooglecbLanguage"
        Me.GooglecbLanguage.Size = New System.Drawing.Size(159, 21)
        Me.GooglecbLanguage.TabIndex = 51
        '
        'GooglecbCountry
        '
        Me.GooglecbCountry.DropDownHeight = 150
        Me.GooglecbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GooglecbCountry.DropDownWidth = 128
        Me.GooglecbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GooglecbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GooglecbCountry.FormattingEnabled = True
        Me.GooglecbCountry.IntegralHeight = False
        Me.GooglecbCountry.Items.AddRange(New Object() {"All", "Abkhazia", "Afghanistan", "Åland Islands", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bonaire", "Bosnia and Herz.", "Botswana", "Bouvet Island", "Brazil", "British IOT", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African", "Chad", "Chile", "China", "Christmas Island", "Cocos Islands", "Colombia", "Comoros", "Congo", "Congo, Democratic", "Cook Islands", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Curaçao", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "French Guiana", "French Polynesia", "French Southern", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard and McDonald", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jersey", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea", "Korea, Democratic", "Kuwait", "Kyrgyzstan", "Lao People's", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libyan Arab", "Liechtenstein", "Lithuania", "Luxembourg", "Macao", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Myanmar", "N. Mariana Islands", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Norway", "Oman", "Pakistan", "Palau", "Palestinian", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Barthélemy", "Saint Helena", "Saint Kitts", "Saint Lucia", "Saint Martin", "Saint Pierre", "Saint Vincent", "Samoa", "San Marino", "Sao Tome", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Sint Maarten", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia", "South Ossetia", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard", "Swaziland", "Sweden", "Switzerland", "Syrian Arab", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks Islands", "Tuvalu", "UAE", "Uganda", "Ukraine", "United Kingdom", "United States", "Uruguay", "US Minor", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Virgin Islands, British", "Virgin Islands, U.S.", "Wallis and Futuna", "Western Sahara", "Yemen", "Zambia", "Zimbabwe"})
        Me.GooglecbCountry.Location = New System.Drawing.Point(3, 126)
        Me.GooglecbCountry.Name = "GooglecbCountry"
        Me.GooglecbCountry.Size = New System.Drawing.Size(159, 21)
        Me.GooglecbCountry.TabIndex = 52
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(60, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(42, 13)
        Me.label12.TabIndex = 53
        Me.label12.Text = "Domain"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.ForeColor = System.Drawing.Color.Black
        Me.label13.Location = New System.Drawing.Point(48, 55)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(54, 13)
        Me.label13.TabIndex = 54
        Me.label13.Text = "Language"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.ForeColor = System.Drawing.Color.Black
        Me.label14.Location = New System.Drawing.Point(60, 110)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(46, 13)
        Me.label14.TabIndex = 55
        Me.label14.Text = "Country"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.ForeColor = System.Drawing.Color.Black
        Me.label15.Location = New System.Drawing.Point(63, 165)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(29, 13)
        Me.label15.TabIndex = 56
        Me.label15.Text = "Time"
        '
        'GooglecbTime
        '
        Me.GooglecbTime.DropDownHeight = 150
        Me.GooglecbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GooglecbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GooglecbTime.FormattingEnabled = True
        Me.GooglecbTime.IntegralHeight = False
        Me.GooglecbTime.Items.AddRange(New Object() {"Any Time", "Hour", "Day", "Week", "Mount", "Year"})
        Me.GooglecbTime.Location = New System.Drawing.Point(3, 183)
        Me.GooglecbTime.Name = "GooglecbTime"
        Me.GooglecbTime.Size = New System.Drawing.Size(159, 21)
        Me.GooglecbTime.TabIndex = 57
        '
        'GooglechbFilter
        '
        Me.GooglechbFilter.AutoSize = True
        Me.GooglechbFilter.ForeColor = System.Drawing.Color.Black
        Me.GooglechbFilter.Location = New System.Drawing.Point(3, 258)
        Me.GooglechbFilter.Name = "GooglechbFilter"
        Me.GooglechbFilter.Size = New System.Drawing.Size(126, 17)
        Me.GooglechbFilter.TabIndex = 58
        Me.GooglechbFilter.Text = "Show omitted results"
        Me.GooglechbFilter.UseVisualStyleBackColor = True
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label16.ForeColor = System.Drawing.Color.White
        Me.label16.Location = New System.Drawing.Point(256, 261)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(18, 15)
        Me.label16.TabIndex = 60
        Me.label16.Text = "or"
        '
        'chbBlackList
        '
        Me.chbBlackList.AutoSize = True
        Me.chbBlackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBlackList.ForeColor = System.Drawing.Color.White
        Me.chbBlackList.Location = New System.Drawing.Point(205, 220)
        Me.chbBlackList.Name = "chbBlackList"
        Me.chbBlackList.Size = New System.Drawing.Size(66, 17)
        Me.chbBlackList.TabIndex = 61
        Me.chbBlackList.Text = "Black List"
        Me.chbBlackList.UseVisualStyleBackColor = False
        '
        'chbWhiteList
        '
        Me.chbWhiteList.AutoSize = True
        Me.chbWhiteList.BackColor = System.Drawing.Color.White
        Me.chbWhiteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbWhiteList.ForeColor = System.Drawing.Color.Black
        Me.chbWhiteList.Location = New System.Drawing.Point(297, 220)
        Me.chbWhiteList.Name = "chbWhiteList"
        Me.chbWhiteList.Size = New System.Drawing.Size(70, 17)
        Me.chbWhiteList.TabIndex = 68
        Me.chbWhiteList.Text = "White List"
        Me.chbWhiteList.UseVisualStyleBackColor = False
        '
        'panelGoogle
        '
        Me.panelGoogle.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelGoogle.Controls.Add(Me.GooglechbCountryHard)
        Me.panelGoogle.Controls.Add(Me.GooglechbCountryNorm)
        Me.panelGoogle.Controls.Add(Me.GooglechbLangHard)
        Me.panelGoogle.Controls.Add(Me.GooglechbLangNorm)
        Me.panelGoogle.Controls.Add(Me.GooglechbRandCountry)
        Me.panelGoogle.Controls.Add(Me.GooglechbRandLang)
        Me.panelGoogle.Controls.Add(Me.GooglechbRandDomain)
        Me.panelGoogle.Controls.Add(Me.GooglechbTimeTwo)
        Me.panelGoogle.Controls.Add(Me.GooglechbTimeOne)
        Me.panelGoogle.Controls.Add(Me.label19)
        Me.panelGoogle.Controls.Add(Me.GoogleTimetbTwo)
        Me.panelGoogle.Controls.Add(Me.GoogleTimetbOne)
        Me.panelGoogle.Controls.Add(Me.GooglenudTime)
        Me.panelGoogle.Controls.Add(Me.GooglecbDomain)
        Me.panelGoogle.Controls.Add(Me.GooglecbLanguage)
        Me.panelGoogle.Controls.Add(Me.GooglecbCountry)
        Me.panelGoogle.Controls.Add(Me.label12)
        Me.panelGoogle.Controls.Add(Me.label13)
        Me.panelGoogle.Controls.Add(Me.label14)
        Me.panelGoogle.Controls.Add(Me.GooglechbFilter)
        Me.panelGoogle.Controls.Add(Me.label15)
        Me.panelGoogle.Controls.Add(Me.GooglecbTime)
        Me.panelGoogle.Location = New System.Drawing.Point(649, 92)
        Me.panelGoogle.Name = "panelGoogle"
        Me.panelGoogle.Size = New System.Drawing.Size(168, 280)
        Me.panelGoogle.TabIndex = 69
        Me.panelGoogle.Visible = False
        '
        'GooglechbCountryHard
        '
        Me.GooglechbCountryHard.AutoSize = True
        Me.GooglechbCountryHard.ForeColor = System.Drawing.Color.DarkOrange
        Me.GooglechbCountryHard.Location = New System.Drawing.Point(120, 148)
        Me.GooglechbCountryHard.Name = "GooglechbCountryHard"
        Me.GooglechbCountryHard.Size = New System.Drawing.Size(48, 17)
        Me.GooglechbCountryHard.TabIndex = 71
        Me.GooglechbCountryHard.Text = "hard"
        Me.GooglechbCountryHard.UseVisualStyleBackColor = True
        '
        'GooglechbCountryNorm
        '
        Me.GooglechbCountryNorm.AutoSize = True
        Me.GooglechbCountryNorm.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.GooglechbCountryNorm.Location = New System.Drawing.Point(75, 148)
        Me.GooglechbCountryNorm.Name = "GooglechbCountryNorm"
        Me.GooglechbCountryNorm.Size = New System.Drawing.Size(50, 17)
        Me.GooglechbCountryNorm.TabIndex = 70
        Me.GooglechbCountryNorm.Text = "norm"
        Me.GooglechbCountryNorm.UseVisualStyleBackColor = True
        '
        'GooglechbLangHard
        '
        Me.GooglechbLangHard.AutoSize = True
        Me.GooglechbLangHard.ForeColor = System.Drawing.Color.DarkOrange
        Me.GooglechbLangHard.Location = New System.Drawing.Point(120, 93)
        Me.GooglechbLangHard.Name = "GooglechbLangHard"
        Me.GooglechbLangHard.Size = New System.Drawing.Size(48, 17)
        Me.GooglechbLangHard.TabIndex = 69
        Me.GooglechbLangHard.Text = "hard"
        Me.GooglechbLangHard.UseVisualStyleBackColor = True
        '
        'GooglechbLangNorm
        '
        Me.GooglechbLangNorm.AutoSize = True
        Me.GooglechbLangNorm.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.GooglechbLangNorm.Location = New System.Drawing.Point(75, 93)
        Me.GooglechbLangNorm.Name = "GooglechbLangNorm"
        Me.GooglechbLangNorm.Size = New System.Drawing.Size(50, 17)
        Me.GooglechbLangNorm.TabIndex = 68
        Me.GooglechbLangNorm.Text = "norm"
        Me.GooglechbLangNorm.UseVisualStyleBackColor = True
        '
        'GooglechbRandCountry
        '
        Me.GooglechbRandCountry.AutoSize = True
        Me.GooglechbRandCountry.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GooglechbRandCountry.Location = New System.Drawing.Point(3, 148)
        Me.GooglechbRandCountry.Name = "GooglechbRandCountry"
        Me.GooglechbRandCountry.Size = New System.Drawing.Size(62, 17)
        Me.GooglechbRandCountry.TabIndex = 67
        Me.GooglechbRandCountry.Text = "random"
        Me.GooglechbRandCountry.UseVisualStyleBackColor = True
        Me.GooglechbRandCountry.Visible = False
        '
        'GooglechbRandLang
        '
        Me.GooglechbRandLang.AutoSize = True
        Me.GooglechbRandLang.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GooglechbRandLang.Location = New System.Drawing.Point(3, 93)
        Me.GooglechbRandLang.Name = "GooglechbRandLang"
        Me.GooglechbRandLang.Size = New System.Drawing.Size(62, 17)
        Me.GooglechbRandLang.TabIndex = 66
        Me.GooglechbRandLang.Text = "random"
        Me.GooglechbRandLang.UseVisualStyleBackColor = True
        Me.GooglechbRandLang.Visible = False
        '
        'GooglechbRandDomain
        '
        Me.GooglechbRandDomain.AutoSize = True
        Me.GooglechbRandDomain.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GooglechbRandDomain.Location = New System.Drawing.Point(3, 39)
        Me.GooglechbRandDomain.Name = "GooglechbRandDomain"
        Me.GooglechbRandDomain.Size = New System.Drawing.Size(62, 17)
        Me.GooglechbRandDomain.TabIndex = 65
        Me.GooglechbRandDomain.Text = "random"
        Me.GooglechbRandDomain.UseVisualStyleBackColor = True
        Me.GooglechbRandDomain.Visible = False
        '
        'GooglechbTimeTwo
        '
        Me.GooglechbTimeTwo.AutoSize = True
        Me.GooglechbTimeTwo.Location = New System.Drawing.Point(3, 239)
        Me.GooglechbTimeTwo.Name = "GooglechbTimeTwo"
        Me.GooglechbTimeTwo.Size = New System.Drawing.Size(15, 14)
        Me.GooglechbTimeTwo.TabIndex = 64
        Me.GooglechbTimeTwo.UseVisualStyleBackColor = True
        '
        'GooglechbTimeOne
        '
        Me.GooglechbTimeOne.AutoSize = True
        Me.GooglechbTimeOne.Location = New System.Drawing.Point(3, 213)
        Me.GooglechbTimeOne.Name = "GooglechbTimeOne"
        Me.GooglechbTimeOne.Size = New System.Drawing.Size(15, 14)
        Me.GooglechbTimeOne.TabIndex = 63
        Me.GooglechbTimeOne.UseVisualStyleBackColor = True
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.ForeColor = System.Drawing.Color.White
        Me.label19.Location = New System.Drawing.Point(85, 236)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(11, 13)
        Me.label19.TabIndex = 62
        Me.label19.Text = "-"
        '
        'GoogleTimetbTwo
        '
        Me.GoogleTimetbTwo.Location = New System.Drawing.Point(97, 233)
        Me.GoogleTimetbTwo.Name = "GoogleTimetbTwo"
        Me.GoogleTimetbTwo.Size = New System.Drawing.Size(65, 20)
        Me.GoogleTimetbTwo.TabIndex = 61
        Me.GoogleTimetbTwo.Text = "24/12/2016"
        '
        'GoogleTimetbOne
        '
        Me.GoogleTimetbOne.Location = New System.Drawing.Point(18, 233)
        Me.GoogleTimetbOne.Name = "GoogleTimetbOne"
        Me.GoogleTimetbOne.Size = New System.Drawing.Size(65, 20)
        Me.GoogleTimetbOne.TabIndex = 60
        Me.GoogleTimetbOne.Text = "24/12/2016"
        '
        'GooglenudTime
        '
        Me.GooglenudTime.Location = New System.Drawing.Point(18, 207)
        Me.GooglenudTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.GooglenudTime.Name = "GooglenudTime"
        Me.GooglenudTime.Size = New System.Drawing.Size(40, 20)
        Me.GooglenudTime.TabIndex = 59
        Me.GooglenudTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'panelBing
        '
        Me.panelBing.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelBing.Controls.Add(Me.label18)
        Me.panelBing.Controls.Add(Me.BingchbRegion)
        Me.panelBing.Controls.Add(Me.label17)
        Me.panelBing.Controls.Add(Me.BingchbLang)
        Me.panelBing.Controls.Add(Me.Bingchb18)
        Me.panelBing.Location = New System.Drawing.Point(649, 92)
        Me.panelBing.Name = "panelBing"
        Me.panelBing.Size = New System.Drawing.Size(168, 280)
        Me.panelBing.TabIndex = 70
        Me.panelBing.Visible = False
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.ForeColor = System.Drawing.Color.Black
        Me.label18.Location = New System.Drawing.Point(62, 44)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(46, 13)
        Me.label18.TabIndex = 59
        Me.label18.Text = "Country"
        '
        'BingchbRegion
        '
        Me.BingchbRegion.DropDownHeight = 150
        Me.BingchbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BingchbRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BingchbRegion.FormattingEnabled = True
        Me.BingchbRegion.IntegralHeight = False
        Me.BingchbRegion.Items.AddRange(New Object() {"All", "Argentina", "Australia", "Austria", "Belgium-Dutch", "Belgium-French", "Brazil", "Canada-English", "Canada-French", "France", "Germany", "Hong Kong S.A.R.", "India", "Indonesia", "Italy", "Japan", "Korea", "Malaysia", "Mexico", "Netherlands", "Norway", "China", "Poland", "Russia", "Saudi Arabia", "South Africe", "Spain", "Sweden", "Switzerland", "Switzerland - German", "Taiwan", "Turkey", "United Kingdom", "United States-English", "United States-Spanish"})
        Me.BingchbRegion.Location = New System.Drawing.Point(3, 57)
        Me.BingchbRegion.Name = "BingchbRegion"
        Me.BingchbRegion.Size = New System.Drawing.Size(159, 21)
        Me.BingchbRegion.TabIndex = 60
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.ForeColor = System.Drawing.Color.Black
        Me.label17.Location = New System.Drawing.Point(58, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(54, 13)
        Me.label17.TabIndex = 59
        Me.label17.Text = "Language"
        '
        'BingchbLang
        '
        Me.BingchbLang.DropDownHeight = 150
        Me.BingchbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BingchbLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BingchbLang.FormattingEnabled = True
        Me.BingchbLang.IntegralHeight = False
        Me.BingchbLang.Items.AddRange(New Object() {"All", "(Afan) Oromo", "Abkhazian", "Afar", "Afrikaans", "Albanian", "Amharic", "Arabic", "Armenian", "Assamese", "Aymara", "Azerbaijani", "Bashkir", "Basque", "Bengali", "Bhutani", "Bihari", "Bislama", "Breton", "Bulgarian", "Burmese", "Byelorussian", "Cambodian", "Catalan", "Chinese", "Corsican", "Croatian", "Czech", "Danish", "Dutch", "English", "Esperanto", "Estonian", "Faeroese", "Fiji", "Finnish", "French", "Frisian", "Galician", "Georgian", "German", "Greek", "Greenlandic", "Guarani", "Gujarati", "Hausa", "Hebrew (former iw)", "Hindi", "Hungarian", "Icelandic", "Indonesian (former in)", "Interlingua", "Interlingue", "Inupiak", "Inuktitut (Eskimo)", "Irish", "Italian", "Japanese", "Javanese", "Kannada", "Kashmiri", "Kazakh", "Kinyarwanda", "Kirghiz", "Kirundi", "Korean", "Kurdish", "Laothian", "Latin", "Latvian, Lettish", "Lingala", "Lithuanian", "Macedonian", "Malagasy", "Malay", "Malayalam", "Maltese", "Maori", "Marathi", "Moldavian", "Mongolian", "Nauru", "Nepali", "Norwegian", "Occitan", "Oriya", "Pashto, Pushto", "Persian", "Polish", "Portuguese", "Punjabi", "Quechua", "Rhaeto-Romance", "Romanian", "Russian", "Samoan", "Sangro", "Sanskrit", "Scots Gaelic", "Serbian", "Serbo-Croatian", "Sesotho", "Setswana", "Shona", "Sindhi", "Singhalese", "Siswati", "Slovak", "Slovenian", "Somali", "Spanish", "Sudanese", "Swahili", "Swedish", "Tagalog", "Tajik", "Tamil", "Tatar", "Tegulu", "Thai", "Tibetan", "Tigrinya", "Tonga", "Tsonga", "Turkish", "Turkmen", "Twi", "Uigur", "Ukrainian", "Urdu", "Uzbek", "Vietnamese", "Volapuk", "Welch", "Wolof", "Xhosa", "Yiddish (former ji)", "Yoruba", "Zhuang", "Zulu"})
        Me.BingchbLang.Location = New System.Drawing.Point(3, 17)
        Me.BingchbLang.Name = "BingchbLang"
        Me.BingchbLang.Size = New System.Drawing.Size(159, 21)
        Me.BingchbLang.TabIndex = 59
        '
        'Bingchb18
        '
        Me.Bingchb18.AutoSize = True
        Me.Bingchb18.ForeColor = System.Drawing.Color.Salmon
        Me.Bingchb18.Location = New System.Drawing.Point(3, 88)
        Me.Bingchb18.Name = "Bingchb18"
        Me.Bingchb18.Size = New System.Drawing.Size(46, 17)
        Me.Bingchb18.TabIndex = 58
        Me.Bingchb18.Text = "18+"
        Me.Bingchb18.UseVisualStyleBackColor = True
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label20.ForeColor = System.Drawing.Color.Silver
        Me.label20.Location = New System.Drawing.Point(285, 100)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(82, 13)
        Me.label20.TabIndex = 71
        Me.label20.Text = "Setting Program"
        '
        'clbService
        '
        Me.clbService.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.clbService.FormattingEnabled = True
        Me.clbService.Items.AddRange(New Object() {"Google", "Rambler", "Amazon", "Yandex", "Ecosia", "Yahoo", "Bing", "AOL", "Teoma", "Nigma", "Ask", "Orange", "WOW", "MyWebSearch", "GoTo", "Search", "Hotbot", "StartPage", "ZenSearch", "Bravica", "Mail"})
        Me.clbService.Location = New System.Drawing.Point(454, 114)
        Me.clbService.Name = "clbService"
        Me.clbService.Size = New System.Drawing.Size(186, 259)
        Me.clbService.TabIndex = 72
        Me.clbService.Visible = False
        '
        'btnMany
        '
        Me.btnMany.BackColor = System.Drawing.Color.White
        Me.btnMany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMany.ForeColor = System.Drawing.Color.Black
        Me.btnMany.Location = New System.Drawing.Point(454, 92)
        Me.btnMany.Name = "btnMany"
        Me.btnMany.Size = New System.Drawing.Size(75, 23)
        Me.btnMany.TabIndex = 73
        Me.btnMany.Text = "Many"
        Me.btnMany.UseVisualStyleBackColor = False
        '
        'panelRambler
        '
        Me.panelRambler.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelRambler.Controls.Add(Me.RamblerchbEng)
        Me.panelRambler.Controls.Add(Me.RamblerchbRus)
        Me.panelRambler.Controls.Add(Me.label23)
        Me.panelRambler.Controls.Add(Me.label25)
        Me.panelRambler.Controls.Add(Me.RamblercbSort)
        Me.panelRambler.Controls.Add(Me.Ramblerchb18)
        Me.panelRambler.Location = New System.Drawing.Point(649, 92)
        Me.panelRambler.Name = "panelRambler"
        Me.panelRambler.Size = New System.Drawing.Size(168, 280)
        Me.panelRambler.TabIndex = 71
        Me.panelRambler.Visible = False
        '
        'RamblerchbEng
        '
        Me.RamblerchbEng.AutoSize = True
        Me.RamblerchbEng.ForeColor = System.Drawing.Color.Black
        Me.RamblerchbEng.Location = New System.Drawing.Point(88, 60)
        Me.RamblerchbEng.Name = "RamblerchbEng"
        Me.RamblerchbEng.Size = New System.Drawing.Size(59, 17)
        Me.RamblerchbEng.TabIndex = 61
        Me.RamblerchbEng.Text = "English"
        Me.RamblerchbEng.UseVisualStyleBackColor = True
        '
        'RamblerchbRus
        '
        Me.RamblerchbRus.AutoSize = True
        Me.RamblerchbRus.ForeColor = System.Drawing.Color.Black
        Me.RamblerchbRus.Location = New System.Drawing.Point(18, 60)
        Me.RamblerchbRus.Name = "RamblerchbRus"
        Me.RamblerchbRus.Size = New System.Drawing.Size(63, 17)
        Me.RamblerchbRus.TabIndex = 60
        Me.RamblerchbRus.Text = "Russian"
        Me.RamblerchbRus.UseVisualStyleBackColor = True
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.ForeColor = System.Drawing.Color.Black
        Me.label23.Location = New System.Drawing.Point(56, 44)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(54, 13)
        Me.label23.TabIndex = 59
        Me.label23.Text = "Language"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.ForeColor = System.Drawing.Color.Black
        Me.label25.Location = New System.Drawing.Point(69, 0)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(27, 13)
        Me.label25.TabIndex = 59
        Me.label25.Text = "Sort"
        '
        'RamblercbSort
        '
        Me.RamblercbSort.DropDownHeight = 150
        Me.RamblercbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RamblercbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RamblercbSort.FormattingEnabled = True
        Me.RamblercbSort.IntegralHeight = False
        Me.RamblercbSort.Items.AddRange(New Object() {"Pages on revelantnosti", "Sites by relevance", "Pages by date", "Sites by date"})
        Me.RamblercbSort.Location = New System.Drawing.Point(3, 17)
        Me.RamblercbSort.Name = "RamblercbSort"
        Me.RamblercbSort.Size = New System.Drawing.Size(159, 21)
        Me.RamblercbSort.TabIndex = 59
        '
        'Ramblerchb18
        '
        Me.Ramblerchb18.AutoSize = True
        Me.Ramblerchb18.ForeColor = System.Drawing.Color.Salmon
        Me.Ramblerchb18.Location = New System.Drawing.Point(18, 90)
        Me.Ramblerchb18.Name = "Ramblerchb18"
        Me.Ramblerchb18.Size = New System.Drawing.Size(46, 17)
        Me.Ramblerchb18.TabIndex = 58
        Me.Ramblerchb18.Text = "18+"
        Me.Ramblerchb18.UseVisualStyleBackColor = True
        '
        'rtbLog
        '
        Me.rtbLog.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.rtbLog.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rtbLog.Location = New System.Drawing.Point(454, 164)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.ReadOnly = True
        Me.rtbLog.ShowSelectionMargin = True
        Me.rtbLog.Size = New System.Drawing.Size(186, 208)
        Me.rtbLog.TabIndex = 44
        Me.rtbLog.Text = ""
        '
        'chbISearch
        '
        Me.chbISearch.AutoSize = True
        Me.chbISearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbISearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbISearch.ForeColor = System.Drawing.Color.GreenYellow
        Me.chbISearch.Location = New System.Drawing.Point(205, 240)
        Me.chbISearch.Name = "chbISearch"
        Me.chbISearch.Size = New System.Drawing.Size(60, 17)
        Me.chbISearch.TabIndex = 82
        Me.chbISearch.Text = "ISearch"
        Me.chbISearch.UseVisualStyleBackColor = False
        '
        'panelNigma
        '
        Me.panelNigma.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelNigma.Controls.Add(Me.NigmacbSort)
        Me.panelNigma.Controls.Add(Me.label28)
        Me.panelNigma.Controls.Add(Me.NigmachbBing)
        Me.panelNigma.Controls.Add(Me.NigmachbNigma)
        Me.panelNigma.Controls.Add(Me.NigmachbAltavista)
        Me.panelNigma.Controls.Add(Me.NigmachbYahoo)
        Me.panelNigma.Controls.Add(Me.NigmachbRambler)
        Me.panelNigma.Controls.Add(Me.NigmachbGoogle)
        Me.panelNigma.Controls.Add(Me.NigmachbYandex)
        Me.panelNigma.Controls.Add(Me.label26)
        Me.panelNigma.Controls.Add(Me.label27)
        Me.panelNigma.Controls.Add(Me.NigmacbLang)
        Me.panelNigma.Location = New System.Drawing.Point(649, 92)
        Me.panelNigma.Name = "panelNigma"
        Me.panelNigma.Size = New System.Drawing.Size(168, 280)
        Me.panelNigma.TabIndex = 72
        Me.panelNigma.Visible = False
        '
        'NigmacbSort
        '
        Me.NigmacbSort.DropDownHeight = 150
        Me.NigmacbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NigmacbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NigmacbSort.FormattingEnabled = True
        Me.NigmacbSort.IntegralHeight = False
        Me.NigmacbSort.Items.AddRange(New Object() {"None", "By Date (Newest)", "By Date (Oldest)"})
        Me.NigmacbSort.Location = New System.Drawing.Point(4, 160)
        Me.NigmacbSort.Name = "NigmacbSort"
        Me.NigmacbSort.Size = New System.Drawing.Size(159, 21)
        Me.NigmacbSort.TabIndex = 68
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.ForeColor = System.Drawing.Color.Black
        Me.label28.Location = New System.Drawing.Point(67, 145)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(27, 13)
        Me.label28.TabIndex = 67
        Me.label28.Text = "Sort"
        '
        'NigmachbBing
        '
        Me.NigmachbBing.AutoSize = True
        Me.NigmachbBing.ForeColor = System.Drawing.Color.Black
        Me.NigmachbBing.Location = New System.Drawing.Point(15, 100)
        Me.NigmachbBing.Name = "NigmachbBing"
        Me.NigmachbBing.Size = New System.Drawing.Size(46, 17)
        Me.NigmachbBing.TabIndex = 66
        Me.NigmachbBing.Text = "Bing"
        Me.NigmachbBing.UseVisualStyleBackColor = True
        '
        'NigmachbNigma
        '
        Me.NigmachbNigma.AutoSize = True
        Me.NigmachbNigma.ForeColor = System.Drawing.Color.Black
        Me.NigmachbNigma.Location = New System.Drawing.Point(70, 123)
        Me.NigmachbNigma.Name = "NigmachbNigma"
        Me.NigmachbNigma.Size = New System.Drawing.Size(55, 17)
        Me.NigmachbNigma.TabIndex = 65
        Me.NigmachbNigma.Text = "Nigma"
        Me.NigmachbNigma.UseVisualStyleBackColor = True
        '
        'NigmachbAltavista
        '
        Me.NigmachbAltavista.AutoSize = True
        Me.NigmachbAltavista.ForeColor = System.Drawing.Color.Black
        Me.NigmachbAltavista.Location = New System.Drawing.Point(90, 100)
        Me.NigmachbAltavista.Name = "NigmachbAltavista"
        Me.NigmachbAltavista.Size = New System.Drawing.Size(68, 17)
        Me.NigmachbAltavista.TabIndex = 64
        Me.NigmachbAltavista.Text = "Altavista"
        Me.NigmachbAltavista.UseVisualStyleBackColor = True
        '
        'NigmachbYahoo
        '
        Me.NigmachbYahoo.AutoSize = True
        Me.NigmachbYahoo.ForeColor = System.Drawing.Color.Black
        Me.NigmachbYahoo.Location = New System.Drawing.Point(90, 80)
        Me.NigmachbYahoo.Name = "NigmachbYahoo"
        Me.NigmachbYahoo.Size = New System.Drawing.Size(56, 17)
        Me.NigmachbYahoo.TabIndex = 63
        Me.NigmachbYahoo.Text = "Yahoo"
        Me.NigmachbYahoo.UseVisualStyleBackColor = True
        '
        'NigmachbRambler
        '
        Me.NigmachbRambler.AutoSize = True
        Me.NigmachbRambler.ForeColor = System.Drawing.Color.Black
        Me.NigmachbRambler.Location = New System.Drawing.Point(15, 80)
        Me.NigmachbRambler.Name = "NigmachbRambler"
        Me.NigmachbRambler.Size = New System.Drawing.Size(65, 17)
        Me.NigmachbRambler.TabIndex = 62
        Me.NigmachbRambler.Text = "Rambler"
        Me.NigmachbRambler.UseVisualStyleBackColor = True
        '
        'NigmachbGoogle
        '
        Me.NigmachbGoogle.AutoSize = True
        Me.NigmachbGoogle.ForeColor = System.Drawing.Color.Black
        Me.NigmachbGoogle.Location = New System.Drawing.Point(90, 60)
        Me.NigmachbGoogle.Name = "NigmachbGoogle"
        Me.NigmachbGoogle.Size = New System.Drawing.Size(59, 17)
        Me.NigmachbGoogle.TabIndex = 61
        Me.NigmachbGoogle.Text = "Google"
        Me.NigmachbGoogle.UseVisualStyleBackColor = True
        '
        'NigmachbYandex
        '
        Me.NigmachbYandex.AutoSize = True
        Me.NigmachbYandex.ForeColor = System.Drawing.Color.Black
        Me.NigmachbYandex.Location = New System.Drawing.Point(15, 60)
        Me.NigmachbYandex.Name = "NigmachbYandex"
        Me.NigmachbYandex.Size = New System.Drawing.Size(62, 17)
        Me.NigmachbYandex.TabIndex = 60
        Me.NigmachbYandex.Text = "Yandex"
        Me.NigmachbYandex.UseVisualStyleBackColor = True
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.ForeColor = System.Drawing.Color.Black
        Me.label26.Location = New System.Drawing.Point(59, 44)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(40, 13)
        Me.label26.TabIndex = 59
        Me.label26.Text = "Search"
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.ForeColor = System.Drawing.Color.Black
        Me.label27.Location = New System.Drawing.Point(58, 2)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(54, 13)
        Me.label27.TabIndex = 59
        Me.label27.Text = "Language"
        '
        'NigmacbLang
        '
        Me.NigmacbLang.DropDownHeight = 150
        Me.NigmacbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NigmacbLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NigmacbLang.FormattingEnabled = True
        Me.NigmacbLang.IntegralHeight = False
        Me.NigmacbLang.Items.AddRange(New Object() {"All", "Russian", "Ukrainian", "English"})
        Me.NigmacbLang.Location = New System.Drawing.Point(4, 17)
        Me.NigmacbLang.Name = "NigmacbLang"
        Me.NigmacbLang.Size = New System.Drawing.Size(159, 21)
        Me.NigmacbLang.TabIndex = 59
        '
        'chbFour
        '
        Me.chbFour.AutoSize = True
        Me.chbFour.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbFour.ForeColor = System.Drawing.Color.SpringGreen
        Me.chbFour.Location = New System.Drawing.Point(397, 260)
        Me.chbFour.Name = "chbFour"
        Me.chbFour.Size = New System.Drawing.Size(51, 17)
        Me.chbFour.TabIndex = 83
        Me.chbFour.Text = "site+"
        Me.chbFour.UseVisualStyleBackColor = False
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.label30.ForeColor = System.Drawing.Color.White
        Me.label30.Location = New System.Drawing.Point(379, 261)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(18, 15)
        Me.label30.TabIndex = 86
        Me.label30.Text = "or"
        '
        'label32
        '
        Me.label32.AutoSize = True
        Me.label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label32.ForeColor = System.Drawing.Color.White
        Me.label32.Location = New System.Drawing.Point(276, 221)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(18, 15)
        Me.label32.TabIndex = 88
        Me.label32.Text = "or"
        '
        'panelYandex
        '
        Me.panelYandex.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelYandex.Controls.Add(Me.YandexchbQuery)
        Me.panelYandex.Controls.Add(Me.label33)
        Me.panelYandex.Controls.Add(Me.YandextbTwo)
        Me.panelYandex.Controls.Add(Me.YandextbOne)
        Me.panelYandex.Controls.Add(Me.YandexchbData)
        Me.panelYandex.Controls.Add(Me.YandexchbMount)
        Me.panelYandex.Controls.Add(Me.YandexchbWeek)
        Me.panelYandex.Controls.Add(Me.YandexchbDay)
        Me.panelYandex.Controls.Add(Me.YandexclbLang)
        Me.panelYandex.Controls.Add(Me.label35)
        Me.panelYandex.Location = New System.Drawing.Point(649, 92)
        Me.panelYandex.Name = "panelYandex"
        Me.panelYandex.Size = New System.Drawing.Size(168, 280)
        Me.panelYandex.TabIndex = 73
        Me.panelYandex.Visible = False
        '
        'YandexchbQuery
        '
        Me.YandexchbQuery.AutoSize = True
        Me.YandexchbQuery.Location = New System.Drawing.Point(19, 227)
        Me.YandexchbQuery.Name = "YandexchbQuery"
        Me.YandexchbQuery.Size = New System.Drawing.Size(135, 17)
        Me.YandexchbQuery.TabIndex = 68
        Me.YandexchbQuery.Text = "Accurate search query"
        Me.YandexchbQuery.UseVisualStyleBackColor = True
        '
        'label33
        '
        Me.label33.AutoSize = True
        Me.label33.Location = New System.Drawing.Point(81, 204)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(11, 13)
        Me.label33.TabIndex = 67
        Me.label33.Text = "-"
        '
        'YandextbTwo
        '
        Me.YandextbTwo.Location = New System.Drawing.Point(90, 200)
        Me.YandextbTwo.Name = "YandextbTwo"
        Me.YandextbTwo.Size = New System.Drawing.Size(70, 20)
        Me.YandextbTwo.TabIndex = 66
        Me.YandextbTwo.Text = "15.01.2017"
        '
        'YandextbOne
        '
        Me.YandextbOne.Location = New System.Drawing.Point(21, 200)
        Me.YandextbOne.Name = "YandextbOne"
        Me.YandextbOne.Size = New System.Drawing.Size(60, 20)
        Me.YandextbOne.TabIndex = 65
        Me.YandextbOne.Text = "01.01.2017"
        '
        'YandexchbData
        '
        Me.YandexchbData.AutoSize = True
        Me.YandexchbData.Location = New System.Drawing.Point(3, 206)
        Me.YandexchbData.Name = "YandexchbData"
        Me.YandexchbData.Size = New System.Drawing.Size(15, 14)
        Me.YandexchbData.TabIndex = 64
        Me.YandexchbData.UseVisualStyleBackColor = True
        '
        'YandexchbMount
        '
        Me.YandexchbMount.AutoSize = True
        Me.YandexchbMount.Location = New System.Drawing.Point(108, 177)
        Me.YandexchbMount.Name = "YandexchbMount"
        Me.YandexchbMount.Size = New System.Drawing.Size(56, 17)
        Me.YandexchbMount.TabIndex = 63
        Me.YandexchbMount.Text = "mount"
        Me.YandexchbMount.UseVisualStyleBackColor = True
        '
        'YandexchbWeek
        '
        Me.YandexchbWeek.AutoSize = True
        Me.YandexchbWeek.Location = New System.Drawing.Point(44, 177)
        Me.YandexchbWeek.Name = "YandexchbWeek"
        Me.YandexchbWeek.Size = New System.Drawing.Size(65, 17)
        Me.YandexchbWeek.TabIndex = 62
        Me.YandexchbWeek.Text = "2 weeks"
        Me.YandexchbWeek.UseVisualStyleBackColor = True
        '
        'YandexchbDay
        '
        Me.YandexchbDay.AutoSize = True
        Me.YandexchbDay.Location = New System.Drawing.Point(3, 177)
        Me.YandexchbDay.Name = "YandexchbDay"
        Me.YandexchbDay.Size = New System.Drawing.Size(44, 17)
        Me.YandexchbDay.TabIndex = 61
        Me.YandexchbDay.Text = "day"
        Me.YandexchbDay.UseVisualStyleBackColor = True
        '
        'YandexclbLang
        '
        Me.YandexclbLang.FormattingEnabled = True
        Me.YandexclbLang.Items.AddRange(New Object() {"Russian", "English", "Belorussian", "Indonesian", "Kazakh", "German", "Tatar", "Turkish", "Ukrainian", "French"})
        Me.YandexclbLang.Location = New System.Drawing.Point(21, 18)
        Me.YandexclbLang.Name = "YandexclbLang"
        Me.YandexclbLang.Size = New System.Drawing.Size(111, 154)
        Me.YandexclbLang.TabIndex = 60
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.ForeColor = System.Drawing.Color.Black
        Me.label35.Location = New System.Drawing.Point(58, 2)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(54, 13)
        Me.label35.TabIndex = 59
        Me.label35.Text = "Language"
        '
        'chbAntiPublic
        '
        Me.chbAntiPublic.AutoSize = True
        Me.chbAntiPublic.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chbAntiPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbAntiPublic.ForeColor = System.Drawing.Color.Violet
        Me.chbAntiPublic.Location = New System.Drawing.Point(205, 280)
        Me.chbAntiPublic.Name = "chbAntiPublic"
        Me.chbAntiPublic.Size = New System.Drawing.Size(69, 17)
        Me.chbAntiPublic.TabIndex = 89
        Me.chbAntiPublic.Text = "AntiPublic"
        Me.chbAntiPublic.UseVisualStyleBackColor = False
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.label29.Location = New System.Drawing.Point(205, 300)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(33, 13)
        Me.label29.TabIndex = 90
        Me.label29.Text = "Path:"
        '
        'lbPath
        '
        Me.lbPath.AutoSize = True
        Me.lbPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.lbPath.Location = New System.Drawing.Point(238, 301)
        Me.lbPath.Name = "lbPath"
        Me.lbPath.Size = New System.Drawing.Size(58, 13)
        Me.lbPath.TabIndex = 91
        Me.lbPath.Text = "Search.txt"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = My.Resources.Resources.btnClose
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(620, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 81
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnTray
        '
        Me.btnTray.BackColor = System.Drawing.Color.Transparent
        Me.btnTray.BackgroundImage = My.Resources.Resources.btnTray
        Me.btnTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTray.FlatAppearance.BorderSize = 0
        Me.btnTray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnTray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTray.Location = New System.Drawing.Point(595, 3)
        Me.btnTray.Name = "btnTray"
        Me.btnTray.Size = New System.Drawing.Size(20, 20)
        Me.btnTray.TabIndex = 80
        Me.btnTray.UseVisualStyleBackColor = False
        '
        'btnDirectory
        '
        Me.btnDirectory.BackColor = System.Drawing.Color.Transparent
        Me.btnDirectory.BackgroundImage = My.Resources.Resources.btnPapka
        Me.btnDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDirectory.FlatAppearance.BorderSize = 0
        Me.btnDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.btnDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDirectory.Location = New System.Drawing.Point(570, 3)
        Me.btnDirectory.Name = "btnDirectory"
        Me.btnDirectory.Size = New System.Drawing.Size(20, 20)
        Me.btnDirectory.TabIndex = 79
        Me.btnDirectory.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImage = My.Resources.Resources.btnStart
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(9, 152)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(185, 34)
        Me.btnStart.TabIndex = 78
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.BackgroundImage = My.Resources.Resources.btnStop
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(109, 123)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(85, 23)
        Me.btnStop.TabIndex = 77
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.Transparent
        Me.btnPause.BackgroundImage = My.Resources.Resources.btnPause
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Location = New System.Drawing.Point(9, 123)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(85, 23)
        Me.btnPause.TabIndex = 76
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnProxy
        '
        Me.btnProxy.BackColor = System.Drawing.Color.Transparent
        Me.btnProxy.BackgroundImage = My.Resources.Resources.btnProxy
        Me.btnProxy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProxy.FlatAppearance.BorderSize = 0
        Me.btnProxy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnProxy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.btnProxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProxy.Location = New System.Drawing.Point(109, 94)
        Me.btnProxy.Name = "btnProxy"
        Me.btnProxy.Size = New System.Drawing.Size(85, 23)
        Me.btnProxy.TabIndex = 75
        Me.btnProxy.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.BackgroundImage = My.Resources.Resources.btnSource
        Me.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Location = New System.Drawing.Point(9, 94)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(85, 23)
        Me.btnOpen.TabIndex = 74
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'picMusicCentr
        '
        Me.picMusicCentr.BackgroundImage = My.Resources.Resources.btnSource
        Me.picMusicCentr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMusicCentr.Image = My.Resources.Resources.SubKolonki
        Me.picMusicCentr.Location = New System.Drawing.Point(280, 331)
        Me.picMusicCentr.Name = "picMusicCentr"
        Me.picMusicCentr.Size = New System.Drawing.Size(91, 64)
        Me.picMusicCentr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMusicCentr.TabIndex = 35
        Me.picMusicCentr.TabStop = False
        Me.picMusicCentr.Visible = False
        '
        'picSearch
        '
        Me.picSearch.BackColor = System.Drawing.Color.White
        Me.picSearch.Location = New System.Drawing.Point(454, 114)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(186, 50)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSearch.TabIndex = 34
        Me.picSearch.TabStop = False
        '
        'picMusicRight
        '
        Me.picMusicRight.Image = My.Resources.Resources.dinamik
        Me.picMusicRight.Location = New System.Drawing.Point(397, 325)
        Me.picMusicRight.Name = "picMusicRight"
        Me.picMusicRight.Size = New System.Drawing.Size(53, 70)
        Me.picMusicRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMusicRight.TabIndex = 33
        Me.picMusicRight.TabStop = False
        Me.picMusicRight.Visible = False
        '
        'picMusicLeft
        '
        Me.picMusicLeft.Image = My.Resources.Resources.dinamik
        Me.picMusicLeft.Location = New System.Drawing.Point(200, 325)
        Me.picMusicLeft.Name = "picMusicLeft"
        Me.picMusicLeft.Size = New System.Drawing.Size(53, 70)
        Me.picMusicLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMusicLeft.TabIndex = 31
        Me.picMusicLeft.TabStop = False
        Me.picMusicLeft.Visible = False
        '
        'picMain
        '
        Me.picMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.picMain.Location = New System.Drawing.Point(200, 90)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(250, 229)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMain.TabIndex = 29
        Me.picMain.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(208, 26)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(31, 44)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 94
        Me.pictureBox1.TabStop = False
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnSetting.BackgroundImage = My.Resources.Resources.Setting
        Me.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSetting.Location = New System.Drawing.Point(542, 3)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(25, 25)
        Me.btnSetting.TabIndex = 93
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'myMessage
        '
        Me.myMessage.BackColor = System.Drawing.Color.Transparent
        Me.myMessage.BackgroundImage = My.Resources.Resources.btnMessage
        Me.myMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.myMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.myMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.myMessage.Location = New System.Drawing.Point(545, 30)
        Me.myMessage.Name = "myMessage"
        Me.myMessage.Size = New System.Drawing.Size(45, 45)
        Me.myMessage.TabIndex = 91
        Me.myMessage.UseVisualStyleBackColor = False
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Transparent
        Me.btnChange.BackgroundImage = My.Resources.Resources.ChangeLog
        Me.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChange.Location = New System.Drawing.Point(595, 30)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(45, 45)
        Me.btnChange.TabIndex = 89
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'picHead
        '
        Me.picHead.Image = My.Resources.Resources.Title
        Me.picHead.Location = New System.Drawing.Point(4, 17)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(199, 58)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHead.TabIndex = 6
        Me.picHead.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.lbPath)
        Me.Controls.Add(Me.label29)
        Me.Controls.Add(Me.chbAntiPublic)
        Me.Controls.Add(Me.panelYandex)
        Me.Controls.Add(Me.label32)
        Me.Controls.Add(Me.label30)
        Me.Controls.Add(Me.chbFour)
        Me.Controls.Add(Me.panelNigma)
        Me.Controls.Add(Me.chbISearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTray)
        Me.Controls.Add(Me.btnDirectory)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnProxy)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.nudTimeOut)
        Me.Controls.Add(Me.panelRambler)
        Me.Controls.Add(Me.nudPage)
        Me.Controls.Add(Me.tbLog)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btnMany)
        Me.Controls.Add(Me.nudThread)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.clbService)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.panelBing)
        Me.Controls.Add(Me.panelGoogle)
        Me.Controls.Add(Me.chbWhiteList)
        Me.Controls.Add(Me.tbProxyLink)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.chbBlackList)
        Me.Controls.Add(Me.cbProxyType)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.nudProxy)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.btnLikLoad)
        Me.Controls.Add(Me.rtbLog)
        Me.Controls.Add(Me.chbDelThree)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.cbSearch)
        Me.Controls.Add(Me.chbDelTwo)
        Me.Controls.Add(Me.chbPresence)
        Me.Controls.Add(Me.chbDelNull)
        Me.Controls.Add(Me.chbDelOne)
        Me.Controls.Add(Me.chbOneFile)
        Me.Controls.Add(Me.chbBeep)
        Me.Controls.Add(Me.picMusicCentr)
        Me.Controls.Add(Me.picSearch)
        Me.Controls.Add(Me.picMusicRight)
        Me.Controls.Add(Me.picMusicLeft)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.PanelTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Searcher"
        CType(Me.nudTimeOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.nudPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProxy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        Me.panelGoogle.ResumeLayout(False)
        Me.panelGoogle.PerformLayout()
        CType(Me.GooglenudTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBing.ResumeLayout(False)
        Me.panelBing.PerformLayout()
        Me.panelRambler.ResumeLayout(False)
        Me.panelRambler.PerformLayout()
        Me.panelNigma.ResumeLayout(False)
        Me.panelNigma.PerformLayout()
        Me.panelYandex.ResumeLayout(False)
        Me.panelYandex.PerformLayout()
        CType(Me.picMusicCentr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMusicRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMusicLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As Label

    Friend WithEvents sfgsgs As Label

    Friend WithEvents label3 As Label

    Friend WithEvents lbError As Label

    Friend WithEvents lbProxy As Label

    Friend WithEvents lbThreadWork As Label

    Friend WithEvents label7 As Label

    Friend WithEvents tbLog As TextBox

    Friend WithEvents TimerSetting As System.Windows.Forms.Timer

    Friend WithEvents tbProxyLink As TextBox

    Friend WithEvents label11 As Label

    Friend WithEvents label10 As Label

    Friend WithEvents nudThread As NumericUpDown

    Friend WithEvents nudTimeOut As NumericUpDown

    Friend WithEvents PanelTitle As Panel

    Friend WithEvents lbDork As Label

    Friend WithEvents picHead As PictureBox

    Friend WithEvents pbStatus As ProgressBar

    Friend WithEvents label2 As Label

    Friend WithEvents cbProxyType As ComboBox

    Friend WithEvents label5 As Label

    Friend WithEvents lbVersion As Label

    Friend WithEvents label6 As Label

    Friend WithEvents nudProxy As NumericUpDown

    Friend WithEvents cbSearch As ComboBox

    Friend WithEvents panel1 As Panel

    Friend WithEvents label4 As Label

    Friend WithEvents lbLink As Label

    Friend WithEvents label8 As Label

    Friend WithEvents nudPage As NumericUpDown

    Friend WithEvents TimerThread As System.Windows.Forms.Timer

    Friend WithEvents TimerGetProxy As System.Windows.Forms.Timer

    Friend WithEvents btnLikLoad As Button

    Friend WithEvents ToolTipAbout As ToolTip

    Friend WithEvents picMain As PictureBox

    Friend WithEvents picMusicLeft As PictureBox

    Friend WithEvents IconTray As NotifyIcon

    Friend WithEvents picMusicRight As PictureBox

    Friend WithEvents picSearch As PictureBox

    Friend WithEvents picMusicCentr As PictureBox

    Friend WithEvents chbBeep As CheckBox

    Friend WithEvents chbOneFile As CheckBox

    Friend WithEvents chbDelOne As CheckBox

    Friend WithEvents chbDelNull As CheckBox

    Friend WithEvents chbPresence As CheckBox

    Friend WithEvents chbDelTwo As CheckBox

    Friend WithEvents label9 As Label

    Friend WithEvents chbDelThree As CheckBox

    Friend WithEvents rtbLog As ViewOnlyRichTextBox

    Friend WithEvents panel2 As Panel

    Friend WithEvents pTop As Panel

    Friend WithEvents GooglecbDomain As ComboBox

    Friend WithEvents GooglecbLanguage As ComboBox

    Friend WithEvents GooglecbCountry As ComboBox

    Friend WithEvents label12 As Label

    Friend WithEvents label13 As Label

    Friend WithEvents label14 As Label

    Friend WithEvents label15 As Label

    Friend WithEvents GooglecbTime As ComboBox

    Friend WithEvents GooglechbFilter As CheckBox

    Friend WithEvents TimerError As System.Windows.Forms.Timer

    Friend WithEvents label16 As Label

    Friend WithEvents chbBlackList As CheckBox

    Friend WithEvents TimerCleartb As System.Windows.Forms.Timer

    Friend WithEvents chbWhiteList As CheckBox

    Friend WithEvents panelGoogle As Panel

    Friend WithEvents panelBing As Panel

    Friend WithEvents Bingchb18 As CheckBox

    Friend WithEvents label17 As Label

    Friend WithEvents BingchbLang As ComboBox

    Friend WithEvents BingchbRegion As ComboBox

    Friend WithEvents label18 As Label

    Friend WithEvents GooglechbCountryHard As CheckBox

    Friend WithEvents GooglechbCountryNorm As CheckBox

    Friend WithEvents GooglechbLangHard As CheckBox

    Friend WithEvents GooglechbLangNorm As CheckBox

    Friend WithEvents GooglechbRandCountry As CheckBox

    Friend WithEvents GooglechbRandLang As CheckBox

    Friend WithEvents GooglechbRandDomain As CheckBox

    Friend WithEvents GooglechbTimeTwo As CheckBox

    Friend WithEvents GooglechbTimeOne As CheckBox

    Friend WithEvents label19 As Label

    Friend WithEvents GoogleTimetbTwo As TextBox

    Friend WithEvents GoogleTimetbOne As TextBox

    Friend WithEvents GooglenudTime As NumericUpDown

    Friend WithEvents label21 As Label

    Friend WithEvents label20 As Label

    Friend WithEvents lbQueue As Label

    Friend WithEvents label22 As Label

    Friend WithEvents label24 As Label

    Friend WithEvents lbServiceNow As Label

    Friend WithEvents clbService As CheckedListBox

    Friend WithEvents btnMany As Button

    Friend WithEvents panelRambler As Panel

    Friend WithEvents label23 As Label

    Friend WithEvents label25 As Label

    Friend WithEvents RamblercbSort As ComboBox

    Friend WithEvents Ramblerchb18 As CheckBox

    Friend WithEvents RamblerchbEng As CheckBox

    Friend WithEvents RamblerchbRus As CheckBox

    Friend WithEvents btnOpen As MyButton

    Friend WithEvents btnProxy As MyButton

    Friend WithEvents btnPause As MyButton

    Friend WithEvents btnStop As MyButton

    Friend WithEvents btnStart As MyButton

    Friend WithEvents btnDirectory As MyButton

    Friend WithEvents btnTray As MyButton

    Friend WithEvents btnClose As MyButton

    Friend WithEvents chbISearch As CheckBox

    Friend WithEvents panelNigma As Panel

    Friend WithEvents NigmacbSort As ComboBox

    Friend WithEvents label28 As Label

    Friend WithEvents NigmachbBing As CheckBox

    Friend WithEvents NigmachbNigma As CheckBox

    Friend WithEvents NigmachbAltavista As CheckBox

    Friend WithEvents NigmachbYahoo As CheckBox

    Friend WithEvents NigmachbRambler As CheckBox

    Friend WithEvents NigmachbGoogle As CheckBox

    Friend WithEvents NigmachbYandex As CheckBox

    Friend WithEvents label26 As Label

    Friend WithEvents label27 As Label

    Friend WithEvents NigmacbLang As ComboBox

    Friend WithEvents chbFour As CheckBox

    Friend WithEvents label30 As Label

    Friend WithEvents label32 As Label

    Friend WithEvents btnChange As MyButton

    Friend WithEvents panelYandex As Panel

    Friend WithEvents YandexchbQuery As CheckBox

    Friend WithEvents label33 As Label

    Friend WithEvents YandextbTwo As TextBox

    Friend WithEvents YandextbOne As TextBox

    Friend WithEvents YandexchbData As CheckBox

    Friend WithEvents YandexchbMount As CheckBox

    Friend WithEvents YandexchbWeek As CheckBox

    Friend WithEvents YandexchbDay As CheckBox

    Friend WithEvents YandexclbLang As CheckedListBox

    Friend WithEvents label35 As Label

    Friend WithEvents myMessage As MyButton

    Friend WithEvents lbMessage As Label

    Friend WithEvents btnSetting As MyButton

    Friend WithEvents chbAntiPublic As CheckBox

    Friend WithEvents label29 As Label

    Friend WithEvents lbPath As Label

    Friend WithEvents pictureBox1 As PictureBox
End Class
