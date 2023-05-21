Imports MySql.Data.MySqlClient

Public Class Pelanggan_Main
    Public Property Id As Integer

    Private Sub Pelanggan_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        btnBarang.PerformClick()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
        LogReg.Show()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        pnCanvas.Controls.Clear()
        topLabel.Text = "Data Barang__________________"
        btnBarang.BackColor = Color.Gray
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Transparent
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        pnCanvas.Controls.Clear()

        topLabel.Text = "Riwayat Transaksi__________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Gray
        btnProfil.BackColor = Color.Transparent
    End Sub

    Private Sub btnProfil_Click(sender As Object, e As EventArgs) Handles btnProfil.Click
        pnCanvas.Controls.Clear()
        topLabel.Text = "Profil_________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Gray
        With Pelanggan_Profil
            .TopLevel = False
            pnCanvas.Controls.Add(Pelanggan_Profil)
            .BringToFront()
            .Show()
        End With
        CMD = New MySqlCommand("select * from tbakun where id='" & Id & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Pelanggan_Profil.txtNama.Text = RD.GetString(1)
            Pelanggan_Profil.txtMail.Text = RD.GetString(2)
            Pelanggan_Profil.txtAlamat.Text = RD.GetString(3)
            Pelanggan_Profil.pbProfilePic.ImageLocation = CurDir() + "\gambar\profil\" + RD.GetString(6)
        End If
        RD.Close()
    End Sub

End Class