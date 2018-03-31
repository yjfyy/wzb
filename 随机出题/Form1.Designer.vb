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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_NO = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button_run = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(362, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "第"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(534, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "题"
        '
        'Label_NO
        '
        Me.Label_NO.AutoSize = True
        Me.Label_NO.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_NO.ForeColor = System.Drawing.Color.Red
        Me.Label_NO.Location = New System.Drawing.Point(448, 286)
        Me.Label_NO.Name = "Label_NO"
        Me.Label_NO.Size = New System.Drawing.Size(52, 56)
        Me.Label_NO.TabIndex = 2
        Me.Label_NO.Text = "0"
        '
        'Button_run
        '
        Me.Button_run.Font = New System.Drawing.Font("宋体", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_run.Location = New System.Drawing.Point(405, 368)
        Me.Button_run.Name = "Button_run"
        Me.Button_run.Size = New System.Drawing.Size(155, 50)
        Me.Button_run.TabIndex = 3
        Me.Button_run.Text = "开始"
        Me.Button_run.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(905, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "重新开始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_run)
        Me.Controls.Add(Me.Label_NO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "随机出题"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_NO As Label
    Friend WithEvents Button_run As Button
    Friend WithEvents Button1 As Button
End Class
