Imports MySql.Data.MySqlClient
Public Class Form1
    Public CONN As MySqlConnection
    Dim DS As New DataSet
    Dim DA As MySqlDataAdapter
    Dim RD As MySqlDataReader
    Dim CMD As MySqlCommand
    Dim LokasiData As String
    'Public userlogin As String
    Sub koneksi()
        Dim url, server, user, password, database As String
        server = "localhost"
        user = "root"
        password = ""
        database = "db_sma"
        url = "Server=" & server & "; user id=" & user & "; password=" & password & "; database=" & database
        CONN = New MySqlConnection(url)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub

    Private Sub btn_masuk_Click(sender As Object, e As EventArgs) Handles btn_masuk.Click
        koneksi()
        login()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        kosong()
    End Sub

    Sub kosong()
        tb_username.Text = ""
        tb_pass.Text = ""
        cb_level.Text = ""
        tb_username.Focus()
    End Sub

    Sub login()
        Dim sql, usr, pass, lev As String
        usr = tb_username.Text
        pass = tb_pass.Text
        lev = cb_level.SelectedItem
        sql = "select * from t_user where user='" + usr + "' AND password='" + pass + "' AND level='" + lev + "'"
        CMD = New MySqlCommand(sql, CONN)
        RD = CMD.ExecuteReader()
        If RD.HasRows = True Then
            If lev = "Admin" Then
                Fmenu.Show()
                Me.Hide()
            Else
                Fmenu.RegistrasiToolStripMenuItem.Enabled = False
                Fmenu.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("kombinasi username, password dan level salah", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            kosong()
        End If
        'userlogin = RD.Item("nm_user")
        RD.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
