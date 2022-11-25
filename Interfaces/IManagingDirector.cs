using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface IManagingDirector
    {
        ManagingDirector CreateManager(ManagingDirector manager);
        ManagingDirector UpdateManager (string managerId,ManagingDirector manager);
        ManagingDirector GetManager (string managerId);
        ManagingDirector LoginManager(string managerId);

    }
}