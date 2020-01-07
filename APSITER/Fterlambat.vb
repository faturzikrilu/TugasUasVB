Imports MySql.Data.MySqlClient
Public Class Fterlambat
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
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 210
        DataGridView1.Columns(0).HeaderText = "NIS"
        DataGridView1.Columns(1).HeaderText = "Tanggal"
        DataGridView1.Columns(2).HeaderText = "Waktu"
        DataGridView1.Columns(3).HeaderText = "Alasan"
        DataGridView1.Columns(4).HeaderText = "Peringatan"
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.BlueViolet
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
    End Sub
    Sub tampilangrid()
        da = New MySqlDataAdapter("select * from t_terlambat", conn)
        ds = New DataSet
        da.Fill(ds, "t_terlambat")
        DataGridView1.DataSource = ds.Tables("t_terlambat")
        DataGridView1.ReadOnly = True
        aturangrid()

    End Sub

    Private Sub Fterlambat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilangrid()
        CBnis()
        tb_tgl.Enabled = False
        tb_waktu.Enabled = False
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        kosong()
    End Sub
    Sub kosong()
        cb_nis.Text = ""
        tb_alasan.Text = ""
        tb_peringatan.Text = ""
        cb_nis.Focus()
    End Sub

    Sub CBnis()
        cmd = New MySqlCommand("select * from t_siswa", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cb_nis.Items.Add(rd("nis") & Space(5) & rd("nm_siswa"))
        Loop
        rd.Close()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Close()
        Fmenu.Show()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        koneksi()
        Try
            Dim str As String
            str = "insert into t_terlambat values('" & cb_nis.Text & "','" & tb_tgl.Text & "','" & tb_waktu.Text & "','" & tb_alasan.Text & "','" & tb_peringatan.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("insert data terlambat berhasil dilakukan")
            tampilangrid()
            kosong()
        Catch ex As Exception
            MessageBox.Show("insert data terlambat gagal dilakukan")
        End Try
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        
            If MessageBox.Show("yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                koneksi()
            Dim hapus As String = "delete from t_terlambat where nis='" & cb_nis.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                tampilangrid()
                kosong()
            End If

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        cb_nis.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_tgl.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        'tb_waktu.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tb_alasan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        tb_peringatan.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tb_tgl.Text = Format(Now, "yyyy/MM/dd")
        tb_waktu.Text = Format(Now, "HH:mm:ss")
        Label6.Text = Format(Now, "dd/MM/yyyy")
        Label7.Text = Format(Now, "HH:mm:ss")
    End Sub
End Class