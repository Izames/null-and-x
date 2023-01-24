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

namespace null_and_x
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            first.Content = "x";
            first.IsEnabled = false;
            AI();
        }
        private void start_Click(object sender, RoutedEventArgs e)
        {
            Button[] b = new Button[] { first, second, third, fourth, five, six, seven, eight, nine};
            foreach(Button x in b)
            {
                x.IsEnabled = true;
            }
            start.Content= "рестарт";
            foreach(Button x in b)
            {
                x.Content = "";
            }
        }
        private void second_Click(object sender, RoutedEventArgs e)
        {
            second.Content = "x";
            second.IsEnabled = false;
            AI();
        }

        private void third_Click(object sender, RoutedEventArgs e)
        {
            third.Content = "x";
            third.IsEnabled = false;
            AI();
        }

        private void fourth_Click(object sender, RoutedEventArgs e)
        {
            fourth.Content = "x";
            fourth.IsEnabled = false;
            AI();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            five.Content = "x";
            five.IsEnabled = false;
            AI();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            six.Content = "x";
            six.IsEnabled = false;
            AI();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            seven.Content = "x";
            seven.IsEnabled = false;
            AI();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            eight.Content = "x";
            eight.IsEnabled = false;
            AI();
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            nine.Content = "x";
            nine.IsEnabled = false;
            AI();
        }
        private void AI()
        {
            Random random = new Random();
            while (true)
            {
                int AI_choose = random.Next(1, 10);
                if ((AI_choose == 1) && (first.IsEnabled == true))
                {
                    first.Content = "0";
                    first.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 2) && (second.IsEnabled == true))
                {
                    second.Content = "0";
                    second.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 3) && (third.IsEnabled == true))
                {
                    third.Content = "0";
                    third.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 4) && (fourth.IsEnabled == true))
                {
                    fourth.Content = "0";
                    fourth.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 5) && (five.IsEnabled == true))
                {
                    five.Content = "0";
                    five.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 6) && (six.IsEnabled == true))
                {
                    six.Content = "0";
                    six.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 7) && (seven.IsEnabled == true))
                {
                    seven.Content = "0";
                    seven.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 8) && (eight.IsEnabled == true))
                {
                    eight.Content = "0";
                    eight.IsEnabled = false;
                    break;
                }
                else if ((AI_choose == 9) && (nine.IsEnabled == true))
                {
                    nine.Content = "0";
                    nine.IsEnabled = false;
                    break;
                }
                else if (first.IsEnabled == false && second.IsEnabled==false && third.IsEnabled==false && fourth.IsEnabled == false && five.IsEnabled == false && six.IsEnabled == false && seven.IsEnabled == false && eight.IsEnabled == false && nine.IsEnabled == false)
                {
                    break;
                }
            }
            if (first.Content == "x" && second.Content=="x" && third.Content=="x")
            {
                Win_lose(0);
            }
            else if(fourth.Content=="x" && five.Content == "x" && six.Content == "x")
            {
                Win_lose(0);
            }
            else if(seven.Content=="x" && eight.Content == "x" && nine.Content == "x")
            {
                Win_lose(0);
            }
            else if (first.Content=="x" && five.Content == "x" && nine.Content=="x")
            {
                Win_lose(0);
            }
            else if (third.Content=="x" && five.Content=="x" && seven.Content == "x")
            {
                Win_lose(0);
            }
            else if (first.Content=="x" && fourth.Content=="x" && seven.Content == "x")
            {
                Win_lose(0);
            }
            else if (second.Content=="x" && five.Content== "x" && eight.Content == "x")
            {
                Win_lose(0);
            }
            else if (third.Content=="x" && six.Content=="x" && nine.Content == "x")
            {
                Win_lose(0);
            }
            if (first.Content == "0" && second.Content == "0" && third.Content == "0")
            {
                Win_lose(1);
            }
            else if (fourth.Content == "0" && five.Content == "0" && six.Content == "0")
            {
                Win_lose(1);
            }
            else if (seven.Content == "0" && eight.Content == "0" && nine.Content == "0")
            {
                Win_lose(1);
            }
            else if (first.Content == "0" && five.Content == "0" && nine.Content == "0")
            {
                Win_lose(1);
            }
            else if (third.Content == "0" && five.Content == "0" && seven.Content == "0")
            {
                Win_lose(1);
            }
            else if (first.Content == "0" && fourth.Content == "0" && seven.Content == "0")
            {
                Win_lose(1);
            }
            else if (second.Content == "0" && five.Content == "0" && eight.Content == "0")
            {
                Win_lose(1);
            }
            else if (third.Content == "0" && six.Content == "0" && nine.Content == "0")
            {
                Win_lose(1);
            }
        }
        private void Win_lose(int result)
        {
            if (result == 0)
            {
                MessageBox.Show("Победа!");
            }
            if (result == 1)
            {
                MessageBox.Show("ты рандомайзеру продул...");
            }
            Button[] b = new Button[] { first, second, third, fourth, five, six, seven, eight, nine };
            foreach (Button x in b)
            {
                x.IsEnabled = true;
            }
            foreach (Button x in b)
            {
                x.Content = "";
            }
        }
    }
}
