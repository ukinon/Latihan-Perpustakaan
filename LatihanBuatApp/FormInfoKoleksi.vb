Public Class FormInfoKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If FormPerpustakaan.DataPerpus.GSFoto IsNot Nothing Then
            PictureBox1.Load(FormPerpustakaan.DataPerpus.GSFoto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNama.Text = FormPerpustakaan.DataPerpus.GSnama
        LblJenis.Text = FormPerpustakaan.DataPerpus.GSjenis
        LblDeskripsi.Text = FormPerpustakaan.DataPerpus.GSdeskripsi
        LblPenerbit.Text = FormPerpustakaan.DataPerpus.GSpenerbit
        LblTahunTerbit.Text = FormPerpustakaan.DataPerpus.GStahun
        LblLokasi.Text = FormPerpustakaan.DataPerpus.GSlokasi
        LblTanggalMasuk.Text = FormPerpustakaan.DataPerpus.GStanggalMasuk
        LblStok.Text = FormPerpustakaan.DataPerpus.GSstok
        LblBahasa.Text = FormPerpustakaan.DataPerpus.GSbahasa

        ListBoxKategori.Items.Clear()
        For Each kat In FormPerpustakaan.DataPerpus.GSkategori
            ListBoxKategori.Items.Add(kat)
        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LblLokasi.Click

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class