using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface IAdminManager
    {
       Admin CreateAdmin (Admin admin);
       Admin UpdateAdmin (string id,Admin admin);
       void DeleteAdmin (string id);
       Admin Login (string email, string passWord);
       Admin GetAdmin (string id);
        IList<Admin> GetAllAdmin();
       
        
    }
}