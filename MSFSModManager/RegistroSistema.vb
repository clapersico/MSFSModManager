Module RegistroSistema
    Public Function verificaEsistenzaChiave(ByVal chiave As String) As Boolean
        If My.Computer.Registry.LocalMachine.GetValue(chiave) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub scriviValoreChiave(ByVal regkey As String, ByVal chiave As String, ByVal valore As String)
        Dim reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(regkey, True)

        If reg Is Nothing Then
            reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regkey)
        End If

        reg.SetValue(chiave, valore)
        reg.Close()
    End Sub

    Public Function leggiValoreChiave(ByVal regkey As String, ByVal chiave As String)
        Dim reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(regkey, True)

        If reg Is Nothing Then
            Return ""
        End If

        Return reg.GetValue(chiave)
    End Function
End Module
