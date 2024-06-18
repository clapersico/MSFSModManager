Public Class MSFSModManager
    Public Const REG_KEY_BASE As String = "SOFTWARE\\PersicoProjects\\MSFSModManager\\"
    Public Const REG_KEY_DIR_MOD As String = REG_KEY_BASE + "dir"

    Private Sub OpzioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpzioniToolStripMenuItem.Click
        Me.Enabled = False
        Opzioni.Show()
    End Sub

    Private Sub MSFSModManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Controllo se è presente all'interno del registro di sistema la cartella delle mod
        Dim cartellaMod = RegistroSistema.leggiValoreChiave(REG_KEY_DIR_MOD, "mod")

        If cartellaMod Is Nothing Then
            cartellaModNonImpostata()
        Else
            Dim addons() As String = IO.Directory.GetDirectories(cartellaMod)

            For i As Integer = 1 To addons.Length
                Dim nomeAddon() = addons(i - 1).Split("\")
                Dim nome = nomeAddon(nomeAddon.Length - 1)

                ModList.Items.Add(nome)
            Next
        End If
    End Sub

    Private Sub cartellaModNonImpostata()
        MsgBox("Cartella mod non impostata")
    End Sub
End Class