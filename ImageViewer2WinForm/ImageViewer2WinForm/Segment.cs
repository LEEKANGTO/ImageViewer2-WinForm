using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageViewer2WinForm
{
    public class Segment
    {
        public Pen pen;
        public Point startPoint;
        public Point endPoint;
        public Segment(Pen pen, Point startPoint, Point endPoint)
        {
            this.pen        = pen;
            this.startPoint = startPoint;
            this.endPoint   = endPoint;        
        }

        public void DrawLine(Graphics graphics)
        {
            graphics.DrawLine(pen, startPoint, endPoint);
        }
    }
}
