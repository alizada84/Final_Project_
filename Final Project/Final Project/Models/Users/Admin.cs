
namespace Final_Project.Models.Users;

public class Admin : Person
{
    static uint id_num = 0;
    uint _id;
    public uint Id
    {
        get => _id;
        set => _id = value;
    }

    public Admin(string username, string password) : base(username, password)
    {
        Id = id_num++;
    }
}
