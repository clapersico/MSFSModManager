<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opzioni
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        cartellaModTxt = New TextBox()
        salvaBt = New Button()
        Label2 = New Label()
        cartellaMSFSTxt = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 15)
        Label1.TabIndex = 0
        Label1.Text = "Path cartella MOD"
        ' 
        ' cartellaModTxt
        ' 
        cartellaModTxt.Location = New Point(12, 27)
        cartellaModTxt.Name = "cartellaModTxt"
        cartellaModTxt.Size = New Size(535, 23)
        cartellaModTxt.TabIndex = 1
        ' 
        ' salvaBt
        ' 
        salvaBt.Location = New Point(472, 124)
        salvaBt.Name = "salvaBt"
        salvaBt.Size = New Size(75, 23)
        salvaBt.TabIndex = 3
        salvaBt.Text = "Salva"
        salvaBt.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 3
        Label2.Text = "Path cartella MSFS"
        ' 
        ' cartellaMSFSTxt
        ' 
        cartellaMSFSTxt.Location = New Point(12, 82)
        cartellaMSFSTxt.Name = "cartellaMSFSTxt"
        cartellaMSFSTxt.Size = New Size(535, 23)
        cartellaMSFSTxt.TabIndex = 2
        ' 
        ' Opzioni
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        ClientSize = New Size(559, 159)
        Controls.Add(cartellaMSFSTxt)
        Controls.Add(Label2)
        Controls.Add(salvaBt)
        Controls.Add(cartellaModTxt)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Opzioni"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Opzioni"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cartellaModTxt As TextBox
    Friend WithEvents salvaBt As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cartellaMSFSTxt As TextBox
End Class
