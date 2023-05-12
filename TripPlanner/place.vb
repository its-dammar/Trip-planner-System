Public Class Places
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        userlogin.Show()
        Me.Hide()


    End Sub

    Private Sub LakeSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LakeSideToolStripMenuItem.Click
        lakeside.Show()
        Me.Hide()
    End Sub

    Private Sub MahendraCaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahendraCaveToolStripMenuItem.Click
        mahendracave.Show()
        Me.Hide()
    End Sub

    Private Sub HuguToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HuguToolStripMenuItem.Click
        hugu.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        home.Show()
        Me.Hide()

    End Sub

    Private Sub TalbarahiTampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TalbarahiTampleToolStripMenuItem.Click
        talbarahi.Show()
        Me.Hide()

    End Sub

    Private Sub Places_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SarankotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SarankotToolStripMenuItem.Click
        sarangkot.Show()
        Me.Hide()

    End Sub

    Private Sub DavisFallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DavisFallToolStripMenuItem.Click
        davisfall.Show()
        Me.Hide()

    End Sub

    Private Sub KapucheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapucheToolStripMenuItem.Click
        Kapuche.Show()
        Me.Hide()

    End Sub
End Class