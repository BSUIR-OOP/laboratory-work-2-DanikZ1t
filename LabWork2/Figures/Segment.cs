using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Figures
{
    internal class Segment : Shape
    {
        public Point v1, v2;

        internal override void makePoints(List<Point> Points)
        {
            int maxI;
            double x = v1.x, y = v1.y, ix, iy; ;

            if (Math.Abs(v2.y - v1.y) > Math.Abs(v2.x - v1.x))
            {
                maxI = Math.Abs((int)(v2.y - v1.y));
                if (v2.y > v1.y) iy = step;
                else iy = -step;
                ix = (v2.x - v1.x) / Math.Abs(v2.y - v1.y);
            }
            else
            {
                maxI = Math.Abs((int)(v2.x - v1.x));
                if (v2.x > v1.x) ix = step;
                else ix = -step;
                iy = (v2.y - v1.y) / Math.Abs(v2.x - v1.x);
            }

            Points.Add(new Point(x, y, Color));
            for (int i = 1; i < maxI; i++)
            {
                x += ix;
                y += iy;
                Points.Add(new Point(x, y, Color));
            }
        }

        public Segment(double x1, double y1, double x2, double y2, Brush br)
        {
            shapePoints = new List<Point>();
            v1 = new Point(x1, y1);
            v2 = new Point(x2, y2);
            Color = br;
            makePoints(shapePoints);
        }

        public Segment(int[] vals, Brush br)
        {
            shapePoints = new List<Point>();
            v1 = new Point(vals[0], vals[1]);
            v2 = new Point(vals[2], vals[3]);
            //Color = br;
            Color = Brushes.Orange;
            makePoints(shapePoints);
        }

        public static List<Point> Create(int[] vals, Brush br)
        {
            Segment seg = new Segment(vals, br);
            return seg.shapePoints;
        }

    }
}
