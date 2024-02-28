
namespace Final_Project.Models.Users;

public class Client : Person
{
    static uint id_num = 0;
    uint _id;
    public uint Id
    {
        get => _id;
        set => _id = value;
    }
    public uint Balance { get; set; }
    public DateTime BirthDate { get; set; }

    public Client(string username, string password, DateTime birthDate, uint balance) : base(username, password)
    {
        Id = id_num++;

        BirthDate = birthDate;
        Balance = balance;
    }
}
