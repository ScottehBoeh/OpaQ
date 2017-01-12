<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.opacityBar = New System.Windows.Forms.TrackBar()
        Me.theBrowser = New System.Windows.Forms.WebBrowser()
        Me.addressBar = New System.Windows.Forms.TextBox()
        Me.stripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMenuHomepage_Set = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMenuHomepage_Reset = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buttonHome = New System.Windows.Forms.Button()
        Me.buttonForward = New System.Windows.Forms.Button()
        Me.buttonBack = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.opacityBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(20, 470)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(995, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(94, 17)
        Me.ToolStripStatusLabel1.Text = "OpaQ Proto v1.0"
        '
        'opacityBar
        '
        Me.opacityBar.AutoSize = False
        Me.opacityBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.opacityBar.Location = New System.Drawing.Point(20, 443)
        Me.opacityBar.Maximum = 20
        Me.opacityBar.Name = "opacityBar"
        Me.opacityBar.Size = New System.Drawing.Size(995, 27)
        Me.opacityBar.TabIndex = 10
        Me.opacityBar.Value = 20
        '
        'theBrowser
        '
        Me.theBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.theBrowser.Location = New System.Drawing.Point(20, 121)
        Me.theBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.theBrowser.Name = "theBrowser"
        Me.theBrowser.Size = New System.Drawing.Size(995, 322)
        Me.theBrowser.TabIndex = 11
        '
        'addressBar
        '
        Me.addressBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.addressBar.Location = New System.Drawing.Point(20, 101)
        Me.addressBar.Name = "addressBar"
        Me.addressBar.Size = New System.Drawing.Size(995, 20)
        Me.addressBar.TabIndex = 6
        '
        'stripMenu
        '
        Me.stripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenuHomepage_Set, Me.stripMenuHomepage_Reset, Me.stripMenuExit})
        Me.stripMenu.Name = "stripMenu"
        Me.stripMenu.Size = New System.Drawing.Size(37, 37)
        Me.stripMenu.Text = "File"
        '
        'stripMenuHomepage_Set
        '
        Me.stripMenuHomepage_Set.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentPageToolStripMenuItem, Me.CustomPageToolStripMenuItem})
        Me.stripMenuHomepage_Set.Name = "stripMenuHomepage_Set"
        Me.stripMenuHomepage_Set.Size = New System.Drawing.Size(164, 22)
        Me.stripMenuHomepage_Set.Text = "Set Homepage"
        '
        'CurrentPageToolStripMenuItem
        '
        Me.CurrentPageToolStripMenuItem.Name = "CurrentPageToolStripMenuItem"
        Me.CurrentPageToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CurrentPageToolStripMenuItem.Text = "Current Page"
        '
        'CustomPageToolStripMenuItem
        '
        Me.CustomPageToolStripMenuItem.Name = "CustomPageToolStripMenuItem"
        Me.CustomPageToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CustomPageToolStripMenuItem.Text = "Custom Page..."
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
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenu})
        Me.MenuStrip2.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(995, 41)
        Me.MenuStrip2.TabIndex = 4
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.OpaQBrowser.My.Resources.Resources.OpaQLogo2
        Me.PictureBox1.Location = New System.Drawing.Point(114, 468)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'buttonHome
        '
        Me.buttonHome.FlatAppearance.BorderSize = 0
        Me.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonHome.Image = Global.OpaQBrowser.My.Resources.Resources.home
        Me.buttonHome.Location = New System.Drawing.Point(64, 57)
        Me.buttonHome.Name = "buttonHome"
        Me.buttonHome.Size = New System.Drawing.Size(40, 40)
        Me.buttonHome.TabIndex = 9
        Me.buttonHome.UseVisualStyleBackColor = True
        '
        'buttonForward
        '
        Me.buttonForward.BackgroundImage = Global.OpaQBrowser.My.Resources.Resources.forward1
        Me.buttonForward.FlatAppearance.BorderSize = 0
        Me.buttonForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.buttonForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonForward.Location = New System.Drawing.Point(156, 57)
        Me.buttonForward.Name = "buttonForward"
        Me.buttonForward.Size = New System.Drawing.Size(40, 40)
        Me.buttonForward.TabIndex = 8
        Me.buttonForward.UseVisualStyleBackColor = True
        '
        'buttonBack
        '
        Me.buttonBack.BackgroundImage = Global.OpaQBrowser.My.Resources.Resources.back1
        Me.buttonBack.FlatAppearance.BorderSize = 0
        Me.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBack.Location = New System.Drawing.Point(110, 57)
        Me.buttonBack.Name = "buttonBack"
        Me.buttonBack.Size = New System.Drawing.Size(40, 40)
        Me.buttonBack.TabIndex = 7
        Me.buttonBack.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 512)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.theBrowser)
        Me.Controls.Add(Me.opacityBar)
        Me.Controls.Add(Me.buttonHome)
        Me.Controls.Add(Me.buttonForward)
        Me.Controls.Add(Me.buttonBack)
        Me.Controls.Add(Me.addressBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Tag = ""
        Me.Text = "OpaQ - The Opaque Browser"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.opacityBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents opacityBar As TrackBar
    Friend WithEvents buttonBack As Button
    Friend WithEvents buttonForward As Button
    Friend WithEvents theBrowser As WebBrowser
    Friend WithEvents addressBar As TextBox
    Friend WithEvents stripMenu As ToolStripMenuItem
    Friend WithEvents stripMenuHomepage_Set As ToolStripMenuItem
    Friend WithEvents CurrentPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stripMenuHomepage_Reset As ToolStripMenuItem
    Friend WithEvents stripMenuExit As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents buttonHome As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
