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

namespace lecture11lab1
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
            // Creates a Phonebook
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                { "Kostyantyn", "760-828-3709" },
                { "Josh", "753-593-9934" },
                { "Kevin", "949-234-110" }
            };

            try
            {
                phoneBook.TryGetValue(entryBox.Text, out string phoneNumber);

                outputText.Text = entryBox.Text + "'s phone #\n" + phoneNumber;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
