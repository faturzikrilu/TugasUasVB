<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fsiswa
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
        Me.tb_tanggal_lahir = New System.Windows.Forms.TextBox()
        Me.tb_tempat_lahir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_nmsiswa = New System.Windows.Forms.TextBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nohp_siswa = New System.Windows.Forms.TextBox()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_perkerjaan_ortu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_nohp_ortu = New System.Windows.Forms.TextBox()
        Me.tb_nm_orgtua = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rb_laki = New System.Windows.Forms.RadioButton()
        Me.rb_perem = New System.Windows.Forms.RadioButton()
        Me.cb_agama = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_tanggal_lahir
        '
        Me.tb_tanggal_lahir.Location = New System.Drawing.Point(184, 160)
        Me.tb_tanggal_lahir.Name = "tb_tanggal_lahir"
        Me.tb_tanggal_lahir.Size = New System.Drawing.Size(190, 20)
        Me.tb_tanggal_lahir.TabIndex = 21
        '
        'tb_tempat_lahir
        '
        Me.tb_tempat_lahir.Location = New System.Drawing.Point(184, 134)
        Me.tb_tempat_lahir.Name = "tb_tempat_lahir"
        Me.tb_tempat_lahir.Size = New System.Drawing.Size(190, 20)
        Me.tb_tempat_lahir.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tempat Lahir"
        '
        'tb_nmsiswa
        '
        Me.tb_nmsiswa.Location = New System.Drawing.Point(184, 108)
        Me.tb_nmsiswa.Name = "tb_nmsiswa"
        Me.tb_nmsiswa.Size = New System.Drawing.Size(190, 20)
        Me.tb_nmsiswa.TabIndex = 17
        '
        'tb_nis
        '
        Me.tb_nis.Location = New System.Drawing.Point(184, 82)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(190, 20)
        Me.tb_nis.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "NIS"
        '
        'tb_nohp_siswa
        '
        Me.tb_nohp_siswa.Location = New System.Drawing.Point(586, 108)
        Me.tb_nohp_siswa.Name = "tb_nohp_siswa"
        Me.tb_nohp_siswa.Size = New System.Drawing.Size(190, 20)
        Me.tb_nohp_siswa.TabIndex = 29
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(586, 82)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(190, 20)
        Me.tb_alamat.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nomer HP. Siswa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(497, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Agama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Kelamin"
        '
        'tb_perkerjaan_ortu
        '
        Me.tb_perkerjaan_ortu.Location = New System.Drawing.Point(586, 186)
        Me.tb_perkerjaan_ortu.Name = "tb_perkerjaan_ortu"
        Me.tb_perkerjaan_ortu.Size = New System.Drawing.Size(190, 20)
        Me.tb_perkerjaan_ortu.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(416, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 18)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Pekerjaan Orangtua"
        '
        'tb_nohp_ortu
        '
        Me.tb_nohp_ortu.Location = New System.Drawing.Point(586, 160)
        Me.tb_nohp_ortu.Name = "tb_nohp_ortu"
        Me.tb_nohp_ortu.Size = New System.Drawing.Size(190, 20)
        Me.tb_nohp_ortu.TabIndex = 33
        '
        'tb_nm_orgtua
        '
        Me.tb_nm_orgtua.Location = New System.Drawing.Point(586, 134)
        Me.tb_nm_orgtua.Name = "tb_nm_orgtua"
        Me.tb_nm_orgtua.Size = New System.Drawing.Size(190, 20)
        Me.tb_nm_orgtua.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(402, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 18)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Nomer HP. Orangtua"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(439, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 18)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Nama Orangtua"
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(323, 261)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 38
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.Location = New System.Drawing.Point(404, 261)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 37
        Me.btn_batal.Text = "BATAL"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 24)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "INPUT DATA SISWA"
        '
        'btn_hapus
        '
        Me.btn_hapus.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(485, 261)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 41
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(566, 261)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 40
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(242, 261)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 42
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(778, 150)
        Me.DataGridView1.TabIndex = 43
        '
        'rb_laki
        '
        Me.rb_laki.AutoSize = True
        Me.rb_laki.Location = New System.Drawing.Point(184, 190)
        Me.rb_laki.Name = "rb_laki"
        Me.rb_laki.Size = New System.Drawing.Size(64, 17)
        Me.rb_laki.TabIndex = 44
        Me.rb_laki.TabStop = True
        Me.rb_laki.Text = "Laki-laki"
        Me.rb_laki.UseVisualStyleBackColor = True
        '
        'rb_perem
        '
        Me.rb_perem.AutoSize = True
        Me.rb_perem.Location = New System.Drawing.Point(269, 190)
        Me.rb_perem.Name = "rb_perem"
        Me.rb_perem.Size = New System.Drawing.Size(79, 17)
        Me.rb_perem.TabIndex = 45
        Me.rb_perem.TabStop = True
        Me.rb_perem.Text = "Perempuan"
        Me.rb_perem.UseVisualStyleBackColor = True
        '
        'cb_agama
        '
        Me.cb_agama.FormattingEnabled = True
        Me.cb_agama.Items.AddRange(New Object() {"Islam", "Hindu", "Budha", "Protestan", "Katholik"})
        Me.cb_agama.Location = New System.Drawing.Point(184, 213)
        Me.cb_agama.Name = "cb_agama"
        Me.cb_agama.Size = New System.Drawing.Size(121, 21)
        Me.cb_agama.TabIndex = 46
        '
        'Fsiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 452)
        Me.Controls.Add(Me.cb_agama)
        Me.Controls.Add(Me.rb_perem)
        Me.Controls.Add(Me.rb_laki)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.tb_perkerjaan_ortu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_nohp_ortu)
        Me.Controls.Add(Me.tb_nm_orgtua)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_nohp_siswa)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_tanggal_lahir)
        Me.Controls.Add(Me.tb_tempat_lahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_nmsiswa)
        Me.Controls.Add(Me.tb_nis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fsiswa"
        Me.Text = "Fsiswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_tanggal_lahir As System.Windows.Forms.TextBox
    Friend WithEvents tb_tempat_lahir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_nmsiswa As System.Windows.Forms.TextBox
    Friend WithEvents tb_nis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_nohp_siswa As System.Windows.Forms.TextBox
    Friend WithEvents tb_alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_perkerjaan_ortu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_nohp_ortu As System.Windows.Forms.TextBox
    Friend WithEvents tb_nm_orgtua As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents rb_laki As System.Windows.Forms.RadioButton
    Friend WithEvents rb_perem As System.Windows.Forms.RadioButton
    Friend WithEvents cb_agama As System.Windows.Forms.ComboBox
End Class
