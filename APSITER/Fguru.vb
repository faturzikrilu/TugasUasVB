Imports MySql.Data.MySqlClient
Public Class Fguru
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
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 130
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 70
        DataGridView1.Columns(6).Width = 70
        DataGridView1.Columns(7).Width = 130
        DataGridView1.Columns(8).Width = 100
        DataGridView1.Columns(9).Width = 70
        DataGridView1.Columns(0).HeaderText = "KD Guru"
        DataGridView1.Columns(1).HeaderText = "NIP"
        DataGridView1.Columns(2).HeaderText = "Nama"
        DataGridView1.Columns(3).HeaderText = "Tempat Lahir"
        DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns(5).HeaderText = "Kelamin"
        DataGridView1.Columns(6).HeaderText = "Agama"
        DataGridView1.Columns(7).HeaderText = "Alamat"
        DataGridView1.Columns(8).HeaderText = "Nomer HP"
        DataGridView1.Columns(9).HeaderText = "Mapel"
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.BlueViolet
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
    End Sub
    Sub tampilangrid()

        da = New MySqlDataAdapter("select * from t_guru", conn)
        ds = New DataSet
        da.Fill(ds, "t_guru")
        DataGridView1.DataSource = ds.Tables("t_guru")
        DataGridView1.ReadOnly = True
        aturangrid()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tb_nip.TextChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_kd.TextChanged

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles tb_tempat_lahir.TextChanged

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles tb_alamat.TextChanged

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles tb_nomerhp.TextChanged

    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles tb_tanggal_lahir.TextChanged

    End Sub
    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles tb_mapel.TextChanged

    End Sub
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        kosong()
    End Sub
    Sub kosong()
        tb_kd.Text = ""
        tb_nip.Text = ""
        tb_nama.Text = ""
        tb_tempat_lahir.Text = ""
        tb_tanggal_lahir.Text = ""
        rb_laki.Checked = False
        rb_perem.Checked = False
        cb_agama.Text = ""
        tb_alamat.Text = ""
        tb_nomerhp.Text = ""
        tb_mapel.Text = ""
        tb_kd.Focus()
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
            str = "insert into t_guru values('" & tb_kd.Text & "','" & tb_nip.Text & "','" & tb_nama.Text & "','" & tb_tempat_lahir.Text & "','" & tb_tanggal_lahir.Text & "','" & jeniskel & "','" & cb_agama.Text & "','" & tb_alamat.Text & "','" & tb_nomerhp.Text & "','" & tb_mapel.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("insert data guru berhasil dilakukan")
            tampilangrid()
            kosong()
        Catch ex As Exception
            MessageBox.Show("insert data guru gagal dilakukan")
        End Try
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Close()
        Fmenu.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If tb_kd.Text = "" Then
            MsgBox("silahkan pilih data yang akan dihapus dengan masukan KD Guru dan ENTER")
        Else
            If MessageBox.Show("yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                koneksi()
                Dim hapus As String = "delete from t_guru where kd_guru ='" & tb_kd.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                tampilangrid()
                kosong()
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tb_nama.TextChanged

    End Sub

    Private Sub Fguru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilangrid()
    End Sub

    Private Sub tb_kd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_kd.KeyPress
        tb_kd.MaxLength = 6
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("select * from t_guru where kd_guru='" & tb_kd.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("kd guru tidak ada, silahkan coba lagi!")
                tb_kd.Focus()
            Else
                tb_nip.Text = rd.Item("nip")
                tb_nama.Text = rd.Item("nama")
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
                tb_nomerhp.Text = rd.Item("no_hp")
                tb_mapel.Text = rd.Item("mapel")
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call koneksi()
        Dim edit As String = "update t_guru set nip= '" & tb_nip.Text & "',nama='" & tb_nama.Text & "',tpt_lahir='" & tb_tempat_lahir.Text & "',tgl_lahir='" & tb_tanggal_lahir.Text & "',agama='" & cb_agama.Text & "',alamat='" & tb_alamat.Text & "',no_hp='" & tb_nomerhp.Text & "',mapel='" & tb_mapel.Text & "' where kd_guru='" & tb_kd.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("data berhasil di edit", MsgBoxStyle.Information, "information")
        tampilangrid()
        kosong()
    End Sub
End Class