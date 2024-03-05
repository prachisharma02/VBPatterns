Module Module1
    Sub Main()
        'Pattern 1 - Hollow Square
        Console.WriteLine("Pattern 1 - Hollow Square")
        Console.WriteLine()
        Pattern1()
        Console.WriteLine()

        'Pattern 2 - Number Triangle
        Console.WriteLine("Pattern 2 - Number Triangle")
        Console.WriteLine()
        Pattern2()
        Console.WriteLine()

        'Pattern 3 - Increasing Number Triangle
        Console.WriteLine("Pattern 3 - Increasing Number Triangle")
        Console.WriteLine()
        Pattern3()
        Console.WriteLine()

        'Pattern 4 - Number-increasing reverse Pyramid Pattern
        Console.WriteLine("Pattern 4 - Number-increasing reverse Pyramid Pattern")
        Console.WriteLine()
        Pattern4()
        Console.WriteLine()

        'Pattern 5 - Number-changing Pyramid Pattern
        Console.WriteLine("Pattern 5 - Number-changing Pyramid Pattern")
        Console.WriteLine()
        Pattern5()
        Console.WriteLine()

        'Pattern 6 - Zero-One Triangle Pattern
        Console.WriteLine("Pattern 6 - Zero-One Triangle Pattern")
        Console.WriteLine()
        Pattern6()
        Console.WriteLine()

        'Pattern 7 - Palindrome Triangle Pattern
        Console.WriteLine("Pattern 7 - Palindrome Triangle Pattern")
        Console.WriteLine()
        Pattern7()
        Console.WriteLine()

        'Pattern 8 - Rhombus Pattern
        Console.WriteLine("Pattern 8 - Rhombus Pattern")
        Console.WriteLine()
        Pattern8()
        Console.WriteLine()

        'Pattern 9 - Diamond Star Pattern
        Console.WriteLine("Pattern 9 - Diamond Star Pattern")
        Console.WriteLine()
        Pattern9()
        Console.WriteLine()

        'Pattern 10 - Mirror Image Triangle Pattern
        Console.WriteLine("Pattern 10 - Mirror Image Triangle Pattern")
        Console.WriteLine()
        Pattern10()
        Console.WriteLine()

        'Pattern 11 - Hollow Triangle Pattern
        Console.WriteLine("Pattern 11 - Hollow Triangle Pattern")
        Console.WriteLine()
        Pattern11()
        Console.WriteLine()

        'Pattern 12 - Hollow Reverse Triangle Pattern
        Console.WriteLine("Pattern 12 - Hollow Reverse Triangle Pattern")
        Console.WriteLine()
        Pattern12()
        Console.WriteLine()

        'Pattern 13 - Hollow Diamond Pyramid
        Console.WriteLine("Pattern 13 - Hollow Diamond Pyramid")
        Console.WriteLine()
        Pattern13()
        Console.WriteLine()

        'Pattern 14 - Hollow Hourglass Pattern
        Console.WriteLine("Pattern 14 - Hollow Hourglass Pattern")
        Console.WriteLine()
        Pattern14()
        Console.WriteLine()

        'Pattern 15 - Pascal Triangle
        Console.WriteLine("Pattern 15 - Pascal Triangle")
        Console.WriteLine()
        Pattern15()
        Console.WriteLine()
    End Sub

    Private Sub Pattern1()
        Console.WriteLine("1. Square Hollow Pattern:")
        Console.Write("Enter the number of rows: ")
        Dim n As Integer = CInt(Console.ReadLine())

        ' Print the top line
        For i As Integer = 0 To n - 1
            Console.Write("*")
        Next

        Console.WriteLine()

        ' Print the middle rows
        For i As Integer = 1 To n - 2
            Console.Write("*") ' Print left border
            For j As Integer = 1 To n - 2 ' Adjusted loop to exclude corners
                Console.Write(" ") ' Print spaces for the hollow part
            Next
            Console.WriteLine("*") ' Print right border
        Next

        ' Print the bottom line
        For i As Integer = 0 To n - 1
            Console.Write("*")
        Next

        Console.WriteLine()


    End Sub

    Private Sub Pattern2()
        Console.WriteLine("2. Number triangle Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ") ' Print spaces for indentation
            Next

            For k As Integer = 1 To i
                Console.Write(i) ' Print the number
                Console.Write(" ") ' Print a space after the number
            Next

            Console.WriteLine() ' Move to the next line after printing a row
        Next
    End Sub


    Private Sub Pattern3()
        Dim row As Integer = 6
        'for rows
        For i As Integer = 1 To row
            'for column
            For j As Integer = 1 To i
                Console.Write(j & " ")
            Next
            'for next line to printed by the pattern
            Console.WriteLine(" ")
        Next
    End Sub



    Private Sub Pattern4()
        Dim row As Integer = 6

        ' for rows
        For i As Integer = 0 To row - 1
            ' for columns 
            For j As Integer = row To i + 1 Step -1
                Console.Write(row - j + 1 & " ")
            Next

            ' next line 
            Console.WriteLine(" ")
        Next
    End Sub

    Private Sub Pattern5()
        Dim row As Integer = 6
        Dim n As Integer = 1

        ' for rows
        For i As Integer = 1 To row
            ' for columns
            For j As Integer = 1 To i
                Console.Write(n & " ")
                n = n + 1
            Next

            ' next line 
            Console.WriteLine(" ")
        Next
    End Sub

    Private Sub Pattern6()
        Dim start As Integer = 1
        Dim row As Integer = 5
        ' for rows
        For i As Integer = 0 To row
            If i Mod 2 = 0 Then
                start = 1
            Else
                start = 0
            End If

            For j As Integer = 0 To i
                Console.Write(start & " ")
                start = 1 - start
            Next
            Console.WriteLine(" ")
        Next
    End Sub

    Private Sub Pattern7()
        Dim row As Integer = 6
        For i As Integer = 1 To row
            ' for spaces
            For j As Integer = 1 To row - i
                Console.Write("  ")
            Next

            ' decreasing numbers
            For k As Integer = i To 1 Step -1
                Console.Write(k & " ")
            Next

            ' increasing numbers
            For l As Integer = 2 To i
                Console.Write(l & " ")
            Next

            Console.WriteLine()
        Next
    End Sub

    Private Sub Pattern8()
        Dim row As Integer = 6
        For i As Integer = 1 To row
            ' for spaces
            For j As Integer = 1 To row - i
                Console.Write(" ")
            Next

            For k As Integer = 1 To row
                Console.Write("*")
            Next

            Console.WriteLine()
        Next
    End Sub

    Private Sub Pattern9()
        Dim N As Integer = 5

        ' for erected pyramid
        ' for the rows.
        For i As Integer = 0 To N - 1
            ' for spaces
            For j As Integer = 0 To N - i - 2
                Console.Write(" ")
            Next

            '  printing the stars in each row
            For j As Integer = 0 To 2 * i
                Console.Write("*")
            Next

            ' next line
            Console.WriteLine(" ")

        Next

        ' for inverted pyramid
        ' for rows
        For i As Integer = 0 To N - 1
            ' for spaces
            For j As Integer = 0 To i - 1
                Console.Write(" ")
            Next

            ' printing the stars in each row
            For j As Integer = 0 To 2 * N - (2 * i + 3)
                Console.Write("*")
            Next


            Console.WriteLine()
        Next
    End Sub

    Private Sub Pattern10()
        Dim N As Integer = 6

        ' for inverted pyramid
        ' for rows
        For i As Integer = 0 To N - 1
            ' for spaces
            For j As Integer = 0 To i - 1
                Console.Write(" ")
            Next

            ' printing increasing number
            For j As Integer = i + 1 To N
                Console.Write(j & " ")
            Next

            Console.WriteLine()
        Next

        ' for erected pyramid

        ' for the rows.
        For i As Integer = 1 To N - 1
            ' for spaces
            For j As Integer = 1 To N - i - 1
                Console.Write(" ")
            Next

            '  printing the increasing number 
            For j As Integer = N - i To N
                Console.Write(j & " ")
            Next

            ' next line
            Console.WriteLine(" ")
        Next
    End Sub

    Private Sub Pattern11()
        Dim n As Integer = 6
        For i As Integer = 1 To n
            ' Print spaces
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next

            ' Print stars
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next

            Console.WriteLine()
        Next
    End Sub

    Private Sub Pattern12()
        Dim n As Integer = 6
        For i As Integer = n To 1 Step -1
            ' Print spaces
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next

            ' Print stars or spaces
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next

            Console.WriteLine()
        Next
    End Sub

    Private Sub Pattern13()
        Dim n As Integer = 6
        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
        For i As Integer = n - 1 To 1 Step -1
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub Pattern14()
        Dim n As Integer = 6
        For i As Integer = 0 To n - 1
            ' Print spaces
            For j As Integer = 0 To i - 1
                Console.Write(" ")
            Next

            ' Print stars or spaces
            For j As Integer = 0 To n - i - 1
                If i = 0 OrElse i = n - 1 OrElse j = 0 OrElse j = n - i - 1 Then
                    Console.Write("* ")
                Else
                    Console.Write("  ")
                End If
            Next

            Console.WriteLine()
        Next

        ' Lower half of the hourglass
        For i As Integer = n - 2 To 0 Step -1
            ' Print spaces
            For j As Integer = 0 To i - 1
                Console.Write(" ")
            Next

            ' Print stars or spaces
            For j As Integer = 0 To n - i - 1
                If i = 0 OrElse i = n - 1 OrElse j = 0 OrElse j = n - i - 1 Then
                    Console.Write("* ")
                Else
                    Console.Write("  ")
                End If
            Next

            Console.WriteLine()
        Next
    End Sub


    Private Sub Pattern15()
        Dim N As Integer = 4
        For i As Integer = 1 To N
            Dim b As Integer = 1
            For j As Integer = 0 To N - i
                Console.Write(" ")
            Next

            For k As Integer = 1 To i
                Console.Write(b & " ")
                b = b * (i - k) \ k
            Next
            Console.WriteLine()
        Next
    End Sub
End Module