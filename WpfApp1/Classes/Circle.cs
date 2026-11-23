using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1.Classes
{
    public class Circle : GeometricFigure
    {
        public double Diameter { get; set; }

        public Circle(double x, double y, double diameter) : base(x, y)
        {
            Diameter = diameter;
        }

        public override void Draw(Canvas canvas)
        {
            double radius = Diameter / 2;

            Ellipse circle = new Ellipse
            {
                Width = Diameter,
                Height = Diameter,
                StrokeThickness = 6,
                Stroke = Brushes.HotPink,
                Fill = Brushes.LightPink
            };

            Canvas.SetLeft(circle, X - radius);
            Canvas.SetTop(circle, Y - radius);

            canvas.Children.Add(circle);

        }
    }
}
