using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

// Muhammad Khan
// Assignment05
// Date: 05/15/2019


namespace Homework05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int xOrO = 0;
        List<Button> aList;
        public MainWindow()
        {
            InitializeComponent();
            aList = uxGrid.Children.Cast<Button>().ToList();
            uxTurn.Text = "X's Turn";
        }

        private void UxNewGame_Click(object sender, RoutedEventArgs e)
        {
            uxGrid.IsEnabled = true;
            aList.ForEach(button => { button.Content = null; });
            uxTurn.Text = "X's Turn";
            xOrO = 0;
        }

        private void uxExit_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (!btn.HasContent)
            {
                if (xOrO % 2 == 0)
                {
                    btn.Content = "X";
                    btn.Foreground = Brushes.Red;
                    uxTurn.Text = "O's Turn";
                }
                else
                {
                    btn.Content = "O";
                    btn.Foreground = Brushes.Green;
                    uxTurn.Text = "X's Turn";
                }

                xOrO++;
            }

            FindWinner(aList);

            // if No one wins then we call it a Tie. 
            if (xOrO == 9)
            {
                uxGrid.IsEnabled = false;
                uxTurn.Text = "Game Tied";
            }
        }

        private void FindWinner(List<Button> aList)
        {

            FindRowVictory(aList);
            FindColumnVictory(aList);
            FindDiagonalVictory(aList);
        }


        private void FindColumnVictory(List<Button> aList)
        {
            //Check Vertical Victory.
            // column 0.
            if (((string)aList[0].Content + (string)aList[3].Content + (string)aList[6].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[0].Content + (string)aList[3].Content + (string)aList[6].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            }    //Column 1
            else if (((string)aList[1].Content + (string)aList[4].Content + (string)aList[7].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[1].Content + (string)aList[4].Content + (string)aList[7].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            } //Column 2
            else if (((string)aList[2].Content + (string)aList[5].Content + (string)aList[8].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[2].Content + (string)aList[5].Content + (string)aList[8].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            }

        }


        private void FindRowVictory(List<Button> aList)
        {
            //Check horizontal Victory.
            // row 0.
            if (((string)aList[0].Content + (string)aList[1].Content + (string)aList[2].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[0].Content + (string)aList[1].Content + (string)aList[2].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            }    //row 1
            else if (((string)aList[3].Content + (string)aList[4].Content + (string)aList[5].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[3].Content + (string)aList[4].Content + (string)aList[5].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            } //row 2
            else if (((string)aList[6].Content + (string)aList[7].Content + (string)aList[8].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[6].Content + (string)aList[7].Content + (string)aList[8].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            }

        }

        private void FindDiagonalVictory(List<Button> aList)
        {
            // Diagonal 1

            if (((string)aList[0].Content + (string)aList[4].Content + (string)aList[8].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[0].Content + (string)aList[4].Content + (string)aList[8].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            }    // Diagonal 2
            else if (((string)aList[2].Content + (string)aList[4].Content + (string)aList[6].Content) == "XXX")
            {
                uxTurn.Text = "X is a winner";
                uxGrid.IsEnabled = false;
            }
            else if (((string)aList[2].Content + (string)aList[4].Content + (string)aList[6].Content) == "OOO")
            {
                uxTurn.Text = "O is a winner";
                uxGrid.IsEnabled = false;
            } 
        }
    }
}
