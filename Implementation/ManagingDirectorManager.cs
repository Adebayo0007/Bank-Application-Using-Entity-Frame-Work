using System;
using System.Collections.Generic;
using LegitBankApp.Interfaces;
using LegitBankApp.Model;
using System.IO;
using MySql.Data.MySqlClient;
using System.Linq;

namespace LegitBankApp.Implementations
{
    public class ManagingDirectorManager : IManagingDirector
    {
        // string conn = "Server=localhost;port=3306;Database=bankapp;Uid=root;Pwd=Adebayo58641999";
         private readonly ApplicationContext _context;

        public ManagingDirectorManager()
        {
            _context = new ApplicationContext();
        }
        
        public ManagingDirector CreateManager(ManagingDirector manager)
        {
             _context.managingDirector.Add(manager);
            _context.SaveChanges();
            return manager;
            /*
             try
            {
                
                ManagingDirector manage = new ManagingDirector(firstName, lastName,age,phoneNumber);
                string u = manage.ManagerId;
                
               
               
                using (var connection = new MySqlConnection(conn))
                {
                    string qur = $"insert into Manager (managerId,firstName, lastName , age, phoneNumber) values ('{u}','{manage.FirstName}','{manage.LastName}','{manage.Age}','{manage.PhoneNumber}')";
                    connection.Open();
                    using (var command = new MySqlCommand(qur, connection))
                    {
                        var execute = command.ExecuteNonQuery();
                        if(execute > 0)
                        {
                             System.Console.WriteLine($"\n\t<<<<<Your ID number is: {u}>>>>>");
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

        public ManagingDirector GetManager(string managerId)
        {
             return _context.managingDirector.SingleOrDefault(a => a.ManagerId == managerId);
            /*
           ManagingDirector manager = null;

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = $"select * from Manager where managerId ='{managerId}'  ";
              
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        manager = new ManagingDirector($"{reader["firstName"].ToString()}", $"{reader["lastName"].ToString()}", $"{reader["age"].ToString()}", $"{reader["phoneNumber"].ToString()}");

                    }
                }
            }
            if (manager != null)
            {
                return manager;
            }

            return null;
            */
        }

        public ManagingDirector LoginManager(string managerId)
        {
             return _context.managingDirector.SingleOrDefault(a => a.ManagerId == managerId);
            /*
             ManagingDirector manager = null;
            try
            {
                using (var connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    using (var command = new MySqlCommand($"select * From Manager WHERE managerId = '{managerId}'", connection))
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            manager = new ManagingDirector( reader["firstName"].ToString(), reader["lastName"].ToString(),reader["age"].ToString(), reader["phoneNumber"].ToString());
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            if (manager != null)
            {
                return manager;
            }

            return null;
            */
            
            
        }

        public ManagingDirector UpdateManager(string managerId,ManagingDirector manager)
        {
             var managerInfo =  _context.managingDirector.SingleOrDefault(a => a.ManagerId == managerId);
             managerInfo.FirstName = manager.FirstName ?? managerInfo.FirstName;
             managerInfo.LastName = manager.LastName ?? managerInfo.LastName;
             managerInfo.Age = manager.Age ?? managerInfo.Age;
             managerInfo.PhoneNumber = manager.PhoneNumber ?? managerInfo.PhoneNumber;
            _context.SaveChanges();
            return manager;
            /*
            var manger = GetManager(managerId);
            if(manger != null)
            {
            try
                {
                    using (var connection = new MySqlConnection(conn))
                    {
                        connection.Open();
                        var queryUpdateA = $"update Manager set firstName = '{firstName}', lastName = '{lastName}',phoneNumber = '{phoneNumber}' where managerId = '{managerId}'";
                        using (var command = new MySqlCommand(queryUpdateA, connection))
                        {
                            var execute = command.ExecuteNonQuery();
                            if(execute > 0)
                            {
                                System.Console.WriteLine($"\n\tCongratulation {firstName} {lastName},You have successfully updated your information");

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
    }
}