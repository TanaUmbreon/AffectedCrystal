Public Interface ICloneable(Of T)
    Inherits ICloneable

    ''' <summary>
    ''' 現在のインスタンスのコピーである新しいオブジェクトを作成します。
    ''' </summary>
    ''' <returns>このインスタンスのコピーである新しいオブジェクト。</returns>
    Shadows Function Clone() As T

End Interface
