Imports MySql.Data.MySqlClient

Module dataRetrieve

    Public Sub retrievestudentinfo()

        Try
            dbConnection()
            sql = "SELECT * from student_data WHERE ID_No = '" & formLogin.idnumberTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                idno = dt.Rows(0).Item(0)
                fullname = dt.Rows(0).Item(1) + ", " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
                lastname = dt.Rows(0).Item(1)
                course = dt.Rows(0).Item(4)
                password = dt.Rows(0).Item(5)
                activation = dt.Rows(0).Item(6)
                voted = dt.Rows(0).Item(7)
                If formLogin.idnumberTB.Text = idno And formLogin.lastnameTB.Text = password Then
                    If activation = False Then
                        MsgBox("Activation Required!")
                        clearLogin()
                        formLogin.idnumberTB.Focus()
                    Else
                        If voted = True Then
                            MsgBox("You have already voted!")
                            clearLogin()
                            formLogin.idnumberTB.Focus()
                        Else
                            MsgBox("Welcome " & fullname & "!")
                            retrieveballotno()
                            retrievelocalcandidates()
                            formVotingPane.Show()
                            formLogin.Hide()
                            formVotingPane.studentnameLbl.Text = fullname
                            formVotingPane.courseLbl.Text = course
                            formVotingPane.eballotnoLbl.Text = eballotno
                            clearLogin()
                        End If
                    End If
                Else
                    MsgBox("Incorrect Inputs!")
                    clearLogin()
                    formLogin.idnumberTB.Focus()
                End If
            Else
                MsgBox("Incorrect Inputs!")
                clearLogin()
                formLogin.idnumberTB.Focus()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
            clearLogin()
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub retrieveballotno()

        Try
            dbConnection()
            sql = "SELECT * from eballot_archive WHERE ID_No = @IDNo;"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@IDNo", formLogin.idnumberTB.Text)
            dr = cmd.ExecuteReader
            While dr.Read
                eballotno = dr.GetString("Ballot_No")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try

    End Sub

    Public Sub retrievelocalcandidates()

        If course = "CE" Then
            Candidates()
            department = "Civil Engineering"
        ElseIf course = "CPE" Then
            Candidates()
            department = "Computer Engineering"
        ElseIf course = "ECE" Then
            Candidates()
            department = "Electronics Engineering"
        ElseIf course = "EE" Then
            Candidates()
            department = "Electrical Engineering"
        ElseIf course = "IE" Then
            Candidates()
            department = "Industrial Engineering"
        ElseIf course = "ME" Then
            Candidates()
            department = "Mechanical Engineering"
        End If

    End Sub

    Public Sub Candidates()
        Dim pres1, pres2, vpi1, vpi2, vpe1, vpe2, sec1, sec2, aud1, aud2, tres1, tres2, asec1, asec2, busman1, busman2, busman3, busman4, pro1, pro2, pro3, pro4, b1, b2, b3, b4, b5 As String
        pres1 = ""
        pres2 = ""
        vpi1 = ""
        vpi2 = ""
        vpe1 = ""
        vpe2 = ""
        sec1 = ""
        sec2 = ""
        aud1 = ""
        aud2 = ""
        tres1 = ""
        tres2 = ""
        asec1 = ""
        asec2 = ""
        busman1 = ""
        busman2 = ""
        busman3 = ""
        busman4 = ""
        pro1 = ""
        pro2 = ""
        pro3 = ""
        pro4 = ""
        b1 = ""
        b2 = ""
        b3 = ""
        b4 = ""
        b5 = ""
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'PRESIDENT';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                pres1 = dt.Rows(0).Item(1)
                pres2 = dt.Rows(1).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'VP-INTERNAL';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                vpi1 = dt.Rows(0).Item(1)
                vpi2 = dt.Rows(1).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'VP-EXTERNAL';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                vpe1 = dt.Rows(0).Item(1)
                vpe2 = dt.Rows(1).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'SECRETARY';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                sec1 = dt.Rows(0).Item(1)
                sec2 = dt.Rows(1).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'AUDITOR';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                aud1 = dt.Rows(0).Item(1)
                aud2 = dt.Rows(1).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'TREASURER';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                tres1 = dt.Rows(0).Item(1)
                tres2 = dt.Rows(1).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'ASECRETARY';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                asec1 = dt.Rows(0).Item(1)
                asec2 = dt.Rows(1).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'BUSMANAGER';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                busman1 = dt.Rows(0).Item(1)
                busman2 = dt.Rows(1).Item(1)
                busman3 = dt.Rows(2).Item(1)
                busman4 = dt.Rows(3).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'PRO';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                pro1 = dt.Rows(0).Item(1)
                pro2 = dt.Rows(1).Item(1)
                pro3 = dt.Rows(2).Item(1)
                pro4 = dt.Rows(3).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            dbConnection()
            sql = "SELECT * from candidates WHERE Position = 'BOARD MEMBER';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                b1 = dt.Rows(0).Item(1)
                b2 = dt.Rows(1).Item(1)
                b3 = dt.Rows(2).Item(1)
                b4 = dt.Rows(3).Item(1)
                b5 = dt.Rows(4).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        formVotingPane.presidentCB1.Text = pres1
        formVotingPane.presidentCB2.Text = pres2
        formVotingPane.vpinternalCB1.Text = vpi1
        formVotingPane.vpinternalCB2.Text = vpi2
        formVotingPane.vpexternalCB1.Text = vpe1
        formVotingPane.vpexternalCB2.Text = vpe2
        formVotingPane.secretaryCB1.Text = sec1
        formVotingPane.secretaryCB2.Text = sec2
        formVotingPane.auditorCB1.Text = aud1
        formVotingPane.auditorCB2.Text = aud2
        formVotingPane.treasurerCB1.Text = tres1
        formVotingPane.treasurerCB2.Text = tres2
        formVotingPane.chairmanCB1.Text = asec1
        formVotingPane.chairmanCB2.Text = asec2
        formVotingPane.vicechairmanCB1.Text = busman1
        formVotingPane.vicechairmanCB2.Text = busman2
        formVotingPane.lsecretaryCB1.Text = busman3
        formVotingPane.lsecretaryCB2.Text = busman4
        formVotingPane.ltreasurerCB1.Text = pro1
        formVotingPane.ltreasurerCB2.Text = pro2
        formVotingPane.lauditorCB1.Text = pro3
        formVotingPane.lauditorCB2.Text = pro4
        formVotingPane.boardmemberCB1.Text = b1
        formVotingPane.boardmemberCB2.Text = b2
        formVotingPane.boardmemberCB3.Text = b3
        formVotingPane.boardmemberCB4.Text = b4
        formVotingPane.boardmemberCB5.Text = b5

    End Sub
End Module
