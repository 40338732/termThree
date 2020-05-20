using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PracticalOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Regex regexNum = new Regex("[^0-9.-]+");  //regex that matches disallowed text
        private static readonly Regex regexAlpha = new Regex(" ^[a - zA - Z_] * $");  //regex that matches disallowed text



        public MainWindow()
        {
            InitializeComponent();
            
            
    }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string outPut = "";

            if (txtName.Text != "" || txtAge.Text != "" || txtAddress.Text != "")
            {

                outPut = txtName.Text + "," + txtAge.Text + "," + txtAddress.Text; // + "\n";

             }


            string lines = "This will be appended to a file";
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\uni\\test.txt", true); file.WriteLine(outPut);
            file.Close();



        }

        private static bool IsTextAllowed(string text)
        {
            return regexAlpha.IsMatch(text);
        }
        private static bool IsNumAllowed(string text)
        {
            return regexNum.IsMatch(text);
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {

            txtAddress.Text = "";
            txtAge.Text = "";
            txtName.Text = "";


        }
        
        private void TxtName_LostFocus(object sender, RoutedEventArgs e)
        {
            string input = txtName.Text;
           
            if ( input == "")
            {
               
                lbNameValidate.Content = "* Required Input";
            }
            else
            {
                lbNameValidate.Content = "";
            }
        }

        private void TxtAge_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtAge.Text.Length > 0)
            {
                int input = Int32.Parse(txtAge.Text);

                if (input > 0)
                { }
                else
                {
                    lbAgeValidate.Content = "* Required Input (1-100)";
                }
            }
            else if (txtAge.Text.Length == 0)
            {
                lbAgeValidate.Content = "* Required Input (1-100)";
            }
            else
            {
                lbAgeValidate.Content = null;
            }
        }

        private void TxtAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            string input = txtAddress.Text;

            if (input == "")
            {
                lbAddressValidate.Content = "* Required Input";
            }
            else
            {
                lbNameValidate.Content = null;
            }
        }

        private void BtnReadFile_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            string line;
            string readFromFile = "";
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\\uni\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                readFromFile = readFromFile + line + "\r";
                //System.Console.WriteLine(line);
                counter++;
            }
            txtReadFile.Text = readFromFile;
            file.Close();
            lbAddressValidate.Content = "There were {0} lines." + counter;
            
        }
    }
}
