Public Class Fmenu

    Private Sub RegistrasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrasiToolStripMenuItem.Click
        Fregistrasi.Show()
        Me.Hide()
    End Sub

    Private Sub SiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaToolStripMenuItem.Click
        Fsiswa.Show()
        Me.Hide()
    End Sub

    Private Sub GuruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuruToolStripMenuItem.Click
        Fguru.Show()
        Me.Hide()
    End Sub

    Private Sub KelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelasToolStripMenuItem.Click
        Fkelas.Show()
        Me.Hide()
    End Sub

    Private Sub TerlambatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerlambatToolStripMenuItem.Click
        Fterlambat.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
        Form1.kosong()

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Fmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class