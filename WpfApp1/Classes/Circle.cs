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
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw(Canvas canvas)
        {
            Ellipse circle = new Ellipse
            {
                Width = Radius * 3,
                Height = Radius * 3,
                StrokeThickness = 6,
                Stroke = Brushes.HotPink,
                Fill = Brushes.LightPink
            };

            Canvas.SetLeft(circle, X - Radius);
            Canvas.SetTop(circle, Y - Radius);

            canvas.Children.Add(circle);
        }

    }
}
