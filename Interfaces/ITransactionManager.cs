using System;
using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface ITransactionManager
    {

        Transaction CreateWithdrawal (Transaction transaction);
        Transaction CreateDeposit (Transaction transaction);
        Transaction CreateAirtime (Transaction transaction);
        void DeleteTransaction (string refNum);
        Transaction Transfer (string recieverAccountNumber,Transaction transaction);
        Transaction GetTransaction (string refNum);
         IList<Transaction> GetAllTransaction();
        
             
    }
}