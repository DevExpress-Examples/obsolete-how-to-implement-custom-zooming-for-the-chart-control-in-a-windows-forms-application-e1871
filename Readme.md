<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to implement custom zooming for the chart control in a Windows Forms application


<p><strong>NOTE</strong>. Starting with v17.1, zooming a chart via the mouse wheel scales the chart to the current mouse position and the custom zooming method shown in this example is no longer necessary. <br><br>This example demonstrates how to implement custom zooming for the chart control. To accomplish this task, you can handle the MouseWheel event. Within this event handler, you can call the XYDiagram.PointToDiagram method to obtain information relative to the coordinates of the mouse pointer affiliation with a series or series point in a diagram. After that you can manually assign both minimum and maximum internal values of an axis range as your needs dictate.</p>

<br/>


