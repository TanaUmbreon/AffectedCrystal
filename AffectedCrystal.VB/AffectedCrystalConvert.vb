''' <summary>このプロジェクト内で使われているオブジェクトをコンバートするユーティリティクラスです</summary>
Public Class AffectedCrystalConvert

	''' <summary>描画オブジェクトの種類を文字列にコンバートします</summary>
	''' <param name="type">描画オブジェクトの種類</param>
	Public Overloads Shared Function ToString(ByVal type As DrawerType) As String
		Dim result As String = ""

		Select Case type
			Case DrawerType.Normal
				result = "フリーハンド"
			Case DrawerType.LeftRightMirror
				result = "左右対称"
			Case DrawerType.UpDownMirror
				result = "上下対称"
			Case DrawerType.LeftRightUpDownMirror
				result = "左右上下対称"
			Case DrawerType.Rotate3
				result = "3分割"
			Case DrawerType.Rotate3Mirror
				result = "3分割ミラー"
			Case DrawerType.Rotate4
				result = "4分割"
			Case DrawerType.Rotate4Mirror
				result = "4分割ミラー"
			Case DrawerType.Rotate5
				result = "5分割"
			Case DrawerType.Rotate5Mirror
				result = "5分割ミラー"
			Case DrawerType.Rotate6
				result = "6分割"
			Case DrawerType.Rotate6Mirror
				result = "6分割ミラー"
			Case DrawerType.Rotate8
				result = "8分割"
			Case DrawerType.Rotate8Mirror
				result = "8分割ミラー"
			Case DrawerType.Rotate12
				result = "12分割"
			Case DrawerType.Rotate12Mirror
				result = "12分割ミラー"
			Case DrawerType.Rotate16
				result = "16分割"
			Case DrawerType.Rotate24
				result = "24分割"
			Case DrawerType.Rotate32
				result = "32分割"
			Case DrawerType.Rotate64
				result = "64分割"
			Case Else
				result = "未定義の描画オブジェクト"
		End Select

		Return result
	End Function

End Class
