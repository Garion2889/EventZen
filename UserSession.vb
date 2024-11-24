Public Class UserSession
    Public Shared UserID As Integer
    Public Shared Username As String
    Public Shared Role As String
    Public Shared Sub ClearSession()
        UserID = 0
        Username = String.Empty
        Role = String.Empty
    End Sub
End Class
