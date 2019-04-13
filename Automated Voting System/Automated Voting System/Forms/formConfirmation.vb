Public Class formConfirmation

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        confirmBtn.Text = MessageBox.Show("Are you sure of your voted candidates?", "WARNING: ONCE CONFIRM ITS DONE.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmBtn.Text = DialogResult.Yes Then
            pres = formVotingPane.presidentLbl.Text
            vpintern = formVotingPane.vpinternalLbl.Text
            vpextern = formVotingPane.vpexternalLbl.Text
            sec = formVotingPane.secretaryLbl.Text
            aud = formVotingPane.auditorLbl.Text
            treas = formVotingPane.treasurerLbl.Text
            asec = formVotingPane.chairmanLbl.Text
            busman1 = formVotingPane.vicechairmanLbl.Text
            busman2 = formVotingPane.lsecretaryLbl.Text
            pro1 = formVotingPane.lauditorLbl.Text
            pro2 = formVotingPane.ltreasurerLbl.Text
            boardmem1 = formVotingPane.boardmemberLbl.Text
            boardmem2 = formVotingPane.boardmember2Lbl.Text
            boardmem3 = formVotingPane.boardmember3Lbl.Text
            boardmem4 = formVotingPane.boardmember4Lbl.Text
            boardmem5 = formVotingPane.boardmember5Lbl.Text
            confirmBtn.Text = "CONFIRM"
            handlesVoteLogs()
            updatestudentvoted()
            clearCandidates()
            MsgBox("Thank you for voting!")
            Me.Close()
            formVotingPane.Close()
            formLogin.Show()
            formLogin.idnumberTB.Focus()
        Else
            confirmBtn.Text = "CONFIRM"
        End If
    End Sub

    Private Sub formConfirmation_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt AndAlso e.KeyCode = Keys.F4 Then
            MessageBox.Show("You are not authorized to close this application.", "UNAUTHORIZED CLOSING OF APPLICATION DETECTED.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        ElseIf e.Alt AndAlso e.KeyCode = Keys.F1 Then
            e.Handled = True
            exitLbl.Text = InputBox("Enter passcode to close the application:", "Administrative Rights.")
            If exitLbl.Text = "cpeadmin" Then
                formLogin.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub formConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If presidentLbl.Text = "" Then
            presidentLbl.Text = "-UNDERVOTE-"
            presidentLbl.ForeColor = Color.Gold
        End If
        If vpinternalLbl.Text = "" Then
            vpinternalLbl.Text = "-UNDERVOTE-"
            vpinternalLbl.ForeColor = Color.Gold
        End If
        If vpexternalLbl.Text = "" Then
            vpexternalLbl.Text = "-UNDERVOTE-"
            vpexternalLbl.ForeColor = Color.Gold
        End If
        If secretaryLbl.Text = "" Then
            secretaryLbl.Text = "-UNDERVOTE-"
            secretaryLbl.ForeColor = Color.Gold
        End If
        If auditorLbl.Text = "" Then
            auditorLbl.Text = "-UNDERVOTE-"
            auditorLbl.ForeColor = Color.Gold
        End If
        If treasurerLbl.Text = "" Then
            treasurerLbl.Text = "-UNDERVOTE-"
            treasurerLbl.ForeColor = Color.Gold
        End If
        If chairmanLbl.Text = "" Then
            chairmanLbl.Text = "-UNDERVOTE-"
            chairmanLbl.ForeColor = Color.Gold
        End If
        If vicechairmanLbl.Text = "" Then
            vicechairmanLbl.Text = "-UNDERVOTE-"
            vicechairmanLbl.ForeColor = Color.Gold
        End If
        If lsecretaryLbl.Text = "" Then
            lsecretaryLbl.Text = "-UNDERVOTE-"
            lsecretaryLbl.ForeColor = Color.Gold
        End If
        If ltreasurerLbl.Text = "" Then
            ltreasurerLbl.Text = "-UNDERVOTE-"
            ltreasurerLbl.ForeColor = Color.Gold
        End If
        If lauditorLbl.Text = "" Then
            lauditorLbl.Text = "-UNDERVOTE-"
            lauditorLbl.ForeColor = Color.Gold
        End If
        If boardmem1Lbl.Text = "" Then
            boardmem1Lbl.Text = "-UNDERVOTE-"
            boardmem1Lbl.ForeColor = Color.Gold
        End If
        If boardmem2Lbl.Text = "" Then
            boardmem2Lbl.Text = "-UNDERVOTE-"
            boardmem2Lbl.ForeColor = Color.Gold
        End If
        If boardmem3Lbl.Text = "" Then
            boardmem3Lbl.Text = "-UNDERVOTE-"
            boardmem3Lbl.ForeColor = Color.Gold
        End If
        If boardmem4Lbl.Text = "" Then
            boardmem4Lbl.Text = "-UNDERVOTE-"
            boardmem4Lbl.ForeColor = Color.Gold
        End If
        If boardmem5Lbl.Text = "" Then
            boardmem5Lbl.Text = "-UNDERVOTE-"
            boardmem5Lbl.ForeColor = Color.Gold
        End If
        KeyPreview = True

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

End Class