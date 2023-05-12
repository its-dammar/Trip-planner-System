Imports System.Data.OleDb
Public Class selectedplace
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")

    Private Sub bind_data()
        Dim cmd As New OleDbCommand("select *from selectedplaces ", con)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        selectedplaceDataGridView.DataSource = admin

    End Sub
    Private Sub selectedplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        home.Show()
        Me.Hide()

    End Sub

    Private Sub Btnshow_Click(sender As Object, e As EventArgs) Handles Btnshow.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from selectedplaces where ID=@parm1", con)
        cmd2.Parameters.AddWithValue("@parm1", Txtid.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            Txtplacename.Text = myreader("placename")

        Else
            Txtplacename.Text = ""
            MsgBox("data is not found")
        End If
        con.Close()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        If Txtid.Text = Nothing Or Txtplacename.Text = Nothing Then
            MessageBox.Show("Please enter id and place name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM selectedplaces WHERE[id]=@id or [placename]=@placename", con)
        cmd.Parameters.AddWithValue("@id", OleDbType.VarChar).Value = Txtid.Text.Trim
        cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = Txtplacename.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("ID or Place Name is already take", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtid.Clear()
                Txtplacename.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Dim str As String
        str = "INSERT INTO selectedplaces([ID],[placename]) values (@id, @placename)"
        Dim cmd1 As New OleDbCommand(str, con)
        cmd1.Parameters.Add(New OleDbParameter("@id", CType(Txtid.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@placename", CType(Txtplacename.Text, String)))
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Try
            cmd1.ExecuteNonQuery()

            Txtid.Clear()
            Txtplacename.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        bind_data()
    End Sub

    Private Sub selectedplaceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles selectedplaceDataGridView.CellContentClick
        Try
            Dim index As Integer
            Dim selectrows As DataGridViewRow = selectedplaceDataGridView.Rows(index)
            Txtid.Text = selectrows.Cells(0).Value.ToString
            Txtplacename.Text = selectrows.Cells(1).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles Btnedit.Click
        Dim access As String
        If Txtid.Text = Nothing Or Txtplacename.Text = Nothing Then
            MessageBox.Show("Please details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If


        Dim cmd1 As New OleDbCommand("SELECT COUNT(*) FROM selectedplaces WHERE[placename]=@placename", con)
        cmd1.Parameters.AddWithValue("@placename", OleDbType.VarChar).Value = Txtplacename.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd1.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("This place is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtid.Clear()
                Txtplacename.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        access = "UPDATE selectedplaces SET [placename] = '" & Txtplacename.Text & "' where ID=" & Txtid.Text & ""
        Dim cmd As New OleDbCommand(access, con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Txtid.Clear()
            Txtplacename.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bind_data()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from selectedplaces where ID=@parm1", con)
        cmd2.Parameters.AddWithValue("@parm1", Txtid.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            Txtplacename.Text = myreader("placename")

        Else
            Txtplacename.Text = ""
            MsgBox("data is not found")
        End If
        con.Close()

        Dim cmd4 As New OleDbCommand("DELETE FROM selectedplaces WHERE id=@id", con)

        cmd4.Parameters.Add(New OleDbParameter("@id", CType(Txtid.Text, String)))
        cmd4.Parameters.Add(New OleDbParameter("@username", CType(Txtplacename.Text, String)))
        Try
            con.Open()
            cmd4.ExecuteNonQuery()
            Txtid.Clear()
            Txtplacename.Clear()

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

    Private Sub Btnsearch_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click
        Dim cmd As New OleDbCommand("select *from selectedplaces where placename like '%' +@parm1+ '%'", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox1.Text)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        selectedplaceDataGridView.DataSource = admin
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        setplan.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AddPlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPlanToolStripMenuItem.Click
        setplan.Show()
        Me.Hide()
    End Sub

    Private Sub ViewPlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPlanToolStripMenuItem.Click
        viewplan.show()
        Me.Hide()

    End Sub
End Class