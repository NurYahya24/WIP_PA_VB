Imports MySql.Data.MySqlClient

Public Class Owner_Main

    Private Sub Owner_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        btnProfil.PerformClick()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
        LogReg.Show()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click

        pnCanvas.Controls.Clear()
        topLabel.Text = "Lihat Data Barang__________________"
        btnBarang.BackColor = Color.Gray
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Transparent
        With Owner_Barang
            .TopLevel = False
            pnCanvas.Controls.Add(Owner_Barang)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        pnCanvas.Controls.Clear()

        topLabel.Text = "Lihat Data Transaksi__________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Gray
        btnProfil.BackColor = Color.Transparent
        With Owner_Transaksi
            .TopLevel = False
            pnCanvas.Controls.Add(Owner_Transaksi)
            .BringToFront()
            .Show()
        End With
        Owner_Transaksi.bntProses.PerformClick()

    End Sub

    Private Sub btnProfil_Click(sender As Object, e As EventArgs) Handles btnProfil.Click
        pnCanvas.Controls.Clear()
        topLabel.Text = "Manajemen Data Karyawan_________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Gray
        With Owner_Karyawan
            .TopLevel = False
            pnCanvas.Controls.Add(Owner_Karyawan)
            .BringToFront()
            .Show()

        End With
        Owner_Karyawan.TampilDatabase()
    End Sub

End Class