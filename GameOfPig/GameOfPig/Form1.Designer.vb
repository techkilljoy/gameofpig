<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTurnTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrentRoll = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOverallTotal = New System.Windows.Forms.Label()
        Me.lblComputerOverallTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblComputerRoll = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblComputerTurnTotal = New System.Windows.Forms.Label()
        Me.btnComputer = New System.Windows.Forms.Button()
        Me.lblTurns = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTurnTotal
        '
        Me.lblTurnTotal.AutoSize = True
        Me.lblTurnTotal.Location = New System.Drawing.Point(90, 220)
        Me.lblTurnTotal.Name = "lblTurnTotal"
        Me.lblTurnTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTurnTotal.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Roll"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TurnTotal"
        '
        'lblCurrentRoll
        '
        Me.lblCurrentRoll.AutoSize = True
        Me.lblCurrentRoll.Location = New System.Drawing.Point(95, 183)
        Me.lblCurrentRoll.Name = "lblCurrentRoll"
        Me.lblCurrentRoll.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrentRoll.TabIndex = 3
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(42, 108)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 4
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(38, 60)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(0, 24)
        Me.lblPlayer.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Computer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Overall Total"
        '
        'lblOverallTotal
        '
        Me.lblOverallTotal.AutoSize = True
        Me.lblOverallTotal.Location = New System.Drawing.Point(95, 262)
        Me.lblOverallTotal.Name = "lblOverallTotal"
        Me.lblOverallTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblOverallTotal.TabIndex = 8
        '
        'lblComputerOverallTotal
        '
        Me.lblComputerOverallTotal.AutoSize = True
        Me.lblComputerOverallTotal.Location = New System.Drawing.Point(264, 262)
        Me.lblComputerOverallTotal.Name = "lblComputerOverallTotal"
        Me.lblComputerOverallTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblComputerOverallTotal.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Overall Total"
        '
        'lblComputerRoll
        '
        Me.lblComputerRoll.AutoSize = True
        Me.lblComputerRoll.Location = New System.Drawing.Point(273, 183)
        Me.lblComputerRoll.Name = "lblComputerRoll"
        Me.lblComputerRoll.Size = New System.Drawing.Size(0, 13)
        Me.lblComputerRoll.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "TurnTotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(196, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Current Roll"
        '
        'lblComputerTurnTotal
        '
        Me.lblComputerTurnTotal.AutoSize = True
        Me.lblComputerTurnTotal.Location = New System.Drawing.Point(268, 220)
        Me.lblComputerTurnTotal.Name = "lblComputerTurnTotal"
        Me.lblComputerTurnTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblComputerTurnTotal.TabIndex = 9
        '
        'btnComputer
        '
        Me.btnComputer.Location = New System.Drawing.Point(213, 108)
        Me.btnComputer.Name = "btnComputer"
        Me.btnComputer.Size = New System.Drawing.Size(75, 23)
        Me.btnComputer.TabIndex = 15
        Me.btnComputer.Text = "Computer Roll"
        Me.btnComputer.UseVisualStyleBackColor = True
        '
        'lblTurns
        '
        Me.lblTurns.AutoSize = True
        Me.lblTurns.Location = New System.Drawing.Point(171, 322)
        Me.lblTurns.Name = "lblTurns"
        Me.lblTurns.Size = New System.Drawing.Size(0, 13)
        Me.lblTurns.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(86, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Turns"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 361)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTurns)
        Me.Controls.Add(Me.btnComputer)
        Me.Controls.Add(Me.lblComputerOverallTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblComputerRoll)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblComputerTurnTotal)
        Me.Controls.Add(Me.lblOverallTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.lblCurrentRoll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTurnTotal)
        Me.Name = "Form1"
        Me.Text = "Game Of Pig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTurnTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentRoll As System.Windows.Forms.Label
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOverallTotal As System.Windows.Forms.Label
    Friend WithEvents lblComputerOverallTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblComputerRoll As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblComputerTurnTotal As System.Windows.Forms.Label
    Friend WithEvents btnComputer As System.Windows.Forms.Button
    Friend WithEvents lblTurns As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
