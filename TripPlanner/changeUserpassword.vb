Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Public Class changeuserpassword
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")
    Private Sub bind_data()
        Dim cmd As New OleDbCommand("select *from users ", con)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        userDataGridView.DataSource = admin

    End Sub
    Private Sub changeuserpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        If TxtId.Text = Nothing Or TxtUsername.Text = Nothing Or TxtPassword.Text = Nothing Then
            MessageBox.Show("Please enter details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM users WHERE[id]=@id", con)
        cmd.Parameters.AddWithValue("@id", OleDbType.VarChar).Value = TxtId.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtId.Clear()
                TxtUsername.Clear()
                TxtPassword.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        Dim str As String
        str = "INSERT INTO users([ID],[username],[password]) values (@id, @username, @password)"
        Dim cmd1 As New OleDbCommand(str, con)
        cmd1.Parameters.Add(New OleDbParameter("@id", CType(TxtId.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@username", CType(TxtUsername.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@password", CType(TxtPassword.Text, String)))
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Try
            cmd1.ExecuteNonQuery()

            TxtId.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        bind_data()
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles Btnedit.Click
        Dim access As String
        If TxtId.Text = Nothing Or TxtUsername.Text = Nothing Or TxtPassword.Text = Nothing Then
            MessageBox.Show("Please details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        con.Open()

        con.Close()
        access = "UPDATE users SET [username] = '" & TxtUsername.Text & "', [password] = '" & TxtPassword.Text & "' where ID=" & TxtId.Text & ""
        Dim cmd As New OleDbCommand(access, con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            TxtId.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bind_data()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim cmd4 As New OleDbCommand("DELETE FROM users WHERE id=@id", con)

        cmd4.Parameters.Add(New OleDbParameter("@id", CType(TxtId.Text, String)))
        cmd4.Parameters.Add(New OleDbParameter("@username", CType(TxtUsername.Text, String)))
        cmd4.Parameters.Add(New OleDbParameter("@password", CType(TxtPassword.Text, String)))
        Try
            con.Open()
            cmd4.ExecuteNonQuery()
            TxtId.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bind_data()
    End Sub

    Private Sub Btnprint_Click(sender As Object, e As EventArgs) Handles Btnprint.Click
        PrintPreviewDialog1.Document = PrintDocument2
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("select *from users where username like '%' +@parm1+ '%'", con)
        cmd.Parameters.AddWithValue("@parm1", Txtsearch.Text)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        userDataGridView.DataSource = admin
    End Sub

    Private Sub Btnshow_Click(sender As Object, e As EventArgs) Handles Btnshow.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from users where ID=@parm1", con)
        cmd2.Parameters.AddWithValue("@parm1", TxtId.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            TxtUsername.Text = myreader("username")
            TxtPassword.Text = myreader("password")

        Else
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            MsgBox("data is not found")
        End If
        con.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        setting.Show()
        Me.Hide()

    End Sub
End Class