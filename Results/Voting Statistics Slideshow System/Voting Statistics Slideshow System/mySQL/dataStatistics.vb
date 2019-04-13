Imports MySql.Data.MySqlClient

Module dataStatistics

    Public Sub retrieveforVotes()
        Try
            dbConnection()
            sql = "SELECT Votes, Name FROM candidates;"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                formStatistics.pres1V.Text = dt.Rows(0).Item(0)
                formStatistics.pres1lbl.Text = dt.Rows(0).Item(1)
                formStatistics.pres2V.Text = dt.Rows(1).Item(0)
                formStatistics.pres2lbl.Text = dt.Rows(1).Item(1)
                formStatistics.VPI1V.Text = dt.Rows(2).Item(0)
                formStatistics.vpi1lbl.Text = dt.Rows(2).Item(1)
                formStatistics.VPI2V.Text = dt.Rows(3).Item(0)
                formStatistics.vpi2lbl.Text = dt.Rows(3).Item(1)
                formStatistics.VPE1V.Text = dt.Rows(4).Item(0)
                formStatistics.vpe1lbl.Text = dt.Rows(4).Item(1)
                formStatistics.VPE2V.Text = dt.Rows(5).Item(0)
                formStatistics.vpe2lbl.Text = dt.Rows(5).Item(1)
                formStatistics.Sec1V.Text = dt.Rows(6).Item(0)
                formStatistics.sec1lbl.Text = dt.Rows(6).Item(1)
                formStatistics.Sec2V.Text = dt.Rows(7).Item(0)
                formStatistics.sec2lbl.Text = dt.Rows(7).Item(1)
                formStatistics.Aud1V.Text = dt.Rows(8).Item(0)
                formStatistics.aud1lbl.Text = dt.Rows(8).Item(1)
                formStatistics.Aud2V.Text = dt.Rows(9).Item(0)
                formStatistics.aud2lbl.Text = dt.Rows(9).Item(1)
                formStatistics.Tres1V.Text = dt.Rows(10).Item(0)
                formStatistics.tres1lbl.Text = dt.Rows(10).Item(1)
                formStatistics.Tres2V.Text = dt.Rows(11).Item(0)
                formStatistics.tres2lbl.Text = dt.Rows(11).Item(1)
                formStatistics.ASec1V.Text = dt.Rows(12).Item(0)
                formStatistics.asec1lbl.Text = dt.Rows(12).Item(1)
                formStatistics.ASec2V.Text = dt.Rows(13).Item(0)
                formStatistics.asec2lbl.Text = dt.Rows(13).Item(1)
                formStatistics.BM1V.Text = dt.Rows(14).Item(0)
                formStatistics.bm1lbl.Text = dt.Rows(14).Item(1)
                formStatistics.BM2V.Text = dt.Rows(15).Item(0)
                formStatistics.bm2lbl.Text = dt.Rows(15).Item(1)
                formStatistics.BM3V.Text = dt.Rows(16).Item(0)
                formStatistics.bm3lbl.Text = dt.Rows(16).Item(1)
                formStatistics.BM4V.Text = dt.Rows(17).Item(0)
                formStatistics.bm4lbl.Text = dt.Rows(17).Item(1)
                formStatistics.PRO1V.Text = dt.Rows(18).Item(0)
                formStatistics.pro1lbl.Text = dt.Rows(18).Item(1)
                formStatistics.PRO2V.Text = dt.Rows(19).Item(0)
                formStatistics.pro2lbl.Text = dt.Rows(19).Item(1)
                formStatistics.PRO3V.Text = dt.Rows(20).Item(0)
                formStatistics.pro3lbl.Text = dt.Rows(20).Item(1)
                formStatistics.PRO4V.Text = dt.Rows(21).Item(0)
                formStatistics.pro4lbl.Text = dt.Rows(21).Item(1)
                formStatistics.B1V.Text = dt.Rows(22).Item(0)
                formStatistics.b1lbl.Text = dt.Rows(22).Item(1)
                formStatistics.B2V.Text = dt.Rows(23).Item(0)
                formStatistics.b2lbl.Text = dt.Rows(23).Item(1)
                formStatistics.B3V.Text = dt.Rows(24).Item(0)
                formStatistics.b3lbl.Text = dt.Rows(24).Item(1)
                formStatistics.B4V.Text = dt.Rows(25).Item(0)
                formStatistics.b4lbl.Text = dt.Rows(25).Item(1)
                formStatistics.B5V.Text = dt.Rows(26).Item(0)
                formStatistics.b5lbl.Text = dt.Rows(26).Item(1)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Public Sub loadStatistics()

        callCounts()
        retrieveforVotes()

        totalundervote = Integer.Parse(counttotals) - Integer.Parse(countvoted)
        formStatistics.TOTALstatLbl.Text = totalundervote.ToString + " out of " + counttotals.ToString
        formStatistics.VOTEDstatLbl.Text = (Integer.Parse(countvoted)).ToString + " out of " + counttotals.ToString
    End Sub
End Module
