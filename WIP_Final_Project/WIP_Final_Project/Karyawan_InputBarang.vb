Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Karyawan_InputBarang

    Public Property idBarang As Integer
    Public Property editKah As Boolean

    Dim alamat As String = CurDir() + "\gambar\barang\"
    Dim kondisi As Boolean

    Sub cekForm()
        If txtNama.Text = "" Then
            kondisi = False
        ElseIf txtHarga.Text = "" Then
            kondisi = False
        ElseIf txtStok.Text = "" Then
            kondisi = False
        ElseIf txtDesk.Text = "" Then
            kondisi = False
        ElseIf cbTipe.SelectedIndex = -1 Then
            kondisi = False
        ElseIf cbJenis.SelectedIndex = -1 Then
            kondisi = False
        End If
    End Sub
    Private Sub cbTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipe.SelectedIndexChanged
        If cbTipe.SelectedIndex = 0 Then
            cbJenis.Items.RemoveAt(1)
            cbJenis.Items.RemoveAt(0)
            cbJenis.Items.Add("Elektrik")
            cbJenis.Items.Add("Non-Elektrik")
        ElseIf cbTipe.SelectedIndex = 1 Then
            cbJenis.Items.RemoveAt(1)
            cbJenis.Items.RemoveAt(0)
            cbJenis.Items.Add("Bangunan")
            cbJenis.Items.Add("Properti")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        kondisi = True
        Call koneksi()
        cekForm()
        Dim query As String = ""
        If kondisi Then
            Dim des As String = alamat + txtNama.Text + ".jpg"
            If pbBarang.Image IsNot Nothing Then
                If (My.Computer.FileSystem.FileExists(des)) Then
                    If Not (des = pbBarang.ImageLocation) Then
                        My.Computer.FileSystem.DeleteFile(des)
                        My.Computer.FileSystem.CopyFile(pbBarang.ImageLocation, des)
                    End If

                Else
                    My.Computer.FileSystem.CopyFile(pbBarang.ImageLocation, des)
                End If
            End If
            If editKah Then
                query = "update tbbarang set nama='" & txtNama.Text & "', tipe='" & cbTipe.SelectedItem.ToString & "', jenis='" & cbJenis.SelectedItem.ToString & "', stok='" & txtStok.Text & "', harga='" & txtHarga.Text & "', desk='" & txtDesk.Text & "', foto='" & txtNama.Text + ".jpg" & "' where id='" & idBarang & "'"
            Else
                query = "insert into tbbarang(id, nama, tipe, jenis, stok, harga, desk, foto) values(0, '" & txtNama.Text & "', '" & cbTipe.SelectedItem.ToString & "', '" & cbJenis.SelectedItem.ToString & "', '" & txtStok.Text & "', '" & txtHarga.Text & "', '" & txtDesk.Text & "', '" & txtNama.Text + ".jpg" & "')"
            End If
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan.....|", MsgBoxStyle.Information, "Perhatian")
        End If
        Karyawan_Main.btnBarang.PerformClick()
        Karyawan_barang.readDB()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Karyawan_Main.btnBarang.PerformClick()
        Karyawan_barang.readDB()
    End Sub

    Private Sub pbBarang_Click(sender As Object, e As EventArgs) Handles pbBarang.Click
        BukaFile.Filter = "Picture files(*.jpg)|*.jpg"
        BukaFile.ShowDialog()
        pbBarang.ImageLocation = BukaFile.FileName
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call koneksi()
        CMD = New MySqlCommand("delete from tbkeranjang_item where idbarang='" & idBarang & "';delete from tbbarang where id='" & idBarang & "'", CONN)
        CMD.ExecuteNonQuery()
        Karyawan_Main.btnBarang.PerformClick()
        Karyawan_barang.readDB()
    End Sub
End Class