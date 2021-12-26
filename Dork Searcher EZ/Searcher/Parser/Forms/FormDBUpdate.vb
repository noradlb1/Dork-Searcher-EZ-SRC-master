Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
Public Class FormDBUpdate
    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub
    Private Sub FormDBUpdate_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (File.Exists("x64\SQLite.Interop.dll")) Then
            File.Delete("x64\SQLite.Interop.dll")
        End If
        If (File.Exists("x86\SQLite.Interop.dll")) Then
            File.Delete("x86\SQLite.Interop.dll")
        End If
        If (File.Exists("EntityFramework.dll")) Then
            File.Delete("EntityFramework.dll")
        End If
        If (File.Exists("EntityFramework.SqlServer.dll")) Then
            File.Delete("EntityFramework.SqlServer.dll")
        End If
        If (File.Exists("System.Data.SQLite.dll")) Then
            File.Delete("System.Data.SQLite.dll")
        End If
        If (File.Exists("System.Data.SQLite.EF6.dll")) Then
            File.Delete("System.Data.SQLite.EF6.dll")
        End If
        If (File.Exists("System.Data.SQLite.Linq.dll")) Then
            File.Delete("System.Data.SQLite.Linq.dll")
        End If
        Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.UpdateAll)) With
            {
                .IsBackground = True
            }
        thread.Start()
    End Sub
    Private Sub Papki()
        Directory.CreateDirectory("x64")
        Directory.CreateDirectory("x86")
    End Sub

    Private Sub Update1()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes("Antipublic1(555NewLine555)1:1(555NewLine555)2:2(555NewLine555)3:3")
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("x64\SQLite.Interop.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub() Me.progressBar1.Maximum = num / 1024 + 1))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.label1.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.progressBar1.Value = num1 / 1024
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
    End Sub

    Private Sub Update2()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes("Antipublic2(555NewLine555)1:1(555NewLine555)2:2(555NewLine555)3:3")
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("x86\SQLite.Interop.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub() Me.progressBar2.Maximum = num / 1024 + 1))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.label2.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.progressBar2.Value = num1 / 1024
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
    End Sub

    Private Sub Update3()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes("Antipublic3(555NewLine555)1:1(555NewLine555)2:2(555NewLine555)3:3")
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("EntityFramework.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub() Me.progressBar3.Maximum = num / 1024 + 1))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.label3.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.progressBar3.Value = num1 / 1024
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
    End Sub

    Private Sub Update4()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes("Antipublic4(555NewLine555)1:1(555NewLine555)2:2(555NewLine555)3:3")
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("EntityFramework.SqlServer.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub() Me.progressBar4.Maximum = num / 1024 + 1))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.label4.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.progressBar4.Value = num1 / 1024
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
    End Sub

    Private Sub Update5()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes("Antipublic5(555NewLine555)1:1(555NewLine555)2:2(555NewLine555)3:3")
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("System.Data.SQLite.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub() Me.progressBar5.Maximum = num / 1024 + 1))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.label5.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.progressBar5.Value = num1 / 1024
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
    End Sub

    Private Sub Update6()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes("Antipublic6(555NewLine555)1:1(555NewLine555)2:2(555NewLine555)3:3")
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("System.Data.SQLite.EF6.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub() Me.progressBar6.Maximum = num / 1024 + 1))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.label6.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.progressBar6.Value = num1 / 1024
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
    End Sub

    Private Sub Update7()
        Dim action As System.Action = Nothing
        Dim tcpClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
        tcpClient.Connect("185.51.246.198", 20903)
        Dim stream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim bytes As Byte() = Encoding.GetEncoding(1251).GetBytes("Antipublic7(555NewLine555)1:1(555NewLine555)2:2(555NewLine555)3:3")
        stream.Write(bytes, 0, CInt(bytes.Length))
        Dim networkStream As System.Net.Sockets.NetworkStream = tcpClient.GetStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim fileStream As System.IO.FileStream = New System.IO.FileStream("System.Data.SQLite.Linq.dll", FileMode.Create)
        Dim binaryWriter As System.IO.BinaryWriter = New System.IO.BinaryWriter(fileStream)
        Dim num As Integer = Integer.Parse(binaryFormatter.Deserialize(networkStream).ToString())
        Dim num1 As Integer = 0
        MyBase.BeginInvoke(New Action(Sub() Me.progressBar7.Maximum = num / 1024 + 1))
        While num1 < num
            Dim action1 As System.Action = action
            If (action1 Is Nothing) Then
                Dim text As System.Action = Sub()
                                                Me.label7.Text = String.Concat(New Object() {num1 / 1024, "KB/", num / 1024, "KB"})
                                                Me.progressBar7.Value = num1 / 1024
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
    End Sub

    Private Sub UpdateAll()
        Me.Papki()
        Thread.Sleep(100)
        Me.Update1()
        Thread.Sleep(100)
        Me.Update2()
        Thread.Sleep(100)
        Me.Update3()
        Thread.Sleep(100)
        Me.Update4()
        Thread.Sleep(100)
        Me.Update5()
        Thread.Sleep(100)
        Me.Update6()
        Thread.Sleep(100)
        Me.Update7()
        Thread.Sleep(100)
        Application.[Exit]()
    End Sub

End Class