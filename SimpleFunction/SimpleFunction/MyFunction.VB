Module MyFunction
    Public Sub sayhello()
        Console.WriteLine("HELLO, How are you?")
    End Sub


    Function simplecal(ByVal firstNumber As Double, ByVal op As Integer, ByVal secondNumber As Double)
        Dim result As Double
        If (op = 1) Then
            result = firstNumber + secondNumber
        ElseIf (op = 2) Then
            result = firstNumber * secondNumber
        ElseIf (op = 3) Then
            result = firstNumber - secondNumber
        ElseIf (op = 4) Then
            result = firstNumber / secondNumber
        Else
            result = 0
        End If

        Return result

    End Function






End Module
