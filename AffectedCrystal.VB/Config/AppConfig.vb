Imports AffectedCrystal
Imports Newtonsoft.Json

''' <summary>
''' アプリケーションの設定情報を格納します。
''' </summary>
<JsonObject()>
Public Class AppConfig
    Implements ICloneable(Of AppConfig)

    ''' <summary>
    ''' 描画関係の設定情報を設定または取得します。
    ''' </summary>
    <JsonProperty()>
    Public Property DrawingConf As DrawingConfig

    ''' <summary>
    ''' ウィンドウ関係の設定情報を設定または取得します。
    ''' </summary>
    <JsonProperty()>
    Public Property WindowConf As WindowConfig

    ''' <summary>
    ''' <see cref="AppConfig"/> の新しいインスタンスを生成します。
    ''' </summary>
    Public Sub New()
        DrawingConf = New DrawingConfig()
        WindowConf = New WindowConfig()
    End Sub

    ''' <summary>
    ''' アプリケーションの設定情報を全て規定値にリセットします。
    ''' </summary>
    Public Sub Reset()
        DrawingConf.Reset()
        WindowConf.Reset()
    End Sub

    Public Function Clone() As AppConfig Implements ICloneable(Of AppConfig).Clone
        Dim cloned As New AppConfig() With {
            .DrawingConf = DrawingConf.Clone(),
            .WindowConf = WindowConf.Clone()
        }
        Return cloned
    End Function

    Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
        Return Clone()
    End Function
End Class
