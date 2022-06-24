using System.Collections.Generic;
using System.Windows.Media;

namespace Figures
{
    internal class Triangle : Shape
    {
        public Point a, b, c;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, Brush br)
        {
            shapePoints = new List<Point>();
            a = new Point(x1, y1);
            b = new Point(x2, y2);
            c = new Point(x3, y3);
            Color = br;
            makePoints(shapePoints);
        }

        internal override void makePoints(List<Point> Points)
        {
            Segment l1 = new Segment(a.x, a.y, b.x, b.y, Color);
            Segment l2 = new Segment(c.x, c.y, b.x, b.y, Color);
            Segment l3 = new Segment(a.x, a.y, c.x, c.y, Color);
            l1.makePoints(Points);
            l2.makePoints(Points);
            l3.makePoints(Points);
        }

        public Triangle(int[] vals, Brush br)
        {
            shapePoints = new List<Point>();
            a = new Point(vals[0], vals[1]);
            b = new Point(vals[2], vals[3]);
            c = new Point(vals[4], vals[5]);
            Color = Brushes.Violet;
            makePoints(shapePoints);
        }

        public static List<Point> Create(int[] vals, Brush br)
        {
            Triangle tri = new Triangle(vals, br);
            return tri.shapePoints;
        }

    }
}
