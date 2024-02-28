
namespace Final_Project.Models.Other;

public class Product
{
    static uint id_num = 0;
    uint _id;
    public uint Id
    {
        get => _id;
        set => _id = value;
    }

    string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public uint count { get; set; }
    public uint balance { get; set; }

    public Product(string name, uint count, uint balance)
    {
        Id = id_num++;
        this.count = count;
        this.balance = balance;
    }
}
