Imports Newtonsoft.Json

''' <summary>
''' 描画関係の設定情報を格納します。
''' </summary>
<JsonObject()>
Public Class DrawingConfig
    Implements ICloneable(Of DrawingConfig)

#Region "規定値"

    ''' <summary>キャンバスサイズの最小値</summary>
    Public Shared ReadOnly MinCanvasSize As Size = New Size(1, 1)
    ''' <summary>キャンバスサイズの最大値</summary>
    Public Shared ReadOnly MaxCanvasSize As Size = New Size(1280, 1024)

    ''' <summary>既定のキャンバスの背景色</summary>
    Public Shared ReadOnly DefaultCanvasBgColor As Color = Color.White
    ''' <summary>既定のキャンバスサイズ</summary>
    Public Shared ReadOnly DefaultCanvasSize As Size = New Size(300, 300)
    ''' <summary>既定の描画モードの種類</summary>
    Public Shared ReadOnly DefaultDrawerType As DrawerType = DrawerType.Rotate3Mirror
    ''' <summary>既定のペンの色</summary>
    Public Shared ReadOnly DefaultPenColor As Color = Color.Black
    ''' <summary>既定のペンの幅</summary>
    Public Shared ReadOnly DefaultPenWidth As Single = 1.0F

#End Region

    ''' <summary>
    ''' キャンバスの背景色を設定または取得します。
    ''' </summary>
    <JsonProperty()>
    Public Property CanvasBgColor As Color

    ''' <summary>キャンバスサイズ</summary>
    Private _canvasSize As Size

    ''' <summary>
    ''' キャンバスサイズを設定または取得します。
    ''' 設定した値が最小値から最大値までに収まらなかった場合は自動的に修正されます。
    ''' </summary>
    <JsonProperty()>
    Public Property CanvasSize() As Size
        Get
            Return _canvasSize
        End Get
        Set(ByVal value As Size)
            _canvasSize = value

            If _canvasSize.Width < MinCanvasSize.Width Then
                _canvasSize.Width = MinCanvasSize.Width
            End If
            If _canvasSize.Width > MaxCanvasSize.Width Then
                _canvasSize.Width = MaxCanvasSize.Width
            End If

            If _canvasSize.Height < MinCanvasSize.Height Then
                _canvasSize.Height = MinCanvasSize.Height
            End If
            If _canvasSize.Height > MaxCanvasSize.Height Then
                _canvasSize.Height = MaxCanvasSize.Height
            End If
        End Set
    End Property

    ''' <summary>
    ''' 描画モードの種類を設定または取得します。
    ''' </summary>
    <JsonProperty()>
    Public Property DrawerType As DrawerType

    ''' <summary>
    ''' ペンの色を設定または取得します。
    ''' </summary>
    <JsonProperty()>
    Public Property PenColor As Color

    ''' <summary>
    ''' ペンの幅を設定または取得します。
    ''' </summary>
    <JsonProperty()>
    Public Property PenWidth As Single

    ''' <summary>
    ''' <see cref="DrawingConfig"/> の新しいインスタンスを生成します。
    ''' </summary>
    Public Sub New()
        Reset()
    End Sub

    ''' <summary>
    ''' インスタンスの設定情報を規定値にリセットします。
    ''' </summary>
    Public Sub Reset()
        CanvasBgColor = DefaultCanvasBgColor
        CanvasSize = DefaultCanvasSize
        DrawerType = DefaultDrawerType
        PenColor = DefaultPenColor
        PenWidth = DefaultPenWidth
    End Sub

    Public Function Clone() As DrawingConfig Implements ICloneable(Of DrawingConfig).Clone
        Dim cloned As New DrawingConfig() With {
            .CanvasBgColor = CanvasBgColor,
            .CanvasSize = CanvasSize,
            .DrawerType = DrawerType,
            .PenColor = PenColor,
            .PenWidth = PenWidth
        }

        Return cloned
    End Function

    Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
        Return Clone()
    End Function
End Class
