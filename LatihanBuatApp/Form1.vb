Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

Public Class FormPerpustakaan
    Public Shared DataPerpus = New DataPerpus
    Public Shared selectedDataKoleksi
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Private koleksiDataTabel As New ArrayList()


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'UpdateDataTableArrayList()
    End Sub
    Private Sub FormPerpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub
    Public Sub UpdateDataTableArrayList()
        'DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In DataPerpus.getKoleksiDataTable()
            Dim dataTable As String() = {
            rowKoleksi(1),
            rowKoleksi(2),
            rowKoleksi(3),
            rowKoleksi(4),
            rowKoleksi(5),
            rowKoleksi(6),
            rowKoleksi(7),
            rowKoleksi(8),
            rowKoleksi(9),
            rowKoleksi(10),
            rowKoleksi(11)
            }
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        If ListBoxKoleksi.Items.Count = 0 Then
            MessageBox.Show("Tidak ada item yang tersedia")
        End If
        If ListBoxKoleksi.Items.Count > 0 Then
            If ListBoxKoleksi.SelectedItems.Count <= 0 Then
                MessageBox.Show("Pilih item yang ingin dihapus!")
            End If
            If ListBoxKoleksi.SelectedItems.Count > 0 Then

            End If
        End If

    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        FormTambahKoleksi.Show()
    End Sub

    Private Sub plsBtn_Click(sender As Object, e As EventArgs) Handles plsBtn.Click
        FormTambahKoleksi.Show()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedDataKoleksi = DataGridKoleksi.CurrentRow.Index

        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub showBtn_Click(sender As Object, e As EventArgs) Handles showBtn.Click
        Dim selectedKoleksi As List(Of String) = DataPerpus.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        DataPerpus.GSFoto = selectedKoleksi(2)

        DataPerpus.GSnama = selectedKoleksi(1)
        DataPerpus.GSjenis = selectedKoleksi(5)
        DataPerpus.GSdeskripsi = selectedKoleksi(3)
        DataPerpus.GSpenerbit = selectedKoleksi(4)
        DataPerpus.GStahun = selectedKoleksi(6)
        DataPerpus.GSlokasi = selectedKoleksi(7)
        DataPerpus.GStanggalMasuk = selectedKoleksi(8)
        DataPerpus.GSstok = selectedKoleksi(9)
        DataPerpus.GSbahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = DataPerpus.ConvertStringToKoleksi(selectedKoleksi(11))

        DataPerpus.GSKategori = data_kategori

        Dim InfoTambah = New FormInfoKoleksi()
        InfoTambah.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = DataPerpus.GetDataKoleksiDatabase()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedKoleksi As List(Of String) = DataPerpus.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        DataPerpus.GSFoto = selectedKoleksi(2)

        DataPerpus.GSnama = selectedKoleksi(1)
        DataPerpus.GSjenis = selectedKoleksi(5)
        DataPerpus.GSdeskripsi = selectedKoleksi(3)
        DataPerpus.GSpenerbit = selectedKoleksi(4)
        DataPerpus.GStahun = selectedKoleksi(6)
        DataPerpus.GSlokasi = selectedKoleksi(7)
        DataPerpus.GStanggalMasuk = selectedKoleksi(8)
        DataPerpus.GSstok = selectedKoleksi(9)
        DataPerpus.GSbahasa = selectedKoleksi(10)
        Dim data_kategori As New List(Of String)
        data_kategori = DataPerpus.ConvertStringToKoleksi(selectedKoleksi(11))
        'For Each info_kategori In data_kategori
        '    MessageBox.Show(info_kategori)
        'Next
        DataPerpus.GSkategori = data_kategori


        Dim formUpdate = New FormUpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        Dim formHapus = New FormHapusKoleksi()
        formHapus.Show()
    End Sub
End Class
