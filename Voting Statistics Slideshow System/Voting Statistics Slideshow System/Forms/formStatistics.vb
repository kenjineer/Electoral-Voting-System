Public Class formStatistics

    Private Sub formStatistics_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F5 Then
            loadStatistics()
        End If

    End Sub

    Private Sub formStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        systemTimer.Start()
        dateLbl.Text = Date.Today.ToString("MMMM dd, yyyy")
        callCounts()
        retrieveforCE()
        retrieveforCPE()
        retrieveforECE()
        retrieveforEE()
        retrieveforIE()
        retrieveforME()

        Me.totalChart.Series.Clear()
        Me.totalChart.Series.Add("Legend Color Scheme")
        Me.totalChart.Series("Legend Color Scheme").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Me.totalChart.Series("Legend Color Scheme").Font = New Font("Segoe UI Light", 12)
        Me.totalChart.Series("Legend Color Scheme").CustomProperties = "PieLabelStyle=Disabled"
        Me.totalChart.Series("Legend Color Scheme").Points.AddXY("CE", cecount)
        Me.totalChart.Series("Legend Color Scheme").Points(0).Color = Color.Green
        Me.totalChart.Series("Legend Color Scheme").Points.AddXY("CPE", cpecount)
        Me.totalChart.Series("Legend Color Scheme").Points(1).Color = Color.Maroon
        Me.totalChart.Series("Legend Color Scheme").Points.AddXY("ECE", ececount)
        Me.totalChart.Series("Legend Color Scheme").Points(2).Color = Color.Red
        Me.totalChart.Series("Legend Color Scheme").Points.AddXY("EE", eecount)
        Me.totalChart.Series("Legend Color Scheme").Points(3).Color = Color.Orange
        Me.totalChart.Series("Legend Color Scheme").Points.AddXY("IE", iecount)
        Me.totalChart.Series("Legend Color Scheme").Points(4).Color = Color.Yellow
        Me.totalChart.Series("Legend Color Scheme").Points.AddXY("ME", mecount)
        Me.totalChart.Series("Legend Color Scheme").Points(5).Color = Color.Black
        Me.totalChart.Series("Legend Color Scheme").Points.AddXY("UNDERVOTES", Integer.Parse(counttotals) - (Integer.Parse(cecount) + Integer.Parse(cpecount) + Integer.Parse(ececount) + Integer.Parse(eecount) + Integer.Parse(iecount) + Integer.Parse(mecount)))
        Me.totalChart.Series("Legend Color Scheme").Points(6).Color = Color.Pink
        totalundervote = Integer.Parse(counttotals) - (Integer.Parse(cecount) + Integer.Parse(cpecount) + Integer.Parse(ececount) + Integer.Parse(eecount) + Integer.Parse(iecount) + Integer.Parse(mecount))
        TOTALstatLbl.Text = totalundervote.ToString + " out of " + counttotals.ToString
        VOTEDstatLbl.Text = (Integer.Parse(cecount) + Integer.Parse(cpecount) + Integer.Parse(ececount) + Integer.Parse(eecount) + Integer.Parse(iecount) + Integer.Parse(mecount)).ToString + " out of " + counttotals.ToString

        total = ((Double.Parse(cecount) + Double.Parse(cpecount) + Double.Parse(ececount) + Double.Parse(eecount) + Double.Parse(iecount) + Double.Parse(mecount)) / Double.Parse(counttotals)) * 100
        TOTALperLbl.Text = total.ToString("#0.00") + " %"

        untotal = (Double.Parse(totalundervote) / Double.Parse(counttotals)) * 100
        TOTALundervoteLbl.Text = untotal.ToString("#0.00") + " %"

        Label21.Text = counttotals.ToString

        KeyPreview = True
    End Sub


    Private Sub systemTimer_Tick(sender As Object, e As EventArgs) Handles systemTimer.Tick
        timeLbl.Text = TimeOfDay.ToString("hh:mm:ss tt")
        loadStatistics()
    End Sub
End Class