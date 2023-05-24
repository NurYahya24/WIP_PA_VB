Imports MySql.Data.MySqlClient

Public Class Owner_Transaksi
    Dim dataAwal As Integer = 0
    Dim batasDataHalaman As Integer = 4
    Dim langkah As Integer = 0
    Dim statusBarang As String
    Dim alamatProfil = CurDir() + "\gambar\profil\"

    Sub refreshPage()
        dataAwal = 0
        langkah = 0
    End Sub

    Private Function getRowCount() As Integer
        Call koneksi()
        DA = New MySqlDataAdapter("select * from tbtransaksi join tbakun on tbtransaksi.id_user = tbakun.id " + statusBarang + "group by tbtransaksi.id", CONN)
        DS = New DataSet
        DA.Fill(DS)
        Return DS.Tables(0).Rows.Count
    End Function

    Sub readDB()
        Try
            cek()
            Call koneksi()
            DA = New MySqlDataAdapter("select tbtransaksi.tanggal as 'tanggal', tbtransaksi.status as 'status', tbakun.nama as 'nama', tbakun.alamat as 'alamat', tbtransaksi.id as 'id', sum(tbtransaksi_item.qty * tbtransaksi_item.harga) as 'total', tbakun.foto as 'foto' from tbtransaksi join tbtransaksi_item join tbakun on tbtransaksi.id = tbtransaksi_item.idtransaksi and tbtransaksi.id_user = tbakun.id " + statusBarang + "group by tbtransaksi.id", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, langkah, batasDataHalaman, "transaksi")
            dgvDataTransaksi.DataSource = DS.Tables(0)
            transaksi1.Visible = True
            transaksi2.Visible = True
            transaksi3.Visible = True
            transaksi4.Visible = True
            lbKosong.Visible = False
            If dgvDataTransaksi.RowCount = 4 Then
                lbTanggal1.Text = dgvDataTransaksi.Rows(0).Cells(0).Value.ToString
                lbStatus1.Text = dgvDataTransaksi.Rows(0).Cells(1).Value.ToString
                lbNama1.Text = dgvDataTransaksi.Rows(0).Cells(2).Value.ToString
                lbAlamat1.Text = dgvDataTransaksi.Rows(0).Cells(3).Value.ToString
                lbId1.Text = dgvDataTransaksi.Rows(0).Cells(4).Value.ToString
                lbHarga1.Text = dgvDataTransaksi.Rows(0).Cells(5).Value.ToString
                lbTanggal2.Text = dgvDataTransaksi.Rows(1).Cells(0).Value.ToString
                lbStatus2.Text = dgvDataTransaksi.Rows(1).Cells(1).Value.ToString
                lbNama2.Text = dgvDataTransaksi.Rows(1).Cells(2).Value.ToString
                lbAlamat2.Text = dgvDataTransaksi.Rows(1).Cells(3).Value.ToString
                lbId2.Text = dgvDataTransaksi.Rows(1).Cells(4).Value.ToString
                lbHarga2.Text = dgvDataTransaksi.Rows(1).Cells(5).Value.ToString
                lbTanggal3.Text = dgvDataTransaksi.Rows(2).Cells(0).Value.ToString
                lbStatus3.Text = dgvDataTransaksi.Rows(2).Cells(1).Value.ToString
                lbNama3.Text = dgvDataTransaksi.Rows(2).Cells(2).Value.ToString
                lbAlamat3.Text = dgvDataTransaksi.Rows(2).Cells(3).Value.ToString
                lbId3.Text = dgvDataTransaksi.Rows(2).Cells(4).Value.ToString
                lbHarga3.Text = dgvDataTransaksi.Rows(2).Cells(5).Value.ToString
                lbTanggal4.Text = dgvDataTransaksi.Rows(3).Cells(0).Value.ToString
                lbStatus4.Text = dgvDataTransaksi.Rows(3).Cells(1).Value.ToString
                lbNama4.Text = dgvDataTransaksi.Rows(3).Cells(2).Value.ToString
                lbAlamat4.Text = dgvDataTransaksi.Rows(3).Cells(3).Value.ToString
                lbId4.Text = dgvDataTransaksi.Rows(3).Cells(4).Value.ToString
                lbHarga4.Text = dgvDataTransaksi.Rows(3).Cells(5).Value.ToString
            ElseIf dgvDataTransaksi.RowCount = 3 Then
                lbTanggal1.Text = dgvDataTransaksi.Rows(0).Cells(0).Value.ToString
                lbStatus1.Text = dgvDataTransaksi.Rows(0).Cells(1).Value.ToString
                lbNama1.Text = dgvDataTransaksi.Rows(0).Cells(2).Value.ToString
                lbAlamat1.Text = dgvDataTransaksi.Rows(0).Cells(3).Value.ToString
                lbId1.Text = dgvDataTransaksi.Rows(0).Cells(4).Value.ToString
                lbHarga1.Text = dgvDataTransaksi.Rows(0).Cells(5).Value.ToString
                lbTanggal2.Text = dgvDataTransaksi.Rows(1).Cells(0).Value.ToString
                lbStatus2.Text = dgvDataTransaksi.Rows(1).Cells(1).Value.ToString
                lbNama2.Text = dgvDataTransaksi.Rows(1).Cells(2).Value.ToString
                lbAlamat2.Text = dgvDataTransaksi.Rows(1).Cells(3).Value.ToString
                lbId2.Text = dgvDataTransaksi.Rows(1).Cells(4).Value.ToString
                lbHarga2.Text = dgvDataTransaksi.Rows(1).Cells(5).Value.ToString
                lbTanggal3.Text = dgvDataTransaksi.Rows(2).Cells(0).Value.ToString
                lbStatus3.Text = dgvDataTransaksi.Rows(2).Cells(1).Value.ToString
                lbNama3.Text = dgvDataTransaksi.Rows(2).Cells(2).Value.ToString
                lbAlamat3.Text = dgvDataTransaksi.Rows(2).Cells(3).Value.ToString
                lbId3.Text = dgvDataTransaksi.Rows(2).Cells(4).Value.ToString
                lbHarga3.Text = dgvDataTransaksi.Rows(2).Cells(5).Value.ToString
                transaksi4.Visible = False
            ElseIf dgvDataTransaksi.RowCount = 2 Then
                lbTanggal1.Text = dgvDataTransaksi.Rows(0).Cells(0).Value.ToString
                lbStatus1.Text = dgvDataTransaksi.Rows(0).Cells(1).Value.ToString
                lbNama1.Text = dgvDataTransaksi.Rows(0).Cells(2).Value.ToString
                lbAlamat1.Text = dgvDataTransaksi.Rows(0).Cells(3).Value.ToString
                lbId1.Text = dgvDataTransaksi.Rows(0).Cells(4).Value.ToString
                lbHarga1.Text = dgvDataTransaksi.Rows(0).Cells(5).Value.ToString
                lbTanggal2.Text = dgvDataTransaksi.Rows(1).Cells(0).Value.ToString
                lbStatus2.Text = dgvDataTransaksi.Rows(1).Cells(1).Value.ToString
                lbNama2.Text = dgvDataTransaksi.Rows(1).Cells(2).Value.ToString
                lbAlamat2.Text = dgvDataTransaksi.Rows(1).Cells(3).Value.ToString
                lbId2.Text = dgvDataTransaksi.Rows(1).Cells(4).Value.ToString
                lbHarga2.Text = dgvDataTransaksi.Rows(1).Cells(5).Value.ToString
                transaksi3.Visible = False
                transaksi4.Visible = False
            ElseIf dgvDataTransaksi.RowCount = 1 Then
                If dgvDataTransaksi.Rows(0).Cells(0).Value.ToString = "" Then
                    lbKosong.Visible = True
                    transaksi1.Visible = False
                Else

                    lbTanggal1.Text = dgvDataTransaksi.Rows(0).Cells(0).Value.ToString
                    lbStatus1.Text = dgvDataTransaksi.Rows(0).Cells(1).Value.ToString
                    lbNama1.Text = dgvDataTransaksi.Rows(0).Cells(2).Value.ToString
                    lbAlamat1.Text = dgvDataTransaksi.Rows(0).Cells(3).Value.ToString
                    lbId1.Text = dgvDataTransaksi.Rows(0).Cells(4).Value.ToString
                    lbHarga1.Text = dgvDataTransaksi.Rows(0).Cells(5).Value.ToString
                End If
                transaksi2.Visible = False
                transaksi3.Visible = False
                transaksi4.Visible = False
            Else
                lbKosong.Visible = True
                transaksi1.Visible = False
                transaksi2.Visible = False
                transaksi3.Visible = False
                transaksi4.Visible = False
            End If
            warnaHeader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cek()
    End Sub

    Sub warnaHeader()
        If lbStatus1.Text = "SEDANG DIPROSES" Then
            header1.BackColor = Color.DodgerBlue
        ElseIf lbStatus1.Text = "SELESAI" Then
            header1.BackColor = Color.YellowGreen
        ElseIf lbStatus1.Text = "REQUEST BATAL" Then
            header1.BackColor = Color.Gold
        ElseIf lbStatus1.Text = "DIBATALKAN" Then
            header1.BackColor = Color.Red
        End If
        If lbStatus2.Text = "SEDANG DIPROSES" Then
            header2.BackColor = Color.DodgerBlue
        ElseIf lbStatus2.Text = "SELESAI" Then
            header2.BackColor = Color.YellowGreen
        ElseIf lbStatus2.Text = "REQUEST BATAL" Then
            header2.BackColor = Color.Gold
        ElseIf lbStatus2.Text = "DIBATALKAN" Then
            header2.BackColor = Color.Red
        End If
        If lbStatus3.Text = "SEDANG DIPROSES" Then
            header3.BackColor = Color.DodgerBlue
        ElseIf lbStatus3.Text = "SELESAI" Then
            header3.BackColor = Color.YellowGreen
        ElseIf lbStatus3.Text = "REQUEST BATAL" Then
            header3.BackColor = Color.Gold
        ElseIf lbStatus3.Text = "DIBATALKAN" Then
            header3.BackColor = Color.Red
        End If
        If lbStatus4.Text = "SEDANG DIPROSES" Then
            header4.BackColor = Color.DodgerBlue
        ElseIf lbStatus4.Text = "SELESAI" Then
            header4.BackColor = Color.YellowGreen
        ElseIf lbStatus4.Text = "REQUEST BATAL" Then
            header4.BackColor = Color.Gold
        ElseIf lbStatus4.Text = "DIBATALKAN" Then
            header4.BackColor = Color.Red
        End If

    End Sub

    Sub cek()
        Dim dataAkhir As Integer = getRowCount()
        If dataAwal = 0 Then
            If batasDataHalaman > getRowCount() Or batasDataHalaman = getRowCount() Then
                btnDown.Enabled = False
            Else
                btnDown.Enabled = True
            End If
            btnUp.Enabled = False
        ElseIf (dataAwal + langkah) > dataAkhir Or (dataAwal + langkah) = dataAkhir Then
            btnDown.Enabled = False
            btnUp.Enabled = True
        ElseIf dataAwal > dgvDataTransaksi.RowCount Then
            btnDown.Enabled = False

        Else
            btnUp.Enabled = True
            btnDown.Enabled = True
        End If
    End Sub
    Private Sub bntProses_Click(sender As Object, e As EventArgs) Handles bntProses.Click
        pnPemasukan.Visible = False
        pnProses.BackColor = Color.White
        pnSelesai.BackColor = Color.DodgerBlue
        pnLainnya.BackColor = Color.DodgerBlue
        statusBarang = "where tbtransaksi.status = 'SEDANG DIPROSES'"
        getRowCount()
        readDB()
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        pnPemasukan.Visible = True
        pnProses.BackColor = Color.DodgerBlue
        pnSelesai.BackColor = Color.White
        pnLainnya.BackColor = Color.DodgerBlue
        statusBarang = "where tbtransaksi.status = 'SELESAI'"
        Call koneksi()
        CMD = New MySqlCommand("select sum(tbtransaksi_item.qty * tbtransaksi_item.harga) from tbtransaksi join tbtransaksi_item on tbtransaksi.id=tbtransaksi_item.idtransaksi where tbtransaksi.status = 'SELESAI'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.IsDBNull(0) Then
            lbPemasukan.Text = 0
        Else
            lbPemasukan.Text = RD.GetString(0)
        End If
        getRowCount()
        readDB()
    End Sub

    Private Sub btnLainnya_Click(sender As Object, e As EventArgs) Handles btnLainnya.Click
        pnPemasukan.Visible = False
        pnProses.BackColor = Color.DodgerBlue
        pnSelesai.BackColor = Color.DodgerBlue
        pnLainnya.BackColor = Color.White
        statusBarang = "where tbtransaksi.status = 'REQUEST BATAL' or tbtransaksi.status = 'DIBATALKAN'"
        getRowCount()
        readDB()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        dataAwal = dataAwal - batasDataHalaman
        langkah = langkah - 1
        readDB()
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        dataAwal = dataAwal + batasDataHalaman
        langkah = langkah + 1
        readDB()
    End Sub

    Sub tampilData(ByVal idTrans As Integer)
        Owner_Main.pnCanvas.Controls.Clear()
        Owner_Main.topLabel.Text = "Detail Pesanan__________________"
        With Karyawan_DetailTransaksi
            .TopLevel = False
            Owner_Main.pnCanvas.Controls.Add(Karyawan_DetailTransaksi)
            .BringToFront()
            .Show()
        End With
        Karyawan_DetailTransaksi.idTransaksi = idTrans
        Karyawan_DetailTransaksi.refreshPage()
        Karyawan_DetailTransaksi.readDB()
        Karyawan_DetailTransaksi.btnSelesai.Visible = False
        Karyawan_DetailTransaksi.btnAcc.Visible = False
        Karyawan_DetailTransaksi.btnDec.Visible = False
    End Sub


    Private Sub lbStatus1_Click(sender As Object, e As EventArgs) Handles lbStatus1.Click
        tampilData(lbId1.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(0).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama1.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat1.Text
    End Sub

    Private Sub lbTanggal1_Click(sender As Object, e As EventArgs) Handles lbTanggal1.Click
        tampilData(lbId1.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(0).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama1.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat1.Text
    End Sub

    Private Sub lbTanggal2_Click(sender As Object, e As EventArgs) Handles lbTanggal2.Click
        tampilData(lbId2.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(1).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama2.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat2.Text
    End Sub

    Private Sub lbStatus2_Click(sender As Object, e As EventArgs) Handles lbStatus2.Click
        tampilData(lbId2.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(1).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama2.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat2.Text

    End Sub

    Private Sub lbStatus3_Click(sender As Object, e As EventArgs) Handles lbStatus3.Click
        tampilData(lbId3.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(2).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama3.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat3.Text
    End Sub

    Private Sub lbTanggal3_Click(sender As Object, e As EventArgs) Handles lbTanggal3.Click
        tampilData(lbId3.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(2).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama3.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat3.Text
    End Sub

    Private Sub lbTanggal4_Click(sender As Object, e As EventArgs) Handles lbTanggal4.Click
        tampilData(lbId4.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(3).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama4.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat4.Text
    End Sub

    Private Sub lbStatus4_Click(sender As Object, e As EventArgs) Handles lbStatus4.Click
        tampilData(lbId4.Text)
        Karyawan_DetailTransaksi.pbProfil.ImageLocation = alamatProfil + dgvDataTransaksi.Rows(3).Cells(6).Value.ToString
        Karyawan_DetailTransaksi.lbNamaUser.Text = lbNama4.Text
        Karyawan_DetailTransaksi.lbAlamat.Text = lbAlamat4.Text
    End Sub

End Class