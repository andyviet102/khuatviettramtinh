Public Class Class1
    Public ts As Integer
    Public ms As Integer
    Public Sub New()

    End Sub

    Public Sub New(ts As Integer, ms As Integer)
        Me.ts = ts
        Me.ms = ms

    End Sub
    Public Function Rutgon(ps As Class1) As Class1
        Dim ps1 As New Class1
        Dim a As Integer : Dim b As Integer
        a = ps.ts : b = ps.ms
        While a <> b
            If (a > b) Then
                a = a - b
            End If
            If (b > a) Then
                b = b - a
            End If
        End While
        ps1.ts = ps.ts / a : ps1.ms = ps.ms / a
        Return ps1
    End Function

    Public Function cong(ps1 As Class1, ps2 As Class1) As Class1
        Dim ps As New Class1
        ps.ts = (ps1.ts * ps2.ms) + (ps1.ms * ps2.ts)
        ps.ms = ps1.ms * ps2.ms
        Return ps
    End Function
End Class
