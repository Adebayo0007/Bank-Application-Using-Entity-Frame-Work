using System;
using LegitBankApp.Implementations;
using LegitBankApp.Interfaces;
using LegitBankApp.Model;
using MySql.Data.MySqlClient;

namespace LegitBankApp.Menu
{
    public class AdminMenu
    {
        IAdminManager _iAdminManager              = new AdminManager();
        ITransactionManager _iTransactionManager  = new TransactionManager();
        ICustomerManager _iCustomerManager         = new CustomerManager();
        IManagingDirector _managingDirector        = new ManagingDirectorManager();
        private int _choice;

        //string conn = "Server=localhost;port=3306;Database=bankapp;Uid=root;Pwd=Adebayo58641999";








//ADO.NET

public void ManagerMenu()
{
    System.Console.WriteLine("\n\tEnter 1 to Register\n\tEnter 2 to Login\n\tEnter 3 to get Manager\n\tEnter 4 to see all Admins");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);
    switch(choice)
    {
        case 1:
        CreateManagingDirector();
        break;

         case 2:
        LogInManagingDirector();
        break;

         case 3:
         string security = "ZenithManager0007";
         System.Console.WriteLine("Enter the Company's Security pass");
         string pass = Console.ReadLine();
         if(pass == security)
         {
            System.Console.WriteLine("\n\tEnter Manager's Id");
            string id = Console.ReadLine();
            var manager = new ManagingDirectorManager();
            var check = manager.GetManager(id);
            if(check != null)
            {
                System.Console.WriteLine($"First Name: {check.FirstName}\tLast Name: {check.LastName}\tAge: {check.Age}\t\tNumber: {check.PhoneNumber}\tId: {check.ManagerId}");
            }

         }
         else
         {
            System.Console.WriteLine("Go to the Company for the pass");
         }
        break;

        case 4:
        string security1 = "ZenithManager0007";
         System.Console.WriteLine("Enter the Company's Security pass");
         string pass1 = Console.ReadLine();
         if(pass1 == security1)
         {
            var admin = new AdminManager();
            var adm=admin.GetAllAdmin();
            if(adm != null)
            {
                foreach(var data in adm)
                {
                    System.Console.WriteLine($"StaffId\t\t\tFirstName\tLastName\tAge\tEmail\t\tPassword\tPhoneNumber\t\tAddress\t\tGender");
                    System.Console.WriteLine("_____________________________________________________________________________________________________________________________________________________");
                    System.Console.WriteLine($"\n{data.StaffID}\t{data.FirstName}\t\t{data.LastName}\t\t{data.Age}\t{data.Email}\t{data.Password}\t\t{data.PhoneNumber}\t\t{data.Address}\t{data.Gender}");
                }
            }
          }
         else
         {
            System.Console.WriteLine("Go to the Company for the pass");
         }
        break;
    }

}

public void CreateManagingDirector()
{
    string security = "ZenithManager0007";
                    System.Console.WriteLine("Enter the company's pass");
                    string passs = Console.ReadLine();
                    if(passs == security)
                    {
                                        Console.WriteLine(@"

                    ################################################################################
                    ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                    ####________________________________________________________________________####
                    ####             Welcome to Zenith Bank >>> Admin Registration .            ####
                    ####------------------------------------------------------------------------####
                    ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                    ################################################################################");
                    System.Console.WriteLine("Enter admin first name");
                            string first = Console.ReadLine();
                            System.Console.WriteLine("Enter admin last name");
                            string last = Console.ReadLine();
                            System.Console.WriteLine("Enter admin age");
                            string age = Console.ReadLine();
                            
                            string phone;
                            do
                            {
                            System.Console.WriteLine("Enter admin Phone number");
                            phone = Console.ReadLine();
                            }while(phone.Length != 11);
                            var manager = new ManagingDirector(first,last,age,phone);
                            if(manager != null)
                            {
                            _managingDirector.CreateManager(manager);
                            System.Console.WriteLine("\n\t<<<<<Registration successfully>>>>>");
                            }
                }
                else
                {
                    System.Console.WriteLine("Go back to the bank to ask for the pass");
                }
                

}

public void UpdateManger()
{
     System.Console.WriteLine("Enter admin first name");
                            string first = Console.ReadLine();
                            System.Console.WriteLine("Enter admin last name");
                            string last = Console.ReadLine();
                            string phone;
                            do
                            {
                            System.Console.WriteLine("Enter admin Phone number");
                            phone = Console.ReadLine();
                            }while(phone.Length != 11);
                            System.Console.WriteLine("Enter your Id");
                            string id = Console.ReadLine();
                            System.Console.WriteLine("Enter your age");
                            string age = Console.ReadLine();
                            var manager = new ManagingDirector(first,last,age,phone);
                            if(manager != null)
                            {
                                System.Console.WriteLine("\n\t<<<<< Update Successful >>>>>");
                                  _managingDirector.UpdateManager(id,manager);
                            }
}







public void LogInManagingDirector()
{
    System.Console.WriteLine("Enter your Id");
    string id = Console.ReadLine();
    var manager =_managingDirector.LoginManager(id);
                            if(manager != null)
                            {
                                            System.Console.WriteLine("Login Successfully");
                                            System.Console.WriteLine("\n\tEnter 1 to manage admin\n\tEnter 2 to Update Manager Information");
                                            int i;
                                            int.TryParse(Console.ReadLine(),out i);
                                            
                                            if (i == 1)
                                            {
                                                
                                                                    Console.WriteLine(@"

                                                        ################################################################################
                                                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                                                        ####________________________________________________________________________####
                                                        ####                         Welcome To ZenithBank   !                      ####
                                                        ####------------------------------------------------------------------------####
                                                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                                                        ################################################################################");
                                                    
                                                    System.Console.WriteLine("\n\tEnter 0 to close Application\n\tEnter 1 to Manage Admin");
                                                    int choice;
                                                    int.TryParse(Console.ReadLine(), out choice);
                                                    if(choice == 0)
                                                    {
                                                        System.Console.WriteLine("Closing Application...");
                                                    }
                                                    if(choice == 1)
                                                            {
                                                                System.Console.WriteLine("\n\tEnter 1 to Create Admin\n\tEnter 2 to Delete Admin\n\tEnter 3 to Login Admin\n\tEnter 4 to Get Admin Information using Id\n\tEnter 5 to Update Admin Information with Id");
                                                                int check;
                                                                int.TryParse(Console.ReadLine(), out check);
                                                                switch(check)
                                                                {
                                                                    case 1:
                                                                    CreateAdmin();
                                                                    
                                                                    break;

                                                                    case 2:
                                                                    DeleteAdmin();
                                                                    break;

                                                                    case 3:
                                                                    LogIn();
                                                                    break;

                                                                    case 4:
                                                                    GetAdmin();
                                                                    break;

                                                                    case 5:
                                                                    UpdateAdmin();
                                                                    break;
                                                                }
                                                    }
                                            }

                                            if (i == 2)
                                                {
                                                    UpdateManger();
                                                }

                                        
                                                            
                                        
                                        }
                            else
                            {
                                System.Console.WriteLine("Invalid input");
                            }
                    
}















                public void ManageAdmins()
                {

                    Console.WriteLine(@"

                        ################################################################################
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ####________________________________________________________________________####
                        ####                         Welcome To ZenithBank   !                      ####
                        ####------------------------------------------------------------------------####
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ################################################################################");
                    
                    System.Console.WriteLine("\n\tEnter 0 to close Application\n\tEnter 1 to Manage Admin");
                    int choice;
                    int.TryParse(Console.ReadLine(), out choice);
                    if(choice == 0)
                    {
                        System.Console.WriteLine("Closing Application...");
                    }
                    if(choice == 1)
                    {
                        System.Console.WriteLine("\n\tEnter 1 to Create Admin\n\tEnter 2 to Login Admin\n\tEnter 3 to Get Admin Information using Id\n\tEnter 4 to Update Admin Information with Id");
                        int check;
                        int.TryParse(Console.ReadLine(), out check);
                        switch(check)
                        {
                            case 1:
                            CreateAdmin();
                            
                            break;

                            case 2:
                             LogIn();
                            break;

                            case 3:
                            GetAdmin();
                            break;

                            case 4:
                            UpdateAdmin();
                            break;
                        }
                    }
                    
                }



                 public void ManageCustomer()
                {

                    Console.WriteLine(@"

                        ################################################################################
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ####________________________________________________________________________####
                        ####                         Welcome To ZenithBank   !                      ####
                        ####------------------------------------------------------------------------####
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ################################################################################");
                    
                    System.Console.WriteLine("\n\tEnter 0 to close Application\n\tEnter 1 to Manage Customer");
                    int choice;
                    int.TryParse(Console.ReadLine(), out choice);
                    if(choice == 0)
                    {
                        System.Console.WriteLine("Closing Application...");
                    }
                    if(choice == 1)
                    {
                        System.Console.WriteLine("\n\tEnter 1 to Create Customer\n\tEnter 2 to Delete Customer\n\tEnter 3 to Login Customer\n\tEnter 4 to Get Customer Information using account number\n\tEnter 5 to Update Customer Information with existing account Number\n\tEnter 6 to get all Customer");
                        int check;
                        int.TryParse(Console.ReadLine(), out check);
                        switch(check)
                        {
                            case 1:
                            CreateCustomer();
                            
                            break;

                            case 2:
                            DeleteCustomer();
                            break;

                            case 3:
                             LogInCustomer();
                            break;

                            case 4:
                            GetCustomer();
                            break;

                            case 5:
                            UpdateCustomer();
                            break;

                            case 6:
                            var cus = new CustomerManager();
                             var customer = cus.GetAllCustomer();
                             System.Console.WriteLine($"AccountNumber\tPin\t\tAccountType\t\tAccountBalance\tFirstName\tLastName\tAge\t\tEmail\t\t\tPassword\t\tPhoneNumber\t\tAddress\tGender");
                                        System.Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________________");
                             if(customer != null)
                             {
                                foreach(var data in customer)
                                    {
                                        
                                        System.Console.WriteLine($"\n{data.AccountNumber}\t{data.Pin}\t\t{data.AccountType}\t\t{data.AccountBalance}\t\t{data.FirstName}\t\t{data.LastName}\t\t{data.Age}\t\t{data.Email}\t{data.Password}\t\t{data.PhoneNumber}\t{data.Address}  {data.Gender}");
                                    }

                             }

                            break;
                        }
                    }
                    
                }

                public void CreateCustomer()
                {
                    var customerMenu = new CustomerMenu();
                    customerMenu.RegisterCustomerMenu();
                }

                public void DeleteCustomer()
                {
                    System.Console.WriteLine("Enter your account Number");
                    string acc = Console.ReadLine();
                   _iCustomerManager.DeleteCustomer(acc);
                }

                public void LogInCustomer()
                {
                    var customerMenu = new CustomerMenu();
                    customerMenu.LogCustomerMenu();
                }
                public void GetCustomer()
                {
                    System.Console.WriteLine("Enter your account Number");
                    string acc = Console.ReadLine();
                 var  customer3 = _iCustomerManager.GetCustomer(acc);
                   if(customer3 != null)
                            {
                                System.Console.WriteLine("<<<<Filter Successful>>>>>");
                                System.Console.WriteLine($"\nFirst Name: {customer3.FirstName}\tLast Name: {customer3.LastName}\tAge: {customer3.Age}\tMail: {customer3.Email}\tPassword: {customer3.Password}\n\nPhone number: {customer3.PhoneNumber}\tGender:{customer3.Gender}\tPin: {customer3.Pin}\tAccount Type: {customer3.AccountType}\tAccount Balance: {customer3.AccountBalance}");
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid input");
                            }
                    
                }

                public void UpdateCustomer()
                {
                   
                     Console.WriteLine("\n\tHome && Update && Cutomer");
            Console.Write("\tEnter your First name: ");
            var firstName = Console.ReadLine();
            Console.Write("\tEnter your Last name: ");
            var lastName = Console.ReadLine();
            Console.Write($"\tHello {firstName} {lastName} ! \n\t Enter your age: ");
            var age = Console.ReadLine();
            Console.Write("\tEnter your email address: ");
            var email = Console.ReadLine().Trim().ToUpper();
            Console.Write("\tEnter your Password: ");
            var passWord = Console.ReadLine();
            Console.Write("\tEnter your Phone Number: ");
            var number = Console.ReadLine();
            Console.Write("\tEnter your Address: ");
            var address = Console.ReadLine();
            Console.Write("\tEnter your account number: ");
            var account = Console.ReadLine();
             Console.Write("\tEnter your gender: ");
            var gender = Console.ReadLine();
            var customer = new Customer(" "," "," "," "," "," "," "," "," "," ",0);
            string pin;
            string accType;
             do
            {
            Console.Write("\tEnter four secrete digit Pin: ");
            pin = Console.ReadLine();
            }while(pin.Length != 4 );
            Console.Write("\tEnter your account type\n\tEnter 1 for Student account\n\tEnter 2 for Savings account\n\tEnter 3 for Current account\n\tEnter 4 for Business account\n\tEnter 5 for Joint account: ");
            int ch ;
            int.TryParse(Console.ReadLine(), out ch);
            if(ch ==1)
            {
                accType = "Student account";
                var cus = new Customer(firstName,lastName,age,email,passWord,number,address,gender,pin,accType,0);
                if(cus != null)
                {
                    System.Console.WriteLine($"\n\t<<<<<Congratulation {firstName} {lastName} !>>>>>\n\tUpdate Completed");
                _iCustomerManager.UpdateCustomer(account, cus);
                }
            }

             if(ch ==2)
            {
                accType = "Savings account";
               var cus = new Customer(firstName,lastName,age,email,passWord,number,address,gender,pin,accType,0);
                if(cus != null)
                {
                    System.Console.WriteLine($"\n\t<<<<<Congratulation {firstName} {lastName} !>>>>>\n\tUpdate Completed");
                _iCustomerManager.UpdateCustomer(account, cus);
                }
            }

             if(ch ==3)
            {
                accType = "Current account";
               var cus = new Customer(firstName,lastName,age,email,passWord,number,address,gender,pin,accType,0);
                if(cus != null)
                {
                    System.Console.WriteLine($"\n\t<<<<<Congratulation {firstName} {lastName} !>>>>>\n\tUpdate Completed");
                _iCustomerManager.UpdateCustomer(account, cus);
                }
            }

             if(ch ==4)
            {
                accType = "Business account";
               var cus = new Customer(firstName,lastName,age,email,passWord,number,address,gender,pin,accType,0);
                if(cus != null)
                {
                    System.Console.WriteLine($"\n\t<<<<<Congratulation {firstName} {lastName} !>>>>>\n\tUpdate Completed");
                _iCustomerManager.UpdateCustomer(account, cus);
                }
            }

             if(ch ==5)
            {
                accType = "Joint account";
                var cus = new Customer(firstName,lastName,age,email,passWord,number,address,gender,pin,accType,0);
                if(cus != null)
                {
                    System.Console.WriteLine($"\n\t<<<<<Congratulation {firstName} {lastName} !>>>>>\n\tUpdate Completed");
                _iCustomerManager.UpdateCustomer(account, cus);
                }
            }
            

                }


                public void CreateAdmin()
                {
                    string security = "Zenith0007";
                    System.Console.WriteLine("Enter the company's pass");
                    string passs = Console.ReadLine();
                    if(passs == security)
                    {
                                        Console.WriteLine(@"

                    ################################################################################
                    ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                    ####________________________________________________________________________####
                    ####             Welcome to Zenith Bank >>> Admin Registration .            ####
                    ####------------------------------------------------------------------------####
                    ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                    ################################################################################");
                    System.Console.WriteLine("Enter admin first name");
                            string first = Console.ReadLine();
                            System.Console.WriteLine("Enter admin last name");
                            string last = Console.ReadLine();
                            System.Console.WriteLine("Enter admin age");
                            string age = Console.ReadLine();
                            System.Console.WriteLine("Enter admin mail ");
                            string mail = Console.ReadLine().ToUpper();
                            System.Console.WriteLine("Enter admin password");
                            string pass = Console.ReadLine();
                            string phone;
                            do
                            {
                            System.Console.WriteLine("Enter admin Phone number");
                            phone = Console.ReadLine();
                            }while(phone.Length != 11);
                            System.Console.WriteLine("Enter admin address");
                            string address = Console.ReadLine();
                            System.Console.WriteLine("Enter admin gender");
                            string gender = Console.ReadLine();
                            var admin = new Admin (first,last,age,mail,pass,phone,address,gender);
                            if(admin != null)
                            {
                                _iAdminManager.CreateAdmin(admin);
                                System.Console.WriteLine($"\n\t<<<<<Your ID number is: {admin.StaffID}>>>>>");
                                System.Console.WriteLine($"\n\tCongratulation {admin.FirstName} {admin.LastName},registration completed");
                            }

                }
                else
                {
                    System.Console.WriteLine("Go back to the bank to ask for the pass");
                }
                }


                public  void DeleteAdmin()
                {

                                    Console.WriteLine(@"

                ################################################################################
                ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                ####________________________________________________________________________####
                ####             Welcome to Zenith Bank >>> Delete customer .               ####
                ####------------------------------------------------------------------------####
                ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                ################################################################################");
                            Console.WriteLine("Enter admin Id ");
                            string id = Console.ReadLine().ToUpper();
                            _iAdminManager.DeleteAdmin(id);

                }

                public void LogIn()
                {

                                Console.WriteLine(@"

            ################################################################################
            ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
            ####________________________________________________________________________####
            ####             Welcome to Zenith Bank >>> Login Admin .                   ####
            ####------------------------------------------------------------------------####
            ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
            ################################################################################");
                    System.Console.WriteLine("Enter admin mail ");
                            string mail2 = Console.ReadLine().ToUpper();
                            System.Console.WriteLine("Enter admin password");
                            string pass2 = Console.ReadLine();
                            var admin = _iAdminManager.Login(mail2,pass2);
                            if(admin != null)
                            {
                                System.Console.WriteLine("Login Successfully");
                                System.Console.WriteLine("\n\tEnter 1 to manage admin\n\tEnter 2 to manage Customer");
                                int i;
                                int.TryParse(Console.ReadLine(),out i);
                                
                                if (i == 1)
                                {
                                    
                                    var adminMenu = new AdminMenu();
                                    adminMenu.ManageAdmins();
                                }
                                if (i == 2)
                                {
                                    var adminMenu = new AdminMenu();
                                    adminMenu.ManageCustomer();
                                }

                               
                                                
                               
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid input");
                            }
                    
                }

                public void GetAdmin()
                {

                    Console.WriteLine(@"

                        ################################################################################
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ####________________________________________________________________________####
                        ####Welcome to Zenith Bank >>> Viewing Customer's detail using Admin Portal ####
                        ####------------------------------------------------------------------------####
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ################################################################################");
                    System.Console.WriteLine("Enter staff Id ");
                            string id = Console.ReadLine().ToUpper();
                             var admin3 =_iAdminManager.GetAdmin(id);
                             if(admin3 != null)
                            {
                                System.Console.WriteLine("<<<<Filter Successful>>>>>");
                                System.Console.WriteLine($"\n{admin3.Email}\t{admin3.FirstName}\t{admin3.LastName}\t{admin3.Age}\t{admin3.Password}\t{admin3.PhoneNumber}\t{admin3.Address}\t{admin3.Gender}");
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid input");
                            }

                }

                public void UpdateAdmin()
                {

                            Console.WriteLine(@"

                    ################################################################################
                    ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                    ####________________________________________________________________________####
                    ####Welcome to Zenith Bank >>> Updating Customer's detail using Admin Portal####
                    ####------------------------------------------------------------------------####
                    ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                    ################################################################################");
                            System.Console.WriteLine("Enter admin first name");
                            string first5 = Console.ReadLine();
                            System.Console.WriteLine("Enter admin last name");
                            string last5 = Console.ReadLine();
                            string phone5;
                            do
                            {
                            System.Console.WriteLine("Enter admin Phone number");
                            phone5 = Console.ReadLine();
                            }while(phone5.Length != 11);
                            System.Console.WriteLine("Enter admin age");
                            string age5 = Console.ReadLine();
                            System.Console.WriteLine("Enter admin mail ");
                            string mail5 = Console.ReadLine().ToUpper();
                            System.Console.WriteLine("Enter admin password");
                            string pass5 = Console.ReadLine();
                            System.Console.WriteLine("Enter admin address");
                            string address5 = Console.ReadLine();
                            System.Console.WriteLine("Enter admin Id");
                            string id = Console.ReadLine();
                             System.Console.WriteLine("Enter your gender");
                            string gender = Console.ReadLine();
                            var admin = new Admin(first5,last5,age5,mail5,pass5,phone5,address5,gender);
                            try
                            {
                            if(admin != null)
                            {
                                System.Console.WriteLine("Update Successful");
                             _iAdminManager.UpdateAdmin(id,admin);

                            }

                            }
                            catch(System.Exception ex)
                            {
                                System.Console.WriteLine(ex.Message);
                            }


                }











                




                public void CreateWithdrawalMenu()

                {
                   
                    
                    string pin1;
                    Console.Write("\tEnter your withdrawal amount:");
                    double withdraw;
                     double.TryParse(Console.ReadLine(), out withdraw);
                     
                     string acc;
                     do
                     {
                     System.Console.Write("\tEnter your account number: ");
                     acc = Console.ReadLine();
                     }while(acc.Length != 10);
                     do
                        {
                            Console.Write("\tEnter four secrete digit Pin: ");
                            pin1 = Console.ReadLine();
                        }while(pin1.Length != 4 );
                        var transact = new Transaction(0,0,0,0,0," "," "," "," ");
                   // double y = transact.AccountBalance-=withdraw;
                    //double balance =0;
                     long depo = 0;
                     long airtime = 0;
                     long transfer = 0;
                     string time = DateTime.Now.ToString("dddd,dd MMMM yyyy HH:mm:ss");
                     string refNum = " ";

                     var cus = new CustomerManager();
                     var check = cus.GetCustomer(acc);

                     var tra = new Transaction (check.AccountBalance,withdraw,depo,airtime,transfer,acc,time,refNum,pin1);
                            if(check != null)
                            {
                                if(tra.Pin == check.Pin)
                                { 
                                    double charges;
                                    if(check.AccountType == "Student account")
                                    {
                                        if(check.AccountBalance <= 200000)
                                        {
                                            if(tra.WithdrawalAmount <= check.AccountBalance)
                                            {
                                                if(tra.WithdrawalAmount >= 2000)
                                                                {
                                                                    charges = 0.005*tra.WithdrawalAmount;
                                                                    System.Console.WriteLine($"Your charges is: # {charges}");
                                                                }
                                                                var with = _iTransactionManager.CreateWithdrawal(tra);
                                                                 System.Console.WriteLine($"Transaction successful ! ");
                                                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {check.AccountNumber[0]}{check.AccountNumber[1]}*****{check.AccountNumber[7]}{check.AccountNumber[8]}*\n\tAmt: NGN {with.WithdrawalAmount}\n\tFrom: {check.AccountNumber}\n\tYour balance is: # {with.AccountBalance}\n\tDate: {time}");
                                                                 
                                            }
                                            else
                                            {
                                                System.Console.WriteLine("\n\tLow Balance,try to deposit");
                                            }
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("\n\tTry to Upgrade your account");
                                        }
                                        
                                    }




                                        else
                                        {
                                            if(tra.WithdrawalAmount < check.AccountBalance && check.AccountBalance >= 500)
                                            {
                                               
                                                if(tra.WithdrawalAmount < check.AccountBalance)
                                                {
                                                    if(tra.WithdrawalAmount >= 2000)
                                                                {
                                                                    charges = 0.005*tra.WithdrawalAmount;
                                                                    System.Console.WriteLine($"Your charges is: # {charges}");
                                                                }
                                                                var with = _iTransactionManager.CreateWithdrawal(tra);
                                                                 System.Console.WriteLine($"Transaction successful ! ");
                                                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {check.AccountNumber[0]}{check.AccountNumber[1]}*****{check.AccountNumber[7]}{check.AccountNumber[8]}*\n\tAmt: NGN {with.WithdrawalAmount}\n\tFrom: {check.AccountNumber}\n\tYour balance is: # {with.AccountBalance}\n\tDate: {time}");
                                                                    
                                                }
                                            }
                                             else
                                            {
                                                System.Console.WriteLine("\n\tLow Balance,try to deposit");
                                            }
                                        }
 
                                }
                                else
                                {
                                    System.Console.WriteLine("\n\tWrong Pin");
                                }

                                
                                
                            }
                            else
                            {
                                System.Console.WriteLine("\n\tNot Recognized");
                            }



                }


                public void CreateDepositMenu()

                {
                   
                    
                    string pin1;
                    Console.Write("\tEnter your deposit amount:");
                    double depo;
                     double.TryParse(Console.ReadLine(), out depo);
                    
                     string acc;
                     do
                     {
                     System.Console.WriteLine("\tEnter your account number");
                     acc = Console.ReadLine();
                     }while(acc.Length != 10);
                     do
                        {
                            Console.Write("\tEnter four secrete digit Pin: ");
                            pin1 = Console.ReadLine();
                        }while(pin1.Length != 4 );
                        var transact = new Transaction(0,0,0,0,0," "," "," "," ");
                     double balance =0;
                     long withdraw = 0;
                     long airtime = 0;
                     long transfer=0;
                     string time = DateTime.Now.ToString("dddd,dd MMMM yyyy HH:mm:ss");
                     string refNum = " ";


                     var cus = new CustomerManager();
                     var check = cus.GetCustomer(acc);
                     if(check != null)
                     {
                        if(check.Pin == pin1)
                        {
                            var tra = new Transaction(balance,withdraw,depo,airtime,transfer,acc,time,refNum,pin1);
                       var tra2 = _iTransactionManager.CreateDeposit(tra);
                         System.Console.WriteLine($"Transaction successful ! \nYour RefNum is: # {tra2.RefNum}");
                            System.Console.WriteLine($"\n\tTnx: Credit\n\tAc: {tra2.AccountNumber[0]}{tra2.AccountNumber[1]}*****{tra2.AccountNumber[7]}{tra2.AccountNumber[8]}*\n\tAmt: NGN {tra2.DepositAmount}\n\tInto: {tra2.AccountNumber}\n\tYour balance is: # {tra2.AccountBalance}\n\tDate: {time}");
                        }
                        else
                        {
                            System.Console.WriteLine("\n\tWrong pin");
                        }
                         
                     }
                     else
                     {
                        System.Console.WriteLine("\n\tNot recognize");
                     }

                     

                       


                }


                 public void CreateAirtimeMenu()

                {
                   
                    string pin1;
                    Console.Write("\tEnter your airtime amount:");
                    double airtime;
                     double.TryParse(Console.ReadLine(), out airtime);
                     System.Console.Write("Enter your Network:");
                     string reciever = Console.ReadLine();
                     string acc;
                     do
                     {
                     System.Console.WriteLine("\tEnter your account number");
                     acc = Console.ReadLine();
                     }while(acc.Length != 10);
                     do
                        {
                            Console.Write("\tEnter four secrete digit Pin: ");
                            pin1 = Console.ReadLine();
                        }while(pin1.Length != 4 );
                        var transact = new Transaction(0,0,0,0,0," "," "," "," ");
                    // double i = transact.AccountBalance-=airtime;
                    // double balance = 0;
                     long withdraw = 0;
                     long depo = 0;
                     long transfer = 0;
                     string time = DateTime.Now.ToString("dddd,dd MMMM yyyy HH:mm:ss");
                     string refNum = " ";
                    var cus = new CustomerManager();
                     var check = cus.GetCustomer(acc);

                     var tra = new Transaction (check.AccountBalance,withdraw,depo,airtime,transfer,acc,time,refNum,pin1);
                            if(check != null)
                            {
                                if(tra.Pin == check.Pin)
                                { 
                                    if(check.AccountType == "Student account")
                                    {
                                        if(check.AccountBalance <= 200000)
                                        {
                                            if(tra.AirtimeAmount <= check.AccountBalance)
                                            {
                                                                var air = _iTransactionManager.CreateAirtime(tra);
                                                                 System.Console.WriteLine($"Transaction successful ! ");
                                                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {check.AccountNumber[0]}{check.AccountNumber[1]}*****{check.AccountNumber[7]}{check.AccountNumber[8]}*\n\tAmt: NGN {air.AirtimeAmount}\n\tYour balance is: # {air.AccountBalance}\n\tDate: {time}");
                                                                 
                                            }
                                            else
                                            {
                                                System.Console.WriteLine("\n\tLow Balance,try to deposit");
                                            }
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("\n\tTry to Upgrade your account");
                                        }
                                        
                                    }




                                        else
                                        {
                                            if(tra.AirtimeAmount < check.AccountBalance && check.AccountBalance >= 500)
                                            {
                                               
                                                if(tra.AirtimeAmount < check.AccountBalance)
                                                {
                                                     var air = _iTransactionManager.CreateAirtime(tra);
                                                                 System.Console.WriteLine($"Transaction successful ! ");
                                                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {check.AccountNumber[0]}{check.AccountNumber[1]}*****{check.AccountNumber[7]}{check.AccountNumber[8]}*\n\tAmt: NGN {air.AirtimeAmount}\n\tYour balance is: # {air.AccountBalance}\n\tDate: {time}");
                                                                    
                                                }
                                            }
                                             else
                                            {
                                                System.Console.WriteLine("\n\tLow Balance,try to deposit");
                                            }
                                        }
 
                                }
                                else
                                {
                                    System.Console.WriteLine("\n\tWrong Pin");
                                }

                                
                                
                            }
                            else
                            {
                                System.Console.WriteLine("\n\tNot Recognized");
                            }

                       
                       


                }

                   public void CreateTransferMenu()

                {
                   
                    
                    string pin1;
                    Console.Write("\tEnter amount to transfer amount:");
                    double transfer;
                     double.TryParse(Console.ReadLine(), out transfer);
                    
                     string acc;
                     string acc1;
                     do
                     {
                     System.Console.Write("\tEnter your account number: ");
                     acc = Console.ReadLine();
                     }while(acc.Length != 10);

                     do
                     {
                     System.Console.Write("\tTo: ");
                     acc1 = Console.ReadLine();
                     }while(acc.Length != 10);
                     do
                        {
                            Console.Write("\tEnter four secrete digit Pin: ");
                            pin1 = Console.ReadLine();
                        }while(pin1.Length != 4 );
                        var transact = new Transaction(0,0,0,0,0," "," "," "," ");
                    
                    // double x = transact.AccountBalance-= transfer;
                    // double balance = x;
                     long withdraw = 0;
                     long airtime = 0;
                     long depo=0;
                     string time = DateTime.Now.ToString("dddd,dd MMMM yyyy HH:mm:ss");
                     string refNum = " ";


                                var cus = new CustomerManager();
                     var check = cus.GetCustomer(acc);
                     var check1 = cus.GetCustomer(acc1);

                     var tra = new Transaction (check.AccountBalance,withdraw,depo,airtime,transfer,acc,time,refNum,pin1);
                            if(check != null && check1 != null)
                            {
                                if(tra.Pin == check.Pin)
                                { 
                                    double charges;
                                    if(check.AccountType == "Student account")
                                    {
                                        if(check.AccountBalance <= 200000)
                                        {
                                            if(tra.TransferAmount <= check.AccountBalance)
                                            {
                                                if(tra.TransferAmount >= 2000)
                                                                {
                                                                    charges = 0.005*tra.TransferAmount;
                                                                    System.Console.WriteLine($"Your charges is: # {charges}");
                                                                }
                                                                var with = _iTransactionManager.Transfer(acc1,tra);
                                                                 System.Console.WriteLine($"Transaction successful ! ");
                                                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {check.AccountNumber[0]}{check.AccountNumber[1]}*****{check.AccountNumber[7]}{check.AccountNumber[8]}*\n\tAmt: NGN {with.AirtimeAmount}\n\tFrom: {check.AccountNumber}\n\tYour balance is: # {with.AccountBalance}\n\tDate: {time}");
                                                                 
                                            }
                                            else
                                            {
                                                System.Console.WriteLine("\n\tLow Balance,try to deposit");
                                            }
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("\n\tTry to Upgrade your account");
                                        }
                                        
                                    }




                                        else
                                        {
                                            if(tra.TransferAmount < check.AccountBalance && check.AccountBalance >= 500)
                                            {
                                               
                                                if(tra.TransferAmount < check.AccountBalance)
                                                {
                                                    if(tra.TransferAmount >= 2000)
                                                                {
                                                                    charges = 0.005*tra.TransferAmount;
                                                                    System.Console.WriteLine($"Your charges is: #{charges}");
                                                                }
                                                                var with = _iTransactionManager.Transfer(acc1,tra);
                                                                 System.Console.WriteLine($"Transaction successful ! ");
                                                                    System.Console.WriteLine($"\n\tTnx: Debit\n\tAc: {check.AccountNumber[0]}{check.AccountNumber[1]}*****{check.AccountNumber[7]}{check.AccountNumber[8]}*\n\tAmt: NGN {with.TransferAmount}\n\tFrom: {check.AccountNumber}\n\tYour balance is: # {with.AccountBalance}\n\tDate: {time}");
                                                                    
                                                }
                                            }
                                             else
                                            {
                                                System.Console.WriteLine("\n\tLow Balance,try to deposit");
                                            }
                                        }
 
                                }
                                else
                                {
                                    System.Console.WriteLine("\n\tWrong Pin");
                                }

                                
                                
                            }
                            else
                            {
                                System.Console.WriteLine("\n\tNot Recognized !\nCheck your account number");
                            }

                }


               
                   
                    public void GetTransactionMenu()
                    {
                        System.Console.WriteLine("Enter the ref number to Get transaction");
                        string refNum = Console.ReadLine();
                        System.Console.WriteLine("Enter your account number");
                        string acc = Console.ReadLine();
                        var tra = _iTransactionManager.GetTransaction(refNum);
                        // var cus = new Customer(" "," "," "," "," "," "," "," "," "," ",0);
                        // var transact = new Transaction(0,0,0,0,0," "," "," "," ");
                        if(tra != null)
                        {
                            System.Console.WriteLine($"\nAcc Number= {tra.AccountNumber}\tAcc Balance= {tra.AccountBalance}\tWithdrawal = {tra.WithdrawalAmount}\tDeposit = {tra.DepositAmount}\tAirtime = {tra.AirtimeAmount}\tTransaction date = {tra.DateTime}    Transfer= {tra.TransferAmount}\n");
                        }
                    }

                    public void DeleteTransaction()
                    {
                        System.Console.WriteLine("Enter the ref number to delete transaction");
                        string rep = Console.ReadLine();
                        _iTransactionManager.DeleteTransaction(rep);
                    }

                    public void ManageTransaction()
                    {
                        System.Console.WriteLine("\n\tEnter 1 to Get Transaction\n\tEnter 2 to Delete Transaction\n\tEnter 3 to Get all Transaction");
                        int choice;
                        int.TryParse(Console.ReadLine(),out choice);
                        switch(choice)
                        {
                            case 1:
                            GetTransactionMenu();
                            break;

                            case 2:
                            DeleteTransaction();
                            break;

                             case 3:
                             var transact = new TransactionManager();
                                 transact.GetAllTransaction();
                             System.Console.WriteLine($"AccountBalance\tWithdrawal\tDeposit\t\tAirtime\t\tAccountNumber\t\tRefNum\t\t\ttime\t\t\t\t\tpin\tTransfer");
                             System.Console.WriteLine("_________________________________________________________________________________________________________________________________________________________________________________");
                            break;
                            
                        }
                    }


                   
    }

}