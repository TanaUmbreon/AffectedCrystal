''' <summary>キャンバスサイズを設定するダイアログフォームです</summary>
Public Class CanvasDialog

	Private _drawingConf As New DrawingConfig()

	''' <summary>フォームをダイアログウィンドウで表示します</summary>
	''' <param name="owner">呼びだしたフォーム</param>
	''' <param name="drawingConf">現在の設定情報</param>
	Public Overloads Function ShowDialog(ByVal owner As IWin32Window, ByVal drawingConf As DrawingConfig) As DialogResult
		_drawingConf = DirectCast(drawingConf.Clone(), DrawingConfig)

		With nudCanvasWidth
			.Minimum = CDec(DrawingConfig.MinCanvasSize.Width)
			.Maximum = CDec(DrawingConfig.MaxCanvasSize.Width)
			.Value = CDec(_drawingConf.CanvasSize.Width)
		End With
		With nudCanvasHeight
			.Minimum = CDec(DrawingConfig.MinCanvasSize.Height)
			.Maximum = CDec(DrawingConfig.MaxCanvasSize.Height)
			.Value = CDec(_drawingConf.CanvasSize.Height)
		End With

		Return Me.ShowDialog(owner)
	End Function


	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
		DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub CanvasSizeDialog_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		_drawingConf.CanvasSize = New Size(CInt(nudCanvasWidth.Value), CInt(nudCanvasHeight.Value))
	End Sub


	''' <summary>描画関係の設定情報を取得します</summary>
	Public ReadOnly Property DrawingConf() As DrawingConfig
		Get
			Return _drawingConf
		End Get
	End Property

End Class