Imports MySql.Data.MySqlClient

Module dataStatistics

    Public Sub retrieveforCE()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'CE' AND Voted = True;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cecount = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
        formStatistics.CEstatLbl.Text = cecount.ToString + " out of " + Integer.Parse(countce).ToString
    End Sub

    Public Sub retrieveforCPE()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'CPE' AND Voted = True;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cpecount = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
        formStatistics.CPEstatLbl.Text = cpecount.ToString + " out of " + Integer.Parse(countcpe).ToString
    End Sub

    Public Sub retrieveforECE()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'ECE' AND Voted = True;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                ececount = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
        formStatistics.ECEstatLbl.Text = ececount.ToString + " out of " + Integer.Parse(countece).ToString
    End Sub

    Public Sub retrieveforEE()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'EE' AND Voted = True;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                eecount = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
        formStatistics.EEstatLbl.Text = eecount.ToString + " out of " + Integer.Parse(countee).ToString
    End Sub

    Public Sub retrieveforIE()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'IE' AND Voted = True;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                iecount = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
        formStatistics.IEstatLbl.Text = iecount.ToString + " out of " + Integer.Parse(countie).ToString
    End Sub

    Public Sub retrieveforME()
        Try
            dbConnection()
            sql = "SELECT COUNT(*) FROM student_data WHERE Course = 'ME' AND Voted = True;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                mecount = dr.GetString("COUNT(*)")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
        formStatistics.MEstatLbl.Text = mecount.ToString + " out of " + Integer.Parse(countme).ToString
    End Sub


    Public Sub loadStatistics()

        callCounts()
        retrieveforCE()
        retrieveforCPE()
        retrieveforECE()
        retrieveforEE()
        retrieveforIE()
        retrieveforME()

        formStatistics.totalChart.Series.Clear()
        formStatistics.totalChart.Series.Add("Legend Color Scheme")
        formStatistics.totalChart.Series("Legend Color Scheme").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        formStatistics.totalChart.Series("Legend Color Scheme").Font = New Font("Segoe UI Light", 12)
        formStatistics.totalChart.Series("Legend Color Scheme").CustomProperties = "PieLabelStyle=Disabled"
        formStatistics.totalChart.Series("Legend Color Scheme").Points.AddXY("CE", cecount)
        formStatistics.totalChart.Series("Legend Color Scheme").Points(0).Color = Color.Green
        formStatistics.totalChart.Series("Legend Color Scheme").Points.AddXY("CPE", cpecount)
        formStatistics.totalChart.Series("Legend Color Scheme").Points(1).Color = Color.Maroon
        formStatistics.totalChart.Series("Legend Color Scheme").Points.AddXY("ECE", ececount)
        formStatistics.totalChart.Series("Legend Color Scheme").Points(2).Color = Color.Red
        formStatistics.totalChart.Series("Legend Color Scheme").Points.AddXY("EE", eecount)
        formStatistics.totalChart.Series("Legend Color Scheme").Points(3).Color = Color.Orange
        formStatistics.totalChart.Series("Legend Color Scheme").Points.AddXY("IE", iecount)
        formStatistics.totalChart.Series("Legend Color Scheme").Points(4).Color = Color.Yellow
        formStatistics.totalChart.Series("Legend Color Scheme").Points.AddXY("ME", mecount)
        formStatistics.totalChart.Series("Legend Color Scheme").Points(5).Color = Color.Black
        formStatistics.totalChart.Series("Legend Color Scheme").Points.AddXY("UNDERVOTES", Integer.Parse(counttotals) - (Integer.Parse(cecount) + Integer.Parse(cpecount) + Integer.Parse(ececount) + Integer.Parse(eecount) + Integer.Parse(iecount) + Integer.Parse(mecount)))
        formStatistics.totalChart.Series("Legend Color Scheme").Points(6).Color = Color.Pink
        totalundervote = Integer.Parse(counttotals) - (Integer.Parse(cecount) + Integer.Parse(cpecount) + Integer.Parse(ececount) + Integer.Parse(eecount) + Integer.Parse(iecount) + Integer.Parse(mecount))
        formStatistics.TOTALstatLbl.Text = totalundervote.ToString + " out of " + counttotals.ToString
        formStatistics.VOTEDstatLbl.Text = (Integer.Parse(cecount) + Integer.Parse(cpecount) + Integer.Parse(ececount) + Integer.Parse(eecount) + Integer.Parse(iecount) + Integer.Parse(mecount)).ToString + " out of " + counttotals.ToString

        total = ((Double.Parse(cecount) + Double.Parse(cpecount) + Double.Parse(ececount) + Double.Parse(eecount) + Double.Parse(iecount) + Double.Parse(mecount)) / Double.Parse(counttotals)) * 100
        formStatistics.TOTALperLbl.Text = total.ToString("#0.00") + " %"

        untotal = (Double.Parse(totalundervote) / Double.Parse(counttotals)) * 100
        formStatistics.TOTALundervoteLbl.Text = untotal.ToString("#0.00") + " %"

        formStatistics.Label21.Text = counttotals.ToString
    End Sub
End Module
