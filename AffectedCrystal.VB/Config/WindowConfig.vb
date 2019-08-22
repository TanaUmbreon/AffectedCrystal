Imports Newtonsoft.Json

''' <summary>
''' ウィンドウ関係の設定情報を格納します。
''' </summary>
<JsonObject()>
Public Class WindowConfig
    Implements ICloneable(Of WindowConfig)

#Region "規定値"

    ''' <summary>既定のメインフォームの位置とサイズ</summary>
    Public Shared ReadOnly DefaultMainBounds As Rectangle = New Rectangle(100, 100, 560, 400)
    ''' <summary>既定のメインフォームの状態</summary>
    Public Shared ReadOnly DefaultMainWindowState As FormWindowState = FormWindowState.Normal
    ''' <summary>既定の [キャンバスのサイズ] ダイアログの位置</summary>
    Public Shared ReadOnly DefaultCanvasSizeDialogLocation As Point = New Point(200, 200)

#End Region

    ''' <summary>
    ''' 位置とサイズを、ピクセル単位で設定または取得します。
    ''' </summary>
    Public Property MainBounds As Rectangle

    ''' <summary>
    ''' ウィンドウの状態を設定または取得します。
    ''' </summary>
    Public Property MainWindowState As FormWindowState

    ''' <summary>
    ''' [キャンバスのサイズ] ダイアログの位置を、ピクセル単位で設定または取得します。
    ''' </summary>
    Public Property CanvasSizeDialogLocation As Point

    ''' <summary>
    ''' <see cref="WindowConfig"/> の新しいインスタンスを生成します。
    ''' </summary>
    Public Sub New()
        Reset()
    End Sub

    ''' <summary>
    ''' 設定情報を規定値にリセットします。
    ''' </summary>
    Public Sub Reset()
        MainBounds = DefaultMainBounds
        MainWindowState = DefaultMainWindowState
        CanvasSizeDialogLocation = DefaultCanvasSizeDialogLocation
    End Sub

    Public Function Clone() As WindowConfig Implements ICloneable(Of WindowConfig).Clone
        Dim cloned As New WindowConfig() With {
            .MainBounds = MainBounds,
            .MainWindowState = MainWindowState,
            .CanvasSizeDialogLocation = CanvasSizeDialogLocation
        }
        Return cloned
    End Function

    Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
        Return Clone()
    End Function

End Class
