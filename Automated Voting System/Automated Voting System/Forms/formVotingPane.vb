Public Class formVotingPane

    ' National Candidates

    ' President
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles presidentCB1.CheckedChanged

        If presidentCB1.Checked = True Then
            presidentCB2.Checked = False
            presidentLbl.Text = presidentCB1.Text
            votecounts = votecounts + 1
        Else
            presidentLbl.Text = ""
            votecounts = votecounts - 1
        End If



    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles presidentCB2.CheckedChanged

        If presidentCB2.Checked = True Then
            presidentCB1.Checked = False
            presidentLbl.Text = presidentCB2.Text
            votecounts = votecounts + 1
        Else
            presidentLbl.Text = ""
            votecounts = votecounts - 1
        End If
    End Sub

    'VP-Internal
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles vpinternalCB1.CheckedChanged

        If vpinternalCB1.Checked = True Then
            vpinternalCB2.Checked = False
            vpinternalLbl.Text = vpinternalCB1.Text
            votecounts = votecounts + 1
        Else
            vpinternalLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles vpinternalCB2.CheckedChanged

        If vpinternalCB2.Checked = True Then
            vpinternalCB1.Checked = False
            vpinternalLbl.Text = vpinternalCB2.Text
            votecounts = votecounts + 1
        Else
            vpinternalLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'VP-External
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles vpexternalCB1.CheckedChanged

        If vpexternalCB1.Checked = True Then
            vpexternalCB2.Checked = False
            vpexternalLbl.Text = vpexternalCB1.Text
            votecounts = votecounts + 1
        Else
            vpexternalLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles vpexternalCB2.CheckedChanged

        If vpexternalCB2.Checked = True Then
            vpexternalCB1.Checked = False
            vpexternalLbl.Text = vpexternalCB2.Text
            votecounts = votecounts + 1
        Else
            vpexternalLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Secretary
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles secretaryCB1.CheckedChanged

        If secretaryCB1.Checked = True Then
            secretaryCB2.Checked = False
            secretaryLbl.Text = secretaryCB1.Text
            votecounts = votecounts + 1
        Else
            secretaryLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles secretaryCB2.CheckedChanged

        If secretaryCB2.Checked = True Then
            secretaryCB1.Checked = False
            secretaryLbl.Text = secretaryCB2.Text
            votecounts = votecounts + 1
        Else
            secretaryLbl.Text = ""
            votecounts = votecounts - 1
        End If


    End Sub

    'Auditor
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles auditorCB1.CheckedChanged

        If auditorCB1.Checked = True Then
            auditorCB2.Checked = False
            auditorLbl.Text = auditorCB1.Text
            votecounts = votecounts + 1
        Else
            auditorLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles auditorCB2.CheckedChanged

        If auditorCB2.Checked = True Then
            auditorCB1.Checked = False
            auditorLbl.Text = auditorCB2.Text
            votecounts = votecounts + 1
        Else
            auditorLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Treasurer
    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles treasurerCB1.CheckedChanged

        If treasurerCB1.Checked = True Then
            treasurerCB2.Checked = False
            treasurerLbl.Text = treasurerCB1.Text
            votecounts = votecounts + 1
        Else
            treasurerLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles treasurerCB2.CheckedChanged

        If treasurerCB2.Checked = True Then
            treasurerCB1.Checked = False
            treasurerLbl.Text = treasurerCB2.Text
            votecounts = votecounts + 1
        Else
            treasurerLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Local Candidates

    'Chairman
    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles chairmanCB1.CheckedChanged

        If chairmanCB1.Checked = True Then
            chairmanCB2.Checked = False
            chairmanLbl.Text = chairmanCB1.Text
            votecounts = votecounts + 1
        Else
            chairmanLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles chairmanCB2.CheckedChanged

        If chairmanCB2.Checked = True Then
            chairmanCB1.Checked = False
            chairmanLbl.Text = chairmanCB2.Text
            votecounts = votecounts + 1
        Else
            chairmanLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Vice Chairman
    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles vicechairmanCB1.CheckedChanged

        If vicechairmanCB1.Checked = True Then
            vicechairmanCB2.Checked = False
            vicechairmanLbl.Text = vicechairmanCB1.Text
            votecounts = votecounts + 1
        Else
            vicechairmanLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles vicechairmanCB2.CheckedChanged

        If vicechairmanCB2.Checked = True Then
            vicechairmanCB1.Checked = False
            vicechairmanLbl.Text = vicechairmanCB2.Text
            votecounts = votecounts + 1
        Else
            vicechairmanLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Secretary
    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles lsecretaryCB1.CheckedChanged

        If lsecretaryCB1.Checked = True Then
            lsecretaryCB2.Checked = False
            lsecretaryLbl.Text = lsecretaryCB1.Text
            votecounts = votecounts + 1
        Else
            lsecretaryLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles lsecretaryCB2.CheckedChanged

        If lsecretaryCB2.Checked = True Then
            lsecretaryCB1.Checked = False
            lsecretaryLbl.Text = lsecretaryCB2.Text
            votecounts = votecounts + 1
        Else
            lsecretaryLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Treasurer
    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles ltreasurerCB1.CheckedChanged

        If ltreasurerCB1.Checked = True Then
            ltreasurerCB2.Checked = False
            ltreasurerLbl.Text = ltreasurerCB1.Text
            votecounts = votecounts + 1
        Else
            ltreasurerLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles ltreasurerCB2.CheckedChanged

        If ltreasurerCB2.Checked = True Then
            ltreasurerCB1.Checked = False
            ltreasurerLbl.Text = ltreasurerCB2.Text
            votecounts = votecounts + 1
        Else
            ltreasurerLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Auditor
    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles lauditorCB1.CheckedChanged

        If lauditorCB1.Checked = True Then
            lauditorCB2.Checked = False
            lauditorLbl.Text = lauditorCB1.Text
            votecounts = votecounts + 1
        Else
            lauditorLbl.Text = ""
        End If

    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles lauditorCB2.CheckedChanged

        If lauditorCB2.Checked = True Then
            lauditorCB1.Checked = False
            lauditorLbl.Text = lauditorCB2.Text
            votecounts = votecounts + 1
        Else
            lauditorLbl.Text = ""
            votecounts = votecounts - 1
        End If

    End Sub

    'Board Members
    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles boardmemberCB1.CheckedChanged

        If boardmemberCB1.Checked = True Then
            If boardmemberLbl.Text = "" Then
                boardmemberLbl.Text = boardmemberCB1.Text
                votecounts = votecounts + 1
            ElseIf boardmember2Lbl.Text = "" Then
                boardmember2Lbl.Text = boardmemberCB1.Text
                votecounts = votecounts + 1
            ElseIf boardmember3Lbl.Text = "" Then
                boardmember3Lbl.Text = boardmemberCB1.Text
                votecounts = votecounts + 1
            ElseIf boardmember4Lbl.Text = "" Then
                boardmember4Lbl.Text = boardmemberCB1.Text
                votecounts = votecounts + 1
            ElseIf boardmember5Lbl.Text = "" Then
                boardmember5Lbl.Text = boardmemberCB1.Text
                votecounts = votecounts + 1
            End If
        Else
            If boardmemberLbl.Text = boardmemberCB1.Text Then
                boardmemberLbl.Text = boardmember2Lbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember2Lbl.Text = boardmemberCB1.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember3Lbl.Text = boardmemberCB1.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember4Lbl.Text = boardmemberCB1.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember3Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember5Lbl.Text = boardmemberCB1.Text Then
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            End If
        End If

    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles boardmemberCB2.CheckedChanged

        If boardmemberCB2.Checked = True Then
            If boardmemberLbl.Text = "" Then
                boardmemberLbl.Text = boardmemberCB2.Text
                votecounts = votecounts + 1
            ElseIf boardmember2Lbl.Text = "" Then
                boardmember2Lbl.Text = boardmemberCB2.Text
                votecounts = votecounts + 1
            ElseIf boardmember3Lbl.Text = "" Then
                boardmember3Lbl.Text = boardmemberCB2.Text
                votecounts = votecounts + 1
            ElseIf boardmember4Lbl.Text = "" Then
                boardmember4Lbl.Text = boardmemberCB2.Text
                votecounts = votecounts + 1
            ElseIf boardmember5Lbl.Text = "" Then
                boardmember5Lbl.Text = boardmemberCB2.Text
                votecounts = votecounts + 1
            End If
        Else
            If boardmemberLbl.Text = boardmemberCB2.Text Then
                boardmemberLbl.Text = boardmember2Lbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember2Lbl.Text = boardmemberCB2.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember3Lbl.Text = boardmemberCB2.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember4Lbl.Text = boardmemberCB2.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember3Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember5Lbl.Text = boardmemberCB2.Text Then
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            End If
        End If

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        If votecounts = 0 Then
            MsgBox("Click the ABSTAIN box if you don't want to vote.")
        Else
            formConfirmation.nameLbl.Text = studentnameLbl.Text
            formConfirmation.courseLbl.Text = courseLbl.Text
            formConfirmation.presidentLbl.Text = presidentLbl.Text
            formConfirmation.vpinternalLbl.Text = vpinternalLbl.Text
            formConfirmation.vpexternalLbl.Text = vpexternalLbl.Text
            formConfirmation.secretaryLbl.Text = secretaryLbl.Text
            formConfirmation.auditorLbl.Text = auditorLbl.Text
            formConfirmation.treasurerLbl.Text = treasurerLbl.Text
            formConfirmation.chairmanLbl.Text = chairmanLbl.Text
            formConfirmation.vicechairmanLbl.Text = vicechairmanLbl.Text
            formConfirmation.lsecretaryLbl.Text = lsecretaryLbl.Text
            formConfirmation.ltreasurerLbl.Text = ltreasurerLbl.Text
            formConfirmation.lauditorLbl.Text = lauditorLbl.Text
            formConfirmation.boardmem1Lbl.Text = boardmemberLbl.Text
            formConfirmation.boardmem2Lbl.Text = boardmember2Lbl.Text
            formConfirmation.boardmem3Lbl.Text = boardmember3Lbl.Text
            formConfirmation.boardmem4Lbl.Text = boardmember4Lbl.Text
            formConfirmation.boardmem5Lbl.Text = boardmember5Lbl.Text

            formConfirmation.ShowDialog()
            formConfirmation.Dispose()

        End If

    End Sub

    Private Sub formVotingPane_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub formVotingPane_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KeyPreview = True

    End Sub

    Private Sub abstainCB_CheckedChanged(sender As Object, e As EventArgs) Handles abstainCB.CheckedChanged
        If abstainCB.Checked = True Then
            votecounts = votecounts + 1
            presidentLbl.Text = ""
            vpinternalLbl.Text = ""
            vpexternalLbl.Text = ""
            secretaryLbl.Text = ""
            auditorLbl.Text = ""
            treasurerLbl.Text = ""
            chairmanLbl.Text = ""
            vicechairmanLbl.Text = ""
            lsecretaryLbl.Text = ""
            lauditorLbl.Text = ""
            ltreasurerLbl.Text = ""
            boardmemberLbl.Text = ""
            boardmember2Lbl.Text = ""
            boardmember3Lbl.Text = ""
            boardmember4Lbl.Text = ""
            presidentCB1.Checked = False
            presidentCB2.Checked = False
            vpinternalCB1.Checked = False
            vpinternalCB2.Checked = False
            vpexternalCB1.Checked = False
            vpexternalCB2.Checked = False
            secretaryCB1.Checked = False
            secretaryCB2.Checked = False
            auditorCB1.Checked = False
            auditorCB2.Checked = False
            treasurerCB1.Checked = False
            treasurerCB2.Checked = False
            chairmanCB1.Checked = False
            chairmanCB2.Checked = False
            vicechairmanCB1.Checked = False
            vicechairmanCB2.Checked = False
            lsecretaryCB1.Checked = False
            lsecretaryCB2.Checked = False
            lauditorCB1.Checked = False
            lauditorCB2.Checked = False
            ltreasurerCB1.Checked = False
            ltreasurerCB2.Checked = False
            boardmemberCB1.Checked = False
            boardmemberCB2.Checked = False
            boardmemberCB3.Checked = False
            boardmemberCB4.Checked = False
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        Else
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            votecounts = 0
        End If
    End Sub


    
    Private Sub boardmemberCB3_CheckedChanged(sender As Object, e As EventArgs) Handles boardmemberCB3.CheckedChanged
        If boardmemberCB3.Checked = True Then
            If boardmemberLbl.Text = "" Then
                boardmemberLbl.Text = boardmemberCB3.Text
                votecounts = votecounts + 1
            ElseIf boardmember2Lbl.Text = "" Then
                boardmember2Lbl.Text = boardmemberCB3.Text
                votecounts = votecounts + 1
            ElseIf boardmember3Lbl.Text = "" Then
                boardmember3Lbl.Text = boardmemberCB3.Text
                votecounts = votecounts + 1
            ElseIf boardmember4Lbl.Text = "" Then
                boardmember4Lbl.Text = boardmemberCB3.Text
                votecounts = votecounts + 1
            ElseIf boardmember5Lbl.Text = "" Then
                boardmember5Lbl.Text = boardmemberCB3.Text
                votecounts = votecounts + 1
            End If
        Else
            If boardmemberLbl.Text = boardmemberCB3.Text Then
                boardmemberLbl.Text = boardmember2Lbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember2Lbl.Text = boardmemberCB3.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember3Lbl.Text = boardmemberCB3.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember4Lbl.Text = boardmemberCB3.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember3Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember5Lbl.Text = boardmemberCB3.Text Then
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            End If
        End If
    End Sub

    Private Sub boardmemberCB4_CheckedChanged(sender As Object, e As EventArgs) Handles boardmemberCB4.CheckedChanged
        If boardmemberCB4.Checked = True Then
            If boardmemberLbl.Text = "" Then
                boardmemberLbl.Text = boardmemberCB4.Text
                votecounts = votecounts + 1
            ElseIf boardmember2Lbl.Text = "" Then
                boardmember2Lbl.Text = boardmemberCB4.Text
                votecounts = votecounts + 1
            ElseIf boardmember3Lbl.Text = "" Then
                boardmember3Lbl.Text = boardmemberCB4.Text
                votecounts = votecounts + 1
            ElseIf boardmember4Lbl.Text = "" Then
                boardmember4Lbl.Text = boardmemberCB4.Text
                votecounts = votecounts + 1
            ElseIf boardmember5Lbl.Text = "" Then
                boardmember5Lbl.Text = boardmemberCB4.Text
                votecounts = votecounts + 1
            End If
        Else
            If boardmemberLbl.Text = boardmemberCB4.Text Then
                boardmemberLbl.Text = boardmember2Lbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember2Lbl.Text = boardmemberCB4.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember3Lbl.Text = boardmemberCB4.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember4Lbl.Text = boardmemberCB4.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember3Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember5Lbl.Text = boardmemberCB4.Text Then
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            End If
        End If
    End Sub

    Private Sub boardmemberCB5_CheckedChanged(sender As Object, e As EventArgs) Handles boardmemberCB5.CheckedChanged
        If boardmemberCB5.Checked = True Then
            If boardmemberLbl.Text = "" Then
                boardmemberLbl.Text = boardmemberCB5.Text
                votecounts = votecounts + 1
            ElseIf boardmember2Lbl.Text = "" Then
                boardmember2Lbl.Text = boardmemberCB5.Text
                votecounts = votecounts + 1
            ElseIf boardmember3Lbl.Text = "" Then
                boardmember3Lbl.Text = boardmemberCB5.Text
                votecounts = votecounts + 1
            ElseIf boardmember4Lbl.Text = "" Then
                boardmember4Lbl.Text = boardmemberCB5.Text
                votecounts = votecounts + 1
            ElseIf boardmember5Lbl.Text = "" Then
                boardmember5Lbl.Text = boardmemberCB5.Text
                votecounts = votecounts + 1
            End If
        Else
            If boardmemberLbl.Text = boardmemberCB5.Text Then
                boardmemberLbl.Text = boardmember2Lbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember2Lbl.Text = boardmemberCB5.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember3Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember3Lbl.Text = boardmemberCB5.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember4Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember4Lbl.Text = boardmemberCB5.Text Then
                boardmemberLbl.Text = boardmemberLbl.Text
                boardmember2Lbl.Text = boardmember2Lbl.Text
                boardmember3Lbl.Text = boardmember3Lbl.Text
                boardmember4Lbl.Text = boardmember5Lbl.Text
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            ElseIf boardmember5Lbl.Text = boardmemberCB5.Text Then
                boardmember5Lbl.Text = ""
                votecounts = votecounts - 1
            End If
        End If
    End Sub

End Class