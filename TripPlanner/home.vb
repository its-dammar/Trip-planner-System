Public Class home
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logout.LinkClicked
        userlogin.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        adminlogin.Show()
        Me.Hide()
    End Sub

    Private Sub Btnplaces_Click(sender As Object, e As EventArgs) Handles Btnplaces.Click
        Places.Show()
        Me.Hide()

    End Sub

    Private Sub Btnselected_Click(sender As Object, e As EventArgs) Handles Btnselected.Click
        selectedplace.Show()
        Me.Hide()

    End Sub

    Private Sub Btnaboutapp_Click(sender As Object, e As EventArgs) Handles Btnaboutapp.Click
        aboutapp.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        landingForm.Show()
        Me.Hide()
    End Sub
End Class