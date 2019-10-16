Public Module Registers
    ''' <summary>
    ''' Setzt alle Daten auf den Zustand der Initialisieung zurück.
    ''' </summary>
    ''' <param name="locals">Optional: Gibt an, ob die Liste der lokalen Variablen geleert werden soll. Standard: True.</param>
    ''' <param name="marks">Optional: Gibt an, ob die Liste der Sprungmarken geleert werden soll. Standard: True.</param>
    Public Sub Clear(Optional locals As Boolean = True, Optional marks As Boolean = True)
        REGAX = 0
        REGCX = 0
        Registers.Vars.Clear()
        Registers.Marks.Clear()
        If locals Then MyListLocals.Items.Clear()
        If marks Then MyListMarks.Items.Clear()
    End Sub

#Region "Eigenschaften (Register, Flags)"
    Private p_AX As Int16 = 0
    ''' <summary>
    ''' Ruft den Wert des Akkumulatorregisters ab, oder legt diesen Wert fest.
    ''' </summary>
    Property REGAX As Int16
        Set(value As Int16)
            p_AX = value
            If IoAX IsNot Nothing Then IoAX.Text =CStr(Math.Abs(value))

            IsParity = (CountRealBits(value) Mod 2 = 0)
            IsZero = (value = 0)
            IsSign = (value <> Math.Abs(value))
        End Set
        Get
            Return p_AX
        End Get
    End Property
    Private p_IoAx As Windows.Forms.Control = Nothing
    ''' <summary>
    ''' Ruft das Steuerelement ab, dass den Wert des Akkumulatorregisters darstellt, oder legt dieses fest.
    ''' </summary>
    Property IoAX As Windows.Forms.Control

    Private p_CX As Int16 = 0
    ''' <summary>
    ''' Ruft den Wert des Zählregisters ab, oder legt diesen Wert fest.
    ''' </summary>
    Property REGCX As Int16
        Set(value As Int16)
            p_CX = value
            If IoCX IsNot Nothing Then IoCX.Text = CStr(Math.Abs(value))
        End Set
        Get
            Return p_CX
        End Get
    End Property
    Private p_IoCx As Windows.Forms.Control = Nothing
    ''' <summary>
    ''' Ruft das Steuerelement ab, dass den Wert des Zählregisters darstellt, oder legt dieses fest.
    ''' </summary>
    Property IoCX As Windows.Forms.Control

    Private p_OF As Boolean = False
    ''' <summary>
    ''' Gibt an, ob der aktuelle Wert im Akkumulator mit einem Überlauf verbunden ist, oder legt diesen Wert fest.
    ''' </summary>
    Property IsOverflow As Boolean
        Set(value As Boolean)
            p_OF = value
            If IoOF IsNot Nothing Then IoOF.Text = CStr(Int(value))
        End Set
        Get
            Return p_OF
        End Get
    End Property
    Private p_IoOf As Windows.Forms.Control = Nothing
    ''' <summary>
    ''' Ruft das Steuerelement ab, dass den Wert des Akkumulatorregisters darstellt, oder legt dieses fest.
    ''' </summary>
    Property IoOF As Windows.Forms.Control

    Private p_PF As Boolean = False
    ''' <summary>
    ''' Gibt an, ob der aktuelle Wert im Akkumulator eine Parität bildet, oder legt diesen Wert fest.
    ''' </summary>
    Property IsParity As Boolean
        Set(value As Boolean)
            p_PF = value
            If IoPF IsNot Nothing Then IoPF.Text = CStr(Int(value))
        End Set
        Get
            Return p_PF
        End Get
    End Property
    Private p_IoPf As Windows.Forms.Control = Nothing
    ''' <summary>
    ''' Ruft das Steuerelement ab, dass den Wert des Akkumulatorregisters darstellt, oder legt dieses fest.
    ''' </summary>
    Property IoPF As Windows.Forms.Control

    Private p_ZF As Boolean = False
    ''' <summary>
    ''' Gibt an, ob der aktuelle Wert im Akkumulator gleich Null ist, oder legt diesen Wert fest.
    ''' </summary>
    Property IsZero As Boolean
        Set(value As Boolean)
            p_ZF = value
            If IoZF IsNot Nothing Then IoZF.Text = CStr(Int(value))
        End Set
        Get
            Return p_ZF
        End Get
    End Property
    Private p_IoZf As Windows.Forms.Control = Nothing
    ''' <summary>
    ''' Ruft das Steuerelement ab, dass den Wert des Akkumulatorregisters darstellt, oder legt dieses fest.
    ''' </summary>
    Property IoZF As Windows.Forms.Control

    Private p_SF As Boolean = False
    ''' <summary>
    ''' Gibt an, ob der aktuelle Wert im Akkumulator negativ ist, oder legt diesen Wert fest.
    ''' </summary>
    Property IsSign As Boolean
        Set(value As Boolean)
            p_SF = value
            If IoSF IsNot Nothing Then ioSF.Text = CStr(Int(value))
        End Set
        Get
            Return p_SF
        End Get
    End Property
    Private p_IoSf As Windows.Forms.Control = Nothing
    ''' <summary>
    ''' Ruft das Steuerelement ab, dass den Wert des Akkumulatorregisters darstellt, oder legt dieses fest.
    ''' </summary>
    Property IoSF As Windows.Forms.Control
#End Region

#Region "Eigenschaften (User-defined)"
    Property MyListLocals As Windows.Forms.ListView
    ''' <summary>
    ''' Ruft die Bibliothek der benutzerdefinierten Register mit ihren Werten ab, oder legt diese fest.
    ''' </summary>
    Property Vars As New Dictionary(Of String, Int16)

    Property MyListMarks As Windows.Forms.ListView
    ''' <summary>
    ''' Ruft die Bibliothek der eingetragenen Sprungmarken mit der zugehörigen Zeilennummer ab, oder legt diese fest.
    ''' </summary>
    Property Marks As New Dictionary(Of String, Integer)
#End Region
End Module