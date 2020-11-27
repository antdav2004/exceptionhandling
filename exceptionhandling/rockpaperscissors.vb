Option Strict On
Option Explicit On

Module rockpaperscissors
    'New random object
    Private r As New Random
    Function Gamelength() As Integer
        Dim MenuOptions() As String = {"1 turn", "best of 3 ", "best of five"}
        Dim turns As Integer
        Dim action As String


        Do
            Dim Menuresponse As Integer = Menu(MenuOptions)
            Console.Clear()
            Console.WriteLine("AND PRESS ENTER TO GO BACK TO MENU")
            If Menuresponse = MenuOptions.Count + 1 Then 'the last or extra option in the menu is to exit the program
                turns = 0
                Exit Function

            End If
            Select Case Menuresponse
                Case 1
                    turns = 1
                Case 2
                    turns = 3
                Case 3
                    turns = 5


            End Select
            Return turns
        Loop
    End Function
    Sub Main()
        Dim turns As Integer
        Dim userscore As Integer
        Dim compscore As Integer
        turns = Gamelength()
        'Loop indefinitely
        Dim turn As Integer
        For turn = 0 To turns - 1

            'Get the user input
            Dim user_input As String = String.Empty

            'Loop until the user input isn't empty
            Do While user_input = String.Empty
                Console.WriteLine("Please type in: Rock, Paper, or Scissors")

                Dim input As String = Console.ReadLine
                If input.ToLowerInvariant = "rock" OrElse input.ToLowerInvariant = "paper" OrElse input.ToLowerInvariant = "scissors" Then
                    user_input = input
                End If
            Loop

            'Get the computer's input from the AI function
            Dim comp_input As String = AI()

            'Write out...
            'You picked: <rock/paper/scissors>
            'The computer picked: <rock/paper/scissors>
            Console.Write(String.Format("You picked: {0}{1}The computer picked: {2}{1}", user_input, Environment.NewLine, comp_input))

            'Now type if it's a win, lose, or draw
            If user_input = comp_input Then
                Console.WriteLine("It's a draw.")
            ElseIf user_input = "rock" AndAlso comp_input = "paper" OrElse
                    user_input = "paper" AndAlso comp_input = "scissors" OrElse
                    user_input = "scissors" AndAlso comp_input = "rock" Then
                Console.WriteLine("You lost...")
                compscore += 1
            ElseIf user_input = "rock" AndAlso comp_input = "scissors" OrElse
                    user_input = "paper" AndAlso comp_input = "rock" OrElse
                    user_input = "scissors" AndAlso comp_input = "paper" Then
                Console.WriteLine("You won!")
                userscore += 1

            End If
            Console.ReadKey()
            Console.WriteLine()

        Next turn
        If userscore > compscore Then
            Console.Write("You have won and will win absolutely nothing")
            Module1.newlogentry("win rock paper scissors")
        Else
            Console.Write("you lost this game of chance")
            Module1.newlogentry("lose rock paper scissors")
        End If

    End Sub

    Private Function AI() As String


        Select Case r.Next(0, 3)
            Case 0
                Return "rock"
            Case 1
                Return "paper"
            Case 2
                Return "scissors"
            Case Else
                Return "error"
        End Select
    End Function

End Module

