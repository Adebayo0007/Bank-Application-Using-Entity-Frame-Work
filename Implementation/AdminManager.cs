using System;
using System.Collections.Generic;
using LegitBankApp.Interfaces;
using LegitBankApp.Model;
using System.IO;
using MySql.Data.MySqlClient;
using System.Linq;

namespace LegitBankApp.Implementations
{
    public class AdminManager : IAdminManager
    {

        
        //string conn = "Server=localhost;port=3306;Database=bankapp;Uid=root;Pwd=Adebayo58641999";

         private readonly ApplicationContext _context;

        public AdminManager()
        {
            _context = new ApplicationContext();
        }

       

        public Admin CreateAdmin(Admin admin)
        {
             _context.Admin.Add(admin);
            _context.SaveChanges();
            return admin;

            /*

            try
            {
                
                Admin ad = new Admin(firstName, lastName, age, email, password, phoneNumber, address, gender);

                System.Console.WriteLine($"\n\t<<<<<Your ID number is: {ad.StaffID}>>>>>");
               


                using (var connection = new MySqlConnection(conn))
                {
                    string qur = $"insert into admin (staffId,firstName, lastName, age, email, password, phoneNumber, address, gender) values ('{ad.StaffID}','{ad.FirstName}','{ad.LastName}','{ad.Age}','{ad.Email.Trim().ToUpper()}','{ad.Password}','{ad.PhoneNumber}','{ad.Address}','{ad.Gender}')";
                    connection.Open();
                    using (var command = new MySqlCommand(qur, connection))
                    {
                        var execute = command.ExecuteNonQuery();
                        if(execute > 0)
                        {
                             System.Console.WriteLine($"\n\tCongratulation {firstName} {lastName},registration completed");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            */


        }
        

        public Admin UpdateAdmin(string id,Admin admin)
        {
             var adminInfo =  _context.Admin.SingleOrDefault(a => a.StaffID == id);
             adminInfo.FirstName = admin.FirstName ?? adminInfo.FirstName;
             adminInfo.LastName = admin.LastName ?? adminInfo.LastName;
             adminInfo.Age = admin.Age ?? adminInfo.Age;
             adminInfo.Email = admin.Email ?? adminInfo.Email;
             adminInfo.Password = admin.Password ?? adminInfo.Password;
             adminInfo.PhoneNumber = admin.PhoneNumber ?? adminInfo.PhoneNumber;
             adminInfo.Address = admin.Address ?? adminInfo.Address;
            _context.SaveChanges();
            return admin;
          
            /*
            var admin = GetAdmin(Id);
            if(admin != null)
            {
            try
                {
                    using (var connection = new MySqlConnection(conn))
                    {
                        connection.Open();
                        var queryUpdateA = $"update admin set firstName = '{firstName}', lastName = '{lastname}',phoneNumber = '{phoneNumber}',age = '{age}',email = '{email}',password = '{password}',address = '{address}' where staffId = '{Id}'";
                        using (var command = new MySqlCommand(queryUpdateA, connection))
                        {
                            var execute = command.ExecuteNonQuery();
                            if(execute > 0)
                            {
                                System.Console.WriteLine($"\n\tCongratulation {firstName} {lastname},You have successfully updated your information");

                            }
                            else
                            {
                                System.Console.WriteLine("Invalid input");
                            }
                           
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            else
            {
                System.Console.WriteLine("wrong input");
            }
            */


        }
        


        public void DeleteAdmin(string id)
        {
             var admin = _context.Admin.SingleOrDefault(a => a.StaffID == id);
            _context.Admin.Remove(admin);
            if(admin != null)
            {
            System.Console.WriteLine($"\n\t{admin.FirstName} {admin.LastName} Successfully deleted. ");
            _context.SaveChanges();

            }
            /*
           var admin = GetAdmin(id);
            if (admin != null)
            {
                try
                {
                    using (var connection = new MySqlConnection(conn))
                    {
                        connection.Open();
                        using (var command = new MySqlCommand($"delete From admin WHERE staffId = '{id}'", connection))
                        {
                            var execute = command.ExecuteNonQuery();
                            if(execute > 0)
                            {

                                System.Console.WriteLine($"\n\t{admin.FirstName} {admin.LastName} Successfully deleted. ");
                            }
                           
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("User not found.");
            }
            */

        }

        


        public Admin GetAdmin(string id)
        {
            return _context.Admin.SingleOrDefault(a => a.StaffID== id);
            /*

            Admin admin = null;

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = $"select * from Admin where staffId ='{id}'  ";
              
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        admin = new Admin($"{reader["firstName"].ToString()}", $"{reader["lastName"].ToString()}", $"{reader["age"].ToString()}", $"{reader["email"].ToString()}", $"{reader["password"].ToString()}", $"{reader["phoneNumber"].ToString()}", $"{reader["address"].ToString()}", $"{reader["gender"].ToString()}");

                    }
                }
            }
            if (admin != null)
            {
                return admin;
            }

            return null;
            */

        }


        public Admin Login(string email, string passWord)
        {
            return _context.Admin.SingleOrDefault(a => a.Email== email && a.Password == passWord);
            /*
            
            Admin admin = null;
            try
            {
                using (var connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    using (var command = new MySqlCommand($"select * From admin WHERE email = '{email}'", connection))
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            admin = new Admin( reader["firstName"].ToString(), reader["lastName"].ToString(),reader["age"].ToString(), reader["email"].ToString(), reader["password"].ToString(), reader["phoneNumber"].ToString(), reader["address"].ToString(),reader["staffId"].ToString());
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return admin is not null && admin.Email.ToUpper() == email.ToUpper() && admin.Password == passWord ? admin : null;
            */

            }

            public IList<Admin> GetAllAdmin()
        {
             return _context.Admin.ToList();
            /*

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = $"select * from Admin";
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        System.Console.WriteLine($"{reader["staffId"]}\t{reader["firstName"]}\t{reader["lastName"]}\t{reader["age"]}\t{reader["email"].ToString()}\t{reader["password"].ToString()}\t{reader["phoneNumber"].ToString()}\t{reader["address"].ToString()}\t{reader["gender"].ToString()}");

                    }
                }
            }
            */
            
        }


            
        }
    }
