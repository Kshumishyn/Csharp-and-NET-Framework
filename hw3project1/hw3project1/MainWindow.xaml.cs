// Homework No.3 Exercise No.1
// File Name:     hw3project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 15, 2017
//
// Problem Statement: Uses GUI to streamline the process of calculating a single Mortgage Payment
// with details on the amount going to interest and principle.
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Convert Interest Rate to decimal value, and calculate amount owed to interest
// 2. Using payment, remove the amount going to interest, if enough, and store and subtract rest 
//    as going to principle
// 3. Calculate the new outstanding balance and return all of the above info to the user
// 4. Use GUI to display and store all the above information and calculate it at the press of a button.

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

namespace hw3project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double INTEREST_RATE = 6.39;

        public MainWindow()
        {
            InitializeComponent();
            AnnualInterestBox.Text = INTEREST_RATE + "";
        }
   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Interest Rate
            double effectiveInterestRate = (Convert.ToDouble(AnnualInterestBox.Text))/100;

            // Monthly Mortgage Payment
            double monthlyMortgagePayment = Convert.ToDouble(MonthlyMortgagePaymentBox.Text);

            // Monthly Interest Pay
            double paymentToInterest = (Convert.ToDouble(OutstandingBalanceBox.Text)*effectiveInterestRate/12);

            // Monthly Principle Pay
            double paymentToPrinciple = monthlyMortgagePayment - paymentToInterest;

            // New Outstanding Balance
            double newOutstandingBalance = Convert.ToDouble(OutstandingBalanceBox.Text) - paymentToPrinciple;

            // Sets Output Boxes and converts them to Currencies using "C" format specifier
            // Sorry I know I'm not supposed to use ToString, but it looked so nice. There may 
            //be some redundancy in using the Math Round method, but felt it couldn't hurt to
            // keep it to demonstrate ability to use it as would be expected.
            PaymentToPrincipleBox.Text = Math.Round(paymentToPrinciple, 2).ToString("C");
            PaymentToInterestBox.Text = Math.Round(paymentToInterest, 2).ToString("C");
            NewOutstandingBalanceBox.Text = Math.Round(newOutstandingBalance,2).ToString("C");

        }

    }
}
