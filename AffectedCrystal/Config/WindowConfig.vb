''' <summary>ウィンドウ関係の設定情報を管理するクラスです</summary>
<System.Serializable()> _
Public Class WindowConfig

	Implements IConfig

#Region "規定値(Sharedメンバ)"

	''' <summary>既定のメインフォームの位置とサイズ</summary>
	Private Shared ReadOnly _defaultMainBounds As Rectangle
	''' <summary>既定のメインフォームの状態</summary>
	Private Shared ReadOnly _defaultMainWindowState As FormWindowState
	''' <summary>既定の[キャンバスのサイズ]ダイアログの位置</summary>
	Private Shared ReadOnly _defaultCanvasSizeDialogLocation As Point


	''' <summary>Sharedメンバを初期化します</summary>
	Shared Sub New()
		_defaultMainBounds = New Rectangle(100, 100, 560, 400)
		_defaultMainWindowState = FormWindowState.Normal
		_defaultCanvasSizeDialogLocation = New Point(200, 200)
	End Sub


	''' <summary>既定のメインフォームの位置とサイズを、ピクセル単位で取得します</summary>
	Public Shared ReadOnly Property DefaultMainBounds() As Rectangle
		Get
			Return _defaultMainBounds
		End Get
	End Property

	''' <summary>既定のメインフォームのウィンドウ状態を取得します</summary>
	Public Shared ReadOnly Property DefaultMainWindowState() As FormWindowState
		Get
			Return _defaultMainWindowState
		End Get
	End Property

	''' <summary>既定の[キャンバスのサイズ]ダイアログの位置を、ピクセル単位で取得します</summary>
	Public Shared ReadOnly Property DefaultCanvasSizeDialogLocation() As Point
		Get
			Return _defaultCanvasSizeDialogLocation
		End Get
	End Property

#End Region

	''' <summary>位置とサイズ</summary>
	Private _mainBounds As Rectangle
	''' <summary>ウィンドウの状態</summary>
	Private _mainWindowState As FormWindowState
	''' <summary>[キャンバスのサイズ]ダイアログの位置</summary>
	Private _canvasSizeDialogLocation As Point

#Region "メソッド"

	''' <summary>WindowConfのインスタンスを生成します</summary>
	Public Sub New()
		Reset()
	End Sub


	''' <summary>このインスタンスのクローンを生成します</summary>
	Public Function Clone() As Object Implements System.ICloneable.Clone
		Dim clonedConf As New WindowConfig()

		With clonedConf
			._mainBounds = _mainBounds
			._mainWindowState = _mainWindowState
			._canvasSizeDialogLocation = _canvasSizeDialogLocation
		End With

		Return Nothing
	End Function

	''' <summary>設定情報を規定値にリセットします</summary>
	Public Sub Reset() Implements IConfig.Reset
		_mainBounds = _defaultMainBounds
		_mainWindowState = _defaultMainWindowState
		_canvasSizeDialogLocation = _defaultCanvasSizeDialogLocation
	End Sub

#End Region

#Region "プロパティ"

	''' <summary>位置とサイズを、ピクセル単位で設定または取得します</summary>
	Public Property MainBounds() As Rectangle
		Get
			Return _mainBounds
		End Get
		Set(ByVal value As Rectangle)
			_mainBounds = value
		End Set
	End Property

	''' <summary>ウィンドウの状態を設定または取得します</summary>
	Public Property MainWindowState() As FormWindowState
		Get
			Return _mainWindowState
		End Get
		Set(ByVal value As FormWindowState)
			_mainWindowState = value
		End Set
	End Property

	''' <summary>[キャンバスのサイズ]ダイアログの位置を、ピクセル単位で設定または取得します</summary>
	Public Property CanvasSizeDialogLocation() As Point
		Get
			Return _canvasSizeDialogLocation
		End Get
		Set(ByVal value As Point)
			_canvasSizeDialogLocation = value
		End Set
	End Property

#End Region

End Class
