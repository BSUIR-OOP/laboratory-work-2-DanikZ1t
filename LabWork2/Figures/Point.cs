using System.Collections.Generic;
using System.Windows.Media;

namespace Figures
{
    internal class Point : Shape
    {
        public double x, y;
        public Point(Point point)
        {
            shapePoints = new List<Point>();
            this.x = point.x;
            this.y = point.y;
        }
        public Point(double x, double y, Brush br)
        {
            this.x = x;
            this.y = y;
            Color = br;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            Color = Brushes.Red;
        }

        internal override void makePoints(List<Point> shapePoints)
        {
            shapePoints.Add(new Point(x, y, Color));
        }

        public Point(int[] vals, Brush br)
        {
            shapePoints = new List<Point>();
            this.x = vals[0];
            this.y = vals[1];
            //Color = br;
            Color = Brushes.GreenYellow;
            makePoints(shapePoints);
        }

        public static List<Point> Create(int[] vals, Brush br)
        {
            Point p = new Point(vals, br);
            return p.shapePoints;
        }

    }
}
