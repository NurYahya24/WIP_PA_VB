Imports MySql.Data.MySqlClient

Public Class LogReg

    Sub LoginAuth()
        Call koneksi()
        CMD = New MySqlCommand("select id, level from tbakun where binary email='" & txtLogNama.Text & "' and password='" & txtLogPass.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            If RD.GetString(1) = "KARYAWAN" Then
                Me.Dispose()
                Karyawan_Main.Id = RD.GetValue(0)
                Karyawan_Main.Show()
            ElseIf RD.GetString(1) = "USER" Then
                Me.Dispose()
                Pelanggan_Main.Id = RD.GetValue(0)
                Pelanggan_Main.Show()
            ElseIf RD.GetString(1) = "OWNER" Then
                Me.Dispose()
                Owner_Main.Show()
            End If
        Else
            MessageBox.Show("NAMA ATAU PASSWORD SALAH")
        End If


    End Sub


    Private Sub LogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogIn.LinkClicked
        pnLogin.Show()
        While pnBrand.Location.X < 325
            pnBrand.Location = New Point(pnBrand.Location.X + 2)
        End While
        For Each ctrl As Control In pnRegis.Controls
            If ctrl.GetType() Is GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next
        btnExit.ForeColor = Color.White
        btnExit.BackColor = Color.DarkSlateBlue
        pnRegis.Hide()
    End Sub

    Private Sub Regis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Regis.LinkClicked
        pnRegis.Show()
        While pnBrand.Location.X > 0
            pnBrand.Location = New Point(pnBrand.Location.X - 2)
        End While
        For Each ctrl As Control In pnLogin.Controls
            If ctrl.GetType() Is GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next
        btnExit.ForeColor = Color.DarkSlateBlue
        btnExit.BackColor = Color.Lavender
        pnLogin.Hide()
    End Sub

    Private Sub LogReg_Load(sender As Object, e As EventArgs) Handles Me.Load
        If pnBrand.Location.X > 0 Then
            pnRegis.Hide()
        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If (txtLogNama.Text = "") Or (txtLogPass.Text = "") Then
            MessageBox.Show("Data Belum Lengkap")
        Else
            LoginAuth()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If (txtRegNama.Text = "") Or (txtRegMail.Text = "") Or (txtRegAlamat.Text = "") Or (txtRegPass.Text = "") Then
            MessageBox.Show("Data Belum Lengkap")
        Else
            Call koneksi()
            CMD = New MySqlCommand("select email from tbakun where id = '" & txtRegMail.Text & "'", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If RD.HasRows Then
                MessageBox.Show("E-mail Sudah Terdaftar", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RD.Close()
            Else
                RD.Close()
                CMD = New MySqlCommand("insert into tbakun(id, nama, email, alamat, password, level) values(0, '" & txtRegNama.Text & "', '" & txtRegMail.Text & "', '" & txtRegAlamat.Text & "', '" & txtRegPass.Text & "', 'USER')", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil Registrasi.....|", MsgBoxStyle.Information, "Perhatian")
                pnLogin.Show()
                While pnBrand.Location.X < 325
                    pnBrand.Location = New Point(pnBrand.Location.X + 2)
                End While
                For Each ctrl As Control In pnRegis.Controls
                    If ctrl.GetType() Is GetType(TextBox) Then
                        ctrl.Text = ""
                    End If
                Next
                btnExit.ForeColor = Color.White
                btnExit.BackColor = Color.DarkSlateBlue
                pnRegis.Hide()
            End If
        End If
    End Sub

End Class