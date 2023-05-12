Imports System.Data.OleDb
'Imports System.Data.DataTable
Public Class user
    Dim str As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")
    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click

        If Txtusername.Text = Nothing Or Txtpassword.Text = Nothing Then
            MessageBox.Show("Please enter username and password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM users WHERE[username]=@username", con)
        cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = Txtusername.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("userUame is already take", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtusername.Clear()
                Txtpassword.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        str = "INSERT INTO users ([username],[password]) VALUES (?,?)"
        Dim create As OleDbCommand = New OleDbCommand(str, con)
        create.Parameters.Add(New OleDbParameter("username", CType(Txtusername.Text, String)))
        create.Parameters.Add(New OleDbParameter("password", CType(Txtpassword.Text, String)))

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            create.ExecuteNonQuery()
            'MsgBox("Submit Successfull")
            userlogin.Show()
            Me.Hide()
            'create.Dispose()

            'clear text from the textbox

            Txtusername.Clear()
            Txtpassword.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()

    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        userlogin.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        landingForm.Show()
        Me.Hide()

    End Sub
End Class