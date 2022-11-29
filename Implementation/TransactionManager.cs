using System;
using System.Collections.Generic;
using LegitBankApp.Interfaces;
using LegitBankApp.Model;
using System.IO;
using MySql.Data.MySqlClient;
using System.Linq;

namespace LegitBankApp.Implementations
{
    public class TransactionManager : ITransactionManager
    {

       // string conn = "Server=localhost;port=3306;Database=bankapp;Uid=root;Pwd=Adebayo58641999";

        private readonly ApplicationContext _context;

        public TransactionManager()
        {
            _context = new ApplicationContext();
        }




        public Transaction CreateAirtime(Transaction transaction)
        {

             var customer = new CustomerManager();
            var test = customer.GetCustomer(transaction.AccountNumber);
         
                          test.AccountBalance -= transaction.AirtimeAmount;
                          _context.Customer.Update(test);
                                transaction.AccountBalance = test.AccountBalance;
                                 _context.Transaction.Add(transaction);
                                  _context.SaveChanges(); 
                                   return transaction; 
                

 
           
                
           

            /*
            var customer = new CustomerManager();
            var test = customer.GetCustomer(accountnumber2);
            if (test.AccountType == "Student account")
            {
                if (test.AccountBalance <= 200000)
                {

                    if (airtimeAmount <= test.AccountBalance)
                    {

                        try
                        {

                            Transaction transact = new Transaction(accountBalance, withdrawalAmount, depositAmount, airtimeAmount,transferAmount, accountnumber2, dateTime, refNum, pin);
                            string u = $"{transact.RefNum}";
                            System.Console.Write("Your ref number is:");
                            System.Console.WriteLine(u);

                            using (var connection = new MySqlConnection(conn))
                            {

                                test.AccountBalance -= airtimeAmount;
                                transact.AccountBalance = test.AccountBalance;
                                var cus = new Customer(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 0);
                                cus.AccountBalance = test.AccountBalance;
                                string qur = $"insert into Transaction (accountBalance,withdrawalAmount,depositAmount,airtimeAmount,accountNumber,time,refNum,pin) values ('{test.AccountBalance}','{transact.WithdrawalAmount}','{transact.DepositAmount}','{transact.AirtimeAmount}','{accountnumber2}','{transact.DateTime}','{u}','{pin}')";
                                string qur2 = $"update customer set accountBalance = {test.AccountBalance} where accountNumber = {accountnumber2}";


                                connection.Open();
                                using (var command = new MySqlCommand(qur, connection))
                                {
                                    var execute = command.ExecuteNonQuery();
                                    if (execute > 0)
                                    {

                                        System.Console.WriteLine($"Transaction successful ! ");
                                        System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {accountnumber2[0]}{accountnumber2[1]}*****{accountnumber2[7]}{accountnumber2[8]}*\n\tAmt: NGN {airtimeAmount}\n\tYour balance is: {test.AccountBalance}\n\tDate: {dateTime}");

                                    }
                                }

                                using (var command = new MySqlCommand(qur2, connection))
                                {
                                    var execute = command.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.Beep();
                        System.Console.WriteLine("Low Balance");
                    }
                }

                else
                {
                    System.Console.WriteLine("Go to the bank to upgrade your account");
                }
            }





            if (test.AccountType == "Current account" || test.AccountType == "Savings account" || test.AccountType == "Business account" || test.AccountType == "Joint account")
            {

                if (airtimeAmount < test.AccountBalance && test.AccountBalance >= 500)
                {

                    try
                    {

                        Transaction transact = new Transaction(accountBalance, withdrawalAmount, depositAmount, airtimeAmount,transferAmount,accountnumber2, dateTime, refNum, pin);
                        string u = $"{transact.RefNum}";
                        System.Console.Write("Your ref number is:");
                        System.Console.WriteLine(u);

                        using (var connection = new MySqlConnection(conn))
                        {
                            test.AccountBalance -= airtimeAmount;
                            transact.AccountBalance = test.AccountBalance;
                            var cus = new Customer(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 0);
                            cus.AccountBalance = test.AccountBalance;
                            string qur = $"insert into Transaction (accountBalance,withdrawalAmount,depositAmount,airtimeAmount,accountNumber,time,refNum,pin) values ('{test.AccountBalance}','{transact.WithdrawalAmount}','{transact.DepositAmount}','{transact.AirtimeAmount}','{accountnumber2}','{transact.DateTime}','{u}','{pin}')";
                            string qur2 = $"update customer set accountBalance = {test.AccountBalance} where accountNumber = {accountnumber2}";


                            connection.Open();
                            using (var command = new MySqlCommand(qur, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                                if (execute > 0)
                                {

                                    System.Console.WriteLine($"Transaction successful ! ");
                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {accountnumber2[0]}{accountnumber2[1]}*****{accountnumber2[7]}{accountnumber2[8]}*\n\tAmt: NGN {airtimeAmount}\n\tYour balance is: {test.AccountBalance}\n\tDate: {dateTime}");

                                }
                            }

                            using (var command = new MySqlCommand(qur2, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.Beep();
                    System.Console.WriteLine("Low Balance");
                }
            }
            */

        }



        public Transaction CreateDeposit(Transaction transaction)
        {
             var customer = new CustomerManager();
            var test = customer.GetCustomer(transaction.AccountNumber);
                   
                          test.AccountBalance += transaction.DepositAmount;
                           _context.Customer.Update(test);
                                transaction.AccountBalance = test.AccountBalance;
                                test.AccountBalance = transaction.AccountBalance;
                                 _context.Transaction.Add(transaction);
                                  _context.SaveChanges();
                                   return transaction;   
           

            /*
            var customer = new CustomerManager();
            var test = customer.GetCustomer(accountnumber2);


            try
            {

                Transaction transact = new Transaction(accountBalance, withdrawalAmount, depositAmount, airtimeAmount,transferAmount,accountnumber2, dateTime, refNum, pin);
                string u = $"{transact.RefNum}";
                System.Console.Write("Your ref number is:");
                System.Console.WriteLine(u);

                using (var connection = new MySqlConnection(conn))
                {
                    test.AccountBalance += depositAmount;
                    transact.DepositAmount = depositAmount;
                    var cus = new Customer(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 0);
                    cus.AccountBalance = test.AccountBalance;
                    accountBalance = test.AccountBalance;
                    string qur = $"insert into Transaction (accountBalance,withdrawalAmount,depositAmount,airtimeAmount,accountNumber,time,refNum,pin) values ('{test.AccountBalance}','{transact.WithdrawalAmount}','{transact.DepositAmount}','{transact.AirtimeAmount}','{accountnumber2}','{transact.DateTime}','{u}','{pin}')";
                    string qur2 = $"update customer set accountBalance = {test.AccountBalance} where accountNumber = {accountnumber2}";


                    connection.Open();
                    using (var command = new MySqlCommand(qur, connection))
                    {
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {

                            System.Console.WriteLine($"Transaction successful ! ");
                            System.Console.WriteLine($"\n\tTnx: Credit\n\tAc: {accountnumber2[0]}{accountnumber2[1]}*****{accountnumber2[7]}{accountnumber2[8]}*\n\tAmt: NGN {depositAmount}\n\tInto: {accountnumber2}\n\tYour balance is: {test.AccountBalance}\n\tDate: {dateTime}");

                        }
                    }

                    using (var command = new MySqlCommand(qur2, connection))
                    {
                        var execute = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            */




        }



        public Transaction CreateWithdrawal(Transaction transaction)
        {

             var customer = new CustomerManager();
            var test = customer.GetCustomer(transaction.AccountNumber);
            double charges;
        
                          if(transaction.WithdrawalAmount >= 2000)
                                        {
                                            charges = 0.005*transaction.WithdrawalAmount;
                                            test.AccountBalance -= charges;
                                        }
                          test.AccountBalance -= transaction.WithdrawalAmount;
                           _context.Customer.Update(test);
                                transaction.AccountBalance = test.AccountBalance; 
                                 _context.Transaction.Add(transaction);
                                  _context.SaveChanges(); 
                                   return transaction;                  
           

           

            /*
            var customer = new CustomerManager();
            var test = customer.GetCustomer(accountnumber2);
            if (test.AccountType == "Student account")
            {
                if (test.AccountBalance <= 200000)
                {


                    if (withdrawalAmount <= test.AccountBalance)
                    {
                        try
                        {

                            Transaction transact = new Transaction(accountBalance, withdrawalAmount, depositAmount, airtimeAmount,transferAmount,accountnumber2, dateTime, refNum, pin);
                            string u = $"{transact.RefNum}";
                            System.Console.Write("Your ref number is:");
                            System.Console.WriteLine(u);

                            using (var connection = new MySqlConnection(conn))
                            {
                                test.AccountBalance -= withdrawalAmount;
                                transact.WithdrawalAmount = withdrawalAmount;
                                var cus = new Customer(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 0);
                                cus.AccountBalance = test.AccountBalance;
                                accountBalance = test.AccountBalance;
                                string qur = $"insert into Transaction (accountBalance,withdrawalAmount,depositAmount,airtimeAmount,accountNumber,time,refNum,pin) values ('{test.AccountBalance}','{transact.WithdrawalAmount}','{transact.DepositAmount}','{transact.AirtimeAmount}','{accountnumber2}','{transact.DateTime}','{u}','{pin}')";
                                string qur2 = $"update customer set accountBalance = {test.AccountBalance} where accountNumber = {accountnumber2}";


                                connection.Open();
                                using (var command = new MySqlCommand(qur, connection))
                                {
                                    var execute = command.ExecuteNonQuery();
                                    if (execute > 0)
                                    {

                                        System.Console.WriteLine($"Transaction successful ! ");
                                        System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {accountnumber2[0]}{accountnumber2[1]}*****{accountnumber2[7]}{accountnumber2[8]}*\n\tAmt: NGN {withdrawalAmount}\n\tFrom: {accountnumber2}\n\tYour balance is: {test.AccountBalance}\n\tDate: {dateTime}");

                                    }
                                }

                                using (var command = new MySqlCommand(qur2, connection))
                                {
                                    var execute = command.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }



                    else
                    {
                        System.Console.Beep();
                        System.Console.WriteLine("Low Balance");
                    }
                }
                else
                {
                    System.Console.WriteLine("Go to the bank to upgrade your account");
                }

            }






            if (test.AccountType == "Current account" || test.AccountType == "Savings account" || test.AccountType == "Business account" || test.AccountType == "Joint account")
            {
                if (withdrawalAmount < test.AccountBalance && test.AccountBalance >= 500)
                {
                    try
                    {

                        Transaction transact = new Transaction(accountBalance, withdrawalAmount, depositAmount, airtimeAmount,transferAmount,accountnumber2, dateTime, refNum, pin);
                        string u = $"{transact.RefNum}";
                        System.Console.Write("Your ref number is:");
                        System.Console.WriteLine(u);

                        using (var connection = new MySqlConnection(conn))
                        {
                            test.AccountBalance -= withdrawalAmount;
                            transact.WithdrawalAmount = withdrawalAmount;
                            var cus = new Customer(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 0);
                            cus.AccountBalance = test.AccountBalance;
                            accountBalance = test.AccountBalance;
                            string qur = $"insert into Transaction (accountBalance,withdrawalAmount,depositAmount,airtimeAmount,accountNumber,time,refNum,pin) values ('{test.AccountBalance}','{transact.WithdrawalAmount}','{transact.DepositAmount}','{transact.AirtimeAmount}','{accountnumber2}','{transact.DateTime}','{u}','{pin}')";
                            string qur2 = $"update customer set accountBalance = {test.AccountBalance} where accountNumber = {accountnumber2}";


                            connection.Open();
                            using (var command = new MySqlCommand(qur, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                                if (execute > 0)
                                {

                                    System.Console.WriteLine($"Transaction successful ! ");
                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {accountnumber2[0]}{accountnumber2[1]}*****{accountnumber2[7]}{accountnumber2[8]}*\n\tAmt: NGN {withdrawalAmount}\n\tFrom: {accountnumber2}\n\tYour balance is: {test.AccountBalance}\n\tDate: {dateTime}");

                                }
                            }

                            using (var command = new MySqlCommand(qur2, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }



                else
                {
                    System.Console.Beep();
                    System.Console.WriteLine("Low Balance");
                }



            }
            */
        }



        public Transaction Transfer(string recieverAccountNumber,Transaction transaction)
        {
             var customer = new CustomerManager();
            var test = customer.GetCustomer(transaction.AccountNumber);
            var test1 = customer.GetCustomer(recieverAccountNumber);
            double charges;
            if(test != null && test1 != null)
            {
                if(transaction.TransferAmount >= 2000)
                {
                        charges = 0.005*transaction.TransferAmount;
                        test.AccountBalance -= charges;
                }
                test.AccountBalance -= transaction.TransferAmount;
                transaction.AccountBalance = test.AccountBalance;
                test1.AccountBalance += transaction.TransferAmount;
                _context.Customer.Update(test);
                _context.Customer.Update(test1);
                _context.Transaction.Add(transaction);
                _context.SaveChanges();
                                   
            }
            else 
            {
                System.Console.WriteLine("Confirm your Input");
            }
             return transaction;  
               

 
            
             
           

            /*

             var customer = new CustomerManager();
            var test = customer.GetCustomer(senderAccountnumber);
            var test1 = customer.GetCustomer(recieverAccountnumber);
            if (test.AccountType == "Student account")
            {
                if (test.AccountBalance <= 200000)
                {

                    if (airtimeAmount <= test.AccountBalance)
                    {

                        try
                        {

                            Transaction transact = new Transaction(accountBalance, withdrawalAmount, depositAmount, airtimeAmount,transferAmount, senderAccountnumber, dateTime, refNum, pin);
                            string u = $"{transact.RefNum}";
                            System.Console.Write("Your ref number is:");
                            System.Console.WriteLine(u);

                            using (var connection = new MySqlConnection(conn))
                            {
                                test.AccountBalance -= transferAmount;
                                transact.AccountBalance = test.AccountBalance;
                                var cus = new Customer(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 0);
                                cus.AccountBalance = test.AccountBalance;
                                string qur = $"insert into Transaction (accountBalance,withdrawalAmount,depositAmount,airtimeAmount,accountNumber,time,refNum,pin,transferAmount) values ('{test.AccountBalance}','{transact.WithdrawalAmount}','{transact.DepositAmount}','{transact.AirtimeAmount}','{senderAccountnumber}','{transact.DateTime}','{u}','{pin}','{transferAmount}')";
                                string qur2 = $"update customer set accountBalance = {test.AccountBalance} where accountNumber = {senderAccountnumber}";
                                string qur3 = $"update customer set accountBalance = {test1.AccountBalance+=transferAmount} where accountNumber = {recieverAccountnumber}";


                                connection.Open();
                                using (var command = new MySqlCommand(qur, connection))
                                {
                                    var execute = command.ExecuteNonQuery();
                                    if (execute > 0)
                                    {

                                        System.Console.WriteLine($"Transaction successful ! ");
                                        System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {senderAccountnumber[0]}{senderAccountnumber[1]}*****{senderAccountnumber[7]}{senderAccountnumber[8]}*\n\tAmt: NGN {transferAmount}\n\tYour balance is: {test.AccountBalance}\n\tDate: {dateTime}");

                                    }
                                }

                                using (var command = new MySqlCommand(qur2, connection))
                                {
                                    var execute = command.ExecuteNonQuery();
                                }
                                using (var command = new MySqlCommand(qur3, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                            }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.Beep();
                        System.Console.WriteLine("Low Balance");
                    }
                }

                else
                {
                    System.Console.WriteLine("Go to the bank to upgrade your account");
                }
            }





            if (test.AccountType == "Current account" || test.AccountType == "Savings account" || test.AccountType == "Business account" || test.AccountType == "Joint account")
            {

                if (airtimeAmount < test.AccountBalance && test.AccountBalance >= 500)
                {

                    try
                    {

                        Transaction transact = new Transaction(accountBalance, withdrawalAmount, depositAmount, airtimeAmount,transferAmount,senderAccountnumber, dateTime, refNum, pin);
                        string u = $"{transact.RefNum}";
                        System.Console.Write("Your ref number is:");
                        System.Console.WriteLine(u);

                        using (var connection = new MySqlConnection(conn))
                        {
                            test.AccountBalance -= transferAmount;
                            transact.AccountBalance = test.AccountBalance;
                            var cus = new Customer(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 0);
                            cus.AccountBalance = test.AccountBalance;
                            string qur = $"insert into Transaction (accountBalance,withdrawalAmount,depositAmount,airtimeAmount,accountNumber,time,refNum,pin,transferAmount) values ('{test.AccountBalance}','{transact.WithdrawalAmount}','{transact.DepositAmount}','{transact.AirtimeAmount}','{senderAccountnumber}','{transact.DateTime}','{u}','{pin}','{transferAmount}')";
                                string qur2 = $"update customer set accountBalance = {test.AccountBalance} where accountNumber = {senderAccountnumber}";
                                string qur3 = $"update customer set accountBalance = {test1.AccountBalance+=transferAmount} where accountNumber = {recieverAccountnumber}";


                            connection.Open();
                            using (var command = new MySqlCommand(qur, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                                if (execute > 0)
                                {

                                    System.Console.WriteLine($"Transaction successful ! ");
                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {senderAccountnumber[0]}{senderAccountnumber[1]}*****{senderAccountnumber[7]}{senderAccountnumber[8]}*\n\tAmt: NGN {transferAmount}\n\tYour balance is: {test.AccountBalance}\n\tDate: {dateTime}");

                                }
                            }

                            using (var command = new MySqlCommand(qur2, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                            }
                            using (var command = new MySqlCommand(qur3, connection))
                            {
                                var execute = command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.Beep();
                    System.Console.WriteLine("Low Balance");
                }
            }
            */

        }





        public void DeleteTransaction(string refNum)
        {
             var transaction = _context.Transaction.SingleOrDefault(a => a.RefNum == refNum);
                var customer = new CustomerManager();
               var up = customer.GetCustomer(transaction.AccountNumber);
               up.AccountBalance+=transaction.AirtimeAmount;
                up.AccountBalance-=transaction.DepositAmount;
                up.AccountBalance+=transaction.WithdrawalAmount;
                //up.AccountBalance+=transaction.TransferAmount;
                _context.Customer.Update(up);
            _context.Transaction.Remove(transaction);
            if(transaction != null)
            {
            System.Console.WriteLine($"\n\t{transaction.RefNum} Successfully deleted. ");
            _context.SaveChanges();

            }
            else
            {
                System.Console.WriteLine("User not fount");
            }
            /*

            var transaction = GetTransaction(refNum);
            if (transaction != null)
            {
                try
                {
                    using (var connection = new MySqlConnection(conn))
                    {
                        connection.Open();
                        using (var command = new MySqlCommand($"delete From Transaction WHERE refNum = '{refNum}'", connection))
                        {
                            var execute = command.ExecuteNonQuery();
                            if (execute > 0)
                            {

                                System.Console.WriteLine($"\n\t Transaction Successfully deleted. ");
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



        public Transaction GetTransaction(string refNum)
        {
             return _context.Transaction.SingleOrDefault(a => a.RefNum== refNum);

            
            /*
            Transaction transaction = null;

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = $"select * from Transaction where refNum ='{refNum}'  ";
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        transaction = new Transaction((double)reader["accountBalance"], (double)reader["withdrawalAmount"], (double)reader["depositAmount"], (double)reader["airtimeAmount"],(double)reader["transferAmount"], $"{reader["accountNumber"].ToString()}", $"{reader["refNum"].ToString()}", DateTime.Now.ToString("MMM,dd yyyy "), $"{reader["pin"].ToString()}");

                    }
                }
            }
            if (transaction != null)
            {
                return transaction;
            }

            return null;
            */

        }


        public IList<Transaction> GetAllTransaction()
        {
             return _context.Transaction.ToList();

            /*
            
            Transaction transaction = null;

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = $"select * from Transaction  ";
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        System.Console.WriteLine($"{reader["accountBalance"]}\t\t{reader["withdrawalAmount"]}\t\t{reader["depositAmount"]}\t\t{reader["airtimeAmount"]}\t\t{reader["accountNumber"].ToString()}\t\t{reader["refNum"].ToString()}\t\t{reader["time"].ToString()}\t{reader["pin"].ToString()}\t{reader["transferAmount"]}");

                    }
                }
            }
            if (transaction != null)
            {
                return transaction;
            }

            return null;
            */

        }

    }
}