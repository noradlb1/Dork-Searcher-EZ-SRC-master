Imports System.Data.SQLite
Imports System.IO
Imports Dork_Searcher_EZ.Searcher.Parser.DB

Public Class FormSetting
    Private frmup As FormDBUpdate = New FormDBUpdate()

    Private ReadOnly _db As DataBaseWork = New DataBaseWork()

    Private lamp As Integer

    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

    Private Async Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim str As String = Me.OpenDialog()
        If (str <> "") Then
            Me.lbAdd.Text = "wait..."
            Dim label As System.Windows.Forms.Label = Me.lbAdd
            label.Text = Await Me._db.Add(str)
            label = Nothing
            Dim str1 As System.Windows.Forms.Label = Me.lbCount
            str1.Text = Me._db.CountDb().ToString()
        End If
    End Sub

    Private Sub btnClean_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClean.Click
        Dim dialogResult As System.Windows.Forms.DialogResult = MessageBox.Show("Can not be interrupted! Continue? / Нельзя прервать операцию! Начать проверку?", "Cleaning the database", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (dialogResult = System.Windows.Forms.DialogResult.Yes) Then
            Dim num As Long = Me._db.CountDb()
            Me._db.DeleteDubl()
            Dim num1 As Long = Me._db.CountDb()
            Me.lbCount.Text = num1.ToString()
            MessageBox.Show(String.Concat("Removed rows: ", num - num1))
        End If
        If (dialogResult = System.Windows.Forms.DialogResult.No) Then
            MessageBox.Show("Cancel")
        End If
    End Sub

    Private Sub btnDBCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDBCreate.Click
        Try
            Try
                Select Case Me.CreateDb()
                    Case 1
                        MessageBox.Show("Completed")
                        Me.btnDBCreate.Enabled = False
                        Me.btnUpdateStat.Enabled = True
                        Me.btnDelete.Enabled = True
                        Exit Select
                    Case 2
                        MessageBox.Show("Error create a database. Please delete and try again.")
                        Me.btnDBCreate.Enabled = False
                        Exit Select
                    Case 3
                        MessageBox.Show("The database already exists. Remove the old database and try again.")
                        Me.btnDBCreate.Enabled = False
                        Me.btnDelete.Enabled = True
                        Exit Select
                End Select
            Catch exception As System.Exception
                Me.frmup.ShowDialog()
            End Try
        Finally
            Me.OperationInsp()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim dialogResult As System.Windows.Forms.DialogResult = MessageBox.Show("Remove the database? / Удалить базу данных?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (dialogResult = System.Windows.Forms.DialogResult.Yes) Then
            Try
                Try
                    File.Delete("AntiPublic\link.db")
                    Directory.Delete("AntiPublic")
                    Me.btnDBCreate.Enabled = True
                    MessageBox.Show("The database is deleted / База данных удалена")
                Catch directoryNotFoundException As System.IO.DirectoryNotFoundException
                    MessageBox.Show("Путь не существует / Path does not exist.")
                    Me.btnDelete.Enabled = False
                Catch oException As IOException
                    MessageBox.Show("Перезапустите приложение / Restart the application.")
                End Try
            Finally
                Me.OperationInsp()
            End Try
        ElseIf (dialogResult = System.Windows.Forms.DialogResult.No) Then
            MessageBox.Show("Cancel")
        End If
    End Sub

    Private Sub btnUpdateStat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateStat.Click
        If (Me._db.InspAP() <> 8) Then
            MessageBox.Show("Файлы базы данных не найдены / The database files are not found.")
            Me.btnUpdateStat.Enabled = False
            Return
        End If
        Me.lbCount.Text = Me._db.CountDb().ToString()
    End Sub

    Private Sub btnWork_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbExit.Click
        Me.OperationInsp()
    End Sub

    Private Function CreateDb() As Integer
        If (Not Me._db.InspDB()) Then
            Return 3
        End If
        Directory.CreateDirectory("AntiPublic")
        Dim str As String = "AntiPublic\link.db"
        System.Data.SQLite.SQLiteConnection.CreateFile(str)
        If (Not File.Exists(str)) Then
            Return 2
        End If
        Dim sQLiteConnection As System.Data.SQLite.SQLiteConnection = New System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};", str))
        Dim sQLiteCommand As System.Data.SQLite.SQLiteCommand = New System.Data.SQLite.SQLiteCommand("CREATE TABLE links (value TEXT); CREATE TABLE temp (value TEXT);", sQLiteConnection)
        sQLiteConnection.Open()
        sQLiteCommand.ExecuteNonQuery()
        sQLiteCommand.Dispose()
        sQLiteConnection.Close()
        Return 1
    End Function

    Private Sub FormSetting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.OperationInsp()
        If Me._db.InspAP() = 8 Then
            Dim taskk As Task(Of Long) = Task(Of Long).Factory.StartNew(Function() Me._db.CountDb())
            Me.lbCount.Text = taskk.Result.ToString()
        End If
    End Sub

    Private Sub lbExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbExit.Click
        Me.timer.Interval = 150
        Me.timer.Start()
    End Sub

    Private Function OpenDialog() As String
        Dim str As String
        Using openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
        {
            .Filter = "*.txt|*.txt"
        }
            str = If(openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK, openFileDialog.FileName, "")
        End Using
        Return str
    End Function

    Private Sub OperationInsp()
        If (Me._db.InspAP() = 8) Then
            Me.btnAdd.Enabled = True
            Me.btnUpdateStat.Enabled = True
            Me.btnWork.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnDBCreate.Enabled = False
            Me.btnClean.Enabled = True
        End If
        If (Me._db.InspAP() = 7) Then
            Me.btnAdd.Enabled = False
            Me.btnUpdateStat.Enabled = False
            Me.btnWork.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnClean.Enabled = False
        End If
        If (Me._db.InspAP() <= 7) Then
            Me.btnDBCreate.Enabled = True
        End If
    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
        If (Me.lamp = 0) Then
            Me.label2.Visible = True
        End If
        If (Me.lamp = 1) Then
            Me.label3.Visible = True
        End If
        If (Me.lamp = 2) Then
            Me.label4.Visible = True
        End If
        If (Me.lamp = 3) Then
            Me.label5.Visible = True
        End If
        If (Me.lamp = 4) Then
            Me.label6.Visible = True
        End If
        If (Me.lamp = 5) Then
            Me.label7.Visible = True
        End If
        If (Me.lamp = 6) Then
            Me.label8.Visible = True
        End If
        If (Me.lamp = 7) Then
            Me.label9.Visible = True
        End If
        If (Me.lamp = 8) Then
            Me.label10.Visible = True
        End If
        If (Me.lamp = 9) Then
            Me.label11.Visible = True
        End If
        If (Me.lamp <> 10) Then
            Me.lamp = Me.lamp + 1
            Return
        End If
        Me.lamp = 0
        Me.label2.Visible = False
        Me.label3.Visible = False
        Me.label4.Visible = False
        Me.label5.Visible = False
        Me.label6.Visible = False
        Me.label7.Visible = False
        Me.label8.Visible = False
        Me.label9.Visible = False
        Me.label10.Visible = False
        Me.label11.Visible = False
        Me.timer.[Stop]()
        MyBase.Hide()
    End Sub
End Class