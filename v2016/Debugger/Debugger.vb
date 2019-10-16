Public Class Debugger
    Sub New(coder As Windows.Forms.RichTextBox)
        Me.Coder = coder
    End Sub

#Region "Eigenschaften"
    ''' <summary>
    ''' Ruft das RichTextBox-Steuerelement abm in welchem die Daten eingegeben werden, oder legt dieses Steuerelement fest.
    ''' </summary>
    Property Coder As Windows.Forms.RichTextBox

    ''' <summary>
    ''' Ruft die Nummer der aktuell bearbeiteten Zeile ab, oder legt diese fest.
    ''' </summary>
    Property CurrentLine As Integer = 0
    ''' <summary>
    ''' Ruft die Nummer der aktuell bearbeiteten Spalte ab, oder legt diese fest.
    ''' </summary>
    Property CurrentColumn As Integer = 0
    ''' <summary>
    ''' Ruft die Nummer des aktuell bearbeiteten Zeichens ab, oder legt diese fest.
    ''' </summary>
    Property CurrentChar As Integer = 0

    ''' <summary>
    ''' Ruft einen Wert ab, der angibt, ob der Prozess abgebrochen werden soll, oder legt diesen Wert fest.
    ''' </summary>
    Property IsToAbort As Boolean = False
    ''' <summary>
    ''' Ruft einen Wert ab, der angibt, ob das Debugging zurzeit läuft.
    ''' </summary>
    Property IsRunning As Boolean = False
    ''' <summary>
    ''' Ruft einen Wert ab, der angibt, ob das Debuggin in Schritten durchgeführt werden soll.
    ''' </summary>
    Property DoSteps As Boolean = False
    ''' <summary>
    ''' Ruft einen Wert ab, der angibt, ob der nächste Schritt getätigt werden soll.
    ''' </summary>
    Property DoNextStep As Boolean = False
#End Region

    ''' <summary>
    ''' Überprüft eine Masse an Codezeilen auf syntaktische und prozessorale Gültigkeit hinsichtlich eines feststehenden Satzes an Befehlen.
    ''' </summary>
    ''' <param name="linesOfCode">Die zu durchlaufenden Codezeilen.</param>
    Sub Debug(linesOfCode As String(), Optional doSteps As Boolean = False)
        Registers.Clear()
        Me.CurrentLine = 0

        Me.DoSteps = doSteps
        Me.IsRunning = True
        Me.IsToAbort = False

        'Sprungmarken erfassen
        For Each line$ In linesOfCode
            CurrentLine += 1
            line = line.TrimStart(" "c)
            Dim prompt As String() = PromptData(line, " ")
            Try
                If prompt(0) = "@" Then DebugHandle_Mark(prompt)
            Catch exc As Exception
                ResBasedEx("a0_plain", CurrentLine, exc.Message)
            End Try
        Next
        CurrentLine = 0

        'Debug starten
        Do Until CurrentLine = linesOfCode.Length
            CurrentLine += 1
            Dim line$ = linesOfCode(CurrentLine - 1)
            If Me.DoSteps Then
                Me.Coder.SelectionStart = Me.Coder.GetFirstCharIndexFromLine(CurrentLine - 1)
                Me.Coder.SelectionLength = line.Length
                Me.Coder.Focus()
            End If
            line = line.TrimStart(" "c)
            Dim prompt As String() = PromptData(line, " ")

            'Beenden erlauben
            Windows.Forms.Application.DoEvents()
            If IsToAbort Then Exit Do

            'Einzelschritt abfragen
            If Me.DoSteps AndAlso _
                Not (line = String.Empty Or line.StartsWith(";")) Then
                While Not Me.DoNextStep
                    Windows.Forms.Application.DoEvents()
                    If IsToAbort Then Exit Do
                End While
                Me.DoNextStep = False
            End If

            Try
                Select Case prompt(0).ToLower
                    'Allgemein
                    Case "var" : DebugHandle_Var(prompt)
                    Case "@"
                    Case "mov" : DebugHandle_Mov(prompt)
                    Case "xchg" : DebugHandler_Xchg(prompt)
                    Case "io" : DebugHandler_Io(prompt)
                    Case "stop" : Exit Do

                        'Arithmetisch
                    Case "add" : DebugHandler_Add(prompt)
                    Case "sub" : DebugHandler_Sub(prompt)
                    Case "mul" : DebugHandler_Mul(prompt)
                    Case "div" : DebugHandler_Div(prompt)
                    Case "inc" : DebugHandler_Inc(prompt)
                    Case "dec" : DebugHandler_Dec(prompt)
                    Case "cmp" : DebugHandler_Cmp(prompt)

                        'Sprung
                    Case "jmp" : DebugHandler_Jump(prompt)
                    Case "jg" : DebugHandler_JumpGreater(prompt)
                    Case "jng" : DebugHandler_JumpNotGreater(prompt)
                    Case "je" : DebugHandler_JumpEquals(prompt)
                    Case "jne" : DebugHandler_JumpNotEqual(prompt)
                    Case "jl" : DebugHandler_JumpLess(prompt)
                    Case "jnl" : DebugHandler_JumpNotLess(prompt)
                    Case "loop" : DebugHandler_Loop(prompt)

                    Case ";"
                    Case String.Empty
                    Case Else
                        ResBasedEx("com_invalid", prompt(0))
                End Select
            Catch exc As Exception
                ResBasedEx("a0_plain", CurrentLine, exc.Message)
            End Try
        Loop

        Me.IsToAbort = False
        Me.IsRunning = False
        Me.DoSteps = False : Me.DoNextStep = False
    End Sub

    ''' <summary>
    ''' Separiert die Daten einer Codezeile in Syntax und Argumente.
    ''' </summary>
    ''' <param name="lineOfCode">Die zu untersuchende Codezeile.</param>
    Protected Function PromptData(lineOfCode As String, separator As String) As String()
        Dim Data As String() = {"", ""}
        Dim SepIndex As Integer = lineOfCode.IndexOf(separator)
        If SepIndex = -1 Then
            Data(0) = lineOfCode
        Else
            Data(0) = lineOfCode.Substring(0, SepIndex).TrimEnd(" "c)
            Data(1) = lineOfCode.Substring(SepIndex + separator.Length).TrimStart(" "c)
        End If
        PromptData = Data
    End Function

#Region "Handler"
    Protected Sub DebugHandle_Var(prompt As String())
        Dim Data As String = prompt(1)
        If Data = String.Empty Then ResBasedEx("a0_args_none", "key", MsgRes("sig_var"))
        If Not IsValidReg(Data) Then ResBasedEx("a0_args_invalid", "key", MsgRes("sig_var"), MsgRes("a0_args_letter"))
        If IsUsableReg(Data) Then ResBasedEx("var_exists", Data)

        SetRegValue(Data, 0)
    End Sub

    Protected Sub DebugHandle_Mark(prompt As String())
        Dim Data As String = prompt(1)
        If Data = String.Empty Then ResBasedEx("a0_args_none", "key", MsgRes("sig_mark"))
        If Not IsValidMark(Data) Then ResBasedEx("a0_args_invalid", "key", MsgRes("sig_mark"), MsgRes("a0_args_letterDigit"))
        If IsUsableMark(Data) Then ResBasedEx("mark_exists", Data)

        CreateDisplayItem(Data, CurrentLine, Registers.MyListMarks)
        Marks.Add(Data, CurrentLine - 1)
    End Sub

    Protected Sub DebugHandle_Mov(prompt As String())
        Dim Data As String() = PromptData(prompt(1), ",")
        Secure_Reg(Data(0), "dest", MsgRes("sig_mov"))
        Secure_RegNumeric(Data(1), "src", MsgRes("sig_mov"))

        If IsNumeric(Data(1)) Then
            SetRegValue(Data(0), CInt(Data(1)))
        Else
            SetRegValue(Data(0), GetRegValue(Data(1)))
        End If
    End Sub

    Protected Sub DebugHandler_Xchg(prompt As String())
        Dim Data As String() = PromptData(prompt(1), ",")
        Secure_Reg(Data(0), "reg1", MsgRes("sig_xchg"))
        Secure_Reg(Data(1), "reg2", MsgRes("sig_xchg"))

        Dim value As Integer = GetRegValue(Data(0))
        SetRegValue(Data(0), GetRegValue(Data(1)))
        SetRegValue(Data(1), value)
    End Sub

    Protected Sub DebugHandler_Io(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Reg(Data, "src", MsgRes("sig_io"))

        MsgBox(Data & " := " & GetRegValue(Data), Title:=Windows.Forms.Application.ProductName)
    End Sub

    Protected Sub DebugHandler_Add(prompt As String())
        Dim Data As String() = PromptData(prompt(1), ",")
        Secure_Reg(Data(0), "dest", MsgRes("sig_add"))
        Secure_RegNumeric(Data(1), "summand", MsgRes("sig_add"))

        If IsNumeric(Data(1)) Then
            SetRegValue(Data(0), CInt(GetRegValue(Data(0))) + CInt(Data(1)))
        Else
            SetRegValue(Data(0), CInt(GetRegValue(Data(0))) + CInt(GetRegValue(Data(1))))
        End If
    End Sub

    Protected Sub DebugHandler_Sub(prompt As String())
        Dim Data As String() = PromptData(prompt(1), ",")
        Secure_Reg(Data(0), "dest", MsgRes("sig_sub"))
        Secure_RegNumeric(Data(1), "subtrahend", MsgRes("sig_sub"))

        If IsNumeric(Data(1)) Then
            SetRegValue(Data(0), CInt(GetRegValue(Data(0))) - CInt(Data(1)))
        Else
            SetRegValue(Data(0), CInt(GetRegValue(Data(0))) - CInt(GetRegValue(Data(1))))
        End If
    End Sub

    Protected Sub DebugHandler_Mul(prompt As String())
        Dim Data As String() = PromptData(prompt(1), ",")
        Secure_Reg(Data(0), "dest", MsgRes("sig_mul"))
        Secure_RegNumeric(Data(1), "factor", MsgRes("sig_mul"))

        If IsNumeric(Data(1)) Then
            SetRegValue(Data(0), CInt(GetRegValue(Data(0))) * CInt(Data(1)))
        Else
            SetRegValue(Data(0), CInt(GetRegValue(Data(0))) * CInt(GetRegValue(Data(1))))
        End If
    End Sub

    Protected Sub DebugHandler_Div(prompt As String())
        Dim Data As String() = PromptData(prompt(1), ",")
        Secure_Reg(Data(0), "dest", MsgRes("sig_div"))
        Secure_RegNumeric(Data(1), "dividend", MsgRes("sig_div"))

        Dim a As Integer = 0
        If IsNumeric(Data(1)) Then
            SetRegValue(Data(0), Math.DivRem(CInt(GetRegValue(Data(0))), CInt(Data(1)), a))
        Else
            SetRegValue(Data(0), Math.DivRem(CInt(GetRegValue(Data(0))), CInt(GetRegValue(Data(1))), a))
        End If
    End Sub

    Protected Sub DebugHandler_Inc(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Reg(Data, "reg", MsgRes("sig_inc"))
        SetRegValue(Data, CInt(GetRegValue(Data)) + 1)
    End Sub

    Protected Sub DebugHandler_Dec(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Reg(Data, "reg", MsgRes("sig_dec"))
        SetRegValue(Data, CInt(GetRegValue(Data)) - 1)
    End Sub

    Protected Sub DebugHandler_Cmp(prompt As String())
        Dim Data As String() = PromptData(prompt(1), ",")
        Secure_Reg(Data(0), "reg1", MsgRes("sig_cmp"))
        Secure_RegNumeric(Data(1), "reg2", MsgRes("sig_cmp"))

        If IsNumeric(Data(1)) Then
            SetRegValue("ax", CInt(GetRegValue(Data(0))) - CInt(Data(1)))
        Else
            SetRegValue("ax", CInt(GetRegValue(Data(0))) - CInt(GetRegValue(Data(1))))
        End If
    End Sub

    Protected Sub DebugHandler_Jump(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_jmp"))
        CurrentLine = Marks(Data)
    End Sub
    Protected Sub DebugHandler_JumpGreater(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_jg"))
        If REGAX > 0 Then CurrentLine = Marks(Data)
    End Sub
    Protected Sub DebugHandler_JumpNotGreater(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_jng"))
        If REGAX <= 0 Then CurrentLine = Marks(Data)
    End Sub
    Protected Sub DebugHandler_JumpEquals(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_je"))
        If REGAX = 0 Then CurrentLine = Marks(Data)
    End Sub
    Protected Sub DebugHandler_JumpNotEqual(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_jne"))
        If REGAX <> 0 Then CurrentLine = Marks(Data)
    End Sub
    Protected Sub DebugHandler_JumpLess(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_jl"))
        If REGAX < 0 Then CurrentLine = Marks(Data)
    End Sub
    Protected Sub DebugHandler_JumpNotLess(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_jnl"))
        If REGAX >= 0 Then CurrentLine = Marks(Data)
    End Sub

    Protected Sub DebugHandler_Loop(prompt As String())
        Dim Data As String = prompt(1)
        Secure_Mark(Data, "key", MsgRes("sig_loop"))
        REGCX = CShort(REGCX - 1)
        If REGCX > 0 Then CurrentLine = Marks(Data)
    End Sub
#End Region

    ''' <summary>
    ''' Setzt den Wert eines Registers auf den angegebenen. Kann auch auf den Akkumulator und das Zählregister angewendet werden. Ist das gewünschte Register nicht vorhanden, wird es erstellt.
    ''' </summary>
    ''' <param name="key">Der Schlüsselbezeichner des Registers.</param>
    ''' <param name="value">Der anzunehmender Wert.</param>
    Sub SetRegValue(key As String, value As Integer)
        Select Case key
            Case "ax"
                REGAX = CShort(Math.Min(Short.MaxValue, value))
                IsOverflow = (value > Short.MaxValue)
            Case "cx" : REGCX = CShort(Math.Min(Short.MaxValue, value))
            Case Else
                value = CShort(Math.Min(Short.MaxValue, value))

                If IsUsableReg(key) Then
                    Vars.Remove(key)
                    FindDisplayItem(key, Registers.MyListLocals).SubItems(1).Text = CStr(value)
                Else : CreateDisplayItem(key, CShort(value), Registers.MyListLocals)
                End If
                Vars.Add(key, CShort(value))
        End Select
    End Sub

    ''' <summary>
    ''' Gibt den Wert eines definierten oder vorhandenen Registers aus.
    ''' </summary>
    ''' <param name="key">Der Schlüsselbezeichner des Registers.</param>
    Function GetRegValue(key As String) As Short
        Select Case key
            Case "ax" : GetRegValue = REGAX
            Case "cx" : GetRegValue = REGCX
            Case Else : GetRegValue = Vars(key)
        End Select
    End Function

    ''' <summary>
    ''' Erstellt einen neuen Eintrag mit Schlüssel und Wert in angegeben ListView-Steuerelement.
    ''' </summary>
    ''' <param name="key">Der Bezeichner des Registers.</param>
    ''' <param name="value">Der Wert des Registers.</param>
    Private Sub CreateDisplayItem(key As String, value As Integer, ByRef listView As Windows.Forms.ListView)
        Dim ListViewItem As New Windows.Forms.ListViewItem With {.Text = CStr(key)}
        ListViewItem.SubItems.Add(New Windows.Forms.ListViewItem.ListViewSubItem With {.Text = CStr(value)})
        listView.Items.Add(ListViewItem)
    End Sub

    ''' <summary>
    ''' Gibt keinen oder den Eintrag in einem ListView-Steuerelemts zurück, dessen Schlüssel mit dem Bezeichner übereinstimmt.
    ''' </summary>
    ''' <param name="key">Der Schlüsselbezeichner.</param>
    Private Function FindDisplayItem(key As String, ByRef listView As Windows.Forms.ListView) As Windows.Forms.ListViewItem
        For Each item As Windows.Forms.ListViewItem In listView.Items
            If item.Text = key Then Return item
        Next
        Return Nothing
    End Function
End Class