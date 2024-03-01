namespace Final_Project.Models.Users;

public class Users
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    public DateTime BirthDate { get; set; }
    public float UserBalance { get; set; }
    public int RoleId { get; set; }
}