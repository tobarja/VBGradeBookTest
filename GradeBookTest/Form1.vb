Public Class Form1
    Dim StudentRecords() As StudentRecord

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim StudentRecords(nudStudentCount.Value)
        Me.flpWorkSheet.SuspendLayout()
        For x = 0 To nudStudentCount.Value - 1
            StudentRecords(x) = New StudentRecord(5)
            Me.flpWorkSheet.Controls.Add(StudentRecords(x).Row)
        Next
        Me.flpWorkSheet.ResumeLayout()
        Me.flpWorkSheet.AutoScroll = True
        Me.flpWorkSheet.PerformLayout()
    End Sub

End Class
