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
        retrieveforVotes()

        totalundervote = Integer.Parse(counttotals) - Integer.Parse(countvoted)
        TOTALstatLbl.Text = totalundervote.ToString + " out of " + counttotals.ToString
        VOTEDstatLbl.Text = (Integer.Parse(countvoted)).ToString + " out of " + counttotals.ToString

        KeyPreview = True
    End Sub


    Private Sub systemTimer_Tick(sender As Object, e As EventArgs) Handles systemTimer.Tick
        timeLbl.Text = TimeOfDay.ToString("hh:mm:ss tt")
        loadStatistics()
    End Sub
End Class