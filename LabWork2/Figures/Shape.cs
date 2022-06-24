using System.Collections.Generic;
using System.Windows.Media;

namespace Figures
{

    public abstract class Shape
    {
        public Brush Color;
        public const double step = 1;
        internal List<Point> shapePoints;
        internal abstract void makePoints(List<Point> shapePoints);
    }
}
