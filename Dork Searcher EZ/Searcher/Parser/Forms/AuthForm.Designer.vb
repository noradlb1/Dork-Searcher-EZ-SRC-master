Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AuthForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuthForm))
        Me.btnLoggin = New System.Windows.Forms.Button()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.tbKey = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.picLoad = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lbUpdate = New System.Windows.Forms.Label()
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoggin
        '
        Me.btnLoggin.Enabled = False
        Me.btnLoggin.Location = New System.Drawing.Point(123, 130)
        Me.btnLoggin.Name = "btnLoggin"
        Me.btnLoggin.Size = New System.Drawing.Size(75, 23)
        Me.btnLoggin.TabIndex = 0
        Me.btnLoggin.Text = "Login"
        Me.btnLoggin.UseVisualStyleBackColor = True
        '
        'tbLogin
        '
        Me.tbLogin.Enabled = False
        Me.tbLogin.Location = New System.Drawing.Point(73, 70)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(155, 20)
        Me.tbLogin.TabIndex = 1
        '
        'tbKey
        '
        Me.tbKey.Enabled = False
        Me.tbKey.Location = New System.Drawing.Point(73, 96)
        Me.tbKey.Name = "tbKey"
        Me.tbKey.Size = New System.Drawing.Size(235, 20)
        Me.tbKey.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(22, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 25)
        Me.label1.TabIndex = 4
        Me.label1.Text = "LOGIN"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(36, 73)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(36, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Login:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(44, 99)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(29, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Key:"
        '
        'lbMessage
        '
        Me.lbMessage.AutoSize = True
        Me.lbMessage.ForeColor = System.Drawing.Color.White
        Me.lbMessage.Location = New System.Drawing.Point(139, 52)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(34, 13)
        Me.lbMessage.TabIndex = 9
        Me.lbMessage.Text = "Hello!"
        '
        'picLoad
        '
        Me.picLoad.BackColor = System.Drawing.Color.Transparent
        Me.picLoad.Image = My.Resources.Resources.Indicator
        Me.picLoad.Location = New System.Drawing.Point(247, 58)
        Me.picLoad.Name = "picLoad"
        Me.picLoad.Size = New System.Drawing.Size(32, 32)
        Me.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLoad.TabIndex = 16
        Me.picLoad.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = My.Resources.Resources.btnClose
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Enabled = False
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(309, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 15
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(73, 40)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(206, 5)
        Me.pbStatus.TabIndex = 17
        Me.pbStatus.Visible = False
        '
        'lbUpdate
        '
        Me.lbUpdate.AutoSize = True
        Me.lbUpdate.ForeColor = System.Drawing.Color.White
        Me.lbUpdate.Location = New System.Drawing.Point(127, 23)
        Me.lbUpdate.Name = "lbUpdate"
        Me.lbUpdate.Size = New System.Drawing.Size(0, 13)
        Me.lbUpdate.TabIndex = 18
        '
        'AuthForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(333, 167)
        Me.Controls.Add(Me.lbUpdate)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.picLoad)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbMessage)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbKey)
        Me.Controls.Add(Me.tbLogin)
        Me.Controls.Add(Me.btnLoggin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AuthForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logined"
        CType(Me.picLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoggin As Button

    Friend WithEvents tbLogin As TextBox

    Friend WithEvents tbKey As TextBox

    Friend WithEvents label1 As Label

    Friend WithEvents label2 As Label

    Friend WithEvents label3 As Label

    Friend WithEvents lbMessage As Label

    Friend WithEvents btnClose As Button

    Friend WithEvents picLoad As PictureBox

    Friend WithEvents pbStatus As ProgressBar

    Friend WithEvents timer As System.Windows.Forms.Timer

    Friend WithEvents lbUpdate As Label

End Class
