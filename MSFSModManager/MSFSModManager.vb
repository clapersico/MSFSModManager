Public Class MSFSModManager
    Public Const REG_KEY_BASE As String = "SOFTWARE\\PersicoProjects\\MSFSModManager\\"
    Public Const REG_KEY_DIR_MOD As String = REG_KEY_BASE + "dir"

    Private Sub OpzioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpzioniToolStripMenuItem.Click
        Me.Enabled = False
        Opzioni.Show()
    End Sub

    Private Sub MSFSModManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cartellaMod = RegistroSistema.leggiValoreChiave(REG_KEY_DIR_MOD, "mod")
        Dim cartellaMSFS = RegistroSistema.leggiValoreChiave(REG_KEY_DIR_MOD, "msfs")

        'Cartella MOD
        If cartellaMod Is Nothing Or cartellaMod = "" Then
            MsgBox("Cartella mod non impostata", , "MSFS Mod Manager")
        Else
            Dim addons() As String = IO.Directory.GetDirectories(cartellaMod)

            For i As Integer = 1 To addons.Length
                Dim nomeAddon() = addons(i - 1).Split("\")
                Dim nome = nomeAddon(nomeAddon.Length - 1)

                ModList.Items.Add(nome)
            Next
        End If

        'Cartella MSFS
        If cartellaMSFS Is Nothing Or cartellaMSFS = "" Then
            MsgBox("Cartella MSFS non impostata", , "MSFS Mod Manager")
        End If
    End Sub
End Class