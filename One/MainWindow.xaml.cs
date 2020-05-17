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

namespace One
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

        private void BtnClickMe_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string[] acceptArr= new string[3];
                acceptArr[0] = "Yes";
                acceptArr[1] = "No";
                acceptArr[2] = "N/A";

                lbMessage.Content = acceptArr[2];

                int test = 7;

                lbMessage.Content = test.ToString();
}
            catch(Exception )
            {
                lbMessage.Content = "Error: " + e;
            }


            //lbMessage.Content = "Hello me !!";
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int oneValue = Int32.Parse(txtOne.Text);
                int twoValue = Int32.Parse(txtTwo.Text);

                int threeValue = oneValue + twoValue;
                
                lbMessage.Content = threeValue.ToString();

            }catch(FormatException)
            {
                lbMessage.Content = " input isn't a number";
            }
        }
    }
}
