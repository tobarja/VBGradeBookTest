Public Class Form1
    Dim StudentRecords() As StudentRecord

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim StudentRecords(2)
        For x = 0 To 1
            StudentRecords(x) = New StudentRecord(5)
            StudentRecords(x).Row.Location = New Point(50, (x * StudentRecords(x).Row.Height) + 1)
            Me.Controls.Add(StudentRecords(x).Row)
        Next
    End Sub
End Class
