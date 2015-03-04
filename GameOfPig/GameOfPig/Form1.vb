Public Class Form1
    'Variable declarations
    Dim intCurrentRoll As Integer
    Dim intComputerRoll As Integer
    Dim intTurnTotal(-1) As Integer
    Dim intComputerTurnTotal(-1) As Integer
    Dim intOverallTotal As Integer
    Dim intComputerOverallTotal As Integer
    Dim intRandomHuman1 As Integer
    Dim intRandomHuman2 As Integer
    Dim intRandomComputer1 As Integer
    Dim intRandomComputer2 As Integer
    Dim intEnd As Integer
    Dim intClicked As Integer = 0
    Dim strName As String
    'Name Prompt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strName As String = InputBox("Please Enter your name: ")
        Me.lblPlayer.Text = strName
        Me.btnComputer.Enabled = False


    End Sub

    Private Sub ButtonRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Me.lblComputerRoll.Text = ""
        Me.lblComputerTurnTotal.Text = ""

        intEnd = intTurnTotal.Length
        ReDim Preserve intTurnTotal(intEnd)
        'human Random numbers
        intRandomHuman1 = 5 * Rnd() + 1
        intRandomHuman2 = 5 * Rnd() + 1

        'Display Numbers
        Me.lblCurrentRoll.Text = intRandomHuman1 & "," & intRandomHuman2
        'Display added numbers
        intTurnTotal(intEnd) = intRandomHuman1 + intRandomHuman2
        Me.lblTurnTotal.Text = intTurnTotal(intEnd)

        If intRandomHuman1 = Val(6) Or intRandomHuman2 = Val(6) Then
            MsgBox("Your Turn over")
            intTurnTotal(intEnd) = 0
            intOverallTotal = 0
            Me.btnComputer.Enabled = True
            Me.btnRoll.Enabled = False
        Else
            'display total
            intOverallTotal = (intTurnTotal(intEnd) + intOverallTotal)
            Me.lblOverallTotal.Text = intOverallTotal
            Call Decision(sender, e)
        End If


    End Sub
    'Human Decision
    Private Sub Decision(sender As Object, e As EventArgs)

        Select Case InputBox("A:Roll again, B:End turn")
            Case "A"
                Call ButtonRoll_Click(sender, e)
            Case "B"
                MsgBox("Computer Turn")
                Me.btnComputer.Enabled = True
                Me.btnRoll.Enabled = False

        End Select

    End Sub
    'Computer Decision
    Private Sub ComputerDecision(sender As Object, e As EventArgs)
        If intComputerTurnTotal(intEnd) >= Val(10) Then
            MsgBox("Computer Turn Over")
            Me.btnRoll.Enabled = True
            Me.btnComputer.Enabled = False
        Else
            Call btnComputer_Click(sender, e)
        End If
    End Sub

    Private Sub btnComputer_Click(sender As Object, e As EventArgs) Handles btnComputer.Click
        Me.lblTurnTotal.Text = ""
        Me.lblCurrentRoll.Text = ""

        intEnd = intComputerTurnTotal.Length
        ReDim Preserve intComputerTurnTotal(intEnd)
        'computer random numbers
        intRandomComputer1 = 5 * Rnd() + 1
        intRandomComputer2 = 5 * Rnd() + 1

        'Display Numbers
        Me.lblComputerRoll.Text = intRandomComputer1 & "," & intRandomComputer2

        If intRandomComputer1 = Val(6) Or intRandomComputer2 = Val(6) Then
            MsgBox("Computer Turn over")
           
            intComputerTurnTotal(intEnd) = 0
            Me.btnRoll.Enabled = True
            Me.btnComputer.Enabled = False
            'Display added numbers 
            intComputerTurnTotal(intEnd) = intRandomComputer1 + intRandomComputer2
            Me.lblComputerTurnTotal.Text = intComputerTurnTotal(intEnd)
        Else

            'display total
            intComputerOverallTotal = intComputerTurnTotal(intEnd) + intComputerOverallTotal
            Me.lblComputerOverallTotal.Text = intComputerOverallTotal

            Call ComputerDecision(sender, e)
        End If

        'Turn Counter

        intClicked = intClicked + 1

        If intClicked = 10 Then
            If intComputerOverallTotal > intOverallTotal Then
                MsgBox("Game over: Computer Wins")
            Else
                MsgBox("Game over: " & Me.lblPlayer.Text & " Wins")
            End If

        End If
        Me.lblTurns.Text = intClicked

    End Sub
End Class
