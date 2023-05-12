Imports System.Data.OleDb
Imports System.IO
'Imports System.Data.DataTable
Public Class addplacedetails
    Dim str As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")
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

        If Txttitle.Text = Nothing Or Txtabout.Text = Nothing Or Txtmapurl.Text = Nothing Or Txttransport.Text = Nothing Or Txtwalk.Text = Nothing Then
            MessageBox.Show("Please enter Details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM placedetails WHERE[title]=@title", con)
        cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = Txttitle.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("This Place is Already here", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txttitle.Clear()
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

        str = "INSERT INTO placedetails ([title],[about],[image],[imagename],[transport],[towalk],[map]) VALUES (@title,@about, @image, @imagename, @transport,@towalk, @map)"
        Dim create As OleDbCommand = New OleDbCommand(str, con)

        create.Parameters.Add(New OleDbParameter("title", CType(Txttitle.Text, String)))
        create.Parameters.Add(New OleDbParameter("about", CType(Txtabout.Text, String)))
        create.Parameters.AddWithValue("@image", arrImage)
        'create.Parameters.AddWithValue("image", imgbuffer)
        create.Parameters.Add(New OleDbParameter("imagename", CType(Txtimagename.Text, String)))
        create.Parameters.Add(New OleDbParameter("transport", CType(Txttransport.Text, String)))
        create.Parameters.Add(New OleDbParameter("towalk", CType(Txtwalk.Text, String)))
        create.Parameters.Add(New OleDbParameter("map", CType(Txtmapurl.Text, String)))

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            create.ExecuteNonQuery()
            MsgBox("save data")
            Me.Refresh()

            Me.Show()
            'create.Dispose()

            'clear text from the textbox
            Txttitle.Clear()
            Txtabout.Clear()
            Txtimagename.Clear()
            Txttransport.Clear()
            Txtwalk.Clear()
            Txtmapurl.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()

    End Sub

    Private Sub addplacedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim access As String
        access = "UPDATE placedetails SET [title] = '" & Txttitle.Text & "', [about] = '" & Txtabout.Text & "', [imagename] = '" & Txtimagename.Text & "', [transport] = '" & Txttransport.Text & "', [towalk] = '" & Txtwalk.Text & "', [map] = '" & Txtmapurl.Text & "' where ID=" & TxtID.Text & ""
        Dim cmd As New OleDbCommand(access, con)
        Try

            cmd.ExecuteNonQuery()
            con.Close()
            TxtID.Clear()
            Txttitle.Clear()
            Txtabout.Clear()
            Txtimagename.Clear()
            Txttransport.Clear()
            Txtwalk.Clear()
            Txtmapurl.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        setting.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from placedetails where title=@parm1", con)
        cmd2.Parameters.AddWithValue("@parm1", TxtID.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            Txttitle.Text = myreader("title")
            Txtabout.Text = myreader("about")
            Txtimagename.Text = myreader("imagename")
            Txtmapurl.Text = myreader("transport")
            Txttransport.Text = myreader("towalk")
            Txtwalk.Text = myreader("map")
            'pbimage.items = myreader("image")

        Else
            Txttitle.Text = ""
            Txtabout.Text = ""
            Txtimagename.Text = ""
            Txtmapurl.Text = ""
            Txttransport.Text = ""
            Txtwalk.Text = ""
            MsgBox("data is not found")
        End If
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from placedetails where title=@title", con)
        cmd2.Parameters.AddWithValue("@title", TxtID.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            Txttitle.Text = myreader("title")
            Txtabout.Text = myreader("about")
            'pbimage.Image = myreader("image")
            Txtimagename.Text = myreader("imagename")
            Txttransport.Text = myreader("transport")
            Txtwalk.Text = myreader("towalk")
            Txtmapurl.Text = myreader("map")

        Else
            Txttitle.Text = ""
            Txtabout.Text = ""
            pbimage.Text = ""
            Txtimagename.Text = ""
            Txttransport.Text = ""
            Txtwalk.Text = ""
            Txtmapurl.Text = ""
            MsgBox("data is not found")
        End If
        con.Close()
    End Sub
End Class