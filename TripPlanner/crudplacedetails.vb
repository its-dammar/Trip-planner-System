Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Public Class crudplacedetails
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")

    Private Sub bind_data()
        Dim cmd As New OleDbCommand("select *from placedetails ", con)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        DataGridView1.DataSource = admin
    End Sub

    Private Sub crudplacedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim cmd4 As New OleDbCommand("DELETE FROM placedetails WHERE id=@id", con)

        cmd4.Parameters.Add(New OleDbParameter("@id", CType(TextBox1.Text, String)))

        Try
            con.Open()
            cmd4.ExecuteNonQuery()
            TextBox1.Clear()

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
            TextBox1.Text = selectrows.Cells(0).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click
        Dim cmd As New OleDbCommand("select *from plcedetails where title like '%' +@parm1+ '%'", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox2.Text)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        DataGridView1.DataSource = admin
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        setting.Show()
        Me.Hide()

    End Sub
End Class

