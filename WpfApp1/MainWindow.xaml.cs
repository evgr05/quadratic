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

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            if (double.TryParse(textBoxA.Text, out a) &&
                double.TryParse(textBoxB.Text, out b) &&
                double.TryParse(textBoxC.Text, out c))
            {
                string result = SolveQuadraticEquation(a, b, c);
                resultText.Text = result;
            }
            else
            {
                resultText.Text = "Недопустимый ввод!";
            }
        }

        private string SolveQuadraticEquation(double a, double b, double
c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return $"Корни реальны и отчетливы: {root1} и {root2}";
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return $"Корни действительны и равны: {root}";
            }
            else
            {
                return "Корни сложные";
            }
        }
    }
}
