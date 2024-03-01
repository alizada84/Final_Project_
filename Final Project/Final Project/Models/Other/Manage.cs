namespace Final_Project.Models.Other;
using Final_Project.Models.Users;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic; // Added using directive for List
using System.Data;

internal class Manage
{
    public static List<Users> GetUsers()
    {
        var list = new List<Users>();
        var connection = new SqlConnection("Server=DESKTOP-RU7Q41N\\SQLEXPRESS;Database=FinalProject;Trusted_Connection=True;");
        var command = connection.CreateCommand();
        command.CommandText = "select * from Users";
        connection.Open();

        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var Id = reader.GetInt32("Id");
                var UserName =  reader.GetString("UserName");
                var UserSurname =  reader.GetString("UserSurame");
                var BirthDate = reader.GetDateTime("BirthDate");
                var Balance = reader.GetFloat("Balance");
                var RoleId = reader.GetInt32("RoleId");
                list.Add(new Users
                {
                    Id = Id,
                    UserName = UserName,
                    UserSurname = UserSurname,
                    BirthDate = BirthDate,
                    UserBalance = Balance,
                    RoleId = RoleId
                });
            }
            
        }

        
        connection.Close();

        return list;
    }
}
