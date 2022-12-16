Public Class FormHapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapus.Text() = FormPerpustakaan.selectedTableKoleksiNama

    End Sub

    Private Sub LblHapus_Click(sender As Object, e As EventArgs) Handles LblHapus.Click

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        'FormPerpustakaan.ListBoxKoleksi.Items.Remove(FormPerpustakaan.ListBoxKoleksi.SelectedItem)

        FormPerpustakaan.DataPerpus.DeleteDataKoleksiByIDDatabase(FormPerpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class