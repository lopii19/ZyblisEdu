Imports System.Xml

Public Module FileHandler
    Private t_folder As String = Path.Combine(Path.GetTempPath, "Zyblis.temp")
    ''' <summary>
    ''' Ruft den Ordnerpfad ab, der für temporäre Zeit von der Applikation für Arbeiten mit dem Dateisystem nutzen kann.
    ''' </summary>
    ReadOnly Property MyTempFolder As String
        Get
            If Not IO.Directory.Exists(t_folder) Then IO.Directory.CreateDirectory(t_folder)
            Return t_folder
        End Get
    End Property

    Property MyFile As New MyFile
    Property Coder As RichTextBox

    Sub NewFile()
        If CloseFile() = MsgBoxResult.Cancel Then Exit Sub
        MyFile.Reset()
    End Sub

    Sub OpenFile()
        If CloseFile() = MsgBoxResult.Cancel Then Exit Sub

        'Datei Informationen erstellen
        Dim FileInfo As IO.FileInfo
        Using OFD As New OpenFileDialog With {.AddExtension = True, .CheckFileExists = True, .DefaultExt = "zyd", .Filter = "Zyblis Dokument|*.zyd", .Multiselect = False, .ValidateNames = True}
            Select Case OFD.ShowDialog
                Case DialogResult.OK
                    MyFile.Reset()
                    FileInfo = New IO.FileInfo(OFD.FileName)
                Case Else
                    Exit Sub
            End Select
        End Using
        Dim TempOpenPath As String = Path.Combine(MyTempFolder, FileInfo.Name)
        If IO.Directory.Exists(TempOpenPath) Then IO.Directory.Delete(TempOpenPath, True)
        If Not IO.Directory.Exists(TempOpenPath) Then IO.Directory.CreateDirectory(TempOpenPath)
        ZipFile.ExtractToDirectory(FileInfo.FullName, TempOpenPath)

        'Daten auslesen
        Dim XmlReader As New XmlTextReader(Path.Combine(TempOpenPath, "Core.xml"))
        With XmlReader
            Do While .Read
                Select Case .Name
                    Case "title" : MyFile.Title = .ReadString
                    Case "subject" : MyFile.Subject = .ReadString
                    Case "creator" : MyFile.Author = .ReadString
                    Case "description" : MyFile.Description = .ReadString
                    Case "lastModifiedBy" : MyFile.LastModifiedBy = .ReadString
                    Case "category" : MyFile.Categories = .ReadString
                End Select
            Loop
        End With
        XmlReader.Close()
        XmlReader = New XmlTextReader(Path.Combine(TempOpenPath, "Content.xml"))
        With XmlReader
            Do While .Read
                Select Case .Name
                    Case "coding" : Coder.Text = .ReadString
                    Case "charindex" : Coder.SelectionStart = CInt(.ReadString)
                End Select
            Loop
        End With
        XmlReader.Close()
        MyFile.FullPath = FileInfo.FullName

        IO.Directory.Delete(TempOpenPath, True)
        MyFile.IsChanged = False
    End Sub

    Sub SaveFile()
        MyFile.LastModifiedBy = Environment.UserName

        'Datei Informationen erstellen
        Dim FileInfo As IO.FileInfo
        If MyFile.FullPath = String.Empty Then
            Using SFD As New SaveFileDialog With {.AddExtension = True, .CheckPathExists = True, .DefaultExt = "zyd", .Filter = "Zyblis Dokument|*.zyd", .OverwritePrompt = True, .ValidateNames = True}
                Select Case SFD.ShowDialog
                    Case DialogResult.OK
                        FileInfo = New IO.FileInfo(SFD.FileName)
                    Case Else
                        Exit Sub
                End Select
            End Using
        Else
            FileInfo = New FileInfo(MyFile.FullPath)
        End If
        Dim TempSavePath As String = Path.Combine(MyTempFolder, FileInfo.Name)
        If Not IO.Directory.Exists(TempSavePath) Then IO.Directory.CreateDirectory(TempSavePath)

        'Daten schreiben
        Dim XmlWriter As New XmlTextWriter(Path.Combine(TempSavePath, "Core.xml"), System.Text.Encoding.UTF8)
        With XmlWriter
            .WriteStartDocument()
            .WriteStartElement("coreproperties")
            .WriteElementString("title", MyFile.Title)
            .WriteElementString("subject", MyFile.Subject)
            .WriteElementString("creator", MyFile.Author)
            .WriteElementString("description", MyFile.Description)
            .WriteElementString("lastModifiedBy", MyFile.LastModifiedBy)
            .WriteElementString("category", MyFile.Categories)
            .WriteEndDocument()
        End With
        XmlWriter.Close()
        XmlWriter = New XmlTextWriter(Path.Combine(TempSavePath, "Content.xml"), System.Text.Encoding.UTF8)
        With XmlWriter
            .WriteStartDocument()
            .WriteStartElement("corecontent")
            .WriteElementString("coding", Coder.Text)
            .WriteElementString("charindex", CStr(Coder.SelectionStart))
            .WriteEndDocument()
        End With
        XmlWriter.Close()

        'Datei fertigstellen
        If IO.File.Exists(FileInfo.FullName) Then IO.File.Delete(FileInfo.FullName)
        ZipFile.CreateFromDirectory(TempSavePath, FileInfo.FullName)

        IO.Directory.Delete(TempSavePath, True)
        MyFile.IsChanged = False
    End Sub

    Sub SaveAsFile()
        Using SFD As New SaveFileDialog With {.AddExtension = True, .CheckPathExists = True, .DefaultExt = "zyd", .Filter = "Zyblis Dokument|*.zyd", .OverwritePrompt = True, .ValidateNames = True}
            Select Case SFD.ShowDialog
                Case DialogResult.OK
                    MyFile.FullPath = SFD.FileName
                Case Else
                    Exit Sub
            End Select
        End Using
        SaveFile()
    End Sub

    Function CloseFile() As MsgBoxResult
        If MyFile.IsChanged Then
            Select Case MsgBox(String.Format(My.Resources.save, Application.ProductName, MyFile.Title), MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question, Application.ProductName)
                Case MsgBoxResult.Yes
                    SaveFile()
                Case MsgBoxResult.Cancel
                    Return MsgBoxResult.Cancel
            End Select
        End If
        Return MsgBoxResult.Ok
    End Function
End Module

Public Class MyFile
    Property Title As String = "Unbenannt"
    Property Subject As String = String.Empty
    Property Author As String = Environment.UserName
    Property Description As String = String.Empty
    Property LastModifiedBy As String = String.Empty
    Property Categories As String = String.Empty
    Property IsChanged As Boolean = False
    Property FullPath As String = String.Empty

    Sub Reset()
        Title = "Unbenannt"
        Subject = String.Empty
        Author = Environment.UserName
        Description = String.Empty
        LastModifiedBy = String.Empty
        Categories = String.Empty
        IsChanged = False
        FullPath = String.Empty
    End Sub
End Class