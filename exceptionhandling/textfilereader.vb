Imports System.IO



Module textfilereader


    Function getfilearray()
        Dim filelinearray As ArrayList = New ArrayList
        Using sr As StreamReader = New StreamReader("EnglishSample.txt")

            Dim line As String
            line = sr.ReadLine()
            While line <> Nothing
                Console.WriteLine(line)
                line = LCase(line)
                filelinearray.Add(line)
                line = sr.ReadLine()
            End While

        End Using
        Return (filelinearray)
    End Function
    Sub main()
        ' englishg file is one line so adjuyst code accordingly
        Dim filelinearray As ArrayList

        Dim wordarray As ArrayList
        Dim currentline As String
        Console.ReadKey()
        Console.WriteLine("working")
        ' scanning in the text'
        filelinearray = getfilearray()
        For i = 0 To filelinearray.Count - 1 'print each of the standard menu items
            currentline = filelinearray(i)
            wordarray.add(currentline.Split(" "c))

        Next


        Console.WriteLine("Read In File!!!")
        Console.WriteLine(wordarray(0))
        Console.ReadLine()
    End Sub
End Module
