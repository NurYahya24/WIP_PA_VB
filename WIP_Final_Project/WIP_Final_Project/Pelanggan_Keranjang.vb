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
End Class