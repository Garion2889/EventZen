Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Admin
    Dim connectionString As String = "Server=localhost;Database=eventmanagement;Uid=root;Pwd=;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReusableCodes.Viewevent(admineventview)
        TabControl1.SelectedIndex = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 1
        ReusableCodes.viewregisteredusers(regtable)
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReusableCodes.viewregisteredusers(regtable)
        ReusableCodes.Viewevent(admineventview)
        Dim query1 = "SELECT COUNT(*) AS total_rows FROM events;"
        Dim query2 = "SELECT COUNT(*) AS total_rows FROM registration;"
        Using Connection As New MySqlConnection(connectionString)
            Dim cmd1 As New MySqlCommand(query1, Connection)
            Try
                Connection.Open()
                Using reader As MySqlDataReader = cmd1.ExecuteReader()
                    While reader.Read()
                        Dim totalevents As String = reader("total_rows").ToString()
                        eventquantity.Text = totalevents
                    End While
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Dim cmd2 As New MySqlCommand(query2, Connection)
            Try
                Using reader As MySqlDataReader = cmd2.ExecuteReader()
                    While reader.Read()
                        Dim totalevents As String = reader("total_rows").ToString()
                        registerquantity.Text = totalevents
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub addeventBtn_Click(sender As Object, e As EventArgs) Handles addeventpanelBtn.Click
        addeventpanel.Visible = True
    End Sub

    Private Sub addeventBtn_Click_1(sender As Object, e As EventArgs) Handles addeventBtn.Click
        Dim addevent = addeventtxt.Text
        Dim addeventdate = adddatetxt.Text
        Dim addeventloc = addlocationtxt.Text
        Dim addeventdesc = adddesctxt.Text
        Dim addavail As Integer = addavailtxt.Text
        Dim connectionString = "Server=localhost;Database=eventmanagement;Uid=root;Pwd=;"
        Dim query = "INSERT INTO events (eventName, eventDate, eventLocation, eventDesc, availability) VALUES (@eventName, @eventDate, @eventLocation, @eventDesc, @availability);"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@eventName", addevent)
                    command.Parameters.AddWithValue("@eventDate", addeventdate)
                    command.Parameters.AddWithValue("@eventLocation", addeventloc)
                    command.Parameters.AddWithValue("@eventDesc", addeventdesc)
                    command.Parameters.AddWithValue("@availability", addavail)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Event inserted successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dlteventBtn_Click(sender As Object, e As EventArgs) Handles dlteventBtn.Click
        ' Check if a row is selected
        If admineventview.SelectedRows.Count > 0 Then
            ' Get the selected event code
            Dim eventCode As String = If(admineventview.SelectedRows(0).Cells("eventCode").Value?.ToString(), "")

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM events WHERE eventcode = @eventCode"
                Using connection As New MySqlConnection(connectionString)
                    Try
                        connection.Open()
                        Using command As New MySqlCommand(query, connection)
                            ' Add parameter to prevent SQL injection
                            command.Parameters.AddWithValue("@eventCode", eventCode)
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()

                            ' Check if deletion was successful
                            If rowsAffected > 0 Then
                                MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ' Refresh the DataGridView
                                Viewevent(admineventview)
                            Else
                                MessageBox.Show("Event not found or already deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while deleting the event: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End If
        Else

            MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub canceladdBtn_Click(sender As Object, e As EventArgs) Handles canceladdBtn.Click
        UnlockControls(Me)
        ReusableCodes.ClearTextBoxes(addeventpanel)
        addeventpanel.Visible = False
    End Sub

    Private Sub admineventview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles admineventview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < admineventview.Rows.Count Then
            admineventview.ClearSelection()
            admineventview.Rows(e.RowIndex).Selected = True
            Dim selectedRow As DataGridViewRow = admineventview.Rows(e.RowIndex)
            Dim eventName As String = selectedRow.Cells("eventName").Value.ToString()
            updateeventtxt.Text = selectedRow.Cells("eventName").Value.ToString()
            updatedatetxt.Text = Convert.ToDateTime(selectedRow.Cells("eventDate").Value).ToString("yyyy-MM-dd")
            updatelocationtxt.Text = selectedRow.Cells("eventLocation").Value.ToString()
            updatedesctxt.Text = selectedRow.Cells("eventDesc").Value.ToString()
            updateavailtxt.Text = selectedRow.Cells("availability").Value.ToString()
        Else
            MessageBox.Show("No row selected or invalid index.")
        End If
    End Sub

    Private Sub modifyeventpanelBtn_Click(sender As Object, e As EventArgs) Handles modifyeventpanelBtn.Click
        modifypanel.Visible = True
    End Sub

    Private Sub modifyeventbtn_Click(sender As Object, e As EventArgs) Handles modifyeventbtn.Click
        If admineventview.SelectedRows.Count > 0 Then
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()
                    Dim query As String = "UPDATE events SET eventName = @eventName, eventDate = @eventDate, eventLocation = @eventLocation, eventDesc = @eventDesc, availability = @availability WHERE eventcode = @eventCode"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@eventCode", admineventview.SelectedRows(0).Cells("eventCode").Value)
                        command.Parameters.AddWithValue("@eventName", updateeventtxt.Text)
                        command.Parameters.AddWithValue("@eventDate", Convert.ToDateTime(updatedatetxt.Text).ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@eventLocation", updatelocationtxt.Text)
                        command.Parameters.AddWithValue("@eventDesc", updatedesctxt.Text)
                        command.Parameters.AddWithValue("@availability", Convert.ToInt32(updateavailtxt.Text))
                        Dim rowsAffected = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Row updated successfully.")
                            modifypanel.Visible = False
                            ReusableCodes.ClearTextBoxes(modifypanel)
                        Else
                            MessageBox.Show("No changes made to the database.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}")
                End Try
            End Using
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        ReusableCodes.ClearTextBoxes(addeventpanel)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles modifyclearBtn.Click
        ReusableCodes.ClearTextBoxes(modifypanel)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles modifycancelBtn.Click
        ReusableCodes.ClearTextBoxes(modifypanel)
        modifypanel.Visible = False
    End Sub

    Private Sub loadeventBtn_Click(sender As Object, e As EventArgs) Handles loadeventBtn.Click
        ReusableCodes.Viewevent(admineventview)
    End Sub

    Private Sub regRefreshBtn_Click(sender As Object, e As EventArgs) Handles regRefreshBtn.Click
        ReusableCodes.viewregisteredusers(regtable)
    End Sub
End Class