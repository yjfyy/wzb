Public Class Form1
    Dim no
    Dim biaohao = -1
    Dim maxno
    Private Sub Button_run_Click(sender As Object, e As EventArgs) Handles Button_run.Click
        Try
            If biaohao = maxno Or biaohao = -1 Then
                MsgBox("无题，或题已出完，请出题！")
            Else
                Label_NO.Text = no(biaohao)
                biaohao = biaohao + 1
            End If
        Catch ex As Exception
            MsgBox("无题，或题已出完，请出题！")
        End Try


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
        If Now() > CDate("2018.3.1") Then
            Me.Close()
        End If


        Me.BackgroundImage = Image.FromFile("bj.bmp")
    End Sub

    Private Sub Button1_rest(sender As Object, e As EventArgs) Handles Button_rest.Click
        If MsgBox("出题将覆盖记录，确认重新出题？", vbQuestion + vbYesNo) = vbYes Then
            Try
                no = MakeRndSum(1, maxno, maxno)
                biaohao = 0
            Catch ex As Exception
                MsgBox("题数错误！")
            End Try

        Else

        End If

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Panel1.Left = (Me.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.Height - Panel1.Height) \ 2
    End Sub

    Private Sub Button_set_Click(sender As Object, e As EventArgs) Handles Button_set.Click
        maxno = InputBox("请输入最大题目数:")
        Label_maxno.Text = maxno
    End Sub
End Class
