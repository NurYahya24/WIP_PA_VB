<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pelanggan_DetailBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pelanggan_DetailBarang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNama = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbBarang = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbTipe = New System.Windows.Forms.Label()
        Me.lbJenis = New System.Windows.Forms.Label()
        Me.lbStok = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbHarga = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pbBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rp. "
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbNama.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama.Location = New System.Drawing.Point(0, 26)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(102, 20)
        Me.lbNama.TabIndex = 5
        Me.lbNama.Text = "Nama_Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Deskripsi"
        '
        'txtDesk
        '
        Me.txtDesk.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDesk.Enabled = False
        Me.txtDesk.Location = New System.Drawing.Point(40, 391)
        Me.txtDesk.Multiline = True
        Me.txtDesk.Name = "txtDesk"
        Me.txtDesk.ReadOnly = True
        Me.txtDesk.Size = New System.Drawing.Size(509, 126)
        Me.txtDesk.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jenis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Stok"
        '
        'pbBarang
        '
        Me.pbBarang.Location = New System.Drawing.Point(40, 67)
        Me.pbBarang.Name = "pbBarang"
        Me.pbBarang.Size = New System.Drawing.Size(155, 155)
        Me.pbBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBarang.TabIndex = 0
        Me.pbBarang.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(94, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(94, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = ":"
        '
        'lbTipe
        '
        Me.lbTipe.AutoSize = True
        Me.lbTipe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipe.Location = New System.Drawing.Point(111, 239)
        Me.lbTipe.Name = "lbTipe"
        Me.lbTipe.Size = New System.Drawing.Size(44, 17)
        Me.lbTipe.TabIndex = 16
        Me.lbTipe.Text = "lbTipe"
        '
        'lbJenis
        '
        Me.lbJenis.AutoSize = True
        Me.lbJenis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJenis.Location = New System.Drawing.Point(111, 275)
        Me.lbJenis.Name = "lbJenis"
        Me.lbJenis.Size = New System.Drawing.Size(47, 17)
        Me.lbJenis.TabIndex = 17
        Me.lbJenis.Text = "lbJenis"
        '
        'lbStok
        '
        Me.lbStok.AutoSize = True
        Me.lbStok.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStok.Location = New System.Drawing.Point(111, 309)
        Me.lbStok.Name = "lbStok"
        Me.lbStok.Size = New System.Drawing.Size(44, 17)
        Me.lbStok.TabIndex = 18
        Me.lbStok.Text = "lbStok"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbHarga)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbNama)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(220, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 105)
        Me.Panel1.TabIndex = 19
        '
        'lbHarga
        '
        Me.lbHarga.AutoSize = True
        Me.lbHarga.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbHarga.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHarga.Location = New System.Drawing.Point(34, 70)
        Me.lbHarga.Name = "lbHarga"
        Me.lbHarga.Size = New System.Drawing.Size(103, 20)
        Me.lbHarga.TabIndex = 8
        Me.lbHarga.Text = "Harga_Barang"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 24)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(338, 26)
        Me.Panel3.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(220, 184)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btnAdd.Size = New System.Drawing.Size(126, 38)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Tambahkan"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.Location = New System.Drawing.Point(352, 184)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(132, 38)
        Me.btnDel.TabIndex = 21
        Me.btnDel.Text = "Hapus Dari Keranjang"
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 37)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Pelanggan_DetailBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 525)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbStok)
        Me.Controls.Add(Me.lbJenis)
        Me.Controls.Add(Me.lbTipe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDesk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pelanggan_DetailBarang"
        Me.Text = "Pelanggan_DetailBarang"
        CType(Me.pbBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbBarang As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbNama As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesk As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbTipe As Label
    Friend WithEvents lbJenis As Label
    Friend WithEvents lbStok As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbHarga As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents Button1 As Button
End Class
