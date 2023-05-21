<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Karyawan_Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnProfil = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddBarang = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.topLabel = New System.Windows.Forms.Label()
        Me.pnCanvas = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnProfil)
        Me.Panel1.Controls.Add(Me.btnTransaksi)
        Me.Panel1.Controls.Add(Me.btnBarang)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 600)
        Me.Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 560)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(200, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Log Out"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnProfil
        '
        Me.btnProfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProfil.FlatAppearance.BorderSize = 0
        Me.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfil.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnProfil.Image = CType(resources.GetObject("btnProfil.Image"), System.Drawing.Image)
        Me.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfil.Location = New System.Drawing.Point(0, 216)
        Me.btnProfil.Name = "btnProfil"
        Me.btnProfil.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnProfil.Size = New System.Drawing.Size(200, 40)
        Me.btnProfil.TabIndex = 4
        Me.btnProfil.Text = "Profil"
        Me.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProfil.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTransaksi.Image = CType(resources.GetObject("btnTransaksi.Image"), System.Drawing.Image)
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(0, 176)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTransaksi.Size = New System.Drawing.Size(200, 40)
        Me.btnTransaksi.TabIndex = 3
        Me.btnTransaksi.Text = "Transaksi"
        Me.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBarang.Image = CType(resources.GetObject("btnBarang.Image"), System.Drawing.Image)
        Me.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.Location = New System.Drawing.Point(0, 136)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnBarang.Size = New System.Drawing.Size(200, 40)
        Me.btnBarang.TabIndex = 2
        Me.btnBarang.Text = "Barang"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 75)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 36)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnAddBarang)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.topLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(200, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 36)
        Me.Panel3.TabIndex = 1
        '
        'btnAddBarang
        '
        Me.btnAddBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBarang.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddBarang.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddBarang.FlatAppearance.BorderSize = 0
        Me.btnAddBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBarang.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBarang.ForeColor = System.Drawing.Color.White
        Me.btnAddBarang.Image = CType(resources.GetObject("btnAddBarang.Image"), System.Drawing.Image)
        Me.btnAddBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddBarang.Location = New System.Drawing.Point(458, 0)
        Me.btnAddBarang.Name = "btnAddBarang"
        Me.btnAddBarang.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btnAddBarang.Size = New System.Drawing.Size(113, 36)
        Me.btnAddBarang.TabIndex = 1
        Me.btnAddBarang.Text = "Add New+"
        Me.btnAddBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAddBarang.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(571, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(29, 36)
        Me.Panel5.TabIndex = 2
        '
        'topLabel
        '
        Me.topLabel.AutoSize = True
        Me.topLabel.BackColor = System.Drawing.Color.Transparent
        Me.topLabel.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.topLabel.Location = New System.Drawing.Point(28, 9)
        Me.topLabel.Name = "topLabel"
        Me.topLabel.Size = New System.Drawing.Size(77, 17)
        Me.topLabel.TabIndex = 0
        Me.topLabel.Text = "namaMenu"
        '
        'pnCanvas
        '
        Me.pnCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCanvas.Location = New System.Drawing.Point(200, 36)
        Me.pnCanvas.Name = "pnCanvas"
        Me.pnCanvas.Size = New System.Drawing.Size(600, 564)
        Me.pnCanvas.TabIndex = 2
        '
        'Karyawan_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pnCanvas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Karyawan_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karyawan_Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBarang As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnProfil As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents topLabel As Label
    Friend WithEvents pnCanvas As Panel
    Friend WithEvents btnAddBarang As Button
    Friend WithEvents Panel5 As Panel
End Class
