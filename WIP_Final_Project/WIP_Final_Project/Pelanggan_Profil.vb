Imports MySql.Data.MySqlClient

Public Class Pelanggan_Profil
    Dim kondisi As Boolean
    Dim alamat As String = CurDir() + "\gambar\profil\"

    Sub cekForm()
        If txtNama.Text = "" Then
            kondisi = False
        ElseIf txtAlamat.Text = "" Then
            kondisi = False
        ElseIf txtMail.Text = "" Then
            kondisi = False
        End If
    End Sub

    Private Sub pbProfilePic_Click(sender As Object, e As EventArgs) Handles pbProfilePic.Click
        BukaFile.Filter = "Picture files(*.jpg)|*.jpg"
        BukaFile.ShowDialog()
        pbProfilePic.ImageLocation = BukaFile.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kondisi = True
        cekForm()
        Dim des As String = alamat + txtMail.Text + ".jpg"
        If pbProfilePic.Image IsNot Nothing Then
            If (My.Computer.FileSystem.FileExists(des)) Then
                My.Computer.FileSystem.DeleteFile(des)
                My.Computer.FileSystem.CopyFile(BukaFile.FileName, des)
            Else
                My.Computer.FileSystem.CopyFile(BukaFile.FileName, des)
            End If
        End If
        Dim ubah As String = "update tbakun set nama='" & txtNama.Text & "', email= '" & txtMail.Text & "', alamat = '" & txtAlamat.Text & "', foto = '" & txtMail.Text + ".jpg" & "' where id= '" & Pelanggan_Main.Id & "'"
        If Not kondisi Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan.....|", MsgBoxStyle.Information, "Perhatian")
        End If
    End Sub

End Class