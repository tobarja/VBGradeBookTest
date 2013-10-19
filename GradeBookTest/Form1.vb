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

    Private Sub nudStudentCount_ValueChanged(sender As Object, e As EventArgs) Handles nudStudentCount.ValueChanged
        If IsNothing(nudStudentCount) Or IsNothing(StudentRecords) Then
            Return
        End If
        Me.flpWorkSheet.SuspendLayout()
        Dim newCount As Integer = nudStudentCount.Value
        Dim oldCount As Integer = StudentRecords.GetUpperBound(0)
        If newCount > oldCount Then
            ReDim Preserve StudentRecords(newCount)
            For x = oldCount To newCount - 1
                StudentRecords(x) = New StudentRecord(5)
                Me.flpWorkSheet.Controls.Add(StudentRecords(x).Row)
            Next
        ElseIf newCount < oldCount Then
            For x = oldCount - 1 To newCount Step -1
                Me.flpWorkSheet.Controls.RemoveAt(x)
            Next
            ReDim Preserve StudentRecords(newCount)
        End If
        Me.flpWorkSheet.ResumeLayout()

    End Sub
End Class
