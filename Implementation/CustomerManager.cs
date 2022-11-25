using System;
using System.Collections.Generic;
using LegitBankApp.Interfaces;
using LegitBankApp.Model;
using System.IO;
using MySql.Data.MySqlClient;
using System.Linq;

namespace LegitBankApp.Implementations
{
    public class CustomerManager : ICustomerManager
    {
         //string conn = "Server=localhost;port=3306;Database=bankapp;Uid=root;Pwd=Adebayo58641999";
         private readonly ApplicationContext _context;

        public CustomerManager()
        {
            _context = new ApplicationContext();
        }
        

        public Customer CreateCustomer(Customer customer)
        {
             _context.Customer.Add(customer);
            _context.SaveChanges();
            return customer;
            /*
            try
            {
                
                Customer custom = new Customer(firstName, lastName, age, email, password, phoneNumber, accountNumber, gender,pin,accountType,0);
               
                using (var connection = new MySqlConnection(conn))
                {
                    string qur = $"insert into Customer (firstName, lastName, age, email, password, phoneNumber, accountNumber, gender,pin,accountType,accountBalance) values ('{custom.FirstName}','{custom.LastName}','{custom.Age}','{custom.Email.Trim().ToUpper()}','{custom.Password}','{custom.PhoneNumber}','{custom.AccountNumber}','{custom.Gender}','{custom.Pin}','{custom.AccountType}','{custom.AccountBalance}')";
                    connection.Open();
                    using (var command = new MySqlCommand(qur, connection))
                    {
                        var execute = command.ExecuteNonQuery();
                        if(execute > 0)
                        {
                            System.Console.WriteLine($"<<<<<Your Account Number is : {custom.AccountNumber}>>>>>");
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

        public void DeleteCustomer(string accountNumber)
        {

            var customer = _context.Customer.SingleOrDefault(a => a.AccountNumber == accountNumber);
            _context.Customer.Remove(customer);
            if(customer != null)
            {
            System.Console.WriteLine($"\n\t{customer.FirstName} {customer.LastName} Successfully deleted. ");
            _context.SaveChanges();

            }

            /*
            try
                {
                    using (var connection = new MySqlConnection(conn))
                    {
                        connection.Open();
                        using (var command = new MySqlCommand($"delete From Customer WHERE accountNumber = '{accountNumber}'", connection))
                        {
                            var execute = command.ExecuteNonQuery();
                            if(execute > 0)
                            {
                                Customer custom = new Customer(" ", " ", " ", " ", " ", " ", " ", " "," "," ",0);

                                System.Console.WriteLine($"\n\t{custom.FirstName} {custom.LastName} Successfully deleted. ");
                            }
                           
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                */
            }
           
        public Customer UpdateCustomer(string accountNumber,Customer customer)
        {

            var customerInfo =  _context.Customer.SingleOrDefault(a => a.AccountNumber == accountNumber);
            customerInfo.FirstName = customer.FirstName ?? customerInfo.FirstName;
            customerInfo.LastName = customer.LastName ?? customerInfo.LastName;
            customerInfo.Age = customer.Age ?? customerInfo.Age;
            customerInfo.Email = customer.Email ?? customerInfo.Email;
            customerInfo.Password = customer.Password ?? customerInfo.Password;
            customerInfo.Address = customer.Address ?? customerInfo.Address;
            customerInfo.Gender = customer.Gender ?? customerInfo.Gender;
            customerInfo.AccountType = customer.AccountType ?? customerInfo.AccountType;
            customerInfo.Pin = customer.Pin ?? customerInfo.Pin;
            customerInfo.PhoneNumber = customer.PhoneNumber ?? customerInfo.PhoneNumber;
            _context.SaveChanges();
            return customer;


            /*
           var customer2 = GetCustomer(accountNumber);
            if(customer2 != null)
            {
            try
                {
                    using (var connection = new MySqlConnection(conn))
                    {
                        connection.Open();
                       
                        var queryUpdateA = $"UPDATE Customer SET firstName = '{firstName}',lastName = '{lastName}', age = '{age}',email = '{email}',password = '{password}',phoneNumber = '{phoneNumber}',pin = '{pin}',accountType = '{accountType}' where accountNumber = '{accountNumber}'";
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
                System.Console.WriteLine("Not recognized");
            }
            */


        }

        public Customer GetCustomer(string accountNumber)
        {
              return _context.Customer.SingleOrDefault(a => a.AccountNumber== accountNumber);
            /*
            Customer custom = null;

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = $"select * from Customer where accountNumber ='{accountNumber}'  ";
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        custom = new Customer($"{reader["firstName"].ToString()}", $"{reader["lastName"].ToString()}", $"{reader["age"].ToString()}", $"{reader["email"].ToString()}", $"{reader["password"].ToString()}", $"{reader["phoneNumber"].ToString()}", $"{reader["accountNumber"].ToString()}", $"{reader["gender"].ToString()}", $"{reader["pin"].ToString()}", $"{reader["accountType"].ToString()}",(double)reader["accountBalance"]);

                    }
                }
            }
            if (custom != null)
            {
                return custom;
            }

            return null;
            */

        }

        public Customer Login(string email, string password)
        {
            return _context.Customer.SingleOrDefault(a => a.Email== email && a.Password == password);
            /*
            Customer custom = null;
            try
            {
                using (var connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    using (var command = new MySqlCommand($"select * From Customer WHERE email = '{email}'", connection))
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            custom = new Customer( reader["firstName"].ToString(), reader["lastName"].ToString(),reader["age"].ToString(), reader["email"].ToString(), reader["password"].ToString(), reader["phoneNumber"].ToString(), reader["accountNumber"].ToString(),reader["gender"].ToString(),reader["pin"].ToString(),reader["accountType"].ToString(),(double)reader["accountBalance"]);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return custom is not null && custom.Email.ToUpper() == email.ToUpper() && custom.Password == password ? custom : null;
            */
        }


         public IList<Customer> GetAllCustomer()
        {
             return _context.Customer.ToList();

            /*

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = $"select * from Customer";
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        System.Console.WriteLine($"{reader["firstName"]}\t{reader["lastName"]}\t{reader["age"]}\t{reader["email"]}\t{reader["password"].ToString()}\t{reader["phoneNumber"].ToString()}\t{reader["gender"].ToString()}\t{reader["pin"].ToString()}\t{reader["accountType"].ToString()}");

                    }
                }
            }
            */
            
        }
       
    }
}