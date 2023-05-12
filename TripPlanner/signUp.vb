Imports System.Data.OleDb
'Imports System.Data.DataTable
Public Class signUp
    Dim str As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TripPlanner\TripPlanner\bin\Debug\tripPlanner.accdb")
    Private Sub signUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.size = new size(My.Computer.Screen.WorkingArea.Width,My.Computer.Screen.WorkingArea.Height)
        'Me.Width = 800
        'Me.Height = 500
        'Me.Refresh()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        login.Show()
        Me.Hide()

    End Sub

    Private Sub Btnregister_Click_1(sender As Object, e As EventArgs) Handles Btnregister.Click
        Try
            Dim phone As String = Txtphone.Text
            If Txtname.Text = Nothing Or Txtaddress.Text = Nothing Or Txtphone.Text = Nothing Or ComboBox1.Text = Nothing Then
                MessageBox.Show("Please enter detail", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If (phone.Length < 10 Or phone.Length > 10) Then
                Throw New System.Exception("Digits")
                ' MessageBox.Show("Contact Number must be 10 Digits")
                Txtphone.Clear()

            End If

            str = "INSERT INTO signups ([name],[address],[phone],[gender]) VALUES (?,?,?,?)"
            Dim create As OleDbCommand = New OleDbCommand(str, con)
            create.Parameters.Add(New OleDbParameter("name", CType(Txtname.Text, String)))
            create.Parameters.Add(New OleDbParameter("address", CType(Txtaddress.Text, String)))
            create.Parameters.Add(New OleDbParameter("txtphone", CType(Txtphone.Text, String)))
            create.Parameters.Add(New OleDbParameter("gender", CType(ComboBox1.Text, String)))

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            create.ExecuteNonQuery()
            'MsgBox("Register successfull")
            user.Show()
            Me.Refresh()
            Me.Hide()
            Txtname.Clear()
            Txtaddress.Clear()
            Txtphone.Clear()
            ComboBox1.Items.Clear()

        Catch ex As Exception
            If ex.Message.Equals("Empty") Then
                MessageBox.Show("Fields Cannot be empty")
            ElseIf ex.Message.Equals("Digits") Then
                MessageBox.Show("Contact Number must be 10 Digits")
            End If
        End Try

        con.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        user.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userlogin.Show()
        Me.Hide()

    End Sub
End Class
