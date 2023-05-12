<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeAdminpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changeAdminpassword))
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.Btnshow = New System.Windows.Forms.Button()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.adminDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.adminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.Color.Black
        Me.Btndelete.Location = New System.Drawing.Point(21, 533)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(140, 43)
        Me.Btndelete.TabIndex = 6
        Me.Btndelete.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.Btndelete, "Delete Select Data")
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(118, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 32)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ID"
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.ForeColor = System.Drawing.Color.Black
        Me.Btnadd.Location = New System.Drawing.Point(21, 418)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(140, 44)
        Me.Btnadd.TabIndex = 4
        Me.Btnadd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.Btnadd, "Add New Admin")
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Username"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(937, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "search"
        Me.ToolTip1.SetToolTip(Me.Button1, "Search by Username")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(642, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 38)
        Me.TextBox1.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Enter UserName")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1107, 52)
        Me.Panel1.TabIndex = 13
        '
        'Btnprint
        '
        Me.Btnprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprint.ForeColor = System.Drawing.Color.Black
        Me.Btnprint.Location = New System.Drawing.Point(236, 533)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(161, 43)
        Me.Btnprint.TabIndex = 7
        Me.Btnprint.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.Btnprint, "Print Data")
        Me.Btnprint.UseVisualStyleBackColor = False
        '
        'Btnshow
        '
        Me.Btnshow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnshow.ForeColor = System.Drawing.Color.Black
        Me.Btnshow.Location = New System.Drawing.Point(177, 325)
        Me.Btnshow.Name = "Btnshow"
        Me.Btnshow.Size = New System.Drawing.Size(161, 43)
        Me.Btnshow.TabIndex = 3
        Me.Btnshow.Text = "Show Data"
        Me.ToolTip1.SetToolTip(Me.Btnshow, "Show Data")
        Me.Btnshow.UseVisualStyleBackColor = False
        '
        'Txtusername
        '
        Me.Txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(177, 196)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(237, 38)
        Me.Txtusername.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Txtusername, "Enter UserName")
        '
        'Txtpassword
        '
        Me.Txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpassword.Location = New System.Drawing.Point(177, 265)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(237, 38)
        Me.Txtpassword.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Txtpassword, "Enter Password")
        '
        'Txtid
        '
        Me.Txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtid.Location = New System.Drawing.Point(177, 116)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(237, 38)
        Me.Txtid.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Txtid, "Enter ID")
        '
        'Btnedit
        '
        Me.Btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.Black
        Me.Btnedit.Location = New System.Drawing.Point(236, 419)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(161, 43)
        Me.Btnedit.TabIndex = 5
        Me.Btnedit.Text = "Edit"
        Me.ToolTip1.SetToolTip(Me.Btnedit, "Edit Select Data")
        Me.Btnedit.UseVisualStyleBackColor = False
        '
        'adminDataGridView
        '
        Me.adminDataGridView.AllowUserToAddRows = False
        Me.adminDataGridView.AllowUserToDeleteRows = False
        Me.adminDataGridView.AllowUserToOrderColumns = True
        Me.adminDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.adminDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.adminDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.adminDataGridView.Location = New System.Drawing.Point(436, 89)
        Me.adminDataGridView.Name = "adminDataGridView"
        Me.adminDataGridView.ReadOnly = True
        Me.adminDataGridView.RowHeadersWidth = 51
        Me.adminDataGridView.RowTemplate.Height = 24
        Me.adminDataGridView.Size = New System.Drawing.Size(666, 509)
        Me.adminDataGridView.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.adminDataGridView, "Admin Details")
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
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        '
        'changeAdminpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1107, 642)
        Me.Controls.Add(Me.adminDataGridView)
        Me.Controls.Add(Me.Btnprint)
        Me.Controls.Add(Me.Btnshow)
        Me.Controls.Add(Me.Txtusername)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.Btnedit)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "changeAdminpassword"
        Me.Text = "change Admin Password"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.adminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btndelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents Btnadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnprint As Button
    Friend WithEvents Btnshow As Button
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Txtid As TextBox
    Friend WithEvents Btnedit As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents adminDataGridView As DataGridView
End Class
