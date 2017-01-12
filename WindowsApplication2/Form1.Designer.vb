<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opaqBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(opaqBrowser))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.stripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMenuHomepage_Set = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMenuHomepage_Reset = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.addressBar = New System.Windows.Forms.TextBox()
        Me.buttonBack = New System.Windows.Forms.Button()
        Me.buttonForward = New System.Windows.Forms.Button()
        Me.buttonHome = New System.Windows.Forms.Button()
        Me.opacityBar = New System.Windows.Forms.TrackBar()
        Me.theBrowser = New System.Windows.Forms.WebBrowser()
        Me.buttonGo = New System.Windows.Forms.Button()
        Me.MenuStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.opacityBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenu})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(757, 24)
        Me.MenuStrip2.TabIndex = 4
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'stripMenu
        '
        Me.stripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenuHomepage_Set, Me.stripMenuHomepage_Reset, Me.stripMenuExit})
        Me.stripMenu.Name = "stripMenu"
        Me.stripMenu.Size = New System.Drawing.Size(37, 20)
        Me.stripMenu.Text = "File"
        '
        'stripMenuHomepage_Set
        '
        Me.stripMenuHomepage_Set.Name = "stripMenuHomepage_Set"
        Me.stripMenuHomepage_Set.Size = New System.Drawing.Size(164, 22)
        Me.stripMenuHomepage_Set.Text = "Set Homepage"
        '
        'stripMenuHomepage_Reset
        '
        Me.stripMenuHomepage_Reset.Name = "stripMenuHomepage_Reset"
        Me.stripMenuHomepage_Reset.Size = New System.Drawing.Size(164, 22)
        Me.stripMenuHomepage_Reset.Text = "Reset Homepage"
        '
        'stripMenuExit
        '
        Me.stripMenuExit.Name = "stripMenuExit"
        Me.stripMenuExit.Size = New System.Drawing.Size(164, 22)
        Me.stripMenuExit.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 490)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(757, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(94, 17)
        Me.ToolStripStatusLabel1.Text = "OpaQ Proto v1.0"
        '
        'addressBar
        '
        Me.addressBar.Location = New System.Drawing.Point(106, 1)
        Me.addressBar.Name = "addressBar"
        Me.addressBar.Size = New System.Drawing.Size(227, 20)
        Me.addressBar.TabIndex = 6
        '
        'buttonBack
        '
        Me.buttonBack.Location = New System.Drawing.Point(368, 0)
        Me.buttonBack.Name = "buttonBack"
        Me.buttonBack.Size = New System.Drawing.Size(22, 23)
        Me.buttonBack.TabIndex = 7
        Me.buttonBack.Text = "<"
        Me.buttonBack.UseVisualStyleBackColor = True
        '
        'buttonForward
        '
        Me.buttonForward.Location = New System.Drawing.Point(390, 0)
        Me.buttonForward.Name = "buttonForward"
        Me.buttonForward.Size = New System.Drawing.Size(22, 23)
        Me.buttonForward.TabIndex = 8
        Me.buttonForward.Text = ">"
        Me.buttonForward.UseVisualStyleBackColor = True
        '
        'buttonHome
        '
        Me.buttonHome.Location = New System.Drawing.Point(49, 0)
        Me.buttonHome.Name = "buttonHome"
        Me.buttonHome.Size = New System.Drawing.Size(51, 23)
        Me.buttonHome.TabIndex = 9
        Me.buttonHome.Text = "Home"
        Me.buttonHome.UseVisualStyleBackColor = True
        '
        'opacityBar
        '
        Me.opacityBar.AutoSize = False
        Me.opacityBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.opacityBar.Location = New System.Drawing.Point(0, 463)
        Me.opacityBar.Maximum = 20
        Me.opacityBar.Name = "opacityBar"
        Me.opacityBar.Size = New System.Drawing.Size(757, 27)
        Me.opacityBar.TabIndex = 10
        Me.opacityBar.Value = 6
        '
        'theBrowser
        '
        Me.theBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.theBrowser.Location = New System.Drawing.Point(0, 24)
        Me.theBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.theBrowser.Name = "theBrowser"
        Me.theBrowser.Size = New System.Drawing.Size(757, 439)
        Me.theBrowser.TabIndex = 11
        '
        'buttonGo
        '
        Me.buttonGo.Location = New System.Drawing.Point(334, 0)
        Me.buttonGo.Name = "buttonGo"
        Me.buttonGo.Size = New System.Drawing.Size(34, 23)
        Me.buttonGo.TabIndex = 12
        Me.buttonGo.Text = "Go"
        Me.buttonGo.UseVisualStyleBackColor = True
        '
        'opaqBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 512)
        Me.Controls.Add(Me.buttonGo)
        Me.Controls.Add(Me.theBrowser)
        Me.Controls.Add(Me.opacityBar)
        Me.Controls.Add(Me.buttonHome)
        Me.Controls.Add(Me.buttonForward)
        Me.Controls.Add(Me.buttonBack)
        Me.Controls.Add(Me.addressBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "opaqBrowser"
        Me.Text = "OpaQ - The Opaque Browser"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.opacityBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents stripMenu As ToolStripMenuItem
    Friend WithEvents stripMenuHomepage_Set As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stripMenuHomepage_Reset As ToolStripMenuItem
    Friend WithEvents stripMenuExit As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents addressBar As TextBox
    Friend WithEvents buttonBack As Button
    Friend WithEvents buttonForward As Button
    Friend WithEvents buttonHome As Button
    Friend WithEvents opacityBar As TrackBar
    Friend WithEvents theBrowser As WebBrowser
    Friend WithEvents buttonGo As Button
End Class
