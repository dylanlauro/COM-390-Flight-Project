' By Dylan Lauro, Jake Krumsiek, Jake Rosa-Chaves

Imports Microsoft.Data.SqlClient

Module SQL
    Public ConnString As String = "Data Source=localhost;Initial Catalog=FlightDB;Integrated Security=True;TrustServerCertificate=True"

    Public Enum FlightData
        Jake
        Dylan
    End Enum

    Public CurrentFlight As FlightData = FlightData.Jake

    Public Function RegressionSetting() As String
        Select Case CurrentFlight
            Case FlightData.Dylan
                Return "dbo.GetDylanFlightRegressionData"
            Case Else
                Return "dbo.GetJakeFlightRegressionData"
        End Select
    End Function

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnString)
    End Function
End Module
