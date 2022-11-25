using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LegitBankApp.Model;
namespace LegitBankApp
{
    public class Transaction 
    {
        [Key]
         public  string AccountNumber    {get; set;}
        public  double AccountBalance   {set; get;}
        public  double WithdrawalAmount {get; set;}
        public  double DepositAmount    {get; set;}
        public  double AirtimeAmount    {get; set;}
         public double TransferAmount {get; set;}
        public string Pin             {get; set;}
        public  string DateTime         {get; set;}
        public  string RefNum             {get; set;}
       
        
        public Transaction(double accountBalance,double withdrawalAmount,double depositAmount,double airtimeAmount,double transferAmount,string accountNumber,string dateTime,string refNum,string pin) 
         {
           
            
            this.AccountBalance = accountBalance;
            this.WithdrawalAmount = withdrawalAmount;
            this.DepositAmount = depositAmount;
            this.AirtimeAmount = airtimeAmount;
            this.DateTime      = dateTime;
            this.AccountNumber = accountNumber;
            this.TransferAmount = transferAmount;
            this.Pin = pin;
            refNum = this.RefNum;
            string alpha  ="abcdefghijklmnopqrstuvwxyz".ToUpper();
            var i = new Random().Next(25);
             var j = new Random().Next(25);
              var k = new Random().Next(25,99);
            this.RefNum        = $"Ref{k}{i}{j}{alpha[i]}{alpha[j]}" ;
          

            
         }
         
         

    }
}