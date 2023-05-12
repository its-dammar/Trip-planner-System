<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeuserpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changeuserpassword))
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txtsearch = New System.Windows.Forms.TextBox()
        Me.userDataGridView = New System.Windows.Forms.DataGridView()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.Btnshow = New System.Windows.Forms.Button()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
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
        'Txtsearch
        '
        Me.Txtsearch.BackColor = System.Drawing.Color.White
        Me.Txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsearch.Location = New System.Drawing.Point(642, 7)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.Size = New System.Drawing.Size(266, 38)
        Me.Txtsearch.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Txtsearch, "Enter UserName")
        '
        'userDataGridView
        '
        Me.userDataGridView.AllowUserToAddRows = False
        Me.userDataGridView.AllowUserToDeleteRows = False
        Me.userDataGridView.AllowUserToOrderColumns = True
        Me.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.userDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.userDataGridView.Location = New System.Drawing.Point(436, 110)
        Me.userDataGridView.Name = "userDataGridView"
        Me.userDataGridView.ReadOnly = True
        Me.userDataGridView.RowHeadersWidth = 51
        Me.userDataGridView.RowTemplate.Height = 24
        Me.userDataGridView.Size = New System.Drawing.Size(666, 509)
        Me.userDataGridView.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.userDataGridView, "Admin Details")
        '
        'Btnprint
        '
        Me.Btnprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprint.ForeColor = System.Drawing.Color.Black
        Me.Btnprint.Location = New System.Drawing.Point(236, 554)
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
        Me.Btnshow.Location = New System.Drawing.Point(177, 346)
        Me.Btnshow.Name = "Btnshow"
        Me.Btnshow.Size = New System.Drawing.Size(161, 43)
        Me.Btnshow.TabIndex = 3
        Me.Btnshow.Text = "Show Data"
        Me.ToolTip1.SetToolTip(Me.Btnshow, "Show Data")
        Me.Btnshow.UseVisualStyleBackColor = False
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(177, 217)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(237, 38)
        Me.TxtUsername.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtUsername, "Enter UserName")
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(177, 286)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(237, 38)
        Me.TxtPassword.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TxtPassword, "Enter Password")
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(177, 137)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(237, 38)
        Me.TxtId.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtId, "Enter ID")
        '
        'Btnedit
        '
        Me.Btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.Black
        Me.Btnedit.Location = New System.Drawing.Point(236, 440)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(161, 43)
        Me.Btnedit.TabIndex = 5
        Me.Btnedit.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.Btnedit, "Edit Select Data")
        Me.Btnedit.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.Color.Black
        Me.Btndelete.Location = New System.Drawing.Point(21, 554)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(140, 43)
        Me.Btndelete.TabIndex = 6
        Me.Btndelete.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.Btndelete, "Delete Select Data")
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.ForeColor = System.Drawing.Color.Black
        Me.Btnadd.Location = New System.Drawing.Point(21, 439)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(140, 44)
        Me.Btnadd.TabIndex = 4
        Me.Btnadd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.Btnadd, "Add New Admin")
        Me.Btnadd.UseVisualStyleBackColor = False
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(118, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 32)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 32)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Txtsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 52)
        Me.Panel1.TabIndex = 27
        '
        'changeuserpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1102, 641)
        Me.Controls.Add(Me.userDataGridView)
        Me.Controls.Add(Me.Btnprint)
        Me.Controls.Add(Me.Btnshow)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Btnedit)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "changeuserpassword"
        Me.Text = "change User Password"
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Txtsearch As TextBox
    Friend WithEvents userDataGridView As DataGridView
    Friend WithEvents Btnprint As Button
    Friend WithEvents Btnshow As Button
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Btnedit As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
