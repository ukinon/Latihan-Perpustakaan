Public Class FormUpdateKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBox1.Load(FormPerpustakaan.DataPerpus.GSFoto)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        DtpTanggal.Format = DateTimePickerFormat.Custom
        DtpTanggal.CustomFormat = "yyyy/MM/dd"
        TbNama.Text = FormPerpustakaan.DataPerpus.GSnama
        TbJenis.Text = FormPerpustakaan.DataPerpus.GSjenis
        RtbDesc.Text = FormPerpustakaan.DataPerpus.GSdeskripsi
        TbPenerbit.Text = FormPerpustakaan.DataPerpus.GSpenerbit
        TbLokasiRak.Text = FormPerpustakaan.DataPerpus.GSlokasi
        DtpTanggal.Value = FormPerpustakaan.DataPerpus.GStanggalMasuk
        TbStok.Text = FormPerpustakaan.DataPerpus.GSstok

        If String.Compare(FormPerpustakaan.DataPerpus.GSbahasa, "Indonesia") = 0 Then
            RdIndonesia.Checked = True
        ElseIf String.Compare(FormPerpustakaan.DataPerpus.GSbahasa, "Inggris") = 0 Then
            RdInggris.Checked = True
        End If

        For Each kategoriItem In FormPerpustakaan.DataPerpus.GSkategori
            If String.Compare(kategoriItem, "Sains") Then
                cbSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") Then
                cbSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") Then
                cbTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") Then
                cbBudaya.Checked = True
                        End If

        Next
        FormPerpustakaan.DataPerpus.GSkategori.Clear()
    End Sub

    Private Sub btnUpdateGambar_Click(sender As Object, e As EventArgs) Handles btnUpdateGambar.Click
        OpenFileDialog1.Title = "Pilih Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.JPG|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBox1.Load(picKoleksiDir)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        FormPerpustakaan.DataPerpus.GSFoto = picKoleksiDir.ToString()
        FormPerpustakaan.DataPerpus.GSFoto = FormPerpustakaan.DataPerpus.GSFoto.Replace("\", "/")
    End Sub

    Private Sub btnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles btnUpdateKoleksi.Click
        FormPerpustakaan.DataPerpus.GSnama = TbNama.Text.ToString()
        FormPerpustakaan.DataPerpus.GSjenis = TbJenis.Text.ToString()
        FormPerpustakaan.DataPerpus.GSdeskripsi = RtbDesc.Text.ToString()
        FormPerpustakaan.DataPerpus.GSpenerbit = TbPenerbit.Text.ToString()
        FormPerpustakaan.DataPerpus.GStahun = Integer.Parse(TbTahunTerbit.Text)
        FormPerpustakaan.DataPerpus.GSlokasi = TbLokasiRak.Text.ToString()
        FormPerpustakaan.DataPerpus.GStanggalMasuk = DtpTanggal.Value.ToString("yyyy/MM/dd")
        FormPerpustakaan.DataPerpus.GSstok = Integer.Parse(TbStok.Text)

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
        FormPerpustakaan.DataPerpus.UpdateDataKoleksiByIDDatabase(
        FormPerpustakaan.selectedTableKoleksi,
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
        Dim infoTambah = New FormInfoKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub
End Class