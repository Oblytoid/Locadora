using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath graphicsPath = new GraphicsPath();
        graphicsPath.AddArc(0, 0, 20, 20, 180, 90);
        graphicsPath.AddArc(Width - 21, 0, 20, 20, 270, 90);
        graphicsPath.AddArc(Width - 21, Height - 21, 20, 20, 0, 90);
        graphicsPath.AddArc(0, Height - 21, 20, 20, 90, 90);
        graphicsPath.CloseFigure();

        this.Region = new Region(graphicsPath);

        base.OnPaint(pevent);

        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pevent.Graphics.FillPath(Brushes.LightBlue, graphicsPath);
        pevent.Graphics.DrawPath(Pens.Blue, graphicsPath);
    }
}
