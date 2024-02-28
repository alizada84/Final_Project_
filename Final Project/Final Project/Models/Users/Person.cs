namespace Final_Project.Models.Users;

public class Person
{
    string _username;
    public string Userame
    {
        get => _username;
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            else
                _username = value;
        }
    }

    string _password;
    public string Password
    {
        get => _password;
        set
        {
            if (_password.Length >= 5)
                _password = value;
            else
                throw new ArgumentException("Minimum 5 symbol");
        }
    }

    public Person(string username, string password)
    {
        Userame = username;
        Password = password;
    }
}
