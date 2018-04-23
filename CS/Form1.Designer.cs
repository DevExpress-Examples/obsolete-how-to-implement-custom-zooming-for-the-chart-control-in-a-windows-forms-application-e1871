namespace CustomZooming {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(8D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(6D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint(5D, new object[] {
            ((object)(5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint(6D, new object[] {
            ((object)(6D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint(7D, new object[] {
            ((object)(4D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint(8D, new object[] {
            ((object)(7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint(9D, new object[] {
            ((object)(5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint(10D, new object[] {
            ((object)(6D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint(100D, new object[] {
            ((object)(54D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisYScrolling = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10,
            seriesPoint11});
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(945, 386);
            this.chartControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 386);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

