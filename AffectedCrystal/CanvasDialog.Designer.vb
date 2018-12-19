<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CanvasDialog
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

	'Windows フォーム デザイナで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
	'Windows フォーム デザイナを使用して変更できます。  
	'コード エディタを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.nudCanvasWidth = New System.Windows.Forms.NumericUpDown
		Me.nudCanvasHeight = New System.Windows.Forms.NumericUpDown
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		CType(Me.nudCanvasWidth, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCanvasHeight, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnOk
		'
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.Location = New System.Drawing.Point(106, 98)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 6
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(187, 98)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 7
		Me.btnCancel.Text = "キャンセル"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'nudCanvasWidth
		'
		Me.nudCanvasWidth.Increment = New Decimal(New Integer() {20, 0, 0, 0})
		Me.nudCanvasWidth.Location = New System.Drawing.Point(61, 18)
		Me.nudCanvasWidth.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
		Me.nudCanvasWidth.Name = "nudCanvasWidth"
		Me.nudCanvasWidth.Size = New System.Drawing.Size(72, 19)
		Me.nudCanvasWidth.TabIndex = 1
		Me.nudCanvasWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudCanvasHeight
		'
		Me.nudCanvasHeight.Increment = New Decimal(New Integer() {20, 0, 0, 0})
		Me.nudCanvasHeight.Location = New System.Drawing.Point(61, 43)
		Me.nudCanvasHeight.Name = "nudCanvasHeight"
		Me.nudCanvasHeight.Size = New System.Drawing.Size(72, 19)
		Me.nudCanvasHeight.TabIndex = 4
		Me.nudCanvasHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(30, 20)
		Me.Label1.Margin = New System.Windows.Forms.Padding(21, 0, 3, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(17, 12)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "幅"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(30, 45)
		Me.Label2.Margin = New System.Windows.Forms.Padding(21, 0, 3, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(25, 12)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "高さ"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(139, 20)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 12)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "ピクセル"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(139, 45)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(42, 12)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "ピクセル"
		'
		'CanvasDialog
		'
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(274, 133)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.nudCanvasHeight)
		Me.Controls.Add(Me.nudCanvasWidth)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOk)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "CanvasDialog"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "キャンバスのサイズ"
		CType(Me.nudCanvasWidth, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCanvasHeight, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnOk As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents nudCanvasWidth As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudCanvasHeight As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
