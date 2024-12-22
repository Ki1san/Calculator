using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double result = 0;

        private void Display(TextBox Text)
        {

            string expression = TextBox.Text;
            string[] parts = expression.Split(' ');

            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[2]);
            string operat = parts[1];

            switch (operat)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На 0 делить нельзя");
                        return;
                    }
                    else
                    {
                        result = a / b;
                        break;
                    }
                case "%":
                    result = result / 100;
                    break;

                default:
                    MessageBox.Show("Неверная операция");
                    return;
            }

            Text.Text = result.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Display(TextBox);
        }
    }
}