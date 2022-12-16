Public Class FormTambahKoleksi

    Public Shared FotoKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DtpTanggal.Format = DateTimePickerFormat.Custom
        DtpTanggal.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub btnAddGambar_Click(sender As Object, e As EventArgs) Handles btnAddGambar.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.JPG|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        FotoKoleksi = OpenFileDialog1.FileName

        PictureBox1.Load(FotoKoleksi)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        FormPerpustakaan.DataPerpus.GSFoto = FotoKoleksi.ToString()
        FormPerpustakaan.DataPerpus.GSFoto = FormPerpustakaan.DataPerpus.GSFoto.Replace("\", "/")
    End Sub

    Private Sub btnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles btnTambahKoleksi.Click
        FormPerpustakaan.DataPerpus.GSnama = TbNama.Text
        FormPerpustakaan.DataPerpus.GSjenis = TbJenis.Text
        FormPerpustakaan.DataPerpus.GSdeskripsi = RtbDesc.Text
        FormPerpustakaan.DataPerpus.GSpenerbit = TbPenerbit.Text
        FormPerpustakaan.DataPerpus.GStahun = TbTahunTerbit.Text
        FormPerpustakaan.DataPerpus.GSlokasi = TbLokasiRak.Text
        FormPerpustakaan.DataPerpus.GStanggalMasuk = DtpTanggal.Value.ToShortDateString
        FormPerpustakaan.DataPerpus.GSstok = TbStok.Text

        If RdIndonesia.Checked() Then
            FormPerpustakaan.DataPerpus.GSbahasa = "Bahasa Indonesia"
        End If
        If RdInggris.Checked() Then
            FormPerpustakaan.DataPerpus.GSbahasa = "Bahasa Inggris"
        End If

        If cbSains.Checked() Then
            FormPerpustakaan.DataPerpus.GSkategori.Add("Sains")
        End If
        If cbSosial.Checked() Then
            FormPerpustakaan.DataPerpus.GSkategori.Add("Sosial")
        End If
        If cbTeknologi.Checked() Then
            FormPerpustakaan.DataPerpus.GSkategori.Add("Teknologi")
        End If
        If cbBudaya.Checked() Then
            FormPerpustakaan.DataPerpus.GSkategori.Add("Budaya")
        End If

        FormInfoKoleksi.Show()

        FormPerpustakaan.ListBoxKoleksi.Items.Add(FormPerpustakaan.DataPerpus.GSNama)


        Dim convertedKoleksi = FormPerpustakaan.DataPerpus.ConvertKoleksiToString(FormPerpustakaan.DataPerpus.GSkategori)
        FormPerpustakaan.DataPerpus.AddDataKoleksiDatabase(
        FormPerpustakaan.DataPerpus.GSFoto,
        FormPerpustakaan.DataPerpus.GSnama,
        FormPerpustakaan.DataPerpus.GSjenis,
        FormPerpustakaan.DataPerpus.GSpenerbit,
        FormPerpustakaan.DataPerpus.GSdeskripsi,
        FormPerpustakaan.DataPerpus.GStahun,
        FormPerpustakaan.DataPerpus.GSlokasi,
        FormPerpustakaan.DataPerpus.GStanggalMasuk,
        FormPerpustakaan.DataPerpus.GSstok,
        FormPerpustakaan.DataPerpus.GSbahasa,
        convertedKoleksi
)

        Me.Close()
    End Sub
End Class