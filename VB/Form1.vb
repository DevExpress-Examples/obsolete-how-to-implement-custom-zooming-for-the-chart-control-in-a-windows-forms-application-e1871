Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomZooming
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler chartControl1.MouseWheel, AddressOf chartControl1_MouseWheel
        End Sub

        Private Sub chartControl1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim diagram As XYDiagram = TryCast(DirectCast(sender, ChartControl).Diagram, XYDiagram)
            Dim minValueX As Double = diagram.AxisX.VisualRange.MinValueInternal
            Dim maxValueX As Double = diagram.AxisX.VisualRange.MaxValueInternal
            Dim minValueY As Double = diagram.AxisY.VisualRange.MinValueInternal
            Dim maxValueY As Double = diagram.AxisY.VisualRange.MaxValueInternal
            Dim scrollMinValueX As Double = diagram.AxisX.WholeRange.MinValueInternal
            Dim scrollMaxValueX As Double = diagram.AxisX.WholeRange.MaxValueInternal
            Dim scrollMinValueY As Double = diagram.AxisY.WholeRange.MinValueInternal
            Dim scrollMaxValueY As Double = diagram.AxisY.WholeRange.MaxValueInternal
            Dim coord As DiagramCoordinates = diagram.PointToDiagram(e.Location)
            Dim x As Double = coord.NumericalArgument
            Dim y As Double = coord.NumericalValue
            If e.Delta > 0 AndAlso maxValueY - minValueY > 0.1 AndAlso maxValueX - minValueX > 0.1 Then
                diagram.AxisX.VisualRange.SetMinMaxValues(0.2 * x + 0.8 * minValueX, 0.2 * x + 0.8 * maxValueX)
                diagram.AxisY.VisualRange.SetMinMaxValues(0.2 * y + 0.8 * minValueY, 0.2 * y + 0.8 * maxValueY)
            End If
            If e.Delta < 0 AndAlso (minValueX > scrollMinValueX OrElse maxValueX < scrollMinValueX OrElse minValueY > scrollMinValueY OrElse maxValueY < scrollMaxValueY) Then
                Dim minValueInternalX As Double = If(1.2 * minValueX - 0.2 * x >= scrollMinValueX, 1.2 * minValueX - 0.2 * x, scrollMinValueX)
                Dim maxValueInternalX As Double = If(1.2 * maxValueX - 0.2 * x <= scrollMaxValueX, 1.2 * maxValueX - 0.2 * x, scrollMaxValueX)
                Dim minValueInternalY As Double = If(1.2 * minValueY - 0.2 * y >= scrollMinValueY, 1.2 * minValueY - 0.2 * y, scrollMinValueY)
                Dim maxValueInternalY As Double = If(1.2 * maxValueY - 0.2 * y <= scrollMaxValueY, 1.2 * maxValueY - 0.2 * y, scrollMaxValueY)
                diagram.AxisX.VisualRange.SetMinMaxValues(minValueInternalX, maxValueInternalX)
                diagram.AxisY.VisualRange.SetMinMaxValues(minValueInternalY, maxValueInternalY)
            End If
        End Sub
    End Class
End Namespace