Namespace CustomZooming
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1, New Object() { (DirectCast(7, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(2, New Object() { (DirectCast(8, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(3, New Object() { (DirectCast(6, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(4, New Object() { (DirectCast(7, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(5, New Object() { (DirectCast(5, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(6, New Object() { (DirectCast(6, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(7, New Object() { (DirectCast(4, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(8, New Object() { (DirectCast(7, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(9, New Object() { (DirectCast(5, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(10, New Object() { (DirectCast(6, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(100, New Object() { (DirectCast(54, Object))})
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = True
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisYScrolling = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
            series1.View = lineSeriesView1
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(945, 386)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(945, 386)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

