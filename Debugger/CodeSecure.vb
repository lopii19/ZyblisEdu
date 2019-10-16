Public Module CodeSecure
    ''' <summary>
    ''' Gibt an, ob eine Registerbezeichnung ein gültiges Format aufweist.
    ''' </summary>
    ''' <param name="key">Die propädeutische Bezeichnung.</param>
    Function IsValidReg(key As String) As Boolean
        IsValidReg = False
        For Each c As Char In key.ToCharArray
            IsValidReg = Char.IsLetter(c)
            If Not IsValidReg Then Exit For
        Next
    End Function

    ''' <summary>
    ''' Gibt an, ob ein Register tatsächlich zur Verfügung steht.
    ''' </summary>
    ''' <param name="key">Die Bezeichnung des Registers.</param>
    Function IsUsableReg(key As String) As Boolean
        If key.ToLower = "ax" Or key.ToLower = "cx" Then Return True
        For Each entry As KeyValuePair(Of String, Short) In Vars
            If entry.Key.ToLower = key.ToLower Then Return True
        Next
        Return False
    End Function

    ''' <summary>
    ''' Prüft, ob die Daten als Bezeichnung eines Registers verwertet werden können.
    ''' </summary>
    ''' <param name="data">Die propädeutische Bezeichnung des Registers.</param>
    ''' <param name="param">Der Name des Parameters.</param>
    ''' <param name="signature">Die Signatur, die den Parameter behandelt.</param>
    Sub Secure_Reg(data As String, param As String, signature As String)
        If data = String.Empty Then ResBasedEx("a0_args_none", param, signature)
        If Not IsValidReg(data) Then ResBasedEx("a0_args_invalid", param, signature, MsgRes("a0_args_letter"))
        If Not IsUsableReg(data) Then ResBasedEx("a0_reg_unav", data)
    End Sub

    ''' <summary>
    ''' Prüft, ob die Daten als Bezeichnung eines Registers oder Zahl verwertet werden können.
    ''' </summary>
    ''' <param name="data">Die propädeutische Bezeichnung des Registers.</param>
    ''' <param name="param">Der Name des Parameters.</param>
    ''' <param name="signature">Die Signatur, die den Parameter behandelt.</param>
    Sub Secure_RegNumeric(data As String, param As String, signature As String)
        If data = String.Empty Then ResBasedEx("a0_args_none", param, signature)
        If Not IsNumeric(data) AndAlso Not IsValidReg(data) Then ResBasedEx("a0_args_invalid", param, signature, MsgRes("a0_args_letterDigit"))
        If Not IsNumeric(data) AndAlso Not IsUsableReg(data) Then ResBasedEx("a0_reg_unavNo", data)
    End Sub

    ''' <summary>
    ''' Gibt an, ob die Bezeichnung einer Marke ein gültiges Format aufweisen.
    ''' </summary>
    ''' <param name="name">Der propädeutische Bezeichner der Marke.</param>
    Function IsValidMark(name As String) As Boolean
        For Each c As Char In name.ToCharArray
            If Not Char.IsLetterOrDigit(c) Then Return False
        Next
        Return True
    End Function

    ''' <summary>
    ''' Gibt an, ob eine Marke tatsächlich zur Verfügung steht.
    ''' </summary>
    ''' <param name="name">Die Bezeichnung der Marke.</param>

    Function IsUsableMark(name As String) As Boolean
        For Each entry As KeyValuePair(Of String, Integer) In Marks
            If entry.Key.ToLower = name.ToLower Then Return True
        Next
        Return False
    End Function

    ''' <summary>
    ''' Prüft, ob die Daten als Bezeichnung einer Sprungmarke verwertet werden können.
    ''' </summary>
    ''' <param name="data">Die propädeutische Bezeichnung der Sprungmarke.</param>
    ''' <param name="param">Der Name des Parameters.</param>
    ''' <param name="signature">Die Signatur, die den Parameter behandelt.</param>
    Sub Secure_Mark(ByRef data As String, param As String, signature As String)
        If data = String.Empty Then ResBasedEx("a0_args_none", param, signature)
        If Not data.StartsWith("@") Then ResBasedEx("a0_args_invalid", param, signature, MsgRes("jmp_nomark"))
        data = data.Substring(1)
        If Not IsValidMark(data) Then ResBasedEx("a0_args_invalid", param, signature, MsgRes("a0_args_letterDigit"))
        If Not IsUsableMark(data) Then ResBasedEx("a0_mark_unav", data)
    End Sub
End Module