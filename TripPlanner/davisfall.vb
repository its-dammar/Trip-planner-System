Imports System.Data.OleDb
Public Class davisfall
    Dim str As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        map.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        map.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Places.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Do you want to add this place in your selected place?")

        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM selectedplaces WHERE[placename]=@placename", con)
        cmd.Parameters.AddWithValue("@placename", OleDbType.VarChar).Value = Label1.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("This Place is already add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        str = "INSERT INTO selectedplaces ([placename]) VALUES (?)"
        Dim create As OleDbCommand = New OleDbCommand(str, con)
        create.Parameters.Add(New OleDbParameter("placename", CType(Label1.Text, String)))

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            create.ExecuteNonQuery()
            MsgBox("Add successfull")
            Me.Refresh()
            Me.Show()

            'create.Dispose()

            'clear text from the textbox


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub
End Class