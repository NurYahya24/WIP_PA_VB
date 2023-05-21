Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Pelanggan_DetailBarang
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
    Private Sub pbBarang_Click(sender As Object, e As EventArgs) Handles pbBarang.Click
        BukaFile.Filter = "Picture files(*.jpg)|*.jpg"
        BukaFile.ShowDialog()
        pbBarang.ImageLocation = BukaFile.FileName
    End Sub
End Class