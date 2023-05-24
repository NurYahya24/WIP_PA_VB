Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class Owner_Karyawan
    Dim idkaryawan As Integer
    Dim oldmail As String
    Sub clear()
        txtRegNama.Clear()
        txtRegMail.Clear()
        txtRegAlamat.Clear()
        txtGaji.Clear()
        cb_shift.SelectedIndex = -1
        dgv_data_karyawan.ClearSelection()
        txtCari.Clear()

    End Sub

    Sub TampilDatabase()
        Call koneksi()
        DA = New MySqlDataAdapter("Select id, nama, tbakun.email as 'email', alamat, tbgawai.gaji as 'gaji', tbgawai.shift as 'shift' From tbakun join tbgawai where tbakun.email = tbgawai.email", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbakun")
        dgv_data_karyawan.DataSource = DS.Tables("tbakun")
        dgv_data_karyawan.Refresh()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If (txtRegNama.Text = "") Or (txtRegMail.Text = "") Or (txtRegAlamat.Text = "") Or (txtGaji.Text = "") Or (cb_shift.SelectedIndex = -1) Then
            MessageBox.Show("Data Belum Lengkap")
        Else
            Call koneksi()
            CMD = New MySqlCommand("select email from tbakun where email = '" & txtRegMail.Text & "'", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If RD.HasRows Then
                MessageBox.Show("E-mail Sudah Terdaftar", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RD.Close()
            Else
                RD.Close()
                CMD = New MySqlCommand("insert into tbakun(id, nama, email, alamat, password, level) values(0, '" & txtRegNama.Text & "', '" & txtRegMail.Text & "', '" & txtRegAlamat.Text & "', '123', 'KARYAWAN')", CONN)
                CMD.ExecuteNonQuery()
                CMD = New MySqlCommand("insert into tbgawai(gaji, shift, email) values('" & txtGaji.Text & "', '" & cb_shift.SelectedItem.ToString & "', '" & txtRegMail.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil Registrasi.....|", MsgBoxStyle.Information, "Perhatian")
                Call clear()
                TampilDatabase()
            End If
        End If
    End Sub


    Private Sub dgv_data_karyawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_karyawan.CellClick
        Dim i As Integer
        With dgv_data_karyawan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtRegNama.Text = .Rows(i).Cells(1).Value.ToString
                txtRegMail.Text = .Rows(i).Cells(2).Value.ToString
                txtRegAlamat.Text = .Rows(i).Cells(3).Value.ToString
                txtGaji.Text = .Rows(i).Cells(4).Value.ToString
                If .Rows(i).Cells(5).Value.ToString = "Siang" Then
                    cb_shift.SelectedIndex = 0
                Else
                    cb_shift.SelectedIndex = 1
                End If
                idkaryawan = .Rows(i).Cells(0).Value.ToString
                oldmail = .Rows(i).Cells(2).Value.ToString
            End If
        End With
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call clear()
        Call TampilDatabase()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (txtRegNama.Text = "") Or (txtRegMail.Text = "") Or (txtRegAlamat.Text = "") Or (txtGaji.Text = "") Or (cb_shift.SelectedIndex = -1) Then
            MessageBox.Show("Data Belum Lengkap")
            txtRegNama.Focus()
        Else
            Dim Update As String = "Update tbakun set nama = '" & txtRegNama.Text & "', email = 
                                  '" & txtRegMail.Text & "', Alamat = '" & txtRegAlamat.Text & "' where id = '" & idkaryawan & "'"

            CMD = New MySqlCommand(Update, CONN)
            CMD.ExecuteNonQuery()
            Update = "Update tbgawai set gaji = '" & txtGaji.Text & "', email = 
                                  '" & txtRegMail.Text & "', shift = '" & cb_shift.SelectedItem.ToString & "' where email = '" & oldmail & "'"

            CMD = New MySqlCommand(Update, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil di Update", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Call TampilDatabase()
            Call clear()
            txtRegNama.Focus()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Apakah kamu yakin ingin menghapus Karyawan  " & txtRegNama.Text & " ?", "",
                               MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CMD = New MySqlCommand("Delete From tbakun Where id = '" & idkaryawan & "'", CONN)
            CMD.ExecuteNonQuery()
            CMD = New MySqlCommand("Delete From tbgawai Where email = '" & oldmail & "'", CONN)
            CMD.ExecuteNonQuery()
            Call TampilDatabase()
            Call clear()
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbakun where nama like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From tbakun join tbgawai on tbakun.email = tbgawai.email where nama like '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                dgv_data_karyawan.DataSource = DS.Tables("Dapat")
                dgv_data_karyawan.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub
End Class