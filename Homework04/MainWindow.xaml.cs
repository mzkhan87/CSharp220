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

// Muhammad Khan
// Assignment04
//Date: 05/07/2019
namespace Homework04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            submit_Button.IsEnabled = false;
        }


        private void Zip_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsValidZipCode(zip_textBox.Text))
            {
                submit_Button.IsEnabled = true;
            }
            else
            {
                submit_Button.IsEnabled = false;
            }
        }

        private bool IsValidZipCode(string text)
        {
            bool enabledButton = false;
            if ( text.Length == 5 && text.All(char.IsNumber) )
            {
                enabledButton = true;
            }
            else if ( text.Length == 10 )
            {
                int index = text.IndexOf("-");
                string priorNumber = text.Substring(0, index);
                string postNumber = text.Substring(index + 1);
                if ( index == 5 && priorNumber.All(char.IsNumber) && postNumber.All(char.IsNumber) ) enabledButton = true;

            } else if ( text.Length == 6 )
            {
                string digits = text[1].ToString() + text[3].ToString() + text[5].ToString();
                string characters = text[0].ToString() + text[2].ToString() + text[4].ToString();

                if ( digits.All(char.IsDigit) && characters.All(char.IsLetter) ) enabledButton = true; 
             }
            return enabledButton;
        }
    }
}
