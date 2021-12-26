Imports System.ComponentModel
Imports Control

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class myMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myMessage))
        Me.rtbMessage = New Control.ViewOnlyRichTextBox()
        Me.panelHead = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelHead.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbMessage
        '
        Me.rtbMessage.BackColor = System.Drawing.SystemColors.Control
        Me.rtbMessage.Location = New System.Drawing.Point(0, 30)
        Me.rtbMessage.Name = "rtbMessage"
        Me.rtbMessage.ReadOnly = True
        Me.rtbMessage.Size = New System.Drawing.Size(285, 220)
        Me.rtbMessage.TabIndex = 0
        Me.rtbMessage.Text = ""
        '
        'panelHead
        '
        Me.panelHead.BackColor = System.Drawing.Color.LightCoral
        Me.panelHead.Controls.Add(Me.pictureBox1)
        Me.panelHead.Controls.Add(Me.btnClose)
        Me.panelHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHead.Location = New System.Drawing.Point(0, 0)
        Me.panelHead.Name = "panelHead"
        Me.panelHead.Size = New System.Drawing.Size(285, 30)
        Me.panelHead.TabIndex = 1
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = My.Resources.Resources.btnMessage
        Me.pictureBox1.Location = New System.Drawing.Point(8, 5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = My.Resources.Resources.btnClose
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(258, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'myMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 250)
        Me.Controls.Add(Me.panelHead)
        Me.Controls.Add(Me.rtbMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "myMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Message"
        Me.panelHead.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbMessage As ViewOnlyRichTextBox

    Friend WithEvents panelHead As Panel

    Friend WithEvents btnClose As Button

    Friend WithEvents pictureBox1 As PictureBox
End Class
