Imports MySql.Data.MySqlClient
Imports System.Reflection

Public Class Pelanggan_DetailTransaksi
    Dim dataAwal As Integer = 0
    Dim batasDataHalaman As Integer = 5
    Dim alamat As String = CurDir() + "\gambar\barang\"
    Dim langkah As Integer = 0
    Public Property idTransaksi As Integer
    Sub refreshPage()
        dataAwal = 0
        langkah = 0
    End Sub
    Private Function getRowCount() As Integer
        Call koneksi()
        DA = New MySqlDataAdapter("select tbtransaksi_item.foto as 'foto', tbtransaksi_item.item as 'item', tbtransaksi_item.qty as 'qty', (tbtransaksi_item.qty * tbtransaksi_item.harga) as 'total' from tbtransaksi join tbtransaksi_item on tbtransaksi.id=tbtransaksi_item.idtransaksi where tbtransaksi.id = '" & idTransaksi & "' ", CONN)
        DS = New DataSet
        DA.Fill(DS)
        Return DS.Tables(0).Rows.Count
    End Function

    Sub prosesPesanan(ByVal statusT As String)
        Call koneksi()
        CMD = New MySqlCommand("update tbtransaksi set status = '" & statusT & "' where id = '" & idTransaksi & "'", CONN)
        CMD.ExecuteNonQuery()
        readDB()
    End Sub

    Sub readDB()
        Try
            cek()
            Call koneksi()
            DA = New MySqlDataAdapter("select tbtransaksi_item.foto as 'foto', tbtransaksi_item.item as 'item', tbtransaksi_item.qty as 'qty', (tbtransaksi_item.qty * tbtransaksi_item.harga) as 'total', tbtransaksi.status as 'status' from tbtransaksi join tbtransaksi_item on tbtransaksi.id=tbtransaksi_item.idtransaksi where tbtransaksi.id = '" & idTransaksi & "' ", CONN)
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
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(0).Value.ToString
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(0).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(2).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvKeranjang.Rows(2).Cells(0).Value.ToString
                lbItem3.Text = dgvKeranjang.Rows(2).Cells(1).Value.ToString
                lbQty3.Text = dgvKeranjang.Rows(2).Cells(2).Value.ToString
                lbHarga3.Text = dgvKeranjang.Rows(2).Cells(3).Value.ToString
                PictureBox4.ImageLocation = alamat + dgvKeranjang.Rows(3).Cells(0).Value.ToString
                lbItem4.Text = dgvKeranjang.Rows(3).Cells(1).Value.ToString
                lbQty4.Text = dgvKeranjang.Rows(3).Cells(2).Value.ToString
                lbHarga4.Text = dgvKeranjang.Rows(3).Cells(3).Value.ToString
                PictureBox5.ImageLocation = alamat + dgvKeranjang.Rows(4).Cells(0).Value.ToString
                lbItem5.Text = dgvKeranjang.Rows(4).Cells(1).Value.ToString
                lbQty5.Text = dgvKeranjang.Rows(4).Cells(2).Value.ToString
                lbHarga5.Text = dgvKeranjang.Rows(4).Cells(3).Value.ToString
            ElseIf dgvKeranjang.RowCount = 4 Then
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(0).Value.ToString
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(0).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(2).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvKeranjang.Rows(2).Cells(0).Value.ToString
                lbItem3.Text = dgvKeranjang.Rows(2).Cells(1).Value.ToString
                lbQty3.Text = dgvKeranjang.Rows(2).Cells(2).Value.ToString
                lbHarga3.Text = dgvKeranjang.Rows(2).Cells(3).Value.ToString
                PictureBox4.ImageLocation = alamat + dgvKeranjang.Rows(3).Cells(0).Value.ToString
                lbItem4.Text = dgvKeranjang.Rows(3).Cells(1).Value.ToString
                lbQty4.Text = dgvKeranjang.Rows(3).Cells(2).Value.ToString
                lbHarga4.Text = dgvKeranjang.Rows(3).Cells(3).Value.ToString
                Item5.Visible = False
            ElseIf dgvKeranjang.RowCount = 3 Then
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(0).Value.ToString
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(0).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(2).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                PictureBox3.ImageLocation = alamat + dgvKeranjang.Rows(2).Cells(0).Value.ToString
                lbItem3.Text = dgvKeranjang.Rows(2).Cells(1).Value.ToString
                lbQty3.Text = dgvKeranjang.Rows(2).Cells(2).Value.ToString
                lbHarga3.Text = dgvKeranjang.Rows(2).Cells(3).Value.ToString
                Item4.Visible = False
                Item5.Visible = False
            ElseIf dgvKeranjang.RowCount = 2 Then
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(0).Value.ToString
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
                PictureBox2.ImageLocation = alamat + dgvKeranjang.Rows(1).Cells(0).Value.ToString
                lbItem2.Text = dgvKeranjang.Rows(1).Cells(1).Value.ToString
                lbQty2.Text = dgvKeranjang.Rows(1).Cells(2).Value.ToString
                lbHarga2.Text = dgvKeranjang.Rows(1).Cells(3).Value.ToString
                Item3.Visible = False
                Item4.Visible = False
                Item5.Visible = False
            ElseIf dgvKeranjang.RowCount = 1 Then
                PictureBox1.ImageLocation = alamat + dgvKeranjang.Rows(0).Cells(0).Value.ToString
                lbItem1.Text = dgvKeranjang.Rows(0).Cells(1).Value.ToString
                lbQty1.Text = dgvKeranjang.Rows(0).Cells(2).Value.ToString
                lbHarga1.Text = dgvKeranjang.Rows(0).Cells(3).Value.ToString
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
        btnAcc.Visible = False
        If dgvKeranjang.Rows(0).Cells(4).Value = "SEDANG DIPROSES" Then
            btnAcc.Visible = True
        End If
        totalBiaya()
    End Sub

    Sub totalBiaya()
        Call koneksi()
        CMD = New MySqlCommand("select sum(tbtransaksi_item.qty * tbtransaksi_item.harga) as 'total' from tbtransaksi_item where idtransaksi = '" & idTransaksi & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.IsDBNull(0) Then
            lbTotal.Text = RD.GetString(0)
        Else
            lbTotal.Text = "0"
        End If
        RD.Close()

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


    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        prosesPesanan("REQUEST BATAL")
    End Sub

End Class