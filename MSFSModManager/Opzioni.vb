Public Class Opzioni
    Private REG_SUBKEY_MOD As String = "mod"

    Private Sub Opzioni_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MSFSModManager.Enabled = True
    End Sub

    Private Sub salvaBt_Click(sender As Object, e As EventArgs) Handles salvaBt.Click
        RegistroSistema.scriviValoreChiave(MSFSModManager.REG_KEY_DIR_MOD, REG_SUBKEY_MOD, cartellaModTxt.Text)

        Close()
    End Sub

    Private Sub Opzioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RegistroSistema.verificaEsistenzaChiave(MSFSModManager.REG_KEY_BASE) Then
            cartellaModTxt.Text = RegistroSistema.leggiValoreChiave(MSFSModManager.REG_KEY_DIR_MOD, REG_SUBKEY_MOD)
        End If
    End Sub
End Class