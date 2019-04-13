Public Class formLogin

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        If idnumberTB.Text = "" Then
            MsgBox("Input ID Number!")
        ElseIf lastnameTB.Text = "" Then
            MsgBox("Input Password!")
        Else
            retrievestudentinfo()
        End If

    End Sub

    Private Sub formLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt AndAlso e.KeyCode = Keys.F4 Then
            MessageBox.Show("You are not authorized to close this application.", "UNAUTHORIZED CLOSING OF APPLICATION DETECTED.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        ElseIf e.Alt AndAlso e.KeyCode = Keys.F1 Then
            e.Handled = True
            exitLbl.Text = InputBox("Enter passcode to close the application:", "Administrative Rights.")
            If exitLbl.Text = "cpeadmin" Then
                Me.Close()
            Else
                idnumberTB.Focus()
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If idnumberTB.Text = "" Then
                MsgBox("Input ID Number!")
            ElseIf lastnameTB.Text = "" Then
                MsgBox("Input Password!")
            Else
                retrievestudentinfo()
            End If
        End If
    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        idnumberTB.Focus()
        KeyPreview = True

    End Sub
End Class
