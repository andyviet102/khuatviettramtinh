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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtsocu = New System.Windows.Forms.TextBox()
        Me.txtchisomoi = New System.Windows.Forms.TextBox()
        Me.txttiendien = New System.Windows.Forms.TextBox()
        Me.txtthanhtien = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btntinh = New System.Windows.Forms.Button()
        Me.btnnhap = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txttongtien = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BẢNG THANH TOÁN TIỀN ĐIỆN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ tên KH:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chỉ số cũ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Chỉ số mới"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tiền điện"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Thành tiền"
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(114, 56)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(100, 20)
        Me.txttenkh.TabIndex = 6
        '
        'txtsocu
        '
        Me.txtsocu.Location = New System.Drawing.Point(114, 96)
        Me.txtsocu.Name = "txtsocu"
        Me.txtsocu.Size = New System.Drawing.Size(100, 20)
        Me.txtsocu.TabIndex = 7
        '
        'txtchisomoi
        '
        Me.txtchisomoi.Location = New System.Drawing.Point(114, 140)
        Me.txtchisomoi.Name = "txtchisomoi"
        Me.txtchisomoi.Size = New System.Drawing.Size(100, 20)
        Me.txtchisomoi.TabIndex = 8
        '
        'txttiendien
        '
        Me.txttiendien.Location = New System.Drawing.Point(114, 179)
        Me.txttiendien.Name = "txttiendien"
        Me.txttiendien.Size = New System.Drawing.Size(100, 20)
        Me.txttiendien.TabIndex = 9
        '
        'txtthanhtien
        '
        Me.txtthanhtien.Enabled = False
        Me.txtthanhtien.Location = New System.Drawing.Point(114, 218)
        Me.txtthanhtien.Name = "txtthanhtien"
        Me.txtthanhtien.Size = New System.Drawing.Size(100, 20)
        Me.txtthanhtien.TabIndex = 10
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(332, 56)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(365, 182)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btntinh
        '
        Me.btntinh.Location = New System.Drawing.Point(78, 276)
        Me.btntinh.Name = "btntinh"
        Me.btntinh.Size = New System.Drawing.Size(75, 23)
        Me.btntinh.TabIndex = 12
        Me.btntinh.Text = "Tính tiền"
        Me.btntinh.UseVisualStyleBackColor = True
        '
        'btnnhap
        '
        Me.btnnhap.Location = New System.Drawing.Point(186, 276)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(75, 23)
        Me.btnnhap.TabIndex = 13
        Me.btnnhap.Text = "Nhập mới"
        Me.btnnhap.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(78, 305)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Tổng tiền của các khách hàng"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txttongtien
        '
        Me.txttongtien.Enabled = False
        Me.txttongtien.Location = New System.Drawing.Point(267, 305)
        Me.txttongtien.Name = "txttongtien"
        Me.txttongtien.Size = New System.Drawing.Size(165, 20)
        Me.txttongtien.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 357)
        Me.Controls.Add(Me.txttongtien)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnnhap)
        Me.Controls.Add(Me.btntinh)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtthanhtien)
        Me.Controls.Add(Me.txttiendien)
        Me.Controls.Add(Me.txtchisomoi)
        Me.Controls.Add(Me.txtsocu)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtsocu As System.Windows.Forms.TextBox
    Friend WithEvents txtchisomoi As System.Windows.Forms.TextBox
    Friend WithEvents txttiendien As System.Windows.Forms.TextBox
    Friend WithEvents txtthanhtien As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btntinh As System.Windows.Forms.Button
    Friend WithEvents btnnhap As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txttongtien As System.Windows.Forms.TextBox

End Class
