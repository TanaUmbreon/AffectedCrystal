''' <summary>描画関係の設定情報を管理するクラスです</summary>
<System.Serializable()> _
Public Class DrawingConfig

	Implements IConfig

#Region "規定値"

	''' <summary>キャンバスサイズの最小値</summary>
	Private Shared ReadOnly _minCanvasSize As Size

	''' <summary>キャンバスサイズの最大値</summary>
	Private Shared ReadOnly _maxCanvasSize As Size

	''' <summary>既定のキャンバスの背景色</summary>
	Private Shared ReadOnly _defaultCanvasBgColor As Color
	''' <summary>既定のキャンバスサイズ</summary>
	Private Shared ReadOnly _defaultCanvasSize As Size
	''' <summary>既定の描画モードの種類</summary>
	Private Shared ReadOnly _defaultDrawerType As DrawerType
	''' <summary>既定のペンの色</summary>
	Private Shared ReadOnly _defaultPenColor As Color
	''' <summary>既定のペンの幅</summary>
	Private Shared ReadOnly _defaultPenWidth As Single


	''' <summary>Sharedメンバを初期化します</summary>
	Shared Sub New()
		_minCanvasSize = New Size(1, 1)

		_maxCanvasSize = New Size(1280, 1024)

		_defaultCanvasBgColor = Color.White
		_defaultCanvasSize = New Size(300, 300)
		_defaultDrawerType = DrawerType.Rotate3Mirror
		_defaultPenColor = Color.Black
		_defaultPenWidth = 1.0F
	End Sub


	''' <summary>キャンバスサイズの最小値を取得します</summary>
	Public Shared ReadOnly Property MinCanvasSize() As Size
		Get
			Return _minCanvasSize
		End Get
	End Property

	''' <summary>キャンバスサイズの最大値を取得します</summary>
	Public Shared ReadOnly Property MaxCanvasSize() As Size
		Get
			Return _maxCanvasSize
		End Get
	End Property

	''' <summary>既定のキャンバスの背景色を取得します</summary>
	Public Shared ReadOnly Property DefaultCanvasBgColor() As Color
		Get
			Return _defaultCanvasBgColor
		End Get
	End Property

	''' <summary>既定のキャンバスサイズを取得します</summary>
	Public Shared ReadOnly Property DefaultCanvasSize() As Size
		Get
			Return _defaultCanvasSize
		End Get
	End Property

	''' <summary>既定の描画モードの種類を取得します</summary>
	Public Shared ReadOnly Property DefaultDrawerType() As DrawerType
		Get
			Return _defaultDrawerType
		End Get
	End Property

	''' <summary>既定のペンの色を取得します</summary>
	Public Shared ReadOnly Property DefaultPenColor() As Color
		Get
			Return _defaultPenColor
		End Get
	End Property

	''' <summary>既定のペンの幅を取得します</summary>
	Public Shared ReadOnly Property DefaultPenWidth() As Single
		Get
			Return _defaultPenWidth
		End Get
	End Property

#End Region

	''' <summary>キャンバスの背景色</summary>
	Private _canvasBgColor As Color
	''' <summary>キャンバスサイズ</summary>
	Private _canvasSize As Size
	''' <summary>描画モードの種類</summary>
	Private _drawerType As DrawerType
	''' <summary>ペンの色</summary>
	Private _penColor As Color
	''' <summary>ペンの幅</summary>
	Private _penWidth As Single

#Region "メソッド"

	''' <summary>DrawingConfigのインスタンスを生成します</summary>
	Public Sub New()
		Reset()
	End Sub

	''' <summary>インスタンスのクローンを生成します</summary>
	Public Function Clone() As Object Implements System.ICloneable.Clone
		Dim clonedConf As New DrawingConfig()

		With clonedConf
			._canvasBgColor = _canvasBgColor
			._canvasSize = _canvasSize
			._drawerType = _drawerType
			._penColor = _penColor
			._penWidth = _penWidth
		End With

		Return clonedConf
	End Function

	''' <summary>設定情報を規定値にリセットします</summary>
	Public Sub Reset() Implements IConfig.Reset
		_canvasBgColor = _defaultCanvasBgColor
		_canvasSize = _defaultCanvasSize
		_drawerType = _defaultDrawerType
		_penColor = _defaultPenColor
		_penWidth = _defaultPenWidth
	End Sub

#End Region

#Region "プロパティ"

	''' <summary>キャンバスの背景色を設定または取得します</summary>
	Public Property CanvasBgColor() As Color
		Get
			Return _canvasBgColor
		End Get
		Set(ByVal value As Color)
			_canvasBgColor = value
		End Set
	End Property

	''' <summary>キャンバスサイズを設定または取得します</summary>
	''' <value>設定した値が最小値から最大値までに収まらなかった場合は自動的に修正されます</value>
	Public Property CanvasSize() As Size
		Get
			Return _canvasSize
		End Get
		Set(ByVal value As Size)
			_canvasSize = value

			With _canvasSize
				If .Width < _minCanvasSize.Width Then
					.Width = _minCanvasSize.Width
				End If
				If .Width > _maxCanvasSize.Width Then
					.Width = _maxCanvasSize.Width
				End If

				If .Height < _minCanvasSize.Height Then
					.Height = _minCanvasSize.Height
				End If
				If .Height > _maxCanvasSize.Height Then
					.Height = _maxCanvasSize.Height
				End If
			End With
		End Set
	End Property

	''' <summary>描画モードの種類を設定または取得します</summary>
	Public Property DrawerType() As DrawerType
		Get
			Return _drawerType
		End Get
		Set(ByVal value As DrawerType)
			_drawerType = value
		End Set
	End Property

	''' <summary>ペンの色を設定または取得します</summary>
	Public Property PenColor() As Color
		Get
			Return _penColor
		End Get
		Set(ByVal value As Color)
			_penColor = value
		End Set
	End Property

	''' <summary>ペンの幅を設定または取得します</summary>
	Public Property PenWidth() As Single
		Get
			Return _penWidth
		End Get
		Set(ByVal value As Single)
			_penWidth = value
		End Set
	End Property

#End Region

End Class
