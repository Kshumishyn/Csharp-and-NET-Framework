// Homework No.12 Exercise No.1
// File Name:     MainWindow.xaml.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 27, 2017
//
// Problem Statement: Creates a GUI using a Delegate to find the Area given a Double
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Make GUI
// 2. Each Radio Button changes the delegate, the text for the Entry field and the Image
// 3. Button calls delegate function and calculates area
// 4. Exception Handles

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

namespace hw12project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Delegate
        delegate double Area(double num1);

        // Actual Delegate Variable
        Area formula;

        public MainWindow()
        {
            InitializeComponent();

            // Defaults to Blank Image
            var uri = new Uri("pack://application:,,,/Images/BLANK.PNG");
            var bitmap = new BitmapImage(uri);
            geoImage.Source = bitmap;
        }

        private void SquareRadio_Checked(object sender, RoutedEventArgs e)
        {
            // Changes Image
            var uri = new Uri("pack://application:,,,/Images/SQUARE.PNG");
            var bitmap = new BitmapImage(uri);
            geoImage.Source = bitmap;

            // Sets Instructions for Entry
            choiceTextLabel.Text = "Square Side";

            // Sets Delegate
            formula = SquareArea;
        }

        private void TriangleRadio_Checked(object sender, RoutedEventArgs e)
        {
            // Changes Image
            var uri = new Uri("pack://application:,,,/Images/TRIANGLE.PNG");
            var bitmap = new BitmapImage(uri);
            geoImage.Source = bitmap;

            // Sets Instructions for Entry
            choiceTextLabel.Text = "Triangle Face";

            // Sets Delegate
            formula = TriangleArea;
        }

        private void CircleRadio_Checked(object sender, RoutedEventArgs e)
        {
            // Changes Image
            var uri = new Uri("pack://application:,,,/Images/CIRCLE.PNG");
            var bitmap = new BitmapImage(uri);
            geoImage.Source = bitmap;

            // Sets Instruction for Entry
            choiceTextLabel.Text = "Circle Radius";

            // Sets Delegate
            formula = CircleArea;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Tries to Convert Entry Box to an Integer
            try
            {
                areaLabel.Text = "Area : " + Convert.ToString(formula(Convert.ToDouble(entryBox.Text)));
            }

            // Catches the user converting without a choice
            catch (NullReferenceException n)
            {
                areaLabel.Text = "Please select a Shape";
            }

            // Catches trying to convert non-int to int
            catch (FormatException f)
            {
                areaLabel.Text = "Please enter a valid #";
            }
        }

        // Calculates the Area of a Square
        public static double SquareArea(double side)
        {
            return Math.Round(side * side, 2);
        }

        // Calculates the Area of a Triangle
        public static double TriangleArea(double face)
        {
            return Math.Round(face * face / 2.0, 2);
        }

        // Calculates the Area of a Circle
        public static double CircleArea(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
    }
}
