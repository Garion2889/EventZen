Imports MySql.Data.MySqlClient
Imports Mysqlx

Module ReusableCodes
    Dim connectionString As String = "Server=localhost;Database=eventmanagement;Uid=root;Pwd=;"
    Public Sub Viewevent(eventview As DataGridView)
        Dim query As String = "SELECT * FROM events;"
        Using connection As New MySqlConnection(connectionString)
            Dim cmd As New MySqlCommand(query, connection)
            Try
                connection.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    eventview.Rows.Clear()
                    While reader.Read()
                        Dim eventCode As String = reader("eventcode").ToString()
                        Dim eventName As String = reader("eventName").ToString()
                        Dim eventDate As String = reader("eventDate").ToString()
                        Dim eventLocation As String = reader("eventLocation").ToString()
                        Dim eventDescription As String = reader("eventDesc").ToString()
                        Dim eventAvail As String = reader("Availability").ToString()
                        eventview.Rows.Add(eventCode, eventName, eventDate, eventLocation, eventDescription, eventAvail)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Public Sub UnlockControls(container As Control)
        For Each ctrl As Control In container.Controls
            ctrl.Enabled = True
        Next
    End Sub
    Public Sub ClearTextBoxes(parentContainer As Control)
        For Each ctrl As Control In parentContainer.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
            If TypeOf ctrl Is RichTextBox Then
                CType(ctrl, RichTextBox).Clear()
            End If
        Next
    End Sub
    Public Sub viewregisteredusers(regtable As DataGridView)
        Dim query As String = "SELECT r.regId, u.uid, u.Username, e.eventcode, e.eventName, r.registrationDate FROM Registration r JOIN useraccounts u ON r.uid = u.uid JOIN events e ON r.eventcode = e.eventcode;"
        Using connection As New MySqlConnection(connectionString)
            Dim cmd As New MySqlCommand(query, connection)
            Try
                connection.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    regtable.Rows.Clear()
                    While reader.Read()
                        Dim rid As String = reader("regId").ToString()
                        Dim uid As String = reader("uid").ToString()
                        Dim username As String = reader("Username").ToString()
                        Dim eventCode As String = reader("eventcode").ToString()
                        Dim eventName As String = reader("eventName").ToString()
                        Dim registrationDate As String = reader("registrationDate").ToString()
                        regtable.Rows.Add(rid, uid, username, eventCode, eventName, registrationDate)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
End Module
