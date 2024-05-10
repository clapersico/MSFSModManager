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
        MenuStrip1 = New MenuStrip()
        OpzioniToolStripMenuItem = New ToolStripMenuItem()
        ModList = New ListBox()
        ActiveModList = New ListBox()
        modLb = New Label()
        actModLb = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {OpzioniToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(932, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
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
        ' MSFSModManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 558)
        Controls.Add(actModLb)
        Controls.Add(modLb)
        Controls.Add(ActiveModList)
        Controls.Add(ModList)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MSFSModManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MSFSModManager"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpzioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModList As ListBox
    Friend WithEvents ActiveModList As ListBox
    Friend WithEvents modLb As Label
    Friend WithEvents actModLb As Label
End Class
