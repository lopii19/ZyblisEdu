Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyListLocals = Me.listLocals
        MyListMarks = Me.listMarks

        Me.Debugger = New Debugger(Me.plugCode)
        FileHandler.Coder = Me.plugCode

        Registers.IoAX = Me.ioAX
        Registers.IoCX = Me.ioCX
        Registers.IoOF = Me.ioOF
        Registers.IoPF = Me.ioPF
        Registers.IoZF = Me.ioZF
        Registers.IoSF = Me.ioSF
        Registers.Clear()

        Me.Text = Windows.Forms.Application.ProductName
        Me.infoException.Visible = False
    End Sub

    Private Sub plugCode_SelectionStartChanged(sender As Object, e As EventArgs) Handles plugCode.SelectionChanged
        FileHandler.MyFile.IsChanged = True
        Me.statsLine.Text = SForm("Z {0}", Me.plugCode.GetLineFromCharIndex(Me.plugCode.SelectionStart) + 1)
        Me.statsChar.Text = SForm("Zei {0}", Me.plugCode.SelectionStart + 1)
        Me.statsColumn.Text = SForm("S {0}", Me.plugCode.SelectionStart - Me.plugCode.GetFirstCharIndexOfCurrentLine + 1)
    End Sub

    Private Sub plugCode_TextChanged(sender As Object, e As EventArgs) Handles plugCode.TextChanged
        Registers.Clear(False)
        Me.appStat.Text = "Bereit"
    End Sub

    Private Sub listMarks_DoubleClick(sender As Object, e As EventArgs) Handles listMarks.DoubleClick
        Dim newLine As Integer = CInt(Me.listMarks.SelectedItems(0).SubItems(1).Text)
        Me.plugCode.Focus()
        Me.plugCode.SelectionStart = Me.plugCode.GetFirstCharIndexFromLine(newLine - 1)
        Me.plugCode.SelectionLength = Me.plugCode.Lines(newLine - 1).Length
    End Sub

#Region "#coding"
    ''' <summary>
    ''' Fügt eine Syntax an aktueller Position ein.
    ''' </summary>
    ''' <param name="com">Die Zeichenkette, die die Syntax darstellt.</param>
    ''' <param name="break">Gibt an, ob nach der Eingabe der Zeichenkette weitere automatische Eingaben verhindert werden.</param>
    Public Sub InsertCommand(com As String, Optional break As Boolean = False)
        Dim CIndex As Integer = plugCode.SelectionStart
        Dim Inserted As String = String.Empty
        Try
            If plugCode.Lines(plugCode.GetLineFromCharIndex(CIndex)) <> String.Empty Then Inserted += vbCr
        Catch ex As Exception
        Finally
            Inserted += com.ToLower
            If Not break Then Inserted += " "
        End Try

        plugCode.Focus()
        plugCode.Text = plugCode.Text.Insert(CIndex, Inserted)
        plugCode.SelectionStart = CIndex + Inserted.Length
    End Sub

    Private Sub cVar_Click(sender As Object, e As EventArgs) Handles aVar.Click
        InsertCommand("var")
    End Sub
    Private Sub cMark_Click(sender As Object, e As EventArgs) Handles aMark.Click
        InsertCommand("@")
    End Sub
    Private Sub cMov_Click(sender As Object, e As EventArgs) Handles aMov.Click
        InsertCommand("mov")
    End Sub
    Private Sub cXchg_Click(sender As Object, e As EventArgs) Handles aXchg.Click
        InsertCommand("xchg")
    End Sub
    Private Sub cIO_Click(sender As Object, e As EventArgs) Handles aIo.Click
        InsertCommand("io")
    End Sub
    Private Sub cStop_Click(sender As Object, e As EventArgs) Handles aStop.Click
        InsertCommand("stop", True)
    End Sub
    Private Sub cAdd_Click(sender As Object, e As EventArgs) Handles aAdd.Click
        InsertCommand("add")
    End Sub
    Private Sub cSub_Click(sender As Object, e As EventArgs) Handles aSub.Click
        InsertCommand("sub")
    End Sub
    Private Sub aMul_Click(sender As Object, e As EventArgs) Handles aMul.Click
        InsertCommand("mul")
    End Sub
    Private Sub aDiv_Click(sender As Object, e As EventArgs) Handles aDiv.Click
        InsertCommand("div")
    End Sub
    Private Sub aInc_Click(sender As Object, e As EventArgs) Handles aInc.Click
        InsertCommand("inc")
    End Sub
    Private Sub aDec_Click(sender As Object, e As EventArgs) Handles aDec.Click
        InsertCommand("dec")
    End Sub
    Private Sub aCmp_Click(sender As Object, e As EventArgs) Handles aCmp.Click
        InsertCommand("cmp")
    End Sub
    Private Sub cJmp_Click(sender As Object, e As EventArgs) Handles aJmp.Click
        InsertCommand("jmp @", True)
    End Sub
    Private Sub cLoop_Click(sender As Object, e As EventArgs) Handles aLoop.Click
        InsertCommand("loop @", True)
    End Sub
    Private Sub cJg_Click(sender As Object, e As EventArgs) Handles aJg.Click
        InsertCommand("jg @", True)
    End Sub
    Private Sub cJng_Click(sender As Object, e As EventArgs) Handles aJng.Click
        InsertCommand("jng @", True)
    End Sub
    Private Sub cJe_Click(sender As Object, e As EventArgs) Handles aJe.Click
        InsertCommand("je @", True)
    End Sub
    Private Sub cJne_Click(sender As Object, e As EventArgs) Handles aJne.Click
        InsertCommand("jne @", True)
    End Sub
    Private Sub cJl_Click(sender As Object, e As EventArgs) Handles aJl.Click
        InsertCommand("jl @", True)
    End Sub
    Private Sub cJnl_Click(sender As Object, e As EventArgs) Handles aJnl.Click
        InsertCommand("jnl @", True)
    End Sub
#End Region

#Region "#debug"
    ''' <summary>
    ''' Ruft den Debugger dieser Verwaltung ab, oder legt diesen fest.
    ''' </summary>
    Private Property Debugger As Debugger

    Sub StartDebugging(Optional doSteps As Boolean = False)
        Me.infoException.Visible = False
        Me.gridComs.Enabled = False

        Try
            Me.appStat.Text = "Debugging..."
            Debugger.Debug(Me.plugCode.Lines, doSteps)
            Me.appStat.Text = "Debug erfolgreich"
        Catch ex As Exception
            'Dim info As New ExceptionInformer(ex)
            'info.ShowDialog()

            infoException.Text = ex.Message
            infoException.Visible = True

            Me.appStat.Text = "Debug fehlgeschlagen"
            Me.plugCode.SelectionStart = Me.plugCode.GetFirstCharIndexFromLine(Debugger.CurrentLine - 1)
            Me.plugCode.SelectionLength = Me.plugCode.Lines(Debugger.CurrentLine - 1).Length
        End Try

        Me.gridComs.Enabled = True
        Me.debugStart.Enabled = True
        Me.debugStep.Enabled = True
        Me.debugStop.Enabled = False
        Me.plugCode.Focus()
    End Sub

    Private Sub debugStart_Click(sender As Object, e As EventArgs) Handles debugStart.Click
        Me.debugStart.Enabled = False
        Me.debugStep.Enabled = False
        Me.debugStop.Enabled = True
        StartDebugging()
    End Sub

    Private Sub debugStop_Click(sender As Object, e As EventArgs) Handles debugStop.Click
        Me.debugStop.Enabled = False
        Me.Debugger.IsToAbort = True
    End Sub

    Private Sub debugStep_Click(sender As Object, e As EventArgs) Handles debugStep.Click
        If Me.Debugger.DoSteps Then
            Me.Debugger.DoNextStep = True
        Else
            Me.debugStart.Enabled = True
            Me.debugStep.Enabled = True
            Me.debugStop.Enabled = True
            StartDebugging(True)
        End If
    End Sub

    Private Property IsProjecting As Boolean = False

    Private Sub cmdProject_Click(sender As Object, e As EventArgs) Handles cmdProject.Click
        IsProjecting = Not IsProjecting
        For Each control As System.Windows.Forms.Control In gridPlugs.Controls
            control.Font = New System.Drawing.Font(control.Font.FontFamily, CSng(IIf(IsProjecting, 16, 8)))
        Next
        plugCode.Font = New System.Drawing.Font(plugCode.Font.FontFamily, CSng(IIf(IsProjecting, 24, 12)))
    End Sub
#End Region

#Region "#menu"
    Private Sub Main_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Debugger.IsToAbort = True
        If FileHandler.CloseFile = MsgBoxResult.Cancel Then e.Cancel = True
    End Sub

    Private Sub mainNew_Click(sender As Object, e As EventArgs) Handles mainNew.Click
        FileHandler.NewFile()
        infoException.Visible = False
        plugCode.Clear()
        Registers.Clear()
        Me.plugCode.Focus()
    End Sub
    Private Sub keyNew_Click(sender As Object, e As EventArgs) Handles keyNew.Click
        mainNew.PerformClick()
    End Sub

    Private Sub mainOpen_Click(sender As Object, e As EventArgs) Handles mainOpen.Click
        appStat.Text = "Öffnet..."
        FileHandler.OpenFile()
        appStat.Text = "Geöffnetes Element"
        Me.plugCode.Focus()
    End Sub
    Private Sub keyOpen_Click(sender As Object, e As EventArgs) Handles keyOpen.Click
        mainOpen.PerformClick()
    End Sub

    Private Sub mainSave_Click(sender As Object, e As EventArgs) Handles mainSave.Click
        appStat.Text = "Speichert..."
        FileHandler.SaveFile()
        appStat.Text = "Gespeichertes Element"
        Me.plugCode.Focus()
    End Sub
    Private Sub keySave_Click(sender As Object, e As EventArgs) Handles keySave.Click
        mainSave.PerformClick()
    End Sub

    Private Sub mainSaveas_Click(sender As Object, e As EventArgs) Handles mainSaveas.Click
        appStat.Text = "Speichert..."
        FileHandler.SaveAsFile()
        Me.plugCode.Focus()
        appStat.Text = "Gespeichertes Element"
    End Sub
    Private Sub keySaveAs_Click(sender As Object, e As EventArgs) Handles keySaveAs.Click
        mainSaveas.PerformClick()
    End Sub

    Private Sub mainInfo_Click(sender As Object, e As EventArgs) Handles mainInfo.Click
        DocProperties.ShowDialog()
        Me.plugCode.Focus()
    End Sub
    Private Sub keyInfo_Click(sender As Object, e As EventArgs) Handles keyInfo.Click
        mainInfo.PerformClick()
    End Sub

    Private Sub mainHelp_Click(sender As Object, e As EventArgs) Handles mainHelp.Click
        About.ShowDialog()
    End Sub
#End Region

End Class