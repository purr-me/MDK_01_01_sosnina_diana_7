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
            if(A+B <= C || A+C <= B || B+C <= A)
            {
                MessageBox.Show("Такого не может быть!");
                return;
            }
            //две вершины а=0,0 б=с,0
            double x1 = 0, y1 = 0;
            double x2 = C, y2 = 0;
            //с ищем по теореме косинусов
            double x3 = (A * A + C * C - B * B) / (2 * C);
            double y3 = -Math.Sqrt(A * A - x3 * x3);
            //центр
            double centerX = (x1 + x2 + x3) / 3;
            double centerY = (y1 + y2 + y3) / 3;
            //для нужного места
            double shiftX = X - centerX;
            double shiftY = Y - centerY;

            Polygon triangle = new Polygon
            {
                Stroke = Brushes.LightPink,
                StrokeThickness = 6,
                Fill = Brushes.HotPink
            };


            triangle.Points.Add(new Point(x1 + shiftX, y1 + shiftY));
            triangle.Points.Add(new Point(x2 + shiftX, y2 + shiftY));
            triangle.Points.Add(new Point(x3 + shiftX, y3 + shiftY));

            canvas.Children.Add(triangle);
        }
    }
}
