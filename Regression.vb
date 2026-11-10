' COM 390 Flight Project
' Partners: Dylan Lauro, Jake Krumsiek, Jake Rosa-Chaves

Imports System.Data
Imports Microsoft.Data.SqlClient

Module Regression
    Dim sumy_2, sumx1_2, sumx2_2 As Double
    Dim sumx1y, sumx2y, sumx1x2 As Double
    Public a, b1, b2 As Double

    Public Sub Calculate()
        Dim X1List As New List(Of Double)()
        Dim X2List As New List(Of Double)()
        Dim YList As New List(Of Double)()

        Using connection As SqlConnection = SQL.GetConnection()
            connection.Open()

            Using command As New SqlCommand("dbo.GetJakeFlightRegressionData", connection)
                command.CommandType = CommandType.StoredProcedure

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        X1List.Add(Convert.ToDouble(reader("X1")))
                        X2List.Add(Convert.ToDouble(reader("X2")))
                        YList.Add(Convert.ToDouble(reader("Y")))
                    End While
                End Using
            End Using
        End Using

        Dim X1() As Double = X1List.ToArray()
        Dim X2() As Double = X2List.ToArray()
        Dim Y() As Double = YList.ToArray()

        Dim avgY, avgX1, avgX2 As Double
        Dim sumY, sumX1, sumX2 As Double
        Dim sumSQY, sumSQX1, sumSQX2 As Double
        Dim sumYX1, sumYX2, sumX1X2 As Double

        Dim n = Y.Length

        sumY = CalcSum(Y)
        avgY = CalcMean(sumY, Y.Length)

        sumX1 = CalcSum(X1)
        avgX1 = CalcMean(sumX1, X1.Length)

        sumX2 = CalcSum(X2)
        avgX2 = CalcMean(sumX2, X2.Length)

        sumSQY = CalcSumOfSquares(Y)
        sumSQX1 = CalcSumOfSquares(X1)
        sumSQX2 = CalcSumOfSquares(X2)

        sumYX1 = CalcSumOfVar(Y, X1)
        sumYX2 = CalcSumOfVar(Y, X2)
        sumX1X2 = CalcSumOfVar(X1, X2)

        sumy_2 = sumSQY - (Math.Pow(sumY, 2) / n)
        sumx1_2 = sumSQX1 - (Math.Pow(sumX1, 2) / n)
        sumx2_2 = sumSQX2 - (Math.Pow(sumX2, 2) / n)

        sumx1y = sumYX1 - ((sumX1 * sumY) / n)
        sumx2y = sumYX2 - ((sumX2 * sumY) / n)
        Regression.sumx1x2 = sumX1X2 - ((sumX1 * sumX2) / n)

        b1 = (sumx2_2 * sumx1y - Regression.sumx1x2 * sumx2y) / (sumx1_2 * sumx2_2 - Regression.sumx1x2 * Regression.sumx1x2)
        b2 = (sumx1_2 * sumx2y - Regression.sumx1x2 * sumx1y) / (sumx1_2 * sumx2_2 - Regression.sumx1x2 * Regression.sumx1x2)

        a = avgY - b1 * avgX1 - b2 * avgX2

        System.Windows.Forms.MessageBox.Show(
            "b1 = " & b1 & vbCrLf & "b2 = " & b2 & vbCrLf & "a = " & a,
            "Here are your regression results")
    End Sub

    Public Function CalcMean(sum As Double, N As Integer) As Double
        Dim avg As Double = 0
        avg = sum / N
        Return avg
    End Function

    Public Function CalcSum(array() As Double) As Double
        Dim sum As Double = 0
        For i As Integer = 0 To array.Length - 1
            sum = sum + array(i)
        Next
        Return sum
    End Function

    Public Function CalcSumOfSquares(array() As Double) As Double
        Dim sum As Double = 0
        For i As Integer = 0 To array.Length - 1
            sum = sum + (Math.Pow(array(i), 2))
        Next
        Return sum
    End Function

    Public Function CalcSumOfVar(array1() As Double, array2() As Double) As Double
        Dim sum As Double = 0
        For i As Integer = 0 To array1.Length - 1
            sum = sum + (array1(i) * array2(i))
        Next
        Return sum
    End Function
End Module
