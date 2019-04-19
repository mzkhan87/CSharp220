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
// Assignment 01
// Date: 04/18/2019

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled = false;
        }

        private void UxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            uxSubmitButtonStatus();
        }

        private void UxSubmit_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }

        private void UxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            uxSubmitButtonStatus();
        }

        private void uxSubmitButtonStatus()
        {
            if (uxName.Text != "" && uxPassword.Text != "") uxSubmit.IsEnabled = true;
            else uxSubmit.IsEnabled = false;          
        }

        
    }
}
