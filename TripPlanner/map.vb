Imports System.Text
Public Class map
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Places.Show()

        Me.Hide()

    End Sub

    Private Sub Btnmap_Click(sender As Object, e As EventArgs) Handles Btnmap.Click
        Dim state As String
        Dim city As String
        Dim street As String
        state = Txtstate.Text
        city = Txtcity.Text
        street = Txtstreet.Text
        Dim GetAddress As New StringBuilder
        GetAddress.Append("https://maps.google.com/maps?q=")
        If Txtstate.Text <> "" Then
            '<> means is not equal to
            GetAddress.Append(state + "," & "+")

        End If
        If Txtcity.Text <> "" Then
            '<> means is not equal to
            GetAddress.Append(city + "," & "+")

        End If
        If Txtstreet.Text <> "" Then
            '<> means is not equal to
            GetAddress.Append(street + "," & "+")

        End If
        Browser.Navigate(GetAddress.ToString)
    End Sub
End Class