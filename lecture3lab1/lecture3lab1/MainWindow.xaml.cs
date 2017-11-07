// Homework No.2 Exercise No.2
// File Name:     lecture3lab1.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 11, 2017
//
// Problem Statement: Uses GUI to streamline the Pig Latin Process
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Take first and last name, start them off lowercase
// 2. Take 2nd letter of the word as its own String, Uppercase it then concetenate it
//    with the rest of the word and add the first letter to the end with the string "ay"
// 3. Do above for first and last name Strings, then put back together and print out
// 4. Copy and Paste into Gui Project

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

namespace lecture3lab1
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

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = pigLatinify(FirstNameBox.Text) + " " + pigLatinify(LastNameBox.Text);
        }

        public static string pigLatinify(string name)
        {
            // Substring 1 to 1 so can use ToUpper
            // Using single bound for Substring goes to end
            // ElementAt returns a Char that concatenates into String but can't accept ToUpper or ToLower so lowercase beforehand
            name = name.ToLower();
            name = name.Substring(1, 1).ToUpper() + name.Substring(2) + name.ElementAt(0) + "ay";

            return name;
        }
    }

    
}
