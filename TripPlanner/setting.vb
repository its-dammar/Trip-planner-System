Public Class setting
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        home.Show()
        Me.Hide()

    End Sub

    Private Sub ChangeUsernamePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUsernamePasswordToolStripMenuItem.Click
        changeuserpassword.show()
        Me.Hide()

    End Sub

    Private Sub ChangeUsernamePasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangeUsernamePasswordToolStripMenuItem1.Click
        changeAdminpassword.Show()
        Me.Hide()

    End Sub

    Private Sub AddImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddImageToolStripMenuItem.Click
        addimage.Show()
        Me.Hide()

    End Sub

    Private Sub DetailsAboutPlaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsAboutPlaceToolStripMenuItem.Click
        crudplacedetails.Show()
        Me.Hide()

    End Sub

    Private Sub AddPlaceDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPlaceDetailsToolStripMenuItem.Click
        addplacedetails.Show()
        Me.Hide()

    End Sub

    Private Sub AddAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAdminToolStripMenuItem.Click
        addadmin.Show()
        Me.Hide()

    End Sub
End Class