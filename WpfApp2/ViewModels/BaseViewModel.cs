using System;
using System.ComponentModel;

namespace WpfApp2.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyCharged;

        public void OnChanged(string propertyChanged)
        {
            PropertyCharged(this, new PropertyChangedEventArgs(propertyChanged));
        }
    }
}

public class Class1
{
	public Class1()
	{
	}
}
