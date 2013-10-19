<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nudStudentCount = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flpWorkSheet = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudNumberOfGrades = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudStudentCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudStudentCount
        '
        Me.nudStudentCount.Location = New System.Drawing.Point(136, 17)
        Me.nudStudentCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStudentCount.Name = "nudStudentCount"
        Me.nudStudentCount.Size = New System.Drawing.Size(63, 20)
        Me.nudStudentCount.TabIndex = 1
        Me.nudStudentCount.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of Students:"
        '
        'flpWorkSheet
        '
        Me.flpWorkSheet.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpWorkSheet.Location = New System.Drawing.Point(29, 87)
        Me.flpWorkSheet.Name = "flpWorkSheet"
        Me.flpWorkSheet.Size = New System.Drawing.Size(700, 279)
        Me.flpWorkSheet.TabIndex = 0
        Me.flpWorkSheet.WrapContents = False
        '
        'flpHeader
        '
        Me.flpHeader.Location = New System.Drawing.Point(29, 57)
        Me.flpHeader.Name = "flpHeader"
        Me.flpHeader.Size = New System.Drawing.Size(700, 30)
        Me.flpHeader.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number of Grades:"
        '
        'nudNumberOfGrades
        '
        Me.nudNumberOfGrades.Location = New System.Drawing.Point(332, 15)
        Me.nudNumberOfGrades.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfGrades.Name = "nudNumberOfGrades"
        Me.nudNumberOfGrades.Size = New System.Drawing.Size(63, 20)
        Me.nudNumberOfGrades.TabIndex = 4
        Me.nudNumberOfGrades.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 386)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudNumberOfGrades)
        Me.Controls.Add(Me.flpHeader)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudStudentCount)
        Me.Controls.Add(Me.flpWorkSheet)
        Me.Name = "Form1"
        Me.Text = "GradeBook"
        CType(Me.nudStudentCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudStudentCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents flpWorkSheet As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudNumberOfGrades As System.Windows.Forms.NumericUpDown

End Class
