Imports MySql.Data.MySqlClient

Public Class User
    Private connectionString As String = "Server=localhost;Database=eventmanagement;Uid=root;Pwd=;"
    Private currentUserID As Integer = UserSession.UserID

    ' Register the selected event
    Private Sub RegisterForEvent(eventCode As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Check if the user is already registered for this event
                Dim checkQuery As String = "SELECT * FROM registration WHERE UID = @UID AND eventCode = @EventCode"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@UID", currentUserID)
                    checkCmd.Parameters.AddWithValue("@EventCode", eventCode)

                    Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("You are already registered for this event.")
                            Return
                        End If
                    End Using
                End Using

                ' Register the user for the event
                Dim insertQuery As String = "INSERT INTO registration (UID, eventcode, registrationDate) VALUES (@UID, @EventCode, @RegistrationDate)"
                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@UID", currentUserID)
                    insertCmd.Parameters.AddWithValue("@EventCode", eventCode)
                    insertCmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now.ToString("yyyy-MM-dd"))

                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("You have successfully registered for the event!")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while registering for the event: " & ex.Message)
        End Try
    End Sub

    ' Load registered events for the current user
    Private Sub LoadRegisteredEvents()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to fetch registered events for the current user
                Dim query As String = "SELECT r.regId, r.uid, u.username, e.eventcode, e.eventName, e.eventDate, r.registrationDate " &
                                      "FROM registration r " &
                                      "JOIN events e ON r.eventcode = e.eventcode JOIN useraccounts u ON r.uid = u.uid WHERE r.UID = @UID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UID", currentUserID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear the DataGridView before loading
                        regtable.Rows.Clear()

                        While reader.Read()
                            ' Add rows to the DataGridView
                            regtable.Rows.Add(
                                reader("regId").ToString(),
                                reader("UID").ToString(),
                                reader("username").ToString(),
                                reader("eventcode").ToString(),
                                reader("eventName").ToString(),
                                reader("eventDate").ToString(),
                                reader("registrationDate").ToString()
                            )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading registered events: " & ex.Message)
        End Try
    End Sub


    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load available events and registered events
        ReusableCodes.Viewevent(UserEventTableView)
        LoadRegisteredEvents()
    End Sub

    Private Sub registerevent_Click(sender As Object, e As EventArgs) Handles registerevent.Click
        Try
            ' Ensure a row is selected in the DataGridView
            If UserEventTableView.SelectedRows.Count > 0 Then
                ' Retrieve the event code from the selected row
                Dim selectedEventCode As Object = UserEventTableView.SelectedRows(0).Cells("eventcode").Value

                If selectedEventCode IsNot Nothing AndAlso IsNumeric(selectedEventCode) Then
                    RegisterForEvent(Convert.ToInt32(selectedEventCode))
                    LoadRegisteredEvents() ' Refresh the list of registered events
                Else
                    MessageBox.Show("Invalid event code. Please select a valid event.")
                End If
            Else
                MessageBox.Show("Please select an event to register.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        viewregeventpanel.Visible = True
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        viewregeventpanel.Visible = False
    End Sub
End Class
