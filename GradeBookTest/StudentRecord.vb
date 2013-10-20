Public Class StudentRecord
    Dim Name As TextBox
    Dim GradeBlock() As TextBox
    Dim NumGrades As Integer
    Dim txtAverage As TextBox
    Public Row As Panel
    Public Sub New(NumGrades)
        Me.NumGrades = NumGrades
        LayoutGradeRow()
    End Sub

    Public Shared Function getHeader(NumGrades)
        Dim Header As Panel = New Panel
        Dim GradeHeader(NumGrades - 1) As Label

        Dim Name As Label = New Label
        Name.Text = "Name"
        Name.Location = New Drawing.Size(5, 5)

        With Header
            .Size = New Drawing.Size(670, 25)
            .Controls.Add(Name)
            For x As Integer = 0 To NumGrades - 1
                GradeHeader(x) = New Label
                GradeHeader(x).Location = New Point(80 + (40 * (x + 1)), 5)
                GradeHeader(x).AutoSize = True
                GradeHeader(x).Text = "G" & (x + 1)
                .Controls.Add(GradeHeader(x))
            Next
            Dim lblAverage As Label = New Label
            lblAverage.Location = New Point(82 + (40 * (NumGrades + 1)), 5)
            lblAverage.Text = "Average"
            .Controls.Add(lblAverage)
        End With
        Return Header
    End Function

    Public Sub UpdateAverage()
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

    Sub updateGradeCount(newCount As Integer)
        Dim oldCount As Integer = GradeBlock.Length
        If newCount <> oldCount Then
            NumGrades = newCount
            LayoutGradeRow()
        End If
    End Sub

    Private Sub LayoutGradeRow()
        Row = New Panel
        Row.BorderStyle = BorderStyle.Fixed3D
        Row.Size = New Drawing.Size(670, 30)

        Name = New TextBox
        Name.Location = New Point(5, 5)
        Row.Controls.Add(Name)

        Dim lc As Integer
        ReDim Preserve GradeBlock(NumGrades - 1)
        For lc = 0 To NumGrades - 1
            If IsNothing(GradeBlock(lc)) Then
                GradeBlock(lc) = New TextBox
                GradeBlock(lc).Size = New Drawing.Size(30, 20)
                GradeBlock(lc).Location = New Point(75 + (40 * (lc + 1)), 5)
                AddHandler GradeBlock(lc).TextChanged, AddressOf UpdateAverage
            End If
            Row.Controls.Add(GradeBlock(lc))
        Next
        txtAverage = New TextBox
        txtAverage.Location = New Point(80 + (40 * (lc + 1)), 5)
        Row.Controls.Add(txtAverage)
        UpdateAverage()
    End Sub

End Class
