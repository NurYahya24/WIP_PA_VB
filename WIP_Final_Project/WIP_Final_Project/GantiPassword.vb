Imports MySql.Data.MySqlClient

Public Class GantiPassword

    Public Property idUser As Integer

    Private Sub buttonConfirm_Click(sender As Object, e As EventArgs) Handles buttonConfirm.Click
        Call koneksi()
        CMD = New MySqlCommand("select password from tbakun where id='" & idUser & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        Dim cek As String = RD.GetString(0)
        If txtPassLama.Text = "" Or txtPassBaru.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong")
            RD.Close()
        ElseIf txtPassLama.Text = cek Then
            RD.Close()
            CMD = New MySqlCommand("update tbakun set password = '" & txtPassBaru.Text & "' where id='" & idUser & "' ", CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Berhasil Mengubah Password")
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub seePass1_CheckedChanged(sender As Object, e As EventArgs) Handles seePass1.CheckedChanged
        If seePass1.Checked Then
            txtPassLama.UseSystemPasswordChar = False
        Else
            txtPassLama.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub seePass2_CheckedChanged(sender As Object, e As EventArgs) Handles seePass2.CheckedChanged
        If seePass2.Checked Then
            txtPassBaru.UseSystemPasswordChar = False
        Else
            txtPassBaru.UseSystemPasswordChar = True
        End If
    End Sub
End Class