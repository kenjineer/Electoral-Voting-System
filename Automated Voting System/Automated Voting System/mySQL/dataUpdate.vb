Imports MySql.Data.MySqlClient

Module dataUpdate

    Public Sub updatestudentvoted()

        Try
            dbConnection()
            sql = "UPDATE student_data SET Voted = True WHERE ID_No = @IDNo;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@IDNo", idno)
                result = cmd.ExecuteNonQuery()
            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            idno = ""
            course = ""
            fullname = ""
            lastname = ""
        End Try

    End Sub

    Public Sub updateNationalVotes()

        If pres = "" Then
            pres = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", pres)
                    .Parameters.AddWithValue("@Position", "PRESIDENT")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If vpintern = "" Then
            vpintern = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", vpintern)
                    .Parameters.AddWithValue("@Position", "VP-INTERNAL")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If vpextern = "" Then
            vpextern = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", vpextern)
                    .Parameters.AddWithValue("@Position", "VP-EXTERNAL")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If sec = "" Then
            sec = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", sec)
                    .Parameters.AddWithValue("@Position", "SECRETARY")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If aud = "" Then
            aud = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", aud)
                    .Parameters.AddWithValue("@Position", "AUDITOR")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If treas = "" Then
            treas = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", treas)
                    .Parameters.AddWithValue("@Position", "TREASURER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Public Sub updateLocalVotes()

        If asec = "" Then
            asec = ""
        Else

            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", asec)
                    .Parameters.AddWithValue("@Position", "ASECRETARY")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If busman1 = "" Then
            busman1 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", busman1)
                    .Parameters.AddWithValue("@Position", "BUSMANAGER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If busman2 = "" Then
            busman2 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", busman2)
                    .Parameters.AddWithValue("@Position", "BUSMANAGER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If pro1 = "" Then
            pro1 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", pro1)
                    .Parameters.AddWithValue("@Position", "PRO")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If pro2 = "" Then
            pro2 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", pro2)
                    .Parameters.AddWithValue("@Position", "PRO")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If boardmem1 = "" Then
            boardmem1 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", boardmem1)
                    .Parameters.AddWithValue("@Position", "BOARD MEMBER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If boardmem2 = "" Then
            boardmem2 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", boardmem2)
                    .Parameters.AddWithValue("@Position", "BOARD MEMBER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If boardmem3 = "" Then
            boardmem3 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", boardmem3)
                    .Parameters.AddWithValue("@Position", "BOARD MEMBER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If boardmem4 = "" Then
            boardmem4 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", boardmem4)
                    .Parameters.AddWithValue("@Position", "BOARD MEMBER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If

        If boardmem5 = "" Then
            boardmem5 = ""
        Else
            Try
                dbConnection()
                sql = "UPDATE candidates SET Votes = Votes + 1 WHERE Name = @Name AND Position = @Position;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", boardmem5)
                    .Parameters.AddWithValue("@Position", "BOARD MEMBER")
                    result = .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub


End Module
