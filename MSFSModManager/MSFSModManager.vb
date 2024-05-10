Public Class MSFSModManager
    Public Const REG_KEY_BASE As String = "SOFTWARE\\PersicoProjects\\MSFSModManager\\"
    Public Const REG_KEY_DIR_MOD As String = REG_KEY_BASE + "dir"

    Private Sub OpzioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpzioniToolStripMenuItem.Click
        Me.Enabled = False
        Opzioni.Show()
    End Sub
End Class