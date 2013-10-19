Public Class StudentRecord
    Dim Name As TextBox
    Dim GradeBlock() As TextBox
    Dim txtAverage As TextBox
    Public Row As Panel
    Public Sub New(NumGrades)
        Row = New Panel
        Row.BorderStyle = BorderStyle.Fixed3D
        Row.Size = New Drawing.Size(700, 30)

        Name = New TextBox
        Name.Location = New Point(5, 5)
        Row.Controls.Add(Name)

        Dim lc As Integer
        ReDim GradeBlock(NumGrades)
        For lc = 0 To NumGrades - 1
            GradeBlock(lc) = New TextBox
            GradeBlock(lc).Size = New Drawing.Size(30, 20)
            GradeBlock(lc).Location = New Point(75 + (40 * (lc + 1)), 5)
            AddHandler GradeBlock(lc).TextChanged, AddressOf EditHandler
            Row.Controls.Add(GradeBlock(lc))
        Next
        txtAverage = New TextBox
        txtAverage.Location = New Point(80 + (40 * (lc + 1)), 5)
        Row.Controls.Add(txtAverage)
    End Sub

    Public Sub EditHandler()
        Dim thisGrade As Decimal
        Dim totGrades As Decimal
        Dim numGrades As Integer
        For Each grade As TextBox In GradeBlock
            If Not IsNothing(grade) Then
                If Decimal.TryParse(grade.Text, thisGrade) Then
                    totGrades += thisGrade
                    numGrades += 1
                End If
            End If
        Next
        If numGrades > 0 Then
            txtAverage.Text = (totGrades / numGrades).ToString()
        End If
    End Sub
End Class
