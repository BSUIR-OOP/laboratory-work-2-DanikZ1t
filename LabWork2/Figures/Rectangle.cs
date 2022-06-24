using System.Collections.Generic;
using System.Windows.Media;

namespace Figures
{
    internal class Rectangle : Shape
    {
        public Point leftAngle;
        public int width, height;
        public bool b = false;

        internal override void makePoints(List<Point> Points)
        {
            Segment l1 = new Segment(leftAngle.x, leftAngle.y, leftAngle.x + width, leftAngle.y, Color);
            Segment l2 = new Segment(leftAngle.x, leftAngle.y, leftAngle.x, leftAngle.y + height, Color);
            Segment l3 = new Segment(leftAngle.x + width, leftAngle.y, leftAngle.x + width, leftAngle.y + height, Color);
            Segment l4 = new Segment(leftAngle.x, leftAngle.y + height, leftAngle.x + width, leftAngle.y + height, Color);
            l1.makePoints(Points);
            l2.makePoints(Points);
            l3.makePoints(Points);
            l4.makePoints(Points);
        }

        public Rectangle(int x, int y, int width, int height, Brush br)
        {
            shapePoints = new List<Point>();
            leftAngle = new Point(x, y);
            this.width = width;
            this.height = height;
            Color = br;
            makePoints(shapePoints);
        }

        public Rectangle(int[] vals, Brush br)
        {
            shapePoints = new List<Point>();
            leftAngle = new Point(vals[0], vals[1]);
            this.width = vals[2];
            this.height = vals[3];
            //Color = br;
            Color = Brushes.Aqua;
            makePoints(shapePoints);
        }

        public static List<Point> Create(int[] vals, Brush br)
        {
            Rectangle rect = new Rectangle(vals, br);
            return rect.shapePoints;
        }

    }
}
