Imports System.Data.OleDb
'Imports System.Data.DataTable
Public Class hugu
    Dim str As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        map.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Places.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click



    End Sub

    Private Sub hugu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        map.Show()
        Me.Hide()

    End Sub
End Class