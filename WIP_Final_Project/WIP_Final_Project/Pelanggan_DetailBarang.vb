Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Pelanggan_DetailBarang

    Dim alamat As String = CurDir() + "\gambar\barang\"
    Public Property idBarang As Integer

    Sub cek()
        btnAdd.Visible = True
        btnDel.Visible = True
        Try
            CMD = New MySqlCommand("select * from tbkeranjang_item where idkeranjang = '" & Pelanggan_Main.idCart & "' and idbarang = '" & idBarang & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                btnAdd.Enabled = False
                btnDel.Enabled = True
            Else
                btnAdd.Enabled = True
                btnDel.Enabled = False
            End If
            RD.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call koneksi()
        CMD = New MySqlCommand("insert into tbkeranjang_item(idkeranjang, idbarang, qty) values('" & Pelanggan_Main.idCart & "', '" & idBarang & "', '1')", CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Barang Berhasil Ditambahkan.....|", MsgBoxStyle.Information, "Perhatian")
        cek()
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Call koneksi()
        CMD = New MySqlCommand("delete from tbkeranjang_item where idbarang='" & idBarang & "'", CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Barang Berhasil Dihapus.....|", MsgBoxStyle.Information, "Perhatian")
        cek()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pelanggan_Main.btnBarang.PerformClick()
        Owner_Main.btnBarang.PerformClick()
    End Sub


End Class