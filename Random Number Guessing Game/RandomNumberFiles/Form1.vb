' Written by Michael Kellar
' 10/12/15
Option Strict On
Option Explicit On

Public Class Form1


    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click

        ' Define private variables
        Dim intNumberToGuess As Integer = 0     ' Number to guess.
        Dim intGuessCount As Integer = 0        ' Count of guesses.
        Dim rand As New Random      ' Create a Random object.
        Dim strInput As String      ' Holds input
        Dim intGuessed As Integer   ' User Input of guessed number.


        ' If number is at default 0 from start or reset, then get a random integer from 1-100 and assign to intNumberToGuess.
        If intNumberToGuess = 0 Then
            intNumberToGuess = rand.Next(100) + 1
        End If

        ' Loop until the correct number is guessed based on intNumberToGuess
        Do
            ' Prompts for a number as a guess, and adds 1 to the count.
            strInput = InputBox("Please guess a number from 1 - 100", "Guess a number", "0")

            If Integer.TryParse(strInput, intGuessed) Then
                ' Converts input to integer.
                intGuessCount += 1


                If intGuessed = intNumberToGuess Then
                    ' If Guessed number is the same as the NumberToGuess, then will give a message that they were correct to guess the intNumberToGuess and their amount of guesses.
                    MessageBox.Show("Congratulations, you guessed the correct number of " & intNumberToGuess & " after " & intGuessCount & " guess(es).")


                ElseIf intGuessed < 1 Or intGuessed > 100 Then
                    ' Error if outside the range.
                    MessageBox.Show("You are outside of the range of 1 - 100")


                ElseIf intGuessed > intNumberToGuess Then
                    ' Error for too high of a guess.
                    MessageBox.Show("Too high, try again.")


                ElseIf intGuessed < intNumberToGuess Then
                    ' Error for too low of a guess.
                    MessageBox.Show("Too low, try again.")

                Else
                    ' Error message for anything not caught.
                    MessageBox.Show("I'm not sure how you got here, but please guess a whole number from 1-100")

                End If ' End of Number Comparison

            ElseIf strInput = "" Then
                ' Use to exit the loop when the Cancel button or X is pressed.
                Exit Do


            ElseIf strInput.ToUpper = "SHOW" Or strInput.ToUpper = "DEBUG" Or strInput.ToUpper = "NUMBER" Or strInput.ToUpper = "S" Then
                ' Use to get the number to know the number.
                MessageBox.Show("Oops, you found the cheat. The number you would need to guess is " & CStr(intNumberToGuess))

            ElseIf strInput.ToUpper = "EXIT" Or strInput.ToUpper = "CANCEL" Or strInput.ToUpper = "CLOSE" Or strInput.ToUpper = "X" Then
                ' Use to exit the loop, left just for the heck of it, added when I couldn't figure out why the regular cancel button wouldn't work.
                Exit Sub

            ElseIf strInput.ToUpper = "HELP" Or strInput.ToUpper = "H" Then
                ' Condescending help message.
                MessageBox.Show("Really? You're looking for help in a game that's simply asking for a number from 1 to 100? If you're looking for a cheat, you're looking in the wrong place.")

            Else
                ' Silly error message
                MessageBox.Show("You think there's cheats in this game? Please guess a number from 1 - 100")

            End If ' Ends input value comparison.


        Loop Until intGuessed = intNumberToGuess ' End game/loop


    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub


End Class
