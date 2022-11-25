using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface ICustomerManager
    {
        Customer CreateCustomer (Customer customer);
        Customer UpdateCustomer (string accountNumber,Customer customer);
        void DeleteCustomer (string accountNumber);
        Customer GetCustomer (string accountNumber);
        Customer Login(string email, string password);
        IList<Customer> GetAllCustomer();
      
             
    }
}