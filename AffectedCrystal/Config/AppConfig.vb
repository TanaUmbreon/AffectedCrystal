''' <summary>アプリケーションの設定情報を系統ごとに分割して管理するクラスです</summary>
<System.Serializable()> _
Public Class AppConfig

	Implements IConfig

	''' <summary>描画関係の設定情報</summary>
	Private _drawingConf As DrawingConfig
	''' <summary>ウィンドウ関係の設定情報</summary>
	Private _windowConf As WindowConfig

#Region "メソッド"

	''' <summary>AppConfigのインスタンスを生成します</summary>
	Public Sub New()
		_drawingConf = New DrawingConfig()
		_windowConf = New WindowConfig()
	End Sub


	''' <summary>インスタンスのクローンを生成します</summary>
	Public Function Clone() As Object Implements System.ICloneable.Clone
		Dim clonedConf As New AppConfig()

		With clonedConf
			._drawingConf = DirectCast(_drawingConf.Clone(), DrawingConfig)
			._windowConf = DirectCast(_windowConf.Clone(), WindowConfig)
		End With

		Return clonedConf
	End Function

	''' <summary>アプリケーションの設定情報を全て規定値にリセットします</summary>
	Public Sub Reset() Implements IConfig.Reset
		_drawingConf.Reset()
		_windowConf.Reset()
	End Sub

#End Region

	''' <summary>描画関係の設定情報を設定または取得します</summary>
	Public Property DrawingConf() As DrawingConfig
		Get
			Return _drawingConf
		End Get
		Set(ByVal value As DrawingConfig)
			_drawingConf = value
		End Set
	End Property

	''' <summary>ウィンドウ関係の設定情報を設定または取得します</summary>
	Public Property WindowConf() As WindowConfig
		Get
			Return _windowConf
		End Get
		Set(ByVal value As WindowConfig)
			_windowConf = value
		End Set
	End Property

End Class
