Imports System.Data.OleDb
Public Class viewplan
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")

    Private Sub bind_data()
        Dim cmd As New OleDbCommand("select *from plans ", con)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        DataGridView1.DataSource = admin

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        selectedplace.Show()
        Me.Hide()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from plans where ID=@plan", con)
        cmd2.Parameters.AddWithValue("@plan", TxtID.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            TxtID.Text = myreader("placename")

        Else
            TxtID.Text = ""
            MsgBox("data is not found")
        End If
        con.Close()

        Dim cmd4 As New OleDbCommand("DELETE FROM plans WHERE id=@id", con)
        cmd4.Parameters.Add(New OleDbParameter("@id", CType(TxtID.Text, String)))
        Try
            con.Open()
            cmd4.ExecuteNonQuery()
            TxtID.Clear()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bind_data()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim index As Integer
            Dim selectrows As DataGridViewRow = DataGridView1.Rows(index)
            TxtID.Text = selectrows.Cells(0).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub viewplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand("select *from plans where placename like '%' +@parm1+ '%'", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox2.Text)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        DataGridView1.DataSource = admin
    End Sub
End Class