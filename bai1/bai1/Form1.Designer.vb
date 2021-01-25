<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmauso1 = New System.Windows.Forms.TextBox()
        Me.txttuso1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.phanso2 = New System.Windows.Forms.GroupBox()
        Me.txtmauso2 = New System.Windows.Forms.TextBox()
        Me.txttuso2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtmauso3 = New System.Windows.Forms.TextBox()
        Me.txttuso3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdochia = New System.Windows.Forms.RadioButton()
        Me.rdonhan = New System.Windows.Forms.RadioButton()
        Me.rdotru = New System.Windows.Forms.RadioButton()
        Me.rdocong = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.phanso2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "tử số :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmauso1)
        Me.GroupBox1.Controls.Add(Me.txttuso1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Phân số 1"
        '
        'txtmauso1
        '
        Me.txtmauso1.Location = New System.Drawing.Point(69, 58)
        Me.txtmauso1.Name = "txtmauso1"
        Me.txtmauso1.Size = New System.Drawing.Size(100, 20)
        Me.txtmauso1.TabIndex = 3
        '
        'txttuso1
        '
        Me.txttuso1.Location = New System.Drawing.Point(69, 32)
        Me.txttuso1.Name = "txttuso1"
        Me.txttuso1.Size = New System.Drawing.Size(100, 20)
        Me.txttuso1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "mẫu số:"
        '
        'phanso2
        '
        Me.phanso2.Controls.Add(Me.txtmauso2)
        Me.phanso2.Controls.Add(Me.txttuso2)
        Me.phanso2.Controls.Add(Me.Label3)
        Me.phanso2.Controls.Add(Me.Label4)
        Me.phanso2.Location = New System.Drawing.Point(312, 48)
        Me.phanso2.Name = "phanso2"
        Me.phanso2.Size = New System.Drawing.Size(200, 100)
        Me.phanso2.TabIndex = 2
        Me.phanso2.TabStop = False
        Me.phanso2.Text = "Phân số 2"
        '
        'txtmauso2
        '
        Me.txtmauso2.Location = New System.Drawing.Point(69, 58)
        Me.txtmauso2.Name = "txtmauso2"
        Me.txtmauso2.Size = New System.Drawing.Size(100, 20)
        Me.txtmauso2.TabIndex = 3
        '
        'txttuso2
        '
        Me.txttuso2.Location = New System.Drawing.Point(69, 32)
        Me.txttuso2.Name = "txttuso2"
        Me.txttuso2.Size = New System.Drawing.Size(100, 20)
        Me.txttuso2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "mẫu số:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "tử số :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtmauso3)
        Me.GroupBox3.Controls.Add(Me.txttuso3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(57, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Phân số kết quả"
        '
        'txtmauso3
        '
        Me.txtmauso3.Enabled = False
        Me.txtmauso3.Location = New System.Drawing.Point(69, 58)
        Me.txtmauso3.Name = "txtmauso3"
        Me.txtmauso3.Size = New System.Drawing.Size(100, 20)
        Me.txtmauso3.TabIndex = 3
        '
        'txttuso3
        '
        Me.txttuso3.Enabled = False
        Me.txttuso3.Location = New System.Drawing.Point(69, 32)
        Me.txttuso3.Name = "txttuso3"
        Me.txttuso3.Size = New System.Drawing.Size(100, 20)
        Me.txttuso3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "mẫu số:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "tử số :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdochia)
        Me.GroupBox2.Controls.Add(Me.rdonhan)
        Me.GroupBox2.Controls.Add(Me.rdotru)
        Me.GroupBox2.Controls.Add(Me.rdocong)
        Me.GroupBox2.Location = New System.Drawing.Point(312, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chọn phép toán"
        '
        'rdochia
        '
        Me.rdochia.AutoSize = True
        Me.rdochia.Location = New System.Drawing.Point(0, 78)
        Me.rdochia.Name = "rdochia"
        Me.rdochia.Size = New System.Drawing.Size(87, 17)
        Me.rdochia.TabIndex = 3
        Me.rdochia.TabStop = True
        Me.rdochia.Text = "Chia phân số"
        Me.rdochia.UseVisualStyleBackColor = True
        '
        'rdonhan
        '
        Me.rdonhan.AutoSize = True
        Me.rdonhan.Location = New System.Drawing.Point(0, 57)
        Me.rdonhan.Name = "rdonhan"
        Me.rdonhan.Size = New System.Drawing.Size(92, 17)
        Me.rdonhan.TabIndex = 2
        Me.rdonhan.TabStop = True
        Me.rdonhan.Text = "Nhân phân số"
        Me.rdonhan.UseVisualStyleBackColor = True
        '
        'rdotru
        '
        Me.rdotru.AutoSize = True
        Me.rdotru.Location = New System.Drawing.Point(0, 38)
        Me.rdotru.Name = "rdotru"
        Me.rdotru.Size = New System.Drawing.Size(82, 17)
        Me.rdotru.TabIndex = 1
        Me.rdotru.TabStop = True
        Me.rdotru.Text = "Trừ phân số"
        Me.rdotru.UseVisualStyleBackColor = True
        '
        'rdocong
        '
        Me.rdocong.AutoSize = True
        Me.rdocong.Location = New System.Drawing.Point(0, 19)
        Me.rdocong.Name = "rdocong"
        Me.rdocong.Size = New System.Drawing.Size(91, 17)
        Me.rdocong.TabIndex = 0
        Me.rdocong.TabStop = True
        Me.rdocong.Text = "Cộng phân số"
        Me.rdocong.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 394)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.phanso2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.phanso2.ResumeLayout(False)
        Me.phanso2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmauso1 As System.Windows.Forms.TextBox
    Friend WithEvents txttuso1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents phanso2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmauso2 As System.Windows.Forms.TextBox
    Friend WithEvents txttuso2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmauso3 As System.Windows.Forms.TextBox
    Friend WithEvents txttuso3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdochia As System.Windows.Forms.RadioButton
    Friend WithEvents rdonhan As System.Windows.Forms.RadioButton
    Friend WithEvents rdotru As System.Windows.Forms.RadioButton
    Friend WithEvents rdocong As System.Windows.Forms.RadioButton

End Class
