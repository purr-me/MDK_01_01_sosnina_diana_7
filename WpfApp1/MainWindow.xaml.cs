using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void DrawTriangle_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txTriangleX.Text, out double x) &&
                double.TryParse(txTriangleY.Text, out double y) &&
                double.TryParse(txTriangle1.Text, out double a) &&
                double.TryParse(txTriangle2.Text, out double b) &&
                double.TryParse(txTriangle3.Text, out double c))
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    MessageBox.Show("Стороны треугольника должны быть больше нуля");
                    return;
                }

                Triangle triangle = new Triangle(x, y, a, b, c);
                triangle.Draw(CoolCanvas);
            }
            else
            {
                MessageBox.Show("Введите корректные числа");
            }
        }

        private void DrawCircle_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txCircleX.Text, out double x) &&
                double.TryParse(txCircleY.Text, out double y) &&
                double.TryParse(txCircleD.Text, out double d))
            {
                if (d <= 0)
                {
                    MessageBox.Show("Диаметр должен быть больше нуля");
                    return;
                }

                Circle circle = new Circle(x, y, d);
                circle.Draw(CoolCanvas);
            }
            else
            {
                MessageBox.Show("Введите корректные числа");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CoolCanvas.Children.Clear();
        }
    }
}
