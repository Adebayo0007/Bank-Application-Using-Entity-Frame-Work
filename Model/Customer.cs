using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LegitBankApp.Model
{
    public class Customer : User 
    {
       
        [Key]
        public string AccountNumber {get; set;}
        public string Pin           {get; set;}
        public string AccountType   {get; set;}
        public double AccountBalance {get; set;}
        

        public Customer(string firstName,string lastName,string age,string email,string password,string phoneNumber,string address,string gender,string pin,string accountType,double accountBalance) : base (firstName,lastName,age,email,password,phoneNumber,address,gender)
        {
            this.AccountNumber = GenerateCustomerAcountNumber();
            this.Pin = pin;
            this.PhoneNumber = phoneNumber; 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.Address = address;
            this.Gender = gender;
            this.AccountType = accountType;
            this.AccountBalance = accountBalance;
        }

    

        public string GenerateCustomerAcountNumber()
            {
                Random random = new Random();
                Random rand = new Random();
                string customerAccountNumber = $"{random.Next(300,700).ToString()}{random.Next(100, 900).ToString()}{rand.Next(100,400).ToString()}0";
                return customerAccountNumber;

            }

       
    

    }
}