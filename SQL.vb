' By Dylan Lauro, Jake Krumsiek, Jake Rosa-Chaves

Imports Microsoft.Data.SqlClient

Module SQL
    Public Const ConnString As String = "Data Source=localhost;Initial Catalog=FlightDB;Integrated Security=True;TrustServerCertificate=True"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnString)
    End Function
End Module
