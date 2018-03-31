Public Class Form1
    Dim no
    Dim biaohao = 0
    Private Sub Button_run_Click(sender As Object, e As EventArgs) Handles Button_run.Click

        Label_NO.Text = no(biaohao)
        If biaohao = 35 Then
            MsgBox("题以出完")
        Else
            biaohao = biaohao + 1
        End If

    End Sub
    Public Function MakeRndSum(ByVal iMin As Integer, ByVal iMax As Integer, ByVal iSum As Integer) As Integer()
        '**************************************
        '功能:随机生成iMin到iMax之间的iSum个数,将结果作为数组返回给调用程序
        '参数:iMin,最小取值,没有则无限制
        '     iMax,最大取值,没有则无限制
        '     iSum,需要生成的随机数的个数
        '返回值:调用成功,返回一个数组,且数组大小不为0
        '       调用失败,返回一个大小为零的数组
        '**************************************

        Dim iI, iJ, iNum, iTemp As Integer
        Dim aiSult() As Integer

        ReDim aiSult(iSum)

        iNum = 0
        For iI = 0 To iSum - 1

Line1:
            Randomize()
            iTemp = CInt(iMin + Rnd() * (iMax - iMin))

            '判断是否有重复的数据
            For iJ = 0 To iI - 1
                If iTemp = aiSult(iJ) Then
                    GoTo Line1
                End If
            Next

            '保存数据
            aiSult(iNum) = iTemp
            iNum = iNum + 1

        Next

        Return aiSult

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        no = MakeRndSum(1, 35, 35)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("重新开始", vbQuestion + vbYesNo) = vbYes Then
            no = MakeRndSum(1, 35, 35)
            biaohao = 0
        Else

        End If
    End Sub
End Class
