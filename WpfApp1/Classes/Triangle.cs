using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace WpfApp1.Classes
{
    public class Triangle : GeometricFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double x, double y, double a, double b, double c) : base(x, y)
        {
            A = a;
            B = b;
            C = c;
        }


        public override void Draw(Canvas canvas)
        {
            Polygon triangle = new Polygon
            {
                Stroke = Brushes.LightPink,
                StrokeThickness = 6,
                Fill = Brushes.HotPink
            };

            triangle.Points.Add(new Point(X, Y - A / 2));
            triangle.Points.Add(new Point(X - A / 2, Y + A / 2));
            triangle.Points.Add(new Point(X + A / 2, Y + A / 2));

            canvas.Children.Add(triangle);
        }
    }
}
