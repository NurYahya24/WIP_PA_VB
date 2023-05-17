<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan_barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvDataBarang = New System.Windows.Forms.DataGridView()
        Me.barang1 = New System.Windows.Forms.Panel()
        Me.idBarang = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbHarga = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbNama = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.barang2 = New System.Windows.Forms.Panel()
        Me.idBarang2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbHarga2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbNama2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.barang3 = New System.Windows.Forms.Panel()
        Me.idBarang3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbHarga3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbNama3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.barang4 = New System.Windows.Forms.Panel()
        Me.idBarang4 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbHarga4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbNama4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lbKosong = New System.Windows.Forms.Label()
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barang1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barang2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barang3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barang4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDataBarang
        '
        Me.dgvDataBarang.AllowUserToAddRows = False
        Me.dgvDataBarang.AllowUserToDeleteRows = False
        Me.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataBarang.Location = New System.Drawing.Point(285, 262)
        Me.dgvDataBarang.Name = "dgvDataBarang"
        Me.dgvDataBarang.ReadOnly = True
        Me.dgvDataBarang.Size = New System.Drawing.Size(36, 29)
        Me.dgvDataBarang.TabIndex = 0
        Me.dgvDataBarang.Visible = False
        '
        'barang1
        '
        Me.barang1.BackColor = System.Drawing.Color.White
        Me.barang1.Controls.Add(Me.idBarang)
        Me.barang1.Controls.Add(Me.Label2)
        Me.barang1.Controls.Add(Me.lbHarga)
        Me.barang1.Controls.Add(Me.Panel2)
        Me.barang1.Controls.Add(Me.lbNama)
        Me.barang1.Controls.Add(Me.PictureBox1)
        Me.barang1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.barang1.Location = New System.Drawing.Point(97, 39)
        Me.barang1.Name = "barang1"
        Me.barang1.Size = New System.Drawing.Size(150, 214)
        Me.barang1.TabIndex = 1
        '
        'idBarang
        '
        Me.idBarang.AutoSize = True
        Me.idBarang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.idBarang.Location = New System.Drawing.Point(0, 201)
        Me.idBarang.Name = "idBarang"
        Me.idBarang.Size = New System.Drawing.Size(15, 13)
        Me.idBarang.TabIndex = 5
        Me.idBarang.Text = "id"
        Me.idBarang.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(87, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rp. "
        '
        'lbHarga
        '
        Me.lbHarga.AutoSize = True
        Me.lbHarga.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHarga.ForeColor = System.Drawing.Color.Red
        Me.lbHarga.Location = New System.Drawing.Point(114, 184)
        Me.lbHarga.Name = "lbHarga"
        Me.lbHarga.Size = New System.Drawing.Size(36, 13)
        Me.lbHarga.TabIndex = 3
        Me.lbHarga.Text = "Harga"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 167)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 17)
        Me.Panel2.TabIndex = 4
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbNama.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama.Location = New System.Drawing.Point(0, 150)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(44, 17)
        Me.lbNama.TabIndex = 1
        Me.lbNama.Text = "Nama"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'barang2
        '
        Me.barang2.BackColor = System.Drawing.Color.White
        Me.barang2.Controls.Add(Me.idBarang2)
        Me.barang2.Controls.Add(Me.Label1)
        Me.barang2.Controls.Add(Me.lbHarga2)
        Me.barang2.Controls.Add(Me.Panel4)
        Me.barang2.Controls.Add(Me.lbNama2)
        Me.barang2.Controls.Add(Me.PictureBox2)
        Me.barang2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.barang2.Location = New System.Drawing.Point(354, 39)
        Me.barang2.Name = "barang2"
        Me.barang2.Size = New System.Drawing.Size(150, 214)
        Me.barang2.TabIndex = 5
        '
        'idBarang2
        '
        Me.idBarang2.AutoSize = True
        Me.idBarang2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.idBarang2.Location = New System.Drawing.Point(0, 201)
        Me.idBarang2.Name = "idBarang2"
        Me.idBarang2.Size = New System.Drawing.Size(15, 13)
        Me.idBarang2.TabIndex = 6
        Me.idBarang2.Text = "id"
        Me.idBarang2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(87, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rp. "
        '
        'lbHarga2
        '
        Me.lbHarga2.AutoSize = True
        Me.lbHarga2.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHarga2.ForeColor = System.Drawing.Color.Red
        Me.lbHarga2.Location = New System.Drawing.Point(114, 184)
        Me.lbHarga2.Name = "lbHarga2"
        Me.lbHarga2.Size = New System.Drawing.Size(36, 13)
        Me.lbHarga2.TabIndex = 3
        Me.lbHarga2.Text = "Harga"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 167)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 17)
        Me.Panel4.TabIndex = 4
        '
        'lbNama2
        '
        Me.lbNama2.AutoSize = True
        Me.lbNama2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbNama2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama2.Location = New System.Drawing.Point(0, 150)
        Me.lbNama2.Name = "lbNama2"
        Me.lbNama2.Size = New System.Drawing.Size(44, 17)
        Me.lbNama2.TabIndex = 1
        Me.lbNama2.Text = "Nama"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'barang3
        '
        Me.barang3.BackColor = System.Drawing.Color.White
        Me.barang3.Controls.Add(Me.idBarang3)
        Me.barang3.Controls.Add(Me.Label3)
        Me.barang3.Controls.Add(Me.lbHarga3)
        Me.barang3.Controls.Add(Me.Panel3)
        Me.barang3.Controls.Add(Me.lbNama3)
        Me.barang3.Controls.Add(Me.PictureBox3)
        Me.barang3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.barang3.Location = New System.Drawing.Point(97, 311)
        Me.barang3.Name = "barang3"
        Me.barang3.Size = New System.Drawing.Size(150, 214)
        Me.barang3.TabIndex = 6
        '
        'idBarang3
        '
        Me.idBarang3.AutoSize = True
        Me.idBarang3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.idBarang3.Location = New System.Drawing.Point(0, 201)
        Me.idBarang3.Name = "idBarang3"
        Me.idBarang3.Size = New System.Drawing.Size(15, 13)
        Me.idBarang3.TabIndex = 6
        Me.idBarang3.Text = "id"
        Me.idBarang3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(87, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rp. "
        '
        'lbHarga3
        '
        Me.lbHarga3.AutoSize = True
        Me.lbHarga3.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHarga3.ForeColor = System.Drawing.Color.Red
        Me.lbHarga3.Location = New System.Drawing.Point(114, 184)
        Me.lbHarga3.Name = "lbHarga3"
        Me.lbHarga3.Size = New System.Drawing.Size(36, 13)
        Me.lbHarga3.TabIndex = 3
        Me.lbHarga3.Text = "Harga"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(150, 17)
        Me.Panel3.TabIndex = 4
        '
        'lbNama3
        '
        Me.lbNama3.AutoSize = True
        Me.lbNama3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbNama3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama3.Location = New System.Drawing.Point(0, 150)
        Me.lbNama3.Name = "lbNama3"
        Me.lbNama3.Size = New System.Drawing.Size(44, 17)
        Me.lbNama3.TabIndex = 1
        Me.lbNama3.Text = "Nama"
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'barang4
        '
        Me.barang4.BackColor = System.Drawing.Color.White
        Me.barang4.Controls.Add(Me.idBarang4)
        Me.barang4.Controls.Add(Me.Label4)
        Me.barang4.Controls.Add(Me.lbHarga4)
        Me.barang4.Controls.Add(Me.Panel5)
        Me.barang4.Controls.Add(Me.lbNama4)
        Me.barang4.Controls.Add(Me.PictureBox4)
        Me.barang4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.barang4.Location = New System.Drawing.Point(354, 311)
        Me.barang4.Name = "barang4"
        Me.barang4.Size = New System.Drawing.Size(150, 214)
        Me.barang4.TabIndex = 7
        '
        'idBarang4
        '
        Me.idBarang4.AutoSize = True
        Me.idBarang4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.idBarang4.Location = New System.Drawing.Point(0, 201)
        Me.idBarang4.Name = "idBarang4"
        Me.idBarang4.Size = New System.Drawing.Size(15, 13)
        Me.idBarang4.TabIndex = 6
        Me.idBarang4.Text = "id"
        Me.idBarang4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(87, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rp. "
        '
        'lbHarga4
        '
        Me.lbHarga4.AutoSize = True
        Me.lbHarga4.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHarga4.ForeColor = System.Drawing.Color.Red
        Me.lbHarga4.Location = New System.Drawing.Point(114, 184)
        Me.lbHarga4.Name = "lbHarga4"
        Me.lbHarga4.Size = New System.Drawing.Size(36, 13)
        Me.lbHarga4.TabIndex = 3
        Me.lbHarga4.Text = "Harga"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 167)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(150, 17)
        Me.Panel5.TabIndex = 4
        '
        'lbNama4
        '
        Me.lbNama4.AutoSize = True
        Me.lbNama4.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbNama4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama4.Location = New System.Drawing.Point(0, 150)
        Me.lbNama4.Name = "lbNama4"
        Me.lbNama4.Size = New System.Drawing.Size(44, 17)
        Me.lbNama4.TabIndex = 1
        Me.lbNama4.Text = "Nama"
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnPrev)
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(67, 564)
        Me.Panel6.TabIndex = 8
        '
        'btnPrev
        '
        Me.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrev.Location = New System.Drawing.Point(0, 152)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(67, 260)
        Me.btnPrev.TabIndex = 2
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 412)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(67, 152)
        Me.Panel9.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(67, 152)
        Me.Panel8.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnNext)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(533, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(67, 564)
        Me.Panel7.TabIndex = 9
        '
        'btnNext
        '
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNext.Location = New System.Drawing.Point(0, 152)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(67, 260)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 412)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(67, 152)
        Me.Panel10.TabIndex = 4
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(67, 152)
        Me.Panel11.TabIndex = 3
        '
        'lbKosong
        '
        Me.lbKosong.AutoSize = True
        Me.lbKosong.Location = New System.Drawing.Point(97, 23)
        Me.lbKosong.Name = "lbKosong"
        Me.lbKosong.Size = New System.Drawing.Size(91, 13)
        Me.lbKosong.TabIndex = 10
        Me.lbKosong.Text = "Data Tidak Ada..."
        Me.lbKosong.Visible = False
        '
        'Karyawan_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 564)
        Me.Controls.Add(Me.lbKosong)
        Me.Controls.Add(Me.dgvDataBarang)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.barang4)
        Me.Controls.Add(Me.barang3)
        Me.Controls.Add(Me.barang2)
        Me.Controls.Add(Me.barang1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Karyawan_barang"
        Me.Text = "Karyawan_barang"
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barang1.ResumeLayout(False)
        Me.barang1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barang2.ResumeLayout(False)
        Me.barang2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barang3.ResumeLayout(False)
        Me.barang3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barang4.ResumeLayout(False)
        Me.barang4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDataBarang As DataGridView
    Friend WithEvents barang1 As Panel
    Friend WithEvents lbHarga As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbNama As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents barang2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbHarga2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbNama2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents idBarang As Label
    Friend WithEvents idBarang2 As Label
    Friend WithEvents barang3 As Panel
    Friend WithEvents idBarang3 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbHarga3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbNama3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents barang4 As Panel
    Friend WithEvents idBarang4 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbHarga4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbNama4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnPrev As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnNext As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lbKosong As Label
End Class
