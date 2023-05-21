Imports MySql.Data.MySqlClient

Public Class Karyawan_Main

    Public Property Id As Integer

    Private Sub Karyawan_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        btnBarang.PerformClick()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
        LogReg.Show()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        btnAddBarang.Visible = True
        pnCanvas.Controls.Clear()
        topLabel.Text = "Manajemen Data Barang__________________"
        btnBarang.BackColor = Color.Gray
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Transparent
        With Karyawan_barang
            .TopLevel = False
            pnCanvas.Controls.Add(Karyawan_barang)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        btnAddBarang.Visible = False
        pnCanvas.Controls.Clear()

        topLabel.Text = "Manajemen Data Transaksi__________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Gray
        btnProfil.BackColor = Color.Transparent

    End Sub

    Private Sub btnProfil_Click(sender As Object, e As EventArgs) Handles btnProfil.Click
        btnAddBarang.Visible = False
        pnCanvas.Controls.Clear()
        topLabel.Text = "Profil_________________"
        btnBarang.BackColor = Color.Transparent
        btnTransaksi.BackColor = Color.Transparent
        btnProfil.BackColor = Color.Gray
        With Karyawan_Profil
            .TopLevel = False
            pnCanvas.Controls.Add(Karyawan_Profil)
            .BringToFront()
            .Show()
        End With
        CMD = New MySqlCommand("select * from tbakun join tbgawai on tbakun.email=tbgawai.email where id='" & Id & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Karyawan_Profil.txtNama.Text = RD.GetString(1)
            Karyawan_Profil.txtMail.Text = RD.GetString(2)
            Karyawan_Profil.txtAlamat.Text = RD.GetString(3)
            Karyawan_Profil.lbGaji.Text = RD.GetString(7)
            Karyawan_Profil.lbShift.Text = RD.GetString(8)
            Karyawan_Profil.pbProfilePic.ImageLocation = CurDir() + "\gambar\profil\" + RD.GetString(6)
        End If
        RD.Close()
    End Sub

    Private Sub btnAddBarang_Click(sender As Object, e As EventArgs) Handles btnAddBarang.Click
        btnAddBarang.Visible = False
        topLabel.Text = "Tambah Data Barang________________"
        pnCanvas.Controls.Clear()
        With Karyawan_InputBarang
            .TopLevel = False
            pnCanvas.Controls.Add(Karyawan_InputBarang)
            .BringToFront()
            .Show()
        End With
        Karyawan_InputBarang.btnHapus.Visible = False
        Karyawan_InputBarang.editKah = False
        Karyawan_InputBarang.txtNama.Clear()
        Karyawan_InputBarang.txtHarga.Clear()
        Karyawan_InputBarang.txtDesk.Clear()
        Karyawan_InputBarang.txtStok.Clear()
        Karyawan_InputBarang.cbJenis.SelectedIndex = -1
        Karyawan_InputBarang.cbTipe.SelectedIndex = -1
        Karyawan_InputBarang.pbBarang.ImageLocation = ""
    End Sub

    Private Sub pnCanvas_Paint(sender As Object, e As PaintEventArgs) Handles pnCanvas.Paint

    End Sub
End Class