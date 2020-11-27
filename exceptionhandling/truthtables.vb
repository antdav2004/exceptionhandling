Public Module truthtables




    Function Andgate(ByVal i As Boolean, j As Boolean) As Boolean
        'and gate subroutine
        Dim booleanoutput As Boolean

        If i And j = True Then
            booleanoutput = True
        Else
            booleanoutput = False
        End If

        Andgate = i And j

        Dim gateoutput As Boolean = CInt(booleanoutput)
        Return gateoutput


    End Function


    Function orgate(i As Boolean, j As Boolean) As Boolean
        'or gate subroutine
        Dim gateoutput As Boolean
        gateoutput = i Or j
        Return (gateoutput)

    End Function
    Function xorgate(i As Boolean, j As Boolean) As Boolean
        xorgate = i Xor j
    End Function
    Function notgate(i As Boolean) As Boolean
        notgate = Not i
    End Function
    Sub andtruthtable()
        Console.WriteLine("and truth table")
        Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", "InputA", "inputB", "Output")
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", -1 * CInt(i = 1), -1 * CInt(j = 1), -1 * CInt(Andgate(i = 1, j = 1)))
            Next
        Next
    End Sub
    Sub orgatetruthtable()
        Console.WriteLine("orgate truthtable")
        Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", "InputA", "inputB", "Output")
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", -1 * CInt(i = 1), -1 * CInt(j = 1), -1 * CInt(orgate(i = 1, j = 1)))
            Next
        Next


    End Sub
    Sub xorgatetruthtable()
        Console.WriteLine("xorgate truthtable")
        Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", "InputA", "inputB", "Output")
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", -1 * CInt(i = 1), -1 * CInt(j = 1), -1 * CInt(xorgate(i = 1, j = 1)))
            Next
        Next
    End Sub
    Sub notgatetruthtable()
        Console.WriteLine("notgate truthtable")
        Console.WriteLine("{0}" + vbTab + "{1}", "InputA", "Output")
        For i As Integer = 0 To 1
            Console.WriteLine("{0}" + vbTab + "{1}", -1 * CInt(i = 1), -1 * CInt(notgate(i = 1)))
        Next
    End Sub
    Sub nandgatetruthtable()
        Console.WriteLine("nandgate truthtable")
        Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", "InputA", "inputB", "Output")
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", -1 * CInt(i = 1), -1 * CInt(j = 1), -1 * CInt(notgate(Andgate(i = 1, j = 1))))
            Next
        Next

    End Sub

    Sub nortruthtable()
        Console.WriteLine("norgate truthtable")
        Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", "InputA", "inputB", "Output")
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", -1 * CInt(i = 1), -1 * CInt(j = 1), -1 * CInt(notgate(orgate(i = 1, j = 1))))
            Next
        Next
    End Sub
    Sub Main()
        Dim i As Boolean
        Dim j As Boolean
        Dim intake As String
        Dim gateoutput As Boolean
        Dim usergateselection As String
        Dim userselectinggate As Boolean = True
        Dim userselectedgate As Integer


        andtruthtable()
        orgatetruthtable()
        xorgatetruthtable()
        notgatetruthtable()
        nandgatetruthtable()
        nortruthtable()




        Console.ReadKey()

    End Sub



End Module
