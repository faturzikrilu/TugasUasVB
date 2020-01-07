Imports MySql.Data.MySqlClient
Public Class Fsiswa
    Public conn As MySqlConnection
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim rd As MySqlDataReader
    Dim cmd As MySqlCommand
    Dim lokasidata As String

    Sub koneksi()
        Dim url, server, user, password, database As String
        server = "localhost"
        user = "root"
        password = ""
        database = "db_sma"
        url = "server=" & server & "; user id=" & user & "; password=" & password & "; database=" & database
        conn = New MySqlConnection(url)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub aturangrid()
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 130
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 70
        DataGridView1.Columns(5).Width = 70
        DataGridView1.Columns(6).Width = 150
        DataGridView1.Columns(7).Width = 130
        DataGridView1.Columns(8).Width = 130
        DataGridView1.Columns(9).Width = 135
        DataGridView1.Columns(10).Width = 130
        DataGridView1.Columns(0).HeaderText = "NIS"
        DataGridView1.Columns(1).HeaderText = "Nama Siswa"
        DataGridView1.Columns(2).HeaderText = "Tempat Lahir"
        DataGridView1.Columns(3).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns(4).HeaderText = "Kelamin"
        DataGridView1.Columns(5).HeaderText = "Agama"
        DataGridView1.Columns(6).HeaderText = "Alamat"
        DataGridView1.Columns(7).HeaderText = "Nomer HP. Siswa"
        DataGridView1.Columns(8).HeaderText = "Nama Orangtua"
        DataGridView1.Columns(9).HeaderText = "Nomer HP. Orangtua"
        DataGridView1.Columns(10).HeaderText = "Pekerjaan Orangtua"
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.BlueViolet
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
    End Sub

    Sub tampilangrid()

        da = New MySqlDataAdapter("select * from t_siswa", conn)
        ds = New DataSet
        da.Fill(ds, "t_siswa")
        DataGridView1.DataSource = ds.Tables("t_siswa")
        DataGridView1.ReadOnly = True
        Call aturangrid()
    End Sub


    Private Sub Fsiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilangrid()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        kosong()
    End Sub

    Sub kosong()
        tb_nis.Text = ""
        tb_nmsiswa.Text = ""
        tb_tempat_lahir.Text = ""
        tb_tanggal_lahir.Text = ""
        rb_laki.Checked = False
        rb_perem.Checked = False
        tb_nm_orgtua.Text = ""
        tb_nohp_ortu.Text = ""
        cb_agama.Text = ""
        tb_alamat.Text = ""
        tb_nohp_siswa.Text = ""
        tb_perkerjaan_ortu.Text = ""
        tb_nis.Focus()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Close()
        Fmenu.Show()
    End Sub

    Private Sub tb_nis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nis.KeyPress
        tb_nis.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("select * from t_siswa where nis='" & tb_nis.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("nis tidak ada, silahkan coba lagi!")
                tb_nis.Focus()
            Else
                tb_nmsiswa.Text = rd.Item("nm_siswa")
                tb_tempat_lahir.Text = rd.Item("tpt_lahir")
                'tb_tanggal_lahir.Text = rd.Item("tgl_lahir")
                Dim tgl As Date = rd.Item("tgl_lahir")
                tb_tanggal_lahir.Text = Format(tgl, "yyyy-MM-dd")
                Dim laki As Char
                laki = rd.Item("kelamin")
                If laki = "L" Then
                    rb_laki.Checked = True
                Else
                    rb_perem.Checked = True
                End If
                cb_agama.Text = rd.Item("agama")
                tb_alamat.Text = rd.Item("alamat")
                tb_nohp_siswa.Text = rd.Item("no_hp_siswa")
                tb_nm_orgtua.Text = rd.Item("nm_ortu")
                tb_nohp_ortu.Text = rd.Item("no_hp_ortu")
                tb_perkerjaan_ortu.Text = rd.Item("pekerj_ortu")
            End If
            rd.Close()
            End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        koneksi()
        Try
            Dim jeniskel As String
            Dim str As String
            If rb_laki.Checked = True Then
                jeniskel = "L"
            Else
                jeniskel = "P"
            End If
            str = "insert into t_siswa values('" & tb_nis.Text & "','" & tb_nmsiswa.Text & "','" & tb_tempat_lahir.Text & "','" & tb_tanggal_lahir.Text & "','" & jeniskel & "','" & cb_agama.Text & "','" & tb_alamat.Text & "','" & tb_nohp_siswa.Text & "','" & tb_nm_orgtua.Text & "','" & tb_nohp_ortu.Text & "','" & tb_perkerjaan_ortu.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("insert data siswa berhasil dilakukan")
            tampilangrid()
            kosong()
        Catch ex As Exception
            MessageBox.Show("insert data siswa gagal dilakukan")
        End Try
    End Sub

    Private Sub tb_nis_TextChanged(sender As Object, e As EventArgs) Handles tb_nis.TextChanged

    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If tb_nis.Text = "" Then
            MsgBox("silahkan pilih data yang akan dihapus dengan masukan NIS dan ENTER")
        Else
            If MessageBox.Show("yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                koneksi()
                Dim hapus As String = "delete from t_siswa where nis='" & tb_nis.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                tampilangrid()
                kosong()
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call koneksi()
        Dim edit As String = "update t_siswa set nm_siswa= '" & tb_nmsiswa.Text & "',tpt_lahir='" & tb_tempat_lahir.Text & "',tgl_lahir='" & tb_tanggal_lahir.Text & "',agama='" & cb_agama.Text & "',alamat='" & tb_alamat.Text & "',no_hp_siswa='" & tb_nohp_siswa.Text & "',nm_ortu='" & tb_nm_orgtua.Text & "',no_hp_ortu='" & tb_nohp_ortu.Text & "',pekerj_ortu='" & tb_perkerjaan_ortu.Text & "' where nis='" & tb_nis.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("data berhasil di edit", MsgBoxStyle.Information, "information")
        tampilangrid()
        kosong()


    End Sub
End Class