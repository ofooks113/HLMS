Public Class Welcome
    Dim username As String
    Private Sub cmdcontinue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdcontinue.Click
        If txtname.Text = Nothing Then
            'This would happen if the user doesn't enter anything into the textbox
            MsgBox("Invalid output. Please enter your name using letters only (i.e. no numbers or other characters)",, "Invalid Input")
        ElseIf txtname.Text = username Then
            MsgBox("Name already inputted.",, "Welcome")
            Me.Hide()
            FormMenu.Show()
        Else
            'If the user enters the name, a message would welcome the user with their entered name (e.g. "Welcome Juliet")
            'Once the name is entered and the message is close, the Main Menu Form will reopen again.
            MsgBox("Welcome " + txtname.Text,, "Welcome")
            Me.Hide()
            FormMenu.Show()
        End If
    End Sub
    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        'allow backspace & space
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            'check if outside range of a-z / A-Z
            If ((Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90)) Then
                'key pressed isn't a-z / A-Z, space or backspace, so ignore it
                e.Handled = True
                MsgBox("Invalid output. Please enter your name using letters only (i.e. no numbers or other characters)")
            End If
        End If
    End Sub
End Class
