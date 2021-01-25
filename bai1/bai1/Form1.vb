Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rdochia.CheckedChanged

    End Sub

    Private Sub rdocong_CheckedChanged(sender As Object, e As EventArgs) Handles rdocong.CheckedChanged
        If (rdocong.Checked = True) Then
            Dim ob1 As New Class1(Convert.ToInt32(txttuso1.Text), Convert.ToInt32(txtmauso1.Text))
            Dim ob2 As New Class1(Convert.ToInt32(txttuso2.Text), Convert.ToInt32(txtmauso2.Text))
            Dim kq As New Class1
            kq = kq.cong(ob1, ob2)
            kq = kq.Rutgon(kq)
            txttuso3.Text = kq.ts.ToString()
            txtmauso3.Text = kq.ts.ToString()
        End If
    End Sub

    Private Sub rdotru_CheckedChanged(sender As Object, e As EventArgs) Handles rdotru.CheckedChanged
        If (rdotru.Checked = True) Then
            Dim ob1 As New Class1(Convert.ToInt32(txttuso1.Text))
        End If
    End Sub
End Class
