<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_NO = New System.Windows.Forms.Label()
        Me.Button_run = New System.Windows.Forms.Button()
        Me.Button_rest = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_set = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_maxno = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "第"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(209, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "题"
        '
        'Label_NO
        '
        Me.Label_NO.AutoSize = True
        Me.Label_NO.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_NO.ForeColor = System.Drawing.Color.White
        Me.Label_NO.Location = New System.Drawing.Point(123, 30)
        Me.Label_NO.Name = "Label_NO"
        Me.Label_NO.Size = New System.Drawing.Size(80, 56)
        Me.Label_NO.TabIndex = 2
        Me.Label_NO.Text = "00"
        '
        'Button_run
        '
        Me.Button_run.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_run.ForeColor = System.Drawing.Color.Red
        Me.Button_run.Location = New System.Drawing.Point(86, 112)
        Me.Button_run.Name = "Button_run"
        Me.Button_run.Size = New System.Drawing.Size(155, 60)
        Me.Button_run.TabIndex = 3
        Me.Button_run.Text = "开始"
        Me.Button_run.UseVisualStyleBackColor = True
        '
        'Button_rest
        '
        Me.Button_rest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_rest.Location = New System.Drawing.Point(724, 593)
        Me.Button_rest.Name = "Button_rest"
        Me.Button_rest.Size = New System.Drawing.Size(75, 23)
        Me.Button_rest.TabIndex = 4
        Me.Button_rest.Text = "重新出题"
        Me.Button_rest.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button_run)
        Me.Panel1.Controls.Add(Me.Label_NO)
        Me.Panel1.Location = New System.Drawing.Point(341, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 212)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(703, 641)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "版本Ver 0.2  版权所有:太原市博长智惠科贸有限公司"
        '
        'Button_set
        '
        Me.Button_set.Location = New System.Drawing.Point(805, 593)
        Me.Button_set.Name = "Button_set"
        Me.Button_set.Size = New System.Drawing.Size(75, 23)
        Me.Button_set.TabIndex = 7
        Me.Button_set.Text = "设置"
        Me.Button_set.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(886, 598)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "最大题目数:"
        '
        'Label_maxno
        '
        Me.Label_maxno.AutoSize = True
        Me.Label_maxno.ForeColor = System.Drawing.Color.White
        Me.Label_maxno.Location = New System.Drawing.Point(963, 598)
        Me.Label_maxno.Name = "Label_maxno"
        Me.Label_maxno.Size = New System.Drawing.Size(11, 12)
        Me.Label_maxno.TabIndex = 9
        Me.Label_maxno.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.Label_maxno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button_set)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_rest)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "万柏林区专武干部竞争性选拔面试考场"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_NO As Label
    Friend WithEvents Button_run As Button
    Friend WithEvents Button_rest As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_set As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_maxno As Label
End Class
