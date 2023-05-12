<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class map
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(map))
        Me.Browser = New System.Windows.Forms.WebBrowser()
        Me.Btnmap = New System.Windows.Forms.Button()
        Me.Txtstreet = New System.Windows.Forms.TextBox()
        Me.Lblstreet = New System.Windows.Forms.Label()
        Me.Lblcity = New System.Windows.Forms.Label()
        Me.Lblstate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Txtcity = New System.Windows.Forms.TextBox()
        Me.Txtstate = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browser.Location = New System.Drawing.Point(0, 137)
        Me.Browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(1157, 563)
        Me.Browser.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.Browser, "Map ")
        '
        'Btnmap
        '
        Me.Btnmap.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnmap.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmap.Location = New System.Drawing.Point(926, 71)
        Me.Btnmap.Name = "Btnmap"
        Me.Btnmap.Size = New System.Drawing.Size(170, 43)
        Me.Btnmap.TabIndex = 3
        Me.Btnmap.Text = "Show Map"
        Me.ToolTip1.SetToolTip(Me.Btnmap, "Show Map")
        Me.Btnmap.UseVisualStyleBackColor = True
        '
        'Txtstreet
        '
        Me.Txtstreet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtstreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtstreet.Location = New System.Drawing.Point(828, 15)
        Me.Txtstreet.Name = "Txtstreet"
        Me.Txtstreet.Size = New System.Drawing.Size(268, 34)
        Me.Txtstreet.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Txtstreet, "Enter Street")
        '
        'Lblstreet
        '
        Me.Lblstreet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblstreet.AutoSize = True
        Me.Lblstreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstreet.ForeColor = System.Drawing.Color.White
        Me.Lblstreet.Location = New System.Drawing.Point(714, 15)
        Me.Lblstreet.Name = "Lblstreet"
        Me.Lblstreet.Size = New System.Drawing.Size(91, 32)
        Me.Lblstreet.TabIndex = 18
        Me.Lblstreet.Text = "Street"
        '
        'Lblcity
        '
        Me.Lblcity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblcity.AutoSize = True
        Me.Lblcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcity.ForeColor = System.Drawing.Color.White
        Me.Lblcity.Location = New System.Drawing.Point(405, 15)
        Me.Lblcity.Name = "Lblcity"
        Me.Lblcity.Size = New System.Drawing.Size(64, 32)
        Me.Lblcity.TabIndex = 17
        Me.Lblcity.Text = "City"
        '
        'Lblstate
        '
        Me.Lblstate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblstate.AutoSize = True
        Me.Lblstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstate.ForeColor = System.Drawing.Color.White
        Me.Lblstate.Location = New System.Drawing.Point(387, 80)
        Me.Lblstate.Name = "Lblstate"
        Me.Lblstate.Size = New System.Drawing.Size(82, 32)
        Me.Lblstate.TabIndex = 16
        Me.Lblstate.Text = "State"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Btnmap)
        Me.Panel1.Controls.Add(Me.Txtstreet)
        Me.Panel1.Controls.Add(Me.Lblstreet)
        Me.Panel1.Controls.Add(Me.Lblcity)
        Me.Panel1.Controls.Add(Me.Lblstate)
        Me.Panel1.Controls.Add(Me.Txtcity)
        Me.Panel1.Controls.Add(Me.Txtstate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 136)
        Me.Panel1.TabIndex = 24
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(62, 45)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Back")
        '
        'Txtcity
        '
        Me.Txtcity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcity.Location = New System.Drawing.Point(492, 13)
        Me.Txtcity.Name = "Txtcity"
        Me.Txtcity.Size = New System.Drawing.Size(204, 34)
        Me.Txtcity.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Txtcity, "Enter City")
        '
        'Txtstate
        '
        Me.Txtstate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtstate.Location = New System.Drawing.Point(492, 80)
        Me.Txtstate.Name = "Txtstate"
        Me.Txtstate.Size = New System.Drawing.Size(204, 34)
        Me.Txtstate.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Txtstate, "Enter State")
        '
        'map
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 700)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "map"
        Me.Text = "map"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Browser As WebBrowser
    Friend WithEvents Btnmap As Button
    Friend WithEvents Txtstreet As TextBox
    Friend WithEvents Lblstreet As Label
    Friend WithEvents Lblcity As Label
    Friend WithEvents Lblstate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Txtcity As TextBox
    Friend WithEvents Txtstate As TextBox
End Class
