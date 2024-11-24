Imports MySql.Data.MySqlClient

Public Class Login
    Private connectionString As String = "Server=localhost;Database=eventmanagement;Uid=root;Pwd=;"
    Private Sub ValidateLogin(username As String, password As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim adminQuery As String = "SELECT * FROM admin WHERE adminacc = @Username AND adminpassword = @Password"
                Dim userQuery As String = "SELECT * FROM useraccounts WHERE Username = @Username AND Password = @Password"

                Dim isAdmin As Boolean = False
                Dim isUser As Boolean = False
                ' Check if admin
                Using cmd As New MySqlCommand(adminQuery, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            isAdmin = True
                        End If
                    End Using
                End Using

                ' Check if user 
                If Not isAdmin Then
                    Using cmd As New MySqlCommand(userQuery, conn)
                        cmd.Parameters.AddWithValue("@Username", username)
                        cmd.Parameters.AddWithValue("@Password", password)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.HasRows Then
                                isUser = True
                                If reader.Read() Then
                                    UserSession.UserID = reader.GetInt32("UID")
                                    UserSession.Username = reader.GetString("Username")
                                    UserSession.Role = "User"
                                End If
                            End If
                        End Using
                    End Using
                End If
                If isAdmin Then
                    MessageBox.Show("Admin logged in successfully!")
                    Dim adminForm As New Admin()
                    Me.Close()
                    adminForm.Show()

                ElseIf isUser Then
                    MessageBox.Show("User logged in successfully!")
                    Dim userForm As New User()
                    Me.Close()
                    userForm.Show()

                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            End Using
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim username As String = usernamelogin.Text
        Dim password As String = passwordlogin.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username and password are required.")
            Return
        End If
        ValidateLogin(username, password)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Register.Show()
    End Sub
End Class