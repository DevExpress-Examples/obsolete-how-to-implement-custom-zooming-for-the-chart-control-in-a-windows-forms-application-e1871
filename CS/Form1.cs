using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CustomZooming {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            chartControl1.MouseWheel += new MouseEventHandler(chartControl1_MouseWheel);
        }

        void chartControl1_MouseWheel(object sender, MouseEventArgs e) {
            ((ChartControl)sender).BeginInit();
            XYDiagram diagram = ((ChartControl)sender).Diagram as XYDiagram;
            double minValueX = diagram.AxisX.Range.MinValueInternal;
            double maxValueX = diagram.AxisX.Range.MaxValueInternal;
            double minValueY = diagram.AxisY.Range.MinValueInternal;
            double maxValueY = diagram.AxisY.Range.MaxValueInternal;
            double scrollMinValueX = diagram.AxisX.Range.ScrollingRange.MinValueInternal;
            double scrollMaxValueX = diagram.AxisX.Range.ScrollingRange.MaxValueInternal;
            double scrollMinValueY = diagram.AxisY.Range.ScrollingRange.MinValueInternal;
            double scrollMaxValueY = diagram.AxisY.Range.ScrollingRange.MaxValueInternal;
            DiagramCoordinates coord = diagram.PointToDiagram(e.Location);
            double x = coord.NumericalArgument;
            double y = coord.NumericalValue;
            if (e.Delta > 0 && maxValueY - minValueY > 0.1 && maxValueX - minValueX > 0.1) {
                diagram.AxisX.Range.SetMinMaxValues(0.2 * x + 0.8 * minValueX, 0.2 * x + 0.8 * maxValueX);
                diagram.AxisY.Range.SetMinMaxValues(0.2 * y + 0.8 * minValueY, 0.2 * y + 0.8 * maxValueY);
            }
            if (e.Delta < 0 && (minValueX > scrollMinValueX || maxValueX < scrollMinValueX || minValueY > scrollMinValueY || maxValueY < scrollMaxValueY)) {
                double minValueInternalX = (1.2 * minValueX - 0.2 * x >= scrollMinValueX) ? 1.2 * minValueX - 0.2 * x : scrollMinValueX;
                double maxValueInternalX = (1.2 * maxValueX - 0.2 * x <= scrollMaxValueX) ? 1.2 * maxValueX - 0.2 * x : scrollMaxValueX;
                double minValueInternalY = (1.2 * minValueY - 0.2 * y >= scrollMinValueY) ? 1.2 * minValueY - 0.2 * y : scrollMinValueY;
                double maxValueInternalY = (1.2 * maxValueY - 0.2 * y <= scrollMaxValueY) ? 1.2 * maxValueY - 0.2 * y : scrollMaxValueY;
                diagram.AxisX.Range.SetMinMaxValues(minValueInternalX, maxValueInternalX);
                diagram.AxisY.Range.SetMinMaxValues(minValueInternalY, maxValueInternalY);
            }
            ((ChartControl)sender).EndInit();
        }
    }
}