Module Module1
    Sub Main()

        'Pattern1()
        'Console.WriteLine()


        'Pattern2()
        'Console.WriteLine()


        'Pattern3()
        'Console.WriteLine()


        'Pattern4()
        'Console.WriteLine()


        'Pattern5()
        'Console.WriteLine()


        'Pattern6()
        'Console.WriteLine()


        'Pattern7()
        'Console.WriteLine()


        'Pattern8()
        'Console.WriteLine()


        'Pattern9()
        'Console.WriteLine()


        'Pattern10()
        'Console.WriteLine()


        'Pattern11()
        'Console.WriteLine()


        'Pattern12()
        'Console.WriteLine()


        'Pattern13()
        'Console.WriteLine()


        'Pattern14()
        'Console.WriteLine()


        Pattern15()
        Console.WriteLine()
    End Sub

    Private Sub Pattern1()
        Console.WriteLine("1. Square Hollow Pattern:")
        Console.Write("Enter the number of rows: ")
        Dim n As Integer = CInt(Console.ReadLine())


        For i As Integer = 0 To n - 1
            Console.Write("*")
        Next

        Console.WriteLine()

        For i As Integer = 1 To n - 2
            Console.Write("*")
            For j As Integer = 1 To n - 2
                Console.Write(" ")
            Next
            Console.WriteLine("*")
        Next

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
                Console.Write(" ")
            Next

            For k As Integer = 1 To i
                Console.Write(i)
                Console.Write(" ")
            Next

            Console.WriteLine()
        Next
    End Sub


    Private Sub Pattern3()
        Console.WriteLine("3. Number-increasing Pyramid Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To i
                Console.Write(j)
            Next j
            Console.WriteLine()
        Next i


    End Sub



    Private Sub Pattern4()

        Console.WriteLine("4.  Number-increasing reverse Pyramid Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 0 To n
            For j As Integer = 1 To n - i
                Console.Write(j)
            Next j
            Console.WriteLine()
        Next i
    End Sub



    Private Sub Pattern5()
        Console.WriteLine("5. Number-changing Pyramid Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())
        Dim count As Integer = 1

        For i As Integer = 1 To n
            For j As Integer = 1 To i
                Console.Write(count & " ")
                count += 1
            Next j
            Console.WriteLine()
        Next i

    End Sub

    Private Sub Pattern6()
        Console.WriteLine("6. Zero-One Triangle Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 0 To n
            For j As Integer = 1 To i
                If j Mod 2 = 0 Then
                    Console.Write(0)
                Else
                    Console.Write(1)
                End If
            Next j
            Console.WriteLine()
        Next i

    End Sub

    Private Sub Pattern7()
        Console.WriteLine("7. Palindrome Triangle Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j

            For j As Integer = i To 1 Step -1
                Console.Write(j)
                Console.Write(" ")
            Next j

            For j As Integer = 2 To i
                Console.Write(j)
                Console.Write(" ")
            Next j

            Console.WriteLine()
        Next i

    End Sub

    Private Sub Pattern8()
        Console.WriteLine("8. Rhombus Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 1 To n - 1

            For j As Integer = 1 To n - i - 1
                Console.Write(" ")
            Next j

            For j As Integer = 1 To n
                Console.Write("*")
            Next j

            Console.WriteLine()
        Next i



    End Sub

    Private Sub Pattern9()
        Console.WriteLine("9. Diamond Star Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j

            For k As Integer = 1 To i
                Console.Write("* ")
            Next k

            Console.WriteLine()
        Next i

        For i As Integer = n - 1 To 1 Step -1
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j

            For k As Integer = 1 To i
                Console.Write("* ")
            Next k

            Console.WriteLine()
        Next i
    End Sub



    Private Sub Pattern10()
        Console.WriteLine("10. Mirror Image Triangle Pattern:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To i
                Console.Write(" ")
            Next j
            For k As Integer = i To n
                Console.Write(k & " ")
            Next k
            Console.WriteLine()
        Next i

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j
            For k As Integer = n - i To n
                Console.Write(k & " ")
            Next k
            Console.WriteLine()
        Next i
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
        Console.WriteLine("15. Pascal's Triangle:")
        Console.Write("Enter the number of rows: ")

        Dim n As Integer = CInt(Console.ReadLine())

        For i As Integer = 0 To n - 1
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j

            For j As Integer = 0 To i
                Console.Write(Pascal(i, j) & " ")
            Next j

            Console.WriteLine()
        Next i
    End Sub


    Private Function Pascal(ByVal row As Integer, ByVal col As Integer) As Integer
        If col = 0 Or col = row Then
            Return 1
        End If

        Return Pascal(row - 1, col - 1) + Pascal(row - 1, col)
    End Function


End Module