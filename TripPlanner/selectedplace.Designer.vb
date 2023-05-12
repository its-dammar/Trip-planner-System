<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectedplace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectedplace))
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.selectedplaceDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.Btnshow = New System.Windows.Forms.Button()
        Me.Txtplacename = New System.Windows.Forms.TextBox()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddYourPlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.selectedplaceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selectedplaceDataGridView
        '
        Me.selectedplaceDataGridView.AllowUserToAddRows = False
        Me.selectedplaceDataGridView.AllowUserToDeleteRows = False
        Me.selectedplaceDataGridView.AllowUserToOrderColumns = True
        Me.selectedplaceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.selectedplaceDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.selectedplaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.selectedplaceDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.selectedplaceDataGridView.Location = New System.Drawing.Point(424, 76)
        Me.selectedplaceDataGridView.Margin = New System.Windows.Forms.Padding(9)
        Me.selectedplaceDataGridView.Name = "selectedplaceDataGridView"
        Me.selectedplaceDataGridView.ReadOnly = True
        Me.selectedplaceDataGridView.RowHeadersWidth = 60
        Me.selectedplaceDataGridView.RowTemplate.Height = 24
        Me.selectedplaceDataGridView.Size = New System.Drawing.Size(686, 555)
        Me.selectedplaceDataGridView.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.selectedplaceDataGridView, "Admin Details")
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 45)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Back")
        '
        'Btnsearch
        '
        Me.Btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsearch.Location = New System.Drawing.Point(676, 4)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(143, 44)
        Me.Btnsearch.TabIndex = 9
        Me.Btnsearch.Text = "search"
        Me.ToolTip1.SetToolTip(Me.Btnsearch, "Search by Place Name")
        Me.Btnsearch.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(381, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 38)
        Me.TextBox1.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Enter UserName")
        '
        'Btnprint
        '
        Me.Btnprint.BackColor = System.Drawing.Color.SandyBrown
        Me.Btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprint.ForeColor = System.Drawing.Color.Black
        Me.Btnprint.Location = New System.Drawing.Point(236, 451)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(161, 43)
        Me.Btnprint.TabIndex = 7
        Me.Btnprint.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.Btnprint, "Print Data")
        Me.Btnprint.UseVisualStyleBackColor = False
        '
        'Btnshow
        '
        Me.Btnshow.BackColor = System.Drawing.Color.SandyBrown
        Me.Btnshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnshow.ForeColor = System.Drawing.Color.Black
        Me.Btnshow.Location = New System.Drawing.Point(107, 245)
        Me.Btnshow.Name = "Btnshow"
        Me.Btnshow.Size = New System.Drawing.Size(237, 43)
        Me.Btnshow.TabIndex = 3
        Me.Btnshow.Text = "Show Data"
        Me.ToolTip1.SetToolTip(Me.Btnshow, "Show Data")
        Me.Btnshow.UseVisualStyleBackColor = False
        '
        'Txtplacename
        '
        Me.Txtplacename.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtplacename.Location = New System.Drawing.Point(107, 178)
        Me.Txtplacename.Name = "Txtplacename"
        Me.Txtplacename.Size = New System.Drawing.Size(237, 38)
        Me.Txtplacename.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Txtplacename, "Enter UserName")
        '
        'Txtid
        '
        Me.Txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtid.Location = New System.Drawing.Point(107, 62)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(237, 38)
        Me.Txtid.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Txtid, "Enter ID")
        '
        'Btnedit
        '
        Me.Btnedit.BackColor = System.Drawing.Color.SandyBrown
        Me.Btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.Black
        Me.Btnedit.Location = New System.Drawing.Point(236, 337)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(161, 43)
        Me.Btnedit.TabIndex = 5
        Me.Btnedit.Text = "Edit"
        Me.ToolTip1.SetToolTip(Me.Btnedit, "Edit Select Data")
        Me.Btnedit.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.SandyBrown
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.Color.Black
        Me.Btndelete.Location = New System.Drawing.Point(21, 451)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(140, 43)
        Me.Btndelete.TabIndex = 6
        Me.Btndelete.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.Btndelete, "Delete Select Data")
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.SandyBrown
        Me.Btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.ForeColor = System.Drawing.Color.Black
        Me.Btnadd.Location = New System.Drawing.Point(21, 336)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(140, 44)
        Me.Btnadd.TabIndex = 4
        Me.Btnadd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.Btnadd, "Add New Admin")
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Btnsearch)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1119, 642)
        Me.Panel1.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.Btnprint)
        Me.GroupBox1.Controls.Add(Me.Btnshow)
        Me.GroupBox1.Controls.Add(Me.Txtplacename)
        Me.GroupBox1.Controls.Add(Me.Txtid)
        Me.GroupBox1.Controls.Add(Me.Btnedit)
        Me.GroupBox1.Controls.Add(Me.Btndelete)
        Me.GroupBox1.Controls.Add(Me.Btnadd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 555)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(101, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 32)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Place Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(101, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 32)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "ID"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(941, 54)
        Me.Panel2.TabIndex = 52
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddYourPlanToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(941, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(178, 642)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddYourPlanToolStripMenuItem
        '
        Me.AddYourPlanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPlanToolStripMenuItem, Me.ViewPlanToolStripMenuItem})
        Me.AddYourPlanToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddYourPlanToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.AddYourPlanToolStripMenuItem.Name = "AddYourPlanToolStripMenuItem"
        Me.AddYourPlanToolStripMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.AddYourPlanToolStripMenuItem.Text = "Add your Plan"
        '
        'AddPlanToolStripMenuItem
        '
        Me.AddPlanToolStripMenuItem.Name = "AddPlanToolStripMenuItem"
        Me.AddPlanToolStripMenuItem.Size = New System.Drawing.Size(253, 32)
        Me.AddPlanToolStripMenuItem.Text = "Add & Update plan"
        '
        'ViewPlanToolStripMenuItem
        '
        Me.ViewPlanToolStripMenuItem.Name = "ViewPlanToolStripMenuItem"
        Me.ViewPlanToolStripMenuItem.Size = New System.Drawing.Size(253, 32)
        Me.ViewPlanToolStripMenuItem.Text = "View Plan"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 4)
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        '
        'selectedplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1119, 642)
        Me.Controls.Add(Me.selectedplaceDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "selectedplace"
        Me.Text = "Selected Places"
        CType(Me.selectedplaceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents selectedplaceDataGridView As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Btnsearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btnprint As Button
    Friend WithEvents Btnshow As Button
    Friend WithEvents Txtplacename As TextBox
    Friend WithEvents Txtid As TextBox
    Friend WithEvents Btnedit As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddYourPlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddPlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
End Class
