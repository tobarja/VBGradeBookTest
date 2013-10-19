Public Class Form1
    Dim StudentRecords() As StudentRecord
    Dim NumberOfGrades As Integer
    Dim Header As Panel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim StudentRecords(nudStudentCount.Value)
        NumberOfGrades = nudNumberOfGrades.Value
        Header = StudentRecord.getHeader(NumberOfGrades)
        Me.flpHeader.Controls.Add(Header)
        Me.flpWorkSheet.SuspendLayout()
        For x = 0 To nudStudentCount.Value - 1
            StudentRecords(x) = New StudentRecord(NumberOfGrades)
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

    Private Sub nudNumberOfGrades_ValueChanged(sender As Object, e As EventArgs) Handles nudNumberOfGrades.ValueChanged
        If IsNothing(nudNumberOfGrades) Then
            Return
        End If
        Dim oldCount As Integer = NumberOfGrades
        Dim newCount As Integer = nudNumberOfGrades.Value

        If oldCount <> newCount Then
            Me.flpHeader.Controls.Clear()
            Me.flpHeader.Controls.Add(StudentRecord.getHeader(newCount))
            NumberOfGrades = newCount
        End If
    End Sub
End Class
