Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Public Class changeAdminpassword
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")

    Private Sub bind_data()
        Dim cmd As New OleDbCommand("select *from admins ", con)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        adminDataGridView.DataSource = admin

    End Sub

    Private Sub Btnshow_Click(sender As Object, e As EventArgs) Handles Btnshow.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from admins where ID=@parm1", con)
        cmd2.Parameters.AddWithValue("@parm1", Txtid.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            Txtusername.Text = myreader("username")
            Txtpassword.Text = myreader("password")

        Else
            Txtusername.Text = ""
            Txtpassword.Text = ""
            MsgBox("data is not found")
        End If
        con.Close()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        If Txtid.Text = Nothing Or Txtusername.Text = Nothing Or Txtpassword.Text = Nothing Then
            MessageBox.Show("Please enter details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM admins WHERE[id]=@id", con)
        cmd.Parameters.AddWithValue("@id", OleDbType.VarChar).Value = Txtid.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtid.Clear()
                Txtusername.Clear()
                Txtpassword.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        Dim str As String
        str = "INSERT INTO admins([ID],[username],[password]) values (@id, @username, @password)"
        Dim cmd1 As New OleDbCommand(str, con)
        cmd1.Parameters.Add(New OleDbParameter("@id", CType(Txtid.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@username", CType(Txtusername.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@password", CType(Txtpassword.Text, String)))
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Try
            cmd1.ExecuteNonQuery()

            Txtid.Clear()
            Txtusername.Clear()
            Txtpassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        bind_data()
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles Btnedit.Click
        Dim access As String
        If Txtid.Text = Nothing Or Txtusername.Text = Nothing Or Txtpassword.Text = Nothing Then
            MessageBox.Show("Please details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd1 As New OleDbCommand("SELECT COUNT(*) FROM admins WHERE[username]=@username", con)
        cmd1.Parameters.AddWithValue("@placename", OleDbType.VarChar).Value = Txtusername.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd1.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("This username is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Txtusername.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        access = "UPDATE admins SET [username] = '" & Txtusername.Text & "', [password] = '" & Txtpassword.Text & "' where ID=" & Txtid.Text & ""
        Dim cmd As New OleDbCommand(access, con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Txtid.Clear()
            Txtusername.Clear()
            Txtpassword.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bind_data()

    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim cmd4 As New OleDbCommand("DELETE FROM admins WHERE id=@id", con)

        cmd4.Parameters.Add(New OleDbParameter("@id", CType(Txtid.Text, String)))
        cmd4.Parameters.Add(New OleDbParameter("@username", CType(Txtusername.Text, String)))
        cmd4.Parameters.Add(New OleDbParameter("@password", CType(Txtpassword.Text, String)))
        Try
            con.Open()
            cmd4.ExecuteNonQuery()
            Txtid.Clear()
            Txtusername.Clear()
            Txtpassword.Clear()

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

    Private Sub adminDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles adminDataGridView.CellClick
        Try
            Dim index As Integer
            Dim selectrows As DataGridViewRow = adminDataGridView.Rows(index)
            Txtid.Text = selectrows.Cells(0).Value.ToString
            Txtusername.Text = selectrows.Cells(1).Value.ToString
            Txtpassword.Text = selectrows.Cells(2).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        setting.Show()
        Me.Hide()

    End Sub

    Private Sub changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adminDataGridView.DataSource = GetAdminList()
        bind_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("select *from admins where username like '%' +@parm1+ '%'", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox1.Text)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        adminDataGridView.DataSource = admin
    End Sub
End Class