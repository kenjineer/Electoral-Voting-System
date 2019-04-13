<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStatistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formStatistics))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MEstatLbl = New System.Windows.Forms.Label()
        Me.IEstatLbl = New System.Windows.Forms.Label()
        Me.EEstatLbl = New System.Windows.Forms.Label()
        Me.ECEstatLbl = New System.Windows.Forms.Label()
        Me.CPEstatLbl = New System.Windows.Forms.Label()
        Me.CEstatLbl = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TOTALstatLbl = New System.Windows.Forms.Label()
        Me.totalChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TOTALperLbl = New System.Windows.Forms.Label()
        Me.TOTALundervoteLbl = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.systemTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.VOTEDstatLbl = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(241, 24)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(288, 37)
        Me.Label57.TabIndex = 31
        Me.Label57.Text = "College of Engineering"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(243, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 28)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "University of Perpetual Help System Laguna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(243, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 28)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Engineering Student Council Elections"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 28)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "• Department •"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 28)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Civil Engineering (CE)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 28)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Computer Engineering (CpE)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(586, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 28)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "• Overall Voted Statistics •"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 28)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Electronics Engineering (ECE)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 28)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Electrical Engineering (EE)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(226, 28)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Industrial Engineering (IE)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 482)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(256, 28)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Mechanical Engineering (ME)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'MEstatLbl
        '
        Me.MEstatLbl.AutoSize = True
        Me.MEstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.MEstatLbl.ForeColor = System.Drawing.Color.Black
        Me.MEstatLbl.Location = New System.Drawing.Point(524, 482)
        Me.MEstatLbl.Name = "MEstatLbl"
        Me.MEstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.MEstatLbl.TabIndex = 53
        '
        'IEstatLbl
        '
        Me.IEstatLbl.AutoSize = True
        Me.IEstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.IEstatLbl.ForeColor = System.Drawing.Color.Black
        Me.IEstatLbl.Location = New System.Drawing.Point(524, 443)
        Me.IEstatLbl.Name = "IEstatLbl"
        Me.IEstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.IEstatLbl.TabIndex = 52
        '
        'EEstatLbl
        '
        Me.EEstatLbl.AutoSize = True
        Me.EEstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.EEstatLbl.ForeColor = System.Drawing.Color.Black
        Me.EEstatLbl.Location = New System.Drawing.Point(524, 402)
        Me.EEstatLbl.Name = "EEstatLbl"
        Me.EEstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.EEstatLbl.TabIndex = 51
        '
        'ECEstatLbl
        '
        Me.ECEstatLbl.AutoSize = True
        Me.ECEstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.ECEstatLbl.ForeColor = System.Drawing.Color.Black
        Me.ECEstatLbl.Location = New System.Drawing.Point(524, 362)
        Me.ECEstatLbl.Name = "ECEstatLbl"
        Me.ECEstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.ECEstatLbl.TabIndex = 50
        '
        'CPEstatLbl
        '
        Me.CPEstatLbl.AutoSize = True
        Me.CPEstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.CPEstatLbl.ForeColor = System.Drawing.Color.Black
        Me.CPEstatLbl.Location = New System.Drawing.Point(524, 322)
        Me.CPEstatLbl.Name = "CPEstatLbl"
        Me.CPEstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.CPEstatLbl.TabIndex = 49
        '
        'CEstatLbl
        '
        Me.CEstatLbl.AutoSize = True
        Me.CEstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.CEstatLbl.ForeColor = System.Drawing.Color.Black
        Me.CEstatLbl.Location = New System.Drawing.Point(524, 282)
        Me.CEstatLbl.Name = "CEstatLbl"
        Me.CEstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.CEstatLbl.TabIndex = 48
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(524, 244)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(167, 28)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "• Voted Statistics •"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(23, 602)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 28)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Undervotes"
        '
        'TOTALstatLbl
        '
        Me.TOTALstatLbl.AutoSize = True
        Me.TOTALstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.TOTALstatLbl.ForeColor = System.Drawing.Color.Black
        Me.TOTALstatLbl.Location = New System.Drawing.Point(524, 602)
        Me.TOTALstatLbl.Name = "TOTALstatLbl"
        Me.TOTALstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.TOTALstatLbl.TabIndex = 57
        '
        'totalChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.totalChart.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.totalChart.Legends.Add(Legend1)
        Me.totalChart.Location = New System.Drawing.Point(746, 282)
        Me.totalChart.Name = "totalChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Series1.Legend = "Legend1"
        Series1.Name = "Legend Color Scheme"
        Me.totalChart.Series.Add(Series1)
        Me.totalChart.Size = New System.Drawing.Size(588, 378)
        Me.totalChart.TabIndex = 58
        Me.totalChart.Text = "Chart1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1006, 244)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 28)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "• Pie Chart •"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(917, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(206, 28)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Total Voted Percentage:"
        '
        'TOTALperLbl
        '
        Me.TOTALperLbl.AutoSize = True
        Me.TOTALperLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.TOTALperLbl.ForeColor = System.Drawing.Color.Black
        Me.TOTALperLbl.Location = New System.Drawing.Point(1129, 108)
        Me.TOTALperLbl.Name = "TOTALperLbl"
        Me.TOTALperLbl.Size = New System.Drawing.Size(0, 28)
        Me.TOTALperLbl.TabIndex = 61
        '
        'TOTALundervoteLbl
        '
        Me.TOTALundervoteLbl.AutoSize = True
        Me.TOTALundervoteLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.TOTALundervoteLbl.ForeColor = System.Drawing.Color.Black
        Me.TOTALundervoteLbl.Location = New System.Drawing.Point(1129, 136)
        Me.TOTALundervoteLbl.Name = "TOTALundervoteLbl"
        Me.TOTALundervoteLbl.Size = New System.Drawing.Size(0, 28)
        Me.TOTALundervoteLbl.TabIndex = 63
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(868, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(255, 28)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Total Undervotes Percentage:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(1068, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 28)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Date:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(1068, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 28)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "Time:"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.dateLbl.ForeColor = System.Drawing.Color.Black
        Me.dateLbl.Location = New System.Drawing.Point(1129, 24)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(0, 28)
        Me.dateLbl.TabIndex = 66
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.timeLbl.ForeColor = System.Drawing.Color.Black
        Me.timeLbl.Location = New System.Drawing.Point(1129, 52)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(0, 28)
        Me.timeLbl.TabIndex = 67
        '
        'systemTimer
        '
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(884, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(239, 28)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "Overall Student Population:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(1129, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 28)
        Me.Label21.TabIndex = 69
        '
        'VOTEDstatLbl
        '
        Me.VOTEDstatLbl.AutoSize = True
        Me.VOTEDstatLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.VOTEDstatLbl.ForeColor = System.Drawing.Color.Black
        Me.VOTEDstatLbl.Location = New System.Drawing.Point(524, 642)
        Me.VOTEDstatLbl.Name = "VOTEDstatLbl"
        Me.VOTEDstatLbl.Size = New System.Drawing.Size(0, 28)
        Me.VOTEDstatLbl.TabIndex = 71
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(23, 642)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(103, 28)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Total Voted"
        '
        'formStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1362, 764)
        Me.ControlBox = False
        Me.Controls.Add(Me.VOTEDstatLbl)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TOTALundervoteLbl)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TOTALperLbl)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.totalChart)
        Me.Controls.Add(Me.TOTALstatLbl)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MEstatLbl)
        Me.Controls.Add(Me.IEstatLbl)
        Me.Controls.Add(Me.EEstatLbl)
        Me.Controls.Add(Me.ECEstatLbl)
        Me.Controls.Add(Me.CPEstatLbl)
        Me.Controls.Add(Me.CEstatLbl)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label57)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MEstatLbl As System.Windows.Forms.Label
    Friend WithEvents IEstatLbl As System.Windows.Forms.Label
    Friend WithEvents EEstatLbl As System.Windows.Forms.Label
    Friend WithEvents ECEstatLbl As System.Windows.Forms.Label
    Friend WithEvents CPEstatLbl As System.Windows.Forms.Label
    Friend WithEvents CEstatLbl As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TOTALstatLbl As System.Windows.Forms.Label
    Friend WithEvents totalChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TOTALperLbl As System.Windows.Forms.Label
    Friend WithEvents TOTALundervoteLbl As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents systemTimer As System.Windows.Forms.Timer
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents VOTEDstatLbl As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label

End Class
