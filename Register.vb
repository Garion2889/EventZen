Imports MySql.Data.MySqlClient

Public Class Register
    Private connectionString As String = "Server=localhost;Database=eventmanagement;Uid=root;Pwd=;"
    Private Sub RegisterUser(username As String, password As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO useraccounts (Username, Password) VALUES (@Username, @Password);"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User registered successfully!")
                        Me.Hide()
                        Login.Show()
                    Else
                        MessageBox.Show("Failed to register user.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Dim username As String = usernametxt.Text
        Dim password As String = passwordtxt.Text
        Dim conpassword As String = conpasstxt.Text

        If password IsNot conpassword Then
            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(Name) Then
                MessageBox.Show("All fields are required.")
                Return
            End If
        End If
        RegisterUser(username, password)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
        Login.Show()
    End Sub
End Class
