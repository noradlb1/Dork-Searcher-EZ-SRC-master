<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change))
        Me.panelHead = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rtbChange = New System.Windows.Forms.RichTextBox()
        Me.panelHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHead
        '
        Me.panelHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.panelHead.Controls.Add(Me.label1)
        Me.panelHead.Controls.Add(Me.btnClose)
        Me.panelHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHead.Location = New System.Drawing.Point(0, 0)
        Me.panelHead.Name = "panelHead"
        Me.panelHead.Size = New System.Drawing.Size(284, 35)
        Me.panelHead.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Coral
        Me.label1.Location = New System.Drawing.Point(54, -4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(162, 39)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Change Log"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.BackgroundImage = My.Resources.Resources.btnClose
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(261, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'rtbChange
        '
        Me.rtbChange.BackColor = System.Drawing.SystemColors.Control
        Me.rtbChange.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rtbChange.Location = New System.Drawing.Point(12, 41)
        Me.rtbChange.Name = "rtbChange"
        Me.rtbChange.Size = New System.Drawing.Size(260, 209)
        Me.rtbChange.TabIndex = 1
        Me.rtbChange.Text = ""
        '
        'Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.rtbChange)
        Me.Controls.Add(Me.panelHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Change"
        Me.panelHead.ResumeLayout(False)
        Me.panelHead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelHead As Panel

    Friend WithEvents btnClose As Button

    Friend WithEvents rtbChange As RichTextBox

    Friend WithEvents label1 As Label
End Class
