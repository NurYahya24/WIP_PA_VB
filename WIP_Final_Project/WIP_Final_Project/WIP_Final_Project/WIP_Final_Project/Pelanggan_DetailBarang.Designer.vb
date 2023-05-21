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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbBarang = New System.Windows.Forms.PictureBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BukaFile = New System.Windows.Forms.OpenFileDialog()
        Me.cbTipe = New System.Windows.Forms.ComboBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Barang"
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.LightGray
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Location = New System.Drawing.Point(238, 67)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(320, 13)
        Me.txtNama.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(238, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 1)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(0, -9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 10)
        Me.Panel3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.BackColor = System.Drawing.Color.LightGray
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga.Location = New System.Drawing.Point(238, 127)
        Me.txtHarga.Multiline = True
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(320, 20)
        Me.txtHarga.TabIndex = 6
        Me.txtHarga.Text = "Rp. "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(238, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 1)
        Me.Panel2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Detail Barang"
        '
        'txtDesk
        '
        Me.txtDesk.Location = New System.Drawing.Point(49, 355)
        Me.txtDesk.Multiline = True
        Me.txtDesk.Name = "txtDesk"
        Me.txtDesk.Size = New System.Drawing.Size(509, 162)
        Me.txtDesk.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jenis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Stok"
        '
        'pbBarang
        '
        Me.pbBarang.Location = New System.Drawing.Point(45, 35)
        Me.pbBarang.Name = "pbBarang"
        Me.pbBarang.Size = New System.Drawing.Size(155, 155)
        Me.pbBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBarang.TabIndex = 0
        Me.pbBarang.TabStop = False
        '
        'txtStok
        '
        Me.txtStok.BackColor = System.Drawing.Color.LightGray
        Me.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStok.Location = New System.Drawing.Point(97, 274)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(200, 13)
        Me.txtStok.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Location = New System.Drawing.Point(97, 292)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 1)
        Me.Panel6.TabIndex = 18
        '
        'BukaFile
        '
        Me.BukaFile.FileName = "OpenFileDialog1"
        '
        'cbTipe
        '
        Me.cbTipe.FormattingEnabled = True
        Me.cbTipe.Location = New System.Drawing.Point(97, 207)
        Me.cbTipe.Name = "cbTipe"
        Me.cbTipe.Size = New System.Drawing.Size(200, 21)
        Me.cbTipe.TabIndex = 19
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(98, 245)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(199, 21)
        Me.cbJenis.TabIndex = 20
        '
        'Pelanggan_DetailBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(600, 564)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.cbTipe)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDesk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pelanggan_DetailBarang"
        Me.Text = "Pelanggan_DetailBarang"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbBarang As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesk As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BukaFile As OpenFileDialog
    Friend WithEvents cbTipe As ComboBox
    Friend WithEvents cbJenis As ComboBox
End Class
