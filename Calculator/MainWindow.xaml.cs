using System;
using System.Data;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

          
        }

        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            string ww = OutputLabel.Text.ToString();
            if (ww.Contains("%"))
            {
                string fnumber = "";
                string snumber = "";
                double count = 0;

                int percentIndex = ww.IndexOf("%");
                fnumber = ww.Substring(0, percentIndex);
                snumber = ww.Substring(percentIndex + 1);

                count = double.Parse(fnumber) / double.Parse(snumber) * 100;
                OutputLabel.Text = count.ToString() + "%";
            }
            else if (ww.Contains("/0"))
            {
                MessageBox.Show("На ноль делить нельзя");
            }
            else if (!ww.Contains("/0"))
            {
                string value = new DataTable().Compute(OutputLabel.Text, null).ToString();
                OutputLabel.Text = value;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "9";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "0";
        }

        private void buttonSum_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "+";
        }

        private void buttonMin_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "-";
        }

        private void buttonMult_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "*";
        }

        private void buttonSpl_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "/";
        }

        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text += "%";
        }

        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Text = "";
        }

        private void buttonDelLast_Click(object sender, RoutedEventArgs e)
        {
            string serv = OutputLabel.Text.ToString();
            char[] qq = serv.ToArray();
            
            if(qq.Length - 1 >= 0)
            {
                OutputLabel.Text = serv.Remove(qq.Length - 1);
            }
            else
            {
                MessageBox.Show("удалять больше нечего");
            }
        }
    }
}
