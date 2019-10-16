<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"a", "0"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"a", "0"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.bodyFill = New System.Windows.Forms.TableLayoutPanel()
        Me.gridValues = New System.Windows.Forms.TableLayoutPanel()
        Me.ioF2 = New System.Windows.Forms.TextBox()
        Me.ioF1 = New System.Windows.Forms.TextBox()
        Me.ioSF = New System.Windows.Forms.TextBox()
        Me.ioZF = New System.Windows.Forms.TextBox()
        Me.ioPF = New System.Windows.Forms.TextBox()
        Me.ioOF = New System.Windows.Forms.TextBox()
        Me.ioCX = New System.Windows.Forms.TextBox()
        Me.ioAX = New System.Windows.Forms.TextBox()
        Me.lblAX = New System.Windows.Forms.Label()
        Me.lblCX = New System.Windows.Forms.Label()
        Me.fOF = New System.Windows.Forms.Label()
        Me.fPF = New System.Windows.Forms.Label()
        Me.fSF = New System.Windows.Forms.Label()
        Me.fZF = New System.Windows.Forms.Label()
        Me.f1 = New System.Windows.Forms.Label()
        Me.f2 = New System.Windows.Forms.Label()
        Me.gridComs = New System.Windows.Forms.TableLayoutPanel()
        Me.gridCJump = New System.Windows.Forms.TableLayoutPanel()
        Me.aLoop = New System.Windows.Forms.Button()
        Me.aJg = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.aJnl = New System.Windows.Forms.Button()
        Me.aJne = New System.Windows.Forms.Button()
        Me.aJe = New System.Windows.Forms.Button()
        Me.aJl = New System.Windows.Forms.Button()
        Me.aJng = New System.Windows.Forms.Button()
        Me.aJmp = New System.Windows.Forms.Button()
        Me.gridCArithm = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.aAdd = New System.Windows.Forms.Button()
        Me.aDiv = New System.Windows.Forms.Button()
        Me.aSub = New System.Windows.Forms.Button()
        Me.aMul = New System.Windows.Forms.Button()
        Me.aCmp = New System.Windows.Forms.Button()
        Me.aInc = New System.Windows.Forms.Button()
        Me.aDec = New System.Windows.Forms.Button()
        Me.gridCCommon = New System.Windows.Forms.TableLayoutPanel()
        Me.aXchg = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.aVar = New System.Windows.Forms.Button()
        Me.aMov = New System.Windows.Forms.Button()
        Me.aIo = New System.Windows.Forms.Button()
        Me.aStop = New System.Windows.Forms.Button()
        Me.aMark = New System.Windows.Forms.Button()
        Me.gridMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gridPlugs = New System.Windows.Forms.TableLayoutPanel()
        Me.listMarks = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.infoException = New System.Windows.Forms.Label()
        Me.plugCode = New System.Windows.Forms.RichTextBox()
        Me.listLocals = New System.Windows.Forms.ListView()
        Me.localCol1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.localCol2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlbDebug = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdProject = New System.Windows.Forms.Button()
        Me.debugStart = New System.Windows.Forms.Button()
        Me.debugStop = New System.Windows.Forms.Button()
        Me.debugStep = New System.Windows.Forms.Button()
        Me.statsBar = New System.Windows.Forms.TableLayoutPanel()
        Me.statsLine = New System.Windows.Forms.Label()
        Me.statsColumn = New System.Windows.Forms.Label()
        Me.statsChar = New System.Windows.Forms.Label()
        Me.tlbMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.mainNew = New System.Windows.Forms.Button()
        Me.mainOpen = New System.Windows.Forms.Button()
        Me.mainSave = New System.Windows.Forms.Button()
        Me.mainSaveas = New System.Windows.Forms.Button()
        Me.mainInfo = New System.Windows.Forms.Button()
        Me.mainHelp = New System.Windows.Forms.Button()
        Me.ToolTipManager = New System.Windows.Forms.ToolTip(Me.components)
        Me.bodyBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.appStat = New System.Windows.Forms.Label()
        Me.keyMenu = New System.Windows.Forms.MenuStrip()
        Me.keyFileH = New System.Windows.Forms.ToolStripMenuItem()
        Me.keyNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.keyOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.keySave = New System.Windows.Forms.ToolStripMenuItem()
        Me.keySaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.keyInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.bodyFill.SuspendLayout()
        Me.gridValues.SuspendLayout()
        Me.gridComs.SuspendLayout()
        Me.gridCJump.SuspendLayout()
        Me.gridCArithm.SuspendLayout()
        Me.gridCCommon.SuspendLayout()
        Me.gridMain.SuspendLayout()
        Me.gridPlugs.SuspendLayout()
        Me.tlbDebug.SuspendLayout()
        Me.statsBar.SuspendLayout()
        Me.tlbMain.SuspendLayout()
        Me.bodyBottom.SuspendLayout()
        Me.keyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'bodyFill
        '
        Me.bodyFill.ColumnCount = 2
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.Controls.Add(Me.gridValues, 0, 0)
        Me.bodyFill.Controls.Add(Me.gridComs, 0, 1)
        Me.bodyFill.Controls.Add(Me.gridMain, 1, 1)
        Me.bodyFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bodyFill.Location = New System.Drawing.Point(0, 39)
        Me.bodyFill.Margin = New System.Windows.Forms.Padding(0)
        Me.bodyFill.Name = "bodyFill"
        Me.bodyFill.RowCount = 2
        Me.bodyFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.bodyFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.bodyFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.bodyFill.Size = New System.Drawing.Size(902, 678)
        Me.bodyFill.TabIndex = 0
        '
        'gridValues
        '
        Me.gridValues.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.gridValues.ColumnCount = 10
        Me.bodyFill.SetColumnSpan(Me.gridValues, 2)
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gridValues.Controls.Add(Me.ioF2, 8, 1)
        Me.gridValues.Controls.Add(Me.ioF1, 8, 0)
        Me.gridValues.Controls.Add(Me.ioSF, 6, 1)
        Me.gridValues.Controls.Add(Me.ioZF, 6, 0)
        Me.gridValues.Controls.Add(Me.ioPF, 4, 1)
        Me.gridValues.Controls.Add(Me.ioOF, 4, 0)
        Me.gridValues.Controls.Add(Me.ioCX, 1, 1)
        Me.gridValues.Controls.Add(Me.ioAX, 1, 0)
        Me.gridValues.Controls.Add(Me.lblAX, 0, 0)
        Me.gridValues.Controls.Add(Me.lblCX, 0, 1)
        Me.gridValues.Controls.Add(Me.fOF, 3, 0)
        Me.gridValues.Controls.Add(Me.fPF, 3, 1)
        Me.gridValues.Controls.Add(Me.fSF, 5, 1)
        Me.gridValues.Controls.Add(Me.fZF, 5, 0)
        Me.gridValues.Controls.Add(Me.f1, 7, 0)
        Me.gridValues.Controls.Add(Me.f2, 7, 1)
        Me.gridValues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridValues.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridValues.ForeColor = System.Drawing.SystemColors.Window
        Me.gridValues.Location = New System.Drawing.Point(0, 0)
        Me.gridValues.Margin = New System.Windows.Forms.Padding(0)
        Me.gridValues.Name = "gridValues"
        Me.gridValues.RowCount = 2
        Me.gridValues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.gridValues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.gridValues.Size = New System.Drawing.Size(902, 200)
        Me.gridValues.TabIndex = 2
        '
        'ioF2
        '
        Me.ioF2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioF2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ioF2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioF2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioF2.ForeColor = System.Drawing.SystemColors.Window
        Me.ioF2.Location = New System.Drawing.Point(803, 123)
        Me.ioF2.Name = "ioF2"
        Me.ioF2.ReadOnly = True
        Me.ioF2.Size = New System.Drawing.Size(94, 54)
        Me.ioF2.TabIndex = 0
        Me.ioF2.Text = "0"
        Me.ioF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioF2.Visible = False
        Me.ioF2.WordWrap = False
        '
        'ioF1
        '
        Me.ioF1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioF1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioF1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ioF1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioF1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioF1.ForeColor = System.Drawing.SystemColors.Window
        Me.ioF1.Location = New System.Drawing.Point(803, 23)
        Me.ioF1.Name = "ioF1"
        Me.ioF1.ReadOnly = True
        Me.ioF1.Size = New System.Drawing.Size(94, 54)
        Me.ioF1.TabIndex = 0
        Me.ioF1.Text = "0"
        Me.ioF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioF1.Visible = False
        Me.ioF1.WordWrap = False
        '
        'ioSF
        '
        Me.ioSF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioSF.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioSF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ioSF.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioSF.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioSF.ForeColor = System.Drawing.SystemColors.Window
        Me.ioSF.Location = New System.Drawing.Point(603, 123)
        Me.ioSF.Name = "ioSF"
        Me.ioSF.ReadOnly = True
        Me.ioSF.Size = New System.Drawing.Size(94, 54)
        Me.ioSF.TabIndex = 0
        Me.ioSF.Text = "0"
        Me.ioSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioSF.WordWrap = False
        '
        'ioZF
        '
        Me.ioZF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioZF.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioZF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ioZF.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioZF.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioZF.ForeColor = System.Drawing.SystemColors.Window
        Me.ioZF.Location = New System.Drawing.Point(603, 23)
        Me.ioZF.Name = "ioZF"
        Me.ioZF.ReadOnly = True
        Me.ioZF.Size = New System.Drawing.Size(94, 54)
        Me.ioZF.TabIndex = 0
        Me.ioZF.Text = "0"
        Me.ioZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioZF.WordWrap = False
        '
        'ioPF
        '
        Me.ioPF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioPF.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioPF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ioPF.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioPF.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPF.ForeColor = System.Drawing.SystemColors.Window
        Me.ioPF.Location = New System.Drawing.Point(403, 123)
        Me.ioPF.Name = "ioPF"
        Me.ioPF.ReadOnly = True
        Me.ioPF.Size = New System.Drawing.Size(94, 54)
        Me.ioPF.TabIndex = 0
        Me.ioPF.Text = "0"
        Me.ioPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioPF.WordWrap = False
        '
        'ioOF
        '
        Me.ioOF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioOF.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioOF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ioOF.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioOF.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioOF.ForeColor = System.Drawing.SystemColors.Window
        Me.ioOF.Location = New System.Drawing.Point(403, 23)
        Me.ioOF.Name = "ioOF"
        Me.ioOF.ReadOnly = True
        Me.ioOF.Size = New System.Drawing.Size(94, 54)
        Me.ioOF.TabIndex = 0
        Me.ioOF.Text = "0"
        Me.ioOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioOF.WordWrap = False
        '
        'ioCX
        '
        Me.ioCX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioCX.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioCX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridValues.SetColumnSpan(Me.ioCX, 2)
        Me.ioCX.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioCX.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioCX.ForeColor = System.Drawing.SystemColors.Window
        Me.ioCX.Location = New System.Drawing.Point(103, 107)
        Me.ioCX.Name = "ioCX"
        Me.ioCX.ReadOnly = True
        Me.ioCX.Size = New System.Drawing.Size(194, 86)
        Me.ioCX.TabIndex = 0
        Me.ioCX.Text = "0"
        Me.ioCX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioCX.WordWrap = False
        '
        'ioAX
        '
        Me.ioAX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ioAX.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ioAX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridValues.SetColumnSpan(Me.ioAX, 2)
        Me.ioAX.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ioAX.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioAX.ForeColor = System.Drawing.SystemColors.Window
        Me.ioAX.Location = New System.Drawing.Point(103, 7)
        Me.ioAX.Name = "ioAX"
        Me.ioAX.ReadOnly = True
        Me.ioAX.Size = New System.Drawing.Size(194, 86)
        Me.ioAX.TabIndex = 0
        Me.ioAX.Text = "0"
        Me.ioAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ioAX.WordWrap = False
        '
        'lblAX
        '
        Me.lblAX.AutoSize = True
        Me.lblAX.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAX.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAX.Location = New System.Drawing.Point(10, 0)
        Me.lblAX.Name = "lblAX"
        Me.lblAX.Size = New System.Drawing.Size(87, 100)
        Me.lblAX.TabIndex = 0
        Me.lblAX.Text = "AX"
        Me.lblAX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipManager.SetToolTip(Me.lblAX, "Register des Akkumulators")
        '
        'lblCX
        '
        Me.lblCX.AutoSize = True
        Me.lblCX.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCX.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCX.Location = New System.Drawing.Point(11, 100)
        Me.lblCX.Name = "lblCX"
        Me.lblCX.Size = New System.Drawing.Size(86, 100)
        Me.lblCX.TabIndex = 2
        Me.lblCX.Text = "CX"
        Me.lblCX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipManager.SetToolTip(Me.lblCX, "Register des Zählers")
        '
        'fOF
        '
        Me.fOF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fOF.AutoSize = True
        Me.fOF.Location = New System.Drawing.Point(352, 34)
        Me.fOF.Name = "fOF"
        Me.fOF.Size = New System.Drawing.Size(45, 32)
        Me.fOF.TabIndex = 4
        Me.fOF.Text = "OF"
        Me.fOF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipManager.SetToolTip(Me.fOF, "Überlauf (Overflow Flag)")
        '
        'fPF
        '
        Me.fPF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fPF.AutoSize = True
        Me.fPF.Location = New System.Drawing.Point(357, 134)
        Me.fPF.Name = "fPF"
        Me.fPF.Size = New System.Drawing.Size(40, 32)
        Me.fPF.TabIndex = 6
        Me.fPF.Text = "PF"
        Me.fPF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipManager.SetToolTip(Me.fPF, "Parität (Parity Flag)")
        '
        'fSF
        '
        Me.fSF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fSF.AutoSize = True
        Me.fSF.Location = New System.Drawing.Point(557, 134)
        Me.fSF.Name = "fSF"
        Me.fSF.Size = New System.Drawing.Size(40, 32)
        Me.fSF.TabIndex = 10
        Me.fSF.Text = "SF"
        Me.fSF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipManager.SetToolTip(Me.fSF, "Ist Negativ (Sign Flag)")
        '
        'fZF
        '
        Me.fZF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fZF.AutoSize = True
        Me.fZF.Location = New System.Drawing.Point(556, 34)
        Me.fZF.Name = "fZF"
        Me.fZF.Size = New System.Drawing.Size(41, 32)
        Me.fZF.TabIndex = 8
        Me.fZF.Text = "ZF"
        Me.fZF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipManager.SetToolTip(Me.fZF, "Ist Null (Zero Flag)")
        '
        'f1
        '
        Me.f1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.f1.AutoSize = True
        Me.f1.Enabled = False
        Me.f1.Location = New System.Drawing.Point(757, 34)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(40, 32)
        Me.f1.TabIndex = 12
        Me.f1.Text = "F1"
        Me.f1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.f1.Visible = False
        '
        'f2
        '
        Me.f2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.f2.AutoSize = True
        Me.f2.Enabled = False
        Me.f2.Location = New System.Drawing.Point(757, 134)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(40, 32)
        Me.f2.TabIndex = 14
        Me.f2.Text = "F2"
        Me.f2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.f2.Visible = False
        '
        'gridComs
        '
        Me.gridComs.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.gridComs.ColumnCount = 3
        Me.gridComs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridComs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridComs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridComs.Controls.Add(Me.gridCJump, 0, 3)
        Me.gridComs.Controls.Add(Me.gridCArithm, 0, 2)
        Me.gridComs.Controls.Add(Me.gridCCommon, 0, 1)
        Me.gridComs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridComs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridComs.ForeColor = System.Drawing.SystemColors.Window
        Me.gridComs.Location = New System.Drawing.Point(0, 200)
        Me.gridComs.Margin = New System.Windows.Forms.Padding(0)
        Me.gridComs.Name = "gridComs"
        Me.gridComs.RowCount = 5
        Me.gridComs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridComs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridComs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridComs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridComs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gridComs.Size = New System.Drawing.Size(300, 478)
        Me.gridComs.TabIndex = 1
        '
        'gridCJump
        '
        Me.gridCJump.ColumnCount = 4
        Me.gridComs.SetColumnSpan(Me.gridCJump, 3)
        Me.gridCJump.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCJump.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCJump.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCJump.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCJump.Controls.Add(Me.aLoop, 0, 2)
        Me.gridCJump.Controls.Add(Me.aJg, 1, 1)
        Me.gridCJump.Controls.Add(Me.Label6, 0, 0)
        Me.gridCJump.Controls.Add(Me.aJnl, 3, 2)
        Me.gridCJump.Controls.Add(Me.aJne, 2, 2)
        Me.gridCJump.Controls.Add(Me.aJe, 2, 1)
        Me.gridCJump.Controls.Add(Me.aJl, 3, 1)
        Me.gridCJump.Controls.Add(Me.aJng, 1, 2)
        Me.gridCJump.Controls.Add(Me.aJmp, 0, 1)
        Me.gridCJump.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCJump.Location = New System.Drawing.Point(3, 303)
        Me.gridCJump.Name = "gridCJump"
        Me.gridCJump.RowCount = 3
        Me.gridCJump.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCJump.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCJump.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCJump.Size = New System.Drawing.Size(294, 94)
        Me.gridCJump.TabIndex = 2
        '
        'aLoop
        '
        Me.aLoop.AutoSize = True
        Me.aLoop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aLoop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aLoop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aLoop.FlatAppearance.BorderSize = 0
        Me.aLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aLoop.Location = New System.Drawing.Point(1, 63)
        Me.aLoop.Margin = New System.Windows.Forms.Padding(1)
        Me.aLoop.Name = "aLoop"
        Me.aLoop.Size = New System.Drawing.Size(71, 30)
        Me.aLoop.TabIndex = 2
        Me.aLoop.Text = "LOOP"
        Me.ToolTipManager.SetToolTip(Me.aLoop, "Springt zu einer Marke, wenn die Schleife beendet ist sprich, wenn das Zählregist" & _
        "er Null ist.")
        Me.aLoop.UseVisualStyleBackColor = True
        '
        'aJg
        '
        Me.aJg.AutoSize = True
        Me.aJg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aJg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aJg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aJg.FlatAppearance.BorderSize = 0
        Me.aJg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aJg.Location = New System.Drawing.Point(74, 32)
        Me.aJg.Margin = New System.Windows.Forms.Padding(1)
        Me.aJg.Name = "aJg"
        Me.aJg.Size = New System.Drawing.Size(71, 29)
        Me.aJg.TabIndex = 3
        Me.aJg.Text = "JG"
        Me.ToolTipManager.SetToolTip(Me.aJg, "Springt zu einer Marke, wenn der Wert des Akkumulators größer Null ist.")
        Me.aJg.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.gridCJump.SetColumnSpan(Me.Label6, 4)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 31)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sprungbefehle"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aJnl
        '
        Me.aJnl.AutoSize = True
        Me.aJnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aJnl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aJnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aJnl.FlatAppearance.BorderSize = 0
        Me.aJnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aJnl.Location = New System.Drawing.Point(220, 63)
        Me.aJnl.Margin = New System.Windows.Forms.Padding(1)
        Me.aJnl.Name = "aJnl"
        Me.aJnl.Size = New System.Drawing.Size(73, 30)
        Me.aJnl.TabIndex = 8
        Me.aJnl.Text = "JNL"
        Me.ToolTipManager.SetToolTip(Me.aJnl, "Springt zu einer Marke, wenn der Wert des Akkumulators nicht kleiner Null ist.")
        Me.aJnl.UseVisualStyleBackColor = True
        '
        'aJne
        '
        Me.aJne.AutoSize = True
        Me.aJne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aJne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aJne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aJne.FlatAppearance.BorderSize = 0
        Me.aJne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aJne.Location = New System.Drawing.Point(147, 63)
        Me.aJne.Margin = New System.Windows.Forms.Padding(1)
        Me.aJne.Name = "aJne"
        Me.aJne.Size = New System.Drawing.Size(71, 30)
        Me.aJne.TabIndex = 6
        Me.aJne.Text = "JNE"
        Me.ToolTipManager.SetToolTip(Me.aJne, "Springt zu einer Marke, wenn der Wert des Akkumulators ungleich Null ist.")
        Me.aJne.UseVisualStyleBackColor = True
        '
        'aJe
        '
        Me.aJe.AutoSize = True
        Me.aJe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aJe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aJe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aJe.FlatAppearance.BorderSize = 0
        Me.aJe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aJe.Location = New System.Drawing.Point(147, 32)
        Me.aJe.Margin = New System.Windows.Forms.Padding(1)
        Me.aJe.Name = "aJe"
        Me.aJe.Size = New System.Drawing.Size(71, 29)
        Me.aJe.TabIndex = 5
        Me.aJe.Text = "JE"
        Me.ToolTipManager.SetToolTip(Me.aJe, "Springt zu einer Marke, wenn der Wert des Akkumulators gleich Null ist.")
        Me.aJe.UseVisualStyleBackColor = True
        '
        'aJl
        '
        Me.aJl.AutoSize = True
        Me.aJl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aJl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aJl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aJl.FlatAppearance.BorderSize = 0
        Me.aJl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aJl.Location = New System.Drawing.Point(220, 32)
        Me.aJl.Margin = New System.Windows.Forms.Padding(1)
        Me.aJl.Name = "aJl"
        Me.aJl.Size = New System.Drawing.Size(73, 29)
        Me.aJl.TabIndex = 7
        Me.aJl.Text = "JL"
        Me.ToolTipManager.SetToolTip(Me.aJl, "Springt zu einer Marke, wenn der Wert des Akkumulators kleiner Null ist.")
        Me.aJl.UseVisualStyleBackColor = True
        '
        'aJng
        '
        Me.aJng.AutoSize = True
        Me.aJng.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aJng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aJng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aJng.FlatAppearance.BorderSize = 0
        Me.aJng.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aJng.Location = New System.Drawing.Point(74, 63)
        Me.aJng.Margin = New System.Windows.Forms.Padding(1)
        Me.aJng.Name = "aJng"
        Me.aJng.Size = New System.Drawing.Size(71, 30)
        Me.aJng.TabIndex = 4
        Me.aJng.Text = "JNG"
        Me.ToolTipManager.SetToolTip(Me.aJng, "Springt zu einer Marke, wenn der Wert des Akkumulators nicht größer Null ist.")
        Me.aJng.UseVisualStyleBackColor = True
        '
        'aJmp
        '
        Me.aJmp.AutoSize = True
        Me.aJmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aJmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aJmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aJmp.FlatAppearance.BorderSize = 0
        Me.aJmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aJmp.Location = New System.Drawing.Point(1, 32)
        Me.aJmp.Margin = New System.Windows.Forms.Padding(1)
        Me.aJmp.Name = "aJmp"
        Me.aJmp.Size = New System.Drawing.Size(71, 29)
        Me.aJmp.TabIndex = 1
        Me.aJmp.Text = "JMP"
        Me.ToolTipManager.SetToolTip(Me.aJmp, "Springt zu einer Marke.")
        Me.aJmp.UseVisualStyleBackColor = True
        '
        'gridCArithm
        '
        Me.gridCArithm.ColumnCount = 4
        Me.gridComs.SetColumnSpan(Me.gridCArithm, 3)
        Me.gridCArithm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCArithm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCArithm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCArithm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCArithm.Controls.Add(Me.Label5, 0, 0)
        Me.gridCArithm.Controls.Add(Me.aAdd, 0, 1)
        Me.gridCArithm.Controls.Add(Me.aDiv, 1, 2)
        Me.gridCArithm.Controls.Add(Me.aSub, 0, 2)
        Me.gridCArithm.Controls.Add(Me.aMul, 1, 1)
        Me.gridCArithm.Controls.Add(Me.aCmp, 3, 1)
        Me.gridCArithm.Controls.Add(Me.aInc, 2, 1)
        Me.gridCArithm.Controls.Add(Me.aDec, 2, 2)
        Me.gridCArithm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCArithm.Location = New System.Drawing.Point(3, 203)
        Me.gridCArithm.Name = "gridCArithm"
        Me.gridCArithm.RowCount = 3
        Me.gridCArithm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCArithm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCArithm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCArithm.Size = New System.Drawing.Size(294, 94)
        Me.gridCArithm.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.gridCArithm.SetColumnSpan(Me.Label5, 4)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Arithmetische Befehle"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aAdd
        '
        Me.aAdd.AutoSize = True
        Me.aAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aAdd.FlatAppearance.BorderSize = 0
        Me.aAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aAdd.Location = New System.Drawing.Point(1, 32)
        Me.aAdd.Margin = New System.Windows.Forms.Padding(1)
        Me.aAdd.Name = "aAdd"
        Me.aAdd.Size = New System.Drawing.Size(71, 29)
        Me.aAdd.TabIndex = 1
        Me.aAdd.Text = "ADD"
        Me.ToolTipManager.SetToolTip(Me.aAdd, "Addiert einen Wert (eines Registers) zu einem Register und speichert das Ergebnis" & _
        " in diesem.")
        Me.aAdd.UseVisualStyleBackColor = True
        '
        'aDiv
        '
        Me.aDiv.AutoSize = True
        Me.aDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aDiv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aDiv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aDiv.FlatAppearance.BorderSize = 0
        Me.aDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aDiv.Location = New System.Drawing.Point(74, 63)
        Me.aDiv.Margin = New System.Windows.Forms.Padding(1)
        Me.aDiv.Name = "aDiv"
        Me.aDiv.Size = New System.Drawing.Size(71, 30)
        Me.aDiv.TabIndex = 4
        Me.aDiv.Text = "DIV"
        Me.ToolTipManager.SetToolTip(Me.aDiv, "Dividiert ein Register durch einen Wert (eines Registers) und speichert den ganzz" & _
        "ahligen Quotienten im Zielregister.")
        Me.aDiv.UseVisualStyleBackColor = True
        '
        'aSub
        '
        Me.aSub.AutoSize = True
        Me.aSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aSub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aSub.FlatAppearance.BorderSize = 0
        Me.aSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aSub.Location = New System.Drawing.Point(1, 63)
        Me.aSub.Margin = New System.Windows.Forms.Padding(1)
        Me.aSub.Name = "aSub"
        Me.aSub.Size = New System.Drawing.Size(71, 30)
        Me.aSub.TabIndex = 2
        Me.aSub.Text = "SUB"
        Me.ToolTipManager.SetToolTip(Me.aSub, "Subtrahiert einen Wert (eines Registers) von einem Register und speichert das Erg" & _
        "ebnis in diesem.")
        Me.aSub.UseVisualStyleBackColor = True
        '
        'aMul
        '
        Me.aMul.AutoSize = True
        Me.aMul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aMul.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aMul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aMul.FlatAppearance.BorderSize = 0
        Me.aMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aMul.Location = New System.Drawing.Point(74, 32)
        Me.aMul.Margin = New System.Windows.Forms.Padding(1)
        Me.aMul.Name = "aMul"
        Me.aMul.Size = New System.Drawing.Size(71, 29)
        Me.aMul.TabIndex = 3
        Me.aMul.Text = "MUL"
        Me.ToolTipManager.SetToolTip(Me.aMul, "Multipliziert einen Wert (eines Registers) mit einem Register und speichert das E" & _
        "rgebnis in diesem.")
        Me.aMul.UseVisualStyleBackColor = True
        '
        'aCmp
        '
        Me.aCmp.AutoSize = True
        Me.aCmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aCmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aCmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aCmp.FlatAppearance.BorderSize = 0
        Me.aCmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aCmp.Location = New System.Drawing.Point(220, 32)
        Me.aCmp.Margin = New System.Windows.Forms.Padding(1)
        Me.aCmp.Name = "aCmp"
        Me.aCmp.Size = New System.Drawing.Size(73, 29)
        Me.aCmp.TabIndex = 7
        Me.aCmp.Text = "CMP"
        Me.ToolTipManager.SetToolTip(Me.aCmp, "Prüft die Werte zweier Register auf Gleichheit.")
        Me.aCmp.UseVisualStyleBackColor = True
        '
        'aInc
        '
        Me.aInc.AutoSize = True
        Me.aInc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aInc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aInc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aInc.FlatAppearance.BorderSize = 0
        Me.aInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aInc.Location = New System.Drawing.Point(147, 32)
        Me.aInc.Margin = New System.Windows.Forms.Padding(1)
        Me.aInc.Name = "aInc"
        Me.aInc.Size = New System.Drawing.Size(71, 29)
        Me.aInc.TabIndex = 5
        Me.aInc.Text = "INC"
        Me.ToolTipManager.SetToolTip(Me.aInc, "Inkrementiert den Wert eines Register um 1.")
        Me.aInc.UseVisualStyleBackColor = True
        '
        'aDec
        '
        Me.aDec.AutoSize = True
        Me.aDec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aDec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aDec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aDec.FlatAppearance.BorderSize = 0
        Me.aDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aDec.Location = New System.Drawing.Point(147, 63)
        Me.aDec.Margin = New System.Windows.Forms.Padding(1)
        Me.aDec.Name = "aDec"
        Me.aDec.Size = New System.Drawing.Size(71, 30)
        Me.aDec.TabIndex = 6
        Me.aDec.Text = "DEC"
        Me.ToolTipManager.SetToolTip(Me.aDec, "Dekrementiert den Wert eines Registers um 1.")
        Me.aDec.UseVisualStyleBackColor = True
        '
        'gridCCommon
        '
        Me.gridCCommon.ColumnCount = 4
        Me.gridComs.SetColumnSpan(Me.gridCCommon, 3)
        Me.gridCCommon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCCommon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCCommon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCCommon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.gridCCommon.Controls.Add(Me.aXchg, 0, 2)
        Me.gridCCommon.Controls.Add(Me.Label4, 0, 0)
        Me.gridCCommon.Controls.Add(Me.aVar, 0, 1)
        Me.gridCCommon.Controls.Add(Me.aMov, 1, 1)
        Me.gridCCommon.Controls.Add(Me.aIo, 2, 1)
        Me.gridCCommon.Controls.Add(Me.aStop, 3, 1)
        Me.gridCCommon.Controls.Add(Me.aMark, 0, 2)
        Me.gridCCommon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCCommon.Location = New System.Drawing.Point(3, 103)
        Me.gridCCommon.Name = "gridCCommon"
        Me.gridCCommon.RowCount = 3
        Me.gridCCommon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCCommon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCCommon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.gridCCommon.Size = New System.Drawing.Size(294, 94)
        Me.gridCCommon.TabIndex = 0
        '
        'aXchg
        '
        Me.aXchg.AutoSize = True
        Me.aXchg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aXchg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aXchg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aXchg.FlatAppearance.BorderSize = 0
        Me.aXchg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aXchg.Location = New System.Drawing.Point(74, 63)
        Me.aXchg.Margin = New System.Windows.Forms.Padding(1)
        Me.aXchg.Name = "aXchg"
        Me.aXchg.Size = New System.Drawing.Size(71, 30)
        Me.aXchg.TabIndex = 4
        Me.aXchg.Text = "XCHG"
        Me.ToolTipManager.SetToolTip(Me.aXchg, "Tauscht die Werte zweier Register.")
        Me.aXchg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.gridCCommon.SetColumnSpan(Me.Label4, 4)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Allgemeine Befehle"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aVar
        '
        Me.aVar.AutoSize = True
        Me.aVar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aVar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aVar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aVar.FlatAppearance.BorderSize = 0
        Me.aVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aVar.Location = New System.Drawing.Point(1, 32)
        Me.aVar.Margin = New System.Windows.Forms.Padding(1)
        Me.aVar.Name = "aVar"
        Me.aVar.Size = New System.Drawing.Size(71, 29)
        Me.aVar.TabIndex = 1
        Me.aVar.Text = "VAR"
        Me.ToolTipManager.SetToolTip(Me.aVar, "Definiert eine neue Registervariable mit 16 Bit.")
        Me.aVar.UseVisualStyleBackColor = True
        '
        'aMov
        '
        Me.aMov.AutoSize = True
        Me.aMov.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aMov.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aMov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aMov.FlatAppearance.BorderSize = 0
        Me.aMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aMov.Location = New System.Drawing.Point(74, 32)
        Me.aMov.Margin = New System.Windows.Forms.Padding(1)
        Me.aMov.Name = "aMov"
        Me.aMov.Size = New System.Drawing.Size(71, 29)
        Me.aMov.TabIndex = 3
        Me.aMov.Text = "MOV"
        Me.ToolTipManager.SetToolTip(Me.aMov, "Schiebt einen Wert (eines Registers) auf ein Register.")
        Me.aMov.UseVisualStyleBackColor = True
        '
        'aIo
        '
        Me.aIo.AutoSize = True
        Me.aIo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aIo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aIo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aIo.FlatAppearance.BorderSize = 0
        Me.aIo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aIo.Location = New System.Drawing.Point(147, 32)
        Me.aIo.Margin = New System.Windows.Forms.Padding(1)
        Me.aIo.Name = "aIo"
        Me.aIo.Size = New System.Drawing.Size(71, 29)
        Me.aIo.TabIndex = 5
        Me.aIo.Text = "IO"
        Me.ToolTipManager.SetToolTip(Me.aIo, "Gibt den Wert eines Registers aus.")
        Me.aIo.UseVisualStyleBackColor = True
        '
        'aStop
        '
        Me.aStop.AutoSize = True
        Me.aStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aStop.FlatAppearance.BorderSize = 0
        Me.aStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aStop.Location = New System.Drawing.Point(220, 32)
        Me.aStop.Margin = New System.Windows.Forms.Padding(1)
        Me.aStop.Name = "aStop"
        Me.aStop.Size = New System.Drawing.Size(73, 29)
        Me.aStop.TabIndex = 6
        Me.aStop.Text = "STOP"
        Me.ToolTipManager.SetToolTip(Me.aStop, "Beschreibt ein Prozedurende.")
        Me.aStop.UseVisualStyleBackColor = True
        '
        'aMark
        '
        Me.aMark.AutoSize = True
        Me.aMark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aMark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aMark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aMark.FlatAppearance.BorderSize = 0
        Me.aMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aMark.Location = New System.Drawing.Point(1, 63)
        Me.aMark.Margin = New System.Windows.Forms.Padding(1)
        Me.aMark.Name = "aMark"
        Me.aMark.Size = New System.Drawing.Size(71, 30)
        Me.aMark.TabIndex = 2
        Me.aMark.Text = "@"
        Me.ToolTipManager.SetToolTip(Me.aMark, "Definiert eine neue Marke.")
        Me.aMark.UseVisualStyleBackColor = True
        '
        'gridMain
        '
        Me.gridMain.BackColor = System.Drawing.SystemColors.Control
        Me.gridMain.ColumnCount = 1
        Me.gridMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gridMain.Controls.Add(Me.gridPlugs, 0, 1)
        Me.gridMain.Controls.Add(Me.tlbDebug, 0, 0)
        Me.gridMain.Controls.Add(Me.statsBar, 0, 2)
        Me.gridMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridMain.Location = New System.Drawing.Point(300, 200)
        Me.gridMain.Margin = New System.Windows.Forms.Padding(0)
        Me.gridMain.Name = "gridMain"
        Me.gridMain.RowCount = 3
        Me.gridMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gridMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridMain.Size = New System.Drawing.Size(602, 478)
        Me.gridMain.TabIndex = 0
        '
        'gridPlugs
        '
        Me.gridPlugs.BackColor = System.Drawing.SystemColors.Window
        Me.gridPlugs.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.gridPlugs.ColumnCount = 2
        Me.gridPlugs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gridPlugs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302.0!))
        Me.gridPlugs.Controls.Add(Me.listMarks, 1, 1)
        Me.gridPlugs.Controls.Add(Me.infoException, 1, 2)
        Me.gridPlugs.Controls.Add(Me.plugCode, 0, 0)
        Me.gridPlugs.Controls.Add(Me.listLocals, 1, 0)
        Me.gridPlugs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPlugs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPlugs.Location = New System.Drawing.Point(0, 100)
        Me.gridPlugs.Margin = New System.Windows.Forms.Padding(0)
        Me.gridPlugs.Name = "gridPlugs"
        Me.gridPlugs.RowCount = 3
        Me.gridPlugs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.gridPlugs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.gridPlugs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.gridPlugs.Size = New System.Drawing.Size(602, 278)
        Me.gridPlugs.TabIndex = 0
        '
        'listMarks
        '
        Me.listMarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMarks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.listMarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listMarks.FullRowSelect = True
        Me.listMarks.GridLines = True
        Me.listMarks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listMarks.HideSelection = False
        Me.listMarks.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.listMarks.LabelWrap = False
        Me.listMarks.Location = New System.Drawing.Point(299, 89)
        Me.listMarks.Margin = New System.Windows.Forms.Padding(0)
        Me.listMarks.MultiSelect = False
        Me.listMarks.Name = "listMarks"
        Me.listMarks.Size = New System.Drawing.Size(302, 87)
        Me.listMarks.TabIndex = 2
        Me.listMarks.UseCompatibleStateImageBehavior = False
        Me.listMarks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sprungmarke"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Zeile"
        Me.ColumnHeader2.Width = 200
        '
        'infoException
        '
        Me.infoException.AutoEllipsis = True
        Me.infoException.AutoSize = True
        Me.infoException.BackColor = System.Drawing.SystemColors.Info
        Me.infoException.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoException.Location = New System.Drawing.Point(299, 177)
        Me.infoException.Margin = New System.Windows.Forms.Padding(0)
        Me.infoException.Name = "infoException"
        Me.infoException.Padding = New System.Windows.Forms.Padding(6)
        Me.infoException.Size = New System.Drawing.Size(302, 100)
        Me.infoException.TabIndex = 3
        Me.infoException.Text = "Exception.Message"
        '
        'plugCode
        '
        Me.plugCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.plugCode.BulletIndent = 2
        Me.plugCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plugCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plugCode.Location = New System.Drawing.Point(1, 1)
        Me.plugCode.Margin = New System.Windows.Forms.Padding(0)
        Me.plugCode.Name = "plugCode"
        Me.gridPlugs.SetRowSpan(Me.plugCode, 3)
        Me.plugCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.plugCode.ShowSelectionMargin = True
        Me.plugCode.Size = New System.Drawing.Size(297, 276)
        Me.plugCode.TabIndex = 0
        Me.plugCode.Text = ""
        '
        'listLocals
        '
        Me.listLocals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listLocals.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.localCol1, Me.localCol2})
        Me.listLocals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listLocals.FullRowSelect = True
        Me.listLocals.GridLines = True
        Me.listLocals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listLocals.HideSelection = False
        Me.listLocals.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.listLocals.LabelWrap = False
        Me.listLocals.Location = New System.Drawing.Point(299, 1)
        Me.listLocals.Margin = New System.Windows.Forms.Padding(0)
        Me.listLocals.MultiSelect = False
        Me.listLocals.Name = "listLocals"
        Me.listLocals.Size = New System.Drawing.Size(302, 87)
        Me.listLocals.TabIndex = 1
        Me.listLocals.UseCompatibleStateImageBehavior = False
        Me.listLocals.View = System.Windows.Forms.View.Details
        '
        'localCol1
        '
        Me.localCol1.Text = "Register"
        Me.localCol1.Width = 100
        '
        'localCol2
        '
        Me.localCol2.Text = "Wert"
        Me.localCol2.Width = 200
        '
        'tlbDebug
        '
        Me.tlbDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tlbDebug.AutoSize = True
        Me.tlbDebug.Controls.Add(Me.cmdProject)
        Me.tlbDebug.Controls.Add(Me.debugStart)
        Me.tlbDebug.Controls.Add(Me.debugStop)
        Me.tlbDebug.Controls.Add(Me.debugStep)
        Me.tlbDebug.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbDebug.Location = New System.Drawing.Point(0, 58)
        Me.tlbDebug.Margin = New System.Windows.Forms.Padding(0)
        Me.tlbDebug.Name = "tlbDebug"
        Me.tlbDebug.Padding = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.tlbDebug.Size = New System.Drawing.Size(225, 42)
        Me.tlbDebug.TabIndex = 1
        '
        'cmdProject
        '
        Me.cmdProject.AutoSize = True
        Me.cmdProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdProject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProject.FlatAppearance.BorderSize = 0
        Me.cmdProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProject.Image = Global.ProfiCorp.Zyblis.My.Resources.Resources.Projector_24
        Me.cmdProject.Location = New System.Drawing.Point(9, 6)
        Me.cmdProject.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.cmdProject.Name = "cmdProject"
        Me.cmdProject.Size = New System.Drawing.Size(30, 30)
        Me.cmdProject.TabIndex = 3
        Me.cmdProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipManager.SetToolTip(Me.cmdProject, "Projektionsmodus")
        Me.cmdProject.UseVisualStyleBackColor = True
        '
        'debugStart
        '
        Me.debugStart.AutoSize = True
        Me.debugStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.debugStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.debugStart.FlatAppearance.BorderSize = 0
        Me.debugStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.debugStart.Image = Global.ProfiCorp.Zyblis.My.Resources.Resources.Play_24
        Me.debugStart.Location = New System.Drawing.Point(51, 6)
        Me.debugStart.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.debugStart.Name = "debugStart"
        Me.debugStart.Size = New System.Drawing.Size(81, 30)
        Me.debugStart.TabIndex = 0
        Me.debugStart.Text = "Debug"
        Me.debugStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.debugStart.UseVisualStyleBackColor = True
        '
        'debugStop
        '
        Me.debugStop.AutoSize = True
        Me.debugStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.debugStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.debugStop.Enabled = False
        Me.debugStop.FlatAppearance.BorderSize = 0
        Me.debugStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.debugStop.Image = Global.ProfiCorp.Zyblis.My.Resources.Resources.Stop_24
        Me.debugStop.Location = New System.Drawing.Point(144, 6)
        Me.debugStop.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.debugStop.Name = "debugStop"
        Me.debugStop.Size = New System.Drawing.Size(30, 30)
        Me.debugStop.TabIndex = 1
        Me.debugStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipManager.SetToolTip(Me.debugStop, "Beenden")
        Me.debugStop.UseVisualStyleBackColor = True
        '
        'debugStep
        '
        Me.debugStep.AutoSize = True
        Me.debugStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.debugStep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.debugStep.FlatAppearance.BorderSize = 0
        Me.debugStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.debugStep.Image = Global.ProfiCorp.Zyblis.My.Resources.Resources.Redo_24
        Me.debugStep.Location = New System.Drawing.Point(186, 6)
        Me.debugStep.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.debugStep.Name = "debugStep"
        Me.debugStep.Size = New System.Drawing.Size(30, 30)
        Me.debugStep.TabIndex = 2
        Me.debugStep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipManager.SetToolTip(Me.debugStep, "Einzelschritt")
        Me.debugStep.UseVisualStyleBackColor = True
        '
        'statsBar
        '
        Me.statsBar.AutoSize = True
        Me.statsBar.ColumnCount = 4
        Me.statsBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.statsBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.statsBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.statsBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.statsBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.statsBar.Controls.Add(Me.statsLine, 0, 0)
        Me.statsBar.Controls.Add(Me.statsColumn, 1, 0)
        Me.statsBar.Controls.Add(Me.statsChar, 2, 0)
        Me.statsBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.statsBar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statsBar.Location = New System.Drawing.Point(0, 378)
        Me.statsBar.Margin = New System.Windows.Forms.Padding(0)
        Me.statsBar.Name = "statsBar"
        Me.statsBar.Padding = New System.Windows.Forms.Padding(6)
        Me.statsBar.RowCount = 1
        Me.statsBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.statsBar.Size = New System.Drawing.Size(602, 25)
        Me.statsBar.TabIndex = 2
        '
        'statsLine
        '
        Me.statsLine.AutoSize = True
        Me.statsLine.Location = New System.Drawing.Point(9, 6)
        Me.statsLine.Name = "statsLine"
        Me.statsLine.Size = New System.Drawing.Size(22, 13)
        Me.statsLine.TabIndex = 0
        Me.statsLine.Text = "Z 1"
        '
        'statsColumn
        '
        Me.statsColumn.AutoSize = True
        Me.statsColumn.Location = New System.Drawing.Point(109, 6)
        Me.statsColumn.Name = "statsColumn"
        Me.statsColumn.Size = New System.Drawing.Size(22, 13)
        Me.statsColumn.TabIndex = 1
        Me.statsColumn.Text = "S 1"
        '
        'statsChar
        '
        Me.statsChar.AutoSize = True
        Me.statsChar.Location = New System.Drawing.Point(209, 6)
        Me.statsChar.Name = "statsChar"
        Me.statsChar.Size = New System.Drawing.Size(31, 13)
        Me.statsChar.TabIndex = 2
        Me.statsChar.Text = "Zei 1"
        '
        'tlbMain
        '
        Me.tlbMain.AutoSize = True
        Me.tlbMain.Controls.Add(Me.mainNew)
        Me.tlbMain.Controls.Add(Me.mainOpen)
        Me.tlbMain.Controls.Add(Me.mainSave)
        Me.tlbMain.Controls.Add(Me.mainSaveas)
        Me.tlbMain.Controls.Add(Me.mainInfo)
        Me.tlbMain.Controls.Add(Me.mainHelp)
        Me.tlbMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.tlbMain.Location = New System.Drawing.Point(0, 0)
        Me.tlbMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.Padding = New System.Windows.Forms.Padding(9, 3, 9, 3)
        Me.tlbMain.Size = New System.Drawing.Size(902, 39)
        Me.tlbMain.TabIndex = 0
        Me.tlbMain.WrapContents = False
        '
        'mainNew
        '
        Me.mainNew.AutoSize = True
        Me.mainNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainNew.FlatAppearance.BorderSize = 0
        Me.mainNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mainNew.Location = New System.Drawing.Point(10, 4)
        Me.mainNew.Margin = New System.Windows.Forms.Padding(1)
        Me.mainNew.Name = "mainNew"
        Me.mainNew.Size = New System.Drawing.Size(49, 31)
        Me.mainNew.TabIndex = 5
        Me.mainNew.Text = "Neu"
        Me.mainNew.UseVisualStyleBackColor = True
        '
        'mainOpen
        '
        Me.mainOpen.AutoSize = True
        Me.mainOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainOpen.FlatAppearance.BorderSize = 0
        Me.mainOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainOpen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mainOpen.Location = New System.Drawing.Point(61, 4)
        Me.mainOpen.Margin = New System.Windows.Forms.Padding(1)
        Me.mainOpen.Name = "mainOpen"
        Me.mainOpen.Size = New System.Drawing.Size(68, 31)
        Me.mainOpen.TabIndex = 6
        Me.mainOpen.Text = "Öffnen"
        Me.mainOpen.UseVisualStyleBackColor = True
        '
        'mainSave
        '
        Me.mainSave.AutoSize = True
        Me.mainSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainSave.FlatAppearance.BorderSize = 0
        Me.mainSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mainSave.Location = New System.Drawing.Point(131, 4)
        Me.mainSave.Margin = New System.Windows.Forms.Padding(1)
        Me.mainSave.Name = "mainSave"
        Me.mainSave.Size = New System.Drawing.Size(89, 31)
        Me.mainSave.TabIndex = 7
        Me.mainSave.Text = "Speichern"
        Me.mainSave.UseVisualStyleBackColor = True
        '
        'mainSaveas
        '
        Me.mainSaveas.AutoSize = True
        Me.mainSaveas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainSaveas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainSaveas.FlatAppearance.BorderSize = 0
        Me.mainSaveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainSaveas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mainSaveas.Location = New System.Drawing.Point(222, 4)
        Me.mainSaveas.Margin = New System.Windows.Forms.Padding(1)
        Me.mainSaveas.Name = "mainSaveas"
        Me.mainSaveas.Size = New System.Drawing.Size(139, 31)
        Me.mainSaveas.TabIndex = 10
        Me.mainSaveas.Text = "Speichern unter..."
        Me.mainSaveas.UseVisualStyleBackColor = True
        '
        'mainInfo
        '
        Me.mainInfo.AutoSize = True
        Me.mainInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainInfo.FlatAppearance.BorderSize = 0
        Me.mainInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mainInfo.Location = New System.Drawing.Point(363, 4)
        Me.mainInfo.Margin = New System.Windows.Forms.Padding(1)
        Me.mainInfo.Name = "mainInfo"
        Me.mainInfo.Size = New System.Drawing.Size(119, 31)
        Me.mainInfo.TabIndex = 11
        Me.mainInfo.Text = "Informationen"
        Me.mainInfo.UseVisualStyleBackColor = True
        '
        'mainHelp
        '
        Me.mainHelp.AutoSize = True
        Me.mainHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainHelp.FlatAppearance.BorderSize = 0
        Me.mainHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mainHelp.Location = New System.Drawing.Point(484, 4)
        Me.mainHelp.Margin = New System.Windows.Forms.Padding(1)
        Me.mainHelp.Name = "mainHelp"
        Me.mainHelp.Size = New System.Drawing.Size(27, 31)
        Me.mainHelp.TabIndex = 12
        Me.mainHelp.Text = "?"
        Me.mainHelp.UseVisualStyleBackColor = True
        '
        'bodyBottom
        '
        Me.bodyBottom.AutoSize = True
        Me.bodyBottom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.bodyBottom.ColumnCount = 1
        Me.bodyBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.bodyBottom.Controls.Add(Me.appStat, 0, 0)
        Me.bodyBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bodyBottom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bodyBottom.Location = New System.Drawing.Point(0, 717)
        Me.bodyBottom.MinimumSize = New System.Drawing.Size(0, 23)
        Me.bodyBottom.Name = "bodyBottom"
        Me.bodyBottom.RowCount = 1
        Me.bodyBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.bodyBottom.Size = New System.Drawing.Size(902, 23)
        Me.bodyBottom.TabIndex = 1
        '
        'appStat
        '
        Me.appStat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.appStat.AutoSize = True
        Me.appStat.Location = New System.Drawing.Point(4, 5)
        Me.appStat.Name = "appStat"
        Me.appStat.Size = New System.Drawing.Size(37, 13)
        Me.appStat.TabIndex = 0
        Me.appStat.Text = "Bereit"
        '
        'keyMenu
        '
        Me.keyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.keyFileH})
        Me.keyMenu.Location = New System.Drawing.Point(0, 39)
        Me.keyMenu.Name = "keyMenu"
        Me.keyMenu.Size = New System.Drawing.Size(902, 24)
        Me.keyMenu.TabIndex = 14
        Me.keyMenu.Text = "MenuStrip1"
        Me.keyMenu.Visible = False
        '
        'keyFileH
        '
        Me.keyFileH.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.keyNew, Me.keyOpen, Me.keySave, Me.keySaveAs, Me.keyInfo})
        Me.keyFileH.Name = "keyFileH"
        Me.keyFileH.Size = New System.Drawing.Size(79, 20)
        Me.keyFileH.Text = "FileHandler"
        '
        'keyNew
        '
        Me.keyNew.Name = "keyNew"
        Me.keyNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.keyNew.Size = New System.Drawing.Size(262, 22)
        Me.keyNew.Text = "NewFile()"
        '
        'keyOpen
        '
        Me.keyOpen.Name = "keyOpen"
        Me.keyOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.keyOpen.Size = New System.Drawing.Size(262, 22)
        Me.keyOpen.Text = "OpenFile()"
        '
        'keySave
        '
        Me.keySave.Name = "keySave"
        Me.keySave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.keySave.Size = New System.Drawing.Size(262, 22)
        Me.keySave.Text = "SaveFile()"
        '
        'keySaveAs
        '
        Me.keySaveAs.Name = "keySaveAs"
        Me.keySaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.keySaveAs.Size = New System.Drawing.Size(262, 22)
        Me.keySaveAs.Text = "SaveAsFile()"
        '
        'keyInfo
        '
        Me.keyInfo.Name = "keyInfo"
        Me.keyInfo.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.keyInfo.Size = New System.Drawing.Size(262, 22)
        Me.keyInfo.Text = "ShowInfo()"
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 740)
        Me.Controls.Add(Me.keyMenu)
        Me.Controls.Add(Me.bodyFill)
        Me.Controls.Add(Me.tlbMain)
        Me.Controls.Add(Me.bodyBottom)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(900, 778)
        Me.Name = "Main"
        Me.Text = "Zyblis Education"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bodyFill.ResumeLayout(False)
        Me.gridValues.ResumeLayout(False)
        Me.gridValues.PerformLayout()
        Me.gridComs.ResumeLayout(False)
        Me.gridCJump.ResumeLayout(False)
        Me.gridCJump.PerformLayout()
        Me.gridCArithm.ResumeLayout(False)
        Me.gridCArithm.PerformLayout()
        Me.gridCCommon.ResumeLayout(False)
        Me.gridCCommon.PerformLayout()
        Me.gridMain.ResumeLayout(False)
        Me.gridMain.PerformLayout()
        Me.gridPlugs.ResumeLayout(False)
        Me.gridPlugs.PerformLayout()
        Me.tlbDebug.ResumeLayout(False)
        Me.tlbDebug.PerformLayout()
        Me.statsBar.ResumeLayout(False)
        Me.statsBar.PerformLayout()
        Me.tlbMain.ResumeLayout(False)
        Me.tlbMain.PerformLayout()
        Me.bodyBottom.ResumeLayout(False)
        Me.bodyBottom.PerformLayout()
        Me.keyMenu.ResumeLayout(False)
        Me.keyMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bodyFill As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gridValues As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gridComs As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbMain As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblAX As System.Windows.Forms.Label
    Friend WithEvents lblCX As System.Windows.Forms.Label
    Friend WithEvents ioAX As System.Windows.Forms.TextBox
    Friend WithEvents ioCX As System.Windows.Forms.TextBox
    Friend WithEvents plugCode As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolTipManager As System.Windows.Forms.ToolTip
    Friend WithEvents fOF As System.Windows.Forms.Label
    Friend WithEvents fPF As System.Windows.Forms.Label
    Friend WithEvents fSF As System.Windows.Forms.Label
    Friend WithEvents ioOF As System.Windows.Forms.TextBox
    Friend WithEvents fZF As System.Windows.Forms.Label
    Friend WithEvents ioF1 As System.Windows.Forms.TextBox
    Friend WithEvents ioZF As System.Windows.Forms.TextBox
    Friend WithEvents f1 As System.Windows.Forms.Label
    Friend WithEvents f2 As System.Windows.Forms.Label
    Friend WithEvents ioPF As System.Windows.Forms.TextBox
    Friend WithEvents ioSF As System.Windows.Forms.TextBox
    Friend WithEvents ioF2 As System.Windows.Forms.TextBox
    Friend WithEvents gridCJump As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gridCArithm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gridCCommon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gridMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbDebug As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents gridPlugs As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents listLocals As System.Windows.Forms.ListView
    Friend WithEvents localCol1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents localCol2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents infoException As System.Windows.Forms.Label
    Friend WithEvents listMarks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents aVar As System.Windows.Forms.Button
    Friend WithEvents aMov As System.Windows.Forms.Button
    Friend WithEvents aIo As System.Windows.Forms.Button
    Friend WithEvents aStop As System.Windows.Forms.Button
    Friend WithEvents aMark As System.Windows.Forms.Button
    Friend WithEvents aLoop As System.Windows.Forms.Button
    Friend WithEvents aJg As System.Windows.Forms.Button
    Friend WithEvents aJnl As System.Windows.Forms.Button
    Friend WithEvents aJne As System.Windows.Forms.Button
    Friend WithEvents aJe As System.Windows.Forms.Button
    Friend WithEvents aJl As System.Windows.Forms.Button
    Friend WithEvents aJng As System.Windows.Forms.Button
    Friend WithEvents aJmp As System.Windows.Forms.Button
    Friend WithEvents aAdd As System.Windows.Forms.Button
    Friend WithEvents aSub As System.Windows.Forms.Button
    Friend WithEvents aDiv As System.Windows.Forms.Button
    Friend WithEvents aMul As System.Windows.Forms.Button
    Friend WithEvents aCmp As System.Windows.Forms.Button
    Friend WithEvents aInc As System.Windows.Forms.Button
    Friend WithEvents aDec As System.Windows.Forms.Button
    Friend WithEvents aXchg As System.Windows.Forms.Button
    Friend WithEvents debugStart As System.Windows.Forms.Button
    Friend WithEvents debugStop As System.Windows.Forms.Button
    Friend WithEvents debugStep As System.Windows.Forms.Button
    Friend WithEvents mainNew As System.Windows.Forms.Button
    Friend WithEvents mainOpen As System.Windows.Forms.Button
    Friend WithEvents mainSave As System.Windows.Forms.Button
    Friend WithEvents mainSaveas As System.Windows.Forms.Button
    Friend WithEvents mainInfo As System.Windows.Forms.Button
    Friend WithEvents mainHelp As System.Windows.Forms.Button
    Friend WithEvents statsBar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents statsLine As System.Windows.Forms.Label
    Friend WithEvents statsColumn As System.Windows.Forms.Label
    Friend WithEvents statsChar As System.Windows.Forms.Label
    Friend WithEvents bodyBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents appStat As System.Windows.Forms.Label
    Friend WithEvents keyMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents keyFileH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents keyNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents keyOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents keySave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents keySaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents keyInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdProject As System.Windows.Forms.Button

End Class
