<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows フォーム デザイナで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
	'Windows フォーム デザイナを使用して変更できます。  
	'コード エディタを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.pctCanvas = New System.Windows.Forms.PictureBox
		Me.mstMain = New System.Windows.Forms.MenuStrip
		Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiCreateNew = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiSaveAs = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiConfig = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiDrawerType = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiNormal = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiLeftRightMirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiUpDownMirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiLeftRightUpDownMirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate3 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate3Mirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate4 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate4Mirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate5 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate5Mirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate6 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate6Mirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate8 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate8Mirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate12 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate12Mirror = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate16 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate24 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate32 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiRotate64 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiPenWidth = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiWidth1 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiWidth2 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiWidth3 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiWidth4 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiWidth5 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiWidth10 = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiPenColor = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiCanvas = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem
		Me.tsmiManual = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.tsmiVersion = New System.Windows.Forms.ToolStripMenuItem
		Me.sstMain = New System.Windows.Forms.StatusStrip
		Me.tsslDrawingType = New System.Windows.Forms.ToolStripStatusLabel
		Me.tsslPenWidth = New System.Windows.Forms.ToolStripStatusLabel
		Me.pnlDrawArea = New System.Windows.Forms.Panel
		Me.btnCreateNew = New System.Windows.Forms.Button
		Me.btnNormal = New System.Windows.Forms.Button
		Me.btnLeftRightMirror = New System.Windows.Forms.Button
		Me.btnUpDownMirror = New System.Windows.Forms.Button
		Me.btnLeftRightUpDownMirror = New System.Windows.Forms.Button
		Me.btnRotate3 = New System.Windows.Forms.Button
		Me.btnRotate3Mirror = New System.Windows.Forms.Button
		Me.btnRotate4 = New System.Windows.Forms.Button
		Me.btnRotate4Mirror = New System.Windows.Forms.Button
		Me.btnRotate5 = New System.Windows.Forms.Button
		Me.btnRotate5Mirror = New System.Windows.Forms.Button
		Me.btnRotate6 = New System.Windows.Forms.Button
		Me.btnRotate6Mirror = New System.Windows.Forms.Button
		Me.btnRotate8 = New System.Windows.Forms.Button
		Me.btnRotate8Mirror = New System.Windows.Forms.Button
		Me.btnPenColor = New System.Windows.Forms.Button
		CType(Me.pctCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.mstMain.SuspendLayout()
		Me.sstMain.SuspendLayout()
		Me.pnlDrawArea.SuspendLayout()
		Me.SuspendLayout()
		'
		'pctCanvas
		'
		Me.pctCanvas.BackColor = System.Drawing.Color.White
		Me.pctCanvas.Location = New System.Drawing.Point(0, 0)
		Me.pctCanvas.Margin = New System.Windows.Forms.Padding(0)
		Me.pctCanvas.Name = "pctCanvas"
		Me.pctCanvas.Size = New System.Drawing.Size(100, 100)
		Me.pctCanvas.TabIndex = 0
		Me.pctCanvas.TabStop = False
		'
		'mstMain
		'
		Me.mstMain.AutoSize = False
		Me.mstMain.BackgroundImage = Global.AffectedCrystal.My.Resources.Resources.imgMenuBar26
		Me.mstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiConfig, Me.tsmiHelp})
		Me.mstMain.Location = New System.Drawing.Point(0, 0)
		Me.mstMain.Name = "mstMain"
		Me.mstMain.Size = New System.Drawing.Size(544, 26)
		Me.mstMain.TabIndex = 0
		Me.mstMain.Text = "MenuStrip1"
		'
		'tsmiFile
		'
		Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCreateNew, Me.tsmiOpen, Me.tsmiSave, Me.tsmiSaveAs, Me.ToolStripSeparator1, Me.tsmiExit})
		Me.tsmiFile.Name = "tsmiFile"
		Me.tsmiFile.Size = New System.Drawing.Size(85, 22)
		Me.tsmiFile.Text = "ファイル(&F)"
		'
		'tsmiCreateNew
		'
		Me.tsmiCreateNew.Name = "tsmiCreateNew"
		Me.tsmiCreateNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.tsmiCreateNew.Size = New System.Drawing.Size(231, 22)
		Me.tsmiCreateNew.Text = "新規作成(&N)"
		'
		'tsmiOpen
		'
		Me.tsmiOpen.Name = "tsmiOpen"
		Me.tsmiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.tsmiOpen.Size = New System.Drawing.Size(231, 22)
		Me.tsmiOpen.Text = "開く(&O)..."
		'
		'tsmiSave
		'
		Me.tsmiSave.Name = "tsmiSave"
		Me.tsmiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.tsmiSave.Size = New System.Drawing.Size(231, 22)
		Me.tsmiSave.Text = "保存(&S)..."
		'
		'tsmiSaveAs
		'
		Me.tsmiSaveAs.Name = "tsmiSaveAs"
		Me.tsmiSaveAs.ShortcutKeys = System.Windows.Forms.Keys.F12
		Me.tsmiSaveAs.Size = New System.Drawing.Size(231, 22)
		Me.tsmiSaveAs.Text = "名前を付けて保存(&A)..."
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(228, 6)
		'
		'tsmiExit
		'
		Me.tsmiExit.Name = "tsmiExit"
		Me.tsmiExit.Size = New System.Drawing.Size(231, 22)
		Me.tsmiExit.Text = "終了(&X)"
		'
		'tsmiConfig
		'
		Me.tsmiConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDrawerType, Me.tsmiPenWidth, Me.tsmiPenColor, Me.tsmiCanvas})
		Me.tsmiConfig.Name = "tsmiConfig"
		Me.tsmiConfig.Size = New System.Drawing.Size(62, 22)
		Me.tsmiConfig.Text = "設定(&C)"
		'
		'tsmiDrawerType
		'
		Me.tsmiDrawerType.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNormal, Me.tsmiLeftRightMirror, Me.tsmiUpDownMirror, Me.tsmiLeftRightUpDownMirror, Me.tsmiRotate3, Me.tsmiRotate3Mirror, Me.tsmiRotate4, Me.tsmiRotate4Mirror, Me.tsmiRotate5, Me.tsmiRotate5Mirror, Me.tsmiRotate6, Me.tsmiRotate6Mirror, Me.tsmiRotate8, Me.tsmiRotate8Mirror, Me.tsmiRotate12, Me.tsmiRotate12Mirror, Me.tsmiRotate16, Me.tsmiRotate24, Me.tsmiRotate32, Me.tsmiRotate64})
		Me.tsmiDrawerType.Name = "tsmiDrawerType"
		Me.tsmiDrawerType.Size = New System.Drawing.Size(166, 22)
		Me.tsmiDrawerType.Text = "描画モード(D)"
		'
		'tsmiNormal
		'
		Me.tsmiNormal.Name = "tsmiNormal"
		Me.tsmiNormal.Size = New System.Drawing.Size(150, 22)
		Me.tsmiNormal.Text = "フリーハンド"
		'
		'tsmiLeftRightMirror
		'
		Me.tsmiLeftRightMirror.Name = "tsmiLeftRightMirror"
		Me.tsmiLeftRightMirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiLeftRightMirror.Text = "左右対称"
		'
		'tsmiUpDownMirror
		'
		Me.tsmiUpDownMirror.Name = "tsmiUpDownMirror"
		Me.tsmiUpDownMirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiUpDownMirror.Text = "上下対称"
		'
		'tsmiLeftRightUpDownMirror
		'
		Me.tsmiLeftRightUpDownMirror.Name = "tsmiLeftRightUpDownMirror"
		Me.tsmiLeftRightUpDownMirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiLeftRightUpDownMirror.Text = "左右上下対称"
		'
		'tsmiRotate3
		'
		Me.tsmiRotate3.Name = "tsmiRotate3"
		Me.tsmiRotate3.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate3.Text = "3分割"
		'
		'tsmiRotate3Mirror
		'
		Me.tsmiRotate3Mirror.Name = "tsmiRotate3Mirror"
		Me.tsmiRotate3Mirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate3Mirror.Text = "3分割ミラー"
		'
		'tsmiRotate4
		'
		Me.tsmiRotate4.Name = "tsmiRotate4"
		Me.tsmiRotate4.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate4.Text = "4分割"
		'
		'tsmiRotate4Mirror
		'
		Me.tsmiRotate4Mirror.Name = "tsmiRotate4Mirror"
		Me.tsmiRotate4Mirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate4Mirror.Text = "4分割ミラー"
		'
		'tsmiRotate5
		'
		Me.tsmiRotate5.Name = "tsmiRotate5"
		Me.tsmiRotate5.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate5.Text = "5分割"
		'
		'tsmiRotate5Mirror
		'
		Me.tsmiRotate5Mirror.Name = "tsmiRotate5Mirror"
		Me.tsmiRotate5Mirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate5Mirror.Text = "5分割ミラー"
		'
		'tsmiRotate6
		'
		Me.tsmiRotate6.Name = "tsmiRotate6"
		Me.tsmiRotate6.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate6.Text = "6分割"
		'
		'tsmiRotate6Mirror
		'
		Me.tsmiRotate6Mirror.Name = "tsmiRotate6Mirror"
		Me.tsmiRotate6Mirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate6Mirror.Text = "6分割ミラー"
		'
		'tsmiRotate8
		'
		Me.tsmiRotate8.Name = "tsmiRotate8"
		Me.tsmiRotate8.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate8.Text = "8分割"
		'
		'tsmiRotate8Mirror
		'
		Me.tsmiRotate8Mirror.Name = "tsmiRotate8Mirror"
		Me.tsmiRotate8Mirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate8Mirror.Text = "8分割ミラー"
		'
		'tsmiRotate12
		'
		Me.tsmiRotate12.Name = "tsmiRotate12"
		Me.tsmiRotate12.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate12.Text = "12分割"
		'
		'tsmiRotate12Mirror
		'
		Me.tsmiRotate12Mirror.Name = "tsmiRotate12Mirror"
		Me.tsmiRotate12Mirror.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate12Mirror.Text = "12分割ミラー"
		'
		'tsmiRotate16
		'
		Me.tsmiRotate16.Name = "tsmiRotate16"
		Me.tsmiRotate16.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate16.Text = "16分割"
		'
		'tsmiRotate24
		'
		Me.tsmiRotate24.Name = "tsmiRotate24"
		Me.tsmiRotate24.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate24.Text = "24分割"
		'
		'tsmiRotate32
		'
		Me.tsmiRotate32.Name = "tsmiRotate32"
		Me.tsmiRotate32.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate32.Text = "32分割"
		'
		'tsmiRotate64
		'
		Me.tsmiRotate64.Name = "tsmiRotate64"
		Me.tsmiRotate64.Size = New System.Drawing.Size(150, 22)
		Me.tsmiRotate64.Text = "64分割"
		'
		'tsmiPenWidth
		'
		Me.tsmiPenWidth.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiWidth1, Me.tsmiWidth2, Me.tsmiWidth3, Me.tsmiWidth4, Me.tsmiWidth5, Me.tsmiWidth10})
		Me.tsmiPenWidth.Name = "tsmiPenWidth"
		Me.tsmiPenWidth.Size = New System.Drawing.Size(166, 22)
		Me.tsmiPenWidth.Text = "ペンの幅(&W)"
		'
		'tsmiWidth1
		'
		Me.tsmiWidth1.Name = "tsmiWidth1"
		Me.tsmiWidth1.Size = New System.Drawing.Size(104, 22)
		Me.tsmiWidth1.Text = "1px"
		'
		'tsmiWidth2
		'
		Me.tsmiWidth2.Name = "tsmiWidth2"
		Me.tsmiWidth2.Size = New System.Drawing.Size(104, 22)
		Me.tsmiWidth2.Text = "2px"
		'
		'tsmiWidth3
		'
		Me.tsmiWidth3.Name = "tsmiWidth3"
		Me.tsmiWidth3.Size = New System.Drawing.Size(104, 22)
		Me.tsmiWidth3.Text = "3px"
		'
		'tsmiWidth4
		'
		Me.tsmiWidth4.Name = "tsmiWidth4"
		Me.tsmiWidth4.Size = New System.Drawing.Size(104, 22)
		Me.tsmiWidth4.Text = "4px"
		'
		'tsmiWidth5
		'
		Me.tsmiWidth5.Name = "tsmiWidth5"
		Me.tsmiWidth5.Size = New System.Drawing.Size(104, 22)
		Me.tsmiWidth5.Text = "5px"
		'
		'tsmiWidth10
		'
		Me.tsmiWidth10.Name = "tsmiWidth10"
		Me.tsmiWidth10.Size = New System.Drawing.Size(104, 22)
		Me.tsmiWidth10.Text = "10px"
		'
		'tsmiPenColor
		'
		Me.tsmiPenColor.Name = "tsmiPenColor"
		Me.tsmiPenColor.Size = New System.Drawing.Size(166, 22)
		Me.tsmiPenColor.Text = "ペンの色(&C)..."
		'
		'tsmiCanvas
		'
		Me.tsmiCanvas.Name = "tsmiCanvas"
		Me.tsmiCanvas.Size = New System.Drawing.Size(166, 22)
		Me.tsmiCanvas.Text = "キャンバス(&S)..."
		'
		'tsmiHelp
		'
		Me.tsmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiManual, Me.ToolStripSeparator2, Me.tsmiVersion})
		Me.tsmiHelp.Name = "tsmiHelp"
		Me.tsmiHelp.Size = New System.Drawing.Size(75, 22)
		Me.tsmiHelp.Text = "ヘルプ(&H)"
		'
		'tsmiManual
		'
		Me.tsmiManual.Name = "tsmiManual"
		Me.tsmiManual.Size = New System.Drawing.Size(190, 22)
		Me.tsmiManual.Text = "使い方(&U)..."
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
		'
		'tsmiVersion
		'
		Me.tsmiVersion.Name = "tsmiVersion"
		Me.tsmiVersion.Size = New System.Drawing.Size(190, 22)
		Me.tsmiVersion.Text = "バージョン情報(&V)..."
		'
		'sstMain
		'
		Me.sstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslDrawingType, Me.tsslPenWidth})
		Me.sstMain.Location = New System.Drawing.Point(0, 336)
		Me.sstMain.Name = "sstMain"
		Me.sstMain.Size = New System.Drawing.Size(544, 27)
		Me.sstMain.TabIndex = 18
		Me.sstMain.Text = "StatusStrip1"
		'
		'tsslDrawingType
		'
		Me.tsslDrawingType.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
		Me.tsslDrawingType.Name = "tsslDrawingType"
		Me.tsslDrawingType.Size = New System.Drawing.Size(108, 22)
		Me.tsslDrawingType.Text = "tsslDrawingType"
		'
		'tsslPenWidth
		'
		Me.tsslPenWidth.Name = "tsslPenWidth"
		Me.tsslPenWidth.Size = New System.Drawing.Size(83, 22)
		Me.tsslPenWidth.Text = "tsslPenWidth"
		'
		'pnlDrawArea
		'
		Me.pnlDrawArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlDrawArea.BackColor = System.Drawing.SystemColors.ControlDark
		Me.pnlDrawArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlDrawArea.Controls.Add(Me.pctCanvas)
		Me.pnlDrawArea.Location = New System.Drawing.Point(214, 26)
		Me.pnlDrawArea.Margin = New System.Windows.Forms.Padding(9, 0, 0, 0)
		Me.pnlDrawArea.Name = "pnlDrawArea"
		Me.pnlDrawArea.Size = New System.Drawing.Size(330, 314)
		Me.pnlDrawArea.TabIndex = 17
		'
		'btnCreateNew
		'
		Me.btnCreateNew.Location = New System.Drawing.Point(12, 35)
		Me.btnCreateNew.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
		Me.btnCreateNew.Name = "btnCreateNew"
		Me.btnCreateNew.Size = New System.Drawing.Size(92, 23)
		Me.btnCreateNew.TabIndex = 1
		Me.btnCreateNew.Text = "新規作成"
		Me.btnCreateNew.UseVisualStyleBackColor = True
		'
		'btnNormal
		'
		Me.btnNormal.Location = New System.Drawing.Point(12, 70)
		Me.btnNormal.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
		Me.btnNormal.Name = "btnNormal"
		Me.btnNormal.Size = New System.Drawing.Size(92, 23)
		Me.btnNormal.TabIndex = 2
		Me.btnNormal.Text = "フリーハンド"
		Me.btnNormal.UseVisualStyleBackColor = True
		'
		'btnLeftRightMirror
		'
		Me.btnLeftRightMirror.Location = New System.Drawing.Point(110, 70)
		Me.btnLeftRightMirror.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
		Me.btnLeftRightMirror.Name = "btnLeftRightMirror"
		Me.btnLeftRightMirror.Size = New System.Drawing.Size(92, 23)
		Me.btnLeftRightMirror.TabIndex = 3
		Me.btnLeftRightMirror.Text = "左右対象"
		Me.btnLeftRightMirror.UseVisualStyleBackColor = True
		'
		'btnUpDownMirror
		'
		Me.btnUpDownMirror.Location = New System.Drawing.Point(12, 99)
		Me.btnUpDownMirror.Name = "btnUpDownMirror"
		Me.btnUpDownMirror.Size = New System.Drawing.Size(92, 23)
		Me.btnUpDownMirror.TabIndex = 4
		Me.btnUpDownMirror.Text = "上下対称"
		Me.btnUpDownMirror.UseVisualStyleBackColor = True
		'
		'btnLeftRightUpDownMirror
		'
		Me.btnLeftRightUpDownMirror.Location = New System.Drawing.Point(110, 99)
		Me.btnLeftRightUpDownMirror.Name = "btnLeftRightUpDownMirror"
		Me.btnLeftRightUpDownMirror.Size = New System.Drawing.Size(92, 23)
		Me.btnLeftRightUpDownMirror.TabIndex = 5
		Me.btnLeftRightUpDownMirror.Text = "上下左右対称"
		Me.btnLeftRightUpDownMirror.UseVisualStyleBackColor = True
		'
		'btnRotate3
		'
		Me.btnRotate3.Location = New System.Drawing.Point(12, 128)
		Me.btnRotate3.Name = "btnRotate3"
		Me.btnRotate3.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate3.TabIndex = 6
		Me.btnRotate3.Text = "3分割"
		Me.btnRotate3.UseVisualStyleBackColor = True
		'
		'btnRotate3Mirror
		'
		Me.btnRotate3Mirror.Location = New System.Drawing.Point(110, 128)
		Me.btnRotate3Mirror.Name = "btnRotate3Mirror"
		Me.btnRotate3Mirror.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate3Mirror.TabIndex = 7
		Me.btnRotate3Mirror.Text = "3分割ミラー"
		Me.btnRotate3Mirror.UseVisualStyleBackColor = True
		'
		'btnRotate4
		'
		Me.btnRotate4.Location = New System.Drawing.Point(12, 157)
		Me.btnRotate4.Name = "btnRotate4"
		Me.btnRotate4.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate4.TabIndex = 8
		Me.btnRotate4.Text = "4分割"
		Me.btnRotate4.UseVisualStyleBackColor = True
		'
		'btnRotate4Mirror
		'
		Me.btnRotate4Mirror.Location = New System.Drawing.Point(110, 157)
		Me.btnRotate4Mirror.Name = "btnRotate4Mirror"
		Me.btnRotate4Mirror.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate4Mirror.TabIndex = 9
		Me.btnRotate4Mirror.Text = "4分割ミラー"
		Me.btnRotate4Mirror.UseVisualStyleBackColor = True
		'
		'btnRotate5
		'
		Me.btnRotate5.Location = New System.Drawing.Point(12, 186)
		Me.btnRotate5.Name = "btnRotate5"
		Me.btnRotate5.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate5.TabIndex = 10
		Me.btnRotate5.Text = "5分割"
		Me.btnRotate5.UseVisualStyleBackColor = True
		'
		'btnRotate5Mirror
		'
		Me.btnRotate5Mirror.Location = New System.Drawing.Point(110, 186)
		Me.btnRotate5Mirror.Name = "btnRotate5Mirror"
		Me.btnRotate5Mirror.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate5Mirror.TabIndex = 11
		Me.btnRotate5Mirror.Text = "5分割ミラー"
		Me.btnRotate5Mirror.UseVisualStyleBackColor = True
		'
		'btnRotate6
		'
		Me.btnRotate6.Location = New System.Drawing.Point(12, 215)
		Me.btnRotate6.Name = "btnRotate6"
		Me.btnRotate6.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate6.TabIndex = 12
		Me.btnRotate6.Text = "6分割"
		Me.btnRotate6.UseVisualStyleBackColor = True
		'
		'btnRotate6Mirror
		'
		Me.btnRotate6Mirror.Location = New System.Drawing.Point(110, 215)
		Me.btnRotate6Mirror.Name = "btnRotate6Mirror"
		Me.btnRotate6Mirror.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate6Mirror.TabIndex = 13
		Me.btnRotate6Mirror.Text = "6分割ミラー"
		Me.btnRotate6Mirror.UseVisualStyleBackColor = True
		'
		'btnRotate8
		'
		Me.btnRotate8.Location = New System.Drawing.Point(12, 244)
		Me.btnRotate8.Name = "btnRotate8"
		Me.btnRotate8.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate8.TabIndex = 14
		Me.btnRotate8.Text = "8分割"
		Me.btnRotate8.UseVisualStyleBackColor = True
		'
		'btnRotate8Mirror
		'
		Me.btnRotate8Mirror.Location = New System.Drawing.Point(110, 244)
		Me.btnRotate8Mirror.Name = "btnRotate8Mirror"
		Me.btnRotate8Mirror.Size = New System.Drawing.Size(92, 23)
		Me.btnRotate8Mirror.TabIndex = 15
		Me.btnRotate8Mirror.Text = "8分割ミラー"
		Me.btnRotate8Mirror.UseVisualStyleBackColor = True
		'
		'btnPenColor
		'
		Me.btnPenColor.Location = New System.Drawing.Point(12, 279)
		Me.btnPenColor.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
		Me.btnPenColor.Name = "btnPenColor"
		Me.btnPenColor.Size = New System.Drawing.Size(92, 23)
		Me.btnPenColor.TabIndex = 16
		Me.btnPenColor.Text = "ペンの色"
		Me.btnPenColor.UseVisualStyleBackColor = True
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(544, 363)
		Me.Controls.Add(Me.btnPenColor)
		Me.Controls.Add(Me.btnRotate8Mirror)
		Me.Controls.Add(Me.btnRotate8)
		Me.Controls.Add(Me.btnRotate6Mirror)
		Me.Controls.Add(Me.btnRotate6)
		Me.Controls.Add(Me.btnRotate5Mirror)
		Me.Controls.Add(Me.btnRotate5)
		Me.Controls.Add(Me.btnRotate4Mirror)
		Me.Controls.Add(Me.btnRotate4)
		Me.Controls.Add(Me.btnRotate3Mirror)
		Me.Controls.Add(Me.btnRotate3)
		Me.Controls.Add(Me.btnLeftRightUpDownMirror)
		Me.Controls.Add(Me.btnUpDownMirror)
		Me.Controls.Add(Me.btnLeftRightMirror)
		Me.Controls.Add(Me.btnNormal)
		Me.Controls.Add(Me.btnCreateNew)
		Me.Controls.Add(Me.pnlDrawArea)
		Me.Controls.Add(Me.sstMain)
		Me.Controls.Add(Me.mstMain)
		Me.MainMenuStrip = Me.mstMain
		Me.MinimumSize = New System.Drawing.Size(560, 400)
		Me.Name = "MainForm"
		Me.Text = "AffectedCrystalForm"
		CType(Me.pctCanvas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mstMain.ResumeLayout(False)
		Me.mstMain.PerformLayout()
		Me.sstMain.ResumeLayout(False)
		Me.sstMain.PerformLayout()
		Me.pnlDrawArea.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents pctCanvas As System.Windows.Forms.PictureBox
	Friend WithEvents mstMain As System.Windows.Forms.MenuStrip
	Friend WithEvents tsmiFile As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents sstMain As System.Windows.Forms.StatusStrip
	Friend WithEvents tsmiConfig As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents pnlDrawArea As System.Windows.Forms.Panel
	Friend WithEvents tsslDrawingType As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents tsmiCreateNew As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents tsmiCanvas As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents btnCreateNew As System.Windows.Forms.Button
	Friend WithEvents btnNormal As System.Windows.Forms.Button
	Friend WithEvents btnLeftRightMirror As System.Windows.Forms.Button
	Friend WithEvents btnUpDownMirror As System.Windows.Forms.Button
	Friend WithEvents btnLeftRightUpDownMirror As System.Windows.Forms.Button
	Friend WithEvents btnRotate3 As System.Windows.Forms.Button
	Friend WithEvents btnRotate3Mirror As System.Windows.Forms.Button
	Friend WithEvents btnRotate4 As System.Windows.Forms.Button
	Friend WithEvents btnRotate4Mirror As System.Windows.Forms.Button
	Friend WithEvents btnRotate5 As System.Windows.Forms.Button
	Friend WithEvents btnRotate5Mirror As System.Windows.Forms.Button
	Friend WithEvents btnRotate6 As System.Windows.Forms.Button
	Friend WithEvents btnRotate6Mirror As System.Windows.Forms.Button
	Friend WithEvents btnRotate8 As System.Windows.Forms.Button
	Friend WithEvents btnRotate8Mirror As System.Windows.Forms.Button
	Friend WithEvents tsmiOpen As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiSave As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiSaveAs As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents btnPenColor As System.Windows.Forms.Button
	Friend WithEvents tsmiHelp As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiManual As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents tsmiVersion As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiPenColor As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiDrawerType As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiNormal As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiLeftRightMirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiUpDownMirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiLeftRightUpDownMirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate3 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate3Mirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate4 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate4Mirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate5 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate5Mirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate6 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate6Mirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate8 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate8Mirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate12 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate12Mirror As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate16 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate24 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate32 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiRotate64 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiPenWidth As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiWidth1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiWidth2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiWidth3 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiWidth4 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiWidth5 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsmiWidth10 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsslPenWidth As System.Windows.Forms.ToolStripStatusLabel

End Class
