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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn1.Content);
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn2.Content);
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn3.Content);
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn4.Content);
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn5.Content);
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn6.Content);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn7.Content);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn8.Content);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn9.Content);
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            InputNumber((string)Btn0.Content);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            CalTxtBlck.Text = "";
            InputTxtBlck.Text = "0";
        }

        private void InputNumber(string Btnvalue)
        {
            if (InputTxtBlck.Text != "0")
            {
                InputTxtBlck.Text += Btnvalue;
            }
            else
            {
                InputTxtBlck.Text = Btnvalue;
            }
        }
    }
}