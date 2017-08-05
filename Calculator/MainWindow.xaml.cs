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

namespace Calculator
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
        String num = "";
        int valueOne;
        int valueTwo;
        char op;
        int ans;
        private void Button0(object sender, RoutedEventArgs e)
        {
            num += 0;
            Display.Content = num;
        }
        private void Button1(object sender, RoutedEventArgs e)
        {
            num += 1;
            Display.Content = num;
        }
        private void Button2(object sender, RoutedEventArgs e)
        {
            num += 2;
            Display.Content = num;
        }
        private void Button3(object sender, RoutedEventArgs e)
        {
            num += 3;
            Display.Content = num;
        }
        private void Button4(object sender, RoutedEventArgs e)
        {
            num += 4;
            Display.Content = num;
        }
        private void Button5(object sender, RoutedEventArgs e)
        {
            num += 5;
            Display.Content = num;
        }
        private void Button6(object sender, RoutedEventArgs e)
        {
            num += 6;
            Display.Content = num;
        }
        private void Button7(object sender, RoutedEventArgs e)
        {
            num += 7;
            Display.Content = num;
        }
        private void Button8(object sender, RoutedEventArgs e)
        {
            num += 8;
            Display.Content = num;
        }
        private void Button9(object sender, RoutedEventArgs e)
        {
            num += 9;
            Display.Content = num;
        }

        public int CombineNum(String num)
        {
            int val;
            val = Convert.ToInt32(num);
            return val;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            valueOne = CombineNum(num);
            op = '+';
            num = "0";
            Display.Content = "";

        }
        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            valueOne = CombineNum(num);
            op = '-';
            num = "0";
            Display.Content = "";

        }
        private void Button_Mul(object sender, RoutedEventArgs e)
        {
            valueOne = CombineNum(num);
            op = '*';
            num = "0";
            Display.Content = "";
        }
        private void Button_Div(object sender, RoutedEventArgs e)
        {
            valueOne = CombineNum(num);
            op = '/';
            num = "0";
            Display.Content = "";
        }

        private void Button_Equal(object sender, RoutedEventArgs e)
        {
            valueTwo = CombineNum(num);
            
            if(op == '+')
            {
                ans = valueOne + valueTwo;
            }
            else if (op == '-')
            {
                ans = valueOne - valueTwo;
            }
            else if (op == '*')
            {
                ans = valueOne * valueTwo;
            }
            else
            {
                ans = valueOne / valueTwo;
            }
            Display.Content = ans;
            valueOne = valueTwo;
            valueTwo = 0; 
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            valueOne = 0;
            valueTwo = 0;
            ans = 0;
        }
    }
}
