Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewYearEnd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewYearEnd))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.picEnd = New System.Windows.Forms.PictureBox()
        CType(Me.picEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(68, 144)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Okey"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'picEnd
        '
        Me.picEnd.Image = My.Resources.Resources.giphy
        Me.picEnd.Location = New System.Drawing.Point(-7, -1)
        Me.picEnd.Name = "picEnd"
        Me.picEnd.Size = New System.Drawing.Size(224, 172)
        Me.picEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnd.TabIndex = 0
        Me.picEnd.TabStop = False
        '
        'NewYearEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 170)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.picEnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewYearEnd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Acid time"
        CType(Me.picEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picEnd As PictureBox

    Friend WithEvents btnOk As Button
End Class
