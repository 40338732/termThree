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
using WpfApp2.Properties;



namespace WpfApp2
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

            var x = new Tony();
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            var tony = new Tony();

           
        }
    }

    public partial class Tony
    {
        // Constructors //

        // this takes no argument
        public Person()
        {
            _state = "stopped";
        }

        // this takes two arguments
        public Person(string name, string surname)
        {
            _state = "stopped";
            Name = name;
            Surname = surname;
        }


        // Methods //

        // Changes the state to "walking"
        //  returns true if successfull, false if already walking
        public bool StartWalking()
        {
            if (_state != "walking")
            {
                _state = "walking";
                return true;
            }
            return false;
        }

        // stops whatever action
        public void Stop()
        {
            _state = "stopped";
        }


        // Properties //

        // private property state
        private string _state;

        // public property to get the state
        public string CurrentState
        {
            get { return _state; }
        }

        // public property to get/set the name
        //  using the non-automatic way
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        // public property to get/set the surname
        //  using the automatic way
        public string Surname { get; set; }



    }
}
