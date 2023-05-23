<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Owner_Karyawan
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
        Me.dgv_data_karyawan = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtGaji = New System.Windows.Forms.TextBox()
        Me.txtRegAlamat = New System.Windows.Forms.TextBox()
        Me.txtRegMail = New System.Windows.Forms.TextBox()
        Me.txtRegNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_shift = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        CType(Me.dgv_data_karyawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_data_karyawan
        '
        Me.dgv_data_karyawan.AllowUserToAddRows = False
        Me.dgv_data_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_karyawan.Location = New System.Drawing.Point(26, 100)
        Me.dgv_data_karyawan.Name = "dgv_data_karyawan"
        Me.dgv_data_karyawan.ReadOnly = True
        Me.dgv_data_karyawan.RowHeadersVisible = False
        Me.dgv_data_karyawan.RowHeadersWidth = 51
        Me.dgv_data_karyawan.RowTemplate.Height = 24
        Me.dgv_data_karyawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_data_karyawan.Size = New System.Drawing.Size(750, 188)
        Me.dgv_data_karyawan.TabIndex = 54
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(622, 603)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 38)
        Me.btnDelete.TabIndex = 53
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(536, 603)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 38)
        Me.btnUpdate.TabIndex = 52
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtGaji
        '
        Me.txtGaji.Location = New System.Drawing.Point(111, 389)
        Me.txtGaji.Name = "txtGaji"
        Me.txtGaji.Size = New System.Drawing.Size(186, 22)
        Me.txtGaji.TabIndex = 50
        '
        'txtRegAlamat
        '
        Me.txtRegAlamat.Location = New System.Drawing.Point(111, 361)
        Me.txtRegAlamat.Name = "txtRegAlamat"
        Me.txtRegAlamat.Size = New System.Drawing.Size(186, 22)
        Me.txtRegAlamat.TabIndex = 48
        '
        'txtRegMail
        '
        Me.txtRegMail.Location = New System.Drawing.Point(111, 333)
        Me.txtRegMail.Name = "txtRegMail"
        Me.txtRegMail.Size = New System.Drawing.Size(186, 22)
        Me.txtRegMail.TabIndex = 47
        '
        'txtRegNama
        '
        Me.txtRegNama.Location = New System.Drawing.Point(111, 305)
        Me.txtRegNama.Name = "txtRegNama"
        Me.txtRegNama.Size = New System.Drawing.Size(186, 22)
        Me.txtRegNama.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Shift"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Gaji"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nama"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(450, 603)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 38)
        Me.btnTambah.TabIndex = 39
        Me.btnTambah.Text = "Add"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Alamat"
        '
        'cb_shift
        '
        Me.cb_shift.FormattingEnabled = True
        Me.cb_shift.Items.AddRange(New Object() {"Siang", "Malam"})
        Me.cb_shift.Location = New System.Drawing.Point(111, 417)
        Me.cb_shift.Name = "cb_shift"
        Me.cb_shift.Size = New System.Drawing.Size(186, 24)
        Me.cb_shift.TabIndex = 55
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(708, 603)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 38)
        Me.btnClear.TabIndex = 56
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(518, 46)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(258, 22)
        Me.txtCari.TabIndex = 57
        '
        'Owner_Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 694)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cb_shift)
        Me.Controls.Add(Me.dgv_data_karyawan)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtGaji)
        Me.Controls.Add(Me.txtRegAlamat)
        Me.Controls.Add(Me.txtRegMail)
        Me.Controls.Add(Me.txtRegNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Owner_Karyawan"
        Me.Text = "Owner_Karyawan"
        CType(Me.dgv_data_karyawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_data_karyawan As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtGaji As TextBox
    Friend WithEvents txtRegAlamat As TextBox
    Friend WithEvents txtRegMail As TextBox
    Friend WithEvents txtRegNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_shift As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtCari As TextBox
End Class
