Imports Searcher.Parser
Imports System
Imports System.ComponentModel
Imports System.Data.SQLite
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Namespace Searcher.Parser.DB
	Friend Class DataBaseWork
		Private ReadOnly _config As Config = Config.GetConfig()

		Public Sub New()
			MyBase.New()
		End Sub

		Public Function Add(ByVal path As String) As Task(Of String)
			Return Task.Run(Of String)(Function()
				Dim sQLiteConnection As System.Data.SQLite.SQLiteConnection = New System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};", "Antipublic\link.db"))
				sQLiteConnection.Open()
				Dim sQLiteCommand As System.Data.SQLite.SQLiteCommand = New System.Data.SQLite.SQLiteCommand(sQLiteConnection)
				Using sQLiteTransaction As System.Data.SQLite.SQLiteTransaction = sQLiteConnection.BeginTransaction()
					Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(path)
					While Not streamReader.EndOfStream
						Dim str As String = streamReader.ReadLine()
						sQLiteCommand.CommandText = "INSERT INTO 'temp' ('value') VALUES (@line);"
						sQLiteCommand.Parameters.Add(New SQLiteParameter("@line", str))
						sQLiteCommand.ExecuteNonQuery()
					End While
					streamReader.Close()
					sQLiteTransaction.Commit()
				End Using
				sQLiteCommand.CommandText = "SELECT temp.value FROM temp LEFT JOIN links ON temp.value = links.Value WHERE links.Value IS NULL"
				sQLiteCommand.ExecuteNonQuery()
				sQLiteCommand.CommandText = "INSERT INTO  links (VALUE) SELECT temp.value FROM temp LEFT JOIN links ON temp.value = links.Value WHERE links.Value IS NULL"
				sQLiteCommand.ExecuteNonQuery()
				sQLiteConnection.Close()
				sQLiteCommand.Dispose()
				Me.Deltemp()
				Return "Okey"
			End Function)
		End Function

		Public Function Antipub() As Integer
			If (Not File.Exists(Me._config.sSaveFile)) Then
				Return 0
			End If
			Dim sQLiteConnection As System.Data.SQLite.SQLiteConnection = New System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};", "Antipublic\link.db"))
			sQLiteConnection.Open()
			Dim sQLiteCommand As System.Data.SQLite.SQLiteCommand = New System.Data.SQLite.SQLiteCommand(sQLiteConnection)
			Using sQLiteTransaction As System.Data.SQLite.SQLiteTransaction = sQLiteConnection.BeginTransaction()
				Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me._config.sSaveFile)
				While Not streamReader.EndOfStream
					Dim str As String = streamReader.ReadLine()
					sQLiteCommand.CommandText = "INSERT INTO 'temp' ('value') VALUES (@line);"
					sQLiteCommand.Parameters.Add(New SQLiteParameter("@line", str))
					sQLiteCommand.ExecuteNonQuery()
				End While
				streamReader.Close()
				sQLiteTransaction.Commit()
			End Using
			sQLiteCommand.CommandText = "SELECT temp.value FROM temp LEFT JOIN links ON temp.value = links.Value WHERE links.Value IS NULL"
			Dim sQLiteDataReader As System.Data.SQLite.SQLiteDataReader = sQLiteCommand.ExecuteReader()
			Dim num As Integer = 0
			While sQLiteDataReader.Read()
				File.AppendAllText(String.Concat(Me._config.sData, "/private.txt"), String.Concat(sQLiteDataReader.GetValue(0), "" & VbCrLf & ""))
				num = num + 1
			End While
			sQLiteDataReader.Close()
			sQLiteCommand.CommandText = "INSERT INTO  links (VALUE) SELECT temp.value FROM temp LEFT JOIN links ON temp.value = links.Value WHERE links.Value IS NULL"
			sQLiteCommand.ExecuteNonQuery()
			sQLiteConnection.Close()
			sQLiteCommand.Dispose()
			Me.Deltemp()
			Return num
		End Function

		Public Function CountDb() As Long
			Dim sQLiteConnection As System.Data.SQLite.SQLiteConnection = New System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};", "AntiPublic\link.db"))
			Dim sQLiteCommand As System.Data.SQLite.SQLiteCommand = New System.Data.SQLite.SQLiteCommand("SELECT COUNT(*) FROM 'links';", sQLiteConnection)
			sQLiteConnection.Open()
			Dim num As Long = CLng(sQLiteCommand.ExecuteScalar())
			sQLiteConnection.Close()
			sQLiteCommand.Dispose()
			Return num
		End Function

		Public Sub DeleteDubl()
			Dim sQLiteConnection As System.Data.SQLite.SQLiteConnection = New System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};", "Antipublic\link.db"))
			Dim sQLiteCommand As System.Data.SQLite.SQLiteCommand = New System.Data.SQLite.SQLiteCommand("INSERT INTO  temp (VALUE) Select DISTINCT value FROM links;DELETE FROM `links`;INSERT INTO links (VALUE) Select DISTINCT value FROM temp;DELETE FROM `temp`;", sQLiteConnection)
			sQLiteConnection.Open()
			sQLiteCommand.ExecuteNonQuery()
			sQLiteConnection.Close()
			sQLiteCommand.Dispose()
		End Sub

		Public Sub Deltemp()
			Dim sQLiteConnection As System.Data.SQLite.SQLiteConnection = New System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};", "Antipublic\link.db"))
			Dim sQLiteCommand As System.Data.SQLite.SQLiteCommand = New System.Data.SQLite.SQLiteCommand("DELETE FROM `temp`;", sQLiteConnection)
			sQLiteConnection.Open()
			sQLiteCommand.ExecuteNonQuery()
			sQLiteConnection.Close()
			sQLiteCommand.Dispose()
		End Sub

		Public Function InspAP() As Integer
			Dim num As Integer = 0
			If (File.Exists("AntiPublic\link.db")) Then
				num = num + 1
			End If
			If (File.Exists("x64\SQLite.Interop.dll")) Then
				num = num + 1
			End If
			If (File.Exists("x86\SQLite.Interop.dll")) Then
				num = num + 1
			End If
			If (File.Exists("EntityFramework.dll")) Then
				num = num + 1
			End If
			If (File.Exists("EntityFramework.SqlServer.dll")) Then
				num = num + 1
			End If
			If (File.Exists("System.Data.SQLite.dll")) Then
				num = num + 1
			End If
			If (File.Exists("System.Data.SQLite.EF6.dll")) Then
				num = num + 1
			End If
			If (File.Exists("System.Data.SQLite.Linq.dll")) Then
				num = num + 1
			End If
			Return num
		End Function

		Public Function InspDB() As Boolean
			If (File.Exists("AntiPublic\link.db")) Then
				Return False
			End If
			Return True
		End Function
	End Class
End Namespace