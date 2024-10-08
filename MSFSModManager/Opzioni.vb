Public Class Opzioni
    Private REG_SUBKEY_MOD As String = "mod"
    Private REG_SUBKEY_MSFS As String = "msfs"

    Private Sub Opzioni_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MSFSModManager.Enabled = True
    End Sub

    Private Sub salvaBt_Click(sender As Object, e As EventArgs) Handles salvaBt.Click
        If check() Then
            RegistroSistema.scriviValoreChiave(MSFSModManager.REG_KEY_DIR_MOD, REG_SUBKEY_MOD, cartellaModTxt.Text)
            RegistroSistema.scriviValoreChiave(MSFSModManager.REG_KEY_DIR_MOD, REG_SUBKEY_MSFS, cartellaMSFSTxt.Text)

            Close()
        End If
    End Sub

    Private Sub Opzioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RegistroSistema.verificaEsistenzaChiave(MSFSModManager.REG_KEY_BASE) Then
            cartellaModTxt.Text = RegistroSistema.leggiValoreChiave(MSFSModManager.REG_KEY_DIR_MOD, REG_SUBKEY_MOD)
            cartellaMSFSTxt.Text = RegistroSistema.leggiValoreChiave(MSFSModManager.REG_KEY_DIR_MOD, REG_SUBKEY_MSFS)
        End If
    End Sub

    Private Function check() As Boolean
        cartellaModTxt.BackColor = Color.White
        cartellaMSFSTxt.BackColor = Color.White

        If cartellaModTxt.Text = "" Then
            cartellaModTxt.BackColor = Color.Red : Return False
        End If

        If cartellaMSFSTxt.Text = "" Then
            cartellaMSFSTxt.BackColor = Color.Red : Return False
        End If

        Return True
    End Function
End Class