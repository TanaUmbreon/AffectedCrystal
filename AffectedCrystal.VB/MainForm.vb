Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

''' <summary>Crystalのまねごとをするフォームです</summary>
Public Class MainForm

#Region "フィールド"

	Private Const AppConfFileName As String = "affectedcrystal.conf"

	''' <summary>アプリケーションの設定情報</summary>
	Private appConf As AppConfig

	''' <summary>描画対象のキャンバス</summary>
	Private canvas As Image
	''' <summary>キャンバスへの描画に使うペン</summary>
	Private pen As Pen
	''' <summary>キャンバスへの描画に使うブラシ</summary>
	Private brush As SolidBrush
	''' <summary>描画オブジェクト</summary>
	Private drawer As IDrawer
	''' <summary>円描画時の座標補正値</summary>
	Private drawingCrr As Integer

	''' <summary>キャンバスへのグラフィックオブジェクト</summary>
	Private canvasG As Graphics
	''' <summary>ピクチャボックスへのグラフィックオブジェクト</summary>
	''' <remarks>描画した線をすぐに表示させるために使用</remarks>
	Private pctG As Graphics
	''' <summary>キャンバスの中心座標</summary>
	Private canvasCenterPoint As Point
	''' <summary>描画時、直前にマウスがポイントしていた位置</summary>
	Private oldPoint As Point

	''' <summary>描画していることを示すフラグ</summary>
	Private drawing As Boolean

#End Region

	''' <summary>フィールドを初期化します</summary>
	Private Sub InitFields()
		appConf = LoadAppConf()

		' フィールドのメンバをインスタンス化
		canvas = New Bitmap(1, 1)
		pen = New Pen(Color.Black, 1.0F)
		brush = New SolidBrush(Color.Black)
		drawer = New NormalDrawer()
		drawingCrr = 0

		canvasG = Graphics.FromImage(canvas)
		pctG = pctCanvas.CreateGraphics()
		canvasCenterPoint = New Point(0, 0)
		oldPoint = New Point(0, 0)

		drawing = False

        ' コントロールの設定
        Icon = My.Resources.Icon
        Text = My.Application.Info.ProductName
		Bounds = appConf.WindowConf.MainBounds
		WindowState = appConf.WindowConf.MainWindowState

		' 読み込んだ設定情報を適用
		ApplyCanvas()
		ApplyDrawer()
		ApplyPen()
	End Sub

	''' <summary>フィールドを開放します</summary>
	Private Sub DisposeFields()
		SaveAppConf()

		pctG.Dispose()
		canvasG.Dispose()
		brush.Dispose()
		pen.Dispose()
		canvas.Dispose()
	End Sub

	''' <summary>アプリケーションの設定情報を読み込み、取得します</summary>
	''' <remarks>読み込みに失敗した場合は規定の設定情報が返ります</remarks>
	Private Function LoadAppConf() As AppConfig
		Dim appConf As AppConfig

		Try
			Using fs As New FileStream(AppConfFileName, FileMode.Open)
				Dim bf As New BinaryFormatter()
				appConf = DirectCast(bf.Deserialize(fs), AppConfig)
			End Using
		Catch ex As Exception
			appConf = New AppConfig()
		End Try

		Return appConf
	End Function

	''' <summary>アプリケーションの設定情報を保存します</summary>
	Private Sub SaveAppConf()
		With appConf.WindowConf
			.MainWindowState = WindowState
			WindowState = FormWindowState.Normal
			.MainBounds = Bounds
		End With

		Try
			Using fs As New FileStream(AppConfFileName, FileMode.Create)
				Dim bf As New BinaryFormatter()
				bf.Serialize(fs, appConf)
			End Using
		Catch ex As Exception
			' 書き込み失敗時は何もしない
		End Try
	End Sub

#Region "各設定情報への設定を行うメソッド"

	Private Sub SetCanvasBgColor(ByVal color As Color)
		appConf.DrawingConf.CanvasBgColor = color
	End Sub

	Private Sub SetCanvasSize(ByVal size As Size, Optional ByVal apply As Boolean = True)
		appConf.DrawingConf.CanvasSize = size
		If apply Then
			ApplyCanvas()
		End If
	End Sub

	''' <summary>設定情報に描画モードの種類を設定します</summary>
	''' <param name="type">描画モードの種類</param>
	Private Sub SetDrawerType(ByVal type As DrawerType, Optional ByVal apply As Boolean = True)
		appConf.DrawingConf.DrawerType = type
		If apply Then
			ApplyDrawer()
		End If
	End Sub

	Private Sub SetPenColor(ByVal color As Color, Optional ByVal apply As Boolean = True)
		appConf.DrawingConf.PenColor = color
		If apply Then
			ApplyPen()
		End If
	End Sub

	Private Sub SetPenWidth(ByVal width As Single, Optional ByVal apply As Boolean = True)
		appConf.DrawingConf.PenWidth = width
		If apply Then
			ApplyPen()
		End If
	End Sub

#End Region

#Region "現在の設定情報を適用するメソッド"

	''' <summary>現在の設定をキャンバスに適用します</summary>
	Private Sub ApplyCanvas()
		Using _
		 oldCanvas As Image = canvas, _
		 oldCanvasG As Graphics = canvasG, _
		 oldPctG As Graphics = pctG, _
		 brush As New SolidBrush(appConf.DrawingConf.CanvasBgColor)

			With appConf.DrawingConf.CanvasSize
				canvas = New Bitmap(.Width, .Height)
			End With

			pctCanvas.Size = canvas.Size
			pctCanvas.Image = canvas

			canvasG = Graphics.FromImage(canvas)
			pctG = pctCanvas.CreateGraphics()
			canvasCenterPoint = New Point(canvas.Size.Width / 2, canvas.Size.Height / 2)

			canvasG.FillRectangle(brush, 0, 0, canvas.Width, canvas.Height)
		End Using
	End Sub

	''' <summary>現在の設定情報を描画オブジェクトに適用します</summary>
	Private Sub ApplyDrawer()
		Select Case appConf.DrawingConf.DrawerType
			Case DrawerType.Normal
				drawer = New NormalDrawer()
			Case DrawerType.LeftRightMirror
				drawer = New LeftRightMirrorDrawer()
			Case DrawerType.UpDownMirror
				drawer = New UpDownMirrorDrawer()
			Case DrawerType.LeftRightUpDownMirror
				drawer = New LeftRightUpDownMirrorDrawer()
			Case DrawerType.Rotate3
				drawer = New RotateDrawer(3)
			Case DrawerType.Rotate3Mirror
				drawer = New RotateMirrorDrawer(3)
			Case DrawerType.Rotate4
				drawer = New RotateDrawer(4)
			Case DrawerType.Rotate4Mirror
				drawer = New RotateMirrorDrawer(4)
			Case DrawerType.Rotate5
				drawer = New RotateDrawer(5)
			Case DrawerType.Rotate5Mirror
				drawer = New RotateMirrorDrawer(5)
			Case DrawerType.Rotate6
				drawer = New RotateDrawer(6)
			Case DrawerType.Rotate6Mirror
				drawer = New RotateMirrorDrawer(6)
			Case DrawerType.Rotate8
				drawer = New RotateDrawer(8)
			Case DrawerType.Rotate8Mirror
				drawer = New RotateMirrorDrawer(8)
			Case DrawerType.Rotate12
				drawer = New RotateDrawer(12)
			Case DrawerType.Rotate12Mirror
				drawer = New RotateMirrorDrawer(12)
			Case DrawerType.Rotate16
				drawer = New RotateDrawer(16)
			Case DrawerType.Rotate24
				drawer = New RotateDrawer(24)
			Case DrawerType.Rotate32
				drawer = New RotateDrawer(32)
			Case DrawerType.Rotate64
				drawer = New RotateDrawer(64)
			Case Else
				drawer = New NormalDrawer()
		End Select

		tsslDrawingType.Text = AffectedCrystalConvert.ToString(appConf.DrawingConf.DrawerType)
	End Sub

	''' <summary>現在の設定情報を、キャンバスへの描画に使うペンに適用します</summary>
	Private Sub ApplyPen()
		With appConf.DrawingConf
			pen.Color = .PenColor
			pen.Width = .PenWidth
			brush.Color = .PenColor
			drawingCrr = CInt(.PenWidth / 2)

			tsslPenWidth.Text = CInt(.PenWidth) & "px"
		End With
	End Sub

#End Region

	Private Sub AffectedCrystalForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		InitFields()
	End Sub

	Private Sub AffectedCrystalForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		DisposeFields()
	End Sub

	Private Sub tsmiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExit.Click
		Me.Close()
	End Sub

	Private Sub CreateNew(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiCreateNew.Click, btnCreateNew.Click
		ApplyCanvas()
	End Sub

	Private Sub tsmiCanvas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCanvas.Click
		Using csd As New CanvasDialog()
			With csd
				.Location = appConf.WindowConf.CanvasSizeDialogLocation
				If .ShowDialog(Me, appConf.DrawingConf) = DialogResult.OK Then
					SetCanvasSize(.DrawingConf.CanvasSize)
				End If
				appConf.WindowConf.CanvasSizeDialogLocation = .Location
			End With
		End Using
	End Sub

	Private Sub tsmiOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiOpen.Click
		MessageBox.Show("ファイルは開けません。", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	End Sub

	Private Sub tsmiSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSave.Click
		MessageBox.Show("保存できません。", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	End Sub

	Private Sub tsmiSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSaveAs.Click
		MessageBox.Show("[Alt]+[PrtScn]でスクリーンショットを撮ってなんとかしてください。", My.Application.Info.ProductName, _
		 MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub PenColorDialog(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiPenColor.Click, btnPenColor.Click
		MessageBox.Show("今の色でガマンしてください。", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	End Sub

	Private Sub tsmiManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiManual.Click
		MessageBox.Show("自力で覚えましょう。", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub tsmiVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiVersion.Click
		Using vf As New VersionForm()
			vf.ShowDialog()
		End Using
	End Sub

#Region "描画処理"

	Private Sub pctCanvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pctCanvas.MouseDown
		drawing = True
		oldPoint = e.Location
	End Sub

	Private Sub pctCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pctCanvas.MouseUp
		drawing = False
		pctCanvas.Invalidate()
	End Sub

	Private Sub pctCanvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pctCanvas.MouseMove
		If drawing Then
			drawer.DrawLine(oldPoint, e.Location)
			oldPoint = e.Location
		End If
	End Sub

#End Region

#Region "描画モードの変更"

	Private Sub SetNormal(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiNormal.Click, btnNormal.Click
		SetDrawerType(DrawerType.Normal)
	End Sub

	Private Sub SetLeftRightMirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiLeftRightMirror.Click, btnLeftRightMirror.Click
		SetDrawerType(DrawerType.LeftRightMirror)
	End Sub

	Private Sub SetUpDownMirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiUpDownMirror.Click, btnUpDownMirror.Click
		SetDrawerType(DrawerType.UpDownMirror)
	End Sub

	Private Sub SetLeftRightUpDownMirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiLeftRightUpDownMirror.Click, btnLeftRightUpDownMirror.Click
		SetDrawerType(DrawerType.LeftRightUpDownMirror)
	End Sub

	Private Sub SetRotate3(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate3.Click, btnRotate3.Click
		SetDrawerType(DrawerType.Rotate3)
	End Sub

	Private Sub SetRotate3Mirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate3Mirror.Click, btnRotate3Mirror.Click
		SetDrawerType(DrawerType.Rotate3Mirror)
	End Sub

	Private Sub SetRotate4(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate4.Click, btnRotate4.Click
		SetDrawerType(DrawerType.Rotate4)
	End Sub

	Private Sub SetRotate4Mirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate4Mirror.Click, btnRotate4Mirror.Click
		SetDrawerType(DrawerType.Rotate4Mirror)
	End Sub

	Private Sub SetRotate5(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate5.Click, btnRotate5.Click
		SetDrawerType(DrawerType.Rotate5)
	End Sub

	Private Sub SetRotate5Mirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate5Mirror.Click, btnRotate5Mirror.Click
		SetDrawerType(DrawerType.Rotate5Mirror)
	End Sub

	Private Sub SetRotate6(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate6.Click, btnRotate6.Click
		SetDrawerType(DrawerType.Rotate6)
	End Sub

	Private Sub SetRotate6Mirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate6Mirror.Click, btnRotate6Mirror.Click
		SetDrawerType(DrawerType.Rotate6Mirror)
	End Sub

	Private Sub SetRotate8(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate8.Click, btnRotate8.Click
		SetDrawerType(DrawerType.Rotate8)
	End Sub

	Private Sub SetRotate8Mirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate8Mirror.Click, btnRotate8Mirror.Click
		SetDrawerType(DrawerType.Rotate8Mirror)
	End Sub

	Private Sub SetRotate12(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate12.Click
		SetDrawerType(DrawerType.Rotate12)
	End Sub

	Private Sub SetRotate12Mirror(ByVal sender As System.Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate12Mirror.Click
		SetDrawerType(DrawerType.Rotate12Mirror)
	End Sub

	Private Sub SetRotate16(ByVal sender As Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate16.Click
		SetDrawerType(DrawerType.Rotate16)
	End Sub

	Private Sub SetRotate24(ByVal sender As Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate24.Click
		SetDrawerType(DrawerType.Rotate24)
	End Sub

	Private Sub SetRotate32(ByVal sender As Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate32.Click
		SetDrawerType(DrawerType.Rotate32)
	End Sub

	Private Sub SetRotate64(ByVal sender As Object, ByVal e As System.EventArgs) _
	 Handles tsmiRotate64.Click
		SetDrawerType(DrawerType.Rotate64)
	End Sub

#End Region

#Region "ペン幅の変更"

	Private Sub tsmiWidth1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiWidth1.Click
		SetPenWidth(1.0F)
	End Sub

	Private Sub tsmiWidth2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiWidth2.Click
		SetPenWidth(2.0F)
	End Sub

	Private Sub tsmiWidth3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiWidth3.Click
		SetPenWidth(3.0F)
	End Sub

	Private Sub tsmiWidth4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiWidth4.Click
		SetPenWidth(4.0F)
	End Sub

	Private Sub tsmiWidth5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiWidth5.Click
		SetPenWidth(5.0F)
	End Sub

	Private Sub tsmiWidth10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiWidth10.Click
		SetPenWidth(10.0F)
	End Sub

#End Region

End Class
