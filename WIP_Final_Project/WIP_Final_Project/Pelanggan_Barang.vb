Imports MySql.Data.MySqlClient

Public Class Pelanggan_Barang

    Dim dataAwal As Integer = 0
    Dim batasDataHalaman As Integer = 4
    Dim alamat As String = CurDir() + "\gambar\barang\"
    Private Sub Pelanggan_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readDB()
        'dgvDataBarang.Visible = True
    End Sub

    Private Function getRowCount() As Integer
        Call koneksi()
        DA = New MySqlDataAdapter("select * from tbbarang", CONN)
        DS = New DataSet
        DA.Fill(DS)
        Return DS.Tables(0).Rows.Count
    End Function

    Sub readDB()
        Try
            cek()
            Call koneksi()
            DA = New MySqlDataAdapter("select * from tbbarang", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, dataAwal, batasDataHalaman, "barang")
            dgvDataBarang.DataSource = DS.Tables(0)
            barang1.Visible = True
            barang2.Visible = True
            barang3.Visible = True
            barang4.Visible = True
            If dgvDataBarang.RowCount = 4 Then
                lbNama.Text = dgvDataBarang.Rows(0).Cells(1).Value.ToString
                lbHarga.Text = dgvDataBarang.Rows(0).Cells(5).Value.ToString
                idBarang.Text = dgvDataBarang.Rows(0).Cells(0).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvDataBarang.Rows(0).Cells(7).Value.ToString
                lbNama2.Text = dgvDataBarang.Rows(1).Cells(1).Value.ToString
                lbHarga2.Text = dgvDataBarang.Rows(1).Cells(5).Value.ToString
                idBarang2.Text = dgvDataBarang.Rows(1).Cells(0).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvDataBarang.Rows(1).Cells(7).Value.ToString
                lbNama3.Text = dgvDataBarang.Rows(2).Cells(1).Value.ToString
                lbHarga3.Text = dgvDataBarang.Rows(2).Cells(5).Value.ToString
                idBarang3.Text = dgvDataBarang.Rows(2).Cells(0).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvDataBarang.Rows(2).Cells(7).Value.ToString
                lbNama4.Text = dgvDataBarang.Rows(3).Cells(1).Value.ToString
                lbHarga4.Text = dgvDataBarang.Rows(3).Cells(5).Value.ToString
                idBarang4.Text = dgvDataBarang.Rows(3).Cells(0).Value.ToString
                PictureBox4.ImageLocation = alamat + dgvDataBarang.Rows(3).Cells(7).Value.ToString
            ElseIf dgvDataBarang.RowCount = 3 Then
                lbNama.Text = dgvDataBarang.Rows(0).Cells(1).Value.ToString
                lbHarga.Text = dgvDataBarang.Rows(0).Cells(5).Value.ToString
                idBarang.Text = dgvDataBarang.Rows(0).Cells(0).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvDataBarang.Rows(0).Cells(7).Value.ToString
                lbNama2.Text = dgvDataBarang.Rows(1).Cells(1).Value.ToString
                lbHarga2.Text = dgvDataBarang.Rows(1).Cells(5).Value.ToString
                idBarang2.Text = dgvDataBarang.Rows(1).Cells(0).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvDataBarang.Rows(1).Cells(7).Value.ToString
                lbNama3.Text = dgvDataBarang.Rows(2).Cells(1).Value.ToString
                lbHarga3.Text = dgvDataBarang.Rows(2).Cells(5).Value.ToString
                idBarang3.Text = dgvDataBarang.Rows(2).Cells(0).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvDataBarang.Rows(2).Cells(7).Value.ToString
                barang4.Visible = False
            ElseIf dgvDataBarang.RowCount = 2 Then
                lbNama.Text = dgvDataBarang.Rows(0).Cells(1).Value.ToString
                lbHarga.Text = dgvDataBarang.Rows(0).Cells(5).Value.ToString
                idBarang.Text = dgvDataBarang.Rows(0).Cells(0).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvDataBarang.Rows(0).Cells(7).Value.ToString
                lbNama2.Text = dgvDataBarang.Rows(1).Cells(1).Value.ToString
                lbHarga2.Text = dgvDataBarang.Rows(1).Cells(5).Value.ToString
                idBarang2.Text = dgvDataBarang.Rows(1).Cells(0).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvDataBarang.Rows(1).Cells(7).Value.ToString
                barang3.Visible = False
                barang4.Visible = False
            ElseIf dgvDataBarang.RowCount = 1 Then
                lbNama.Text = dgvDataBarang.Rows(0).Cells(1).Value.ToString
                lbHarga.Text = dgvDataBarang.Rows(0).Cells(5).Value.ToString
                idBarang.Text = dgvDataBarang.Rows(0).Cells(0).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvDataBarang.Rows(0).Cells(7).Value.ToString
                barang2.Visible = False
                barang3.Visible = False
                barang4.Visible = False
            Else
                lbKosong.Visible = True
                barang1.Visible = False
                barang2.Visible = False
                barang3.Visible = False
                barang4.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cek()
    End Sub

    Sub cek()
        Dim dataAkhir As Integer = getRowCount()
        If dataAwal = 0 Then
            If batasDataHalaman > getRowCount() Or batasDataHalaman = getRowCount() Then
                btnNext.Enabled = False
            Else
                btnNext.Enabled = True
            End If
            btnPrev.Enabled = False
        ElseIf dataAwal > dataAkhir Then
            btnNext.Enabled = False
        ElseIf dataAwal > dgvDataBarang.RowCount Then
            btnNext.Enabled = False
        Else
            btnPrev.Enabled = True
            btnNext.Enabled = True
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        dataAwal = dataAwal + batasDataHalaman
        readDB()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Pelanggan_Main.topLabel.Text = "Detail Barang________________"
        Pelanggan_Main.pnCanvas.Controls.Clear()
        With Pelanggan_DetailBarang
            .TopLevel = False
            Pelanggan_Main.pnCanvas.Controls.Add(Pelanggan_DetailBarang)
            .BringToFront()
            .Show()
        End With
        Pelanggan_DetailBarang.idBarang = idBarang.Text
        Pelanggan_DetailBarang.lbNama.Text = dgvDataBarang.Rows(0).Cells(1).Value.ToString
        Pelanggan_DetailBarang.lbHarga.Text = dgvDataBarang.Rows(0).Cells(5).Value.ToString
        Pelanggan_DetailBarang.lbTipe.Text = dgvDataBarang.Rows(0).Cells(2).Value.ToString
        Pelanggan_DetailBarang.lbJenis.Text = dgvDataBarang.Rows(0).Cells(3).Value.ToString
        Pelanggan_DetailBarang.txtDesk.Text = dgvDataBarang.Rows(0).Cells(6).Value.ToString
        Pelanggan_DetailBarang.pbBarang.ImageLocation = alamat + dgvDataBarang.Rows(0).Cells(7).Value.ToString
        Pelanggan_DetailBarang.lbStok.Text = dgvDataBarang.Rows(0).Cells(4).Value.ToString
        Pelanggan_DetailBarang.cek()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Pelanggan_Main.topLabel.Text = "Detail Barang________________"
        Pelanggan_Main.pnCanvas.Controls.Clear()
        With Pelanggan_DetailBarang
            .TopLevel = False
            Pelanggan_Main.pnCanvas.Controls.Add(Pelanggan_DetailBarang)
            .BringToFront()
            .Show()
        End With
        Pelanggan_DetailBarang.idBarang = idBarang2.Text
        Pelanggan_DetailBarang.lbNama.Text = dgvDataBarang.Rows(1).Cells(1).Value.ToString
        Pelanggan_DetailBarang.lbHarga.Text = dgvDataBarang.Rows(1).Cells(5).Value.ToString
        Pelanggan_DetailBarang.lbTipe.Text = dgvDataBarang.Rows(1).Cells(2).Value.ToString
        Pelanggan_DetailBarang.lbJenis.Text = dgvDataBarang.Rows(1).Cells(3).Value.ToString
        Pelanggan_DetailBarang.txtDesk.Text = dgvDataBarang.Rows(1).Cells(6).Value.ToString
        Pelanggan_DetailBarang.pbBarang.ImageLocation = alamat + dgvDataBarang.Rows(1).Cells(7).Value.ToString
        Pelanggan_DetailBarang.lbStok.Text = dgvDataBarang.Rows(1).Cells(4).Value.ToString
        Pelanggan_DetailBarang.cek()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Pelanggan_Main.topLabel.Text = "Detail Barang________________"
        Pelanggan_Main.pnCanvas.Controls.Clear()
        With Pelanggan_DetailBarang
            .TopLevel = False
            Pelanggan_Main.pnCanvas.Controls.Add(Pelanggan_DetailBarang)
            .BringToFront()
            .Show()
        End With
        Pelanggan_DetailBarang.idBarang = idBarang3.Text
        Pelanggan_DetailBarang.lbNama.Text = dgvDataBarang.Rows(2).Cells(1).Value.ToString
        Pelanggan_DetailBarang.lbHarga.Text = dgvDataBarang.Rows(2).Cells(5).Value.ToString
        Pelanggan_DetailBarang.lbTipe.Text = dgvDataBarang.Rows(2).Cells(2).Value.ToString
        Pelanggan_DetailBarang.lbJenis.Text = dgvDataBarang.Rows(2).Cells(3).Value.ToString
        Pelanggan_DetailBarang.txtDesk.Text = dgvDataBarang.Rows(2).Cells(6).Value.ToString
        Pelanggan_DetailBarang.pbBarang.ImageLocation = alamat + dgvDataBarang.Rows(2).Cells(7).Value.ToString
        Pelanggan_DetailBarang.lbStok.Text = dgvDataBarang.Rows(2).Cells(4).Value.ToString
        Pelanggan_DetailBarang.cek()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Pelanggan_Main.topLabel.Text = "Detail Barang________________"
        Pelanggan_Main.pnCanvas.Controls.Clear()
        With Pelanggan_DetailBarang
            .TopLevel = False
            Pelanggan_Main.pnCanvas.Controls.Add(Pelanggan_DetailBarang)
            .BringToFront()
            .Show()
        End With
        Pelanggan_DetailBarang.idBarang = idBarang4.Text
        Pelanggan_DetailBarang.lbNama.Text = dgvDataBarang.Rows(3).Cells(1).Value.ToString
        Pelanggan_DetailBarang.lbHarga.Text = dgvDataBarang.Rows(3).Cells(5).Value.ToString
        Pelanggan_DetailBarang.lbTipe.Text = dgvDataBarang.Rows(3).Cells(2).Value.ToString
        Pelanggan_DetailBarang.lbJenis.Text = dgvDataBarang.Rows(3).Cells(3).Value.ToString
        Pelanggan_DetailBarang.txtDesk.Text = dgvDataBarang.Rows(3).Cells(6).Value.ToString
        Pelanggan_DetailBarang.pbBarang.ImageLocation = alamat + dgvDataBarang.Rows(3).Cells(7).Value.ToString
        Pelanggan_DetailBarang.lbStok.Text = dgvDataBarang.Rows(3).Cells(4).Value.ToString
        Pelanggan_DetailBarang.cek()
    End Sub
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        dataAwal = dataAwal - batasDataHalaman
        readDB()
    End Sub


End Class