<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogReg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogReg))
        Me.Regis = New System.Windows.Forms.LinkLabel()
        Me.pnLogin = New System.Windows.Forms.Panel()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.holderLog2 = New System.Windows.Forms.Label()
        Me.holderLog1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLogPass = New System.Windows.Forms.TextBox()
        Me.txtLogNama = New System.Windows.Forms.TextBox()
        Me.pnRegis = New System.Windows.Forms.Panel()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRegPass = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRegAlamat = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRegMail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRegNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LogIn = New System.Windows.Forms.LinkLabel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnBrand = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnLogin.SuspendLayout()
        Me.pnRegis.SuspendLayout()
        Me.pnBrand.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Regis
        '
        Me.Regis.AutoSize = True
        Me.Regis.DisabledLinkColor = System.Drawing.Color.DodgerBlue
        Me.Regis.LinkColor = System.Drawing.Color.DodgerBlue
        Me.Regis.Location = New System.Drawing.Point(193, 431)
        Me.Regis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Regis.Name = "Regis"
        Me.Regis.Size = New System.Drawing.Size(68, 16)
        Me.Regis.TabIndex = 1
        Me.Regis.TabStop = True
        Me.Regis.Text = "Registrasi"
        '
        'pnLogin
        '
        Me.pnLogin.BackColor = System.Drawing.Color.Lavender
        Me.pnLogin.Controls.Add(Me.btnMasuk)
        Me.pnLogin.Controls.Add(Me.holderLog2)
        Me.pnLogin.Controls.Add(Me.holderLog1)
        Me.pnLogin.Controls.Add(Me.Panel3)
        Me.pnLogin.Controls.Add(Me.Panel2)
        Me.pnLogin.Controls.Add(Me.Label3)
        Me.pnLogin.Controls.Add(Me.txtLogPass)
        Me.pnLogin.Controls.Add(Me.txtLogNama)
        Me.pnLogin.Controls.Add(Me.Regis)
        Me.pnLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.pnLogin.Name = "pnLogin"
        Me.pnLogin.Size = New System.Drawing.Size(433, 556)
        Me.pnLogin.TabIndex = 1
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(79, 350)
        Me.btnMasuk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(303, 54)
        Me.btnMasuk.TabIndex = 9
        Me.btnMasuk.Text = "MASUK"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'holderLog2
        '
        Me.holderLog2.AutoSize = True
        Me.holderLog2.BackColor = System.Drawing.Color.Transparent
        Me.holderLog2.ForeColor = System.Drawing.Color.DimGray
        Me.holderLog2.Location = New System.Drawing.Point(75, 250)
        Me.holderLog2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.holderLog2.Name = "holderLog2"
        Me.holderLog2.Size = New System.Drawing.Size(67, 16)
        Me.holderLog2.TabIndex = 8
        Me.holderLog2.Text = "Password"
        '
        'holderLog1
        '
        Me.holderLog1.AutoSize = True
        Me.holderLog1.BackColor = System.Drawing.Color.Transparent
        Me.holderLog1.ForeColor = System.Drawing.Color.DimGray
        Me.holderLog1.Location = New System.Drawing.Point(75, 161)
        Me.holderLog1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.holderLog1.Name = "holderLog1"
        Me.holderLog1.Size = New System.Drawing.Size(45, 16)
        Me.holderLog1.TabIndex = 7
        Me.holderLog1.Text = "E-mail"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(79, 311)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(303, 1)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(79, 223)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(303, 1)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(283, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Log In."
        '
        'txtLogPass
        '
        Me.txtLogPass.BackColor = System.Drawing.Color.Lavender
        Me.txtLogPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogPass.Location = New System.Drawing.Point(79, 281)
        Me.txtLogPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogPass.Name = "txtLogPass"
        Me.txtLogPass.Size = New System.Drawing.Size(303, 19)
        Me.txtLogPass.TabIndex = 3
        '
        'txtLogNama
        '
        Me.txtLogNama.BackColor = System.Drawing.Color.Lavender
        Me.txtLogNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogNama.Location = New System.Drawing.Point(79, 192)
        Me.txtLogNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogNama.Name = "txtLogNama"
        Me.txtLogNama.Size = New System.Drawing.Size(303, 19)
        Me.txtLogNama.TabIndex = 2
        '
        'pnRegis
        '
        Me.pnRegis.BackColor = System.Drawing.Color.Lavender
        Me.pnRegis.Controls.Add(Me.btnDaftar)
        Me.pnRegis.Controls.Add(Me.Label8)
        Me.pnRegis.Controls.Add(Me.Panel6)
        Me.pnRegis.Controls.Add(Me.Label7)
        Me.pnRegis.Controls.Add(Me.txtRegPass)
        Me.pnRegis.Controls.Add(Me.Panel5)
        Me.pnRegis.Controls.Add(Me.Label6)
        Me.pnRegis.Controls.Add(Me.txtRegAlamat)
        Me.pnRegis.Controls.Add(Me.Panel4)
        Me.pnRegis.Controls.Add(Me.Label5)
        Me.pnRegis.Controls.Add(Me.txtRegMail)
        Me.pnRegis.Controls.Add(Me.Panel1)
        Me.pnRegis.Controls.Add(Me.txtRegNama)
        Me.pnRegis.Controls.Add(Me.Label4)
        Me.pnRegis.Controls.Add(Me.LogIn)
        Me.pnRegis.Location = New System.Drawing.Point(433, 0)
        Me.pnRegis.Margin = New System.Windows.Forms.Padding(4)
        Me.pnRegis.Name = "pnRegis"
        Me.pnRegis.Size = New System.Drawing.Size(433, 556)
        Me.pnRegis.TabIndex = 3
        '
        'btnDaftar
        '
        Me.btnDaftar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.ForeColor = System.Drawing.Color.White
        Me.btnDaftar.Location = New System.Drawing.Point(81, 431)
        Me.btnDaftar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(303, 54)
        Me.btnDaftar.TabIndex = 20
        Me.btnDaftar.Text = "DAFTAR"
        Me.btnDaftar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(77, 337)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Password"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(81, 399)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(303, 1)
        Me.Panel6.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(77, 249)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Alamat"
        '
        'txtRegPass
        '
        Me.txtRegPass.BackColor = System.Drawing.Color.Lavender
        Me.txtRegPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegPass.Location = New System.Drawing.Point(81, 368)
        Me.txtRegPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegPass.Name = "txtRegPass"
        Me.txtRegPass.Size = New System.Drawing.Size(303, 23)
        Me.txtRegPass.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(81, 310)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(303, 1)
        Me.Panel5.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(77, 161)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "E-mail"
        '
        'txtRegAlamat
        '
        Me.txtRegAlamat.BackColor = System.Drawing.Color.Lavender
        Me.txtRegAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegAlamat.Location = New System.Drawing.Point(81, 279)
        Me.txtRegAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegAlamat.Name = "txtRegAlamat"
        Me.txtRegAlamat.Size = New System.Drawing.Size(303, 23)
        Me.txtRegAlamat.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(81, 223)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(303, 1)
        Me.Panel4.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(77, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nama"
        '
        'txtRegMail
        '
        Me.txtRegMail.BackColor = System.Drawing.Color.Lavender
        Me.txtRegMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegMail.Location = New System.Drawing.Point(81, 192)
        Me.txtRegMail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegMail.Name = "txtRegMail"
        Me.txtRegMail.Size = New System.Drawing.Size(303, 23)
        Me.txtRegMail.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(81, 133)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 1)
        Me.Panel1.TabIndex = 9
        '
        'txtRegNama
        '
        Me.txtRegNama.BackColor = System.Drawing.Color.Lavender
        Me.txtRegNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNama.Location = New System.Drawing.Point(81, 102)
        Me.txtRegNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegNama.Name = "txtRegNama"
        Me.txtRegNama.Size = New System.Drawing.Size(303, 23)
        Me.txtRegNama.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(241, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Registrasi."
        '
        'LogIn
        '
        Me.LogIn.AutoSize = True
        Me.LogIn.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LogIn.Location = New System.Drawing.Point(208, 503)
        Me.LogIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(43, 16)
        Me.LogIn.TabIndex = 2
        Me.LogIn.TabStop = True
        Me.LogIn.Text = "Log In"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(820, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(53, 49)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(77, 293)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELAMAT DATANG DI APLIKASI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(92, 315)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TOKO BANGUNAN ASHWANI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnBrand
        '
        Me.pnBrand.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnBrand.Controls.Add(Me.Label2)
        Me.pnBrand.Controls.Add(Me.Label1)
        Me.pnBrand.Controls.Add(Me.PictureBox2)
        Me.pnBrand.Controls.Add(Me.PictureBox1)
        Me.pnBrand.Location = New System.Drawing.Point(433, 0)
        Me.pnBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.pnBrand.Name = "pnBrand"
        Me.pnBrand.Size = New System.Drawing.Size(433, 556)
        Me.pnBrand.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WIP_Final_Project.My.Resources.Resources.png_building_521
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 293)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(297, 260)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(96, 102)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 193)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LogReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 554)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnBrand)
        Me.Controls.Add(Me.pnRegis)
        Me.Controls.Add(Me.pnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LogReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogReg"
        Me.pnLogin.ResumeLayout(False)
        Me.pnLogin.PerformLayout()
        Me.pnRegis.ResumeLayout(False)
        Me.pnRegis.PerformLayout()
        Me.pnBrand.ResumeLayout(False)
        Me.pnBrand.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Regis As LinkLabel
    Friend WithEvents pnLogin As Panel
    Friend WithEvents pnRegis As Panel
    Friend WithEvents LogIn As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLogPass As TextBox
    Friend WithEvents txtLogNama As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents holderLog2 As Label
    Friend WithEvents holderLog1 As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRegMail As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRegNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtRegAlamat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtRegPass As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnBrand As Panel
End Class
