Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataPerpus
    Private namaKoleksi As String
    Private jenisKoleksi As String
    Private deskripsi As String
    Private penerbit As String
    Private tahunTerbit As String
    Private lokasiRak As String
    Private tanggalMasuk As String
    Private stok As String
    Private bahasa As String
    Private kategori As New List(Of String)
    Private foto As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Property GSnama() As String
        Get
            Return namaKoleksi
        End Get
        Set(value As String)
            namaKoleksi = value
        End Set
    End Property

    Public Property GSjenis() As String
        Get
            Return jenisKoleksi
        End Get
        Set(value As String)
            jenisKoleksi = value
        End Set
    End Property

    Public Property GSdeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSpenerbit() As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property

    Public Property GStahun() As String
        Get
            Return tahunTerbit
        End Get
        Set(value As String)
            tahunTerbit = value
        End Set
    End Property

    Public Property GSlokasi() As String
        Get
            Return lokasiRak
        End Get
        Set(value As String)
            lokasiRak = value
        End Set
    End Property

    Public Property GStanggalMasuk() As String
        Get
            Return tanggalMasuk
        End Get
        Set(value As String)
            tanggalMasuk = value
        End Set
    End Property

    Public Property GSstok() As String
        Get
            Return stok
        End Get
        Set(value As String)
            stok = value
        End Set
    End Property

    Public Property GSbahasa() As String
        Get
            Return bahasa
        End Get
        Set(value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSkategori() As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property

    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
        End Set
    End Property


    Private koleksiDataTable As New ArrayList()

    Public Function AddKoleksiDataTable(foto As String,
                                        namaKoleksi As String,
                                        jenisKoleksi As String,
                                        penerbit As String,
                                        deskripsi As String,
                                        tahunTerbit As String,
                                        lokasiRak As String,
                                        tanggalMasuk As String,
                                        stok As String,
                                        bahasa As String,
                                        kategori As String)
        koleksiDataTable.Add({
        foto, namaKoleksi, jenisKoleksi, penerbit, deskripsi, tahunTerbit, lokasiRak, tanggalMasuk, stok, bahasa, kategori
        })
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to List
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi as 'Nama Koleksi',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  penerbit AS 'Penerbit',
                                  tahun_terbit AS 'Tahun Terbit',
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                  lokasi AS 'Lokasi Rak',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa',
                                  kategori AS 'Kategori'
                                  FROM koleksi"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As Date,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI (nama_koleksi, dir_gambar,
                        deskripsi, penerbit, jenis_koleksi,
                        tahun_terbit, lokasi, tanggal_masuk_koleksi,
                        stock, bahasa, kategori) VALUE('" _
                        & nama_koleksi & "', '" _
                        & dir_gambar & "', '" _
                        & deskripsi_koleksi & "', '" _
                        & penerbit_koleksi & "', '" _
                        & jenis_koleksi & "',  '" _
                        & tahun_terbit & "', '" _
                        & lokasi_rak & "', '" _
                        & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                        & stock_koleksi & "', '" _
                        & bahasa_koleksi & "', '" _
                        & kategori_koleksi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'FormPerpustakaan.SqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime = " + "True" + ";" + "Allow Zero Datetime = " + "True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi,
                                  nama_koleksi ,
                                  dir_gambar,
                                  deskripsi,
                                  penerbit,
                                  jenis_koleksi,
                                  tahun_terbit,
                                  lokasi,
                                  tanggal_masuk_koleksi,
                                  stock,
                                  bahasa,
                                  kategori
                                  FROM koleksi
                                  WHERE id_koleksi='" & ID & "' "
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                        dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As Date,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)
        tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE KOLEKSI SET " &
                        "nama_koleksi= '" & nama_koleksi & "',  " &
                        "dir_gambar= '" & dir_gambar & "',  " &
                        "deskripsi= '" & deskripsi_koleksi & "',  " &
                        "penerbit= '" & penerbit_koleksi & "',  " &
                        "jenis_koleksi= '" & jenis_koleksi & "',  " &
                        "tahun_terbit= '" & tahun_terbit & "',  " &
                        "lokasi= '" & lokasi_rak & "',  " &
                        "tanggal_masuk_koleksi= '" & tanggal_masuk.ToString("yyyy/MM/dd") & "',  " &
                        "stock= '" & stock_koleksi & "',  " &
                        "bahasa= '" & bahasa_koleksi & "',  " &
                        "kategori= '" & kategori_koleksi & "'  " &
                        "WHERE id_koleksi= '" & ID & "'"
            Debug.Print(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'FormPerpustakaan.SqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi " &
                "WHERE id_koleksi='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex
        Finally
            dbConn.Dispose()
        End Try

    End Function
End Class
