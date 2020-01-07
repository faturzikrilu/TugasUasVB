Imports MySql.Data.MySqlClient
Public Class Fkelas
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
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(0).HeaderText = "NIS"
        DataGridView1.Columns(1).HeaderText = "Kelas"
        DataGridView1.Columns(2).HeaderText = "KD Guru"
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.BlueViolet
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
    End Sub

    Sub tampilangrid()
        da = New MySqlDataAdapter("select * from t_pembagian_kls", conn)
        ds = New DataSet
        da.Fill(ds, "t_pembagian_kls")
        DataGridView1.DataSource = ds.Tables("t_pembagian_kls")
        DataGridView1.ReadOnly = True
        aturangrid()
    End Sub

    Private Sub Fkelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        CBnis()
        CBkd()
        tampilangrid()

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        kosong()
    End Sub

    Sub kosong()
        cb_nis.Text = ""
        cb_kls.Text = ""
        cb_kd.Text = ""
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

    Sub CBkd()
        cmd = New MySqlCommand("select * from t_guru", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cb_kd.Items.Add(rd("kd_guru") & Space(5) & rd("nama"))
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
            str = "insert into t_pembagian_kls values('" & cb_nis.Text & "','" & cb_kls.Text & "','" & cb_kd.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("insert data kelas berhasil dilakukan")
            tampilangrid()
            kosong()
        Catch ex As Exception
            MessageBox.Show("insert data kelas gagal dilakukan")
        End Try
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If MessageBox.Show("yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            Dim hapus As String = "delete from t_pembagian_kls where nis='" & cb_nis.Text & "'"
            cmd = New MySqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            tampilangrid()
            kosong()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        cb_nis.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        cb_kls.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        cb_kd.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub

End Class