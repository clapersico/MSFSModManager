<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSFSModManager
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
        navbar = New MenuStrip()
        OpzioniToolStripMenuItem = New ToolStripMenuItem()
        ModList = New ListBox()
        ActiveModList = New ListBox()
        modLb = New Label()
        actModLb = New Label()
        attivaModBt = New Button()
        attivaTutteModBt = New Button()
        disattivaModBt = New Button()
        disattivaTutteModBt = New Button()
        navbar.SuspendLayout()
        SuspendLayout()
        ' 
        ' navbar
        ' 
        navbar.Items.AddRange(New ToolStripItem() {OpzioniToolStripMenuItem})
        navbar.Location = New Point(0, 0)
        navbar.Name = "navbar"
        navbar.Size = New Size(932, 24)
        navbar.TabIndex = 0
        navbar.Text = "MenuStrip1"
        ' 
        ' OpzioniToolStripMenuItem
        ' 
        OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        OpzioniToolStripMenuItem.Size = New Size(60, 20)
        OpzioniToolStripMenuItem.Text = "Opzioni"
        ' 
        ' ModList
        ' 
        ModList.FormattingEnabled = True
        ModList.ItemHeight = 15
        ModList.Location = New Point(12, 57)
        ModList.Name = "ModList"
        ModList.Size = New Size(415, 484)
        ModList.TabIndex = 1
        ' 
        ' ActiveModList
        ' 
        ActiveModList.FormattingEnabled = True
        ActiveModList.ItemHeight = 15
        ActiveModList.Location = New Point(505, 57)
        ActiveModList.Name = "ActiveModList"
        ActiveModList.Size = New Size(415, 484)
        ActiveModList.TabIndex = 2
        ' 
        ' modLb
        ' 
        modLb.AutoSize = True
        modLb.Location = New Point(12, 39)
        modLb.Name = "modLb"
        modLb.Size = New Size(73, 15)
        modLb.TabIndex = 3
        modLb.Text = "Elenco MOD"
        ' 
        ' actModLb
        ' 
        actModLb.AutoSize = True
        actModLb.Location = New Point(505, 39)
        actModLb.Name = "actModLb"
        actModLb.Size = New Size(107, 15)
        actModLb.TabIndex = 4
        actModLb.Text = "Elenco MOD Attive"
        ' 
        ' attivaModBt
        ' 
        attivaModBt.Location = New Point(433, 242)
        attivaModBt.Name = "attivaModBt"
        attivaModBt.Size = New Size(66, 21)
        attivaModBt.TabIndex = 5
        attivaModBt.Text = ">"
        attivaModBt.UseVisualStyleBackColor = True
        ' 
        ' attivaTutteModBt
        ' 
        attivaTutteModBt.Location = New Point(433, 215)
        attivaTutteModBt.Name = "attivaTutteModBt"
        attivaTutteModBt.Size = New Size(66, 21)
        attivaTutteModBt.TabIndex = 6
        attivaTutteModBt.Text = ">>"
        attivaTutteModBt.UseVisualStyleBackColor = True
        ' 
        ' disattivaModBt
        ' 
        disattivaModBt.Location = New Point(433, 296)
        disattivaModBt.Name = "disattivaModBt"
        disattivaModBt.Size = New Size(66, 21)
        disattivaModBt.TabIndex = 7
        disattivaModBt.Text = "<"
        disattivaModBt.UseVisualStyleBackColor = True
        ' 
        ' disattivaTutteModBt
        ' 
        disattivaTutteModBt.Location = New Point(433, 323)
        disattivaTutteModBt.Name = "disattivaTutteModBt"
        disattivaTutteModBt.Size = New Size(66, 21)
        disattivaTutteModBt.TabIndex = 8
        disattivaTutteModBt.Text = "<<"
        disattivaTutteModBt.UseVisualStyleBackColor = True
        ' 
        ' MSFSModManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 558)
        Controls.Add(disattivaTutteModBt)
        Controls.Add(disattivaModBt)
        Controls.Add(attivaTutteModBt)
        Controls.Add(attivaModBt)
        Controls.Add(actModLb)
        Controls.Add(modLb)
        Controls.Add(ActiveModList)
        Controls.Add(ModList)
        Controls.Add(navbar)
        MainMenuStrip = navbar
        Name = "MSFSModManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MSFSModManager"
        navbar.ResumeLayout(False)
        navbar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents navbar As MenuStrip
    Friend WithEvents OpzioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModList As ListBox
    Friend WithEvents ActiveModList As ListBox
    Friend WithEvents modLb As Label
    Friend WithEvents actModLb As Label
    Friend WithEvents attivaModBt As Button
    Friend WithEvents attivaTutteModBt As Button
    Friend WithEvents disattivaModBt As Button
    Friend WithEvents disattivaTutteModBt As Button
End Class
