using System.Windows.Media;

namespace Figures
{
    internal class Circle : Ellipse
    {
        public int r;

        public Circle(int x, int y, int width, int height, Brush br) : base(x, y, width, height, br)
        {
            r = width / 2;
            makePoints(shapePoints);
        }

        public Circle(int x, int y, int r, Brush br) : base(x - r, y - r, r * 2, r * 2, br)
        {
            this.a = new Point(x - r, y - r);
            this.r = r;
            Color = br;
            makePoints(shapePoints);
        }

    }
}
