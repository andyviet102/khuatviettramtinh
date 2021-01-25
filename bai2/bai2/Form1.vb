Imports System.Collections
Public Class Form1
    Dim kh As New ArrayList()

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txttiendien.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtsocu.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtchisomoi.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.Columns.Add("họ tên KH", 100)
        ListView1.Columns.Add("dien tien thu", 70)
        ListView1.Columns.Add("thanh tien", 100)
    End Sub

    Private Sub btntinh_Click(sender As Object, e As EventArgs) Handles btntinh.Click
        Dim dtt As Long
        Dim tt As Long
        dtt = Convert.ToInt64(txtchisomoi.Text) - Convert.ToInt64(txtsocu.Text)
        tt = dtt * Convert.ToInt64(txttiendien.Text)
        Dim kh1 As New Class1(txttenkh.Text, dtt, Convert.ToInt64(txttiendien.Text), tt)
        kh.Add(kh1)
        ListView1.Items.Clear()
        Dim arr(3) As String
        Dim itemlv As ListViewItem
        For Each item As Class1 In kh
            arr(0) = item.tenkh
            arr(1) = item.dtt
            arr(2) = item.tt
            itemlv = New ListViewItem(arr)
            ListView1.Items.Add(itemlv)
        Next
        txtthanhtien.Text = tt.ToString()
    End Sub
End Class
