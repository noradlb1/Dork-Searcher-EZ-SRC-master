<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetting))
        Me.pHead = New System.Windows.Forms.Panel()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lbExit = New System.Windows.Forms.Label()
        Me.pDown = New System.Windows.Forms.Panel()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnDBCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdateStat = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lbCount2 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.btnWork = New System.Windows.Forms.Button()
        Me.lbAdd = New System.Windows.Forms.Label()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.pHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'pHead
        '
        Me.pHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.pHead.Controls.Add(Me.label11)
        Me.pHead.Controls.Add(Me.label10)
        Me.pHead.Controls.Add(Me.label9)
        Me.pHead.Controls.Add(Me.label8)
        Me.pHead.Controls.Add(Me.label7)
        Me.pHead.Controls.Add(Me.label6)
        Me.pHead.Controls.Add(Me.label5)
        Me.pHead.Controls.Add(Me.label4)
        Me.pHead.Controls.Add(Me.label3)
        Me.pHead.Controls.Add(Me.label2)
        Me.pHead.Controls.Add(Me.lbExit)
        Me.pHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHead.Location = New System.Drawing.Point(0, 0)
        Me.pHead.Name = "pHead"
        Me.pHead.Size = New System.Drawing.Size(250, 25)
        Me.pHead.TabIndex = 0
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(225, 4)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(18, 20)
        Me.label11.TabIndex = 10
        Me.label11.Text = ">"
        Me.label11.Visible = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(205, 4)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(18, 20)
        Me.label10.TabIndex = 9
        Me.label10.Text = ">"
        Me.label10.Visible = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(185, 4)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(18, 20)
        Me.label9.TabIndex = 8
        Me.label9.Text = ">"
        Me.label9.Visible = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(165, 4)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(18, 20)
        Me.label8.TabIndex = 7
        Me.label8.Text = ">"
        Me.label8.Visible = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(145, 4)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(18, 20)
        Me.label7.TabIndex = 6
        Me.label7.Text = ">"
        Me.label7.Visible = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(125, 4)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(18, 20)
        Me.label6.TabIndex = 5
        Me.label6.Text = ">"
        Me.label6.Visible = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(105, 4)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(18, 20)
        Me.label5.TabIndex = 4
        Me.label5.Text = ">"
        Me.label5.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(85, 4)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(18, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = ">"
        Me.label4.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(65, 4)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(18, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = ">"
        Me.label3.Visible = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(45, 4)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(18, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = ">"
        Me.label2.Visible = False
        '
        'lbExit
        '
        Me.lbExit.AutoSize = True
        Me.lbExit.BackColor = System.Drawing.Color.Black
        Me.lbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lbExit.Location = New System.Drawing.Point(5, 4)
        Me.lbExit.Name = "lbExit"
        Me.lbExit.Size = New System.Drawing.Size(35, 20)
        Me.lbExit.TabIndex = 0
        Me.lbExit.Text = "Exit"
        '
        'pDown
        '
        Me.pDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.pDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pDown.Location = New System.Drawing.Point(0, 275)
        Me.pDown.Name = "pDown"
        Me.pDown.Size = New System.Drawing.Size(250, 25)
        Me.pDown.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(98, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Anti-Public"
        '
        'btnDBCreate
        '
        Me.btnDBCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDBCreate.Enabled = False
        Me.btnDBCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBCreate.Location = New System.Drawing.Point(172, 28)
        Me.btnDBCreate.Name = "btnDBCreate"
        Me.btnDBCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnDBCreate.TabIndex = 4
        Me.btnDBCreate.Text = "Create"
        Me.btnDBCreate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(172, 132)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdateStat
        '
        Me.btnUpdateStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUpdateStat.Enabled = False
        Me.btnUpdateStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStat.Location = New System.Drawing.Point(53, 175)
        Me.btnUpdateStat.Name = "btnUpdateStat"
        Me.btnUpdateStat.Size = New System.Drawing.Size(145, 23)
        Me.btnUpdateStat.TabIndex = 6
        Me.btnUpdateStat.Text = "Update Statistic"
        Me.btnUpdateStat.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 204)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(250, 1)
        Me.panel1.TabIndex = 7
        '
        'lbCount2
        '
        Me.lbCount2.AutoSize = True
        Me.lbCount2.ForeColor = System.Drawing.Color.White
        Me.lbCount2.Location = New System.Drawing.Point(6, 213)
        Me.lbCount2.Name = "lbCount2"
        Me.lbCount2.Size = New System.Drawing.Size(53, 13)
        Me.lbCount2.TabIndex = 8
        Me.lbCount2.Text = "Quantity:"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(6, 236)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(87, 13)
        Me.label14.TabIndex = 10
        Me.label14.Text = "Synchronization:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.ForeColor = System.Drawing.Color.Red
        Me.label13.Location = New System.Drawing.Point(97, 236)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(13, 13)
        Me.label13.TabIndex = 11
        Me.label13.Text = "0"
        '
        'lbCount
        '
        Me.lbCount.AutoSize = True
        Me.lbCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lbCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCount.Location = New System.Drawing.Point(66, 213)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(13, 13)
        Me.lbCount.TabIndex = 12
        Me.lbCount.Text = "0"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnAdd.Enabled = False
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(5, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Visible = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(0, 169)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(250, 1)
        Me.panel2.TabIndex = 14
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panel3.Location = New System.Drawing.Point(85, 25)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1, 144)
        Me.panel3.TabIndex = 15
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panel4.Location = New System.Drawing.Point(166, 25)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(1, 144)
        Me.panel4.TabIndex = 16
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Enabled = False
        Me.checkBox1.ForeColor = System.Drawing.Color.White
        Me.checkBox1.Location = New System.Drawing.Point(5, 63)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(47, 17)
        Me.checkBox1.TabIndex = 17
        Me.checkBox1.Text = "Fast"
        Me.checkBox1.UseVisualStyleBackColor = True
        Me.checkBox1.Visible = False
        '
        'checkBox2
        '
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Enabled = False
        Me.checkBox2.ForeColor = System.Drawing.Color.White
        Me.checkBox2.Location = New System.Drawing.Point(5, 86)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(75, 17)
        Me.checkBox2.TabIndex = 18
        Me.checkBox2.Text = "Check Null"
        Me.checkBox2.UseVisualStyleBackColor = True
        Me.checkBox2.Visible = False
        '
        'checkBox3
        '
        Me.checkBox3.AutoSize = True
        Me.checkBox3.Enabled = False
        Me.checkBox3.ForeColor = System.Drawing.Color.White
        Me.checkBox3.Location = New System.Drawing.Point(5, 109)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(57, 17)
        Me.checkBox3.TabIndex = 19
        Me.checkBox3.Text = "Regex"
        Me.checkBox3.UseVisualStyleBackColor = True
        Me.checkBox3.Visible = False
        '
        'btnWork
        '
        Me.btnWork.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnWork.Enabled = False
        Me.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWork.Location = New System.Drawing.Point(5, 140)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.Size = New System.Drawing.Size(75, 23)
        Me.btnWork.TabIndex = 20
        Me.btnWork.Text = "Work"
        Me.btnWork.UseVisualStyleBackColor = False
        Me.btnWork.Visible = False
        '
        'lbAdd
        '
        Me.lbAdd.AutoSize = True
        Me.lbAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lbAdd.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbAdd.Location = New System.Drawing.Point(106, 153)
        Me.lbAdd.Name = "lbAdd"
        Me.lbAdd.Size = New System.Drawing.Size(32, 13)
        Me.lbAdd.TabIndex = 22
        Me.lbAdd.Text = "None"
        '
        'btnClean
        '
        Me.btnClean.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnClean.Enabled = False
        Me.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClean.Location = New System.Drawing.Point(172, 103)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 23
        Me.btnClean.Text = "Clean"
        Me.btnClean.UseVisualStyleBackColor = False
        '
        'FormSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(250, 300)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.lbAdd)
        Me.Controls.Add(Me.btnWork)
        Me.Controls.Add(Me.checkBox3)
        Me.Controls.Add(Me.checkBox2)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.lbCount2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.btnUpdateStat)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDBCreate)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pDown)
        Me.Controls.Add(Me.pHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSetting"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Setting"
        Me.pHead.ResumeLayout(False)
        Me.pHead.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pHead As Panel

    Friend WithEvents pDown As Panel

    Friend WithEvents label11 As Label

    Friend WithEvents label10 As Label

    Friend WithEvents label9 As Label

    Friend WithEvents label8 As Label

    Friend WithEvents label7 As Label

    Friend WithEvents label6 As Label

    Friend WithEvents label5 As Label

    Friend WithEvents label4 As Label

    Friend WithEvents label3 As Label

    Friend WithEvents label2 As Label

    Friend WithEvents lbExit As Label

    Friend WithEvents timer As System.Windows.Forms.Timer

    Friend WithEvents label1 As Label

    Friend WithEvents btnDBCreate As Button

    Friend WithEvents btnDelete As Button

    Friend WithEvents btnUpdateStat As Button

    Friend WithEvents panel1 As Panel

    Friend WithEvents lbCount2 As Label

    Friend WithEvents label14 As Label

    Friend WithEvents label13 As Label

    Friend WithEvents lbCount As Label

    Friend WithEvents btnAdd As Button

    Friend WithEvents panel2 As Panel

    Friend WithEvents panel3 As Panel

    Friend WithEvents panel4 As Panel

    Friend WithEvents checkBox1 As CheckBox

    Friend WithEvents checkBox2 As CheckBox

    Friend WithEvents checkBox3 As CheckBox

    Friend WithEvents btnWork As Button

    Friend WithEvents lbAdd As Label

    Friend WithEvents btnClean As Button
End Class
