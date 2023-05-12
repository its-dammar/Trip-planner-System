Imports System.Data.OleDb
Public Class setplan
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")

    Private Sub setplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        selectedplace.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        Dim access As String
        access = "UPDATE plans SET [placename] = '" & Txtplacename.Text & "', [plandate] = '" & Dtplandate.Text & "',[startdate] = '" & Dtstartdate.Text & "',[returndate] = '" & Dtreturndate.Text & "',[no_of_person] = '" & Txtnoofperson.Text & "',[ebudget] = '" & Txtbudget.Text & "',[each_person_budget] = '" & Txtperbudget.Text & "',[notes] = '" & Txtnotes.Text & "' where ID=" & TxtID.Text & ""
        Dim cmd As New OleDbCommand(access, con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            Me.Refresh()
            'MsgBox("update successful")


            con.Close()
            TxtID.Clear()
            Txtnotes.Clear()
            Txtbudget.Clear()
            Txtnoofperson.Clear()
            Txtplacename.Clear()
            Txtperbudget.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Dim str As String
        str = "INSERT INTO plans ([placename],[plandate],[startdate],[returndate],[no_of_person],[ebudget],[each_person_budget],[notes]) values (@placename, @plandate,@startdate,@returndate,@no_of_person,@ebudget,@eachpersonbudget,@notes)"
        Dim cmd1 As New OleDbCommand(str, con)
        cmd1.Parameters.Add(New OleDbParameter("@placename", CType(Txtplacename.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@startdate", CType(Dtstartdate.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@plandate", CType(Dtplandate.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@returndate", CType(Dtreturndate.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@no_of_person", CType(Txtnoofperson.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@ebudget", CType(Txtbudget.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@eachpersonbudget", CType(Txtperbudget.Text, String)))
        cmd1.Parameters.Add(New OleDbParameter("@notes", CType(Txtnotes.Text, String)))
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Try
            cmd1.ExecuteNonQuery()
            'MsgBox("data save")
            Me.Refresh()
            Me.Show()

            Txtnotes.Clear()
            Txtbudget.Clear()
            Txtnoofperson.Clear()
            Txtplacename.Clear()
            Txtperbudget.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub Btnshow_Click(sender As Object, e As EventArgs) Handles Btnshow.Click
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd2 As New OleDbCommand("select *from plans where ID=@id", con)
        cmd2.Parameters.AddWithValue("@id", TxtID.Text)
        Dim myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            Txtplacename.Text = myreader("placename")
            Dtplandate.Text = myreader("plandate")
            Dtstartdate.Text = myreader("startdate")
            Dtreturndate.Text = myreader("returndate")
            Txtnoofperson.Text = myreader("no_of_person")
            Txtbudget.Text = myreader("ebudget")
            Txtperbudget.Text = myreader("each_person_budget")
            Txtnotes.Text = myreader("notes")

        Else
            Txtplacename.Text = ""
            Dtplandate.Text = ""
            Dtstartdate.Text = ""
            Dtreturndate.Text = ""
            Txtplacename.Text = ""
            Txtbudget.Text = ""
            Txtperbudget.Text = ""
            Txtnotes.Text = ""

            MsgBox("data is not found")
            Me.Refresh()
            TxtID.Clear()

        End If
        con.Close()
    End Sub
End Class