Imports MySql.Data.MySqlClient

Public Class Pelanggan_Keranjang

    Dim dataAwal As Integer = 0
    Dim batasDataHalaman As Integer = 5
    Dim alamat As String = CurDir() + "\gambar\barang\"
    Dim langkah As Integer = 0
    Private Sub Pelanggan_Keranjang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readDB()
    End Sub

    Sub refreshPage()
        dataAwal = 0
        langkah = 0
    End Sub
    Private Function getRowCount() As Integer
        Call koneksi()
        DA = New MySqlDataAdapter("select * from tbkeranjang join tbkeranjang_item join tbakun join tbbarang on tbkeranjang.id=tbkeranjang_item.idkeranjang and tbkeranjang.id_user=tbakun.id and tbkeranjang_item.idbarang=tbbarang.id where tbakun.id = '" & Pelanggan_Main.Id & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        Return DS.Tables(0).Rows.Count
    End Function

    Sub totalBiaya()
        Call koneksi()
        CMD = New MySqlCommand("select sum(tbkeranjang_item.qty * tbbarang.harga) as 'total' from tbkeranjang_item join tbbarang on tbkeranjang_item.idbarang = tbbarang.id where tbkeranjang_item.idkeranjang = '" & Pelanggan_Main.idCart & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.IsDBNull(0) Then
            lbTotal.Text = RD.GetString(0)
        Else
            lbTotal.Text = "0"
        End If
        RD.Close()

    End Sub

    Sub addQty(ByVal idTambah As Integer)
        Dim tambah As String = "update tbkeranjang_item set qty=qty+1 where idbarang='" & idTambah & "' and idkeranjang='" & Pelanggan_Main.idCart & "'"
        Call koneksi()
        CMD = New MySqlCommand(tambah, CONN)
        CMD.ExecuteNonQuery()
        readDB()
    End Sub

    Sub minQty(ByVal idKurang As Integer)
        Dim kurang As String = "update tbkeranjang_item set qty=qty-1 where idbarang='" & idKurang & "' and idkeranjang='" & Pelanggan_Main.idCart & "'"
        Call koneksi()
        CMD = New MySqlCommand(kurang, CONN)
        CMD.ExecuteNonQuery()
        readDB()
    End Sub

    Sub cancelItem(ByVal idHapus As Integer)
        Dim hapus As String = "Delete from tbkeranjang_item where idbarang='" & idHapus & "' and idkeranjang='" & Pelanggan_Main.idCart & "'"
        Call koneksi()
        CMD = New MySqlCommand(hapus, CONN)
        CMD.ExecuteNonQuery()
        refreshPage()
        readDB()
    End Sub

    Function maxValue(ByVal addValue As Integer) As Integer
        Call koneksi()
        CMD = New MySqlCommand("select stok from tbbarang where id='" & addValue & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim stok As Integer = RD.GetString(0)
        Return stok
    End Function

    Sub readDB()
        Try
            cek()
            Call koneksi()
            DA = New MySqlDataAdapter("select tbkeranjang_item.idbarang as 'id', tbbarang.nama as 'item', tbbarang.foto as 'foto', tbkeranjang_item.qty as 'qty', (tbkeranjang_item.qty * tbbarang.harga) as 'total' from tbkeranjang join tbkeranjang_item join tbakun join tbbarang on tbkeranjang.id=tbkeranjang_item.idkeranjang and tbkeranjang.id_user=tbakun.id and tbkeranjang_item.idbarang=tbbarang.id where tbkeranjang.id = '" & Pelanggan_Main.idCart & "'", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, langkah, batasDataHalaman, "item")
            dgvKeranjang.DataSource = DS.Tables(0)
            Item1.Visible = True
            Item2.Visible = True
            Item3.Visible = True
            Item4.Visible = True
            Item5.Visible = True
            lbKosong.Visible = False
            If dgvKeranjang.RowCount = 5 Then
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(4).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(4).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(2).Value.ToString
                lbItem3.Text = dgvKeranjang.Rows(2).Cells(1).Value.ToString
                lbHarga3.Text = dgvKeranjang.Rows(2).Cells(4).Value.ToString
                lbQty3.Text = dgvKeranjang.Rows(2).Cells(3).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvKeranjang.Rows(2).Cells(2).Value.ToString
                lbItem4.Text = dgvKeranjang.Rows(3).Cells(1).Value.ToString
                lbHarga4.Text = dgvKeranjang.Rows(3).Cells(4).Value.ToString
                lbQty4.Text = dgvKeranjang.Rows(3).Cells(3).Value.ToString
                PictureBox4.ImageLocation = alamat + dgvKeranjang.Rows(3).Cells(2).Value.ToString
                lbItem5.Text = dgvKeranjang.Rows(4).Cells(1).Value.ToString
                lbHarga5.Text = dgvKeranjang.Rows(4).Cells(4).Value.ToString
                lbQty5.Text = dgvKeranjang.Rows(4).Cells(3).Value.ToString
                PictureBox5.ImageLocation = alamat + dgvKeranjang.Rows(4).Cells(2).Value.ToString
            ElseIf dgvKeranjang.RowCount = 4 Then
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(4).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(4).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(2).Value.ToString
                lbItem3.Text = dgvKeranjang.Rows(2).Cells(1).Value.ToString
                lbHarga3.Text = dgvKeranjang.Rows(2).Cells(4).Value.ToString
                lbQty3.Text = dgvKeranjang.Rows(2).Cells(3).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvKeranjang.Rows(2).Cells(2).Value.ToString
                lbItem4.Text = dgvKeranjang.Rows(3).Cells(1).Value.ToString
                lbHarga4.Text = dgvKeranjang.Rows(3).Cells(4).Value.ToString
                lbQty4.Text = dgvKeranjang.Rows(3).Cells(3).Value.ToString
                PictureBox4.ImageLocation = alamat + dgvKeranjang.Rows(3).Cells(2).Value.ToString
                Item5.Visible = False
            ElseIf dgvKeranjang.RowCount = 3 Then
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(4).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(4).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(2).Value.ToString
                lbItem3.Text = dgvKeranjang.Rows(2).Cells(1).Value.ToString
                lbHarga3.Text = dgvKeranjang.Rows(2).Cells(4).Value.ToString
                lbQty3.Text = dgvKeranjang.Rows(2).Cells(3).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvKeranjang.Rows(2).Cells(2).Value.ToString
                Item4.Visible = False
                Item5.Visible = False
            ElseIf dgvKeranjang.RowCount = 2 Then
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(4).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(4).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(2).Value.ToString
                Item3.Visible = False
                Item4.Visible = False
                Item5.Visible = False
            ElseIf dgvKeranjang.RowCount = 1 Then
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(4).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(2).Value.ToString
                Item2.Visible = False
                Item3.Visible = False
                Item4.Visible = False
                Item5.Visible = False
            Else
                lbKosong.Visible = True
                Item1.Visible = False
                Item2.Visible = False
                Item3.Visible = False
                Item4.Visible = False
                Item5.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cek()
        totalBiaya()
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
        ElseIf dataAwal > dgvKeranjang.RowCount Then
            btnDown.Enabled = False

        Else
            btnUp.Enabled = True
            btnDown.Enabled = True
        End If
    End Sub

    Sub cart2Checkout()
        Call koneksi()
        DA = New MySqlDataAdapter("select tbbarang.nama as 'item', tbkeranjang_item.qty as 'qty', tbbarang.harga as 'harga', tbbarang.foto as 'foto', tbbarang.id as 'idBarang' from tbkeranjang join tbkeranjang_item join tbakun join tbbarang on tbkeranjang.id=tbkeranjang_item.idkeranjang and tbkeranjang.id_user=tbakun.id and tbkeranjang_item.idbarang=tbbarang.id where tbkeranjang.id = '" & Pelanggan_Main.idCart & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "CartToCheckout")
        dgvLemparData.DataSource = DS.Tables(0)
    End Sub
    Sub checkOut()
        Dim tanggal As String = DateTime.Now.ToString("dd/MMMM/yyyy", New System.Globalization.CultureInfo("id-ID"))
        cart2Checkout()
        Call koneksi()
        CMD = New MySqlCommand("insert into tbtransaksi (id, id_user, tanggal, status) values('" & Pelanggan_Main.idCart & "', '" & Pelanggan_Main.Id & "', '" & tanggal & "', 'SEDANG DIPROSES')", CONN)
        CMD.ExecuteNonQuery()
        For Each row As DataGridViewRow In dgvLemparData.Rows
            Dim itemBarang As String = row.Cells(0).Value
            Dim qtyBarang As Integer = row.Cells(1).Value
            Dim hargaBarang As Integer = row.Cells(2).Value
            Dim fotoBarang As String = row.Cells(3).Value
            Dim idBarangQ As Integer = row.Cells(4).Value
            CMD = New MySqlCommand("insert into tbtransaksi_item(idtransaksi, item, qty, harga, foto, idBarang) values('" & Pelanggan_Main.idCart & "', '" & itemBarang & "', '" & qtyBarang & "', '" & hargaBarang & "', '" & fotoBarang & "', '" & idBarangQ & "')", CONN)
            CMD.ExecuteNonQuery()
            CMD = New MySqlCommand("update tbbarang set stok = stok - " & qtyBarang & " where id='" & idBarangQ & "'", CONN)
            CMD.ExecuteNonQuery()
        Next
        CMD = New MySqlCommand("delete from tbkeranjang_item where idkeranjang='" & Pelanggan_Main.idCart & "';delete from tbkeranjang where id = '" & Pelanggan_Main.idCart & "'", CONN)
        CMD.ExecuteNonQuery()
        Pelanggan_Barang.readDB()
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

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Dim parameterQ As Integer = dgvKeranjang.Rows(0).Cells(0).Value.ToString
        addQty(parameterQ)
        If lbQty1.Text = maxValue(parameterQ) Then
            btnAdd1.Enabled = False
        End If

    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Dim parameterQ As Integer = dgvKeranjang.Rows(1).Cells(0).Value.ToString
        addQty(parameterQ)
        If lbQty2.Text = maxValue(parameterQ) Then
            btnAdd2.Enabled = False
        End If
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        Dim parameterQ As Integer = dgvKeranjang.Rows(2).Cells(0).Value.ToString
        addQty(parameterQ)
        If lbQty3.Text = maxValue(parameterQ) Then
            btnAdd3.Enabled = False
        End If
    End Sub

    Private Sub btnAdd4_Click(sender As Object, e As EventArgs) Handles btnAdd4.Click
        Dim parameterQ As Integer = dgvKeranjang.Rows(3).Cells(0).Value.ToString
        addQty(parameterQ)
        If lbQty4.Text = maxValue(parameterQ) Then
            btnAdd4.Enabled = False
        End If
    End Sub

    Private Sub btnAdd5_Click(sender As Object, e As EventArgs) Handles btnAdd5.Click
        Dim parameterQ As Integer = dgvKeranjang.Rows(4).Cells(0).Value.ToString
        addQty(parameterQ)
        If lbQty5.Text = maxValue(parameterQ) Then
            btnAdd5.Enabled = False
        End If
    End Sub

    Private Sub btnMin1_Click(sender As Object, e As EventArgs) Handles btnMin1.Click
        If lbQty1.Text = 1 Then
            Dim cancel As String
            cancel = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cancel = MsgBoxResult.Yes Then
                cancelItem(dgvKeranjang.Rows(0).Cells(0).Value.ToString)
            End If
        Else
            minQty(dgvKeranjang.Rows(0).Cells(0).Value.ToString)
        End If
        btnAdd1.Enabled = True
    End Sub

    Private Sub btnMin2_Click(sender As Object, e As EventArgs) Handles btnMin2.Click
        If lbQty2.Text = 1 Then
            Dim cancel As String
            cancel = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cancel = MsgBoxResult.Yes Then
                cancelItem(dgvKeranjang.Rows(1).Cells(0).Value.ToString)
            End If
        Else
            minQty(dgvKeranjang.Rows(1).Cells(0).Value.ToString)
        End If
        btnAdd2.Enabled = True
    End Sub

    Private Sub btnMin3_Click(sender As Object, e As EventArgs) Handles btnMin3.Click
        If lbQty3.Text = 1 Then
            Dim cancel As String
            cancel = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cancel = MsgBoxResult.Yes Then
                cancelItem(dgvKeranjang.Rows(2).Cells(0).Value.ToString)
            End If
        Else
            minQty(dgvKeranjang.Rows(2).Cells(0).Value.ToString)
        End If
        btnAdd3.Enabled = True
    End Sub

    Private Sub btnMin4_Click(sender As Object, e As EventArgs) Handles btnMin4.Click
        If lbQty4.Text = 1 Then
            Dim cancel As String
            cancel = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cancel = MsgBoxResult.Yes Then
                cancelItem(dgvKeranjang.Rows(3).Cells(0).Value.ToString)
            End If
        Else
            minQty(dgvKeranjang.Rows(3).Cells(0).Value.ToString)
        End If
        btnAdd4.Enabled = True
    End Sub

    Private Sub btnMin5_Click(sender As Object, e As EventArgs) Handles btnMin5.Click
        If lbQty5.Text = 1 Then
            Dim cancel As String
            cancel = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cancel = MsgBoxResult.Yes Then
                cancelItem(dgvKeranjang.Rows(4).Cells(0).Value.ToString)
            End If
        Else
            minQty(dgvKeranjang.Rows(4).Cells(0).Value.ToString)
        End If
        btnAdd5.Enabled = True
    End Sub

    Private Sub btnRm1_Click(sender As Object, e As EventArgs) Handles btnRm1.Click
        cancelItem(dgvKeranjang.Rows(0).Cells(0).Value.ToString)
        btnAdd1.Enabled = True
    End Sub

    Private Sub btnRm2_Click(sender As Object, e As EventArgs) Handles btnRm2.Click
        cancelItem(dgvKeranjang.Rows(1).Cells(0).Value.ToString)
        btnAdd2.Enabled = True
    End Sub

    Private Sub btnRm3_Click(sender As Object, e As EventArgs) Handles btnRm3.Click
        cancelItem(dgvKeranjang.Rows(2).Cells(0).Value.ToString)
        btnAdd3.Enabled = True
    End Sub

    Private Sub btnRm4_Click(sender As Object, e As EventArgs) Handles btnRm4.Click
        cancelItem(dgvKeranjang.Rows(3).Cells(0).Value.ToString)
        btnAdd4.Enabled = True
    End Sub

    Private Sub btnRm5_Click(sender As Object, e As EventArgs) Handles btnRm5.Click
        cancelItem(dgvKeranjang.Rows(4).Cells(0).Value.ToString)
        btnAdd5.Enabled = True
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If lbTotal.Text > 0 Then
            checkOut()
            Pelanggan_Main.AdaCart()
            Pelanggan_Main.btnTransaksi.PerformClick()
        End If
    End Sub
End Class