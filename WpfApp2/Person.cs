using System;

public class Person
{
	public Person()
	{
        _state = "stopped";


	}

    public Person(string name, string surname)
    {
        _state = "stopped";
        Name = name;
        Surname = surname;
    }

    public bool StartWalking()
    {
        if (_state != "walking")
        {
            _state = "walking";
            return true;
        }
        return false;
    }

    public void Stop()
    {
        _state = "stopped";
    }

    private string _state;

    public string CurrentState
    {
        get { return _state; }
    }

    public string Name
    {
        get { return Name;}
        set { Name = value; }
    }

    public string Surname { get; set }


}
