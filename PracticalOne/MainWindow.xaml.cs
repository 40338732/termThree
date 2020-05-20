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

        public MainWindow()
        {
            InitializeComponent();
         }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string outPut = "";

            if (txtName.Text != "" || txtAge.Text != "" || txtAddress.Text != "")
            {
                outPut = txtName.Text + "," + txtAge.Text + "," + txtAddress.Text; 
             }

            // Write the output to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\uni\\test.txt", true); file.WriteLine(outPut);
            file.Close();
            
            clearFields();
            lbSaveMessage.Content = "Saved";

        }

        private void clearFields()
        {
            txtAddress.Text = "";
            txtAge.Text = "";
            txtName.Text = "";
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            clearFields();
        }
        
        private void TxtName_LostFocus(object sender, RoutedEventArgs e)
        {
            string input = txtName.Text;
           
            if ( input != "")
            {
                lbNameValidate.Content = null;
                Regex regex = new Regex("[^a-zA-Z]+");
                if (regex.IsMatch(input))
                {
                    // MessageBox.Show("Invalid Input !");
                    lbNameValidate.Content = "* Invalid Input !";
            
                }
                else
                {
                    lbNameValidate.Content = null;
                }
            }
            if (input == "")
            {
                lbNameValidate.Content = "* Required Input";
            }
        }

        private void TxtAge_LostFocus(object sender, RoutedEventArgs e)
        {
            lbAgeValidate.Content = null;
            int number;
            bool success = Int32.TryParse(txtAge.Text, out number);
            if (success)
            {
                
                if (txtAge.Text.Length > 0)
                {
                    int input = Int32.Parse(txtAge.Text);

                    if (input > 0 && input < 100)
                    { }
                    else
                    {
                        lbAgeValidate.Content = "* Invalid Input (1-100)";
               
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
            else
            {
                lbAgeValidate.Content = "* Required Input (1-100)";

            }
        }

        private void TxtAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            string input = txtAddress.Text;

            if (input != "")
            {
                lbAddressValidate.Content = null;
                Regex regex = new Regex("[^A - Za - z0 - 9] ");
                if (regex.IsMatch(input))
                {
                    // MessageBox.Show("Invalid Input !");
                    lbAddressValidate.Content = "* Invalid Input !";
         
                }
                else
                {
                    lbAddressValidate.Content = null;
                }
            }
            if (input == "")
            {
                lbAddressValidate.Content = "* Required Input";
      
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

        private void TxtName_GotFocus(object sender, RoutedEventArgs e)
        {
            lbSaveMessage.Content = "";
        }

        private void TxtAge_GotFocus(object sender, RoutedEventArgs e)
        {
            lbSaveMessage.Content = "";
        }

        private void TxtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbSaveMessage.Content = "";
        }
    }
}
