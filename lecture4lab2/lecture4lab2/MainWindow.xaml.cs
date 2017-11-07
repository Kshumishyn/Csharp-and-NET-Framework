// Homework No.? Exercise No.?
// File Name:     lecture4lab2.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 18, 2017
//
// Problem Statement: Calculates how far over the Speed Limit someone goes.
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Prompt the user for the Speed Limit and their Velocity
// 2. Calculate whether they were speeding or not and reprimand them appropriately.
// 3. Copy and Paste most of the code into GUI for Button

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

namespace lecture4lab2
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
            // Constants
            const int FLAT_RATE = 60;
            const int PENALTY_FEE = 250;
            const int SPEED_PENALTY_RATE = 7;

            // Variables
            int speedLimit;
            int velocity;
            int netSpeedViolation;
            int absSpeedViolation;
            int speedTicketFeeDue;

            // Reads speedLimit
            speedLimit = Convert.ToInt32(SpeedLimitEntry.Text);

            // Reads Velocity
            velocity = Convert.ToInt32(VelocityEntry.Text);

            // Calculates Difference from Speed Limit
            netSpeedViolation = speedLimit - velocity;

            // Only valid for non-negative numbers
            if (netSpeedViolation >= 0)
            {
                FeedbackText.Text = "Well done CITIZEN!";

                // Green for Safe
                ColorCanvas.Background = Brushes.Green;
            }
            else
            {
                // Takes Absolute Value for use with $7.00 rate per mile over Speed Limit
                absSpeedViolation = Math.Abs(netSpeedViolation);

                // Calculates fee generally
                speedTicketFeeDue = FLAT_RATE + absSpeedViolation * SPEED_PENALTY_RATE;

                // Yellow for Caution Advised
                ColorCanvas.Background = Brushes.Yellow;

                // Adds Flat Penalty if 25 over the Speed Limit
                if (absSpeedViolation > 25)
                {
                    speedTicketFeeDue += PENALTY_FEE;

                    // Red for Penalty Zone
                    ColorCanvas.Background = Brushes.Red;
                }

                // Scolds User
                FeedbackText.Text = "Your fee is $" + Math.Round((double)speedTicketFeeDue,2) + " punk, check yourself before you hurt someone.";

                // Sets output
                FeeOutputBox.Text = "$" + Math.Round((double)speedTicketFeeDue, 2);
            }
        }
    }
}
