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

namespace lecture6lab1
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

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double leftNumber = Convert.ToDouble(leftHandBox.Text);
                double rightNumber = Convert.ToDouble(rightHandBox.Text);

                outputBox.Text = Convert.ToString(Math.Round(leftNumber + rightNumber, 2));
                displayBox.Text = Math.Round(leftNumber, 2) + " + " + Math.Round(rightNumber, 2);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Wrong Format Bub : " + exception.Message);
            }

        }

        private void subtractionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double leftNumber = Convert.ToDouble(leftHandBox.Text);
                double rightNumber = Convert.ToDouble(rightHandBox.Text);

                outputBox.Text = Convert.ToString(Math.Round(leftNumber - rightNumber, 2));
                displayBox.Text = Math.Round(leftNumber, 2) + " - " + Math.Round(rightNumber, 2);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Wrong Format Bub : " + exception.Message);
            }
        }

        private void multiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double leftNumber = Convert.ToDouble(leftHandBox.Text);
                double rightNumber = Convert.ToDouble(rightHandBox.Text);

                outputBox.Text = Convert.ToString(Math.Round(leftNumber * rightNumber, 2));
                displayBox.Text = Math.Round(leftNumber, 2) + " * " + Math.Round(rightNumber, 2);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Wrong Format Bub : " + exception.Message);
            }
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double leftNumber = Convert.ToDouble(leftHandBox.Text);
                double rightNumber = Convert.ToDouble(rightHandBox.Text);

                outputBox.Text = Convert.ToString(Math.Round(leftNumber / rightNumber, 2));
                displayBox.Text = Math.Round(leftNumber, 2) + " / " + Math.Round(rightNumber, 2);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Wrong Format Bub : " + exception.Message);
            }
        }

        private void remainderButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double leftNumber = Convert.ToDouble(leftHandBox.Text);
                double rightNumber = Convert.ToDouble(rightHandBox.Text);

                outputBox.Text = Convert.ToString(Math.Round(leftNumber % rightNumber, 2));
                displayBox.Text = Math.Round(leftNumber, 2) + " % " + Math.Round(rightNumber, 2);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Wrong Format Bub : " + exception.Message);
            }
        }
    }
}
