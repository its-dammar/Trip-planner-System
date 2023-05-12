Imports System.Data.OleDb
Imports System.IO
'Imports System.Data.DataTable
Public Class addimage
    Dim str As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")
    Private Sub bind_data()
        Dim cmd As New OleDbCommand("select *from images ", con)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        DataGridView1.DataSource = admin

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myphoto As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            With OpenFileDialog1
                .Filter = "jpg, jpeg Image|*.jpg;*.jpeg|PNG Image|*.png|BMP Image|*.bmp|" & "AllowDrop Files (*.*)|*.*"
                .FileName = ""
                .Title = "Choose a picture.."
                .AddExtension = True
                .FilterIndex = 1
                .Multiselect = False
                .ValidateNames = True
                .InitialDirectory = myphoto
                .RestoreDirectory = True
                If (.ShowDialog = DialogResult.OK) Then
                    pbimage.Image = Image.FromFile(OpenFileDialog1.FileName)
                Else
                    Return
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Txtimagename.Text = Nothing Then
            MessageBox.Show("Please enter image name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM images WHERE[imagename]=@imagename", con)
        cmd.Parameters.AddWithValue("@imagemane", OleDbType.VarChar).Value = Txtimagename.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Same Image name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtimagename.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Dim img As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        Dim images As New BinaryReader(img)
        'Dim imgbuffer(img.Length)
        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()

        con.Open()


        img.Close()

        str = "INSERT INTO images ([imagename],[image]) VALUES (@imagename,@image)"
        Dim create As OleDbCommand = New OleDbCommand(str, con)

        create.Parameters.Add(New OleDbParameter("imagename", CType(Txtimagename.Text, String)))
        create.Parameters.AddWithValue("@image", arrImage)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            create.ExecuteNonQuery()
            MsgBox("save data")
            Me.Refresh()
            Me.Show()
            Txtimagename.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        Dim access As String
        access = "UPDATE images SET [imagename] = '" & Txtimagenmaes.Text & " where ID=" & Txtid.Text & ""
        Dim cmd As New OleDbCommand(access, con)

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Try

            cmd.ExecuteNonQuery()

            Txtid.Clear()
            Txtimagenmaes.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bind_data()
        con.Close()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim cmd4 As New OleDbCommand("DELETE FROM images WHERE id=@id", con)

        cmd4.Parameters.Add(New OleDbParameter("@id", CType(Txtid.Text, String)))
        cmd4.Parameters.Add(New OleDbParameter("@imagename", CType(Txtimagenmaes.Text, String)))

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Try
            cmd4.ExecuteNonQuery()
            Txtid.Clear()
            Txtimagenmaes.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bind_data()
        con.Close()

    End Sub

    Private Sub Btnshow_Click(sender As Object, e As EventArgs) Handles Btnshow.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from images where ID=@parm1", con)
        cmd2.Parameters.AddWithValue("@parm1", Txtid.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            Txtimagenmaes.Text = myreader("imagename")

        Else
            Txtimagenmaes.Text = ""
            MsgBox("data is not found")
        End If
        bind_data()
        con.Close()

    End Sub

    Private Sub addimage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
        Me.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As New OleDbCommand("select *from images where imagename like '%' +@parm1+ '%'", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox1.Text)
        Dim sa As New OleDbDataAdapter
        sa.SelectCommand = cmd
        Dim admin As New DataTable
        admin.Clear()
        sa.Fill(admin)
        DataGridView1.DataSource = admin
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        setting.Show()
        Me.Hide()

    End Sub
End Class