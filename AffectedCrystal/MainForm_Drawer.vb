Partial Public Class MainForm

#Region "IDrawer"

	''' <summary>描画する機能を実装します</summary>
	''' <remarks>Strategyパターンを適用しています</remarks>
	Private Interface IDrawer

		''' <summary>直線を描画します</summary>
		''' <param name="pt1">直線の始点</param>
		''' <param name="pt2">直線の終点</param>
		Sub DrawLine(ByVal pt1 As Point, ByVal pt2 As Point)

	End Interface

#End Region

#Region "DrawerBase"

	''' <summary>描画オブジェクトの抽象クラスです</summary>
	Private MustInherit Class DrawerBase

		Implements IDrawer

		Public MustOverride Sub DrawLine(ByVal pt1 As System.Drawing.Point, ByVal pt2 As System.Drawing.Point) Implements IDrawer.DrawLine

		''' <summary>キャンバスに、切れ目のない描画を行います</summary>
		''' <param name="pt1">始点</param>
		''' <param name="pt2">終点</param>
		Protected Sub Draw(ByVal pt1 As Point, ByVal pt2 As Point)
			With MainForm
				Dim rect1 As Rectangle = New Rectangle( _
				 pt1.X - .drawingCrr, pt1.Y - .drawingCrr, CInt(.pen.Width), CInt(.pen.Width))
				Dim rect2 As Rectangle = New Rectangle( _
				 pt2.X - .drawingCrr, pt2.Y - .drawingCrr, CInt(.pen.Width), CInt(.pen.Width))

				.canvasG.DrawLine(.pen, pt1, pt2)
				.canvasG.FillEllipse(.brush, rect1)
				.canvasG.FillEllipse(.brush, rect2)
				.pctG.DrawLine(.pen, pt1, pt2)
				.pctG.FillEllipse(.brush, rect1)
				.pctG.FillEllipse(.brush, rect2)
			End With
		End Sub

		''' <summary>原点を基準に回転した点を算出します</summary>
		''' <param name="pt">回転させる点</param>
		''' <param name="rota">回転角[ラジアン]</param>
		Protected Function Rotate(ByVal pt As Point, ByVal rota As Double) As Point
			Dim ptAng As Double = Math.Atan2(pt.Y, pt.X) + rota
			Dim r As Double = Math.Sqrt(CDbl((pt.X * pt.X) + (pt.Y * pt.Y)))

			Return New Point(CInt(r * Math.Cos(ptAng)), CInt(r * Math.Sin(ptAng)))
		End Function

	End Class
#End Region

#Region "NormalDrawer"

	''' <summary>普通に描画する描画オブジェクトです</summary>
	Private Class NormalDrawer

		Inherits DrawerBase

		Public Overrides Sub DrawLine(ByVal pt1 As System.Drawing.Point, ByVal pt2 As System.Drawing.Point)
			Draw(pt1, pt2)
		End Sub
	End Class

#End Region

#Region "LeftRightMirrorDrawer"

	''' <summary>左右対称に描画する描画オブジェクトです</summary>
	Private Class LeftRightMirrorDrawer

		Inherits DrawerBase

		Public Overrides Sub DrawLine(ByVal pt1 As System.Drawing.Point, ByVal pt2 As System.Drawing.Point)
			With MainForm
				Dim pt1mrr As New Point(.canvas.Size.Width - pt1.X, pt1.Y)
				Dim pt2mrr As New Point(.canvas.Size.Width - pt2.X, pt2.Y)

				Draw(pt1, pt2)
				Draw(pt1mrr, pt2mrr)
			End With
		End Sub
	End Class

#End Region

#Region "UpDownMirrorDrawer"

	''' <summary>上下対称に描画する描画オブジェクトです</summary>
	Private Class UpDownMirrorDrawer

		Inherits DrawerBase

		Public Overrides Sub DrawLine(ByVal pt1 As System.Drawing.Point, ByVal pt2 As System.Drawing.Point)
			With MainForm
				Dim pt1mrr As New Point(pt1.X, .canvas.Size.Height - pt1.Y)
				Dim pt2mrr As New Point(pt2.X, .canvas.Size.Height - pt2.Y)

				Draw(pt1, pt2)
				Draw(pt1mrr, pt2mrr)
			End With
		End Sub
	End Class

#End Region

#Region "LeftRightUpDownMirrorDrawer"

	''' <summary>左右上下対称に描画する描画オブジェクトです</summary>
	Private Class LeftRightUpDownMirrorDrawer

		Inherits DrawerBase

		Public Overrides Sub DrawLine(ByVal pt1 As System.Drawing.Point, ByVal pt2 As System.Drawing.Point)
			With MainForm
				Dim pt1mrr1 As New Point(.canvas.Size.Width - pt1.X, pt1.Y)
				Dim pt2mrr1 As New Point(.canvas.Size.Width - pt2.X, pt2.Y)
				Dim pt1mrr2 As New Point(pt1.X, .canvas.Size.Height - pt1.Y)
				Dim pt2mrr2 As New Point(pt2.X, .canvas.Size.Height - pt2.Y)
				Dim pt1mrr3 As New Point(.canvas.Size.Width - pt1.X, .canvas.Size.Height - pt1.Y)
				Dim pt2mrr3 As New Point(.canvas.Size.Width - pt2.X, .canvas.Size.Height - pt2.Y)

				Draw(pt1, pt2)
				Draw(pt1mrr1, pt2mrr1)
				Draw(pt1mrr2, pt2mrr2)
				Draw(pt1mrr3, pt2mrr3)
			End With
		End Sub
	End Class

#End Region

#Region "RotateDrawer"

	''' <summary>回転して描画する描画オブジェクトです</summary>
	Private Class RotateDrawer

		Inherits DrawerBase

		''' <summary>円の分割数</summary>
		Protected divition As Integer

		''' <summary>RotateDrawerのインスタンスを生成します</summary>
		''' <param name="divition">円の分割数</param>
		Public Sub New(ByVal divition As Integer)
			Me.divition = divition
		End Sub

		Public Overrides Sub DrawLine(ByVal pt1 As System.Drawing.Point, ByVal pt2 As System.Drawing.Point)
			With MainForm
				.pctCanvas.SuspendLayout()
				Dim pt1offset As Point = Point.Subtract(pt1, .canvasCenterPoint)
				Dim pt2offset As Point = Point.Subtract(pt2, .canvasCenterPoint)

				For i As Integer = 1 To divition
					Dim rad As Double = 2.0 / divition * i * Math.PI
					Dim pt1rota As Point = Rotate(pt1offset, rad)
					Dim pt2rota As Point = Rotate(pt2offset, rad)

					pt1rota = Point.Add(pt1rota, .canvasCenterPoint)
					pt2rota = Point.Add(pt2rota, .canvasCenterPoint)
					Draw(pt1rota, pt2rota)
				Next
				.pctCanvas.ResumeLayout(False)
			End With
		End Sub
	End Class

#End Region

#Region "RotateMirrorDrawer"

	''' <summary>回転して描画し、さらに左右対称に描画する描画オブジェクトです</summary>
	Private Class RotateMirrorDrawer

		Inherits DrawerBase

		''' <summary>円の分割数</summary>
		Private divition As Integer

		''' <summary>RotateMirrorDrawerのインスタンスを生成します</summary>
		''' <param name="divition">円の分割数</param>
		Public Sub New(ByVal divition As Integer)
			Me.divition = divition
		End Sub

		Public Overrides Sub DrawLine(ByVal pt1 As System.Drawing.Point, ByVal pt2 As System.Drawing.Point)
			With MainForm
				.pctCanvas.SuspendLayout()
				Dim pt1offset As Point = Point.Subtract(pt1, .canvasCenterPoint)
				Dim pt2offset As Point = Point.Subtract(pt2, .canvasCenterPoint)

				For i As Integer = 1 To divition
					Dim rad As Double = 2.0 / divition * i * Math.PI
					Dim pt1rota As Point = Point.Add(Rotate(pt1offset, rad), .canvasCenterPoint)
					Dim pt2rota As Point = Point.Add(Rotate(pt2offset, rad), .canvasCenterPoint)
					Dim pt1mrr As New Point(.canvas.Size.Width - pt1rota.X, pt1rota.Y)
					Dim pt2mrr As New Point(.canvas.Size.Width - pt2rota.X, pt2rota.Y)

					Draw(pt1rota, pt2rota)
					Draw(pt1mrr, pt2mrr)
				Next
				.pctCanvas.ResumeLayout(False)
			End With
		End Sub

	End Class

#End Region

End Class
