Imports System.IO
Imports System.Runtime.Remoting.Channels
Imports System.Data.SqlClient
Imports System.Xml
Imports Module2
Imports System.Math
Module Module1
    Sub MySubroutine1()
        Console.WriteLine("welcome to the log viewing area")
        Console.ReadKey()
        Using sr As StreamReader = New StreamReader("log.txt")
            Dim line As String
            line = sr.ReadLine()
            While line <> Nothing
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
            Console.ReadKey()
        End Using
    End Sub
    Sub mysub2()
        Console.Write("doing menu item 2")
        truthtables.Main()

    End Sub
    Sub mysub3()
        Dim path As String = "C:\Users\antdav\source\repos\exceptionhandling\exceptionhandling\bin\Debug\log.txt"
        Console.Write("clearing log")
        Console.ReadKey()
        System.IO.File.WriteAllText(path, "")

    End Sub
    Sub mysub4()
        Console.ReadKey()
        rockpaperscissors.Main()

    End Sub
    Sub mysub5()
        'ceaser cipher encript
        Dim ceaserinput As String
        Dim key As Integer
        Dim encryptedmsg As String
        Console.WriteLine("welcom to the ceaser cipher encrypter." & vbNewLine & "enter the text you wouldlike to decrypt or press enter to return to menu")
        ceaserinput = Console.ReadLine()
        If ceaserinput.Length > 0 Then
            Dim ceaserarray As Char() = ceaserinput.ToCharArray
            Console.WriteLine("please enter your key (no negatives)")
            key = Console.ReadLine()
            For i = 0 To ceaserarray.Length - 1
                encryptedmsg = encryptedmsg & Chr(Asc(ceaserarray(i)) + key)


            Next
            Console.WriteLine("done!" & vbNewLine & "here is your encrypted text")
            Console.WriteLine(encryptedmsg)
            Console.ReadKey()
            newlogentry("encrypt text with ceaser cipher")
        Else
            Exit Sub


        End If
    End Sub
    Sub mysub6()
        'ceaser cipher decrypt
        Dim decoded As String
        Dim key As Integer
        Dim todecode As String
        Console.WriteLine("welcome yto the ceasart cipher decrypter" & vbNewLine & "enter the text you wishg to decrypt or press enter to return to the menu")
        todecode = Console.ReadLine()

        If todecode.Length > 0 Then
            Dim ceaserarray As Char() = todecode.ToCharArray
            Console.WriteLine("please enter your key (no negatives)")
            key = Console.ReadLine()
            For i = 0 To ceaserarray.Length - 1
                decoded = decoded & Chr(Asc(ceaserarray(i)) - key)


            Next
            Console.WriteLine("done!" & vbNewLine & "here is your encrypted text")
            Console.WriteLine(decoded)
            Console.ReadKey()
            newlogentry("decrypt using ceaser cipher")
        Else
            Exit Sub


        End If

    End Sub
    Sub mysub7()
        'custom "digital safe"
        Dim key As Integer
        Dim myla As New ArrayList

        Console.WriteLine("welcome to your own personal digital safe exzcept it can be deleted by anyone")
        Console.WriteLine("please enter your key")
        Dim decodedline As String
        key = Console.ReadLine
        Using SR As StreamReader = New StreamReader("SAFE.txt")
            Dim line As String
            line = SR.ReadLine
            While line <> Nothing
                Dim ceaserarray As Char() = line.ToCharArray
                For i = 0 To ceaserarray.Length - 1
                    decodedline = decodedline & Chr(Asc(ceaserarray(i)) - key)


                Next


                myla.Add(decodedline)
                decodedline = ("")


                line = SR.ReadLine()
            End While
            Console.WriteLine("done decrypting!!")
            For i = 0 To myla.Count - 1
                Console.WriteLine(myla(i))

            Next

        End Using
        Console.ReadKey()
    End Sub


    Sub mysub8()
        ' text file read in and frequency monitor
        textfilereader.main()
    End Sub
    Sub Main()
        Dim MenuOptions() As String = {"view log", "truth table", "cut log", "rock paper scissors(1p)", "ceaser cipher encrypt", "ceaser cypher decryt(key)", "custom safe access","text file word ana"}
        Dim action As String
        newlogentry("program started")

        Do
            Dim Menuresponse As Integer = Menu(MenuOptions)
            Console.Clear()
            If Menuresponse = MenuOptions.Count + 1 Then 'the last or extra option in the menu is to exit the program
                Exit Sub
            End If
            Select Case Menuresponse
                Case 1
                    MySubroutine1()
                    newlogentry(" option 1( reading out log)")
                Case 2
                    mysub2()
                    newlogentry(" option 2 (truth table)")
                Case 3
                    mysub3()

                Case 4
                    mysub4()
                    newlogentry("option 4 (rock paper scissors)")
                Case 5
                    newlogentry("option 5 (ceaser encrypt)")
                    mysub5()

                Case 6
                    newlogentry("option 6 (ceaser decrypt)")
                    mysub6()
                Case 7
                    mysub7()
                Case 8
                    mysub8()

            End Select
        Loop
    End Sub

    Sub newlogentry(action As String)
        Using sw As StreamWriter = New StreamWriter("LOG.txt", True)
            sw.WriteLine("at {0}  minutes of hour {1} of the day {2} / {3} /{4}", CStr(Minute(Now)), CStr(Hour(Now)), CStr(Day(Now)), CStr(Month(Now)), CStr(Year(Now)))
            sw.WriteLine("user did " & action)

        End Using

    End Sub
    Function Menu(MenuOptions As String()) As Integer
        Console.Clear()
        Console.WriteLine("---MENU---")
        Console.WriteLine()
        For i = 0 To MenuOptions.Length - 1 'print each of the standard menu items
            Console.WriteLine(i + 1 & " : " & MenuOptions(i))
        Next
        Console.WriteLine(MenuOptions.Length + 1 & " : Exit Program") 'add an extra menu item to exit the program
        Console.WriteLine()
        Return ChooseMenuOption(MenuOptions.Length + 1)
    End Function

    Function ChooseMenuOption(NumberOfOptions As Integer)
        Dim Response As Integer = -1
        Do While Response = -1 'response of -1 means that we haven't suceeded in getting a proper menu choice
            Console.WriteLine("Choose an item from: 1 to " & NumberOfOptions)
            Try
                Dim Input As Integer = Console.ReadLine() 'get the users input and try to cast it to an integer
                If Input > 0 And Input <= NumberOfOptions Then 'if this suceeds then check it's in the right range
                    Response = Input
                Else
                    Err.Raise(1)
                End If
            Catch ex As Exception
                Console.WriteLine("Please only enter an integer between 1 & " & NumberOfOptions)
                newlogentry(" not use the requred format")

            Finally
                Console.WriteLine()
            End Try
        Loop
        Return Response
    End Function
End Module
