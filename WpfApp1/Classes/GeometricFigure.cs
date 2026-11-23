using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace WpfApp1.Classes
{
    public abstract class GeometricFigure
    {
        public double X { get; set; }
        public double Y { get; set; }

        public GeometricFigure(double x, double y) {
            X = x;
            Y = y;
        }

        public abstract void Draw(Canvas canvas);

    }
}
