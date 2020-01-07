Imports MySql.Data.MySqlClient
Public Class Fregistrasi
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
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(1).HeaderText = "Username"
        DataGridView1.Columns(2).HeaderText = "Password"
        DataGridView1.Columns(3).HeaderText = "Nama Lengkap"
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.BlueViolet
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
    End Sub
    Sub tampilangrid()

        da = New MySqlDataAdapter("select * from t_user", conn)
        ds = New DataSet
        da.Fill(ds, "t_user")
        DataGridView1.DataSource = ds.Tables("t_user")
        DataGridView1.ReadOnly = True
        aturangrid()

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Fregistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilangrid()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        koneksi()
        Try
            Dim str As String
            str = "insert into t_user values('null','" & tb_user.Text & "','" & tb_pass.Text & "','" & tb_namaleng.Text & "','" & cb_level.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("insert data user berhasil dilakukan")
            tampilangrid()
            kosong()
        Catch ex As Exception
            MessageBox.Show("insert user siswa gagal dilakukan")
        End Try
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        kosong()
    End Sub

    Sub kosong()
        tb_user.Text = ""
        tb_pass.Text = ""
        tb_namaleng.Text = ""
        cb_level.Text = ""
        tb_user.Focus()

    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Close()
        Fmenu.Show()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If MessageBox.Show("yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            Dim hapus As String = "delete from t_user where user='" & tb_user.Text & "'"
            cmd = New MySqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            tampilangrid()
            kosong()
        End If
    End Sub

   
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        tb_user.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        tb_pass.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tb_namaleng.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        cb_level.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value

    End Sub


End Class