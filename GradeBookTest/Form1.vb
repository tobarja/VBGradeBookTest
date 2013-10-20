Public Class Form1
    Dim StudentRecords() As StudentRecord
    Dim NumberOfGrades As Integer
    Dim Header As Panel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim StudentRecords(nudStudentCount.Value - 1)
        NumberOfGrades = nudNumberOfGrades.Value
        Header = StudentRecord.getHeader(NumberOfGrades)
        Me.flpHeader.Controls.Add(Header)
        For x = 0 To nudStudentCount.Value - 1
            StudentRecords(x) = New StudentRecord(NumberOfGrades)
        Next
        ReDrawRecordsPanel()
        Me.flpWorkSheet.AutoScroll = True
        Me.flpWorkSheet.PerformLayout()
    End Sub

    Private Sub nudStudentCount_ValueChanged(sender As Object, e As EventArgs) Handles nudStudentCount.ValueChanged
        If IsNothing(nudStudentCount) Or IsNothing(StudentRecords) Then
            Return
        End If
        Dim newCount As Integer = nudStudentCount.Value
        Dim oldCount As Integer = StudentRecords.Length
        If newCount > oldCount Then
            ReDim Preserve StudentRecords(newCount - 1)
            For x = oldCount To newCount - 1
                StudentRecords(x) = New StudentRecord(NumberOfGrades)
            Next
        ElseIf newCount < oldCount Then
            ReDim Preserve StudentRecords(newCount - 1)
        End If
        ReDrawRecordsPanel()

    End Sub

    Private Sub nudNumberOfGrades_ValueChanged(sender As Object, e As EventArgs) Handles nudNumberOfGrades.ValueChanged
        If IsNothing(nudNumberOfGrades) Or IsNothing(StudentRecords) Then
            Return
        End If
        Dim oldCount As Integer = NumberOfGrades
        Dim newCount As Integer = nudNumberOfGrades.Value

        If oldCount <> newCount Then
            Me.flpHeader.Controls.Clear()
            Me.flpHeader.Controls.Add(StudentRecord.getHeader(newCount))
            NumberOfGrades = newCount
            For Each record As StudentRecord In StudentRecords
                record.updateGradeCount(newCount)
            Next
            ReDrawRecordsPanel()
        End If
    End Sub

    Private Sub ReDrawRecordsPanel()
        Me.flpWorkSheet.SuspendLayout()
        Me.flpWorkSheet.Controls.Clear()
        For Each record As StudentRecord In StudentRecords
            Me.flpWorkSheet.Controls.Add(record.Row)
        Next
        Me.flpWorkSheet.ResumeLayout()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ReDrawRecordsPanel()
    End Sub
End Class
