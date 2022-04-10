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


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string userInput = "0";
        double numberOne = 0;
        double numberTwo = 0;
        // 1 +, 2 -, 3 *, 4 /, 5 x2, 6 *-1,
        int action;
        double result;
        public MainWindow()
        {
            InitializeComponent();
            LabelUserInput.Content = "0";
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            if (userInput != "0")
            {
                userInput += "0";
            }
            else
            {
            }
            LabelUserInput.Content = userInput;
        }
        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "1";
            LabelUserInput.Content = userInput;
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "2";
            LabelUserInput.Content = userInput;
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "3";
            LabelUserInput.Content = userInput;
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "4";
            LabelUserInput.Content = userInput;
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "5";
            LabelUserInput.Content = userInput;
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "6";
            LabelUserInput.Content = userInput;
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "7";
            LabelUserInput.Content = userInput;
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "8";
            LabelUserInput.Content = userInput;
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            DeleteDefaultValue(LabelUserInput.Content.ToString());
            userInput += "9";
            LabelUserInput.Content = userInput;
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            numberOne = Convert.ToDouble(userInput);
            userInput = "";
            LabelUserInput.Content = userInput;
            action = 1;
        }
        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            numberOne = Convert.ToDouble(userInput);
            userInput = "";
            LabelUserInput.Content = userInput;
            action = 2;
        }
        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            numberOne = Convert.ToDouble(userInput);
            userInput = "";
            LabelUserInput.Content = userInput;
            action = 3;
        }
        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            numberOne = Convert.ToDouble(userInput);
            userInput = "";
            LabelUserInput.Content = userInput;
            action = 4;
        }
        private void ButtonSquare_Click(object sender, RoutedEventArgs e)
        {
            action = 5;
            double result;
            numberOne = Convert.ToDouble(userInput);
            userInput = "";
            result = MyMath.ReturnResult(action, numberOne);
            LabelUserInput.Content = result;
        }
        private void ButtonNegative_Click(object sender, RoutedEventArgs e)
        {
            action = 6;
            double result;
            numberOne = Convert.ToDouble(userInput);
            userInput = "";
            result = MyMath.ReturnResult(action, numberOne);
            LabelUserInput.Content = result;
        }
        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            numberTwo = Convert.ToDouble(userInput);
            if (action == 4 && numberTwo == 0)
            {
                LabelUserInput.Content = "Kiss my shiny metal ass, can't divide by zero";
            }
            else
            {
                double result = MyMath.ReturnResult(action, numberOne, numberTwo);
                LabelUserInput.Content = result;
                userInput = "";
            }
        }

        private void ButtonDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            numberOne = 0;
            numberTwo = 0;
            userInput = "0";
            LabelUserInput.Content = userInput;
        }
        private void ButtonDeleteLast_Click(object sender, RoutedEventArgs e)
        {
            if (userInput.Length == 1)
            {
                userInput = "0";
                LabelUserInput.Content = userInput;
            }
            else
            {
                int lastIndex = userInput.Length - 1;
                userInput = userInput.Substring(0, lastIndex);
                LabelUserInput.Content = userInput;
            }
        }
        private void DeleteDefaultValue(string userInput)
        {
            if (userInput == "0")
            {
                this.userInput = "";
            }
        }

        private void FormCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            int convertResult = 0;
            KeyConverter converter = new KeyConverter();
            string key = converter.ConvertToString(e.Key);
            bool isNumber = Int32.TryParse(key, out convertResult);
            DeleteDefaultValue(userInput);
            if (isNumber)
            {
                userInput += key;
                LabelUserInput.Content = userInput;
            }
            else if (key == "Backspace")
            {
                if (userInput.Length == 1)
                {
                    userInput = "0";
                    LabelUserInput.Content = userInput;
                }
                else if (userInput.Length > 1)
                {
                    int lastIndex = userInput.Length - 1;
                    userInput = userInput.Substring(0, lastIndex);
                    LabelUserInput.Content = userInput;

                }
            }
        }
    }
}
