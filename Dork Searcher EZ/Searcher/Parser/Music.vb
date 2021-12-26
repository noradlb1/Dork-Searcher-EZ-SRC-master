Imports System.IO
Imports System.Runtime.InteropServices
Imports WMPLib

Namespace Searcher.Parser
    Friend Class Music
        Private wmp As WindowsMediaPlayer = s()

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub music()
            Dim geffa As Byte() = My.Resources.Geffa
            Dim fileStream As System.IO.FileStream = New System.IO.FileStream(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "Beep.mp3"), FileMode.Create)
            fileStream.Write(geffa, 0, CInt(geffa.Length))
            fileStream.Close()
        End Sub

        Public Sub musicOff()
            If (Me.wmp IsNot Nothing) Then
                Me.wmp.controls.[stop]()
            End If
        End Sub

        Public Sub musicOn()
            If (Me.wmp IsNot Nothing) Then
                Me.wmp.URL = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "Beep.mp3")
            End If
        End Sub

        Private Shared Function s() As WindowsMediaPlayer
            Dim variable As WindowsMediaPlayer
            Try
                variable = DirectCast(Activator.CreateInstance(Marshal.GetTypeFromCLSID(New Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6"))), WindowsMediaPlayer)
            Catch
                variable = Nothing
            End Try
            Return variable
        End Function
    End Class
End Namespace