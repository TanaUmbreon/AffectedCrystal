<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VersionForm
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
		Me.btnClose = New System.Windows.Forms.Button
		Me.pctIcon = New System.Windows.Forms.PictureBox
		Me.lblApplicationName = New System.Windows.Forms.Label
		Me.lblVersion = New System.Windows.Forms.Label
		Me.lblCopyright = New System.Windows.Forms.Label
		CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Location = New System.Drawing.Point(227, 82)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 23)
		Me.btnClose.TabIndex = 0
		Me.btnClose.Text = "閉じる"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'pctIcon
		'
		Me.pctIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.pctIcon.Location = New System.Drawing.Point(18, 24)
		Me.pctIcon.Margin = New System.Windows.Forms.Padding(9, 15, 9, 9)
		Me.pctIcon.Name = "pctIcon"
		Me.pctIcon.Size = New System.Drawing.Size(32, 32)
		Me.pctIcon.TabIndex = 1
		Me.pctIcon.TabStop = False
		'
		'lblApplicationName
		'
		Me.lblApplicationName.AutoSize = True
		Me.lblApplicationName.Location = New System.Drawing.Point(68, 15)
		Me.lblApplicationName.Margin = New System.Windows.Forms.Padding(9, 6, 3, 3)
		Me.lblApplicationName.Name = "lblApplicationName"
		Me.lblApplicationName.Size = New System.Drawing.Size(91, 12)
		Me.lblApplicationName.TabIndex = 1
		Me.lblApplicationName.Text = "ApplicationName"
		'
		'lblVersion
		'
		Me.lblVersion.AutoSize = True
		Me.lblVersion.Location = New System.Drawing.Point(68, 36)
		Me.lblVersion.Margin = New System.Windows.Forms.Padding(9, 6, 3, 3)
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(44, 12)
		Me.lblVersion.TabIndex = 2
		Me.lblVersion.Text = "Version"
		'
		'lblCopyright
		'
		Me.lblCopyright.AutoSize = True
		Me.lblCopyright.Location = New System.Drawing.Point(68, 57)
		Me.lblCopyright.Margin = New System.Windows.Forms.Padding(9, 6, 3, 3)
		Me.lblCopyright.Name = "lblCopyright"
		Me.lblCopyright.Size = New System.Drawing.Size(54, 12)
		Me.lblCopyright.TabIndex = 3
		Me.lblCopyright.Text = "Copyright"
		'
		'VersionForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(314, 117)
		Me.Controls.Add(Me.lblCopyright)
		Me.Controls.Add(Me.lblVersion)
		Me.Controls.Add(Me.lblApplicationName)
		Me.Controls.Add(Me.pctIcon)
		Me.Controls.Add(Me.btnClose)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "VersionForm"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "バージョン情報"
		CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents pctIcon As System.Windows.Forms.PictureBox
	Friend WithEvents lblApplicationName As System.Windows.Forms.Label
	Friend WithEvents lblVersion As System.Windows.Forms.Label
	Friend WithEvents lblCopyright As System.Windows.Forms.Label

End Class
