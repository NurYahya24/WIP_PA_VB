Imports MySql.Data.MySqlClient

Public Class Pelanggan_Main
    Public Property Id As Integer
    Public Property idCart As Integer

    Sub AdaCart()
        Call koneksi()
        CMD = New MySqlCommand("select tbkeranjang.id as 'id' from tbkeranjang join tbakun on tbkeranjang.id_user = tbakun.id where tbakun.id = '" & Id & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            RD.Close()
            CMD = New MySqlCommand("insert into tbkeranjang(id, id_user) values('0', '" & Id & "')", CONN)
            CMD.ExecuteNonQuery()
            AdaCart()
        Else
            idCart = RD.GetString(0)
            RD.Close()
        End If
    End Sub

    Private Sub Pelanggan_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        AdaCart()
        btnBarang.PerformClick()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
        LogReg.Show()
        Button1.Visible = True
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        pnCanvas.Controls.Clear()
        topLabel.Text = "Data Barang__________________"
        btnBarang.BackColor = Color.Gray
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Transparent
        With Pelanggan_Barang
            .TopLevel = False
            pnCanvas.Controls.Add(Pelanggan_Barang)
            .BringToFront()
            .Show()
        End With
        Button1.Visible = True
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        pnCanvas.Controls.Clear()

        topLabel.Text = "Riwayat Transaksi__________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Gray
        btnProfil.BackColor = Color.Transparent
        Button1.Visible = True
        With Pelanggan_Transaksi
            .TopLevel = False
            pnCanvas.Controls.Add(Pelanggan_Transaksi)
            .BringToFront()
            .Show()
        End With
        Pelanggan_Transaksi.bntProses.PerformClick()
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
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnCanvas.Controls.Clear()
        topLabel.Text = "Keranjang Saya__________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Transparent
        With Pelanggan_Keranjang
            .TopLevel = False
            pnCanvas.Controls.Add(Pelanggan_Keranjang)
            .BringToFront()
            .Show()
        End With
        Pelanggan_Keranjang.refreshPage()
        Pelanggan_Keranjang.readDB()
        Button1.Visible = False

    End Sub

End Class