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

        caricamentoAddon(ModList, cartellaMod)
        caricamentoAddon(ActiveModList, cartellaMSFS)

        If ModList.Items.Count = 0 And ActiveModList.Items.Count = 0 Then
            attivaModBt.Enabled = False
            attivaTutteModBt.Enabled = False
            disattivaModBt.Enabled = False
            disattivaTutteModBt.Enabled = False
        End If
    End Sub

    Private Sub attivaModBt_Click(sender As Object, e As EventArgs) Handles attivaModBt.Click
        MsgBox(ModList.SelectedItem)
    End Sub

    Private Sub caricamentoAddon(ByRef control As ListBox, ByVal dir As String)
        If dir Is Nothing Or dir = "" Then
            MsgBox("Cartella " + dir + " non impostata", , "MSFS Mod Manager")
        Else
            Dim addons() As String = IO.Directory.GetDirectories(dir)

            For i As Integer = 1 To addons.Length
                Dim nomeAddon() = addons(i - 1).Split("\")
                Dim nome = nomeAddon(nomeAddon.Length - 1)

                control.Items.Add(nome)
            Next
        End If
    End Sub
End Class