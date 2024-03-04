using Final_Project.Models.Users;
using Final_Project.Models.Other;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Final_Project.Models.Other;
using Final_Project.Models.Users;

public class Manage
{
    private static string connectionString = "Server=DESKTOP-RU7Q41N\\SQLEXPRESS;Database=FinalProject;TrustServerCertificate=True;Trusted_Connection=True;";

    public static List<Users> GetUsers()
    {
        var userList = new List<Users>();

        using (var connection = new SqlConnection(connectionString))
        {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Users";


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userId = reader.GetInt32(reader.GetOrdinal("Id"));
                        var userName = reader.GetString(reader.GetOrdinal("UserName"));
                        var userSurname = reader.GetString(reader.GetOrdinal("UserSurname"));
                        var birthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                        var userBalance = reader.GetFloat(reader.GetOrdinal("UserBalance"));
                        var roleId = reader.GetInt32(reader.GetOrdinal("RoleId"));

                        userList.Add(new Users
                        {
                            Id = userId,
                            UserName = userName,
                            UserSurname = userSurname,
                            BirthDate = birthDate,
                            UserBalance = userBalance,
                            RoleId = roleId
                        });
                    }
                }
                connection.Close();
        }


            return userList;
    }

    public static void AddUser(Users user)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Users (UserName, UserSurname, BirthDate, UserBalance, RoleId) " +
                                  "VALUES (@UserName, @UserSurname, @BirthDate, @UserBalance, @RoleId)";
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@UserSurname", user.UserSurname);
            command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
            command.Parameters.AddWithValue("@UserBalance", user.UserBalance);
            command.Parameters.AddWithValue("@RoleId", user.RoleId);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public static void UpdateUser(Users user)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "UPDATE Users SET UserName = @UserName, UserSurname = @UserSurname, " +
                                  "BirthDate = @BirthDate, UserBalance = @UserBalance, RoleId = @RoleId " +
                                  "WHERE Id = @Id";
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@UserSurname", user.UserSurname);
            command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
            command.Parameters.AddWithValue("@UserBalance", user.UserBalance);
            command.Parameters.AddWithValue("@RoleId", user.RoleId);
            command.Parameters.AddWithValue("@Id", user.Id);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public static void DeleteUser(int userId)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Users WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", userId);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public static List<Product> GetProducts()
    {
        var productList = new List<Product>();

        using (var connection = new SqlConnection(connectionString))
        {
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Products";
            connection.Open();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var productId = reader.GetInt32(reader.GetOrdinal("Id"));
                    var productName = reader.GetString(reader.GetOrdinal("Name"));
                    var productCount = reader.GetInt32(reader.GetOrdinal("ProductCount"));
                    var productPrice = reader.GetFloat(reader.GetOrdinal("ProductPrice"));

                    productList.Add(new Product
                    {
                        Id = productId,
                        Name = productName,
                        ProductCount = productCount,
                        ProductPrice = productPrice
                    });
                }
            }
            connection.Close();
        }

        return productList;
    }

    public static void AddProduct(Product product)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Products (Name, ProductCount, ProductPrice) " +
                                  "VALUES (@Name, @ProductCount, @ProductPrice)";
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@ProductCount", product.ProductCount);
            command.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public static void UpdateProduct(Product product)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "UPDATE Products SET Name = @Name, ProductCount = @ProductCount, " +
                                  "ProductPrice = @ProductPrice WHERE Id = @Id";
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@ProductCount", product.ProductCount);
            command.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
            command.Parameters.AddWithValue("@Id", product.Id);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public static void DeleteProduct(int productId)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Products WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", productId);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
