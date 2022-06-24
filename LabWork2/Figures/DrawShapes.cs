using System.Collections.Generic;
using System.Windows.Controls;

namespace Figures
{
    public class DrawShapes
    {
        public List<Shape> list;
        internal static void DrawPoints(List<Point> points, Canvas g)
        {
            const int pSize = 7;
            foreach (var point in points)
            {
                System.Windows.Shapes.Ellipse pEllipse = new System.Windows.Shapes.Ellipse();
                pEllipse.Width = pSize;
                pEllipse.Height = pSize;
                pEllipse.Margin = new System.Windows.Thickness(point.x, point.y, 0, 0);
                pEllipse.Stroke = point.Color;
                pEllipse.StrokeThickness = pSize;
                g.Children.Add(pEllipse);
            }
        }

        public void DrawList(Canvas g)
        {
            foreach (Shape shape in list)
            {
                DrawPoints(shape.shapePoints, g);
            }
        }

        public DrawShapes()
        { list = new List<Shape>(); }

        public void Add(Shape shape)
        {
            list.Add(shape);
        }

    }
}
