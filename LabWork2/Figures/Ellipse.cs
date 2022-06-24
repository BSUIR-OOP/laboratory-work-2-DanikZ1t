using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Figures
{
    internal class Ellipse : Shape
    {
        public Point a;
        public int width;
        public int height;

        internal override void makePoints(List<Point> shapePoints)
        {
            double step = 0.1;
            if (width == 0 || height == 0)
            {
                shapePoints.Add(new Point(a.x, a.y, Color));
            }
            else
            {
                double aa = width / 2, b = height / 2, y0 = a.y, y = y0 - b, x0 = a.x, k = 0;
                for (double x = x0 - aa; x < x0 + aa + 2 * step; x += step)
                {
                    k = b * Math.Sqrt(Math.Abs(1 - (x - x0) * (x - x0) / (aa * aa)));
                    Color = Brushes.Gray;
                    shapePoints.Add(new Point(x, y0 + k, Color));
                    shapePoints.Add(new Point(x, y0 - k, Color));
                }
            }
        }


        public Ellipse(int x, int y, int width, int height, Brush br)
        {
            shapePoints = new List<Point>();
            a = new Point(x, y);
            this.width = width;
            this.height = height;
            Color = br;
            makePoints(shapePoints);
        }

        public Ellipse(int[] vals, Brush br)
        {
            shapePoints = new List<Point>();
            a = new Point(vals[0], vals[1]);
            this.width = vals[2];
            this.height = vals[3];
            //Color = br;
            Color = Brushes.Gray;
            makePoints(shapePoints);
        }

        public static List<Point> Create(int[] vals, Brush br)
        {
            Ellipse ell = new Ellipse(vals, br);
            return ell.shapePoints;
        }

    }
}
