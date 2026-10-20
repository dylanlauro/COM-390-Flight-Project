Module RegressionExample
    Dim sumy_2, sumx1_2, sumx2_2 As Double
    Dim sumx1y, sumx2y, sumx1x2 As Double
    Dim a, b1, b2 As Double

    Public Sub Main(args As String())
        Dim avgY, avgX1, avgX2 As Double
        Dim sumY, sumX1, sumX2 As Double
        Dim sumSQY, sumSQX1, sumSQX2 As Double
        Dim sumYX1, sumYX2, sumX1X2 As Double
        Dim Y() As Double = {2, 4, 4, 1, 5, 4, 7, 9, 7, 8, 5, 2, 8, 6, 10, 9, 3, 6, 7, 10}
        Dim X1() As Double = {1, 2, 1, 1, 3, 4, 5, 5, 7, 6, 4, 3, 6, 6, 8, 9, 2, 6, 4, 4}
        Dim X2() As Double = {3, 5, 3, 4, 6, 5, 6, 7, 8, 4, 3, 4, 6, 7, 7, 6, 6, 5, 6, 9}

        Dim n = Y.Length
        sumY = CalcSum(Y)
        avgY = CalcMean(sumY, Y.Length)

        sumX1 = CalcSum(X1)
        avgX1 = CalcMean(sumX1, X1.Length)

        sumX2 = CalcSum(X2)
        avgX2 = CalcMean(sumX2, X2.Length)

        Console.WriteLine("sumY = " & sumY & " avgY = " & avgY)
        Console.WriteLine("sumX1 = " & sumX1 & " avgX1 = " & avgX1)
        Console.WriteLine("sumX2 = " & sumX2 & " avgX2 = " & avgX2)

        sumSQY = CalcSumOfSquares(Y)
        sumSQX1 = CalcSumOfSquares(X1)
        sumSQX2 = CalcSumOfSquares(X2)
        Console.WriteLine("Y SQ = " & sumSQY & " X1 SQ = " & sumSQX1 & " X2 SQ = " & sumSQX2)

        sumYX1 = CalcSumOfVar(Y, X1)
        sumYX2 = CalcSumOfVar(Y, X2)
        sumX1X2 = CalcSumOfVar(X1, X2)
        Console.WriteLine("YX1 = " & sumYX1 & " YX2 = " & sumYX2 & " X1X2 = " & sumX1X2)

        sumy_2 = sumSQY - (Math.Pow(sumY, 2) / n)
        Console.WriteLine("sumy_2 = " & sumy_2)


        sumx1_2 = sumSQX1 - (Math.Pow(sumX1, 2) / n)
        Console.WriteLine("sumx1_2 = " & sumx1_2)


        sumx2_2 = sumSQX2 - (Math.Pow(sumX2, 2) / n)
        Console.WriteLine("sumx2_2 = " & sumx2_2)

        sumx1y = sumYX1 - ((sumX1 * sumY) / n)
        Console.WriteLine("sumx1y = " & sumx1y)

        sumx2y = sumYX2 - ((sumX2 * sumY) / n)
        Console.WriteLine("sumx2y = " & sumx2y)

        RegressionExample.sumx1x2 = sumX1X2 - ((sumX1 * sumX2) / n)
        Console.WriteLine("sumx1x2 = " & RegressionExample.sumx1x2)

        b1 = (sumx2_2 * sumx1y - RegressionExample.sumx1x2 * sumx2y) / (sumx1_2 * sumx2_2 - RegressionExample.sumx1x2 * RegressionExample.sumx1x2)
        Console.WriteLine("b1 = " & b1)

        b2 = (sumx1_2 * sumx2y - RegressionExample.sumx1x2 * sumx1y) / (sumx1_2 * sumx2_2 - RegressionExample.sumx1x2 * RegressionExample.sumx1x2)
        Console.WriteLine("b2 = " & b2)

        a = avgY - b1 * avgX1 - b2 * avgX2
        Console.WriteLine("a = " & a)

        If Not Console.IsInputRedirected Then
            Console.WriteLine("Press Enter to close")
            Console.ReadLine()
        End If
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
