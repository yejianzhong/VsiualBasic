Public Class Form1

    '求最小数
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, min As Single
        a = InputBox("请输入", "求最小数")
        b = InputBox("请输入", "求最小数")
        c = InputBox("请输入", "求最小数")
        If a < b Then min = a Else min = b
        If c < min Then min = c

        MsgBox("最小数是" & min)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    '判断输入数
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Single
        a = InputBox("请输入", "判断输入数")
        If a > 0 Then
            MsgBox("a大于零")
        ElseIf a < 0 Then
            MsgBox("a小于零")
        Else
            MsgBox("a等于零")
        End If

    End Sub

    '季节查询
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nu As Integer
        nu = InputBox("请输入月份：", "季节查询")
        Select Case nu
            Case 1, 2, 12
                MsgBox("冬季", MsgBoxStyle.OkOnly, "查询结果")
            Case 3, 4, 5
                MsgBox("春季", MsgBoxStyle.OkOnly, "查询结果")
            Case 6, 7, 8
                MsgBox("夏季", MsgBoxStyle.OkOnly, "查询结果")
            Case 9, 10, 11
                MsgBox("秋季", MsgBoxStyle.OkOnly, "查询结果")
            Case Else
                MsgBox("输入错误", MsgBoxStyle.OkCancel, "查询结果")
        End Select
    End Sub
End Class
