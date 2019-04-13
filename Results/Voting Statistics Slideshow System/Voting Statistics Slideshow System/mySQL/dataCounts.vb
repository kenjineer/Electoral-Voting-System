Imports MySql.Data.MySqlClient

Module dataCounts

    Public Sub callCounts()
        TOTALVotedcount()
        TOTALcount()
        
    End Sub

    Public Sub TOTALVotedcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Voted = '1';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                countvoted = Integer.Parse(dr.GetString("COUNT(*)"))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub TOTALcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                counttotals = Integer.Parse(dr.GetString("COUNT(*)"))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

   
End Module

