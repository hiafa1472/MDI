<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiodataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KalkulatorUsiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleKalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiencetificKalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaktuStripAwal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.WaktuTools = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAplikasiToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuAplikasiToolStripMenuItem
        '
        Me.MenuAplikasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BiodataToolStripMenuItem, Me.KalkulatorUsiaToolStripMenuItem, Me.KalkulatorToolStripMenuItem})
        Me.MenuAplikasiToolStripMenuItem.Name = "MenuAplikasiToolStripMenuItem"
        Me.MenuAplikasiToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.MenuAplikasiToolStripMenuItem.Text = "Menu Aplikasi"
        '
        'BiodataToolStripMenuItem
        '
        Me.BiodataToolStripMenuItem.Image = CType(resources.GetObject("BiodataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BiodataToolStripMenuItem.Name = "BiodataToolStripMenuItem"
        Me.BiodataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BiodataToolStripMenuItem.Text = "Biodata"
        '
        'KalkulatorUsiaToolStripMenuItem
        '
        Me.KalkulatorUsiaToolStripMenuItem.Name = "KalkulatorUsiaToolStripMenuItem"
        Me.KalkulatorUsiaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KalkulatorUsiaToolStripMenuItem.Text = "Kalkulator Usia"
        '
        'KalkulatorToolStripMenuItem
        '
        Me.KalkulatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpleKalkulatorToolStripMenuItem, Me.SiencetificKalkulatorToolStripMenuItem})
        Me.KalkulatorToolStripMenuItem.Name = "KalkulatorToolStripMenuItem"
        Me.KalkulatorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KalkulatorToolStripMenuItem.Text = "Kalkulator"
        '
        'SimpleKalkulatorToolStripMenuItem
        '
        Me.SimpleKalkulatorToolStripMenuItem.Name = "SimpleKalkulatorToolStripMenuItem"
        Me.SimpleKalkulatorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SimpleKalkulatorToolStripMenuItem.Text = "Simple Kalkulator"
        '
        'SiencetificKalkulatorToolStripMenuItem
        '
        Me.SiencetificKalkulatorToolStripMenuItem.Name = "SiencetificKalkulatorToolStripMenuItem"
        Me.SiencetificKalkulatorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SiencetificKalkulatorToolStripMenuItem.Text = "Siencetific Kalkulator"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WaktuStripAwal, Me.WaktuTools})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'WaktuStripAwal
        '
        Me.WaktuStripAwal.Name = "WaktuStripAwal"
        Me.WaktuStripAwal.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripButton1.Text = "Kalkulator"
        '
        'WaktuTools
        '
        Me.WaktuTools.Name = "WaktuTools"
        Me.WaktuTools.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripButton2.Text = "Waktu"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuAplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BiodataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KalkulatorUsiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KalkulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleKalkulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiencetificKalkulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents WaktuStripAwal As ToolStripStatusLabel
    Friend WithEvents WaktuTools As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
