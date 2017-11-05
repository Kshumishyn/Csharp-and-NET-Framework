// Homework No.4 Exercise No.1
// File Name:     hw4project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 25, 2017
//
// Problem Statement: Uses someone's height and weight to calculate their BMI and displays appropriate text/color.
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Displays a prompt for the two attributes that are required from the user
// 2. Calculates the BMI using the weight and height variables and the button to trigger the evaluation
// 3. Outputs the BMI in a textbox, uses the BMI to determine color feedback and text feedback
// 4. Displays the feedback and BMI

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

namespace hw4project1
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

        private void bmiButton_Click(object sender, RoutedEventArgs e)
        {
            // Variables
            double weight = Convert.ToDouble(weightBox.Text);
            double height = Convert.ToDouble(heightBox.Text);
            double bmi = (weight * 720) / (Math.Pow(height, 2));

            // Gives Color and text Feedback
            // Less than 15
            if (bmi < 15)
            {
                feedbackCanvas.Background = Brushes.Aquamarine;
                feedbackBox.Text = "You are below the Healthy BMI Standard.";
            }
            // Greater than 26
            else if (bmi > 26)
            {
                feedbackCanvas.Background = Brushes.LightYellow;
                feedbackBox.Text = "You are above the Healthy BMI Standard.";
            }
            // Inclusive of 15-26
            else
            {
                feedbackCanvas.Background = Brushes.ForestGreen;
                feedbackBox.Text = "You are at the Healthy BMI Standard.";
            }

            // Gives Text feedback on BMI
            bmiBox.Text = Math.Round(bmi, 2).ToString();
        }
    }
}
