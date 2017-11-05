// Homework No.6 Exercise No.1
// File Name:     hw6project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 8, 2017
//
// Problem Statement: Builds a Driver GUI for the Counter Class
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Make Counter Class
// 2. Build GUI for Counter Class
// 3. Test Counter

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

namespace hw6project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Counter newCounter = new Counter();
        bool toggle = true;

        public MainWindow()
        {
            InitializeComponent();

            if (newCounter.GetCounter() == 0)
            {
                newCounter.SetCounter(0);
            }
        }

        private void CreateCounterButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleCounter(toggle);
            toggle = !toggle;
        }

        // Toggles all Elements to Argument/Parameter
        public void ToggleCounter(bool toggleTo)
        {
            setCounterButton.IsEnabled = toggleTo;
            setCounterBox.IsEnabled = toggleTo;
            setCounterBox.Text = "";

            getCounterButton.IsEnabled = toggleTo;
            getCounterBox.IsEnabled = toggleTo;
            getCounterBox.Text = "";

            incrementCounterButton.IsEnabled = toggleTo;
            incrementBox.IsEnabled = toggleTo;
            incrementBox.Text = "";

            decrementCounterButton.IsEnabled = toggleTo;
            decrementBox.IsEnabled = toggleTo;
            decrementBox.Text = "";

            displayCounterButton.IsEnabled = toggleTo;

            equalsCounterButton.IsEnabled = toggleTo;
            equalsBox.IsEnabled = toggleTo;
            equalsBox.Text = "";

            counterLabel.IsEnabled = toggleTo;
            emptyTextBlock.IsEnabled = toggleTo;
            emptyTextBlock.Text = "0";

            booleanBox.IsEnabled = toggleTo;
            booleanBox.Text = "";
            
        }

        private void setCounterButton_Click(object sender, RoutedEventArgs e)
        {
            int tempInt;
            try
            {
                tempInt = Convert.ToInt32(setCounterBox.Text);
                newCounter.SetCounter(tempInt);

                emptyTextBlock.Text = Convert.ToString(newCounter.GetCounter());
            }
            catch (FormatException newException)
            {
                emptyTextBlock.Text = newException.Message;
            }
        }

        private void getCounterButton_Click(object sender, RoutedEventArgs e)
        {
            int tempInt;

            tempInt = newCounter.GetCounter();

            getCounterBox.Text = Convert.ToString(tempInt);
        }

        // Increments depending if Value was provided in box
        private void incrementCounterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (incrementBox.Text == "")
                {
                    newCounter.Increment();
                }
                else
                {
                    int tempValue = Convert.ToInt32(incrementBox.Text);
                    newCounter.Increment(tempValue);
                }
                emptyTextBlock.Text = Convert.ToString(newCounter.GetCounter());
            }
            catch (FormatException newException)
            {
                emptyTextBlock.Text = newException.Message;
            }
        }

        // Decrements depending if Value was provided in box
        private void decrementCounterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (decrementBox.Text == "")
                {
                    newCounter.Decrement();
                }
                else
                {
                    int tempValue = Convert.ToInt32(decrementBox.Text);
                    newCounter.Decrement(tempValue);
                }
                emptyTextBlock.Text = Convert.ToString(newCounter.GetCounter());
            }
            catch (FormatException newException)
            {
                emptyTextBlock.Text = newException.Message;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            newCounter.DisplayCounter();
        }

        private void equalsCounterButton_Click(object sender, RoutedEventArgs e)
        {
            int toCompare;
            try
            {
                toCompare = Convert.ToInt32(equalsBox.Text);

                if (newCounter.Equals(toCompare))
                {
                    booleanBox.Text = "True";
                }
                else
                {
                    booleanBox.Text = "False";
                }
            }
            catch (FormatException newException)
            {
                emptyTextBlock.Text = newException.Message;
            }
        }
    }

}

