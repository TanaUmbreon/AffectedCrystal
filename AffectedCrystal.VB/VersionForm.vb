Public Class VersionForm

	Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'各項目は自動的に表示されます。
		'なお、任意の表示を行いたい場合は、目的の項目を直接変更してください。

		With My.Application
			'メインフォームのアイコンを表示
			pctIcon.Image = .ApplicationContext.MainForm.Icon.ToBitmap

			'アセンブリ情報の製品名を表示
			lblApplicationName.Text = .Info.ProductName

			'アセンブリ情報のバージョンを表示
			lblVersion.Text = "Version " & .Info.Version.ToString(3)

			'アセンブリ情報の著作権を表示
			lblCopyright.Text = .Info.Copyright
		End With
	End Sub

	Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
End Class
