' By Dylan Lauro, Jake Krumsiek, Jake Rosa-Chaves

Imports Microsoft.Data.SqlClient

Module SQL
    ' Connection string for the database we're currently using.
    ' Change it here (or set SQL.ConnString from anywhere) to switch databases.
    Public ConnString As String = "Data Source=localhost;Initial Catalog=FlightDB;Integrated Security=True;TrustServerCertificate=True"

    ' Whose flight data the regression uses. Set CurrentFlight before calling Regression.Regression().
    Public Enum FlightData
        Jake
        Dylan
    End Enum

    Public CurrentFlight As FlightData = FlightData.Jake

    ' Stored procedure that returns X1, X2 and Y for the current flight
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
