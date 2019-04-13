Imports MySql.Data.MySqlClient

Module dataCounts

    Public Sub callCounts()
        TOTALcount()
        CEtotalcount()
        CPEtotalcount()
        ECEtotalcount()
        EEtotalcount()
        IEtotalcount()
        MEtotalcount()
        
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

    Public Sub CEtotalcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'CE';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                countce = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub CPEtotalcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'CPE';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                countcpe = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub ECEtotalcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'ECE';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                countece = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub EEtotalcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'EE';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                countee = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub IEtotalcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'IE';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                countie = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub


    Public Sub MEtotalcount()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'ME';"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                countme = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub
End Module

