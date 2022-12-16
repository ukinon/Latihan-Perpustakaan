<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerpustakaan
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPerpustakaan))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.minBtn = New System.Windows.Forms.Button()
        Me.plsBtn = New System.Windows.Forms.Button()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.showBtn = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(985, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.AllowDrop = True
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(12, 53)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(212, 381)
        Me.ListBoxKoleksi.TabIndex = 1
        '
        'minBtn
        '
        Me.minBtn.BackgroundImage = CType(resources.GetObject("minBtn.BackgroundImage"), System.Drawing.Image)
        Me.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minBtn.Location = New System.Drawing.Point(41, 27)
        Me.minBtn.Name = "minBtn"
        Me.minBtn.Size = New System.Drawing.Size(24, 23)
        Me.minBtn.TabIndex = 2
        Me.minBtn.UseVisualStyleBackColor = True
        '
        'plsBtn
        '
        Me.plsBtn.BackColor = System.Drawing.Color.Transparent
        Me.plsBtn.BackgroundImage = CType(resources.GetObject("plsBtn.BackgroundImage"), System.Drawing.Image)
        Me.plsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.plsBtn.Location = New System.Drawing.Point(12, 27)
        Me.plsBtn.Name = "plsBtn"
        Me.plsBtn.Size = New System.Drawing.Size(23, 23)
        Me.plsBtn.TabIndex = 3
        Me.plsBtn.UseVisualStyleBackColor = False
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(230, 53)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.Size = New System.Drawing.Size(739, 273)
        Me.DataGridKoleksi.TabIndex = 4
        '
        'showBtn
        '
        Me.showBtn.Location = New System.Drawing.Point(773, 351)
        Me.showBtn.Name = "showBtn"
        Me.showBtn.Size = New System.Drawing.Size(95, 31)
        Me.showBtn.TabIndex = 5
        Me.showBtn.Text = "Show"
        Me.showBtn.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(669, 351)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 31)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'removeBtn
        '
        Me.removeBtn.Location = New System.Drawing.Point(874, 351)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(95, 31)
        Me.removeBtn.TabIndex = 7
        Me.removeBtn.Text = "Remove"
        Me.removeBtn.UseVisualStyleBackColor = True
        '
        'FormPerpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 448)
        Me.Controls.Add(Me.removeBtn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.showBtn)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.plsBtn)
        Me.Controls.Add(Me.minBtn)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPerpustakaan"
        Me.Text = "Form Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents minBtn As Button
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents plsBtn As Button
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents showBtn As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents removeBtn As Button
End Class
