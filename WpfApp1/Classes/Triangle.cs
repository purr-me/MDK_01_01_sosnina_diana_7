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
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }


        public Triangle(double x, double y, double x1, double y1, double x2, double y2, double x3, double y3) : base(x, y)
        {
            X1 = x1; Y1 = y1;
            X2 = x2; Y2 = y2;
            X3 = x3; Y3 = y3;
        }


        public override void Draw(Canvas canvas)
        {
            Polygon triangle = new Polygon
            {
                Stroke = Brushes.LightPink,
                StrokeThickness = 6,
                Fill = Brushes.HotPink
            };

            triangle.Points.Add(new Point(X1, Y1));
            triangle.Points.Add(new Point(X2, Y2));
            triangle.Points.Add(new Point(X3, Y3));

            canvas.Children.Add(triangle);
        }
    }
}
