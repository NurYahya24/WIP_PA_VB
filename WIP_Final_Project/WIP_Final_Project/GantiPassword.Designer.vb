<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GantiPassword
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
        Me.txtPassLama = New System.Windows.Forms.TextBox()
        Me.txtPassBaru = New System.Windows.Forms.TextBox()
        Me.buttonConfirm = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.seePass1 = New System.Windows.Forms.CheckBox()
        Me.seePass2 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassLama
        '
        Me.txtPassLama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassLama.Location = New System.Drawing.Point(148, 107)
        Me.txtPassLama.Name = "txtPassLama"
        Me.txtPassLama.Size = New System.Drawing.Size(330, 29)
        Me.txtPassLama.TabIndex = 0
        Me.txtPassLama.UseSystemPasswordChar = True
        '
        'txtPassBaru
        '
        Me.txtPassBaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassBaru.Location = New System.Drawing.Point(148, 192)
        Me.txtPassBaru.Name = "txtPassBaru"
        Me.txtPassBaru.Size = New System.Drawing.Size(330, 29)
        Me.txtPassBaru.TabIndex = 1
        Me.txtPassBaru.UseSystemPasswordChar = True
        '
        'buttonConfirm
        '
        Me.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonConfirm.Location = New System.Drawing.Point(148, 262)
        Me.buttonConfirm.Name = "buttonConfirm"
        Me.buttonConfirm.Size = New System.Drawing.Size(330, 42)
        Me.buttonConfirm.TabIndex = 2
        Me.buttonConfirm.Text = "KONFIRMASI"
        Me.buttonConfirm.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 45)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(574, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 45)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(145, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password Lama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(145, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password Baru"
        '
        'seePass1
        '
        Me.seePass1.AutoSize = True
        Me.seePass1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.seePass1.Location = New System.Drawing.Point(148, 140)
        Me.seePass1.Name = "seePass1"
        Me.seePass1.Size = New System.Drawing.Size(94, 17)
        Me.seePass1.TabIndex = 6
        Me.seePass1.Text = "See Password"
        Me.seePass1.UseVisualStyleBackColor = True
        '
        'seePass2
        '
        Me.seePass2.AutoSize = True
        Me.seePass2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.seePass2.Location = New System.Drawing.Point(148, 227)
        Me.seePass2.Name = "seePass2"
        Me.seePass2.Size = New System.Drawing.Size(94, 17)
        Me.seePass2.TabIndex = 7
        Me.seePass2.Text = "See Password"
        Me.seePass2.UseVisualStyleBackColor = True
        '
        'GantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 355)
        Me.Controls.Add(Me.seePass2)
        Me.Controls.Add(Me.seePass1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.buttonConfirm)
        Me.Controls.Add(Me.txtPassBaru)
        Me.Controls.Add(Me.txtPassLama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GantiPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GantiPassword"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassLama As TextBox
    Friend WithEvents txtPassBaru As TextBox
    Friend WithEvents buttonConfirm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents seePass1 As CheckBox
    Friend WithEvents seePass2 As CheckBox
End Class
