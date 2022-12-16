<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateKoleksi
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbBudaya = New System.Windows.Forms.CheckBox()
        Me.cbTeknologi = New System.Windows.Forms.CheckBox()
        Me.cbSosial = New System.Windows.Forms.CheckBox()
        Me.cbSains = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.RdIndonesia = New System.Windows.Forms.RadioButton()
        Me.btnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbStok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TbTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TbLokasiRak = New System.Windows.Forms.TextBox()
        Me.TbPenerbit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RtbDesc = New System.Windows.Forms.RichTextBox()
        Me.TbJenis = New System.Windows.Forms.TextBox()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdateGambar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(148, 490)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Kategori"
        '
        'cbBudaya
        '
        Me.cbBudaya.AutoSize = True
        Me.cbBudaya.Location = New System.Drawing.Point(6, 89)
        Me.cbBudaya.Name = "cbBudaya"
        Me.cbBudaya.Size = New System.Drawing.Size(62, 17)
        Me.cbBudaya.TabIndex = 3
        Me.cbBudaya.Text = "Budaya"
        Me.cbBudaya.UseVisualStyleBackColor = True
        '
        'cbTeknologi
        '
        Me.cbTeknologi.AutoSize = True
        Me.cbTeknologi.Location = New System.Drawing.Point(6, 66)
        Me.cbTeknologi.Name = "cbTeknologi"
        Me.cbTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.cbTeknologi.TabIndex = 2
        Me.cbTeknologi.Text = "Teknologi"
        Me.cbTeknologi.UseVisualStyleBackColor = True
        '
        'cbSosial
        '
        Me.cbSosial.AutoSize = True
        Me.cbSosial.Location = New System.Drawing.Point(6, 43)
        Me.cbSosial.Name = "cbSosial"
        Me.cbSosial.Size = New System.Drawing.Size(54, 17)
        Me.cbSosial.TabIndex = 1
        Me.cbSosial.Text = "Sosial"
        Me.cbSosial.UseVisualStyleBackColor = True
        '
        'cbSains
        '
        Me.cbSains.AutoSize = True
        Me.cbSains.Location = New System.Drawing.Point(7, 20)
        Me.cbSains.Name = "cbSains"
        Me.cbSains.Size = New System.Drawing.Size(52, 17)
        Me.cbSains.TabIndex = 0
        Me.cbSains.Text = "Sains"
        Me.cbSains.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbBudaya)
        Me.GroupBox2.Controls.Add(Me.cbTeknologi)
        Me.GroupBox2.Controls.Add(Me.cbSosial)
        Me.GroupBox2.Controls.Add(Me.cbSains)
        Me.GroupBox2.Location = New System.Drawing.Point(284, 490)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 115)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'RdInggris
        '
        Me.RdInggris.AutoSize = True
        Me.RdInggris.Location = New System.Drawing.Point(6, 43)
        Me.RdInggris.Name = "RdInggris"
        Me.RdInggris.Size = New System.Drawing.Size(95, 17)
        Me.RdInggris.TabIndex = 1
        Me.RdInggris.TabStop = True
        Me.RdInggris.Text = "Bahasa Inggris"
        Me.RdInggris.UseVisualStyleBackColor = True
        '
        'RdIndonesia
        '
        Me.RdIndonesia.AutoSize = True
        Me.RdIndonesia.Location = New System.Drawing.Point(7, 20)
        Me.RdIndonesia.Name = "RdIndonesia"
        Me.RdIndonesia.Size = New System.Drawing.Size(110, 17)
        Me.RdIndonesia.TabIndex = 0
        Me.RdIndonesia.TabStop = True
        Me.RdIndonesia.Text = "Bahasa Indonesia"
        Me.RdIndonesia.UseVisualStyleBackColor = True
        '
        'btnUpdateKoleksi
        '
        Me.btnUpdateKoleksi.Location = New System.Drawing.Point(369, 622)
        Me.btnUpdateKoleksi.Name = "btnUpdateKoleksi"
        Me.btnUpdateKoleksi.Size = New System.Drawing.Size(115, 51)
        Me.btnUpdateKoleksi.TabIndex = 47
        Me.btnUpdateKoleksi.Text = "Update Koleksi"
        Me.btnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdInggris)
        Me.GroupBox1.Controls.Add(Me.RdIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(284, 404)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 70)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(148, 404)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Bahasa"
        '
        'TbStok
        '
        Me.TbStok.Location = New System.Drawing.Point(284, 371)
        Me.TbStok.Name = "TbStok"
        Me.TbStok.Size = New System.Drawing.Size(183, 20)
        Me.TbStok.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(148, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Stok"
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Location = New System.Drawing.Point(284, 335)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(183, 20)
        Me.DtpTanggal.TabIndex = 40
        '
        'TbTahunTerbit
        '
        Me.TbTahunTerbit.Location = New System.Drawing.Point(284, 265)
        Me.TbTahunTerbit.Name = "TbTahunTerbit"
        Me.TbTahunTerbit.Size = New System.Drawing.Size(183, 20)
        Me.TbTahunTerbit.TabIndex = 39
        '
        'TbLokasiRak
        '
        Me.TbLokasiRak.Location = New System.Drawing.Point(284, 300)
        Me.TbLokasiRak.Name = "TbLokasiRak"
        Me.TbLokasiRak.Size = New System.Drawing.Size(183, 20)
        Me.TbLokasiRak.TabIndex = 38
        '
        'TbPenerbit
        '
        Me.TbPenerbit.Location = New System.Drawing.Point(284, 230)
        Me.TbPenerbit.Name = "TbPenerbit"
        Me.TbPenerbit.Size = New System.Drawing.Size(183, 20)
        Me.TbPenerbit.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(148, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Penerbit"
        '
        'RtbDesc
        '
        Me.RtbDesc.Location = New System.Drawing.Point(284, 119)
        Me.RtbDesc.Name = "RtbDesc"
        Me.RtbDesc.Size = New System.Drawing.Size(183, 96)
        Me.RtbDesc.TabIndex = 32
        Me.RtbDesc.Text = ""
        '
        'TbJenis
        '
        Me.TbJenis.Location = New System.Drawing.Point(284, 85)
        Me.TbJenis.Name = "TbJenis"
        Me.TbJenis.Size = New System.Drawing.Size(183, 20)
        Me.TbJenis.TabIndex = 31
        '
        'TbNama
        '
        Me.TbNama.Location = New System.Drawing.Point(284, 53)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(183, 20)
        Me.TbNama.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Koleksi"
        '
        'btnUpdateGambar
        '
        Me.btnUpdateGambar.Location = New System.Drawing.Point(12, 180)
        Me.btnUpdateGambar.Name = "btnUpdateGambar"
        Me.btnUpdateGambar.Size = New System.Drawing.Size(98, 23)
        Me.btnUpdateGambar.TabIndex = 26
        Me.btnUpdateGambar.Text = "Update Gambar"
        Me.btnUpdateGambar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 118)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tambah Koleksi"
        '
        'FormUpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 682)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnUpdateKoleksi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TbStok)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DtpTanggal)
        Me.Controls.Add(Me.TbTahunTerbit)
        Me.Controls.Add(Me.TbLokasiRak)
        Me.Controls.Add(Me.TbPenerbit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RtbDesc)
        Me.Controls.Add(Me.TbJenis)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpdateGambar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUpdateKoleksi"
        Me.Text = "FormUpdateKoleksi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents cbBudaya As CheckBox
    Friend WithEvents cbTeknologi As CheckBox
    Friend WithEvents cbSosial As CheckBox
    Friend WithEvents cbSains As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents RdIndonesia As RadioButton
    Friend WithEvents btnUpdateKoleksi As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbStok As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents TbTahunTerbit As TextBox
    Friend WithEvents TbLokasiRak As TextBox
    Friend WithEvents TbPenerbit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RtbDesc As RichTextBox
    Friend WithEvents TbJenis As TextBox
    Friend WithEvents TbNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdateGambar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
