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
    /// 

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

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create a loop out putting odd numbers 
                int startNumber = 0;
                int numberToGoUpTo;
                string colours = "";
                numberToGoUpTo = Int32.Parse(txtOne.Text);

                for (int i = 0; i < numberToGoUpTo; i++)
                {

                    startNumber = i;

                    if (startNumber % 2 != 0)
                    {
                        string[] stringArray = { "Red", "yellow" };
                        foreach (var colour in stringArray)
                        {
                            colours = colour;
                        }

                        txtList.Text = txtList.Text + startNumber.ToString() +" " + colours + Environment.NewLine ;
                    }


                    List<string> stringList = new List<string>();
                    stringList.Add("apple");
                    stringList.Add("Banana");
                    stringList.Add("Orange");

                    txtList.Text = txtList.Text + stringList[1].ToUpper().ToString();

                    // System.Threading.Thread.Sleep(1000);

                    





                }
            }catch(FormatException)
            {
                lbMessage.Content = " input isn't a number";
            }

           

        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dictionary<int, string> users = new Dictionary<int, string>();

                users.Add(1, "Susan");
                users.Add(2, "Tony");
                users.Add(3, "Ben");
                users.Add(4, "Poppy");

                Random rnd = new Random();
                int num = rnd.Next(1, 5);


                lbMessage.Content = users[num];
                bool x = users.ContainsKey(num);
                lbMessage.Content = x.ToString();

            }catch(FormatException)
            {
                lbMessage.Content = "incorrect format";
            }

          
        }
    }
}
