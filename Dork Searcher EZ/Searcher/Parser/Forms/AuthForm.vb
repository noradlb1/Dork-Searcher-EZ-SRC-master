Imports _1488
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Searcher.Parser
Imports Searcher.Properties
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Net.Sockets
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports xNet
Imports Dork_Searcher_EZ.Searcher.Parser
Imports Dork_Searcher_EZ.Searcher.Parser.Forms

Public Class AuthForm
    Private ReadOnly _config As Config = Config.GetConfig()

    Private frm As MainForm = New MainForm()

    Private fnc As Func = New Func()

    Private login As String

    Private pass As String

    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

    Private Sub AuthForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (File.Exists("new.exe")) Then
            File.Delete("new.exe")
        End If
        If (File.Exists("gg.dll.bac")) Then
            File.Delete("gg.dll.bac")
        End If
        Dim str As String = File.ReadAllText("mes.dat")
        Me._config.Message = str
        Me.picLoad.Visible = True
        Me.btnClose.Enabled = False
        Me.btnLoggin.Enabled = False
        Me.tbLogin.Enabled = False
        Me.tbKey.Enabled = False
        Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.GetInfo))
        thread.Start()
    End Sub

    Private Sub AuthForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        MyBase.Capture = False
        Dim message As System.Windows.Forms.Message = System.Windows.Forms.Message.Create(MyBase.Handle, 161, New IntPtr(2), IntPtr.Zero)
        Me.WndProc(message)
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Application.[Exit]()
    End Sub

    Private Sub btnLoggin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoggin.Click
        Dim str As String = Me.Registr(1)
        Me.login = str.Split(New Char() {";"c})(0)
        Me.pass = str.Split(New Char() {";"c})(1)
        Me.picLoad.Visible = True
        Me.btnLoggin.Enabled = False
        Me.tbLogin.Enabled = False
        Me.tbKey.Enabled = False
        Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.Send))
        thread.Start()
    End Sub

    Private Function ComputeMD5Checksum(ByVal path As String) As String
        Dim str As String
        Using fileStream As System.IO.FileStream = File.OpenRead(path)
            Dim mD5CryptoServiceProvider As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim numArray(CType(fileStream.Length, IntPtr) - 1) As Byte
            fileStream.Read(numArray, 0, CInt(fileStream.Length))
            str = BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(numArray)).Replace("-", String.Empty)
        End Using
        Return str
    End Function
    Private Sub erre(ByVal [Error] As String)
        MyBase.BeginInvoke(New Action(Sub()
                                          Me.lbMessage.Text = [Error]
                                          Me.picLoad.Visible = False
                                          Me.btnClose.Enabled = True
                                          Me.btnLoggin.Enabled = True
                                          Me.tbLogin.Enabled = True
                                          Me.tbKey.Enabled = True
                                      End Sub))
    End Sub

    Private Sub GetInfo()
        Dim str As String = Me.Registr(0)
        Me.login = str.Split(New Char() {";"c})(0)
        Me.pass = str.Split(New Char() {";"c})(1)
        MyBase.BeginInvoke(New Action(Sub()
                                          If (str <> "") Then
                                              Me.tbLogin.Text = Me.login
                                              Me.tbKey.Text = Me.pass
                                          End If
                                      End Sub))
        Me._config.HWID = Me.fnc.GetInfo("Hello World")
        If (Not (Me.login <> "") OrElse Not (Me.pass <> "")) Then
            MyBase.BeginInvoke(New Action(Sub()
                                              Me.picLoad.Visible = False
                                              Me.btnClose.Enabled = True
                                              Me.btnLoggin.Enabled = True
                                              Me.tbLogin.Enabled = True
                                              Me.tbKey.Enabled = True
                                          End Sub))
        Else
            MyBase.BeginInvoke(New Action(Sub()
                                              Me.lbMessage.Text = "Connect."
                                              Me.picLoad.Visible = True
                                          End Sub))
            Try
                MyBase.BeginInvoke(New Action(Sub()
                                                  Me.picLoad.Visible = True
                                                  Me.btnClose.Enabled = False
                                                  Me.btnLoggin.Enabled = False
                                                  Me.tbLogin.Enabled = False
                                                  Me.tbKey.Enabled = False
                                              End Sub))
                Me.Send()
                Me.erre("Hello")
            Catch exception As System.Exception
                Me.erre("Error")
            End Try
        End If
    End Sub
    Private Function logged() As Boolean
        Dim flag As Boolean
        Try
            Dim str As String = ""
            Using httpRequest As xNet.HttpRequest = New xNet.HttpRequest()
                str = httpRequest.[Get]("https://raw.githubusercontent.com/SupportSearcher/Search/master/New", Nothing).ToString()
            End Using
            Dim users As Searcher.Parser.Forms.User() = JsonConvert.DeserializeObject(Of Client)(str).Users
            Dim num As Integer = 0
            While num < CInt(users.Length)
                Dim user As Searcher.Parser.Forms.User = users(num)
                If (Me._config.HWID = user.Keys) Then
                    flag = True
                    Return flag
                Else
                    num = num + 1
                End If
            End While
            flag = False
        Catch exception As System.Exception
            flag = False
        End Try
        Return flag
    End Function

    Private Function Registr(ByVal work As Integer) As String
        Dim str As String
        If (work <> 0) Then
            If (work = 1) Then
                Using registryKey As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Searcher")
                    Try
                        registryKey.SetValue("Login", Me.tbLogin.Text)
                        registryKey.SetValue("Key", Me.tbKey.Text)
                        If (registryKey.GetValue("Keys") Is Nothing) Then
                            registryKey.SetValue("Keys", "1")
                            File.AppendAllText("Key.txt", Me._config.HWID)
                        End If
                        str = String.Concat(Me.tbLogin.Text, ";", Me.tbKey.Text)
                        Return str
                    Catch
                        File.AppendAllText("Key.txt", Me._config.HWID)
                    End Try
                End Using
            End If
            Return ""
        Else
            Using registryKey1 As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Searcher")
                Try
                    Dim value As Object = registryKey1.GetValue("Login")
                    Dim value1 As Object = registryKey1.GetValue("Key")
                    str = String.Concat(value, ";", value1)
                    Return str
                Catch
                    If (Me.tbLogin.Text <> "" OrElse Me.tbKey.Text <> "") Then
                        registryKey1.SetValue("Login", Me.tbLogin.Text)
                        registryKey1.SetValue("Key", Me.tbKey.Text)
                    End If
                End Try
                str = ""
            End Using
        End If
        Return str
    End Function

    Private Sub Send()
        MyBase.BeginInvoke(New Action(Sub()
                                          Me.lbMessage.Text = "Ok"
                                          Me.picLoad.Visible = False
                                          MyBase.Hide()
                                          Me.frm.Show()
                                      End Sub))
    End Sub

    Private Sub UpdatexNet()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim str As String = String.Concat(New String() {"xNet(555NewLine555)Login:", Me.login, "(555NewLine555)Key:", Me.pass, "(555NewLine555)HWID:", Me._config.HWID})
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes(str)
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("xNetnew.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub()
                                          Me.pbStatus.Visible = True
                                          Me.pbStatus.Maximum = num
                                          Me.lbMessage.Text = "Pack update"
                                      End Sub))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.lbUpdate.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.pbStatus.Value = num1
                                            End Sub
                Dim action2 As System.Action = text
                action = text
                action1 = action2
            End If
            MyBase.BeginInvoke(action1)
            binaryWriter.Write(DirectCast(binaryFormatter.Deserialize(networkStream), Byte()))
            num1 += 1024
        End While
        binaryWriter.Close()
        fileStream.Close()
        networkStream.Close()
        tcpClient.Close()
        File.Replace("xNetnew.dll", "xNet.dll", "gg.dll.bac")
    End Sub
End Class